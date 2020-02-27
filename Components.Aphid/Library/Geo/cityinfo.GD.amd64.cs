
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
                                    public const string Country = "GD";
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
                            
                                        var cur = (Math.Abs(12.19021 - lat) + Math.Abs(-61.70677 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(12.21833 - lat) + Math.Abs(-61.63917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05288 - lat) + Math.Abs(-61.75226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.04903 - lat) + Math.Abs(-61.66875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.48292 - lat) + Math.Abs(-61.45597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.12278 - lat) + Math.Abs(-61.62498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.16462 - lat) + Math.Abs(-61.72965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Victoria", "05", 12.19021, -61.70677);
case 1: return new CityInfo("Sauteurs", "06", 12.21833, -61.63917);
case 2: return new CityInfo("Saint George's", "03", 12.05288, -61.75226);
case 3: return new CityInfo("Saint David’s", "02", 12.04903, -61.66875);
case 4: return new CityInfo("Hillsborough", "10", 12.48292, -61.45597);
case 5: return new CityInfo("Grenville", "01", 12.12278, -61.62498);
default: return new CityInfo("Gouyave", "04", 12.16462, -61.72965);

                                    }                                        
                                }
                            
                        }
                    }
                