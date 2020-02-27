
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
                                    public const string Country = "BN";
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
                            
                                        var cur = (Math.Abs(4.80278 - lat) + Math.Abs(114.64917 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(4.60637 - lat) + Math.Abs(114.32476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.58361 - lat) + Math.Abs(114.2312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.97058 - lat) + Math.Abs(115.02078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.02447 - lat) + Math.Abs(115.04664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.70861 - lat) + Math.Abs(115.07167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.89035 - lat) + Math.Abs(114.94006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tutong", "04", 4.80278, 114.64917);
case 1: return new CityInfo("Seria", "01", 4.60637, 114.32476);
case 2: return new CityInfo("Kuala Belait", "01", 4.58361, 114.2312);
case 3: return new CityInfo("Mentiri", "02", 4.97058, 115.02078);
case 4: return new CityInfo("Kapok", "02", 5.02447, 115.04664);
case 5: return new CityInfo("Bangar", "03", 4.70861, 115.07167);
default: return new CityInfo("Bandar Seri Begawan", "02", 4.89035, 114.94006);

                                    }                                        
                                }
                            
                        }
                    }
                