
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
                                    public const string Country = "PE";
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
                            
                                        var cur = (Math.Abs(-3.68046 - lat) + Math.Abs(-80.67819 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-5.90181 - lat) + Math.Abs(-76.12234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.93139 - lat) + Math.Abs(-77.22667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.13833 - lat) + Math.Abs(-77.74361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.37778 - lat) + Math.Abs(-77.59306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.13972 - lat) + Math.Abs(-77.14389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.98333 - lat) + Math.Abs(-77.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.71417 - lat) + Math.Abs(-76.74822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.03333 - lat) + Math.Abs(-77.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.61667 - lat) + Math.Abs(-77.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.75 - lat) + Math.Abs(-77.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.1775 - lat) + Math.Abs(-79.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.15139 - lat) + Math.Abs(-77.30056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.41554 - lat) + Math.Abs(-78.75201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.41667 - lat) + Math.Abs(-80.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.63333 - lat) + Math.Abs(-78.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.81667 - lat) + Math.Abs(-78.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.13333 - lat) + Math.Abs(-77.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.18839 - lat) + Math.Abs(-76.92767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.45917 - lat) + Math.Abs(-76.46333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.20917 - lat) + Math.Abs(-79.67528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.56694 - lat) + Math.Abs(-80.45153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.50637 - lat) + Math.Abs(-79.85725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.11599 - lat) + Math.Abs(-79.02998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.81417 - lat) + Math.Abs(-75.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.35 - lat) + Math.Abs(-79.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.80694 - lat) + Math.Abs(-76.22944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.92947 - lat) + Math.Abs(-74.70771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.4925 - lat) + Math.Abs(-77.47306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.4125 - lat) + Math.Abs(-79.36194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.1877 - lat) + Math.Abs(-76.52046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.29532 - lat) + Math.Abs(-75.99574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.37167 - lat) + Math.Abs(-77.91194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.26972 - lat) + Math.Abs(-77.67944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.75 - lat) + Math.Abs(-77.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.26667 - lat) + Math.Abs(-79.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.27694 - lat) + Math.Abs(-77.29639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.30861 - lat) + Math.Abs(-77.42194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.48333 - lat) + Math.Abs(-78.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.39361 - lat) + Math.Abs(-77.57472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.50139 - lat) + Math.Abs(-76.36556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.39114 - lat) + Math.Abs(-76.72331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.92694 - lat) + Math.Abs(-80.34472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.87722 - lat) + Math.Abs(-80.97306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.85 - lat) + Math.Abs(-74.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.57722 - lat) + Math.Abs(-81.27194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.38333 - lat) + Math.Abs(-78.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.35 - lat) + Math.Abs(-76.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.31472 - lat) + Math.Abs(-79.28278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.51392 - lat) + Math.Abs(-80.00313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.90389 - lat) + Math.Abs(-80.68528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.95 - lat) + Math.Abs(-77.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.93333 - lat) + Math.Abs(-78.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.83333 - lat) + Math.Abs(-77.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.91083 - lat) + Math.Abs(-78.255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.13917 - lat) + Math.Abs(-77.10389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.33917 - lat) + Math.Abs(-79.43028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.31222 - lat) + Math.Abs(-79.40639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.26222 - lat) + Math.Abs(-77.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.90083 - lat) + Math.Abs(-80.81583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.3 - lat) + Math.Abs(-78.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.03333 - lat) + Math.Abs(-77.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.83333 - lat) + Math.Abs(-78.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.38745 - lat) + Math.Abs(-76.81262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.41667 - lat) + Math.Abs(-80.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.97639 - lat) + Math.Abs(-78.8136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.75794 - lat) + Math.Abs(-76.77443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.56667 - lat) + Math.Abs(-77.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.21778 - lat) + Math.Abs(-77.69417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.73384 - lat) + Math.Abs(-76.78651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.01667 - lat) + Math.Abs(-75.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.35 - lat) + Math.Abs(-78.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.23083 - lat) + Math.Abs(-77.625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.57972 - lat) + Math.Abs(-76.26278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.02308 - lat) + Math.Abs(-76.13298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.56361 - lat) + Math.Abs(-79.05139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.55694 - lat) + Math.Abs(-80.82222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.6 - lat) + Math.Abs(-78.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.69139 - lat) + Math.Abs(-76.21472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.69917 - lat) + Math.Abs(-77.74361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.66667 - lat) + Math.Abs(-73.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.93395 - lat) + Math.Abs(-76.77158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.77838 - lat) + Math.Abs(-79.98263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.15111 - lat) + Math.Abs(-79.43472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.02611 - lat) + Math.Abs(-79.87417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.14099 - lat) + Math.Abs(-78.17329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.95889 - lat) + Math.Abs(-79.23917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.88111 - lat) + Math.Abs(-79.91972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.75772 - lat) + Math.Abs(-79.82747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.68333 - lat) + Math.Abs(-76.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.76667 - lat) + Math.Abs(-74.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.03333 - lat) + Math.Abs(-74.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.55 - lat) + Math.Abs(-75.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.98861 - lat) + Math.Abs(-78.61194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.0304 - lat) + Math.Abs(-76.47499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.4289 - lat) + Math.Abs(-79.50416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.11667 - lat) + Math.Abs(-78.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.81923 - lat) + Math.Abs(-76.57578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.52491 - lat) + Math.Abs(-77.15681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.33333 - lat) + Math.Abs(-78.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.08333 - lat) + Math.Abs(-77.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.81667 - lat) + Math.Abs(-76.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.3 - lat) + Math.Abs(-78.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.61085 - lat) + Math.Abs(-76.69302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.73813 - lat) + Math.Abs(-79.8275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.84333 - lat) + Math.Abs(-80.87639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.64194 - lat) + Math.Abs(-80.4475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.14583 - lat) + Math.Abs(-79.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.05 - lat) + Math.Abs(-79.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.76778 - lat) + Math.Abs(-79.31167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.96667 - lat) + Math.Abs(-77.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.18333 - lat) + Math.Abs(-78.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.43333 - lat) + Math.Abs(-78.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.36667 - lat) + Math.Abs(-76.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.91888 - lat) + Math.Abs(-79.582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.26167 - lat) + Math.Abs(-78.49611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8 - lat) + Math.Abs(-78.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.655 - lat) + Math.Abs(-79.31333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.85722 - lat) + Math.Abs(-80.68111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.03333 - lat) + Math.Abs(-81.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.95028 - lat) + Math.Abs(-78.62278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.221 - lat) + Math.Abs(-78.97698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.27472 - lat) + Math.Abs(-79.60417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.06935 - lat) + Math.Abs(-76.71484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.4 - lat) + Math.Abs(-76.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.98372 - lat) + Math.Abs(-76.68839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.05675 - lat) + Math.Abs(-77.16651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.06083 - lat) + Math.Abs(-73.85028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.86556 - lat) + Math.Abs(-79.81778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.72215 - lat) + Math.Abs(-77.4563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.17139 - lat) + Math.Abs(-77.72194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.26066 - lat) + Math.Abs(-69.95714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.59929 - lat) + Math.Abs(-76.72494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.96667 - lat) + Math.Abs(-78.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.73333 - lat) + Math.Abs(-77.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.09222 - lat) + Math.Abs(-77.67806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.32917 - lat) + Math.Abs(-78.04139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.395 - lat) + Math.Abs(-77.49083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.35889 - lat) + Math.Abs(-79.03583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.27389 - lat) + Math.Abs(-79.03806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.83778 - lat) + Math.Abs(-80.64556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.49735 - lat) + Math.Abs(-76.88469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.46221 - lat) + Math.Abs(-76.81953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.98772 - lat) + Math.Abs(-78.64727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.99222 - lat) + Math.Abs(-76.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.377 - lat) + Math.Abs(-74.96564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.05743 - lat) + Math.Abs(-77.75848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.46361 - lat) + Math.Abs(-78.3825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.54306 - lat) + Math.Abs(-78.67917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.18806 - lat) + Math.Abs(-79.51528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.71667 - lat) + Math.Abs(-79.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.37915 - lat) + Math.Abs(-74.55387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.85167 - lat) + Math.Abs(-76.34167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.01389 - lat) + Math.Abs(-77.16361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.01125 - lat) + Math.Abs(-78.76769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.7675 - lat) + Math.Abs(-79.77722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.92861 - lat) + Math.Abs(-79.22611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.83333 - lat) + Math.Abs(-77.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.19449 - lat) + Math.Abs(-80.63282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.97984 - lat) + Math.Abs(-76.76813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.56667 - lat) + Math.Abs(-77.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.83667 - lat) + Math.Abs(-79.93417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.7775 - lat) + Math.Abs(-76.29056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.71778 - lat) + Math.Abs(-79.76972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.92033 - lat) + Math.Abs(-76.33142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.21667 - lat) + Math.Abs(-75.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.32879 - lat) + Math.Abs(-71.85505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.15227 - lat) + Math.Abs(-76.89906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.09972 - lat) + Math.Abs(-79.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.56667 - lat) + Math.Abs(-74.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.59667 - lat) + Math.Abs(-80.20889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.96667 - lat) + Math.Abs(-75.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.89778 - lat) + Math.Abs(-75.99333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.66667 - lat) + Math.Abs(-77.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.2 - lat) + Math.Abs(-77.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.07361 - lat) + Math.Abs(-77.98139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.2 - lat) + Math.Abs(-75.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.25 - lat) + Math.Abs(-78.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.08917 - lat) + Math.Abs(-81.11444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.6269 - lat) + Math.Abs(-79.94456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.73291 - lat) + Math.Abs(-79.3015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.42889 - lat) + Math.Abs(-79.83889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.06222 - lat) + Math.Abs(-77.97667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.70651 - lat) + Math.Abs(-76.77113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.49778 - lat) + Math.Abs(-78.41833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.40056 - lat) + Math.Abs(-79.57139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.16667 - lat) + Math.Abs(-79.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.99502 - lat) + Math.Abs(-79.66773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.84438 - lat) + Math.Abs(-79.30093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.03333 - lat) + Math.Abs(-78.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.9 - lat) + Math.Abs(-78.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.9 - lat) + Math.Abs(-75.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.46861 - lat) + Math.Abs(-77.39444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.1025 - lat) + Math.Abs(-77.95944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.98472 - lat) + Math.Abs(-79.74528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.63333 - lat) + Math.Abs(-77.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.04861 - lat) + Math.Abs(-77.64583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.79535 - lat) + Math.Abs(-76.66557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.87278 - lat) + Math.Abs(-79.34278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.92694 - lat) + Math.Abs(-79.12861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.1725 - lat) + Math.Abs(-78.35889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.65389 - lat) + Math.Abs(-81.30472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.33333 - lat) + Math.Abs(-75.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.53333 - lat) + Math.Abs(-73.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.95972 - lat) + Math.Abs(-79.24222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.2 - lat) + Math.Abs(-78.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.00352 - lat) + Math.Abs(-79.08907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.03416 - lat) + Math.Abs(-76.97168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.15194 - lat) + Math.Abs(-79.71417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.1868 - lat) + Math.Abs(-79.97076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.53536 - lat) + Math.Abs(-80.01104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.13889 - lat) + Math.Abs(-78.18194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.61583 - lat) + Math.Abs(-77.8025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.63066 - lat) + Math.Abs(-79.82855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.87431 - lat) + Math.Abs(-79.86871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.2 - lat) + Math.Abs(-77.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.98944 - lat) + Math.Abs(-79.61917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.54364 - lat) + Math.Abs(-79.86217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.17111 - lat) + Math.Abs(-79.00917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.49396 - lat) + Math.Abs(-76.8187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.40417 - lat) + Math.Abs(-79.28444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.49361 - lat) + Math.Abs(-77.435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.39444 - lat) + Math.Abs(-77.48167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.68271 - lat) + Math.Abs(-80.19899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.60528 - lat) + Math.Abs(-74.30472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.87778 - lat) + Math.Abs(-80.70528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.3225 - lat) + Math.Abs(-77.60361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.7 - lat) + Math.Abs(-78.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.19111 - lat) + Math.Abs(-77.71333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.10778 - lat) + Math.Abs(-81.0475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.91667 - lat) + Math.Abs(-77.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.33667 - lat) + Math.Abs(-77.88 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.25 - lat) + Math.Abs(-78.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.37306 - lat) + Math.Abs(-77.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.03333 - lat) + Math.Abs(-78.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.76667 - lat) + Math.Abs(-78.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.16389 - lat) + Math.Abs(-77.94528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.95 - lat) + Math.Abs(-78.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.91667 - lat) + Math.Abs(-77.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.63333 - lat) + Math.Abs(-78.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.17806 - lat) + Math.Abs(-81.12472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.095 - lat) + Math.Abs(-78.42139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.23111 - lat) + Math.Abs(-77.95639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.41417 - lat) + Math.Abs(-77.96861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.06667 - lat) + Math.Abs(-77.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.45674 - lat) + Math.Abs(-81.28487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.52167 - lat) + Math.Abs(-77.97083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.41667 - lat) + Math.Abs(-76.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.98333 - lat) + Math.Abs(-78.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.88333 - lat) + Math.Abs(-77.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.51444 - lat) + Math.Abs(-79.12028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.2 - lat) + Math.Abs(-78.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.42444 - lat) + Math.Abs(-79.24167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.30833 - lat) + Math.Abs(-77.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.82702 - lat) + Math.Abs(-76.80199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.40232 - lat) + Math.Abs(-80.74224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.38412 - lat) + Math.Abs(-76.00505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.65333 - lat) + Math.Abs(-80.24667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.08965 - lat) + Math.Abs(-78.9602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.61111 - lat) + Math.Abs(-78.435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.65 - lat) + Math.Abs(-77.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.13722 - lat) + Math.Abs(-77.95361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.7352 - lat) + Math.Abs(-77.61686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.70111 - lat) + Math.Abs(-79.90611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.41667 - lat) + Math.Abs(-76.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.56667 - lat) + Math.Abs(-78.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.48611 - lat) + Math.Abs(-77.81528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.91167 - lat) + Math.Abs(-80.96 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.22694 - lat) + Math.Abs(-75.67528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.7894 - lat) + Math.Abs(-79.84439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.46667 - lat) + Math.Abs(-78.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.0764 - lat) + Math.Abs(-79.04371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.91667 - lat) + Math.Abs(-78.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.26667 - lat) + Math.Abs(-77.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.33333 - lat) + Math.Abs(-80.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.17697 - lat) + Math.Abs(-76.72774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.58278 - lat) + Math.Abs(-76.33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.5827 - lat) + Math.Abs(-79.79713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.11667 - lat) + Math.Abs(-76.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.28333 - lat) + Math.Abs(-76.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.39083 - lat) + Math.Abs(-79.82194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.4025 - lat) + Math.Abs(-77.57583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.86722 - lat) + Math.Abs(-78.26167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.70729 - lat) + Math.Abs(-78.80785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.74912 - lat) + Math.Abs(-73.25383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.3 - lat) + Math.Abs(-74.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.24083 - lat) + Math.Abs(-77.95722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.23556 - lat) + Math.Abs(-79.31694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.15 - lat) + Math.Abs(-75.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.66667 - lat) + Math.Abs(-74.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.3186 - lat) + Math.Abs(-76.77556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.18722 - lat) + Math.Abs(-77.3425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.01611 - lat) + Math.Abs(-77.86083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.56583 - lat) + Math.Abs(-79.52194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.95 - lat) + Math.Abs(-77.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.33333 - lat) + Math.Abs(-77.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.52779 - lat) + Math.Abs(-77.52778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.68333 - lat) + Math.Abs(-78.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.93062 - lat) + Math.Abs(-76.24223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.33333 - lat) + Math.Abs(-77.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.73333 - lat) + Math.Abs(-77.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.08333 - lat) + Math.Abs(-79.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.17417 - lat) + Math.Abs(-77.86528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.23861 - lat) + Math.Abs(-79.45056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.46667 - lat) + Math.Abs(-78.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.8 - lat) + Math.Abs(-78.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.89796 - lat) + Math.Abs(-76.94089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.81667 - lat) + Math.Abs(-77.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.76667 - lat) + Math.Abs(-78.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.65 - lat) + Math.Abs(-77.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.41667 - lat) + Math.Abs(-77.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.20033 - lat) + Math.Abs(-76.7878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.03819 - lat) + Math.Abs(-76.95293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.3 - lat) + Math.Abs(-78 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.93333 - lat) + Math.Abs(-78.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.31674 - lat) + Math.Abs(-76.93953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.76917 - lat) + Math.Abs(-74.71008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.08167 - lat) + Math.Abs(-77.09083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.38333 - lat) + Math.Abs(-78.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.25 - lat) + Math.Abs(-79.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.09917 - lat) + Math.Abs(-77.62667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.92958 - lat) + Math.Abs(-79.94796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.86972 - lat) + Math.Abs(-79.12111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.63889 - lat) + Math.Abs(-79.78889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.90806 - lat) + Math.Abs(-79.86417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.45012 - lat) + Math.Abs(-72.66896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.08333 - lat) + Math.Abs(-78.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.03333 - lat) + Math.Abs(-79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.08333 - lat) + Math.Abs(-79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.62436 - lat) + Math.Abs(-78.47594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.26851 - lat) + Math.Abs(-81.21719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.45 - lat) + Math.Abs(-80.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.36667 - lat) + Math.Abs(-78.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.85972 - lat) + Math.Abs(-77.94333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.93306 - lat) + Math.Abs(-78.66278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.94889 - lat) + Math.Abs(-78.22528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.11667 - lat) + Math.Abs(-78.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.91667 - lat) + Math.Abs(-77.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.58333 - lat) + Math.Abs(-77.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.83333 - lat) + Math.Abs(-77.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.33333 - lat) + Math.Abs(-75.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.56667 - lat) + Math.Abs(-74.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.26667 - lat) + Math.Abs(-77.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.30111 - lat) + Math.Abs(-77.9725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.58333 - lat) + Math.Abs(-77.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.97528 - lat) + Math.Abs(-79.06611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.02306 - lat) + Math.Abs(-78.61556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.49361 - lat) + Math.Abs(-77.85944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.48333 - lat) + Math.Abs(-78.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.6 - lat) + Math.Abs(-78.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.01417 - lat) + Math.Abs(-77.95333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.82557 - lat) + Math.Abs(-76.13327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.67658 - lat) + Math.Abs(-76.70396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.93417 - lat) + Math.Abs(-77.85222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.6 - lat) + Math.Abs(-78.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.0925 - lat) + Math.Abs(-80.1625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.66667 - lat) + Math.Abs(-78.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.78167 - lat) + Math.Abs(-77.86833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.55 - lat) + Math.Abs(-78.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.90139 - lat) + Math.Abs(-78.69417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.64056 - lat) + Math.Abs(-79.38917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.79139 - lat) + Math.Abs(-79.22167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.88333 - lat) + Math.Abs(-77.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.305 - lat) + Math.Abs(-78.89833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.16 - lat) + Math.Abs(-78.28889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.11967 - lat) + Math.Abs(-76.99126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.08528 - lat) + Math.Abs(-78.57833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.1 - lat) + Math.Abs(-77.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.23333 - lat) + Math.Abs(-78.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.41667 - lat) + Math.Abs(-78.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.77137 - lat) + Math.Abs(-79.84088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.84472 - lat) + Math.Abs(-79.14694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.15 - lat) + Math.Abs(-78.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.22436 - lat) + Math.Abs(-79.42476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.8585 - lat) + Math.Abs(-76.60855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.57087 - lat) + Math.Abs(-76.13753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.83333 - lat) + Math.Abs(-78.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.03889 - lat) + Math.Abs(-79.79389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.84361 - lat) + Math.Abs(-75.90306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.23169 - lat) + Math.Abs(-77.86903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.23333 - lat) + Math.Abs(-77.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.8659 - lat) + Math.Abs(-78.14585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.58333 - lat) + Math.Abs(-78.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.67528 - lat) + Math.Abs(-79.03306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.26667 - lat) + Math.Abs(-80.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.8 - lat) + Math.Abs(-77.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.95694 - lat) + Math.Abs(-76.41806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.47472 - lat) + Math.Abs(-78.30167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.48333 - lat) + Math.Abs(-78.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.22583 - lat) + Math.Abs(-77.71639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.74389 - lat) + Math.Abs(-79.18639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.28194 - lat) + Math.Abs(-77.64472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.04692 - lat) + Math.Abs(-77.80901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.11667 - lat) + Math.Abs(-78.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.37306 - lat) + Math.Abs(-79.60028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.94667 - lat) + Math.Abs(-80.94167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.94167 - lat) + Math.Abs(-80.65083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.04611 - lat) + Math.Abs(-79.26472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.03194 - lat) + Math.Abs(-77.06639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.6375 - lat) + Math.Abs(-80.59167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.73639 - lat) + Math.Abs(-78.42556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.63333 - lat) + Math.Abs(-77.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.16378 - lat) + Math.Abs(-78.50027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.61667 - lat) + Math.Abs(-78.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.85261 - lat) + Math.Abs(-76.63035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.45 - lat) + Math.Abs(-78.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.4 - lat) + Math.Abs(-78.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.90583 - lat) + Math.Abs(-70.51639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.13861 - lat) + Math.Abs(-79.04028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.26083 - lat) + Math.Abs(-79.96417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.48333 - lat) + Math.Abs(-72.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.26667 - lat) + Math.Abs(-74.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.35 - lat) + Math.Abs(-78.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.45 - lat) + Math.Abs(-80.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.05614 - lat) + Math.Abs(-76.5911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.66417 - lat) + Math.Abs(-78.67722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.26667 - lat) + Math.Abs(-76.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.83298 - lat) + Math.Abs(-76.67582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.6 - lat) + Math.Abs(-78 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.68333 - lat) + Math.Abs(-78.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.83333 - lat) + Math.Abs(-78.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.75611 - lat) + Math.Abs(-78.44111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.63311 - lat) + Math.Abs(-78.53431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.63983 - lat) + Math.Abs(-79.71491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.93139 - lat) + Math.Abs(-76.11315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.71444 - lat) + Math.Abs(-79.10778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.80583 - lat) + Math.Abs(-77.71722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.88333 - lat) + Math.Abs(-81.0275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.17227 - lat) + Math.Abs(-76.74895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.41639 - lat) + Math.Abs(-78.43583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.35861 - lat) + Math.Abs(-77.59722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.13333 - lat) + Math.Abs(-78.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.88167 - lat) + Math.Abs(-81.01556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.23917 - lat) + Math.Abs(-77.64639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.78105 - lat) + Math.Abs(-77.6094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.48139 - lat) + Math.Abs(-80.245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.72343 - lat) + Math.Abs(-76.69643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.98333 - lat) + Math.Abs(-78.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.15193 - lat) + Math.Abs(-76.98925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.29722 - lat) + Math.Abs(-77.61778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.80105 - lat) + Math.Abs(-76.07194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.53333 - lat) + Math.Abs(-77.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.35806 - lat) + Math.Abs(-74.57361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.47533 - lat) + Math.Abs(-74.80709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.31139 - lat) + Math.Abs(-74.86222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.43361 - lat) + Math.Abs(-78.86361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.95167 - lat) + Math.Abs(-78.72722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.47528 - lat) + Math.Abs(-76.43444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.91667 - lat) + Math.Abs(-78.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.62722 - lat) + Math.Abs(-78.85278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.52972 - lat) + Math.Abs(-76.4925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.51111 - lat) + Math.Abs(-76.48 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.66306 - lat) + Math.Abs(-76.28667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.79111 - lat) + Math.Abs(-76.32639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.64361 - lat) + Math.Abs(-79.73806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.25691 - lat) + Math.Abs(-80.88599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.07771 - lat) + Math.Abs(-80.7369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.50306 - lat) + Math.Abs(-80.27306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.45472 - lat) + Math.Abs(-72.25556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.5 - lat) + Math.Abs(-69.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.25223 - lat) + Math.Abs(-71.67969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.25 - lat) + Math.Abs(-69.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.2 - lat) + Math.Abs(-70.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.32139 - lat) + Math.Abs(-72.08222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.45944 - lat) + Math.Abs(-75.91722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.66694 - lat) + Math.Abs(-71.92111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.71366 - lat) + Math.Abs(-75.47466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.665 - lat) + Math.Abs(-76.08639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.13532 - lat) + Math.Abs(-75.57371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.66111 - lat) + Math.Abs(-74.52722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.54722 - lat) + Math.Abs(-71.47667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.64917 - lat) + Math.Abs(-71.65778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.695 - lat) + Math.Abs(-76.84556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.77389 - lat) + Math.Abs(-72.87667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.21806 - lat) + Math.Abs(-71.43167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.26667 - lat) + Math.Abs(-69.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.51667 - lat) + Math.Abs(-76.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.2 - lat) + Math.Abs(-75.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.24111 - lat) + Math.Abs(-76.64556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.21778 - lat) + Math.Abs(-73.14111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.80861 - lat) + Math.Abs(-71.20111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.22361 - lat) + Math.Abs(-75.80639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.03333 - lat) + Math.Abs(-76.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.58917 - lat) + Math.Abs(-73.99444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.65694 - lat) + Math.Abs(-72.52528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.24083 - lat) + Math.Abs(-74.35306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.93111 - lat) + Math.Abs(-75.77861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.21667 - lat) + Math.Abs(-69.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.76667 - lat) + Math.Abs(-70.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.71135 - lat) + Math.Abs(-76.1498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.73944 - lat) + Math.Abs(-75.26972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.61167 - lat) + Math.Abs(-74.53194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.07556 - lat) + Math.Abs(-72.62583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.47806 - lat) + Math.Abs(-76.4475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.48333 - lat) + Math.Abs(-75.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.18694 - lat) + Math.Abs(-70.66 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.87528 - lat) + Math.Abs(-77.11833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.27333 - lat) + Math.Abs(-73.02167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.50889 - lat) + Math.Abs(-71.88528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.02253 - lat) + Math.Abs(-77.64378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.12472 - lat) + Math.Abs(-69.96611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.30472 - lat) + Math.Abs(-72.11583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.5325 - lat) + Math.Abs(-73.67722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.68611 - lat) + Math.Abs(-71.62278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.02861 - lat) + Math.Abs(-73.17056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.90167 - lat) + Math.Abs(-73.40111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.72944 - lat) + Math.Abs(-72.42972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.8575 - lat) + Math.Abs(-70.75611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.42508 - lat) + Math.Abs(-71.67215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.4 - lat) + Math.Abs(-70.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.53306 - lat) + Math.Abs(-71.55083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.78528 - lat) + Math.Abs(-73.47361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.21917 - lat) + Math.Abs(-72.62389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.74083 - lat) + Math.Abs(-75.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.16389 - lat) + Math.Abs(-71.47667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.56722 - lat) + Math.Abs(-74.52361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.4062 - lat) + Math.Abs(-70.36464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.26417 - lat) + Math.Abs(-72.92889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.05056 - lat) + Math.Abs(-73.29722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.07694 - lat) + Math.Abs(-70.84333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.17306 - lat) + Math.Abs(-72.83083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.07722 - lat) + Math.Abs(-76.21194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.23861 - lat) + Math.Abs(-75.74528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.65944 - lat) + Math.Abs(-74.09056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.09306 - lat) + Math.Abs(-75.17194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.34611 - lat) + Math.Abs(-71.44778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.95 - lat) + Math.Abs(-70.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.81667 - lat) + Math.Abs(-70.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.76771 - lat) + Math.Abs(-76.27523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.95917 - lat) + Math.Abs(-73.18583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.145 - lat) + Math.Abs(-71.40694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.35 - lat) + Math.Abs(-75.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.25403 - lat) + Math.Abs(-77.19088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.1325 - lat) + Math.Abs(-74.33278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.44639 - lat) + Math.Abs(-70.04694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.45 - lat) + Math.Abs(-71.59 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.175 - lat) + Math.Abs(-72.85028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.58333 - lat) + Math.Abs(-76.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.35611 - lat) + Math.Abs(-73.2325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.18333 - lat) + Math.Abs(-71.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.52472 - lat) + Math.Abs(-70.02833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.41899 - lat) + Math.Abs(-75.68992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.47444 - lat) + Math.Abs(-70.03278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.3 - lat) + Math.Abs(-69.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.76667 - lat) + Math.Abs(-69.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.39056 - lat) + Math.Abs(-75.56361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.57806 - lat) + Math.Abs(-71.93917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.14028 - lat) + Math.Abs(-73.14278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.01667 - lat) + Math.Abs(-77.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.11667 - lat) + Math.Abs(-76.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.61667 - lat) + Math.Abs(-72.87139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.73333 - lat) + Math.Abs(-74.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.67191 - lat) + Math.Abs(-69.35547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.94528 - lat) + Math.Abs(-72.17139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.79847 - lat) + Math.Abs(-73.92438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.93333 - lat) + Math.Abs(-74.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.19194 - lat) + Math.Abs(-74.11139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.65306 - lat) + Math.Abs(-73.42917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.01465 - lat) + Math.Abs(-70.25362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.35306 - lat) + Math.Abs(-70.13194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.13333 - lat) + Math.Abs(-74.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.13588 - lat) + Math.Abs(-77.00742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.88472 - lat) + Math.Abs(-76.43972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.7975 - lat) + Math.Abs(-77.71306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.42704 - lat) + Math.Abs(-76.16363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.4075 - lat) + Math.Abs(-76.82 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.78734 - lat) + Math.Abs(-75.93612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.01889 - lat) + Math.Abs(-75.75806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.16278 - lat) + Math.Abs(-73.3125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.115 - lat) + Math.Abs(-73.60444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.215 - lat) + Math.Abs(-74.28917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.47025 - lat) + Math.Abs(-71.52758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.99471 - lat) + Math.Abs(-70.19532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.37556 - lat) + Math.Abs(-70.13222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.89119 - lat) + Math.Abs(-75.38745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.5 - lat) + Math.Abs(-69.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.26944 - lat) + Math.Abs(-71.22611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.03333 - lat) + Math.Abs(-75.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.48694 - lat) + Math.Abs(-71.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.14583 - lat) + Math.Abs(-73.04278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.56139 - lat) + Math.Abs(-71.84889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.13333 - lat) + Math.Abs(-77.1946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.69361 - lat) + Math.Abs(-73.75861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.25222 - lat) + Math.Abs(-74.63861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.67417 - lat) + Math.Abs(-74.32 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15 - lat) + Math.Abs(-75.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.07556 - lat) + Math.Abs(-76.38528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.18469 - lat) + Math.Abs(-75.71124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.13222 - lat) + Math.Abs(-72.59056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.61111 - lat) + Math.Abs(-70.78611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.15 - lat) + Math.Abs(-72.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.79917 - lat) + Math.Abs(-77.17333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.00538 - lat) + Math.Abs(-76.89329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.69788 - lat) + Math.Abs(-70.6061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.90083 - lat) + Math.Abs(-76.66333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.06 - lat) + Math.Abs(-76.93028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.05 - lat) + Math.Abs(-75.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.86667 - lat) + Math.Abs(-72.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.49361 - lat) + Math.Abs(-71.77389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.12417 - lat) + Math.Abs(-75.35733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.33806 - lat) + Math.Abs(-76.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.25061 - lat) + Math.Abs(-75.86116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.76667 - lat) + Math.Abs(-74.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.18667 - lat) + Math.Abs(-71.34167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.39889 - lat) + Math.Abs(-76.15904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.20278 - lat) + Math.Abs(-71.31556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.13818 - lat) + Math.Abs(-76.62288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.0125 - lat) + Math.Abs(-73.98083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.75944 - lat) + Math.Abs(-76.30056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.07674 - lat) + Math.Abs(-76.99435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.84684 - lat) + Math.Abs(-75.38146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.46667 - lat) + Math.Abs(-69.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.01083 - lat) + Math.Abs(-75.73583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.36528 - lat) + Math.Abs(-75.16222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.65 - lat) + Math.Abs(-74.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.2 - lat) + Math.Abs(-75.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.65138 - lat) + Math.Abs(-73.36388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.95591 - lat) + Math.Abs(-75.28411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.11667 - lat) + Math.Abs(-77.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.16667 - lat) + Math.Abs(-76.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.6 - lat) + Math.Abs(-73.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.23333 - lat) + Math.Abs(-69.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.66667 - lat) + Math.Abs(-76.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.48889 - lat) + Math.Abs(-76.66194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.38333 - lat) + Math.Abs(-76.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.20694 - lat) + Math.Abs(-73.33556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.97195 - lat) + Math.Abs(-75.25562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.17944 - lat) + Math.Abs(-70.89889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.7925 - lat) + Math.Abs(-70.49472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.2 - lat) + Math.Abs(-74.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.94639 - lat) + Math.Abs(-74.31139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.46667 - lat) + Math.Abs(-71.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.21667 - lat) + Math.Abs(-69.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.516 - lat) + Math.Abs(-75.19933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.91978 - lat) + Math.Abs(-76.6561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53361 - lat) + Math.Abs(-73.60528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53333 - lat) + Math.Abs(-75.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.82278 - lat) + Math.Abs(-71.53944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.04917 - lat) + Math.Abs(-74.13861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.30778 - lat) + Math.Abs(-72.13611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.36667 - lat) + Math.Abs(-76.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.75 - lat) + Math.Abs(-70.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.23092 - lat) + Math.Abs(-70.75401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.9486 - lat) + Math.Abs(-76.38112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.86334 - lat) + Math.Abs(-72.69306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.24778 - lat) + Math.Abs(-73.45389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.71417 - lat) + Math.Abs(-72.43528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.31778 - lat) + Math.Abs(-70.25806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.62583 - lat) + Math.Abs(-73.79833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.43333 - lat) + Math.Abs(-69.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.18139 - lat) + Math.Abs(-76.80389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.01333 - lat) + Math.Abs(-73.83972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.55778 - lat) + Math.Abs(-71.45111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.63667 - lat) + Math.Abs(-72.55944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.38 - lat) + Math.Abs(-71.455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.76667 - lat) + Math.Abs(-72.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.4764 - lat) + Math.Abs(-69.43292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.91667 - lat) + Math.Abs(-69.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.43333 - lat) + Math.Abs(-69.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.7 - lat) + Math.Abs(-74.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.62361 - lat) + Math.Abs(-71.18444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.33333 - lat) + Math.Abs(-76.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.1719 - lat) + Math.Abs(-71.7924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.8422 - lat) + Math.Abs(-70.0199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.21667 - lat) + Math.Abs(-73.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.15778 - lat) + Math.Abs(-70.35222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.06 - lat) + Math.Abs(-72.69083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.80135 - lat) + Math.Abs(-77.74333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.14694 - lat) + Math.Abs(-74.30583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.59331 - lat) + Math.Abs(-69.18913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.12806 - lat) + Math.Abs(-75.70667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.47889 - lat) + Math.Abs(-72.11167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.48333 - lat) + Math.Abs(-76.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.97993 - lat) + Math.Abs(-71.45988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.06667 - lat) + Math.Abs(-75.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.38333 - lat) + Math.Abs(-70.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.495 - lat) + Math.Abs(-72.04333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.26667 - lat) + Math.Abs(-69.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.08444 - lat) + Math.Abs(-73.58889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.85 - lat) + Math.Abs(-74.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.02694 - lat) + Math.Abs(-71.56722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.73828 - lat) + Math.Abs(-75.62448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.60444 - lat) + Math.Abs(-74.23528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.51639 - lat) + Math.Abs(-71.38833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.99167 - lat) + Math.Abs(-70.21333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.21667 - lat) + Math.Abs(-73.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.97222 - lat) + Math.Abs(-71.41 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.71029 - lat) + Math.Abs(-76.20538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.4225 - lat) + Math.Abs(-71.84667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.23444 - lat) + Math.Abs(-76.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.32611 - lat) + Math.Abs(-74.9975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.95417 - lat) + Math.Abs(-71.75972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.06667 - lat) + Math.Abs(-71.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.1 - lat) + Math.Abs(-69.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.04722 - lat) + Math.Abs(-75.24931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.4 - lat) + Math.Abs(-75.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.86083 - lat) + Math.Abs(-73.07361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.68139 - lat) + Math.Abs(-71.41694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.5 - lat) + Math.Abs(-73.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.15167 - lat) + Math.Abs(-69.66306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.9451 - lat) + Math.Abs(-75.22394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.26667 - lat) + Math.Abs(-75.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.27972 - lat) + Math.Abs(-73.34583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.31522 - lat) + Math.Abs(-71.59364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.73333 - lat) + Math.Abs(-70.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.55 - lat) + Math.Abs(-74.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.37111 - lat) + Math.Abs(-76.44361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.7 - lat) + Math.Abs(-77.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.175 - lat) + Math.Abs(-72.67389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.35972 - lat) + Math.Abs(-69.61889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.76333 - lat) + Math.Abs(-71.84944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.80015 - lat) + Math.Abs(-75.54603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.4525 - lat) + Math.Abs(-70.59861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.66667 - lat) + Math.Abs(-77.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.86667 - lat) + Math.Abs(-76.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.11667 - lat) + Math.Abs(-73 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.74899 - lat) + Math.Abs(-75.48635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.11532 - lat) + Math.Abs(-77.39783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.22889 - lat) + Math.Abs(-73.89417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.3949 - lat) + Math.Abs(-74.86687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.14639 - lat) + Math.Abs(-71.45944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.71306 - lat) + Math.Abs(-72.57417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.18694 - lat) + Math.Abs(-73.54389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.55917 - lat) + Math.Abs(-74.19528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.87 - lat) + Math.Abs(-72.50389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.53361 - lat) + Math.Abs(-75.18556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.41528 - lat) + Math.Abs(-76.23556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.29472 - lat) + Math.Abs(-75.77361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.77528 - lat) + Math.Abs(-69.96028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.23361 - lat) + Math.Abs(-70.59722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.34611 - lat) + Math.Abs(-75.56861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.03778 - lat) + Math.Abs(-73.64361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.60889 - lat) + Math.Abs(-73.34361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.64604 - lat) + Math.Abs(-71.34481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.61639 - lat) + Math.Abs(-73.08611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.2225 - lat) + Math.Abs(-73.02556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.95722 - lat) + Math.Abs(-76.93222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.85411 - lat) + Math.Abs(-75.50767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.47389 - lat) + Math.Abs(-75.96 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.75917 - lat) + Math.Abs(-71.955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.05694 - lat) + Math.Abs(-74.21361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.18611 - lat) + Math.Abs(-76.6475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.95139 - lat) + Math.Abs(-73.36778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.71539 - lat) + Math.Abs(-75.51586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.66846 - lat) + Math.Abs(-76.77165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.17972 - lat) + Math.Abs(-73.18611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.5775 - lat) + Math.Abs(-75.40167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.48333 - lat) + Math.Abs(-74.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.73 - lat) + Math.Abs(-70.51306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.25611 - lat) + Math.Abs(-72.555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.59278 - lat) + Math.Abs(-71.77194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.96886 - lat) + Math.Abs(-75.3078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.26611 - lat) + Math.Abs(-72.34167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.40361 - lat) + Math.Abs(-73.66972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.08651 - lat) + Math.Abs(-76.14831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.68333 - lat) + Math.Abs(-70.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.51667 - lat) + Math.Abs(-76.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.07139 - lat) + Math.Abs(-71.73972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.25722 - lat) + Math.Abs(-72.26306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.81667 - lat) + Math.Abs(-70.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.11111 - lat) + Math.Abs(-70.90778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.34861 - lat) + Math.Abs(-75.66917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.39139 - lat) + Math.Abs(-73.915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.40294 - lat) + Math.Abs(-77.39666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.00806 - lat) + Math.Abs(-75.02194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.0525 - lat) + Math.Abs(-71.12889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.62694 - lat) + Math.Abs(-71.38528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.43306 - lat) + Math.Abs(-73.10778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.48194 - lat) + Math.Abs(-73.56111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.38333 - lat) + Math.Abs(-74.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.47788 - lat) + Math.Abs(-70.63583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.07541 - lat) + Math.Abs(-76.31719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.85 - lat) + Math.Abs(-76.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.93573 - lat) + Math.Abs(-76.70611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.23333 - lat) + Math.Abs(-70.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.83098 - lat) + Math.Abs(-74.93895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.81371 - lat) + Math.Abs(-75.45482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.83364 - lat) + Math.Abs(-75.43462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.18278 - lat) + Math.Abs(-72.90556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.76667 - lat) + Math.Abs(-69.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.34278 - lat) + Math.Abs(-76.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.59972 - lat) + Math.Abs(-76.14111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.11056 - lat) + Math.Abs(-73.87139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.19832 - lat) + Math.Abs(-70.93567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.3 - lat) + Math.Abs(-75.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.02306 - lat) + Math.Abs(-72.01472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.42139 - lat) + Math.Abs(-72.91194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.73642 - lat) + Math.Abs(-75.44356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.35 - lat) + Math.Abs(-69.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.27361 - lat) + Math.Abs(-75.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.75 - lat) + Math.Abs(-69.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.32583 - lat) + Math.Abs(-74.53083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.78333 - lat) + Math.Abs(-74.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.85 - lat) + Math.Abs(-76.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.48333 - lat) + Math.Abs(-70.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.4025 - lat) + Math.Abs(-74.75083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.25 - lat) + Math.Abs(-76.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.00611 - lat) + Math.Abs(-76.5225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.21194 - lat) + Math.Abs(-75.11028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.74117 - lat) + Math.Abs(-75.56279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.88333 - lat) + Math.Abs(-74.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.40692 - lat) + Math.Abs(-76.33628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.58972 - lat) + Math.Abs(-70.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.15056 - lat) + Math.Abs(-73.34194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.08833 - lat) + Math.Abs(-77.47431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.93556 - lat) + Math.Abs(-76.83389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.335 - lat) + Math.Abs(-72.15667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.96306 - lat) + Math.Abs(-72.66472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.35672 - lat) + Math.Abs(-71.16924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.08528 - lat) + Math.Abs(-72.10806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.37411 - lat) + Math.Abs(-77.10205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.8 - lat) + Math.Abs(-70.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.22944 - lat) + Math.Abs(-72.58611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.65806 - lat) + Math.Abs(-76.63083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.60778 - lat) + Math.Abs(-71.80806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.94444 - lat) + Math.Abs(-75.77667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.08333 - lat) + Math.Abs(-70.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.76861 - lat) + Math.Abs(-70.90194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.98333 - lat) + Math.Abs(-74.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.64167 - lat) + Math.Abs(-71.76944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.85 - lat) + Math.Abs(-74.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.94917 - lat) + Math.Abs(-73.22611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.63556 - lat) + Math.Abs(-71.7375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.6 - lat) + Math.Abs(-74.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.09667 - lat) + Math.Abs(-75.69083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.61333 - lat) + Math.Abs(-70.76278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.68333 - lat) + Math.Abs(-74.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.01472 - lat) + Math.Abs(-72.01417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.33111 - lat) + Math.Abs(-72.11472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.33333 - lat) + Math.Abs(-70.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.81781 - lat) + Math.Abs(-75.62382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.56417 - lat) + Math.Abs(-75.20778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.38195 - lat) + Math.Abs(-77.20579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.26667 - lat) + Math.Abs(-74.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.93333 - lat) + Math.Abs(-70.88278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.06667 - lat) + Math.Abs(-77.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.29875 - lat) + Math.Abs(-77.14535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.30194 - lat) + Math.Abs(-71.68722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13 - lat) + Math.Abs(-74.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.79861 - lat) + Math.Abs(-75.665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.14778 - lat) + Math.Abs(-69.68889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.47917 - lat) + Math.Abs(-72.4425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.04318 - lat) + Math.Abs(-77.02824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.37972 - lat) + Math.Abs(-75.75389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.49361 - lat) + Math.Abs(-71.155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.03583 - lat) + Math.Abs(-75.70028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.86417 - lat) + Math.Abs(-70.56278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.62222 - lat) + Math.Abs(-71.76889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.10333 - lat) + Math.Abs(-72.04389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.13333 - lat) + Math.Abs(-70.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.34667 - lat) + Math.Abs(-75.78639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.66472 - lat) + Math.Abs(-76.53944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.25 - lat) + Math.Abs(-74.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.61361 - lat) + Math.Abs(-72.69639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.51893 - lat) + Math.Abs(-75.89935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.48333 - lat) + Math.Abs(-70.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.43194 - lat) + Math.Abs(-71.27306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.23778 - lat) + Math.Abs(-76.83972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.35 - lat) + Math.Abs(-70.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.18444 - lat) + Math.Abs(-73.34889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.08333 - lat) + Math.Abs(-76.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.06146 - lat) + Math.Abs(-75.33505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.86667 - lat) + Math.Abs(-72.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.36417 - lat) + Math.Abs(-71.92389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.1 - lat) + Math.Abs(-76.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.63333 - lat) + Math.Abs(-74.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.14667 - lat) + Math.Abs(-71.82167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.55333 - lat) + Math.Abs(-76.62333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.75694 - lat) + Math.Abs(-71.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.69444 - lat) + Math.Abs(-73.11639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.15895 - lat) + Math.Abs(-75.99304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.5 - lat) + Math.Abs(-70.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.21667 - lat) + Math.Abs(-69.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.76025 - lat) + Math.Abs(-75.43587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.01278 - lat) + Math.Abs(-74.44222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.02389 - lat) + Math.Abs(-76.67917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.77584 - lat) + Math.Abs(-75.49656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.75003 - lat) + Math.Abs(-71.34641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.11667 - lat) + Math.Abs(-75.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.94861 - lat) + Math.Abs(-76.745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.48333 - lat) + Math.Abs(-75.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.85639 - lat) + Math.Abs(-72.62556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.94028 - lat) + Math.Abs(-73.13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.8895 - lat) + Math.Abs(-75.26554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.7 - lat) + Math.Abs(-76.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.99 - lat) + Math.Abs(-77.04583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.25 - lat) + Math.Abs(-73.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15 - lat) + Math.Abs(-69.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.95 - lat) + Math.Abs(-69.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.05927 - lat) + Math.Abs(-76.35269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.63185 - lat) + Math.Abs(-71.34108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.08333 - lat) + Math.Abs(-69.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.42083 - lat) + Math.Abs(-70.51333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.18917 - lat) + Math.Abs(-76.95139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.64972 - lat) + Math.Abs(-71.6875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.15 - lat) + Math.Abs(-70.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.06777 - lat) + Math.Abs(-75.72861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.35 - lat) + Math.Abs(-69.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.71667 - lat) + Math.Abs(-75.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.05278 - lat) + Math.Abs(-73.56556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.13333 - lat) + Math.Abs(-75.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.3 - lat) + Math.Abs(-69.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.00367 - lat) + Math.Abs(-76.36452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.05 - lat) + Math.Abs(-77.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.4 - lat) + Math.Abs(-75.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.33806 - lat) + Math.Abs(-72.06528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.04833 - lat) + Math.Abs(-73.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53639 - lat) + Math.Abs(-75.30528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.07 - lat) + Math.Abs(-77.59944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.61667 - lat) + Math.Abs(-69.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.12385 - lat) + Math.Abs(-77.15733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.26527 - lat) + Math.Abs(-75.64722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.40583 - lat) + Math.Abs(-76.57694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.41333 - lat) + Math.Abs(-72.20639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.68833 - lat) + Math.Abs(-71.63583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.06806 - lat) + Math.Abs(-78.15222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.80816 - lat) + Math.Abs(-75.47143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.26667 - lat) + Math.Abs(-74.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.44167 - lat) + Math.Abs(-76.19028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.495 - lat) + Math.Abs(-77.20778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.33139 - lat) + Math.Abs(-72.89028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.65667 - lat) + Math.Abs(-76.50333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.31389 - lat) + Math.Abs(-70.32194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.93333 - lat) + Math.Abs(-74.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.68278 - lat) + Math.Abs(-72.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.5 - lat) + Math.Abs(-72.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.89889 - lat) + Math.Abs(-75.83111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.06513 - lat) + Math.Abs(-75.20486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.20306 - lat) + Math.Abs(-75.79806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.78261 - lat) + Math.Abs(-74.97266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.09583 - lat) + Math.Abs(-72.47278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.75861 - lat) + Math.Abs(-73.5275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.64528 - lat) + Math.Abs(-73.08639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.75667 - lat) + Math.Abs(-74.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.6 - lat) + Math.Abs(-75.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.82327 - lat) + Math.Abs(-70.8854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.35 - lat) + Math.Abs(-75.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.35 - lat) + Math.Abs(-76.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.73083 - lat) + Math.Abs(-72.1075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.74972 - lat) + Math.Abs(-73.93111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.11667 - lat) + Math.Abs(-75.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.49917 - lat) + Math.Abs(-76.74889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.73 - lat) + Math.Abs(-74.27278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.01111 - lat) + Math.Abs(-74.17806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.80722 - lat) + Math.Abs(-75.42439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.09639 - lat) + Math.Abs(-77.61389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.18333 - lat) + Math.Abs(-75.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.2 - lat) + Math.Abs(-75.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.02778 - lat) + Math.Abs(-74.94583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.10667 - lat) + Math.Abs(-77.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.16028 - lat) + Math.Abs(-76.23694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.17361 - lat) + Math.Abs(-73.88639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.81139 - lat) + Math.Abs(-75.765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.21278 - lat) + Math.Abs(-72.19 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.96667 - lat) + Math.Abs(-75.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.47389 - lat) + Math.Abs(-76.40944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.58333 - lat) + Math.Abs(-77.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.54167 - lat) + Math.Abs(-70.01861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.06667 - lat) + Math.Abs(-75.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.0725 - lat) + Math.Abs(-72.47278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.64528 - lat) + Math.Abs(-75.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.53333 - lat) + Math.Abs(-71.30556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.49714 - lat) + Math.Abs(-76.05724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.60333 - lat) + Math.Abs(-72.72639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.56556 - lat) + Math.Abs(-69.04167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.47139 - lat) + Math.Abs(-69.53722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.9075 - lat) + Math.Abs(-71.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.52264 - lat) + Math.Abs(-71.96734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.3825 - lat) + Math.Abs(-70.33472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.55 - lat) + Math.Abs(-72.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.90611 - lat) + Math.Abs(-70.87417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.23333 - lat) + Math.Abs(-75.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.43333 - lat) + Math.Abs(-75.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.75 - lat) + Math.Abs(-70.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.09722 - lat) + Math.Abs(-77.5925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.35 - lat) + Math.Abs(-70 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.83639 - lat) + Math.Abs(-72.43083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.38806 - lat) + Math.Abs(-71.89972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.41583 - lat) + Math.Abs(-73.20778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10 - lat) + Math.Abs(-77.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.21306 - lat) + Math.Abs(-72.88861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.74639 - lat) + Math.Abs(-72.35667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.28508 - lat) + Math.Abs(-77.19879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.22361 - lat) + Math.Abs(-72.47111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.2625 - lat) + Math.Abs(-73.20056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.87111 - lat) + Math.Abs(-70.60667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.03333 - lat) + Math.Abs(-73.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.62722 - lat) + Math.Abs(-71.64611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.8 - lat) + Math.Abs(-71.5325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.38821 - lat) + Math.Abs(-77.07956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.37181 - lat) + Math.Abs(-77.48744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.43333 - lat) + Math.Abs(-69.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.33712 - lat) + Math.Abs(-77.44188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.24 - lat) + Math.Abs(-71.08222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.72503 - lat) + Math.Abs(-75.57086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.03778 - lat) + Math.Abs(-76.21528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.91762 - lat) + Math.Abs(-75.31401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.10111 - lat) + Math.Abs(-71.42944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.7174 - lat) + Math.Abs(-75.08118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.16222 - lat) + Math.Abs(-73.29472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.35583 - lat) + Math.Abs(-71.66972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.28222 - lat) + Math.Abs(-72.04194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.26889 - lat) + Math.Abs(-76.41417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.63278 - lat) + Math.Abs(-75.89056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.85194 - lat) + Math.Abs(-71.80333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.00778 - lat) + Math.Abs(-73.24778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.4 - lat) + Math.Abs(-74.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.71472 - lat) + Math.Abs(-74.03306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.3 - lat) + Math.Abs(-75.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.01667 - lat) + Math.Abs(-69.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.65709 - lat) + Math.Abs(-75.10119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.61 - lat) + Math.Abs(-73.74 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.26667 - lat) + Math.Abs(-75.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.08833 - lat) + Math.Abs(-71.7575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.91333 - lat) + Math.Abs(-76.53833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.73333 - lat) + Math.Abs(-76.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.56667 - lat) + Math.Abs(-69.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14 - lat) + Math.Abs(-69.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.65056 - lat) + Math.Abs(-71.02139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.87417 - lat) + Math.Abs(-72.87278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.13333 - lat) + Math.Abs(-76.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.58556 - lat) + Math.Abs(-74.35056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.7 - lat) + Math.Abs(-74.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.10194 - lat) + Math.Abs(-72.70667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.83806 - lat) + Math.Abs(-72.65361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.03333 - lat) + Math.Abs(-75.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.06667 - lat) + Math.Abs(-75.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.1 - lat) + Math.Abs(-69.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.21861 - lat) + Math.Abs(-73.61917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.1 - lat) + Math.Abs(-73.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.48056 - lat) + Math.Abs(-70.1225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.94306 - lat) + Math.Abs(-76.70944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.58333 - lat) + Math.Abs(-75.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.4 - lat) + Math.Abs(-70.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.91417 - lat) + Math.Abs(-75.86306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.57556 - lat) + Math.Abs(-72.13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.63833 - lat) + Math.Abs(-71.60111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.4979 - lat) + Math.Abs(-70.21714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.36611 - lat) + Math.Abs(-73.87667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.96667 - lat) + Math.Abs(-74.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.51833 - lat) + Math.Abs(-73.72222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.39222 - lat) + Math.Abs(-72.04778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.63 - lat) + Math.Abs(-72.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.45894 - lat) + Math.Abs(-76.16325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.40985 - lat) + Math.Abs(-76.13235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.17139 - lat) + Math.Abs(-73.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.52111 - lat) + Math.Abs(-76.73722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.4 - lat) + Math.Abs(-71.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.70639 - lat) + Math.Abs(-76.26833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.5475 - lat) + Math.Abs(-72.91861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.3 - lat) + Math.Abs(-75.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.86806 - lat) + Math.Abs(-73.66722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.27278 - lat) + Math.Abs(-74.20472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.47278 - lat) + Math.Abs(-71.39389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.02694 - lat) + Math.Abs(-71.45278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.98333 - lat) + Math.Abs(-73.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.40696 - lat) + Math.Abs(-76.46168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.3 - lat) + Math.Abs(-77.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.24056 - lat) + Math.Abs(-73.07111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.46667 - lat) + Math.Abs(-71.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.97528 - lat) + Math.Abs(-73.065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.66417 - lat) + Math.Abs(-75.22333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.57139 - lat) + Math.Abs(-77.26722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.01667 - lat) + Math.Abs(-75.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.30833 - lat) + Math.Abs(-71.84306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.11667 - lat) + Math.Abs(-72.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.20417 - lat) + Math.Abs(-71.65444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.30056 - lat) + Math.Abs(-73.23083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.84778 - lat) + Math.Abs(-73.75333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.86583 - lat) + Math.Abs(-74.24694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.98278 - lat) + Math.Abs(-76.7675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.95972 - lat) + Math.Abs(-73.60917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.35 - lat) + Math.Abs(-75.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.73315 - lat) + Math.Abs(-75.75573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.66748 - lat) + Math.Abs(-76.25668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.585 - lat) + Math.Abs(-72.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.85278 - lat) + Math.Abs(-72.07917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.27167 - lat) + Math.Abs(-76.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.67222 - lat) + Math.Abs(-72.02194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.79472 - lat) + Math.Abs(-73.98889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.14167 - lat) + Math.Abs(-76.62472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.60472 - lat) + Math.Abs(-71.55944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.79889 - lat) + Math.Abs(-75.89194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.26667 - lat) + Math.Abs(-75.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.81667 - lat) + Math.Abs(-70.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.18222 - lat) + Math.Abs(-74.22472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.7425 - lat) + Math.Abs(-73.78833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.91667 - lat) + Math.Abs(-76.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.83889 - lat) + Math.Abs(-74.31194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.34417 - lat) + Math.Abs(-75.86833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.66083 - lat) + Math.Abs(-76.51444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.56667 - lat) + Math.Abs(-70.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.19194 - lat) + Math.Abs(-76.78028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.85333 - lat) + Math.Abs(-77.03778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.11944 - lat) + Math.Abs(-73.31806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.00806 - lat) + Math.Abs(-71.99806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.63333 - lat) + Math.Abs(-69.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.46722 - lat) + Math.Abs(-76.62417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.33899 - lat) + Math.Abs(-77.16943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.62861 - lat) + Math.Abs(-74.14389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.26778 - lat) + Math.Abs(-70.24944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.8058 - lat) + Math.Abs(-75.7165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.92139 - lat) + Math.Abs(-73.90528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.31667 - lat) + Math.Abs(-70.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.26806 - lat) + Math.Abs(-70.37806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.62375 - lat) + Math.Abs(-72.71055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.05659 - lat) + Math.Abs(-77.11814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.86667 - lat) + Math.Abs(-74.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.50833 - lat) + Math.Abs(-71.44556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.82833 - lat) + Math.Abs(-76.61639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.0925 - lat) + Math.Abs(-77.62667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.33333 - lat) + Math.Abs(-71.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.31667 - lat) + Math.Abs(-70.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.52611 - lat) + Math.Abs(-76.54278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.94167 - lat) + Math.Abs(-70.18694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.75 - lat) + Math.Abs(-70.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.15502 - lat) + Math.Abs(-77.43963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.88333 - lat) + Math.Abs(-74.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.28583 - lat) + Math.Abs(-70.36361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.595 - lat) + Math.Abs(-71.69944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.50611 - lat) + Math.Abs(-73.47917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.81278 - lat) + Math.Abs(-75.78306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.51333 - lat) + Math.Abs(-72.81 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.47583 - lat) + Math.Abs(-72.07222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.61667 - lat) + Math.Abs(-70.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.62139 - lat) + Math.Abs(-71.97889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.65 - lat) + Math.Abs(-70.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.29083 - lat) + Math.Abs(-73.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.06444 - lat) + Math.Abs(-74.005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.75 - lat) + Math.Abs(-77.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.07667 - lat) + Math.Abs(-76.73528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.90843 - lat) + Math.Abs(-70.19616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.05 - lat) + Math.Abs(-69.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.68167 - lat) + Math.Abs(-72.27417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.65 - lat) + Math.Abs(-73.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.88639 - lat) + Math.Abs(-70.58889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.15878 - lat) + Math.Abs(-74.22321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.55778 - lat) + Math.Abs(-77.18083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.68333 - lat) + Math.Abs(-70.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.79611 - lat) + Math.Abs(-74.36361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.20944 - lat) + Math.Abs(-73.62222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.80135 - lat) + Math.Abs(-75.43969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.055 - lat) + Math.Abs(-73.91 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.78333 - lat) + Math.Abs(-70.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.78333 - lat) + Math.Abs(-76.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.11667 - lat) + Math.Abs(-75.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.39889 - lat) + Math.Abs(-71.535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.13333 - lat) + Math.Abs(-70.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.62222 - lat) + Math.Abs(-76.66944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.07409 - lat) + Math.Abs(-77.14423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.01472 - lat) + Math.Abs(-73.93306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.07583 - lat) + Math.Abs(-72.49389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.85461 - lat) + Math.Abs(-75.35344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.4 - lat) + Math.Abs(-70.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.07361 - lat) + Math.Abs(-74.41194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.36056 - lat) + Math.Abs(-72.87556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.47056 - lat) + Math.Abs(-72.14833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.80861 - lat) + Math.Abs(-73.29111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.79667 - lat) + Math.Abs(-72.86056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.52611 - lat) + Math.Abs(-73.36611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.38722 - lat) + Math.Abs(-73.96083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.73194 - lat) + Math.Abs(-74.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.79222 - lat) + Math.Abs(-76.90944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.6725 - lat) + Math.Abs(-71.67944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.65556 - lat) + Math.Abs(-73.38722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.88333 - lat) + Math.Abs(-74.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.4425 - lat) + Math.Abs(-72.31083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.7 - lat) + Math.Abs(-69.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.13083 - lat) + Math.Abs(-76.20472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.73333 - lat) + Math.Abs(-77.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.27861 - lat) + Math.Abs(-75.78694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.62278 - lat) + Math.Abs(-71.26778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.13472 - lat) + Math.Abs(-72.76472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.1 - lat) + Math.Abs(-70.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.10472 - lat) + Math.Abs(-72.6125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.06667 - lat) + Math.Abs(-75.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.95083 - lat) + Math.Abs(-71.73722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.27361 - lat) + Math.Abs(-76.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.61667 - lat) + Math.Abs(-74.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.91667 - lat) + Math.Abs(-71.68111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.73193 - lat) + Math.Abs(-75.54634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.21778 - lat) + Math.Abs(-74.04333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.65 - lat) + Math.Abs(-75.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.86667 - lat) + Math.Abs(-74.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.35252 - lat) + Math.Abs(-75.66211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.76944 - lat) + Math.Abs(-71.25417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.95707 - lat) + Math.Abs(-75.36996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.49718 - lat) + Math.Abs(-77.24149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.66083 - lat) + Math.Abs(-71.70083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.26667 - lat) + Math.Abs(-70.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.80611 - lat) + Math.Abs(-73.96694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.8 - lat) + Math.Abs(-73.90306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.97389 - lat) + Math.Abs(-71.82667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.45778 - lat) + Math.Abs(-77.32729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.42393 - lat) + Math.Abs(-74.61361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.63389 - lat) + Math.Abs(-72.88139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.12 - lat) + Math.Abs(-71.47278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.4275 - lat) + Math.Abs(-71.8675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.92778 - lat) + Math.Abs(-72.48389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.30889 - lat) + Math.Abs(-72.94667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.20778 - lat) + Math.Abs(-73.06639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.1325 - lat) + Math.Abs(-73.26861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.44556 - lat) + Math.Abs(-72.08417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.37722 - lat) + Math.Abs(-73.16139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.16472 - lat) + Math.Abs(-72.62111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.06222 - lat) + Math.Abs(-72.66972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.76803 - lat) + Math.Abs(-71.45952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.50611 - lat) + Math.Abs(-71.49184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.63972 - lat) + Math.Abs(-71.06111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.63951 - lat) + Math.Abs(-71.29921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.56277 - lat) + Math.Abs(-71.30312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.28891 - lat) + Math.Abs(-70.04363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.615 - lat) + Math.Abs(-71.33833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.18137 - lat) + Math.Abs(-71.1407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.09272 - lat) + Math.Abs(-71.33119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.34147 - lat) + Math.Abs(-71.46311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.27683 - lat) + Math.Abs(-71.45026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.2461 - lat) + Math.Abs(-71.44442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.1254 - lat) + Math.Abs(-71.41216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.08976 - lat) + Math.Abs(-71.33664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.09425 - lat) + Math.Abs(-71.33922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.18391 - lat) + Math.Abs(-71.38343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.05417 - lat) + Math.Abs(-71.38583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.46968 - lat) + Math.Abs(-71.19843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.28514 - lat) + Math.Abs(-71.08773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.26989 - lat) + Math.Abs(-71.09599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.28083 - lat) + Math.Abs(-73.97611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.80528 - lat) + Math.Abs(-76.97889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.9275 - lat) + Math.Abs(-74.87417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.3875 - lat) + Math.Abs(-73.68972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.73513 - lat) + Math.Abs(-72.61568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.90741 - lat) + Math.Abs(-73.66779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.2925 - lat) + Math.Abs(-74.6275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.72417 - lat) + Math.Abs(-69.25556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.2975 - lat) + Math.Abs(-78.24 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.49139 - lat) + Math.Abs(-78.46861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.4375 - lat) + Math.Abs(-78.34972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.28111 - lat) + Math.Abs(-78.21278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.11167 - lat) + Math.Abs(-78.06139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.59306 - lat) + Math.Abs(-77.80806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.17833 - lat) + Math.Abs(-77.74917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.26167 - lat) + Math.Abs(-77.69278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.36917 - lat) + Math.Abs(-77.56333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.25639 - lat) + Math.Abs(-77.70028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.22667 - lat) + Math.Abs(-77.74056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.38278 - lat) + Math.Abs(-77.54528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.40639 - lat) + Math.Abs(-77.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.42806 - lat) + Math.Abs(-77.53611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.03389 - lat) + Math.Abs(-77.47917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.34722 - lat) + Math.Abs(-77.38944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.45556 - lat) + Math.Abs(-77.42667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.43833 - lat) + Math.Abs(-77.32056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.45667 - lat) + Math.Abs(-77.29833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.74278 - lat) + Math.Abs(-77.49722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.81528 - lat) + Math.Abs(-77.38278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.94056 - lat) + Math.Abs(-77.30806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.56556 - lat) + Math.Abs(-77.41583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.4525 - lat) + Math.Abs(-76.32389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.885 - lat) + Math.Abs(-73.56722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.49139 - lat) + Math.Abs(-76.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.61611 - lat) + Math.Abs(-78.92333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.12417 - lat) + Math.Abs(-78.4975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.62732 - lat) + Math.Abs(-74.97658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.70553 - lat) + Math.Abs(-76.70206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.54999 - lat) + Math.Abs(-76.81613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.53965 - lat) + Math.Abs(-76.73639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.95851 - lat) + Math.Abs(-76.24853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.89412 - lat) + Math.Abs(-76.41455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.94459 - lat) + Math.Abs(-76.22323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.78531 - lat) + Math.Abs(-75.67408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.78593 - lat) + Math.Abs(-75.37849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.79319 - lat) + Math.Abs(-75.48414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.768 - lat) + Math.Abs(-75.47441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.61607 - lat) + Math.Abs(-75.09115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.78509 - lat) + Math.Abs(-75.42597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.89161 - lat) + Math.Abs(-75.3435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.97147 - lat) + Math.Abs(-75.25065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.95671 - lat) + Math.Abs(-75.25685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.93581 - lat) + Math.Abs(-75.25959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.88982 - lat) + Math.Abs(-75.28571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.20273 - lat) + Math.Abs(-76.75967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.2329 - lat) + Math.Abs(-76.92328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.09536 - lat) + Math.Abs(-76.83688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.63333 - lat) + Math.Abs(-72.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.12823 - lat) + Math.Abs(-76.65018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.18298 - lat) + Math.Abs(-76.6933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.52821 - lat) + Math.Abs(-76.71823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.63126 - lat) + Math.Abs(-69.44638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.87655 - lat) + Math.Abs(-77.03345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.49989 - lat) + Math.Abs(-73.05136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.83605 - lat) + Math.Abs(-71.3649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.15395 - lat) + Math.Abs(-77.70263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.77326 - lat) + Math.Abs(-75.81109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zorritos", "24", -3.68046, -80.67819);
case 1: return new CityInfo("Yurimaguas", "16", -5.90181, -76.12234);
case 2: return new CityInfo("Yuracyacu", "22", -5.93139, -77.22667);
case 3: return new CityInfo("Yungay", "02", -9.13833, -77.74361);
case 4: return new CityInfo("Yungar", "02", -9.37778, -77.59306);
case 5: return new CityInfo("Yorongos", "22", -6.13972, -77.14389);
case 6: return new CityInfo("Yauya", "02", -8.98333, -77.3);
case 7: return new CityInfo("Yanas", "10", -9.71417, -76.74822);
case 8: return new CityInfo("Yanama", "02", -9.03333, -77.48333);
case 9: return new CityInfo("Yanac", "02", -8.61667, -77.86667);
case 10: return new CityInfo("Yambrasbamba", "01", -5.75, -77.9);
case 11: return new CityInfo("Yamango", "20", -5.1775, -79.75);
case 12: return new CityInfo("Vista Alegre", "01", -6.15139, -77.30056);
case 13: return new CityInfo("Virú", "13", -8.41554, -78.75201);
case 14: return new CityInfo("Vice", "20", -5.41667, -80.78333);
case 15: return new CityInfo("Uticyacu", "06", -6.63333, -78.8);
case 16: return new CityInfo("Usquil", "13", -7.81667, -78.41667);
case 17: return new CityInfo("Ucuncha", "13", -7.13333, -77.88333);
case 18: return new CityInfo("Uco", "02", -9.18839, -76.92767);
case 19: return new CityInfo("Uchiza", "22", -8.45917, -76.46333);
case 20: return new CityInfo("Tunal", "20", -5.20917, -79.67528);
case 21: return new CityInfo("Tumbes", "24", -3.56694, -80.45153);
case 22: return new CityInfo("Túcume", "14", -6.50637, -79.85725);
case 23: return new CityInfo("Trujillo", "13", -8.11599, -79.02998);
case 24: return new CityInfo("Trompeteros", "16", -3.81417, -75.05833);
case 25: return new CityInfo("Trinidad", "06", -7.35, -79.03333);
case 26: return new CityInfo("Tres Unidos", "22", -6.80694, -76.22944);
case 27: return new CityInfo("Tournavista", "10", -8.92947, -74.70771);
case 28: return new CityInfo("Totora", "01", -6.4925, -77.47306);
case 29: return new CityInfo("Tocmoche", "06", -6.4125, -79.36194);
case 30: return new CityInfo("Tocache", "22", -8.1877, -76.52046);
case 31: return new CityInfo("Tingo María", "10", -9.29532, -75.99574);
case 32: return new CityInfo("Tingo", "01", -6.37167, -77.91194);
case 33: return new CityInfo("Tinco", "02", -9.26972, -77.67944);
case 34: return new CityInfo("Ticapampa", "02", -9.75, -77.45);
case 35: return new CityInfo("Tembladera", "06", -7.26667, -79.15);
case 36: return new CityInfo("Tayabamba", "13", -8.27694, -77.29639);
case 37: return new CityInfo("Taurija", "13", -8.30861, -77.42194);
case 38: return new CityInfo("Tauca", "02", -8.48333, -78.05);
case 39: return new CityInfo("Tarica", "02", -9.39361, -77.57472);
case 40: return new CityInfo("Tarapoto", "22", -6.50139, -76.36556);
case 41: return new CityInfo("Tantamayo", "10", -9.39114, -76.72331);
case 42: return new CityInfo("Tambo Grande", "20", -4.92694, -80.34472);
case 43: return new CityInfo("Tamarindo", "20", -4.87722, -80.97306);
case 44: return new CityInfo("Tamanco", "16", -5.85, -74.31667);
case 45: return new CityInfo("Talara", "20", -4.57722, -81.27194);
case 46: return new CityInfo("Tacabamba", "06", -6.38333, -78.61667);
case 47: return new CityInfo("Tabalosos", "22", -6.35, -76.68333);
case 48: return new CityInfo("Tabaconas", "06", -5.31472, -79.28278);
case 49: return new CityInfo("Suyo", "20", -4.51392, -80.00313);
case 50: return new CityInfo("Sullana", "20", -4.90389, -80.68528);
case 51: return new CityInfo("Sucre", "02", -8.95, -77.85);
case 52: return new CityInfo("Sucre", "06", -6.93333, -78.15);
case 53: return new CityInfo("Succha", "02", -9.83333, -77.65);
case 54: return new CityInfo("Sorochuco", "06", -6.91083, -78.255);
case 55: return new CityInfo("Soritor", "22", -6.13917, -77.10389);
case 56: return new CityInfo("Sondorillo", "20", -5.33917, -79.43028);
case 57: return new CityInfo("Sondor", "20", -5.31222, -79.40639);
case 58: return new CityInfo("Soloco", "01", -6.26222, -77.74444);
case 59: return new CityInfo("Sojo", "20", -4.90083, -80.81583);
case 60: return new CityInfo("Socota", "06", -6.3, -78.73333);
case 61: return new CityInfo("Sitabamba", "13", -8.03333, -77.73333);
case 62: return new CityInfo("Sinsicap", "13", -7.83333, -78.76667);
case 63: return new CityInfo("Singa", "10", -9.38745, -76.81262);
case 64: return new CityInfo("Sinchao", "20", -5.41667, -80.66667);
case 65: return new CityInfo("Simbal", "13", -7.97639, -78.8136);
case 66: return new CityInfo("Sillapata", "10", -9.75794, -76.77443);
case 67: return new CityInfo("Sihuas", "02", -8.56667, -77.61667);
case 68: return new CityInfo("Shupluy", "02", -9.21778, -77.69417);
case 69: return new CityInfo("Shunqui", "10", -9.73384, -76.78651);
case 70: return new CityInfo("Shucushuyacu", "16", -6.01667, -75.85);
case 71: return new CityInfo("Shirac", "06", -7.35, -78.05);
case 72: return new CityInfo("Shilla", "02", -9.23083, -77.625);
case 73: return new CityInfo("Shapaja", "22", -6.57972, -76.26278);
case 74: return new CityInfo("Shamboyacu", "22", -7.02308, -76.13298);
case 75: return new CityInfo("Sexi", "06", -6.56361, -79.05139);
case 76: return new CityInfo("Sechura", "20", -5.55694, -80.82222);
case 77: return new CityInfo("Sayapullo", "13", -7.6, -78.46667);
case 78: return new CityInfo("Sauce", "22", -6.69139, -76.21472);
case 79: return new CityInfo("Sartimbamba", "13", -7.69917, -77.74361);
case 80: return new CityInfo("Saquena", "16", -4.66667, -73.51667);
case 81: return new CityInfo("Saposoa", "22", -6.93395, -76.77158);
case 82: return new CityInfo("Sapillica", "20", -4.77838, -79.98263);
case 83: return new CityInfo("Sapalache", "20", -5.15111, -79.43472);
case 84: return new CityInfo("Santo Domingo", "20", -5.02611, -79.87417);
case 85: return new CityInfo("Santiago de Chuco", "13", -8.14099, -78.17329);
case 86: return new CityInfo("Santiago de Cao", "13", -7.95889, -79.23917);
case 87: return new CityInfo("Santa Rosa", "14", -6.88111, -79.91972);
case 88: return new CityInfo("Santa Rosa", "14", -6.75772, -79.82747);
case 89: return new CityInfo("Santa Rosa", "22", -6.68333, -76.61667);
case 90: return new CityInfo("Santa Isabel", "16", -5.76667, -74.51667);
case 91: return new CityInfo("Santa Elena", "16", -6.03333, -74.08333);
case 92: return new CityInfo("Santa Cruz", "16", -5.55, -75.8);
case 93: return new CityInfo("Santa", "02", -8.98861, -78.61194);
case 94: return new CityInfo("San Rafael", "22", -7.0304, -76.47499);
case 95: return new CityInfo("San Pedro de Lloc", "13", -7.4289, -79.50416);
case 96: return new CityInfo("San Pablo", "06", -7.11667, -78.83333);
case 97: return new CityInfo("San Pablo", "22", -6.81923, -76.57578);
case 98: return new CityInfo("San Marcos", "02", -9.52491, -77.15681);
case 99: return new CityInfo("San Marcos", "06", -7.33333, -78.18333);
case 100: return new CityInfo("San Luis", "02", -9.08333, -77.35);
case 101: return new CityInfo("San Lorenzo", "16", -4.81667, -76.6);
case 102: return new CityInfo("San Juan", "06", -7.3, -78.5);
case 103: return new CityInfo("Sisa", "22", -6.61085, -76.69302);
case 104: return new CityInfo("San José", "14", -6.73813, -79.8275);
case 105: return new CityInfo("San Jacinto", "20", -4.84333, -80.87639);
case 106: return new CityInfo("San Jacinto", "24", -3.64194, -80.4475);
case 107: return new CityInfo("San Ignacio", "06", -5.14583, -79.00139);
case 108: return new CityInfo("San Gregorio", "06", -7.05, -79.1);
case 109: return new CityInfo("San Felipe", "06", -5.76778, -79.31167);
case 110: return new CityInfo("San Carlos", "01", -5.96667, -77.93333);
case 111: return new CityInfo("San Bernardino", "06", -7.18333, -78.83333);
case 112: return new CityInfo("San Benito", "06", -7.43333, -78.93333);
case 113: return new CityInfo("San Antonio", "22", -6.36667, -76.35);
case 114: return new CityInfo("Saña", "14", -6.91888, -79.582);
case 115: return new CityInfo("Samanco", "02", -9.26167, -78.49611);
case 116: return new CityInfo("Salpo", "13", -8, -78.61667);
case 117: return new CityInfo("Sallique", "06", -5.655, -79.31333);
case 118: return new CityInfo("Salitral", "20", -4.85722, -80.68111);
case 119: return new CityInfo("Salinera Colán", "20", -5.03333, -81.06667);
case 120: return new CityInfo("Guadalupito", "13", -8.95028, -78.62278);
case 121: return new CityInfo("Salaverry", "13", -8.221, -78.97698);
case 122: return new CityInfo("Salas", "14", -6.27472, -79.60417);
case 123: return new CityInfo("Sacanche", "22", -7.06935, -76.71484);
case 124: return new CityInfo("Roque", "22", -6.4, -76.8);
case 125: return new CityInfo("Rondos", "10", -9.98372, -76.68839);
case 126: return new CityInfo("Rioja", "22", -6.05675, -77.16651);
case 127: return new CityInfo("Requena", "16", -5.06083, -73.85028);
case 128: return new CityInfo("Reque", "14", -6.86556, -79.81778);
case 129: return new CityInfo("Recuay", "02", -9.72215, -77.4563);
case 130: return new CityInfo("Ranrahirca", "02", -9.17139, -77.72194);
case 131: return new CityInfo("Ramón Castilla", "16", -4.26066, -69.95714);
case 132: return new CityInfo("Quivilla", "10", -9.59929, -76.72494);
case 133: return new CityInfo("Quiruvilca", "13", -7.96667, -78.2);
case 134: return new CityInfo("Quinuabamba", "02", -8.73333, -77.36667);
case 135: return new CityInfo("Quinjalca", "01", -6.09222, -77.67806);
case 136: return new CityInfo("Quillo", "02", -9.32917, -78.04139);
case 137: return new CityInfo("Quiches", "02", -8.395, -77.49083);
case 138: return new CityInfo("Querocoto", "06", -6.35889, -79.03583);
case 139: return new CityInfo("Querocotillo", "06", -6.27389, -79.03806);
case 140: return new CityInfo("Querecotillo", "20", -4.83778, -80.64556);
case 141: return new CityInfo("Puños", "10", -9.49735, -76.88469);
case 142: return new CityInfo("Punchao", "10", -9.46221, -76.81953);
case 143: return new CityInfo("Puerto Santa", "02", -8.98772, -78.64727);
case 144: return new CityInfo("Puerto Rico", "22", -6.99222, -76.41917);
case 145: return new CityInfo("Puerto Inca", "10", -9.377, -74.96564);
case 146: return new CityInfo("Puerto Galilea", "01", -4.05743, -77.75848);
case 147: return new CityInfo("Puerto Casma", "02", -9.46361, -78.3825);
case 148: return new CityInfo("Chao", "13", -8.54306, -78.67917);
case 149: return new CityInfo("Pueblo Nuevo", "13", -7.18806, -79.51528);
case 150: return new CityInfo("Pueblo Nuevo", "14", -5.71667, -79.88333);
case 151: return new CityInfo("Pucallpa", "25", -8.37915, -74.55387);
case 152: return new CityInfo("Pucacaca", "22", -6.85167, -76.34167);
case 153: return new CityInfo("Posic", "22", -6.01389, -77.16361);
case 154: return new CityInfo("Poroto", "13", -8.01125, -78.76769);
case 155: return new CityInfo("Pomalca", "14", -6.7675, -79.77722);
case 156: return new CityInfo("Pomahuaca", "06", -5.92861, -79.22611);
case 157: return new CityInfo("Pomabamba", "02", -8.83333, -77.46667);
case 158: return new CityInfo("Piura", "20", -5.19449, -80.63282);
case 159: return new CityInfo("Piscoyacu", "22", -6.97984, -76.76813);
case 160: return new CityInfo("Pira", "02", -9.56667, -77.71667);
case 161: return new CityInfo("Pimentel", "14", -6.83667, -79.93417);
case 162: return new CityInfo("Pilluana", "22", -6.7775, -76.29056);
case 163: return new CityInfo("Picsi", "14", -6.71778, -79.76972);
case 164: return new CityInfo("Picota", "22", -6.92033, -76.33142);
case 165: return new CityInfo("Pelejo", "22", -6.21667, -75.81667);
case 166: return new CityInfo("Pebas", "16", -3.32879, -71.85505);
case 167: return new CityInfo("Paucas", "02", -9.15227, -76.89906);
case 168: return new CityInfo("Paltashaco", "20", -5.09972, -79.88333);
case 169: return new CityInfo("Parinari", "16", -4.56667, -74.43333);
case 170: return new CityInfo("Papayal", "24", -3.59667, -80.20889);
case 171: return new CityInfo("Pantoja", "16", -0.96667, -75.16667);
case 172: return new CityInfo("Panao", "10", -9.89778, -75.99333);
case 173: return new CityInfo("Pampas", "02", -9.66667, -77.83333);
case 174: return new CityInfo("Pampas", "02", -8.2, -77.9);
case 175: return new CityInfo("Pamparomas", "02", -9.07361, -77.98139);
case 176: return new CityInfo("Pampa Hermosa", "16", -7.2, -75.3);
case 177: return new CityInfo("Pallasca", "02", -8.25, -78.01667);
case 178: return new CityInfo("Paita", "20", -5.08917, -81.11444);
case 179: return new CityInfo("Paimas", "20", -4.6269, -79.94456);
case 180: return new CityInfo("Paiján", "13", -7.73291, -79.3015);
case 181: return new CityInfo("Pacora", "14", -6.42889, -79.83889);
case 182: return new CityInfo("Paclas", "01", -6.06222, -77.97667);
case 183: return new CityInfo("Pachas", "10", -9.70651, -76.77113);
case 184: return new CityInfo("Paccha", "06", -6.49778, -78.41833);
case 185: return new CityInfo("Pacasmayo", "13", -7.40056, -79.57139);
case 186: return new CityInfo("Pacanga", "13", -7.16667, -79.5);
case 187: return new CityInfo("Pacaipampa", "20", -4.99502, -79.66773);
case 188: return new CityInfo("Oyotún", "14", -6.84438, -79.30093);
case 189: return new CityInfo("Oxamarca", "06", -7.03333, -78.06667);
case 190: return new CityInfo("Otuzco", "13", -7.9, -78.58333);
case 191: return new CityInfo("Orellana", "16", -6.9, -75.16667);
case 192: return new CityInfo("Omia", "01", -6.46861, -77.39444);
case 193: return new CityInfo("Olto", "01", -6.1025, -77.95944);
case 194: return new CityInfo("Olmos", "14", -5.98472, -79.74528);
case 195: return new CityInfo("Olleros", "02", -9.63333, -77.48333);
case 196: return new CityInfo("Olleros", "01", -6.04861, -77.64583);
case 197: return new CityInfo("Obas", "10", -9.79535, -76.66557);
case 198: return new CityInfo("Nueva Arica", "14", -6.87278, -79.34278);
case 199: return new CityInfo("Niepos", "06", -6.92694, -79.12861);
case 200: return new CityInfo("Nepeña", "02", -9.1725, -78.35889);
case 201: return new CityInfo("Negritos", "20", -4.65389, -81.30472);
case 202: return new CityInfo("Navarro", "22", -6.33333, -75.75);
case 203: return new CityInfo("Nauta", "16", -4.53333, -73.55);
case 204: return new CityInfo("Nanchoc", "06", -6.95972, -79.24222);
case 205: return new CityInfo("Namora", "06", -7.2, -78.33333);
case 206: return new CityInfo("Namballe", "06", -5.00352, -79.08907);
case 207: return new CityInfo("Moyobamba", "22", -6.03416, -76.97168);
case 208: return new CityInfo("Motupe", "14", -6.15194, -79.71417);
case 209: return new CityInfo("Morropón", "20", -5.1868, -79.97076);
case 210: return new CityInfo("Mórrope", "14", -6.53536, -80.01104);
case 211: return new CityInfo("Moro", "02", -9.13889, -78.18194);
case 212: return new CityInfo("Montevideo", "01", -6.61583, -77.8025);
case 213: return new CityInfo("Montero", "20", -4.63066, -79.82855);
case 214: return new CityInfo("Monsefú", "14", -6.87431, -79.86871);
case 215: return new CityInfo("Mollepata", "13", -8.2, -77.95);
case 216: return new CityInfo("Mocupe", "14", -6.98944, -79.61917);
case 217: return new CityInfo("Mochumí", "14", -6.54364, -79.86217);
case 218: return new CityInfo("Moche", "13", -8.17111, -79.00917);
case 219: return new CityInfo("Miraflores", "10", -9.49396, -76.8187);
case 220: return new CityInfo("Miracosta", "06", -6.40417, -79.28444);
case 221: return new CityInfo("Milpuc", "01", -6.49361, -77.435);
case 222: return new CityInfo("Mendoza", "01", -6.39444, -77.48167);
case 223: return new CityInfo("Matapalo", "24", -3.68271, -80.19899);
case 224: return new CityInfo("Masisea", "25", -8.60528, -74.30472);
case 225: return new CityInfo("Marcavelica", "20", -4.87778, -80.70528);
case 226: return new CityInfo("Marcara District", "02", -9.3225, -77.60361);
case 227: return new CityInfo("Marcabal", "13", -7.7, -78.03333);
case 228: return new CityInfo("Mancos", "02", -9.19111, -77.71333);
case 229: return new CityInfo("Máncora", "20", -4.10778, -81.0475);
case 230: return new CityInfo("Malvas", "02", -9.91667, -77.68333);
case 231: return new CityInfo("Maino", "01", -6.33667, -77.88);
case 232: return new CityInfo("Magdalena", "06", -7.25, -78.66667);
case 233: return new CityInfo("Magdalena", "01", -6.37306, -77.9);
case 234: return new CityInfo("Mache", "13", -8.03333, -78.53333);
case 235: return new CityInfo("Macate", "02", -8.76667, -78.08333);
case 236: return new CityInfo("Luya", "01", -6.16389, -77.94528);
case 237: return new CityInfo("Lucmapampa", "06", -6.95, -78.1);
case 238: return new CityInfo("Lucma", "02", -8.91667, -77.41667);
case 239: return new CityInfo("Lucma", "13", -7.63333, -78.55);
case 240: return new CityInfo("Los Organos", "20", -4.17806, -81.12472);
case 241: return new CityInfo("Lonya Grande", "01", -6.095, -78.42139);
case 242: return new CityInfo("Lonya Chico", "01", -6.23111, -77.95639);
case 243: return new CityInfo("Longuita", "01", -6.41417, -77.96861);
case 244: return new CityInfo("Longotea", "13", -7.06667, -77.91667);
case 245: return new CityInfo("Lobitos", "20", -4.45674, -81.28487);
case 246: return new CityInfo("Lluchubamba", "06", -7.52167, -77.97083);
case 247: return new CityInfo("Llata", "10", -9.41667, -76.78333);
case 248: return new CityInfo("Llapa", "06", -6.98333, -78.81667);
case 249: return new CityInfo("Llama", "02", -8.88333, -77.3);
case 250: return new CityInfo("Llama", "06", -6.51444, -79.12028);
case 251: return new CityInfo("Llacanora", "06", -7.2, -78.43333);
case 252: return new CityInfo("Licupis", "06", -6.42444, -79.24167);
case 253: return new CityInfo("Levanto", "01", -6.30833, -77.89861);
case 254: return new CityInfo("La Unión", "10", -9.82702, -76.80199);
case 255: return new CityInfo("La Unión", "20", -5.40232, -80.74224);
case 256: return new CityInfo("Las Palmas", "10", -9.38412, -76.00505);
case 257: return new CityInfo("Las Lomas", "20", -4.65333, -80.24667);
case 258: return new CityInfo("Laredo", "13", -8.08965, -78.9602);
case 259: return new CityInfo("La Peca", "01", -5.61111, -78.435);
case 260: return new CityInfo("La Pampa", "02", -8.65, -77.9);
case 261: return new CityInfo("Lamud", "01", -6.13722, -77.95361);
case 262: return new CityInfo("La Merced", "02", -9.7352, -77.61686);
case 263: return new CityInfo("Lambayeque", "14", -6.70111, -79.90611);
case 264: return new CityInfo("Lamas", "22", -6.41667, -76.53333);
case 265: return new CityInfo("Lajas", "06", -6.56667, -78.73333);
case 266: return new CityInfo("La Jalca", "01", -6.48611, -77.81528);
case 267: return new CityInfo("La Huaca", "20", -4.91167, -80.96);
case 268: return new CityInfo("Lagunas", "16", -5.22694, -75.67528);
case 269: return new CityInfo("Lagunas", "20", -4.7894, -79.84439);
case 270: return new CityInfo("La Grama", "06", -7.46667, -78.13333);
case 271: return new CityInfo("La Esperanza", "13", -8.0764, -79.04371);
case 272: return new CityInfo("La Cuesta", "13", -7.91667, -78.71667);
case 273: return new CityInfo("Lacabamba", "02", -8.26667, -77.9);
case 274: return new CityInfo("La Arena", "20", -5.33333, -80.73333);
case 275: return new CityInfo("Juanjuí", "22", -7.17697, -76.72774);
case 276: return new CityInfo("Juan Guerra", "22", -6.58278, -76.33);
case 277: return new CityInfo("Jilili", "20", -4.5827, -79.79713);
case 278: return new CityInfo("Jepelacio", "22", -6.11667, -76.95);
case 279: return new CityInfo("Jeberos", "16", -5.28333, -76.28333);
case 280: return new CityInfo("Jayanca", "14", -6.39083, -79.82194);
case 281: return new CityInfo("Jangas", "02", -9.4025, -77.57583);
case 282: return new CityInfo("Jamalca", "01", -5.86722, -78.26167);
case 283: return new CityInfo("Jaén", "06", -5.70729, -78.80785);
case 284: return new CityInfo("Iquitos", "16", -3.74912, -73.25383);
case 285: return new CityInfo("Iparia", "25", -9.3, -74.53333);
case 286: return new CityInfo("Inguilpata", "01", -6.24083, -77.95722);
case 287: return new CityInfo("Incahuasi", "14", -6.23556, -79.31694);
case 288: return new CityInfo("Inahuaya", "16", -7.15, -75.28333);
case 289: return new CityInfo("Iberia", "16", -5.66667, -74.15);
case 290: return new CityInfo("Huicungo", "22", -7.3186, -76.77556);
case 291: return new CityInfo("Huaylillas", "13", -8.18722, -77.3425);
case 292: return new CityInfo("Huata", "02", -9.01611, -77.86083);
case 293: return new CityInfo("Huarmaca", "20", -5.56583, -79.52194);
case 294: return new CityInfo("Huaripampa", "02", -8.95, -77.83333);
case 295: return new CityInfo("Huari", "02", -9.33333, -77.23333);
case 296: return new CityInfo("Huaraz", "02", -9.52779, -77.52778);
case 297: return new CityInfo("Huaranchal", "13", -7.68333, -78.45);
case 298: return new CityInfo("Huánuco", "10", -9.93062, -76.24223);
case 299: return new CityInfo("Huandoval", "02", -8.33333, -77.98333);
case 300: return new CityInfo("Huanchay", "02", -9.73333, -77.83333);
case 301: return new CityInfo("Huanchaco", "13", -8.08333, -79.11667);
case 302: return new CityInfo("Huancas", "01", -6.17417, -77.86528);
case 303: return new CityInfo("Huancabamba", "20", -5.23861, -79.45056);
case 304: return new CityInfo("Huambos", "06", -6.46667, -78.96667);
case 305: return new CityInfo("Huamachuco", "13", -7.8, -78.06667);
case 306: return new CityInfo("Huallanca", "02", -9.89796, -76.94089);
case 307: return new CityInfo("Huallanca", "02", -8.81667, -77.86667);
case 308: return new CityInfo("Hualgayoc", "06", -6.76667, -78.61667);
case 309: return new CityInfo("Huacrachuco", "10", -8.65, -77.08333);
case 310: return new CityInfo("Huachis", "02", -9.41667, -77.11667);
case 311: return new CityInfo("Huacchis", "02", -9.20033, -76.7878);
case 312: return new CityInfo("Huacaybamba", "10", -9.03819, -76.95293);
case 313: return new CityInfo("Huacaschuque", "02", -8.3, -78);
case 314: return new CityInfo("Huacapampa", "06", -6.93333, -78.13333);
case 315: return new CityInfo("Huacachi", "02", -9.31674, -76.93953);
case 316: return new CityInfo("Honoria", "10", -8.76917, -74.71008);
case 317: return new CityInfo("Habana", "22", -6.08167, -77.09083);
case 318: return new CityInfo("Guzmango", "06", -7.38333, -78.9);
case 319: return new CityInfo("Guadalupe", "13", -7.25, -79.48333);
case 320: return new CityInfo("Granada", "01", -6.09917, -77.62667);
case 321: return new CityInfo("Frias", "20", -4.92958, -79.94796);
case 322: return new CityInfo("La Florida", "06", -6.86972, -79.12111);
case 323: return new CityInfo("Ferreñafe", "14", -6.63889, -79.78889);
case 324: return new CityInfo("Eten", "14", -6.90806, -79.86417);
case 325: return new CityInfo("San Antonio del Estrecho", "16", -2.45012, -72.66896);
case 326: return new CityInfo("Encañada", "06", -7.08333, -78.35);
case 327: return new CityInfo("El Prado", "06", -7.03333, -79);
case 328: return new CityInfo("El Porvenir", "13", -8.08333, -79);
case 329: return new CityInfo("El Parco District", "01", -5.62436, -78.47594);
case 330: return new CityInfo("El Alto", "20", -4.26851, -81.21719);
case 331: return new CityInfo("Dos Pueblos", "20", -5.45, -80.76667);
case 332: return new CityInfo("Cutervo", "06", -6.36667, -78.85);
case 333: return new CityInfo("Curgos", "13", -7.85972, -77.94333);
case 334: return new CityInfo("Cumba", "01", -5.93306, -78.66278);
case 335: return new CityInfo("La Caleta Culebras", "02", -9.94889, -78.22528);
case 336: return new CityInfo("Cujillo", "06", -6.11667, -78.53333);
case 337: return new CityInfo("Cuispes", "01", -5.91667, -77.93333);
case 338: return new CityInfo("Corongo", "02", -8.58333, -77.91667);
case 339: return new CityInfo("Coris", "02", -9.83333, -77.75);
case 340: return new CityInfo("Contamana", "16", -7.33333, -75.01667);
case 341: return new CityInfo("Concordia", "16", -4.56667, -74.78333);
case 342: return new CityInfo("Conchucos", "02", -8.26667, -77.85);
case 343: return new CityInfo("Colcamar", "01", -6.30111, -77.9725);
case 344: return new CityInfo("Colcabamba", "02", -9.58333, -77.81667);
case 345: return new CityInfo("Colasay", "06", -5.97528, -79.06611);
case 346: return new CityInfo("Coishco", "02", -9.02306, -78.61556);
case 347: return new CityInfo("Cochabamba", "02", -9.49361, -77.85944);
case 348: return new CityInfo("Cochabamba", "06", -6.48333, -78.9);
case 349: return new CityInfo("Cocabamba", "01", -6.6, -78.01667);
case 350: return new CityInfo("Churuja", "01", -6.01417, -77.95333);
case 351: return new CityInfo("Churubamba", "10", -9.82557, -76.13327);
case 352: return new CityInfo("Chuquis", "10", -9.67658, -76.70396);
case 353: return new CityInfo("Chuquibamba", "01", -6.93417, -77.85222);
case 354: return new CityInfo("Chumuch", "06", -6.6, -78.21667);
case 355: return new CityInfo("Chulucanas", "20", -5.0925, -80.1625);
case 356: return new CityInfo("Chugur", "06", -6.66667, -78.75);
case 357: return new CityInfo("Chugay", "13", -7.78167, -77.86833);
case 358: return new CityInfo("Chota", "06", -6.55, -78.65);
case 359: return new CityInfo("Choros", "06", -5.90139, -78.69417);
case 360: return new CityInfo("Chongoyape", "14", -6.64056, -79.38917);
case 361: return new CityInfo("Chocope", "13", -7.79139, -79.22167);
case 362: return new CityInfo("Chisquilla", "01", -5.88333, -77.73333);
case 363: return new CityInfo("Chirinos", "06", -5.305, -78.89833);
case 364: return new CityInfo("Chiriaco", "01", -5.16, -78.28889);
case 365: return new CityInfo("Chingas", "02", -9.11967, -76.99126);
case 366: return new CityInfo("Chimbote", "02", -9.08528, -78.57833);
case 367: return new CityInfo("Chillia", "13", -8.1, -77.48333);
case 368: return new CityInfo("Chilete", "06", -7.23333, -78.85);
case 369: return new CityInfo("Chiguirip", "06", -6.41667, -78.73333);
case 370: return new CityInfo("Chiclayo", "14", -6.77137, -79.84088);
case 371: return new CityInfo("Chicama", "13", -7.84472, -79.14694);
case 372: return new CityInfo("Chetilla", "06", -7.15, -78.66667);
case 373: return new CityInfo("Chepén", "13", -7.22436, -79.42476);
case 374: return new CityInfo("Chavinillo", "10", -9.8585, -76.60855);
case 375: return new CityInfo("Chazuta", "22", -6.57087, -76.13753);
case 376: return new CityInfo("Charat", "13", -7.83333, -78.45);
case 377: return new CityInfo("Chalaco", "20", -5.03889, -79.79389);
case 378: return new CityInfo("Chaglla", "10", -9.84361, -75.90306);
case 379: return new CityInfo("Chachapoyas", "01", -6.23169, -77.86903);
case 380: return new CityInfo("Chacas", "02", -9.23333, -77.38333);
case 381: return new CityInfo("Celendín", "06", -6.8659, -78.14585);
case 382: return new CityInfo("Cauday", "06", -7.58333, -78.08333);
case 383: return new CityInfo("Catache", "06", -6.67528, -79.03306);
case 384: return new CityInfo("Catacaos", "20", -5.26667, -80.68333);
case 385: return new CityInfo("Catac", "02", -9.8, -77.43333);
case 386: return new CityInfo("Caspisapa", "22", -6.95694, -76.41806);
case 387: return new CityInfo("Casma", "02", -9.47472, -78.30167);
case 388: return new CityInfo("Cascas", "13", -7.48333, -78.81667);
case 389: return new CityInfo("Cascapara", "02", -9.22583, -77.71639);
case 390: return new CityInfo("Casa Grande", "13", -7.74389, -79.18639);
case 391: return new CityInfo("Carhuaz", "02", -9.28194, -77.64472);
case 392: return new CityInfo("Carás", "02", -9.04692, -77.80901);
case 393: return new CityInfo("Carabamba", "13", -8.11667, -78.61667);
case 394: return new CityInfo("Canchaque", "20", -5.37306, -79.60028);
case 395: return new CityInfo("Cancas", "24", -3.94667, -80.94167);
case 396: return new CityInfo("Cañaveral", "24", -3.94167, -80.65083);
case 397: return new CityInfo("Cañaris", "14", -6.04611, -79.26472);
case 398: return new CityInfo("Calzada", "22", -6.03194, -77.06639);
case 399: return new CityInfo("Caleta Cruz", "24", -3.6375, -80.59167);
case 400: return new CityInfo("Cajaruro", "01", -5.73639, -78.42556);
case 401: return new CityInfo("Cajamarquilla", "02", -9.63333, -77.75);
case 402: return new CityInfo("Cajamarca", "06", -7.16378, -78.50027);
case 403: return new CityInfo("Cajabamba", "06", -7.61667, -78.05);
case 404: return new CityInfo("Cahuac", "10", -9.85261, -76.63035);
case 405: return new CityInfo("Cachachi", "06", -7.45, -78.28333);
case 406: return new CityInfo("Cabana", "02", -8.4, -78.03333);
case 407: return new CityInfo("Caballococha", "16", -3.90583, -70.51639);
case 408: return new CityInfo("Buenos Aires", "13", -8.13861, -79.04028);
case 409: return new CityInfo("Buenos Aires", "20", -5.26083, -79.96417);
case 410: return new CityInfo("Breu", "25", -9.48333, -72.71667);
case 411: return new CityInfo("Bretaña", "16", -5.26667, -74.28333);
case 412: return new CityInfo("Bolognesi", "02", -8.35, -78.06667);
case 413: return new CityInfo("Bernal", "20", -5.45, -80.75);
case 414: return new CityInfo("Bellavista", "22", -7.05614, -76.5911);
case 415: return new CityInfo("Bellavista", "06", -5.66417, -78.67722);
case 416: return new CityInfo("Barranquita", "22", -6.26667, -76.01667);
case 417: return new CityInfo("Barranca", "16", -4.83298, -76.67582);
case 418: return new CityInfo("Bambas", "02", -8.6, -78);
case 419: return new CityInfo("Bambamarca", "06", -6.68333, -78.53333);
case 420: return new CityInfo("Balsas", "01", -6.83333, -78.01667);
case 421: return new CityInfo("Bagua Grande", "01", -5.75611, -78.44111);
case 422: return new CityInfo("Bagua", "01", -5.63311, -78.53431);
case 423: return new CityInfo("Ayabaca", "20", -4.63983, -79.71491);
case 424: return new CityInfo("Aucayacu", "10", -8.93139, -76.11315);
case 425: return new CityInfo("Ascope", "13", -7.71444, -79.10778);
case 426: return new CityInfo("Aricapampa", "13", -7.80583, -77.71722);
case 427: return new CityInfo("Arenal", "20", -4.88333, -81.0275);
case 428: return new CityInfo("Arancay", "10", -9.17227, -76.74895);
case 429: return new CityInfo("Aramango", "01", -5.41639, -78.43583);
case 430: return new CityInfo("Anta", "02", -9.35861, -77.59722);
case 431: return new CityInfo("Angasmarca", "13", -8.13333, -78.06667);
case 432: return new CityInfo("Amotape", "20", -4.88167, -81.01556);
case 433: return new CityInfo("Amashca", "02", -9.23917, -77.64639);
case 434: return new CityInfo("Aija", "02", -9.78105, -77.6094);
case 435: return new CityInfo("Aguas Verdes", "24", -3.48139, -80.245);
case 436: return new CityInfo("Agua Blanca", "22", -6.72343, -76.69643);
case 437: return new CityInfo("Agallpampa", "13", -7.98333, -78.55);
case 438: return new CityInfo("Aczo", "02", -9.15193, -76.98925);
case 439: return new CityInfo("Acopampa", "02", -9.29722, -77.61778);
case 440: return new CityInfo("Acomayo", "10", -9.80105, -76.07194);
case 441: return new CityInfo("Aco", "02", -8.53333, -77.88333);
case 442: return new CityInfo("Puerto Callao", "25", -8.35806, -74.57361);
case 443: return new CityInfo("Campoverde", "25", -8.47533, -74.80709);
case 444: return new CityInfo("Nueva Requena", "25", -8.31139, -74.86222);
case 445: return new CityInfo("La Coipa", "06", -5.43361, -78.86361);
case 446: return new CityInfo("La Sacilia", "06", -5.95167, -78.72722);
case 447: return new CityInfo("Alianza Cristiana", "16", -3.47528, -76.43444);
case 448: return new CityInfo("Utco", "06", -6.91667, -78.05);
case 449: return new CityInfo("Las Pirias", "06", -5.62722, -78.85278);
case 450: return new CityInfo("Zapatero", "22", -6.52972, -76.4925);
case 451: return new CityInfo("Cuñumbuqui", "22", -6.51111, -76.48);
case 452: return new CityInfo("Utcurarca", "22", -6.66306, -76.28667);
case 453: return new CityInfo("Buenos Aires", "22", -6.79111, -76.32639);
case 454: return new CityInfo("Manuel Antonio Mesones Muro", "14", -6.64361, -79.73806);
case 455: return new CityInfo("La Breita", "20", -4.25691, -80.88599);
case 456: return new CityInfo("Papayal", "24", -4.07771, -80.7369);
case 457: return new CityInfo("Zarumilla", "24", -3.50306, -80.27306);
case 458: return new CityInfo("Zurite", "08", -13.45472, -72.25556);
case 459: return new CityInfo("Zepita", "21", -16.5, -69.1);
case 460: return new CityInfo("Yura", "04", -16.25223, -71.67969);
case 461: return new CityInfo("Yunguyo", "21", -16.25, -69.08333);
case 462: return new CityInfo("Yunga", "18", -16.2, -70.68333);
case 463: return new CityInfo("Yucay", "08", -13.32139, -72.08222);
case 464: return new CityInfo("Yauyos", "15", -12.45944, -75.91722);
case 465: return new CityInfo("Yaurisque", "08", -13.66694, -71.92111);
case 466: return new CityInfo("Yauli", "12", -11.71366, -75.47466);
case 467: return new CityInfo("Yauli", "12", -11.665, -76.08639);
case 468: return new CityInfo("Rosario de Yauca", "11", -14.13532, -75.57371);
case 469: return new CityInfo("Yauca", "04", -15.66111, -74.52722);
case 470: return new CityInfo("Yarabamba", "04", -16.54722, -71.47667);
case 471: return new CityInfo("Yanque", "04", -15.64917, -71.65778);
case 472: return new CityInfo("Yangas", "15", -11.695, -76.84556);
case 473: return new CityInfo("Yanaquihua", "04", -15.77389, -72.87667);
case 474: return new CityInfo("Yanaoca", "08", -14.21806, -71.43167);
case 475: return new CityInfo("Yanahuaya", "21", -14.26667, -69.2);
case 476: return new CityInfo("Yanahuanca", "19", -10.51667, -76.49861);
case 477: return new CityInfo("Yanacancha", "12", -12.2, -75.41667);
case 478: return new CityInfo("Yanacancha", "10", -10.24111, -76.64556);
case 479: return new CityInfo("Yanaca", "03", -14.21778, -73.14111);
case 480: return new CityInfo("Vizcachane", "04", -15.80861, -71.20111);
case 481: return new CityInfo("Vitis", "15", -12.22361, -75.80639);
case 482: return new CityInfo("Vitarte", "15", -12.03333, -76.93333);
case 483: return new CityInfo("Vischongo", "05", -13.58917, -73.99444);
case 484: return new CityInfo("Viraco", "04", -15.65694, -72.52528);
case 485: return new CityInfo("Vinchos", "05", -13.24083, -74.35306);
case 486: return new CityInfo("Viñac", "15", -12.93111, -75.77861);
case 487: return new CityInfo("Vilque Chico", "21", -15.21667, -69.68333);
case 488: return new CityInfo("Vilque", "21", -15.76667, -70.25);
case 489: return new CityInfo("Villa Tupac Amaru", "11", -13.71135, -76.1498);
case 490: return new CityInfo("Villa Rica", "19", -10.73944, -75.26972);
case 491: return new CityInfo("Vilcanchos", "05", -13.61167, -74.53194);
case 492: return new CityInfo("Vilcabamba", "03", -14.07556, -72.62583);
case 493: return new CityInfo("Vilcabamba", "19", -10.47806, -76.4475);
case 494: return new CityInfo("Vilca", "09", -12.48333, -75.18333);
case 495: return new CityInfo("Vilavila", "21", -15.18694, -70.66);
case 496: return new CityInfo("Ventanilla", "07", -11.87528, -77.11833);
case 497: return new CityInfo("Velinga", "04", -15.27333, -73.02167);
case 498: return new CityInfo("Velille", "08", -14.50889, -71.88528);
case 499: return new CityInfo("Végueta", "15", -11.02253, -77.64378);
case 500: return new CityInfo("Usicayos", "21", -14.12472, -69.96611);
case 501: return new CityInfo("Urubamba", "08", -13.30472, -72.11583);
case 502: return new CityInfo("Uripa", "03", -13.5325, -73.67722);
case 503: return new CityInfo("Urcos", "08", -13.68611, -71.62278);
case 504: return new CityInfo("Urasqui", "04", -16.02861, -73.17056);
case 505: return new CityInfo("Upahuacho", "05", -14.90167, -73.40111);
case 506: return new CityInfo("Uñon", "04", -15.72944, -72.42972);
case 507: return new CityInfo("Umachiri", "21", -14.8575, -70.75611);
case 508: return new CityInfo("Uchumayo", "04", -16.42508, -71.67215);
case 509: return new CityInfo("Ubinas", "18", -16.4, -70.86667);
case 510: return new CityInfo("Tuti", "04", -15.53306, -71.55083);
case 511: return new CityInfo("Turpo", "03", -13.78528, -73.47361);
case 512: return new CityInfo("Turpay", "03", -14.21917, -72.62389);
case 513: return new CityInfo("Tupe", "15", -12.74083, -75.80833);
case 514: return new CityInfo("Tungasuca", "08", -14.16389, -71.47667);
case 515: return new CityInfo("Totos", "05", -13.56722, -74.52361);
case 516: return new CityInfo("Totoral", "23", -17.4062, -70.36464);
case 517: return new CityInfo("Toro", "04", -15.26417, -72.92889);
case 518: return new CityInfo("Toraya", "03", -14.05056, -73.29722);
case 519: return new CityInfo("Torata", "18", -17.07694, -70.84333);
case 520: return new CityInfo("Tomepampa", "04", -15.17306, -72.83083);
case 521: return new CityInfo("Tomay Kichwa", "10", -10.07722, -76.21194);
case 522: return new CityInfo("Tomas", "15", -12.23861, -75.74528);
case 523: return new CityInfo("Tocota", "04", -15.65944, -74.09056);
case 524: return new CityInfo("Tibillo", "11", -14.09306, -75.17194);
case 525: return new CityInfo("Tisco", "04", -15.34611, -71.44778);
case 526: return new CityInfo("Tirapata", "21", -14.95, -70.4);
case 527: return new CityInfo("Tiquillaca", "21", -15.81667, -70.2);
case 528: return new CityInfo("Tinyahuarco", "19", -10.76771, -76.27523);
case 529: return new CityInfo("Tintay", "03", -13.95917, -73.18583);
case 530: return new CityInfo("Tinta", "08", -14.145, -71.40694);
case 531: return new CityInfo("Ticrapo", "09", -13.35, -75.41667);
case 532: return new CityInfo("Ticllos", "02", -10.25403, -77.19088);
case 533: return new CityInfo("Ticllas", "05", -13.1325, -74.33278);
case 534: return new CityInfo("Ticaco", "23", -17.44639, -70.04694);
case 535: return new CityInfo("Tiabaya", "04", -16.45, -71.59);
case 536: return new CityInfo("Taurisma", "04", -15.175, -72.85028);
case 537: return new CityInfo("Tauripampa", "15", -12.58333, -76.11667);
case 538: return new CityInfo("Tauria", "04", -15.35611, -73.2325);
case 539: return new CityInfo("Tarucani", "04", -16.18333, -71.06667);
case 540: return new CityInfo("Tarucachi", "23", -17.52472, -70.02833);
case 541: return new CityInfo("Tarma", "12", -11.41899, -75.68992);
case 542: return new CityInfo("Tarata", "23", -17.47444, -70.03278);
case 543: return new CityInfo("Taraco", "21", -15.3, -69.96667);
case 544: return new CityInfo("Taquile", "21", -15.76667, -69.68333);
case 545: return new CityInfo("Tapo", "12", -11.39056, -75.56361);
case 546: return new CityInfo("Tapay", "04", -15.57806, -71.93917);
case 547: return new CityInfo("Tapairihua", "03", -14.14028, -73.14278);
case 548: return new CityInfo("Tapacocha", "02", -10.01667, -77.58333);
case 549: return new CityInfo("Tanta", "15", -12.11667, -76.01667);
case 550: return new CityInfo("Tamburco", "03", -13.61667, -72.87139);
case 551: return new CityInfo("Tambo Quemado", "05", -14.73333, -74.68333);
case 552: return new CityInfo("Tambopata", "17", -12.67191, -69.35547);
case 553: return new CityInfo("Tambobamba", "03", -13.94528, -72.17139);
case 554: return new CityInfo("Tambo", "05", -14.79847, -73.92438);
case 555: return new CityInfo("Tambo", "05", -12.93333, -74.01667);
case 556: return new CityInfo("Tambillo", "05", -13.19194, -74.11139);
case 557: return new CityInfo("Talavera", "03", -13.65306, -73.42917);
case 558: return new CityInfo("Tacna", "23", -18.01465, -70.25362);
case 559: return new CityInfo("Susapaya", "23", -17.35306, -70.13194);
case 560: return new CityInfo("Surcubamba", "09", -12.13333, -74.68333);
case 561: return new CityInfo("Santiago de Surco", "15", -12.13588, -77.00742);
case 562: return new CityInfo("Surco", "15", -11.88472, -76.43972);
case 563: return new CityInfo("Supe", "15", -10.7975, -77.71306);
case 564: return new CityInfo("Sunampe", "11", -13.42704, -76.16363);
case 565: return new CityInfo("Sumbilca", "15", -11.4075, -76.82);
case 566: return new CityInfo("Suitucancha", "12", -11.78734, -75.93612);
case 567: return new CityInfo("Subtanjalla", "11", -14.01889, -75.75806);
case 568: return new CityInfo("Soraya", "03", -14.16278, -73.3125);
case 569: return new CityInfo("Soras", "05", -14.115, -73.60444);
case 570: return new CityInfo("Socos", "05", -13.215, -74.28917);
case 571: return new CityInfo("Socabaya", "04", -16.47025, -71.52758);
case 572: return new CityInfo("Sobraya", "23", -17.99471, -70.19532);
case 573: return new CityInfo("Sitajara", "23", -17.37556, -70.13222);
case 574: return new CityInfo("Sincos", "12", -11.89119, -75.38745);
case 575: return new CityInfo("Sina", "21", -14.5, -69.28333);
case 576: return new CityInfo("Sicuani", "08", -14.26944, -71.22611);
case 577: return new CityInfo("Sicaya", "12", -12.03333, -75.28333);
case 578: return new CityInfo("Sibayo", "04", -15.48694, -71.45833);
case 579: return new CityInfo("Sepahua", "25", -11.14583, -73.04278);
case 580: return new CityInfo("Saylla", "08", -13.56139, -71.84889);
case 581: return new CityInfo("Sayán", "15", -11.13333, -77.1946);
case 582: return new CityInfo("Saurama", "05", -13.69361, -73.75861);
case 583: return new CityInfo("Satipo", "12", -11.25222, -74.63861);
case 584: return new CityInfo("Sarhua", "05", -13.67417, -74.32);
case 585: return new CityInfo("Sapallanga", "12", -12.15, -75.18333);
case 586: return new CityInfo("San Vicente de Cañete", "15", -13.07556, -76.38528);
case 587: return new CityInfo("Santiago", "11", -14.18469, -75.71124);
case 588: return new CityInfo("Santa Teresa", "08", -13.13222, -72.59056);
case 589: return new CityInfo("Santa Rosa", "21", -14.61111, -70.78611);
case 590: return new CityInfo("Santa Rosa", "03", -14.15, -72.66667);
case 591: return new CityInfo("Santa Rosa", "15", -11.79917, -77.17333);
case 592: return new CityInfo("Santa María", "15", -12.00538, -76.89329);
case 593: return new CityInfo("Santa Lucía", "21", -15.69788, -70.6061);
case 594: return new CityInfo("Santa Eulalia", "15", -11.90083, -76.66333);
case 595: return new CityInfo("Santa Cruz", "15", -11.06, -76.93028);
case 596: return new CityInfo("Santa Ana", "09", -13.05, -75.13333);
case 597: return new CityInfo("Santa Ana", "08", -12.86667, -72.71667);
case 598: return new CityInfo("San Salvador", "08", -13.49361, -71.77389);
case 599: return new CityInfo("San Ramón", "12", -11.12417, -75.35733);
case 600: return new CityInfo("San Rafael", "10", -10.33806, -76.18333);
case 601: return new CityInfo("San Pedro de Cajas", "12", -11.25061, -75.86116);
case 602: return new CityInfo("San Pedro", "05", -14.76667, -74.1);
case 603: return new CityInfo("San Pedro", "08", -14.18667, -71.34167);
case 604: return new CityInfo("San Pedro", "11", -13.39889, -76.15904);
case 605: return new CityInfo("San Pablo", "08", -14.20278, -71.31556);
case 606: return new CityInfo("San Miguel de Cauri", "10", -10.13818, -76.62288);
case 607: return new CityInfo("San Miguel", "05", -13.0125, -73.98083);
case 608: return new CityInfo("San Mateo", "15", -11.75944, -76.30056);
case 609: return new CityInfo("San Luis", "15", -12.07674, -76.99435);
case 610: return new CityInfo("San Lorenzo", "12", -11.84684, -75.38146);
case 611: return new CityInfo("San Lorenzo", "17", -11.46667, -69.3);
case 612: return new CityInfo("San Juan Bautista", "11", -14.01083, -75.73583);
case 613: return new CityInfo("San Juan de Marcona", "11", -15.36528, -75.16222);
case 614: return new CityInfo("San Juan", "05", -14.65, -74.2);
case 615: return new CityInfo("San Juan", "09", -13.2, -75.65);
case 616: return new CityInfo("San Jerónimo", "03", -13.65138, -73.36388);
case 617: return new CityInfo("San Jerónimo", "12", -11.95591, -75.28411);
case 618: return new CityInfo("San Isidro", "15", -12.11667, -77.05);
case 619: return new CityInfo("Sangallaya", "15", -12.16667, -76.26667);
case 620: return new CityInfo("San Francisco", "05", -12.6, -73.81667);
case 621: return new CityInfo("Sandia", "21", -14.23333, -69.43333);
case 622: return new CityInfo("San Clemente", "11", -13.66667, -76.15);
case 623: return new CityInfo("San Buenaventura", "15", -11.48889, -76.66194);
case 624: return new CityInfo("San Bartolo", "15", -12.38333, -76.78333);
case 625: return new CityInfo("Sañayca", "03", -14.20694, -73.33556);
case 626: return new CityInfo("San Agustin", "12", -11.97195, -75.25562);
case 627: return new CityInfo("Samegua", "18", -17.17944, -70.89889);
case 628: return new CityInfo("Sama Grande", "23", -17.7925, -70.49472);
case 629: return new CityInfo("Salcabamba", "09", -12.2, -74.78333);
case 630: return new CityInfo("Sacsamarca", "05", -13.94639, -74.31139);
case 631: return new CityInfo("Sabandia", "04", -16.46667, -71.5);
case 632: return new CityInfo("Rosaspata", "21", -15.21667, -69.53333);
case 633: return new CityInfo("Río Grande", "11", -14.516, -75.19933);
case 634: return new CityInfo("Ricardo Palma", "15", -11.91978, -76.6561);
case 635: return new CityInfo("Ranracancha", "03", -13.53361, -73.60528);
case 636: return new CityInfo("Quito-Arma", "09", -13.53333, -75.33333);
case 637: return new CityInfo("Quiquijana", "08", -13.82278, -71.53944);
case 638: return new CityInfo("Quinua", "05", -13.04917, -74.13861);
case 639: return new CityInfo("Quiñota", "08", -14.30778, -72.13611);
case 640: return new CityInfo("Quinocay", "15", -12.36667, -76.23333);
case 641: return new CityInfo("Quinistaquillas", "18", -16.75, -70.88333);
case 642: return new CityInfo("Quince Mil", "08", -13.23092, -70.75401);
case 643: return new CityInfo("Quilmaná", "15", -12.9486, -76.38112);
case 644: return new CityInfo("Quillabamba", "08", -12.86334, -72.69306);
case 645: return new CityInfo("Quilcata", "05", -15.24778, -73.45389);
case 646: return new CityInfo("Quilca", "04", -16.71417, -72.43528);
case 647: return new CityInfo("Quilahuani", "23", -17.31778, -70.25806);
case 648: return new CityInfo("Quicacha", "04", -15.62583, -73.79833);
case 649: return new CityInfo("Quiaca", "21", -14.43333, -69.35);
case 650: return new CityInfo("Queropalca", "10", -10.18139, -76.80389);
case 651: return new CityInfo("Querobamba", "05", -14.01333, -73.83972);
case 652: return new CityInfo("Quequeña", "04", -16.55778, -71.45111);
case 653: return new CityInfo("Quellouno", "08", -12.63667, -72.55944);
case 654: return new CityInfo("Quehue", "08", -14.38, -71.455);
case 655: return new CityInfo("Quebrada Honda", "08", -12.76667, -72.23333);
case 656: return new CityInfo("Putina", "21", -15.4764, -69.43292);
case 657: return new CityInfo("Putina", "21", -14.91667, -69.86667);
case 658: return new CityInfo("Pusi", "21", -15.43333, -69.93333);
case 659: return new CityInfo("Puquio", "05", -14.7, -74.13333);
case 660: return new CityInfo("Puquina", "18", -16.62361, -71.18444);
case 661: return new CityInfo("Punta Hermosa", "15", -12.33333, -76.81667);
case 662: return new CityInfo("Punta de Bombón", "04", -17.1719, -71.7924);
case 663: return new CityInfo("Puno", "21", -15.8422, -70.0199);
case 664: return new CityInfo("Pullo", "05", -15.21667, -73.81667);
case 665: return new CityInfo("Pujocucho", "23", -17.15778, -70.35222);
case 666: return new CityInfo("Puyca", "04", -15.06, -72.69083);
case 667: return new CityInfo("Puerto Supe", "15", -10.80135, -77.74333);
case 668: return new CityInfo("Puerto Ocopa", "12", -11.14694, -74.30583);
case 669: return new CityInfo("Puerto Maldonado", "17", -12.59331, -69.18913);
case 670: return new CityInfo("Pueblo Nuevo", "11", -14.12806, -75.70667);
case 671: return new CityInfo("Pucyura", "08", -13.47889, -72.11167);
case 672: return new CityInfo("Pucusana", "15", -12.48333, -76.8);
case 673: return new CityInfo("Pucara", "04", -15.97993, -71.45988);
case 674: return new CityInfo("Pozuzo", "19", -10.06667, -75.53333);
case 675: return new CityInfo("Potoni", "21", -14.38333, -70.08333);
case 676: return new CityInfo("Poroy", "08", -13.495, -72.04333);
case 677: return new CityInfo("Pomata", "21", -16.26667, -69.3);
case 678: return new CityInfo("Pomacocha", "03", -14.08444, -73.58889);
case 679: return new CityInfo("Pomacocha", "09", -12.85, -74.51667);
case 680: return new CityInfo("Pomacanchi", "08", -14.02694, -71.56722);
case 681: return new CityInfo("Pomacancha", "12", -11.73828, -75.62448);
case 682: return new CityInfo("Pomabamba", "05", -13.60444, -74.23528);
case 683: return new CityInfo("Pocsi", "04", -16.51639, -71.38833);
case 684: return new CityInfo("Pocollay", "23", -17.99167, -70.21333);
case 685: return new CityInfo("Pocohuanca", "03", -14.21667, -73.08333);
case 686: return new CityInfo("Pitumarca", "08", -13.97222, -71.41);
case 687: return new CityInfo("Pisco", "11", -13.71029, -76.20538);
case 688: return new CityInfo("Pisac", "08", -13.4225, -71.84667);
case 689: return new CityInfo("Pirca", "15", -11.23444, -76.65556);
case 690: return new CityInfo("Pilpichaca", "09", -13.32611, -74.9975);
case 691: return new CityInfo("Pillpinto", "08", -13.95417, -71.75972);
case 692: return new CityInfo("Pillcopata", "08", -13.06667, -71.16667);
case 693: return new CityInfo("Pilcuyo", "21", -16.1, -69.56667);
case 694: return new CityInfo("Pilcomay", "12", -12.04722, -75.24931);
case 695: return new CityInfo("Pilchaca", "09", -12.4, -75.1);
case 696: return new CityInfo("Pichirhua", "03", -13.86083, -73.07361);
case 697: return new CityInfo("Pichigua", "08", -14.68139, -71.41694);
case 698: return new CityInfo("Pichari", "08", -12.5, -73.81667);
case 699: return new CityInfo("Phara", "21", -14.15167, -69.66306);
case 700: return new CityInfo("Perené", "12", -10.9451, -75.22394);
case 701: return new CityInfo("Pazos", "09", -12.26667, -75.1);
case 702: return new CityInfo("Pausa", "05", -15.27972, -73.34583);
case 703: return new CityInfo("Paucartambo", "08", -13.31522, -71.59364);
case 704: return new CityInfo("Paucarcolla", "21", -15.73333, -70.05);
case 705: return new CityInfo("Paucarbamba", "09", -12.55, -74.55);
case 706: return new CityInfo("Paucar", "19", -10.37111, -76.44361);
case 707: return new CityInfo("Pativilca", "15", -10.7, -77.78333);
case 708: return new CityInfo("Pataypampa", "03", -14.175, -72.67389);
case 709: return new CityInfo("Patambuco", "21", -14.35972, -69.61889);
case 710: return new CityInfo("Paruro", "08", -13.76333, -71.84944);
case 711: return new CityInfo("Parco", "12", -11.80015, -75.54603);
case 712: return new CityInfo("Paratia", "21", -15.4525, -70.59861);
case 713: return new CityInfo("Paramonga", "15", -10.66667, -77.83333);
case 714: return new CityInfo("Paracas", "11", -13.86667, -76.26667);
case 715: return new CityInfo("Pangoa", "08", -12.11667, -73);
case 716: return new CityInfo("Pancan", "12", -11.74899, -75.48635);
case 717: return new CityInfo("Pampas Chico", "02", -10.11532, -77.39783);
case 718: return new CityInfo("Pampas", "05", -13.22889, -73.89417);
case 719: return new CityInfo("Pampas", "09", -12.3949, -74.86687);
case 720: return new CityInfo("Pampamarca", "08", -14.14639, -71.45944);
case 721: return new CityInfo("Pampacolca", "04", -15.71306, -72.57417);
case 722: return new CityInfo("Pampachiri", "03", -14.18694, -73.54389);
case 723: return new CityInfo("Pampa Cangallo", "05", -13.55917, -74.19528);
case 724: return new CityInfo("Palpacachi", "03", -13.87, -72.50389);
case 725: return new CityInfo("Palpa", "11", -14.53361, -75.18556);
case 726: return new CityInfo("Pallanchacra", "19", -10.41528, -76.23556);
case 727: return new CityInfo("Palcamayo", "12", -11.29472, -75.77361);
case 728: return new CityInfo("Palca", "23", -17.77528, -69.96028);
case 729: return new CityInfo("Palca", "21", -15.23361, -70.59722);
case 730: return new CityInfo("Palca", "12", -11.34611, -75.56861);
case 731: return new CityInfo("Paico", "05", -14.03778, -73.64361);
case 732: return new CityInfo("Pacucha", "03", -13.60889, -73.34361);
case 733: return new CityInfo("Pacocha", "18", -17.64604, -71.34481);
case 734: return new CityInfo("Pacobamba", "03", -13.61639, -73.08611);
case 735: return new CityInfo("Pachaconas", "03", -14.2225, -73.02556);
case 736: return new CityInfo("Paccho", "15", -10.95722, -76.93222);
case 737: return new CityInfo("Paccha", "12", -11.85411, -75.50767);
case 738: return new CityInfo("Paccha", "12", -11.47389, -75.96);
case 739: return new CityInfo("Paccaritambo", "08", -13.75917, -71.955);
case 740: return new CityInfo("Pacaycasa", "05", -13.05694, -74.21361);
case 741: return new CityInfo("Pacaraos", "15", -11.18611, -76.6475);
case 742: return new CityInfo("Pacapausa", "05", -14.95139, -73.36778);
case 743: return new CityInfo("Paca", "12", -11.71539, -75.51586);
case 744: return new CityInfo("Oyón", "15", -10.66846, -76.77165);
case 745: return new CityInfo("Oyolo", "05", -15.17972, -73.18611);
case 746: return new CityInfo("Oxapampa", "19", -10.5775, -75.40167);
case 747: return new CityInfo("Otoca", "05", -14.48333, -74.7);
case 748: return new CityInfo("Orurillo", "21", -14.73, -70.51306);
case 749: return new CityInfo("Oropesa", "03", -14.25611, -72.555);
case 750: return new CityInfo("Oropesa", "08", -13.59278, -71.77194);
case 751: return new CityInfo("Orcotuna", "12", -11.96886, -75.3078);
case 752: return new CityInfo("Orcopampa", "04", -15.26611, -72.34167);
case 753: return new CityInfo("Ongoy", "03", -13.40361, -73.66972);
case 754: return new CityInfo("Ondores", "12", -11.08651, -76.14831);
case 755: return new CityInfo("Omate", "18", -16.68333, -70.98333);
case 756: return new CityInfo("Omas", "15", -12.51667, -76.28333);
case 757: return new CityInfo("Omacha", "08", -14.07139, -71.73972);
case 758: return new CityInfo("Ollantaytambo", "08", -13.25722, -72.26306);
case 759: return new CityInfo("Ollachea", "21", -13.81667, -70.48333);
case 760: return new CityInfo("Ocuviri", "21", -15.11111, -70.90778);
case 761: return new CityInfo("Ocucaje", "11", -14.34861, -75.66917);
case 762: return new CityInfo("Ocros", "05", -13.39139, -73.915);
case 763: return new CityInfo("Ocros", "02", -10.40294, -77.39666);
case 764: return new CityInfo("Ocoyo", "09", -14.00806, -75.02194);
case 765: return new CityInfo("Ocoruro", "08", -15.0525, -71.12889);
case 766: return new CityInfo("Ocongate", "08", -13.62694, -71.38528);
case 767: return new CityInfo("Ocoña", "04", -16.43306, -73.10778);
case 768: return new CityInfo("Ocobamba", "03", -13.48194, -73.56111);
case 769: return new CityInfo("Ocaña", "05", -14.38333, -74.81667);
case 770: return new CityInfo("Ñuñoa", "21", -14.47788, -70.63583);
case 771: return new CityInfo("Nuevo Imperial", "15", -13.07541, -76.31719);
case 772: return new CityInfo("Ninacaca", "19", -10.85, -76.11667);
case 773: return new CityInfo("Asentamiento Humano Nicolas de Pierola", "15", -11.93573, -76.70611);
case 774: return new CityInfo("Nicasio", "21", -15.23333, -70.25);
case 775: return new CityInfo("Nazca", "11", -14.83098, -74.93895);
case 776: return new CityInfo("Muquiyauyo", "12", -11.81371, -75.45482);
case 777: return new CityInfo("Muqui", "12", -11.83364, -75.43462);
case 778: return new CityInfo("Mungui", "04", -15.18278, -72.90556);
case 779: return new CityInfo("Muñani", "21", -14.76667, -69.95);
case 780: return new CityInfo("Mosca", "10", -10.34278, -76.29167);
case 781: return new CityInfo("Morococha", "12", -11.59972, -76.14111);
case 782: return new CityInfo("Morcolla", "05", -14.11056, -73.87139);
case 783: return new CityInfo("Moquegua", "18", -17.19832, -70.93567);
case 784: return new CityInfo("Mollepampa", "09", -13.3, -75.4);
case 785: return new CityInfo("Mollendo", "04", -17.02306, -72.01472);
case 786: return new CityInfo("Mollebamba", "03", -14.42139, -72.91194);
case 787: return new CityInfo("Molinos", "12", -11.73642, -75.44356);
case 788: return new CityInfo("Moho", "21", -15.35, -69.5);
case 789: return new CityInfo("Miraflores", "15", -12.27361, -75.85);
case 790: return new CityInfo("Mazo Cruz", "21", -16.75, -69.73333);
case 791: return new CityInfo("Mazamari", "12", -11.32583, -74.53083);
case 792: return new CityInfo("Mayocc", "09", -12.78333, -74.4);
case 793: return new CityInfo("Matucana", "15", -11.85, -76.4);
case 794: return new CityInfo("Matalaque", "18", -16.48333, -70.81667);
case 795: return new CityInfo("Mariposa", "12", -11.4025, -74.75083);
case 796: return new CityInfo("Mariatana", "15", -12.25, -76.33333);
case 797: return new CityInfo("Margos", "10", -10.00611, -76.5225);
case 798: return new CityInfo("Minas de Marcona", "11", -15.21194, -75.11028);
case 799: return new CityInfo("Marco", "12", -11.74117, -75.56279);
case 800: return new CityInfo("Marcas", "09", -12.88333, -74.38333);
case 801: return new CityInfo("Marcapomacocha", "12", -11.40692, -76.33628);
case 802: return new CityInfo("Marcapata", "08", -13.58972, -70.97222);
case 803: return new CityInfo("Marcabamba", "05", -15.15056, -73.34194);
case 804: return new CityInfo("Marca", "02", -10.08833, -77.47431);
case 805: return new CityInfo("Maray", "15", -10.93556, -76.83389);
case 806: return new CityInfo("Maras", "08", -13.335, -72.15667);
case 807: return new CityInfo("Maranura", "08", -12.96306, -72.66472);
case 808: return new CityInfo("Maranganí", "08", -14.35672, -71.16924);
case 809: return new CityInfo("Mara", "03", -14.08528, -72.10806);
case 810: return new CityInfo("Mangas", "02", -10.37411, -77.10205);
case 811: return new CityInfo("Mañazo", "21", -15.8, -70.33333);
case 812: return new CityInfo("Mamara", "03", -14.22944, -72.58611);
case 813: return new CityInfo("Mala", "15", -12.65806, -76.63083);
case 814: return new CityInfo("Madrigal", "04", -15.60778, -71.80806);
case 815: return new CityInfo("Madean", "15", -12.94444, -75.77667);
case 816: return new CityInfo("Macusani", "21", -14.08333, -70.43333);
case 817: return new CityInfo("Macari", "21", -14.76861, -70.90194);
case 818: return new CityInfo("Macachacra", "05", -12.98333, -74.2);
case 819: return new CityInfo("Maca", "04", -15.64167, -71.76944);
case 820: return new CityInfo("Luricocha", "05", -12.85, -74.26667);
case 821: return new CityInfo("Lucre", "03", -13.94917, -73.22611);
case 822: return new CityInfo("Lucre", "08", -13.63556, -71.7375);
case 823: return new CityInfo("Lucanas", "05", -14.6, -74.25);
case 824: return new CityInfo("Los Aquijes", "11", -14.09667, -75.69083);
case 825: return new CityInfo("Locumba", "23", -17.61333, -70.76278);
case 826: return new CityInfo("Locroja", "09", -12.68333, -74.43333);
case 827: return new CityInfo("Lluta", "04", -16.01472, -72.01417);
case 828: return new CityInfo("Llusco", "08", -14.33111, -72.11472);
case 829: return new CityInfo("Lloque", "18", -16.33333, -70.73333);
case 830: return new CityInfo("Llocllapampa", "12", -11.81781, -75.62382);
case 831: return new CityInfo("Llipata", "11", -14.56417, -75.20778);
case 832: return new CityInfo("Llipa", "02", -10.38195, -77.20579);
case 833: return new CityInfo("Llauta", "05", -14.26667, -74.91667);
case 834: return new CityInfo("Llalli", "21", -14.93333, -70.88278);
case 835: return new CityInfo("Llacllin", "02", -10.06667, -77.61667);
case 836: return new CityInfo("Llaclla", "02", -10.29875, -77.14535);
case 837: return new CityInfo("Livitaca", "08", -14.30194, -71.68722);
case 838: return new CityInfo("Lircay", "09", -13, -74.71667);
case 839: return new CityInfo("Lincha", "15", -12.79861, -75.665);
case 840: return new CityInfo("Limbani", "21", -14.14778, -69.68889);
case 841: return new CityInfo("Limatambo", "08", -13.47917, -72.4425);
case 842: return new CityInfo("Lima", "LMA", -12.04318, -77.02824);
case 843: return new CityInfo("Leticia", "12", -11.37972, -75.75389);
case 844: return new CityInfo("Layo", "08", -14.49361, -71.155);
case 845: return new CityInfo("La Tinguiña", "11", -14.03583, -75.70028);
case 846: return new CityInfo("Las Yaras", "23", -17.86417, -70.56278);
case 847: return new CityInfo("Lari", "04", -15.62222, -71.76889);
case 848: return new CityInfo("Lares", "08", -13.10333, -72.04389);
case 849: return new CityInfo("Laraqueri", "21", -16.13333, -70.05);
case 850: return new CityInfo("Laraos", "15", -12.34667, -75.78639);
case 851: return new CityInfo("Laraos", "15", -11.66472, -76.53944);
case 852: return new CityInfo("Laramate", "05", -14.25, -74.86667);
case 853: return new CityInfo("La Pampa", "04", -16.61361, -72.69639);
case 854: return new CityInfo("La Oroya", "12", -11.51893, -75.89935);
case 855: return new CityInfo("Lanlacuni Bajo", "21", -13.48333, -70.41667);
case 856: return new CityInfo("Langui", "08", -14.43194, -71.27306);
case 857: return new CityInfo("Lampian", "15", -11.23778, -76.83972);
case 858: return new CityInfo("Lampa", "21", -15.35, -70.36667);
case 859: return new CityInfo("Lampa", "05", -15.18444, -73.34889);
case 860: return new CityInfo("La Molina", "15", -12.08333, -76.95);
case 861: return new CityInfo("La Merced", "12", -11.06146, -75.33505);
case 862: return new CityInfo("Lambrama", "03", -13.86667, -72.76667);
case 863: return new CityInfo("Lamay", "08", -13.36417, -71.92389);
case 864: return new CityInfo("Lahuaytambo", "15", -12.1, -76.4);
case 865: return new CityInfo("La Esmeralda", "09", -12.63333, -74.6);
case 866: return new CityInfo("La Curva", "04", -17.14667, -71.82167);
case 867: return new CityInfo("Lachaqui", "15", -11.55333, -76.62333);
case 868: return new CityInfo("La Capilla", "18", -16.75694, -71.17917);
case 869: return new CityInfo("Kishuara", "03", -13.69444, -73.11639);
case 870: return new CityInfo("Junín", "12", -11.15895, -75.99304);
case 871: return new CityInfo("Juliaca", "21", -15.5, -70.13333);
case 872: return new CityInfo("Juli", "21", -16.21667, -69.45);
case 873: return new CityInfo("Julcan", "12", -11.76025, -75.43587);
case 874: return new CityInfo("Julcamarca", "09", -13.01278, -74.44222);
case 875: return new CityInfo("Jivia", "10", -10.02389, -76.67917);
case 876: return new CityInfo("Jauja", "12", -11.77584, -75.49656);
case 877: return new CityInfo("Jatun Orcochiri", "04", -15.75003, -71.34641);
case 878: return new CityInfo("Jarpa", "12", -12.11667, -75.46667);
case 879: return new CityInfo("Jucul", "15", -10.94861, -76.745);
case 880: return new CityInfo("Izcuchaca", "09", -12.48333, -75.01667);
case 881: return new CityInfo("Iray", "04", -15.85639, -72.62556);
case 882: return new CityInfo("Iquipi", "04", -15.94028, -73.13);
case 883: return new CityInfo("Ingenio", "12", -11.8895, -75.26554);
case 884: return new CityInfo("Independencia", "11", -13.7, -76.03333);
case 885: return new CityInfo("Independencia", "15", -11.99, -77.04583);
case 886: return new CityInfo("Incuyo", "05", -15.25, -73.58333);
case 887: return new CityInfo("Inchupalla", "21", -15, -69.68333);
case 888: return new CityInfo("Iñapari", "17", -10.95, -69.58333);
case 889: return new CityInfo("Imperial", "15", -13.05927, -76.35269);
case 890: return new CityInfo("Ilo", "18", -17.63185, -71.34108);
case 891: return new CityInfo("Ilave", "21", -16.08333, -69.66667);
case 892: return new CityInfo("Ilabaya", "23", -17.42083, -70.51333);
case 893: return new CityInfo("Ihuari", "15", -11.18917, -76.95139);
case 894: return new CityInfo("Ichupampa", "04", -15.64972, -71.6875);
case 895: return new CityInfo("Ichuña", "18", -16.15, -70.56667);
case 896: return new CityInfo("Ica", "11", -14.06777, -75.72861);
case 897: return new CityInfo("Iberia", "17", -11.35, -69.58333);
case 898: return new CityInfo("Humay", "11", -13.71667, -75.9);
case 899: return new CityInfo("Umamarca", "03", -14.05278, -73.56556);
case 900: return new CityInfo("Huayucachi", "12", -12.13333, -75.23333);
case 901: return new CityInfo("Huayrapata", "21", -15.3, -69.33333);
case 902: return new CityInfo("Huayllay", "19", -11.00367, -76.36452);
case 903: return new CityInfo("Huayllapampa", "02", -10.05, -77.53333);
case 904: return new CityInfo("Huayllahuara", "09", -12.4, -75.16667);
case 905: return new CityInfo("Huayllabamba", "08", -13.33806, -72.06528);
case 906: return new CityInfo("Huayana", "03", -14.04833, -73.60972);
case 907: return new CityInfo("Huayacundo Arma", "09", -13.53639, -75.30528);
case 908: return new CityInfo("Huaura", "15", -11.07, -77.59944);
case 909: return new CityInfo("Huata", "21", -15.61667, -69.96667);
case 910: return new CityInfo("Huasta", "02", -10.12385, -77.15733);
case 911: return new CityInfo("Huasahuasi", "12", -11.26527, -75.64722);
case 912: return new CityInfo("Huaros", "15", -11.40583, -76.57694);
case 913: return new CityInfo("Huarocondo", "08", -13.41333, -72.20639);
case 914: return new CityInfo("Huaro", "08", -13.68833, -71.63583);
case 915: return new CityInfo("Huarmey", "02", -10.06806, -78.15222);
case 916: return new CityInfo("Huaripampa", "12", -11.80816, -75.47143);
case 917: return new CityInfo("Huaribamba", "09", -12.26667, -74.95);
case 918: return new CityInfo("Huariaca", "19", -10.44167, -76.19028);
case 919: return new CityInfo("Huaral", "15", -11.495, -77.20778);
case 920: return new CityInfo("Huaquirca", "03", -14.33139, -72.89028);
case 921: return new CityInfo("Huanza", "15", -11.65667, -76.50333);
case 922: return new CityInfo("Huanuara", "23", -17.31389, -70.32194);
case 923: return new CityInfo("Huanta", "05", -12.93333, -74.25);
case 924: return new CityInfo("Huanoquite", "08", -13.68278, -72.01667);
case 925: return new CityInfo("Huanipaca", "03", -13.5, -72.93333);
case 926: return new CityInfo("Huangascar", "15", -12.89889, -75.83111);
case 927: return new CityInfo("Huancayo", "12", -12.06513, -75.20486);
case 928: return new CityInfo("Huancaya", "15", -12.20306, -75.79806);
case 929: return new CityInfo("Huancavelica", "09", -12.78261, -74.97266);
case 930: return new CityInfo("Huancarqui", "04", -16.09583, -72.47278);
case 931: return new CityInfo("Huancaray", "03", -13.75861, -73.5275);
case 932: return new CityInfo("Huancarama", "03", -13.64528, -73.08639);
case 933: return new CityInfo("Huancapi", "05", -13.75667, -74.06667);
case 934: return new CityInfo("Huancano", "11", -13.6, -75.61667);
case 935: return new CityInfo("Hacienda Huancane", "21", -15.82327, -70.8854);
case 936: return new CityInfo("Huancabamba", "19", -10.35, -75.53333);
case 937: return new CityInfo("Huampara", "15", -12.35, -76.18333);
case 938: return new CityInfo("Huambo", "04", -15.73083, -72.1075);
case 939: return new CityInfo("Huambalpa", "05", -13.74972, -73.93111);
case 940: return new CityInfo("Huamatambo", "09", -13.11667, -75.68333);
case 941: return new CityInfo("Huamantanga", "15", -11.49917, -76.74889);
case 942: return new CityInfo("Huamanquiquia", "05", -13.73, -74.27278);
case 943: return new CityInfo("Huamanguilla", "05", -13.01111, -74.17806);
case 944: return new CityInfo("Huamali", "12", -11.80722, -75.42439);
case 945: return new CityInfo("Hualmay", "15", -11.09639, -77.61389);
case 946: return new CityInfo("Huacrapuquio", "12", -12.18333, -75.21667);
case 947: return new CityInfo("Huachos", "09", -13.2, -75.51667);
case 948: return new CityInfo("Huachocolpa", "09", -13.02778, -74.94583);
case 949: return new CityInfo("Huacho", "15", -11.10667, -77.605);
case 950: return new CityInfo("Huacar", "10", -10.16028, -76.23694);
case 951: return new CityInfo("Huacaña", "05", -14.17361, -73.88639);
case 952: return new CityInfo("Hongos", "15", -12.81139, -75.765);
case 953: return new CityInfo("Haquira", "03", -14.21278, -72.19);
case 954: return new CityInfo("Guadalupe", "11", -13.96667, -75.76667);
case 955: return new CityInfo("Goyllarisquizga", "19", -10.47389, -76.40944);
case 956: return new CityInfo("Gorgor", "15", -10.58333, -77.03333);
case 957: return new CityInfo("Estique", "23", -17.54167, -70.01861);
case 958: return new CityInfo("El Tambo", "12", -12.06667, -75.21667);
case 959: return new CityInfo("Progreso", "03", -14.0725, -72.47278);
case 960: return new CityInfo("El Ingenio", "11", -14.64528, -75.05833);
case 961: return new CityInfo("El Descanso", "08", -14.53333, -71.30556);
case 962: return new CityInfo("El Carmen", "11", -13.49714, -76.05724);
case 963: return new CityInfo("El Cardo", "04", -16.60333, -72.72639);
case 964: return new CityInfo("Desaguadero", "21", -16.56556, -69.04167);
case 965: return new CityInfo("Cuyocuyo", "21", -14.47139, -69.53722);
case 966: return new CityInfo("Cusipata", "08", -13.9075, -71.49861);
case 967: return new CityInfo("Cusco", "08", -13.52264, -71.96734);
case 968: return new CityInfo("Curibaya", "23", -17.3825, -70.33472);
case 969: return new CityInfo("Curahuasi", "03", -13.55, -72.7);
case 970: return new CityInfo("Cupi", "21", -14.90611, -70.87417);
case 971: return new CityInfo("Cullhuas", "12", -12.23333, -75.16667);
case 972: return new CityInfo("Cuenca", "09", -12.43333, -75.03333);
case 973: return new CityInfo("Cuchumbaya", "18", -16.75, -70.68333);
case 974: return new CityInfo("Cruz Blanca", "15", -11.09722, -77.5925);
case 975: return new CityInfo("Crucero", "21", -14.35, -70);
case 976: return new CityInfo("Coyllurqui", "03", -13.83639, -72.43083);
case 977: return new CityInfo("Coya", "08", -13.38806, -71.89972);
case 978: return new CityInfo("Cotaruse", "03", -14.41583, -73.20778);
case 979: return new CityInfo("Cotaparaco", "02", -10, -77.6);
case 980: return new CityInfo("Cotahuasi", "04", -15.21306, -72.88861);
case 981: return new CityInfo("Cotabambas", "03", -13.74639, -72.35667);
case 982: return new CityInfo("Corpanqui", "02", -10.28508, -77.19879);
case 983: return new CityInfo("Corire", "04", -16.22361, -72.47111);
case 984: return new CityInfo("Corculla", "05", -15.2625, -73.20056);
case 985: return new CityInfo("Corani", "21", -13.87111, -70.60667);
case 986: return new CityInfo("Coracora", "05", -15.03333, -73.78333);
case 987: return new CityInfo("Coporaque", "04", -15.62722, -71.64611);
case 988: return new CityInfo("Coporaque", "08", -14.8, -71.5325);
case 989: return new CityInfo("Copa", "15", -10.38821, -77.07956);
case 990: return new CityInfo("Copa", "02", -10.37181, -77.48744);
case 991: return new CityInfo("Conima", "21", -15.43333, -69.43333);
case 992: return new CityInfo("Congas", "02", -10.33712, -77.44188);
case 993: return new CityInfo("Condoroma", "08", -15.24, -71.08222);
case 994: return new CityInfo("Concho", "12", -11.72503, -75.57086);
case 995: return new CityInfo("Conchamarca", "10", -10.03778, -76.21528);
case 996: return new CityInfo("Concepción", "12", -11.91762, -75.31401);
case 997: return new CityInfo("Combapata", "08", -14.10111, -71.42944);
case 998: return new CityInfo("Comas", "12", -11.7174, -75.08118);
case 999: return new CityInfo("Colta", "05", -15.16222, -73.29472);
case 1000: return new CityInfo("Colquepata", "08", -13.35583, -71.66972);
case 1001: return new CityInfo("Colquemarca", "08", -14.28222, -72.04194);
case 1002: return new CityInfo("Colpas", "10", -10.26889, -76.41417);
case 1003: return new CityInfo("Colonia", "15", -12.63278, -75.89056);
case 1004: return new CityInfo("Colcha", "08", -13.85194, -71.80333);
case 1005: return new CityInfo("Colcabamba", "03", -14.00778, -73.24778);
case 1006: return new CityInfo("Colcabamba", "09", -12.4, -74.7);
case 1007: return new CityInfo("Colca", "05", -13.71472, -74.03306);
case 1008: return new CityInfo("Colca", "12", -12.3, -75.21667);
case 1009: return new CityInfo("Cojata", "21", -15.01667, -69.36667);
case 1010: return new CityInfo("Cochas", "12", -11.65709, -75.10119);
case 1011: return new CityInfo("Cocharcas", "03", -13.61, -73.74);
case 1012: return new CityInfo("Cocas", "09", -13.26667, -75.36667);
case 1013: return new CityInfo("Cocachacra", "04", -17.08833, -71.7575);
case 1014: return new CityInfo("Cocachacra", "15", -11.91333, -76.53833);
case 1015: return new CityInfo("Coayllo", "15", -12.73333, -76.46667);
case 1016: return new CityInfo("Coata", "21", -15.56667, -69.95);
case 1017: return new CityInfo("Coasa", "21", -14, -69.96667);
case 1018: return new CityInfo("Coalaque", "18", -16.65056, -71.02139);
case 1019: return new CityInfo("Circa", "03", -13.87417, -72.87278);
case 1020: return new CityInfo("Cieneguilla", "15", -12.13333, -76.81667);
case 1021: return new CityInfo("Chuschi", "05", -13.58556, -74.35056);
case 1022: return new CityInfo("Churcampa", "09", -12.7, -74.4);
case 1023: return new CityInfo("Chuquibambilla", "03", -14.10194, -72.70667);
case 1024: return new CityInfo("Chuquibamba", "04", -15.83806, -72.65361);
case 1025: return new CityInfo("Chupamarca", "09", -13.03333, -75.6);
case 1026: return new CityInfo("Chupaca", "12", -12.06667, -75.28333);
case 1027: return new CityInfo("Chupa", "21", -15.1, -69.98333);
case 1028: return new CityInfo("Chungui", "05", -13.21861, -73.61917);
case 1029: return new CityInfo("Chumpi", "05", -15.1, -73.76667);
case 1030: return new CityInfo("Chucatamani", "23", -17.48056, -70.1225);
case 1031: return new CityInfo("Chosica", "15", -11.94306, -76.70944);
case 1032: return new CityInfo("Chontabamba", "19", -10.58333, -75.48333);
case 1033: return new CityInfo("Chojata", "18", -16.4, -70.73333);
case 1034: return new CityInfo("Chocos", "15", -12.91417, -75.86306);
case 1035: return new CityInfo("Choco", "04", -15.57556, -72.13);
case 1036: return new CityInfo("Chivay", "04", -15.63833, -71.60111);
case 1037: return new CityInfo("Chipispaya", "23", -17.4979, -70.21714);
case 1038: return new CityInfo("Chipao", "05", -14.36611, -73.87667);
case 1039: return new CityInfo("Chincho", "09", -12.96667, -74.36667);
case 1040: return new CityInfo("Chincheros", "03", -13.51833, -73.72222);
case 1041: return new CityInfo("Chinchero", "08", -13.39222, -72.04778);
case 1042: return new CityInfo("Chinchaypujio", "08", -13.63, -72.23333);
case 1043: return new CityInfo("Chincha Baja", "11", -13.45894, -76.16325);
case 1044: return new CityInfo("Chincha Alta", "11", -13.40985, -76.13235);
case 1045: return new CityInfo("Chilcas", "05", -13.17139, -73.90694);
case 1046: return new CityInfo("Chilca", "15", -12.52111, -76.73722);
case 1047: return new CityInfo("Chiguata", "04", -16.4, -71.4);
case 1048: return new CityInfo("Chicla", "15", -11.70639, -76.26833);
case 1049: return new CityInfo("Chichas", "04", -15.5475, -72.91861);
case 1050: return new CityInfo("Chicche", "12", -12.3, -75.28333);
case 1051: return new CityInfo("Chiara", "03", -13.86806, -73.66722);
case 1052: return new CityInfo("Chiara", "05", -13.27278, -74.20472);
case 1053: return new CityInfo("Checca", "08", -14.47278, -71.39389);
case 1054: return new CityInfo("Checacupe", "08", -14.02694, -71.45278);
case 1055: return new CityInfo("Chaviña", "05", -14.98333, -73.83333);
case 1056: return new CityInfo("Chaupimarca", "19", -10.40696, -76.46168);
case 1057: return new CityInfo("Chasquitambo", "02", -10.3, -77.6);
case 1058: return new CityInfo("Charcana", "04", -15.24056, -73.07111);
case 1059: return new CityInfo("Characato", "04", -16.46667, -71.48333);
case 1060: return new CityInfo("Chapimarca", "03", -13.97528, -73.065);
case 1061: return new CityInfo("Changuillo", "11", -14.66417, -75.22333);
case 1062: return new CityInfo("Chancay", "15", -11.57139, -77.26722);
case 1063: return new CityInfo("Chambara", "12", -12.01667, -75.38333);
case 1064: return new CityInfo("Chamaca", "08", -14.30833, -71.84306);
case 1065: return new CityInfo("Challhuahuacho", "03", -14.11667, -72.25);
case 1066: return new CityInfo("Challabamba", "08", -13.20417, -71.65444);
case 1067: return new CityInfo("Chalhuanca", "03", -14.30056, -73.23083);
case 1068: return new CityInfo("Chalcos", "05", -13.84778, -73.75333);
case 1069: return new CityInfo("Chala", "04", -15.86583, -74.24694);
case 1070: return new CityInfo("Chaclacayo", "15", -11.98278, -76.7675);
case 1071: return new CityInfo("Chaccrampa", "03", -13.95972, -73.60917);
case 1072: return new CityInfo("Chacapampa", "12", -12.35, -75.25);
case 1073: return new CityInfo("Chacapalpa", "12", -11.73315, -75.75573);
case 1074: return new CityInfo("Cerro de Pasco", "19", -10.66748, -76.25668);
case 1075: return new CityInfo("Ccorca", "08", -13.585, -72.05972);
case 1076: return new CityInfo("Ccapi", "08", -13.85278, -72.07917);
case 1077: return new CityInfo("Cayna", "10", -10.27167, -76.38889);
case 1078: return new CityInfo("Cayarani", "04", -14.67222, -72.02194);
case 1079: return new CityInfo("Cayara", "05", -13.79472, -73.98889);
case 1080: return new CityInfo("Cauri", "10", -10.14167, -76.62472);
case 1081: return new CityInfo("Ccatca", "08", -13.60472, -71.55944);
case 1082: return new CityInfo("Catahuasi", "15", -12.79889, -75.89194);
case 1083: return new CityInfo("Castrovirreyna", "09", -13.26667, -75.31667);
case 1084: return new CityInfo("Carumas", "18", -16.81667, -70.71667);
case 1085: return new CityInfo("Carmen Alto", "05", -13.18222, -74.22472);
case 1086: return new CityInfo("Carhuanca", "05", -13.7425, -73.78833);
case 1087: return new CityInfo("Carhuamayo", "12", -10.91667, -76.03333);
case 1088: return new CityInfo("Carapo", "05", -13.83889, -74.31194);
case 1089: return new CityInfo("Carania", "15", -12.34417, -75.86833);
case 1090: return new CityInfo("Carampoma", "15", -11.66083, -76.51444);
case 1091: return new CityInfo("Caracoto", "21", -15.56667, -70.1);
case 1092: return new CityInfo("Carac", "15", -11.19194, -76.78028);
case 1093: return new CityInfo("Carabayllo", "15", -11.85333, -77.03778);
case 1094: return new CityInfo("Capaya", "03", -14.11944, -73.31806);
case 1095: return new CityInfo("Capacmarca", "08", -14.00806, -71.99806);
case 1096: return new CityInfo("Capachica", "21", -15.63333, -69.81667);
case 1097: return new CityInfo("Canta", "15", -11.46722, -76.62417);
case 1098: return new CityInfo("Canis", "02", -10.33899, -77.16943);
case 1099: return new CityInfo("Cangallo", "05", -13.62861, -74.14389);
case 1100: return new CityInfo("Candarave", "23", -17.26778, -70.24944);
case 1101: return new CityInfo("Canchayllo", "12", -11.8058, -75.7165);
case 1102: return new CityInfo("Canaria", "05", -13.92139, -73.90528);
case 1103: return new CityInfo("Caminaca", "21", -15.31667, -70.06667);
case 1104: return new CityInfo("Camilaca", "23", -17.26806, -70.37806);
case 1105: return new CityInfo("Camaná", "04", -16.62375, -72.71055);
case 1106: return new CityInfo("Callao", "07", -12.05659, -77.11814);
case 1107: return new CityInfo("Callanmarca", "09", -12.86667, -74.63333);
case 1108: return new CityInfo("Callalli", "04", -15.50833, -71.44556);
case 1109: return new CityInfo("Callahuanca", "15", -11.82833, -76.61639);
case 1110: return new CityInfo("Caleta de Carquín", "15", -11.0925, -77.62667);
case 1111: return new CityInfo("Calca", "08", -13.33333, -71.95);
case 1112: return new CityInfo("Calapuja", "21", -15.31667, -70.21667);
case 1113: return new CityInfo("Calango", "15", -12.52611, -76.54278);
case 1114: return new CityInfo("Calana", "23", -17.94167, -70.18694);
case 1115: return new CityInfo("Calacoa", "18", -16.75, -70.7);
case 1116: return new CityInfo("Cajacay", "02", -10.15502, -77.43963);
case 1117: return new CityInfo("Caja", "09", -12.88333, -74.46667);
case 1118: return new CityInfo("Cairani", "23", -17.28583, -70.36361);
case 1119: return new CityInfo("Caicay", "08", -13.595, -71.69944);
case 1120: return new CityInfo("Cahuacho", "04", -15.50611, -73.47917);
case 1121: return new CityInfo("Cacra", "15", -12.81278, -75.78306);
case 1122: return new CityInfo("Cachora", "03", -13.51333, -72.81);
case 1123: return new CityInfo("Cachimayo", "08", -13.47583, -72.07222);
case 1124: return new CityInfo("Cabanilla", "21", -15.61667, -70.35);
case 1125: return new CityInfo("Cabanaconde", "04", -15.62139, -71.97889);
case 1126: return new CityInfo("Cabana", "21", -15.65, -70.31667);
case 1127: return new CityInfo("Cabana", "05", -14.29083, -73.96667);
case 1128: return new CityInfo("Bolognesi", "25", -10.06444, -74.005);
case 1129: return new CityInfo("Barranca", "15", -10.75, -77.76667);
case 1130: return new CityInfo("Baños", "10", -10.07667, -76.73528);
case 1131: return new CityInfo("Azángaro", "21", -14.90843, -70.19616);
case 1132: return new CityInfo("Ayrampuni", "21", -15.05, -69.88333);
case 1133: return new CityInfo("Ayo", "04", -15.68167, -72.27417);
case 1134: return new CityInfo("Ayna", "05", -12.65, -73.91667);
case 1135: return new CityInfo("Ayaviri", "21", -14.88639, -70.58889);
case 1136: return new CityInfo("Ayacucho", "05", -13.15878, -74.22321);
case 1137: return new CityInfo("Aucallama", "15", -11.55778, -77.18083);
case 1138: return new CityInfo("Atuncolla", "21", -15.68333, -70.15);
case 1139: return new CityInfo("Atiquipa", "04", -15.79611, -74.36361);
case 1140: return new CityInfo("Atico", "04", -16.20944, -73.62222);
case 1141: return new CityInfo("Ataura", "12", -11.80135, -75.43969);
case 1142: return new CityInfo("Asquipata", "05", -14.055, -73.91);
case 1143: return new CityInfo("Asillo", "21", -14.78333, -70.35);
case 1144: return new CityInfo("Asia", "15", -12.78333, -76.56667);
case 1145: return new CityInfo("Arma", "09", -13.11667, -75.53333);
case 1146: return new CityInfo("Arequipa", "04", -16.39889, -71.535);
case 1147: return new CityInfo("Arapa", "21", -15.13333, -70.11667);
case 1148: return new CityInfo("Arahuay", "15", -11.62222, -76.66944);
case 1149: return new CityInfo("Aquia", "02", -10.07409, -77.14423);
case 1150: return new CityInfo("Apongo", "05", -14.01472, -73.93306);
case 1151: return new CityInfo("Aplao", "04", -16.07583, -72.49389);
case 1152: return new CityInfo("Apata", "12", -11.85461, -75.35344);
case 1153: return new CityInfo("Antauta", "21", -14.4, -70.36667);
case 1154: return new CityInfo("Antaparco", "09", -13.07361, -74.41194);
case 1155: return new CityInfo("Antabamba", "03", -14.36056, -72.87556);
case 1156: return new CityInfo("Anta", "08", -13.47056, -72.14833);
case 1157: return new CityInfo("Aniso", "05", -14.80861, -73.29111);
case 1158: return new CityInfo("Andaray", "04", -15.79667, -72.86056);
case 1159: return new CityInfo("Andarapa", "03", -13.52611, -73.36611);
case 1160: return new CityInfo("Andamarca", "05", -14.38722, -73.96083);
case 1161: return new CityInfo("Andamarca", "12", -11.73194, -74.80278);
case 1162: return new CityInfo("Andajes", "15", -10.79222, -76.90944);
case 1163: return new CityInfo("Andahuaylillas", "08", -13.6725, -71.67944);
case 1164: return new CityInfo("Andahuaylas", "03", -13.65556, -73.38722);
case 1165: return new CityInfo("Anchonga", "09", -12.88333, -74.7);
case 1166: return new CityInfo("Ancahuasi", "08", -13.4425, -72.31083);
case 1167: return new CityInfo("Ananea", "21", -14.7, -69.55);
case 1168: return new CityInfo("Ambo", "10", -10.13083, -76.20472);
case 1169: return new CityInfo("Ambar", "15", -10.73333, -77.26667);
case 1170: return new CityInfo("Alis", "15", -12.27861, -75.78694);
case 1171: return new CityInfo("El Algarrobal", "18", -17.62278, -71.26778);
case 1172: return new CityInfo("Alca", "04", -15.13472, -72.76472);
case 1173: return new CityInfo("Ajoyani", "21", -14.1, -70.2);
case 1174: return new CityInfo("Ayrihuanca", "03", -14.10472, -72.6125);
case 1175: return new CityInfo("Ahuac", "12", -12.06667, -75.35);
case 1176: return new CityInfo("Acos", "08", -13.95083, -71.73722);
case 1177: return new CityInfo("Acos", "15", -11.27361, -76.82083);
case 1178: return new CityInfo("Acoria", "09", -12.61667, -74.88333);
case 1179: return new CityInfo("Acomayo", "08", -13.91667, -71.68111);
case 1180: return new CityInfo("Acolla", "12", -11.73193, -75.54634);
case 1181: return new CityInfo("Acocro", "05", -13.21778, -74.04333);
case 1182: return new CityInfo("Acobambilla", "09", -12.65, -75.38333);
case 1183: return new CityInfo("Acobamba", "09", -12.86667, -74.56667);
case 1184: return new CityInfo("Acobamba", "12", -11.35252, -75.66211);
case 1185: return new CityInfo("Accocunca", "08", -14.76944, -71.25417);
case 1186: return new CityInfo("Aco", "12", -11.95707, -75.36996);
case 1187: return new CityInfo("Aco", "02", -10.49718, -77.24149);
case 1188: return new CityInfo("Achoma", "04", -15.66083, -71.70083);
case 1189: return new CityInfo("Achaya", "21", -15.26667, -70.15);
case 1190: return new CityInfo("Achanizo", "04", -15.80611, -73.96694);
case 1191: return new CityInfo("Accomarca", "05", -13.8, -73.90306);
case 1192: return new CityInfo("Accha", "08", -13.97389, -71.82667);
case 1193: return new CityInfo("Acas", "02", -10.45778, -77.32729);
case 1194: return new CityInfo("Acarí", "04", -15.42393, -74.61361);
case 1195: return new CityInfo("Abancay", "03", -13.63389, -72.88139);
case 1196: return new CityInfo("Mosoc Llacta", "08", -14.12, -71.47278);
case 1197: return new CityInfo("Taray", "08", -13.4275, -71.8675);
case 1198: return new CityInfo("Huayllati", "03", -13.92778, -72.48389);
case 1199: return new CityInfo("Sabaino", "03", -14.30889, -72.94667);
case 1200: return new CityInfo("Ayahuay", "03", -14.20778, -73.06639);
case 1201: return new CityInfo("Huayllo", "03", -14.1325, -73.26861);
case 1202: return new CityInfo("Santo Tomas", "08", -14.44556, -72.08417);
case 1203: return new CityInfo("Caraybamba", "03", -14.37722, -73.16139);
case 1204: return new CityInfo("San Antonio", "03", -14.16472, -72.62111);
case 1205: return new CityInfo("Curpahuasi", "03", -14.06222, -72.66972);
case 1206: return new CityInfo("Huarancante", "04", -15.76803, -71.45952);
case 1207: return new CityInfo("Ccolo", "04", -15.50611, -71.49184);
case 1208: return new CityInfo("Huarichancara", "04", -15.63972, -71.06111);
case 1209: return new CityInfo("Llongasora", "04", -15.63951, -71.29921);
case 1210: return new CityInfo("Jayune", "04", -15.56277, -71.30312);
case 1211: return new CityInfo("Chuquitira", "23", -17.28891, -70.04363);
case 1212: return new CityInfo("Pueblo Nuevo", "18", -17.615, -71.33833);
case 1213: return new CityInfo("Callanca", "08", -14.18137, -71.1407);
case 1214: return new CityInfo("Cullcuyre", "08", -14.09272, -71.33119);
case 1215: return new CityInfo("Cahuanuyo", "08", -14.34147, -71.46311);
case 1216: return new CityInfo("Ccaquiracunca", "08", -14.27683, -71.45026);
case 1217: return new CityInfo("Chignayhua", "08", -14.2461, -71.44442);
case 1218: return new CityInfo("Ccuntuma", "08", -14.1254, -71.41216);
case 1219: return new CityInfo("Lima Pampa", "08", -14.08976, -71.33664);
case 1220: return new CityInfo("Jayobamba", "08", -14.09425, -71.33922);
case 1221: return new CityInfo("Queromarca", "08", -14.18391, -71.38343);
case 1222: return new CityInfo("Qquea", "08", -14.05417, -71.38583);
case 1223: return new CityInfo("Conchopata", "08", -14.46968, -71.19843);
case 1224: return new CityInfo("Mosoc Cancha", "08", -14.28514, -71.08773);
case 1225: return new CityInfo("Huayna Alcalde", "08", -14.26989, -71.09599);
case 1226: return new CityInfo("Aucara", "05", -14.28083, -73.97611);
case 1227: return new CityInfo("Caujul", "15", -10.80528, -76.97889);
case 1228: return new CityInfo("Bajo Pichanaqui", "12", -10.9275, -74.87417);
case 1229: return new CityInfo("Huaccana", "03", -13.3875, -73.68972);
case 1230: return new CityInfo("Echarate", "08", -12.73513, -72.61568);
case 1231: return new CityInfo("Genaro Herrera", "16", -4.90741, -73.66779);
case 1232: return new CityInfo("Coviriali", "12", -11.2925, -74.6275);
case 1233: return new CityInfo("Kelluyo", "21", -16.72417, -69.25556);
case 1234: return new CityInfo("Providencia", "01", -6.2975, -78.24);
case 1235: return new CityInfo("Chalamarca", "06", -6.49139, -78.46861);
case 1236: return new CityInfo("Choropampa", "06", -6.4375, -78.34972);
case 1237: return new CityInfo("Collonce", "01", -6.28111, -78.21278);
case 1238: return new CityInfo("Santa Catalina", "01", -6.11167, -78.06139);
case 1239: return new CityInfo("Duraznopampa", "01", -6.59306, -77.80806);
case 1240: return new CityInfo("Matacoto", "02", -9.17833, -77.74917);
case 1241: return new CityInfo("Carhuac", "02", -9.26167, -77.69278);
case 1242: return new CityInfo("Aco", "02", -9.36917, -77.56333);
case 1243: return new CityInfo("Cheto", "01", -6.25639, -77.70028);
case 1244: return new CityInfo("Daguas", "01", -6.22667, -77.74056);
case 1245: return new CityInfo("Longar", "01", -6.38278, -77.54528);
case 1246: return new CityInfo("Cochamal", "01", -6.40639, -77.58333);
case 1247: return new CityInfo("Huambo", "01", -6.42806, -77.53611);
case 1248: return new CityInfo("Parcoy", "13", -8.03389, -77.47917);
case 1249: return new CityInfo("Urpay", "13", -8.34722, -77.38944);
case 1250: return new CityInfo("Ullulluco", "02", -8.45556, -77.42667);
case 1251: return new CityInfo("Challas", "13", -8.43833, -77.32056);
case 1252: return new CityInfo("Huancaspata", "13", -8.45667, -77.29833);
case 1253: return new CityInfo("Naranjos", "22", -5.74278, -77.49722);
case 1254: return new CityInfo("Bajo Naranjillo", "22", -5.81528, -77.38278);
case 1255: return new CityInfo("Nueva Cajamarca", "22", -5.94056, -77.30806);
case 1256: return new CityInfo("Saramiriza", "16", -4.56556, -77.41583);
case 1257: return new CityInfo("Nuevo Progreso", "10", -8.4525, -76.32389);
case 1258: return new CityInfo("San Juan", "16", -3.885, -73.56722);
case 1259: return new CityInfo("Yanahuanca", "19", -10.49139, -76.51667);
case 1260: return new CityInfo("Huabal", "06", -5.61611, -78.92333);
case 1261: return new CityInfo("Buenos Aires", "02", -9.12417, -78.4975);
case 1262: return new CityInfo("Yuyapichis", "10", -9.62732, -74.97658);
case 1263: return new CityInfo("Pampamarca", "10", -9.70553, -76.70206);
case 1264: return new CityInfo("Llata", "10", -9.54999, -76.81613);
case 1265: return new CityInfo("Jacas Grande", "10", -9.53965, -76.73639);
case 1266: return new CityInfo("Cayhuayna", "10", -9.95851, -76.24853);
case 1267: return new CityInfo("Huancapallac", "10", -9.89412, -76.41455);
case 1268: return new CityInfo("Paucarbamba", "10", -9.94459, -76.22323);
case 1269: return new CityInfo("El Rosario", "12", -11.78531, -75.67408);
case 1270: return new CityInfo("Masma Chicche", "12", -11.78593, -75.37849);
case 1271: return new CityInfo("Sausa", "12", -11.79319, -75.48414);
case 1272: return new CityInfo("Huertas", "12", -11.768, -75.47441);
case 1273: return new CityInfo("Mucllo", "12", -11.61607, -75.09115);
case 1274: return new CityInfo("Masma", "12", -11.78509, -75.42597);
case 1275: return new CityInfo("Matahuasi", "12", -11.89161, -75.3435);
case 1276: return new CityInfo("Hualhuas", "12", -11.97147, -75.25065);
case 1277: return new CityInfo("Saño", "12", -11.95671, -75.25685);
case 1278: return new CityInfo("Quilcas", "12", -11.93581, -75.25959);
case 1279: return new CityInfo("Quichuay", "12", -11.88982, -75.28571);
case 1280: return new CityInfo("Rapayan", "02", -9.20273, -76.75967);
case 1281: return new CityInfo("Anra", "02", -9.2329, -76.92328);
case 1282: return new CityInfo("Cochabamba", "10", -9.09536, -76.83688);
case 1283: return new CityInfo("San Pedro De Cachora", "03", -13.63333, -72.88333);
case 1284: return new CityInfo("Ledoy", "22", -7.12823, -76.65018);
case 1285: return new CityInfo("Pajarillo", "22", -7.18298, -76.6933);
case 1286: return new CityInfo("Shatoja", "22", -6.52821, -76.71823);
case 1287: return new CityInfo("La Rinconada", "21", -14.63126, -69.44638);
case 1288: return new CityInfo("Urb. Santo Domingo", "15", -11.87655, -77.03345);
case 1289: return new CityInfo("Indiana", "16", -3.49989, -73.05136);
case 1290: return new CityInfo("Salvación", "17", -12.83605, -71.3649);
case 1291: return new CityInfo("Bolívar", "13", -7.15395, -77.70263);
default: return new CityInfo("Paucartambo", "19", -10.77326, -75.81109);

                                    }                                        
                                }
                            
                        }
                    }
                