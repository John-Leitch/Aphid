
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
                                    public const string Country = "TC";
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
                            
                                        var cur = (Math.Abs(21.46122 - lat) + Math.Abs(-71.14188 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(21.49293 - lat) + Math.Abs(-71.53304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Cockburn Town", "00", 21.46122, -71.14188);
default: return new CityInfo("Cockburn Harbour", "00", 21.49293, -71.53304);

                                    }                                        
                                }
                            
                        }
                    }
                