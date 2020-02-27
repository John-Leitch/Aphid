
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
                                    public const string Country = "SX";
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
                            
                                        var cur = (Math.Abs(18.03783 - lat) + Math.Abs(-63.11852 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.026 - lat) + Math.Abs(-63.04582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04987 - lat) + Math.Abs(-63.03789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04852 - lat) + Math.Abs(-63.06513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04048 - lat) + Math.Abs(-63.08397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Simson Bay Village", "00", 18.03783, -63.11852);
case 1: return new CityInfo("Philipsburg", "", 18.026, -63.04582);
case 2: return new CityInfo("Lower Prince’s Quarter", "00", 18.04987, -63.03789);
case 3: return new CityInfo("Cul de Sac", "00", 18.04852, -63.06513);
default: return new CityInfo("Koolbaai", "00", 18.04048, -63.08397);

                                    }                                        
                                }
                            
                        }
                    }
                