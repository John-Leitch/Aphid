
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
                                    public const string Country = "BW";
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
                            
                                        var cur = (Math.Abs(-25.26667 - lat) + Math.Abs(23.28333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-24.03333 - lat) + Math.Abs(21.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.05 - lat) + Math.Abs(22.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.16458 - lat) + Math.Abs(22.45573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.38333 - lat) + Math.Abs(22.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.44236 - lat) + Math.Abs(27.46153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.95 - lat) + Math.Abs(27.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.50639 - lat) + Math.Abs(25.63625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.67014 - lat) + Math.Abs(25.53975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.4184 - lat) + Math.Abs(27.40127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.05 - lat) + Math.Abs(26.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.10719 - lat) + Math.Abs(27.15205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.36536 - lat) + Math.Abs(21.84219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.38754 - lat) + Math.Abs(26.71077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.97895 - lat) + Math.Abs(27.84296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.4 - lat) + Math.Abs(23.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.46667 - lat) + Math.Abs(22.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.18333 - lat) + Math.Abs(27.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.86667 - lat) + Math.Abs(27.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.72454 - lat) + Math.Abs(27.57199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.87158 - lat) + Math.Abs(25.86989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.8645 - lat) + Math.Abs(27.42391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.02257 - lat) + Math.Abs(24.36052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.79904 - lat) + Math.Abs(27.19376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.45 - lat) + Math.Abs(26.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.52779 - lat) + Math.Abs(25.62698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.54605 - lat) + Math.Abs(27.12507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.01667 - lat) + Math.Abs(25.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.3115 - lat) + Math.Abs(25.37642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.66667 - lat) + Math.Abs(22.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.21667 - lat) + Math.Abs(26.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.7718 - lat) + Math.Abs(25.42156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.75 - lat) + Math.Abs(26.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.57234 - lat) + Math.Abs(27.45058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.18333 - lat) + Math.Abs(24.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.68805 - lat) + Math.Abs(26.65948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.59701 - lat) + Math.Abs(27.63006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.40659 - lat) + Math.Abs(25.49508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.99637 - lat) + Math.Abs(27.66766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.37114 - lat) + Math.Abs(27.58575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.43333 - lat) + Math.Abs(26.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.62694 - lat) + Math.Abs(25.86556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.32301 - lat) + Math.Abs(27.83492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.41667 - lat) + Math.Abs(26.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.6 - lat) + Math.Abs(26.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.98333 - lat) + Math.Abs(23.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.72125 - lat) + Math.Abs(27.31057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.26875 - lat) + Math.Abs(28.74946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.99075 - lat) + Math.Abs(27.33158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.62455 - lat) + Math.Abs(27.44875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.4 - lat) + Math.Abs(21.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.6155 - lat) + Math.Abs(27.3294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.28333 - lat) + Math.Abs(27.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.48333 - lat) + Math.Abs(27.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.9 - lat) + Math.Abs(27.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.10407 - lat) + Math.Abs(26.81421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.56667 - lat) + Math.Abs(27 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.18621 - lat) + Math.Abs(27.48856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.78333 - lat) + Math.Abs(24.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.75785 - lat) + Math.Abs(27.35001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.16667 - lat) + Math.Abs(21.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.22435 - lat) + Math.Abs(25.67728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.09442 - lat) + Math.Abs(25.02977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.41494 - lat) + Math.Abs(25.59263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.38333 - lat) + Math.Abs(25.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.96667 - lat) + Math.Abs(21.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.66384 - lat) + Math.Abs(27.2239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.4 - lat) + Math.Abs(27.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.05 - lat) + Math.Abs(20.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.48333 - lat) + Math.Abs(25.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.66667 - lat) + Math.Abs(21.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.88333 - lat) + Math.Abs(24.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.68954 - lat) + Math.Abs(23.49403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.01667 - lat) + Math.Abs(24.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.80165 - lat) + Math.Abs(25.16024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.96675 - lat) + Math.Abs(25.33273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.67518 - lat) + Math.Abs(22.78762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.93369 - lat) + Math.Abs(26.57032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.59235 - lat) + Math.Abs(27.31069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.16667 - lat) + Math.Abs(24.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.41667 - lat) + Math.Abs(25.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.9988 - lat) + Math.Abs(21.77962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.18333 - lat) + Math.Abs(25.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.8327 - lat) + Math.Abs(28.72882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.69785 - lat) + Math.Abs(21.64581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.65451 - lat) + Math.Abs(25.90859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.66667 - lat) + Math.Abs(25.78222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.17 - lat) + Math.Abs(27.50778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.98333 - lat) + Math.Abs(23.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.58333 - lat) + Math.Abs(26.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.53333 - lat) + Math.Abs(21.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.02591 - lat) + Math.Abs(25.48976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.03918 - lat) + Math.Abs(26.63774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.9 - lat) + Math.Abs(20.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.45 - lat) + Math.Abs(26.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.6 - lat) + Math.Abs(25.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.69611 - lat) + Math.Abs(25.80111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.57389 - lat) + Math.Abs(25.83417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.54194 - lat) + Math.Abs(25.77139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.51917 - lat) + Math.Abs(25.8075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.55139 - lat) + Math.Abs(25.80306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.53778 - lat) + Math.Abs(25.9275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.56694 - lat) + Math.Abs(25.87417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.58722 - lat) + Math.Abs(25.87444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.63222 - lat) + Math.Abs(25.83139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.60167 - lat) + Math.Abs(24.72806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Werda", "04", -25.26667, 23.28333);
case 1: return new CityInfo("Tshane", "04", -24.03333, 21.9);
case 2: return new CityInfo("Tshabong", "04", -26.05, 22.45);
case 3: return new CityInfo("Tsau", "11", -20.16458, 22.45573);
case 4: return new CityInfo("Toteng", "00", -20.38333, 22.95);
case 5: return new CityInfo("Tonota", "01", -21.44236, 27.46153);
case 6: return new CityInfo("Tobane", "01", -21.95, 27.9);
case 7: return new CityInfo("Tlhareselele", "10", -25.50639, 25.63625);
case 8: return new CityInfo("Thamaga", "06", -24.67014, 25.53975);
case 9: return new CityInfo("Tamasane", "01", -22.4184, 27.40127);
case 10: return new CityInfo("Sua", "01", -20.05, 26.2);
case 11: return new CityInfo("Shakgwe", "01", -23.10719, 27.15205);
case 12: return new CityInfo("Shakawe", "11", -18.36536, 21.84219);
case 13: return new CityInfo("Serowe", "01", -22.38754, 26.71077);
case 14: return new CityInfo("Selebi-Phikwe", "17", -21.97895, 27.84296);
case 15: return new CityInfo("Sekoma", "10", -24.4, 23.88333);
case 16: return new CityInfo("Sehithwa", "11", -20.46667, 22.71667);
case 17: return new CityInfo("Sefophe", "01", -22.18333, 27.96667);
case 18: return new CityInfo("Sebina", "08", -20.86667, 27.25);
case 19: return new CityInfo("Ratholo", "01", -22.72454, 27.57199);
case 20: return new CityInfo("Ramotswa", "09", -24.87158, 25.86989);
case 21: return new CityInfo("Ramokgonami", "01", -22.8645, 27.42391);
case 22: return new CityInfo("Rakops", "01", -21.02257, 24.36052);
case 23: return new CityInfo("Pilikwe", "01", -22.79904, 27.19376);
case 24: return new CityInfo("Pilane", "05", -24.45, 26.13333);
case 25: return new CityInfo("Pandamatenga", "11", -18.52779, 25.62698);
case 26: return new CityInfo("Palapye", "01", -22.54605, 27.12507);
case 27: return new CityInfo("Otse", "09", -25.01667, 25.73333);
case 28: return new CityInfo("Orapa", "01", -21.3115, 25.37642);
case 29: return new CityInfo("Nokaneng", "11", -19.66667, 22.26667);
case 30: return new CityInfo("Nata", "01", -20.21667, 26.18333);
case 31: return new CityInfo("Mosopa", "10", -24.7718, 25.42156);
case 32: return new CityInfo("Mosetse", "01", -20.75, 26.65);
case 33: return new CityInfo("Moremi", "01", -22.57234, 27.45058);
case 34: return new CityInfo("Mopipi", "01", -21.18333, 24.88333);
case 35: return new CityInfo("Mookane", "01", -23.68805, 26.65948);
case 36: return new CityInfo("Maunatlala", "01", -22.59701, 27.63006);
case 37: return new CityInfo("Molepolole", "06", -24.40659, 25.49508);
case 38: return new CityInfo("Makobeng", "01", -22.99637, 27.66766);
case 39: return new CityInfo("Mogapinyana", "01", -22.37114, 27.58575);
case 40: return new CityInfo("Moijabana", "01", -22.43333, 26.41667);
case 41: return new CityInfo("Mogoditshane", "06", -24.62694, 25.86556);
case 42: return new CityInfo("Mogapi", "01", -22.32301, 27.83492);
case 43: return new CityInfo("Mochudi", "05", -24.41667, 26.15);
case 44: return new CityInfo("Mmathubudukwane", "05", -24.6, 26.43333);
case 45: return new CityInfo("Maun", "11", -19.98333, 23.41667);
case 46: return new CityInfo("Mathakola", "01", -22.72125, 27.31057);
case 47: return new CityInfo("Mathathane", "01", -22.26875, 28.74946);
case 48: return new CityInfo("Mathambgwane", "01", -20.99075, 27.33158);
case 49: return new CityInfo("Masunga", "08", -20.62455, 27.44875);
case 50: return new CityInfo("Manyana", "04", -23.4, 21.71667);
case 51: return new CityInfo("Malaka", "01", -22.6155, 27.3294);
case 52: return new CityInfo("Makwata", "01", -23.28333, 27.3);
case 53: return new CityInfo("Makoba", "00", -23.48333, 27.11667);
case 54: return new CityInfo("Makaleng", "08", -20.9, 27.28333);
case 55: return new CityInfo("Mahalapye", "01", -23.10407, 26.81421);
case 56: return new CityInfo("Magothla", "00", -23.56667, 27);
case 57: return new CityInfo("Machaneng", "01", -23.18621, 27.48856);
case 58: return new CityInfo("Mabuli", "00", -25.78333, 24.6);
case 59: return new CityInfo("Maapi", "01", -22.75785, 27.35001);
case 60: return new CityInfo("Lokwabe", "00", -24.16667, 21.83333);
case 61: return new CityInfo("Lobatse", "16", -25.22435, 25.67728);
case 62: return new CityInfo("Letlhakeng", "06", -24.09442, 25.02977);
case 63: return new CityInfo("Letlhakane", "01", -21.41494, 25.59263);
case 64: return new CityInfo("Lenchwe Le Tau", "06", -24.38333, 25.85);
case 65: return new CityInfo("Lehututu", "04", -23.96667, 21.86667);
case 66: return new CityInfo("Letsheng", "01", -22.66384, 27.2239);
case 67: return new CityInfo("Kurametsi", "00", -23.4, 27.06667);
case 68: return new CityInfo("Kuli", "03", -23.05, 20.06667);
case 69: return new CityInfo("Kopong", "09", -24.48333, 25.88333);
case 70: return new CityInfo("Khuis", "00", -26.66667, 21.83333);
case 71: return new CityInfo("Khudumelapye", "06", -23.88333, 24.75);
case 72: return new CityInfo("Khakhea", "10", -24.68954, 23.49403);
case 73: return new CityInfo("Kavimba", "12", -18.01667, 24.6);
case 74: return new CityInfo("Kasane", "12", -17.80165, 25.16024);
case 75: return new CityInfo("Kanye", "10", -24.96675, 25.33273);
case 76: return new CityInfo("Kang", "04", -23.67518, 22.78762);
case 77: return new CityInfo("Kalamare", "01", -22.93369, 26.57032);
case 78: return new CityInfo("Kalakamati", "08", -20.59235, 27.31069);
case 79: return new CityInfo("Kachikau", "12", -18.16667, 24.46667);
case 80: return new CityInfo("Janeng", "09", -25.41667, 25.55);
case 81: return new CityInfo("Hukuntsi", "04", -23.9988, 21.77962);
case 82: return new CityInfo("Gweta", "01", -20.18333, 25.23333);
case 83: return new CityInfo("Gobojango", "01", -21.8327, 28.72882);
case 84: return new CityInfo("Ghanzi", "03", -21.69785, 21.64581);
case 85: return new CityInfo("Gaborone", "14", -24.65451, 25.90859);
case 86: return new CityInfo("Gabane", "06", -24.66667, 25.78222);
case 87: return new CityInfo("Francistown", "13", -21.17, 27.50778);
case 88: return new CityInfo("Dutlwe", "06", -23.98333, 23.9);
case 89: return new CityInfo("Dukwe", "08", -20.58333, 26.41667);
case 90: return new CityInfo("Dekar", "03", -21.53333, 21.93333);
case 91: return new CityInfo("Botlhapatlou", "06", -24.02591, 25.48976);
case 92: return new CityInfo("Bonwapitse", "01", -23.03918, 26.63774);
case 93: return new CityInfo("Bokspits", "00", -26.9, 20.7);
case 94: return new CityInfo("Bokaa", "05", -24.45, 26.01667);
case 95: return new CityInfo("Boatlaname", "00", -23.6, 25.83333);
case 96: return new CityInfo("Mmokolodi", "06", -24.69611, 25.80111);
case 97: return new CityInfo("Gaphatshwe", "06", -24.57389, 25.83417);
case 98: return new CityInfo("Mononyane", "06", -24.54194, 25.77139);
case 99: return new CityInfo("Galekgatshwane", "06", -24.51917, 25.8075);
case 100: return new CityInfo("Metsemotlhaba", "06", -24.55139, 25.80306);
case 101: return new CityInfo("Kgaphamadi", "06", -24.53778, 25.9275);
case 102: return new CityInfo("Mmopone", "06", -24.56694, 25.87417);
case 103: return new CityInfo("Dumadumana", "06", -24.58722, 25.87444);
case 104: return new CityInfo("Nkoyaphiri", "06", -24.63222, 25.83139);
default: return new CityInfo("Jwaneng", "15", -24.60167, 24.72806);

                                    }                                        
                                }
                            
                        }
                    }
                