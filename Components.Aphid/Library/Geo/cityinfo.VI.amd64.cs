
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
                                    public const string Country = "VI";
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
                            
                                        var cur = (Math.Abs(18.3419 - lat) + Math.Abs(-64.9307 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.33134 - lat) + Math.Abs(-64.79375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.72751 - lat) + Math.Abs(-64.74698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Charlotte Amalie", "030", 18.3419, -64.9307);
case 1: return new CityInfo("Cruz Bay", "020", 18.33134, -64.79375);
default: return new CityInfo("Saint Croix", "010", 17.72751, -64.74698);

                                    }                                        
                                }
                            
                        }
                    }
                