
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
                                    public const string Country = "KN";
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
                            
                                        var cur = (Math.Abs(17.30037 - lat) + Math.Abs(-62.77584 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(17.35908 - lat) + Math.Abs(-62.84858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.40605 - lat) + Math.Abs(-62.83562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.40454 - lat) + Math.Abs(-62.79296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.37956 - lat) + Math.Abs(-62.75318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.2 - lat) + Math.Abs(-62.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.32327 - lat) + Math.Abs(-62.72914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.3259 - lat) + Math.Abs(-62.81055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.13218 - lat) + Math.Abs(-62.57267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.38271 - lat) + Math.Abs(-62.75747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.12623 - lat) + Math.Abs(-62.60265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.41473 - lat) + Math.Abs(-62.8139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.16667 - lat) + Math.Abs(-62.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.13333 - lat) + Math.Abs(-62.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.35 - lat) + Math.Abs(-62.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.29779 - lat) + Math.Abs(-62.77021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.2955 - lat) + Math.Abs(-62.72499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Trinity", "15", 17.30037, -62.77584);
case 1: return new CityInfo("Sandy Point Town", "02", 17.35908, -62.84858);
case 2: return new CityInfo("Saint Paul’s", "09", 17.40605, -62.83562);
case 3: return new CityInfo("Sadlers", "06", 17.40454, -62.79296);
case 4: return new CityInfo("Nicola Town", "01", 17.37956, -62.75318);
case 5: return new CityInfo("Newcastle", "05", 17.2, -62.58333);
case 6: return new CityInfo("Monkey Hill", "11", 17.32327, -62.72914);
case 7: return new CityInfo("Middle Island", "13", 17.3259, -62.81055);
case 8: return new CityInfo("Market Shop", "04", 17.13218, -62.57267);
case 9: return new CityInfo("Mansion", "01", 17.38271, -62.75747);
case 10: return new CityInfo("Fig Tree", "07", 17.12623, -62.60265);
case 11: return new CityInfo("Dieppe Bay Town", "06", 17.41473, -62.8139);
case 12: return new CityInfo("Cotton Ground", "12", 17.16667, -62.61667);
case 13: return new CityInfo("Charlestown", "10", 17.13333, -62.61667);
case 14: return new CityInfo("Cayon", "08", 17.35, -62.73333);
case 15: return new CityInfo("Boyd’s", "15", 17.29779, -62.77021);
default: return new CityInfo("Basseterre", "03", 17.2955, -62.72499);

                                    }                                        
                                }
                            
                        }
                    }
                