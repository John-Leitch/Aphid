
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
                                    public const string Country = "TK";
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
                            
                                        var cur = (Math.Abs(-9.38516 - lat) + Math.Abs(-171.24675 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-9.20045 - lat) + Math.Abs(-171.84804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.54212 - lat) + Math.Abs(-172.51591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Fale old settlement", "F", -9.38516, -171.24675);
case 1: return new CityInfo("Nukunonu", "N", -9.20045, -171.84804);
default: return new CityInfo("Atafu Village", "A", -8.54212, -172.51591);

                                    }                                        
                                }
                            
                        }
                    }
                