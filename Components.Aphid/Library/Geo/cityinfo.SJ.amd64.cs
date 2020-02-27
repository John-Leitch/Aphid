
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
                                    public const string Country = "SJ";
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
                            
                                        var cur = (Math.Abs(78.22334 - lat) + Math.Abs(15.64689 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(78.06435 - lat) + Math.Abs(14.21169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.9221 - lat) + Math.Abs(-8.7187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Longyearbyen", "21", 78.22334, 15.64689);
case 1: return new CityInfo("Barentsburg", "21", 78.06435, 14.21169);
default: return new CityInfo("Olonkinbyen", "22", 70.9221, -8.7187);

                                    }                                        
                                }
                            
                        }
                    }
                