
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
                                    public const string Country = "ET";
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
                            
                                        var cur = (Math.Abs(7.93333 - lat) + Math.Abs(38.71667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(6.75 - lat) + Math.Abs(38.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.88333 - lat) + Math.Abs(38.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91667 - lat) + Math.Abs(37.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.58964 - lat) + Math.Abs(39.43767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45 - lat) + Math.Abs(39.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6 - lat) + Math.Abs(38.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.96667 - lat) + Math.Abs(36.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66667 - lat) + Math.Abs(38.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.2 - lat) + Math.Abs(35.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31667 - lat) + Math.Abs(39.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.2 - lat) + Math.Abs(38.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.56667 - lat) + Math.Abs(37.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.76494 - lat) + Math.Abs(38.91006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15203 - lat) + Math.Abs(39.02335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91667 - lat) + Math.Abs(38.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.01667 - lat) + Math.Abs(39.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.5 - lat) + Math.Abs(35.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55 - lat) + Math.Abs(39.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58679 - lat) + Math.Abs(39.12111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.99865 - lat) + Math.Abs(35.58879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3 - lat) + Math.Abs(35.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.9 - lat) + Math.Abs(39.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.8 - lat) + Math.Abs(35.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.49667 - lat) + Math.Abs(39.47528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.05 - lat) + Math.Abs(38.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.7875 - lat) + Math.Abs(39.54222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.83333 - lat) + Math.Abs(36.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.87309 - lat) + Math.Abs(38.44425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.03219 - lat) + Math.Abs(39.04756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.50583 - lat) + Math.Abs(39.52278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.25 - lat) + Math.Abs(37.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.31667 - lat) + Math.Abs(38.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06667 - lat) + Math.Abs(38.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.88333 - lat) + Math.Abs(38.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.71668 - lat) + Math.Abs(39.86997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08155 - lat) + Math.Abs(39.74339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.65 - lat) + Math.Abs(36.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.67344 - lat) + Math.Abs(36.83441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35 - lat) + Math.Abs(42.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.10307 - lat) + Math.Abs(38.28289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.15 - lat) + Math.Abs(39.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.54978 - lat) + Math.Abs(37.85374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21667 - lat) + Math.Abs(41.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.31387 - lat) + Math.Abs(42.11815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48333 - lat) + Math.Abs(38.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98333 - lat) + Math.Abs(37.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.15 - lat) + Math.Abs(35.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.6 - lat) + Math.Abs(37.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.01667 - lat) + Math.Abs(39.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53417 - lat) + Math.Abs(37.96515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.13952 - lat) + Math.Abs(40.71083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.17031 - lat) + Math.Abs(35.83491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.65 - lat) + Math.Abs(37.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16658 - lat) + Math.Abs(40.64689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.06667 - lat) + Math.Abs(38.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.81667 - lat) + Math.Abs(40.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.01667 - lat) + Math.Abs(37.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.8 - lat) + Math.Abs(38.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25 - lat) + Math.Abs(34.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7 - lat) + Math.Abs(37.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.8 - lat) + Math.Abs(38.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.3 - lat) + Math.Abs(36.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.73292 - lat) + Math.Abs(41.082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.98333 - lat) + Math.Abs(39.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.59306 - lat) + Math.Abs(41.86611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.41667 - lat) + Math.Abs(38.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.13333 - lat) + Math.Abs(39.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53333 - lat) + Math.Abs(34.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16667 - lat) + Math.Abs(38.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.31168 - lat) + Math.Abs(41.44301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.75225 - lat) + Math.Abs(38.97846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66667 - lat) + Math.Abs(38.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.85 - lat) + Math.Abs(38.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.84752 - lat) + Math.Abs(39.76027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.35 - lat) + Math.Abs(37.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.67954 - lat) + Math.Abs(39.53262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.15611 - lat) + Math.Abs(37.89806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.98417 - lat) + Math.Abs(37.765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11667 - lat) + Math.Abs(38.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7 - lat) + Math.Abs(37.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.28333 - lat) + Math.Abs(36.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.96667 - lat) + Math.Abs(37.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.45 - lat) + Math.Abs(38.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.9 - lat) + Math.Abs(40.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.456 - lat) + Math.Abs(36.35302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.19152 - lat) + Math.Abs(40.01675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.78333 - lat) + Math.Abs(36.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.59364 - lat) + Math.Abs(37.39077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98333 - lat) + Math.Abs(40.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06205 - lat) + Math.Abs(38.47635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.06667 - lat) + Math.Abs(34.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.08569 - lat) + Math.Abs(40.86708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.56838 - lat) + Math.Abs(41.43869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.1 - lat) + Math.Abs(39.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06667 - lat) + Math.Abs(37.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.03333 - lat) + Math.Abs(37.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.12109 - lat) + Math.Abs(38.72337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.63418 - lat) + Math.Abs(38.23603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.85 - lat) + Math.Abs(36.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.11667 - lat) + Math.Abs(37.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03333 - lat) + Math.Abs(38.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.02497 - lat) + Math.Abs(38.74689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.277 - lat) + Math.Abs(39.462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.26667 - lat) + Math.Abs(37.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.98333 - lat) + Math.Abs(39.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.79342 - lat) + Math.Abs(41.00578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.86 - lat) + Math.Abs(37.76159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Ziway", "51", 7.93333, 38.71667);
case 1: return new CityInfo("Yirga ‘Alem", "54", 6.75, 38.41667);
case 2: return new CityInfo("Yabēlo", "51", 4.88333, 38.08333);
case 3: return new CityInfo("Werota", "46", 11.91667, 37.7);
case 4: return new CityInfo("Were Īlu", "46", 10.58964, 39.43767);
case 5: return new CityInfo("Wenjī", "51", 8.45, 39.28333);
case 6: return new CityInfo("Wendo", "54", 6.6, 38.41667);
case 7: return new CityInfo("Turmi", "54", 4.96667, 36.48333);
case 8: return new CityInfo("Tulu Bolo", "51", 8.66667, 38.21667);
case 9: return new CityInfo("Tippi", "54", 7.2, 35.45);
case 10: return new CityInfo("Sirre", "51", 8.31667, 39.48333);
case 11: return new CityInfo("Shashemenē", "51", 7.2, 38.6);
case 12: return new CityInfo("Shambu", "51", 9.56667, 37.1);
case 13: return new CityInfo("Shakiso", "51", 5.76494, 38.91006);
case 14: return new CityInfo("Sendafa", "51", 9.15203, 39.02335);
case 15: return new CityInfo("Sebeta", "51", 8.91667, 38.61667);
case 16: return new CityInfo("Robīt", "46", 12.01667, 39.63333);
case 17: return new CityInfo("Nejo", "51", 9.5, 35.5);
case 18: return new CityInfo("Nazrēt", "51", 8.55, 39.26667);
case 19: return new CityInfo("Mojo", "51", 8.58679, 39.12111);
case 20: return new CityInfo("Mīzan Teferī", "54", 6.99865, 35.58879);
case 21: return new CityInfo("Metu", "51", 8.3, 35.58333);
case 22: return new CityInfo("Metahāra", "51", 8.9, 39.91667);
case 23: return new CityInfo("Mendī", "51", 9.8, 35.1);
case 24: return new CityInfo("Mek'ele", "53", 13.49667, 39.47528);
case 25: return new CityInfo("Mēga", "51", 4.05, 38.3);
case 26: return new CityInfo("Maych’ew", "53", 12.7875, 39.54222);
case 27: return new CityInfo("Lobuni", "54", 4.83333, 36.1);
case 28: return new CityInfo("Leku", "54", 6.87309, 38.44425);
case 29: return new CityInfo("Lalībela", "46", 12.03219, 39.04756);
case 30: return new CityInfo("Korem", "53", 12.50583, 39.52278);
case 31: return new CityInfo("Konso", "54", 5.25, 37.48333);
case 32: return new CityInfo("K’olīto", "54", 7.31667, 38.08333);
case 33: return new CityInfo("Kofelē", "51", 7.06667, 38.78333);
case 34: return new CityInfo("Kibre Mengist", "51", 5.88333, 38.98333);
case 35: return new CityInfo("Kemisē", "46", 10.71668, 39.86997);
case 36: return new CityInfo("Kombolcha", "46", 11.08155, 39.74339);
case 37: return new CityInfo("Jinka", "54", 5.65, 36.65);
case 38: return new CityInfo("Jimma", "51", 7.67344, 36.83441);
case 39: return new CityInfo("Jijiga", "52", 9.35, 42.8);
case 40: return new CityInfo("Inda Silasē", "53", 14.10307, 38.28289);
case 41: return new CityInfo("Huruta", "51", 8.15, 39.35);
case 42: return new CityInfo("Hosa’ina", "54", 7.54978, 37.85374);
case 43: return new CityInfo("Hīrna", "51", 9.21667, 41.1);
case 44: return new CityInfo("Harar", "50", 9.31387, 42.11815);
case 45: return new CityInfo("Hāgere Selam", "54", 6.48333, 38.51667);
case 46: return new CityInfo("Hāgere Hiywet", "51", 8.98333, 37.85);
case 47: return new CityInfo("Gorē", "51", 8.15, 35.53333);
case 48: return new CityInfo("Gondar", "46", 12.6, 37.46667);
case 49: return new CityInfo("Goba", "51", 7.01667, 39.98333);
case 50: return new CityInfo("Waliso", "51", 8.53417, 37.96515);
case 51: return new CityInfo("Ginir", "51", 7.13952, 40.71083);
case 52: return new CityInfo("Gimbi", "51", 9.17031, 35.83491);
case 53: return new CityInfo("Gīdolē", "54", 5.65, 37.36667);
case 54: return new CityInfo("Gewanē", "45", 10.16658, 40.64689);
case 55: return new CityInfo("Genet", "51", 9.06667, 38.5);
case 56: return new CityInfo("Gelemso", "51", 8.81667, 40.51667);
case 57: return new CityInfo("Gēdo", "51", 9.01667, 37.45);
case 58: return new CityInfo("Gebre Guracha", "51", 9.8, 38.4);
case 59: return new CityInfo("Gambēla", "49", 8.25, 34.58333);
case 60: return new CityInfo("Finote Selam", "46", 10.7, 37.26667);
case 61: return new CityInfo("Fichē", "51", 9.8, 38.73333);
case 62: return new CityInfo("Felege Neway", "54", 6.3, 36.88333);
case 63: return new CityInfo("Dubti", "45", 11.73292, 41.082);
case 64: return new CityInfo("Dodola", "51", 6.98333, 39.18333);
case 65: return new CityInfo("Dire Dawa", "48", 9.59306, 41.86611);
case 66: return new CityInfo("Dīla", "54", 6.41667, 38.31667);
case 67: return new CityInfo("Desē", "46", 11.13333, 39.63333);
case 68: return new CityInfo("Dembī Dolo", "51", 8.53333, 34.8);
case 69: return new CityInfo("Dejen", "46", 10.16667, 38.13333);
case 70: return new CityInfo("Deder", "51", 9.31168, 41.44301);
case 71: return new CityInfo("Bishoftu", "51", 8.75225, 38.97846);
case 72: return new CityInfo("Debre Werk’", "46", 10.66667, 38.16667);
case 73: return new CityInfo("Debre Tabor", "46", 11.85, 38.01667);
case 74: return new CityInfo("Debre Sīna", "46", 9.84752, 39.76027);
case 75: return new CityInfo("Debre Mark’os", "46", 10.35, 37.73333);
case 76: return new CityInfo("Debre Birhan", "46", 9.67954, 39.53262);
case 77: return new CityInfo("Debark’", "46", 13.15611, 37.89806);
case 78: return new CityInfo("Dabat", "46", 12.98417, 37.765);
case 79: return new CityInfo("Butajīra", "54", 8.11667, 38.36667);
case 80: return new CityInfo("Burē", "46", 10.7, 37.06667);
case 81: return new CityInfo("Bonga", "54", 7.28333, 36.23333);
case 82: return new CityInfo("Bodītī", "54", 6.96667, 37.86667);
case 83: return new CityInfo("Bichena", "46", 10.45, 38.2);
case 84: return new CityInfo("Bedēsa", "51", 8.9, 40.78333);
case 85: return new CityInfo("Bedelē", "51", 8.456, 36.35302);
case 86: return new CityInfo("Batī", "46", 11.19152, 40.01675);
case 87: return new CityInfo("Bako", "54", 5.78333, 36.56667);
case 88: return new CityInfo("Bahir Dar", "46", 11.59364, 37.39077);
case 89: return new CityInfo("Āwash", "45", 8.98333, 40.16667);
case 90: return new CityInfo("Hawassa", "54", 7.06205, 38.47635);
case 91: return new CityInfo("Āsosa", "47", 10.06667, 34.53333);
case 92: return new CityInfo("Āsbe Teferī", "51", 9.08569, 40.86708);
case 93: return new CityInfo("Asaita", "45", 11.56838, 41.43869);
case 94: return new CityInfo("Āsasa", "51", 7.1, 39.2);
case 95: return new CityInfo("Āreka", "54", 7.06667, 37.7);
case 96: return new CityInfo("Arba Minch", "54", 6.03333, 37.55);
case 97: return new CityInfo("Axum", "53", 14.12109, 38.72337);
case 98: return new CityInfo("Hagere Maryam", "51", 5.63418, 38.23603);
case 99: return new CityInfo("Āgaro", "51", 7.85, 36.65);
case 100: return new CityInfo("Ādīs Zemen", "46", 12.11667, 37.78333);
case 101: return new CityInfo("Ādīs ‘Alem", "51", 9.03333, 38.4);
case 102: return new CityInfo("Addis Ababa", "44", 9.02497, 38.74689);
case 103: return new CityInfo("Ādīgrat", "53", 14.277, 39.462);
case 104: return new CityInfo("Addiet Canna", "46", 11.26667, 37.48333);
case 105: return new CityInfo("Abomsa", "46", 9.98333, 39.98333);
case 106: return new CityInfo("Semera", "45", 11.79342, 41.00578);
default: return new CityInfo("Sodo", "54", 6.86, 37.76159);

                                    }                                        
                                }
                            
                        }
                    }
                