
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
                                    public const string Country = "NR";
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
                            
                                        var cur = (Math.Abs(-0.53536 - lat) + Math.Abs(166.91048 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-0.51393 - lat) + Math.Abs(166.92384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.50803 - lat) + Math.Abs(166.92945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.521 - lat) + Math.Abs(166.95813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.52792 - lat) + Math.Abs(166.95249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.50845 - lat) + Math.Abs(166.95326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.55085 - lat) + Math.Abs(166.9252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.52545 - lat) + Math.Abs(166.91247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.54098 - lat) + Math.Abs(166.91305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.54539 - lat) + Math.Abs(166.94871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yangor", "01", -0.53536, 166.91048);
case 1: return new CityInfo("Uaboe", "13", -0.51393, 166.92384);
case 2: return new CityInfo("Baiti", "05", -0.50803, 166.92945);
case 3: return new CityInfo("Ijuw", "10", -0.521, 166.95813);
case 4: return new CityInfo("Anibare", "04", -0.52792, 166.95249);
case 5: return new CityInfo("Anabar", "02", -0.50845, 166.95326);
case 6: return new CityInfo("Yaren", "14", -0.55085, 166.9252);
case 7: return new CityInfo("Arijejen", "01", -0.52545, 166.91247);
case 8: return new CityInfo("Boe", "06", -0.54098, 166.91305);
default: return new CityInfo("Menen", "11", -0.54539, 166.94871);

                                    }                                        
                                }
                            
                        }
                    }
                