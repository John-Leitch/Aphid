
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
                                    public const string Country = "ST";
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
                            
                                        var cur = (Math.Abs(0.29667 - lat) + Math.Abs(6.68139 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(0.33654 - lat) + Math.Abs(6.72732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.13417 - lat) + Math.Abs(6.64944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.63943 - lat) + Math.Abs(7.41951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.37917 - lat) + Math.Abs(6.6375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Trindade", "02", 0.29667, 6.68139);
case 1: return new CityInfo("São Tomé", "02", 0.33654, 6.72732);
case 2: return new CityInfo("São João dos Angolares", "02", 0.13417, 6.64944);
case 3: return new CityInfo("Santo António", "01", 1.63943, 7.41951);
default: return new CityInfo("Guadalupe", "02", 0.37917, 6.6375);

                                    }                                        
                                }
                            
                        }
                    }
                