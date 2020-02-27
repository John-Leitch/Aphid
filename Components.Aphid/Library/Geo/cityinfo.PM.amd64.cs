
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
                                    public const string Country = "PM";
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
                            
                                        var cur = (Math.Abs(46.77914 - lat) + Math.Abs(-56.1773 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(47.0975 - lat) + Math.Abs(-56.38139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Saint-Pierre", "97502", 46.77914, -56.1773);
default: return new CityInfo("Miquelon", "97501", 47.0975, -56.38139);

                                    }                                        
                                }
                            
                        }
                    }
                