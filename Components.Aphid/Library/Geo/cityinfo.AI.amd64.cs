
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
                                    public const string Country = "AI";
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
                            
                                        var cur = (Math.Abs(18.17191 - lat) + Math.Abs(-63.14941 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.21704 - lat) + Math.Abs(-63.05783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20799 - lat) + Math.Abs(-63.04178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.215 - lat) + Math.Abs(-63.02238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.22026 - lat) + Math.Abs(-63.04607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.19201 - lat) + Math.Abs(-63.08779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20118 - lat) + Math.Abs(-63.08998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.22919 - lat) + Math.Abs(-63.04401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20542 - lat) + Math.Abs(-63.07847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.25601 - lat) + Math.Abs(-63.0102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.19939 - lat) + Math.Abs(-63.0665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23333 - lat) + Math.Abs(-63 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17648 - lat) + Math.Abs(-63.09375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.22104 - lat) + Math.Abs(-63.01329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("West End Village", "11205437", 18.17191, -63.14941);
case 1: return new CityInfo("The Valley", "11205396", 18.21704, -63.05783);
case 2: return new CityInfo("The Quarter", "11205439", 18.20799, -63.04178);
case 3: return new CityInfo("Farrington", "11205444", 18.215, -63.02238);
case 4: return new CityInfo("Stoney Ground", "11205443", 18.22026, -63.04607);
case 5: return new CityInfo("South Hill Village", "11205438", 18.19201, -63.08779);
case 6: return new CityInfo("Sandy Ground Village", "11205392", 18.20118, -63.08998);
case 7: return new CityInfo("North Side", "11205440", 18.22919, -63.04401);
case 8: return new CityInfo("North Hill Village", "11205436", 18.20542, -63.07847);
case 9: return new CityInfo("Island Harbour", "11205441", 18.25601, -63.0102);
case 10: return new CityInfo("George Hill", "11205442", 18.19939, -63.0665);
case 11: return new CityInfo("East End Village", "11205433", 18.23333, -63);
case 12: return new CityInfo("Blowing Point Village", "11205389", 18.17648, -63.09375);
default: return new CityInfo("Sandy Hill", "11205393", 18.22104, -63.01329);

                                    }                                        
                                }
                            
                        }
                    }
                