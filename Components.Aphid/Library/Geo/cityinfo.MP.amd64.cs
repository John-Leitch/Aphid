
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
                                    public const string Country = "MP";
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
                            
                                        var cur = (Math.Abs(14.96823 - lat) + Math.Abs(145.61998 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(15.21233 - lat) + Math.Abs(145.7545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("San Jose Village", "120", 14.96823, 145.61998);
default: return new CityInfo("Saipan", "110", 15.21233, 145.7545);

                                    }                                        
                                }
                            
                        }
                    }
                