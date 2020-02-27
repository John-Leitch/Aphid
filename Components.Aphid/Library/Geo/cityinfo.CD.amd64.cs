
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
                                    public const string Country = "CD";
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
                            
                                        var cur = (Math.Abs(0.76755 - lat) + Math.Abs(24.43973 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(3.03716 - lat) + Math.Abs(29.53551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.14838 - lat) + Math.Abs(27.99466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.39534 - lat) + Math.Abs(29.13779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.41621 - lat) + Math.Abs(20.79995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.57386 - lat) + Math.Abs(29.04339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.00906 - lat) + Math.Abs(23.45278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.85187 - lat) + Math.Abs(21.5595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.13603 - lat) + Math.Abs(23.58979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.97503 - lat) + Math.Abs(23.44391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.35218 - lat) + Math.Abs(21.42192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.38771 - lat) + Math.Abs(25.74885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.52105 - lat) + Math.Abs(23.6005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.15127 - lat) + Math.Abs(21.51672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.38532 - lat) + Math.Abs(27.00029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.51528 - lat) + Math.Abs(25.19099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.94373 - lat) + Math.Abs(25.92237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.42741 - lat) + Math.Abs(26.66656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.89624 - lat) + Math.Abs(22.41659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.59678 - lat) + Math.Abs(26.66715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.73508 - lat) + Math.Abs(24.99798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.94749 - lat) + Math.Abs(29.19471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.13791 - lat) + Math.Abs(24.48179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.49682 - lat) + Math.Abs(28.79081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.05255 - lat) + Math.Abs(26.9143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.77391 - lat) + Math.Abs(27.61603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.33111 - lat) + Math.Abs(20.58638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.67409 - lat) + Math.Abs(29.22845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.279 - lat) + Math.Abs(21.00284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.74504 - lat) + Math.Abs(23.95328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.49573 - lat) + Math.Abs(22.26962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.14164 - lat) + Math.Abs(29.29117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.78582 - lat) + Math.Abs(24.72997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.33863 - lat) + Math.Abs(20.88577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.55941 - lat) + Math.Abs(30.25224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.18771 - lat) + Math.Abs(22.46827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.49077 - lat) + Math.Abs(28.84281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.20443 - lat) + Math.Abs(25.85475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.50695 - lat) + Math.Abs(21.0726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.81461 - lat) + Math.Abs(23.68665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.28163 - lat) + Math.Abs(20.88053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.49113 - lat) + Math.Abs(29.47306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.23909 - lat) + Math.Abs(23.61598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.73877 - lat) + Math.Abs(23.78326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.66089 - lat) + Math.Abs(27.47938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.98303 - lat) + Math.Abs(26.7384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.71484 - lat) + Math.Abs(25.46674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.76097 - lat) + Math.Abs(27.25135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.87352 - lat) + Math.Abs(26.59746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.99707 - lat) + Math.Abs(12.9484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.72037 - lat) + Math.Abs(17.69001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.01728 - lat) + Math.Abs(16.92238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.92753 - lat) + Math.Abs(12.37148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.25837 - lat) + Math.Abs(14.85838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.04865 - lat) + Math.Abs(18.26034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.83861 - lat) + Math.Abs(13.46306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.02328 - lat) + Math.Abs(19.53385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.06046 - lat) + Math.Abs(17.1821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.65332 - lat) + Math.Abs(18.63566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.32758 - lat) + Math.Abs(15.31357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.04098 - lat) + Math.Abs(18.81619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.47833 - lat) + Math.Abs(16.81735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.5833 - lat) + Math.Abs(15.16554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.9275 - lat) + Math.Abs(18.2881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.25651 - lat) + Math.Abs(19.77234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.54437 - lat) + Math.Abs(18.60364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.1898 - lat) + Math.Abs(19.8833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.85098 - lat) + Math.Abs(13.05364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.158 - lat) + Math.Abs(16.23249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.31687 - lat) + Math.Abs(17.38063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.38361 - lat) + Math.Abs(15.39139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yangambi", "30", 0.76755, 24.43973);
case 1: return new CityInfo("Watsa", "16", 3.03716, 29.53551);
case 2: return new CityInfo("Wamba", "16", 2.14838, 27.99466);
case 3: return new CityInfo("Uvira", "12", -3.39534, 29.13779);
case 4: return new CityInfo("Tshikapa", "18", -6.41621, 20.79995);
case 5: return new CityInfo("Sake", "11", -1.57386, 29.04339);
case 6: return new CityInfo("Mwene-Ditu", "21", -7.00906, 23.45278);
case 7: return new CityInfo("Mweka", "18", -4.85187, 21.5595);
case 8: return new CityInfo("Mbuji-Mayi", "04", -6.13603, 23.58979);
case 9: return new CityInfo("Lusambo", "27", -4.97503, 23.44391);
case 10: return new CityInfo("Luebo", "18", -5.35218, 21.42192);
case 11: return new CityInfo("Lubao", "21", -5.38771, 25.74885);
case 12: return new CityInfo("Lodja", "27", -3.52105, 23.6005);
case 13: return new CityInfo("Lisala", "02", 2.15127, 21.51672);
case 14: return new CityInfo("Kongolo", "29", -5.38532, 27.00029);
case 15: return new CityInfo("Kisangani", "30", 0.51528, 25.19099);
case 16: return new CityInfo("Kindu", "10", -2.94373, 25.92237);
case 17: return new CityInfo("Kasongo", "10", -4.42741, 26.66656);
case 18: return new CityInfo("Kananga", "23", -5.89624, 22.41659);
case 19: return new CityInfo("Kampene", "10", -3.59678, 26.66715);
case 20: return new CityInfo("Kamina", "15", -8.73508, 24.99798);
case 21: return new CityInfo("Kalemie", "29", -5.94749, 29.19471);
case 22: return new CityInfo("Kabinda", "04", -6.13791, 24.48179);
case 23: return new CityInfo("Kabare", "12", -2.49682, 28.79081);
case 24: return new CityInfo("Kabalo", "29", -6.05255, 26.9143);
case 25: return new CityInfo("Isiro", "16", 2.77391, 27.61603);
case 26: return new CityInfo("Ilebo", "18", -4.33111, 20.58638);
case 27: return new CityInfo("Goma", "11", -1.67409, 29.22845);
case 28: return new CityInfo("Gbadolite", "26", 4.279, 21.00284);
case 29: return new CityInfo("Gandajika", "04", -6.74504, 23.95328);
case 30: return new CityInfo("Demba", "23", -5.49573, 22.26962);
case 31: return new CityInfo("Butembo", "11", 0.14164, 29.29117);
case 32: return new CityInfo("Buta", "13", 2.78582, 24.72997);
case 33: return new CityInfo("Businga", "26", 3.33863, 20.88577);
case 34: return new CityInfo("Bunia", "17", 1.55941, 30.25224);
case 35: return new CityInfo("Bumba", "25", 2.18771, 22.46827);
case 36: return new CityInfo("Bukavu", "12", -2.49077, 28.84281);
case 37: return new CityInfo("Bukama", "15", -9.20443, 25.85475);
case 38: return new CityInfo("Bongandanga", "28", 1.50695, 21.0726);
case 39: return new CityInfo("Bondo", "13", 3.81461, 23.68665);
case 40: return new CityInfo("Boende", "31", -0.28163, 20.88053);
case 41: return new CityInfo("Beni", "11", 0.49113, 29.47306);
case 42: return new CityInfo("Basoko", "30", 1.23909, 23.61598);
case 43: return new CityInfo("Aketi", "13", 2.73877, 23.78326);
case 44: return new CityInfo("Lubumbashi", "14", -11.66089, 27.47938);
case 45: return new CityInfo("Likasi", "14", -10.98303, 26.7384);
case 46: return new CityInfo("Kolwezi", "22", -10.71484, 25.46674);
case 47: return new CityInfo("Kipushi", "14", -11.76097, 27.25135);
case 48: return new CityInfo("Kambove", "14", -10.87352, 26.59746);
case 49: return new CityInfo("Tshela", "08", -4.99707, 12.9484);
case 50: return new CityInfo("Nioki", "24", -2.72037, 17.69001);
case 51: return new CityInfo("Mushie", "24", -3.01728, 16.92238);
case 52: return new CityInfo("Moanda", "08", -5.92753, 12.37148);
case 53: return new CityInfo("Mbanza-Ngungu", "08", -5.25837, 14.85838);
case 54: return new CityInfo("Mbandaka", "02", 0.04865, 18.26034);
case 55: return new CityInfo("Matadi", "08", -5.83861, 13.46306);
case 56: return new CityInfo("Mangai", "20", -4.02328, 19.53385);
case 57: return new CityInfo("Lukolela", "02", -1.06046, 17.1821);
case 58: return new CityInfo("Libenge", "28", 3.65332, 18.63566);
case 59: return new CityInfo("Kinshasa", "06", -4.32758, 15.31357);
case 60: return new CityInfo("Kikwit", "20", -5.04098, 18.81619);
case 61: return new CityInfo("Kasongo-Lunda", "19", -6.47833, 16.81735);
case 62: return new CityInfo("Kasangulu", "08", -4.5833, 15.16554);
case 63: return new CityInfo("Inongo", "24", -1.9275, 18.2881);
case 64: return new CityInfo("Gemena", "02", 3.25651, 19.77234);
case 65: return new CityInfo("Bulungu", "20", -4.54437, 18.60364);
case 66: return new CityInfo("Bosobolo", "26", 4.1898, 19.8833);
case 67: return new CityInfo("Boma", "08", -5.85098, 13.05364);
case 68: return new CityInfo("Bolobo", "24", -2.158, 16.23249);
case 69: return new CityInfo("Bandundu", "20", -3.31687, 17.38063);
default: return new CityInfo("Masina", "06", -4.38361, 15.39139);

                                    }                                        
                                }
                            
                        }
                    }
                