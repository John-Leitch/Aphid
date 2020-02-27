
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
                                    public const string Country = "BQ";
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
                            
                                        var cur = (Math.Abs(17.643 - lat) + Math.Abs(-63.22649 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(17.6259 - lat) + Math.Abs(-63.24919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.48303 - lat) + Math.Abs(-62.9864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.15 - lat) + Math.Abs(-68.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.48333 - lat) + Math.Abs(-62.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.13333 - lat) + Math.Abs(-68.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.23333 - lat) + Math.Abs(-68.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.16667 - lat) + Math.Abs(-68.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Upper Hell's Gate", "SB", 17.643, -63.22649);
case 1: return new CityInfo("The Bottom", "SB", 17.6259, -63.24919);
case 2: return new CityInfo("Oranjestad", "SE", 17.48303, -62.9864);
case 3: return new CityInfo("Kralendijk", "BO", 12.15, -68.26667);
case 4: return new CityInfo("Golden Rock", "SE", 17.48333, -62.98333);
case 5: return new CityInfo("Dorp Tera Kora", "BO", 12.13333, -68.26667);
case 6: return new CityInfo("Dorp Rincón", "BO", 12.23333, -68.33333);
default: return new CityInfo("Dorp Antriol", "BO", 12.16667, -68.26667);

                                    }                                        
                                }
                            
                        }
                    }
                