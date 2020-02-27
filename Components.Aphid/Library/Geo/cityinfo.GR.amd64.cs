
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
                                    public const string Country = "GR";
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
                            
                                        var cur = (Math.Abs(39.69153 - lat) + Math.Abs(20.76458 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(35.29502 - lat) + Math.Abs(24.82944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.75439 - lat) + Math.Abs(20.65008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58676 - lat) + Math.Abs(21.8194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93333 - lat) + Math.Abs(22.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.5368 - lat) + Math.Abs(21.41401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65911 - lat) + Math.Abs(22.87499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1303 - lat) + Math.Abs(24.90412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6086 - lat) + Math.Abs(22.12336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30192 - lat) + Math.Abs(24.19189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78022 - lat) + Math.Abs(20.89555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48333 - lat) + Math.Abs(21.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29948 - lat) + Math.Abs(21.93918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45 - lat) + Math.Abs(23.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.755 - lat) + Math.Abs(22.56417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.28961 - lat) + Math.Abs(20.90422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44048 - lat) + Math.Abs(23.884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66717 - lat) + Math.Abs(22.39597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86307 - lat) + Math.Abs(22.9761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.2391 - lat) + Math.Abs(23.63485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.13281 - lat) + Math.Abs(24.94963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51721 - lat) + Math.Abs(23.87818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35368 - lat) + Math.Abs(24.40033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99227 - lat) + Math.Abs(22.70663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33234 - lat) + Math.Abs(21.86263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.02361 - lat) + Math.Abs(27.92326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43879 - lat) + Math.Abs(21.707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.68715 - lat) + Math.Abs(23.03509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.111 - lat) + Math.Abs(26.86682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20622 - lat) + Math.Abs(25.70114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95939 - lat) + Math.Abs(22.45211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31815 - lat) + Math.Abs(21.8602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88227 - lat) + Math.Abs(22.94237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07762 - lat) + Math.Abs(22.63166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40876 - lat) + Math.Abs(26.12948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.37585 - lat) + Math.Abs(24.20109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03999 - lat) + Math.Abs(26.20097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56901 - lat) + Math.Abs(21.63825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12497 - lat) + Math.Abs(23.95198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16253 - lat) + Math.Abs(21.66693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95895 - lat) + Math.Abs(22.80573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31031 - lat) + Math.Abs(20.60897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00058 - lat) + Math.Abs(22.07917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69161 - lat) + Math.Abs(20.78597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81423 - lat) + Math.Abs(23.77892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84221 - lat) + Math.Abs(23.77651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06815 - lat) + Math.Abs(24.81039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91639 - lat) + Math.Abs(20.88639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36103 - lat) + Math.Abs(22.94248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94843 - lat) + Math.Abs(22.79203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74231 - lat) + Math.Abs(22.08844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03186 - lat) + Math.Abs(21.79158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36801 - lat) + Math.Abs(22.37715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86094 - lat) + Math.Abs(22.70831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12275 - lat) + Math.Abs(20.62589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05824 - lat) + Math.Abs(25.40827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67023 - lat) + Math.Abs(22.18347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96105 - lat) + Math.Abs(23.753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16716 - lat) + Math.Abs(23.33659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30444 - lat) + Math.Abs(21.7944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78175 - lat) + Math.Abs(21.97728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19696 - lat) + Math.Abs(25.04042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9761 - lat) + Math.Abs(22.75985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38181 - lat) + Math.Abs(22.74616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31748 - lat) + Math.Abs(23.17752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40983 - lat) + Math.Abs(21.58569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22557 - lat) + Math.Abs(26.05129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.4049 - lat) + Math.Abs(23.60332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7642 - lat) + Math.Abs(23.48011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74692 - lat) + Math.Abs(26.98316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.59236 - lat) + Math.Abs(21.08878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42586 - lat) + Math.Abs(23.67189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63984 - lat) + Math.Abs(21.70448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.27064 - lat) + Math.Abs(25.13783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67106 - lat) + Math.Abs(21.49886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86219 - lat) + Math.Abs(21.20575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.22358 - lat) + Math.Abs(23.92307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07941 - lat) + Math.Abs(26.57777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8332 - lat) + Math.Abs(23.80311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39859 - lat) + Math.Abs(24.94904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03058 - lat) + Math.Abs(21.36506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79446 - lat) + Math.Abs(20.85188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53008 - lat) + Math.Abs(21.99431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33708 - lat) + Math.Abs(22.41983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.407 - lat) + Math.Abs(24.20067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54852 - lat) + Math.Abs(21.66031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.176 - lat) + Math.Abs(20.58392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16554 - lat) + Math.Abs(21.98165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02496 - lat) + Math.Abs(25.77202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19899 - lat) + Math.Abs(25.48862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25894 - lat) + Math.Abs(26.07493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82181 - lat) + Math.Abs(20.65511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.47623 - lat) + Math.Abs(24.06274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.88117 - lat) + Math.Abs(22.22758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38832 - lat) + Math.Abs(23.17369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49727 - lat) + Math.Abs(23.36295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.50889 - lat) + Math.Abs(22.37944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73718 - lat) + Math.Abs(24.42765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.74507 - lat) + Math.Abs(24.43329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10114 - lat) + Math.Abs(23.07669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55493 - lat) + Math.Abs(21.76837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82244 - lat) + Math.Abs(21.07486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6553 - lat) + Math.Abs(21.38315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.41352 - lat) + Math.Abs(28.15516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89789 - lat) + Math.Abs(21.31245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61977 - lat) + Math.Abs(23.12296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81254 - lat) + Math.Abs(20.83241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52021 - lat) + Math.Abs(22.8586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.58417 - lat) + Math.Abs(22.66765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.73778 - lat) + Math.Abs(22.28917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.53753 - lat) + Math.Abs(25.16343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07286 - lat) + Math.Abs(24.76851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.29607 - lat) + Math.Abs(25.01587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.18798 - lat) + Math.Abs(25.28091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08356 - lat) + Math.Abs(22.04891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29528 - lat) + Math.Abs(26.07296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.325 - lat) + Math.Abs(23.31889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85628 - lat) + Math.Abs(20.98161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.42107 - lat) + Math.Abs(25.43087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31439 - lat) + Math.Abs(26.13259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25114 - lat) + Math.Abs(20.78528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.303 - lat) + Math.Abs(23.15016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57358 - lat) + Math.Abs(21.66628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67386 - lat) + Math.Abs(21.68383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43512 - lat) + Math.Abs(21.20989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61898 - lat) + Math.Abs(22.35087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23707 - lat) + Math.Abs(22.12533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97064 - lat) + Math.Abs(23.69043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69119 - lat) + Math.Abs(20.86519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66735 - lat) + Math.Abs(21.31535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45317 - lat) + Math.Abs(21.48972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84371 - lat) + Math.Abs(22.25993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86778 - lat) + Math.Abs(22.73186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40831 - lat) + Math.Abs(22.71162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31121 - lat) + Math.Abs(26.22056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90964 - lat) + Math.Abs(22.70074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91667 - lat) + Math.Abs(22.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51094 - lat) + Math.Abs(24.14616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18072 - lat) + Math.Abs(20.79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46354 - lat) + Math.Abs(22.74198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36213 - lat) + Math.Abs(21.97197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.89641 - lat) + Math.Abs(22.37082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.38317 - lat) + Math.Abs(24.59084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65614 - lat) + Math.Abs(20.81806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80453 - lat) + Math.Abs(21.17461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51419 - lat) + Math.Abs(21.28181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12546 - lat) + Math.Abs(23.88038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.50751 - lat) + Math.Abs(23.94238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.29257 - lat) + Math.Abs(25.43292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69737 - lat) + Math.Abs(21.34682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.21961 - lat) + Math.Abs(24.5341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26191 - lat) + Math.Abs(23.15943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07405 - lat) + Math.Abs(22.06248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90656 - lat) + Math.Abs(22.12792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96163 - lat) + Math.Abs(23.91514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07446 - lat) + Math.Abs(22.43009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10319 - lat) + Math.Abs(22.89789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48717 - lat) + Math.Abs(24.07344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87662 - lat) + Math.Abs(22.88911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79412 - lat) + Math.Abs(23.05204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33333 - lat) + Math.Abs(22.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.21412 - lat) + Math.Abs(23.55145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80117 - lat) + Math.Abs(20.78486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12144 - lat) + Math.Abs(23.72686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02922 - lat) + Math.Abs(26.44836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90417 - lat) + Math.Abs(24.56306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16227 - lat) + Math.Abs(23.49089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25757 - lat) + Math.Abs(25.72796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35 - lat) + Math.Abs(23.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01133 - lat) + Math.Abs(23.60303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31964 - lat) + Math.Abs(23.78763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28262 - lat) + Math.Abs(25.18684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99854 - lat) + Math.Abs(23.38325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32218 - lat) + Math.Abs(26.543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85 - lat) + Math.Abs(22.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40728 - lat) + Math.Abs(20.24842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20783 - lat) + Math.Abs(26.10467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3077 - lat) + Math.Abs(25.52021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85575 - lat) + Math.Abs(21.38789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.61547 - lat) + Math.Abs(27.83619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16139 - lat) + Math.Abs(22.33156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.75947 - lat) + Math.Abs(22.58 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9823 - lat) + Math.Abs(22.72462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.7 - lat) + Math.Abs(25.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46414 - lat) + Math.Abs(26.1239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76398 - lat) + Math.Abs(22.94302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30241 - lat) + Math.Abs(23.73035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50469 - lat) + Math.Abs(21.9075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15397 - lat) + Math.Abs(24.50614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.1087 - lat) + Math.Abs(21.07793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9332 - lat) + Math.Abs(23.53147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.28216 - lat) + Math.Abs(22.02827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62333 - lat) + Math.Abs(20.19433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82158 - lat) + Math.Abs(21.29425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.89003 - lat) + Math.Abs(21.20619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78951 - lat) + Math.Abs(20.84825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75427 - lat) + Math.Abs(26.97699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25081 - lat) + Math.Abs(20.64686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96427 - lat) + Math.Abs(23.49649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11953 - lat) + Math.Abs(22.39734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.18268 - lat) + Math.Abs(21.68414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80971 - lat) + Math.Abs(23.23073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33383 - lat) + Math.Abs(24.49468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31204 - lat) + Math.Abs(21.90374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67144 - lat) + Math.Abs(21.36274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74853 - lat) + Math.Abs(20.81828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16683 - lat) + Math.Abs(20.94356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.70822 - lat) + Math.Abs(20.72656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.26976 - lat) + Math.Abs(22.04875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88829 - lat) + Math.Abs(22.4641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36541 - lat) + Math.Abs(25.02023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43898 - lat) + Math.Abs(21.86684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25936 - lat) + Math.Abs(20.81136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42763 - lat) + Math.Abs(22.74717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66432 - lat) + Math.Abs(21.73541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53912 - lat) + Math.Abs(21.80116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29558 - lat) + Math.Abs(21.78504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36555 - lat) + Math.Abs(24.48232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71957 - lat) + Math.Abs(22.71001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.06316 - lat) + Math.Abs(21.97895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61056 - lat) + Math.Abs(21.74698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14861 - lat) + Math.Abs(21.48028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90222 - lat) + Math.Abs(22.54875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.11406 - lat) + Math.Abs(20.89956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.89055 - lat) + Math.Abs(22.78122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01812 - lat) + Math.Abs(24.00599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90002 - lat) + Math.Abs(22.046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05261 - lat) + Math.Abs(22.95271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01324 - lat) + Math.Abs(23.77223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32806 - lat) + Math.Abs(21.87367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57852 - lat) + Math.Abs(23.64326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71279 - lat) + Math.Abs(22.84049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73402 - lat) + Math.Abs(23.4906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20555 - lat) + Math.Abs(25.09985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56483 - lat) + Math.Abs(21.58944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.37571 - lat) + Math.Abs(21.97493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56956 - lat) + Math.Abs(21.61176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.34566 - lat) + Math.Abs(24.4251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95617 - lat) + Math.Abs(20.7505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.52306 - lat) + Math.Abs(21.10139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77564 - lat) + Math.Abs(22.57578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95899 - lat) + Math.Abs(22.77131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.64883 - lat) + Math.Abs(22.81397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10942 - lat) + Math.Abs(22.88595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32786 - lat) + Math.Abs(23.14384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3895 - lat) + Math.Abs(22.99948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15369 - lat) + Math.Abs(20.7712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49944 - lat) + Math.Abs(23.45361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00938 - lat) + Math.Abs(24.86718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.59673 - lat) + Math.Abs(23.54457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07911 - lat) + Math.Abs(26.18215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.216 - lat) + Math.Abs(23.86806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.97527 - lat) + Math.Abs(26.37137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98243 - lat) + Math.Abs(26.39676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79906 - lat) + Math.Abs(20.74056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61667 - lat) + Math.Abs(22.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45044 - lat) + Math.Abs(20.27781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66061 - lat) + Math.Abs(21.76906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66731 - lat) + Math.Abs(21.61108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.4731 - lat) + Math.Abs(23.60219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.21357 - lat) + Math.Abs(23.2675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81635 - lat) + Math.Abs(20.86437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76329 - lat) + Math.Abs(24.02371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51061 - lat) + Math.Abs(21.70103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01555 - lat) + Math.Abs(24.78129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51672 - lat) + Math.Abs(24.08653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69102 - lat) + Math.Abs(26.94341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.22628 - lat) + Math.Abs(25.99991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91869 - lat) + Math.Abs(22.59339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55276 - lat) + Math.Abs(21.74846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67513 - lat) + Math.Abs(21.44102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00611 - lat) + Math.Abs(25.15191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94203 - lat) + Math.Abs(23.64619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91298 - lat) + Math.Abs(21.6965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84472 - lat) + Math.Abs(27.15932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45806 - lat) + Math.Abs(21.61889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00161 - lat) + Math.Abs(23.94075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50552 - lat) + Math.Abs(21.59523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04187 - lat) + Math.Abs(23.68494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58627 - lat) + Math.Abs(21.96355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.5615 - lat) + Math.Abs(21.92812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.32682 - lat) + Math.Abs(26.17648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16612 - lat) + Math.Abs(21.11303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15708 - lat) + Math.Abs(20.81875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16667 - lat) + Math.Abs(21.03472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94041 - lat) + Math.Abs(22.83946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41936 - lat) + Math.Abs(20.01469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48491 - lat) + Math.Abs(23.99421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01539 - lat) + Math.Abs(23.69187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04931 - lat) + Math.Abs(21.36308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36967 - lat) + Math.Abs(20.30419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69226 - lat) + Math.Abs(23.45306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.74086 - lat) + Math.Abs(24.43623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69331 - lat) + Math.Abs(20.84656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04319 - lat) + Math.Abs(26.50452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96775 - lat) + Math.Abs(23.5721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3703 - lat) + Math.Abs(24.70345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03021 - lat) + Math.Abs(22.94902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05 - lat) + Math.Abs(23.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.48487 - lat) + Math.Abs(21.24683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67444 - lat) + Math.Abs(21.59344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94813 - lat) + Math.Abs(22.8398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51823 - lat) + Math.Abs(21.95248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59994 - lat) + Math.Abs(20.84261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.19722 - lat) + Math.Abs(20.18556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.24444 - lat) + Math.Abs(21.73444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53495 - lat) + Math.Abs(21.86465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30895 - lat) + Math.Abs(26.54723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14657 - lat) + Math.Abs(23.86494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01294 - lat) + Math.Abs(22.72814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66419 - lat) + Math.Abs(22.74985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08333 - lat) + Math.Abs(25.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.28572 - lat) + Math.Abs(20.40044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61472 - lat) + Math.Abs(21.52046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48682 - lat) + Math.Abs(21.90288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54858 - lat) + Math.Abs(20.32436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47111 - lat) + Math.Abs(20.51111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41658 - lat) + Math.Abs(22.7661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38002 - lat) + Math.Abs(23.62842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88195 - lat) + Math.Abs(22.77723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.19833 - lat) + Math.Abs(21.70263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.2482 - lat) + Math.Abs(22.85796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16945 - lat) + Math.Abs(26.14058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86336 - lat) + Math.Abs(20.56469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03905 - lat) + Math.Abs(26.45598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31444 - lat) + Math.Abs(20.79314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52816 - lat) + Math.Abs(21.45016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41815 - lat) + Math.Abs(24.69091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73241 - lat) + Math.Abs(20.82795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60151 - lat) + Math.Abs(21.55586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14666 - lat) + Math.Abs(26.5292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79616 - lat) + Math.Abs(21.32971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63102 - lat) + Math.Abs(22.8235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.58316 - lat) + Math.Abs(21.44729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15697 - lat) + Math.Abs(26.5217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00514 - lat) + Math.Abs(23.88302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94184 - lat) + Math.Abs(23.66309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22008 - lat) + Math.Abs(21.98158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91075 - lat) + Math.Abs(20.95178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46667 - lat) + Math.Abs(22.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.783 - lat) + Math.Abs(20.88183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60845 - lat) + Math.Abs(21.8172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92812 - lat) + Math.Abs(23.70105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46269 - lat) + Math.Abs(21.65793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.55232 - lat) + Math.Abs(21.24062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.37662 - lat) + Math.Abs(21.86407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05563 - lat) + Math.Abs(26.45053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46982 - lat) + Math.Abs(21.82482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23128 - lat) + Math.Abs(23.68185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45238 - lat) + Math.Abs(21.23246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73795 - lat) + Math.Abs(27.00001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19793 - lat) + Math.Abs(26.25429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.54097 - lat) + Math.Abs(25.56287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71998 - lat) + Math.Abs(23.94792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63847 - lat) + Math.Abs(23.15609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08344 - lat) + Math.Abs(21.01375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10896 - lat) + Math.Abs(25.80903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97536 - lat) + Math.Abs(23.36243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95527 - lat) + Math.Abs(23.85443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67175 - lat) + Math.Abs(26.83113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8264 - lat) + Math.Abs(21.48997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57988 - lat) + Math.Abs(24.11184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.18866 - lat) + Math.Abs(21.72903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74628 - lat) + Math.Abs(22.57844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16383 - lat) + Math.Abs(20.71842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30326 - lat) + Math.Abs(23.75549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77366 - lat) + Math.Abs(24.9504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.4929 - lat) + Math.Abs(22.97962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95034 - lat) + Math.Abs(23.09191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10118 - lat) + Math.Abs(22.27106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89553 - lat) + Math.Abs(22.64197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65795 - lat) + Math.Abs(21.28532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51458 - lat) + Math.Abs(26.22241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31163 - lat) + Math.Abs(23.64 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98642 - lat) + Math.Abs(23.79347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.4626 - lat) + Math.Abs(25.37637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76017 - lat) + Math.Abs(20.71876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56667 - lat) + Math.Abs(22.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96667 - lat) + Math.Abs(23.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71013 - lat) + Math.Abs(20.71386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.47587 - lat) + Math.Abs(24.03995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98402 - lat) + Math.Abs(22.78178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16261 - lat) + Math.Abs(22.79406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93575 - lat) + Math.Abs(23.07243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23988 - lat) + Math.Abs(22.27465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.42207 - lat) + Math.Abs(24.14151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79209 - lat) + Math.Abs(26.7049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62553 - lat) + Math.Abs(20.83558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60827 - lat) + Math.Abs(21.97996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27408 - lat) + Math.Abs(21.73211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07025 - lat) + Math.Abs(21.01892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40847 - lat) + Math.Abs(21.27511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30754 - lat) + Math.Abs(26.11332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90794 - lat) + Math.Abs(21.20392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58722 - lat) + Math.Abs(20.87567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23902 - lat) + Math.Abs(26.09341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82068 - lat) + Math.Abs(22.66102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.60793 - lat) + Math.Abs(22.81996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17935 - lat) + Math.Abs(24.20842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94504 - lat) + Math.Abs(23.71416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94661 - lat) + Math.Abs(23.53156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08278 - lat) + Math.Abs(20.72433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.52461 - lat) + Math.Abs(20.25519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08889 - lat) + Math.Abs(20.74333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25627 - lat) + Math.Abs(25.60415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00647 - lat) + Math.Abs(23.42348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31942 - lat) + Math.Abs(23.79649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05378 - lat) + Math.Abs(21.38189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08733 - lat) + Math.Abs(23.97642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03333 - lat) + Math.Abs(23.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43729 - lat) + Math.Abs(23.62824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59023 - lat) + Math.Abs(22.74342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15722 - lat) + Math.Abs(20.85719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0357 - lat) + Math.Abs(23.75733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03491 - lat) + Math.Abs(23.73811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0927 - lat) + Math.Abs(23.82223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67653 - lat) + Math.Abs(23.12689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60834 - lat) + Math.Abs(21.44767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52027 - lat) + Math.Abs(23.63296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.28015 - lat) + Math.Abs(22.81819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10556 - lat) + Math.Abs(25.37639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56863 - lat) + Math.Abs(22.80691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39167 - lat) + Math.Abs(21.8275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12181 - lat) + Math.Abs(25.24014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53885 - lat) + Math.Abs(24.15554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42972 - lat) + Math.Abs(21.66361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73565 - lat) + Math.Abs(20.82291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31122 - lat) + Math.Abs(23.43916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48228 - lat) + Math.Abs(24.01253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48893 - lat) + Math.Abs(21.71751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99319 - lat) + Math.Abs(22.72531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82814 - lat) + Math.Abs(22.44807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94789 - lat) + Math.Abs(23.6788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13248 - lat) + Math.Abs(26.51698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3525 - lat) + Math.Abs(21.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17229 - lat) + Math.Abs(21.67974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85053 - lat) + Math.Abs(20.94458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80998 - lat) + Math.Abs(22.64544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.80757 - lat) + Math.Abs(22.85132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.26342 - lat) + Math.Abs(25.42305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.05143 - lat) + Math.Abs(24.8733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33933 - lat) + Math.Abs(21.83751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72716 - lat) + Math.Abs(26.90747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10772 - lat) + Math.Abs(26.55529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.99744 - lat) + Math.Abs(20.70639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66883 - lat) + Math.Abs(20.94535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44373 - lat) + Math.Abs(23.65365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36781 - lat) + Math.Abs(26.17639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71397 - lat) + Math.Abs(21.34919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92117 - lat) + Math.Abs(21.237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40769 - lat) + Math.Abs(21.96301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87483 - lat) + Math.Abs(25.06359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.18387 - lat) + Math.Abs(21.70133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.74536 - lat) + Math.Abs(24.4265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.55276 - lat) + Math.Abs(22.71658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.32713 - lat) + Math.Abs(23.15171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44046 - lat) + Math.Abs(23.59282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07707 - lat) + Math.Abs(22.03235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23366 - lat) + Math.Abs(23.89333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9861 - lat) + Math.Abs(22.15337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44529 - lat) + Math.Abs(25.32872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.14889 - lat) + Math.Abs(29.59361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88298 - lat) + Math.Abs(22.31355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76944 - lat) + Math.Abs(21.18222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12546 - lat) + Math.Abs(21.39966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.60787 - lat) + Math.Abs(22.94593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81973 - lat) + Math.Abs(21.70486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58131 - lat) + Math.Abs(23.39016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52641 - lat) + Math.Abs(21.55415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05111 - lat) + Math.Abs(22.00778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13086 - lat) + Math.Abs(26.00361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23758 - lat) + Math.Abs(20.52958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.37138 - lat) + Math.Abs(21.43151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.39893 - lat) + Math.Abs(25.44807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03634 - lat) + Math.Abs(26.44531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75658 - lat) + Math.Abs(23.51688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46361 - lat) + Math.Abs(21.89848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04213 - lat) + Math.Abs(21.11875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.75014 - lat) + Math.Abs(22.79532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50881 - lat) + Math.Abs(21.14614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04775 - lat) + Math.Abs(22.68479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05 - lat) + Math.Abs(23.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21667 - lat) + Math.Abs(21.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61065 - lat) + Math.Abs(21.64324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13729 - lat) + Math.Abs(21.06968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99471 - lat) + Math.Abs(23.34324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40111 - lat) + Math.Abs(22.14222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.45505 - lat) + Math.Abs(27.34563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55982 - lat) + Math.Abs(21.84195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58917 - lat) + Math.Abs(21.7284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.89407 - lat) + Math.Abs(22.47511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64629 - lat) + Math.Abs(21.37309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49693 - lat) + Math.Abs(21.78802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41803 - lat) + Math.Abs(20.37483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42386 - lat) + Math.Abs(21.69379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52359 - lat) + Math.Abs(21.47325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56817 - lat) + Math.Abs(23.21458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.54323 - lat) + Math.Abs(26.10862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04839 - lat) + Math.Abs(24.32039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65514 - lat) + Math.Abs(20.79608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.2898 - lat) + Math.Abs(23.82475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88333 - lat) + Math.Abs(23.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.35825 - lat) + Math.Abs(20.43886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05799 - lat) + Math.Abs(21.57887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15317 - lat) + Math.Abs(23.96278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72674 - lat) + Math.Abs(26.68964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04708 - lat) + Math.Abs(21.34814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66065 - lat) + Math.Abs(22.82564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.61139 - lat) + Math.Abs(27.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61542 - lat) + Math.Abs(22.26028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06667 - lat) + Math.Abs(23.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79808 - lat) + Math.Abs(23.47967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31003 - lat) + Math.Abs(26.33629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28367 - lat) + Math.Abs(25.46262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62225 - lat) + Math.Abs(23.2337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.4 - lat) + Math.Abs(23.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78168 - lat) + Math.Abs(21.28399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23789 - lat) + Math.Abs(23.801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.60957 - lat) + Math.Abs(21.60509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40131 - lat) + Math.Abs(22.98727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8 - lat) + Math.Abs(22.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43978 - lat) + Math.Abs(21.96582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61667 - lat) + Math.Abs(23.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.9415 - lat) + Math.Abs(22.11535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75806 - lat) + Math.Abs(20.81017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43911 - lat) + Math.Abs(21.75977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41178 - lat) + Math.Abs(23.82128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07989 - lat) + Math.Abs(23.52108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08007 - lat) + Math.Abs(22.40469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96727 - lat) + Math.Abs(23.99684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.967 - lat) + Math.Abs(21.93369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9783 - lat) + Math.Abs(22.97781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85695 - lat) + Math.Abs(23.04739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05695 - lat) + Math.Abs(26.54476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.166 - lat) + Math.Abs(20.75608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47946 - lat) + Math.Abs(23.44796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29472 - lat) + Math.Abs(22.02145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65936 - lat) + Math.Abs(20.93908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86881 - lat) + Math.Abs(21.90667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20133 - lat) + Math.Abs(20.43706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.711 - lat) + Math.Abs(23.0503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.14602 - lat) + Math.Abs(24.51475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71935 - lat) + Math.Abs(20.83013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.28333 - lat) + Math.Abs(26.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.14115 - lat) + Math.Abs(21.48047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76667 - lat) + Math.Abs(23.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71408 - lat) + Math.Abs(22.88023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89108 - lat) + Math.Abs(24.00307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32297 - lat) + Math.Abs(25.39275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06933 - lat) + Math.Abs(23.78223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12747 - lat) + Math.Abs(22.50704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61233 - lat) + Math.Abs(23.03773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49454 - lat) + Math.Abs(21.68392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52389 - lat) + Math.Abs(22.19972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91655 - lat) + Math.Abs(22.30336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42336 - lat) + Math.Abs(20.07094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.83036 - lat) + Math.Abs(20.70442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.55988 - lat) + Math.Abs(22.86072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.68269 - lat) + Math.Abs(22.29586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43616 - lat) + Math.Abs(22.87665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70839 - lat) + Math.Abs(21.2897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16679 - lat) + Math.Abs(22.85773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.987 - lat) + Math.Abs(23.85518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93279 - lat) + Math.Abs(22.85002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93333 - lat) + Math.Abs(21.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46237 - lat) + Math.Abs(21.73789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77771 - lat) + Math.Abs(20.6676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71445 - lat) + Math.Abs(24.05647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63689 - lat) + Math.Abs(22.41761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56555 - lat) + Math.Abs(23.28484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.09755 - lat) + Math.Abs(21.41861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.68186 - lat) + Math.Abs(22.03002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47825 - lat) + Math.Abs(26.12427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.9 - lat) + Math.Abs(22.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.62786 - lat) + Math.Abs(22.78449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70936 - lat) + Math.Abs(21.72117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17182 - lat) + Math.Abs(21.45607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13344 - lat) + Math.Abs(26.85237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06174 - lat) + Math.Abs(22.09602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23062 - lat) + Math.Abs(24.98291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.88297 - lat) + Math.Abs(22.54683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.57565 - lat) + Math.Abs(21.89245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.15821 - lat) + Math.Abs(25.64459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.13712 - lat) + Math.Abs(23.83055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96308 - lat) + Math.Abs(22.63638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61501 - lat) + Math.Abs(22.01188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96592 - lat) + Math.Abs(22.76093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94532 - lat) + Math.Abs(21.1791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.32352 - lat) + Math.Abs(21.87367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59193 - lat) + Math.Abs(21.62034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.37974 - lat) + Math.Abs(23.15969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95094 - lat) + Math.Abs(21.97078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89712 - lat) + Math.Abs(21.2811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44594 - lat) + Math.Abs(21.83454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24672 - lat) + Math.Abs(20.74711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82711 - lat) + Math.Abs(23.96715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03344 - lat) + Math.Abs(25.94731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01487 - lat) + Math.Abs(25.82939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.68426 - lat) + Math.Abs(22.71355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58808 - lat) + Math.Abs(20.91197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29243 - lat) + Math.Abs(26.13399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06576 - lat) + Math.Abs(23.76356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13672 - lat) + Math.Abs(20.95761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59157 - lat) + Math.Abs(20.8051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.89295 - lat) + Math.Abs(27.28768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89886 - lat) + Math.Abs(23.87181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11833 - lat) + Math.Abs(25.53578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.79526 - lat) + Math.Abs(21.95794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94007 - lat) + Math.Abs(22.9513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.253 - lat) + Math.Abs(22.98211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.34952 - lat) + Math.Abs(22.74714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82259 - lat) + Math.Abs(22.75069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04708 - lat) + Math.Abs(21.032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10255 - lat) + Math.Abs(21.08389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86756 - lat) + Math.Abs(22.34795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54115 - lat) + Math.Abs(23.77995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97061 - lat) + Math.Abs(22.78018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47503 - lat) + Math.Abs(23.23883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32827 - lat) + Math.Abs(25.2581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77908 - lat) + Math.Abs(26.89179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.57356 - lat) + Math.Abs(22.30361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4123 - lat) + Math.Abs(23.12553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78772 - lat) + Math.Abs(22.86158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52372 - lat) + Math.Abs(22.72981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41237 - lat) + Math.Abs(24.43068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.14955 - lat) + Math.Abs(22.98979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.49459 - lat) + Math.Abs(23.65375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42944 - lat) + Math.Abs(22.44443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35365 - lat) + Math.Abs(22.78841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91295 - lat) + Math.Abs(22.98651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00288 - lat) + Math.Abs(23.73755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81886 - lat) + Math.Abs(20.82259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76021 - lat) + Math.Abs(23.45448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.25111 - lat) + Math.Abs(21.67361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96843 - lat) + Math.Abs(23.21351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.79368 - lat) + Math.Abs(24.57577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.63477 - lat) + Math.Abs(24.10287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93542 - lat) + Math.Abs(21.14503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07438 - lat) + Math.Abs(23.81106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01321 - lat) + Math.Abs(22.74839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60749 - lat) + Math.Abs(21.50133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20176 - lat) + Math.Abs(24.13711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70374 - lat) + Math.Abs(26.90454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05106 - lat) + Math.Abs(21.7169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38 - lat) + Math.Abs(23.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.36875 - lat) + Math.Abs(26.13718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81016 - lat) + Math.Abs(22.86972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.30777 - lat) + Math.Abs(25.37159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84842 - lat) + Math.Abs(21.38403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99908 - lat) + Math.Abs(23.58001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51124 - lat) + Math.Abs(24.02921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33263 - lat) + Math.Abs(23.73188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46354 - lat) + Math.Abs(23.60284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33335 - lat) + Math.Abs(26.09845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15981 - lat) + Math.Abs(20.93292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56853 - lat) + Math.Abs(22.54017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.22243 - lat) + Math.Abs(27.61191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10843 - lat) + Math.Abs(21.78349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02369 - lat) + Math.Abs(23.80068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49551 - lat) + Math.Abs(22.84424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01135 - lat) + Math.Abs(23.66597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9625 - lat) + Math.Abs(23.61972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80585 - lat) + Math.Abs(23.9774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.00556 - lat) + Math.Abs(21.63778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.21633 - lat) + Math.Abs(26.20724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03258 - lat) + Math.Abs(25.7528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58096 - lat) + Math.Abs(21.69298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.74507 - lat) + Math.Abs(26.95961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59852 - lat) + Math.Abs(22.69114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63333 - lat) + Math.Abs(24.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.30812 - lat) + Math.Abs(25.04651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.12271 - lat) + Math.Abs(25.85804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39025 - lat) + Math.Abs(20.10781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87581 - lat) + Math.Abs(21.26422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62281 - lat) + Math.Abs(20.88758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78547 - lat) + Math.Abs(21.11417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08615 - lat) + Math.Abs(26.43288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60751 - lat) + Math.Abs(22.71348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16803 - lat) + Math.Abs(24.01628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10897 - lat) + Math.Abs(22.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92995 - lat) + Math.Abs(21.14714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07035 - lat) + Math.Abs(21.65097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.48672 - lat) + Math.Abs(21.62551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33091 - lat) + Math.Abs(23.03957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04862 - lat) + Math.Abs(25.79081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41237 - lat) + Math.Abs(21.25258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28634 - lat) + Math.Abs(25.05612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.82791 - lat) + Math.Abs(22.77732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0249 - lat) + Math.Abs(22.73294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94749 - lat) + Math.Abs(22.8303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20271 - lat) + Math.Abs(24.99827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32903 - lat) + Math.Abs(21.84254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8487 - lat) + Math.Abs(23.0032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15 - lat) + Math.Abs(21.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83012 - lat) + Math.Abs(20.75755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65597 - lat) + Math.Abs(21.31742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49374 - lat) + Math.Abs(23.16008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63067 - lat) + Math.Abs(20.92183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55239 - lat) + Math.Abs(20.27403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8346 - lat) + Math.Abs(24.08572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71692 - lat) + Math.Abs(21.61865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41672 - lat) + Math.Abs(21.89646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20902 - lat) + Math.Abs(25.33773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57048 - lat) + Math.Abs(23.63131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33575 - lat) + Math.Abs(22.01129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94715 - lat) + Math.Abs(21.61865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91218 - lat) + Math.Abs(21.79836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.50701 - lat) + Math.Abs(27.21322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01333 - lat) + Math.Abs(24.41611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06402 - lat) + Math.Abs(22.64739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79845 - lat) + Math.Abs(20.71498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39121 - lat) + Math.Abs(26.09643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29119 - lat) + Math.Abs(22.50066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7588 - lat) + Math.Abs(20.64915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39061 - lat) + Math.Abs(21.9233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36485 - lat) + Math.Abs(21.92191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.88778 - lat) + Math.Abs(22.23317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.5285 - lat) + Math.Abs(26.09242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76729 - lat) + Math.Abs(21.33946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78305 - lat) + Math.Abs(27.14289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88893 - lat) + Math.Abs(22.70784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73564 - lat) + Math.Abs(21.53578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.58145 - lat) + Math.Abs(21.09169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.98784 - lat) + Math.Abs(23.61219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33386 - lat) + Math.Abs(26.31092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23697 - lat) + Math.Abs(23.21411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.21579 - lat) + Math.Abs(23.87938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70564 - lat) + Math.Abs(20.94749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77246 - lat) + Math.Abs(22.37917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23361 - lat) + Math.Abs(20.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07044 - lat) + Math.Abs(20.70039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49928 - lat) + Math.Abs(22.88589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39847 - lat) + Math.Abs(21.79961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.14995 - lat) + Math.Abs(21.62298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77844 - lat) + Math.Abs(22.78573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3529 - lat) + Math.Abs(26.55758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.21753 - lat) + Math.Abs(20.89994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05586 - lat) + Math.Abs(23.70515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.63008 - lat) + Math.Abs(21.44553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.09276 - lat) + Math.Abs(22.58223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29881 - lat) + Math.Abs(21.99892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.88778 - lat) + Math.Abs(20.62389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12706 - lat) + Math.Abs(20.91781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38811 - lat) + Math.Abs(23.59598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.75013 - lat) + Math.Abs(21.41136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4651 - lat) + Math.Abs(21.87322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23318 - lat) + Math.Abs(26.20724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.53875 - lat) + Math.Abs(23.28873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.28099 - lat) + Math.Abs(21.90491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95 - lat) + Math.Abs(23.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.55167 - lat) + Math.Abs(21.81989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29352 - lat) + Math.Abs(26.10214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27712 - lat) + Math.Abs(21.96128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83894 - lat) + Math.Abs(23.92505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61741 - lat) + Math.Abs(21.29232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.45046 - lat) + Math.Abs(24.17507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80083 - lat) + Math.Abs(20.83789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9503 - lat) + Math.Abs(26.98388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03222 - lat) + Math.Abs(22.1125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.30599 - lat) + Math.Abs(23.1209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97099 - lat) + Math.Abs(23.40061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23415 - lat) + Math.Abs(26.04535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.28447 - lat) + Math.Abs(23.86308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16528 - lat) + Math.Abs(20.93206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.70444 - lat) + Math.Abs(21.62694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03913 - lat) + Math.Abs(22.11265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91033 - lat) + Math.Abs(23.72361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74174 - lat) + Math.Abs(20.90286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9634 - lat) + Math.Abs(23.76523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79283 - lat) + Math.Abs(22.7247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60453 - lat) + Math.Abs(21.48776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.36421 - lat) + Math.Abs(20.71848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45669 - lat) + Math.Abs(22.16577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43201 - lat) + Math.Abs(22.42443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.9552 - lat) + Math.Abs(23.1521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91356 - lat) + Math.Abs(23.0046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05282 - lat) + Math.Abs(23.76523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32787 - lat) + Math.Abs(25.14341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73333 - lat) + Math.Abs(25.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66486 - lat) + Math.Abs(20.85189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44461 - lat) + Math.Abs(23.26707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61758 - lat) + Math.Abs(20.9675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50342 - lat) + Math.Abs(20.26728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01186 - lat) + Math.Abs(25.74234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.34976 - lat) + Math.Abs(23.4656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63192 - lat) + Math.Abs(22.05258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18444 - lat) + Math.Abs(20.97933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52782 - lat) + Math.Abs(21.50569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20251 - lat) + Math.Abs(23.96504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01467 - lat) + Math.Abs(25.69127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49789 - lat) + Math.Abs(20.27608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3105 - lat) + Math.Abs(25.31327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32626 - lat) + Math.Abs(25.2774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47294 - lat) + Math.Abs(21.26133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76236 - lat) + Math.Abs(21.61853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54754 - lat) + Math.Abs(21.58817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86153 - lat) + Math.Abs(22.47647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46413 - lat) + Math.Abs(21.69342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17519 - lat) + Math.Abs(23.61572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51224 - lat) + Math.Abs(21.86473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.071 - lat) + Math.Abs(25.40174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86289 - lat) + Math.Abs(23.75802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95342 - lat) + Math.Abs(22.96681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32531 - lat) + Math.Abs(25.06694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52903 - lat) + Math.Abs(21.53226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85 - lat) + Math.Abs(21.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06518 - lat) + Math.Abs(21.63809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.35883 - lat) + Math.Abs(20.56472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.34692 - lat) + Math.Abs(24.45196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07795 - lat) + Math.Abs(24.87009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38067 - lat) + Math.Abs(22.38001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01667 - lat) + Math.Abs(23.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35742 - lat) + Math.Abs(21.56222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49618 - lat) + Math.Abs(23.44886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.49864 - lat) + Math.Abs(23.96341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79134 - lat) + Math.Abs(20.87407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41623 - lat) + Math.Abs(26.92328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.8497 - lat) + Math.Abs(22.38812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.35632 - lat) + Math.Abs(21.84314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05997 - lat) + Math.Abs(21.87533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00572 - lat) + Math.Abs(23.41537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.62794 - lat) + Math.Abs(24.92021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.52641 - lat) + Math.Abs(21.76617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69524 - lat) + Math.Abs(21.18467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05167 - lat) + Math.Abs(25.49829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02524 - lat) + Math.Abs(23.78257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44177 - lat) + Math.Abs(23.68306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20472 - lat) + Math.Abs(20.88222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15637 - lat) + Math.Abs(21.58532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60111 - lat) + Math.Abs(20.31194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.26246 - lat) + Math.Abs(26.14017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10235 - lat) + Math.Abs(23.66901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51602 - lat) + Math.Abs(21.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72117 - lat) + Math.Abs(22.72436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29472 - lat) + Math.Abs(22.38472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39959 - lat) + Math.Abs(23.62275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6 - lat) + Math.Abs(22.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54679 - lat) + Math.Abs(21.89397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45395 - lat) + Math.Abs(21.80351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4158 - lat) + Math.Abs(21.79897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35076 - lat) + Math.Abs(27.98292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71986 - lat) + Math.Abs(22.39733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.58791 - lat) + Math.Abs(22.94439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89736 - lat) + Math.Abs(22.92832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18414 - lat) + Math.Abs(22.73831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84006 - lat) + Math.Abs(22.10433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44466 - lat) + Math.Abs(24.9429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38492 - lat) + Math.Abs(23.24686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.21741 - lat) + Math.Abs(23.32234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40097 - lat) + Math.Abs(23.8022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16973 - lat) + Math.Abs(25.93437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.62675 - lat) + Math.Abs(21.49528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32821 - lat) + Math.Abs(24.33525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.2569 - lat) + Math.Abs(25.23757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14231 - lat) + Math.Abs(21.61353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23333 - lat) + Math.Abs(25.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35816 - lat) + Math.Abs(25.44615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.22683 - lat) + Math.Abs(27.85645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02387 - lat) + Math.Abs(21.31963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.265 - lat) + Math.Abs(25.72127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83267 - lat) + Math.Abs(22.6978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89013 - lat) + Math.Abs(23.74406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.52761 - lat) + Math.Abs(21.63436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.57783 - lat) + Math.Abs(22.33744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04135 - lat) + Math.Abs(23.54295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.70639 - lat) + Math.Abs(20.7925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15278 - lat) + Math.Abs(20.96214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.36336 - lat) + Math.Abs(23.44348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81094 - lat) + Math.Abs(22.53842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6277 - lat) + Math.Abs(22.76492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97933 - lat) + Math.Abs(21.82281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50131 - lat) + Math.Abs(21.53934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89472 - lat) + Math.Abs(22.18861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.30311 - lat) + Math.Abs(25.2316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.50805 - lat) + Math.Abs(22.97885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15393 - lat) + Math.Abs(22.19719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11035 - lat) + Math.Abs(23.83505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.37194 - lat) + Math.Abs(21.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62753 - lat) + Math.Abs(20.97163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.48413 - lat) + Math.Abs(23.54774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11977 - lat) + Math.Abs(23.86428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51038 - lat) + Math.Abs(21.74169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32152 - lat) + Math.Abs(21.85221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.53888 - lat) + Math.Abs(22.89323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39764 - lat) + Math.Abs(21.59911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02375 - lat) + Math.Abs(23.90788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12722 - lat) + Math.Abs(22.30028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61352 - lat) + Math.Abs(21.38072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42892 - lat) + Math.Abs(22.66728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10458 - lat) + Math.Abs(23.87938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59524 - lat) + Math.Abs(22.04025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.22403 - lat) + Math.Abs(20.51636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33762 - lat) + Math.Abs(23.67077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4625 - lat) + Math.Abs(23.17183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6926 - lat) + Math.Abs(21.58124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59468 - lat) + Math.Abs(21.65204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92422 - lat) + Math.Abs(21.81031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.13101 - lat) + Math.Abs(22.41983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55271 - lat) + Math.Abs(21.63707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.93408 - lat) + Math.Abs(20.46461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47942 - lat) + Math.Abs(22.49357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69206 - lat) + Math.Abs(22.41811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.49955 - lat) + Math.Abs(23.97488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61837 - lat) + Math.Abs(22.76989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95002 - lat) + Math.Abs(23.73437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24212 - lat) + Math.Abs(26.1992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.92652 - lat) + Math.Abs(21.14226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95611 - lat) + Math.Abs(22.79094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79205 - lat) + Math.Abs(20.89192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11669 - lat) + Math.Abs(23.87572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59894 - lat) + Math.Abs(20.87489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31885 - lat) + Math.Abs(26.05691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36977 - lat) + Math.Abs(22.77716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29633 - lat) + Math.Abs(21.8357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.26703 - lat) + Math.Abs(20.85428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.83793 - lat) + Math.Abs(22.88097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39343 - lat) + Math.Abs(22.93189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47118 - lat) + Math.Abs(21.61939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79763 - lat) + Math.Abs(22.79727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.27717 - lat) + Math.Abs(23.58906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.14657 - lat) + Math.Abs(23.85608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14417 - lat) + Math.Abs(20.86292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80096 - lat) + Math.Abs(22.70441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32789 - lat) + Math.Abs(22.54661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86886 - lat) + Math.Abs(20.80425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42051 - lat) + Math.Abs(23.64772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84681 - lat) + Math.Abs(21.11022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19106 - lat) + Math.Abs(25.71524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44142 - lat) + Math.Abs(24.02436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75612 - lat) + Math.Abs(22.85757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.63337 - lat) + Math.Abs(21.3995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72602 - lat) + Math.Abs(24.01289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78773 - lat) + Math.Abs(20.83085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61472 - lat) + Math.Abs(26.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6965 - lat) + Math.Abs(20.81308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44811 - lat) + Math.Abs(24.00511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53889 - lat) + Math.Abs(24.99167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93333 - lat) + Math.Abs(23.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7995 - lat) + Math.Abs(20.79769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.34519 - lat) + Math.Abs(22.76466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59975 - lat) + Math.Abs(22.8456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90411 - lat) + Math.Abs(23.06043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92736 - lat) + Math.Abs(23.14221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06667 - lat) + Math.Abs(24.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29169 - lat) + Math.Abs(23.91011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86324 - lat) + Math.Abs(21.56185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98938 - lat) + Math.Abs(23.66011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.13715 - lat) + Math.Abs(25.00131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35505 - lat) + Math.Abs(22.90881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63707 - lat) + Math.Abs(22.80504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08295 - lat) + Math.Abs(26.37218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24792 - lat) + Math.Abs(26.27178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09903 - lat) + Math.Abs(20.99108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01667 - lat) + Math.Abs(23.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1543 - lat) + Math.Abs(26.85162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51778 - lat) + Math.Abs(23.92675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20944 - lat) + Math.Abs(25.2047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.09707 - lat) + Math.Abs(24.68818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85919 - lat) + Math.Abs(23.39979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71901 - lat) + Math.Abs(22.75869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31294 - lat) + Math.Abs(20.35856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71135 - lat) + Math.Abs(21.69084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25149 - lat) + Math.Abs(23.69554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35253 - lat) + Math.Abs(24.43378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94611 - lat) + Math.Abs(25.22445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98376 - lat) + Math.Abs(23.72784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81675 - lat) + Math.Abs(22.92939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65111 - lat) + Math.Abs(22.99917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40395 - lat) + Math.Abs(22.72118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.55 - lat) + Math.Abs(26.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53556 - lat) + Math.Abs(21.08135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93955 - lat) + Math.Abs(22.82223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06134 - lat) + Math.Abs(23.58971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8505 - lat) + Math.Abs(21.66316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.04778 - lat) + Math.Abs(22.07484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.82328 - lat) + Math.Abs(20.72862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72986 - lat) + Math.Abs(22.85455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29882 - lat) + Math.Abs(23.50189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54431 - lat) + Math.Abs(22.86435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04321 - lat) + Math.Abs(25.09277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90594 - lat) + Math.Abs(23.75035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.82567 - lat) + Math.Abs(22.30689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40194 - lat) + Math.Abs(21.89649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.98181 - lat) + Math.Abs(24.72439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16014 - lat) + Math.Abs(20.98561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.488 - lat) + Math.Abs(22.69758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35121 - lat) + Math.Abs(23.48599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.74337 - lat) + Math.Abs(23.03301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70053 - lat) + Math.Abs(21.03896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.64788 - lat) + Math.Abs(21.6271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90953 - lat) + Math.Abs(22.88353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.14634 - lat) + Math.Abs(25.26538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.0992 - lat) + Math.Abs(22.00443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57372 - lat) + Math.Abs(22.83539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.18109 - lat) + Math.Abs(20.48903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63333 - lat) + Math.Abs(22.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61987 - lat) + Math.Abs(22.79923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76251 - lat) + Math.Abs(20.92357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22627 - lat) + Math.Abs(23.21868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15619 - lat) + Math.Abs(22.04485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66612 - lat) + Math.Abs(22.38127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63163 - lat) + Math.Abs(21.78649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9471 - lat) + Math.Abs(21.6619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47958 - lat) + Math.Abs(22.5835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67907 - lat) + Math.Abs(22.95825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81537 - lat) + Math.Abs(20.68674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97336 - lat) + Math.Abs(24.72391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26091 - lat) + Math.Abs(27.96698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07169 - lat) + Math.Abs(25.51967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29917 - lat) + Math.Abs(20.37311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34722 - lat) + Math.Abs(21.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85 - lat) + Math.Abs(22.47906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.29084 - lat) + Math.Abs(24.88412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.37936 - lat) + Math.Abs(22.98181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44997 - lat) + Math.Abs(24.93562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44904 - lat) + Math.Abs(25.39095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08333 - lat) + Math.Abs(23.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.32763 - lat) + Math.Abs(23.05395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.28913 - lat) + Math.Abs(21.81854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.27228 - lat) + Math.Abs(21.836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28374 - lat) + Math.Abs(25.05904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25 - lat) + Math.Abs(21.18528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.13267 - lat) + Math.Abs(23.85874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76005 - lat) + Math.Abs(21.18912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65923 - lat) + Math.Abs(22.78882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71051 - lat) + Math.Abs(23.34659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56585 - lat) + Math.Abs(21.29631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08658 - lat) + Math.Abs(20.923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83333 - lat) + Math.Abs(24.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48387 - lat) + Math.Abs(21.90563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90588 - lat) + Math.Abs(21.26936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23401 - lat) + Math.Abs(25.98018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33014 - lat) + Math.Abs(21.76413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.0394 - lat) + Math.Abs(25.08258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.80888 - lat) + Math.Abs(27.09764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38333 - lat) + Math.Abs(22.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18996 - lat) + Math.Abs(22.09308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07276 - lat) + Math.Abs(22.55111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73414 - lat) + Math.Abs(23.94389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63531 - lat) + Math.Abs(20.86578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35 - lat) + Math.Abs(25.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83175 - lat) + Math.Abs(25.89821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27097 - lat) + Math.Abs(20.94257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52813 - lat) + Math.Abs(22.37713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85944 - lat) + Math.Abs(21.16639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.63912 - lat) + Math.Abs(22.59171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74481 - lat) + Math.Abs(22.36575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75809 - lat) + Math.Abs(20.87248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95055 - lat) + Math.Abs(23.52803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05 - lat) + Math.Abs(23.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.393 - lat) + Math.Abs(23.88492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79842 - lat) + Math.Abs(21.35068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16667 - lat) + Math.Abs(22.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18222 - lat) + Math.Abs(22.75944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.37039 - lat) + Math.Abs(22.9835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41667 - lat) + Math.Abs(24.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.36667 - lat) + Math.Abs(23.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.64019 - lat) + Math.Abs(21.5375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09422 - lat) + Math.Abs(21.02011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15469 - lat) + Math.Abs(22.3183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45663 - lat) + Math.Abs(23.22093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.89284 - lat) + Math.Abs(22.72483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.00548 - lat) + Math.Abs(22.96095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08333 - lat) + Math.Abs(23.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.14846 - lat) + Math.Abs(22.35426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.24861 - lat) + Math.Abs(22.08194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74667 - lat) + Math.Abs(23.4275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43704 - lat) + Math.Abs(21.35358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95278 - lat) + Math.Abs(22.61208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98333 - lat) + Math.Abs(23.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.87924 - lat) + Math.Abs(23.04691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92135 - lat) + Math.Abs(23.45877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62139 - lat) + Math.Abs(21.40778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34078 - lat) + Math.Abs(23.01258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13689 - lat) + Math.Abs(21.64911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15789 - lat) + Math.Abs(26.06099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86791 - lat) + Math.Abs(21.4655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48586 - lat) + Math.Abs(21.84789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47419 - lat) + Math.Abs(21.08051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45212 - lat) + Math.Abs(23.68775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20332 - lat) + Math.Abs(23.83982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72506 - lat) + Math.Abs(24.44685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43556 - lat) + Math.Abs(28.22199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33977 - lat) + Math.Abs(25.15895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.40981 - lat) + Math.Abs(28.1192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.29354 - lat) + Math.Abs(28.16225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21492 - lat) + Math.Abs(28.11487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.09102 - lat) + Math.Abs(28.08571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.09419 - lat) + Math.Abs(28.01565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.6647 - lat) + Math.Abs(26.8812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80217 - lat) + Math.Abs(26.7447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.87696 - lat) + Math.Abs(27.20532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.87168 - lat) + Math.Abs(27.18373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97732 - lat) + Math.Abs(22.6498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13969 - lat) + Math.Abs(21.02613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15064 - lat) + Math.Abs(20.73636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45339 - lat) + Math.Abs(19.998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0132 - lat) + Math.Abs(24.38132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01887 - lat) + Math.Abs(24.64063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6802 - lat) + Math.Abs(22.2645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79194 - lat) + Math.Abs(22.4075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45504 - lat) + Math.Abs(21.42904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62666 - lat) + Math.Abs(23.21566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9567 - lat) + Math.Abs(24.14806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06165 - lat) + Math.Abs(24.96248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15943 - lat) + Math.Abs(23.36134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73253 - lat) + Math.Abs(22.69359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19206 - lat) + Math.Abs(24.10385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80289 - lat) + Math.Abs(22.77882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69028 - lat) + Math.Abs(21.62324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92713 - lat) + Math.Abs(23.17944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97437 - lat) + Math.Abs(25.42022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5687 - lat) + Math.Abs(22.33907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13488 - lat) + Math.Abs(24.888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19356 - lat) + Math.Abs(22.43203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62048 - lat) + Math.Abs(22.40365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37184 - lat) + Math.Abs(23.5359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66257 - lat) + Math.Abs(22.64061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02828 - lat) + Math.Abs(22.07924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.31661 - lat) + Math.Abs(24.00215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41436 - lat) + Math.Abs(21.38015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99473 - lat) + Math.Abs(23.98408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26541 - lat) + Math.Abs(23.25247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76733 - lat) + Math.Abs(21.61595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48654 - lat) + Math.Abs(22.31735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95396 - lat) + Math.Abs(23.39833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52437 - lat) + Math.Abs(22.20242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25532 - lat) + Math.Abs(22.07543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76942 - lat) + Math.Abs(22.7088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63193 - lat) + Math.Abs(23.19029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47966 - lat) + Math.Abs(23.13695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56953 - lat) + Math.Abs(23.6588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53967 - lat) + Math.Abs(21.50292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17916 - lat) + Math.Abs(23.39602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08394 - lat) + Math.Abs(23.34608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99354 - lat) + Math.Abs(23.59613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17927 - lat) + Math.Abs(23.32022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00984 - lat) + Math.Abs(22.66344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26147 - lat) + Math.Abs(21.32533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95495 - lat) + Math.Abs(22.03763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37093 - lat) + Math.Abs(22.45863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57182 - lat) + Math.Abs(22.15195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46898 - lat) + Math.Abs(22.9718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59814 - lat) + Math.Abs(22.55733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98417 - lat) + Math.Abs(23.34785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02385 - lat) + Math.Abs(23.70619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93526 - lat) + Math.Abs(22.5438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58338 - lat) + Math.Abs(21.30453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02878 - lat) + Math.Abs(26.29455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99992 - lat) + Math.Abs(23.78207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64361 - lat) + Math.Abs(22.93086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54712 - lat) + Math.Abs(23.01967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6594 - lat) + Math.Abs(24.69257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94959 - lat) + Math.Abs(22.19168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77806 - lat) + Math.Abs(24.70944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91643 - lat) + Math.Abs(23.48137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42483 - lat) + Math.Abs(23.52223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26805 - lat) + Math.Abs(22.46366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04144 - lat) + Math.Abs(23.31487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51406 - lat) + Math.Abs(23.82471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52772 - lat) + Math.Abs(23.76306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64963 - lat) + Math.Abs(23.30344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56546 - lat) + Math.Abs(26.4581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60359 - lat) + Math.Abs(22.12578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66944 - lat) + Math.Abs(22.93806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66498 - lat) + Math.Abs(23.70015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58939 - lat) + Math.Abs(22.30861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71161 - lat) + Math.Abs(22.21694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54477 - lat) + Math.Abs(23.5899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27726 - lat) + Math.Abs(23.14735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47274 - lat) + Math.Abs(23.09197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19194 - lat) + Math.Abs(26.29944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99894 - lat) + Math.Abs(22.03254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81788 - lat) + Math.Abs(23.35546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.23333 - lat) + Math.Abs(24.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01871 - lat) + Math.Abs(23.51971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12844 - lat) + Math.Abs(23.38174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01495 - lat) + Math.Abs(22.55244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76346 - lat) + Math.Abs(21.41039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62192 - lat) + Math.Abs(21.5048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76722 - lat) + Math.Abs(22.15194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06032 - lat) + Math.Abs(22.5612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70641 - lat) + Math.Abs(24.53392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88172 - lat) + Math.Abs(23.61858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79094 - lat) + Math.Abs(21.5429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11067 - lat) + Math.Abs(24.02755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67045 - lat) + Math.Abs(22.80545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03874 - lat) + Math.Abs(23.94046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64944 - lat) + Math.Abs(22.95083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.23499 - lat) + Math.Abs(23.38899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26194 - lat) + Math.Abs(21.54417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38581 - lat) + Math.Abs(22.20881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41307 - lat) + Math.Abs(22.54677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76874 - lat) + Math.Abs(22.12346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35927 - lat) + Math.Abs(22.54513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17972 - lat) + Math.Abs(21.99444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08499 - lat) + Math.Abs(23.54757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13382 - lat) + Math.Abs(24.99408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09369 - lat) + Math.Abs(23.97859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06783 - lat) + Math.Abs(22.05264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02861 - lat) + Math.Abs(25.69306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47333 - lat) + Math.Abs(25.52222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10462 - lat) + Math.Abs(21.01864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26125 - lat) + Math.Abs(23.00043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92055 - lat) + Math.Abs(23.97489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6907 - lat) + Math.Abs(22.01751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73331 - lat) + Math.Abs(22.13674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35061 - lat) + Math.Abs(22.21079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.6249 - lat) + Math.Abs(26.42771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78373 - lat) + Math.Abs(22.088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28835 - lat) + Math.Abs(22.28361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.40086 - lat) + Math.Abs(22.39309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65806 - lat) + Math.Abs(22.99378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81211 - lat) + Math.Abs(22.53853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48453 - lat) + Math.Abs(22.21451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51472 - lat) + Math.Abs(21.67861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08266 - lat) + Math.Abs(24.18968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00404 - lat) + Math.Abs(23.62994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02654 - lat) + Math.Abs(26.25906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06825 - lat) + Math.Abs(23.3903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94411 - lat) + Math.Abs(24.00118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18333 - lat) + Math.Abs(23.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02517 - lat) + Math.Abs(22.00437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79826 - lat) + Math.Abs(22.66659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81373 - lat) + Math.Abs(22.16166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68767 - lat) + Math.Abs(23.27737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55083 - lat) + Math.Abs(22.39667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71633 - lat) + Math.Abs(24.72859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28405 - lat) + Math.Abs(23.29549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4885 - lat) + Math.Abs(21.2124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10445 - lat) + Math.Abs(22.62162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20885 - lat) + Math.Abs(23.28325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37704 - lat) + Math.Abs(23.44135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68306 - lat) + Math.Abs(22.19118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37091 - lat) + Math.Abs(22.0673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01657 - lat) + Math.Abs(23.52834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66671 - lat) + Math.Abs(22.94881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99444 - lat) + Math.Abs(22.56909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92598 - lat) + Math.Abs(22.01634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52154 - lat) + Math.Abs(21.32144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83112 - lat) + Math.Abs(24.02483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47276 - lat) + Math.Abs(22.9579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64241 - lat) + Math.Abs(22.53458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84715 - lat) + Math.Abs(24.06005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56475 - lat) + Math.Abs(22.55072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20083 - lat) + Math.Abs(22.02488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90605 - lat) + Math.Abs(24.67215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06619 - lat) + Math.Abs(22.23128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62643 - lat) + Math.Abs(22.73291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97023 - lat) + Math.Abs(22.01682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59918 - lat) + Math.Abs(22.98613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03844 - lat) + Math.Abs(22.57638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1947 - lat) + Math.Abs(24.01731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9875 - lat) + Math.Abs(24.61489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08742 - lat) + Math.Abs(24.84092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7202 - lat) + Math.Abs(22.14439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10056 - lat) + Math.Abs(24.89847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00054 - lat) + Math.Abs(24.63627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74418 - lat) + Math.Abs(23.03571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54881 - lat) + Math.Abs(23.1654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27443 - lat) + Math.Abs(22.54164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49874 - lat) + Math.Abs(22.92617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95755 - lat) + Math.Abs(26.26577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45376 - lat) + Math.Abs(21.14216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05011 - lat) + Math.Abs(23.68893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81902 - lat) + Math.Abs(22.41903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74296 - lat) + Math.Abs(22.85256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76169 - lat) + Math.Abs(22.52637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91013 - lat) + Math.Abs(22.87253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56071 - lat) + Math.Abs(22.18545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70035 - lat) + Math.Abs(22.60697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26667 - lat) + Math.Abs(24.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98508 - lat) + Math.Abs(23.67017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2671 - lat) + Math.Abs(22.59615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83866 - lat) + Math.Abs(21.49793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58779 - lat) + Math.Abs(23.0315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73067 - lat) + Math.Abs(24.72816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90495 - lat) + Math.Abs(24.35083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48416 - lat) + Math.Abs(22.34328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41921 - lat) + Math.Abs(22.46309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80318 - lat) + Math.Abs(22.32615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60611 - lat) + Math.Abs(22.32918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31403 - lat) + Math.Abs(22.46448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43711 - lat) + Math.Abs(22.5753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81462 - lat) + Math.Abs(22.72748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80223 - lat) + Math.Abs(22.36158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87068 - lat) + Math.Abs(23.90121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94338 - lat) + Math.Abs(24.17747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49186 - lat) + Math.Abs(23.64928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50085 - lat) + Math.Abs(23.45138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15636 - lat) + Math.Abs(23.41322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78283 - lat) + Math.Abs(22.27388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30506 - lat) + Math.Abs(24.89438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02801 - lat) + Math.Abs(25.31809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33333 - lat) + Math.Abs(23.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29451 - lat) + Math.Abs(23.54332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.72048 - lat) + Math.Abs(26.2152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95133 - lat) + Math.Abs(21.92612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19548 - lat) + Math.Abs(23.5923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7758 - lat) + Math.Abs(23.95105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50306 - lat) + Math.Abs(26.52972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73083 - lat) + Math.Abs(22.91722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59189 - lat) + Math.Abs(23.78209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10237 - lat) + Math.Abs(23.62576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79663 - lat) + Math.Abs(23.91093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6361 - lat) + Math.Abs(22.38884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59443 - lat) + Math.Abs(22.46036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92912 - lat) + Math.Abs(26.01801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63695 - lat) + Math.Abs(23.2758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93266 - lat) + Math.Abs(23.42773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22204 - lat) + Math.Abs(23.66837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94739 - lat) + Math.Abs(24.14311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90528 - lat) + Math.Abs(23.49944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41278 - lat) + Math.Abs(21.06222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0239 - lat) + Math.Abs(23.60927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49462 - lat) + Math.Abs(26.5039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81872 - lat) + Math.Abs(22.35489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0961 - lat) + Math.Abs(23.78323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92149 - lat) + Math.Abs(22.74659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09397 - lat) + Math.Abs(23.64376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49605 - lat) + Math.Abs(22.98794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27459 - lat) + Math.Abs(23.29381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43503 - lat) + Math.Abs(21.33161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80826 - lat) + Math.Abs(22.70733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73817 - lat) + Math.Abs(22.87557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51131 - lat) + Math.Abs(26.4574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05231 - lat) + Math.Abs(23.57997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66495 - lat) + Math.Abs(22.4456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55569 - lat) + Math.Abs(22.49374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50858 - lat) + Math.Abs(23.67946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5054 - lat) + Math.Abs(22.4152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49863 - lat) + Math.Abs(22.91192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03204 - lat) + Math.Abs(23.8287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58449 - lat) + Math.Abs(26.54318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30575 - lat) + Math.Abs(23.2066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11363 - lat) + Math.Abs(23.3768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32946 - lat) + Math.Abs(23.1336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84084 - lat) + Math.Abs(22.92163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38119 - lat) + Math.Abs(23.92374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19409 - lat) + Math.Abs(23.32832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26537 - lat) + Math.Abs(23.20376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83854 - lat) + Math.Abs(24.3013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76516 - lat) + Math.Abs(22.49173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29147 - lat) + Math.Abs(23.34205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.587 - lat) + Math.Abs(22.25007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2439 - lat) + Math.Abs(23.28484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46371 - lat) + Math.Abs(22.8617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75158 - lat) + Math.Abs(22.76904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60985 - lat) + Math.Abs(22.68196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68785 - lat) + Math.Abs(22.84582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5727 - lat) + Math.Abs(22.23803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79443 - lat) + Math.Abs(23.84163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96148 - lat) + Math.Abs(24.51132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90621 - lat) + Math.Abs(24.70726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31312 - lat) + Math.Abs(23.06343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86442 - lat) + Math.Abs(24.3165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34772 - lat) + Math.Abs(23.0155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13333 - lat) + Math.Abs(23.39754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22923 - lat) + Math.Abs(22.49811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98847 - lat) + Math.Abs(24.02036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62558 - lat) + Math.Abs(23.44074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62944 - lat) + Math.Abs(22.06806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86239 - lat) + Math.Abs(24.11271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25332 - lat) + Math.Abs(22.79602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06007 - lat) + Math.Abs(23.60501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61844 - lat) + Math.Abs(22.17581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.22328 - lat) + Math.Abs(22.8272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99205 - lat) + Math.Abs(22.14465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19351 - lat) + Math.Abs(23.8157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7043 - lat) + Math.Abs(22.54112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84098 - lat) + Math.Abs(22.77483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24384 - lat) + Math.Abs(24.92084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4474 - lat) + Math.Abs(22.59004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32443 - lat) + Math.Abs(23.65511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22994 - lat) + Math.Abs(23.60358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50252 - lat) + Math.Abs(21.1611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79339 - lat) + Math.Abs(22.0254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41344 - lat) + Math.Abs(23.0075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65829 - lat) + Math.Abs(22.89712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83434 - lat) + Math.Abs(21.58426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76796 - lat) + Math.Abs(22.92858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51685 - lat) + Math.Abs(22.39599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14835 - lat) + Math.Abs(23.44482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14712 - lat) + Math.Abs(25.30108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24688 - lat) + Math.Abs(23.22488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44505 - lat) + Math.Abs(23.67999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78243 - lat) + Math.Abs(22.15629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89427 - lat) + Math.Abs(23.75048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88714 - lat) + Math.Abs(22.81345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9129 - lat) + Math.Abs(23.87124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51224 - lat) + Math.Abs(21.32038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.692 - lat) + Math.Abs(22.10099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50064 - lat) + Math.Abs(21.24446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85677 - lat) + Math.Abs(22.21264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17169 - lat) + Math.Abs(22.48463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55125 - lat) + Math.Abs(22.24955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41551 - lat) + Math.Abs(22.60392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88153 - lat) + Math.Abs(26.04697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58873 - lat) + Math.Abs(22.39976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67838 - lat) + Math.Abs(22.54257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24395 - lat) + Math.Abs(22.38033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12625 - lat) + Math.Abs(22.15753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25172 - lat) + Math.Abs(23.07598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03455 - lat) + Math.Abs(21.94279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10056 - lat) + Math.Abs(22.49778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74533 - lat) + Math.Abs(22.97982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13444 - lat) + Math.Abs(23.22154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7469 - lat) + Math.Abs(22.2474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20587 - lat) + Math.Abs(23.2046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62741 - lat) + Math.Abs(24.5765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06413 - lat) + Math.Abs(25.6857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63526 - lat) + Math.Abs(22.5082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13629 - lat) + Math.Abs(24.97932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10029 - lat) + Math.Abs(23.49658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65298 - lat) + Math.Abs(22.1191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72351 - lat) + Math.Abs(23.0042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26957 - lat) + Math.Abs(26.38522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63569 - lat) + Math.Abs(23.24653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75 - lat) + Math.Abs(23.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39139 - lat) + Math.Abs(23.05578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64531 - lat) + Math.Abs(21.70313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83628 - lat) + Math.Abs(21.14061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45102 - lat) + Math.Abs(26.46067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26349 - lat) + Math.Abs(21.8176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84184 - lat) + Math.Abs(22.98292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95962 - lat) + Math.Abs(22.85929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03569 - lat) + Math.Abs(23.47361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02477 - lat) + Math.Abs(24.37833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81497 - lat) + Math.Abs(23.28131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01396 - lat) + Math.Abs(24.29647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68738 - lat) + Math.Abs(22.30516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30069 - lat) + Math.Abs(21.78896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54652 - lat) + Math.Abs(22.31795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35533 - lat) + Math.Abs(26.43691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77778 - lat) + Math.Abs(22.57194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98013 - lat) + Math.Abs(24.05565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5049 - lat) + Math.Abs(21.37703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31659 - lat) + Math.Abs(22.58817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60286 - lat) + Math.Abs(22.50681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63382 - lat) + Math.Abs(22.12893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99865 - lat) + Math.Abs(22.17355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04861 - lat) + Math.Abs(20.75667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22754 - lat) + Math.Abs(22.461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11917 - lat) + Math.Abs(25.40535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59057 - lat) + Math.Abs(21.77671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.59374 - lat) + Math.Abs(26.22947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50503 - lat) + Math.Abs(21.2111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75662 - lat) + Math.Abs(23.13377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47888 - lat) + Math.Abs(22.48319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9269 - lat) + Math.Abs(24.30805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21282 - lat) + Math.Abs(23.30035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33055 - lat) + Math.Abs(21.79102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4314 - lat) + Math.Abs(21.85806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56632 - lat) + Math.Abs(22.59033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37399 - lat) + Math.Abs(22.57862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.099 - lat) + Math.Abs(24.28915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.57542 - lat) + Math.Abs(26.22905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14788 - lat) + Math.Abs(24.93869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61354 - lat) + Math.Abs(22.69278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99302 - lat) + Math.Abs(22.87433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98556 - lat) + Math.Abs(24.69389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05806 - lat) + Math.Abs(23.65108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93328 - lat) + Math.Abs(24.71088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18097 - lat) + Math.Abs(23.23551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60954 - lat) + Math.Abs(23.10014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21947 - lat) + Math.Abs(23.36874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99594 - lat) + Math.Abs(22.72637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13056 - lat) + Math.Abs(24.20843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11048 - lat) + Math.Abs(23.25815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48723 - lat) + Math.Abs(21.19136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08921 - lat) + Math.Abs(22.78067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26031 - lat) + Math.Abs(23.37279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65139 - lat) + Math.Abs(22.16659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73184 - lat) + Math.Abs(22.59992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21887 - lat) + Math.Abs(23.08454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85591 - lat) + Math.Abs(24.70595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78667 - lat) + Math.Abs(21.68895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01234 - lat) + Math.Abs(20.55817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56889 - lat) + Math.Abs(22.36576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56225 - lat) + Math.Abs(26.5147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59142 - lat) + Math.Abs(22.33192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71539 - lat) + Math.Abs(23.04588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93959 - lat) + Math.Abs(24.40687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42906 - lat) + Math.Abs(23.02978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35 - lat) + Math.Abs(23.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25403 - lat) + Math.Abs(22.34342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97116 - lat) + Math.Abs(21.94659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75754 - lat) + Math.Abs(22.17962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02119 - lat) + Math.Abs(23.48336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26956 - lat) + Math.Abs(22.50608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46693 - lat) + Math.Abs(22.54204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52165 - lat) + Math.Abs(21.26341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27743 - lat) + Math.Abs(22.89398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.64551 - lat) + Math.Abs(26.47676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17434 - lat) + Math.Abs(22.02368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81917 - lat) + Math.Abs(22.65875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04835 - lat) + Math.Abs(23.41362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13212 - lat) + Math.Abs(23.30436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40611 - lat) + Math.Abs(26.42557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34563 - lat) + Math.Abs(23.31026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18745 - lat) + Math.Abs(22.48171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76915 - lat) + Math.Abs(22.31331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75139 - lat) + Math.Abs(23.98262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25715 - lat) + Math.Abs(24.24498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46909 - lat) + Math.Abs(22.99378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60953 - lat) + Math.Abs(22.36954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88951 - lat) + Math.Abs(22.91682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47501 - lat) + Math.Abs(25.47456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10543 - lat) + Math.Abs(24.0857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64189 - lat) + Math.Abs(22.85734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2739 - lat) + Math.Abs(22.57775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07374 - lat) + Math.Abs(23.44637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79004 - lat) + Math.Abs(22.23339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1728 - lat) + Math.Abs(24.21527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14653 - lat) + Math.Abs(23.90667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28659 - lat) + Math.Abs(23.39033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20778 - lat) + Math.Abs(22.44311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75508 - lat) + Math.Abs(22.21753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7409 - lat) + Math.Abs(24.57787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81931 - lat) + Math.Abs(22.17761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55613 - lat) + Math.Abs(23.3735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05 - lat) + Math.Abs(24.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5825 - lat) + Math.Abs(22.95028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09941 - lat) + Math.Abs(23.42396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89537 - lat) + Math.Abs(23.69857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83582 - lat) + Math.Abs(21.51351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58442 - lat) + Math.Abs(21.49218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7568 - lat) + Math.Abs(23.0356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18217 - lat) + Math.Abs(23.28243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39748 - lat) + Math.Abs(23.87505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03061 - lat) + Math.Abs(24.28153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00991 - lat) + Math.Abs(22.1765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12747 - lat) + Math.Abs(25.18573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95433 - lat) + Math.Abs(22.41037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08452 - lat) + Math.Abs(21.42744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99505 - lat) + Math.Abs(24.6525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94604 - lat) + Math.Abs(22.44974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96083 - lat) + Math.Abs(22.5243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39608 - lat) + Math.Abs(23.79547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02557 - lat) + Math.Abs(23.77574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30888 - lat) + Math.Abs(22.49577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85817 - lat) + Math.Abs(22.87604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4682 - lat) + Math.Abs(23.28015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31966 - lat) + Math.Abs(21.55148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7559 - lat) + Math.Abs(22.28062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06013 - lat) + Math.Abs(24.04724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80935 - lat) + Math.Abs(24.15686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26108 - lat) + Math.Abs(23.22107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78197 - lat) + Math.Abs(21.40981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75258 - lat) + Math.Abs(22.01691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93132 - lat) + Math.Abs(23.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94403 - lat) + Math.Abs(23.5063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56325 - lat) + Math.Abs(22.10968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03436 - lat) + Math.Abs(22.15207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6252 - lat) + Math.Abs(21.70851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11667 - lat) + Math.Abs(25.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69151 - lat) + Math.Abs(23.0046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02504 - lat) + Math.Abs(24.33933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79798 - lat) + Math.Abs(22.84048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89305 - lat) + Math.Abs(26.17234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97643 - lat) + Math.Abs(22.12958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89703 - lat) + Math.Abs(22.55277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67056 - lat) + Math.Abs(22.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98333 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07374 - lat) + Math.Abs(22.90818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86285 - lat) + Math.Abs(23.77186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68797 - lat) + Math.Abs(22.95348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70733 - lat) + Math.Abs(22.26385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34253 - lat) + Math.Abs(21.51333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95008 - lat) + Math.Abs(24.63993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10063 - lat) + Math.Abs(23.59144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68748 - lat) + Math.Abs(22.1364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59148 - lat) + Math.Abs(22.36466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42614 - lat) + Math.Abs(22.92782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47539 - lat) + Math.Abs(22.86891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08548 - lat) + Math.Abs(23.70981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48866 - lat) + Math.Abs(21.55768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91389 - lat) + Math.Abs(24.25139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84666 - lat) + Math.Abs(24.25431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7482 - lat) + Math.Abs(22.62638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31948 - lat) + Math.Abs(22.25804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8203 - lat) + Math.Abs(24.24373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27558 - lat) + Math.Abs(24.97237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8026 - lat) + Math.Abs(22.04751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15283 - lat) + Math.Abs(24.1473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82291 - lat) + Math.Abs(22.24816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16641 - lat) + Math.Abs(22.80298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78099 - lat) + Math.Abs(22.95889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92393 - lat) + Math.Abs(23.87119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99455 - lat) + Math.Abs(22.05749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48148 - lat) + Math.Abs(21.28786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98508 - lat) + Math.Abs(23.41347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.70546 - lat) + Math.Abs(26.29498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34806 - lat) + Math.Abs(26.49611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54606 - lat) + Math.Abs(22.26686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68744 - lat) + Math.Abs(22.85799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16338 - lat) + Math.Abs(23.26798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12826 - lat) + Math.Abs(26.22441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60215 - lat) + Math.Abs(22.1943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66424 - lat) + Math.Abs(23.11373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86725 - lat) + Math.Abs(22.58298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72398 - lat) + Math.Abs(21.74825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24926 - lat) + Math.Abs(23.69616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25906 - lat) + Math.Abs(23.33574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71799 - lat) + Math.Abs(22.29545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09973 - lat) + Math.Abs(23.58022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32663 - lat) + Math.Abs(22.52636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15559 - lat) + Math.Abs(22.23048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07463 - lat) + Math.Abs(24.24545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71598 - lat) + Math.Abs(22.72841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10142 - lat) + Math.Abs(23.67992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49588 - lat) + Math.Abs(22.24439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50003 - lat) + Math.Abs(22.87351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90795 - lat) + Math.Abs(24.65636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94935 - lat) + Math.Abs(23.45706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4815 - lat) + Math.Abs(23.04863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59722 - lat) + Math.Abs(22.21533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98582 - lat) + Math.Abs(22.54165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87302 - lat) + Math.Abs(24.17889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96279 - lat) + Math.Abs(24.80441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82615 - lat) + Math.Abs(22.59279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64125 - lat) + Math.Abs(23.02528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82143 - lat) + Math.Abs(23.03008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73049 - lat) + Math.Abs(23.7118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9011 - lat) + Math.Abs(22.6304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73566 - lat) + Math.Abs(22.21512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75105 - lat) + Math.Abs(23.38721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71412 - lat) + Math.Abs(22.15923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08131 - lat) + Math.Abs(25.69494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79555 - lat) + Math.Abs(21.83577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48652 - lat) + Math.Abs(23.59537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80257 - lat) + Math.Abs(21.46085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08213 - lat) + Math.Abs(22.27914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07 - lat) + Math.Abs(25.59041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97306 - lat) + Math.Abs(22.05639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45354 - lat) + Math.Abs(21.25889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74405 - lat) + Math.Abs(23.58807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47734 - lat) + Math.Abs(21.63352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84352 - lat) + Math.Abs(22.30178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08139 - lat) + Math.Abs(25.55186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8924 - lat) + Math.Abs(22.05709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87132 - lat) + Math.Abs(25.9902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65648 - lat) + Math.Abs(22.21576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28562 - lat) + Math.Abs(23.03683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07041 - lat) + Math.Abs(23.46064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2266 - lat) + Math.Abs(21.82827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05695 - lat) + Math.Abs(23.42391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31997 - lat) + Math.Abs(22.49356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71509 - lat) + Math.Abs(22.78012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67862 - lat) + Math.Abs(22.19933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49717 - lat) + Math.Abs(22.8344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55535 - lat) + Math.Abs(22.47083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94596 - lat) + Math.Abs(24.21091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10982 - lat) + Math.Abs(23.33256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66152 - lat) + Math.Abs(22.7119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54446 - lat) + Math.Abs(21.74841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49234 - lat) + Math.Abs(21.57279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33272 - lat) + Math.Abs(23.92149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14324 - lat) + Math.Abs(23.33539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78203 - lat) + Math.Abs(21.48458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93293 - lat) + Math.Abs(24.33835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68967 - lat) + Math.Abs(21.67974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96346 - lat) + Math.Abs(24.36007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46582 - lat) + Math.Abs(21.31001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83417 - lat) + Math.Abs(22.38767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39386 - lat) + Math.Abs(22.54021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06443 - lat) + Math.Abs(23.95751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84995 - lat) + Math.Abs(25.87644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62667 - lat) + Math.Abs(22.44417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84024 - lat) + Math.Abs(22.65408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78916 - lat) + Math.Abs(24.03504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43492 - lat) + Math.Abs(21.90609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.31976 - lat) + Math.Abs(23.54026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83703 - lat) + Math.Abs(22.34227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92054 - lat) + Math.Abs(23.6563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50139 - lat) + Math.Abs(22.54 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16381 - lat) + Math.Abs(21.81945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8055 - lat) + Math.Abs(22.00363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09915 - lat) + Math.Abs(23.4367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66121 - lat) + Math.Abs(21.55395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67131 - lat) + Math.Abs(22.60466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33419 - lat) + Math.Abs(22.5245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67806 - lat) + Math.Abs(22.19278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75113 - lat) + Math.Abs(22.4541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64075 - lat) + Math.Abs(22.96039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.615 - lat) + Math.Abs(22.9762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93011 - lat) + Math.Abs(22.08052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79084 - lat) + Math.Abs(22.26373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77406 - lat) + Math.Abs(22.35304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.273 - lat) + Math.Abs(22.48109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32579 - lat) + Math.Abs(22.30868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37372 - lat) + Math.Abs(22.39738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.023 - lat) + Math.Abs(22.24078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41944 - lat) + Math.Abs(26.22504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63098 - lat) + Math.Abs(19.76312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.5834 - lat) + Math.Abs(19.8827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.72089 - lat) + Math.Abs(19.84147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56577 - lat) + Math.Abs(19.8483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78683 - lat) + Math.Abs(19.79297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6242 - lat) + Math.Abs(19.87826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78638 - lat) + Math.Abs(19.67317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84231 - lat) + Math.Abs(19.40494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.75594 - lat) + Math.Abs(19.78492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48467 - lat) + Math.Abs(19.92469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66918 - lat) + Math.Abs(19.7402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64436 - lat) + Math.Abs(19.85194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60527 - lat) + Math.Abs(19.86719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60919 - lat) + Math.Abs(19.815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56785 - lat) + Math.Abs(19.88362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62441 - lat) + Math.Abs(19.92016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74554 - lat) + Math.Abs(19.67943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68969 - lat) + Math.Abs(19.82809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53916 - lat) + Math.Abs(19.86483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59279 - lat) + Math.Abs(19.88459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78822 - lat) + Math.Abs(19.92125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78028 - lat) + Math.Abs(19.74475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60556 - lat) + Math.Abs(19.8925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69472 - lat) + Math.Abs(19.83667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65283 - lat) + Math.Abs(19.8425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.5611 - lat) + Math.Abs(19.89842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68988 - lat) + Math.Abs(19.74084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54367 - lat) + Math.Abs(19.91369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49506 - lat) + Math.Abs(19.87336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61571 - lat) + Math.Abs(19.84762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77767 - lat) + Math.Abs(19.66378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43517 - lat) + Math.Abs(19.97632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.70567 - lat) + Math.Abs(19.79226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61594 - lat) + Math.Abs(19.89564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62162 - lat) + Math.Abs(19.85837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03381 - lat) + Math.Abs(23.82962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.33981 - lat) + Math.Abs(28.19942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72837 - lat) + Math.Abs(20.8678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41448 - lat) + Math.Abs(25.3422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42711 - lat) + Math.Abs(19.94877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61154 - lat) + Math.Abs(24.608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7936 - lat) + Math.Abs(19.81736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.72363 - lat) + Math.Abs(19.69969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01896 - lat) + Math.Abs(25.85371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36225 - lat) + Math.Abs(24.26013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.12468 - lat) + Math.Abs(25.73882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78697 - lat) + Math.Abs(20.71923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42391 - lat) + Math.Abs(25.32248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99214 - lat) + Math.Abs(25.45515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97156 - lat) + Math.Abs(26.93727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32934 - lat) + Math.Abs(25.31353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74809 - lat) + Math.Abs(23.91059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32969 - lat) + Math.Abs(25.2065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95342 - lat) + Math.Abs(23.74897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03715 - lat) + Math.Abs(25.97179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02277 - lat) + Math.Abs(23.8576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4582 - lat) + Math.Abs(26.97272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4634 - lat) + Math.Abs(25.33022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97866 - lat) + Math.Abs(23.74103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31915 - lat) + Math.Abs(25.09307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3721 - lat) + Math.Abs(24.5414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76663 - lat) + Math.Abs(23.90039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.52264 - lat) + Math.Abs(20.88358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25459 - lat) + Math.Abs(24.63495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93149 - lat) + Math.Abs(23.76779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98468 - lat) + Math.Abs(23.64711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25045 - lat) + Math.Abs(23.24982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97574 - lat) + Math.Abs(23.76911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06019 - lat) + Math.Abs(23.79264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03013 - lat) + Math.Abs(23.72379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65304 - lat) + Math.Abs(22.92624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5785 - lat) + Math.Abs(26.48069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19428 - lat) + Math.Abs(23.32874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.52997 - lat) + Math.Abs(23.82029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45265 - lat) + Math.Abs(25.34863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96491 - lat) + Math.Abs(23.66511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35864 - lat) + Math.Abs(24.43857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.38132 - lat) + Math.Abs(24.58257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32104 - lat) + Math.Abs(25.24422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0092 - lat) + Math.Abs(25.6617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03996 - lat) + Math.Abs(25.98059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94988 - lat) + Math.Abs(23.62309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00624 - lat) + Math.Abs(23.78373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53918 - lat) + Math.Abs(21.25923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.74387 - lat) + Math.Abs(24.42262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12723 - lat) + Math.Abs(23.78729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11643 - lat) + Math.Abs(23.98182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02544 - lat) + Math.Abs(23.87617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70592 - lat) + Math.Abs(23.6985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.37904 - lat) + Math.Abs(22.92752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06647 - lat) + Math.Abs(23.71701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12964 - lat) + Math.Abs(23.75751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06059 - lat) + Math.Abs(23.85926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0271 - lat) + Math.Abs(23.73051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69581 - lat) + Math.Abs(23.94483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85181 - lat) + Math.Abs(23.84068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82036 - lat) + Math.Abs(23.84424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80612 - lat) + Math.Abs(23.85793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93445 - lat) + Math.Abs(23.86484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71733 - lat) + Math.Abs(24.03646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04312 - lat) + Math.Abs(23.97749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97506 - lat) + Math.Abs(23.88556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02328 - lat) + Math.Abs(23.93286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02639 - lat) + Math.Abs(23.95758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82436 - lat) + Math.Abs(23.95539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99336 - lat) + Math.Abs(23.97796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96552 - lat) + Math.Abs(23.97873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97835 - lat) + Math.Abs(23.9179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20345 - lat) + Math.Abs(23.80308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30226 - lat) + Math.Abs(23.78634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08343 - lat) + Math.Abs(23.48413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02734 - lat) + Math.Abs(23.43663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99407 - lat) + Math.Abs(23.38556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79047 - lat) + Math.Abs(20.73944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46424 - lat) + Math.Abs(23.57237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58289 - lat) + Math.Abs(19.9122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59011 - lat) + Math.Abs(19.89736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64035 - lat) + Math.Abs(19.83517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66336 - lat) + Math.Abs(19.84787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7061 - lat) + Math.Abs(19.83337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8265 - lat) + Math.Abs(20.79854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75792 - lat) + Math.Abs(20.90072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9857 - lat) + Math.Abs(24.37531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89785 - lat) + Math.Abs(24.24176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93063 - lat) + Math.Abs(22.89317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90754 - lat) + Math.Abs(22.93984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86466 - lat) + Math.Abs(22.99614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10211 - lat) + Math.Abs(23.85025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90105 - lat) + Math.Abs(22.49024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.00708 - lat) + Math.Abs(22.15676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67816 - lat) + Math.Abs(20.81956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64281 - lat) + Math.Abs(20.82815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65025 - lat) + Math.Abs(20.83932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66548 - lat) + Math.Abs(20.83664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65624 - lat) + Math.Abs(20.83882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68744 - lat) + Math.Abs(20.8224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64023 - lat) + Math.Abs(20.84094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50691 - lat) + Math.Abs(21.24129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69686 - lat) + Math.Abs(21.68313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3495 - lat) + Math.Abs(23.65056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41537 - lat) + Math.Abs(23.61372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02778 - lat) + Math.Abs(22.04621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42522 - lat) + Math.Abs(25.36155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38112 - lat) + Math.Abs(22.97484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92022 - lat) + Math.Abs(21.17623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06134 - lat) + Math.Abs(25.39145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13772 - lat) + Math.Abs(25.02535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13888 - lat) + Math.Abs(25.00368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34253 - lat) + Math.Abs(21.94103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94931 - lat) + Math.Abs(24.78859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6532 - lat) + Math.Abs(22.94156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19048 - lat) + Math.Abs(22.0132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.38015 - lat) + Math.Abs(28.08285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16031 - lat) + Math.Abs(26.8248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26378 - lat) + Math.Abs(22.83855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12863 - lat) + Math.Abs(25.32546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1849;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zoodóchos", "ESYE21", 39.69153, 20.76458);
case 1: return new CityInfo("Zonianá", "ESYE43", 35.29502, 24.82944);
case 2: return new CityInfo("Zítsa", "ESYE21", 39.75439, 20.65008);
case 3: return new CityInfo("Zileftí", "ESYE14", 39.58676, 21.8194);
case 4: return new CityInfo("Zevgolateió", "ESYE25", 37.93333, 22.8);
case 5: return new CityInfo("Zevgarákion", "ESYE23", 38.5368, 21.41401);
case 6: return new CityInfo("Zéli", "ESYE24", 38.65911, 22.87499);
case 7: return new CityInfo("Zarós", "ESYE43", 35.1303, 24.90412);
case 8: return new CityInfo("Zárkos", "ESYE14", 39.6086, 22.12336);
case 9: return new CityInfo("Zárakes", "ESYE24", 38.30192, 24.19189);
case 10: return new CityInfo("Zakynthos", "ESYE22", 37.78022, 20.89555);
case 11: return new CityInfo("Zacháro", "ESYE23", 37.48333, 21.65);
case 12: return new CityInfo("Zaḯmi", "ESYE14", 39.29948, 21.93918);
case 13: return new CityInfo("Zagorá", "ESYE14", 39.45, 23.1);
case 14: return new CityInfo("Gýtheio", "ESYE25", 36.755, 22.56417);
case 15: return new CityInfo("Gymnótopos", "ESYE21", 39.28961, 20.90422);
case 16: return new CityInfo("Yimnón", "ESYE24", 38.44048, 23.884);
case 17: return new CityInfo("Giánnouli", "ESYE14", 39.66717, 22.39597);
case 18: return new CityInfo("Giáltra", "ESYE24", 38.86307, 22.9761);
case 19: return new CityInfo("Gialós", "ESYE43", 35.2391, 23.63485);
case 20: return new CityInfo("Gérgeri", "ESYE43", 35.13281, 24.94963);
case 21: return new CityInfo("Geráni", "ESYE43", 35.51721, 23.87818);
case 22: return new CityInfo("Geráni", "ESYE43", 35.35368, 24.40033);
case 23: return new CityInfo("Geráki", "ESYE25", 36.99227, 22.70663);
case 24: return new CityInfo("Georgikó", "ESYE14", 39.33234, 21.86263);
case 25: return new CityInfo("Gennadi", "ESYE42", 36.02361, 27.92326);
case 26: return new CityInfo("Gelánthi", "ESYE14", 39.43879, 21.707);
case 27: return new CityInfo("Géfyra", "ESYE25", 36.68715, 23.03509);
case 28: return new CityInfo("Xirókampos", "ESYE42", 37.111, 26.86682);
case 29: return new CityInfo("Xirókambos", "ESYE43", 35.20622, 25.70114);
case 30: return new CityInfo("Xirokámbion", "ESYE25", 36.95939, 22.45211);
case 31: return new CityInfo("Xinonéri", "ESYE14", 39.31815, 21.8602);
case 32: return new CityInfo("Xilokériza", "ESYE25", 37.88227, 22.94237);
case 33: return new CityInfo("Xylókastro", "ESYE25", 38.07762, 22.63166);
case 34: return new CityInfo("Vrontádos", "ESYE41", 38.40876, 26.12948);
case 35: return new CityInfo("Vrýses", "ESYE43", 35.37585, 24.20109);
case 36: return new CityInfo("Vrísa", "ESYE41", 39.03999, 26.20097);
case 37: return new CityInfo("Vrína", "ESYE23", 37.56901, 21.63825);
case 38: return new CityInfo("Vraná", "ESYE31", 38.12497, 23.95198);
case 39: return new CityInfo("Vrachnaíika", "ESYE23", 38.16253, 21.66693);
case 40: return new CityInfo("Vrakháti", "ESYE25", 37.95895, 22.80573);
case 41: return new CityInfo("Vouvopótamos", "ESYE21", 39.31031, 20.60897);
case 42: return new CityInfo("Ázoros", "ESYE14", 40.00058, 22.07917);
case 43: return new CityInfo("Vounoplagiá", "ESYE21", 39.69161, 20.78597);
case 44: return new CityInfo("Vouliagméni", "ESYE31", 37.81423, 23.77892);
case 45: return new CityInfo("Voúla", "ESYE31", 37.84221, 23.77651);
case 46: return new CityInfo("Vóroi", "ESYE43", 35.06815, 24.81039);
case 47: return new CityInfo("Vónitsa", "ESYE23", 38.91639, 20.88639);
case 48: return new CityInfo("Volos", "ESYE14", 39.36103, 22.94248);
case 49: return new CityInfo("Vokhaïkó", "ESYE25", 37.94843, 22.79203);
case 50: return new CityInfo("Vlachogiánni", "ESYE14", 39.74231, 22.08844);
case 51: return new CityInfo("Vlachópoulo", "ESYE25", 37.03186, 21.79158);
case 52: return new CityInfo("Vlachokerasiá", "ESYE25", 37.36801, 22.37715);
case 53: return new CityInfo("Vlachiótis", "ESYE25", 36.86094, 22.70831);
case 54: return new CityInfo("Vlacháta", "ESYE22", 38.12275, 20.62589);
case 55: return new CityInfo("Vívlos", "ESYE42", 37.05824, 25.40827);
case 56: return new CityInfo("Vytína", "ESYE25", 37.67023, 22.18347);
case 57: return new CityInfo("Výronas", "ESYE31", 37.96105, 23.753);
case 58: return new CityInfo("Vília", "ESYE31", 38.16716, 23.33659);
case 59: return new CityInfo("Aktaío", "ESYE23", 38.30444, 21.7944);
case 60: return new CityInfo("Verdikoússa", "ESYE14", 39.78175, 21.97728);
case 61: return new CityInfo("Veneráton", "ESYE43", 35.19696, 25.04042);
case 62: return new CityInfo("Vélo", "ESYE25", 37.9761, 22.75985);
case 63: return new CityInfo("Velestíno", "ESYE14", 39.38181, 22.74616);
case 64: return new CityInfo("Vágia", "ESYE24", 38.31748, 23.17752);
case 65: return new CityInfo("Vatsouniá", "ESYE14", 39.40983, 21.58569);
case 66: return new CityInfo("Vatoússa", "ESYE41", 39.22557, 26.05129);
case 67: return new CityInfo("Vathí", "ESYE24", 38.4049, 23.60332);
case 68: return new CityInfo("Vathý", "ESYE31", 37.7642, 23.48011);
case 69: return new CityInfo("Vathý", "ESYE41", 37.74692, 26.98316);
case 70: return new CityInfo("Vasilópoulo", "ESYE23", 38.59236, 21.08878);
case 71: return new CityInfo("Vasilikón", "ESYE24", 38.42586, 23.67189);
case 72: return new CityInfo("Vasilikí", "ESYE14", 39.63984, 21.70448);
case 73: return new CityInfo("Vasilíai", "ESYE43", 35.27064, 25.13783);
case 74: return new CityInfo("Varvásaina", "ESYE23", 37.67106, 21.49886);
case 75: return new CityInfo("Vartholomió", "ESYE23", 37.86219, 21.20575);
case 76: return new CityInfo("Varnávas", "ESYE31", 38.22358, 23.92307);
case 77: return new CityInfo("Vareiá", "ESYE41", 39.07941, 26.57777);
case 78: return new CityInfo("Vári", "ESYE31", 37.8332, 23.80311);
case 79: return new CityInfo("Vári", "ESYE42", 37.39859, 24.94904);
case 80: return new CityInfo("Várda", "ESYE23", 38.03058, 21.36506);
case 81: return new CityInfo("Vanáton", "ESYE22", 37.79446, 20.85188);
case 82: return new CityInfo("Marathéa", "ESYE14", 39.53008, 21.99431);
case 83: return new CityInfo("Vamvakoú", "ESYE14", 39.33708, 22.41983);
case 84: return new CityInfo("Vámos", "ESYE43", 35.407, 24.20067);
case 85: return new CityInfo("Valtinó", "ESYE14", 39.54852, 21.66031);
case 86: return new CityInfo("Valsamáta", "ESYE22", 38.176, 20.58392);
case 87: return new CityInfo("Valýra", "ESYE25", 37.16554, 21.98165);
case 88: return new CityInfo("Vaïniá", "ESYE43", 35.02496, 25.77202);
case 89: return new CityInfo("Tzermiádon", "ESYE43", 35.19899, 25.48862);
case 90: return new CityInfo("Skalokhóri", "ESYE41", 39.25894, 26.07493);
case 91: return new CityInfo("Tsoukaládhes", "ESYE22", 38.82181, 20.65511);
case 92: return new CityInfo("Tsikalariá", "ESYE43", 35.47623, 24.06274);
case 93: return new CityInfo("Tsarítsani", "ESYE14", 39.88117, 22.22758);
case 94: return new CityInfo("Tsagkaráda", "ESYE14", 39.38832, 23.17369);
case 95: return new CityInfo("Troizína", "ESYE31", 37.49727, 23.36295);
case 96: return new CityInfo("Trípoli", "ESYE25", 37.50889, 22.37944);
case 97: return new CityInfo("Trypití", "ESYE42", 36.73718, 24.42765);
case 98: return new CityInfo("Triovasálos", "ESYE42", 36.74507, 24.43329);
case 99: return new CityInfo("Tríkeri", "ESYE14", 39.10114, 23.07669);
case 100: return new CityInfo("Tríkala", "ESYE14", 39.55493, 21.76837);
case 101: return new CityInfo("Trýfos", "ESYE23", 38.82244, 21.07486);
case 102: return new CityInfo("Triandaíika", "ESYE23", 38.6553, 21.38315);
case 103: return new CityInfo("Ialysós", "ESYE42", 36.41352, 28.15516);
case 104: return new CityInfo("Traganón", "ESYE25", 37.89789, 21.31245);
case 105: return new CityInfo("Tragána", "ESYE24", 38.61977, 23.12296);
case 106: return new CityInfo("Tragákion", "ESYE22", 37.81254, 20.83241);
case 107: return new CityInfo("Tolón", "ESYE25", 37.52021, 22.8586);
case 108: return new CityInfo("Tithoréa", "ESYE24", 38.58417, 22.66765);
case 109: return new CityInfo("Týrnavos", "ESYE14", 39.73778, 22.28917);
case 110: return new CityInfo("Tínos", "ESYE42", 37.53753, 25.16343);
case 111: return new CityInfo("Tympáki", "ESYE43", 35.07286, 24.76851);
case 112: return new CityInfo("Tílisos", "ESYE43", 35.29607, 25.01587);
case 113: return new CityInfo("Thrapsanón", "ESYE43", 35.18798, 25.28091);
case 114: return new CityInfo("Thouría", "ESYE25", 37.08356, 22.04891);
case 115: return new CityInfo("Tholopotámi", "ESYE41", 38.29528, 26.07296);
case 116: return new CityInfo("Thívai", "ESYE24", 38.325, 23.31889);
case 117: return new CityInfo("Thýrio", "ESYE23", 38.85628, 20.98161);
case 118: return new CityInfo("Firá", "ESYE42", 36.42107, 25.43087);
case 119: return new CityInfo("Thymianá", "ESYE41", 38.31439, 26.13259);
case 120: return new CityInfo("Thesprotikó", "ESYE21", 39.25114, 20.78528);
case 121: return new CityInfo("Thespiés", "ESYE24", 38.303, 23.15016);
case 122: return new CityInfo("Thérmo", "ESYE23", 38.57358, 21.66628);
case 123: return new CityInfo("Theópetra", "ESYE14", 39.67386, 21.68383);
case 124: return new CityInfo("Theodóriana", "ESYE21", 39.43512, 21.20989);
case 125: return new CityInfo("Terpsithéa", "ESYE14", 39.61898, 22.35087);
case 126: return new CityInfo("Témeni", "ESYE23", 38.23707, 22.12533);
case 127: return new CityInfo("Távros", "ESYE31", 37.97064, 23.69043);
case 128: return new CityInfo("Amfithéa", "ESYE21", 39.69119, 20.86519);
case 129: return new CityInfo("Strátos", "ESYE23", 38.66735, 21.31535);
case 130: return new CityInfo("Stournaraíïka", "ESYE14", 39.45317, 21.48972);
case 131: return new CityInfo("Stoúpa", "ESYE25", 36.84371, 22.25993);
case 132: return new CityInfo("Stómio", "ESYE14", 39.86778, 22.73186);
case 133: return new CityInfo("Steíri", "ESYE24", 38.40831, 22.71162);
case 134: return new CityInfo("Stýpsi", "ESYE41", 39.31121, 26.22056);
case 135: return new CityInfo("Stimánga", "ESYE25", 37.90964, 22.70074);
case 136: return new CityInfo("Stylída", "ESYE24", 38.91667, 22.61667);
case 137: return new CityInfo("Stérnes", "ESYE43", 35.51094, 24.14616);
case 138: return new CityInfo("Stefáni", "ESYE21", 39.18072, 20.79);
case 139: return new CityInfo("Stefanovíkeio", "ESYE14", 39.46354, 22.74198);
case 140: return new CityInfo("Stavrós", "ESYE14", 39.36213, 21.97197);
case 141: return new CityInfo("Stavrós", "ESYE24", 38.89641, 22.37082);
case 142: return new CityInfo("Stavroménos Rethýmnis", "ESYE43", 35.38317, 24.59084);
case 143: return new CityInfo("Stavráki", "ESYE21", 39.65614, 20.81806);
case 144: return new CityInfo("Stános", "ESYE23", 38.80453, 21.17461);
case 145: return new CityInfo("Stamná", "ESYE23", 38.51419, 21.28181);
case 146: return new CityInfo("Stamáta", "ESYE31", 38.12546, 23.88038);
case 147: return new CityInfo("Stalós", "ESYE43", 35.50751, 23.94238);
case 148: return new CityInfo("Stalís", "ESYE43", 35.29257, 25.43292);
case 149: return new CityInfo("Spoláïta", "ESYE23", 38.69737, 21.34682);
case 150: return new CityInfo("Spílion", "ESYE43", 35.21961, 24.5341);
case 151: return new CityInfo("Spétses", "ESYE31", 37.26191, 23.15943);
case 152: return new CityInfo("Sperchógeia", "ESYE25", 37.07405, 22.06248);
case 153: return new CityInfo("Spercheiáda", "ESYE24", 38.90656, 22.12792);
case 154: return new CityInfo("Spáta", "ESYE31", 37.96163, 23.91514);
case 155: return new CityInfo("Spárti", "ESYE25", 37.07446, 22.43009);
case 156: return new CityInfo("Soúrpi", "ESYE14", 39.10319, 22.89789);
case 157: return new CityInfo("Soúda", "ESYE43", 35.48717, 24.07344);
case 158: return new CityInfo("Solomós", "ESYE25", 37.87662, 22.88911);
case 159: return new CityInfo("Sofikón", "ESYE25", 37.79412, 23.05204);
case 160: return new CityInfo("Sofádes", "ESYE14", 39.33333, 22.1);
case 161: return new CityInfo("Skoúrta", "ESYE24", 38.21412, 23.55145);
case 162: return new CityInfo("Skoulikádo", "ESYE22", 37.80117, 20.78486);
case 163: return new CityInfo("Skópelos", "ESYE14", 39.12144, 23.72686);
case 164: return new CityInfo("Skópelos", "ESYE41", 39.02922, 26.44836);
case 165: return new CityInfo("Skýros", "ESYE24", 38.90417, 24.56306);
case 166: return new CityInfo("Skiáthos", "ESYE14", 39.16227, 23.49089);
case 167: return new CityInfo("Schísma Eloúndas", "ESYE43", 35.25757, 25.72796);
case 168: return new CityInfo("Schimatári", "ESYE24", 38.35, 23.58333);
case 169: return new CityInfo("Skarmagkás", "ESYE31", 38.01133, 23.60303);
case 170: return new CityInfo("Skála Oropoú", "ESYE31", 38.31964, 23.78763);
case 171: return new CityInfo("Skalánion", "ESYE43", 35.28262, 25.18684);
case 172: return new CityInfo("Skála Foúrkas", "ESYE12", 39.99854, 23.38325);
case 173: return new CityInfo("Skála", "ESYE42", 37.32218, 26.543);
case 174: return new CityInfo("Skála", "ESYE25", 36.85, 22.66667);
case 175: return new CityInfo("Sývota", "ESYE21", 39.40728, 20.24842);
case 176: return new CityInfo("Sitia", "ESYE43", 35.20783, 26.10467);
case 177: return new CityInfo("Sísion", "ESYE43", 35.3077, 25.52021);
case 178: return new CityInfo("Synoikismós Chavaríou", "ESYE23", 37.85575, 21.38789);
case 179: return new CityInfo("Sými", "ESYE42", 36.61547, 27.83619);
case 180: return new CityInfo("Sylivainiótika", "ESYE23", 38.16139, 22.33156);
case 181: return new CityInfo("Sykoúrio", "ESYE14", 39.75947, 22.58);
case 182: return new CityInfo("Sikyón", "ESYE25", 37.9823, 22.72462);
case 183: return new CityInfo("Síkinos", "ESYE42", 36.7, 25.11667);
case 184: return new CityInfo("Sykiáda", "ESYE41", 38.46414, 26.1239);
case 185: return new CityInfo("Sykiá", "ESYE25", 36.76398, 22.94302);
case 186: return new CityInfo("Sykámino", "ESYE31", 38.30241, 23.73035);
case 187: return new CityInfo("Servotá", "ESYE14", 39.50469, 21.9075);
case 188: return new CityInfo("Sérifos", "ESYE42", 37.15397, 24.50614);
case 189: return new CityInfo("Selládes", "ESYE21", 39.1087, 21.07793);
case 190: return new CityInfo("Selínia", "ESYE31", 37.9332, 23.53147);
case 191: return new CityInfo("Selianítika", "ESYE23", 38.28216, 22.02827);
case 192: return new CityInfo("Sagiáda", "ESYE21", 39.62333, 20.19433);
case 193: return new CityInfo("Savália", "ESYE23", 37.82158, 21.29425);
case 194: return new CityInfo("Sardínia", "ESYE23", 38.89003, 21.20619);
case 195: return new CityInfo("Sarakinádhon", "ESYE22", 37.78951, 20.84825);
case 196: return new CityInfo("Samos", "ESYE41", 37.75427, 26.97699);
case 197: return new CityInfo("Sámi", "ESYE22", 38.25081, 20.64686);
case 198: return new CityInfo("Salamína", "ESYE31", 37.96427, 23.49649);
case 199: return new CityInfo("Rozená", "ESYE25", 38.11953, 22.39734);
case 200: return new CityInfo("Royítika", "ESYE23", 38.18268, 21.68414);
case 201: return new CityInfo("Roviés", "ESYE24", 38.80971, 23.23073);
case 202: return new CityInfo("Roussospíti", "ESYE43", 35.33383, 24.49468);
case 203: return new CityInfo("Roússo", "ESYE14", 39.31204, 21.90374);
case 204: return new CityInfo("Neápolis", "ESYE23", 38.67144, 21.36274);
case 205: return new CityInfo("Romírion", "ESYE22", 37.74853, 20.81828);
case 206: return new CityInfo("Rókka", "ESYE21", 39.16683, 20.94356);
case 207: return new CityInfo("Rodotópi", "ESYE21", 39.70822, 20.72656);
case 208: return new CityInfo("Rododáfni", "ESYE23", 38.26976, 22.04875);
case 209: return new CityInfo("Rodhítsa", "ESYE24", 38.88829, 22.4641);
case 210: return new CityInfo("Rodiá", "ESYE43", 35.36541, 25.02023);
case 211: return new CityInfo("Rizovoúni", "ESYE14", 39.43898, 21.86684);
case 212: return new CityInfo("Rizovoúni", "ESYE21", 39.25936, 20.81136);
case 213: return new CityInfo("Rizómylos", "ESYE14", 39.42763, 22.74717);
case 214: return new CityInfo("Rízoma", "ESYE14", 39.66432, 21.73541);
case 215: return new CityInfo("Rizarió", "ESYE14", 39.53912, 21.80116);
case 216: return new CityInfo("Río", "ESYE23", 38.29558, 21.78504);
case 217: return new CityInfo("Rethymno", "ESYE43", 35.36555, 24.48232);
case 218: return new CityInfo("Rengínion", "ESYE24", 38.71957, 22.71001);
case 219: return new CityInfo("Rentína", "ESYE14", 39.06316, 21.97895);
case 220: return new CityInfo("Ráxa", "ESYE14", 39.61056, 21.74698);
case 221: return new CityInfo("Raptópoulo", "ESYE24", 39.14861, 21.48028);
case 222: return new CityInfo("Rapsáni", "ESYE14", 39.90222, 22.54875);
case 223: return new CityInfo("Ráchi", "ESYE21", 39.11406, 20.89956);
case 224: return new CityInfo("Rákhai", "ESYE24", 38.89055, 22.78122);
case 225: return new CityInfo("Rafína", "ESYE31", 38.01812, 24.00599);
case 226: return new CityInfo("Ftéri", "ESYE24", 38.90002, 22.046);
case 227: return new CityInfo("Pteleós", "ESYE14", 39.05261, 22.95271);
case 228: return new CityInfo("Psychikó", "ESYE31", 38.01324, 23.77223);
case 229: return new CityInfo("Psathópyrgos", "ESYE23", 38.32806, 21.87367);
case 230: return new CityInfo("Psachná", "ESYE24", 38.57852, 23.64326);
case 231: return new CityInfo("Prósimna", "ESYE25", 37.71279, 22.84049);
case 232: return new CityInfo("Prokópi", "ESYE24", 38.73402, 23.4906);
case 233: return new CityInfo("Profítis Ilías", "ESYE43", 35.20555, 25.09985);
case 234: return new CityInfo("Pródromos", "ESYE14", 39.56483, 21.58944);
case 235: return new CityInfo("Pródromos", "ESYE14", 39.37571, 21.97493);
case 236: return new CityInfo("Prínos", "ESYE14", 39.56956, 21.61176);
case 237: return new CityInfo("Prinés", "ESYE43", 35.34566, 24.4251);
case 238: return new CityInfo("Préveza", "ESYE21", 38.95617, 20.7505);
case 239: return new CityInfo("Prámanta", "ESYE21", 39.52306, 21.10139);
case 240: return new CityInfo("Pournári", "ESYE14", 39.77564, 22.57578);
case 241: return new CityInfo("Poullítsa", "ESYE25", 37.95899, 22.77131);
case 242: return new CityInfo("Poullakídha", "ESYE25", 37.64883, 22.81397);
case 243: return new CityInfo("Poúlithra", "ESYE25", 37.10942, 22.88595);
case 244: return new CityInfo("Pórto Chéli", "ESYE25", 37.32786, 23.14384);
case 245: return new CityInfo("Portariá", "ESYE14", 39.3895, 22.99948);
case 246: return new CityInfo("Póros", "ESYE22", 38.15369, 20.7712);
case 247: return new CityInfo("Póros", "ESYE31", 37.49944, 23.45361);
case 248: return new CityInfo("Pómpia", "ESYE43", 35.00938, 24.86718);
case 249: return new CityInfo("Politiká", "ESYE24", 38.59673, 23.54457);
case 250: return new CityInfo("Polichnítos", "ESYE41", 39.07911, 26.18215);
case 251: return new CityInfo("Polydéndri", "ESYE31", 38.216, 23.86806);
case 252: return new CityInfo("Plomári", "ESYE41", 38.97527, 26.37137);
case 253: return new CityInfo("Plagiá", "ESYE41", 38.98243, 26.39676);
case 254: return new CityInfo("Plagiá", "ESYE23", 38.79906, 20.74056);
case 255: return new CityInfo("Platýkampos", "ESYE14", 39.61667, 22.53333);
case 256: return new CityInfo("Platariá", "ESYE21", 39.45044, 20.27781);
case 257: return new CityInfo("Plátanos", "ESYE14", 39.66061, 21.76906);
case 258: return new CityInfo("Plátanos", "ESYE23", 37.66731, 21.61108);
case 259: return new CityInfo("Plátanos", "ESYE43", 35.4731, 23.60219);
case 260: return new CityInfo("Plataiés", "ESYE24", 38.21357, 23.2675);
case 261: return new CityInfo("Plános", "ESYE22", 37.81635, 20.86437);
case 262: return new CityInfo("Pláka", "ESYE31", 37.76329, 24.02371);
case 263: return new CityInfo("Pigí", "ESYE14", 39.51061, 21.70103);
case 264: return new CityInfo("Pitsídia", "ESYE43", 35.01555, 24.78129);
case 265: return new CityInfo("Pithári", "ESYE43", 35.51672, 24.08653);
case 266: return new CityInfo("Pythagóreio", "ESYE41", 37.69102, 26.94341);
case 267: return new CityInfo("Pyrgíon", "ESYE41", 38.22628, 25.99991);
case 268: return new CityInfo("Pyrgetós", "ESYE14", 39.91869, 22.59339);
case 269: return new CityInfo("Pyrgetós", "ESYE14", 39.55276, 21.74846);
case 270: return new CityInfo("Pýrgos", "ESYE23", 37.67513, 21.44102);
case 271: return new CityInfo("Pýrgos", "ESYE43", 35.00611, 25.15191);
case 272: return new CityInfo("Piraeus", "ESYE31", 37.94203, 23.64619);
case 273: return new CityInfo("Pýlos", "ESYE25", 36.91298, 21.6965);
case 274: return new CityInfo("Pylí", "ESYE42", 36.84472, 27.15932);
case 275: return new CityInfo("Pýli", "ESYE14", 39.45806, 21.61889);
case 276: return new CityInfo("Pikérmi", "ESYE31", 38.00161, 23.94075);
case 277: return new CityInfo("Piáleia", "ESYE14", 39.50552, 21.59523);
case 278: return new CityInfo("Petroúpolis", "ESYE31", 38.04187, 23.68494);
case 279: return new CityInfo("Petrotó", "ESYE14", 39.58627, 21.96355);
case 280: return new CityInfo("Petróporo", "ESYE14", 39.5615, 21.92812);
case 281: return new CityInfo("Pétra", "ESYE41", 39.32682, 26.17648);
case 282: return new CityInfo("Pétra", "ESYE21", 39.16612, 21.11303);
case 283: return new CityInfo("Pétra", "ESYE21", 39.15708, 20.81875);
case 284: return new CityInfo("Péta", "ESYE21", 39.16667, 21.03472);
case 285: return new CityInfo("Periyiáli", "ESYE25", 37.94041, 22.83946);
case 286: return new CityInfo("Perivóli", "ESYE22", 39.41936, 20.01469);
case 287: return new CityInfo("Perivólia", "ESYE43", 35.48491, 23.99421);
case 288: return new CityInfo("Peristéri", "ESYE31", 38.01539, 23.69187);
case 289: return new CityInfo("Perdikáki", "ESYE23", 39.04931, 21.36308);
case 290: return new CityInfo("Pérdika", "ESYE21", 39.36967, 20.30419);
case 291: return new CityInfo("Pérdhika", "ESYE31", 37.69226, 23.45306);
case 292: return new CityInfo("Péran Triovasálos", "ESYE42", 36.74086, 24.43623);
case 293: return new CityInfo("Pérama", "ESYE21", 39.69331, 20.84656);
case 294: return new CityInfo("Pérama", "ESYE41", 39.04319, 26.50452);
case 295: return new CityInfo("Pérama", "ESYE31", 37.96775, 23.5721);
case 296: return new CityInfo("Pérama", "ESYE43", 35.3703, 24.70345);
case 297: return new CityInfo("Perachóra", "ESYE25", 38.03021, 22.94902);
case 298: return new CityInfo("Pentéli", "ESYE31", 38.05, 23.86667);
case 299: return new CityInfo("Pendálofon", "ESYE23", 38.48487, 21.24683);
case 300: return new CityInfo("Pelópi", "ESYE23", 37.67444, 21.59344);
case 301: return new CityInfo("Pelasgía", "ESYE24", 38.94813, 22.8398);
case 302: return new CityInfo("Pedinó", "ESYE14", 39.51823, 21.95248);
case 303: return new CityInfo("Pediní", "ESYE21", 39.59994, 20.84261);
case 304: return new CityInfo("Gáïos", "ESYE22", 39.19722, 20.18556);
case 305: return new CityInfo("Pátra", "ESYE23", 38.24444, 21.73444);
case 306: return new CityInfo("Patouliá", "ESYE14", 39.53495, 21.86465);
case 307: return new CityInfo("Pátmos", "ESYE42", 37.30895, 26.54723);
case 308: return new CityInfo("Patitírion", "ESYE14", 39.14657, 23.86494);
case 309: return new CityInfo("Pásion", "ESYE25", 38.01294, 22.72814);
case 310: return new CityInfo("Ínachos", "ESYE25", 37.66419, 22.74985);
case 311: return new CityInfo("Páros", "ESYE42", 37.08333, 25.15);
case 312: return new CityInfo("Párga", "ESYE21", 39.28572, 20.40044);
case 313: return new CityInfo("Paravóla", "ESYE23", 38.61472, 21.52046);
case 314: return new CityInfo("Proástio", "ESYE14", 39.48682, 21.90288);
case 315: return new CityInfo("Parapótamos", "ESYE21", 39.54858, 20.32436);
case 316: return new CityInfo("Paramythiá", "ESYE21", 39.47111, 20.51111);
case 317: return new CityInfo("Parálio Ástros", "ESYE25", 37.41658, 22.7661);
case 318: return new CityInfo("Paralía Avlídhos", "ESYE24", 38.38002, 23.62842);
case 319: return new CityInfo("Paralía Rachón", "ESYE24", 38.88195, 22.77723);
case 320: return new CityInfo("Paralía", "ESYE23", 38.19833, 21.70263);
case 321: return new CityInfo("Paralía Tyroú", "ESYE25", 37.2482, 22.85796);
case 322: return new CityInfo("Parákoila", "ESYE41", 39.16945, 26.14058);
case 323: return new CityInfo("Parakálamos", "ESYE21", 39.86336, 20.56469);
case 324: return new CityInfo("Pappádos", "ESYE41", 39.03905, 26.45598);
case 325: return new CityInfo("Pappadátes", "ESYE21", 39.31444, 20.79314);
case 326: return new CityInfo("Pappadhátai", "ESYE23", 38.52816, 21.45016);
case 327: return new CityInfo("Pánormos", "ESYE43", 35.41815, 24.69091);
case 328: return new CityInfo("Pantokrátor", "ESYE22", 37.73241, 20.82795);
case 329: return new CityInfo("Pandánassa", "ESYE23", 38.60151, 21.55586);
case 330: return new CityInfo("Panagioúda", "ESYE41", 39.14666, 26.5292);
case 331: return new CityInfo("Panagía", "ESYE14", 39.79616, 21.32971);
case 332: return new CityInfo("Panarítis", "ESYE25", 37.63102, 22.8235);
case 333: return new CityInfo("Panaitólion", "ESYE23", 38.58316, 21.44729);
case 334: return new CityInfo("Pámfila", "ESYE41", 39.15697, 26.5217);
case 335: return new CityInfo("Pallíni", "ESYE31", 38.00514, 23.88302);
case 336: return new CityInfo("Palioúri", "ESYE12", 39.94184, 23.66309);
case 337: return new CityInfo("Palioúri", "ESYE14", 39.22008, 21.98158);
case 338: return new CityInfo("Paliámpela", "ESYE23", 38.91075, 20.95178);
case 339: return new CityInfo("Palamás", "ESYE14", 39.46667, 22.08333);
case 340: return new CityInfo("Pálairos", "ESYE23", 38.783, 20.88183);
case 341: return new CityInfo("Palaiópyrgos", "ESYE14", 39.60845, 21.8172);
case 342: return new CityInfo("Palaió Fáliro", "ESYE31", 37.92812, 23.70105);
case 343: return new CityInfo("Palaiomonástiro", "ESYE14", 39.46269, 21.65793);
case 344: return new CityInfo("Palaiománina", "ESYE23", 38.55232, 21.24062);
case 345: return new CityInfo("Palaiokklísi", "ESYE14", 39.37662, 21.86407);
case 346: return new CityInfo("Palaiókipos", "ESYE41", 39.05563, 26.45053);
case 347: return new CityInfo("Palaiochóri", "ESYE14", 39.46982, 21.82482);
case 348: return new CityInfo("Palaióchora", "ESYE43", 35.23128, 23.68185);
case 349: return new CityInfo("Lesíni", "ESYE23", 38.45238, 21.23246);
case 350: return new CityInfo("Palaiókastro", "ESYE41", 37.73795, 27.00001);
case 351: return new CityInfo("Palekastro", "ESYE43", 35.19793, 26.25429);
case 352: return new CityInfo("Psará", "ESYE41", 38.54097, 25.56287);
case 353: return new CityInfo("Palaiá Fókaia", "ESYE31", 37.71998, 23.94792);
case 354: return new CityInfo("Palaiá Epídavros", "ESYE25", 37.63847, 23.15609);
case 355: return new CityInfo("Pachykálamos", "ESYE21", 39.08344, 21.01375);
case 356: return new CityInfo("Pacheía Ámmos", "ESYE43", 35.10896, 25.80903);
case 357: return new CityInfo("Páchi", "ESYE31", 37.97536, 23.36243);
case 358: return new CityInfo("Paianía", "ESYE31", 37.95527, 23.85443);
case 359: return new CityInfo("Pagóndas", "ESYE41", 37.67175, 26.83113);
case 360: return new CityInfo("Oxýneia", "ESYE14", 39.8264, 21.48997);
case 361: return new CityInfo("Oxílithos", "ESYE24", 38.57988, 24.11184);
case 362: return new CityInfo("Ovriá", "ESYE23", 38.18866, 21.72903);
case 363: return new CityInfo("Óssa", "ESYE14", 39.74628, 22.57844);
case 364: return new CityInfo("Oropós", "ESYE21", 39.16383, 20.71842);
case 365: return new CityInfo("Oropós", "ESYE31", 38.30326, 23.75549);
case 366: return new CityInfo("Órmos Korthíou", "ESYE42", 37.77366, 24.9504);
case 367: return new CityInfo("Orchomenós", "ESYE24", 38.4929, 22.97962);
case 368: return new CityInfo("Oreoí", "ESYE24", 38.95034, 23.09191);
case 369: return new CityInfo("Omvriakí", "ESYE24", 39.10118, 22.27106);
case 370: return new CityInfo("Omólio", "ESYE14", 39.89553, 22.64197);
case 371: return new CityInfo("Ókhthia", "ESYE23", 38.65795, 21.28532);
case 372: return new CityInfo("Oinoússes", "ESYE41", 38.51458, 26.22241);
case 373: return new CityInfo("Oinófyta", "ESYE24", 38.31163, 23.64);
case 374: return new CityInfo("Papágou", "ESYE31", 37.98642, 23.79347);
case 375: return new CityInfo("Oía", "ESYE42", 36.4626, 25.37637);
case 376: return new CityInfo("Nikiána", "ESYE22", 38.76017, 20.71876);
case 377: return new CityInfo("Níkaia", "ESYE14", 39.56667, 22.46667);
case 378: return new CityInfo("Níkaia", "ESYE31", 37.96667, 23.65);
case 379: return new CityInfo("Nidhríon", "ESYE22", 38.71013, 20.71386);
case 380: return new CityInfo("Nerokoúros", "ESYE43", 35.47587, 24.03995);
case 381: return new CityInfo("Nerántza", "ESYE25", 37.98402, 22.78178);
case 382: return new CityInfo("Néos Plátanos", "ESYE14", 39.16261, 22.79406);
case 383: return new CityInfo("Néos Pírgos", "ESYE24", 38.93575, 23.07243);
case 384: return new CityInfo("Néon Monastírion", "ESYE24", 39.23988, 22.27465);
case 385: return new CityInfo("Néo Chorío", "ESYE43", 35.42207, 24.14151);
case 386: return new CityInfo("Néon Karlovásion", "ESYE41", 37.79209, 26.7049);
case 387: return new CityInfo("Neochorópoulo", "ESYE21", 39.62553, 20.83558);
case 388: return new CityInfo("Oichalía", "ESYE14", 39.60827, 21.97996);
case 389: return new CityInfo("Neochóri", "ESYE14", 39.27408, 21.73211);
case 390: return new CityInfo("Neochóri", "ESYE21", 39.07025, 21.01892);
case 391: return new CityInfo("Neochórion", "ESYE23", 38.40847, 21.27511);
case 392: return new CityInfo("Neochóri", "ESYE41", 38.30754, 26.11332);
case 393: return new CityInfo("Neochóri", "ESYE23", 37.90794, 21.20392);
case 394: return new CityInfo("Neokaisáreia", "ESYE21", 39.58722, 20.87567);
case 395: return new CityInfo("Nénita", "ESYE41", 38.23902, 26.09341);
case 396: return new CityInfo("Neméa", "ESYE25", 37.82068, 22.66102);
case 397: return new CityInfo("Néa Tírins", "ESYE25", 37.60793, 22.81996);
case 398: return new CityInfo("Néa Stíra", "ESYE24", 38.17935, 24.20842);
case 399: return new CityInfo("Néa Smýrni", "ESYE31", 37.94504, 23.71416);
case 400: return new CityInfo("Néa Skióni", "ESYE12", 39.94661, 23.53156);
case 401: return new CityInfo("Néa Sinópi", "ESYE21", 39.08278, 20.72433);
case 402: return new CityInfo("Néa Seléfkeia", "ESYE21", 39.52461, 20.25519);
case 403: return new CityInfo("Néa Sampsoúnta", "ESYE21", 39.08889, 20.74333);
case 404: return new CityInfo("Neápoli", "ESYE43", 35.25627, 25.60415);
case 405: return new CityInfo("Néa Péramos", "ESYE31", 38.00647, 23.42348);
case 406: return new CityInfo("Néa Palátia", "ESYE31", 38.31942, 23.79649);
case 407: return new CityInfo("Néa Manoláda", "ESYE23", 38.05378, 21.38189);
case 408: return new CityInfo("Néa Mákri", "ESYE31", 38.08733, 23.97642);
case 409: return new CityInfo("Ílion", "ESYE31", 38.03333, 23.7);
case 410: return new CityInfo("Néa Lámpsakos", "ESYE24", 38.43729, 23.62824);
case 411: return new CityInfo("Néa Kíos", "ESYE25", 37.59023, 22.74342);
case 412: return new CityInfo("Néa Kerasoúnta", "ESYE21", 39.15722, 20.85719);
case 413: return new CityInfo("Néa Ionía", "ESYE31", 38.0357, 23.75733);
case 414: return new CityInfo("Néa Filadélfeia", "ESYE31", 38.03491, 23.73811);
case 415: return new CityInfo("Néa Erythraía", "ESYE31", 38.0927, 23.82223);
case 416: return new CityInfo("Néa Epídavros", "ESYE25", 37.67653, 23.12689);
case 417: return new CityInfo("Néa Avórani", "ESYE23", 38.60834, 21.44767);
case 418: return new CityInfo("Néa Artáki", "ESYE24", 38.52027, 23.63296);
case 419: return new CityInfo("Néa Anchiálos", "ESYE14", 39.28015, 22.81819);
case 420: return new CityInfo("Náxos", "ESYE42", 37.10556, 25.37639);
case 421: return new CityInfo("Náfplio", "ESYE25", 37.56863, 22.80691);
case 422: return new CityInfo("Náfpaktos", "ESYE23", 38.39167, 21.8275);
case 423: return new CityInfo("Náousa", "ESYE42", 37.12181, 25.24014);
case 424: return new CityInfo("Mouzourás", "ESYE43", 35.53885, 24.15554);
case 425: return new CityInfo("Mouzáki", "ESYE14", 39.42972, 21.66361);
case 426: return new CityInfo("Mouzaki", "ESYE22", 37.73565, 20.82291);
case 427: return new CityInfo("Kallithea - Moustafádhes", "ESYE24", 38.31122, 23.43916);
case 428: return new CityInfo("Mourniés", "ESYE43", 35.48228, 24.01253);
case 429: return new CityInfo("Mouriá", "ESYE14", 39.48893, 21.71751);
case 430: return new CityInfo("Moúlki", "ESYE25", 37.99319, 22.72531);
case 431: return new CityInfo("Moskhokhórion", "ESYE24", 38.82814, 22.44807);
case 432: return new CityInfo("Moskháton", "ESYE31", 37.94789, 23.6788);
case 433: return new CityInfo("Mória", "ESYE41", 39.13248, 26.51698);
case 434: return new CityInfo("Morfovoúni", "ESYE14", 39.3525, 21.75);
case 435: return new CityInfo("Monodhéndrion", "ESYE23", 38.17229, 21.67974);
case 436: return new CityInfo("Monastiráki", "ESYE23", 38.85053, 20.94458);
case 437: return new CityInfo("Mólos", "ESYE24", 38.80998, 22.64544);
case 438: return new CityInfo("Moláoi", "ESYE25", 36.80757, 22.85132);
case 439: return new CityInfo("Mokhós", "ESYE43", 35.26342, 25.42305);
case 440: return new CityInfo("Moíres", "ESYE43", 35.05143, 24.8733);
case 441: return new CityInfo("Mitrópoli", "ESYE14", 39.33933, 21.83751);
case 442: return new CityInfo("Mytilinioí", "ESYE41", 37.72716, 26.90747);
case 443: return new CityInfo("Mytilene", "ESYE41", 39.10772, 26.55529);
case 444: return new CityInfo("Mýtikas", "ESYE21", 38.99744, 20.70639);
case 445: return new CityInfo("Mýtikas", "ESYE23", 38.66883, 20.94535);
case 446: return new CityInfo("Mytikas", "ESYE24", 38.44373, 23.65365);
case 447: return new CityInfo("Míthymna", "ESYE41", 39.36781, 26.17639);
case 448: return new CityInfo("Myrtiá", "ESYE23", 37.71397, 21.34919);
case 449: return new CityInfo("Myrsíni", "ESYE23", 37.92117, 21.237);
case 450: return new CityInfo("Mýrina", "ESYE14", 39.40769, 21.96301);
case 451: return new CityInfo("Mýrina", "ESYE41", 39.87483, 25.06359);
case 452: return new CityInfo("Mindilóglion", "ESYE23", 38.18387, 21.70133);
case 453: return new CityInfo("Mílos", "ESYE42", 36.74536, 24.4265);
case 454: return new CityInfo("Mýloi", "ESYE25", 37.55276, 22.71658);
case 455: return new CityInfo("Miléai", "ESYE14", 39.32713, 23.15171);
case 456: return new CityInfo("Mikrón Vathí", "ESYE24", 38.44046, 23.59282);
case 457: return new CityInfo("Mikrománi", "ESYE25", 37.07707, 22.03235);
case 458: return new CityInfo("Mikrokhórion", "ESYE31", 38.23366, 23.89333);
case 459: return new CityInfo("Mikrá Mantíneia", "ESYE25", 36.9861, 22.15337);
case 460: return new CityInfo("Mykonos", "ESYE42", 37.44529, 25.32872);
case 461: return new CityInfo("Megísti", "ESYE42", 36.14889, 29.59361);
case 462: return new CityInfo("Mexiátai", "ESYE24", 38.88298, 22.31355);
case 463: return new CityInfo("Metsovo", "ESYE21", 39.76944, 21.18222);
case 464: return new CityInfo("Metóchi", "ESYE23", 38.12546, 21.39966);
case 465: return new CityInfo("Metókhion", "ESYE25", 37.60787, 22.94593);
case 466: return new CityInfo("Methóni", "ESYE25", 36.81973, 21.70486);
case 467: return new CityInfo("Méthana", "ESYE31", 37.58131, 23.39016);
case 468: return new CityInfo("Áyios Andréas", "ESYE23", 38.52641, 21.55415);
case 469: return new CityInfo("Messíni", "ESYE25", 37.05111, 22.00778);
case 470: return new CityInfo("Mesótopos", "ESYE41", 39.13086, 26.00361);
case 471: return new CityInfo("Mesopótamo", "ESYE21", 39.23758, 20.52958);
case 472: return new CityInfo("Mesolóngi", "ESYE23", 38.37138, 21.43151);
case 473: return new CityInfo("Mesariá", "ESYE42", 36.39893, 25.44807);
case 474: return new CityInfo("Mesagrós", "ESYE41", 39.03634, 26.44531);
case 475: return new CityInfo("Mesagrós", "ESYE31", 37.75658, 23.51688);
case 476: return new CityInfo("Agía Triáda", "ESYE14", 39.46361, 21.89848);
case 477: return new CityInfo("Menídi", "ESYE23", 39.04213, 21.11875);
case 478: return new CityInfo("Melívoia", "ESYE14", 39.75014, 22.79532);
case 479: return new CityInfo("Melissourgoí", "ESYE21", 39.50881, 21.14614);
case 480: return new CityInfo("Melíssi", "ESYE25", 38.04775, 22.68479);
case 481: return new CityInfo("Melíssia", "ESYE31", 38.05, 23.83333);
case 482: return new CityInfo("Meligalás", "ESYE25", 37.21667, 21.96667);
case 483: return new CityInfo("Megárchis", "ESYE14", 39.61065, 21.64324);
case 484: return new CityInfo("Megárchi", "ESYE21", 39.13729, 21.06968);
case 485: return new CityInfo("Mégara", "ESYE31", 37.99471, 23.34324);
case 486: return new CityInfo("Megalópoli", "ESYE25", 37.40111, 22.14222);
case 487: return new CityInfo("Megálo Chorió", "ESYE42", 36.45505, 27.34563);
case 488: return new CityInfo("Megalochóri", "ESYE14", 39.55982, 21.84195);
case 489: return new CityInfo("Méga Kefalóvryso", "ESYE14", 39.58917, 21.7284);
case 490: return new CityInfo("Megáli Vrísi", "ESYE24", 38.89407, 22.47511);
case 491: return new CityInfo("Megáli Khóra", "ESYE23", 38.64629, 21.37309);
case 492: return new CityInfo("Megála Kalývia", "ESYE14", 39.49693, 21.78802);
case 493: return new CityInfo("Mazarakiá", "ESYE21", 39.41803, 20.37483);
case 494: return new CityInfo("Mavrommáti", "ESYE14", 39.42386, 21.69379);
case 495: return new CityInfo("Mataránga", "ESYE23", 38.52359, 21.47325);
case 496: return new CityInfo("Martínon", "ESYE24", 38.56817, 23.21458);
case 497: return new CityInfo("Mármaro", "ESYE41", 38.54323, 26.10862);
case 498: return new CityInfo("Marmárion", "ESYE24", 38.04839, 24.32039);
case 499: return new CityInfo("Mármara", "ESYE21", 39.65514, 20.79608);
case 500: return new CityInfo("Markópoulo Oropoú", "ESYE31", 38.2898, 23.82475);
case 501: return new CityInfo("Markópoulo", "ESYE31", 37.88333, 23.93333);
case 502: return new CityInfo("Margaríti", "ESYE21", 39.35825, 20.43886);
case 503: return new CityInfo("Marathópolis", "ESYE25", 37.05799, 21.57887);
case 504: return new CityInfo("Marathónas", "ESYE31", 38.15317, 23.96278);
case 505: return new CityInfo("Marathókampos", "ESYE41", 37.72674, 26.68964);
case 506: return new CityInfo("Manoláda", "ESYE23", 38.04708, 21.34814);
case 507: return new CityInfo("Mánesis", "ESYE25", 37.66065, 22.82564);
case 508: return new CityInfo("Mandráki", "ESYE42", 36.61139, 27.13333);
case 509: return new CityInfo("Mándra", "ESYE14", 39.61542, 22.26028);
case 510: return new CityInfo("Mándra", "ESYE31", 38.06667, 23.5);
case 511: return new CityInfo("Mantoúdi", "ESYE24", 38.79808, 23.47967);
case 512: return new CityInfo("Mantamádos", "ESYE41", 39.31003, 26.33629);
case 513: return new CityInfo("Mália", "ESYE43", 35.28367, 25.46262);
case 514: return new CityInfo("Malesína", "ESYE24", 38.62225, 23.2337);
case 515: return new CityInfo("Malakónta", "ESYE24", 38.4, 23.76667);
case 516: return new CityInfo("Malakási", "ESYE14", 39.78168, 21.28399);
case 517: return new CityInfo("Malakása", "ESYE31", 38.23789, 23.801);
case 518: return new CityInfo("Makrísia", "ESYE23", 37.60957, 21.60509);
case 519: return new CityInfo("Makrinítsa", "ESYE14", 39.40131, 22.98727);
case 520: return new CityInfo("Makrychóri", "ESYE14", 39.8, 22.48333);
case 521: return new CityInfo("Makrychóri", "ESYE14", 39.43978, 21.96582);
case 522: return new CityInfo("Makrikápa", "ESYE24", 38.61667, 23.75);
case 523: return new CityInfo("Makrakómi", "ESYE24", 38.9415, 22.11535);
case 524: return new CityInfo("Makhairádhon", "ESYE22", 37.75806, 20.81017);
case 525: return new CityInfo("Magoulítsa", "ESYE14", 39.43911, 21.75977);
case 526: return new CityInfo("Magoúla", "ESYE24", 38.41178, 23.82128);
case 527: return new CityInfo("Magoúla", "ESYE31", 38.07989, 23.52108);
case 528: return new CityInfo("Magoúla", "ESYE25", 37.08007, 22.40469);
case 529: return new CityInfo("Artémida", "ESYE31", 37.96727, 23.99684);
case 530: return new CityInfo("Loutró", "ESYE14", 39.967, 21.93369);
case 531: return new CityInfo("Loutráki", "ESYE25", 37.9783, 22.97781);
case 532: return new CityInfo("Loutrá Aidhipsoú", "ESYE24", 38.85695, 23.04739);
case 533: return new CityInfo("Loutrá", "ESYE41", 39.05695, 26.54476);
case 534: return new CityInfo("Loúros", "ESYE21", 39.166, 20.75608);
case 535: return new CityInfo("Loukísia", "ESYE24", 38.47946, 23.44796);
case 536: return new CityInfo("Lóngos", "ESYE23", 38.29472, 22.02145);
case 537: return new CityInfo("Longádes", "ESYE21", 39.65936, 20.93908);
case 538: return new CityInfo("Longá", "ESYE25", 36.86881, 21.90667);
case 539: return new CityInfo("Lixoúri", "ESYE22", 38.20133, 20.43706);
case 540: return new CityInfo("Livanátes", "ESYE24", 38.711, 23.0503);
case 541: return new CityInfo("Livádion", "ESYE42", 37.14602, 24.51475);
case 542: return new CityInfo("Lithakiá", "ESYE22", 37.71935, 20.83013);
case 543: return new CityInfo("Leipsoí", "ESYE42", 37.28333, 26.76667);
case 544: return new CityInfo("Limnokhórion", "ESYE23", 38.14115, 21.48047);
case 545: return new CityInfo("Límni", "ESYE24", 38.76667, 23.31667);
case 546: return new CityInfo("Límnes", "ESYE25", 37.71408, 22.88023);
case 547: return new CityInfo("Limín Mesoyaías", "ESYE31", 37.89108, 24.00307);
case 548: return new CityInfo("Limín Khersonísou", "ESYE43", 35.32297, 25.39275);
case 549: return new CityInfo("Lykóvrysi", "ESYE31", 38.06933, 23.78223);
case 550: return new CityInfo("Likoporiá", "ESYE25", 38.12747, 22.50704);
case 551: return new CityInfo("Ligourión", "ESYE25", 37.61233, 23.03773);
case 552: return new CityInfo("Lygariá", "ESYE14", 39.49454, 21.68392);
case 553: return new CityInfo("Lidoríki", "ESYE24", 38.52389, 22.19972);
case 554: return new CityInfo("Lianokládhion", "ESYE24", 38.91655, 22.30336);
case 555: return new CityInfo("Lefkímmi", "ESYE22", 39.42336, 20.07094);
case 556: return new CityInfo("Lefkáda", "ESYE22", 38.83036, 20.70442);
case 557: return new CityInfo("Lefkákia", "ESYE25", 37.55988, 22.86072);
case 558: return new CityInfo("Levídion", "ESYE25", 37.68269, 22.29586);
case 559: return new CityInfo("Livadeiá", "ESYE24", 38.43616, 22.87665);
case 560: return new CityInfo("Lepenoú", "ESYE23", 38.70839, 21.2897);
case 561: return new CityInfo("Leonídio", "ESYE25", 37.16679, 22.85773);
case 562: return new CityInfo("Leondárion", "ESYE31", 37.987, 23.85518);
case 563: return new CityInfo("Lékhaio", "ESYE25", 37.93279, 22.85002);
case 564: return new CityInfo("Lechainá", "ESYE23", 37.93333, 21.26667);
case 565: return new CityInfo("Lazarína", "ESYE14", 39.46237, 21.73789);
case 566: return new CityInfo("Lazaráta", "ESYE22", 38.77771, 20.6676);
case 567: return new CityInfo("Lávrio", "ESYE31", 37.71445, 24.05647);
case 568: return new CityInfo("Lárisa", "ESYE14", 39.63689, 22.41761);
case 569: return new CityInfo("Lárimna", "ESYE24", 38.56555, 23.28484);
case 570: return new CityInfo("Lápas", "ESYE23", 38.09755, 21.41861);
case 571: return new CityInfo("Langádhia", "ESYE25", 37.68186, 22.03002);
case 572: return new CityInfo("Lagkáda", "ESYE41", 38.47825, 26.12427);
case 573: return new CityInfo("Lamía", "ESYE24", 38.9, 22.43333);
case 574: return new CityInfo("Láloukas", "ESYE25", 37.62786, 22.78449);
case 575: return new CityInfo("Lálas", "ESYE23", 37.70936, 21.72117);
case 576: return new CityInfo("Lakkopetra", "ESYE23", 38.17182, 21.45607);
case 577: return new CityInfo("Lakkí", "ESYE42", 37.13344, 26.85237);
case 578: return new CityInfo("Laíika", "ESYE25", 37.06174, 22.09602);
case 579: return new CityInfo("Krousón", "ESYE43", 35.23062, 24.98291);
case 580: return new CityInfo("Krokeés", "ESYE25", 36.88297, 22.54683);
case 581: return new CityInfo("Taxiárches", "ESYE14", 39.57565, 21.89245);
case 582: return new CityInfo("Kritsá", "ESYE43", 35.15821, 25.64459);
case 583: return new CityInfo("Kryonéri", "ESYE31", 38.13712, 23.83055);
case 584: return new CityInfo("Krionérion", "ESYE25", 37.96308, 22.63638);
case 585: return new CityInfo("Kríni", "ESYE14", 39.61501, 22.01188);
case 586: return new CityInfo("Krínes", "ESYE25", 37.96592, 22.76093);
case 587: return new CityInfo("Kríkellos", "ESYE23", 38.94532, 21.1791);
case 588: return new CityInfo("Krýa Vrýsi", "ESYE14", 39.32352, 21.87367);
case 589: return new CityInfo("Kréstena", "ESYE23", 37.59193, 21.62034);
case 590: return new CityInfo("Kranídi", "ESYE25", 37.37974, 23.15969);
case 591: return new CityInfo("Kraniá Elassónas", "ESYE14", 39.95094, 21.97078);
case 592: return new CityInfo("Kraniá", "ESYE13", 39.89712, 21.2811);
case 593: return new CityInfo("Kraniá", "ESYE14", 39.44594, 21.83454);
case 594: return new CityInfo("Kranéa", "ESYE21", 39.24672, 20.74711);
case 595: return new CityInfo("Kouvarás", "ESYE31", 37.82711, 23.96715);
case 596: return new CityInfo("Koutsourás", "ESYE43", 35.03344, 25.94731);
case 597: return new CityInfo("Koutsounári", "ESYE43", 35.01487, 25.82939);
case 598: return new CityInfo("Koutsopódi", "ESYE25", 37.68426, 22.71355);
case 599: return new CityInfo("Koutselió", "ESYE21", 39.58808, 20.91197);
case 600: return new CityInfo("Skoutáros", "ESYE41", 39.29243, 26.13399);
case 601: return new CityInfo("Metamórfosi", "ESYE31", 38.06576, 23.76356);
case 602: return new CityInfo("Kostakioí", "ESYE21", 39.13672, 20.95761);
case 603: return new CityInfo("Kosmirá", "ESYE21", 39.59157, 20.8051);
case 604: return new CityInfo("Kos", "ESYE42", 36.89295, 27.28768);
case 605: return new CityInfo("Koropí", "ESYE31", 37.89886, 23.87181);
case 606: return new CityInfo("Kóronos", "ESYE42", 37.11833, 25.53578);
case 607: return new CityInfo("Koróni", "ESYE25", 36.79526, 21.95794);
case 608: return new CityInfo("Kórinthos", "ESYE25", 37.94007, 22.9513);
case 609: return new CityInfo("Domvraína", "ESYE24", 38.253, 22.98211);
case 610: return new CityInfo("Korakovoúni", "ESYE25", 37.34952, 22.74714);
case 611: return new CityInfo("ArchaÍes Kleonés", "ESYE25", 37.82259, 22.75069);
case 612: return new CityInfo("Komméno", "ESYE21", 39.04708, 21.032);
case 613: return new CityInfo("Kompóti", "ESYE21", 39.10255, 21.08389);
case 614: return new CityInfo("Kompotádes", "ESYE24", 38.86756, 22.34795);
case 615: return new CityInfo("Kolympári", "ESYE43", 35.54115, 23.77995);
case 616: return new CityInfo("Kokkónion", "ESYE25", 37.97061, 22.78018);
case 617: return new CityInfo("Kókkinon", "ESYE24", 38.47503, 23.23883);
case 618: return new CityInfo("Kokkíni Cháni", "ESYE43", 35.32827, 25.2581);
case 619: return new CityInfo("Kokkári", "ESYE41", 37.77908, 26.89179);
case 620: return new CityInfo("Koiláda", "ESYE14", 39.57356, 22.30361);
case 621: return new CityInfo("Koilás", "ESYE25", 37.4123, 23.12553);
case 622: return new CityInfo("Klénia", "ESYE25", 37.78772, 22.86158);
case 623: return new CityInfo("Kivéri", "ESYE25", 37.52372, 22.72981);
case 624: return new CityInfo("Kýthnos", "ESYE42", 37.41237, 24.43068);
case 625: return new CityInfo("Kýthira", "ESYE31", 36.14955, 22.98979);
case 626: return new CityInfo("Kíssamos", "ESYE43", 35.49459, 23.65375);
case 627: return new CityInfo("Kírra", "ESYE24", 38.42944, 22.44443);
case 628: return new CityInfo("Kyriáki", "ESYE24", 38.35365, 22.78841);
case 629: return new CityInfo("Kyrás Vrýsi", "ESYE25", 37.91295, 22.98651);
case 630: return new CityInfo("Kipséli", "ESYE31", 38.00288, 23.73755);
case 631: return new CityInfo("Kipséli", "ESYE22", 37.81886, 20.82259);
case 632: return new CityInfo("Kypséli", "ESYE31", 37.76021, 23.45448);
case 633: return new CityInfo("Kyparissía", "ESYE25", 37.25111, 21.67361);
case 634: return new CityInfo("Kinéta", "ESYE31", 37.96843, 23.21351);
case 635: return new CityInfo("Kímolos", "ESYE42", 36.79368, 24.57577);
case 636: return new CityInfo("Kými", "ESYE24", 38.63477, 24.10287);
case 637: return new CityInfo("Kyllíni", "ESYE23", 37.93542, 21.14503);
case 638: return new CityInfo("Kifisiá", "ESYE31", 38.07438, 23.81106);
case 639: return new CityInfo("Kiáto", "ESYE25", 38.01321, 22.74839);
case 640: return new CityInfo("Chrysomiliá", "ESYE14", 39.60749, 21.50133);
case 641: return new CityInfo("Chóra Sfakíon", "ESYE43", 35.20176, 24.13711);
case 642: return new CityInfo("Chóra", "ESYE41", 37.70374, 26.90454);
case 643: return new CityInfo("Chóra", "ESYE25", 37.05106, 21.7169);
case 644: return new CityInfo("Cholargós", "ESYE31", 38, 23.8);
case 645: return new CityInfo("Chios", "ESYE41", 38.36875, 26.13718);
case 646: return new CityInfo("Khiliomódhi", "ESYE25", 37.81016, 22.86972);
case 647: return new CityInfo("Khersónisos", "ESYE43", 35.30777, 25.37159);
case 648: return new CityInfo("Chávari", "ESYE23", 37.84842, 21.38403);
case 649: return new CityInfo("Chaniotis", "ESYE12", 39.99908, 23.58001);
case 650: return new CityInfo("Chaniá", "ESYE43", 35.51124, 24.02921);
case 651: return new CityInfo("Khalkoútsion", "ESYE31", 38.33263, 23.73188);
case 652: return new CityInfo("Chalkída", "ESYE24", 38.46354, 23.60284);
case 653: return new CityInfo("Chalkeió", "ESYE41", 38.33335, 26.09845);
case 654: return new CityInfo("Chalkiádes", "ESYE21", 39.15981, 20.93292);
case 655: return new CityInfo("Chálki", "ESYE14", 39.56853, 22.54017);
case 656: return new CityInfo("Chálki", "ESYE42", 36.22243, 27.61191);
case 657: return new CityInfo("Chalandrítsa", "ESYE23", 38.10843, 21.78349);
case 658: return new CityInfo("Khalándrion", "ESYE31", 38.02369, 23.80068);
case 659: return new CityInfo("Chairóneia", "ESYE24", 38.49551, 22.84424);
case 660: return new CityInfo("Chaïdári", "ESYE31", 38.01135, 23.66597);
case 661: return new CityInfo("Keratsíni", "ESYE31", 37.9625, 23.61972);
case 662: return new CityInfo("Keratéa", "ESYE31", 37.80585, 23.9774);
case 663: return new CityInfo("Kerasochóri", "ESYE24", 39.00556, 21.63778);
case 664: return new CityInfo("Kerámion", "ESYE41", 39.21633, 26.20724);
case 665: return new CityInfo("Kentrí", "ESYE43", 35.03258, 25.7528);
case 666: return new CityInfo("Kefalóvryso", "ESYE14", 39.58096, 21.69298);
case 667: return new CityInfo("Kéfalos", "ESYE42", 36.74507, 26.95961);
case 668: return new CityInfo("Kefalári", "ESYE25", 37.59852, 22.69114);
case 669: return new CityInfo("Kéa", "ESYE42", 37.63333, 24.35);
case 670: return new CityInfo("Kavrochóri", "ESYE43", 35.30812, 25.04651);
case 671: return new CityInfo("Kavoúsi", "ESYE43", 35.12271, 25.85804);
case 672: return new CityInfo("Kávos", "ESYE22", 39.39025, 20.10781);
case 673: return new CityInfo("Kavásila", "ESYE23", 37.87581, 21.26422);
case 674: return new CityInfo("Katsikás", "ESYE21", 39.62281, 20.88758);
case 675: return new CityInfo("Katoúna", "ESYE23", 38.78547, 21.11417);
case 676: return new CityInfo("Káto Trítos", "ESYE41", 39.08615, 26.43288);
case 677: return new CityInfo("Káto Tithoréa", "ESYE24", 38.60751, 22.71348);
case 678: return new CityInfo("Káto Soúlion", "ESYE31", 38.16803, 24.01628);
case 679: return new CityInfo("Káto Pitsá", "ESYE25", 38.10897, 22.53472);
case 680: return new CityInfo("Káto Panagía", "ESYE23", 37.92995, 21.14714);
case 681: return new CityInfo("Káto Mazaráki", "ESYE23", 38.07035, 21.65097);
case 682: return new CityInfo("Káto Makrinoú", "ESYE23", 38.48672, 21.62551);
case 683: return new CityInfo("Káto Lekhónia", "ESYE14", 39.33091, 23.03957);
case 684: return new CityInfo("Káto Chorió", "ESYE43", 35.04862, 25.79081);
case 685: return new CityInfo("Katochí", "ESYE23", 38.41237, 21.25258);
case 686: return new CityInfo("Káto Kalésia", "ESYE43", 35.28634, 25.05612);
case 687: return new CityInfo("Káto Glykóvrysi", "ESYE25", 36.82791, 22.77732);
case 688: return new CityInfo("Káto Dhiminió", "ESYE25", 38.0249, 22.73294);
case 689: return new CityInfo("Káto Ássos", "ESYE25", 37.94749, 22.8303);
case 690: return new CityInfo("Káto Asítai", "ESYE43", 35.20271, 24.99827);
case 691: return new CityInfo("Káto Arachovítika", "ESYE23", 38.32903, 21.84254);
case 692: return new CityInfo("Káto Almyrí", "ESYE25", 37.8487, 23.0032);
case 693: return new CityInfo("Káto Achaḯa", "ESYE23", 38.15, 21.55);
case 694: return new CityInfo("Katastárion", "ESYE22", 37.83012, 20.75755);
case 695: return new CityInfo("Katákolo", "ESYE23", 37.65597, 21.31742);
case 696: return new CityInfo("Kástron", "ESYE24", 38.49374, 23.16008);
case 697: return new CityInfo("Kastrítsa", "ESYE21", 39.63067, 20.92183);
case 698: return new CityInfo("Kastrí", "ESYE21", 39.55239, 20.27403);
case 699: return new CityInfo("Kastrí", "ESYE43", 34.8346, 24.08572);
case 700: return new CityInfo("Kastráki", "ESYE14", 39.71692, 21.61865);
case 701: return new CityInfo("Kastráki", "ESYE24", 38.41672, 21.89646);
case 702: return new CityInfo("Kastélli", "ESYE43", 35.20902, 25.33773);
case 703: return new CityInfo("Kastélla", "ESYE24", 38.57048, 23.63131);
case 704: return new CityInfo("Karpochóri", "ESYE14", 39.33575, 22.01129);
case 705: return new CityInfo("Karperó", "ESYE13", 39.94715, 21.61865);
case 706: return new CityInfo("Karpenísi", "ESYE24", 38.91218, 21.79836);
case 707: return new CityInfo("Karpathos", "ESYE42", 35.50701, 27.21322);
case 708: return new CityInfo("Kárystos", "ESYE24", 38.01333, 24.41611);
case 709: return new CityInfo("Kariótika Karyás", "ESYE25", 38.06402, 22.64739);
case 710: return new CityInfo("Kariótai", "ESYE22", 38.79845, 20.71498);
case 711: return new CityInfo("Karyés", "ESYE41", 38.39121, 26.09643);
case 712: return new CityInfo("Karyés", "ESYE25", 37.29119, 22.50066);
case 713: return new CityInfo("Karyá", "ESYE22", 38.7588, 20.64915);
case 714: return new CityInfo("Karditsomagoúla", "ESYE14", 39.39061, 21.9233);
case 715: return new CityInfo("Kardítsa", "ESYE14", 39.36485, 21.92191);
case 716: return new CityInfo("Kardamýli", "ESYE25", 36.88778, 22.23317);
case 717: return new CityInfo("Kardámyla", "ESYE41", 38.5285, 26.09242);
case 718: return new CityInfo("Kardamás", "ESYE23", 37.76729, 21.33946);
case 719: return new CityInfo("Kardámaina", "ESYE42", 36.78305, 27.14289);
case 720: return new CityInfo("Karavómilos", "ESYE24", 38.88893, 22.70784);
case 721: return new CityInfo("Karátoula", "ESYE23", 37.73564, 21.53578);
case 722: return new CityInfo("Karaïskákis", "ESYE23", 38.58145, 21.09169);
case 723: return new CityInfo("Pefkochóri", "ESYE12", 39.98784, 23.61219);
case 724: return new CityInfo("Kápi", "ESYE41", 39.33386, 26.31092);
case 725: return new CityInfo("Kaparéllion", "ESYE24", 38.23697, 23.21411);
case 726: return new CityInfo("Kapandríti", "ESYE31", 38.21579, 23.87938);
case 727: return new CityInfo("Kandíla", "ESYE23", 38.70564, 20.94749);
case 728: return new CityInfo("Kandíla", "ESYE25", 37.77246, 22.37917);
case 729: return new CityInfo("Kanaláki", "ESYE21", 39.23361, 20.6);
case 730: return new CityInfo("Kanáli", "ESYE21", 39.07044, 20.70039);
case 731: return new CityInfo("Kanália", "ESYE14", 39.49928, 22.88589);
case 732: return new CityInfo("Kanália", "ESYE14", 39.39847, 21.79961);
case 733: return new CityInfo("Kamínia", "ESYE23", 38.14995, 21.62298);
case 734: return new CityInfo("Kaména Voúrla", "ESYE24", 38.77844, 22.78573);
case 735: return new CityInfo("Kámbos", "ESYE42", 37.3529, 26.55758);
case 736: return new CityInfo("Kampí", "ESYE21", 39.21753, 20.89994);
case 737: return new CityInfo("Kamaterón", "ESYE31", 38.05586, 23.70515);
case 738: return new CityInfo("Kamaroúla", "ESYE23", 38.63008, 21.44553);
case 739: return new CityInfo("Kamári", "ESYE25", 38.09276, 22.58223);
case 740: return new CityInfo("Kamárai", "ESYE23", 38.29881, 21.99892);
case 741: return new CityInfo("Kalpáki", "ESYE21", 39.88778, 20.62389);
case 742: return new CityInfo("Kalóvatos", "ESYE21", 39.12706, 20.91781);
case 743: return new CityInfo("Kalochóri - Panteíchi", "ESYE24", 38.38811, 23.59598);
case 744: return new CityInfo("Kalomoíra", "ESYE14", 39.75013, 21.41136);
case 745: return new CityInfo("Kalogrianá", "ESYE14", 39.4651, 21.87322);
case 746: return new CityInfo("Kalloní", "ESYE41", 39.23318, 26.20724);
case 747: return new CityInfo("Kalloní", "ESYE31", 37.53875, 23.28873);
case 748: return new CityInfo("Kallíthiro", "ESYE14", 39.28099, 21.90491);
case 749: return new CityInfo("Kallithéa", "ESYE31", 37.95, 23.7);
case 750: return new CityInfo("Kallithéa", "ESYE23", 37.55167, 21.81989);
case 751: return new CityInfo("Kallimasiá", "ESYE41", 38.29352, 26.10214);
case 752: return new CityInfo("Kallifóni", "ESYE14", 39.27712, 21.96128);
case 753: return new CityInfo("Kalývia Thorikoú", "ESYE31", 37.83894, 23.92505);
case 754: return new CityInfo("Kalývia", "ESYE23", 38.61741, 21.29232);
case 755: return new CityInfo("Kalýves", "ESYE43", 35.45046, 24.17507);
case 756: return new CityInfo("Kalipádhon", "ESYE22", 37.80083, 20.83789);
case 757: return new CityInfo("Kálymnos", "ESYE42", 36.9503, 26.98388);
case 758: return new CityInfo("Kalávryta", "ESYE23", 38.03222, 22.1125);
case 759: return new CityInfo("Kalá Nerá", "ESYE14", 39.30599, 23.1209);
case 760: return new CityInfo("Kalándra", "ESYE12", 39.97099, 23.40061);
case 761: return new CityInfo("Kalamotí", "ESYE41", 38.23415, 26.04535);
case 762: return new CityInfo("Kálamos", "ESYE31", 38.28447, 23.86308);
case 763: return new CityInfo("Kalamiá", "ESYE21", 39.16528, 20.93206);
case 764: return new CityInfo("Kalampáka", "ESYE14", 39.70444, 21.62694);
case 765: return new CityInfo("Kalamata", "ESYE25", 37.03913, 22.11265);
case 766: return new CityInfo("Álimos", "ESYE31", 37.91033, 23.72361);
case 767: return new CityInfo("Kalamákion", "ESYE22", 37.74174, 20.90286);
case 768: return new CityInfo("Kaisarianí", "ESYE31", 37.9634, 23.76523);
case 769: return new CityInfo("Kainoúryion", "ESYE24", 38.79283, 22.7247);
case 770: return new CityInfo("Kainoúryion", "ESYE23", 38.60453, 21.48776);
case 771: return new CityInfo("Itháki", "ESYE22", 38.36421, 20.71848);
case 772: return new CityInfo("Itéa", "ESYE14", 39.45669, 22.16577);
case 773: return new CityInfo("Itéa", "ESYE24", 38.43201, 22.42443);
case 774: return new CityInfo("Istiaía", "ESYE24", 38.9552, 23.1521);
case 775: return new CityInfo("Isthmía", "ESYE25", 37.91356, 23.0046);
case 776: return new CityInfo("Irákleio", "ESYE31", 38.05282, 23.76523);
case 777: return new CityInfo("Irákleion", "ESYE43", 35.32787, 25.14341);
case 778: return new CityInfo("Íos", "ESYE42", 36.73333, 25.28333);
case 779: return new CityInfo("Ioánnina", "ESYE21", 39.66486, 20.85189);
case 780: return new CityInfo("Iliókastron", "ESYE25", 37.44461, 23.26707);
case 781: return new CityInfo("Iliókali", "ESYE21", 39.61758, 20.9675);
case 782: return new CityInfo("Igoumenítsa", "ESYE21", 39.50342, 20.26728);
case 783: return new CityInfo("Ierápetra", "ESYE43", 35.01186, 25.74234);
case 784: return new CityInfo("Ýdra", "ESYE31", 37.34976, 23.4656);
case 785: return new CityInfo("Grizáno", "ESYE14", 39.63192, 22.05258);
case 786: return new CityInfo("Grammenítsa", "ESYE21", 39.18444, 20.97933);
case 787: return new CityInfo("Grammatikoú", "ESYE23", 38.52782, 21.50569);
case 788: return new CityInfo("Grammatikó", "ESYE31", 38.20251, 23.96504);
case 789: return new CityInfo("Gra Liyiá", "ESYE43", 35.01467, 25.69127);
case 790: return new CityInfo("Graikochóri", "ESYE21", 39.49789, 20.27608);
case 791: return new CityInfo("Goúves", "ESYE43", 35.3105, 25.31327);
case 792: return new CityInfo("Goúrnes", "ESYE43", 35.32626, 25.2774);
case 793: return new CityInfo("Gouriá", "ESYE23", 38.47294, 21.26133);
case 794: return new CityInfo("Goúmero", "ESYE23", 37.76236, 21.61853);
case 795: return new CityInfo("Gorgogýri", "ESYE14", 39.54754, 21.58817);
case 796: return new CityInfo("Gónnoi", "ESYE14", 39.86153, 22.47647);
case 797: return new CityInfo("Gómfoi", "ESYE14", 39.46413, 21.69342);
case 798: return new CityInfo("Glóssa", "ESYE14", 39.17519, 23.61572);
case 799: return new CityInfo("Glínos", "ESYE14", 39.51224, 21.86473);
case 800: return new CityInfo("Glinádo", "ESYE42", 37.071, 25.40174);
case 801: return new CityInfo("Glyfáda", "ESYE31", 37.86289, 23.75802);
case 802: return new CityInfo("Glífa", "ESYE24", 38.95342, 22.96681);
case 803: return new CityInfo("Gázi", "ESYE43", 35.32531, 25.06694);
case 804: return new CityInfo("Gavaloú", "ESYE23", 38.52903, 21.53226);
case 805: return new CityInfo("Gastoúni", "ESYE23", 37.85, 21.25);
case 806: return new CityInfo("Gargaliánoi", "ESYE25", 37.06518, 21.63809);
case 807: return new CityInfo("Gardíki", "ESYE21", 39.35883, 20.56472);
case 808: return new CityInfo("Gállos", "ESYE43", 35.34692, 24.45196);
case 809: return new CityInfo("Galiá", "ESYE43", 35.07795, 24.87009);
case 810: return new CityInfo("Galaxídhion", "ESYE24", 38.38067, 22.38001);
case 811: return new CityInfo("Galátsi", "ESYE31", 38.01667, 23.75);
case 812: return new CityInfo("Galatás", "ESYE23", 38.35742, 21.56222);
case 813: return new CityInfo("Galatás", "ESYE31", 37.49618, 23.44886);
case 814: return new CityInfo("Galatás", "ESYE43", 35.49864, 23.96341);
case 815: return new CityInfo("Gaïtánion", "ESYE22", 37.79134, 20.87407);
case 816: return new CityInfo("Fry", "ESYE42", 35.41623, 26.92328);
case 817: return new CityInfo("Frantzís", "ESYE24", 38.8497, 22.38812);
case 818: return new CityInfo("Frágko", "ESYE14", 39.35632, 21.84314);
case 819: return new CityInfo("Fourná", "ESYE24", 39.05997, 21.87533);
case 820: return new CityInfo("Foúrka", "ESYE12", 40.00572, 23.41537);
case 821: return new CityInfo("Folégandros", "ESYE42", 36.62794, 24.92021);
case 822: return new CityInfo("Flamoúli", "ESYE14", 39.52641, 21.76617);
case 823: return new CityInfo("Fyteíes", "ESYE23", 38.69524, 21.18467);
case 824: return new CityInfo("Filótion", "ESYE42", 37.05167, 25.49829);
case 825: return new CityInfo("Filothéi", "ESYE31", 38.02524, 23.78257);
case 826: return new CityInfo("Fílla", "ESYE24", 38.44177, 23.68306);
case 827: return new CityInfo("Filippiáda", "ESYE21", 39.20472, 20.88222);
case 828: return new CityInfo("Filiatrá", "ESYE25", 37.15637, 21.58532);
case 829: return new CityInfo("Filiátes", "ESYE21", 39.60111, 20.31194);
case 830: return new CityInfo("Fília", "ESYE41", 39.26246, 26.14017);
case 831: return new CityInfo("Fylí", "ESYE31", 38.10235, 23.66901);
case 832: return new CityInfo("Fíki", "ESYE14", 39.51602, 21.65556);
case 833: return new CityInfo("Fíkhtion", "ESYE25", 37.72117, 22.72436);
case 834: return new CityInfo("Fársala", "ESYE14", 39.29472, 22.38472);
case 835: return new CityInfo("Fáros", "ESYE24", 38.39959, 23.62275);
case 836: return new CityInfo("Farkadóna", "ESYE14", 39.6, 22.06667);
case 837: return new CityInfo("Faneroméni", "ESYE14", 39.54679, 21.89397);
case 838: return new CityInfo("Magoúla", "ESYE14", 39.45395, 21.80351);
case 839: return new CityInfo("Fanári", "ESYE14", 39.4158, 21.79897);
case 840: return new CityInfo("Fanes", "ESYE42", 36.35076, 27.98292);
case 841: return new CityInfo("Fálanna", "ESYE14", 39.71986, 22.39733);
case 842: return new CityInfo("Éxarkhos", "ESYE24", 38.58791, 22.94439);
case 843: return new CityInfo("Examília", "ESYE25", 37.89736, 22.92832);
case 844: return new CityInfo("Evxinoúpolis", "ESYE14", 39.18414, 22.73831);
case 845: return new CityInfo("Evangelismós", "ESYE14", 39.84006, 22.10433);
case 846: return new CityInfo("Ermoúpolis", "ESYE42", 37.44466, 24.9429);
case 847: return new CityInfo("Ermióni", "ESYE25", 37.38492, 23.24686);
case 848: return new CityInfo("Erythrés", "ESYE31", 38.21741, 23.32234);
case 849: return new CityInfo("Erétria", "ESYE24", 38.40097, 23.8022);
case 850: return new CityInfo("Eresós", "ESYE41", 39.16973, 25.93437);
case 851: return new CityInfo("Epitálio", "ESYE23", 37.62675, 21.49528);
case 852: return new CityInfo("Episkopí", "ESYE43", 35.32821, 24.33525);
case 853: return new CityInfo("Episkopí", "ESYE43", 35.2569, 25.23757);
case 854: return new CityInfo("Epinianá", "ESYE24", 39.14231, 21.61353);
case 855: return new CityInfo("Ano Arhanes", "ESYE43", 35.23333, 25.16667);
case 856: return new CityInfo("Emporeío", "ESYE42", 36.35816, 25.44615);
case 857: return new CityInfo("Émponas", "ESYE42", 36.22683, 27.85645);
case 858: return new CityInfo("Empesós", "ESYE23", 39.02387, 21.31963);
case 859: return new CityInfo("Eloúnda", "ESYE43", 35.265, 25.72127);
case 860: return new CityInfo("Élos", "ESYE25", 36.83267, 22.6978);
case 861: return new CityInfo("Ellinikó", "ESYE31", 37.89013, 23.74406);
case 862: return new CityInfo("Eleftherochóri", "ESYE14", 39.52761, 21.63436);
case 863: return new CityInfo("Eleftherés", "ESYE14", 39.57783, 22.33744);
case 864: return new CityInfo("Elefsína", "ESYE31", 38.04135, 23.54295);
case 865: return new CityInfo("Eleoúsa", "ESYE21", 39.70639, 20.7925);
case 866: return new CityInfo("Eleoúsa", "ESYE21", 39.15278, 20.96214);
case 867: return new CityInfo("Eleónas", "ESYE24", 38.36336, 23.44348);
case 868: return new CityInfo("Eláteia", "ESYE14", 39.81094, 22.53842);
case 869: return new CityInfo("Eláteia", "ESYE24", 38.6277, 22.76492);
case 870: return new CityInfo("Eláti", "ESYE13", 39.97933, 21.82281);
case 871: return new CityInfo("Eláti", "ESYE14", 39.50131, 21.53934);
case 872: return new CityInfo("Elassóna", "ESYE14", 39.89472, 22.18861);
case 873: return new CityInfo("Eliá", "ESYE43", 35.30311, 25.2316);
case 874: return new CityInfo("Elafónisos", "ESYE25", 36.50805, 22.97885);
case 875: return new CityInfo("Ekkára", "ESYE24", 39.15393, 22.19719);
case 876: return new CityInfo("Ekáli", "ESYE31", 38.11035, 23.83505);
case 877: return new CityInfo("Voulgaréli", "ESYE21", 39.37194, 21.18333);
case 878: return new CityInfo("Drosochóri", "ESYE21", 39.62753, 20.97163);
case 879: return new CityInfo("Dhrosiá", "ESYE24", 38.48413, 23.54774);
case 880: return new CityInfo("Drosiá", "ESYE31", 38.11977, 23.86428);
case 881: return new CityInfo("Droseró", "ESYE14", 39.51038, 21.74169);
case 882: return new CityInfo("Drépano", "ESYE23", 38.32152, 21.85221);
case 883: return new CityInfo("Drépanon", "ESYE25", 37.53888, 22.89323);
case 884: return new CityInfo("Drakótrypa", "ESYE14", 39.39764, 21.59911);
case 885: return new CityInfo("Dhráfi", "ESYE31", 38.02375, 23.90788);
case 886: return new CityInfo("Domokós", "ESYE24", 39.12722, 22.30028);
case 887: return new CityInfo("Dhokímion", "ESYE23", 38.61352, 21.38072);
case 888: return new CityInfo("Dístomo", "ESYE24", 38.42892, 22.66728);
case 889: return new CityInfo("Diónysos", "ESYE31", 38.10458, 23.87938);
case 890: return new CityInfo("Dimitsána", "ESYE25", 37.59524, 22.04025);
case 891: return new CityInfo("Dilináta", "ESYE22", 38.22403, 20.51636);
case 892: return new CityInfo("Dílesi", "ESYE24", 38.33762, 23.67077);
case 893: return new CityInfo("Dídyma", "ESYE25", 37.4625, 23.17183);
case 894: return new CityInfo("Diáva", "ESYE14", 39.6926, 21.58124);
case 895: return new CityInfo("Dialektó", "ESYE14", 39.59468, 21.65204);
case 896: return new CityInfo("Deskáti", "ESYE13", 39.92422, 21.81031);
case 897: return new CityInfo("Dhervéni", "ESYE25", 38.13101, 22.41983);
case 898: return new CityInfo("Dendrochóri", "ESYE14", 39.55271, 21.63707);
case 899: return new CityInfo("Delvináki", "ESYE21", 39.93408, 20.46461);
case 900: return new CityInfo("Delphi", "ESYE24", 38.47942, 22.49357);
case 901: return new CityInfo("Dasochóri", "ESYE14", 39.69206, 22.41811);
case 902: return new CityInfo("Darátsos", "ESYE43", 35.49955, 23.97488);
case 903: return new CityInfo("Dhalamanára", "ESYE25", 37.61837, 22.76989);
case 904: return new CityInfo("Dhafní", "ESYE31", 37.95002, 23.73437);
case 905: return new CityInfo("Dáfia", "ESYE41", 39.24212, 26.1992);
case 906: return new CityInfo("Boúka", "ESYE23", 38.92652, 21.14226);
case 907: return new CityInfo("Boláti", "ESYE25", 37.95611, 22.79094);
case 908: return new CityInfo("Bókhali", "ESYE22", 37.79205, 20.89192);
case 909: return new CityInfo("Rodópoli", "ESYE31", 38.11669, 23.87572);
case 910: return new CityInfo("Báfra", "ESYE21", 39.59894, 20.87489);
case 911: return new CityInfo("Ágios Geórgios Sykoúsis", "ESYE41", 38.31885, 26.05691);
case 912: return new CityInfo("Ágios Geórgios Ferón", "ESYE14", 39.36977, 22.77716);
case 913: return new CityInfo("Ágios Geórgios", "ESYE14", 39.29633, 21.8357);
case 914: return new CityInfo("Ágios Geórgios", "ESYE21", 39.26703, 20.85428);
case 915: return new CityInfo("Ágios Geórgios Lichádos", "ESYE24", 38.83793, 22.88097);
case 916: return new CityInfo("Ágios Geórgios", "ESYE24", 38.39343, 22.93189);
case 917: return new CityInfo("Ágios Vissaríonas", "ESYE14", 39.47118, 21.61939);
case 918: return new CityInfo("Áyios Vasílios", "ESYE25", 37.79763, 22.79727);
case 919: return new CityInfo("Áyios Thomás", "ESYE24", 38.27717, 23.58906);
case 920: return new CityInfo("Ágios Stéfanos", "ESYE31", 38.14657, 23.85608);
case 921: return new CityInfo("Ágios Spyrídon", "ESYE21", 39.14417, 20.86292);
case 922: return new CityInfo("Áyios Serafím", "ESYE24", 38.80096, 22.70441);
case 923: return new CityInfo("Ágios Pétros", "ESYE25", 37.32789, 22.54661);
case 924: return new CityInfo("Ágios Nikólaos", "ESYE23", 38.86886, 20.80425);
case 925: return new CityInfo("Áyios Nikólaos", "ESYE24", 38.42051, 23.64772);
case 926: return new CityInfo("Arkoúdi", "ESYE23", 37.84681, 21.11022);
case 927: return new CityInfo("Ágios Nikólaos", "ESYE43", 35.19106, 25.71524);
case 928: return new CityInfo("Ágios Loukás", "ESYE24", 38.44142, 24.02436);
case 929: return new CityInfo("Áyios Konstandínos", "ESYE24", 38.75612, 22.85757);
case 930: return new CityInfo("Áyios Konstandínos", "ESYE23", 38.63337, 21.3995);
case 931: return new CityInfo("Ágios Konstantínos", "ESYE31", 37.72602, 24.01289);
case 932: return new CityInfo("Áyios Kírikos", "ESYE22", 37.78773, 20.83085);
case 933: return new CityInfo("Agios Kirykos", "ESYE41", 37.61472, 26.29444);
case 934: return new CityInfo("Ágios Ioánnis", "ESYE21", 39.6965, 20.81308);
case 935: return new CityInfo("Áyios Ioánnis", "ESYE24", 38.44811, 24.00511);
case 936: return new CityInfo("Ágios Efstrátios", "ESYE41", 39.53889, 24.99167);
case 937: return new CityInfo("Agios Dimitrios", "ESYE31", 37.93333, 23.73333);
case 938: return new CityInfo("Áyios Dhimítrios", "ESYE22", 37.7995, 20.79769);
case 939: return new CityInfo("Ágios Andréas", "ESYE25", 37.34519, 22.76466);
case 940: return new CityInfo("Áyios Adhrianós", "ESYE25", 37.59975, 22.8456);
case 941: return new CityInfo("Áyios", "ESYE24", 38.90411, 23.06043);
case 942: return new CityInfo("Ágioi Theódoroi", "ESYE25", 37.92736, 23.14221);
case 943: return new CityInfo("Ágioi Déka", "ESYE43", 35.06667, 24.96667);
case 944: return new CityInfo("Áyioi Apóstoloi", "ESYE31", 38.29169, 23.91011);
case 945: return new CityInfo("Agiófyllo", "ESYE14", 39.86324, 21.56185);
case 946: return new CityInfo("Agía Varvára", "ESYE31", 37.98938, 23.66011);
case 947: return new CityInfo("Agía Varvára", "ESYE43", 35.13715, 25.00131);
case 948: return new CityInfo("Agía Triáda", "ESYE24", 38.35505, 22.90881);
case 949: return new CityInfo("Ayía Triás", "ESYE25", 37.63707, 22.80504);
case 950: return new CityInfo("Agiásos", "ESYE41", 39.08295, 26.37218);
case 951: return new CityInfo("Agía Paraskeví", "ESYE41", 39.24792, 26.27178);
case 952: return new CityInfo("Agía Paraskeví", "ESYE21", 39.09903, 20.99108);
case 953: return new CityInfo("Agía Paraskeví", "ESYE31", 38.01667, 23.83333);
case 954: return new CityInfo("Agía Marína", "ESYE42", 37.1543, 26.85162);
case 955: return new CityInfo("Agía Marína", "ESYE43", 35.51778, 23.92675);
case 956: return new CityInfo("Áyiai Paraskiaí", "ESYE43", 35.20944, 25.2047);
case 957: return new CityInfo("Agía Galíni", "ESYE43", 35.09707, 24.68818);
case 958: return new CityInfo("Agía Ánna", "ESYE24", 38.85919, 23.39979);
case 959: return new CityInfo("Agiá", "ESYE14", 39.71901, 22.75869);
case 960: return new CityInfo("Agiá", "ESYE21", 39.31294, 20.35856);
case 961: return new CityInfo("Ávra", "ESYE14", 39.71135, 21.69084);
case 962: return new CityInfo("Avlónas", "ESYE31", 38.25149, 23.69554);
case 963: return new CityInfo("Atsipópoulo", "ESYE43", 35.35253, 24.43378);
case 964: return new CityInfo("Atsikí", "ESYE41", 39.94611, 25.22445);
case 965: return new CityInfo("Athens", "ESYE31", 37.98376, 23.72784);
case 966: return new CityInfo("Athíkia", "ESYE25", 37.81675, 22.92939);
case 967: return new CityInfo("Atalánti", "ESYE24", 38.65111, 22.99917);
case 968: return new CityInfo("Ástros", "ESYE25", 37.40395, 22.72118);
case 969: return new CityInfo("Astypálaia", "ESYE42", 36.55, 26.35);
case 970: return new CityInfo("Astakós", "ESYE23", 38.53556, 21.08135);
case 971: return new CityInfo("Ássos", "ESYE25", 37.93955, 22.82223);
case 972: return new CityInfo("Asprópyrgos", "ESYE31", 38.06134, 23.58971);
case 973: return new CityInfo("Asprokklisiá", "ESYE14", 39.8505, 21.66316);
case 974: return new CityInfo("Asprókhoma", "ESYE25", 37.04778, 22.07484);
case 975: return new CityInfo("Asprángeloi", "ESYE21", 39.82328, 20.72862);
case 976: return new CityInfo("Asopós", "ESYE25", 36.72986, 22.85455);
case 977: return new CityInfo("Asopía", "ESYE24", 38.29882, 23.50189);
case 978: return new CityInfo("Asíni", "ESYE25", 37.54431, 22.86435);
case 979: return new CityInfo("Asímion", "ESYE43", 35.04321, 25.09277);
case 980: return new CityInfo("Argyroúpoli", "ESYE31", 37.90594, 23.75035);
case 981: return new CityInfo("Argyropoúli", "ESYE14", 39.82567, 22.30689);
case 982: return new CityInfo("Artesianó", "ESYE14", 39.40194, 21.89649);
case 983: return new CityInfo("Artemón", "ESYE42", 36.98181, 24.72439);
case 984: return new CityInfo("Árta", "ESYE21", 39.16014, 20.98561);
case 985: return new CityInfo("Arméni", "ESYE14", 39.488, 22.69758);
case 986: return new CityInfo("Árma", "ESYE24", 38.35121, 23.48599);
case 987: return new CityInfo("Arkítsa", "ESYE24", 38.74337, 23.03301);
case 988: return new CityInfo("Archontochóri", "ESYE23", 38.70053, 21.03896);
case 989: return new CityInfo("Archaía Olympía", "ESYE23", 37.64788, 21.6271);
case 990: return new CityInfo("Arkhaía Kórinthos", "ESYE25", 37.90953, 22.88353);
case 991: return new CityInfo("Arkalochóri", "ESYE43", 35.14634, 25.26538);
case 992: return new CityInfo("Áris", "ESYE25", 37.0992, 22.00443);
case 993: return new CityInfo("Aria", "ESYE25", 37.57372, 22.83539);
case 994: return new CityInfo("Argostólion", "ESYE22", 38.18109, 20.48903);
case 995: return new CityInfo("Árgos", "ESYE25", 37.63333, 22.73333);
case 996: return new CityInfo("Argolikón", "ESYE25", 37.61987, 22.79923);
case 997: return new CityInfo("Argási", "ESYE22", 37.76251, 20.92357);
case 998: return new CityInfo("Argalastí", "ESYE14", 39.22627, 23.21868);
case 999: return new CityInfo("Arfará", "ESYE25", 37.15619, 22.04485);
case 1000: return new CityInfo("Areópoli", "ESYE25", 36.66612, 22.38127);
case 1001: return new CityInfo("Ardáni", "ESYE14", 39.63163, 21.78649);
case 1002: return new CityInfo("Dímitra", "ESYE13", 39.9471, 21.6619);
case 1003: return new CityInfo("Aráchova", "ESYE24", 38.47958, 22.5835);
case 1004: return new CityInfo("Arakhnaíon", "ESYE25", 37.67907, 22.95825);
case 1005: return new CityInfo("Apólpaina", "ESYE22", 38.81537, 20.68674);
case 1006: return new CityInfo("Apollonía", "ESYE42", 36.97336, 24.72391);
case 1007: return new CityInfo("Apóllona", "ESYE42", 36.26091, 27.96698);
case 1008: return new CityInfo("Apérathos", "ESYE42", 37.07169, 25.51967);
case 1009: return new CityInfo("Anthoúsa", "ESYE21", 39.29917, 20.37311);
case 1010: return new CityInfo("Anthiró", "ESYE14", 39.34722, 21.45833);
case 1011: return new CityInfo("Anthíli", "ESYE24", 38.85, 22.47906);
case 1012: return new CityInfo("Anógeia", "ESYE43", 35.29084, 24.88412);
case 1013: return new CityInfo("Áno Vólos", "ESYE14", 39.37936, 22.98181);
case 1014: return new CityInfo("Áno Sýros", "ESYE42", 37.44997, 24.93562);
case 1015: return new CityInfo("Áno Merá", "ESYE42", 37.44904, 25.39095);
case 1016: return new CityInfo("Áno Liósia", "ESYE31", 38.08333, 23.7);
case 1017: return new CityInfo("Áno Lekhónia", "ESYE14", 39.32763, 23.05395);
case 1018: return new CityInfo("Kopanáki", "ESYE25", 37.28913, 21.81854);
case 1019: return new CityInfo("Áno Kastrítsi", "ESYE23", 38.27228, 21.836);
case 1020: return new CityInfo("Áno Kalésia", "ESYE43", 35.28374, 25.05904);
case 1021: return new CityInfo("Áno Kalentíni", "ESYE21", 39.25, 21.18528);
case 1022: return new CityInfo("Anoixi", "ESYE31", 38.13267, 23.85874);
case 1023: return new CityInfo("Anílio", "ESYE21", 39.76005, 21.18912);
case 1024: return new CityInfo("Anífion", "ESYE25", 37.65923, 22.78882);
case 1025: return new CityInfo("Megalochóri", "ESYE31", 37.71051, 23.34659);
case 1026: return new CityInfo("Angelókastro", "ESYE23", 38.56585, 21.29631);
case 1027: return new CityInfo("Anéza", "ESYE21", 39.08658, 20.923);
case 1028: return new CityInfo("Andros", "ESYE42", 37.83333, 24.93333);
case 1029: return new CityInfo("Andrítsaina", "ESYE23", 37.48387, 21.90563);
case 1030: return new CityInfo("Andravída", "ESYE23", 37.90588, 21.26936);
case 1031: return new CityInfo("Ántissa", "ESYE41", 39.23401, 25.98018);
case 1032: return new CityInfo("Antirrio", "ESYE23", 38.33014, 21.76413);
case 1033: return new CityInfo("Antíparos", "ESYE42", 37.0394, 25.08258);
case 1034: return new CityInfo("Antimácheia", "ESYE42", 36.80888, 27.09764);
case 1035: return new CityInfo("Antikyra", "ESYE24", 38.38333, 22.63333);
case 1036: return new CityInfo("Anávra", "ESYE14", 39.18996, 22.09308);
case 1037: return new CityInfo("Anávra", "ESYE14", 39.07276, 22.55111);
case 1038: return new CityInfo("Anávyssos", "ESYE31", 37.73414, 23.94389);
case 1039: return new CityInfo("Anatolí", "ESYE21", 39.63531, 20.86578);
case 1040: return new CityInfo("Anáfi", "ESYE42", 36.35, 25.76667);
case 1041: return new CityInfo("Amorgós", "ESYE42", 36.83175, 25.89821);
case 1042: return new CityInfo("Ammótopos", "ESYE21", 39.27097, 20.94257);
case 1043: return new CityInfo("Ámfissa", "ESYE24", 38.52813, 22.37713);
case 1044: return new CityInfo("Amfilochía", "ESYE23", 38.85944, 21.16639);
case 1045: return new CityInfo("Amfíkleia", "ESYE24", 38.63912, 22.59171);
case 1046: return new CityInfo("Ampelóna", "ESYE14", 39.74481, 22.36575);
case 1047: return new CityInfo("Ambelókipoi", "ESYE22", 37.75809, 20.87248);
case 1048: return new CityInfo("Ampelákia", "ESYE31", 37.95055, 23.52803);
case 1049: return new CityInfo("Maroúsi", "ESYE31", 38.05, 23.8);
case 1050: return new CityInfo("Amárynthos", "ESYE24", 38.393, 23.88492);
case 1051: return new CityInfo("Amaliáda", "ESYE23", 37.79842, 21.35068);
case 1052: return new CityInfo("Amaliapolis", "ESYE14", 39.16667, 22.88333);
case 1053: return new CityInfo("Almyrós", "ESYE14", 39.18222, 22.75944);
case 1054: return new CityInfo("Álli Meriá", "ESYE14", 39.37039, 22.9835);
case 1055: return new CityInfo("Alivéri", "ESYE24", 38.41667, 24.03333);
case 1056: return new CityInfo("Alíartos", "ESYE24", 38.36667, 23.1);
case 1057: return new CityInfo("Alfeioúsa", "ESYE23", 37.64019, 21.5375);
case 1058: return new CityInfo("Akropotamiá", "ESYE21", 39.09422, 21.02011);
case 1059: return new CityInfo("Akráta", "ESYE23", 38.15469, 22.3183);
case 1060: return new CityInfo("Akraifnía", "ESYE24", 38.45663, 23.22093);
case 1061: return new CityInfo("Akhinós", "ESYE24", 38.89284, 22.72483);
case 1062: return new CityInfo("Akhíllio", "ESYE14", 39.00548, 22.96095);
case 1063: return new CityInfo("Acharnés", "ESYE31", 38.08333, 23.73333);
case 1064: return new CityInfo("Aíyira", "ESYE23", 38.14846, 22.35426);
case 1065: return new CityInfo("Aígio", "ESYE23", 38.24861, 22.08194);
case 1066: return new CityInfo("Aegina", "ESYE31", 37.74667, 23.4275);
case 1067: return new CityInfo("Aitolikó", "ESYE23", 38.43704, 21.35358);
case 1068: return new CityInfo("Aigáni", "ESYE14", 39.95278, 22.61208);
case 1069: return new CityInfo("Aigáleo", "ESYE31", 37.98333, 23.68333);
case 1070: return new CityInfo("Aidipsós", "ESYE24", 38.87924, 23.04691);
case 1071: return new CityInfo("Aiánteio", "ESYE31", 37.92135, 23.45877);
case 1072: return new CityInfo("Agrínio", "ESYE23", 38.62139, 21.40778);
case 1073: return new CityInfo("Agriá", "ESYE14", 39.34078, 23.01258);
case 1074: return new CityInfo("Ágrafa", "ESYE24", 39.13689, 21.64911);
case 1075: return new CityInfo("Ágra", "ESYE41", 39.15789, 26.06099);
case 1076: return new CityInfo("Agnantiá", "ESYE14", 39.86791, 21.4655);
case 1077: return new CityInfo("Agnanteró", "ESYE14", 39.48586, 21.84789);
case 1078: return new CityInfo("Ágnanta", "ESYE21", 39.47419, 21.08051);
case 1079: return new CityInfo("Afrátion", "ESYE24", 38.45212, 23.68775);
case 1080: return new CityInfo("Afidnés", "ESYE31", 38.20332, 23.83982);
case 1081: return new CityInfo("Adámas", "ESYE42", 36.72506, 24.44685);
case 1082: return new CityInfo("Ródos", "ESYE42", 36.43556, 28.22199);
case 1083: return new CityInfo("Néa Alikarnassós", "ESYE43", 35.33977, 25.15895);
case 1084: return new CityInfo("Kremastí", "ESYE42", 36.40981, 28.1192);
case 1085: return new CityInfo("Afántou", "ESYE42", 36.29354, 28.16225);
case 1086: return new CityInfo("Archángelos", "ESYE42", 36.21492, 28.11487);
case 1087: return new CityInfo("Líndos", "ESYE42", 36.09102, 28.08571);
case 1088: return new CityInfo("Lárdos", "ESYE42", 36.09419, 28.01565);
case 1089: return new CityInfo("Iraío", "ESYE41", 37.6647, 26.8812);
case 1090: return new CityInfo("Kontakaíika", "ESYE41", 37.80217, 26.7447);
case 1091: return new CityInfo("Zipári", "ESYE42", 36.87696, 27.20532);
case 1092: return new CityInfo("Linopótis", "ESYE42", 36.87168, 27.18373);
case 1093: return new CityInfo("Néoi Póroi", "ESYE12", 39.97732, 22.6498);
case 1094: return new CityInfo("Ágioi Anárgyroi", "ESYE21", 39.13969, 21.02613);
case 1095: return new CityInfo("Néos Oropós", "ESYE21", 39.15064, 20.73636);
case 1096: return new CityInfo("Petrití", "ESYE22", 39.45339, 19.998);
case 1097: return new CityInfo("Zygós", "ESYE11", 41.0132, 24.38132);
case 1098: return new CityInfo("Zarkadiá", "ESYE11", 41.01887, 24.64063);
case 1099: return new CityInfo("Akrolímni", "ESYE12", 40.6802, 22.2645);
case 1100: return new CityInfo("Giannitsá", "ESYE12", 40.79194, 22.4075);
case 1101: return new CityInfo("Gérmas", "ESYE13", 40.45504, 21.42904);
case 1102: return new CityInfo("Gerakaroú", "ESYE12", 40.62666, 23.21566);
case 1103: return new CityInfo("Georgianí", "ESYE11", 40.9567, 24.14806);
case 1104: return new CityInfo("Genisséa", "ESYE11", 41.06165, 24.96248);
case 1105: return new CityInfo("Gefyroúdi", "ESYE12", 41.15943, 23.36134);
case 1106: return new CityInfo("Géfyra", "ESYE12", 40.73253, 22.69359);
case 1107: return new CityInfo("Xiropótamos", "ESYE11", 41.19206, 24.10385);
case 1108: return new CityInfo("Xirochóri", "ESYE12", 40.80289, 22.77882);
case 1109: return new CityInfo("Xinó Neró", "ESYE13", 40.69028, 21.62324);
case 1110: return new CityInfo("Xilópolis", "ESYE12", 40.92713, 23.17944);
case 1111: return new CityInfo("Xylaganí", "ESYE11", 40.97437, 25.42022);
case 1112: return new CityInfo("Xechasméni", "ESYE12", 40.5687, 22.33907);
case 1113: return new CityInfo("Xánthi", "ESYE11", 41.13488, 24.888);
case 1114: return new CityInfo("Vrontoú", "ESYE12", 40.19356, 22.43203);
case 1115: return new CityInfo("Vrysáki", "ESYE12", 40.62048, 22.40365);
case 1116: return new CityInfo("Vrástama", "ESYE12", 40.37184, 23.5359);
case 1117: return new CityInfo("Vrachiá", "ESYE12", 40.66257, 22.64061);
case 1118: return new CityInfo("Voreinó", "ESYE12", 41.02828, 22.07924);
case 1119: return new CityInfo("Vólakas", "ESYE11", 41.31661, 24.00215);
case 1120: return new CityInfo("Vogatsikó", "ESYE13", 40.41436, 21.38015);
case 1121: return new CityInfo("Krinída", "ESYE12", 40.99473, 23.98408);
case 1122: return new CityInfo("Vyróneia", "ESYE12", 41.26541, 23.25247);
case 1123: return new CityInfo("Vévi", "ESYE13", 40.76733, 21.61595);
case 1124: return new CityInfo("Vergína", "ESYE12", 40.48654, 22.31735);
case 1125: return new CityInfo("Vérgi", "ESYE12", 40.95396, 23.39833);
case 1126: return new CityInfo("Véroia", "ESYE12", 40.52437, 22.20242);
case 1127: return new CityInfo("Velventós", "ESYE13", 40.25532, 22.07543);
case 1128: return new CityInfo("Vathýlakkos", "ESYE12", 40.76942, 22.7088);
case 1129: return new CityInfo("Vasiloúdi", "ESYE12", 40.63193, 23.19029);
case 1130: return new CityInfo("Vasiliká", "ESYE12", 40.47966, 23.13695);
case 1131: return new CityInfo("Varvára", "ESYE12", 40.56953, 23.6588);
case 1132: return new CityInfo("Varikó", "ESYE13", 40.53967, 21.50292);
case 1133: return new CityInfo("Vamvakófyto", "ESYE12", 41.17916, 23.39602);
case 1134: return new CityInfo("Vamvakiá", "ESYE12", 41.08394, 23.34608);
case 1135: return new CityInfo("Valtotópi", "ESYE12", 40.99354, 23.59613);
case 1136: return new CityInfo("Valteró", "ESYE12", 41.17927, 23.32022);
case 1137: return new CityInfo("Vafiochóri", "ESYE12", 41.00984, 22.66344);
case 1138: return new CityInfo("Tsotíli", "ESYE13", 40.26147, 21.32533);
case 1139: return new CityInfo("Tsákoi", "ESYE12", 40.95495, 22.03763);
case 1140: return new CityInfo("Trílofos", "ESYE12", 40.37093, 22.45863);
case 1141: return new CityInfo("Trílofo", "ESYE12", 40.57182, 22.15195);
case 1142: return new CityInfo("Trílofos", "ESYE12", 40.46898, 22.9718);
case 1143: return new CityInfo("Tríkala", "ESYE12", 40.59814, 22.55733);
case 1144: return new CityInfo("Triantafylliá", "ESYE12", 40.98417, 23.34785);
case 1145: return new CityInfo("Toúmpa", "ESYE12", 41.02385, 23.70619);
case 1146: return new CityInfo("Toúmpa", "ESYE12", 40.93526, 22.5438);
case 1147: return new CityInfo("Toichío", "ESYE13", 40.58338, 21.30453);
case 1148: return new CityInfo("Tycheró", "ESYE11", 41.02878, 26.29455);
case 1149: return new CityInfo("Tholós", "ESYE12", 40.99992, 23.78207);
case 1150: return new CityInfo("Thessaloníki", "ESYE12", 40.64361, 22.93086);
case 1151: return new CityInfo("Thérmi", "ESYE12", 40.54712, 23.01967);
case 1152: return new CityInfo("Theológos", "ESYE11", 40.6594, 24.69257);
case 1153: return new CityInfo("Theodorákeio", "ESYE12", 40.94959, 22.19168);
case 1154: return new CityInfo("Thásos", "ESYE11", 40.77806, 24.70944);
case 1155: return new CityInfo("Terpní", "ESYE12", 40.91643, 23.48137);
case 1156: return new CityInfo("Taxiárchis", "ESYE12", 40.42483, 23.52223);
case 1157: return new CityInfo("Svorónos", "ESYE12", 40.26805, 22.46366);
case 1158: return new CityInfo("Strymonikó", "ESYE12", 41.04144, 23.31487);
case 1159: return new CityInfo("Stratónion", "ESYE12", 40.51406, 23.82471);
case 1160: return new CityInfo("Stratoníki", "ESYE12", 40.52772, 23.76306);
case 1161: return new CityInfo("Stívos", "ESYE12", 40.64963, 23.30344);
case 1162: return new CityInfo("Stérna", "ESYE11", 41.56546, 26.4581);
case 1163: return new CityInfo("Stenímachos", "ESYE12", 40.60359, 22.12578);
case 1164: return new CityInfo("Stavroúpoli", "ESYE12", 40.66944, 22.93806);
case 1165: return new CityInfo("Stavrós", "ESYE12", 40.66498, 23.70015);
case 1166: return new CityInfo("Stavrós", "ESYE12", 40.58939, 22.30861);
case 1167: return new CityInfo("Stavrodrómi", "ESYE12", 40.71161, 22.21694);
case 1168: return new CityInfo("Stanós", "ESYE12", 40.54477, 23.5899);
case 1169: return new CityInfo("Sozópoli", "ESYE12", 40.27726, 23.14735);
case 1170: return new CityInfo("Sourotí", "ESYE12", 40.47274, 23.09197);
case 1171: return new CityInfo("Souflí", "ESYE11", 41.19194, 26.29944);
case 1172: return new CityInfo("Sosándra", "ESYE12", 40.99894, 22.03254);
case 1173: return new CityInfo("Sochós", "ESYE12", 40.81788, 23.35546);
case 1174: return new CityInfo("Smínthi", "ESYE11", 41.23333, 24.86667);
case 1175: return new CityInfo("Skoútari", "ESYE12", 41.01871, 23.51971);
case 1176: return new CityInfo("Skotoússa", "ESYE12", 41.12844, 23.38174);
case 1177: return new CityInfo("Skotína", "ESYE12", 40.01495, 22.55244);
case 1178: return new CityInfo("Skopiá", "ESYE13", 40.76346, 21.41039);
case 1179: return new CityInfo("Sklíthro", "ESYE13", 40.62192, 21.5048);
case 1180: return new CityInfo("Skýdra", "ESYE12", 40.76722, 22.15194);
case 1181: return new CityInfo("Leptokaryá", "ESYE12", 40.06032, 22.5612);
case 1182: return new CityInfo("Skála Kalliráchis", "ESYE11", 40.70641, 24.53392);
case 1183: return new CityInfo("Sitochóri", "ESYE12", 40.88172, 23.61858);
case 1184: return new CityInfo("Sitariá", "ESYE13", 40.79094, 21.5429);
case 1185: return new CityInfo("Sitagroí", "ESYE11", 41.11067, 24.02755);
case 1186: return new CityInfo("Síndos", "ESYE12", 40.67045, 22.80545);
case 1187: return new CityInfo("Sykiá", "ESYE12", 40.03874, 23.94046);
case 1188: return new CityInfo("Sykiés", "ESYE12", 40.64944, 22.95083);
case 1189: return new CityInfo("Sidirókastro", "ESYE12", 41.23499, 23.38899);
case 1190: return new CityInfo("Siátista", "ESYE13", 40.26194, 21.54417);
case 1191: return new CityInfo("Sfikiá", "ESYE12", 40.38581, 22.20881);
case 1192: return new CityInfo("Sfendámi", "ESYE12", 40.41307, 22.54677);
case 1193: return new CityInfo("Sevastianá", "ESYE12", 40.76874, 22.12346);
case 1194: return new CityInfo("Sevastí", "ESYE12", 40.35927, 22.54513);
case 1195: return new CityInfo("Sérvia", "ESYE13", 40.17972, 21.99444);
case 1196: return new CityInfo("Sérres", "ESYE12", 41.08499, 23.54757);
case 1197: return new CityInfo("Sélero", "ESYE11", 41.13382, 24.99408);
case 1198: return new CityInfo("Sárti", "ESYE12", 40.09369, 23.97859);
case 1199: return new CityInfo("Sarantáporo", "ESYE14", 40.06783, 22.05264);
case 1200: return new CityInfo("Sápes", "ESYE11", 41.02861, 25.69306);
case 1201: return new CityInfo("Samothráki", "ESYE11", 40.47333, 25.52222);
case 1202: return new CityInfo("Samarína", "ESYE13", 40.10462, 21.01864);
case 1203: return new CityInfo("Rodópoli", "ESYE12", 41.26125, 23.00043);
case 1204: return new CityInfo("Rodolívos", "ESYE12", 40.92055, 23.97489);
case 1205: return new CityInfo("Rodochóri", "ESYE12", 40.6907, 22.01751);
case 1206: return new CityInfo("Rizó", "ESYE12", 40.73331, 22.13674);
case 1207: return new CityInfo("Rizómata", "ESYE12", 40.35061, 22.21079);
case 1208: return new CityInfo("Rízia", "ESYE11", 41.6249, 26.42771);
case 1209: return new CityInfo("Rizári", "ESYE12", 40.78373, 22.088);
case 1210: return new CityInfo("Ritíni", "ESYE12", 40.28835, 22.28361);
case 1211: return new CityInfo("Ryákia", "ESYE12", 40.40086, 22.39309);
case 1212: return new CityInfo("Péfka", "ESYE12", 40.65806, 22.99378);
case 1213: return new CityInfo("Rachóna", "ESYE12", 40.81211, 22.53853);
case 1214: return new CityInfo("Ráchi", "ESYE12", 40.48453, 22.21451);
case 1215: return new CityInfo("Ptolemaḯda", "ESYE13", 40.51472, 21.67861);
case 1216: return new CityInfo("Fteliá", "ESYE11", 41.08266, 24.18968);
case 1217: return new CityInfo("Psychikó", "ESYE12", 41.00404, 23.62994);
case 1218: return new CityInfo("Provatónas", "ESYE11", 41.02654, 26.25906);
case 1219: return new CityInfo("Provatás", "ESYE12", 41.06825, 23.3903);
case 1220: return new CityInfo("Próti", "ESYE12", 40.94411, 24.00118);
case 1221: return new CityInfo("Prosotsáni", "ESYE11", 41.18333, 23.96667);
case 1222: return new CityInfo("Prómachoi", "ESYE12", 41.02517, 22.00437);
case 1223: return new CityInfo("Próchoma", "ESYE12", 40.79826, 22.66659);
case 1224: return new CityInfo("Profítis Ilías", "ESYE12", 40.81373, 22.16166);
case 1225: return new CityInfo("Profítis", "ESYE12", 40.68767, 23.27737);
case 1226: return new CityInfo("Pródromos", "ESYE12", 40.55083, 22.39667);
case 1227: return new CityInfo("Potamiá", "ESYE11", 40.71633, 24.72859);
case 1228: return new CityInfo("Portariá", "ESYE12", 40.28405, 23.29549);
case 1229: return new CityInfo("Poreiá", "ESYE13", 40.4885, 21.2124);
case 1230: return new CityInfo("Pontoirákleia", "ESYE12", 41.10445, 22.62162);
case 1231: return new CityInfo("Pontisméno", "ESYE12", 41.20885, 23.28325);
case 1232: return new CityInfo("Polýgyros", "ESYE12", 40.37704, 23.44135);
case 1233: return new CityInfo("Polyplátanos", "ESYE12", 40.68306, 22.19118);
case 1234: return new CityInfo("Polýmylos", "ESYE13", 40.37091, 22.0673);
case 1235: return new CityInfo("Políkhronon", "ESYE12", 40.01657, 23.52834);
case 1236: return new CityInfo("Políchni", "ESYE12", 40.66671, 22.94881);
case 1237: return new CityInfo("Polýkastro", "ESYE12", 40.99444, 22.56909);
case 1238: return new CityInfo("Polykárpi", "ESYE12", 40.92598, 22.01634);
case 1239: return new CityInfo("Polykárpi", "ESYE13", 40.52154, 21.32144);
case 1240: return new CityInfo("Podhokhóri", "ESYE11", 40.83112, 24.02483);
case 1241: return new CityInfo("Plagiári", "ESYE12", 40.47276, 22.9579);
case 1242: return new CityInfo("Platý", "ESYE12", 40.64241, 22.53458);
case 1243: return new CityInfo("Platanótopos", "ESYE11", 40.84715, 24.06005);
case 1244: return new CityInfo("Plátanos", "ESYE12", 40.56475, 22.55072);
case 1245: return new CityInfo("Platanórevma", "ESYE13", 40.20083, 22.02488);
case 1246: return new CityInfo("Pigés", "ESYE11", 40.90605, 24.67215);
case 1247: return new CityInfo("Pýthio", "ESYE14", 40.06619, 22.23128);
case 1248: return new CityInfo("Chalástra", "ESYE12", 40.62643, 22.73291);
case 1249: return new CityInfo("Piperiés", "ESYE12", 40.97023, 22.01682);
case 1250: return new CityInfo("Pylaía", "ESYE12", 40.59918, 22.98613);
case 1251: return new CityInfo("Pefkodásos", "ESYE12", 41.03844, 22.57638);
case 1252: return new CityInfo("Petroússa", "ESYE11", 41.1947, 24.01731);
case 1253: return new CityInfo("Petropigí", "ESYE11", 40.9875, 24.61489);
case 1254: return new CityInfo("Petrochóri", "ESYE11", 41.08742, 24.84092);
case 1255: return new CityInfo("Petraía", "ESYE12", 40.7202, 22.14439);
case 1256: return new CityInfo("Peteinós", "ESYE11", 41.10056, 24.89847);
case 1257: return new CityInfo("Pérni", "ESYE11", 41.00054, 24.63627);
case 1258: return new CityInfo("Perivolákion", "ESYE12", 40.74418, 23.03571);
case 1259: return new CityInfo("Peristerá", "ESYE12", 40.54881, 23.1654);
case 1260: return new CityInfo("Perístasi", "ESYE12", 40.27443, 22.54164);
case 1261: return new CityInfo("Peraía", "ESYE12", 40.49874, 22.92617);
case 1262: return new CityInfo("Péplos", "ESYE11", 40.95755, 26.26577);
case 1263: return new CityInfo("Pentávryso", "ESYE13", 40.45376, 21.14216);
case 1264: return new CityInfo("Pentápoli", "ESYE12", 41.05011, 23.68893);
case 1265: return new CityInfo("Pentaplátano", "ESYE12", 40.81902, 22.41903);
case 1266: return new CityInfo("Pentálofos", "ESYE12", 40.74296, 22.85256);
case 1267: return new CityInfo("Pélla", "ESYE12", 40.76169, 22.52637);
case 1268: return new CityInfo("Pedinó", "ESYE12", 40.91013, 22.87253);
case 1269: return new CityInfo("Patrída", "ESYE12", 40.56071, 22.18545);
case 1270: return new CityInfo("Parthéni", "ESYE12", 40.70035, 22.60697);
case 1271: return new CityInfo("Paranésti", "ESYE11", 41.26667, 24.5);
case 1272: return new CityInfo("Paralímnio", "ESYE12", 40.98508, 23.67017);
case 1273: return new CityInfo("Paralía", "ESYE12", 40.2671, 22.59615);
case 1274: return new CityInfo("Pappagiánnis", "ESYE13", 40.83866, 21.49793);
case 1275: return new CityInfo("Panórama", "ESYE12", 40.58779, 23.0315);
case 1276: return new CityInfo("Panayía", "ESYE11", 40.73067, 24.72816);
case 1277: return new CityInfo("Palaió Tsiflíki", "ESYE11", 40.90495, 24.35083);
case 1278: return new CityInfo("Palatítsia", "ESYE12", 40.48416, 22.34328);
case 1279: return new CityInfo("Palaiostáni", "ESYE12", 40.41921, 22.46309);
case 1280: return new CityInfo("Palaiós Mylótopos", "ESYE12", 40.80318, 22.32615);
case 1281: return new CityInfo("Palaió Skyllítsi", "ESYE12", 40.60611, 22.32918);
case 1282: return new CityInfo("Palaió Keramídi", "ESYE12", 40.31403, 22.46448);
case 1283: return new CityInfo("Palaió Eleftherochóri", "ESYE12", 40.43711, 22.5753);
case 1284: return new CityInfo("Palaió Agionéri", "ESYE12", 40.81462, 22.72748);
case 1285: return new CityInfo("Axós", "ESYE12", 40.80223, 22.36158);
case 1286: return new CityInfo("Palaiokómi", "ESYE12", 40.87068, 23.90121);
case 1287: return new CityInfo("Palaiochóri", "ESYE11", 40.94338, 24.17747);
case 1288: return new CityInfo("Palaiochóri", "ESYE12", 40.49186, 23.64928);
case 1289: return new CityInfo("Palaiochóra", "ESYE12", 40.50085, 23.45138);
case 1290: return new CityInfo("Palaiókastro", "ESYE12", 41.15636, 23.41322);
case 1291: return new CityInfo("Palaífyto", "ESYE12", 40.78283, 22.27388);
case 1292: return new CityInfo("Páchni", "ESYE11", 41.30506, 24.89438);
case 1293: return new CityInfo("Pagoúria", "ESYE11", 41.02801, 25.31809);
case 1294: return new CityInfo("Ouranoupolis", "ESYE12", 40.33333, 23.98333);
case 1295: return new CityInfo("Ormýlia", "ESYE12", 40.29451, 23.54332);
case 1296: return new CityInfo("Orménio", "ESYE11", 41.72048, 26.2152);
case 1297: return new CityInfo("Órma", "ESYE12", 40.95133, 21.92612);
case 1298: return new CityInfo("Oreiní", "ESYE12", 41.19548, 23.5923);
case 1299: return new CityInfo("Orfánio", "ESYE11", 40.7758, 23.95105);
case 1300: return new CityInfo("Orestiáda", "ESYE11", 41.50306, 26.52972);
case 1301: return new CityInfo("Oraiókastro", "ESYE12", 40.73083, 22.91722);
case 1302: return new CityInfo("Olympiáda", "ESYE12", 40.59189, 23.78209);
case 1303: return new CityInfo("Oinoússa", "ESYE12", 41.10237, 23.62576);
case 1304: return new CityInfo("Ofrínion", "ESYE11", 40.79663, 23.91093);
case 1305: return new CityInfo("Nisí", "ESYE12", 40.6361, 22.38884);
case 1306: return new CityInfo("Niséli", "ESYE12", 40.59443, 22.46036);
case 1307: return new CityInfo("Nípsa", "ESYE11", 40.92912, 26.01801);
case 1308: return new CityInfo("Nikomidinó", "ESYE12", 40.63695, 23.2758);
case 1309: return new CityInfo("Nikókleia", "ESYE12", 40.93266, 23.42773);
case 1310: return new CityInfo("Níkiti", "ESYE12", 40.22204, 23.66837);
case 1311: return new CityInfo("Nikísiani", "ESYE11", 40.94739, 24.14311);
case 1312: return new CityInfo("Nigríta", "ESYE12", 40.90528, 23.49944);
case 1313: return new CityInfo("Nestório", "ESYE13", 40.41278, 21.06222);
case 1314: return new CityInfo("Néos Skopós", "ESYE12", 41.0239, 23.60927);
case 1315: return new CityInfo("Néos Pýrgos", "ESYE11", 41.49462, 26.5039);
case 1316: return new CityInfo("Néos Mylótopos", "ESYE12", 40.81872, 22.35489);
case 1317: return new CityInfo("Néos Marmarás", "ESYE12", 40.0961, 23.78323);
case 1318: return new CityInfo("Néo Gynaikókastro", "ESYE12", 40.92149, 22.74659);
case 1319: return new CityInfo("Néo Soúli", "ESYE12", 41.09397, 23.64376);
case 1320: return new CityInfo("Néo Rýsi", "ESYE12", 40.49605, 22.98794);
case 1321: return new CityInfo("Néo Petrítsi", "ESYE12", 41.27459, 23.29381);
case 1322: return new CityInfo("Néo Kostarázi", "ESYE13", 40.43503, 21.33161);
case 1323: return new CityInfo("Néo Agionéri", "ESYE12", 40.80826, 22.70733);
case 1324: return new CityInfo("Neochoroúda", "ESYE12", 40.73817, 22.87557);
case 1325: return new CityInfo("Neochóri", "ESYE11", 41.51131, 26.4574);
case 1326: return new CityInfo("Neochóri", "ESYE12", 41.05231, 23.57997);
case 1327: return new CityInfo("Neochóri", "ESYE12", 40.66495, 22.4456);
case 1328: return new CityInfo("Kypséli", "ESYE12", 40.55569, 22.49374);
case 1329: return new CityInfo("Neochóri", "ESYE12", 40.50858, 23.67946);
case 1330: return new CityInfo("Neókastro", "ESYE12", 40.5054, 22.4152);
case 1331: return new CityInfo("Néoi Epivátes", "ESYE12", 40.49863, 22.91192);
case 1332: return new CityInfo("Néa Zíchni", "ESYE12", 41.03204, 23.8287);
case 1333: return new CityInfo("Néa Výssa", "ESYE11", 41.58449, 26.54318);
case 1334: return new CityInfo("Néa Tríglia", "ESYE12", 40.30575, 23.2066);
case 1335: return new CityInfo("Néa Tirolóï", "ESYE12", 41.11363, 23.3768);
case 1336: return new CityInfo("Néa Sílata", "ESYE12", 40.32946, 23.1336);
case 1337: return new CityInfo("Néa Sánta", "ESYE12", 40.84084, 22.92163);
case 1338: return new CityInfo("Néa Róda", "ESYE12", 40.38119, 23.92374);
case 1339: return new CityInfo("Néa Poteídaia", "ESYE12", 40.19409, 23.32832);
case 1340: return new CityInfo("Néa Plágia", "ESYE12", 40.26537, 23.20376);
case 1341: return new CityInfo("Néa Péramos", "ESYE11", 40.83854, 24.3013);
case 1342: return new CityInfo("Néa Pélla", "ESYE12", 40.76516, 22.49173);
case 1343: return new CityInfo("Ólynthos", "ESYE12", 40.29147, 23.34205);
case 1344: return new CityInfo("Néa Nikomídeia", "ESYE12", 40.587, 22.25007);
case 1345: return new CityInfo("Néa Moudhaniá", "ESYE12", 40.2439, 23.28484);
case 1346: return new CityInfo("Néa Michanióna", "ESYE12", 40.46371, 22.8617);
case 1347: return new CityInfo("Néa Mesimvría", "ESYE12", 40.75158, 22.76904);
case 1348: return new CityInfo("Néa Málgara", "ESYE12", 40.60985, 22.68196);
case 1349: return new CityInfo("Néa Magnisía", "ESYE12", 40.68785, 22.84582);
case 1350: return new CityInfo("Néa Lykógianni", "ESYE12", 40.5727, 22.23803);
case 1351: return new CityInfo("Néa Kerdýlia", "ESYE12", 40.79443, 23.84163);
case 1352: return new CityInfo("Néa Karváli", "ESYE11", 40.96148, 24.51132);
case 1353: return new CityInfo("Néa Karyá", "ESYE11", 40.90621, 24.70726);
case 1354: return new CityInfo("Néa Kallikráteia", "ESYE12", 40.31312, 23.06343);
case 1355: return new CityInfo("Néa Iraklítsa", "ESYE11", 40.86442, 24.3165);
case 1356: return new CityInfo("Néa Irákleia", "ESYE12", 40.34772, 23.0155);
case 1357: return new CityInfo("Néa Fókaia", "ESYE12", 40.13333, 23.39754);
case 1358: return new CityInfo("Néa Éfesos", "ESYE12", 40.22923, 22.49811);
case 1359: return new CityInfo("Néa Báfra", "ESYE12", 40.98847, 24.02036);
case 1360: return new CityInfo("Néa Apollonía", "ESYE12", 40.62558, 23.44074);
case 1361: return new CityInfo("Náousa", "ESYE12", 40.62944, 22.06806);
case 1362: return new CityInfo("Mousthéni", "ESYE11", 40.86239, 24.11271);
case 1363: return new CityInfo("Mouriés", "ESYE12", 41.25332, 22.79602);
case 1364: return new CityInfo("Monóvrysi", "ESYE12", 41.06007, 23.60501);
case 1365: return new CityInfo("Monóspita", "ESYE12", 40.61844, 22.17581);
case 1366: return new CityInfo("Myriófyto", "ESYE12", 41.22328, 22.8272);
case 1367: return new CityInfo("Miliá", "ESYE12", 40.99205, 22.14465);
case 1368: return new CityInfo("Mikrópolis", "ESYE11", 41.19351, 23.8157);
case 1369: return new CityInfo("Mikró Monastíri", "ESYE12", 40.7043, 22.54112);
case 1370: return new CityInfo("Mikrókampos", "ESYE12", 40.84098, 22.77483);
case 1371: return new CityInfo("Mýki", "ESYE11", 41.24384, 24.92084);
case 1372: return new CityInfo("Methóni", "ESYE12", 40.4474, 22.59004);
case 1373: return new CityInfo("Metagkítsi", "ESYE12", 40.32443, 23.65511);
case 1374: return new CityInfo("Metamórfosi", "ESYE12", 40.22994, 23.60358);
case 1375: return new CityInfo("Mesopotamía", "ESYE13", 40.50252, 21.1611);
case 1376: return new CityInfo("Mesiméri", "ESYE12", 40.79339, 22.0254);
case 1377: return new CityInfo("Mesiméri", "ESYE12", 40.41344, 23.0075);
case 1378: return new CityInfo("Meneméni", "ESYE12", 40.65829, 22.89712);
case 1379: return new CityInfo("Melíti", "ESYE13", 40.83434, 21.58426);
case 1380: return new CityInfo("Melissochóri", "ESYE12", 40.76796, 22.92858);
case 1381: return new CityInfo("Melíki", "ESYE12", 40.51685, 22.39599);
case 1382: return new CityInfo("Melenikítsi", "ESYE12", 41.14835, 23.44482);
case 1383: return new CityInfo("Méga Pistó", "ESYE11", 41.14712, 25.30108);
case 1384: return new CityInfo("Megalochóri", "ESYE12", 41.24688, 23.22488);
case 1385: return new CityInfo("Megáli Panagía", "ESYE12", 40.44505, 23.67999);
case 1386: return new CityInfo("Mavrovoúni", "ESYE12", 40.78243, 22.15629);
case 1387: return new CityInfo("Mavrothálassa", "ESYE12", 40.89427, 23.75048);
case 1388: return new CityInfo("Mavronéri", "ESYE12", 40.88714, 22.81345);
case 1389: return new CityInfo("Mavrólofos", "ESYE12", 40.9129, 23.87124);
case 1390: return new CityInfo("Mavrochóri", "ESYE13", 40.51224, 21.32038);
case 1391: return new CityInfo("Marína", "ESYE12", 40.692, 22.10099);
case 1392: return new CityInfo("Maniákoi", "ESYE13", 40.50064, 21.24446);
case 1393: return new CityInfo("Mándalo", "ESYE12", 40.85677, 22.21264);
case 1394: return new CityInfo("Díon", "ESYE12", 40.17169, 22.48463);
case 1395: return new CityInfo("Makrochóri", "ESYE12", 40.55125, 22.24955);
case 1396: return new CityInfo("Makrýgialos", "ESYE12", 40.41551, 22.60392);
case 1397: return new CityInfo("Loutrós", "ESYE11", 40.88153, 26.04697);
case 1398: return new CityInfo("Loutrós", "ESYE12", 40.58873, 22.39976);
case 1399: return new CityInfo("Loudías", "ESYE12", 40.67838, 22.54257);
case 1400: return new CityInfo("Lófos", "ESYE12", 40.24395, 22.38033);
case 1401: return new CityInfo("Livádi", "ESYE14", 40.12625, 22.15753);
case 1402: return new CityInfo("Livadiá", "ESYE12", 41.25172, 23.07598);
case 1403: return new CityInfo("Livaderó", "ESYE13", 40.03455, 21.94279);
case 1404: return new CityInfo("Litóchoro", "ESYE12", 40.10056, 22.49778);
case 1405: return new CityInfo("Lití", "ESYE12", 40.74533, 22.97982);
case 1406: return new CityInfo("Lithótopos", "ESYE12", 41.13444, 23.22154);
case 1407: return new CityInfo("Liparó", "ESYE12", 40.7469, 22.2474);
case 1408: return new CityInfo("Limnochóri", "ESYE12", 41.20587, 23.2046);
case 1409: return new CityInfo("Limenária", "ESYE11", 40.62741, 24.5765);
case 1410: return new CityInfo("Lýkeio", "ESYE11", 41.06413, 25.6857);
case 1411: return new CityInfo("Lianovérgi", "ESYE12", 40.63526, 22.5082);
case 1412: return new CityInfo("Lefkópetra", "ESYE11", 41.13629, 24.97932);
case 1413: return new CityInfo("Lefkónas", "ESYE12", 41.10029, 23.49658);
case 1414: return new CityInfo("Lefkádia", "ESYE12", 40.65298, 22.1191);
case 1415: return new CityInfo("Lagyná", "ESYE12", 40.72351, 23.0042);
case 1416: return new CityInfo("Lávara", "ESYE11", 41.26957, 26.38522);
case 1417: return new CityInfo("Lagkadikia", "ESYE12", 40.63569, 23.24653);
case 1418: return new CityInfo("Lagkadás", "ESYE12", 40.75, 23.06667);
case 1419: return new CityInfo("Lákkoma", "ESYE12", 40.39139, 23.05578);
case 1420: return new CityInfo("Levaía", "ESYE13", 40.64531, 21.70313);
case 1421: return new CityInfo("Laimós", "ESYE13", 40.83628, 21.14061);
case 1422: return new CityInfo("Lagós", "ESYE11", 41.45102, 26.46067);
case 1423: return new CityInfo("Krókos", "ESYE13", 40.26349, 21.8176);
case 1424: return new CityInfo("Krithiá", "ESYE12", 40.84184, 22.98292);
case 1425: return new CityInfo("Kristóni", "ESYE12", 40.95962, 22.85929);
case 1426: return new CityInfo("Kryopigí", "ESYE12", 40.03569, 23.47361);
case 1427: return new CityInfo("Kryonéri", "ESYE11", 41.02477, 24.37833);
case 1428: return new CityInfo("Kryonéri", "ESYE12", 40.81497, 23.28131);
case 1429: return new CityInfo("Krinídes", "ESYE11", 41.01396, 24.29647);
case 1430: return new CityInfo("Krýa Vrýsi", "ESYE12", 40.68738, 22.30516);
case 1431: return new CityInfo("Kozáni", "ESYE13", 40.30069, 21.78896);
case 1432: return new CityInfo("Kouloúra", "ESYE12", 40.54652, 22.31795);
case 1433: return new CityInfo("Koufóvouno", "ESYE11", 41.35533, 26.43691);
case 1434: return new CityInfo("Koufália", "ESYE12", 40.77778, 22.57194);
case 1435: return new CityInfo("Kormísta", "ESYE12", 40.98013, 24.05565);
case 1436: return new CityInfo("Korisós", "ESYE13", 40.5049, 21.37703);
case 1437: return new CityInfo("Korinós", "ESYE12", 40.31659, 22.58817);
case 1438: return new CityInfo("Koryfí", "ESYE12", 40.60286, 22.50681);
case 1439: return new CityInfo("Kopanós", "ESYE12", 40.63382, 22.12893);
case 1440: return new CityInfo("Konstantía", "ESYE12", 40.99865, 22.17355);
case 1441: return new CityInfo("Kónitsa", "ESYE21", 40.04861, 20.75667);
case 1442: return new CityInfo("Kontariótissa", "ESYE12", 40.22754, 22.461);
case 1443: return new CityInfo("Komotiní", "ESYE11", 41.11917, 25.40535);
case 1444: return new CityInfo("Komniná", "ESYE13", 40.59057, 21.77671);
case 1445: return new CityInfo("Kómara", "ESYE11", 41.59374, 26.22947);
case 1446: return new CityInfo("Kolokynthoú", "ESYE13", 40.50503, 21.2111);
case 1447: return new CityInfo("Kolchikón", "ESYE12", 40.75662, 23.13377);
case 1448: return new CityInfo("Kolindrós", "ESYE12", 40.47888, 22.48319);
case 1449: return new CityInfo("Kokkinóchoma", "ESYE11", 40.9269, 24.30805);
case 1450: return new CityInfo("Koímisi", "ESYE12", 41.21282, 23.30035);
case 1451: return new CityInfo("Koíla", "ESYE13", 40.33055, 21.79102);
case 1452: return new CityInfo("Kleítos", "ESYE13", 40.4314, 21.85806);
case 1453: return new CityInfo("Kleidí", "ESYE12", 40.56632, 22.59033);
case 1454: return new CityInfo("Kítros", "ESYE12", 40.37399, 22.57862);
case 1455: return new CityInfo("Kýria", "ESYE11", 41.099, 24.28915);
case 1456: return new CityInfo("Kyprínos", "ESYE11", 41.57542, 26.22905);
case 1457: return new CityInfo("Kimméria", "ESYE11", 41.14788, 24.93869);
case 1458: return new CityInfo("Kýmina", "ESYE12", 40.61354, 22.69278);
case 1459: return new CityInfo("Kilkís", "ESYE12", 40.99302, 22.87433);
case 1460: return new CityInfo("Chrysoúpolis", "ESYE11", 40.98556, 24.69389);
case 1461: return new CityInfo("Chrysó", "ESYE12", 41.05806, 23.65108);
case 1462: return new CityInfo("Chrysochóri", "ESYE11", 40.93328, 24.71088);
case 1463: return new CityInfo("Chrysochórafa", "ESYE12", 41.18097, 23.23551);
case 1464: return new CityInfo("Chortiátis", "ESYE12", 40.60954, 23.10014);
case 1465: return new CityInfo("Chorteró", "ESYE12", 41.21947, 23.36874);
case 1466: return new CityInfo("Chorýgio", "ESYE12", 40.99594, 22.72637);
case 1467: return new CityInfo("Choristí", "ESYE11", 41.13056, 24.20843);
case 1468: return new CityInfo("Cheímarros", "ESYE12", 41.11048, 23.25815);
case 1469: return new CityInfo("Chiliódendro", "ESYE13", 40.48723, 21.19136);
case 1470: return new CityInfo("Chérso", "ESYE12", 41.08921, 22.78067);
case 1471: return new CityInfo("Charopó", "ESYE12", 41.26031, 23.37279);
case 1472: return new CityInfo("Charíessa", "ESYE12", 40.65139, 22.16659);
case 1473: return new CityInfo("Chalkidóna", "ESYE12", 40.73184, 22.59992);
case 1474: return new CityInfo("Kerkíni", "ESYE12", 41.21887, 23.08454);
case 1475: return new CityInfo("Keramotí", "ESYE11", 40.85591, 24.70595);
case 1476: return new CityInfo("Kélli", "ESYE13", 40.78667, 21.68895);
case 1477: return new CityInfo("Kefalóvryso", "ESYE21", 40.01234, 20.55817);
case 1478: return new CityInfo("Kefalochóri", "ESYE12", 40.56889, 22.36576);
case 1479: return new CityInfo("Kavýli", "ESYE11", 41.56225, 26.5147);
case 1480: return new CityInfo("Kavásila", "ESYE12", 40.59142, 22.33192);
case 1481: return new CityInfo("Kavallári", "ESYE12", 40.71539, 23.04588);
case 1482: return new CityInfo("Kavála", "ESYE11", 40.93959, 24.40687);
case 1483: return new CityInfo("Káto Scholári", "ESYE12", 40.42906, 23.02978);
case 1484: return new CityInfo("Káto Nevrokópi", "ESYE11", 41.35, 23.86667);
case 1485: return new CityInfo("Káto Miliá", "ESYE12", 40.25403, 22.34342);
case 1486: return new CityInfo("Loutráki", "ESYE12", 40.97116, 21.94659);
case 1487: return new CityInfo("Káto Lipochóri", "ESYE12", 40.75754, 22.17962);
case 1488: return new CityInfo("Káto Kamíla", "ESYE12", 41.02119, 23.48336);
case 1489: return new CityInfo("Kateríni", "ESYE12", 40.26956, 22.50608);
case 1490: return new CityInfo("Katachás", "ESYE12", 40.46693, 22.54204);
case 1491: return new CityInfo("Kastoria", "ESYE13", 40.52165, 21.26341);
case 1492: return new CityInfo("Kastanoússa", "ESYE12", 41.27743, 22.89398);
case 1493: return new CityInfo("Kastaniés", "ESYE11", 41.64551, 26.47676);
case 1494: return new CityInfo("Kastaniá", "ESYE13", 40.17434, 22.02368);
case 1495: return new CityInfo("Kastanás", "ESYE12", 40.81917, 22.65875);
case 1496: return new CityInfo("Kassándreia", "ESYE12", 40.04835, 23.41362);
case 1497: return new CityInfo("Karperí", "ESYE12", 41.13212, 23.30436);
case 1498: return new CityInfo("Karotí", "ESYE11", 41.40611, 26.42557);
case 1499: return new CityInfo("Símantra", "ESYE12", 40.34563, 23.31026);
case 1500: return new CityInfo("Karítsa", "ESYE12", 40.18745, 22.48171);
case 1501: return new CityInfo("Karyótissa", "ESYE12", 40.76915, 22.31331);
case 1502: return new CityInfo("Karianí", "ESYE11", 40.75139, 23.98262);
case 1503: return new CityInfo("Karyes", "736572", 40.25715, 24.24498);
case 1504: return new CityInfo("Kardiá", "ESYE12", 40.46909, 22.99378);
case 1505: return new CityInfo("Kampochóri", "ESYE12", 40.60953, 22.36954);
case 1506: return new CityInfo("Kampánis", "ESYE12", 40.88951, 22.91682);
case 1507: return new CityInfo("Kamariótissa", "ESYE11", 40.47501, 25.47456);
case 1508: return new CityInfo("Kalós Agrós", "ESYE11", 41.10543, 24.0857);
case 1509: return new CityInfo("Kalochóri", "ESYE12", 40.64189, 22.85734);
case 1510: return new CityInfo("Kallithéa", "ESYE12", 40.2739, 22.57775);
case 1511: return new CityInfo("Kallithéa", "ESYE12", 40.07374, 23.44637);
case 1512: return new CityInfo("Kallípoli", "ESYE12", 40.79004, 22.23339);
case 1513: return new CityInfo("Kallífytos", "ESYE11", 41.1728, 24.21527);
case 1514: return new CityInfo("Kalí Vrýsi", "ESYE11", 41.14653, 23.90667);
case 1515: return new CityInfo("Kalýves Polygýrou", "ESYE12", 40.28659, 23.39033);
case 1516: return new CityInfo("Ágios Spyrídon", "ESYE12", 40.20778, 22.44311);
case 1517: return new CityInfo("Kalývia", "ESYE12", 40.75508, 22.21753);
case 1518: return new CityInfo("Prínos", "ESYE11", 40.7409, 24.57787);
case 1519: return new CityInfo("Kalí", "ESYE12", 40.81931, 22.17761);
case 1520: return new CityInfo("Kalamotó", "ESYE12", 40.55613, 23.3735);
case 1521: return new CityInfo("Kalampáki", "ESYE11", 41.05, 24.18333);
case 1522: return new CityInfo("Kalamariá", "ESYE12", 40.5825, 22.95028);
case 1523: return new CityInfo("Kalá Déndra", "ESYE12", 41.09941, 23.42396);
case 1524: return new CityInfo("Ívira", "ESYE12", 40.89537, 23.69857);
case 1525: return new CityInfo("Itéa", "ESYE13", 40.83582, 21.51351);
case 1526: return new CityInfo("Léchovo", "ESYE13", 40.58442, 21.49218);
case 1527: return new CityInfo("Iráklion", "ESYE12", 40.7568, 23.0356);
case 1528: return new CityInfo("Irákleia", "ESYE12", 41.18217, 23.28243);
case 1529: return new CityInfo("Ierissós", "ESYE12", 40.39748, 23.87505);
case 1530: return new CityInfo("Lydía", "ESYE11", 41.03061, 24.28153);
case 1531: return new CityInfo("Ída", "ESYE12", 41.00991, 22.1765);
case 1532: return new CityInfo("Íasmos", "ESYE11", 41.12747, 25.18573);
case 1533: return new CityInfo("Gríva", "ESYE12", 40.95433, 22.41037);
case 1534: return new CityInfo("Grevená", "ESYE13", 40.08452, 21.42744);
case 1535: return new CityInfo("Gravoúna", "ESYE11", 40.99505, 24.6525);
case 1536: return new CityInfo("Gouménissa", "ESYE12", 40.94604, 22.44974);
case 1537: return new CityInfo("Gorgópi", "ESYE12", 40.96083, 22.5243);
case 1538: return new CityInfo("Gomáti", "ESYE12", 40.39608, 23.79547);
case 1539: return new CityInfo("Gázoros", "ESYE12", 41.02557, 23.77574);
case 1540: return new CityInfo("Ganóchora", "ESYE12", 40.30888, 22.49577);
case 1541: return new CityInfo("Gallikós", "ESYE12", 40.85817, 22.87604);
case 1542: return new CityInfo("Galátista", "ESYE12", 40.4682, 23.28015);
case 1543: return new CityInfo("Galatiní", "ESYE13", 40.31966, 21.55148);
case 1544: return new CityInfo("Galatádes", "ESYE12", 40.7559, 22.28062);
case 1545: return new CityInfo("Fotolívos", "ESYE11", 41.06013, 24.04724);
case 1546: return new CityInfo("Foliá", "ESYE11", 40.80935, 24.15686);
case 1547: return new CityInfo("Néa Flogitá", "ESYE12", 40.26108, 23.22107);
case 1548: return new CityInfo("Flórina", "ESYE13", 40.78197, 21.40981);
case 1549: return new CityInfo("Flamouriá", "ESYE12", 40.75258, 22.01691);
case 1550: return new CityInfo("Flámpouro", "ESYE12", 40.93132, 23.56667);
case 1551: return new CityInfo("Anthí", "ESYE12", 40.94403, 23.5063);
case 1552: return new CityInfo("Fyteía", "ESYE12", 40.56325, 22.10968);
case 1553: return new CityInfo("Filóteia", "ESYE12", 41.03436, 22.15207);
case 1554: return new CityInfo("Filótas", "ESYE13", 40.6252, 21.70851);
case 1555: return new CityInfo("Fillýra", "ESYE11", 41.11667, 25.63333);
case 1556: return new CityInfo("Fíliro", "ESYE12", 40.69151, 23.0046);
case 1557: return new CityInfo("Fílippoi", "ESYE11", 41.02504, 24.33933);
case 1558: return new CityInfo("Néa Filadélfeia", "ESYE12", 40.79798, 22.84048);
case 1559: return new CityInfo("Féres", "ESYE11", 40.89305, 26.17234);
case 1560: return new CityInfo("Exaplátanos", "ESYE12", 40.97643, 22.12958);
case 1561: return new CityInfo("Evropós", "ESYE12", 40.89703, 22.55277);
case 1562: return new CityInfo("Évosmos", "ESYE12", 40.67056, 22.90833);
case 1563: return new CityInfo("Évlalo", "ESYE11", 40.98333, 24.8);
case 1564: return new CityInfo("Efkarpía", "ESYE12", 41.07374, 22.90818);
case 1565: return new CityInfo("Efkarpía", "ESYE12", 40.86285, 23.77186);
case 1566: return new CityInfo("Efkarpía", "ESYE12", 40.68797, 22.95348);
case 1567: return new CityInfo("Esóvalta", "ESYE12", 40.70733, 22.26385);
case 1568: return new CityInfo("Erátyra", "ESYE13", 40.34253, 21.51333);
case 1569: return new CityInfo("Erateinó", "ESYE11", 40.95008, 24.63993);
case 1570: return new CityInfo("Eptámyloi", "ESYE12", 41.10063, 23.59144);
case 1571: return new CityInfo("Episkopí", "ESYE12", 40.68748, 22.1364);
case 1572: return new CityInfo("Episkopí", "ESYE12", 40.59148, 22.36466);
case 1573: return new CityInfo("Epanomí", "ESYE12", 40.42614, 22.92782);
case 1574: return new CityInfo("Néa Kerasiá", "ESYE12", 40.47539, 22.86891);
case 1575: return new CityInfo("Emmanouíl Pappás", "ESYE12", 41.08548, 23.70981);
case 1576: return new CityInfo("Empório", "ESYE13", 40.48866, 21.55768);
case 1577: return new CityInfo("Eleftheroúpolis", "ESYE11", 40.91389, 24.25139);
case 1578: return new CityInfo("Eleftherés", "ESYE11", 40.84666, 24.25431);
case 1579: return new CityInfo("Eleoúsa", "ESYE12", 40.7482, 22.62638);
case 1580: return new CityInfo("Elatochori", "ESYE12", 40.31948, 22.25804);
case 1581: return new CityInfo("Elaiochóri", "ESYE11", 40.8203, 24.24373);
case 1582: return new CityInfo("Echínos", "ESYE11", 41.27558, 24.97237);
case 1583: return new CityInfo("Édessa", "ESYE12", 40.8026, 22.04751);
case 1584: return new CityInfo("Dráma", "ESYE11", 41.15283, 24.1473);
case 1585: return new CityInfo("Droseró", "ESYE12", 40.82291, 22.24816);
case 1586: return new CityInfo("Drosáto", "ESYE12", 41.16641, 22.80298);
case 1587: return new CityInfo("Drymós", "ESYE12", 40.78099, 22.95889);
case 1588: return new CityInfo("Dravískos", "ESYE12", 40.92393, 23.87119);
case 1589: return new CityInfo("Dorothéa", "ESYE12", 40.99455, 22.05749);
case 1590: return new CityInfo("Dispilió", "ESYE13", 40.48148, 21.28786);
case 1591: return new CityInfo("Dimitrítsi", "ESYE12", 40.98508, 23.41347);
case 1592: return new CityInfo("Díkaia", "ESYE11", 41.70546, 26.29498);
case 1593: return new CityInfo("Didymóteicho", "ESYE11", 41.34806, 26.49611);
case 1594: return new CityInfo("Diavatós", "ESYE12", 40.54606, 22.26686);
case 1595: return new CityInfo("Diavatá", "ESYE12", 40.68744, 22.85799);
case 1596: return new CityInfo("Dasochóri", "ESYE12", 41.16338, 23.26798);
case 1597: return new CityInfo("Dadía", "ESYE11", 41.12826, 26.22441);
case 1598: return new CityInfo("Ágios Geórgios", "ESYE12", 40.60215, 22.1943);
case 1599: return new CityInfo("Ágios Vasíleios", "ESYE12", 40.66424, 23.11373);
case 1600: return new CityInfo("Ágios Pétros", "ESYE12", 40.86725, 22.58298);
case 1601: return new CityInfo("Ágios Panteleímonas", "ESYE13", 40.72398, 21.74825);
case 1602: return new CityInfo("Ágios Nikólaos", "ESYE12", 40.24926, 23.69616);
case 1603: return new CityInfo("Ágios Mámas", "ESYE12", 40.25906, 23.33574);
case 1604: return new CityInfo("Ágios Loukás", "ESYE12", 40.71799, 22.29545);
case 1605: return new CityInfo("Ágios Ioánnis", "ESYE12", 41.09973, 23.58022);
case 1606: return new CityInfo("Káto Ágios Ioánnis", "ESYE12", 40.32663, 22.52636);
case 1607: return new CityInfo("Ágios Dimítrios", "ESYE12", 40.15559, 22.23048);
case 1608: return new CityInfo("Ágios Athanásios", "ESYE11", 41.07463, 24.24545);
case 1609: return new CityInfo("Ágios Athanásios", "ESYE12", 40.71598, 22.72841);
case 1610: return new CityInfo("Ágio Pnévma", "ESYE12", 41.10142, 23.67992);
case 1611: return new CityInfo("Agía Varvára", "ESYE12", 40.49588, 22.24439);
case 1612: return new CityInfo("Agía Triáda", "ESYE12", 40.50003, 22.87351);
case 1613: return new CityInfo("Agíasma", "ESYE11", 40.90795, 24.65636);
case 1614: return new CityInfo("Agía Paraskeví", "ESYE12", 40.94935, 23.45706);
case 1615: return new CityInfo("Agía Paraskeví", "ESYE12", 40.4815, 23.04863);
case 1616: return new CityInfo("Agía Marína", "ESYE12", 40.59722, 22.21533);
case 1617: return new CityInfo("Axioúpoli", "ESYE12", 40.98582, 22.54165);
case 1618: return new CityInfo("Avlí", "ESYE11", 40.87302, 24.17889);
case 1619: return new CityInfo("Ávato", "ESYE11", 40.96279, 24.80441);
case 1620: return new CityInfo("Áthyra", "ESYE12", 40.82615, 22.59279);
case 1621: return new CityInfo("Asvestochóri", "ESYE12", 40.64125, 23.02528);
case 1622: return new CityInfo("Ássiros", "ESYE12", 40.82143, 23.03008);
case 1623: return new CityInfo("Asproválta", "ESYE12", 40.73049, 23.7118);
case 1624: return new CityInfo("Áspros", "ESYE12", 40.9011, 22.6304);
case 1625: return new CityInfo("Áspro", "ESYE12", 40.73566, 22.21512);
case 1626: return new CityInfo("Askós", "ESYE12", 40.75105, 23.38721);
case 1627: return new CityInfo("Arsénio", "ESYE12", 40.71412, 22.15923);
case 1628: return new CityInfo("Arrianá", "ESYE11", 41.08131, 25.69494);
case 1629: return new CityInfo("Árnissa", "ESYE12", 40.79555, 21.83577);
case 1630: return new CityInfo("Arnaía", "ESYE12", 40.48652, 23.59537);
case 1631: return new CityInfo("Armenokhórion", "ESYE13", 40.80257, 21.46085);
case 1632: return new CityInfo("Archángelos", "ESYE12", 41.08213, 22.27914);
case 1633: return new CityInfo("Arísvi", "ESYE11", 41.07, 25.59041);
case 1634: return new CityInfo("Aridaía", "ESYE12", 40.97306, 22.05639);
case 1635: return new CityInfo("Argos Orestiko", "ESYE13", 40.45354, 21.25889);
case 1636: return new CityInfo("Aréthousa", "ESYE12", 40.74405, 23.58807);
case 1637: return new CityInfo("Árdassa", "ESYE13", 40.47734, 21.63352);
case 1638: return new CityInfo("Aravissós", "ESYE12", 40.84352, 22.30178);
case 1639: return new CityInfo("Áratos", "ESYE11", 41.08139, 25.55186);
case 1640: return new CityInfo("Ápsalos", "ESYE12", 40.8924, 22.05709);
case 1641: return new CityInfo("Ántheia", "ESYE11", 40.87132, 25.9902);
case 1642: return new CityInfo("Áno Zervochóri", "ESYE12", 40.65648, 22.21576);
case 1643: return new CityInfo("Áno Poróïa", "ESYE12", 41.28562, 23.03683);
case 1644: return new CityInfo("Mitroúsi", "ESYE12", 41.07041, 23.46064);
case 1645: return new CityInfo("Áno Kómi", "ESYE13", 40.2266, 21.82827);
case 1646: return new CityInfo("Áno Kamíla", "ESYE12", 41.05695, 23.42391);
case 1647: return new CityInfo("Áno Ágios Ioánnis", "ESYE12", 40.31997, 22.49356);
case 1648: return new CityInfo("Anchíalos", "ESYE12", 40.71509, 22.78012);
case 1649: return new CityInfo("Angelochóri", "ESYE12", 40.67862, 22.19933);
case 1650: return new CityInfo("Angelochórion", "ESYE12", 40.49717, 22.8344);
case 1651: return new CityInfo("Agkathiá", "ESYE12", 40.55535, 22.47083);
case 1652: return new CityInfo("Antifílippoi", "ESYE11", 40.94596, 24.21091);
case 1653: return new CityInfo("Anayénnisis", "ESYE12", 41.10982, 23.33256);
case 1654: return new CityInfo("Anatolikó", "ESYE12", 40.66152, 22.7119);
case 1655: return new CityInfo("Anatolikó", "ESYE13", 40.54446, 21.74841);
case 1656: return new CityInfo("Anaráchi", "ESYE13", 40.49234, 21.57279);
case 1657: return new CityInfo("Ammoulianí", "ESYE12", 40.33272, 23.92149);
case 1658: return new CityInfo("Ammoudhiá", "ESYE12", 41.14324, 23.33539);
case 1659: return new CityInfo("Ammochóri", "ESYE13", 40.78203, 21.48458);
case 1660: return new CityInfo("Amisianá", "ESYE11", 40.93293, 24.33835);
case 1661: return new CityInfo("Amýntaio", "ESYE13", 40.68967, 21.67974);
case 1662: return new CityInfo("Amygdaleónas", "ESYE11", 40.96346, 24.36007);
case 1663: return new CityInfo("Ampelókipoi", "ESYE13", 40.46582, 21.31001);
case 1664: return new CityInfo("Ampeleíes", "ESYE12", 40.83417, 22.38767);
case 1665: return new CityInfo("Alónia", "ESYE12", 40.39386, 22.54021);
case 1666: return new CityInfo("Alistráti", "ESYE12", 41.06443, 23.95751);
case 1667: return new CityInfo("Alexandroupoli", "ESYE11", 40.84995, 25.87644);
case 1668: return new CityInfo("Alexándreia", "ESYE12", 40.62667, 22.44417);
case 1669: return new CityInfo("Akropótamos", "ESYE12", 40.84024, 22.65408);
case 1670: return new CityInfo("Akropótamos", "ESYE11", 40.78916, 24.03504);
case 1671: return new CityInfo("Akriní", "ESYE13", 40.43492, 21.90609);
case 1672: return new CityInfo("Achladochóri", "ESYE12", 41.31976, 23.54026);
case 1673: return new CityInfo("Achladochóri", "ESYE12", 40.83703, 22.34227);
case 1674: return new CityInfo("Achinós", "ESYE12", 40.92054, 23.6563);
case 1675: return new CityInfo("Aigínio", "ESYE12", 40.50139, 22.54);
case 1676: return new CityInfo("Aianí", "ESYE13", 40.16381, 21.81945);
case 1677: return new CityInfo("Ágras", "ESYE12", 40.8055, 22.00363);
case 1678: return new CityInfo("Áfytos", "ESYE12", 40.09915, 23.4367);
case 1679: return new CityInfo("Aetós", "ESYE13", 40.66121, 21.55395);
case 1680: return new CityInfo("Ádendro", "ESYE12", 40.67131, 22.60466);
case 1681: return new CityInfo("Néa Trapezoúnta", "ESYE12", 40.33419, 22.5245);
case 1682: return new CityInfo("Eirinoúpoli", "ESYE12", 40.67806, 22.19278);
case 1683: return new CityInfo("Paralímni", "ESYE12", 40.75113, 22.4541);
case 1684: return new CityInfo("Ágios Pávlos", "ESYE12", 40.64075, 22.96039);
case 1685: return new CityInfo("Triandría", "ESYE12", 40.615, 22.9762);
case 1686: return new CityInfo("Xifianí", "ESYE12", 40.93011, 22.08052);
case 1687: return new CityInfo("Trifýlli", "ESYE12", 40.79084, 22.26373);
case 1688: return new CityInfo("Melíssi", "ESYE12", 40.77406, 22.35304);
case 1689: return new CityInfo("Andromáchi", "ESYE12", 40.273, 22.48109);
case 1690: return new CityInfo("Moschopótamos", "ESYE12", 40.32579, 22.30868);
case 1691: return new CityInfo("Élafos", "ESYE12", 40.37372, 22.39738);
case 1692: return new CityInfo("Kalývia", "ESYE14", 40.023, 22.24078);
case 1693: return new CityInfo("Metaxádes", "ESYE11", 41.41944, 26.22504);
case 1694: return new CityInfo("Giannádes", "ESYE22", 39.63098, 19.76312);
case 1695: return new CityInfo("Virós", "ESYE22", 39.5834, 19.8827);
case 1696: return new CityInfo("Spartýlas", "ESYE22", 39.72089, 19.84147);
case 1697: return new CityInfo("Sinarádes", "ESYE22", 39.56577, 19.8483);
case 1698: return new CityInfo("Róda", "ESYE22", 39.78683, 19.79297);
case 1699: return new CityInfo("Potamós", "ESYE22", 39.6242, 19.87826);
case 1700: return new CityInfo("Perouládes", "ESYE22", 39.78638, 19.67317);
case 1701: return new CityInfo("Othonoí", "ESYE22", 39.84231, 19.40494);
case 1702: return new CityInfo("Nýmfes", "ESYE22", 39.75594, 19.78492);
case 1703: return new CityInfo("Moraḯtika", "ESYE22", 39.48467, 19.92469);
case 1704: return new CityInfo("Liapádes", "ESYE22", 39.66918, 19.7402);
case 1705: return new CityInfo("Kontokáli", "ESYE22", 39.64436, 19.85194);
case 1706: return new CityInfo("Kompítsion", "ESYE22", 39.60527, 19.86719);
case 1707: return new CityInfo("Kokkínion", "ESYE22", 39.60919, 19.815);
case 1708: return new CityInfo("Kynopiástes", "ESYE22", 39.56785, 19.88362);
case 1709: return new CityInfo("Corfu", "ESYE22", 39.62441, 19.92016);
case 1710: return new CityInfo("Kavvadádes", "ESYE22", 39.74554, 19.67943);
case 1711: return new CityInfo("Káto Korakiána", "ESYE22", 39.68969, 19.82809);
case 1712: return new CityInfo("Káto Garoúna", "ESYE22", 39.53916, 19.86483);
case 1713: return new CityInfo("Kastanéa", "ESYE22", 39.59279, 19.88459);
case 1714: return new CityInfo("Kassiopi", "ESYE22", 39.78822, 19.92125);
case 1715: return new CityInfo("Karousádes", "ESYE22", 39.78028, 19.74475);
case 1716: return new CityInfo("Kanáli", "ESYE22", 39.60556, 19.8925);
case 1717: return new CityInfo("Ypsos", "ESYE22", 39.69472, 19.83667);
case 1718: return new CityInfo("Gouviá", "ESYE22", 39.65283, 19.8425);
case 1719: return new CityInfo("Gastoúri", "ESYE22", 39.5611, 19.89842);
case 1720: return new CityInfo("Doukádes", "ESYE22", 39.68988, 19.74084);
case 1721: return new CityInfo("Benítses", "ESYE22", 39.54367, 19.91369);
case 1722: return new CityInfo("Ágios Matthaíos", "ESYE22", 39.49506, 19.87336);
case 1723: return new CityInfo("Ágios Ioánnis", "ESYE22", 39.61571, 19.84762);
case 1724: return new CityInfo("Avliótes", "ESYE22", 39.77767, 19.66378);
case 1725: return new CityInfo("Argyrádes", "ESYE22", 39.43517, 19.97632);
case 1726: return new CityInfo("Áno Korakiána", "ESYE22", 39.70567, 19.79226);
case 1727: return new CityInfo("Alepoú", "ESYE22", 39.61594, 19.89564);
case 1728: return new CityInfo("Áfra", "ESYE22", 39.62162, 19.85837);
case 1729: return new CityInfo("Vrilissia", "ESYE31", 38.03381, 23.82962);
case 1730: return new CityInfo("Faliraki", "ESYE42", 36.33981, 28.19942);
case 1731: return new CityInfo("Laganás", "ESYE22", 37.72837, 20.8678);
case 1732: return new CityInfo("Platýs Gialós", "ESYE42", 37.41448, 25.3422);
case 1733: return new CityInfo("Agios Geórgios Argyrádon", "ESYE22", 39.42711, 19.94877);
case 1734: return new CityInfo("Potós", "ESYE11", 40.61154, 24.608);
case 1735: return new CityInfo("Acharávi", "ESYE22", 39.7936, 19.81736);
case 1736: return new CityInfo("Agios Georgis", "ESYE22", 39.72363, 19.69969);
case 1737: return new CityInfo("Férma", "ESYE43", 35.01896, 25.85371);
case 1738: return new CityInfo("Georgioupolis", "ESYE43", 35.36225, 24.26013);
case 1739: return new CityInfo("Ístro", "ESYE43", 35.12468, 25.73882);
case 1740: return new CityInfo("Ligia", "ESYE22", 38.78697, 20.71923);
case 1741: return new CityInfo("Ornós", "ESYE42", 37.42391, 25.32248);
case 1742: return new CityInfo("Arvi", "ESYE43", 34.99214, 25.45515);
case 1743: return new CityInfo("Pánormos", "ESYE42", 36.97156, 26.93727);
case 1744: return new CityInfo("Káto Goúves", "ESYE43", 35.32934, 25.31353);
case 1745: return new CityInfo("Saronída", "ESYE31", 37.74809, 23.91059);
case 1746: return new CityInfo("Karterós", "ESYE43", 35.32969, 25.2065);
case 1747: return new CityInfo("Ymittos", "ESYE31", 37.95342, 23.74897);
case 1748: return new CityInfo("Makry-Gialos", "ESYE43", 35.03715, 25.97179);
case 1749: return new CityInfo("Gérakas", "ESYE31", 38.02277, 23.8576);
case 1750: return new CityInfo("Megálo Chorió", "ESYE42", 37.4582, 26.97272);
case 1751: return new CityInfo("Toúrlos", "ESYE42", 37.4634, 25.33022);
case 1752: return new CityInfo("Kolonaki", "ESYE31", 37.97866, 23.74103);
case 1753: return new CityInfo("Ágioi Theódoroi", "ESYE43", 35.31915, 25.09307);
case 1754: return new CityInfo("Adelianós Kámpos", "ESYE43", 35.3721, 24.5414);
case 1755: return new CityInfo("Paralía Ofryníou", "ESYE11", 40.76663, 23.90039);
case 1756: return new CityInfo("Agía Kyriakí", "ESYE21", 39.52264, 20.88358);
case 1757: return new CityInfo("Agía Foteiní", "ESYE43", 35.25459, 24.63495);
case 1758: return new CityInfo("Ilioúpoli", "ESYE31", 37.93149, 23.76779);
case 1759: return new CityInfo("Korydallós", "ESYE31", 37.98468, 23.64711);
case 1760: return new CityInfo("Paralía Dionysíou", "ESYE12", 40.25045, 23.24982);
case 1761: return new CityInfo("Zográfos", "ESYE31", 37.97574, 23.76911);
case 1762: return new CityInfo("Péfki", "ESYE31", 38.06019, 23.79264);
case 1763: return new CityInfo("Ágioi Anárgyroi", "ESYE31", 38.03013, 23.72379);
case 1764: return new CityInfo("Ampelókipoi", "ESYE12", 40.65304, 22.92624);
case 1765: return new CityInfo("Foúrnoi", "ESYE41", 37.5785, 26.48069);
case 1766: return new CityInfo("Néa Potídhaia", "ESYE12", 40.19428, 23.32874);
case 1767: return new CityInfo("Tavronítis", "ESYE43", 35.52997, 23.82029);
case 1768: return new CityInfo("Klouvás", "ESYE42", 37.45265, 25.34863);
case 1769: return new CityInfo("Agios Ioannis Rentis", "ESYE31", 37.96491, 23.66511);
case 1770: return new CityInfo("Violí Charáki", "ESYE43", 35.35864, 24.43857);
case 1771: return new CityInfo("Sfakáki", "ESYE43", 35.38132, 24.58257);
case 1772: return new CityInfo("Vatheianós Kámpos", "ESYE43", 35.32104, 25.24422);
case 1773: return new CityInfo("Néa Anatolí", "ESYE43", 35.0092, 25.6617);
case 1774: return new CityInfo("Análipsi", "ESYE43", 35.03996, 25.98059);
case 1775: return new CityInfo("Drapetsóna", "ESYE31", 37.94988, 23.62309);
case 1776: return new CityInfo("Néo Psychikó", "ESYE31", 38.00624, 23.78373);
case 1777: return new CityInfo("Chlói", "ESYE13", 40.53918, 21.25923);
case 1778: return new CityInfo("Pláka", "ESYE42", 36.74387, 24.42262);
case 1779: return new CityInfo("Varybóbi", "ESYE31", 38.12723, 23.78729);
case 1780: return new CityInfo("Aghios Panteleímon", "ESYE31", 38.11643, 23.98182);
case 1781: return new CityInfo("Anthoúsa", "ESYE31", 38.02544, 23.87617);
case 1782: return new CityInfo("Néa Vrasná", "ESYE12", 40.70592, 23.6985);
case 1783: return new CityInfo("Néa Ionía", "ESYE14", 39.37904, 22.92752);
case 1784: return new CityInfo("Zefyri", "ESYE31", 38.06647, 23.71701);
case 1785: return new CityInfo("Thrakomakedónes", "ESYE31", 38.12964, 23.75751);
case 1786: return new CityInfo("Néa Pentéli", "ESYE31", 38.06059, 23.85926);
case 1787: return new CityInfo("Néa Chalkidóna", "ESYE31", 38.0271, 23.73051);
case 1788: return new CityInfo("Thymári", "ESYE31", 37.69581, 23.94483);
case 1789: return new CityInfo("Kítsi", "ESYE31", 37.85181, 23.84068);
case 1790: return new CityInfo("Agía Marína", "ESYE31", 37.82036, 23.84424);
case 1791: return new CityInfo("Agios Dimítrios Kropiás", "ESYE31", 37.80612, 23.85793);
case 1792: return new CityInfo("Karellás", "ESYE31", 37.93445, 23.86484);
case 1793: return new CityInfo("Ergatikés Katoikíes Attikís", "ESYE31", 37.71733, 24.03646);
case 1794: return new CityInfo("Neos Voutzás", "ESYE31", 38.04312, 23.97749);
case 1795: return new CityInfo("Argithéa", "ESYE31", 37.97506, 23.88556);
case 1796: return new CityInfo("Dióni", "ESYE31", 38.02328, 23.93286);
case 1797: return new CityInfo("Kallitechnoúpoli", "ESYE31", 38.02639, 23.95758);
case 1798: return new CityInfo("Néos Kouvarás", "ESYE31", 37.82436, 23.95539);
case 1799: return new CityInfo("Agia Kyriakií Spáton", "ESYE31", 37.99336, 23.97796);
case 1800: return new CityInfo("Neápoli Spáton", "ESYE31", 37.96552, 23.97873);
case 1801: return new CityInfo("Christoúpoli", "ESYE31", 37.97835, 23.9179);
case 1802: return new CityInfo("Agía Triáda", "ESYE31", 38.20345, 23.80308);
case 1803: return new CityInfo("Néa Politeía", "ESYE31", 38.30226, 23.78634);
case 1804: return new CityInfo("Néa Zoí", "ESYE31", 38.08343, 23.48413);
case 1805: return new CityInfo("Vlycháda", "ESYE31", 38.02734, 23.43663);
case 1806: return new CityInfo("Lákka Kalogírou", "ESYE31", 37.99407, 23.38556);
case 1807: return new CityInfo("Metamórfosi", "ESYE21", 39.79047, 20.73944);
case 1808: return new CityInfo("Ksyróvrisi", "ESYE24", 38.46424, 23.57237);
case 1809: return new CityInfo("Perama", "ESYE22", 39.58289, 19.9122);
case 1810: return new CityInfo("Chrysiída", "ESYE22", 39.59011, 19.89736);
case 1811: return new CityInfo("Kyrá Chrysikoú", "ESYE22", 39.64035, 19.83517);
case 1812: return new CityInfo("Límni", "ESYE22", 39.66336, 19.84787);
case 1813: return new CityInfo("Káto Agios Márkos", "ESYE22", 39.7061, 19.83337);
case 1814: return new CityInfo("Alónia", "ESYE22", 37.8265, 20.79854);
case 1815: return new CityInfo("Kallitéros", "ESYE22", 37.75792, 20.90072);
case 1816: return new CityInfo("Prósfyges", "ESYE11", 40.9857, 24.37531);
case 1817: return new CityInfo("Panagiá", "ESYE11", 40.89785, 24.24176);
case 1818: return new CityInfo("Archaío Limáni", "ESYE25", 37.93063, 22.89317);
case 1819: return new CityInfo("Káto Examília", "ESYE25", 37.90754, 22.93984);
case 1820: return new CityInfo("Loutrá Oraías Elénis", "ESYE25", 37.86466, 22.99614);
case 1821: return new CityInfo("Efédron Anagénnisi", "ESYE31", 38.10211, 23.85025);
case 1822: return new CityInfo("Agía Paraskeví Lamiéon", "ESYE24", 38.90105, 22.49024);
case 1823: return new CityInfo("Paralía Vérgas", "ESYE25", 37.00708, 22.15676);
case 1824: return new CityInfo("Kardamítsia", "ESYE21", 39.67816, 20.81956);
case 1825: return new CityInfo("Káto Mármara", "ESYE21", 39.64281, 20.82815);
case 1826: return new CityInfo("Velissários", "ESYE21", 39.65025, 20.83932);
case 1827: return new CityInfo("Pentéli", "ESYE21", 39.66548, 20.83664);
case 1828: return new CityInfo("Tsiflikópoulo", "ESYE21", 39.65624, 20.83882);
case 1829: return new CityInfo("Eksochí", "ESYE21", 39.68744, 20.8224);
case 1830: return new CityInfo("Káto Neochorópoulo", "ESYE21", 39.64023, 20.84094);
case 1831: return new CityInfo("Néa Léfki", "ESYE13", 40.50691, 21.24129);
case 1832: return new CityInfo("Análipsi", "ESYE13", 40.69686, 21.68313);
case 1833: return new CityInfo("Pláka Dílesi", "ESYE24", 38.3495, 23.65056);
case 1834: return new CityInfo("Paralía Vathéos", "ESYE24", 38.41537, 23.61372);
case 1835: return new CityInfo("Garéfeion", "ESYE12", 41.02778, 22.04621);
case 1836: return new CityInfo("Plintrí", "ESYE42", 37.42522, 25.36155);
case 1837: return new CityInfo("Anakasiá", "ESYE14", 39.38112, 22.97484);
case 1838: return new CityInfo("Íkaros", "ESYE23", 37.92022, 21.17623);
case 1839: return new CityInfo("Ágios Arsénios", "ESYE42", 37.06134, 25.39145);
case 1840: return new CityInfo("Símantra", "ESYE11", 41.13772, 25.02535);
case 1841: return new CityInfo("Fília", "ESYE11", 41.13888, 25.00368);
case 1842: return new CityInfo("Mavrika", "ESYE14", 39.34253, 21.94103);
case 1843: return new CityInfo("Iliokentima", "ESYE11", 40.94931, 24.78859);
case 1844: return new CityInfo("Neapoli", "ESYE12", 40.6532, 22.94156);
case 1845: return new CityInfo("Nea Lava", "ESYE13", 40.19048, 22.0132);
case 1846: return new CityInfo("Dhamatria", "ESYE42", 36.38015, 28.08285);
case 1847: return new CityInfo("Kamara", "ESYE42", 37.16031, 26.8248);
case 1848: return new CityInfo("Stathmós Mourión", "ESYE12", 41.26378, 22.83855);
default: return new CityInfo("Mosynopolis, Maximianopolis, Μαξιμιανούπολις", "ESYE11", 41.12863, 25.32546);

                                    }                                        
                                }
                            
                        }
                    }
                