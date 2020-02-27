
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
                                    public const string Country = "BA";
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
                            
                                        var cur = (Math.Abs(44.38605 - lat) + Math.Abs(19.10247 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(44.54765 - lat) + Math.Abs(17.37357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.44929 - lat) + Math.Abs(18.64978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.42667 - lat) + Math.Abs(18.03778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.20169 - lat) + Math.Abs(17.90397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.39875 - lat) + Math.Abs(17.94103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14593 - lat) + Math.Abs(16.01728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.44583 - lat) + Math.Abs(18.14972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.79224 - lat) + Math.Abs(16.94224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.46209 - lat) + Math.Abs(18.74941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16369 - lat) + Math.Abs(15.95444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.35878 - lat) + Math.Abs(18.35397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.87873 - lat) + Math.Abs(17.65861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90225 - lat) + Math.Abs(18.34438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18183 - lat) + Math.Abs(18.94096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.2375 - lat) + Math.Abs(17.48389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15424 - lat) + Math.Abs(17.79009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.98889 - lat) + Math.Abs(18.17806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.7826 - lat) + Math.Abs(19.29256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.77139 - lat) + Math.Abs(17.02833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80461 - lat) + Math.Abs(19.16183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18497 - lat) + Math.Abs(15.80579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55618 - lat) + Math.Abs(16.73349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08936 - lat) + Math.Abs(16.01906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.16444 - lat) + Math.Abs(18.32833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58338 - lat) + Math.Abs(18.79106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67771 - lat) + Math.Abs(19.03384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53842 - lat) + Math.Abs(18.66709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.24352 - lat) + Math.Abs(17.57499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97597 - lat) + Math.Abs(15.78489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.6658 - lat) + Math.Abs(18.44593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85829 - lat) + Math.Abs(17.23583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.71197 - lat) + Math.Abs(18.34362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.22637 - lat) + Math.Abs(17.66583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50133 - lat) + Math.Abs(18.78523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60639 - lat) + Math.Abs(17.85972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61191 - lat) + Math.Abs(17.98552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.11333 - lat) + Math.Abs(17.72 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0377 - lat) + Math.Abs(16.54019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09743 - lat) + Math.Abs(15.85818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.06389 - lat) + Math.Abs(15.77806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.31382 - lat) + Math.Abs(18.68416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.084 - lat) + Math.Abs(17.95995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.71634 - lat) + Math.Abs(18.25783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9363 - lat) + Math.Abs(16.02224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70819 - lat) + Math.Abs(18.48834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.10748 - lat) + Math.Abs(19.29669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0973 - lat) + Math.Abs(17.52331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.56226 - lat) + Math.Abs(18.69322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.93817 - lat) + Math.Abs(18.80079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72897 - lat) + Math.Abs(18.42575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.49071 - lat) + Math.Abs(17.38161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.28237 - lat) + Math.Abs(17.08597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.46674 - lat) + Math.Abs(18.5637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.29896 - lat) + Math.Abs(18.85532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.84864 - lat) + Math.Abs(18.35644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.5038 - lat) + Math.Abs(18.99818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7667 - lat) + Math.Abs(16.667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61354 - lat) + Math.Abs(16.64062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.83154 - lat) + Math.Abs(17.50273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61781 - lat) + Math.Abs(19.36719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.79894 - lat) + Math.Abs(19.00363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.31453 - lat) + Math.Abs(17.8029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88741 - lat) + Math.Abs(17.96555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.22302 - lat) + Math.Abs(17.54056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54562 - lat) + Math.Abs(18.47865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.17133 - lat) + Math.Abs(17.65816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82222 - lat) + Math.Abs(17.60917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87021 - lat) + Math.Abs(17.66256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97991 - lat) + Math.Abs(16.71401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60233 - lat) + Math.Abs(18.93165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.6101 - lat) + Math.Abs(17.68981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76367 - lat) + Math.Abs(18.76512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.39261 - lat) + Math.Abs(16.62001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.40953 - lat) + Math.Abs(17.87855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.47281 - lat) + Math.Abs(17.32621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.76547 - lat) + Math.Abs(19.28667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.63299 - lat) + Math.Abs(17.97216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17417 - lat) + Math.Abs(15.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.72295 - lat) + Math.Abs(16.99887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.46849 - lat) + Math.Abs(19.07466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90105 - lat) + Math.Abs(18.59185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05444 - lat) + Math.Abs(15.89694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63139 - lat) + Math.Abs(16.7825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.78882 - lat) + Math.Abs(18.16049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.81664 - lat) + Math.Abs(18.56949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96 - lat) + Math.Abs(16.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90866 - lat) + Math.Abs(15.94045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.99724 - lat) + Math.Abs(18.58464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86027 - lat) + Math.Abs(16.66069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.40159 - lat) + Math.Abs(18.91638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.77414 - lat) + Math.Abs(16.86329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03366 - lat) + Math.Abs(18.69334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63039 - lat) + Math.Abs(16.07443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.65345 - lat) + Math.Abs(18.36951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8917 - lat) + Math.Abs(16.89814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.69831 - lat) + Math.Abs(17.95757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.1277 - lat) + Math.Abs(18.58065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02461 - lat) + Math.Abs(18.32107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.95215 - lat) + Math.Abs(18.59869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.08007 - lat) + Math.Abs(17.15556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.51031 - lat) + Math.Abs(18.02624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.25861 - lat) + Math.Abs(18.11333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.92333 - lat) + Math.Abs(17.61556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.41729 - lat) + Math.Abs(17.08288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.59234 - lat) + Math.Abs(18.56458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.34333 - lat) + Math.Abs(17.80806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86646 - lat) + Math.Abs(18.46603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.17016 - lat) + Math.Abs(19.09195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.68776 - lat) + Math.Abs(18.04885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.56594 - lat) + Math.Abs(17.53216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86801 - lat) + Math.Abs(16.8551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13443 - lat) + Math.Abs(15.85217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01194 - lat) + Math.Abs(18.25528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94975 - lat) + Math.Abs(17.35014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54771 - lat) + Math.Abs(18.10003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.76452 - lat) + Math.Abs(18.16887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82693 - lat) + Math.Abs(18.38318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54245 - lat) + Math.Abs(18.52618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63498 - lat) + Math.Abs(18.8434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.20466 - lat) + Math.Abs(17.85665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.19694 - lat) + Math.Abs(17.545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.9512 - lat) + Math.Abs(18.08702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82695 - lat) + Math.Abs(17.00746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.3829 - lat) + Math.Abs(17.59416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90857 - lat) + Math.Abs(17.30135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.99273 - lat) + Math.Abs(17.27639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61875 - lat) + Math.Abs(17.14351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60321 - lat) + Math.Abs(18.97967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.86556 - lat) + Math.Abs(18.04333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61831 - lat) + Math.Abs(17.37204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.67833 - lat) + Math.Abs(19.02845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.68966 - lat) + Math.Abs(19.23933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.39005 - lat) + Math.Abs(17.48552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.88188 - lat) + Math.Abs(18.38864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7329 - lat) + Math.Abs(18.18884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53251 - lat) + Math.Abs(16.77682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.22669 - lat) + Math.Abs(18.69274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.48904 - lat) + Math.Abs(18.56982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94295 - lat) + Math.Abs(18.08132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.57065 - lat) + Math.Abs(18.01775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.50464 - lat) + Math.Abs(18.44649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.43765 - lat) + Math.Abs(18.90713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94673 - lat) + Math.Abs(17.83785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.13311 - lat) + Math.Abs(18.12292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98172 - lat) + Math.Abs(16.09447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.34954 - lat) + Math.Abs(17.1688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66554 - lat) + Math.Abs(19.24691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.34203 - lat) + Math.Abs(17.27059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87485 - lat) + Math.Abs(15.78256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.95128 - lat) + Math.Abs(18.27128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82939 - lat) + Math.Abs(18.30003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.878 - lat) + Math.Abs(18.49699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.08161 - lat) + Math.Abs(18.95258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82222 - lat) + Math.Abs(18.20667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.37208 - lat) + Math.Abs(17.41449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.96668 - lat) + Math.Abs(18.05504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87851 - lat) + Math.Abs(18.42764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70307 - lat) + Math.Abs(18.3101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.73333 - lat) + Math.Abs(18.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.41124 - lat) + Math.Abs(18.17029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.93806 - lat) + Math.Abs(17.58833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.41752 - lat) + Math.Abs(16.8169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.42921 - lat) + Math.Abs(18.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01911 - lat) + Math.Abs(18.15477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55659 - lat) + Math.Abs(18.76159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01091 - lat) + Math.Abs(15.95487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.41833 - lat) + Math.Abs(17.285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.66795 - lat) + Math.Abs(18.97564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.62058 - lat) + Math.Abs(18.44684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.04583 - lat) + Math.Abs(16.84861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.16722 - lat) + Math.Abs(18.53528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.95952 - lat) + Math.Abs(17.90288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.50646 - lat) + Math.Abs(18.77854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.71849 - lat) + Math.Abs(17.22515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.44131 - lat) + Math.Abs(18.11883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.47229 - lat) + Math.Abs(18.72685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.4806 - lat) + Math.Abs(18.69709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.37389 - lat) + Math.Abs(16.38083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35454 - lat) + Math.Abs(17.32536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50671 - lat) + Math.Abs(16.46699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94317 - lat) + Math.Abs(18.64673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.14361 - lat) + Math.Abs(17.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.89021 - lat) + Math.Abs(16.3251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80235 - lat) + Math.Abs(18.40477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04327 - lat) + Math.Abs(18.66996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07559 - lat) + Math.Abs(18.41023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0611 - lat) + Math.Abs(18.58612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15106 - lat) + Math.Abs(16.47869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.05008 - lat) + Math.Abs(18.11958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73179 - lat) + Math.Abs(18.08698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.36682 - lat) + Math.Abs(17.32678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97839 - lat) + Math.Abs(17.90779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.22861 - lat) + Math.Abs(17.70083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35401 - lat) + Math.Abs(17.78045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73998 - lat) + Math.Abs(17.31881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72524 - lat) + Math.Abs(18.81474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67961 - lat) + Math.Abs(17.7578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96694 - lat) + Math.Abs(15.94306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.12139 - lat) + Math.Abs(17.68444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55712 - lat) + Math.Abs(19.07186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05361 - lat) + Math.Abs(16.03254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.09769 - lat) + Math.Abs(17.8783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.05722 - lat) + Math.Abs(17.45083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.79237 - lat) + Math.Abs(16.94039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82837 - lat) + Math.Abs(18.7242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01862 - lat) + Math.Abs(18.26063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86995 - lat) + Math.Abs(18.81012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18455 - lat) + Math.Abs(19.33085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.62804 - lat) + Math.Abs(18.35323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.17944 - lat) + Math.Abs(16.36389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05987 - lat) + Math.Abs(18.46756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55537 - lat) + Math.Abs(16.36897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04643 - lat) + Math.Abs(16.37782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13747 - lat) + Math.Abs(17.98722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8825 - lat) + Math.Abs(16.15139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21956 - lat) + Math.Abs(16.53929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14484 - lat) + Math.Abs(17.25453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17667 - lat) + Math.Abs(16.80944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.48677 - lat) + Math.Abs(17.82278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.25892 - lat) + Math.Abs(17.88815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.87645 - lat) + Math.Abs(18.42967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.78265 - lat) + Math.Abs(16.92676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75874 - lat) + Math.Abs(19.21437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81694 - lat) + Math.Abs(15.87083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.09472 - lat) + Math.Abs(18.17028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.40596 - lat) + Math.Abs(18.52648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77842 - lat) + Math.Abs(17.19386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86332 - lat) + Math.Abs(19.33931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.81038 - lat) + Math.Abs(18.56999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.654 - lat) + Math.Abs(17.95897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.74475 - lat) + Math.Abs(17.82714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.37792 - lat) + Math.Abs(17.41426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.44189 - lat) + Math.Abs(17.01495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73824 - lat) + Math.Abs(18.27335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.39548 - lat) + Math.Abs(18.73849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80753 - lat) + Math.Abs(19.25999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10548 - lat) + Math.Abs(16.67668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98568 - lat) + Math.Abs(15.82304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.88014 - lat) + Math.Abs(18.07452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.34765 - lat) + Math.Abs(17.76848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.2663 - lat) + Math.Abs(18.42961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75708 - lat) + Math.Abs(17.21178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72453 - lat) + Math.Abs(17.32431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.76111 - lat) + Math.Abs(17.17944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86717 - lat) + Math.Abs(16.97464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92018 - lat) + Math.Abs(16.89933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67228 - lat) + Math.Abs(18.01109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.44874 - lat) + Math.Abs(18.20521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.49497 - lat) + Math.Abs(18.07644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85887 - lat) + Math.Abs(19.23291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00694 - lat) + Math.Abs(15.87194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.13156 - lat) + Math.Abs(17.86452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54065 - lat) + Math.Abs(18.48069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.89341 - lat) + Math.Abs(18.37751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03139 - lat) + Math.Abs(15.91444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.52891 - lat) + Math.Abs(17.2812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.06433 - lat) + Math.Abs(17.93894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.97583 - lat) + Math.Abs(17.5275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.03758 - lat) + Math.Abs(18.24564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08833 - lat) + Math.Abs(15.93083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86373 - lat) + Math.Abs(19.26363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.65126 - lat) + Math.Abs(17.96082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.66028 - lat) + Math.Abs(17.76167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.60871 - lat) + Math.Abs(17.95078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.76324 - lat) + Math.Abs(17.19012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zvornik", "02", 44.38605, 19.10247);
case 1: return new CityInfo("Živinice", "02", 44.54765, 17.37357);
case 2: return new CityInfo("Živinice", "01", 44.44929, 18.64978);
case 3: return new CityInfo("Žepče", "01", 44.42667, 18.03778);
case 4: return new CityInfo("Zenica", "01", 44.20169, 17.90397);
case 5: return new CityInfo("Željezno Polje", "01", 44.39875, 17.94103);
case 6: return new CityInfo("Zborište", "01", 45.14593, 16.01728);
case 7: return new CityInfo("Zavidovići", "01", 44.44583, 18.14972);
case 8: return new CityInfo("Zabrišće", "01", 43.79224, 16.94224);
case 9: return new CityInfo("Vukovije Donje", "01", 44.46209, 18.74941);
case 10: return new CityInfo("Vrnograč", "01", 45.16369, 15.95444);
case 11: return new CityInfo("Vozuća", "00", 44.35878, 18.35397);
case 12: return new CityInfo("Voljevac", "01", 43.87873, 17.65861);
case 13: return new CityInfo("Vogošća", "01", 43.90225, 18.34438);
case 14: return new CityInfo("Vlasenica", "02", 44.18183, 18.94096);
case 15: return new CityInfo("Vitina", "01", 43.2375, 17.48389);
case 16: return new CityInfo("Vitez", "01", 44.15424, 17.79009);
case 17: return new CityInfo("Visoko", "01", 43.98889, 18.17806);
case 18: return new CityInfo("Višegrad", "02", 43.7826, 19.29256);
case 19: return new CityInfo("Vidoši", "01", 43.77139, 17.02833);
case 20: return new CityInfo("Velika Obarska", "02", 44.80461, 19.16183);
case 21: return new CityInfo("Velika Kladuša", "01", 45.18497, 15.80579);
case 22: return new CityInfo("Velagići", "01", 44.55618, 16.73349);
case 23: return new CityInfo("Varoška Rijeka", "01", 45.08936, 16.01906);
case 24: return new CityInfo("Vareš", "01", 44.16444, 18.32833);
case 25: return new CityInfo("Ustikolina", "01", 43.58338, 18.79106);
case 26: return new CityInfo("Ugljevik", "02", 44.67771, 19.03384);
case 27: return new CityInfo("Tuzla", "01", 44.53842, 18.66709);
case 28: return new CityInfo("Turbe", "01", 44.24352, 17.57499);
case 29: return new CityInfo("Tržačka Raštela", "01", 44.97597, 15.78489);
case 30: return new CityInfo("Trnovo", "02", 43.6658, 18.44593);
case 31: return new CityInfo("Trn", "02", 44.85829, 17.23583);
case 32: return new CityInfo("Trebinje", "02", 42.71197, 18.34362);
case 33: return new CityInfo("Travnik", "01", 44.22637, 17.66583);
case 34: return new CityInfo("Tojšići", "01", 44.50133, 18.78523);
case 35: return new CityInfo("Teslić", "02", 44.60639, 17.85972);
case 36: return new CityInfo("Tešanj", "01", 44.61191, 17.98552);
case 37: return new CityInfo("Tasovčići", "01", 43.11333, 17.72);
case 38: return new CityInfo("Svodna", "02", 45.0377, 16.54019);
case 39: return new CityInfo("Šumatac", "01", 45.09743, 15.85818);
case 40: return new CityInfo("Šturlić", "01", 45.06389, 15.77806);
case 41: return new CityInfo("Stupari", "00", 44.31382, 18.68416);
case 42: return new CityInfo("Stolac", "01", 43.084, 17.95995);
case 43: return new CityInfo("Stjepan-Polje", "01", 44.71634, 18.25783);
case 44: return new CityInfo("Stijena", "01", 44.9363, 16.02224);
case 45: return new CityInfo("Srebrenik", "01", 44.70819, 18.48834);
case 46: return new CityInfo("Srebrenica", "02", 44.10748, 19.29669);
case 47: return new CityInfo("Srbac", "02", 45.0973, 17.52331);
case 48: return new CityInfo("Solina", "01", 44.56226, 18.69322);
case 49: return new CityInfo("Sokolac", "02", 43.93817, 18.80079);
case 50: return new CityInfo("Sladna", "01", 44.72897, 18.42575);
case 51: return new CityInfo("Kneževo", "02", 44.49071, 17.38161);
case 52: return new CityInfo("Šipovo", "02", 44.28237, 17.08597);
case 53: return new CityInfo("Šerići", "01", 44.46674, 18.5637);
case 54: return new CityInfo("Šekovići", "02", 44.29896, 18.85532);
case 55: return new CityInfo("Sarajevo", "01", 43.84864, 18.35644);
case 56: return new CityInfo("Sapna", "01", 44.5038, 18.99818);
case 57: return new CityInfo("Sanski Most", "01", 44.7667, 16.667);
case 58: return new CityInfo("Sanica", "01", 44.61354, 16.64062);
case 59: return new CityInfo("Rumboci", "01", 43.83154, 17.50273);
case 60: return new CityInfo("Rudo", "02", 43.61781, 19.36719);
case 61: return new CityInfo("Rogatica", "02", 43.79894, 19.00363);
case 62: return new CityInfo("Rodoč", "01", 43.31453, 17.8029);
case 63: return new CityInfo("Ravno", "01", 42.88741, 17.96555);
case 64: return new CityInfo("Radišići", "01", 43.22302, 17.54056);
case 65: return new CityInfo("Puračić", "01", 44.54562, 18.47865);
case 66: return new CityInfo("Novi Travnik", "01", 44.17133, 17.65816);
case 67: return new CityInfo("Prozor", "01", 43.82222, 17.60917);
case 68: return new CityInfo("Prnjavor", "02", 44.87021, 17.66256);
case 69: return new CityInfo("Prijedor", "02", 44.97991, 16.71401);
case 70: return new CityInfo("Priboj", "02", 44.60233, 18.93165);
case 71: return new CityInfo("Pribinić", "02", 44.6101, 17.68981);
case 72: return new CityInfo("Prača", "01", 43.76367, 18.76512);
case 73: return new CityInfo("Potoci", "02", 44.39261, 16.62001);
case 74: return new CityInfo("Potoci", "01", 43.40953, 17.87855);
case 75: return new CityInfo("Posušje", "01", 43.47281, 17.32621);
case 76: return new CityInfo("Popovi", "02", 44.76547, 19.28667);
case 77: return new CityInfo("Polje-Bijela", "01", 43.63299, 17.97216);
case 78: return new CityInfo("Podzvizd", "01", 45.17417, 15.87361);
case 79: return new CityInfo("Podhum", "01", 43.72295, 16.99887);
case 80: return new CityInfo("Petkovci", "02", 44.46849, 19.07466);
case 81: return new CityInfo("Pelagićevo", "02", 44.90105, 18.59185);
case 82: return new CityInfo("Pećigrad", "01", 45.05444, 15.89694);
case 83: return new CityInfo("Peći", "01", 44.63139, 16.7825);
case 84: return new CityInfo("Pazarić", "01", 43.78882, 18.16049);
case 85: return new CityInfo("Pale", "02", 43.81664, 18.56949);
case 86: return new CityInfo("Otoka", "01", 44.96, 16.17917);
case 87: return new CityInfo("Ostrožac", "01", 44.90866, 15.94045);
case 88: return new CityInfo("Oštra Luka", "02", 44.99724, 18.58464);
case 89: return new CityInfo("Oštra Luka", "02", 44.86027, 16.66069);
case 90: return new CityInfo("Osmaci", "02", 44.40159, 18.91638);
case 91: return new CityInfo("Orguz", "01", 43.77414, 16.86329);
case 92: return new CityInfo("Orašje", "01", 45.03366, 18.69334);
case 93: return new CityInfo("Orašac", "01", 44.63039, 16.07443);
case 94: return new CityInfo("Orahovica Donja", "01", 44.65345, 18.36951);
case 95: return new CityInfo("Omarska", "02", 44.8917, 16.89814);
case 96: return new CityInfo("Omanjska", "01", 44.69831, 17.95757);
case 97: return new CityInfo("Olovo", "01", 44.1277, 18.58065);
case 98: return new CityInfo("Odžak", "01", 45.02461, 18.32107);
case 99: return new CityInfo("Obudovac", "02", 44.95215, 18.59869);
case 100: return new CityInfo("Novo Selo", "02", 44.08007, 17.15556);
case 101: return new CityInfo("Novi Šeher", "01", 44.51031, 18.02624);
case 102: return new CityInfo("Nevesinje", "02", 43.25861, 18.11333);
case 103: return new CityInfo("Neum", "01", 42.92333, 17.61556);
case 104: return new CityInfo("Mrkonjić Grad", "02", 44.41729, 17.08288);
case 105: return new CityInfo("Mramor", "01", 44.59234, 18.56458);
case 106: return new CityInfo("Mostar", "01", 43.34333, 17.80806);
case 107: return new CityInfo("Mionica", "01", 44.86646, 18.46603);
case 108: return new CityInfo("Milići", "02", 44.17016, 19.09195);
case 109: return new CityInfo("Matuzići", "01", 44.68776, 18.04885);
case 110: return new CityInfo("Maslovare", "02", 44.56594, 17.53216);
case 111: return new CityInfo("Marićka", "02", 44.86801, 16.8551);
case 112: return new CityInfo("Mala Kladuša", "01", 45.13443, 15.85217);
case 113: return new CityInfo("Mahala", "01", 44.01194, 18.25528);
case 114: return new CityInfo("Maglajani", "02", 44.94975, 17.35014);
case 115: return new CityInfo("Maglaj", "01", 44.54771, 18.10003);
case 116: return new CityInfo("Lukavica", "01", 44.76452, 18.16887);
case 117: return new CityInfo("Lukavica", "02", 43.82693, 18.38318);
case 118: return new CityInfo("Lukavac", "01", 44.54245, 18.52618);
case 119: return new CityInfo("Lopare", "02", 44.63498, 18.8434);
case 120: return new CityInfo("Lokvine", "01", 44.20466, 17.85665);
case 121: return new CityInfo("Ljubuški", "01", 43.19694, 17.545);
case 122: return new CityInfo("Ljubinje", "02", 42.9512, 18.08702);
case 123: return new CityInfo("Livno", "01", 43.82695, 17.00746);
case 124: return new CityInfo("Široki Brijeg", "01", 43.3829, 17.59416);
case 125: return new CityInfo("Laktaši", "02", 44.90857, 17.30135);
case 126: return new CityInfo("Kupres", "01", 43.99273, 17.27639);
case 127: return new CityInfo("Krupa na Vrbasu", "02", 44.61875, 17.14351);
case 128: return new CityInfo("Teočak", "01", 44.60321, 18.97967);
case 129: return new CityInfo("Kreševo", "01", 43.86556, 18.04333);
case 130: return new CityInfo("Kotor Varoš", "02", 44.61831, 17.37204);
case 131: return new CityInfo("Kopači", "02", 43.67833, 19.02845);
case 132: return new CityInfo("Kojčinovac", "02", 44.68966, 19.23933);
case 133: return new CityInfo("Kočerin", "01", 43.39005, 17.48552);
case 134: return new CityInfo("Kobilja Glava", "01", 43.88188, 18.38864);
case 135: return new CityInfo("Klokotnica", "01", 44.7329, 18.18884);
case 136: return new CityInfo("Ključ", "01", 44.53251, 16.77682);
case 137: return new CityInfo("Kladanj", "01", 44.22669, 18.69274);
case 138: return new CityInfo("Kiseljak", "01", 44.48904, 18.56982);
case 139: return new CityInfo("Kiseljak", "01", 43.94295, 18.08132);
case 140: return new CityInfo("Karadaglije", "01", 44.57065, 18.01775);
case 141: return new CityInfo("Kalinovik", "02", 43.50464, 18.44649);
case 142: return new CityInfo("Kalesija", "01", 44.43765, 18.90713);
case 143: return new CityInfo("Kalenderovci Donji", "02", 44.94673, 17.83785);
case 144: return new CityInfo("Kakanj", "01", 44.13311, 18.12292);
case 145: return new CityInfo("Jezerski", "01", 44.98172, 16.09447);
case 146: return new CityInfo("Jezero", "02", 44.34954, 17.1688);
case 147: return new CityInfo("Janja", "02", 44.66554, 19.24691);
case 148: return new CityInfo("Jajce", "01", 44.34203, 17.27059);
case 149: return new CityInfo("Izačić", "01", 44.87485, 15.78256);
case 150: return new CityInfo("Ilijaš", "01", 43.95128, 18.27128);
case 151: return new CityInfo("Ilidža", "01", 43.82939, 18.30003);
case 152: return new CityInfo("Hreša", "02", 43.878, 18.49699);
case 153: return new CityInfo("Han Pijesak", "02", 44.08161, 18.95258);
case 154: return new CityInfo("Hadžići", "01", 43.82222, 18.20667);
case 155: return new CityInfo("Grude", "01", 43.37208, 17.41449);
case 156: return new CityInfo("Gromiljak", "01", 43.96668, 18.05504);
case 157: return new CityInfo("Gradačac", "01", 44.87851, 18.42764);
case 158: return new CityInfo("Gračanica", "01", 44.70307, 18.3101);
case 159: return new CityInfo("Gračanica", "01", 43.73333, 18.28333);
case 160: return new CityInfo("Gostovići", "01", 44.41124, 18.17029);
case 161: return new CityInfo("Gornji Vakuf", "01", 43.93806, 17.58833);
case 162: return new CityInfo("Gornji Ribnik", "02", 44.41752, 16.8169);
case 163: return new CityInfo("Gornje Živinice", "01", 44.42921, 18.61667);
case 164: return new CityInfo("Gornje Moštre", "01", 44.01911, 18.15477);
case 165: return new CityInfo("Gornja Tuzla", "01", 44.55659, 18.76159);
case 166: return new CityInfo("Gornja Koprivna", "01", 45.01091, 15.95487);
case 167: return new CityInfo("Gorica", "01", 43.41833, 17.285);
case 168: return new CityInfo("Goražde", "01", 43.66795, 18.97564);
case 169: return new CityInfo("Gnojnica", "01", 44.62058, 18.44684);
case 170: return new CityInfo("Glamoč", "01", 44.04583, 16.84861);
case 171: return new CityInfo("Gacko", "02", 43.16722, 18.53528);
case 172: return new CityInfo("Fojnica", "01", 43.95952, 17.90288);
case 173: return new CityInfo("Foča", "02", 43.50646, 18.77854);
case 174: return new CityInfo("Tomislavgrad", "01", 43.71849, 17.22515);
case 175: return new CityInfo("Dubravica", "01", 44.44131, 18.11883);
case 176: return new CityInfo("Dubrave Gornje", "01", 44.47229, 18.72685);
case 177: return new CityInfo("Dubrave Donje", "01", 44.4806, 18.69709);
case 178: return new CityInfo("Drvar", "01", 44.37389, 16.38083);
case 179: return new CityInfo("Drinovci", "01", 43.35454, 17.32536);
case 180: return new CityInfo("Drinić", "02", 44.50671, 16.46699);
case 181: return new CityInfo("Donji Žabar", "02", 44.94317, 18.64673);
case 182: return new CityInfo("Donji Vakuf", "01", 44.14361, 17.4);
case 183: return new CityInfo("Donji Dubovik", "02", 44.89021, 16.3251);
case 184: return new CityInfo("Donja Međiđa", "01", 44.80235, 18.40477);
case 185: return new CityInfo("Donja Mahala", "01", 45.04327, 18.66996);
case 186: return new CityInfo("Donja Dubica", "01", 45.07559, 18.41023);
case 187: return new CityInfo("Domaljevac", "01", 45.0611, 18.58612);
case 188: return new CityInfo("Dobrljin", "02", 45.15106, 16.47869);
case 189: return new CityInfo("Dobrinje", "01", 44.05008, 18.11958);
case 190: return new CityInfo("Doboj", "02", 44.73179, 18.08698);
case 191: return new CityInfo("Divičani", "01", 44.36682, 17.32678);
case 192: return new CityInfo("Derventa", "02", 44.97839, 17.90779);
case 193: return new CityInfo("Čitluk", "01", 43.22861, 17.70083);
case 194: return new CityInfo("Cim", "01", 43.35401, 17.78045);
case 195: return new CityInfo("Čelinac", "02", 44.73998, 17.31881);
case 196: return new CityInfo("Čelić", "01", 44.72524, 18.81474);
case 197: return new CityInfo("Čečava", "02", 44.67961, 17.7578);
case 198: return new CityInfo("Cazin", "01", 44.96694, 15.94306);
case 199: return new CityInfo("Čapljina", "01", 43.12139, 17.68444);
case 200: return new CityInfo("Čajniče", "02", 43.55712, 19.07186);
case 201: return new CityInfo("Bužim", "01", 45.05361, 16.03254);
case 202: return new CityInfo("Busovača", "01", 44.09769, 17.8783);
case 203: return new CityInfo("Bugojno", "01", 44.05722, 17.45083);
case 204: return new CityInfo("Bronzani Majdan", "02", 44.79237, 16.94039);
case 205: return new CityInfo("Brka", "BRC", 44.82837, 18.7242);
case 206: return new CityInfo("Breza", "01", 44.01862, 18.26063);
case 207: return new CityInfo("Brčko", "BRC", 44.86995, 18.81012);
case 208: return new CityInfo("Bratunac", "02", 44.18455, 19.33085);
case 209: return new CityInfo("Petrovo", "02", 44.62804, 18.35323);
case 210: return new CityInfo("Bosansko Grahovo", "01", 44.17944, 16.36389);
case 211: return new CityInfo("Šamac", "02", 45.05987, 18.46756);
case 212: return new CityInfo("Bosanski Petrovac", "01", 44.55537, 16.36897);
case 213: return new CityInfo("Novi Grad", "02", 45.04643, 16.37782);
case 214: return new CityInfo("Brod", "02", 45.13747, 17.98722);
case 215: return new CityInfo("Bosanska Krupa", "01", 44.8825, 16.15139);
case 216: return new CityInfo("Kostajnica", "02", 45.21956, 16.53929);
case 217: return new CityInfo("Gradiška", "02", 45.14484, 17.25453);
case 218: return new CityInfo("Kozarska Dubica", "02", 45.17667, 16.80944);
case 219: return new CityInfo("Blatnica", "02", 44.48677, 17.82278);
case 220: return new CityInfo("Blagaj", "01", 43.25892, 17.88815);
case 221: return new CityInfo("Bileća", "02", 42.87645, 18.42967);
case 222: return new CityInfo("Bila", "01", 43.78265, 16.92676);
case 223: return new CityInfo("Bijeljina", "02", 44.75874, 19.21437);
case 224: return new CityInfo("Bihać", "01", 44.81694, 15.87083);
case 225: return new CityInfo("Berkovići", "02", 43.09472, 18.17028);
case 226: return new CityInfo("Banovići", "01", 44.40596, 18.52648);
case 227: return new CityInfo("Banja Luka", "02", 44.77842, 17.19386);
case 228: return new CityInfo("Balatun", "02", 44.86332, 19.33931);
case 229: return new CityInfo("Koran", "02", 43.81038, 18.56999);
case 230: return new CityInfo("Jelah", "01", 44.654, 17.95897);
case 231: return new CityInfo("Stanari", "02", 44.74475, 17.82714);
case 232: return new CityInfo("Dobratići", "01", 44.37792, 17.41426);
case 233: return new CityInfo("Podbrdo", "02", 44.44189, 17.01495);
case 234: return new CityInfo("Malešići", "01", 44.73824, 18.27335);
case 235: return new CityInfo("Svojat", "00", 44.39548, 18.73849);
case 236: return new CityInfo("Dvorovi", "02", 44.80753, 19.25999);
case 237: return new CityInfo("Knežica", "02", 45.10548, 16.67668);
case 238: return new CityInfo("Pjanići", "01", 44.98568, 15.82304);
case 239: return new CityInfo("Polje", "01", 43.88014, 18.07452);
case 240: return new CityInfo("Ilići", "01", 43.34765, 17.76848);
case 241: return new CityInfo("Careva Ćuprija", "00", 44.2663, 18.42961);
case 242: return new CityInfo("Starcevica", "02", 44.75708, 17.21178);
case 243: return new CityInfo("Čelinac", "02", 44.72453, 17.32431);
case 244: return new CityInfo("Hiseti", "02", 44.76111, 17.17944);
case 245: return new CityInfo("Piskavica", "02", 44.86717, 16.97464);
case 246: return new CityInfo("Lamovita", "02", 44.92018, 16.89933);
case 247: return new CityInfo("Tešanjka", "01", 44.67228, 18.01109);
case 248: return new CityInfo("Kovači", "01", 44.44874, 18.20521);
case 249: return new CityInfo("Liješnica", "01", 44.49497, 18.07644);
case 250: return new CityInfo("Ostojićevo", "02", 44.85887, 19.23291);
case 251: return new CityInfo("Ćoralići", "01", 45.00694, 15.87194);
case 252: return new CityInfo("Crnići", "01", 43.13156, 17.86452);
case 253: return new CityInfo("Barice", "01", 44.54065, 18.48069);
case 254: return new CityInfo("Hotonj", "01", 43.89341, 18.37751);
case 255: return new CityInfo("Skokovi", "01", 45.03139, 15.91444);
case 256: return new CityInfo("Drežnica", "01", 43.52891, 17.2812);
case 257: return new CityInfo("Kačuni", "01", 44.06433, 17.93894);
case 258: return new CityInfo("Pajić Polje", "01", 43.97583, 17.5275);
case 259: return new CityInfo("Gornja Breza", "01", 44.03758, 18.24564);
case 260: return new CityInfo("Todorovo", "01", 45.08833, 15.93083);
case 261: return new CityInfo("Brodac-Gornji", "02", 44.86373, 19.26363);
case 262: return new CityInfo("Konjic", "01", 43.65126, 17.96082);
case 263: return new CityInfo("Jablanica", "01", 43.66028, 17.76167);
case 264: return new CityInfo("Bijela", "01", 43.60871, 17.95078);
default: return new CityInfo("Mejdan - Obilićevo", "02", 44.76324, 17.19012);

                                    }                                        
                                }
                            
                        }
                    }
                