
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
                                    public const string Country = "ML";
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
                            
                                        var cur = (Math.Abs(15.3684 - lat) + Math.Abs(-4.2628 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(12.35811 - lat) + Math.Abs(-4.77688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11868 - lat) + Math.Abs(-10.57729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.18333 - lat) + Math.Abs(-8.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28737 - lat) + Math.Abs(-4.59317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.77348 - lat) + Math.Abs(-3.00742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.20126 - lat) + Math.Abs(1.01186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.45722 - lat) + Math.Abs(-4.9169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.67443 - lat) + Math.Abs(-3.97891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7328 - lat) + Math.Abs(-6.1219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.31755 - lat) + Math.Abs(-5.66654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11266 - lat) + Math.Abs(-6.72865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.4317 - lat) + Math.Abs(-6.2157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.30335 - lat) + Math.Abs(-4.89562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.2 - lat) + Math.Abs(-10.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.5304 - lat) + Math.Abs(-5.77003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.22932 - lat) + Math.Abs(-9.59277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.2526 - lat) + Math.Abs(-5.993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.9322 - lat) + Math.Abs(-3.9906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.16875 - lat) + Math.Abs(-7.28466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4843 - lat) + Math.Abs(-4.18296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.9182 - lat) + Math.Abs(2.4022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7021 - lat) + Math.Abs(-6.0659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.39173 - lat) + Math.Abs(-5.46421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.86273 - lat) + Math.Abs(-7.55985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.064 - lat) + Math.Abs(-3.07539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08943 - lat) + Math.Abs(-6.8929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5728 - lat) + Math.Abs(-8.0339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.88333 - lat) + Math.Abs(-9.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.0349 - lat) + Math.Abs(-9.4895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44111 - lat) + Math.Abs(1.40778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.84217 - lat) + Math.Abs(-4.9245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.9641 - lat) + Math.Abs(-5.35791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.44693 - lat) + Math.Abs(-11.44448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.74409 - lat) + Math.Abs(-8.07257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.93333 - lat) + Math.Abs(-8.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.55 - lat) + Math.Abs(-5.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.87778 - lat) + Math.Abs(-1.92306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.41453 - lat) + Math.Abs(-3.67075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.27167 - lat) + Math.Abs(-0.04472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.00155 - lat) + Math.Abs(-2.94978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.90608 - lat) + Math.Abs(-4.55332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.25705 - lat) + Math.Abs(-3.40126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.28333 - lat) + Math.Abs(-10.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.4822 - lat) + Math.Abs(-6.7911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.54 - lat) + Math.Abs(-9.1921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.955 - lat) + Math.Abs(-0.34861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.41769 - lat) + Math.Abs(-7.48323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.95007 - lat) + Math.Abs(-5.76024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.077 - lat) + Math.Abs(-6.8312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.0775 - lat) + Math.Abs(-3.51594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.35005 - lat) + Math.Abs(-3.61038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54773 - lat) + Math.Abs(-7.44808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.65 - lat) + Math.Abs(-8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.8065 - lat) + Math.Abs(-10.8321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.90476 - lat) + Math.Abs(-3.52649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.6597 - lat) + Math.Abs(0.5022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.11667 - lat) + Math.Abs(1.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.95944 - lat) + Math.Abs(3.14111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45059 - lat) + Math.Abs(2.48795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.38944 - lat) + Math.Abs(-5.24528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91667 - lat) + Math.Abs(-8.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Youwarou", "04", 15.3684, -4.2628);
case 1: return new CityInfo("Yorosso", "06", 12.35811, -4.77688);
case 2: return new CityInfo("Yélimané", "03", 15.11868, -10.57729);
case 3: return new CityInfo("Yanfolila", "06", 11.18333, -8.15);
case 4: return new CityInfo("Tominian", "05", 13.28737, -4.59317);
case 5: return new CityInfo("Timbuktu", "08", 16.77348, -3.00742);
case 6: return new CityInfo("Tessalit", "10", 20.20126, 1.01186);
case 7: return new CityInfo("Ténenkou", "04", 14.45722, -4.9169);
case 8: return new CityInfo("Taoudenni", "12070575", 22.67443, -3.97891);
case 9: return new CityInfo("Sokolo", "05", 14.7328, -6.1219);
case 10: return new CityInfo("Sikasso", "06", 11.31755, -5.66654);
case 11: return new CityInfo("Séguéla", "05", 14.11266, -6.72865);
case 12: return new CityInfo("Ségou", "05", 13.4317, -6.2157);
case 13: return new CityInfo("San", "05", 13.30335, -4.89562);
case 14: return new CityInfo("Sagalo", "03", 12.2, -10.7);
case 15: return new CityInfo("Ntossoni", "06", 12.5304, -5.77003);
case 16: return new CityInfo("Nioro", "03", 15.22932, -9.59277);
case 17: return new CityInfo("Niono", "05", 14.2526, -5.993);
case 18: return new CityInfo("Niafunké", "08", 15.9322, -3.9906);
case 19: return new CityInfo("Nara", "07", 15.16875, -7.28466);
case 20: return new CityInfo("Mopti", "04", 14.4843, -4.18296);
case 21: return new CityInfo("Ménaka", "12070577", 15.9182, 2.4022);
case 22: return new CityInfo("Markala", "05", 13.7021, -6.0659);
case 23: return new CityInfo("Koutiala", "06", 12.39173, -5.46421);
case 24: return new CityInfo("Koulikoro", "07", 12.86273, -7.55985);
case 25: return new CityInfo("Koro", "04", 14.064, -3.07539);
case 26: return new CityInfo("Kolondiéba", "06", 11.08943, -6.8929);
case 27: return new CityInfo("Kolokani", "07", 13.5728, -8.0339);
case 28: return new CityInfo("Kokofata", "03", 12.88333, -9.95);
case 29: return new CityInfo("Kita", "03", 13.0349, -9.4895);
case 30: return new CityInfo("Kidal", "10", 18.44111, 1.40778);
case 31: return new CityInfo("Kinmparana", "05", 12.84217, -4.9245);
case 32: return new CityInfo("Ké-Macina", "05", 13.9641, -5.35791);
case 33: return new CityInfo("Kayes", "03", 14.44693, -11.44448);
case 34: return new CityInfo("Kati", "07", 12.74409, -8.07257);
case 35: return new CityInfo("Kangaba", "07", 11.93333, -8.41667);
case 36: return new CityInfo("Kadiolo", "06", 10.55, -5.76667);
case 37: return new CityInfo("Gourma Rharous", "08", 16.87778, -1.92306);
case 38: return new CityInfo("Goundam", "08", 16.41453, -3.67075);
case 39: return new CityInfo("Gao", "09", 16.27167, -0.04472);
case 40: return new CityInfo("Douentza", "04", 15.00155, -2.94978);
case 41: return new CityInfo("Djénné", "04", 13.90608, -4.55332);
case 42: return new CityInfo("Diré", "08", 16.25705, -3.40126);
case 43: return new CityInfo("Diré", "08", 12.28333, -10.96667);
case 44: return new CityInfo("Dioila", "07", 12.4822, -6.7911);
case 45: return new CityInfo("Diéma", "03", 14.54, -9.1921);
case 46: return new CityInfo("Bourem", "09", 16.955, -0.34861);
case 47: return new CityInfo("Bougouni", "06", 11.41769, -7.48323);
case 48: return new CityInfo("Bla", "05", 12.95007, -5.76024);
case 49: return new CityInfo("Barouéli", "05", 13.077, -6.8312);
case 50: return new CityInfo("Bankass", "04", 14.0775, -3.51594);
case 51: return new CityInfo("Bandiagara", "04", 14.35005, -3.61038);
case 52: return new CityInfo("Banamba", "07", 13.54773, -7.44808);
case 53: return new CityInfo("Bamako", "01", 12.65, -8);
case 54: return new CityInfo("Bafoulabé", "03", 13.8065, -10.8321);
case 55: return new CityInfo("Araouane", "08", 18.90476, -3.52649);
case 56: return new CityInfo("Ansongo", "09", 15.6597, 0.5022);
case 57: return new CityInfo("Abeïbara", "10", 19.11667, 1.75);
case 58: return new CityInfo("Inékar", "09", 15.95944, 3.14111);
case 59: return new CityInfo("Ti-n-Essako", "10", 18.45059, 2.48795);
case 60: return new CityInfo("Leleni", "06", 12.38944, -5.24528);
default: return new CityInfo("Figuira-Toma", "01", 11.91667, -8.36667);

                                    }                                        
                                }
                            
                        }
                    }
                