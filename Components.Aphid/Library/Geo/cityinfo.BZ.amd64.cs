
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
                                    public const string Country = "BZ";
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
                            
                                        var cur = (Math.Abs(17.89382 - lat) + Math.Abs(-88.65452 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(17.91598 - lat) + Math.Abs(-87.9659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.1588 - lat) + Math.Abs(-89.0696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.09835 - lat) + Math.Abs(-88.8097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.51419 - lat) + Math.Abs(-88.36647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08124 - lat) + Math.Abs(-88.56328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.9697 - lat) + Math.Abs(-88.23313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39375 - lat) + Math.Abs(-88.38849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.075 - lat) + Math.Abs(-89.13917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.25 - lat) + Math.Abs(-88.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.49952 - lat) + Math.Abs(-88.19756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.33472 - lat) + Math.Abs(-88.83472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Shipyard", "04", 17.89382, -88.65452);
case 1: return new CityInfo("San Pedro", "01", 17.91598, -87.9659);
case 2: return new CityInfo("San Ignacio", "02", 17.1588, -89.0696);
case 3: return new CityInfo("Punta Gorda", "06", 16.09835, -88.8097);
case 4: return new CityInfo("Placencia", "05", 16.51419, -88.36647);
case 5: return new CityInfo("Orange Walk", "04", 18.08124, -88.56328);
case 6: return new CityInfo("Dangriga", "05", 16.9697, -88.23313);
case 7: return new CityInfo("Corozal", "03", 18.39375, -88.38849);
case 8: return new CityInfo("Benque Viejo el Carmen", "02", 17.075, -89.13917);
case 9: return new CityInfo("Belmopan", "02", 17.25, -88.76667);
case 10: return new CityInfo("Belize City", "01", 17.49952, -88.19756);
default: return new CityInfo("Valley of Peace", "02", 17.33472, -88.83472);

                                    }                                        
                                }
                            
                        }
                    }
                