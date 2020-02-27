
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
                                    public const string Country = "MS";
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
                            
                                        var cur = (Math.Abs(16.75095 - lat) + Math.Abs(-62.22175 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(16.7727 - lat) + Math.Abs(-62.21729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.78215 - lat) + Math.Abs(-62.19103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.70555 - lat) + Math.Abs(-62.21292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.73048 - lat) + Math.Abs(-62.21568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.79183 - lat) + Math.Abs(-62.21058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Salem", "03", 16.75095, -62.22175);
case 1: return new CityInfo("Saint Peters", "03", 16.7727, -62.21729);
case 2: return new CityInfo("Saint John's Village", "03", 16.78215, -62.19103);
case 3: return new CityInfo("Plymouth", "01", 16.70555, -62.21292);
case 4: return new CityInfo("Cork Hill", "01", 16.73048, -62.21568);
default: return new CityInfo("Brades", "03", 16.79183, -62.21058);

                                    }                                        
                                }
                            
                        }
                    }
                