
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
                                    public const string Country = "BI";
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
                            
                                        var cur = (Math.Abs(-4.1348 - lat) + Math.Abs(29.804 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-3.94877 - lat) + Math.Abs(29.62438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.9736 - lat) + Math.Abs(29.4386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.5086 - lat) + Math.Abs(29.469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.51128 - lat) + Math.Abs(29.70334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.2617 - lat) + Math.Abs(29.4206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.3489 - lat) + Math.Abs(29.4839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.38193 - lat) + Math.Abs(29.36142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.2682 - lat) + Math.Abs(29.6079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.42708 - lat) + Math.Abs(29.92463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.47639 - lat) + Math.Abs(30.24861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.2186 - lat) + Math.Abs(30.5528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.10139 - lat) + Math.Abs(30.16278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.0804 - lat) + Math.Abs(29.391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.8869 - lat) + Math.Abs(29.1248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.9663 - lat) + Math.Abs(29.1944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.9075 - lat) + Math.Abs(29.8306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.9221 - lat) + Math.Abs(29.6293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.8451 - lat) + Math.Abs(30.3414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.5845 - lat) + Math.Abs(30.0959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.9279 - lat) + Math.Abs(29.992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Makamba", "17", -4.1348, 29.804);
case 1: return new CityInfo("Bururi", "10", -3.94877, 29.62438);
case 2: return new CityInfo("Rumonge", "26", -3.9736, 29.4386);
case 3: return new CityInfo("Manga", "25", -3.5086, 29.469);
case 4: return new CityInfo("Mwaro", "23", -3.51128, 29.70334);
case 5: return new CityInfo("Muzinda", "09", -3.2617, 29.4206);
case 6: return new CityInfo("Isale", "25", -3.3489, 29.4839);
case 7: return new CityInfo("Bujumbura", "24", -3.38193, 29.36142);
case 8: return new CityInfo("Muramvya", "22", -3.2682, 29.6079);
case 9: return new CityInfo("Gitega", "13", -3.42708, 29.92463);
case 10: return new CityInfo("Ruyigi", "21", -3.47639, 30.24861);
case 11: return new CityInfo("Cankuzo", "11", -3.2186, 30.5528);
case 12: return new CityInfo("Karuzi", "14", -3.10139, 30.16278);
case 13: return new CityInfo("Bubanza", "09", -3.0804, 29.391);
case 14: return new CityInfo("Cibitoke", "12", -2.8869, 29.1248);
case 15: return new CityInfo("Buganda", "12", -2.9663, 29.1944);
case 16: return new CityInfo("Ngozi", "19", -2.9075, 29.8306);
case 17: return new CityInfo("Kayanza", "15", -2.9221, 29.6293);
case 18: return new CityInfo("Muyinga", "18", -2.8451, 30.3414);
case 19: return new CityInfo("Kirundo", "16", -2.5845, 30.0959);
default: return new CityInfo("Rutana", "20", -3.9279, 29.992);

                                    }                                        
                                }
                            
                        }
                    }
                