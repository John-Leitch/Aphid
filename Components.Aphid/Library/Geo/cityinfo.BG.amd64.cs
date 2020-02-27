
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
                                    public const string Country = "BG";
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
                            
                                        var cur = (Math.Abs(43.1896 - lat) + Math.Abs(27.70429 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(41.3795 - lat) + Math.Abs(25.09605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.71667 - lat) + Math.Abs(24.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.05 - lat) + Math.Abs(25.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.47889 - lat) + Math.Abs(22.74917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.4 - lat) + Math.Abs(25.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76036 - lat) + Math.Abs(26.68063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.48333 - lat) + Math.Abs(26.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02528 - lat) + Math.Abs(23.68417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.63472 - lat) + Math.Abs(23.3535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03139 - lat) + Math.Abs(24.11278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.19356 - lat) + Math.Abs(23.2868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43 - lat) + Math.Abs(26.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.4 - lat) + Math.Abs(27.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.69281 - lat) + Math.Abs(23.44518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21 - lat) + Math.Abs(23.5625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7136 - lat) + Math.Abs(27.75867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.99159 - lat) + Math.Abs(22.88236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.31667 - lat) + Math.Abs(27.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.7 - lat) + Math.Abs(26.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55 - lat) + Math.Abs(26.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02754 - lat) + Math.Abs(23.99155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.08124 - lat) + Math.Abs(25.62904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21667 - lat) + Math.Abs(27.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.1 - lat) + Math.Abs(24.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7 - lat) + Math.Abs(25.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.04906 - lat) + Math.Abs(26.61206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.2512 - lat) + Math.Abs(26.57215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.53588 - lat) + Math.Abs(25.65764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.86667 - lat) + Math.Abs(25.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.83528 - lat) + Math.Abs(22.65167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.89427 - lat) + Math.Abs(24.71589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.9 - lat) + Math.Abs(25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.08333 - lat) + Math.Abs(26.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.56667 - lat) + Math.Abs(27.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.85 - lat) + Math.Abs(26.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.91667 - lat) + Math.Abs(24.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.74789 - lat) + Math.Abs(27.40911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.59692 - lat) + Math.Abs(22.95634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.96667 - lat) + Math.Abs(23.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61875 - lat) + Math.Abs(25.35033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76667 - lat) + Math.Abs(26.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.33058 - lat) + Math.Abs(27.59908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73835 - lat) + Math.Abs(24.02435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.76667 - lat) + Math.Abs(26.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.19167 - lat) + Math.Abs(25.18111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.26667 - lat) + Math.Abs(24.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63333 - lat) + Math.Abs(23.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5 - lat) + Math.Abs(24.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.23333 - lat) + Math.Abs(25.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6 - lat) + Math.Abs(26.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43278 - lat) + Math.Abs(25.64194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.8 - lat) + Math.Abs(23.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.26667 - lat) + Math.Abs(23.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76667 - lat) + Math.Abs(25.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.13333 - lat) + Math.Abs(24.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.70168 - lat) + Math.Abs(28.30399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.41801 - lat) + Math.Abs(27.6956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.69751 - lat) + Math.Abs(23.32415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.06667 - lat) + Math.Abs(27.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.57439 - lat) + Math.Abs(24.71204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94248 - lat) + Math.Abs(26.20464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.85182 - lat) + Math.Abs(23.03792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.68583 - lat) + Math.Abs(26.32917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46667 - lat) + Math.Abs(24.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.0273 - lat) + Math.Abs(27.01982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.88333 - lat) + Math.Abs(23.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.03333 - lat) + Math.Abs(25.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.1171 - lat) + Math.Abs(27.26056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.27064 - lat) + Math.Abs(26.92286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.71667 - lat) + Math.Abs(25.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.53983 - lat) + Math.Abs(28.53429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.02583 - lat) + Math.Abs(25.11361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.21138 - lat) + Math.Abs(24.12946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.65 - lat) + Math.Abs(26.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.61667 - lat) + Math.Abs(23.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.56079 - lat) + Math.Abs(27.52195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.28333 - lat) + Math.Abs(23.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56667 - lat) + Math.Abs(23.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51667 - lat) + Math.Abs(26.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.337 - lat) + Math.Abs(23.5528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.13178 - lat) + Math.Abs(24.93999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.62179 - lat) + Math.Abs(22.83286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.84872 - lat) + Math.Abs(25.9534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.8 - lat) + Math.Abs(27.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48751 - lat) + Math.Abs(24.84945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15 - lat) + Math.Abs(23.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.13333 - lat) + Math.Abs(23.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.8863 - lat) + Math.Abs(23.46714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.53333 - lat) + Math.Abs(26.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.64185 - lat) + Math.Abs(27.67713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.27408 - lat) + Math.Abs(24.94083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.99012 - lat) + Math.Abs(24.0873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54565 - lat) + Math.Abs(22.96553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3 - lat) + Math.Abs(25.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15 - lat) + Math.Abs(25.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.1 - lat) + Math.Abs(25.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.18333 - lat) + Math.Abs(27.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.26791 - lat) + Math.Abs(27.75611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.16667 - lat) + Math.Abs(26.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88333 - lat) + Math.Abs(23.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.07641 - lat) + Math.Abs(23.08592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38333 - lat) + Math.Abs(24.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35 - lat) + Math.Abs(26.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.56326 - lat) + Math.Abs(27.62986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.37233 - lat) + Math.Abs(25.63525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.15 - lat) + Math.Abs(24.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.36667 - lat) + Math.Abs(27.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.41667 - lat) + Math.Abs(24.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7 - lat) + Math.Abs(24.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39846 - lat) + Math.Abs(23.20702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.03372 - lat) + Math.Abs(24.29995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.05 - lat) + Math.Abs(24.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6 - lat) + Math.Abs(23.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.45 - lat) + Math.Abs(24.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.2 - lat) + Math.Abs(24.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.24278 - lat) + Math.Abs(25.32194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6 - lat) + Math.Abs(25.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49518 - lat) + Math.Abs(24.19021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.73618 - lat) + Math.Abs(23.96052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.21667 - lat) + Math.Abs(25.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.45 - lat) + Math.Abs(26.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.1 - lat) + Math.Abs(26.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.81998 - lat) + Math.Abs(27.88007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.16214 - lat) + Math.Abs(22.78376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35 - lat) + Math.Abs(27.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.48333 - lat) + Math.Abs(26.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.70528 - lat) + Math.Abs(24.89521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.56667 - lat) + Math.Abs(27.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.63333 - lat) + Math.Abs(25.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.25551 - lat) + Math.Abs(22.85175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.65921 - lat) + Math.Abs(27.73602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45602 - lat) + Math.Abs(25.08008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6 - lat) + Math.Abs(25.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68623 - lat) + Math.Abs(23.85371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7 - lat) + Math.Abs(23.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.91667 - lat) + Math.Abs(25.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.4125 - lat) + Math.Abs(23.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.16955 - lat) + Math.Abs(27.84541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15 - lat) + Math.Abs(23.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76667 - lat) + Math.Abs(26.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.62403 - lat) + Math.Abs(23.16876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.97958 - lat) + Math.Abs(27.52477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76794 - lat) + Math.Abs(22.66406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63461 - lat) + Math.Abs(25.86439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49869 - lat) + Math.Abs(24.93973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83333 - lat) + Math.Abs(26.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.11111 - lat) + Math.Abs(25.72833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.2 - lat) + Math.Abs(24.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.85 - lat) + Math.Abs(24.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.36667 - lat) + Math.Abs(26.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.13333 - lat) + Math.Abs(24.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82106 - lat) + Math.Abs(23.23677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.36667 - lat) + Math.Abs(25.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.31167 - lat) + Math.Abs(25.07333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35626 - lat) + Math.Abs(24.1119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.05 - lat) + Math.Abs(23.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.28389 - lat) + Math.Abs(22.69111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65 - lat) + Math.Abs(25.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.88833 - lat) + Math.Abs(22.52139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.79658 - lat) + Math.Abs(26.50063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.81675 - lat) + Math.Abs(27.75552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47127 - lat) + Math.Abs(25.65485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.37444 - lat) + Math.Abs(23.48444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.05 - lat) + Math.Abs(24.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73333 - lat) + Math.Abs(23.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.34157 - lat) + Math.Abs(28.05759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.77864 - lat) + Math.Abs(23.72058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35 - lat) + Math.Abs(24.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88333 - lat) + Math.Abs(26.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.81667 - lat) + Math.Abs(23.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.63333 - lat) + Math.Abs(24.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.36385 - lat) + Math.Abs(23.10669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.08439 - lat) + Math.Abs(23.0571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5 - lat) + Math.Abs(24.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7 - lat) + Math.Abs(24.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.08333 - lat) + Math.Abs(27.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.23424 - lat) + Math.Abs(27.7749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.32715 - lat) + Math.Abs(25.36379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.98333 - lat) + Math.Abs(25.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61667 - lat) + Math.Abs(26.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5 - lat) + Math.Abs(24.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.60193 - lat) + Math.Abs(23.66135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.93415 - lat) + Math.Abs(25.55557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.93333 - lat) + Math.Abs(25.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52222 - lat) + Math.Abs(23.86861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5 - lat) + Math.Abs(26.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.61667 - lat) + Math.Abs(25.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.99278 - lat) + Math.Abs(27.50713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.43601 - lat) + Math.Abs(28.33953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.31667 - lat) + Math.Abs(27.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.65 - lat) + Math.Abs(26.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.63333 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61667 - lat) + Math.Abs(27.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57084 - lat) + Math.Abs(27.29875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35 - lat) + Math.Abs(24.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.61667 - lat) + Math.Abs(24.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52672 - lat) + Math.Abs(26.1249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68568 - lat) + Math.Abs(25.95565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.71667 - lat) + Math.Abs(26.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.6708 - lat) + Math.Abs(24.45233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43333 - lat) + Math.Abs(23.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.6 - lat) + Math.Abs(23.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.66667 - lat) + Math.Abs(25.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.64109 - lat) + Math.Abs(24.69368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.13333 - lat) + Math.Abs(25.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.34747 - lat) + Math.Abs(27.17898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.83738 - lat) + Math.Abs(22.65279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.66326 - lat) + Math.Abs(24.37557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56667 - lat) + Math.Abs(23.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.12778 - lat) + Math.Abs(25.70167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.68333 - lat) + Math.Abs(23.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.85 - lat) + Math.Abs(26.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.01682 - lat) + Math.Abs(23.04852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.91667 - lat) + Math.Abs(26.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.99296 - lat) + Math.Abs(27.71596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38611 - lat) + Math.Abs(23.03056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.70123 - lat) + Math.Abs(28.03787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.43333 - lat) + Math.Abs(26.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.87472 - lat) + Math.Abs(25.33417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.8 - lat) + Math.Abs(25.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.83333 - lat) + Math.Abs(24 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38333 - lat) + Math.Abs(25.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.16667 - lat) + Math.Abs(26.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.66667 - lat) + Math.Abs(23.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.93333 - lat) + Math.Abs(25.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49566 - lat) + Math.Abs(25.30363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.59258 - lat) + Math.Abs(25.87486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.92111 - lat) + Math.Abs(22.82111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.81667 - lat) + Math.Abs(27.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.05 - lat) + Math.Abs(27.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.97897 - lat) + Math.Abs(25.4785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.69134 - lat) + Math.Abs(22.97365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.92191 - lat) + Math.Abs(22.93109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.64462 - lat) + Math.Abs(24.15857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.4 - lat) + Math.Abs(24.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46667 - lat) + Math.Abs(24.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3 - lat) + Math.Abs(23.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.74167 - lat) + Math.Abs(22.72694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.05 - lat) + Math.Abs(25.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.22222 - lat) + Math.Abs(27.56944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.74327 - lat) + Math.Abs(24.40003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03333 - lat) + Math.Abs(25.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51806 - lat) + Math.Abs(22.66611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.2 - lat) + Math.Abs(25.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38417 - lat) + Math.Abs(22.88083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.27884 - lat) + Math.Abs(24.08251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.44408 - lat) + Math.Abs(27.63902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73333 - lat) + Math.Abs(24.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7 - lat) + Math.Abs(24.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.65 - lat) + Math.Abs(24.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46667 - lat) + Math.Abs(23.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.2 - lat) + Math.Abs(25.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.87426 - lat) + Math.Abs(27.88865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.50606 - lat) + Math.Abs(27.46781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.76667 - lat) + Math.Abs(23.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.66075 - lat) + Math.Abs(23.06732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35 - lat) + Math.Abs(25.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.74085 - lat) + Math.Abs(22.90723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15167 - lat) + Math.Abs(22.6425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3 - lat) + Math.Abs(25.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.01667 - lat) + Math.Abs(24.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.75 - lat) + Math.Abs(23.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.9565 - lat) + Math.Abs(22.53255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.47222 - lat) + Math.Abs(23.33583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.0325 - lat) + Math.Abs(23.37806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.9 - lat) + Math.Abs(23.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.50086 - lat) + Math.Abs(25.80992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.10566 - lat) + Math.Abs(23.02003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.43333 - lat) + Math.Abs(23.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68408 - lat) + Math.Abs(24.293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.14962 - lat) + Math.Abs(26.81116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.36256 - lat) + Math.Abs(23.00324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.15296 - lat) + Math.Abs(23.00146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.06795 - lat) + Math.Abs(27.86744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.01667 - lat) + Math.Abs(23.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.23581 - lat) + Math.Abs(23.12738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.21239 - lat) + Math.Abs(24.02081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.62722 - lat) + Math.Abs(22.68361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.95694 - lat) + Math.Abs(23.5725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.64594 - lat) + Math.Abs(25.12627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.94225 - lat) + Math.Abs(24.21843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.73802 - lat) + Math.Abs(27.49643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.8383 - lat) + Math.Abs(23.48851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.61667 - lat) + Math.Abs(25.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.42166 - lat) + Math.Abs(28.15848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.7 - lat) + Math.Abs(27.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.11667 - lat) + Math.Abs(27.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.18067 - lat) + Math.Abs(27.88823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.01667 - lat) + Math.Abs(24.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.65 - lat) + Math.Abs(25.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58333 - lat) + Math.Abs(25.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.84142 - lat) + Math.Abs(24.91759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15 - lat) + Math.Abs(26.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.75 - lat) + Math.Abs(24.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94525 - lat) + Math.Abs(27.28751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.25615 - lat) + Math.Abs(27.82105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.09768 - lat) + Math.Abs(27.93961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.285 - lat) + Math.Abs(28.0418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.64987 - lat) + Math.Abs(27.64838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.40296 - lat) + Math.Abs(28.41189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Beloslav", "61", 43.1896, 27.70429);
case 1: return new CityInfo("Zlatograd", "57", 41.3795, 25.09605);
case 2: return new CityInfo("Zlatitsa", "58", 42.71667, 24.13333);
case 3: return new CityInfo("Zlataritsa", "62", 43.05, 25.9);
case 4: return new CityInfo("Zemen", "49", 42.47889, 22.74917);
case 5: return new CityInfo("Zelenikovo", "51", 42.4, 25.08333);
case 6: return new CityInfo("Zavet", "52", 43.76036, 26.68063);
case 7: return new CityInfo("Yambol", "65", 42.48333, 26.5);
case 8: return new CityInfo("Yakoruda", "38", 42.02528, 23.68417);
case 9: return new CityInfo("Yakimovo", "47", 43.63472, 23.3535);
case 10: return new CityInfo("Yablanitsa", "46", 43.03139, 24.11278);
case 11: return new CityInfo("Varshets", "47", 43.19356, 23.2868);
case 12: return new CityInfo("Varbitsa", "54", 43, 26.63333);
case 13: return new CityInfo("Valchidol", "61", 43.4, 27.55);
case 14: return new CityInfo("Valchedram", "47", 43.69281, 23.44518);
case 15: return new CityInfo("Vratsa", "64", 43.21, 23.5625);
case 16: return new CityInfo("Sveti Vlas", "39", 42.7136, 27.75867);
case 17: return new CityInfo("Vidin", "63", 43.99159, 22.88236);
case 18: return new CityInfo("Vetrino", "61", 43.31667, 27.43333);
case 19: return new CityInfo("Vetovo", "53", 43.7, 26.26667);
case 20: return new CityInfo("Venets", "54", 43.55, 26.93333);
case 21: return new CityInfo("Velingrad", "48", 42.02754, 23.99155);
case 22: return new CityInfo("Veliko Tŭrnovo", "62", 43.08124, 25.62904);
case 23: return new CityInfo("Varna", "61", 43.21667, 27.91667);
case 24: return new CityInfo("Ugarchin", "46", 43.1, 24.41667);
case 25: return new CityInfo("Tvarditsa", "56", 42.7, 25.9);
case 26: return new CityInfo("Tutrakan", "55", 44.04906, 26.61206);
case 27: return new CityInfo("Targovishte", "60", 43.2512, 26.57215);
case 28: return new CityInfo("Tsenovo", "53", 43.53588, 25.65764);
case 29: return new CityInfo("Tryavna", "41", 42.86667, 25.5);
case 30: return new CityInfo("Tran", "49", 42.83528, 22.65167);
case 31: return new CityInfo("Troyan", "46", 42.89427, 24.71589);
case 32: return new CityInfo("Topolovo", "51", 41.9, 25);
case 33: return new CityInfo("Topolovgrad", "43", 42.08333, 26.33333);
case 34: return new CityInfo("Dobrich", "40", 43.56667, 27.83333);
case 35: return new CityInfo("Tochilari", "52", 43.85, 26.46667);
case 36: return new CityInfo("Teteven", "46", 42.91667, 24.26667);
case 37: return new CityInfo("Tervel", "40", 43.74789, 27.40911);
case 38: return new CityInfo("Batanovtsi", "49", 42.59692, 22.95634);
case 39: return new CityInfo("Svoge", "58", 42.96667, 23.35);
case 40: return new CityInfo("Svishtov", "62", 43.61875, 25.35033);
case 41: return new CityInfo("Svilengrad", "43", 41.76667, 26.2);
case 42: return new CityInfo("Suvorovo", "61", 43.33058, 27.59908);
case 43: return new CityInfo("Sarnitsa", "48", 41.73835, 24.02435);
case 44: return new CityInfo("Sungurlare", "39", 42.76667, 26.78333);
case 45: return new CityInfo("Suhindol", "62", 43.19167, 25.18111);
case 46: return new CityInfo("Saedinenie", "51", 42.26667, 24.55);
case 47: return new CityInfo("Strumyani", "38", 41.63333, 23.2);
case 48: return new CityInfo("Strelcha", "48", 42.5, 24.31667);
case 49: return new CityInfo("Strazhitsa", "62", 43.23333, 25.96667);
case 50: return new CityInfo("Straldzha", "65", 42.6, 26.68333);
case 51: return new CityInfo("Stara Zagora", "59", 42.43278, 25.64194);
case 52: return new CityInfo("Stara Kresna", "38", 41.8, 23.18333);
case 53: return new CityInfo("Dupnitsa", "45", 42.26667, 23.11667);
case 54: return new CityInfo("Stambolovo", "43", 41.76667, 25.65);
case 55: return new CityInfo("Stamboliyski", "51", 42.13333, 24.53333);
case 56: return new CityInfo("Spasovo", "40", 43.70168, 28.30399);
case 57: return new CityInfo("Sozopol", "39", 42.41801, 27.6956);
case 58: return new CityInfo("Sofia", "42", 42.69751, 23.32415);
case 59: return new CityInfo("Smyadovo", "54", 43.06667, 27.01667);
case 60: return new CityInfo("Smolyan", "57", 41.57439, 24.71204);
case 61: return new CityInfo("Slivo Pole", "53", 43.94248, 26.20464);
case 62: return new CityInfo("Slivnitsa", "58", 42.85182, 23.03792);
case 63: return new CityInfo("Sliven", "56", 42.68583, 26.32917);
case 64: return new CityInfo("Slavyanovo", "50", 43.46667, 24.86667);
case 65: return new CityInfo("Sitovo", "55", 44.0273, 27.01982);
case 66: return new CityInfo("Simitli", "38", 41.88333, 23.11667);
case 67: return new CityInfo("Simeonovgrad", "43", 42.03333, 25.83333);
case 68: return new CityInfo("Silistra", "55", 44.1171, 27.26056);
case 69: return new CityInfo("Shumen", "54", 43.27064, 26.92286);
case 70: return new CityInfo("Shipka", "59", 42.71667, 25.33333);
case 71: return new CityInfo("Shabla", "40", 43.53983, 28.53429);
case 72: return new CityInfo("Sevlievo", "41", 43.02583, 25.11361);
case 73: return new CityInfo("Septemvri", "48", 42.21138, 24.12946);
case 74: return new CityInfo("Senovo", "53", 43.65, 26.36667);
case 75: return new CityInfo("Satovcha", "38", 41.61667, 23.98333);
case 76: return new CityInfo("Sarafovo", "39", 42.56079, 27.52195);
case 77: return new CityInfo("Sapareva Banya", "45", 42.28333, 23.26667);
case 78: return new CityInfo("Sandanski", "38", 41.56667, 23.28333);
case 79: return new CityInfo("Samuil", "52", 43.51667, 26.75);
case 80: return new CityInfo("Samokov", "58", 42.337, 23.5528);
case 81: return new CityInfo("Sadovo", "51", 42.13178, 24.93999);
case 82: return new CityInfo("Ruzhintsi", "63", 43.62179, 22.83286);
case 83: return new CityInfo("Ruse", "53", 43.84872, 25.9534);
case 84: return new CityInfo("Ruen", "39", 42.8, 27.28333);
case 85: return new CityInfo("Rudozem", "57", 41.48751, 24.84945);
case 86: return new CityInfo("Roman", "64", 43.15, 23.91667);
case 87: return new CityInfo("Rila", "45", 42.13333, 23.13333);
case 88: return new CityInfo("Razlog", "38", 41.8863, 23.46714);
case 89: return new CityInfo("Razgrad", "52", 43.53333, 26.51667);
case 90: return new CityInfo("Ravda", "39", 42.64185, 27.67713);
case 91: return new CityInfo("Rakovski", "51", 42.27408, 24.94083);
case 92: return new CityInfo("Rakitovo", "48", 41.99012, 24.0873);
case 93: return new CityInfo("Radomir", "49", 42.54565, 22.96553);
case 94: return new CityInfo("Radnevo", "59", 42.3, 25.93333);
case 95: return new CityInfo("Parvomaytsi", "62", 43.15, 25.65);
case 96: return new CityInfo("Parvomay", "51", 42.1, 25.21667);
case 97: return new CityInfo("Provadia", "61", 43.18333, 27.43333);
case 98: return new CityInfo("Primorsko", "39", 42.26791, 27.75611);
case 99: return new CityInfo("Veliki Preslav", "54", 43.16667, 26.81667);
case 100: return new CityInfo("Pravets", "58", 42.88333, 23.91667);
case 101: return new CityInfo("Porominovo", "45", 42.07641, 23.08592);
case 102: return new CityInfo("Pordim", "50", 43.38333, 24.85);
case 103: return new CityInfo("Popovo", "60", 43.35, 26.23333);
case 104: return new CityInfo("Pomorie", "39", 42.56326, 27.62986);
case 105: return new CityInfo("Polski Trambesh", "62", 43.37233, 25.63525);
case 106: return new CityInfo("Plovdiv", "51", 42.15, 24.75);
case 107: return new CityInfo("Pliska", "54", 43.36667, 27.11667);
case 108: return new CityInfo("Pleven", "50", 43.41667, 24.61667);
case 109: return new CityInfo("Pirdop", "58", 42.7, 24.18333);
case 110: return new CityInfo("Petrich", "38", 41.39846, 23.20702);
case 111: return new CityInfo("Peshtera", "48", 42.03372, 24.29995);
case 112: return new CityInfo("Perushtitsa", "51", 42.05, 24.55);
case 113: return new CityInfo("Pernik", "49", 42.6, 23.03333);
case 114: return new CityInfo("Iskar", "50", 43.45, 24.26667);
case 115: return new CityInfo("Pazardzhik", "48", 42.2, 24.33333);
case 116: return new CityInfo("Pavlikeni", "62", 43.24278, 25.32194);
case 117: return new CityInfo("Pavel Banya", "59", 42.6, 25.2);
case 118: return new CityInfo("Panagyurishte", "48", 42.49518, 24.19021);
case 119: return new CityInfo("Oryahovo", "64", 43.73618, 23.96052);
case 120: return new CityInfo("Opan", "59", 42.21667, 25.7);
case 121: return new CityInfo("Opaka", "60", 43.45, 26.16667);
case 122: return new CityInfo("Omurtag", "60", 43.1, 26.41667);
case 123: return new CityInfo("Obzor", "39", 42.81998, 27.88007);
case 124: return new CityInfo("Novo Selo", "63", 44.16214, 22.78376);
case 125: return new CityInfo("Novi Pazar", "54", 43.35, 27.2);
case 126: return new CityInfo("Nova Zagora", "56", 42.48333, 26.01667);
case 127: return new CityInfo("Nikopol", "50", 43.70528, 24.89521);
case 128: return new CityInfo("Nikola-Kozlevo", "54", 43.56667, 27.23333);
case 129: return new CityInfo("Nikolaevo", "59", 42.63333, 25.8);
case 130: return new CityInfo("Nevestino", "45", 42.25551, 22.85175);
case 131: return new CityInfo("Nesebar", "39", 42.65921, 27.73602);
case 132: return new CityInfo("Nedelino", "57", 41.45602, 25.08008);
case 133: return new CityInfo("Maglizh", "59", 42.6, 25.55);
case 134: return new CityInfo("Mizia", "64", 43.68623, 23.85371);
case 135: return new CityInfo("Mirkovo", "58", 42.7, 23.98333);
case 136: return new CityInfo("Mineralni Bani", "43", 41.91667, 25.35);
case 137: return new CityInfo("Montana", "47", 43.4125, 23.225);
case 138: return new CityInfo("Tsarevo", "39", 42.16955, 27.84541);
case 139: return new CityInfo("Mezdra", "64", 43.15, 23.7);
case 140: return new CityInfo("Medovene", "52", 43.76667, 26.51667);
case 141: return new CityInfo("Medkovets", "47", 43.62403, 23.16876);
case 142: return new CityInfo("Malko Tarnovo", "39", 41.97958, 27.52477);
case 143: return new CityInfo("Makresh", "63", 43.76794, 22.66406);
case 144: return new CityInfo("Madzharovo", "43", 41.63461, 25.86439);
case 145: return new CityInfo("Madan", "57", 41.49869, 24.93973);
case 146: return new CityInfo("Lyubimets", "43", 41.83333, 26.08333);
case 147: return new CityInfo("Lyaskovets", "62", 43.11111, 25.72833);
case 148: return new CityInfo("Lukovit", "46", 43.2, 24.16667);
case 149: return new CityInfo("Laki", "51", 41.85, 24.81667);
case 150: return new CityInfo("Loznitsa", "52", 43.36667, 26.6);
case 151: return new CityInfo("Lovech", "46", 43.13333, 24.71667);
case 152: return new CityInfo("Lom", "47", 43.82106, 23.23677);
case 153: return new CityInfo("Levski", "50", 43.36667, 25.13333);
case 154: return new CityInfo("Letnitsa", "46", 43.31167, 25.07333);
case 155: return new CityInfo("Lesichovo", "48", 42.35626, 24.1119);
case 156: return new CityInfo("Lakatnik", "58", 43.05, 23.4);
case 157: return new CityInfo("Kyustendil", "45", 42.28389, 22.69111);
case 158: return new CityInfo("Kardzhali", "44", 41.65, 25.36667);
case 159: return new CityInfo("Kula", "63", 43.88833, 22.52139);
case 160: return new CityInfo("Kubrat", "52", 43.79658, 26.50063);
case 161: return new CityInfo("Krushari", "40", 43.81675, 27.75552);
case 162: return new CityInfo("Krumovgrad", "44", 41.47127, 25.65485);
case 163: return new CityInfo("Krivodol", "64", 43.37444, 23.48444);
case 164: return new CityInfo("Krichim", "51", 42.05, 24.46667);
case 165: return new CityInfo("Kresna", "38", 41.73333, 23.15);
case 166: return new CityInfo("Kranevo", "40", 43.34157, 28.05759);
case 167: return new CityInfo("Kozloduy", "64", 43.77864, 23.72058);
case 168: return new CityInfo("Koynare", "50", 43.35, 24.13333);
case 169: return new CityInfo("Kotel", "56", 42.88333, 26.45);
case 170: return new CityInfo("Kostinbrod", "58", 42.81667, 23.21667);
case 171: return new CityInfo("Koprivshtitsa", "58", 42.63333, 24.35);
case 172: return new CityInfo("Kolarovo", "38", 41.36385, 23.10669);
case 173: return new CityInfo("Kocherinovo", "45", 42.08439, 23.0571);
case 174: return new CityInfo("Knezha", "50", 43.5, 24.08333);
case 175: return new CityInfo("Klisura", "51", 42.7, 24.45);
case 176: return new CityInfo("Kiten", "61", 43.08333, 27.31667);
case 177: return new CityInfo("Kiten", "39", 42.23424, 27.7749);
case 178: return new CityInfo("Kirkovo", "44", 41.32715, 25.36379);
case 179: return new CityInfo("Kilifarevo", "62", 42.98333, 25.63333);
case 180: return new CityInfo("Tsar Kaloyan", "52", 43.61667, 26.25);
case 181: return new CityInfo("Hisarya", "51", 42.5, 24.7);
case 182: return new CityInfo("Hayredin", "64", 43.60193, 23.66135);
case 183: return new CityInfo("Haskovo", "43", 41.93415, 25.55557);
case 184: return new CityInfo("Harmanli", "43", 41.93333, 25.9);
case 185: return new CityInfo("Hadzhidimovo", "38", 41.52222, 23.86861);
case 186: return new CityInfo("Kermen", "56", 42.5, 26.25);
case 187: return new CityInfo("Kazanlak", "59", 42.61667, 25.4);
case 188: return new CityInfo("Kaynardzha", "55", 43.99278, 27.50713);
case 189: return new CityInfo("Kavarna", "40", 43.43601, 28.33953);
case 190: return new CityInfo("Kaspichan", "54", 43.31667, 27.16667);
case 191: return new CityInfo("Karnobat", "39", 42.65, 26.98333);
case 192: return new CityInfo("Karlovo", "51", 42.63333, 24.8);
case 193: return new CityInfo("Kaolinovo", "54", 43.61667, 27.11667);
case 194: return new CityInfo("Kameno", "39", 42.57084, 27.29875);
case 195: return new CityInfo("Kaloyanovo", "51", 42.35, 24.73333);
case 196: return new CityInfo("Kalofer", "51", 42.61667, 24.98333);
case 197: return new CityInfo("Ivaylovgrad", "43", 41.52672, 26.1249);
case 198: return new CityInfo("Ivanovo", "53", 43.68568, 25.95565);
case 199: return new CityInfo("Isperih", "52", 43.71667, 26.83333);
case 200: return new CityInfo("Iskar", "50", 43.6708, 24.45233);
case 201: return new CityInfo("Ihtiman", "58", 42.43333, 23.81667);
case 202: return new CityInfo("Garmen", "38", 41.6, 23.81667);
case 203: return new CityInfo("Gurkovo", "59", 42.66667, 25.8);
case 204: return new CityInfo("Gulyantsi", "50", 43.64109, 24.69368);
case 205: return new CityInfo("Gŭlŭbovo", "59", 42.13333, 25.85);
case 206: return new CityInfo("Sredets", "39", 42.34747, 27.17898);
case 207: return new CityInfo("Gramada", "63", 43.83738, 22.65279);
case 208: return new CityInfo("Gyovren", "57", 41.66326, 24.37557);
case 209: return new CityInfo("Gotse Delchev", "38", 41.56667, 23.73333);
case 210: return new CityInfo("Gorna Oryahovitsa", "62", 43.12778, 25.70167);
case 211: return new CityInfo("Gorna Malina", "58", 42.68333, 23.7);
case 212: return new CityInfo("Gorichevo", "52", 43.85, 26.45);
case 213: return new CityInfo("Godech", "58", 43.01682, 23.04852);
case 214: return new CityInfo("Glavinitsa", "55", 43.91667, 26.83333);
case 215: return new CityInfo("Dolni Chiflik", "61", 42.99296, 27.71596);
case 216: return new CityInfo("Georgi Damyanovo", "47", 43.38611, 23.03056);
case 217: return new CityInfo("General Toshevo", "40", 43.70123, 28.03787);
case 218: return new CityInfo("Gara Hitrino", "54", 43.43333, 26.91667);
case 219: return new CityInfo("Gabrovo", "41", 42.87472, 25.33417);
case 220: return new CityInfo("Gabrovo", "44", 41.8, 25.26667);
case 221: return new CityInfo("Etropole", "58", 42.83333, 24);
case 222: return new CityInfo("Elkhovo", "59", 42.38333, 25.43333);
case 223: return new CityInfo("Elhovo", "65", 42.16667, 26.56667);
case 224: return new CityInfo("Elin Pelin", "58", 42.66667, 23.6);
case 225: return new CityInfo("Elena", "62", 42.93333, 25.88333);
case 226: return new CityInfo("Dzhebel", "44", 41.49566, 25.30363);
case 227: return new CityInfo("Dve Mogili", "53", 43.59258, 25.87486);
case 228: return new CityInfo("Dunavtsi", "63", 43.92111, 22.82111);
case 229: return new CityInfo("Dulovo", "55", 43.81667, 27.15);
case 230: return new CityInfo("Dalgopol", "61", 43.05, 27.35);
case 231: return new CityInfo("Dryanovo", "41", 42.97897, 25.4785);
case 232: return new CityInfo("Drenovets", "63", 43.69134, 22.97365);
case 233: return new CityInfo("Dragoman", "58", 42.92191, 22.93109);
case 234: return new CityInfo("Dospat", "57", 41.64462, 24.15857);
case 235: return new CityInfo("Dolni Dabnik", "50", 43.4, 24.43333);
case 236: return new CityInfo("Dolna Mitropolia", "50", 43.46667, 24.53333);
case 237: return new CityInfo("Dolna Banya", "58", 42.3, 23.76667);
case 238: return new CityInfo("Dimovo", "63", 43.74167, 22.72694);
case 239: return new CityInfo("Dimitrovgrad", "43", 42.05, 25.6);
case 240: return new CityInfo("Devnya", "61", 43.22222, 27.56944);
case 241: return new CityInfo("Devin", "57", 41.74327, 24.40003);
case 242: return new CityInfo("Debelets", "62", 43.03333, 25.61667);
case 243: return new CityInfo("Chuprene", "63", 43.51806, 22.66611);
case 244: return new CityInfo("Chirpan", "59", 42.2, 25.33333);
case 245: return new CityInfo("Chiprovtsi", "47", 43.38417, 22.88083);
case 246: return new CityInfo("Cherven Bryag", "50", 43.27884, 24.08251);
case 247: return new CityInfo("Chernomorets", "39", 42.44408, 27.63902);
case 248: return new CityInfo("Chepelare", "57", 41.73333, 24.68333);
case 249: return new CityInfo("Chelopech", "58", 42.7, 24.08333);
case 250: return new CityInfo("Chavdar", "58", 42.65, 24.05);
case 251: return new CityInfo("Byala Slatina", "64", 43.46667, 23.93333);
case 252: return new CityInfo("Byala Cherkva", "62", 43.2, 25.3);
case 253: return new CityInfo("Byala", "61", 42.87426, 27.88865);
case 254: return new CityInfo("Burgas", "39", 42.50606, 27.46781);
case 255: return new CityInfo("Buhovo", "42", 42.76667, 23.56667);
case 256: return new CityInfo("Brusartsi", "47", 43.66075, 23.06732);
case 257: return new CityInfo("Brezovo", "51", 42.35, 25.08333);
case 258: return new CityInfo("Breznik", "49", 42.74085, 22.90723);
case 259: return new CityInfo("Bregovo", "63", 44.15167, 22.6425);
case 260: return new CityInfo("Bratya Daskalovi", "59", 42.3, 25.21667);
case 261: return new CityInfo("Bratsigovo", "48", 42.01667, 24.36667);
case 262: return new CityInfo("Bozhurishte", "58", 42.75, 23.2);
case 263: return new CityInfo("Boynitsa", "63", 43.9565, 22.53255);
case 264: return new CityInfo("Boychinovtsi", "47", 43.47222, 23.33583);
case 265: return new CityInfo("Bov", "58", 43.0325, 23.37806);
case 266: return new CityInfo("Botevgrad", "58", 42.9, 23.78333);
case 267: return new CityInfo("Borovo", "53", 43.50086, 25.80992);
case 268: return new CityInfo("Borovets", "45", 42.10566, 23.02003);
case 269: return new CityInfo("Borovan", "64", 43.43333, 23.75);
case 270: return new CityInfo("Borino", "57", 41.68408, 24.293);
case 271: return new CityInfo("Bolyarovo", "65", 42.14962, 26.81116);
case 272: return new CityInfo("Bobov Dol", "45", 42.36256, 23.00324);
case 273: return new CityInfo("Boboshevo", "45", 42.15296, 23.00146);
case 274: return new CityInfo("Bliznatsi", "61", 43.06795, 27.86744);
case 275: return new CityInfo("Blagoevgrad", "38", 42.01667, 23.1);
case 276: return new CityInfo("Berkovitsa", "47", 43.23581, 23.12738);
case 277: return new CityInfo("Belovo", "48", 42.21239, 24.02081);
case 278: return new CityInfo("Belogradchik", "63", 43.62722, 22.68361);
case 279: return new CityInfo("Belitsa", "38", 41.95694, 23.5725);
case 280: return new CityInfo("Belene", "50", 43.64594, 25.12627);
case 281: return new CityInfo("Batak", "48", 41.94225, 24.21843);
case 282: return new CityInfo("Bata", "39", 42.73802, 27.49643);
case 283: return new CityInfo("Bansko", "38", 41.8383, 23.48851);
case 284: return new CityInfo("Banite", "57", 41.61667, 25.01667);
case 285: return new CityInfo("Balchik", "40", 43.42166, 28.15848);
case 286: return new CityInfo("Aytos", "39", 42.7, 27.25);
case 287: return new CityInfo("Avren", "61", 43.11667, 27.66667);
case 288: return new CityInfo("Asparuhovo", "61", 43.18067, 27.88823);
case 289: return new CityInfo("Asenovgrad", "51", 42.01667, 24.86667);
case 290: return new CityInfo("Asen", "59", 42.65, 25.2);
case 291: return new CityInfo("Ardino", "44", 41.58333, 25.13333);
case 292: return new CityInfo("Apriltsi", "46", 42.84142, 24.91759);
case 293: return new CityInfo("Antonovo", "60", 43.15, 26.16667);
case 294: return new CityInfo("Anton", "58", 42.75, 24.28333);
case 295: return new CityInfo("Alfatar", "55", 43.94525, 27.28751);
case 296: return new CityInfo("Aksakovo", "61", 43.25615, 27.82105);
case 297: return new CityInfo("Ahtopol", "39", 42.09768, 27.93961);
case 298: return new CityInfo("Zlatni Pyasatsi", "61", 43.285, 28.0418);
case 299: return new CityInfo("Aheloy", "39", 42.64987, 27.64838);
default: return new CityInfo("Balgarevo", "61", 43.40296, 28.41189);

                                    }                                        
                                }
                            
                        }
                    }
                