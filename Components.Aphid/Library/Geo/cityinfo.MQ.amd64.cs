
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
                                    public const string Country = "MQ";
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
                            
                                        var cur = (Math.Abs(14.61774 - lat) + Math.Abs(-61.099 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(14.74309 - lat) + Math.Abs(-61.17541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.67099 - lat) + Math.Abs(-61.03905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78352 - lat) + Math.Abs(-60.99227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.46848 - lat) + Math.Abs(-60.92138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.48738 - lat) + Math.Abs(-60.90257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.5454 - lat) + Math.Abs(-60.83831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.53912 - lat) + Math.Abs(-61.03354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55 - lat) + Math.Abs(-60.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.67751 - lat) + Math.Abs(-60.94228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7761 - lat) + Math.Abs(-61.13564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.47158 - lat) + Math.Abs(-60.86989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83257 - lat) + Math.Abs(-61.05553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61341 - lat) + Math.Abs(-60.99964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61513 - lat) + Math.Abs(-60.90311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73807 - lat) + Math.Abs(-60.96319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-61 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.60365 - lat) + Math.Abs(-61.07418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.57529 - lat) + Math.Abs(-60.97453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.86935 - lat) + Math.Abs(-61.11521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Schoelcher", "MQ", 14.61774, -61.099);
case 1: return new CityInfo("Saint-Pierre", "MQ", 14.74309, -61.17541);
case 2: return new CityInfo("Saint-Joseph", "MQ", 14.67099, -61.03905);
case 3: return new CityInfo("Sainte-Marie", "MQ", 14.78352, -60.99227);
case 4: return new CityInfo("Sainte-Luce", "MQ", 14.46848, -60.92138);
case 5: return new CityInfo("Rivière-Pilote", "MQ", 14.48738, -60.90257);
case 6: return new CityInfo("Le Vauclin", "MQ", 14.5454, -60.83831);
case 7: return new CityInfo("Les Trois-Îlets", "MQ", 14.53912, -61.03354);
case 8: return new CityInfo("Saint-Esprit", "MQ", 14.55, -60.93333);
case 9: return new CityInfo("Le Robert", "MQ", 14.67751, -60.94228);
case 10: return new CityInfo("Le Morne-Rouge", "MQ", 14.7761, -61.13564);
case 11: return new CityInfo("Le Marin", "MQ", 14.47158, -60.86989);
case 12: return new CityInfo("Le Lorrain", "MQ", 14.83257, -61.05553);
case 13: return new CityInfo("Le Lamentin", "MQ", 14.61341, -60.99964);
case 14: return new CityInfo("Le François", "MQ", 14.61513, -60.90311);
case 15: return new CityInfo("La Trinité", "MQ", 14.73807, -60.96319);
case 16: return new CityInfo("Le Gros-Morne", "MQ", 14.7, -61);
case 17: return new CityInfo("Fort-de-France", "MQ", 14.60365, -61.07418);
case 18: return new CityInfo("Ducos", "MQ", 14.57529, -60.97453);
default: return new CityInfo("Basse-Pointe", "MQ", 14.86935, -61.11521);

                                    }                                        
                                }
                            
                        }
                    }
                