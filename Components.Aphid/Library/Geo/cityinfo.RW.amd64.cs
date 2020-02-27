
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
                                    public const string Country = "RW";
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
                            
                                        var cur = (Math.Abs(-1.9487 - lat) + Math.Abs(30.4347 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-1.49984 - lat) + Math.Abs(29.63497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.479 - lat) + Math.Abs(29.5564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.94995 - lat) + Math.Abs(30.05885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.06028 - lat) + Math.Abs(29.34778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.1597 - lat) + Math.Abs(30.5427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.07444 - lat) + Math.Abs(29.75667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.46397 - lat) + Math.Abs(29.57389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.4846 - lat) + Math.Abs(28.9075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.70278 - lat) + Math.Abs(29.25639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.5763 - lat) + Math.Abs(30.0675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.59667 - lat) + Math.Abs(29.73944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.35187 - lat) + Math.Abs(29.75089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.93653 - lat) + Math.Abs(29.8061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Rwamagana", "11", -1.9487, 30.4347);
case 1: return new CityInfo("Musanze", "13", -1.49984, 29.63497);
case 2: return new CityInfo("Nzega", "15", -2.479, 29.5564);
case 3: return new CityInfo("Kigali", "12", -1.94995, 30.05885);
case 4: return new CityInfo("Kibuye", "14", -2.06028, 29.34778);
case 5: return new CityInfo("Kibungo", "11", -2.1597, 30.5427);
case 6: return new CityInfo("Gitarama", "15", -2.07444, 29.75667);
case 7: return new CityInfo("Gikongoro", "15", -2.46397, 29.57389);
case 8: return new CityInfo("Cyangugu", "14", -2.4846, 28.9075);
case 9: return new CityInfo("Gisenyi", "14", -1.70278, 29.25639);
case 10: return new CityInfo("Byumba", "13", -1.5763, 30.0675);
case 11: return new CityInfo("Butare", "15", -2.59667, 29.73944);
case 12: return new CityInfo("Nyanza", "15", -2.35187, 29.75089);
default: return new CityInfo("Eglise Catholique, Centrale GIKO", "15", -1.93653, 29.8061);

                                    }                                        
                                }
                            
                        }
                    }
                