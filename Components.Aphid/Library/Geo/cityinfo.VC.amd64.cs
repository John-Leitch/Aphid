
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
                                    public const string Country = "VC";
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
                            
                                        var cur = (Math.Abs(13.01102 - lat) + Math.Abs(-61.23548 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.20175 - lat) + Math.Abs(-61.27014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.15527 - lat) + Math.Abs(-61.22742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28054 - lat) + Math.Abs(-61.1185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.89186 - lat) + Math.Abs(-61.18521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.29069 - lat) + Math.Abs(-61.24043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25636 - lat) + Math.Abs(-61.11954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.1943 - lat) + Math.Abs(-61.13904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.23676 - lat) + Math.Abs(-61.27275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.15924 - lat) + Math.Abs(-61.23161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Port Elizabeth", "06", 13.01102, -61.23548);
case 1: return new CityInfo("Layou", "02", 13.20175, -61.27014);
case 2: return new CityInfo("Kingstown", "04", 13.15527, -61.22742);
case 3: return new CityInfo("Georgetown", "01", 13.28054, -61.1185);
case 4: return new CityInfo("Dovers", "06", 12.89186, -61.18521);
case 5: return new CityInfo("Chateaubelair", "03", 13.29069, -61.24043);
case 6: return new CityInfo("Byera Village", "01", 13.25636, -61.11954);
case 7: return new CityInfo("Biabou", "01", 13.1943, -61.13904);
case 8: return new CityInfo("Barrouallie", "05", 13.23676, -61.27275);
default: return new CityInfo("Kingstown Park", "04", 13.15924, -61.23161);

                                    }                                        
                                }
                            
                        }
                    }
                