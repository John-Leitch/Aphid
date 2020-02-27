
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
                                    public const string Country = "BM";
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
                            
                                        var cur = (Math.Abs(32.38167 - lat) + Math.Abs(-64.67806 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(32.2949 - lat) + Math.Abs(-64.78303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Saint George", "06", 32.38167, -64.67806);
default: return new CityInfo("Hamilton", "03", 32.2949, -64.78303);

                                    }                                        
                                }
                            
                        }
                    }
                