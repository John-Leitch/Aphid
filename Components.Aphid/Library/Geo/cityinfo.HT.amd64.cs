
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
                                    public const string Country = "HT";
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
                            
                                        var cur = (Math.Abs(19.0505 - lat) + Math.Abs(-72.46585 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(19.61668 - lat) + Math.Abs(-72.02442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16338 - lat) + Math.Abs(-73.80949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32589 - lat) + Math.Abs(-74.39598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.0173 - lat) + Math.Abs(-71.96235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.65297 - lat) + Math.Abs(-72.09391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.08209 - lat) + Math.Abs(-71.83855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.24384 - lat) + Math.Abs(-71.84157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.59946 - lat) + Math.Abs(-72.78088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.43877 - lat) + Math.Abs(-72.1991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.10819 - lat) + Math.Abs(-72.69379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26241 - lat) + Math.Abs(-73.54603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.93397 - lat) + Math.Abs(-72.72138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07611 - lat) + Math.Abs(-73.81254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18182 - lat) + Math.Abs(-74.00345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.41327 - lat) + Math.Abs(-72.08077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.69696 - lat) + Math.Abs(-72.15712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.7518 - lat) + Math.Abs(-72.43006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.93984 - lat) + Math.Abs(-72.83037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.54349 - lat) + Math.Abs(-72.33881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.24963 - lat) + Math.Abs(-74.0971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.59795 - lat) + Math.Abs(-72.46994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.67707 - lat) + Math.Abs(-72.26969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.66745 - lat) + Math.Abs(-72.55229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.33594 - lat) + Math.Abs(-72.11662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.67525 - lat) + Math.Abs(-71.89691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.52535 - lat) + Math.Abs(-73.50815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43117 - lat) + Math.Abs(-72.86521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47611 - lat) + Math.Abs(-73.23495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.63011 - lat) + Math.Abs(-73.15499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5125 - lat) + Math.Abs(-72.28528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.52201 - lat) + Math.Abs(-71.92323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.54934 - lat) + Math.Abs(-71.72475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.56039 - lat) + Math.Abs(-74.25777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.40815 - lat) + Math.Abs(-71.78132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.807 - lat) + Math.Abs(-73.37605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.83455 - lat) + Math.Abs(-72.1048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44599 - lat) + Math.Abs(-73.08957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.60837 - lat) + Math.Abs(-72.21319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.51736 - lat) + Math.Abs(-72.36133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23167 - lat) + Math.Abs(-72.32289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.17607 - lat) + Math.Abs(-72.13958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.67014 - lat) + Math.Abs(-72.1243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.70603 - lat) + Math.Abs(-72.40336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4049 - lat) + Math.Abs(-74.4528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3054 - lat) + Math.Abs(-74.21968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5111 - lat) + Math.Abs(-72.63343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.84507 - lat) + Math.Abs(-72.52349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.38398 - lat) + Math.Abs(-73.41435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.83047 - lat) + Math.Abs(-71.93563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44773 - lat) + Math.Abs(-72.28398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.65 - lat) + Math.Abs(-74.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.85379 - lat) + Math.Abs(-73.19131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23427 - lat) + Math.Abs(-72.53539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.15 - lat) + Math.Abs(-72.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.6708 - lat) + Math.Abs(-72.67808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.54091 - lat) + Math.Abs(-72.52679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4259 - lat) + Math.Abs(-72.76995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.26513 - lat) + Math.Abs(-72.76897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.57744 - lat) + Math.Abs(-72.16872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.44755 - lat) + Math.Abs(-72.68928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.66273 - lat) + Math.Abs(-71.83798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39566 - lat) + Math.Abs(-71.85634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.50547 - lat) + Math.Abs(-71.98122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27782 - lat) + Math.Abs(-73.12733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.79445 - lat) + Math.Abs(-72.79949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.61549 - lat) + Math.Abs(-71.77792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.48342 - lat) + Math.Abs(-72.48537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.52734 - lat) + Math.Abs(-72.24337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.26177 - lat) + Math.Abs(-72.51611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.99345 - lat) + Math.Abs(-72.39058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.65476 - lat) + Math.Abs(-71.81451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.54472 - lat) + Math.Abs(-72.30278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.56107 - lat) + Math.Abs(-74.42167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.57677 - lat) + Math.Abs(-72.22625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18872 - lat) + Math.Abs(-73.00287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20601 - lat) + Math.Abs(-74.04013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.67546 - lat) + Math.Abs(-71.95271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.56766 - lat) + Math.Abs(-73.88942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27484 - lat) + Math.Abs(-74.16613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20169 - lat) + Math.Abs(-73.88957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.55037 - lat) + Math.Abs(-74.31317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.16696 - lat) + Math.Abs(-71.79015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.2311 - lat) + Math.Abs(-72.39545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.19331 - lat) + Math.Abs(-73.74601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29987 - lat) + Math.Abs(-73.65455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.54114 - lat) + Math.Abs(-72.39922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.37795 - lat) + Math.Abs(-71.8303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.69274 - lat) + Math.Abs(-72.01733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.75938 - lat) + Math.Abs(-72.19815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32648 - lat) + Math.Abs(-73.86734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.73582 - lat) + Math.Abs(-72.41929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.69142 - lat) + Math.Abs(-73.33769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23768 - lat) + Math.Abs(-72.06638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.48255 - lat) + Math.Abs(-73.63884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.66307 - lat) + Math.Abs(-73.20943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.46959 - lat) + Math.Abs(-72.11466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.81667 - lat) + Math.Abs(-72.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27974 - lat) + Math.Abs(-73.39433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.63382 - lat) + Math.Abs(-73.0553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.5011 - lat) + Math.Abs(-73.3449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05 - lat) + Math.Abs(-71.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.83449 - lat) + Math.Abs(-72.86644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.51881 - lat) + Math.Abs(-71.88214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.68075 - lat) + Math.Abs(-72.31978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.64901 - lat) + Math.Abs(-74.30786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.93333 - lat) + Math.Abs(-72.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Verrettes", "06", 19.0505, -72.46585);
case 1: return new CityInfo("Trou du Nord", "10", 19.61668, -72.02442);
case 2: return new CityInfo("Torbeck", "12", 18.16338, -73.80949);
case 3: return new CityInfo("Tiburon", "12", 18.32589, -74.39598);
case 4: return new CityInfo("Thomonde", "07", 19.0173, -71.96235);
case 5: return new CityInfo("Thomazeau", "11", 18.65297, -72.09391);
case 6: return new CityInfo("Thomassique", "07", 19.08209, -71.83855);
case 7: return new CityInfo("Thiotte", "13", 18.24384, -71.84157);
case 8: return new CityInfo("Terre Neuve", "06", 19.59946, -72.78088);
case 9: return new CityInfo("Saint-Raphaël", "09", 19.43877, -72.1991);
case 10: return new CityInfo("Saint-Marc", "06", 19.10819, -72.69379);
case 11: return new CityInfo("Saint-Louis du Sud", "12", 18.26241, -73.54603);
case 12: return new CityInfo("Saint-Louis du Nord", "03", 19.93397, -72.72138);
case 13: return new CityInfo("Saint-Jean du Sud", "12", 18.07611, -73.81254);
case 14: return new CityInfo("Roche-à-Bateau", "12", 18.18182, -74.00345);
case 15: return new CityInfo("Ranquitte", "09", 19.41327, -72.08077);
case 16: return new CityInfo("Quartier Morin", "09", 19.69696, -72.15712);
case 17: return new CityInfo("Port-Margot", "09", 19.7518, -72.43006);
case 18: return new CityInfo("Port-de-Paix", "03", 19.93984, -72.83037);
case 19: return new CityInfo("Port-au-Prince", "11", 18.54349, -72.33881);
case 20: return new CityInfo("Port-à-Piment", "12", 18.24963, -74.0971);
case 21: return new CityInfo("Plaisance", "09", 19.59795, -72.46994);
case 22: return new CityInfo("Plaine du Nord", "09", 19.67707, -72.26969);
case 23: return new CityInfo("Pilate", "09", 19.66745, -72.55229);
case 24: return new CityInfo("Pignon", "09", 19.33594, -72.11662);
case 25: return new CityInfo("Phaëton", "10", 19.67525, -71.89691);
case 26: return new CityInfo("Petit Trou de Nippes", "15", 18.52535, -73.50815);
case 27: return new CityInfo("Tigwav", "11", 18.43117, -72.86521);
case 28: return new CityInfo("Petite Rivière de Nippes", "14", 18.47611, -73.23495);
case 29: return new CityInfo("Petite Anse", "03", 19.63011, -73.15499);
case 30: return new CityInfo("Pétionville", "11", 18.5125, -72.28528);
case 31: return new CityInfo("Perches", "10", 19.52201, -71.92323);
case 32: return new CityInfo("Ouanaminthe", "10", 19.54934, -71.72475);
case 33: return new CityInfo("Moron", "14", 18.56039, -74.25777);
case 34: return new CityInfo("Montòrganize", "10", 19.40815, -71.78132);
case 35: return new CityInfo("Môle Saint-Nicolas", "03", 19.807, -73.37605);
case 36: return new CityInfo("Mirebalais", "07", 18.83455, -72.1048);
case 37: return new CityInfo("Miragoâne", "15", 18.44599, -73.08957);
case 38: return new CityInfo("Milot", "09", 19.60837, -72.21319);
case 39: return new CityInfo("Marmelade", "06", 19.51736, -72.36133);
case 40: return new CityInfo("Marigot", "13", 18.23167, -72.32289);
case 41: return new CityInfo("Mayisad", "07", 19.17607, -72.13958);
case 42: return new CityInfo("Limonade", "09", 19.67014, -72.1243);
case 43: return new CityInfo("Lenbe", "09", 19.70603, -72.40336);
case 44: return new CityInfo("Les Irois", "14", 18.4049, -74.4528);
case 45: return new CityInfo("Les Anglais", "12", 18.3054, -74.21968);
case 46: return new CityInfo("Léogâne", "11", 18.5111, -72.63343);
case 47: return new CityInfo("Borgne", "09", 19.84507, -72.52349);
case 48: return new CityInfo("L'Asile", "15", 18.38398, -73.41435);
case 49: return new CityInfo("Lascahobas", "07", 18.83047, -71.93563);
case 50: return new CityInfo("Kenscoff", "11", 18.44773, -72.28398);
case 51: return new CityInfo("Jérémie", "14", 18.65, -74.11667);
case 52: return new CityInfo("Jean-Rabel", "03", 19.85379, -73.19131);
case 53: return new CityInfo("Jacmel", "13", 18.23427, -72.53539);
case 54: return new CityInfo("Hinche", "07", 19.15, -72.01667);
case 55: return new CityInfo("Gros Morne", "06", 19.6708, -72.67808);
case 56: return new CityInfo("Gressier", "11", 18.54091, -72.52679);
case 57: return new CityInfo("Grangwav", "11", 18.4259, -72.76995);
case 58: return new CityInfo("Grande Saline", "06", 19.26513, -72.76897);
case 59: return new CityInfo("Grande Rivière du Nord", "09", 19.57744, -72.16872);
case 60: return new CityInfo("Gonaïves", "06", 19.44755, -72.68928);
case 61: return new CityInfo("Fort Liberté", "10", 19.66273, -71.83798);
case 62: return new CityInfo("Fonds Verrettes", "11", 18.39566, -71.85634);
case 63: return new CityInfo("Fond Parisien", "11", 18.50547, -71.98122);
case 64: return new CityInfo("Fond des Blancs", "12", 18.27782, -73.12733);
case 65: return new CityInfo("Fond Bassin Bleu", "03", 19.79445, -72.79949);
case 66: return new CityInfo("Ferrier", "10", 19.61549, -71.77792);
case 67: return new CityInfo("Ennery", "06", 19.48342, -72.48537);
case 68: return new CityInfo("Dondon", "09", 19.52734, -72.24337);
case 69: return new CityInfo("Dessalines", "06", 19.26177, -72.51611);
case 70: return new CityInfo("Désarmes", "06", 18.99345, -72.39058);
case 71: return new CityInfo("Dérac", "10", 19.65476, -71.81451);
case 72: return new CityInfo("Delmas 73", "11", 18.54472, -72.30278);
case 73: return new CityInfo("Dame-Marie", "14", 18.56107, -74.42167);
case 74: return new CityInfo("Croix-des-Bouquets", "11", 18.57677, -72.22625);
case 75: return new CityInfo("Kotdefè", "13", 18.18872, -73.00287);
case 76: return new CityInfo("Koto", "12", 18.20601, -74.04013);
case 77: return new CityInfo("Cornillon", "11", 18.67546, -71.95271);
case 78: return new CityInfo("Corail", "14", 18.56766, -73.88942);
case 79: return new CityInfo("Chardonnière", "12", 18.27484, -74.16613);
case 80: return new CityInfo("Chantal", "12", 18.20169, -73.88957);
case 81: return new CityInfo("Chambellan", "14", 18.55037, -74.31317);
case 82: return new CityInfo("Cerca la Source", "07", 19.16696, -71.79015);
case 83: return new CityInfo("Cayes-Jacmel", "13", 18.2311, -72.39545);
case 84: return new CityInfo("Les Cayes", "12", 18.19331, -73.74601);
case 85: return new CityInfo("Cavaillon", "12", 18.29987, -73.65455);
case 86: return new CityInfo("Carrefour", "11", 18.54114, -72.39922);
case 87: return new CityInfo("Carice", "10", 19.37795, -71.8303);
case 88: return new CityInfo("Caracol", "10", 19.69274, -72.01733);
case 89: return new CityInfo("Okap", "09", 19.75938, -72.19815);
case 90: return new CityInfo("Camp Perrin", "12", 18.32648, -73.86734);
case 91: return new CityInfo("Cabaret", "11", 18.73582, -72.41929);
case 92: return new CityInfo("Bombardopolis", "03", 19.69142, -73.33769);
case 93: return new CityInfo("Belle-Anse", "13", 18.23768, -72.06638);
case 94: return new CityInfo("Baradères", "15", 18.48255, -73.63884);
case 95: return new CityInfo("Baie de Henne", "03", 19.66307, -73.20943);
case 96: return new CityInfo("Bahon", "09", 19.46959, -72.11466);
case 97: return new CityInfo("Arcahaie", "03", 19.81667, -72.91667);
case 98: return new CityInfo("Aquin", "12", 18.27974, -73.39433);
case 99: return new CityInfo("Anse Rouge", "06", 19.63382, -73.0553);
case 100: return new CityInfo("Anse-à-Veau", "14", 18.5011, -73.3449);
case 101: return new CityInfo("Anse-à-Pitre", "13", 18.05, -71.75);
case 102: return new CityInfo("Anse à Galets", "11", 18.83449, -72.86644);
case 103: return new CityInfo("Acul Samedi", "10", 19.51881, -71.88214);
case 104: return new CityInfo("Acul du Nord", "09", 19.68075, -72.31978);
case 105: return new CityInfo("Les Abricots", "14", 18.64901, -74.30786);
default: return new CityInfo("Ti Port-de-Paix", "03", 19.93333, -72.83333);

                                    }                                        
                                }
                            
                        }
                    }
                