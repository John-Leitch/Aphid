
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
                                    public const string Country = "SB";
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
                            
                                        var cur = (Math.Abs(-9.10306 - lat) + Math.Abs(160.15056 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-9.69523 - lat) + Math.Abs(159.71734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.43333 - lat) + Math.Abs(159.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.10303 - lat) + Math.Abs(156.84186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.14497 - lat) + Math.Abs(159.59212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.76778 - lat) + Math.Abs(160.69778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.725 - lat) + Math.Abs(165.79722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.45442 - lat) + Math.Abs(161.92045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.71111 - lat) + Math.Abs(156.39722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tulagi", "10", -9.10306, 160.15056);
case 1: return new CityInfo("Malango", "06", -9.69523, 159.71734);
case 2: return new CityInfo("Honiara", "14", -9.43333, 159.95);
case 3: return new CityInfo("Gizo", "11", -8.10303, 156.84186);
case 4: return new CityInfo("Buala", "07", -8.14497, 159.59212);
case 5: return new CityInfo("Auki", "03", -8.76778, 160.69778);
case 6: return new CityInfo("Lata", "09", -10.725, 165.79722);
case 7: return new CityInfo("Kirakira", "08", -10.45442, 161.92045);
default: return new CityInfo("Taro", "12", -6.71111, 156.39722);

                                    }                                        
                                }
                            
                        }
                    }
                