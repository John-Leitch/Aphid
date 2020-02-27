
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
                                    public const string Country = "SM";
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
                            
                                        var cur = (Math.Abs(43.96897 - lat) + Math.Abs(12.48167 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(43.93667 - lat) + Math.Abs(12.44639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90451 - lat) + Math.Abs(12.42142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90878 - lat) + Math.Abs(12.48201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.91001 - lat) + Math.Abs(12.45738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.98333 - lat) + Math.Abs(12.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.92831 - lat) + Math.Abs(12.49798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94961 - lat) + Math.Abs(12.46828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94193 - lat) + Math.Abs(12.44738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94593 - lat) + Math.Abs(12.4185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Serravalle", "09", 43.96897, 12.48167);
case 1: return new CityInfo("San Marino", "07", 43.93667, 12.44639);
case 2: return new CityInfo("Poggio di Chiesanuova", "02", 43.90451, 12.42142);
case 3: return new CityInfo("Monte Giardino", "08", 43.90878, 12.48201);
case 4: return new CityInfo("Fiorentino", "05", 43.91001, 12.45738);
case 5: return new CityInfo("Falciano", "09", 43.98333, 12.5);
case 6: return new CityInfo("Faetano", "04", 43.92831, 12.49798);
case 7: return new CityInfo("Domagnano", "03", 43.94961, 12.46828);
case 8: return new CityInfo("Borgo Maggiore", "06", 43.94193, 12.44738);
default: return new CityInfo("Acquaviva", "01", 43.94593, 12.4185);

                                    }                                        
                                }
                            
                        }
                    }
                