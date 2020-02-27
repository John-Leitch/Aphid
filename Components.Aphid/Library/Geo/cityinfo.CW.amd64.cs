
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
                                    public const string Country = "CW";
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
                            
                                        var cur = (Math.Abs(12.1084 - lat) + Math.Abs(-68.93354 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(12.15 - lat) + Math.Abs(-68.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.37047 - lat) + Math.Abs(-69.15405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.27749 - lat) + Math.Abs(-69.1125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.29014 - lat) + Math.Abs(-69.07389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Willemstad", "", 12.1084, -68.93354);
case 1: return new CityInfo("Sint Michiel Liber", "00", 12.15, -68.98333);
case 2: return new CityInfo("Sabana Westpunt", "00", 12.37047, -69.15405);
case 3: return new CityInfo("Dorp Soto", "00", 12.27749, -69.1125);
default: return new CityInfo("Barber", "00", 12.29014, -69.07389);

                                    }                                        
                                }
                            
                        }
                    }
                