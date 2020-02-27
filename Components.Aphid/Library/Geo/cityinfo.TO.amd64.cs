
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
                                    public const string Country = "TO";
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
                            
                                        var cur = (Math.Abs(-21.19292 - lat) + Math.Abs(-175.17678 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-19.81468 - lat) + Math.Abs(-174.35423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.33333 - lat) + Math.Abs(-174.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13938 - lat) + Math.Abs(-175.2018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.6506 - lat) + Math.Abs(-173.98404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.17735 - lat) + Math.Abs(-175.1172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13333 - lat) + Math.Abs(-175.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.9544 - lat) + Math.Abs(-173.79616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.15216 - lat) + Math.Abs(-175.21333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.18627 - lat) + Math.Abs(-175.12453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vaini", "02", -21.19292, -175.17678);
case 1: return new CityInfo("Pangai", "01", -19.81468, -174.35423);
case 2: return new CityInfo("‘Ohonua", "EU", -21.33333, -174.95);
case 3: return new CityInfo("Nuku‘alofa", "02", -21.13938, -175.2018);
case 4: return new CityInfo("Neiafu", "03", -18.6506, -173.98404);
case 5: return new CityInfo("Lapaha", "02", -21.17735, -175.1172);
case 6: return new CityInfo("Kolonga", "02", -21.13333, -175.06667);
case 7: return new CityInfo("Hihifo", "NI", -15.9544, -173.79616);
case 8: return new CityInfo("Haveluloto", "02", -21.15216, -175.21333);
default: return new CityInfo("Tatakamotonga", "02", -21.18627, -175.12453);

                                    }                                        
                                }
                            
                        }
                    }
                