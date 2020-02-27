
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
                                    public const string Country = "GF";
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
                            
                                        var cur = (Math.Abs(5.01171 - lat) + Math.Abs(-52.47241 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(5.37676 - lat) + Math.Abs(-52.95679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.50153 - lat) + Math.Abs(-54.02916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.88857 - lat) + Math.Abs(-51.80243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.72874 - lat) + Math.Abs(-52.32495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.88585 - lat) + Math.Abs(-52.27857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.313 - lat) + Math.Abs(-52.13083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91667 - lat) + Math.Abs(-52.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.84921 - lat) + Math.Abs(-52.32355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.64155 - lat) + Math.Abs(-54.03167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.66906 - lat) + Math.Abs(-53.77897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91216 - lat) + Math.Abs(-52.37432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.16281 - lat) + Math.Abs(-52.64265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.47952 - lat) + Math.Abs(-53.20524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.27295 - lat) + Math.Abs(-54.38146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.93333 - lat) + Math.Abs(-52.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.16887 - lat) + Math.Abs(-52.33525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.15526 - lat) + Math.Abs(-54.34311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tonate", "GF", 5.01171, -52.47241);
case 1: return new CityInfo("Sinnamary", "GF", 5.37676, -52.95679);
case 2: return new CityInfo("Saint-Laurent-du-Maroni", "GF", 5.50153, -54.02916);
case 3: return new CityInfo("Saint-Georges", "GF", 3.88857, -51.80243);
case 4: return new CityInfo("Roura", "GF", 4.72874, -52.32495);
case 5: return new CityInfo("Rémire", "GF", 4.88585, -52.27857);
case 6: return new CityInfo("Régina", "GF", 4.313, -52.13083);
case 7: return new CityInfo("Rémire-Montjoly", "GF", 4.91667, -52.26667);
case 8: return new CityInfo("Matoury", "GF", 4.84921, -52.32355);
case 9: return new CityInfo("Maripasoula", "GF", 3.64155, -54.03167);
case 10: return new CityInfo("Mana", "GF", 5.66906, -53.77897);
case 11: return new CityInfo("Macouria", "GF", 4.91216, -52.37432);
case 12: return new CityInfo("Kourou", "GF", 5.16281, -52.64265);
case 13: return new CityInfo("Iracoubo", "GF", 5.47952, -53.20524);
case 14: return new CityInfo("Grand-Santi", "GF", 4.27295, -54.38146);
case 15: return new CityInfo("Cayenne", "GF", 4.93333, -52.33333);
case 16: return new CityInfo("Camopi", "GF", 3.16887, -52.33525);
default: return new CityInfo("Apatou", "GF", 5.15526, -54.34311);

                                    }                                        
                                }
                            
                        }
                    }
                