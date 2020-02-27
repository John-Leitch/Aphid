
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
                                    public const string Country = "AW";
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
                            
                                        var cur = (Math.Abs(12.53914 - lat) + Math.Abs(-70.02004 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(12.43624 - lat) + Math.Abs(-69.90713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.50953 - lat) + Math.Abs(-69.98094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.45026 - lat) + Math.Abs(-69.93811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.5351 - lat) + Math.Abs(-70.00688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.52398 - lat) + Math.Abs(-70.02703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tanki Leendert", "00", 12.53914, -70.02004);
case 1: return new CityInfo("San Nicolas", "00", 12.43624, -69.90713);
case 2: return new CityInfo("Santa Cruz", "00", 12.50953, -69.98094);
case 3: return new CityInfo("Savaneta", "00", 12.45026, -69.93811);
case 4: return new CityInfo("Paradera", "00", 12.5351, -70.00688);
default: return new CityInfo("Oranjestad", "00", 12.52398, -70.02703);

                                    }                                        
                                }
                            
                        }
                    }
                