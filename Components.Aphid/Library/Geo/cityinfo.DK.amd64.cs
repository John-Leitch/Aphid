
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
                                    public const string Country = "DK";
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
                            
                                        var cur = (Math.Abs(57.3537 - lat) + Math.Abs(9.94176 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(55.00801 - lat) + Math.Abs(11.91057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.24639 - lat) + Math.Abs(9.30603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.10854 - lat) + Math.Abs(10.02215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.38482 - lat) + Math.Abs(10.13784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13218 - lat) + Math.Abs(9.55582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.66768 - lat) + Math.Abs(11.73967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.62298 - lat) + Math.Abs(12.1387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.48176 - lat) + Math.Abs(8.77991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.04489 - lat) + Math.Abs(10.61309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2 - lat) + Math.Abs(8.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0876 - lat) + Math.Abs(8.62852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54872 - lat) + Math.Abs(12.02391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.45319 - lat) + Math.Abs(9.40201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.07322 - lat) + Math.Abs(10.45536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.06767 - lat) + Math.Abs(10.12558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.13166 - lat) + Math.Abs(9.95942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75473 - lat) + Math.Abs(12.23837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.70927 - lat) + Math.Abs(9.5357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.48117 - lat) + Math.Abs(9.13795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.62112 - lat) + Math.Abs(8.48069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.68361 - lat) + Math.Abs(12.48713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.42764 - lat) + Math.Abs(9.28435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.62199 - lat) + Math.Abs(12.38511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.1179 - lat) + Math.Abs(9.857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.38994 - lat) + Math.Abs(9.79354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.36172 - lat) + Math.Abs(10.6519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.26725 - lat) + Math.Abs(8.32167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.59287 - lat) + Math.Abs(12.16968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.83946 - lat) + Math.Abs(12.54432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.25291 - lat) + Math.Abs(10.1484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.8326 - lat) + Math.Abs(10.59723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.09519 - lat) + Math.Abs(10.13605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.85 - lat) + Math.Abs(9.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.93306 - lat) + Math.Abs(8.86674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6125 - lat) + Math.Abs(11.77034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.34535 - lat) + Math.Abs(10.17594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.31952 - lat) + Math.Abs(10.20659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.18858 - lat) + Math.Abs(9.06925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.46457 - lat) + Math.Abs(8.57968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.93788 - lat) + Math.Abs(9.25547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.69846 - lat) + Math.Abs(8.21238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.0474 - lat) + Math.Abs(10.66385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.95523 - lat) + Math.Abs(8.69491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54582 - lat) + Math.Abs(9.61553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.65006 - lat) + Math.Abs(12.3016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.38333 - lat) + Math.Abs(10.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6303 - lat) + Math.Abs(12.60035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.90861 - lat) + Math.Abs(8.53041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.63423 - lat) + Math.Abs(12.01465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.72111 - lat) + Math.Abs(11.46547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.9723 - lat) + Math.Abs(9.84806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.05982 - lat) + Math.Abs(10.60677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13255 - lat) + Math.Abs(9.63289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.65183 - lat) + Math.Abs(11.28658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.20743 - lat) + Math.Abs(9.01386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.88875 - lat) + Math.Abs(12.04102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.49205 - lat) + Math.Abs(8.59397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.41382 - lat) + Math.Abs(12.24502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54021 - lat) + Math.Abs(9.76748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.4915 - lat) + Math.Abs(10.49609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.00392 - lat) + Math.Abs(10.10125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.30965 - lat) + Math.Abs(12.38885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.88536 - lat) + Math.Abs(9.83839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.48454 - lat) + Math.Abs(9.14617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.06224 - lat) + Math.Abs(9.98822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.43941 - lat) + Math.Abs(10.4094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.76828 - lat) + Math.Abs(12.19723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.53888 - lat) + Math.Abs(11.5912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.98704 - lat) + Math.Abs(12.28461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13124 - lat) + Math.Abs(10.11987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.81479 - lat) + Math.Abs(12.40545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.24097 - lat) + Math.Abs(9.53503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.53703 - lat) + Math.Abs(10.03792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.43184 - lat) + Math.Abs(11.55547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.48526 - lat) + Math.Abs(10.2554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.90896 - lat) + Math.Abs(9.78917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.45272 - lat) + Math.Abs(9.56741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.23801 - lat) + Math.Abs(10.0851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.53285 - lat) + Math.Abs(12.22227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.53628 - lat) + Math.Abs(12.1827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.04271 - lat) + Math.Abs(10.08631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.52253 - lat) + Math.Abs(9.72125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13291 - lat) + Math.Abs(8.90353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.74232 - lat) + Math.Abs(12.30276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.85 - lat) + Math.Abs(12.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.40276 - lat) + Math.Abs(11.35459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.90785 - lat) + Math.Abs(12.15036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.15735 - lat) + Math.Abs(8.76901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.15672 - lat) + Math.Abs(9.94523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.83626 - lat) + Math.Abs(9.89255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.25058 - lat) + Math.Abs(11.29352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.95 - lat) + Math.Abs(8.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.56699 - lat) + Math.Abs(9.02707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75122 - lat) + Math.Abs(11.96083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.03434 - lat) + Math.Abs(9.93177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.72093 - lat) + Math.Abs(10.58394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.47117 - lat) + Math.Abs(10.20312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.1697 - lat) + Math.Abs(9.54508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.42648 - lat) + Math.Abs(10.44265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.33188 - lat) + Math.Abs(10.52251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.7997 - lat) + Math.Abs(11.62599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.21333 - lat) + Math.Abs(10.03441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.3843 - lat) + Math.Abs(10.50295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.09038 - lat) + Math.Abs(9.76505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.93639 - lat) + Math.Abs(10.71019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.64152 - lat) + Math.Abs(12.08035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.2571 - lat) + Math.Abs(12.02125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.10091 - lat) + Math.Abs(14.70664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.30145 - lat) + Math.Abs(10.47505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.2554 - lat) + Math.Abs(12.37936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.68062 - lat) + Math.Abs(12.45373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.07076 - lat) + Math.Abs(9.33531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.36569 - lat) + Math.Abs(9.06316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.65944 - lat) + Math.Abs(11.35504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.69495 - lat) + Math.Abs(11.38885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4426 - lat) + Math.Abs(11.79011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.09006 - lat) + Math.Abs(8.24402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.23828 - lat) + Math.Abs(10.4786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.33051 - lat) + Math.Abs(8.76966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.4607 - lat) + Math.Abs(10.03639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.12374 - lat) + Math.Abs(12.04477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.22147 - lat) + Math.Abs(9.67569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.82657 - lat) + Math.Abs(9.36247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.51527 - lat) + Math.Abs(10.39756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.56228 - lat) + Math.Abs(11.95786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.04356 - lat) + Math.Abs(11.96792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.79567 - lat) + Math.Abs(12.15509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.80682 - lat) + Math.Abs(8.62859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6268 - lat) + Math.Abs(8.28757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.39594 - lat) + Math.Abs(10.38831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.97313 - lat) + Math.Abs(10.153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.00511 - lat) + Math.Abs(11.9606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.76906 - lat) + Math.Abs(11.87425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.92491 - lat) + Math.Abs(11.67109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.79334 - lat) + Math.Abs(8.85282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.31274 - lat) + Math.Abs(10.78964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.22992 - lat) + Math.Abs(11.76092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.44603 - lat) + Math.Abs(8.39786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.05732 - lat) + Math.Abs(9.7408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.05877 - lat) + Math.Abs(9.92284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.89784 - lat) + Math.Abs(11.88414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.46107 - lat) + Math.Abs(9.8794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.97877 - lat) + Math.Abs(12.34685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.93405 - lat) + Math.Abs(12.50485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.9815 - lat) + Math.Abs(9.63917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.06067 - lat) + Math.Abs(15.13058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.03211 - lat) + Math.Abs(11.88356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.36451 - lat) + Math.Abs(10.44824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.83038 - lat) + Math.Abs(11.13567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.45553 - lat) + Math.Abs(10.55433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.50591 - lat) + Math.Abs(9.73054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.85621 - lat) + Math.Abs(10.51726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0669 - lat) + Math.Abs(10.16112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.77662 - lat) + Math.Abs(11.50017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.64985 - lat) + Math.Abs(9.97515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75528 - lat) + Math.Abs(12.32327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.03632 - lat) + Math.Abs(10.19632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.2375 - lat) + Math.Abs(10.23778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.83941 - lat) + Math.Abs(12.27725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.48375 - lat) + Math.Abs(9.29917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.37047 - lat) + Math.Abs(9.71466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.08959 - lat) + Math.Abs(9.46084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.05941 - lat) + Math.Abs(8.95508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.27459 - lat) + Math.Abs(10.31181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.96245 - lat) + Math.Abs(9.2583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.01295 - lat) + Math.Abs(11.96544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.106 - lat) + Math.Abs(8.97915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.78251 - lat) + Math.Abs(12.36856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.87496 - lat) + Math.Abs(12.34579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.54856 - lat) + Math.Abs(8.31019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.60461 - lat) + Math.Abs(11.97477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.35655 - lat) + Math.Abs(10.58447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.39026 - lat) + Math.Abs(9.89486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.85097 - lat) + Math.Abs(9.40129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.32993 - lat) + Math.Abs(11.13857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.45802 - lat) + Math.Abs(12.18214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.67594 - lat) + Math.Abs(12.56553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.77044 - lat) + Math.Abs(12.50378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.10845 - lat) + Math.Abs(10.06986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4904 - lat) + Math.Abs(9.47216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.91179 - lat) + Math.Abs(12.49952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.01194 - lat) + Math.Abs(10.05617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.28581 - lat) + Math.Abs(9.43528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.5917 - lat) + Math.Abs(11.86253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.0317 - lat) + Math.Abs(8.85697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.44903 - lat) + Math.Abs(10.65769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.19774 - lat) + Math.Abs(9.67173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.30673 - lat) + Math.Abs(9.16835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.67954 - lat) + Math.Abs(11.08864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75295 - lat) + Math.Abs(12.10315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.66399 - lat) + Math.Abs(11.42029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.70876 - lat) + Math.Abs(10.01668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.85248 - lat) + Math.Abs(11.98565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75588 - lat) + Math.Abs(9.4258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.61543 - lat) + Math.Abs(12.35182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.09915 - lat) + Math.Abs(9.2047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13883 - lat) + Math.Abs(9.15768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.65719 - lat) + Math.Abs(12.47364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.99866 - lat) + Math.Abs(8.12605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.74944 - lat) + Math.Abs(8.41953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.96397 - lat) + Math.Abs(11.85044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.9618 - lat) + Math.Abs(12.5341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.86066 - lat) + Math.Abs(9.85034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75621 - lat) + Math.Abs(9.85643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.3155 - lat) + Math.Abs(10.32041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.09027 - lat) + Math.Abs(12.45693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75292 - lat) + Math.Abs(11.45298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.91017 - lat) + Math.Abs(9.89872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.88098 - lat) + Math.Abs(12.50111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.08701 - lat) + Math.Abs(10.03716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.50736 - lat) + Math.Abs(11.28873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.91148 - lat) + Math.Abs(11.59756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.33177 - lat) + Math.Abs(10.43725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.81667 - lat) + Math.Abs(12.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.51086 - lat) + Math.Abs(8.91872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.36009 - lat) + Math.Abs(8.61607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.71148 - lat) + Math.Abs(11.46416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7175 - lat) + Math.Abs(11.71279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.64306 - lat) + Math.Abs(9.79029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.24811 - lat) + Math.Abs(10.26533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.46417 - lat) + Math.Abs(9.98229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16466 - lat) + Math.Abs(10.14571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.58812 - lat) + Math.Abs(9.95922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.26608 - lat) + Math.Abs(10.06299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.92791 - lat) + Math.Abs(12.30081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13615 - lat) + Math.Abs(8.97662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.72366 - lat) + Math.Abs(12.43998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.03606 - lat) + Math.Abs(12.6136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.02283 - lat) + Math.Abs(12.19752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.06823 - lat) + Math.Abs(12.55782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.77043 - lat) + Math.Abs(9.7011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.54481 - lat) + Math.Abs(12.12392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.32346 - lat) + Math.Abs(11.96389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.46658 - lat) + Math.Abs(10.02165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.34936 - lat) + Math.Abs(12.23382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.22357 - lat) + Math.Abs(10.12268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.61752 - lat) + Math.Abs(8.18069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.11548 - lat) + Math.Abs(8.6172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.13361 - lat) + Math.Abs(9.06121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.25762 - lat) + Math.Abs(9.86316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.99609 - lat) + Math.Abs(10.30807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.71482 - lat) + Math.Abs(10.11682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.32819 - lat) + Math.Abs(10.04931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.24943 - lat) + Math.Abs(9.48771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.73565 - lat) + Math.Abs(12.15158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.98978 - lat) + Math.Abs(9.87174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.06558 - lat) + Math.Abs(12.28512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75726 - lat) + Math.Abs(8.9275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.58333 - lat) + Math.Abs(12.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.41578 - lat) + Math.Abs(10.87825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.91918 - lat) + Math.Abs(9.59523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.28948 - lat) + Math.Abs(9.04913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.53926 - lat) + Math.Abs(11.22708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6666 - lat) + Math.Abs(12.40377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.27237 - lat) + Math.Abs(10.10483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.14616 - lat) + Math.Abs(9.05467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.84523 - lat) + Math.Abs(9.23769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.9943 - lat) + Math.Abs(9.99085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.12196 - lat) + Math.Abs(12.31056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.57644 - lat) + Math.Abs(11.93004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.79124 - lat) + Math.Abs(12.26421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.15902 - lat) + Math.Abs(9.91691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.30604 - lat) + Math.Abs(11.54766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.00623 - lat) + Math.Abs(9.81711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.97073 - lat) + Math.Abs(12.0225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.83956 - lat) + Math.Abs(12.06896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.44073 - lat) + Math.Abs(10.53661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.67938 - lat) + Math.Abs(12.53463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.41618 - lat) + Math.Abs(11.56934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.56568 - lat) + Math.Abs(9.75257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.97558 - lat) + Math.Abs(12.40314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.15664 - lat) + Math.Abs(10.01318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.37445 - lat) + Math.Abs(11.25966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.66212 - lat) + Math.Abs(12.18698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.08822 - lat) + Math.Abs(9.26622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.27919 - lat) + Math.Abs(11.80382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.80858 - lat) + Math.Abs(12.36066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.77276 - lat) + Math.Abs(9.33925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.21981 - lat) + Math.Abs(12.17013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.25561 - lat) + Math.Abs(12.11926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.0951 - lat) + Math.Abs(10.24226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.99464 - lat) + Math.Abs(12.54733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.47028 - lat) + Math.Abs(8.45187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.68923 - lat) + Math.Abs(11.84725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4858 - lat) + Math.Abs(12.08171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4301 - lat) + Math.Abs(9.92973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.61613 - lat) + Math.Abs(9.30763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.19442 - lat) + Math.Abs(10.6821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.91079 - lat) + Math.Abs(9.73601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16035 - lat) + Math.Abs(10.29287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.5928 - lat) + Math.Abs(12.67221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.53133 - lat) + Math.Abs(11.4925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.67383 - lat) + Math.Abs(12.59541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.35817 - lat) + Math.Abs(9.48701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75238 - lat) + Math.Abs(12.5745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.25679 - lat) + Math.Abs(10.99738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.42686 - lat) + Math.Abs(10.47137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.74818 - lat) + Math.Abs(12.49532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.0975 - lat) + Math.Abs(9.52264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.48194 - lat) + Math.Abs(9.01756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.27021 - lat) + Math.Abs(9.94102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.6455 - lat) + Math.Abs(12.41008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8894 - lat) + Math.Abs(9.67465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.48407 - lat) + Math.Abs(9.97908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.66594 - lat) + Math.Abs(9.67217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.97153 - lat) + Math.Abs(9.61129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.94316 - lat) + Math.Abs(9.12798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.46946 - lat) + Math.Abs(8.70007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.49472 - lat) + Math.Abs(11.97584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.16871 - lat) + Math.Abs(9.24384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.64195 - lat) + Math.Abs(9.64958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.56691 - lat) + Math.Abs(10.08863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.87038 - lat) + Math.Abs(12.3864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.45756 - lat) + Math.Abs(12.03651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.37797 - lat) + Math.Abs(9.66065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.84759 - lat) + Math.Abs(12.42791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.73349 - lat) + Math.Abs(9.10785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.33535 - lat) + Math.Abs(10.32045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.06025 - lat) + Math.Abs(10.21179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.73165 - lat) + Math.Abs(12.36328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.26539 - lat) + Math.Abs(8.79256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.43079 - lat) + Math.Abs(10.37818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.95201 - lat) + Math.Abs(9.87216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.4421 - lat) + Math.Abs(10.1517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.27023 - lat) + Math.Abs(9.90081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.81229 - lat) + Math.Abs(11.50129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.37315 - lat) + Math.Abs(10.04131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.30353 - lat) + Math.Abs(10.46428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.80399 - lat) + Math.Abs(9.51441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.15674 - lat) + Math.Abs(10.21076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.76899 - lat) + Math.Abs(9.86184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.46432 - lat) + Math.Abs(10.31957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.6947 - lat) + Math.Abs(9.49336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.048 - lat) + Math.Abs(9.9187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.65691 - lat) + Math.Abs(12.36381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.0708 - lat) + Math.Abs(14.91978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.88803 - lat) + Math.Abs(10.41117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.16249 - lat) + Math.Abs(9.72996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.04434 - lat) + Math.Abs(9.41741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.76711 - lat) + Math.Abs(11.84979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.70574 - lat) + Math.Abs(12.55544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.32006 - lat) + Math.Abs(15.18662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vrå", "19", 57.3537, 9.94176);
case 1: return new CityInfo("Vordingborg", "20", 55.00801, 11.91057);
case 2: return new CityInfo("Vojens", "21", 55.24639, 9.30603);
case 3: return new CityInfo("Vodskov", "19", 57.10854, 10.02215);
case 4: return new CityInfo("Vissenbjerg", "21", 55.38482, 10.13784);
case 5: return new CityInfo("Virklund", "18", 56.13218, 9.55582);
case 6: return new CityInfo("Vipperød", "20", 55.66768, 11.73967);
case 7: return new CityInfo("Vindinge", "20", 55.62298, 12.1387);
case 8: return new CityInfo("Vinderup", "18", 56.48176, 8.77991);
case 9: return new CityInfo("Vindeby", "21", 55.04489, 10.61309);
case 10: return new CityInfo("Vildbjerg", "18", 56.2, 8.76667);
case 11: return new CityInfo("Videbæk", "18", 56.0876, 8.62852);
case 12: return new CityInfo("Viby", "20", 55.54872, 12.02391);
case 13: return new CityInfo("Viborg", "18", 56.45319, 9.40201);
case 14: return new CityInfo("Vester-Skerninge", "21", 55.07322, 10.45536);
case 15: return new CityInfo("Vester Hassing", "19", 57.06767, 10.12558);
case 16: return new CityInfo("Vestbjerg", "19", 57.13166, 9.95942);
case 17: return new CityInfo("Veksø", "17", 55.75473, 12.23837);
case 18: return new CityInfo("Vejle", "21", 55.70927, 9.5357);
case 19: return new CityInfo("Vejen", "21", 55.48117, 9.13795);
case 20: return new CityInfo("Varde", "21", 55.62112, 8.48069);
case 21: return new CityInfo("Vanløse", "17", 55.68361, 12.48713);
case 22: return new CityInfo("Vamdrup", "21", 55.42764, 9.28435);
case 23: return new CityInfo("Vallensbæk", "17", 55.62199, 12.38511);
case 24: return new CityInfo("Vadum", "19", 57.1179, 9.857);
case 25: return new CityInfo("Ulstrup", "18", 56.38994, 9.79354);
case 26: return new CityInfo("Ullerslev", "21", 55.36172, 10.6519);
case 27: return new CityInfo("Ulfborg", "18", 56.26725, 8.32167);
case 28: return new CityInfo("Tune", "20", 55.59287, 12.16968);
case 29: return new CityInfo("Trørød", "17", 55.83946, 12.54432);
case 30: return new CityInfo("Trige", "18", 56.25291, 10.1484);
case 31: return new CityInfo("Tranebjerg", "18", 55.8326, 10.59723);
case 32: return new CityInfo("Tranbjerg", "18", 56.09519, 10.13605);
case 33: return new CityInfo("Tørring", "18", 55.85, 9.48333);
case 34: return new CityInfo("Tønder", "21", 54.93306, 8.86674);
case 35: return new CityInfo("Tølløse", "20", 55.6125, 11.77034);
case 36: return new CityInfo("Tommerup Stationsby", "21", 55.34535, 10.17594);
case 37: return new CityInfo("Tommerup", "21", 55.31952, 10.20659);
case 38: return new CityInfo("Toftlund", "21", 55.18858, 9.06925);
case 39: return new CityInfo("Tjæreborg", "21", 55.46457, 8.57968);
case 40: return new CityInfo("Tinglev", "21", 54.93788, 9.25547);
case 41: return new CityInfo("Thyborøn", "18", 56.69846, 8.21238);
case 42: return new CityInfo("Thurø By", "21", 55.0474, 10.66385);
case 43: return new CityInfo("Thisted", "19", 56.95523, 8.69491);
case 44: return new CityInfo("Taulov", "21", 55.54582, 9.61553);
case 45: return new CityInfo("Taastrup", "17", 55.65006, 12.3016);
case 46: return new CityInfo("Tårs", "19", 57.38333, 10.11667);
case 47: return new CityInfo("Tårnby", "17", 55.6303, 12.60035);
case 48: return new CityInfo("Tarm", "18", 55.90861, 8.53041);
case 49: return new CityInfo("Svogerslev", "20", 55.63423, 12.01465);
case 50: return new CityInfo("Svinninge", "20", 55.72111, 11.46547);
case 51: return new CityInfo("Svenstrup", "19", 56.9723, 9.84806);
case 52: return new CityInfo("Svendborg", "21", 55.05982, 10.60677);
case 53: return new CityInfo("Svejbæk", "18", 56.13255, 9.63289);
case 54: return new CityInfo("Svebølle", "20", 55.65183, 11.28658);
case 55: return new CityInfo("Sunds", "18", 56.20743, 9.01386);
case 56: return new CityInfo("Stubbekøbing", "20", 54.88875, 12.04102);
case 57: return new CityInfo("Struer", "18", 56.49205, 8.59397);
case 58: return new CityInfo("Strøby Egede", "20", 55.41382, 12.24502);
case 59: return new CityInfo("Strib", "21", 55.54021, 9.76748);
case 60: return new CityInfo("Strandby", "19", 57.4915, 10.49609);
case 61: return new CityInfo("Storvorde", "19", 57.00392, 10.10125);
case 62: return new CityInfo("Store Heddinge", "20", 55.30965, 12.38885);
case 63: return new CityInfo("Støvring", "19", 56.88536, 9.83839);
case 64: return new CityInfo("Stoholm", "18", 56.48454, 9.14617);
case 65: return new CityInfo("Stilling", "18", 56.06224, 9.98822);
case 66: return new CityInfo("Stige", "21", 55.43941, 10.4094);
case 67: return new CityInfo("Stenløse", "17", 55.76828, 12.19723);
case 68: return new CityInfo("Stenlille", "20", 55.53888, 11.5912);
case 69: return new CityInfo("Stege", "20", 54.98704, 12.28461);
case 70: return new CityInfo("Stavtrup", "18", 56.13124, 10.11987);
case 71: return new CityInfo("Stavnsholt", "17", 55.81479, 12.40545);
case 72: return new CityInfo("Starup", "21", 55.24097, 9.53503);
case 73: return new CityInfo("Spentrup", "18", 56.53703, 10.03792);
case 74: return new CityInfo("Sorø", "20", 55.43184, 11.55547);
case 75: return new CityInfo("Søndersø", "21", 55.48526, 10.2554);
case 76: return new CityInfo("Sønderborg", "21", 54.90896, 9.78917);
case 77: return new CityInfo("Sønder Bjert", "21", 55.45272, 9.56741);
case 78: return new CityInfo("Søften", "18", 56.23801, 10.0851);
case 79: return new CityInfo("Solrød Strand", "20", 55.53285, 12.22227);
case 80: return new CityInfo("Solrød", "20", 55.53628, 12.1827);
case 81: return new CityInfo("Solbjerg", "18", 56.04271, 10.08631);
case 82: return new CityInfo("Snoghøj", "21", 55.52253, 9.72125);
case 83: return new CityInfo("Snejbjerg", "18", 56.13291, 8.90353);
case 84: return new CityInfo("Smørumnedre", "17", 55.74232, 12.30276);
case 85: return new CityInfo("Slangerup", "17", 55.85, 12.18333);
case 86: return new CityInfo("Slagelse", "20", 55.40276, 11.35459);
case 87: return new CityInfo("Skævinge", "17", 55.90785, 12.15036);
case 88: return new CityInfo("Skaerbaek", "21", 55.15735, 8.76901);
case 89: return new CityInfo("Skovby", "18", 56.15672, 9.94523);
case 90: return new CityInfo("Skørping", "19", 56.83626, 9.89255);
case 91: return new CityInfo("Skælskør", "20", 55.25058, 11.29352);
case 92: return new CityInfo("Skjern", "18", 55.95, 8.5);
case 93: return new CityInfo("Skive", "18", 56.56699, 9.02707);
case 94: return new CityInfo("Skibby", "17", 55.75122, 11.96083);
case 95: return new CityInfo("Skanderborg", "18", 56.03434, 9.93177);
case 96: return new CityInfo("Skagen", "19", 57.72093, 10.58394);
case 97: return new CityInfo("Sindal", "19", 57.47117, 10.20312);
case 98: return new CityInfo("Silkeborg", "18", 56.1697, 9.54508);
case 99: return new CityInfo("Seden", "21", 55.42648, 10.44265);
case 100: return new CityInfo("Sæby", "19", 57.33188, 10.52251);
case 101: return new CityInfo("Sakskøbing", "20", 54.7997, 11.62599);
case 102: return new CityInfo("Sabro", "18", 56.21333, 10.03441);
case 103: return new CityInfo("Ryomgård", "18", 56.3843, 10.50295);
case 104: return new CityInfo("Ry", "18", 56.09038, 9.76505);
case 105: return new CityInfo("Rudkøbing", "21", 54.93639, 10.71019);
case 106: return new CityInfo("Roskilde", "20", 55.64152, 12.08035);
case 107: return new CityInfo("Rønnede", "20", 55.2571, 12.02125);
case 108: return new CityInfo("Rønne", "17", 55.10091, 14.70664);
case 109: return new CityInfo("Rønde", "18", 56.30145, 10.47505);
case 110: return new CityInfo("Rødvig", "20", 55.2554, 12.37936);
case 111: return new CityInfo("Rødovre", "17", 55.68062, 12.45373);
case 112: return new CityInfo("Rødekro", "21", 55.07076, 9.33531);
case 113: return new CityInfo("Rødding", "21", 55.36569, 9.06316);
case 114: return new CityInfo("Rødbyhavn", "20", 54.65944, 11.35504);
case 115: return new CityInfo("Rødby", "20", 54.69495, 11.38885);
case 116: return new CityInfo("Ringsted", "20", 55.4426, 11.79011);
case 117: return new CityInfo("Ringkøbing", "18", 56.09006, 8.24402);
case 118: return new CityInfo("Ringe", "21", 55.23828, 10.4786);
case 119: return new CityInfo("Ribe", "21", 55.33051, 8.76966);
case 120: return new CityInfo("Randers", "18", 56.4607, 10.03639);
case 121: return new CityInfo("Præstø", "20", 55.12374, 12.04477);
case 122: return new CityInfo("Pandrup", "19", 57.22147, 9.67569);
case 123: return new CityInfo("Padborg", "21", 54.82657, 9.36247);
case 124: return new CityInfo("Otterup", "21", 55.51527, 10.39756);
case 125: return new CityInfo("Osted", "20", 55.56228, 11.95786);
case 126: return new CityInfo("Ørslev", "20", 55.04356, 11.96792);
case 127: return new CityInfo("Ølstykke", "17", 55.79567, 12.15509);
case 128: return new CityInfo("Ølgod", "21", 55.80682, 8.62859);
case 129: return new CityInfo("Oksbøl", "21", 55.6268, 8.28757);
case 130: return new CityInfo("Odense", "21", 55.39594, 10.38831);
case 131: return new CityInfo("Odder", "18", 55.97313, 10.153);
case 132: return new CityInfo("Nyråd", "20", 55.00511, 11.9606);
case 133: return new CityInfo("Nykøbing Falster", "20", 54.76906, 11.87425);
case 134: return new CityInfo("Nykøbing Sjælland", "20", 55.92491, 11.67109);
case 135: return new CityInfo("Nykøbing Mors", "19", 56.79334, 8.85282);
case 136: return new CityInfo("Nyborg", "21", 55.31274, 10.78964);
case 137: return new CityInfo("Næstved", "20", 55.22992, 11.76092);
case 138: return new CityInfo("Nordby", "21", 55.44603, 8.39786);
case 139: return new CityInfo("Nordborg", "21", 55.05732, 9.7408);
case 140: return new CityInfo("Nørresundby", "19", 57.05877, 9.92284);
case 141: return new CityInfo("Nørre Alslev", "20", 54.89784, 11.88414);
case 142: return new CityInfo("Nørre Åby", "21", 55.46107, 9.8794);
case 143: return new CityInfo("Nødebo", "17", 55.97877, 12.34685);
case 144: return new CityInfo("Nivå", "17", 55.93405, 12.50485);
case 145: return new CityInfo("Nibe", "19", 56.9815, 9.63917);
case 146: return new CityInfo("Nexø", "17", 55.06067, 15.13058);
case 147: return new CityInfo("Neder Vindinge", "20", 55.03211, 11.88356);
case 148: return new CityInfo("Neder Holluf", "21", 55.36451, 10.44824);
case 149: return new CityInfo("Nakskov", "20", 54.83038, 11.13567);
case 150: return new CityInfo("Munkebo", "21", 55.45553, 10.55433);
case 151: return new CityInfo("Middelfart", "21", 55.50591, 9.73054);
case 152: return new CityInfo("Marstal", "21", 54.85621, 10.51726);
case 153: return new CityInfo("Mårslet", "18", 56.0669, 10.16112);
case 154: return new CityInfo("Maribo", "20", 54.77662, 11.50017);
case 155: return new CityInfo("Mariager", "19", 56.64985, 9.97515);
case 156: return new CityInfo("Måløv", "17", 55.75528, 12.32327);
case 157: return new CityInfo("Malling", "18", 56.03632, 10.19632);
case 158: return new CityInfo("Lystrup", "18", 56.2375, 10.23778);
case 159: return new CityInfo("Lynge", "17", 55.83941, 12.27725);
case 160: return new CityInfo("Lunderskov", "21", 55.48375, 9.29917);
case 161: return new CityInfo("Løkken", "19", 57.37047, 9.71466);
case 162: return new CityInfo("Løjt Kirkeby", "21", 55.08959, 9.46084);
case 163: return new CityInfo("Løgumkloster", "21", 55.05941, 8.95508);
case 164: return new CityInfo("Løgten", "18", 56.27459, 10.31181);
case 165: return new CityInfo("Løgstør", "19", 56.96245, 9.2583);
case 166: return new CityInfo("Liseleje", "17", 56.01295, 11.96544);
case 167: return new CityInfo("Lind", "18", 56.106, 8.97915);
case 168: return new CityInfo("Værløse", "17", 55.78251, 12.36856);
case 169: return new CityInfo("Lillerød", "17", 55.87496, 12.34579);
case 170: return new CityInfo("Lemvig", "18", 56.54856, 8.31019);
case 171: return new CityInfo("Lejre", "20", 55.60461, 11.97477);
case 172: return new CityInfo("Langeskov", "21", 55.35655, 10.58447);
case 173: return new CityInfo("Langå", "18", 56.39026, 9.89486);
case 174: return new CityInfo("Kruså", "21", 54.85097, 9.40129);
case 175: return new CityInfo("Korsør", "20", 55.32993, 11.13857);
case 176: return new CityInfo("Køge", "20", 55.45802, 12.18214);
case 177: return new CityInfo("Copenhagen", "17", 55.67594, 12.56553);
case 178: return new CityInfo("Kongens Lyngby", "17", 55.77044, 12.50378);
case 179: return new CityInfo("Kolt", "18", 56.10845, 10.06986);
case 180: return new CityInfo("Kolding", "21", 55.4904, 9.47216);
case 181: return new CityInfo("Kokkedal", "17", 55.91179, 12.49952);
case 182: return new CityInfo("Klarup", "19", 57.01194, 10.05617);
case 183: return new CityInfo("Kjellerup", "18", 56.28581, 9.43528);
case 184: return new CityInfo("Kirke Hvalsø", "20", 55.5917, 11.86253);
case 185: return new CityInfo("Kibæk", "18", 56.0317, 8.85697);
case 186: return new CityInfo("Kerteminde", "21", 55.44903, 10.65769);
case 187: return new CityInfo("Kås", "19", 57.19774, 9.67173);
case 188: return new CityInfo("Karup", "18", 56.30673, 9.16835);
case 189: return new CityInfo("Kalundborg", "20", 55.67954, 11.08864);
case 190: return new CityInfo("Jyllinge", "20", 55.75295, 12.10315);
case 191: return new CityInfo("Jyderup", "20", 55.66399, 11.42029);
case 192: return new CityInfo("Juelsminde", "18", 55.70876, 10.01668);
case 193: return new CityInfo("Jægerspris", "17", 55.85248, 11.98565);
case 194: return new CityInfo("Jelling", "21", 55.75588, 9.4258);
case 195: return new CityInfo("Ishøj", "17", 55.61543, 12.35182);
case 196: return new CityInfo("Isenvad", "18", 56.09915, 9.2047);
case 197: return new CityInfo("Ikast", "18", 56.13883, 9.15768);
case 198: return new CityInfo("Hvidovre", "17", 55.65719, 12.47364);
case 199: return new CityInfo("Hvide Sande", "18", 55.99866, 8.12605);
case 200: return new CityInfo("Hurup", "19", 56.74944, 8.41953);
case 201: return new CityInfo("Hundested", "17", 55.96397, 11.85044);
case 202: return new CityInfo("Humlebæk", "17", 55.9618, 12.5341);
case 203: return new CityInfo("Horsens", "18", 55.86066, 9.85034);
case 204: return new CityInfo("Hornsyld", "18", 55.75621, 9.85643);
case 205: return new CityInfo("Hornslet", "18", 56.3155, 10.32041);
case 206: return new CityInfo("Hornbæk", "17", 56.09027, 12.45693);
case 207: return new CityInfo("Hørve", "20", 55.75292, 11.45298);
case 208: return new CityInfo("Høruphav", "21", 54.91017, 9.89872);
case 209: return new CityInfo("Hørsholm", "17", 55.88098, 12.50111);
case 210: return new CityInfo("Hørning", "18", 56.08701, 10.03716);
case 211: return new CityInfo("Høng", "20", 55.50736, 11.28873);
case 212: return new CityInfo("Højby", "20", 55.91148, 11.59756);
case 213: return new CityInfo("Højby", "21", 55.33177, 10.43725);
case 214: return new CityInfo("Holte", "17", 55.81667, 12.46667);
case 215: return new CityInfo("Holsted", "21", 55.51086, 8.91872);
case 216: return new CityInfo("Holstebro", "18", 56.36009, 8.61607);
case 217: return new CityInfo("Holeby", "20", 54.71148, 11.46416);
case 218: return new CityInfo("Holbæk", "20", 55.7175, 11.71279);
case 219: return new CityInfo("Hobro", "19", 56.64306, 9.79029);
case 220: return new CityInfo("Hjortshøj", "18", 56.24811, 10.26533);
case 221: return new CityInfo("Hjørring", "19", 57.46417, 9.98229);
case 222: return new CityInfo("Hjallerup", "19", 57.16466, 10.14571);
case 223: return new CityInfo("Hirtshals", "19", 57.58812, 9.95922);
case 224: return new CityInfo("Hinnerup", "18", 56.26608, 10.06299);
case 225: return new CityInfo("Hillerød", "17", 55.92791, 12.30081);
case 226: return new CityInfo("Herning", "18", 56.13615, 8.97662);
case 227: return new CityInfo("Herlev", "17", 55.72366, 12.43998);
case 228: return new CityInfo("Helsingør", "17", 56.03606, 12.6136);
case 229: return new CityInfo("Helsinge", "17", 56.02283, 12.19752);
case 230: return new CityInfo("Hellebæk", "17", 56.06823, 12.55782);
case 231: return new CityInfo("Hedensted", "18", 55.77043, 9.7011);
case 232: return new CityInfo("Havdrup", "20", 55.54481, 12.12392);
case 233: return new CityInfo("Haslev", "20", 55.32346, 11.96389);
case 234: return new CityInfo("Harndrup", "21", 55.46658, 10.02165);
case 235: return new CityInfo("Hårlev", "20", 55.34936, 12.23382);
case 236: return new CityInfo("Hårby", "21", 55.22357, 10.12268);
case 237: return new CityInfo("Harboøre", "18", 56.61752, 8.18069);
case 238: return new CityInfo("Hanstholm", "19", 57.11548, 8.6172);
case 239: return new CityInfo("Hammerum", "18", 56.13361, 9.06121);
case 240: return new CityInfo("Hammel", "18", 56.25762, 9.86316);
case 241: return new CityInfo("Hals", "19", 56.99609, 10.30807);
case 242: return new CityInfo("Hadsund", "19", 56.71482, 10.11682);
case 243: return new CityInfo("Hadsten", "18", 56.32819, 10.04931);
case 244: return new CityInfo("Haderslev", "21", 55.24943, 9.48771);
case 245: return new CityInfo("Gundsømagle", "20", 55.73565, 12.15158);
case 246: return new CityInfo("Guderup", "21", 54.98978, 9.87174);
case 247: return new CityInfo("Græsted", "17", 56.06558, 12.28512);
case 248: return new CityInfo("Grindsted", "21", 55.75726, 8.9275);
case 249: return new CityInfo("Greve", "20", 55.58333, 12.3);
case 250: return new CityInfo("Grenaa", "18", 56.41578, 10.87825);
case 251: return new CityInfo("Gråsten", "21", 54.91918, 9.59523);
case 252: return new CityInfo("Gram", "21", 55.28948, 9.04913);
case 253: return new CityInfo("Gørlev", "20", 55.53926, 11.22708);
case 254: return new CityInfo("Glostrup", "17", 55.6666, 12.40377);
case 255: return new CityInfo("Glamsbjerg", "21", 55.27237, 10.10483);
case 256: return new CityInfo("Gjellerup", "18", 56.14616, 9.05467);
case 257: return new CityInfo("Give", "21", 55.84523, 9.23769);
case 258: return new CityInfo("Gistrup", "19", 56.9943, 9.99085);
case 259: return new CityInfo("Gilleleje", "17", 56.12196, 12.31056);
case 260: return new CityInfo("Gedser", "20", 54.57644, 11.93004);
case 261: return new CityInfo("Ganløse", "17", 55.79124, 12.26421);
case 262: return new CityInfo("Galten", "18", 56.15902, 9.91691);
case 263: return new CityInfo("Fuglebjerg", "20", 55.30604, 11.54766);
case 264: return new CityInfo("Frejlev", "19", 57.00623, 9.81711);
case 265: return new CityInfo("Frederiksværk", "17", 55.97073, 12.0225);
case 266: return new CityInfo("Frederikssund", "17", 55.83956, 12.06896);
case 267: return new CityInfo("Frederikshavn", "19", 57.44073, 10.53661);
case 268: return new CityInfo("Frederiksberg", "17", 55.67938, 12.53463);
case 269: return new CityInfo("Frederiksberg", "20", 55.41618, 11.56934);
case 270: return new CityInfo("Fredericia", "21", 55.56568, 9.75257);
case 271: return new CityInfo("Fredensborg", "17", 55.97558, 12.40314);
case 272: return new CityInfo("Framlev", "18", 56.15664, 10.01318);
case 273: return new CityInfo("Forlev", "20", 55.37445, 11.25966);
case 274: return new CityInfo("Fløng", "17", 55.66212, 12.18698);
case 275: return new CityInfo("Fjerritslev", "19", 57.08822, 9.26622);
case 276: return new CityInfo("Fensmark", "20", 55.27919, 11.80382);
case 277: return new CityInfo("Farum", "17", 55.80858, 12.36066);
case 278: return new CityInfo("Farsø", "19", 56.77276, 9.33925);
case 279: return new CityInfo("Faxe Ladeplads", "20", 55.21981, 12.17013);
case 280: return new CityInfo("Faxe", "20", 55.25561, 12.11926);
case 281: return new CityInfo("Faaborg", "21", 55.0951, 10.24226);
case 282: return new CityInfo("Espergærde", "17", 55.99464, 12.54733);
case 283: return new CityInfo("Esbjerg", "21", 55.47028, 8.45187);
case 284: return new CityInfo("Ejby", "20", 55.68923, 11.84725);
case 285: return new CityInfo("Ejby", "20", 55.4858, 12.08171);
case 286: return new CityInfo("Ejby", "21", 55.4301, 9.92973);
case 287: return new CityInfo("Egtved", "21", 55.61613, 9.30763);
case 288: return new CityInfo("Ebeltoft", "18", 56.19442, 10.6821);
case 289: return new CityInfo("Dybbøl", "21", 54.91079, 9.73601);
case 290: return new CityInfo("Dronninglund", "19", 57.16035, 10.29287);
case 291: return new CityInfo("Dragør", "17", 55.5928, 12.67221);
case 292: return new CityInfo("Dianalund", "20", 55.53133, 11.4925);
case 293: return new CityInfo("Christianshavn", "17", 55.67383, 12.59541);
case 294: return new CityInfo("Christiansfeld", "21", 55.35817, 9.48701);
case 295: return new CityInfo("Charlottenlund", "17", 55.75238, 12.5745);
case 296: return new CityInfo("Byrum", "19", 57.25679, 10.99738);
case 297: return new CityInfo("Bullerup", "21", 55.42686, 10.47137);
case 298: return new CityInfo("Buddinge", "17", 55.74818, 12.49532);
case 299: return new CityInfo("Brovst", "19", 57.0975, 9.52264);
case 300: return new CityInfo("Brørup", "21", 55.48194, 9.01756);
case 301: return new CityInfo("Brønderslev", "19", 57.27021, 9.94102);
case 302: return new CityInfo("Brøndbyvester", "17", 55.6455, 12.41008);
case 303: return new CityInfo("Broager", "21", 54.8894, 9.67465);
case 304: return new CityInfo("Brenderup", "21", 55.48407, 9.97908);
case 305: return new CityInfo("Brejning", "21", 55.66594, 9.67217);
case 306: return new CityInfo("Brædstrup", "18", 55.97153, 9.61129);
case 307: return new CityInfo("Brande", "18", 55.94316, 9.12798);
case 308: return new CityInfo("Bramming", "21", 55.46946, 8.70007);
case 309: return new CityInfo("Borup", "20", 55.49472, 11.97584);
case 310: return new CityInfo("Bording Kirkeby", "18", 56.16871, 9.24384);
case 311: return new CityInfo("Børkop", "21", 55.64195, 9.64958);
case 312: return new CityInfo("Bogense", "21", 55.56691, 10.08863);
case 313: return new CityInfo("Blovstrød", "17", 55.87038, 12.3864);
case 314: return new CityInfo("Bjæverskov", "20", 55.45756, 12.03651);
case 315: return new CityInfo("Bjerringbro", "18", 56.37797, 9.66065);
case 316: return new CityInfo("Birkerød", "17", 55.84759, 12.42791);
case 317: return new CityInfo("Billund", "21", 55.73349, 9.10785);
case 318: return new CityInfo("Bellinge", "21", 55.33535, 10.32045);
case 319: return new CityInfo("Beder", "18", 56.06025, 10.21179);
case 320: return new CityInfo("Ballerup", "17", 55.73165, 12.36328);
case 321: return new CityInfo("Avlum", "18", 56.26539, 8.79256);
case 322: return new CityInfo("Auning", "18", 56.43079, 10.37818);
case 323: return new CityInfo("Augustenborg", "21", 54.95201, 9.87216);
case 324: return new CityInfo("Assentoft", "18", 56.4421, 10.1517);
case 325: return new CityInfo("Assens", "21", 55.27023, 9.90081);
case 326: return new CityInfo("Asnæs", "20", 55.81229, 11.50129);
case 327: return new CityInfo("Årup", "21", 55.37315, 10.04131);
case 328: return new CityInfo("Årslev", "21", 55.30353, 10.46428);
case 329: return new CityInfo("Aars", "19", 56.80399, 9.51441);
case 330: return new CityInfo("Århus", "18", 56.15674, 10.21076);
case 331: return new CityInfo("Arden", "19", 56.76899, 9.86184);
case 332: return new CityInfo("Allingåbro", "18", 56.46432, 10.31957);
case 333: return new CityInfo("Ålestrup", "19", 56.6947, 9.49336);
case 334: return new CityInfo("Aalborg", "19", 57.048, 9.9187);
case 335: return new CityInfo("Albertslund", "17", 55.65691, 12.36381);
case 336: return new CityInfo("Åkirkeby", "17", 55.0708, 14.91978);
case 337: return new CityInfo("Ærøskøbing", "21", 54.88803, 10.41117);
case 338: return new CityInfo("Åbybro", "19", 57.16249, 9.72996);
case 339: return new CityInfo("Aabenraa", "21", 55.04434, 9.41741);
case 340: return new CityInfo("Sundby", "20", 54.76711, 11.84979);
case 341: return new CityInfo("Vibekevang", "17", 55.70574, 12.55544);
default: return new CityInfo("Christiansø", "17", 55.32006, 15.18662);

                                    }                                        
                                }
                            
                        }
                    }
                