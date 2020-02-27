
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
                                    public const string Country = "MF";
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
                            
                                        var cur = (Math.Abs(18.06819 - lat) + Math.Abs(-63.08302 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.10476 - lat) + Math.Abs(-63.05358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Marigot", "00", 18.06819, -63.08302);
default: return new CityInfo("Grand-Case", "00", 18.10476, -63.05358);

                                    }                                        
                                }
                            
                        }
                    }
                