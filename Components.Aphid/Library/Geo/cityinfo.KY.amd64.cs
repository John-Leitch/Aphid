
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
                                    public const string Country = "KY";
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
                            
                                        var cur = (Math.Abs(19.36667 - lat) + Math.Abs(-81.41667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(19.35 - lat) + Math.Abs(-81.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.2866 - lat) + Math.Abs(-81.37436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.3 - lat) + Math.Abs(-81.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.27647 - lat) + Math.Abs(-81.2542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.66114 - lat) + Math.Abs(-80.10984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("West Bay", "10375968", 19.36667, -81.41667);
case 1: return new CityInfo("North Side", "10375970", 19.35, -81.2);
case 2: return new CityInfo("George Town", "10346796", 19.2866, -81.37436);
case 3: return new CityInfo("East End", "10375971", 19.3, -81.11667);
case 4: return new CityInfo("Bodden Town", "10375969", 19.27647, -81.2542);
default: return new CityInfo("Little Cayman", "10375972", 19.66114, -80.10984);

                                    }                                        
                                }
                            
                        }
                    }
                