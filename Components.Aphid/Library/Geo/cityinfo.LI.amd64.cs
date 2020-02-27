
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
                                    public const string Country = "LI";
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
                            
                                        var cur = (Math.Abs(47.14151 - lat) + Math.Abs(9.52154 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(47.11815 - lat) + Math.Abs(9.54197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10752 - lat) + Math.Abs(9.52815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23123 - lat) + Math.Abs(9.54678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16498 - lat) + Math.Abs(9.50867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23799 - lat) + Math.Abs(9.5254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18516 - lat) + Math.Abs(9.54437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21805 - lat) + Math.Abs(9.5442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22038 - lat) + Math.Abs(9.50935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21071 - lat) + Math.Abs(9.52223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06665 - lat) + Math.Abs(9.50251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vaduz", "11", 47.14151, 9.52154);
case 1: return new CityInfo("Triesenberg", "10", 47.11815, 9.54197);
case 2: return new CityInfo("Triesen", "09", 47.10752, 9.52815);
case 3: return new CityInfo("Schellenberg", "08", 47.23123, 9.54678);
case 4: return new CityInfo("Schaan", "07", 47.16498, 9.50867);
case 5: return new CityInfo("Ruggell", "06", 47.23799, 9.5254);
case 6: return new CityInfo("Planken", "05", 47.18516, 9.54437);
case 7: return new CityInfo("Mauren", "04", 47.21805, 9.5442);
case 8: return new CityInfo("Gamprin", "03", 47.22038, 9.50935);
case 9: return new CityInfo("Eschen", "02", 47.21071, 9.52223);
default: return new CityInfo("Balzers", "01", 47.06665, 9.50251);

                                    }                                        
                                }
                            
                        }
                    }
                