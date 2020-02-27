
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
                                    public const string Country = "SS";
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
                            
                                        var cur = (Math.Abs(6.5525 - lat) + Math.Abs(30.49806 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(4.09444 - lat) + Math.Abs(30.67639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.57083 - lat) + Math.Abs(28.39417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.01222 - lat) + Math.Abs(27.57081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.70111 - lat) + Math.Abs(27.98972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.17925 - lat) + Math.Abs(32.15206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.76194 - lat) + Math.Abs(27.39194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.41177 - lat) + Math.Abs(32.57046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.27389 - lat) + Math.Abs(28.6775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.44389 - lat) + Math.Abs(31.75083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.6 - lat) + Math.Abs(27.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.80619 - lat) + Math.Abs(29.67742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4675 - lat) + Math.Abs(25.67833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.79853 - lat) + Math.Abs(33.13045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61658 - lat) + Math.Abs(33.06215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3472 - lat) + Math.Abs(30.32433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91667 - lat) + Math.Abs(29.46944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.53342 - lat) + Math.Abs(31.66049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.60975 - lat) + Math.Abs(33.92621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30306 - lat) + Math.Abs(30.14056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30278 - lat) + Math.Abs(27.98 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.88889 - lat) + Math.Abs(32.10944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.77222 - lat) + Math.Abs(33.59139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.85165 - lat) + Math.Abs(31.58247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53324 - lat) + Math.Abs(28.10037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.86512 - lat) + Math.Abs(32.48212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.02667 - lat) + Math.Abs(29.24611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.20889 - lat) + Math.Abs(31.55861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.25722 - lat) + Math.Abs(29.79833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.12193 - lat) + Math.Abs(31.40904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.7431 - lat) + Math.Abs(32.8049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79111 - lat) + Math.Abs(33.00444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91542 - lat) + Math.Abs(29.98109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.13639 - lat) + Math.Abs(28.34583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yirol", "11550544", 6.5525, 30.49806);
case 1: return new CityInfo("Yei", "11550555", 4.09444, 30.67639);
case 2: return new CityInfo("Yambio", "11550566", 4.57083, 28.39417);
case 3: return new CityInfo("Winejok", "11550582", 9.01222, 27.57081);
case 4: return new CityInfo("Wau", "11550565", 7.70111, 27.98972);
case 5: return new CityInfo("Waat", "11550574", 8.17925, 32.15206);
case 6: return new CityInfo("Aweil", "11550543", 8.76194, 27.39194);
case 7: return new CityInfo("Torit", "11550567", 4.41177, 32.57046);
case 8: return new CityInfo("Tonj", "11550563", 7.27389, 28.6775);
case 9: return new CityInfo("Terekeka", "11550571", 5.44389, 31.75083);
case 10: return new CityInfo("Tambura", "11550589", 5.6, 27.46667);
case 11: return new CityInfo("Rumbek", "11550581", 6.80619, 29.67742);
case 12: return new CityInfo("Raja", "11550548", 8.4675, 25.67833);
case 13: return new CityInfo("Pibor", "11550573", 6.79853, 33.13045);
case 14: return new CityInfo("Nasir", "11550577", 8.61658, 33.06215);
case 15: return new CityInfo("Mundri", "11550552", 5.3472, 30.32433);
case 16: return new CityInfo("Maridi", "11550570", 4.91667, 29.46944);
case 17: return new CityInfo("Malakal", "11550575", 9.53342, 31.66049);
case 18: return new CityInfo("Maiwut", "9072661", 8.60975, 33.92621);
case 19: return new CityInfo("Leer", "11550579", 8.30306, 30.14056);
case 20: return new CityInfo("Kuacjok", "11550545", 8.30278, 27.98);
case 21: return new CityInfo("Kodok", "11550558", 9.88889, 32.10944);
case 22: return new CityInfo("Kapoeta", "11550596", 4.77222, 33.59139);
case 23: return new CityInfo("Juba", "11550569", 4.85165, 31.58247);
case 24: return new CityInfo("Gogrial", "11550545", 8.53324, 28.10037);
case 25: return new CityInfo("Pajok", "11550567", 3.86512, 32.48212);
case 26: return new CityInfo("Cueibet", "11550562", 7.02667, 29.24611);
case 27: return new CityInfo("Bor", "11550576", 6.20889, 31.55861);
case 28: return new CityInfo("Bentiu", "11550578", 9.25722, 29.79833);
case 29: return new CityInfo("Ayod", "11550580", 8.12193, 31.40904);
case 30: return new CityInfo("Renk", "11550588", 11.7431, 32.8049);
case 31: return new CityInfo("Akobo", "9407085", 7.79111, 33.00444);
case 32: return new CityInfo("Pariang", "367894", 9.91542, 29.98109);
default: return new CityInfo("Mayen Abun", "11550564", 9.13639, 28.34583);

                                    }                                        
                                }
                            
                        }
                    }
                