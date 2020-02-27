
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
                                    public const string Country = "GW";
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
                            
                                        var cur = (Math.Abs(11.88694 - lat) + Math.Abs(-15.85556 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(11.33333 - lat) + Math.Abs(-14.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66286 - lat) + Math.Abs(-14.15427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.32344 - lat) + Math.Abs(-13.95343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.07333 - lat) + Math.Abs(-15.31889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.28 - lat) + Math.Abs(-14.22222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77665 - lat) + Math.Abs(-15.17177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.48389 - lat) + Math.Abs(-15.22167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.2825 - lat) + Math.Abs(-15.25472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.06722 - lat) + Math.Abs(-16.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.27444 - lat) + Math.Abs(-16.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.28333 - lat) + Math.Abs(-15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.58889 - lat) + Math.Abs(-14.99583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.57694 - lat) + Math.Abs(-15.47611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.22306 - lat) + Math.Abs(-15.4475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.86357 - lat) + Math.Abs(-15.59767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.16583 - lat) + Math.Abs(-14.66167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Quinhámel", "12", 11.88694, -15.85556);
case 1: return new CityInfo("Quebo", "07", 11.33333, -14.93333);
case 2: return new CityInfo("Pirada", "10", 12.66286, -14.15427);
case 3: return new CityInfo("Pitche", "10", 12.32344, -13.95343);
case 4: return new CityInfo("Mansôa", "04", 12.07333, -15.31889);
case 5: return new CityInfo("Gabú", "10", 12.28, -14.22222);
case 6: return new CityInfo("Fulacunda", "02", 11.77665, -15.17177);
case 7: return new CityInfo("Farim", "04", 12.48389, -15.22167);
case 8: return new CityInfo("Catió", "07", 11.2825, -15.25472);
case 9: return new CityInfo("Canchungo", "06", 12.06722, -16.03333);
case 10: return new CityInfo("Cacheu", "06", 12.27444, -16.16528);
case 11: return new CityInfo("Bubaque", "05", 11.28333, -15.83333);
case 12: return new CityInfo("Buba", "02", 11.58889, -14.99583);
case 13: return new CityInfo("Bolama", "05", 11.57694, -15.47611);
case 14: return new CityInfo("Bissorã", "04", 12.22306, -15.4475);
case 15: return new CityInfo("Bissau", "11", 11.86357, -15.59767);
default: return new CityInfo("Bafatá", "01", 12.16583, -14.66167);

                                    }                                        
                                }
                            
                        }
                    }
                