
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
                                    public const string Country = "TL";
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
                            
                                        var cur = (Math.Abs(-8.8575 - lat) + Math.Abs(126.36472 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-9.31286 - lat) + Math.Abs(125.25648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.00417 - lat) + Math.Abs(125.64861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.2 - lat) + Math.Abs(124.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.53007 - lat) + Math.Abs(125.74163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.61194 - lat) + Math.Abs(125.20611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.51139 - lat) + Math.Abs(126.01306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.99167 - lat) + Math.Abs(125.21972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.5875 - lat) + Math.Abs(125.34194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.55861 - lat) + Math.Abs(125.57361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.47572 - lat) + Math.Abs(126.45633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.99241 - lat) + Math.Abs(125.50816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.72806 - lat) + Math.Abs(125.56639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.52167 - lat) + Math.Abs(126.99833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.72389 - lat) + Math.Abs(125.43611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.64306 - lat) + Math.Abs(126.37833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Viqueque", "VI", -8.8575, 126.36472);
case 1: return new CityInfo("Suai", "CO", -9.31286, 125.25648);
case 2: return new CityInfo("Same", "MF", -9.00417, 125.64861);
case 3: return new CityInfo("Pante Makasar", "OE", -9.2, 124.38333);
case 4: return new CityInfo("Metinaro", "DI", -8.53007, 125.74163);
case 5: return new CityInfo("Maubara", "LI", -8.61194, 125.20611);
case 6: return new CityInfo("Manatutu", "MT", -8.51139, 126.01306);
case 7: return new CityInfo("Maliana", "BO", -8.99167, 125.21972);
case 8: return new CityInfo("Likisá", "LI", -8.5875, 125.34194);
case 9: return new CityInfo("Dili", "DI", -8.55861, 125.57361);
case 10: return new CityInfo("Baukau", "BA", -8.47572, 126.45633);
case 11: return new CityInfo("Ainaro", "AN", -8.99241, 125.50816);
case 12: return new CityInfo("Aileu", "AL", -8.72806, 125.56639);
case 13: return new CityInfo("Lospalos", "LA", -8.52167, 126.99833);
case 14: return new CityInfo("Gleno", "ER", -8.72389, 125.43611);
default: return new CityInfo("Venilale", "BA", -8.64306, 126.37833);

                                    }                                        
                                }
                            
                        }
                    }
                