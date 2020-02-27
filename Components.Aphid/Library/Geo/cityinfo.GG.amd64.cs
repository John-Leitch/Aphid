
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
                                    public const string Country = "GG";
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
                            
                                        var cur = (Math.Abs(49.43333 - lat) + Math.Abs(-2.65 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(49.48389 - lat) + Math.Abs(-2.52333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45981 - lat) + Math.Abs(-2.53527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71549 - lat) + Math.Abs(-2.20757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45694 - lat) + Math.Abs(-2.63583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.46757 - lat) + Math.Abs(-2.60015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.44389 - lat) + Math.Abs(-2.58018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43331 - lat) + Math.Abs(-2.35622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43713 - lat) + Math.Abs(-2.55479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Torteval", "6417214", 49.43333, -2.65);
case 1: return new CityInfo("Saint Sampson", "6417233", 49.48389, -2.52333);
case 2: return new CityInfo("Saint Peter Port", "6417228", 49.45981, -2.53527);
case 3: return new CityInfo("St Anne", "8989934", 49.71549, -2.20757);
case 4: return new CityInfo("Saint Saviour", "6417215", 49.45694, -2.63583);
case 5: return new CityInfo("Castel", "6417229", 49.46757, -2.60015);
case 6: return new CityInfo("Saint Andrew", "6417226", 49.44389, -2.58018);
case 7: return new CityInfo("Sark", "00", 49.43331, -2.35622);
default: return new CityInfo("St Martin", "6417224", 49.43713, -2.55479);

                                    }                                        
                                }
                            
                        }
                    }
                