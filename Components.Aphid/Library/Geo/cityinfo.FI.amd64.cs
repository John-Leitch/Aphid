
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
                                    public const string Country = "FI";
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
                            
                                        var cur = (Math.Abs(63.62209 - lat) + Math.Abs(22.99456 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(60.8 - lat) + Math.Abs(23.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.55632 - lat) + Math.Abs(23.59606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.08333 - lat) + Math.Abs(24.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.30893 - lat) + Math.Abs(23.67734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.93958 - lat) + Math.Abs(22.51306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.08333 - lat) + Math.Abs(26.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.37181 - lat) + Math.Abs(25.8458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.15 - lat) + Math.Abs(22.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.88333 - lat) + Math.Abs(22.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.8 - lat) + Math.Abs(28 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.20963 - lat) + Math.Abs(25.14195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.18538 - lat) + Math.Abs(26.99547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.14466 - lat) + Math.Abs(28.28196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.13607 - lat) + Math.Abs(22.25223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.12695 - lat) + Math.Abs(27.46276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.24759 - lat) + Math.Abs(23.78004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.51667 - lat) + Math.Abs(27.68306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.5794 - lat) + Math.Abs(27.70354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.68333 - lat) + Math.Abs(21.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.16187 - lat) + Math.Abs(23.81922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.02121 - lat) + Math.Abs(24.50483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.70601 - lat) + Math.Abs(23.26688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.06667 - lat) + Math.Abs(25.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.21023 - lat) + Math.Abs(23.76738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.41699 - lat) + Math.Abs(24.31965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.48472 - lat) + Math.Abs(24.99157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.75 - lat) + Math.Abs(27.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.47839 - lat) + Math.Abs(23.78285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.31667 - lat) + Math.Abs(23.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.93333 - lat) + Math.Abs(26.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.46667 - lat) + Math.Abs(21.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.76101 - lat) + Math.Abs(28.02853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.68333 - lat) + Math.Abs(21.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.05 - lat) + Math.Abs(22.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.35932 - lat) + Math.Abs(27.75506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.31533 - lat) + Math.Abs(27.873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.29414 - lat) + Math.Abs(25.04099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.01667 - lat) + Math.Abs(22.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.33333 - lat) + Math.Abs(22.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.66667 - lat) + Math.Abs(28.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.26421 - lat) + Math.Abs(24.03122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.6 - lat) + Math.Abs(22.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.05635 - lat) + Math.Abs(22.10584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.096 - lat) + Math.Abs(21.61577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.56667 - lat) + Math.Abs(26.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.80043 - lat) + Math.Abs(21.40841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.5 - lat) + Math.Abs(25.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.78668 - lat) + Math.Abs(30.00753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.90864 - lat) + Math.Abs(27.02843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.75 - lat) + Math.Abs(26.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.08333 - lat) + Math.Abs(23.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.42844 - lat) + Math.Abs(21.87103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.6 - lat) + Math.Abs(24.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.76469 - lat) + Math.Abs(25.6523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.40368 - lat) + Math.Abs(25.02638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.81667 - lat) + Math.Abs(28.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.48372 - lat) + Math.Abs(30.62731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.15 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.45148 - lat) + Math.Abs(22.26869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.91667 - lat) + Math.Abs(24.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.62803 - lat) + Math.Abs(23.81828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.84811 - lat) + Math.Abs(24.14662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.1 - lat) + Math.Abs(26.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.16667 - lat) + Math.Abs(23.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.76667 - lat) + Math.Abs(24.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.18333 - lat) + Math.Abs(30.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.4819 - lat) + Math.Abs(21.74156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.08333 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.95 - lat) + Math.Abs(26.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.81412 - lat) + Math.Abs(24.62594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.58333 - lat) + Math.Abs(22.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.49911 - lat) + Math.Abs(23.78712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.81035 - lat) + Math.Abs(23.76823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.56085 - lat) + Math.Abs(21.61639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.56667 - lat) + Math.Abs(28.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.15 - lat) + Math.Abs(28.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.91667 - lat) + Math.Abs(27.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.5 - lat) + Math.Abs(25.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.61667 - lat) + Math.Abs(27.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.88685 - lat) + Math.Abs(28.90778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.35 - lat) + Math.Abs(23.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.32852 - lat) + Math.Abs(27.44782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.56421 - lat) + Math.Abs(25.85363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.5581 - lat) + Math.Abs(22.78526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.65736 - lat) + Math.Abs(26.04642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.78691 - lat) + Math.Abs(28.37299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.13333 - lat) + Math.Abs(28.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.66667 - lat) + Math.Abs(27.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.61667 - lat) + Math.Abs(23.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.86667 - lat) + Math.Abs(24.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.41667 - lat) + Math.Abs(26.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.11667 - lat) + Math.Abs(21.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.13862 - lat) + Math.Abs(24.22715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.43333 - lat) + Math.Abs(29.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.66667 - lat) + Math.Abs(25.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.5 - lat) + Math.Abs(26.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.08333 - lat) + Math.Abs(27.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.81455 - lat) + Math.Abs(24.75924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.87703 - lat) + Math.Abs(21.81945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.9 - lat) + Math.Abs(24.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.37752 - lat) + Math.Abs(25.26906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.79446 - lat) + Math.Abs(22.82822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.14025 - lat) + Math.Abs(25.76948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.2925 - lat) + Math.Abs(28.15806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.18333 - lat) + Math.Abs(29.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.8699 - lat) + Math.Abs(28.87999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.2 - lat) + Math.Abs(27.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.34306 - lat) + Math.Abs(22.69642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.38333 - lat) + Math.Abs(23.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.11389 - lat) + Math.Abs(22.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.64759 - lat) + Math.Abs(22.72977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.31991 - lat) + Math.Abs(23.82085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.38333 - lat) + Math.Abs(23.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.83333 - lat) + Math.Abs(28.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.03333 - lat) + Math.Abs(22.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.4746 - lat) + Math.Abs(24.32652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.70486 - lat) + Math.Abs(25.25396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.65 - lat) + Math.Abs(29.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.37658 - lat) + Math.Abs(21.94184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.66667 - lat) + Math.Abs(25.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.53333 - lat) + Math.Abs(22.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.98575 - lat) + Math.Abs(24.05714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.5268 - lat) + Math.Abs(26.46203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.28333 - lat) + Math.Abs(28.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.5 - lat) + Math.Abs(25.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.5 - lat) + Math.Abs(28.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.50579 - lat) + Math.Abs(27.24643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.73769 - lat) + Math.Abs(24.77726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.22882 - lat) + Math.Abs(21.41691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.89563 - lat) + Math.Abs(24.28785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.61667 - lat) + Math.Abs(24.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.43333 - lat) + Math.Abs(29.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.48333 - lat) + Math.Abs(28.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.63333 - lat) + Math.Abs(26.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.12724 - lat) + Math.Abs(21.51127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.91667 - lat) + Math.Abs(26.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.50613 - lat) + Math.Abs(25.66449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.06667 - lat) + Math.Abs(28.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.48592 - lat) + Math.Abs(22.16895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.31667 - lat) + Math.Abs(29.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.68333 - lat) + Math.Abs(24.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.66667 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.49349 - lat) + Math.Abs(26.54346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.43333 - lat) + Math.Abs(29.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.68333 - lat) + Math.Abs(25.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.95 - lat) + Math.Abs(21.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.1 - lat) + Math.Abs(26.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.46667 - lat) + Math.Abs(24.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.0701 - lat) + Math.Abs(27.21763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.66667 - lat) + Math.Abs(25.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.52728 - lat) + Math.Abs(28.17495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.52466 - lat) + Math.Abs(22.9583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.86667 - lat) + Math.Abs(27.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.11667 - lat) + Math.Abs(23.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.75883 - lat) + Math.Abs(29.38843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.26667 - lat) + Math.Abs(25.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.65 - lat) + Math.Abs(25.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.38333 - lat) + Math.Abs(26.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.76667 - lat) + Math.Abs(22.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.10856 - lat) + Math.Abs(28.17186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.47581 - lat) + Math.Abs(25.3749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.48333 - lat) + Math.Abs(21.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.69348 - lat) + Math.Abs(22.00862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.85 - lat) + Math.Abs(29.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.09626 - lat) + Math.Abs(23.52757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.46125 - lat) + Math.Abs(23.63228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.16667 - lat) + Math.Abs(25.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.42481 - lat) + Math.Abs(22.51601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.38333 - lat) + Math.Abs(25.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.23333 - lat) + Math.Abs(26.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.3 - lat) + Math.Abs(27.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.25 - lat) + Math.Abs(25.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.5 - lat) + Math.Abs(26.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.43333 - lat) + Math.Abs(23.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.2 - lat) + Math.Abs(23.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.44869 - lat) + Math.Abs(26.03187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.21667 - lat) + Math.Abs(24.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.77364 - lat) + Math.Abs(23.96255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.11083 - lat) + Math.Abs(27.51056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.65 - lat) + Math.Abs(22.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.04624 - lat) + Math.Abs(24.35463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.01667 - lat) + Math.Abs(23.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.55 - lat) + Math.Abs(29.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.30672 - lat) + Math.Abs(22.30097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.41667 - lat) + Math.Abs(27.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.33424 - lat) + Math.Abs(24.27197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.45671 - lat) + Math.Abs(22.68694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.35 - lat) + Math.Abs(25.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.72685 - lat) + Math.Abs(29.01592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.93456 - lat) + Math.Abs(25.41121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.01236 - lat) + Math.Abs(25.46816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.26667 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18395 - lat) + Math.Abs(24.82786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25778 - lat) + Math.Abs(25.19278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.67766 - lat) + Math.Abs(24.3572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.85 - lat) + Math.Abs(22.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.80487 - lat) + Math.Abs(25.72964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.30135 - lat) + Math.Abs(22.37821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.78333 - lat) + Math.Abs(25.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.52277 - lat) + Math.Abs(22.53073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.8287 - lat) + Math.Abs(22.9099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.46407 - lat) + Math.Abs(24.8073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.54205 - lat) + Math.Abs(29.13965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.96011 - lat) + Math.Abs(28.55104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.60416 - lat) + Math.Abs(22.07926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.59274 - lat) + Math.Abs(21.86846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.46667 - lat) + Math.Abs(23.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.91667 - lat) + Math.Abs(24.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.20746 - lat) + Math.Abs(28.08222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.38333 - lat) + Math.Abs(25.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.95 - lat) + Math.Abs(25.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.47283 - lat) + Math.Abs(21.33707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.36667 - lat) + Math.Abs(22 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.19375 - lat) + Math.Abs(21.90972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.46744 - lat) + Math.Abs(22.02428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.66965 - lat) + Math.Abs(25.8475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.67915 - lat) + Math.Abs(21.99274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.35 - lat) + Math.Abs(23.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.13333 - lat) + Math.Abs(25.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.95 - lat) + Math.Abs(23.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.19861 - lat) + Math.Abs(24.87772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.41667 - lat) + Math.Abs(24.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.80798 - lat) + Math.Abs(25.99314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.76667 - lat) + Math.Abs(26.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.5 - lat) + Math.Abs(23.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.68857 - lat) + Math.Abs(27.27227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.63333 - lat) + Math.Abs(21.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.66667 - lat) + Math.Abs(27.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.48333 - lat) + Math.Abs(21.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.85839 - lat) + Math.Abs(21.50035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.3 - lat) + Math.Abs(24.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.23355 - lat) + Math.Abs(25.09947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.76667 - lat) + Math.Abs(22.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.57082 - lat) + Math.Abs(22.09883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.58333 - lat) + Math.Abs(22.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.41667 - lat) + Math.Abs(26.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.03014 - lat) + Math.Abs(24.62791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.63333 - lat) + Math.Abs(25.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.94225 - lat) + Math.Abs(21.57311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.15523 - lat) + Math.Abs(27.29939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.36375 - lat) + Math.Abs(21.62556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.92618 - lat) + Math.Abs(27.58135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.36293 - lat) + Math.Abs(24.66781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.83744 - lat) + Math.Abs(25.18607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.79682 - lat) + Math.Abs(25.70457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.45659 - lat) + Math.Abs(26.22505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71667 - lat) + Math.Abs(24.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.84972 - lat) + Math.Abs(23.0561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.02472 - lat) + Math.Abs(23.50482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.24859 - lat) + Math.Abs(24.06534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.53333 - lat) + Math.Abs(29.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.80985 - lat) + Math.Abs(25.41545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.57346 - lat) + Math.Abs(26.05257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.51032 - lat) + Math.Abs(22.46176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.31667 - lat) + Math.Abs(30.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.53333 - lat) + Math.Abs(24.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.49009 - lat) + Math.Abs(27.78262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.56667 - lat) + Math.Abs(21.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.31667 - lat) + Math.Abs(23.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.06244 - lat) + Math.Abs(27.80571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.91198 - lat) + Math.Abs(26.12796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.78333 - lat) + Math.Abs(23.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.6 - lat) + Math.Abs(22.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.15896 - lat) + Math.Abs(24.86797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.41407 - lat) + Math.Abs(25.95194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.75388 - lat) + Math.Abs(22.74728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.96927 - lat) + Math.Abs(23.0088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.67028 - lat) + Math.Abs(22.89325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.1 - lat) + Math.Abs(21.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.05871 - lat) + Math.Abs(28.18871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.2 - lat) + Math.Abs(23.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.36667 - lat) + Math.Abs(27.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.62443 - lat) + Math.Abs(26.1972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.65 - lat) + Math.Abs(22.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.08333 - lat) + Math.Abs(25.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.87575 - lat) + Math.Abs(21.69765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.97609 - lat) + Math.Abs(22.01143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.98267 - lat) + Math.Abs(25.66151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.03333 - lat) + Math.Abs(24.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.7 - lat) + Math.Abs(22.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.12381 - lat) + Math.Abs(24.43853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.154 - lat) + Math.Abs(23.68858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.51667 - lat) + Math.Abs(23.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.96667 - lat) + Math.Abs(29.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.54529 - lat) + Math.Abs(21.3588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.87558 - lat) + Math.Abs(23.71948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.61667 - lat) + Math.Abs(22.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.8 - lat) + Math.Abs(23.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.89238 - lat) + Math.Abs(27.67703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.46998 - lat) + Math.Abs(22.16145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.57847 - lat) + Math.Abs(25.18814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.56667 - lat) + Math.Abs(25.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.13333 - lat) + Math.Abs(29.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.5 - lat) + Math.Abs(24.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.72859 - lat) + Math.Abs(23.03387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.27429 - lat) + Math.Abs(21.37596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.1191 - lat) + Math.Abs(22.30976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.86667 - lat) + Math.Abs(26.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4664 - lat) + Math.Abs(26.94582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.02222 - lat) + Math.Abs(25.15417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.65 - lat) + Math.Abs(23.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.3 - lat) + Math.Abs(23.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.78333 - lat) + Math.Abs(21.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.11418 - lat) + Math.Abs(21.68216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.1638 - lat) + Math.Abs(21.56151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.01667 - lat) + Math.Abs(25.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.76023 - lat) + Math.Abs(29.84711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.61667 - lat) + Math.Abs(26.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.33047 - lat) + Math.Abs(23.77785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.83847 - lat) + Math.Abs(23.13066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.25647 - lat) + Math.Abs(22.35643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.0293 - lat) + Math.Abs(21.70028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.11984 - lat) + Math.Abs(25.07835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.65 - lat) + Math.Abs(26.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.21667 - lat) + Math.Abs(22.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.66474 - lat) + Math.Abs(24.89356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.1 - lat) + Math.Abs(30.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.23333 - lat) + Math.Abs(23.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.38333 - lat) + Math.Abs(24.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.36667 - lat) + Math.Abs(24.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.16047 - lat) + Math.Abs(22.729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.13139 - lat) + Math.Abs(25.79744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.45385 - lat) + Math.Abs(22.57699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.46667 - lat) + Math.Abs(23.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.49525 - lat) + Math.Abs(30.25081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.2 - lat) + Math.Abs(23.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.26667 - lat) + Math.Abs(24.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.35002 - lat) + Math.Abs(26.27921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.89752 - lat) + Math.Abs(29.83494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.91069 - lat) + Math.Abs(29.28228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.40338 - lat) + Math.Abs(25.105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.91314 - lat) + Math.Abs(25.50339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.71309 - lat) + Math.Abs(27.43056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.80158 - lat) + Math.Abs(24.54483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.73641 - lat) + Math.Abs(24.56371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.53271 - lat) + Math.Abs(25.10917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.18333 - lat) + Math.Abs(26.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.54878 - lat) + Math.Abs(23.68845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.21209 - lat) + Math.Abs(24.72756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.10299 - lat) + Math.Abs(23.07129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.43333 - lat) + Math.Abs(22.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.38444 - lat) + Math.Abs(21.22331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.2 - lat) + Math.Abs(22.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.13333 - lat) + Math.Abs(22.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.8963 - lat) + Math.Abs(26.97045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.86667 - lat) + Math.Abs(24.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.96667 - lat) + Math.Abs(25.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.91667 - lat) + Math.Abs(25.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.61292 - lat) + Math.Abs(23.94196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.53418 - lat) + Math.Abs(24.20977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.24015 - lat) + Math.Abs(23.71789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.07178 - lat) + Math.Abs(23.66163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.66667 - lat) + Math.Abs(22.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.30851 - lat) + Math.Abs(21.70856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.52156 - lat) + Math.Abs(26.93125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.9 - lat) + Math.Abs(23.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.96667 - lat) + Math.Abs(25.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.8 - lat) + Math.Abs(22.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.99357 - lat) + Math.Abs(26.64785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.29563 - lat) + Math.Abs(28.25289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.46383 - lat) + Math.Abs(24.07602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.10081 - lat) + Math.Abs(24.12177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.86067 - lat) + Math.Abs(23.45289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.18427 - lat) + Math.Abs(24.95034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.62542 - lat) + Math.Abs(22.89594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.25 - lat) + Math.Abs(23.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.22728 - lat) + Math.Abs(27.72846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.98333 - lat) + Math.Abs(28.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.40724 - lat) + Math.Abs(22.36904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.25174 - lat) + Math.Abs(24.88111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.24147 - lat) + Math.Abs(25.72088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.9 - lat) + Math.Abs(27.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.79901 - lat) + Math.Abs(24.36939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.23333 - lat) + Math.Abs(29.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.68333 - lat) + Math.Abs(21.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.06667 - lat) + Math.Abs(28.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.11796 - lat) + Math.Abs(28.50763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.73333 - lat) + Math.Abs(26.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.17823 - lat) + Math.Abs(27.83165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.80162 - lat) + Math.Abs(23.48004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.60118 - lat) + Math.Abs(29.76316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.47369 - lat) + Math.Abs(25.08992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.86667 - lat) + Math.Abs(25.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.37899 - lat) + Math.Abs(27.43372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.9 - lat) + Math.Abs(24.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.919 - lat) + Math.Abs(25.17011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.8642 - lat) + Math.Abs(25.19002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.81667 - lat) + Math.Abs(22.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.5 - lat) + Math.Abs(22.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.67486 - lat) + Math.Abs(22.70256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.05251 - lat) + Math.Abs(26.48117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.65986 - lat) + Math.Abs(27.53891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.01172 - lat) + Math.Abs(22.33332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.11319 - lat) + Math.Abs(21.95884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4 - lat) + Math.Abs(21.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.04587 - lat) + Math.Abs(24.00459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.90596 - lat) + Math.Abs(27.02881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.17185 - lat) + Math.Abs(28.75242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.67162 - lat) + Math.Abs(30.93276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.73333 - lat) + Math.Abs(22.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.76951 - lat) + Math.Abs(23.0658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.89488 - lat) + Math.Abs(26.33869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.55915 - lat) + Math.Abs(27.19067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.31735 - lat) + Math.Abs(25.3731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.63333 - lat) + Math.Abs(24.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.66667 - lat) + Math.Abs(28.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.93333 - lat) + Math.Abs(23.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.18333 - lat) + Math.Abs(22.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.22284 - lat) + Math.Abs(21.37218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.98333 - lat) + Math.Abs(22.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.05 - lat) + Math.Abs(25.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61 - lat) + Math.Abs(25.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.63333 - lat) + Math.Abs(26.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.06218 - lat) + Math.Abs(23.65447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.16952 - lat) + Math.Abs(24.93545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.20564 - lat) + Math.Abs(26.03811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.43333 - lat) + Math.Abs(28.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.78333 - lat) + Math.Abs(24.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.01753 - lat) + Math.Abs(27.21906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.17654 - lat) + Math.Abs(25.35233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.17255 - lat) + Math.Abs(24.56303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.58333 - lat) + Math.Abs(26.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.31667 - lat) + Math.Abs(22.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.38333 - lat) + Math.Abs(26.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.83333 - lat) + Math.Abs(22.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.56974 - lat) + Math.Abs(27.19794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.99596 - lat) + Math.Abs(24.46434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.63913 - lat) + Math.Abs(23.19531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.46667 - lat) + Math.Abs(24.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.4 - lat) + Math.Abs(23.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.009 - lat) + Math.Abs(24.71385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.13333 - lat) + Math.Abs(25.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.75 - lat) + Math.Abs(25.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.21948 - lat) + Math.Abs(24.61684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.81462 - lat) + Math.Abs(23.62146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.36667 - lat) + Math.Abs(23.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.2 - lat) + Math.Abs(21.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.13333 - lat) + Math.Abs(22.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.59371 - lat) + Math.Abs(23.05738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.2052 - lat) + Math.Abs(24.6522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.38573 - lat) + Math.Abs(23.63215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.08333 - lat) + Math.Abs(28.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.80511 - lat) + Math.Abs(30.15422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71667 - lat) + Math.Abs(26.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.97359 - lat) + Math.Abs(23.43389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.63549 - lat) + Math.Abs(22.85741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.06667 - lat) + Math.Abs(22.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.39233 - lat) + Math.Abs(25.66507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.6 - lat) + Math.Abs(22.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.29901 - lat) + Math.Abs(25.08887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.6471 - lat) + Math.Abs(22.58755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.53333 - lat) + Math.Abs(25.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.56667 - lat) + Math.Abs(21.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.21667 - lat) + Math.Abs(25.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.74544 - lat) + Math.Abs(26.07084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.68333 - lat) + Math.Abs(26.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.58333 - lat) + Math.Abs(23.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.16667 - lat) + Math.Abs(24.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.95 - lat) + Math.Abs(22.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63 - lat) + Math.Abs(23.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.23333 - lat) + Math.Abs(22.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.55403 - lat) + Math.Abs(24.06186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.6 - lat) + Math.Abs(25.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.28333 - lat) + Math.Abs(22.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.21746 - lat) + Math.Abs(24.78151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14784 - lat) + Math.Abs(24.98561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.80509 - lat) + Math.Abs(24.79614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.15261 - lat) + Math.Abs(24.76467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.09192 - lat) + Math.Abs(21.72297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.09705 - lat) + Math.Abs(21.6959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.0848 - lat) + Math.Abs(21.61716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.1678 - lat) + Math.Abs(23.83819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.29972 - lat) + Math.Abs(22.3004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.45284 - lat) + Math.Abs(26.94276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.00027 - lat) + Math.Abs(23.81586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Ytteresse", "15", 63.62209, 22.99456);
case 1: return new CityInfo("Ypäjä", "05", 60.8, 23.28333);
case 2: return new CityInfo("Ylöjärvi", "06", 61.55632, 23.59606);
case 3: return new CityInfo("Ylivieska", "17", 64.08333, 24.55);
case 4: return new CityInfo("Ylitornio", "19", 66.30893, 23.67734);
case 5: return new CityInfo("Ylistaro", "14", 62.93958, 22.51306);
case 6: return new CityInfo("Ylikiiminki", "17", 65.08333, 26.25);
case 7: return new CityInfo("Yli-Ii", "17", 65.37181, 25.8458);
case 8: return new CityInfo("Ylihärmä", "14", 63.15, 22.78333);
case 9: return new CityInfo("Yläne", "02", 60.88333, 22.41667);
case 10: return new CityInfo("Ylämaa", "09", 60.8, 28);
case 11: return new CityInfo("Vuosaari", "01", 60.20963, 25.14195);
case 12: return new CityInfo("Vuolijoki", "18", 64.18538, 26.99547);
case 13: return new CityInfo("Vuokatti", "18", 64.14466, 28.28196);
case 14: return new CityInfo("Vörå", "15", 63.13607, 22.25223);
case 15: return new CityInfo("Virtasalmi", "10", 62.12695, 27.46276);
case 16: return new CityInfo("Virrat", "06", 62.24759, 23.78004);
case 17: return new CityInfo("Virolahti", "08", 60.51667, 27.68306);
case 18: return new CityInfo("Virojoki", "08", 60.5794, 27.70354);
case 19: return new CityInfo("Vinkkilä", "02", 60.68333, 21.71667);
case 20: return new CityInfo("Vimpeli", "14", 63.16187, 23.81922);
case 21: return new CityInfo("Vilppula", "06", 62.02121, 24.50483);
case 22: return new CityInfo("Viljakkala", "06", 61.70601, 23.26688);
case 23: return new CityInfo("Viitasaari", "13", 63.06667, 25.86667);
case 24: return new CityInfo("Viiala", "06", 61.21023, 23.76738);
case 25: return new CityInfo("Vihti", "01", 60.41699, 24.31965);
case 26: return new CityInfo("Vihanti", "17", 64.48472, 24.99157);
case 27: return new CityInfo("Vieremä", "11", 63.75, 27.01667);
case 28: return new CityInfo("Veteli", "16", 63.47839, 23.78285);
case 29: return new CityInfo("Vesilahti", "06", 61.31667, 23.61667);
case 30: return new CityInfo("Vesanto", "11", 62.93333, 26.41667);
case 31: return new CityInfo("Velkua", "02", 60.46667, 21.66667);
case 32: return new CityInfo("Vehmersalmi", "11", 62.76101, 28.02853);
case 33: return new CityInfo("Vehmaa", "02", 60.68333, 21.66667);
case 34: return new CityInfo("Västanfjärd", "02", 60.05, 22.68333);
case 35: return new CityInfo("Varpaisjärvi", "11", 63.35932, 27.75506);
case 36: return new CityInfo("Varkaus", "11", 62.31533, 27.873);
case 37: return new CityInfo("Vantaa", "01", 60.29414, 25.04099);
case 38: return new CityInfo("Vampula", "04", 61.01667, 22.7);
case 39: return new CityInfo("Vammala", "06", 61.33333, 22.9);
case 40: return new CityInfo("Valtimo", "12", 63.66667, 28.8);
case 41: return new CityInfo("Valkeakoski", "06", 61.26421, 24.03122);
case 42: return new CityInfo("Vahto", "02", 60.6, 22.3);
case 43: return new CityInfo("Vähäkyrö", "15", 63.05635, 22.10584);
case 44: return new CityInfo("Vaasa", "15", 63.096, 21.61577);
case 45: return new CityInfo("Vaala", "18", 64.56667, 26.83333);
case 46: return new CityInfo("Uusikaupunki", "02", 60.80043, 21.40841);
case 47: return new CityInfo("Uurainen", "13", 62.5, 25.45);
case 48: return new CityInfo("Uukuniemi", "09", 61.78668, 30.00753);
case 49: return new CityInfo("Utsjoki", "19", 69.90864, 27.02843);
case 50: return new CityInfo("Utajärvi", "17", 64.75, 26.38333);
case 51: return new CityInfo("Urjala", "06", 61.08333, 23.53333);
case 52: return new CityInfo("Ulvila", "04", 61.42844, 21.87103);
case 53: return new CityInfo("Ullava", "16", 63.6, 24.08333);
case 54: return new CityInfo("Tyrnävä", "17", 64.76469, 25.6523);
case 55: return new CityInfo("Tuusula", "01", 60.40368, 25.02638);
case 56: return new CityInfo("Tuusniemi", "11", 62.81667, 28.5);
case 57: return new CityInfo("Tuupovaara", "12", 62.48372, 30.62731);
case 58: return new CityInfo("Tuulos", "05", 61.15, 24.8);
case 59: return new CityInfo("Turku", "02", 60.45148, 22.26869);
case 60: return new CityInfo("Turenki", "05", 60.91667, 24.63333);
case 61: return new CityInfo("Töysä", "14", 62.62803, 23.81828);
case 62: return new CityInfo("Tornio", "19", 65.84811, 24.14662);
case 63: return new CityInfo("Toivakka", "13", 62.1, 26.08333);
case 64: return new CityInfo("Akaa", "06", 61.16667, 23.86667);
case 65: return new CityInfo("Toholampi", "16", 63.76667, 24.25);
case 66: return new CityInfo("Tohmajärvi", "12", 62.18333, 30.38333);
case 67: return new CityInfo("Teuva", "14", 62.4819, 21.74156);
case 68: return new CityInfo("Tervola", "19", 66.08333, 24.8);
case 69: return new CityInfo("Tervo", "11", 62.95, 26.75);
case 70: return new CityInfo("Tervakoski", "05", 60.81412, 24.62594);
case 71: return new CityInfo("Tarvasjoki", "02", 60.58333, 22.73333);
case 72: return new CityInfo("Tampere", "06", 61.49911, 23.78712);
case 73: return new CityInfo("Tammela", "05", 60.81035, 23.76823);
case 74: return new CityInfo("Taivassalo", "02", 60.56085, 21.61639);
case 75: return new CityInfo("Taivalkoski", "17", 65.56667, 28.25);
case 76: return new CityInfo("Taipalsaari", "09", 61.15, 28.05);
case 77: return new CityInfo("Taavetti", "09", 60.91667, 27.56667);
case 78: return new CityInfo("Sysmä", "07", 61.5, 25.68333);
case 79: return new CityInfo("Suonenjoki", "11", 62.61667, 27.13333);
case 80: return new CityInfo("Suomussalmi", "18", 64.88685, 28.90778);
case 81: return new CityInfo("Suomusjärvi", "02", 60.35, 23.65);
case 82: return new CityInfo("Suomenniemi", "10", 61.32852, 27.44782);
case 83: return new CityInfo("Suolahti", "13", 62.56421, 25.85363);
case 84: return new CityInfo("Suodenniemi", "06", 61.5581, 22.78526);
case 85: return new CityInfo("Sumiainen", "13", 62.65736, 26.04642);
case 86: return new CityInfo("Sulkava", "10", 61.78691, 28.37299);
case 87: return new CityInfo("Sotkamo", "18", 64.13333, 28.41667);
case 88: return new CityInfo("Sonkajärvi", "11", 63.66667, 27.51667);
case 89: return new CityInfo("Somero", "02", 60.61667, 23.53333);
case 90: return new CityInfo("Soini", "14", 62.86667, 24.21667);
case 91: return new CityInfo("Sodankylä", "19", 67.41667, 26.6);
case 92: return new CityInfo("Smedsby", "15", 63.11667, 21.7);
case 93: return new CityInfo("Siuntio", "01", 60.13862, 24.22715);
case 94: return new CityInfo("Simpele", "09", 61.43333, 29.36667);
case 95: return new CityInfo("Simo", "19", 65.66667, 25.05);
case 96: return new CityInfo("Broby", "08", 60.5, 26.71667);
case 97: return new CityInfo("Siilinjärvi", "11", 63.08333, 27.66667);
case 98: return new CityInfo("Siikajoki", "17", 64.81455, 24.75924);
case 99: return new CityInfo("Siikainen", "04", 61.87703, 21.81945);
case 100: return new CityInfo("Sievi", "17", 63.9, 24.5);
case 101: return new CityInfo("Sibbo", "01", 60.37752, 25.26906);
case 102: return new CityInfo("Seinäjoki", "14", 62.79446, 22.82822);
case 103: return new CityInfo("Säynätsalo", "13", 62.14025, 25.76948);
case 104: return new CityInfo("Savukoski", "19", 67.2925, 28.15806);
case 105: return new CityInfo("Savonranta", "10", 62.18333, 29.2);
case 106: return new CityInfo("Savonlinna", "10", 61.8699, 28.87999);
case 107: return new CityInfo("Savitaipale", "09", 61.2, 27.7);
case 108: return new CityInfo("Sauvo", "02", 60.34306, 22.69642);
case 109: return new CityInfo("Saukkola", "01", 60.38333, 23.98333);
case 110: return new CityInfo("Särkisalo", "02", 60.11389, 22.95);
case 111: return new CityInfo("Sandsund", "15", 63.64759, 22.72977);
case 112: return new CityInfo("Sammatti", "01", 60.31991, 23.82085);
case 113: return new CityInfo("Salo", "02", 60.38333, 23.13333);
case 114: return new CityInfo("Salla", "19", 66.83333, 28.66667);
case 115: return new CityInfo("Säkylä", "04", 61.03333, 22.33333);
case 116: return new CityInfo("Sahalahti", "06", 61.4746, 24.32652);
case 117: return new CityInfo("Saarijärvi", "13", 62.70486, 25.25396);
case 118: return new CityInfo("Saari", "09", 61.65, 29.75);
case 119: return new CityInfo("Rymättylä", "02", 60.37658, 21.94184);
case 120: return new CityInfo("Ruukki", "17", 64.66667, 25.1);
case 121: return new CityInfo("Rusko", "02", 60.53333, 22.21667);
case 122: return new CityInfo("Ruovesi", "06", 61.98575, 24.05714);
case 123: return new CityInfo("Ruotsinpyhtää", "01", 60.5268, 26.46203);
case 124: return new CityInfo("Ruokolahti", "09", 61.28333, 28.83333);
case 125: return new CityInfo("Rovaniemi", "19", 66.5, 25.71667);
case 126: return new CityInfo("Ristijärvi", "18", 64.5, 28.21667);
case 127: return new CityInfo("Ristiina", "10", 61.50579, 27.24643);
case 128: return new CityInfo("Riihimäki", "05", 60.73769, 24.77726);
case 129: return new CityInfo("Replot", "15", 63.22882, 21.41691);
case 130: return new CityInfo("Renko", "05", 60.89563, 24.28785);
case 131: return new CityInfo("Reisjärvi", "17", 63.61667, 24.9);
case 132: return new CityInfo("Rautjärvi", "09", 61.43333, 29.35);
case 133: return new CityInfo("Rautavaara", "11", 63.48333, 28.3);
case 134: return new CityInfo("Rautalampi", "11", 62.63333, 26.83333);
case 135: return new CityInfo("Rauma", "04", 61.12724, 21.51127);
case 136: return new CityInfo("Ranua", "19", 65.91667, 26.53333);
case 137: return new CityInfo("Rantsila", "17", 64.50613, 25.66449);
case 138: return new CityInfo("Rantasalmi", "10", 62.06667, 28.3);
case 139: return new CityInfo("Raisio", "02", 60.48592, 22.16895);
case 140: return new CityInfo("Rääkkylä", "12", 62.31667, 29.61667);
case 141: return new CityInfo("Raahe", "17", 64.68333, 24.48333);
case 142: return new CityInfo("Pylkönmäki", "13", 62.66667, 24.8);
case 143: return new CityInfo("Pyhtää", "08", 60.49349, 26.54346);
case 144: return new CityInfo("Pyhäselkä", "12", 62.43333, 29.96667);
case 145: return new CityInfo("Pyhäsalmi", "17", 63.68333, 25.98333);
case 146: return new CityInfo("Pyhäranta", "02", 60.95, 21.45);
case 147: return new CityInfo("Pyhäntä", "17", 64.1, 26.31667);
case 148: return new CityInfo("Pyhäjoki", "17", 64.46667, 24.23333);
case 149: return new CityInfo("Pyhäjärvi", "19", 67.0701, 27.21763);
case 150: return new CityInfo("Pyhäjärvi", "17", 63.66667, 25.9);
case 151: return new CityInfo("Puumala", "10", 61.52728, 28.17495);
case 152: return new CityInfo("Purmo", "15", 63.52466, 22.9583);
case 153: return new CityInfo("Puolanka", "18", 64.86667, 27.66667);
case 154: return new CityInfo("Punkalaidun", "06", 61.11667, 23.1);
case 155: return new CityInfo("Punkaharju", "10", 61.75883, 29.38843);
case 156: return new CityInfo("Pulkkila", "17", 64.26667, 25.86667);
case 157: return new CityInfo("Pukkila", "01", 60.65, 25.56667);
case 158: return new CityInfo("Pudasjärvi", "17", 65.38333, 26.91667);
case 159: return new CityInfo("Pöytyä", "02", 60.76667, 22.66667);
case 160: return new CityInfo("Posio", "19", 66.10856, 28.17186);
case 161: return new CityInfo("Pornainen", "01", 60.47581, 25.3749);
case 162: return new CityInfo("Pori", "04", 61.48333, 21.78333);
case 163: return new CityInfo("Pomarkku", "04", 61.69348, 22.00862);
case 164: return new CityInfo("Polvijärvi", "12", 62.85, 29.36667);
case 165: return new CityInfo("Pohja", "01", 60.09626, 23.52757);
case 166: return new CityInfo("Pirkkala", "06", 61.46125, 23.63228);
case 167: return new CityInfo("Piippola", "17", 64.16667, 25.96667);
case 168: return new CityInfo("Piikkiö", "02", 60.42481, 22.51601);
case 169: return new CityInfo("Pihtipudas", "13", 63.38333, 25.56667);
case 170: return new CityInfo("Pielavesi", "11", 63.23333, 26.75);
case 171: return new CityInfo("Pieksämäki", "10", 62.3, 27.13333);
case 172: return new CityInfo("Petäjävesi", "13", 62.25, 25.2);
case 173: return new CityInfo("Pertunmaa", "10", 61.5, 26.48333);
case 174: return new CityInfo("Pertteli", "02", 60.43333, 23.26667);
case 175: return new CityInfo("Perniö", "02", 60.2, 23.13333);
case 176: return new CityInfo("Pernå", "01", 60.44869, 26.03187);
case 177: return new CityInfo("Perho", "16", 63.21667, 24.41667);
case 178: return new CityInfo("Pello", "19", 66.77364, 23.96255);
case 179: return new CityInfo("Pelkosenniemi", "19", 67.11083, 27.51056);
case 180: return new CityInfo("Pedersöre", "15", 63.65, 22.68333);
case 181: return new CityInfo("Parola", "05", 61.04624, 24.35463);
case 182: return new CityInfo("Parkano", "06", 62.01667, 23.01667);
case 183: return new CityInfo("Parikkala", "09", 61.55, 29.5);
case 184: return new CityInfo("Pargas", "02", 60.30672, 22.30097);
case 185: return new CityInfo("Paltamo", "18", 64.41667, 27.83333);
case 186: return new CityInfo("Pälkäne", "06", 61.33424, 24.27197);
case 187: return new CityInfo("Paimio", "02", 60.45671, 22.68694);
case 188: return new CityInfo("Padasjoki", "07", 61.35, 25.28333);
case 189: return new CityInfo("Outokumpu", "12", 62.72685, 29.01592);
case 190: return new CityInfo("Oulunsalo", "17", 64.93456, 25.41121);
case 191: return new CityInfo("Oulu", "17", 65.01236, 25.46816);
case 192: return new CityInfo("Oulainen", "17", 64.26667, 24.8);
case 193: return new CityInfo("Otaniemi", "01", 60.18395, 24.82786);
case 194: return new CityInfo("Östersundom", "01", 60.25778, 25.19278);
case 195: return new CityInfo("Orivesi", "06", 61.67766, 24.3572);
case 196: return new CityInfo("Oripää", "02", 60.85, 22.68333);
case 197: return new CityInfo("Orimattila", "07", 60.80487, 25.72964);
case 198: return new CityInfo("Oravais", "15", 63.30135, 22.37821);
case 199: return new CityInfo("Oitti", "05", 60.78333, 25.03333);
case 200: return new CityInfo("Nykarleby", "15", 63.52277, 22.53073);
case 201: return new CityInfo("Nurmo", "14", 62.8287, 22.9099);
case 202: return new CityInfo("Nurmijärvi", "01", 60.46407, 24.8073);
case 203: return new CityInfo("Nurmes", "12", 63.54205, 29.13965);
case 204: return new CityInfo("Nuijamaa", "09", 60.96011, 28.55104);
case 205: return new CityInfo("Nousiainen", "02", 60.60416, 22.07926);
case 206: return new CityInfo("Noormarkku", "04", 61.59274, 21.86846);
case 207: return new CityInfo("Nokia", "06", 61.46667, 23.5);
case 208: return new CityInfo("Nivala", "17", 63.91667, 24.96667);
case 209: return new CityInfo("Nilsiä", "11", 63.20746, 28.08222);
case 210: return new CityInfo("Nickby", "01", 60.38333, 25.28333);
case 211: return new CityInfo("Nastola", "07", 60.95, 25.93333);
case 212: return new CityInfo("Närpes", "15", 62.47283, 21.33707);
case 213: return new CityInfo("Nakkila", "04", 61.36667, 22);
case 214: return new CityInfo("Nagu", "02", 60.19375, 21.90972);
case 215: return new CityInfo("Naantali", "02", 60.46744, 22.02428);
case 216: return new CityInfo("Myrskylä", "01", 60.66965, 25.8475);
case 217: return new CityInfo("Mynämäki", "02", 60.67915, 21.99274);
case 218: return new CityInfo("Muurla", "02", 60.35, 23.28333);
case 219: return new CityInfo("Muurame", "13", 62.13333, 25.66667);
case 220: return new CityInfo("Muonio", "19", 67.95, 23.7);
case 221: return new CityInfo("Munkkiniemi", "01", 60.19861, 24.87772);
case 222: return new CityInfo("Multia", "13", 62.41667, 24.78333);
case 223: return new CityInfo("Muhos", "17", 64.80798, 25.99314);
case 224: return new CityInfo("Muhos", "17", 64.76667, 26.1);
case 225: return new CityInfo("Mouhijärvi", "06", 61.5, 23.01667);
case 226: return new CityInfo("Mikkeli", "10", 61.68857, 27.27227);
case 227: return new CityInfo("Mietoinen", "02", 60.63333, 21.93333);
case 228: return new CityInfo("Miehikkälä", "08", 60.66667, 27.7);
case 229: return new CityInfo("Merimasku", "02", 60.48333, 21.86667);
case 230: return new CityInfo("Merikarvia", "04", 61.85839, 21.50035);
case 231: return new CityInfo("Merijärvi", "17", 64.3, 24.45);
case 232: return new CityInfo("Mellunkylä", "01", 60.23355, 25.09947);
case 233: return new CityInfo("Mellilä", "02", 60.76667, 22.95);
case 234: return new CityInfo("Masku", "02", 60.57082, 22.09883);
case 235: return new CityInfo("Marttila", "02", 60.58333, 22.9);
case 236: return new CityInfo("Mäntyharju", "10", 61.41667, 26.88333);
case 237: return new CityInfo("Mänttä", "06", 62.03014, 24.62791);
case 238: return new CityInfo("Mäntsälä", "01", 60.63333, 25.31667);
case 239: return new CityInfo("Malax", "15", 62.94225, 21.57311);
case 240: return new CityInfo("Maaninka", "11", 63.15523, 27.29939);
case 241: return new CityInfo("Luvia", "04", 61.36375, 21.62556);
case 242: return new CityInfo("Luumäki", "09", 60.92618, 27.58135);
case 243: return new CityInfo("Luopioinen", "06", 61.36293, 24.66781);
case 244: return new CityInfo("Lumijoki", "17", 64.83744, 25.18607);
case 245: return new CityInfo("Luhanka", "13", 61.79682, 25.70457);
case 246: return new CityInfo("Lovisa", "01", 60.45659, 26.22505);
case 247: return new CityInfo("Loppi", "05", 60.71667, 24.45);
case 248: return new CityInfo("Loimaa", "02", 60.84972, 23.0561);
case 249: return new CityInfo("Lohtaja", "16", 64.02472, 23.50482);
case 250: return new CityInfo("Lohja", "01", 60.24859, 24.06534);
case 251: return new CityInfo("Liperi", "12", 62.53333, 29.36667);
case 252: return new CityInfo("Liminka", "17", 64.80985, 25.41545);
case 253: return new CityInfo("Liljendal", "01", 60.57346, 26.05257);
case 254: return new CityInfo("Lieto", "02", 60.51032, 22.46176);
case 255: return new CityInfo("Lieksa", "12", 63.31667, 30.01667);
case 256: return new CityInfo("Lestijärvi", "16", 63.53333, 24.65);
case 257: return new CityInfo("Leppävirta", "11", 62.49009, 27.78262);
case 258: return new CityInfo("Lemu", "02", 60.56667, 21.96667);
case 259: return new CityInfo("Lempäälä", "06", 61.31667, 23.75);
case 260: return new CityInfo("Lemi", "09", 61.06244, 27.80571);
case 261: return new CityInfo("Leivonmäki", "13", 61.91198, 26.12796);
case 262: return new CityInfo("Lehtimäki", "14", 62.78333, 23.91667);
case 263: return new CityInfo("Lavia", "04", 61.6, 22.6);
case 264: return new CityInfo("Lauttasaari", "01", 60.15896, 24.86797);
case 265: return new CityInfo("Laukaa", "13", 62.41407, 25.95194);
case 266: return new CityInfo("Larsmo", "15", 63.75388, 22.74728);
case 267: return new CityInfo("Lapua", "14", 62.96927, 23.0088);
case 268: return new CityInfo("Lepplax", "15", 63.67028, 22.89325);
case 269: return new CityInfo("Lappi", "04", 61.1, 21.83333);
case 270: return new CityInfo("Lappeenranta", "09", 61.05871, 28.18871);
case 271: return new CityInfo("Lappajärvi", "14", 63.2, 23.63333);
case 272: return new CityInfo("Lapinlahti", "11", 63.36667, 27.4);
case 273: return new CityInfo("Lapinjärvi", "01", 60.62443, 26.1972);
case 274: return new CityInfo("Längelmäki", "04", 61.65, 22.1);
case 275: return new CityInfo("Lammi", "05", 61.08333, 25.01667);
case 276: return new CityInfo("Laitila", "02", 60.87575, 21.69765);
case 277: return new CityInfo("Laihia", "15", 62.97609, 22.01143);
case 278: return new CityInfo("Lahti", "07", 60.98267, 25.66151);
case 279: return new CityInfo("Kyyjärvi", "13", 63.03333, 24.56667);
case 280: return new CityInfo("Kyrö", "02", 60.7, 22.75);
case 281: return new CityInfo("Kirkkonummi", "01", 60.12381, 24.43853);
case 282: return new CityInfo("Kylmäkoski", "06", 61.154, 23.68858);
case 283: return new CityInfo("Kuusjoki", "02", 60.51667, 23.2);
case 284: return new CityInfo("Kuusamo", "17", 65.96667, 29.18333);
case 285: return new CityInfo("Kustavi", "02", 60.54529, 21.3588);
case 286: return new CityInfo("Kuru", "06", 61.87558, 23.71948);
case 287: return new CityInfo("Kurikka", "14", 62.61667, 22.41667);
case 288: return new CityInfo("Kuortane", "14", 62.8, 23.5);
case 289: return new CityInfo("Kuopio", "11", 62.89238, 27.67703);
case 290: return new CityInfo("Kullaa", "04", 61.46998, 22.16145);
case 291: return new CityInfo("Kuivaniemi", "17", 65.57847, 25.18814);
case 292: return new CityInfo("Kuhmoinen", "13", 61.56667, 25.18333);
case 293: return new CityInfo("Kuhmo", "18", 64.13333, 29.51667);
case 294: return new CityInfo("Kuhmalahti", "06", 61.5, 24.56667);
case 295: return new CityInfo("Kronoby", "15", 63.72859, 23.03387);
case 296: return new CityInfo("Kristinestad", "15", 62.27429, 21.37596);
case 297: return new CityInfo("Köyliö", "04", 61.1191, 22.30976);
case 298: return new CityInfo("Kouvola", "08", 60.86667, 26.7);
case 299: return new CityInfo("Kotka", "08", 60.4664, 26.94582);
case 300: return new CityInfo("Hämeenkoski", "07", 61.02222, 25.15417);
case 301: return new CityInfo("Koski Tl", "02", 60.65, 23.15);
case 302: return new CityInfo("Kortesjärvi", "14", 63.3, 23.16667);
case 303: return new CityInfo("Korsnäs", "15", 62.78333, 21.2);
case 304: return new CityInfo("Korsholm", "15", 63.11418, 21.68216);
case 305: return new CityInfo("Korppoo", "02", 60.1638, 21.56151);
case 306: return new CityInfo("Korpilahti", "13", 62.01667, 25.55);
case 307: return new CityInfo("Kontiolahti", "12", 62.76023, 29.84711);
case 308: return new CityInfo("Konnevesi", "13", 62.61667, 26.31667);
case 309: return new CityInfo("Kolari", "19", 67.33047, 23.77785);
case 310: return new CityInfo("Kokkola", "16", 63.83847, 23.13066);
case 311: return new CityInfo("Kokemäki", "04", 61.25647, 22.35643);
case 312: return new CityInfo("Kodisjoki", "04", 61.0293, 21.70028);
case 313: return new CityInfo("Kivijärvi", "13", 63.11984, 25.07835);
case 314: return new CityInfo("Kiuruvesi", "11", 63.65, 26.61667);
case 315: return new CityInfo("Kiukainen", "04", 61.21667, 22.08333);
case 316: return new CityInfo("Kittilä", "19", 67.66474, 24.89356);
case 317: return new CityInfo("Kitee", "12", 62.1, 30.15);
case 318: return new CityInfo("Kisko", "02", 60.23333, 23.48333);
case 319: return new CityInfo("Kinnula", "13", 63.38333, 24.95);
case 320: return new CityInfo("Kinnula", "13", 63.36667, 24.96667);
case 321: return new CityInfo("Kimito", "02", 60.16047, 22.729);
case 322: return new CityInfo("Kiiminki", "17", 65.13139, 25.79744);
case 323: return new CityInfo("Kiikoinen", "06", 61.45385, 22.57699);
case 324: return new CityInfo("Kiikala", "02", 60.46667, 23.56667);
case 325: return new CityInfo("Kiihtelysvaara", "12", 62.49525, 30.25081);
case 326: return new CityInfo("Kihniö", "06", 62.2, 23.18333);
case 327: return new CityInfo("Keuruu", "13", 62.26667, 24.7);
case 328: return new CityInfo("Kestilä", "17", 64.35002, 26.27921);
case 329: return new CityInfo("Kesälahti", "12", 61.89752, 29.83494);
case 330: return new CityInfo("Kerimäki", "10", 61.91069, 29.28228);
case 331: return new CityInfo("Kerava", "01", 60.40338, 25.105);
case 332: return new CityInfo("Kempele", "17", 64.91314, 25.50339);
case 333: return new CityInfo("Kemijärvi", "19", 66.71309, 27.43056);
case 334: return new CityInfo("Keminmaa", "19", 65.80158, 24.54483);
case 335: return new CityInfo("Kemi", "19", 65.73641, 24.56371);
case 336: return new CityInfo("Kellokoski", "01", 60.53271, 25.10917);
case 337: return new CityInfo("Keitele", "11", 63.18333, 26.36667);
case 338: return new CityInfo("Kaustinen", "16", 63.54878, 23.68845);
case 339: return new CityInfo("Kauniainen", "01", 60.21209, 24.72756);
case 340: return new CityInfo("Kauhava", "14", 63.10299, 23.07129);
case 341: return new CityInfo("Kauhajoki", "14", 62.43333, 22.18333);
case 342: return new CityInfo("Kaskinen", "15", 62.38444, 21.22331);
case 343: return new CityInfo("Karvia", "04", 62.2, 22.65);
case 344: return new CityInfo("Karvia", "04", 62.13333, 22.56667);
case 345: return new CityInfo("Karttula", "11", 62.8963, 26.97045);
case 346: return new CityInfo("Karstula", "13", 62.86667, 24.78333);
case 347: return new CityInfo("Kärsämäki", "17", 63.96667, 25.76667);
case 348: return new CityInfo("Kärkölä", "07", 60.91667, 25.25);
case 349: return new CityInfo("Kärkölä", "01", 60.61292, 23.94196);
case 350: return new CityInfo("Karkkila", "01", 60.53418, 24.20977);
case 351: return new CityInfo("Karjalohja", "01", 60.24015, 23.71789);
case 352: return new CityInfo("Karis", "01", 60.07178, 23.66163);
case 353: return new CityInfo("Karinainen", "02", 60.66667, 22.76667);
case 354: return new CityInfo("Karijoki", "14", 62.30851, 21.70856);
case 355: return new CityInfo("Karhula", "08", 60.52156, 26.93125);
case 356: return new CityInfo("Kannus", "16", 63.9, 23.9);
case 357: return new CityInfo("Kannonkoski", "13", 62.96667, 25.25);
case 358: return new CityInfo("Kankaanpää", "04", 61.8, 22.41667);
case 359: return new CityInfo("Kangasniemi", "10", 61.99357, 26.64785);
case 360: return new CityInfo("Kangaslampi", "11", 62.29563, 28.25289);
case 361: return new CityInfo("Kangasala", "06", 61.46383, 24.07602);
case 362: return new CityInfo("Kalvola", "05", 61.10081, 24.12177);
case 363: return new CityInfo("Kälviä", "16", 63.86067, 23.45289);
case 364: return new CityInfo("Kallio", "01", 60.18427, 24.95034);
case 365: return new CityInfo("Kållby", "15", 63.62542, 22.89594);
case 366: return new CityInfo("Kalajoki", "17", 64.25, 23.95);
case 367: return new CityInfo("Kajaani", "18", 64.22728, 27.72846);
case 368: return new CityInfo("Kaavi", "11", 62.98333, 28.5);
case 369: return new CityInfo("Kaarina", "02", 60.40724, 22.36904);
case 370: return new CityInfo("Kaarela", "01", 60.25174, 24.88111);
case 371: return new CityInfo("Jyväskylä", "13", 62.24147, 25.72088);
case 372: return new CityInfo("Juva", "10", 61.9, 27.85);
case 373: return new CityInfo("Juupajoki", "06", 61.79901, 24.36939);
case 374: return new CityInfo("Juuka", "12", 63.23333, 29.25);
case 375: return new CityInfo("Jurva", "14", 62.68333, 21.98333);
case 376: return new CityInfo("Juankoski", "11", 63.06667, 28.35);
case 377: return new CityInfo("Joutseno", "09", 61.11796, 28.50763);
case 378: return new CityInfo("Joutsa", "13", 61.73333, 26.11667);
case 379: return new CityInfo("Joroinen", "10", 62.17823, 27.83165);
case 380: return new CityInfo("Jokioinen", "05", 60.80162, 23.48004);
case 381: return new CityInfo("Joensuu", "12", 62.60118, 29.76316);
case 382: return new CityInfo("Järvenpää", "01", 60.47369, 25.08992);
case 383: return new CityInfo("Järvelä", "07", 60.86667, 25.28333);
case 384: return new CityInfo("Jäppilä", "10", 62.37899, 27.43372);
case 385: return new CityInfo("Janakkala", "05", 60.9, 24.6);
case 386: return new CityInfo("Jämsänkoski", "13", 61.919, 25.17011);
case 387: return new CityInfo("Jämsä", "13", 61.8642, 25.19002);
case 388: return new CityInfo("Jämijärvi", "04", 61.81667, 22.7);
case 389: return new CityInfo("Jalasjärvi", "14", 62.5, 22.75);
case 390: return new CityInfo("Jakobstad", "15", 63.67486, 22.70256);
case 391: return new CityInfo("Jaala", "08", 61.05251, 26.48117);
case 392: return new CityInfo("Ivalo", "19", 68.65986, 27.53891);
case 393: return new CityInfo("Isokyrö", "15", 63.01172, 22.33332);
case 394: return new CityInfo("Isojoki", "14", 62.11319, 21.95884);
case 395: return new CityInfo("Iniö", "02", 60.4, 21.4);
case 396: return new CityInfo("Ingå", "01", 60.04587, 24.00459);
case 397: return new CityInfo("Inari", "19", 68.90596, 27.02881);
case 398: return new CityInfo("Imatra", "09", 61.17185, 28.75242);
case 399: return new CityInfo("Ilomantsi", "12", 62.67162, 30.93276);
case 400: return new CityInfo("Ilmajoki", "14", 62.73333, 22.56667);
case 401: return new CityInfo("Ikaalinen", "06", 61.76951, 23.0658);
case 402: return new CityInfo("Iitti", "08", 60.89488, 26.33869);
case 403: return new CityInfo("Iisalmi", "11", 63.55915, 27.19067);
case 404: return new CityInfo("Ii", "17", 65.31735, 25.3731);
case 405: return new CityInfo("Hyvinge", "01", 60.63333, 24.86667);
case 406: return new CityInfo("Hyrynsalmi", "18", 64.66667, 28.53333);
case 407: return new CityInfo("Humppila", "05", 60.93333, 23.36667);
case 408: return new CityInfo("Huittinen", "04", 61.18333, 22.7);
case 409: return new CityInfo("Houtskär", "02", 60.22284, 21.37218);
case 410: return new CityInfo("Honkajoki", "04", 61.98333, 22.26667);
case 411: return new CityInfo("Hollola", "07", 61.05, 25.43333);
case 412: return new CityInfo("Hollola", "07", 61, 25.5);
case 413: return new CityInfo("Hirvensalmi", "10", 61.63333, 26.8);
case 414: return new CityInfo("Himanka", "17", 64.06218, 23.65447);
case 415: return new CityInfo("Helsinki", "01", 60.16952, 24.93545);
case 416: return new CityInfo("Heinola", "07", 61.20564, 26.03811);
case 417: return new CityInfo("Heinävesi", "10", 62.43333, 28.6);
case 418: return new CityInfo("Hausjärvi", "05", 60.78333, 24.93333);
case 419: return new CityInfo("Haukivuori", "10", 62.01753, 27.21906);
case 420: return new CityInfo("Haukipudas", "17", 65.17654, 25.35233);
case 421: return new CityInfo("Hauho", "05", 61.17255, 24.56303);
case 422: return new CityInfo("Hartola", "07", 61.58333, 26.01667);
case 423: return new CityInfo("Harjavalta", "04", 61.31667, 22.13333);
case 424: return new CityInfo("Hankasalmi", "13", 62.38333, 26.43333);
case 425: return new CityInfo("Hanko", "01", 59.83333, 22.95);
case 426: return new CityInfo("Hamina", "08", 60.56974, 27.19794);
case 427: return new CityInfo("Hämeenlinna", "05", 60.99596, 24.46434);
case 428: return new CityInfo("Hämeenkyrö", "06", 61.63913, 23.19531);
case 429: return new CityInfo("Halsua", "16", 63.46667, 24.16667);
case 430: return new CityInfo("Halikko", "02", 60.4, 23.08333);
case 431: return new CityInfo("Hailuoto", "17", 65.009, 24.71385);
case 432: return new CityInfo("Haapavesi", "17", 64.13333, 25.36667);
case 433: return new CityInfo("Haapajärvi", "17", 63.75, 25.33333);
case 434: return new CityInfo("Gumböle", "01", 60.21948, 24.61684);
case 435: return new CityInfo("Forssa", "05", 60.81462, 23.62146);
case 436: return new CityInfo("Evijärvi", "14", 63.36667, 23.48333);
case 437: return new CityInfo("Eurajoki", "04", 61.2, 21.73333);
case 438: return new CityInfo("Eura", "04", 61.13333, 22.13333);
case 439: return new CityInfo("Esse", "15", 63.59371, 23.05738);
case 440: return new CityInfo("Espoo", "01", 60.2052, 24.6522);
case 441: return new CityInfo("Enontekiö", "19", 68.38573, 23.63215);
case 442: return new CityInfo("Enonkoski", "10", 62.08333, 28.93333);
case 443: return new CityInfo("Eno", "12", 62.80511, 30.15422);
case 444: return new CityInfo("Elimäki", "08", 60.71667, 26.46667);
case 445: return new CityInfo("Ekenäs", "01", 59.97359, 23.43389);
case 446: return new CityInfo("Edsevö", "15", 63.63549, 22.85741);
case 447: return new CityInfo("Dragsfjärd", "02", 60.06667, 22.48333);
case 448: return new CityInfo("Porvoo", "01", 60.39233, 25.66507);
case 449: return new CityInfo("Bennäs", "15", 63.6, 22.8);
case 450: return new CityInfo("Auttoinen", "07", 61.29901, 25.08887);
case 451: return new CityInfo("Aura", "02", 60.6471, 22.58755);
case 452: return new CityInfo("Askola", "01", 60.53333, 25.6);
case 453: return new CityInfo("Askainen", "02", 60.56667, 21.86667);
case 454: return new CityInfo("Asikkala", "07", 61.21667, 25.5);
case 455: return new CityInfo("Artjärvi", "07", 60.74544, 26.07084);
case 456: return new CityInfo("Anjala", "08", 60.68333, 26.83333);
case 457: return new CityInfo("Alavus", "14", 62.58333, 23.61667);
case 458: return new CityInfo("Alavieska", "17", 64.16667, 24.3);
case 459: return new CityInfo("Alastaro", "02", 60.95, 22.85);
case 460: return new CityInfo("Alajärvi", "14", 63, 23.81667);
case 461: return new CityInfo("Alahärmä", "14", 63.23333, 22.85);
case 462: return new CityInfo("Ähtäri", "14", 62.55403, 24.06186);
case 463: return new CityInfo("Äänekoski", "13", 62.6, 25.73333);
case 464: return new CityInfo("Äetsä", "06", 61.28333, 22.68333);
case 465: return new CityInfo("Kilo", "01", 60.21746, 24.78151);
case 466: return new CityInfo("Suomenlinna", "01", 60.14784, 24.98561);
case 467: return new CityInfo("Levi", "19", 67.80509, 24.79614);
case 468: return new CityInfo("Koukkuniemi", "01", 60.15261, 24.76467);
case 469: return new CityInfo("Ristinummi", "15", 63.09192, 21.72297);
case 470: return new CityInfo("Teeriniemi", "15", 63.09705, 21.6959);
case 471: return new CityInfo("Hietalahti", "15", 63.0848, 21.61716);
case 472: return new CityInfo("Toijala", "06", 61.1678, 23.83819);
case 473: return new CityInfo("Väståboland", "02", 60.29972, 22.3004);
case 474: return new CityInfo("Katariina", "08", 60.45284, 26.94276);
default: return new CityInfo("Älajärvi", "14", 63.00027, 23.81586);

                                    }                                        
                                }
                            
                        }
                    }
                