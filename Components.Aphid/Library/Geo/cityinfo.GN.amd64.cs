
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
                                    public const string Country = "GN";
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
                            
                                        var cur = (Math.Abs(12.5311 - lat) + Math.Abs(-13.1224 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(7.56748 - lat) + Math.Abs(-9.26283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.44503 - lat) + Math.Abs(-11.66422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.36667 - lat) + Math.Abs(-13.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.65 - lat) + Math.Abs(-9.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.9 - lat) + Math.Abs(-13.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.42282 - lat) + Math.Abs(-9.16852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7 - lat) + Math.Abs(-14.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.05915 - lat) + Math.Abs(-12.39498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75624 - lat) + Math.Abs(-8.8179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.62577 - lat) + Math.Abs(-8.69413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.37546 - lat) + Math.Abs(-12.09148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.079 - lat) + Math.Abs(-12.2982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54351 - lat) + Math.Abs(-9.47099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8 - lat) + Math.Abs(-8.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.31823 - lat) + Math.Abs(-12.28332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.65 - lat) + Math.Abs(-9.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.48333 - lat) + Math.Abs(-13.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.58632 - lat) + Math.Abs(-11.89485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.1848 - lat) + Math.Abs(-10.09987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.05692 - lat) + Math.Abs(-12.86576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4 - lat) + Math.Abs(-13.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.26667 - lat) + Math.Abs(-9.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.38542 - lat) + Math.Abs(-9.30568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56744 - lat) + Math.Abs(-10.1336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.75 - lat) + Math.Abs(-13.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.36676 - lat) + Math.Abs(-13.58253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43056 - lat) + Math.Abs(-13.08806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.04036 - lat) + Math.Abs(-10.74343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.79111 - lat) + Math.Abs(-13.52333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.29062 - lat) + Math.Abs(-10.7121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.69249 - lat) + Math.Abs(-12.24967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7433 - lat) + Math.Abs(-11.10778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.70643 - lat) + Math.Abs(-13.38465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.53795 - lat) + Math.Abs(-13.67729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.535 - lat) + Math.Abs(-13.68778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.93217 - lat) + Math.Abs(-14.29055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16667 - lat) + Math.Abs(-14.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69011 - lat) + Math.Abs(-8.64869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.42383 - lat) + Math.Abs(-12.68183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Youkounkoun", "B", 12.5311, -13.1224);
case 1: return new CityInfo("Yomou", "N", 7.56748, -9.26283);
case 2: return new CityInfo("Tougué", "L", 11.44503, -11.66422);
case 3: return new CityInfo("Tondon", "D", 10.36667, -13.35);
case 4: return new CityInfo("Tokonou", "K", 9.65, -9.78333);
case 5: return new CityInfo("Télimélé", "D", 10.9, -13.03333);
case 6: return new CityInfo("Siguiri", "K", 11.42282, -9.16852);
case 7: return new CityInfo("Sanguéya", "B", 10.7, -14.36667);
case 8: return new CityInfo("Pita", "M", 11.05915, -12.39498);
case 9: return new CityInfo("Nzérékoré", "N", 7.75624, -8.8179);
case 10: return new CityInfo("Mandiana", "K", 10.62577, -8.69413);
case 11: return new CityInfo("Mamou", "M", 10.37546, -12.09148);
case 12: return new CityInfo("Mali", "L", 12.079, -12.2982);
case 13: return new CityInfo("Macenta", "N", 8.54351, -9.47099);
case 14: return new CityInfo("Lola", "N", 7.8, -8.53333);
case 15: return new CityInfo("Labé", "L", 11.31823, -12.28332);
case 16: return new CityInfo("Kouroussa", "K", 10.65, -9.88333);
case 17: return new CityInfo("Koundara", "B", 12.48333, -13.3);
case 18: return new CityInfo("Koubia", "L", 11.58632, -11.89485);
case 19: return new CityInfo("Kissidougou", "F", 9.1848, -10.09987);
case 20: return new CityInfo("Kindia", "D", 10.05692, -12.86576);
case 21: return new CityInfo("Kimbo", "B", 10.4, -13.55);
case 22: return new CityInfo("Kérouané", "K", 9.26667, -9.01667);
case 23: return new CityInfo("Kankan", "K", 10.38542, -9.30568);
case 24: return new CityInfo("Gueckedou", "N", 8.56744, -10.1336);
case 25: return new CityInfo("Gaoual", "B", 11.75, -13.2);
case 26: return new CityInfo("Fria", "B", 10.36676, -13.58253);
case 27: return new CityInfo("Forécariah", "D", 9.43056, -13.08806);
case 28: return new CityInfo("Faranah", "F", 10.04036, -10.74343);
case 29: return new CityInfo("Dubréka", "D", 9.79111, -13.52333);
case 30: return new CityInfo("Dinguiraye", "F", 11.29062, -10.7121);
case 31: return new CityInfo("Dalaba", "M", 10.69249, -12.24967);
case 32: return new CityInfo("Dabola", "F", 10.7433, -11.10778);
case 33: return new CityInfo("Coyah", "D", 9.70643, -13.38465);
case 34: return new CityInfo("Conakry", "04", 9.53795, -13.67729);
case 35: return new CityInfo("Camayenne", "04", 9.535, -13.68778);
case 36: return new CityInfo("Boké", "B", 10.93217, -14.29055);
case 37: return new CityInfo("Boffa", "B", 10.16667, -14.03333);
case 38: return new CityInfo("Beyla", "N", 8.69011, -8.64869);
default: return new CityInfo("Lélouma", "L", 11.42383, -12.68183);

                                    }                                        
                                }
                            
                        }
                    }
                