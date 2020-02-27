
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
                                    public const string Country = "MC";
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
                            
                                        var cur = (Math.Abs(43.73976 - lat) + Math.Abs(7.42732 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(43.73333 - lat) + Math.Abs(7.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.73439 - lat) + Math.Abs(7.42024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.72687 - lat) + Math.Abs(7.41766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.7489 - lat) + Math.Abs(7.43423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.73679 - lat) + Math.Abs(7.41647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Monte-Carlo", "00", 43.73976, 7.42732);
case 1: return new CityInfo("Monaco", "00", 43.73333, 7.41667);
case 2: return new CityInfo("La Condamine", "00", 43.73439, 7.42024);
case 3: return new CityInfo("Fontvieille", "00", 43.72687, 7.41766);
case 4: return new CityInfo("Saint-Roman", "00", 43.7489, 7.43423);
default: return new CityInfo("Moneghetti", "00", 43.73679, 7.41647);

                                    }                                        
                                }
                            
                        }
                    }
                