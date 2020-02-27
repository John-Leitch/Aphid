
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
                                    public const string Country = "CO";
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
                            
                                        var cur = (Math.Abs(5.02208 - lat) + Math.Abs(-74.00481 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(4.75881 - lat) + Math.Abs(-74.38017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28215 - lat) + Math.Abs(-73.16896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.39462 - lat) + Math.Abs(-76.0715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.48971 - lat) + Math.Abs(-74.86919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.81532 - lat) + Math.Abs(-73.26768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7474 - lat) + Math.Abs(-74.81572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.53168 - lat) + Math.Abs(-76.63512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.58234 - lat) + Math.Abs(-76.49146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.86048 - lat) + Math.Abs(-76.38364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33775 - lat) + Math.Abs(-72.39586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.00621 - lat) + Math.Abs(-73.90972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.59841 - lat) + Math.Abs(-75.0114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.96321 - lat) + Math.Abs(-75.41738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.67457 - lat) + Math.Abs(-74.8343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.66355 - lat) + Math.Abs(-75.51753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.11577 - lat) + Math.Abs(-77.40169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.45948 - lat) + Math.Abs(-74.33823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06242 - lat) + Math.Abs(-75.87159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.12428 - lat) + Math.Abs(-73.75156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.43637 - lat) + Math.Abs(-73.29606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.43713 - lat) + Math.Abs(-74.52157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00886 - lat) + Math.Abs(-74.47226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.22052 - lat) + Math.Abs(-75.21864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.142 - lat) + Math.Abs(-73.62664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.93502 - lat) + Math.Abs(-74.60036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.17484 - lat) + Math.Abs(-76.46197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.83389 - lat) + Math.Abs(-72.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.21617 - lat) + Math.Abs(-73.5949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60768 - lat) + Math.Abs(-72.97901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44361 - lat) + Math.Abs(-75.27306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.67169 - lat) + Math.Abs(-73.17421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28333 - lat) + Math.Abs(-71.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.04565 - lat) + Math.Abs(-75.51474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.03067 - lat) + Math.Abs(-75.11607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.27372 - lat) + Math.Abs(-74.19614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.0375 - lat) + Math.Abs(-76.62667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.63413 - lat) + Math.Abs(-73.52438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91427 - lat) + Math.Abs(-72.97144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.69934 - lat) + Math.Abs(-76.4423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.58933 - lat) + Math.Abs(-76.89599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.52583 - lat) + Math.Abs(-74.23611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.31648 - lat) + Math.Abs(-74.91101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.87384 - lat) + Math.Abs(-74.56244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.30911 - lat) + Math.Abs(-72.87122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.57544 - lat) + Math.Abs(-76.19814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.11841 - lat) + Math.Abs(-74.34549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.36753 - lat) + Math.Abs(-73.52075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.96278 - lat) + Math.Abs(-75.73806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.08808 - lat) + Math.Abs(-74.47746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.71929 - lat) + Math.Abs(-74.92918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.01335 - lat) + Math.Abs(-73.67352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.615 - lat) + Math.Abs(-75.62422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.19403 - lat) + Math.Abs(-75.70746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.46314 - lat) + Math.Abs(-73.25322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.19869 - lat) + Math.Abs(-75.11733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4475 - lat) + Math.Abs(-73.14361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25801 - lat) + Math.Abs(-76.14928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.29382 - lat) + Math.Abs(-75.3919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.18727 - lat) + Math.Abs(-74.48105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.74313 - lat) + Math.Abs(-74.97604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.55894 - lat) + Math.Abs(-73.01232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.31696 - lat) + Math.Abs(-76.1342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.71505 - lat) + Math.Abs(-72.26592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.2409 - lat) + Math.Abs(-74.35497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.78637 - lat) + Math.Abs(-75.5337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.89944 - lat) + Math.Abs(-76.17417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.04364 - lat) + Math.Abs(-77.09137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.40306 - lat) + Math.Abs(-74.02528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.22041 - lat) + Math.Abs(-73.45695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.70444 - lat) + Math.Abs(-75.74028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.30933 - lat) + Math.Abs(-73.81575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.48667 - lat) + Math.Abs(-73.93748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74778 - lat) + Math.Abs(-72.53694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.03228 - lat) + Math.Abs(-72.85639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.68966 - lat) + Math.Abs(-73.22779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3236 - lat) + Math.Abs(-73.49067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09263 - lat) + Math.Abs(-76.72822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.27169 - lat) + Math.Abs(-75.44222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.32944 - lat) + Math.Abs(-75.41137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.08647 - lat) + Math.Abs(-77.61858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.72967 - lat) + Math.Abs(-73.94137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.53528 - lat) + Math.Abs(-73.36778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.79112 - lat) + Math.Abs(-78.79275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.08466 - lat) + Math.Abs(-76.19536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.18662 - lat) + Math.Abs(-75.55473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.87562 - lat) + Math.Abs(-74.97873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.21217 - lat) + Math.Abs(-76.31945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.40849 - lat) + Math.Abs(-71.66196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.86512 - lat) + Math.Abs(-74.70906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.51111 - lat) + Math.Abs(-76.40178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55833 - lat) + Math.Abs(-72.98757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.61167 - lat) + Math.Abs(-76.08139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.95481 - lat) + Math.Abs(-76.26839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33457 - lat) + Math.Abs(-74.30292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75979 - lat) + Math.Abs(-72.82583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.20221 - lat) + Math.Abs(-72.96502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.45082 - lat) + Math.Abs(-75.43864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.52392 - lat) + Math.Abs(-75.58139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.30984 - lat) + Math.Abs(-72.48295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.01306 - lat) + Math.Abs(-75.69528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.93462 - lat) + Math.Abs(-73.51297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.96531 - lat) + Math.Abs(-73.91301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.4582 - lat) + Math.Abs(-74.63434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.56393 - lat) + Math.Abs(-73.18398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.06276 - lat) + Math.Abs(-75.7937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.42031 - lat) + Math.Abs(-72.69184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.57916 - lat) + Math.Abs(-73.64486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.7717 - lat) + Math.Abs(-77.66536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.35017 - lat) + Math.Abs(-76.68341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.97136 - lat) + Math.Abs(-75.93123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.17361 - lat) + Math.Abs(-76.05917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.63895 - lat) + Math.Abs(-72.73583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.05227 - lat) + Math.Abs(-73.50459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75 - lat) + Math.Abs(-73 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.31728 - lat) + Math.Abs(-73.39655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.35 - lat) + Math.Abs(-74.45179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.48587 - lat) + Math.Abs(-75.72921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.74193 - lat) + Math.Abs(-75.56738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43633 - lat) + Math.Abs(-73.28981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.07664 - lat) + Math.Abs(-73.42077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.8727 - lat) + Math.Abs(-74.14435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90093 - lat) + Math.Abs(-74.85985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.66001 - lat) + Math.Abs(-74.39258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.06694 - lat) + Math.Abs(-75.13778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.19903 - lat) + Math.Abs(-73.89128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.01789 - lat) + Math.Abs(-72.74675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.91044 - lat) + Math.Abs(-72.78001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.86467 - lat) + Math.Abs(-75.82192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.11248 - lat) + Math.Abs(-75.82419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58358 - lat) + Math.Abs(-75.40068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.892 - lat) + Math.Abs(-69.742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.09473 - lat) + Math.Abs(-77.39482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.57032 - lat) + Math.Abs(-77.28043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.66462 - lat) + Math.Abs(-75.71339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46065 - lat) + Math.Abs(-71.73618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.82998 - lat) + Math.Abs(-72.16286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85221 - lat) + Math.Abs(-73.81229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.31206 - lat) + Math.Abs(-74.58544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.30347 - lat) + Math.Abs(-74.56477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.26598 - lat) + Math.Abs(-76.56487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91726 - lat) + Math.Abs(-74.09364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.02311 - lat) + Math.Abs(-73.4523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.24779 - lat) + Math.Abs(-73.85238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.61538 - lat) + Math.Abs(-73.61701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.22978 - lat) + Math.Abs(-72.6901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.4519 - lat) + Math.Abs(-73.81436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36633 - lat) + Math.Abs(-72.98361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.45303 - lat) + Math.Abs(-75.65072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06097 - lat) + Math.Abs(-74.23721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.10289 - lat) + Math.Abs(-73.79845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.81136 - lat) + Math.Abs(-74.72084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.91833 - lat) + Math.Abs(-73.79109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.03805 - lat) + Math.Abs(-76.92446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.92614 - lat) + Math.Abs(-74.17299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.97611 - lat) + Math.Abs(-75.79454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.04906 - lat) + Math.Abs(-74.83198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.95395 - lat) + Math.Abs(-76.69644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.33347 - lat) + Math.Abs(-74.88016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.1014 - lat) + Math.Abs(-73.44041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.49474 - lat) + Math.Abs(-77.52136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.76483 - lat) + Math.Abs(-73.24758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.50055 - lat) + Math.Abs(-73.33299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.56514 - lat) + Math.Abs(-73.45017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.9075 - lat) + Math.Abs(-73.9384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.39306 - lat) + Math.Abs(-75.14083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.71062 - lat) + Math.Abs(-75.31069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.98495 - lat) + Math.Abs(-73.43238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.91843 - lat) + Math.Abs(-74.76459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.69937 - lat) + Math.Abs(-75.25353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.71434 - lat) + Math.Abs(-72.93391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04028 - lat) + Math.Abs(-72.63509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46838 - lat) + Math.Abs(-73.26022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9817 - lat) + Math.Abs(-72.71503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33369 - lat) + Math.Abs(-72.68283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.57937 - lat) + Math.Abs(-74.21682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.77737 - lat) + Math.Abs(-74.72049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.65374 - lat) + Math.Abs(-76.64442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.30472 - lat) + Math.Abs(-75.39778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24391 - lat) + Math.Abs(-75.14675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.9579 - lat) + Math.Abs(-73.9436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.50291 - lat) + Math.Abs(-73.85227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4429 - lat) + Math.Abs(-73.33688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.61557 - lat) + Math.Abs(-76.38261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.40367 - lat) + Math.Abs(-74.3867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.20524 - lat) + Math.Abs(-72.75639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.20296 - lat) + Math.Abs(-76.92275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.49154 - lat) + Math.Abs(-74.25957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51238 - lat) + Math.Abs(-73.24436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.76343 - lat) + Math.Abs(-74.13916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.26425 - lat) + Math.Abs(-75.93085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.04463 - lat) + Math.Abs(-73.79724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.07993 - lat) + Math.Abs(-74.6989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.08959 - lat) + Math.Abs(-72.72432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13156 - lat) + Math.Abs(-72.70895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.96705 - lat) + Math.Abs(-74.43512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.08289 - lat) + Math.Abs(-72.80071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.96319 - lat) + Math.Abs(-71.8823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.03728 - lat) + Math.Abs(-77.62094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24217 - lat) + Math.Abs(-74.50037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.12172 - lat) + Math.Abs(-74.76614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.881 - lat) + Math.Abs(-73.40977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.28535 - lat) + Math.Abs(-75.33385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13833 - lat) + Math.Abs(-75.26417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.07415 - lat) + Math.Abs(-75.96423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.75773 - lat) + Math.Abs(-74.75451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.47282 - lat) + Math.Abs(-75.16547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.86432 - lat) + Math.Abs(-72.7162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.14844 - lat) + Math.Abs(-77.0045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.70908 - lat) + Math.Abs(-73.60404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.13356 - lat) + Math.Abs(-70.86233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87401 - lat) + Math.Abs(-72.98217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.64738 - lat) + Math.Abs(-75.46031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.86806 - lat) + Math.Abs(-75.62139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44472 - lat) + Math.Abs(-75.36972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.70267 - lat) + Math.Abs(-76.57389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.18333 - lat) + Math.Abs(-76.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.00945 - lat) + Math.Abs(-76.48494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.0575 - lat) + Math.Abs(-73.48112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.24079 - lat) + Math.Abs(-74.19904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.86048 - lat) + Math.Abs(-73.26234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.95 - lat) + Math.Abs(-75.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.3242 - lat) + Math.Abs(-74.96017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38166 - lat) + Math.Abs(-81.36891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.71418 - lat) + Math.Abs(-75.09799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.3 - lat) + Math.Abs(-73.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60361 - lat) + Math.Abs(-75.28824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.99022 - lat) + Math.Abs(-72.907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87458 - lat) + Math.Abs(-75.56706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.32125 - lat) + Math.Abs(-74.56848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23778 - lat) + Math.Abs(-74.35166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.83861 - lat) + Math.Abs(-76.77189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48511 - lat) + Math.Abs(-75.0196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.29436 - lat) + Math.Abs(-75.02589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95833 - lat) + Math.Abs(-75.83627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27515 - lat) + Math.Abs(-76.37641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3956 - lat) + Math.Abs(-75.06476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46135 - lat) + Math.Abs(-75.55778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.99445 - lat) + Math.Abs(-76.22885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.65138 - lat) + Math.Abs(-74.06991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.05154 - lat) + Math.Abs(-75.26775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47754 - lat) + Math.Abs(-73.92255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.6725 - lat) + Math.Abs(-77.01389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.73586 - lat) + Math.Abs(-75.52626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51847 - lat) + Math.Abs(-73.72238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.57583 - lat) + Math.Abs(-72.64591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.34314 - lat) + Math.Abs(-76.91124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40195 - lat) + Math.Abs(-72.55314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.69637 - lat) + Math.Abs(-73.69957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.65972 - lat) + Math.Abs(-75.12809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.42139 - lat) + Math.Abs(-71.73167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.82052 - lat) + Math.Abs(-73.16851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.79536 - lat) + Math.Abs(-73.84063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04343 - lat) + Math.Abs(-74.99366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.13258 - lat) + Math.Abs(-75.09499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.50294 - lat) + Math.Abs(-77.21537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.95157 - lat) + Math.Abs(-75.08198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.46103 - lat) + Math.Abs(-73.68048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.75924 - lat) + Math.Abs(-76.52969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.84778 - lat) + Math.Abs(-74.62148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.77107 - lat) + Math.Abs(-73.00314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27345 - lat) + Math.Abs(-75.24103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.36985 - lat) + Math.Abs(-73.87267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.01746 - lat) + Math.Abs(-73.54703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6587 - lat) + Math.Abs(-72.73344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.89616 - lat) + Math.Abs(-76.23422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.85028 - lat) + Math.Abs(-75.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.92874 - lat) + Math.Abs(-76.21104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.08221 - lat) + Math.Abs(-75.79107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.69659 - lat) + Math.Abs(-78.24482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.47446 - lat) + Math.Abs(-77.08144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.43004 - lat) + Math.Abs(-72.86768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.44344 - lat) + Math.Abs(-75.72815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.24976 - lat) + Math.Abs(-74.72079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.82767 - lat) + Math.Abs(-75.1217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55952 - lat) + Math.Abs(-73.13637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.11667 - lat) + Math.Abs(-75.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.96426 - lat) + Math.Abs(-75.10165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.97876 - lat) + Math.Abs(-74.2927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.17644 - lat) + Math.Abs(-76.87838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27972 - lat) + Math.Abs(-74.53389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.91408 - lat) + Math.Abs(-67.06996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.39833 - lat) + Math.Abs(-75.15111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.22396 - lat) + Math.Abs(-73.07696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.28626 - lat) + Math.Abs(-77.46921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.33623 - lat) + Math.Abs(-73.18203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.39523 - lat) + Math.Abs(-75.06562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.87809 - lat) + Math.Abs(-75.25248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87707 - lat) + Math.Abs(-72.6243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.30153 - lat) + Math.Abs(-74.06954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.71161 - lat) + Math.Abs(-73.24344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.79577 - lat) + Math.Abs(-75.69947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79177 - lat) + Math.Abs(-74.77316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.18789 - lat) + Math.Abs(-74.99315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4021 - lat) + Math.Abs(-73.20737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3533 - lat) + Math.Abs(-75.95244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.17864 - lat) + Math.Abs(-74.42311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.51525 - lat) + Math.Abs(-77.04679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92901 - lat) + Math.Abs(-75.02709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13269 - lat) + Math.Abs(-73.49065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.61617 - lat) + Math.Abs(-74.352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.93303 - lat) + Math.Abs(-74.69346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.91423 - lat) + Math.Abs(-75.48009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3741 - lat) + Math.Abs(-75.75891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.03047 - lat) + Math.Abs(-74.21482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14475 - lat) + Math.Abs(-75.50877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.58317 - lat) + Math.Abs(-81.70636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.81148 - lat) + Math.Abs(-72.84929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.76107 - lat) + Math.Abs(-73.3922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.87884 - lat) + Math.Abs(-76.26722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.18361 - lat) + Math.Abs(-75.38167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.33849 - lat) + Math.Abs(-77.5957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.49273 - lat) + Math.Abs(-73.48537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.96502 - lat) + Math.Abs(-75.96541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.6375 - lat) + Math.Abs(-75.57028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.92923 - lat) + Math.Abs(-75.01517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.49027 - lat) + Math.Abs(-74.79463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.40733 - lat) + Math.Abs(-75.48749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.99244 - lat) + Math.Abs(-76.04335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94617 - lat) + Math.Abs(-75.44275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.58453 - lat) + Math.Abs(-73.54184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.09908 - lat) + Math.Abs(-72.2488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.69636 - lat) + Math.Abs(-73.76932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15153 - lat) + Math.Abs(-75.61657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.63072 - lat) + Math.Abs(-74.92214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.84893 - lat) + Math.Abs(-75.81711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.79115 - lat) + Math.Abs(-74.76059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.3915 - lat) + Math.Abs(-73.49574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.23922 - lat) + Math.Abs(-75.23996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.26093 - lat) + Math.Abs(-76.73986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.35642 - lat) + Math.Abs(-73.20918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.0108 - lat) + Math.Abs(-75.60493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.41256 - lat) + Math.Abs(-76.15457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.77717 - lat) + Math.Abs(-75.25642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.16647 - lat) + Math.Abs(-75.76595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5874 - lat) + Math.Abs(-73.83901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.44348 - lat) + Math.Abs(-77.11964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.42164 - lat) + Math.Abs(-75.70318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15515 - lat) + Math.Abs(-75.37371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.54444 - lat) + Math.Abs(-72.90722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.1571 - lat) + Math.Abs(-76.28852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2919 - lat) + Math.Abs(-73.38485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.52973 - lat) + Math.Abs(-75.64525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.28075 - lat) + Math.Abs(-74.76469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.21474 - lat) + Math.Abs(-77.99801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.05861 - lat) + Math.Abs(-75.50306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.25833 - lat) + Math.Abs(-73.56142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.82203 - lat) + Math.Abs(-76.52242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4952 - lat) + Math.Abs(-75.12448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.70199 - lat) + Math.Abs(-74.71602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.02835 - lat) + Math.Abs(-74.69379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66565 - lat) + Math.Abs(-73.82151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.22947 - lat) + Math.Abs(-72.76099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.53793 - lat) + Math.Abs(-73.63201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.4002 - lat) + Math.Abs(-73.33544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.57749 - lat) + Math.Abs(-72.47574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.51952 - lat) + Math.Abs(-74.59293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74517 - lat) + Math.Abs(-74.53378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33957 - lat) + Math.Abs(-75.73018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.62306 - lat) + Math.Abs(-75.76278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.69188 - lat) + Math.Abs(-76.65835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.33234 - lat) + Math.Abs(-73.86141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.11737 - lat) + Math.Abs(-74.47944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23657 - lat) + Math.Abs(-75.72191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.85871 - lat) + Math.Abs(-74.93129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.87136 - lat) + Math.Abs(-77.64027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16863 - lat) + Math.Abs(-74.71682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.68116 - lat) + Math.Abs(-74.71406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.34828 - lat) + Math.Abs(-73.89601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87259 - lat) + Math.Abs(-74.6405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.23114 - lat) + Math.Abs(-76.41668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36361 - lat) + Math.Abs(-72.4063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46304 - lat) + Math.Abs(-74.65436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.28048 - lat) + Math.Abs(-71.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.93833 - lat) + Math.Abs(-73.20833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.90999 - lat) + Math.Abs(-75.15931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.65149 - lat) + Math.Abs(-74.05734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.78889 - lat) + Math.Abs(-70.35584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.22134 - lat) + Math.Abs(-76.93691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.09912 - lat) + Math.Abs(-72.95647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.02225 - lat) + Math.Abs(-73.4044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.19337 - lat) + Math.Abs(-74.78189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.86528 - lat) + Math.Abs(-67.92389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.01811 - lat) + Math.Abs(-76.26413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.98778 - lat) + Math.Abs(-74.95472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.18903 - lat) + Math.Abs(-67.48588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.976 - lat) + Math.Abs(-74.58516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.19994 - lat) + Math.Abs(-74.72733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.49156 - lat) + Math.Abs(-74.40326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.50514 - lat) + Math.Abs(-76.49571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.19374 - lat) + Math.Abs(-77.26661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.88371 - lat) + Math.Abs(-77.50324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87739 - lat) + Math.Abs(-73.6781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.99376 - lat) + Math.Abs(-74.28439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.79176 - lat) + Math.Abs(-75.84101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.22263 - lat) + Math.Abs(-76.03026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50122 - lat) + Math.Abs(-75.508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2411 - lat) + Math.Abs(-74.95815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.41706 - lat) + Math.Abs(-73.5804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.56976 - lat) + Math.Abs(-77.464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.75118 - lat) + Math.Abs(-74.93004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.42111 - lat) + Math.Abs(-76.24472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.80739 - lat) + Math.Abs(-77.57216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.72792 - lat) + Math.Abs(-71.99266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.43823 - lat) + Math.Abs(-76.61316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.64297 - lat) + Math.Abs(-74.75393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.77697 - lat) + Math.Abs(-74.85344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.62843 - lat) + Math.Abs(-77.45956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.05694 - lat) + Math.Abs(-75.41028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4115 - lat) + Math.Abs(-75.58508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.19698 - lat) + Math.Abs(-75.64506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.95334 - lat) + Math.Abs(-77.36598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.0406 - lat) + Math.Abs(-78.65877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.46167 - lat) + Math.Abs(-74.61621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.85371 - lat) + Math.Abs(-76.05071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2665 - lat) + Math.Abs(-75.80442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.72396 - lat) + Math.Abs(-72.48646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.74846 - lat) + Math.Abs(-75.10776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43251 - lat) + Math.Abs(-74.70414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91925 - lat) + Math.Abs(-74.46771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53226 - lat) + Math.Abs(-73.17309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.32908 - lat) + Math.Abs(-74.45302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.3335 - lat) + Math.Abs(-75.70463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.54261 - lat) + Math.Abs(-74.87823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.14109 - lat) + Math.Abs(-77.86479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51604 - lat) + Math.Abs(-76.97449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.98789 - lat) + Math.Abs(-73.04953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55 - lat) + Math.Abs(-73.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.81333 - lat) + Math.Abs(-75.69611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.02123 - lat) + Math.Abs(-75.90926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.38346 - lat) + Math.Abs(-75.16122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68819 - lat) + Math.Abs(-73.66451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18739 - lat) + Math.Abs(-74.91504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.98452 - lat) + Math.Abs(-72.7505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.88148 - lat) + Math.Abs(-71.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.2975 - lat) + Math.Abs(-75.09667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.76645 - lat) + Math.Abs(-78.18326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.62492 - lat) + Math.Abs(-72.42345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.65861 - lat) + Math.Abs(-73.9825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.06895 - lat) + Math.Abs(-77.05273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.21361 - lat) + Math.Abs(-77.28111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.30722 - lat) + Math.Abs(-74.30056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.41639 - lat) + Math.Abs(-73.17 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.44533 - lat) + Math.Abs(-72.46268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.19111 - lat) + Math.Abs(-74.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.43637 - lat) + Math.Abs(-72.63808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.37565 - lat) + Math.Abs(-72.64795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.11705 - lat) + Math.Abs(-75.01732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33189 - lat) + Math.Abs(-75.5417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.53944 - lat) + Math.Abs(-76.30361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40756 - lat) + Math.Abs(-73.28824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.74055 - lat) + Math.Abs(-74.75443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53773 - lat) + Math.Abs(-73.29234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.0161 - lat) + Math.Abs(-75.62854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.72362 - lat) + Math.Abs(-76.13403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.89167 - lat) + Math.Abs(-75.4375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.2929 - lat) + Math.Abs(-72.70277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.25462 - lat) + Math.Abs(-76.61086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.78013 - lat) + Math.Abs(-73.11708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.37054 - lat) + Math.Abs(-74.15219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.48309 - lat) + Math.Abs(-76.74053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95652 - lat) + Math.Abs(-73.62548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.44962 - lat) + Math.Abs(-75.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.10112 - lat) + Math.Abs(-73.05123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.64644 - lat) + Math.Abs(-75.97269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.13429 - lat) + Math.Abs(-75.14001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.22038 - lat) + Math.Abs(-76.31385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.52708 - lat) + Math.Abs(-75.4593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.13278 - lat) + Math.Abs(-74.15977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.13969 - lat) + Math.Abs(-73.39739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.52716 - lat) + Math.Abs(-75.22873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.65672 - lat) + Math.Abs(-74.18249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.0595 - lat) + Math.Abs(-77.56554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.9361 - lat) + Math.Abs(-75.22169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.79035 - lat) + Math.Abs(-71.33917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.02378 - lat) + Math.Abs(-75.99588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.34434 - lat) + Math.Abs(-72.81726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.24803 - lat) + Math.Abs(-77.49085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.62773 - lat) + Math.Abs(-75.8127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.59548 - lat) + Math.Abs(-73.3082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.26387 - lat) + Math.Abs(-73.29876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23773 - lat) + Math.Abs(-73.35604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.34001 - lat) + Math.Abs(-73.12205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.57583 - lat) + Math.Abs(-75.97389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.7125 - lat) + Math.Abs(-77.27083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.63589 - lat) + Math.Abs(-72.19543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.35368 - lat) + Math.Abs(-73.4566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.80168 - lat) + Math.Abs(-74.39304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.95511 - lat) + Math.Abs(-76.60526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.52692 - lat) + Math.Abs(-74.03736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.57535 - lat) + Math.Abs(-74.88831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06696 - lat) + Math.Abs(-74.38439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.76978 - lat) + Math.Abs(-72.94099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.12614 - lat) + Math.Abs(-74.38495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.30604 - lat) + Math.Abs(-74.62083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06767 - lat) + Math.Abs(-73.87769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.9273 - lat) + Math.Abs(-75.28189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.1665 - lat) + Math.Abs(-75.52001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42627 - lat) + Math.Abs(-76.78926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09419 - lat) + Math.Abs(-74.77573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.62057 - lat) + Math.Abs(-75.09415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.54359 - lat) + Math.Abs(-75.80852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.60893 - lat) + Math.Abs(-75.17656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.39781 - lat) + Math.Abs(-74.82731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.28995 - lat) + Math.Abs(-77.35721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.53528 - lat) + Math.Abs(-74.10778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.30061 - lat) + Math.Abs(-72.74667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.24407 - lat) + Math.Abs(-76.43564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.98057 - lat) + Math.Abs(-76.82119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.87393 - lat) + Math.Abs(-75.17151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36667 - lat) + Math.Abs(-81.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.57655 - lat) + Math.Abs(-73.36696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.70592 - lat) + Math.Abs(-74.23021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.50861 - lat) + Math.Abs(-78.4511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33348 - lat) + Math.Abs(-75.30542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.48747 - lat) + Math.Abs(-75.72581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2752 - lat) + Math.Abs(-73.86884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74798 - lat) + Math.Abs(-75.88143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.56639 - lat) + Math.Abs(-75.75111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97917 - lat) + Math.Abs(-75.4202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2971 - lat) + Math.Abs(-74.4733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.94806 - lat) + Math.Abs(-75.5275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.2455 - lat) + Math.Abs(-76.13017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25 - lat) + Math.Abs(-76.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87638 - lat) + Math.Abs(-73.57284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.72151 - lat) + Math.Abs(-72.84908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75084 - lat) + Math.Abs(-72.80339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24194 - lat) + Math.Abs(-74.42667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23767 - lat) + Math.Abs(-75.67489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.67315 - lat) + Math.Abs(-72.80875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.47559 - lat) + Math.Abs(-72.97046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.15284 - lat) + Math.Abs(-76.65208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.25778 - lat) + Math.Abs(-70.23472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.29622 - lat) + Math.Abs(-75.8839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.25283 - lat) + Math.Abs(-76.22924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.19608 - lat) + Math.Abs(-73.14504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.33667 - lat) + Math.Abs(-71.95111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.29034 - lat) + Math.Abs(-75.50757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.80175 - lat) + Math.Abs(-77.17032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.20475 - lat) + Math.Abs(-74.64075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.51005 - lat) + Math.Abs(-73.34982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.25184 - lat) + Math.Abs(-75.56359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.32233 - lat) + Math.Abs(-73.01516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28393 - lat) + Math.Abs(-75.26016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.93722 - lat) + Math.Abs(-75.73778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.29659 - lat) + Math.Abs(-75.05496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.47501 - lat) + Math.Abs(-75.6004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.19889 - lat) + Math.Abs(-74.89295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55194 - lat) + Math.Abs(-74.00861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.17358 - lat) + Math.Abs(-75.33621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.9832 - lat) + Math.Abs(-75.30155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15596 - lat) + Math.Abs(-74.26618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.25397 - lat) + Math.Abs(-75.15403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00864 - lat) + Math.Abs(-73.54115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06889 - lat) + Math.Abs(-75.51738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.81638 - lat) + Math.Abs(-72.27946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77505 - lat) + Math.Abs(-72.44447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44589 - lat) + Math.Abs(-74.95869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33653 - lat) + Math.Abs(-76.72756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.85953 - lat) + Math.Abs(-74.77386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.69903 - lat) + Math.Abs(-72.73233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54119 - lat) + Math.Abs(-74.62942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.37837 - lat) + Math.Abs(-72.2395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23293 - lat) + Math.Abs(-75.18985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24202 - lat) + Math.Abs(-74.75467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.73245 - lat) + Math.Abs(-74.26419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.08154 - lat) + Math.Abs(-73.60761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55196 - lat) + Math.Abs(-74.78741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.50567 - lat) + Math.Abs(-72.59299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.97214 - lat) + Math.Abs(-73.31959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61712 - lat) + Math.Abs(-75.15146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.94411 - lat) + Math.Abs(-72.83253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.75343 - lat) + Math.Abs(-73.10473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.83793 - lat) + Math.Abs(-72.5037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.37899 - lat) + Math.Abs(-75.26769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.89403 - lat) + Math.Abs(-76.35455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23648 - lat) + Math.Abs(-75.8135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.8454 - lat) + Math.Abs(-77.24791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.43333 - lat) + Math.Abs(-76.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.49605 - lat) + Math.Abs(-76.54945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.35078 - lat) + Math.Abs(-77.52339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6779 - lat) + Math.Abs(-75.81218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.9218 - lat) + Math.Abs(-75.06232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.21528 - lat) + Math.Abs(-69.94056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.86242 - lat) + Math.Abs(-74.90977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.30711 - lat) + Math.Abs(-73.71152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.93497 - lat) + Math.Abs(-77.30634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.11317 - lat) + Math.Abs(-73.2178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.89972 - lat) + Math.Abs(-75.8825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.52483 - lat) + Math.Abs(-76.03921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00177 - lat) + Math.Abs(-74.34174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.00187 - lat) + Math.Abs(-76.7789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.32064 - lat) + Math.Abs(-72.56281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84965 - lat) + Math.Abs(-75.27942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.97431 - lat) + Math.Abs(-75.36195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.53282 - lat) + Math.Abs(-76.10318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.6045 - lat) + Math.Abs(-77.13152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.45265 - lat) + Math.Abs(-75.78746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.17835 - lat) + Math.Abs(-76.76265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.27784 - lat) + Math.Abs(-76.63082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13162 - lat) + Math.Abs(-72.33841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.49056 - lat) + Math.Abs(-70.40917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21321 - lat) + Math.Abs(-73.23827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.39341 - lat) + Math.Abs(-75.89232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.74867 - lat) + Math.Abs(-75.60626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.19847 - lat) + Math.Abs(-74.39368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.38439 - lat) + Math.Abs(-73.17332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.17848 - lat) + Math.Abs(-73.58948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3592 - lat) + Math.Abs(-74.39047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.21826 - lat) + Math.Abs(-73.81121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.48016 - lat) + Math.Abs(-75.43664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.26667 - lat) + Math.Abs(-73.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.40194 - lat) + Math.Abs(-75.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.4731 - lat) + Math.Abs(-77.58024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.51061 - lat) + Math.Abs(-73.07178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.56228 - lat) + Math.Abs(-73.33405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61868 - lat) + Math.Abs(-73.80265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.29851 - lat) + Math.Abs(-77.40614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15769 - lat) + Math.Abs(-75.64317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21043 - lat) + Math.Abs(-72.46399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.44783 - lat) + Math.Abs(-74.66311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.64999 - lat) + Math.Abs(-76.56984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.60221 - lat) + Math.Abs(-76.9713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.02649 - lat) + Math.Abs(-74.86844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00332 - lat) + Math.Abs(-76.00355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.03131 - lat) + Math.Abs(-75.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.70493 - lat) + Math.Abs(-73.47527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.0959 - lat) + Math.Abs(-73.44407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.72069 - lat) + Math.Abs(-73.96926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.56223 - lat) + Math.Abs(-72.57499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.86371 - lat) + Math.Abs(-73.96167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.19762 - lat) + Math.Abs(-75.9799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.10421 - lat) + Math.Abs(-77.762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.78333 - lat) + Math.Abs(-75.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.79027 - lat) + Math.Abs(-73.66011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.8293 - lat) + Math.Abs(-75.03346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.733 - lat) + Math.Abs(-73.09588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87715 - lat) + Math.Abs(-73.78097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.56309 - lat) + Math.Abs(-74.69519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.14592 - lat) + Math.Abs(-72.5708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.79211 - lat) + Math.Abs(-75.78601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.38541 - lat) + Math.Abs(-73.36364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.59902 - lat) + Math.Abs(-75.81976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.26074 - lat) + Math.Abs(-76.53499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.77762 - lat) + Math.Abs(-76.32444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.61203 - lat) + Math.Abs(-72.9793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.17117 - lat) + Math.Abs(-75.76404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.18461 - lat) + Math.Abs(-75.59913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.16054 - lat) + Math.Abs(-76.68397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.45065 - lat) + Math.Abs(-77.97998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.64867 - lat) + Math.Abs(-75.63457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.82501 - lat) + Math.Abs(-77.63966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.55452 - lat) + Math.Abs(-76.06722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.05516 - lat) + Math.Abs(-77.49669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.9704 - lat) + Math.Abs(-77.52146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.17698 - lat) + Math.Abs(-74.53254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.43889 - lat) + Math.Abs(-75.23222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.20856 - lat) + Math.Abs(-74.73584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.58333 - lat) + Math.Abs(-75.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.79925 - lat) + Math.Abs(-75.90718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.08004 - lat) + Math.Abs(-75.17556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50611 - lat) + Math.Abs(-72.48332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.20831 - lat) + Math.Abs(-75.73565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15676 - lat) + Math.Abs(-71.76372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.54302 - lat) + Math.Abs(-73.30826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95635 - lat) + Math.Abs(-74.07819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.32333 - lat) + Math.Abs(-73.14889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.25472 - lat) + Math.Abs(-74.0025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46554 - lat) + Math.Abs(-72.41539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.02505 - lat) + Math.Abs(-73.57313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.96417 - lat) + Math.Abs(-73.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.21472 - lat) + Math.Abs(-73.81719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.87739 - lat) + Math.Abs(-74.46744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.95502 - lat) + Math.Abs(-73.70018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.31569 - lat) + Math.Abs(-75.79826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00619 - lat) + Math.Abs(-73.47274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.93658 - lat) + Math.Abs(-73.83314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.51573 - lat) + Math.Abs(-74.78935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.23429 - lat) + Math.Abs(-75.16335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.86601 - lat) + Math.Abs(-73.87748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.28046 - lat) + Math.Abs(-75.44354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46746 - lat) + Math.Abs(-74.53617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.30798 - lat) + Math.Abs(-73.3202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.57082 - lat) + Math.Abs(-77.88542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.03078 - lat) + Math.Abs(-74.9701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14334 - lat) + Math.Abs(-74.22384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.88043 - lat) + Math.Abs(-73.76566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.91992 - lat) + Math.Abs(-77.56738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.13103 - lat) + Math.Abs(-77.54815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06692 - lat) + Math.Abs(-74.59499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.81449 - lat) + Math.Abs(-75.24063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.2464 - lat) + Math.Abs(-73.41833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.0248 - lat) + Math.Abs(-75.75589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.96093 - lat) + Math.Abs(-77.73161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.38425 - lat) + Math.Abs(-73.68617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.13333 - lat) + Math.Abs(-76.3927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.2224 - lat) + Math.Abs(-77.67766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.76383 - lat) + Math.Abs(-76.33292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46243 - lat) + Math.Abs(-72.50465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.87621 - lat) + Math.Abs(-72.85594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.14353 - lat) + Math.Abs(-75.18532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06667 - lat) + Math.Abs(-74.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.51997 - lat) + Math.Abs(-74.35261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.54625 - lat) + Math.Abs(-73.70687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88752 - lat) + Math.Abs(-72.79749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.38944 - lat) + Math.Abs(-73.37989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.68178 - lat) + Math.Abs(-75.21907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.0682 - lat) + Math.Abs(-73.16981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.37747 - lat) + Math.Abs(-75.44883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.30079 - lat) + Math.Abs(-74.80754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.68013 - lat) + Math.Abs(-75.95259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.72461 - lat) + Math.Abs(-76.26675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.38678 - lat) + Math.Abs(-75.54736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.31667 - lat) + Math.Abs(-75.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.64367 - lat) + Math.Abs(-77.01924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.19593 - lat) + Math.Abs(-75.62777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.08236 - lat) + Math.Abs(-73.36334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.80263 - lat) + Math.Abs(-72.80586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.94597 - lat) + Math.Abs(-73.34435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.32279 - lat) + Math.Abs(-73.74268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.76288 - lat) + Math.Abs(-73.61091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.16095 - lat) + Math.Abs(-75.04811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.89686 - lat) + Math.Abs(-74.886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.63781 - lat) + Math.Abs(-73.28878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.15 - lat) + Math.Abs(-75.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75662 - lat) + Math.Abs(-73.5395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.99111 - lat) + Math.Abs(-73.87154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.69244 - lat) + Math.Abs(-73.52042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.33646 - lat) + Math.Abs(-74.36378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.40425 - lat) + Math.Abs(-73.7964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.71638 - lat) + Math.Abs(-74.21195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.00075 - lat) + Math.Abs(-77.44918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.52066 - lat) + Math.Abs(-74.18504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.46263 - lat) + Math.Abs(-73.62162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.77133 - lat) + Math.Abs(-76.13324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.02973 - lat) + Math.Abs(-75.0086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.15264 - lat) + Math.Abs(-75.03624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.33916 - lat) + Math.Abs(-73.93852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.79261 - lat) + Math.Abs(-71.77596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.88606 - lat) + Math.Abs(-72.8487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.48797 - lat) + Math.Abs(-73.89749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06222 - lat) + Math.Abs(-73.08644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.3223 - lat) + Math.Abs(-76.2348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.80487 - lat) + Math.Abs(-73.97029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.85903 - lat) + Math.Abs(-72.91882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.68318 - lat) + Math.Abs(-77.07331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.61438 - lat) + Math.Abs(-75.60623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.29005 - lat) + Math.Abs(-74.81612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.66885 - lat) + Math.Abs(-72.99289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.67472 - lat) + Math.Abs(-75.65833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.29606 - lat) + Math.Abs(-75.5612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.12383 - lat) + Math.Abs(-74.95181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.81367 - lat) + Math.Abs(-74.35453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.14924 - lat) + Math.Abs(-74.88429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.17591 - lat) + Math.Abs(-75.59174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.5654 - lat) + Math.Abs(-75.5169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.66808 - lat) + Math.Abs(-72.69986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13735 - lat) + Math.Abs(-73.09847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93248 - lat) + Math.Abs(-72.60125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.45199 - lat) + Math.Abs(-76.81029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.40785 - lat) + Math.Abs(-77.39218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.42717 - lat) + Math.Abs(-77.09693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.74404 - lat) + Math.Abs(-77.33481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.85314 - lat) + Math.Abs(-74.25996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.10193 - lat) + Math.Abs(-75.19508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61135 - lat) + Math.Abs(-74.26824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.40283 - lat) + Math.Abs(-74.82415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98691 - lat) + Math.Abs(-73.94697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55 - lat) + Math.Abs(-72.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.05489 - lat) + Math.Abs(-73.81519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.25264 - lat) + Math.Abs(-74.29069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.45365 - lat) + Math.Abs(-77.44017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.57006 - lat) + Math.Abs(-75.32863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.65724 - lat) + Math.Abs(-73.74685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.65296 - lat) + Math.Abs(-72.92461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.0117 - lat) + Math.Abs(-75.93968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.03155 - lat) + Math.Abs(-74.97612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.24518 - lat) + Math.Abs(-73.49655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48277 - lat) + Math.Abs(-72.49718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.5079 - lat) + Math.Abs(-76.23619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.67817 - lat) + Math.Abs(-75.28466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.84975 - lat) + Math.Abs(-74.23627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15031 - lat) + Math.Abs(-73.9614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.41151 - lat) + Math.Abs(-72.44876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.47926 - lat) + Math.Abs(-78.10972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.68549 - lat) + Math.Abs(-76.31372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.56363 - lat) + Math.Abs(-73.79488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7174 - lat) + Math.Abs(-75.12023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51064 - lat) + Math.Abs(-73.44776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.69736 - lat) + Math.Abs(-73.51117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.88778 - lat) + Math.Abs(-75.16417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.35342 - lat) + Math.Abs(-73.71147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.76279 - lat) + Math.Abs(-76.221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.11696 - lat) + Math.Abs(-76.98214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00114 - lat) + Math.Abs(-73.97581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.60347 - lat) + Math.Abs(-74.80951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18618 - lat) + Math.Abs(-74.06085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91345 - lat) + Math.Abs(-76.04004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.32598 - lat) + Math.Abs(-75.76835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71307 - lat) + Math.Abs(-72.65759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.8245 - lat) + Math.Abs(-73.03408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.83916 - lat) + Math.Abs(-75.66727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48569 - lat) + Math.Abs(-75.39496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.42692 - lat) + Math.Abs(-74.97548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.89784 - lat) + Math.Abs(-72.88666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.27251 - lat) + Math.Abs(-73.30911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.93135 - lat) + Math.Abs(-76.48481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.65685 - lat) + Math.Abs(-76.68859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.00017 - lat) + Math.Abs(-76.26915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.19992 - lat) + Math.Abs(-73.54274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.60519 - lat) + Math.Abs(-73.06809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.06004 - lat) + Math.Abs(-74.69212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.64786 - lat) + Math.Abs(-77.57819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.90875 - lat) + Math.Abs(-77.79145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.44552 - lat) + Math.Abs(-69.79897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.2708 - lat) + Math.Abs(-73.48669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.58007 - lat) + Math.Abs(-72.96687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53941 - lat) + Math.Abs(-72.77238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.89391 - lat) + Math.Abs(-72.50782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.24958 - lat) + Math.Abs(-73.7661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.54373 - lat) + Math.Abs(-73.45433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.00578 - lat) + Math.Abs(-72.10568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.18333 - lat) + Math.Abs(-75.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.30173 - lat) + Math.Abs(-70.20415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.79936 - lat) + Math.Abs(-75.19467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.40254 - lat) + Math.Abs(-75.68029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03886 - lat) + Math.Abs(-75.78969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.80938 - lat) + Math.Abs(-74.098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.82968 - lat) + Math.Abs(-72.84332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.31847 - lat) + Math.Abs(-75.2933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.29461 - lat) + Math.Abs(-73.04022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.17301 - lat) + Math.Abs(-76.26275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.58612 - lat) + Math.Abs(-74.82705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.39158 - lat) + Math.Abs(-75.68723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.85362 - lat) + Math.Abs(-77.51817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.47681 - lat) + Math.Abs(-74.04416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.34633 - lat) + Math.Abs(-75.50888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46894 - lat) + Math.Abs(-73.33765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.29005 - lat) + Math.Abs(-73.47354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.90841 - lat) + Math.Abs(-77.5477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.20805 - lat) + Math.Abs(-77.46548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.35625 - lat) + Math.Abs(-73.24131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.09351 - lat) + Math.Abs(-76.64973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25757 - lat) + Math.Abs(-74.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.83545 - lat) + Math.Abs(-74.45548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04639 - lat) + Math.Abs(-75.90705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.76619 - lat) + Math.Abs(-72.694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.39408 - lat) + Math.Abs(-75.2583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.63333 - lat) + Math.Abs(-73.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.63312 - lat) + Math.Abs(-73.32398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.49477 - lat) + Math.Abs(-75.35271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.19034 - lat) + Math.Abs(-76.97369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.37606 - lat) + Math.Abs(-74.8015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06051 - lat) + Math.Abs(-73.97925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.40306 - lat) + Math.Abs(-75.29417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.28908 - lat) + Math.Abs(-74.89825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.0573 - lat) + Math.Abs(-75.18524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.34249 - lat) + Math.Abs(-76.49581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.56645 - lat) + Math.Abs(-75.32499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53833 - lat) + Math.Abs(-75.08861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.61889 - lat) + Math.Abs(-75.63583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.31419 - lat) + Math.Abs(-73.94968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.40867 - lat) + Math.Abs(-73.29572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.87443 - lat) + Math.Abs(-75.62028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.00703 - lat) + Math.Abs(-74.24765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27756 - lat) + Math.Abs(-74.64312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.14468 - lat) + Math.Abs(-73.68578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.52897 - lat) + Math.Abs(-73.92273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.02502 - lat) + Math.Abs(-74.62279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55823 - lat) + Math.Abs(-73.28198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.13781 - lat) + Math.Abs(-72.66456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.19053 - lat) + Math.Abs(-72.47588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55642 - lat) + Math.Abs(-72.50378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36238 - lat) + Math.Abs(-73.60313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.60412 - lat) + Math.Abs(-73.48518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.61637 - lat) + Math.Abs(-73.81748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.06196 - lat) + Math.Abs(-73.63718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.4425 - lat) + Math.Abs(-74.04417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.10569 - lat) + Math.Abs(-75.39812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.9825 - lat) + Math.Abs(-75.60361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.16723 - lat) + Math.Abs(-73.36823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.60731 - lat) + Math.Abs(-72.60108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.25778 - lat) + Math.Abs(-73.81228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14893 - lat) + Math.Abs(-75.62841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.34431 - lat) + Math.Abs(-73.37393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.66638 - lat) + Math.Abs(-76.68106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.21536 - lat) + Math.Abs(-74.98189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.85876 - lat) + Math.Abs(-74.05866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.28025 - lat) + Math.Abs(-72.96782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.28581 - lat) + Math.Abs(-73.14722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.72315 - lat) + Math.Abs(-75.48316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.21421 - lat) + Math.Abs(-72.86948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.54765 - lat) + Math.Abs(-75.31128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.94829 - lat) + Math.Abs(-74.59392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.35943 - lat) + Math.Abs(-77.28367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.37073 - lat) + Math.Abs(-76.6044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.32585 - lat) + Math.Abs(-74.86933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.84315 - lat) + Math.Abs(-72.69404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.95568 - lat) + Math.Abs(-72.94783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88479 - lat) + Math.Abs(-75.79052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.75427 - lat) + Math.Abs(-72.9744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98654 - lat) + Math.Abs(-75.19349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.82722 - lat) + Math.Abs(-73.68831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.07959 - lat) + Math.Abs(-75.12059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74639 - lat) + Math.Abs(-75.91167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.55151 - lat) + Math.Abs(-77.11948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.39972 - lat) + Math.Abs(-75.51444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.72439 - lat) + Math.Abs(-75.28168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.08236 - lat) + Math.Abs(-75.33509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.34862 - lat) + Math.Abs(-73.90168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.14725 - lat) + Math.Abs(-74.72014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.86292 - lat) + Math.Abs(-77.72734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.62711 - lat) + Math.Abs(-72.62625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.54782 - lat) + Math.Abs(-75.64368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4092 - lat) + Math.Abs(-74.75715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.40569 - lat) + Math.Abs(-73.94683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.52881 - lat) + Math.Abs(-72.69595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.34644 - lat) + Math.Abs(-74.49147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.37926 - lat) + Math.Abs(-73.9155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.45912 - lat) + Math.Abs(-74.8797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.40671 - lat) + Math.Abs(-76.34819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.74989 - lat) + Math.Abs(-76.02539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78558 - lat) + Math.Abs(-76.24065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.03132 - lat) + Math.Abs(-73.10327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.37808 - lat) + Math.Abs(-74.88356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.68489 - lat) + Math.Abs(-75.32311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9792 - lat) + Math.Abs(-75.29724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.03586 - lat) + Math.Abs(-76.40788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.91667 - lat) + Math.Abs(-76.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.34776 - lat) + Math.Abs(-72.9458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.43722 - lat) + Math.Abs(-76.5225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.79739 - lat) + Math.Abs(-76.48316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.09106 - lat) + Math.Abs(-75.63569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55456 - lat) + Math.Abs(-73.86567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.52949 - lat) + Math.Abs(-75.64091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25271 - lat) + Math.Abs(-74.91574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.9596 - lat) + Math.Abs(-72.65315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91857 - lat) + Math.Abs(-74.02799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.62271 - lat) + Math.Abs(-76.57039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.44234 - lat) + Math.Abs(-75.42874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78962 - lat) + Math.Abs(-75.11686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.3324 - lat) + Math.Abs(-75.82665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40511 - lat) + Math.Abs(-75.98255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.26787 - lat) + Math.Abs(-72.64197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.74104 - lat) + Math.Abs(-73.0483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.26667 - lat) + Math.Abs(-74.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.73035 - lat) + Math.Abs(-74.43663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58078 - lat) + Math.Abs(-75.34842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.2817 - lat) + Math.Abs(-72.79399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.5928 - lat) + Math.Abs(-73.2465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.98598 - lat) + Math.Abs(-74.48283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.83047 - lat) + Math.Abs(-72.88419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.21207 - lat) + Math.Abs(-76.15564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.90089 - lat) + Math.Abs(-76.29783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.38364 - lat) + Math.Abs(-77.15622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.01397 - lat) + Math.Abs(-76.64612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.31939 - lat) + Math.Abs(-74.97358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21433 - lat) + Math.Abs(-74.31363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.04963 - lat) + Math.Abs(-76.0028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.22245 - lat) + Math.Abs(-75.48173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51377 - lat) + Math.Abs(-73.94913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.35969 - lat) + Math.Abs(-75.73888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.8801 - lat) + Math.Abs(-77.03116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.58333 - lat) + Math.Abs(-77 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.04096 - lat) + Math.Abs(-72.86538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.12539 - lat) + Math.Abs(-73.1198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.11096 - lat) + Math.Abs(-75.55152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.68822 - lat) + Math.Abs(-73.91784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.23907 - lat) + Math.Abs(-77.59721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.45371 - lat) + Math.Abs(-73.3625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.97106 - lat) + Math.Abs(-73.88817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9893 - lat) + Math.Abs(-73.77058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.3387 - lat) + Math.Abs(-76.18342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.83994 - lat) + Math.Abs(-76.96889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.73176 - lat) + Math.Abs(-74.34129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.60971 - lat) + Math.Abs(-74.08175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.61095 - lat) + Math.Abs(-72.64773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.34814 - lat) + Math.Abs(-78.32571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.15778 - lat) + Math.Abs(-76.97111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33031 - lat) + Math.Abs(-72.58505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.87252 - lat) + Math.Abs(-74.53925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.90069 - lat) + Math.Abs(-73.28347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.11284 - lat) + Math.Abs(-75.98378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.91102 - lat) + Math.Abs(-72.80926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.99458 - lat) + Math.Abs(-76.7812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.74601 - lat) + Math.Abs(-75.97765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.49766 - lat) + Math.Abs(-77.13587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.22675 - lat) + Math.Abs(-73.12608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.80165 - lat) + Math.Abs(-74.74177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.60508 - lat) + Math.Abs(-75.66619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33732 - lat) + Math.Abs(-75.55795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.20087 - lat) + Math.Abs(-75.86865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.41828 - lat) + Math.Abs(-75.87753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.98892 - lat) + Math.Abs(-72.91254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.59477 - lat) + Math.Abs(-77.05408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.99528 - lat) + Math.Abs(-75.81278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.70413 - lat) + Math.Abs(-73.2793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.96854 - lat) + Math.Abs(-74.78132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94597 - lat) + Math.Abs(-74.10647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.95672 - lat) + Math.Abs(-72.79456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.56963 - lat) + Math.Abs(-72.96676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06528 - lat) + Math.Abs(-73.85472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.63572 - lat) + Math.Abs(-73.22282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.43809 - lat) + Math.Abs(-75.33136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.93168 - lat) + Math.Abs(-73.61507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.67154 - lat) + Math.Abs(-78.13978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.15333 - lat) + Math.Abs(-75.05306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.79408 - lat) + Math.Abs(-74.9164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.94985 - lat) + Math.Abs(-75.95826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.04183 - lat) + Math.Abs(-77.21646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.22622 - lat) + Math.Abs(-77.40439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.41164 - lat) + Math.Abs(-76.4152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31372 - lat) + Math.Abs(-75.13982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.59147 - lat) + Math.Abs(-75.38178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.49828 - lat) + Math.Abs(-73.97591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.2522 - lat) + Math.Abs(-75.0198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.03103 - lat) + Math.Abs(-74.88683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15639 - lat) + Math.Abs(-75.78722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.53389 - lat) + Math.Abs(-75.68111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25444 - lat) + Math.Abs(-75.34389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25 - lat) + Math.Abs(-74 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.73127 - lat) + Math.Abs(-75.14257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.72342 - lat) + Math.Abs(-76.11909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.25563 - lat) + Math.Abs(-77.24876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45928 - lat) + Math.Abs(-73.94331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75463 - lat) + Math.Abs(-73.43669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85051 - lat) + Math.Abs(-76.42694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64233 - lat) + Math.Abs(-72.79944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.27254 - lat) + Math.Abs(-74.41513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.02917 - lat) + Math.Abs(-71.42806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.08471 - lat) + Math.Abs(-70.75908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.69432 - lat) + Math.Abs(-73.01868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.27123 - lat) + Math.Abs(-75.49044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.59181 - lat) + Math.Abs(-74.18983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51858 - lat) + Math.Abs(-72.88387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.10658 - lat) + Math.Abs(-75.94244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88299 - lat) + Math.Abs(-76.62587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.63087 - lat) + Math.Abs(-75.0946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.30322 - lat) + Math.Abs(-75.85381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55687 - lat) + Math.Abs(-75.82806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.79722 - lat) + Math.Abs(-75.995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33278 - lat) + Math.Abs(-75.79111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.07273 - lat) + Math.Abs(-75.14768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.83362 - lat) + Math.Abs(-74.4995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88508 - lat) + Math.Abs(-75.33467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.11072 - lat) + Math.Abs(-75.70923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.6561 - lat) + Math.Abs(-75.87877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.17061 - lat) + Math.Abs(-76.16641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.2633 - lat) + Math.Abs(-77.51376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.55099 - lat) + Math.Abs(-74.53517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.39639 - lat) + Math.Abs(-75.445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.78405 - lat) + Math.Abs(-74.76268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.91016 - lat) + Math.Abs(-75.07764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04001 - lat) + Math.Abs(-75.70315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.56826 - lat) + Math.Abs(-74.9523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.06278 - lat) + Math.Abs(-75.78722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.97083 - lat) + Math.Abs(-73.37972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.91472 - lat) + Math.Abs(-76.85482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.52385 - lat) + Math.Abs(-75.31733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18694 - lat) + Math.Abs(-74.57528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.37745 - lat) + Math.Abs(-75.14065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.88283 - lat) + Math.Abs(-77.70103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.67472 - lat) + Math.Abs(-75.7825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.16099 - lat) + Math.Abs(-72.59238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75894 - lat) + Math.Abs(-73.91376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.32866 - lat) + Math.Abs(-75.87824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.87661 - lat) + Math.Abs(-74.43768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.22222 - lat) + Math.Abs(-75.23667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.17282 - lat) + Math.Abs(-72.54706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.37648 - lat) + Math.Abs(-74.66995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.61161 - lat) + Math.Abs(-75.45624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30844 - lat) + Math.Abs(-73.6166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.25725 - lat) + Math.Abs(-75.77142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5695 - lat) + Math.Abs(-74.55715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.80464 - lat) + Math.Abs(-75.89036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.51158 - lat) + Math.Abs(-77.27719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.98695 - lat) + Math.Abs(-73.75797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.63148 - lat) + Math.Abs(-76.06444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.08065 - lat) + Math.Abs(-73.22054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.78928 - lat) + Math.Abs(-75.42725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.17 - lat) + Math.Abs(-73.09306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.52762 - lat) + Math.Abs(-74.02335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.77411 - lat) + Math.Abs(-72.86834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.03327 - lat) + Math.Abs(-75.91907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.25917 - lat) + Math.Abs(-75.3225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.5209 - lat) + Math.Abs(-77.26206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.18917 - lat) + Math.Abs(-75.70361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.39806 - lat) + Math.Abs(-75.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57562 - lat) + Math.Abs(-73.09489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.29889 - lat) + Math.Abs(-72.49472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.4258 - lat) + Math.Abs(-76.90558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.38463 - lat) + Math.Abs(-74.04424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55645 - lat) + Math.Abs(-76.88389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.20796 - lat) + Math.Abs(-75.78881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.88556 - lat) + Math.Abs(-73.36889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.87802 - lat) + Math.Abs(-72.89575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.37575 - lat) + Math.Abs(-73.21547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.31328 - lat) + Math.Abs(-72.08157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.8543 - lat) + Math.Abs(-73.04003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.61208 - lat) + Math.Abs(-72.92761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.75446 - lat) + Math.Abs(-76.62791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.5142 - lat) + Math.Abs(-76.84939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.5194 - lat) + Math.Abs(-74.17765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.7225 - lat) + Math.Abs(-76.02083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.67611 - lat) + Math.Abs(-76.20417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.92583 - lat) + Math.Abs(-75.67056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.93897 - lat) + Math.Abs(-75.5858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.81854 - lat) + Math.Abs(-73.63659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74372 - lat) + Math.Abs(-75.71331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.90333 - lat) + Math.Abs(-75.6825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.71873 - lat) + Math.Abs(-75.90734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75849 - lat) + Math.Abs(-76.65255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.85389 - lat) + Math.Abs(-76.02528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.76141 - lat) + Math.Abs(-74.79473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.79162 - lat) + Math.Abs(-74.16556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96444 - lat) + Math.Abs(-74.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55666 - lat) + Math.Abs(-74.26355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.50563 - lat) + Math.Abs(-72.7331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.33488 - lat) + Math.Abs(-74.84289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.03672 - lat) + Math.Abs(-73.23558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.39278 - lat) + Math.Abs(-73.0325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.00151 - lat) + Math.Abs(-73.51126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33889 - lat) + Math.Abs(-76.73139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.33022 - lat) + Math.Abs(-72.62765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.93556 - lat) + Math.Abs(-76.24056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.79029 - lat) + Math.Abs(-74.78244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.73924 - lat) + Math.Abs(-73.83489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.89115 - lat) + Math.Abs(-72.13328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.62206 - lat) + Math.Abs(-72.75724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.39949 - lat) + Math.Abs(-78.18923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64059 - lat) + Math.Abs(-73.32762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.97028 - lat) + Math.Abs(-76.58583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47131 - lat) + Math.Abs(-73.2031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33997 - lat) + Math.Abs(-73.61696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.01402 - lat) + Math.Abs(-71.29624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.35111 - lat) + Math.Abs(-72.45639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.25875 - lat) + Math.Abs(-77.36516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.16232 - lat) + Math.Abs(-73.5221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.18266 - lat) + Math.Abs(-73.7871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.4525 - lat) + Math.Abs(-76.91917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.34944 - lat) + Math.Abs(-74.98056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.33196 - lat) + Math.Abs(-75.97409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.57286 - lat) + Math.Abs(-72.64591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.66749 - lat) + Math.Abs(-76.87297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.68362 - lat) + Math.Abs(-76.60439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.87516 - lat) + Math.Abs(-75.61943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.41258 - lat) + Math.Abs(-74.99219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.96454 - lat) + Math.Abs(-76.40795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.12002 - lat) + Math.Abs(-76.32131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.26456 - lat) + Math.Abs(-73.15012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.39176 - lat) + Math.Abs(-74.93344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.5391 - lat) + Math.Abs(-74.89752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.26942 - lat) + Math.Abs(-73.37537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.63918 - lat) + Math.Abs(-76.53055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.66779 - lat) + Math.Abs(-74.0215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.96701 - lat) + Math.Abs(-74.90294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.5018 - lat) + Math.Abs(-75.74309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.16433 - lat) + Math.Abs(-75.43906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.99732 - lat) + Math.Abs(-72.69138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.02839 - lat) + Math.Abs(-73.44703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21093 - lat) + Math.Abs(-74.31797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.936 - lat) + Math.Abs(-74.03975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.23479 - lat) + Math.Abs(-75.78465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.39961 - lat) + Math.Abs(-75.54719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.89862 - lat) + Math.Abs(-76.14205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8894 - lat) + Math.Abs(-75.67015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.04911 - lat) + Math.Abs(-75.33728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3359 - lat) + Math.Abs(-74.02659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74389 - lat) + Math.Abs(-73.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.58103 - lat) + Math.Abs(-74.44293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zipaquirá", "33", 5.02208, -74.00481);
case 1: return new CityInfo("Zipacón", "33", 4.75881, -74.38017);
case 2: return new CityInfo("Zetaquira", "36", 5.28215, -73.16896);
case 3: return new CityInfo("Zarzal", "29", 4.39462, -76.0715);
case 4: return new CityInfo("Zaragoza", "02", 7.48971, -74.86919);
case 5: return new CityInfo("Zapatoca", "26", 6.81532, -73.26768);
case 6: return new CityInfo("Zambrano", "35", 9.7474, -74.81572);
case 7: return new CityInfo("Yuto", "11", 5.53168, -76.63512);
case 8: return new CityInfo("Yumbo", "29", 3.58234, -76.49146);
case 9: return new CityInfo("Yotoco", "29", 3.86048, -76.38364);
case 10: return new CityInfo("Yopal", "32", 5.33775, -72.39586);
case 11: return new CityInfo("Yondó", "02", 7.00621, -73.90972);
case 12: return new CityInfo("Yolombó", "02", 6.59841, -75.0114);
case 13: return new CityInfo("Yarumal", "02", 6.96321, -75.41738);
case 14: return new CityInfo("Yalí", "02", 6.67457, -74.8343);
case 15: return new CityInfo("Yaguará", "16", 2.66355, -75.51753);
case 16: return new CityInfo("Yacuanquer", "20", 1.11577, -77.40169);
case 17: return new CityInfo("Yacopí", "33", 5.45948, -74.33823);
case 18: return new CityInfo("Viterbo", "37", 5.06242, -75.87159);
case 19: return new CityInfo("Vistahermosa", "19", 3.12428, -73.75156);
case 20: return new CityInfo("Viracachá", "36", 5.43637, -73.29606);
case 21: return new CityInfo("Viotá", "33", 4.43713, -74.52157);
case 22: return new CityInfo("Villeta", "33", 5.00886, -74.47226);
case 23: return new CityInfo("Villavieja", "16", 3.22052, -75.21864);
case 24: return new CityInfo("Villavicencio", "19", 4.142, -73.62664);
case 25: return new CityInfo("Villarrica", "28", 3.93502, -74.60036);
case 26: return new CityInfo("Villa Rica", "09", 3.17484, -76.46197);
case 27: return new CityInfo("Villa del Rosario", "21", 7.83389, -72.47417);
case 28: return new CityInfo("Villapinzón", "33", 5.21617, -73.5949);
case 29: return new CityInfo("Villanueva", "17", 10.60768, -72.97901);
case 30: return new CityInfo("Villanueva", "35", 10.44361, -75.27306);
case 31: return new CityInfo("Villanueva", "26", 6.67169, -73.17421);
case 32: return new CityInfo("Villanueva", "32", 5.28333, -71.96667);
case 33: return new CityInfo("Villamaría", "37", 5.04565, -75.51474);
case 34: return new CityInfo("Villahermosa", "28", 5.03067, -75.11607);
case 35: return new CityInfo("Villagómez", "33", 5.27372, -74.19614);
case 36: return new CityInfo("Villagarzón", "22", 1.0375, -76.62667);
case 37: return new CityInfo("Villa de Leyva", "36", 5.63413, -73.52438);
case 38: return new CityInfo("Villa Caro", "21", 7.91427, -72.97144);
case 39: return new CityInfo("Vijes", "29", 3.69934, -76.4423);
case 40: return new CityInfo("Vigía del Fuerte", "02", 6.58933, -76.89599);
case 41: return new CityInfo("La Victoria", "36", 5.52583, -74.23611);
case 42: return new CityInfo("Victoria", "37", 5.31648, -74.91101);
case 43: return new CityInfo("Vianí", "33", 4.87384, -74.56244);
case 44: return new CityInfo("Vetas", "26", 7.30911, -72.87122);
case 45: return new CityInfo("Versalles", "29", 4.57544, -76.19814);
case 46: return new CityInfo("Vergara", "33", 5.11841, -74.34549);
case 47: return new CityInfo("Ventaquemada", "36", 5.36753, -73.52075);
case 48: return new CityInfo("Venecia", "02", 5.96278, -75.73806);
case 49: return new CityInfo("Venecia", "33", 4.08808, -74.47746);
case 50: return new CityInfo("Venadillo", "28", 4.71929, -74.92918);
case 51: return new CityInfo("Vélez", "26", 6.01335, -73.67352);
case 52: return new CityInfo("Valparaíso", "02", 5.615, -75.62422);
case 53: return new CityInfo("Valparaíso", "08", 1.19403, -75.70746);
case 54: return new CityInfo("Valledupar", "10", 10.46314, -73.25322);
case 55: return new CityInfo("Valle de San Juan", "28", 4.19869, -75.11733);
case 56: return new CityInfo("Valle de San José", "26", 6.4475, -73.14361);
case 57: return new CityInfo("Valencia", "12", 8.25801, -76.14928);
case 58: return new CityInfo("Valdivia", "02", 7.29382, -75.3919);
case 59: return new CityInfo("Útica", "33", 5.18727, -74.48105);
case 60: return new CityInfo("Usiacurí", "04", 10.74313, -74.97604);
case 61: return new CityInfo("Urumita", "17", 10.55894, -73.01232);
case 62: return new CityInfo("Urrao", "02", 6.31696, -76.1342);
case 63: return new CityInfo("Uribia", "17", 11.71505, -72.26592);
case 64: return new CityInfo("Uribe", "19", 3.2409, -74.35497);
case 65: return new CityInfo("San José de Uré", "12", 7.78637, -75.5337);
case 66: return new CityInfo("Uramita", "02", 6.89944, -76.17417);
case 67: return new CityInfo("Unguía", "11", 8.04364, -77.09137);
case 68: return new CityInfo("Une", "33", 4.40306, -74.02528);
case 69: return new CityInfo("Úmbita", "36", 5.22041, -73.45695);
case 70: return new CityInfo("Ulloa", "29", 4.70444, -75.74028);
case 71: return new CityInfo("Villa de San Diego de Ubaté", "33", 5.30933, -73.81575);
case 72: return new CityInfo("Ubaque", "33", 4.48667, -73.93748);
case 73: return new CityInfo("Ubalá", "33", 4.74778, -72.53694);
case 74: return new CityInfo("Tutazá", "36", 6.03228, -72.85639);
case 75: return new CityInfo("Tuta", "36", 5.68966, -73.22779);
case 76: return new CityInfo("Turmequé", "36", 5.3236, -73.49067);
case 77: return new CityInfo("Turbo", "02", 8.09263, -76.72822);
case 78: return new CityInfo("Turbaná", "35", 10.27169, -75.44222);
case 79: return new CityInfo("Turbaco", "35", 10.32944, -75.41137);
case 80: return new CityInfo("Túquerres", "20", 1.08647, -77.61858);
case 81: return new CityInfo("Tununguá", "36", 5.72967, -73.94137);
case 82: return new CityInfo("Tunja", "36", 5.53528, -73.36778);
case 83: return new CityInfo("Tumaco", "20", 1.79112, -78.79275);
case 84: return new CityInfo("Tuluá", "29", 4.08466, -76.19536);
case 85: return new CityInfo("Tuchín", "12", 9.18662, -75.55473);
case 86: return new CityInfo("Tubará", "04", 10.87562, -74.97873);
case 87: return new CityInfo("Trujillo", "29", 4.21217, -76.31945);
case 88: return new CityInfo("Trinidad", "32", 5.40849, -71.66196);
case 89: return new CityInfo("Tres Esquinas", "28", 3.86512, -74.70906);
case 90: return new CityInfo("Totoró", "09", 2.51111, -76.40178);
case 91: return new CityInfo("Tota", "36", 5.55833, -72.98757);
case 92: return new CityInfo("Toro", "29", 4.61167, -76.08139);
case 93: return new CityInfo("Toribío", "09", 2.95481, -76.26839);
case 94: return new CityInfo("Topaipí", "33", 5.33457, -74.30292);
case 95: return new CityInfo("Tópaga", "36", 5.75979, -72.82583);
case 96: return new CityInfo("Tona", "26", 7.20221, -72.96502);
case 97: return new CityInfo("Tolú Viejo", "27", 9.45082, -75.43864);
case 98: return new CityInfo("Santiago de Tolú", "27", 9.52392, -75.58139);
case 99: return new CityInfo("Toledo", "21", 7.30984, -72.48295);
case 100: return new CityInfo("Toledo", "02", 7.01306, -75.69528);
case 101: return new CityInfo("Togüí", "36", 5.93462, -73.51297);
case 102: return new CityInfo("Tocancipá", "33", 4.96531, -73.91301);
case 103: return new CityInfo("Tocaima", "33", 4.4582, -74.63434);
case 104: return new CityInfo("Toca", "36", 5.56393, -73.18398);
case 105: return new CityInfo("Titiribí", "02", 6.06276, -75.7937);
case 106: return new CityInfo("Tipacoque", "36", 6.42031, -72.69184);
case 107: return new CityInfo("Tinjacá", "36", 5.57916, -73.64486);
case 108: return new CityInfo("Timbiquí", "09", 2.7717, -77.66536);
case 109: return new CityInfo("Timbío", "09", 2.35017, -76.68341);
case 110: return new CityInfo("Timaná", "16", 1.97136, -75.93123);
case 111: return new CityInfo("Tierralta", "12", 8.17361, -76.05917);
case 112: return new CityInfo("Tibú", "21", 8.63895, -72.73583);
case 113: return new CityInfo("Tibirita", "33", 5.05227, -73.50459);
case 114: return new CityInfo("Tibasosa", "36", 5.75, -73);
case 115: return new CityInfo("Tibaná", "36", 5.31728, -73.39655);
case 116: return new CityInfo("Tibacuy", "33", 4.35, -74.45179);
case 117: return new CityInfo("Tesalia", "16", 2.48587, -75.72921);
case 118: return new CityInfo("Teruel", "16", 2.74193, -75.56738);
case 119: return new CityInfo("Teorama", "21", 8.43633, -73.28981);
case 120: return new CityInfo("Tenza", "36", 5.07664, -73.42077);
case 121: return new CityInfo("Tenjo", "33", 4.8727, -74.14435);
case 122: return new CityInfo("Tenerife", "38", 9.90093, -74.85985);
case 123: return new CityInfo("Tena", "33", 4.66001, -74.39258);
case 124: return new CityInfo("Tello", "16", 3.06694, -75.13778);
case 125: return new CityInfo("Tausa", "33", 5.19903, -73.89128);
case 126: return new CityInfo("Tauramena", "32", 5.01789, -72.74675);
case 127: return new CityInfo("Tasco", "36", 5.91044, -72.78001);
case 128: return new CityInfo("Tarso", "02", 5.86467, -75.82192);
case 129: return new CityInfo("Tarqui", "16", 2.11248, -75.82419);
case 130: return new CityInfo("Tarazá", "02", 7.58358, -75.40068);
case 131: return new CityInfo("Tarapacá", "01", -2.892, -69.742);
case 132: return new CityInfo("Tangua", "20", 1.09473, -77.39482);
case 133: return new CityInfo("Taminango", "20", 1.57032, -77.28043);
case 134: return new CityInfo("Támesis", "02", 5.66462, -75.71339);
case 135: return new CityInfo("Tame", "03", 6.46065, -71.73618);
case 136: return new CityInfo("Támara", "32", 5.82998, -72.16286);
case 137: return new CityInfo("Tamalameque", "10", 8.85221, -73.81229);
case 138: return new CityInfo("Talaigua Viejo", "35", 9.31206, -74.58544);
case 139: return new CityInfo("Talaigua Nuevo", "35", 9.30347, -74.56477);
case 140: return new CityInfo("Tadó", "11", 5.26598, -76.56487);
case 141: return new CityInfo("Tabio", "33", 4.91726, -74.09364);
case 142: return new CityInfo("Sutatenza", "36", 5.02311, -73.4523);
case 143: return new CityInfo("Sutatausa", "33", 5.24779, -73.85238);
case 144: return new CityInfo("Sutamarchán", "36", 5.61538, -73.61701);
case 145: return new CityInfo("Susacón", "36", 6.22978, -72.6901);
case 146: return new CityInfo("Susa", "33", 5.4519, -73.81436);
case 147: return new CityInfo("Suratá", "26", 7.36633, -72.98361);
case 148: return new CityInfo("Supía", "37", 5.45303, -75.65072);
case 149: return new CityInfo("Supatá", "33", 5.06097, -74.23721);
case 150: return new CityInfo("Suesca", "33", 5.10289, -73.79845);
case 151: return new CityInfo("Sucre", "27", 8.81136, -74.72084);
case 152: return new CityInfo("Sucre", "26", 5.91833, -73.79109);
case 153: return new CityInfo("Sucre", "09", 2.03805, -76.92446);
case 154: return new CityInfo("Subachoque", "33", 4.92614, -74.17299);
case 155: return new CityInfo("Suaza", "16", 1.97611, -75.79454);
case 156: return new CityInfo("Suárez", "28", 4.04906, -74.83198);
case 157: return new CityInfo("Suárez", "09", 2.95395, -76.69644);
case 158: return new CityInfo("Suan", "04", 10.33347, -74.88016);
case 159: return new CityInfo("Suaita", "26", 6.1014, -73.44041);
case 160: return new CityInfo("Sotomayor", "20", 1.49474, -77.52136);
case 161: return new CityInfo("Sotaquirá", "36", 5.76483, -73.24758);
case 162: return new CityInfo("Soracá", "36", 5.50055, -73.33299);
case 163: return new CityInfo("Sora", "36", 5.56514, -73.45017);
case 164: return new CityInfo("Sopó", "33", 4.9075, -73.9384);
case 165: return new CityInfo("Soplaviento", "35", 10.39306, -75.14083);
case 166: return new CityInfo("Sonsón", "02", 5.71062, -75.31069);
case 167: return new CityInfo("Somondoco", "36", 4.98495, -73.43238);
case 168: return new CityInfo("Soledad", "04", 10.91843, -74.76459);
case 169: return new CityInfo("Solano", "08", 0.69937, -75.25353);
case 170: return new CityInfo("Sogamoso", "36", 5.71434, -72.93391);
case 171: return new CityInfo("Socotá", "36", 6.04028, -72.63509);
case 172: return new CityInfo("Socorro", "26", 6.46838, -73.26022);
case 173: return new CityInfo("Socha Viejo", "36", 5.9817, -72.71503);
case 174: return new CityInfo("Soatá", "36", 6.33369, -72.68283);
case 175: return new CityInfo("Soacha", "33", 4.57937, -74.21682);
case 176: return new CityInfo("Sitionuevo", "38", 10.77737, -74.72049);
case 177: return new CityInfo("Sipí", "11", 4.65374, -76.64442);
case 178: return new CityInfo("Sincelejo", "27", 9.30472, -75.39778);
case 179: return new CityInfo("San Luis de Sincé", "27", 9.24391, -75.14675);
case 180: return new CityInfo("Simití", "35", 7.9579, -73.9436);
case 181: return new CityInfo("Simijaca", "33", 5.50291, -73.85227);
case 182: return new CityInfo("Simacota", "26", 6.4429, -73.33688);
case 183: return new CityInfo("Silvia", "09", 2.61557, -76.38261);
case 184: return new CityInfo("Silvania", "33", 4.40367, -74.3867);
case 185: return new CityInfo("Silos", "21", 7.20524, -72.75639);
case 186: return new CityInfo("Sibundoy", "22", 1.20296, -76.92275);
case 187: return new CityInfo("Sibaté", "33", 4.49154, -74.25957);
case 188: return new CityInfo("Siachoque", "36", 5.51238, -73.24436);
case 189: return new CityInfo("Prado-Sevilla", "38", 10.76343, -74.13916);
case 190: return new CityInfo("Sevilla", "29", 4.26425, -75.93085);
case 191: return new CityInfo("Sesquilé", "33", 5.04463, -73.79724);
case 192: return new CityInfo("Segovia", "02", 7.07993, -74.6989);
case 193: return new CityInfo("Sativasur", "36", 6.08959, -72.72432);
case 194: return new CityInfo("Sativanorte", "36", 6.13156, -72.70895);
case 195: return new CityInfo("Sasaima", "33", 4.96705, -74.43512);
case 196: return new CityInfo("Sardinata", "21", 8.08289, -72.80071);
case 197: return new CityInfo("Saravena", "03", 6.96319, -71.8823);
case 198: return new CityInfo("Sapuyes", "20", 1.03728, -77.62094);
case 199: return new CityInfo("San Zenón", "38", 9.24217, -74.50037);
case 200: return new CityInfo("San Vicente del Caguán", "08", 2.12172, -74.76614);
case 201: return new CityInfo("San Vicente de Chucurí", "26", 6.881, -73.40977);
case 202: return new CityInfo("San Vicente", "02", 6.28535, -75.33385);
case 203: return new CityInfo("Santuario", "02", 6.13833, -75.26417);
case 204: return new CityInfo("Santuario", "24", 5.07415, -75.96423);
case 205: return new CityInfo("Santo Tomás", "04", 10.75773, -74.75451);
case 206: return new CityInfo("Santo Domingo", "02", 6.47282, -75.16547);
case 207: return new CityInfo("Santiago", "21", 7.86432, -72.7162);
case 208: return new CityInfo("Santiago", "22", 1.14844, -77.0045);
case 209: return new CityInfo("Santa Sofía", "36", 5.70908, -73.60404);
case 210: return new CityInfo("Santa Rosalia", "31", 5.13356, -70.86233);
case 211: return new CityInfo("Santa Rosa de Viterbo", "36", 5.87401, -72.98217);
case 212: return new CityInfo("Santa Rosa de Osos", "02", 6.64738, -75.46031);
case 213: return new CityInfo("Santa Rosa de Cabal", "24", 4.86806, -75.62139);
case 214: return new CityInfo("Santa Rosa", "35", 10.44472, -75.36972);
case 215: return new CityInfo("Santa Rosa", "09", 1.70267, -76.57389);
case 216: return new CityInfo("Santa Rita", "11", 5.18333, -76.48333);
case 217: return new CityInfo("Santander de Quilichao", "09", 3.00945, -76.48494);
case 218: return new CityInfo("Santana", "36", 6.0575, -73.48112);
case 219: return new CityInfo("Santa Marta", "38", 11.24079, -74.19904);
case 220: return new CityInfo("Santa María", "36", 4.86048, -73.26234);
case 221: return new CityInfo("Santa María", "16", 2.95, -75.65);
case 222: return new CityInfo("Santa Lucía", "04", 10.3242, -74.96017);
case 223: return new CityInfo("Santa Isabel", "25", 13.38166, -81.36891);
case 224: return new CityInfo("Santa Isabel", "28", 4.71418, -75.09799);
case 225: return new CityInfo("Santa Helena", "26", 6.3, -73.58333);
case 226: return new CityInfo("Santa Catalina", "35", 10.60361, -75.28824);
case 227: return new CityInfo("Santa Bárbara", "26", 6.99022, -72.907);
case 228: return new CityInfo("Santa Bárbara", "02", 5.87458, -75.56706);
case 229: return new CityInfo("Santa Ana", "38", 9.32125, -74.56848);
case 230: return new CityInfo("San Sebastián de Buenavista", "38", 9.23778, -74.35166);
case 231: return new CityInfo("San Sebastián", "09", 1.83861, -76.77189);
case 232: return new CityInfo("San Roque", "02", 6.48511, -75.0196);
case 233: return new CityInfo("San Rafael", "02", 6.29436, -75.02589);
case 234: return new CityInfo("San Pelayo", "12", 8.95833, -75.83627);
case 235: return new CityInfo("San Pedro de Urabá", "02", 8.27515, -76.37641);
case 236: return new CityInfo("San Pedro", "27", 9.3956, -75.06476);
case 237: return new CityInfo("San Pedro", "02", 6.46135, -75.55778);
case 238: return new CityInfo("San Pedro", "29", 3.99445, -76.22885);
case 239: return new CityInfo("San Pablo de Borbur", "36", 5.65138, -74.06991);
case 240: return new CityInfo("San Pablo", "35", 10.05154, -75.26775);
case 241: return new CityInfo("San Pablo", "35", 7.47754, -73.92255);
case 242: return new CityInfo("San Pablo", "20", 1.6725, -77.01389);
case 243: return new CityInfo("San Onofre", "27", 9.73586, -75.52626);
case 244: return new CityInfo("San Miguel de Sema", "36", 5.51847, -73.72238);
case 245: return new CityInfo("San Miguel", "26", 6.57583, -72.64591);
case 246: return new CityInfo("La Dorada", "22", 0.34314, -76.91124);
case 247: return new CityInfo("San Mateo", "36", 6.40195, -72.55314);
case 248: return new CityInfo("San Martín", "19", 3.69637, -73.69957);
case 249: return new CityInfo("San Marcos", "27", 8.65972, -75.12809);
case 250: return new CityInfo("San Luis de Palenque", "32", 5.42139, -71.73167);
case 251: return new CityInfo("San Luis de Gaceno", "36", 4.82052, -73.16851);
case 252: return new CityInfo("Cubarral", "19", 3.79536, -73.84063);
case 253: return new CityInfo("San Luis", "02", 6.04343, -74.99366);
case 254: return new CityInfo("San Luis", "28", 4.13258, -75.09499);
case 255: return new CityInfo("San Lorenzo", "20", 1.50294, -77.21537);
case 256: return new CityInfo("San Juan Nepomuceno", "35", 9.95157, -75.08198);
case 257: return new CityInfo("San Juanito", "19", 4.46103, -73.68048);
case 258: return new CityInfo("San Juan de Urabá", "02", 8.75924, -76.52969);
case 259: return new CityInfo("San Juan de Rioseco", "33", 4.84778, -74.62148);
case 260: return new CityInfo("San Juan del Cesar", "17", 10.77107, -73.00314);
case 261: return new CityInfo("San Juan de Betulia", "27", 9.27345, -75.24103);
case 262: return new CityInfo("San Juan de Arama", "19", 3.36985, -73.87267);
case 263: return new CityInfo("San José de Pare", "36", 6.01746, -73.54703);
case 264: return new CityInfo("San José de Miranda", "26", 6.6587, -72.73344);
case 265: return new CityInfo("San José del Palmar", "11", 4.89616, -76.23422);
case 266: return new CityInfo("San José de la Montaña", "02", 6.85028, -75.68333);
case 267: return new CityInfo("Isnos", "16", 1.92874, -76.21104);
case 268: return new CityInfo("San José", "37", 5.08221, -75.79107);
case 269: return new CityInfo("San José", "20", 1.69659, -78.24482);
case 270: return new CityInfo("San José", "20", 1.47446, -77.08144);
case 271: return new CityInfo("San Joaquín", "26", 6.43004, -72.86768);
case 272: return new CityInfo("San Jerónimo", "02", 6.44344, -75.72815);
case 273: return new CityInfo("San Jacinto del Cauca", "35", 8.24976, -74.72079);
case 274: return new CityInfo("San Jacinto", "35", 9.82767, -75.1217);
case 275: return new CityInfo("San Gil", "26", 6.55952, -73.13637);
case 276: return new CityInfo("San Francisco", "02", 6.11667, -75.98333);
case 277: return new CityInfo("San Francisco", "02", 5.96426, -75.10165);
case 278: return new CityInfo("San Francisco", "33", 4.97876, -74.2927);
case 279: return new CityInfo("San Francisco", "22", 1.17644, -76.87838);
case 280: return new CityInfo("San Fernando", "35", 9.27972, -74.53389);
case 281: return new CityInfo("San Felipe", "15", 1.91408, -67.06996);
case 282: return new CityInfo("San Estanislao", "35", 10.39833, -75.15111);
case 283: return new CityInfo("San Eduardo", "36", 5.22396, -73.07696);
case 284: return new CityInfo("Sandoná", "20", 1.28626, -77.46921);
case 285: return new CityInfo("San Diego", "10", 10.33623, -73.18203);
case 286: return new CityInfo("San Cristóbal", "35", 10.39523, -75.06562);
case 287: return new CityInfo("San Cristóbal", "35", 9.87809, -75.25248);
case 288: return new CityInfo("San Cayetano", "21", 7.87707, -72.6243);
case 289: return new CityInfo("San Cayetano", "33", 5.30153, -74.06954);
case 290: return new CityInfo("San Carlos de Guaroa", "19", 3.71161, -73.24344);
case 291: return new CityInfo("San Carlos", "12", 8.79577, -75.69947);
case 292: return new CityInfo("San Carlos", "02", 7.79177, -74.77316);
case 293: return new CityInfo("San Carlos", "02", 6.18789, -74.99315);
case 294: return new CityInfo("San Calixto", "21", 8.4021, -73.20737);
case 295: return new CityInfo("San Bernardo del Viento", "12", 9.3533, -75.95244);
case 296: return new CityInfo("San Bernardo", "33", 4.17864, -74.42311);
case 297: return new CityInfo("San Bernardo", "20", 1.51525, -77.04679);
case 298: return new CityInfo("San Benito Abad", "27", 8.92901, -75.02709);
case 299: return new CityInfo("San Benito", "26", 6.13269, -73.49065);
case 300: return new CityInfo("San Antonio del Tequendama", "33", 4.61617, -74.352);
case 301: return new CityInfo("San Antonio", "38", 9.93303, -74.69346);
case 302: return new CityInfo("San Antonio", "28", 3.91423, -75.48009);
case 303: return new CityInfo("San Antero", "12", 9.3741, -75.75891);
case 304: return new CityInfo("San Ángel", "38", 10.03047, -74.21482);
case 305: return new CityInfo("San Andrés de Sotavento", "12", 9.14475, -75.50877);
case 306: return new CityInfo("San Andrés", "25", 12.58317, -81.70636);
case 307: return new CityInfo("San Andrés", "26", 6.81148, -72.84929);
case 308: return new CityInfo("San Alberto", "10", 7.76107, -73.3922);
case 309: return new CityInfo("San Agustín", "16", 1.87884, -76.26722);
case 310: return new CityInfo("Sampués", "27", 9.18361, -75.38167);
case 311: return new CityInfo("Samaniego", "20", 1.33849, -77.5957);
case 312: return new CityInfo("Samacá", "36", 5.49273, -73.48537);
case 313: return new CityInfo("Salgar", "02", 5.96502, -75.96541);
case 314: return new CityInfo("Salento", "23", 4.6375, -75.57028);
case 315: return new CityInfo("Saldaña", "28", 3.92923, -75.01517);
case 316: return new CityInfo("Salamina", "38", 10.49027, -74.79463);
case 317: return new CityInfo("Salamina", "37", 5.40733, -75.48749);
case 318: return new CityInfo("Saladoblanco", "16", 1.99244, -76.04335);
case 319: return new CityInfo("Sahagún", "12", 8.94617, -75.44275);
case 320: return new CityInfo("Sáchica", "36", 5.58453, -73.54184);
case 321: return new CityInfo("Sácama", "32", 6.09908, -72.2488);
case 322: return new CityInfo("Saboyá", "36", 5.69636, -73.76932);
case 323: return new CityInfo("Sabaneta", "02", 6.15153, -75.61657);
case 324: return new CityInfo("Sabanalarga", "04", 10.63072, -74.92214);
case 325: return new CityInfo("Sabanalarga", "02", 6.84893, -75.81711);
case 326: return new CityInfo("Sabanagrande", "04", 10.79115, -74.76059);
case 327: return new CityInfo("Sabana de Torres", "26", 7.3915, -73.49574);
case 328: return new CityInfo("Rovira", "28", 4.23922, -75.23996);
case 329: return new CityInfo("Rosas", "09", 2.26093, -76.73986);
case 330: return new CityInfo("Rondón", "36", 5.35642, -73.20918);
case 331: return new CityInfo("Roncesvalles", "28", 4.0108, -75.60493);
case 332: return new CityInfo("Roldanillo", "29", 4.41256, -76.15457);
case 333: return new CityInfo("Rivera", "16", 2.77717, -75.25642);
case 334: return new CityInfo("Risaralda", "37", 5.16647, -75.76595);
case 335: return new CityInfo("Río Viejo", "35", 8.5874, -73.83901);
case 336: return new CityInfo("Riosucio", "11", 7.44348, -77.11964);
case 337: return new CityInfo("Riosucio", "37", 5.42164, -75.70318);
case 338: return new CityInfo("Rionegro", "02", 6.15515, -75.37371);
case 339: return new CityInfo("Riohacha", "17", 11.54444, -72.90722);
case 340: return new CityInfo("Riofrío", "29", 4.1571, -76.28852);
case 341: return new CityInfo("Río de Oro", "10", 8.2919, -73.38485);
case 342: return new CityInfo("Rioblanco", "28", 3.52973, -75.64525);
case 343: return new CityInfo("Ricaurte", "33", 4.28075, -74.76469);
case 344: return new CityInfo("Ricaurte", "20", 1.21474, -77.99801);
case 345: return new CityInfo("Retiro", "02", 6.05861, -75.50306);
case 346: return new CityInfo("Restrepo", "19", 4.25833, -73.56142);
case 347: return new CityInfo("Restrepo", "29", 3.82203, -76.52242);
case 348: return new CityInfo("Repelón", "04", 10.4952, -75.12448);
case 349: return new CityInfo("Remolino", "38", 10.70199, -74.71602);
case 350: return new CityInfo("Remedios", "02", 7.02835, -74.69379);
case 351: return new CityInfo("Regidor", "35", 8.66565, -73.82151);
case 352: return new CityInfo("Recetor", "32", 5.22947, -72.76099);
case 353: return new CityInfo("Ráquira", "36", 5.53793, -73.63201);
case 354: return new CityInfo("Ramiriquí", "36", 5.4002, -73.33544);
case 355: return new CityInfo("Ragonvalia", "21", 7.57749, -72.47574);
case 356: return new CityInfo("Apulo", "33", 4.51952, -74.59293);
case 357: return new CityInfo("Quipile", "33", 4.74517, -74.53378);
case 358: return new CityInfo("Quinchía", "24", 5.33957, -75.73018);
case 359: return new CityInfo("Quimbaya", "23", 4.62306, -75.76278);
case 360: return new CityInfo("Quibdó", "11", 5.69188, -76.65835);
case 361: return new CityInfo("Quetame", "33", 4.33234, -73.86141);
case 362: return new CityInfo("Quebradanegra", "33", 5.11737, -74.47944);
case 363: return new CityInfo("Purísima de la Concepción", "12", 9.23657, -75.72191);
case 364: return new CityInfo("Purificación", "28", 3.85871, -74.93129);
case 365: return new CityInfo("Pupiales", "20", 0.87136, -77.64027);
case 366: return new CityInfo("Punta de Piedras", "38", 10.16863, -74.71682);
case 367: return new CityInfo("Pulí", "33", 4.68116, -74.71406);
case 368: return new CityInfo("Puerto Wilches", "26", 7.34828, -73.89601);
case 369: return new CityInfo("Puerto Triunfo", "02", 5.87259, -74.6405);
case 370: return new CityInfo("Puerto Tejada", "09", 3.23114, -76.41668);
case 371: return new CityInfo("Puerto Santander", "21", 8.36361, -72.4063);
case 372: return new CityInfo("Puerto Salgar", "33", 5.46304, -74.65436);
case 373: return new CityInfo("Puerto Rondón", "03", 6.28048, -71.1);
case 374: return new CityInfo("Puerto Yuca", "19", 2.93833, -73.20833);
case 375: return new CityInfo("Puerto Rico", "08", 1.90999, -75.15931);
case 376: return new CityInfo("Puerto Parra", "26", 6.65149, -74.05734);
case 377: return new CityInfo("Puerto Nariño", "01", -3.78889, -70.35584);
case 378: return new CityInfo("Puerto Meluk", "11", 5.22134, -76.93691);
case 379: return new CityInfo("Puerto López", "19", 4.09912, -72.95647);
case 380: return new CityInfo("Puerto Lleras", "19", 3.02225, -73.4044);
case 381: return new CityInfo("Puerto Leguízamo", "22", -0.19337, -74.78189);
case 382: return new CityInfo("Inírida", "15", 3.86528, -67.92389);
case 383: return new CityInfo("Puerto Escondido", "12", 9.01811, -76.26413);
case 384: return new CityInfo("Puerto Colombia", "04", 10.98778, -74.95472);
case 385: return new CityInfo("Puerto Carreño", "31", 6.18903, -67.48588);
case 386: return new CityInfo("Puerto Boyacá", "36", 5.976, -74.58516);
case 387: return new CityInfo("Puerto Bogotá", "33", 5.19994, -74.72733);
case 388: return new CityInfo("Puerto Berrío", "02", 6.49156, -74.40326);
case 389: return new CityInfo("Puerto Asís", "22", 0.50514, -76.49571);
case 390: return new CityInfo("Puerres", "20", 1.19374, -77.26661);
case 391: return new CityInfo("Puerres", "20", 0.88371, -77.50324);
case 392: return new CityInfo("Puente Nacional", "26", 5.87739, -73.6781);
case 393: return new CityInfo("Puebloviejo", "38", 10.99376, -74.28439);
case 394: return new CityInfo("Pueblorrico", "02", 5.79176, -75.84101);
case 395: return new CityInfo("Pueblo Rico", "24", 5.22263, -76.03026);
case 396: return new CityInfo("Pueblo Nuevo", "12", 8.50122, -75.508);
case 397: return new CityInfo("Pueblo Nuevo", "12", 8.2411, -74.95815);
case 398: return new CityInfo("Pueblo Bello", "10", 10.41706, -73.5804);
case 399: return new CityInfo("Providencia", "20", 1.56976, -77.464);
case 400: return new CityInfo("Prado", "28", 3.75118, -74.93004);
case 401: return new CityInfo("Pradera", "29", 3.42111, -76.24472);
case 402: return new CityInfo("Potosí", "20", 0.80739, -77.57216);
case 403: return new CityInfo("Pore", "32", 5.72792, -71.99266);
case 404: return new CityInfo("Popayán", "09", 2.43823, -76.61316);
case 405: return new CityInfo("Ponedera", "04", 10.64297, -74.75393);
case 406: return new CityInfo("Polonuevo", "04", 10.77697, -74.85344);
case 407: return new CityInfo("Policarpa", "20", 1.62843, -77.45956);
case 408: return new CityInfo("Playarrica", "28", 4.05694, -75.41028);
case 409: return new CityInfo("Planeta Rica", "12", 8.4115, -75.58508);
case 410: return new CityInfo("Planadas", "28", 3.19698, -75.64506);
case 411: return new CityInfo("Pizarro", "11", 4.95334, -77.36598);
case 412: return new CityInfo("Salahonda", "20", 2.0406, -78.65877);
case 413: return new CityInfo("Pivijay", "38", 10.46167, -74.61621);
case 414: return new CityInfo("Pitalito", "16", 1.85371, -76.05071);
case 415: return new CityInfo("Pital", "16", 2.2665, -75.80442);
case 416: return new CityInfo("Pisba", "36", 5.72396, -72.48646);
case 417: return new CityInfo("Piojó", "04", 10.74846, -75.10776);
case 418: return new CityInfo("Santa Bárbara de Pinto", "38", 9.43251, -74.70414);
case 419: return new CityInfo("Pinillos", "35", 8.91925, -74.46771);
case 420: return new CityInfo("Pinchote", "26", 6.53226, -73.17309);
case 421: return new CityInfo("Pijiño del Carmen", "38", 9.32908, -74.45302);
case 422: return new CityInfo("Pijao", "23", 4.3335, -75.70463);
case 423: return new CityInfo("Piedras", "28", 4.54261, -74.87823);
case 424: return new CityInfo("Piedrancha", "20", 1.14109, -77.86479);
case 425: return new CityInfo("Pie de Pató", "11", 5.51604, -76.97449);
case 426: return new CityInfo("Piedecuesta", "26", 6.98789, -73.04953);
case 427: return new CityInfo("Pesca", "36", 5.55, -73.05);
case 428: return new CityInfo("Pereira", "24", 4.81333, -75.69611);
case 429: return new CityInfo("Peque", "02", 7.02123, -75.90926);
case 430: return new CityInfo("Pensilvania", "37", 5.38346, -75.16122);
case 431: return new CityInfo("Pelaya", "10", 8.68819, -73.66451);
case 432: return new CityInfo("Pedraza", "38", 10.18739, -74.91504);
case 433: return new CityInfo("Paz de Río", "36", 5.98452, -72.7505);
case 434: return new CityInfo("Paz de Ariporo", "32", 5.88148, -71.89167);
case 435: return new CityInfo("Payandé", "28", 4.2975, -75.09667);
case 436: return new CityInfo("Payán", "20", 1.76645, -78.18326);
case 437: return new CityInfo("Paya", "36", 5.62492, -72.42345);
case 438: return new CityInfo("Pauna", "36", 5.65861, -73.9825);
case 439: return new CityInfo("Patía", "09", 2.06895, -77.05273);
case 440: return new CityInfo("Pasto", "20", 1.21361, -77.28111);
case 441: return new CityInfo("Pasca", "33", 4.30722, -74.30056);
case 442: return new CityInfo("Páramo", "26", 6.41639, -73.17);
case 443: return new CityInfo("Panqueba", "36", 6.44533, -72.46268);
case 444: return new CityInfo("Pandi", "33", 4.19111, -74.4875);
case 445: return new CityInfo("Pamplonita", "21", 7.43637, -72.63808);
case 446: return new CityInfo("Pamplona", "21", 7.37565, -72.64795);
case 447: return new CityInfo("Palocabildo", "28", 5.11705, -75.01732);
case 448: return new CityInfo("Palmito", "27", 9.33189, -75.5417);
case 449: return new CityInfo("Palmira", "29", 3.53944, -76.30361);
case 450: return new CityInfo("Palmas del Socorro", "26", 6.40756, -73.28824);
case 451: return new CityInfo("Palmar de Varela", "04", 10.74055, -74.75443);
case 452: return new CityInfo("Palmar", "26", 6.53773, -73.29234);
case 453: return new CityInfo("Palestina", "37", 5.0161, -75.62854);
case 454: return new CityInfo("Palestina", "16", 1.72362, -76.13403);
case 455: return new CityInfo("Palermo", "16", 2.89167, -75.4375);
case 456: return new CityInfo("Pajarito", "36", 5.2929, -72.70277);
case 457: return new CityInfo("Paispamba", "09", 2.25462, -76.61086);
case 458: return new CityInfo("Paipa", "36", 5.78013, -73.11708);
case 459: return new CityInfo("Paime", "33", 5.37054, -74.15219);
case 460: return new CityInfo("Paimadó", "11", 5.48309, -76.74053);
case 461: return new CityInfo("Pailitas", "10", 8.95652, -73.62548);
case 462: return new CityInfo("Paicol", "16", 2.44962, -75.775);
case 463: return new CityInfo("Páez", "36", 5.10112, -73.05123);
case 464: return new CityInfo("Belalcázar", "09", 2.64644, -75.97269);
case 465: return new CityInfo("Padua", "28", 5.13429, -75.14001);
case 466: return new CityInfo("Padilla", "09", 3.22038, -76.31385);
case 467: return new CityInfo("Pácora", "37", 5.52708, -75.4593);
case 468: return new CityInfo("Pacho", "33", 5.13278, -74.15977);
case 469: return new CityInfo("Pachavita", "36", 5.13969, -73.39739);
case 470: return new CityInfo("Ovejas", "27", 9.52716, -75.22873);
case 471: return new CityInfo("Otanche", "36", 5.65672, -74.18249);
case 472: return new CityInfo("Ospina", "20", 1.0595, -77.56554);
case 473: return new CityInfo("Ortega", "28", 3.9361, -75.22169);
case 474: return new CityInfo("Orocué", "32", 4.79035, -71.33917);
case 475: return new CityInfo("Oporapa", "16", 2.02378, -75.99588);
case 476: return new CityInfo("Onzaga", "26", 6.34434, -72.81726);
case 477: return new CityInfo("Olaya Herrera", "20", 1.24803, -77.49085);
case 478: return new CityInfo("Olaya", "02", 6.62773, -75.8127);
case 479: return new CityInfo("Oicatá", "36", 5.59548, -73.3082);
case 480: return new CityInfo("Oiba", "26", 6.26387, -73.29876);
case 481: return new CityInfo("Ocaña", "21", 8.23773, -73.35604);
case 482: return new CityInfo("Ocamonte", "26", 6.34001, -73.12205);
case 483: return new CityInfo("Obando", "29", 4.57583, -75.97389);
case 484: return new CityInfo("Nuquí", "11", 5.7125, -77.27083);
case 485: return new CityInfo("Nunchía", "32", 5.63589, -72.19543);
case 486: return new CityInfo("Nuevo Colón", "36", 5.35368, -73.4566);
case 487: return new CityInfo("Nueva Granada", "38", 9.80168, -74.39304);
case 488: return new CityInfo("Nóvita", "11", 4.95511, -76.60526);
case 489: return new CityInfo("Norosí", "35", 8.52692, -74.03736);
case 490: return new CityInfo("Norcasia", "37", 5.57535, -74.88831);
case 491: return new CityInfo("Nocaima", "33", 5.06696, -74.38439);
case 492: return new CityInfo("Nobsa", "36", 5.76978, -72.94099);
case 493: return new CityInfo("Nimaima", "33", 5.12614, -74.38495);
case 494: return new CityInfo("Nilo", "33", 4.30604, -74.62083);
case 495: return new CityInfo("Nemocón", "33", 5.06767, -73.87769);
case 496: return new CityInfo("Neiva", "16", 2.9273, -75.28189);
case 497: return new CityInfo("Neira", "37", 5.1665, -75.52001);
case 498: return new CityInfo("Necoclí", "02", 8.42627, -76.78926);
case 499: return new CityInfo("Nechí", "02", 8.09419, -74.77573);
case 500: return new CityInfo("Natagaima", "28", 3.62057, -75.09415);
case 501: return new CityInfo("Nátaga", "16", 2.54359, -75.80852);
case 502: return new CityInfo("Nariño", "02", 5.60893, -75.17656);
case 503: return new CityInfo("Nariño", "33", 4.39781, -74.82731);
case 504: return new CityInfo("Nariño", "20", 1.28995, -77.35721);
case 505: return new CityInfo("Muzo", "36", 5.53528, -74.10778);
case 506: return new CityInfo("Mutiscua", "21", 7.30061, -72.74667);
case 507: return new CityInfo("Mutatá", "02", 7.24407, -76.43564);
case 508: return new CityInfo("Murindó", "02", 6.98057, -76.82119);
case 509: return new CityInfo("Murillo", "28", 4.87393, -75.17151);
case 510: return new CityInfo("Mountain", "25", 13.36667, -81.36667);
case 511: return new CityInfo("Motavita", "36", 5.57655, -73.36696);
case 512: return new CityInfo("Mosquera", "33", 4.70592, -74.23021);
case 513: return new CityInfo("Mosquera", "20", 2.50861, -78.4511);
case 514: return new CityInfo("Morroa", "27", 9.33348, -75.30542);
case 515: return new CityInfo("Morelia", "08", 1.48747, -75.72581);
case 516: return new CityInfo("Morales", "35", 8.2752, -73.86884);
case 517: return new CityInfo("Montería", "12", 8.74798, -75.88143);
case 518: return new CityInfo("Montenegro", "23", 4.56639, -75.75111);
case 519: return new CityInfo("Montelíbano", "12", 7.97917, -75.4202);
case 520: return new CityInfo("Montecristo", "35", 8.2971, -74.4733);
case 521: return new CityInfo("Montebello", "02", 5.94806, -75.5275);
case 522: return new CityInfo("Moñitos", "12", 9.2455, -76.13017);
case 523: return new CityInfo("Moñitos", "12", 8.25, -76.05);
case 524: return new CityInfo("Moniquirá", "36", 5.87638, -73.57284);
case 525: return new CityInfo("Monguí", "36", 5.72151, -72.84908);
case 526: return new CityInfo("Mongua", "36", 5.75084, -72.80339);
case 527: return new CityInfo("Mompós", "35", 9.24194, -74.42667);
case 528: return new CityInfo("Momil", "12", 9.23767, -75.67489);
case 529: return new CityInfo("Molagavita", "26", 6.67315, -72.80875);
case 530: return new CityInfo("Mogotes", "26", 6.47559, -72.97046);
case 531: return new CityInfo("Mocoa", "22", 1.15284, -76.65208);
case 532: return new CityInfo("Mitú", "30", 1.25778, -70.23472);
case 533: return new CityInfo("Mistrató", "24", 5.29622, -75.8839);
case 534: return new CityInfo("Miranda", "09", 3.25283, -76.22924);
case 535: return new CityInfo("Miraflores", "36", 5.19608, -73.14504);
case 536: return new CityInfo("Miraflores", "14", 1.33667, -71.95111);
case 537: return new CityInfo("Milán", "08", 1.29034, -75.50757);
case 538: return new CityInfo("Mercaderes", "09", 1.80175, -77.17032);
case 539: return new CityInfo("Melgar", "28", 4.20475, -74.64075);
case 540: return new CityInfo("Medina", "33", 4.51005, -73.34982);
case 541: return new CityInfo("Medellín", "02", 6.25184, -75.56359);
case 542: return new CityInfo("Matanza", "26", 7.32233, -73.01516);
case 543: return new CityInfo("Marulanda", "37", 5.28393, -75.26016);
case 544: return new CityInfo("Marsella", "24", 4.93722, -75.73778);
case 545: return new CityInfo("Marquetalia", "37", 5.29659, -75.05496);
case 546: return new CityInfo("Marmato", "37", 5.47501, -75.6004);
case 547: return new CityInfo("San Sebastián de Mariquita", "28", 5.19889, -74.89295);
case 548: return new CityInfo("Maripí", "36", 5.55194, -74.00861);
case 549: return new CityInfo("Marinilla", "02", 6.17358, -75.33621);
case 550: return new CityInfo("María la Baja", "35", 9.9832, -75.30155);
case 551: return new CityInfo("Margarita", "35", 9.15596, -74.26618);
case 552: return new CityInfo("Manzanares", "37", 5.25397, -75.15403);
case 553: return new CityInfo("Manta", "33", 5.00864, -73.54115);
case 554: return new CityInfo("Manizales", "37", 5.06889, -75.51738);
case 555: return new CityInfo("Maní", "32", 4.81638, -72.27946);
case 556: return new CityInfo("Manaure", "17", 11.77505, -72.44447);
case 557: return new CityInfo("Manatí", "04", 10.44589, -74.95869);
case 558: return new CityInfo("Managrú", "11", 5.33653, -76.72756);
case 559: return new CityInfo("Malambo", "04", 10.85953, -74.77386);
case 560: return new CityInfo("Málaga", "26", 6.69903, -72.73233);
case 561: return new CityInfo("Majagual", "27", 8.54119, -74.62942);
case 562: return new CityInfo("Maicao", "17", 11.37837, -72.2395);
case 563: return new CityInfo("Mahates", "35", 10.23293, -75.18985);
case 564: return new CityInfo("Magangué", "35", 9.24202, -74.75467);
case 565: return new CityInfo("Madrid", "33", 4.73245, -74.26419);
case 566: return new CityInfo("Machetá", "33", 5.08154, -73.60761);
case 567: return new CityInfo("Maceo", "02", 6.55196, -74.78741);
case 568: return new CityInfo("Macaravita", "26", 6.50567, -72.59299);
case 569: return new CityInfo("Macanal", "36", 4.97214, -73.31959);
case 570: return new CityInfo("Luruaco", "04", 10.61712, -75.15146);
case 571: return new CityInfo("Lourdes", "21", 7.94411, -72.83253);
case 572: return new CityInfo("Los Santos", "26", 6.75343, -73.10473);
case 573: return new CityInfo("Los Patios", "21", 7.83793, -72.5037);
case 574: return new CityInfo("Los Palmitos", "27", 9.37899, -75.26769);
case 575: return new CityInfo("Los Córdobas", "12", 8.89403, -76.35455);
case 576: return new CityInfo("Lorica", "12", 9.23648, -75.8135);
case 577: return new CityInfo("López", "09", 2.8454, -77.24791);
case 578: return new CityInfo("López", "09", 2.43333, -76.8);
case 579: return new CityInfo("Lloró", "11", 5.49605, -76.54945);
case 580: return new CityInfo("Linares", "20", 1.35078, -77.52339);
case 581: return new CityInfo("Liborina", "02", 6.6779, -75.81218);
case 582: return new CityInfo("Líbano", "28", 4.9218, -75.06232);
case 583: return new CityInfo("Leticia", "01", -4.21528, -69.94056);
case 584: return new CityInfo("Lérida", "28", 4.86242, -74.90977);
case 585: return new CityInfo("Lenguazaque", "33", 5.30711, -73.71152);
case 586: return new CityInfo("Leiva", "20", 1.93497, -77.30634);
case 587: return new CityInfo("Lebrija", "26", 7.11317, -73.2178);
case 588: return new CityInfo("La Virginia", "24", 4.89972, -75.8825);
case 589: return new CityInfo("La Victoria", "29", 4.52483, -76.03921);
case 590: return new CityInfo("La Vega", "33", 5.00177, -74.34174);
case 591: return new CityInfo("La Vega", "09", 2.00187, -76.7789);
case 592: return new CityInfo("La Uvita", "36", 6.32064, -72.56281);
case 593: return new CityInfo("La Unión", "27", 8.84965, -75.27942);
case 594: return new CityInfo("La Unión", "02", 5.97431, -75.36195);
case 595: return new CityInfo("La Unión", "29", 4.53282, -76.10318);
case 596: return new CityInfo("La Unión", "20", 1.6045, -77.13152);
case 597: return new CityInfo("La Tebaida", "23", 4.45265, -75.78746);
case 598: return new CityInfo("La Sierra", "09", 2.17835, -76.76265);
case 599: return new CityInfo("Ánimas", "11", 5.27784, -76.63082);
case 600: return new CityInfo("La Salina", "32", 6.13162, -72.33841);
case 601: return new CityInfo("La Primavera", "31", 5.49056, -70.40917);
case 602: return new CityInfo("La Playa", "21", 8.21321, -73.23827);
case 603: return new CityInfo("La Plata", "16", 2.39341, -75.89232);
case 604: return new CityInfo("La Pintada", "02", 5.74867, -75.60626);
case 605: return new CityInfo("La Peña", "33", 5.19847, -74.39368);
case 606: return new CityInfo("La Paz", "10", 10.38439, -73.17332);
case 607: return new CityInfo("La Paz", "26", 6.17848, -73.58948);
case 608: return new CityInfo("La Palma", "33", 5.3592, -74.39047);
case 609: return new CityInfo("Landázuri", "26", 6.21826, -73.81121);
case 610: return new CityInfo("La Montañita", "08", 1.48016, -75.43664);
case 611: return new CityInfo("La Mesa", "33", 5.26667, -73.91667);
case 612: return new CityInfo("La Merced", "24", 5.40194, -75.88472);
case 613: return new CityInfo("La Llanada", "20", 1.4731, -77.58024);
case 614: return new CityInfo("La Jagua del Pilar", "17", 10.51061, -73.07178);
case 615: return new CityInfo("La Jagua de Ibirico", "10", 9.56228, -73.33405);
case 616: return new CityInfo("La Gloria", "10", 8.61868, -73.80265);
case 617: return new CityInfo("La Florida", "20", 1.29851, -77.40614);
case 618: return new CityInfo("La Estrella", "02", 6.15769, -75.64317);
case 619: return new CityInfo("La Esperanza", "21", 8.21043, -72.46399);
case 620: return new CityInfo("La Dorada", "37", 5.44783, -74.66311);
case 621: return new CityInfo("La Cumbre", "29", 3.64999, -76.56984);
case 622: return new CityInfo("La Cruz", "20", 1.60221, -76.9713);
case 623: return new CityInfo("La Chamba", "28", 4.02649, -74.86844);
case 624: return new CityInfo("La Celia", "24", 5.00332, -76.00355);
case 625: return new CityInfo("La Ceja", "02", 6.03131, -75.43333);
case 626: return new CityInfo("La Capilla", "36", 5.70493, -73.47527);
case 627: return new CityInfo("La Capilla", "36", 5.0959, -73.44407);
case 628: return new CityInfo("La Calera", "33", 4.72069, -73.96926);
case 629: return new CityInfo("Labranzagrande", "36", 5.56223, -72.57499);
case 630: return new CityInfo("La Belleza", "26", 5.86371, -73.96167);
case 631: return new CityInfo("La Argentina", "16", 2.19762, -75.9799);
case 632: return new CityInfo("Juradó", "11", 7.10421, -77.762);
case 633: return new CityInfo("Junín", "28", 4.78333, -75.01667);
case 634: return new CityInfo("Junín", "33", 4.79027, -73.66011);
case 635: return new CityInfo("Juan de Acosta", "04", 10.8293, -75.03346);
case 636: return new CityInfo("Jordán", "26", 6.733, -73.09588);
case 637: return new CityInfo("Jesús María", "26", 5.87715, -73.78097);
case 638: return new CityInfo("Jerusalén", "33", 4.56309, -74.69519);
case 639: return new CityInfo("Jericó", "36", 6.14592, -72.5708);
case 640: return new CityInfo("Jericó", "02", 5.79211, -75.78601);
case 641: return new CityInfo("Jenesano", "36", 5.38541, -73.36364);
case 642: return new CityInfo("Jardín", "02", 5.59902, -75.81976);
case 643: return new CityInfo("Jamundí", "29", 3.26074, -76.53499);
case 644: return new CityInfo("Jambaló", "09", 2.77762, -76.32444);
case 645: return new CityInfo("Iza", "36", 5.61203, -72.9793);
case 646: return new CityInfo("Ituango", "02", 7.17117, -75.76404);
case 647: return new CityInfo("Itagüí", "02", 6.18461, -75.59913);
case 648: return new CityInfo("Istmina", "11", 5.16054, -76.68397);
case 649: return new CityInfo("Iscuandé", "20", 2.45065, -77.97998);
case 650: return new CityInfo("Íquira", "16", 2.64867, -75.63457);
case 651: return new CityInfo("Ipiales", "20", 0.82501, -77.63966);
case 652: return new CityInfo("Inzá", "09", 2.55452, -76.06722);
case 653: return new CityInfo("Imués", "20", 1.05516, -77.49669);
case 654: return new CityInfo("Iles", "20", 0.9704, -77.52146);
case 655: return new CityInfo("Icononzo", "28", 4.17698, -74.53254);
case 656: return new CityInfo("Ibagué", "28", 4.43889, -75.23222);
case 657: return new CityInfo("Honda", "28", 5.20856, -74.73584);
case 658: return new CityInfo("Hobo", "16", 2.58333, -75.45);
case 659: return new CityInfo("Hispania", "02", 5.79925, -75.90718);
case 660: return new CityInfo("Herveo", "28", 5.08004, -75.17556);
case 661: return new CityInfo("Herrán", "21", 7.50611, -72.48332);
case 662: return new CityInfo("Heliconia", "02", 6.20831, -75.73565);
case 663: return new CityInfo("Municipio Hato Corozal", "32", 6.15676, -71.76372);
case 664: return new CityInfo("Hato", "26", 6.54302, -73.30826);
case 665: return new CityInfo("Hatillo de Loba", "35", 8.95635, -74.07819);
case 666: return new CityInfo("Hacarí", "21", 8.32333, -73.14889);
case 667: return new CityInfo("Gutiérrez", "33", 4.25472, -74.0025);
case 668: return new CityInfo("Güicán", "36", 6.46554, -72.41539);
case 669: return new CityInfo("Güepsa", "26", 6.02505, -73.57313);
case 670: return new CityInfo("Guayatá", "36", 4.96417, -73.4875);
case 671: return new CityInfo("Guayabetal", "33", 4.21472, -73.81719);
case 672: return new CityInfo("Guayabal de Síquima", "33", 4.87739, -74.46744);
case 673: return new CityInfo("Guavatá", "26", 5.95502, -73.70018);
case 674: return new CityInfo("Guática", "24", 5.31569, -75.79826);
case 675: return new CityInfo("Guateque", "36", 5.00619, -73.47274);
case 676: return new CityInfo("Guatavita", "33", 4.93658, -73.83314);
case 677: return new CityInfo("Guataquí", "33", 4.51573, -74.78935);
case 678: return new CityInfo("Guatapé", "02", 6.23429, -75.16335);
case 679: return new CityInfo("Guasca", "33", 4.86601, -73.87748);
case 680: return new CityInfo("Guarne", "02", 6.28046, -75.44354);
case 681: return new CityInfo("Guaranda", "27", 8.46746, -74.53617);
case 682: return new CityInfo("Guapotá", "26", 6.30798, -73.3202);
case 683: return new CityInfo("Guapí", "09", 2.57082, -77.88542);
case 684: return new CityInfo("Guamo", "28", 4.03078, -74.9701);
case 685: return new CityInfo("Guamal", "38", 9.14334, -74.22384);
case 686: return new CityInfo("Guamal", "19", 3.88043, -73.76566);
case 687: return new CityInfo("Gualmatán", "20", 0.91992, -77.56738);
case 688: return new CityInfo("Guaitarilla", "20", 1.13103, -77.54815);
case 689: return new CityInfo("Guaduas", "33", 5.06692, -74.59499);
case 690: return new CityInfo("Guadalupe", "02", 6.81449, -75.24063);
case 691: return new CityInfo("Guadalupe", "26", 6.2464, -73.41833);
case 692: return new CityInfo("Guadalupe", "16", 2.0248, -75.75589);
case 693: return new CityInfo("Guachucal", "20", 0.96093, -77.73161);
case 694: return new CityInfo("Guachetá", "33", 5.38425, -73.68617);
case 695: return new CityInfo("Guachené", "09", 3.13333, -76.3927);
case 696: return new CityInfo("Guachavés", "20", 1.2224, -77.67766);
case 697: return new CityInfo("Guacarí", "29", 3.76383, -76.33292);
case 698: return new CityInfo("Guacamayas", "36", 6.46243, -72.50465);
case 699: return new CityInfo("Guaca", "26", 6.87621, -72.85594);
case 700: return new CityInfo("Granada", "02", 6.14353, -75.18532);
case 701: return new CityInfo("Granada", "33", 5.06667, -74.56667);
case 702: return new CityInfo("Granada", "33", 4.51997, -74.35261);
case 703: return new CityInfo("Granada", "19", 3.54625, -73.70687);
case 704: return new CityInfo("Gramalote", "21", 7.88752, -72.79749);
case 705: return new CityInfo("González", "10", 8.38944, -73.37989);
case 706: return new CityInfo("Gómez Plata", "02", 6.68178, -75.21907);
case 707: return new CityInfo("Girón", "26", 7.0682, -73.16981);
case 708: return new CityInfo("Girardota", "02", 6.37747, -75.44883);
case 709: return new CityInfo("Girardot City", "33", 4.30079, -74.80754);
case 710: return new CityInfo("Giraldo", "02", 6.68013, -75.95259);
case 711: return new CityInfo("Ginebra", "29", 3.72461, -76.26675);
case 712: return new CityInfo("Gigante", "16", 2.38678, -75.54736);
case 713: return new CityInfo("Génova", "23", 4.31667, -75.76667);
case 714: return new CityInfo("Génova", "20", 1.64367, -77.01924);
case 715: return new CityInfo("Garzón", "16", 2.19593, -75.62777);
case 716: return new CityInfo("Garagoa", "36", 5.08236, -73.36334);
case 717: return new CityInfo("Gámeza", "36", 5.80263, -72.80586);
case 718: return new CityInfo("Gámbita", "26", 5.94597, -73.34435);
case 719: return new CityInfo("Gamarra", "10", 8.32279, -73.74268);
case 720: return new CityInfo("Gama", "33", 4.76288, -73.61091);
case 721: return new CityInfo("Galeras", "27", 9.16095, -75.04811);
case 722: return new CityInfo("Galapa", "04", 10.89686, -74.886);
case 723: return new CityInfo("Galán", "26", 6.63781, -73.28878);
case 724: return new CityInfo("Gaitania", "28", 3.15, -75.81667);
case 725: return new CityInfo("Gachantivá", "36", 5.75662, -73.5395);
case 726: return new CityInfo("Gachancipá", "33", 4.99111, -73.87154);
case 727: return new CityInfo("Gachalá", "33", 4.69244, -73.52042);
case 728: return new CityInfo("Fusagasugá", "33", 4.33646, -74.36378);
case 729: return new CityInfo("Fúquene", "33", 5.40425, -73.7964);
case 730: return new CityInfo("Funza", "33", 4.71638, -74.21195);
case 731: return new CityInfo("Funes", "20", 1.00075, -77.44918);
case 732: return new CityInfo("Fundación", "38", 10.52066, -74.18504);
case 733: return new CityInfo("Fuente de Oro", "19", 3.46263, -73.62162);
case 734: return new CityInfo("Frontino", "02", 6.77133, -76.13324);
case 735: return new CityInfo("Frías", "28", 5.02973, -75.0086);
case 736: return new CityInfo("Fresno", "28", 5.15264, -75.03624);
case 737: return new CityInfo("Fosca", "33", 4.33916, -73.93852);
case 738: return new CityInfo("Fortul", "03", 6.79261, -71.77596);
case 739: return new CityInfo("Fonseca", "17", 10.88606, -72.8487);
case 740: return new CityInfo("Fómeque", "33", 4.48797, -73.89749);
case 741: return new CityInfo("Floridablanca", "26", 7.06222, -73.08644);
case 742: return new CityInfo("Florida", "29", 3.3223, -76.2348);
case 743: return new CityInfo("Florián", "26", 5.80487, -73.97029);
case 744: return new CityInfo("Floresta", "36", 5.85903, -72.91882);
case 745: return new CityInfo("Florencia", "09", 1.68318, -77.07331);
case 746: return new CityInfo("Florencia", "08", 1.61438, -75.60623);
case 747: return new CityInfo("Flandes", "28", 4.29005, -74.81612);
case 748: return new CityInfo("Firavitoba", "36", 5.66885, -72.99289);
case 749: return new CityInfo("Filandia", "23", 4.67472, -75.65833);
case 750: return new CityInfo("Filadelfia", "37", 5.29606, -75.5612);
case 751: return new CityInfo("Falan", "28", 5.12383, -74.95181);
case 752: return new CityInfo("Facatativá", "33", 4.81367, -74.35453);
case 753: return new CityInfo("Espinal", "28", 4.14924, -74.88429);
case 754: return new CityInfo("Envigado", "02", 6.17591, -75.59174);
case 755: return new CityInfo("Entrerríos", "02", 6.5654, -75.5169);
case 756: return new CityInfo("Enciso", "26", 6.66808, -72.69986);
case 757: return new CityInfo("Encino", "26", 6.13735, -73.09847);
case 758: return new CityInfo("El Zulia", "21", 7.93248, -72.60125);
case 759: return new CityInfo("El Tambo", "09", 2.45199, -76.81029);
case 760: return new CityInfo("El Tambo", "20", 1.40785, -77.39218);
case 761: return new CityInfo("El Tablón", "20", 1.42717, -77.09693);
case 762: return new CityInfo("El Rosario", "20", 1.74404, -77.33481);
case 763: return new CityInfo("El Rosal", "33", 4.85314, -74.25996);
case 764: return new CityInfo("El Roble", "27", 9.10193, -75.19508);
case 765: return new CityInfo("El Retén", "38", 10.61135, -74.26824);
case 766: return new CityInfo("El Piñón", "38", 10.40283, -74.82415);
case 767: return new CityInfo("El Peñón", "35", 8.98691, -73.94697);
case 768: return new CityInfo("El Peñón", "26", 6.55, -72.83333);
case 769: return new CityInfo("El Peñón", "26", 6.05489, -73.81519);
case 770: return new CityInfo("El Peñón", "33", 5.25264, -74.29069);
case 771: return new CityInfo("El Peñol", "20", 1.45365, -77.44017);
case 772: return new CityInfo("El Paujíl", "08", 1.57006, -75.32863);
case 773: return new CityInfo("El Paso", "10", 9.65724, -73.74685);
case 774: return new CityInfo("El Molino", "17", 10.65296, -72.92461);
case 775: return new CityInfo("Elías", "16", 2.0117, -75.93968);
case 776: return new CityInfo("El Guamo", "35", 10.03155, -74.97612);
case 777: return new CityInfo("El Guacamayo", "26", 6.24518, -73.49655);
case 778: return new CityInfo("El Espino", "36", 6.48277, -72.49718);
case 779: return new CityInfo("El Dovio", "29", 4.5079, -76.23619);
case 780: return new CityInfo("El Doncello", "08", 1.67817, -75.28466);
case 781: return new CityInfo("El Difícil", "38", 9.84975, -74.23627);
case 782: return new CityInfo("El Copey", "10", 10.15031, -73.9614);
case 783: return new CityInfo("El Cocuy", "36", 6.41151, -72.44876);
case 784: return new CityInfo("El Charco", "20", 2.47926, -78.10972);
case 785: return new CityInfo("El Cerrito", "29", 3.68549, -76.31372);
case 786: return new CityInfo("El Castillo", "19", 3.56363, -73.79488);
case 787: return new CityInfo("El Carmen de Bolívar", "35", 9.7174, -75.12023);
case 788: return new CityInfo("El Carmen", "21", 8.51064, -73.44776);
case 789: return new CityInfo("El Carmen de Chucurí", "26", 6.69736, -73.51117);
case 790: return new CityInfo("El Carmen", "11", 5.88778, -75.16417);
case 791: return new CityInfo("El Calvario", "19", 4.35342, -73.71147);
case 792: return new CityInfo("El Cairo", "29", 4.76279, -76.221);
case 793: return new CityInfo("El Bordo", "09", 2.11696, -76.98214);
case 794: return new CityInfo("El Banco", "38", 9.00114, -73.97581);
case 795: return new CityInfo("El Bagre", "02", 7.60347, -74.80951);
case 796: return new CityInfo("Algarrobo", "38", 10.18618, -74.06085);
case 797: return new CityInfo("El Águila", "29", 4.91345, -76.04004);
case 798: return new CityInfo("Ebéjico", "02", 6.32598, -75.76835);
case 799: return new CityInfo("Durania", "21", 7.71307, -72.65759);
case 800: return new CityInfo("Duitama", "36", 5.8245, -73.03408);
case 801: return new CityInfo("Dosquebradas", "24", 4.83916, -75.66727);
case 802: return new CityInfo("Donmatías", "02", 6.48569, -75.39496);
case 803: return new CityInfo("Doima", "28", 4.42692, -74.97548);
case 804: return new CityInfo("Distracción", "17", 10.89784, -72.88666);
case 805: return new CityInfo("Dibulla", "17", 11.27251, -73.30911);
case 806: return new CityInfo("Darien", "29", 3.93135, -76.48481);
case 807: return new CityInfo("Dagua", "29", 3.65685, -76.68859);
case 808: return new CityInfo("Dabeiba", "02", 7.00017, -76.26915);
case 809: return new CityInfo("Curumaní", "10", 9.19992, -73.54274);
case 810: return new CityInfo("Curití", "26", 6.60519, -73.06809);
case 811: return new CityInfo("Cunday", "28", 4.06004, -74.69212);
case 812: return new CityInfo("Cumbitara", "20", 1.64786, -77.57819);
case 813: return new CityInfo("Cumbal", "20", 0.90875, -77.79145);
case 814: return new CityInfo("Cumaribo", "31", 4.44552, -69.79897);
case 815: return new CityInfo("Cumaral", "19", 4.2708, -73.48669);
case 816: return new CityInfo("Cuítiva", "36", 5.58007, -72.96687);
case 817: return new CityInfo("Cucutilla", "21", 7.53941, -72.77238);
case 818: return new CityInfo("Cúcuta", "21", 7.89391, -72.50782);
case 819: return new CityInfo("Cucunubá", "33", 5.24958, -73.7661);
case 820: return new CityInfo("Cucaita", "36", 5.54373, -73.45433);
case 821: return new CityInfo("Cubará", "36", 7.00578, -72.10568);
case 822: return new CityInfo("Cruces de Anorí", "02", 7.18333, -75.06667);
case 823: return new CityInfo("Cravo Norte", "03", 6.30173, -70.20415);
case 824: return new CityInfo("Coyaima", "28", 3.79936, -75.19467);
case 825: return new CityInfo("Coveñas", "27", 9.40254, -75.68029);
case 826: return new CityInfo("Cotorra", "12", 9.03886, -75.78969);
case 827: return new CityInfo("Cota", "33", 4.80938, -74.098);
case 828: return new CityInfo("Corrales", "36", 5.82968, -72.84332);
case 829: return new CityInfo("Corozal", "27", 9.31847, -75.2933);
case 830: return new CityInfo("Coromoro", "26", 6.29461, -73.04022);
case 831: return new CityInfo("Corinto", "09", 3.17301, -76.26275);
case 832: return new CityInfo("Córdoba", "35", 9.58612, -74.82705);
case 833: return new CityInfo("Córdoba", "23", 4.39158, -75.68723);
case 834: return new CityInfo("Córdoba", "20", 0.85362, -77.51817);
case 835: return new CityInfo("Coper", "36", 5.47681, -74.04416);
case 836: return new CityInfo("Copacabana", "02", 6.34633, -75.50888);
case 837: return new CityInfo("Convención", "21", 8.46894, -73.33765);
case 838: return new CityInfo("Contratación", "26", 6.29005, -73.47354);
case 839: return new CityInfo("Contadero", "20", 0.90841, -77.5477);
case 840: return new CityInfo("Consacá", "20", 1.20805, -77.46548);
case 841: return new CityInfo("Confines", "26", 6.35625, -73.24131);
case 842: return new CityInfo("Condoto", "11", 5.09351, -76.64973);
case 843: return new CityInfo("Concordia", "38", 10.25757, -74.83333);
case 844: return new CityInfo("Concordia", "38", 9.83545, -74.45548);
case 845: return new CityInfo("Concordia", "02", 6.04639, -75.90705);
case 846: return new CityInfo("Concepción", "26", 6.76619, -72.694);
case 847: return new CityInfo("Concepción", "02", 6.39408, -75.2583);
case 848: return new CityInfo("Combita", "36", 5.63333, -73.31667);
case 849: return new CityInfo("Cómbita", "36", 5.63312, -73.32398);
case 850: return new CityInfo("Colosó", "27", 9.49477, -75.35271);
case 851: return new CityInfo("Colón", "22", 1.19034, -76.97369);
case 852: return new CityInfo("Colombia", "16", 3.37606, -74.8015);
case 853: return new CityInfo("Cogua", "33", 5.06051, -73.97925);
case 854: return new CityInfo("Coello", "28", 4.40306, -75.29417);
case 855: return new CityInfo("Coello", "28", 4.28908, -74.89825);
case 856: return new CityInfo("Cocorná", "02", 6.0573, -75.18524);
case 857: return new CityInfo("Coconuco", "09", 2.34249, -76.49581);
case 858: return new CityInfo("Clemencia", "35", 10.56645, -75.32499);
case 859: return new CityInfo("Cisneros", "02", 6.53833, -75.08861);
case 860: return new CityInfo("Circasia", "23", 4.61889, -75.63583);
case 861: return new CityInfo("Cimitarra", "26", 6.31419, -73.94968);
case 862: return new CityInfo("Ciénega", "36", 5.40867, -73.29572);
case 863: return new CityInfo("Ciénaga de Oro", "12", 8.87443, -75.62028);
case 864: return new CityInfo("Ciénaga", "38", 11.00703, -74.24765);
case 865: return new CityInfo("Cicuco", "35", 9.27756, -74.64312);
case 866: return new CityInfo("Chocontá", "33", 5.14468, -73.68578);
case 867: return new CityInfo("Choachí", "33", 4.52897, -73.92273);
case 868: return new CityInfo("Chivolo", "38", 10.02502, -74.62279);
case 869: return new CityInfo("Chivatá", "36", 5.55823, -73.28198);
case 870: return new CityInfo("Chitagá", "21", 7.13781, -72.66456);
case 871: return new CityInfo("Chita", "36", 6.19053, -72.47588);
case 872: return new CityInfo("Chiscas", "36", 6.55642, -72.50378);
case 873: return new CityInfo("Chiriguaná", "10", 9.36238, -73.60313);
case 874: return new CityInfo("Chíquiza", "36", 5.60412, -73.48518);
case 875: return new CityInfo("Chiquinquirá", "36", 5.61637, -73.81748);
case 876: return new CityInfo("Chipatá", "26", 6.06196, -73.63718);
case 877: return new CityInfo("Chipaque", "33", 4.4425, -74.04417);
case 878: return new CityInfo("Chinú", "12", 9.10569, -75.39812);
case 879: return new CityInfo("Chinchiná", "37", 4.9825, -75.60361);
case 880: return new CityInfo("Chinavita", "36", 5.16723, -73.36823);
case 881: return new CityInfo("Chinácota", "21", 7.60731, -72.60108);
case 882: return new CityInfo("Chimichagua", "10", 9.25778, -73.81228);
case 883: return new CityInfo("Chimá", "12", 9.14893, -75.62841);
case 884: return new CityInfo("Chima", "26", 6.34431, -73.37393);
case 885: return new CityInfo("Chigorodó", "02", 7.66638, -76.68106);
case 886: return new CityInfo("Chicoral", "28", 4.21536, -74.98189);
case 887: return new CityInfo("Chía", "33", 4.85876, -74.05866);
case 888: return new CityInfo("Charta", "26", 7.28025, -72.96782);
case 889: return new CityInfo("Charalá", "26", 6.28581, -73.14722);
case 890: return new CityInfo("Chaparral", "28", 3.72315, -75.48316);
case 891: return new CityInfo("Chámeza", "32", 5.21421, -72.86948);
case 892: return new CityInfo("Chalán", "27", 9.54765, -75.31128);
case 893: return new CityInfo("Chaguaní", "33", 4.94829, -74.59392);
case 894: return new CityInfo("Chachagüí", "20", 1.35943, -77.28367);
case 895: return new CityInfo("Cértegui", "11", 5.37073, -76.6044);
case 896: return new CityInfo("Cerro de San Antonio", "38", 10.32585, -74.86933);
case 897: return new CityInfo("Cerrito", "26", 6.84315, -72.69404);
case 898: return new CityInfo("Cerinza", "36", 5.95568, -72.94783);
case 899: return new CityInfo("Cereté", "12", 8.88479, -75.79052);
case 900: return new CityInfo("Cepitá", "26", 6.75427, -72.9744);
case 901: return new CityInfo("Caucasia", "02", 7.98654, -75.19349);
case 902: return new CityInfo("Castilla La Nueva", "19", 3.82722, -73.68831);
case 903: return new CityInfo("Casabianca", "28", 5.07959, -75.12059);
case 904: return new CityInfo("Cartago", "29", 4.74639, -75.91167);
case 905: return new CityInfo("Cartago", "20", 1.55151, -77.11948);
case 906: return new CityInfo("Cartagena", "35", 10.39972, -75.51444);
case 907: return new CityInfo("Carolina", "02", 6.72439, -75.28168);
case 908: return new CityInfo("Carmen de Viboral", "02", 6.08236, -75.33509);
case 909: return new CityInfo("Carmen de Carupa", "33", 5.34862, -73.90168);
case 910: return new CityInfo("Carmen de Apicalá", "28", 4.14725, -74.72014);
case 911: return new CityInfo("Carlosama", "20", 0.86292, -77.72734);
case 912: return new CityInfo("Carcasí", "26", 6.62711, -72.62625);
case 913: return new CityInfo("Caramanta", "02", 5.54782, -75.64368);
case 914: return new CityInfo("Caracolí", "02", 6.4092, -74.75715);
case 915: return new CityInfo("Cáqueza", "33", 4.40569, -73.94683);
case 916: return new CityInfo("Capitanejo", "26", 6.52881, -72.69595);
case 917: return new CityInfo("Caparrapí", "33", 5.34644, -74.49147);
case 918: return new CityInfo("Cantagallo", "35", 7.37926, -73.9155);
case 919: return new CityInfo("Candelaria", "04", 10.45912, -74.8797);
case 920: return new CityInfo("Candelaria", "29", 3.40671, -76.34819);
case 921: return new CityInfo("Cañasgordas", "02", 6.74989, -76.02539);
case 922: return new CityInfo("Canalete", "12", 8.78558, -76.24065);
case 923: return new CityInfo("Campohermoso", "36", 5.03132, -73.10327);
case 924: return new CityInfo("Campo de la Cruz", "04", 10.37808, -74.88356);
case 925: return new CityInfo("Campoalegre", "16", 2.68489, -75.32311);
case 926: return new CityInfo("Campamento", "02", 6.9792, -75.29724);
case 927: return new CityInfo("Caloto", "09", 3.03586, -76.40788);
case 928: return new CityInfo("Calimita", "29", 3.91667, -76.5);
case 929: return new CityInfo("California", "26", 7.34776, -72.9458);
case 930: return new CityInfo("Cali", "29", 3.43722, -76.5225);
case 931: return new CityInfo("Caldono", "09", 2.79739, -76.48316);
case 932: return new CityInfo("Caldas", "02", 6.09106, -75.63569);
case 933: return new CityInfo("Caldas", "36", 5.55456, -73.86567);
case 934: return new CityInfo("Calarcá", "23", 4.52949, -75.64091);
case 935: return new CityInfo("Calamar", "35", 10.25271, -74.91574);
case 936: return new CityInfo("Calamar", "14", 1.9596, -72.65315);
case 937: return new CityInfo("Cajicá", "33", 4.91857, -74.02799);
case 938: return new CityInfo("Cajibío", "09", 2.62271, -76.57039);
case 939: return new CityInfo("Cajamarca", "28", 4.44234, -75.42874);
case 940: return new CityInfo("Caimito", "27", 8.78962, -75.11686);
case 941: return new CityInfo("Caicedonia", "29", 4.3324, -75.82665);
case 942: return new CityInfo("Caicedo", "02", 6.40511, -75.98255);
case 943: return new CityInfo("Cácota", "21", 7.26787, -72.64197);
case 944: return new CityInfo("Cáchira", "21", 7.74104, -73.0483);
case 945: return new CityInfo("Cachipay", "33", 5.26667, -74.56667);
case 946: return new CityInfo("Cachipay", "33", 4.73035, -74.43663);
case 947: return new CityInfo("Cáceres", "02", 7.58078, -75.34842);
case 948: return new CityInfo("Cabuyaro", "19", 4.2817, -72.79399);
case 949: return new CityInfo("Cabrera", "26", 6.5928, -73.2465);
case 950: return new CityInfo("Cabrera", "33", 3.98598, -74.48283);
case 951: return new CityInfo("Busbanzá", "36", 5.83047, -72.88419);
case 952: return new CityInfo("Bugalagrande", "29", 4.21207, -76.15564);
case 953: return new CityInfo("Guadalajara de Buga", "29", 3.90089, -76.29783);
case 954: return new CityInfo("Buesaco", "20", 1.38364, -77.15622);
case 955: return new CityInfo("Buenos Aires", "09", 3.01397, -76.64612);
case 956: return new CityInfo("Buenavista", "27", 9.31939, -74.97358);
case 957: return new CityInfo("Buenavista", "38", 9.21433, -74.31363);
case 958: return new CityInfo("Buenavista", "12", 9.04963, -76.0028);
case 959: return new CityInfo("Buenavista", "12", 8.22245, -75.48173);
case 960: return new CityInfo("Buenavista", "36", 5.51377, -73.94913);
case 961: return new CityInfo("Buenavista", "23", 4.35969, -75.73888);
case 962: return new CityInfo("Buenaventura", "29", 3.8801, -77.03116);
case 963: return new CityInfo("Buenaventura", "29", 3.58333, -77);
case 964: return new CityInfo("Bucarasica", "21", 8.04096, -72.86538);
case 965: return new CityInfo("Bucaramanga", "26", 7.12539, -73.1198);
case 966: return new CityInfo("Briceño", "02", 7.11096, -75.55152);
case 967: return new CityInfo("Briceño", "36", 5.68822, -73.91784);
case 968: return new CityInfo("Providencia", "20", 1.23907, -77.59721);
case 969: return new CityInfo("Boyacá", "36", 5.45371, -73.3625);
case 970: return new CityInfo("Bosconia", "10", 9.97106, -73.88817);
case 971: return new CityInfo("Bolívar", "26", 5.9893, -73.77058);
case 972: return new CityInfo("Bolívar", "29", 4.3387, -76.18342);
case 973: return new CityInfo("Bolívar", "09", 1.83994, -76.96889);
case 974: return new CityInfo("Bojacá", "33", 4.73176, -74.34129);
case 975: return new CityInfo("Bogotá", "34", 4.60971, -74.08175);
case 976: return new CityInfo("Bochalema", "21", 7.61095, -72.64773);
case 977: return new CityInfo("Bocas de Satinga", "20", 2.34814, -78.32571);
case 978: return new CityInfo("Curbaradó", "11", 7.15778, -76.97111);
case 979: return new CityInfo("Boavita", "36", 6.33031, -72.58505);
case 980: return new CityInfo("Bituima", "33", 4.87252, -74.53925);
case 981: return new CityInfo("Betulia", "26", 6.90069, -73.28347);
case 982: return new CityInfo("Betulia", "02", 6.11284, -75.98378);
case 983: return new CityInfo("Betéitiva", "36", 5.91102, -72.80926);
case 984: return new CityInfo("Beté", "11", 5.99458, -76.7812);
case 985: return new CityInfo("Betania", "02", 5.74601, -75.97765);
case 986: return new CityInfo("Arboleda", "20", 1.49766, -77.13587);
case 987: return new CityInfo("Berbeo", "36", 5.22675, -73.12608);
case 988: return new CityInfo("Beltrán", "33", 4.80165, -74.74177);
case 989: return new CityInfo("Belmira", "02", 6.60508, -75.66619);
case 990: return new CityInfo("Bello", "02", 6.33732, -75.55795);
case 991: return new CityInfo("Belén de Umbría", "24", 5.20087, -75.86865);
case 992: return new CityInfo("Belén de los Andaquíes", "08", 1.41828, -75.87753);
case 993: return new CityInfo("Belén", "36", 5.98892, -72.91254);
case 994: return new CityInfo("Belén", "20", 1.59477, -77.05408);
case 995: return new CityInfo("Belalcázar", "37", 4.99528, -75.81278);
case 996: return new CityInfo("Becerril", "10", 9.70413, -73.2793);
case 997: return new CityInfo("Barranquilla", "04", 10.96854, -74.78132);
case 998: return new CityInfo("Barranco de Loba", "35", 8.94597, -74.10647);
case 999: return new CityInfo("Barrancas", "17", 10.95672, -72.79456);
case 1000: return new CityInfo("Barranca de Upía", "19", 4.56963, -72.96676);
case 1001: return new CityInfo("Barrancabermeja", "26", 7.06528, -73.85472);
case 1002: return new CityInfo("Barichara", "26", 6.63572, -73.22282);
case 1003: return new CityInfo("Barbosa", "02", 6.43809, -75.33136);
case 1004: return new CityInfo("Barbosa", "26", 5.93168, -73.61507);
case 1005: return new CityInfo("Barbacoas", "20", 1.67154, -78.13978);
case 1006: return new CityInfo("Baraya", "16", 3.15333, -75.05306);
case 1007: return new CityInfo("Baranoa", "04", 10.79408, -74.9164);
case 1008: return new CityInfo("Balboa", "24", 4.94985, -75.95826);
case 1009: return new CityInfo("Balboa", "09", 2.04183, -77.21646);
case 1010: return new CityInfo("Bahía Solano", "11", 6.22622, -77.40439);
case 1011: return new CityInfo("Bagadó", "11", 5.41164, -76.4152);
case 1012: return new CityInfo("Ayapel", "12", 8.31372, -75.13982);
case 1013: return new CityInfo("Ataco", "28", 3.59147, -75.38178);
case 1014: return new CityInfo("Astrea", "10", 9.49828, -73.97591);
case 1015: return new CityInfo("Arroyohondo", "35", 10.2522, -75.0198);
case 1016: return new CityInfo("Guayabal", "28", 5.03103, -74.88683);
case 1017: return new CityInfo("Armenia", "02", 6.15639, -75.78722);
case 1018: return new CityInfo("Armenia", "23", 4.53389, -75.68111);
case 1019: return new CityInfo("Arjona", "35", 10.25444, -75.34389);
case 1020: return new CityInfo("Ariguaní", "10", 10.25, -74);
case 1021: return new CityInfo("Argelia", "02", 5.73127, -75.14257);
case 1022: return new CityInfo("Argelia", "29", 4.72342, -76.11909);
case 1023: return new CityInfo("Argelia", "09", 2.25563, -77.24876);
case 1024: return new CityInfo("Arenal", "35", 8.45928, -73.94331);
case 1025: return new CityInfo("Arcabuco", "36", 5.75463, -73.43669);
case 1026: return new CityInfo("Arboletes", "02", 8.85051, -76.42694);
case 1027: return new CityInfo("Arboledas", "21", 7.64233, -72.79944);
case 1028: return new CityInfo("Arbeláez", "33", 4.27254, -74.41513);
case 1029: return new CityInfo("Arauquita", "03", 7.02917, -71.42806);
case 1030: return new CityInfo("Arauca", "03", 7.08471, -70.75908);
case 1031: return new CityInfo("Aratoca", "26", 6.69432, -73.01868);
case 1032: return new CityInfo("Aranzazu", "37", 5.27123, -75.49044);
case 1033: return new CityInfo("Aracataca", "38", 10.59181, -74.18983);
case 1034: return new CityInfo("Aquitania", "36", 5.51858, -72.88387);
case 1035: return new CityInfo("Apía", "24", 5.10658, -75.94244);
case 1036: return new CityInfo("Apartadó", "02", 7.88299, -76.62587);
case 1037: return new CityInfo("Anzoátegui", "28", 4.63087, -75.0946);
case 1038: return new CityInfo("Anzá", "02", 6.30322, -75.85381);
case 1039: return new CityInfo("Santa Fe de Antioquia", "02", 6.55687, -75.82806);
case 1040: return new CityInfo("Ansermanuevo", "29", 4.79722, -75.995);
case 1041: return new CityInfo("Anserma", "24", 5.33278, -75.79111);
case 1042: return new CityInfo("Anorí", "02", 7.07273, -75.14768);
case 1043: return new CityInfo("Anolaima", "33", 4.83362, -74.4995);
case 1044: return new CityInfo("Angostura", "02", 6.88508, -75.33467);
case 1045: return new CityInfo("Angelópolis", "02", 6.11072, -75.70923);
case 1046: return new CityInfo("Andes", "02", 5.6561, -75.87877);
case 1047: return new CityInfo("Andalucía", "29", 4.17061, -76.16641);
case 1048: return new CityInfo("Ancuya", "20", 1.2633, -77.51376);
case 1049: return new CityInfo("Anapoima", "33", 4.55099, -74.53517);
case 1050: return new CityInfo("Anaime", "28", 4.39639, -75.445);
case 1051: return new CityInfo("Ambalema", "28", 4.78405, -74.76268);
case 1052: return new CityInfo("Amalfi", "02", 6.91016, -75.07764);
case 1053: return new CityInfo("Amagá", "02", 6.04001, -75.70315);
case 1054: return new CityInfo("Alvarado", "28", 4.56826, -74.9523);
case 1055: return new CityInfo("Altamira", "16", 2.06278, -75.78722);
case 1056: return new CityInfo("Almeida", "36", 4.97083, -73.37972);
case 1057: return new CityInfo("Almaguer", "09", 1.91472, -76.85482);
case 1058: return new CityInfo("Algeciras", "16", 2.52385, -75.31733);
case 1059: return new CityInfo("Algarrobo", "38", 10.18694, -74.57528);
case 1060: return new CityInfo("Alejandría", "02", 6.37745, -75.14065);
case 1061: return new CityInfo("Aldana", "20", 0.88283, -77.70103);
case 1062: return new CityInfo("Alcalá", "29", 4.67472, -75.7825);
case 1063: return new CityInfo("Albania", "17", 11.16099, -72.59238);
case 1064: return new CityInfo("Albania", "26", 5.75894, -73.91376);
case 1065: return new CityInfo("Albania", "08", 1.32866, -75.87824);
case 1066: return new CityInfo("Albán", "33", 4.87661, -74.43768);
case 1067: return new CityInfo("Aipe", "16", 3.22222, -75.23667);
case 1068: return new CityInfo("Aguazul", "32", 5.17282, -72.54706);
case 1069: return new CityInfo("Agua de Dios", "33", 4.37648, -74.66995);
case 1070: return new CityInfo("Aguadas", "37", 5.61161, -75.45624);
case 1071: return new CityInfo("Aguachica", "10", 8.30844, -73.6166);
case 1072: return new CityInfo("Agrado", "16", 2.25725, -75.77142);
case 1073: return new CityInfo("Achí", "35", 8.5695, -74.55715);
case 1074: return new CityInfo("Acevedo", "16", 1.80464, -75.89036);
case 1075: return new CityInfo("Acandí", "11", 8.51158, -77.27719);
case 1076: return new CityInfo("Acacías", "19", 3.98695, -73.75797);
case 1077: return new CityInfo("Abriaquí", "02", 6.63148, -76.06444);
case 1078: return new CityInfo("Ábrego", "21", 8.08065, -73.22054);
case 1079: return new CityInfo("Abejorral", "02", 5.78928, -75.42725);
case 1080: return new CityInfo("Los Santos", "26", 7.17, -73.09306);
case 1081: return new CityInfo("Lejanías", "19", 3.52762, -74.02335);
case 1082: return new CityInfo("El Dorado", "19", 2.77411, -72.86834);
case 1083: return new CityInfo("Curillo", "08", 1.03327, -75.91907);
case 1084: return new CityInfo("Laureles", "28", 4.25917, -75.3225);
case 1085: return new CityInfo("Santacruz", "20", 1.5209, -77.26206);
case 1086: return new CityInfo("Campo Alegre", "28", 3.18917, -75.70361);
case 1087: return new CityInfo("Santiago Pérez", "28", 3.39806, -75.605);
case 1088: return new CityInfo("El Tarra", "21", 8.57562, -73.09489);
case 1089: return new CityInfo("Labateca", "21", 7.29889, -72.49472);
case 1090: return new CityInfo("La Hormiga", "22", 0.4258, -76.90558);
case 1091: return new CityInfo("Mesetas", "19", 3.38463, -74.04424);
case 1092: return new CityInfo("Bellavista", "11", 6.55645, -76.88389);
case 1093: return new CityInfo("Génova", "23", 4.20796, -75.78881);
case 1094: return new CityInfo("Chivor", "36", 4.88556, -73.36889);
case 1095: return new CityInfo("Monterrey", "32", 4.87802, -72.89575);
case 1096: return new CityInfo("Paratebueno", "33", 4.37575, -73.21547);
case 1097: return new CityInfo("Puerto Gaitán", "19", 4.31328, -72.08157);
case 1098: return new CityInfo("Sabanalarga", "32", 4.8543, -73.04003);
case 1099: return new CityInfo("Villanueva", "32", 4.61208, -72.92761);
case 1100: return new CityInfo("Morales", "09", 2.75446, -76.62791);
case 1101: return new CityInfo("Villa Rica", "09", 2.5142, -76.84939);
case 1102: return new CityInfo("Quípama", "36", 5.5194, -74.17765);
case 1103: return new CityInfo("La Cumbre", "29", 3.7225, -76.02083);
case 1104: return new CityInfo("Canalete", "12", 8.67611, -76.20417);
case 1105: return new CityInfo("Fredonia", "02", 5.92583, -75.67056);
case 1106: return new CityInfo("Santa María", "16", 2.93897, -75.5858);
case 1107: return new CityInfo("Gachetá", "33", 4.81854, -73.63659);
case 1108: return new CityInfo("San Carlos", "12", 8.74372, -75.71331);
case 1109: return new CityInfo("San Andrés", "02", 6.90333, -75.6825);
case 1110: return new CityInfo("Buriticá", "02", 6.71873, -75.90734);
case 1111: return new CityInfo("Carepa", "02", 7.75849, -76.65255);
case 1112: return new CityInfo("Ciudad Bolívar", "02", 5.85389, -76.02528);
case 1113: return new CityInfo("Vegachí", "02", 6.76141, -74.79473);
case 1114: return new CityInfo("Altos del Rosario", "35", 8.79162, -74.16556);
case 1115: return new CityInfo("Santa Rosa del Sur", "35", 7.96444, -74.05444);
case 1116: return new CityInfo("Tiquisio", "35", 8.55666, -74.26355);
case 1117: return new CityInfo("Covarachía", "36", 6.50563, -72.7331);
case 1118: return new CityInfo("Cartagena del Chairá", "08", 1.33488, -74.84289);
case 1119: return new CityInfo("Agustín Codazzi", "10", 10.03672, -73.23558);
case 1120: return new CityInfo("Manaure Balcón del Cesar", "10", 10.39278, -73.0325);
case 1121: return new CityInfo("San Martín", "10", 8.00151, -73.51126);
case 1122: return new CityInfo("El Cantón de San Pablo", "11", 5.33889, -76.73139);
case 1123: return new CityInfo("El Retorno", "14", 2.33022, -72.62765);
case 1124: return new CityInfo("Isnos", "16", 1.93556, -76.24056);
case 1125: return new CityInfo("Plato", "38", 9.79029, -74.78244);
case 1126: return new CityInfo("El Dorado", "19", 3.73924, -73.83489);
case 1127: return new CityInfo("Mapiripán", "19", 2.89115, -72.13328);
case 1128: return new CityInfo("Puerto Concordia", "19", 2.62206, -72.75724);
case 1129: return new CityInfo("La Tola", "20", 2.39949, -78.18923);
case 1130: return new CityInfo("La Esperanza", "21", 7.64059, -73.32762);
case 1131: return new CityInfo("Puerto Guzmán", "22", 0.97028, -76.58583);
case 1132: return new CityInfo("El Playón", "26", 7.47131, -73.2031);
case 1133: return new CityInfo("Santa Helena del Opón", "26", 6.33997, -73.61696);
case 1134: return new CityInfo("Carurú", "30", 1.01402, -71.29624);
case 1135: return new CityInfo("Tibacuy", "33", 4.35111, -72.45639);
case 1136: return new CityInfo("Santa Genoveva de Docordó", "11", 4.25875, -77.36516);
case 1137: return new CityInfo("Aguada", "26", 6.16232, -73.5221);
case 1138: return new CityInfo("La Macarena", "19", 2.18266, -73.7871);
case 1139: return new CityInfo("Valle del Guamuez", "22", 0.4525, -76.91917);
case 1140: return new CityInfo("Santa Isabel", "28", 3.34944, -74.98056);
case 1141: return new CityInfo("San José del Fragua", "08", 1.33196, -75.97409);
case 1142: return new CityInfo("San José del Guaviare", "14", 2.57286, -72.64591);
case 1143: return new CityInfo("Orito", "22", 0.66749, -76.87297);
case 1144: return new CityInfo("Puerto Caicedo", "22", 0.68362, -76.60439);
case 1145: return new CityInfo("Solita", "08", 0.87516, -75.61943);
case 1146: return new CityInfo("Samaná", "37", 5.41258, -74.99219);
case 1147: return new CityInfo("Puerto Guzmán", "22", 0.96454, -76.40795);
case 1148: return new CityInfo("Piamonte", "09", 1.12002, -76.32131);
case 1149: return new CityInfo("Rionegro", "26", 7.26456, -73.15012);
case 1150: return new CityInfo("Alpujarra", "28", 3.39176, -74.93344);
case 1151: return new CityInfo("Dolores", "28", 3.5391, -74.89752);
case 1152: return new CityInfo("Puerto Lleras", "19", 3.26942, -73.37537);
case 1153: return new CityInfo("Piendamo", "09", 2.63918, -76.53055);
case 1154: return new CityInfo("Barrio San Luis", "34", 4.66779, -74.0215);
case 1155: return new CityInfo("Armero-Guyabal", "28", 4.96701, -74.90294);
case 1156: return new CityInfo("Sopetrán", "02", 6.5018, -75.74309);
case 1157: return new CityInfo("Valdivia", "02", 7.16433, -75.43906);
case 1158: return new CityInfo("Socha", "36", 5.99732, -72.69138);
case 1159: return new CityInfo("Chitaraque", "36", 6.02839, -73.44703);
case 1160: return new CityInfo("San Fernando", "35", 9.21093, -74.31797);
case 1161: return new CityInfo("San Martín de Loba", "35", 8.936, -74.03975);
case 1162: return new CityInfo("Anserma", "37", 5.23479, -75.78465);
case 1163: return new CityInfo("La Merced", "37", 5.39961, -75.54719);
case 1164: return new CityInfo("El Carmen de Atrato", "11", 5.89862, -76.14205);
case 1165: return new CityInfo("Puerto Libertador", "12", 7.8894, -75.67015);
case 1166: return new CityInfo("La Apartada", "12", 8.04911, -75.33728);
case 1167: return new CityInfo("San Cayetano", "33", 5.3359, -74.02659);
case 1168: return new CityInfo("Ubalá", "33", 4.74389, -73.53472);
default: return new CityInfo("El Colegio", "33", 4.58103, -74.44293);

                                    }                                        
                                }
                            
                        }
                    }
                