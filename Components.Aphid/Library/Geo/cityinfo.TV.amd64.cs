
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
                                    public const string Country = "TV";
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
                            
                                        var cur = (Math.Abs(-6.28764 - lat) + Math.Abs(176.31472 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-7.24562 - lat) + Math.Abs(177.14511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.10819 - lat) + Math.Abs(177.33393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.52425 - lat) + Math.Abs(179.19417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.49026 - lat) + Math.Abs(178.68016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.52544 - lat) + Math.Abs(179.1941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.48996 - lat) + Math.Abs(178.69256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.02731 - lat) + Math.Abs(178.31351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.52074 - lat) + Math.Abs(179.1968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.5174 - lat) + Math.Abs(179.19829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.51758 - lat) + Math.Abs(179.20094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.49922 - lat) + Math.Abs(179.19502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Toga Village", "NMG", -6.28764, 176.31472);
case 1: return new CityInfo("Tanrake Village", "NUI", -7.24562, 177.14511);
case 2: return new CityInfo("Kulia Village", "NIT", -6.10819, 177.33393);
case 3: return new CityInfo("Funafuti", "FUN", -8.52425, 179.19417);
case 4: return new CityInfo("Asau Village", "VAI", -7.49026, 178.68016);
case 5: return new CityInfo("Vaiaku Village", "FUN", -8.52544, 179.1941);
case 6: return new CityInfo("Motufoua School", "VAI", -7.48996, 178.69256);
case 7: return new CityInfo("Savave Village", "NKF", -8.02731, 178.31351);
case 8: return new CityInfo("Alapi Village", "FUN", -8.52074, 179.1968);
case 9: return new CityInfo("Senala Village", "FUN", -8.5174, 179.19829);
case 10: return new CityInfo("Fakaifou Village", "FUN", -8.51758, 179.20094);
default: return new CityInfo("Teone Village", "FUN", -8.49922, 179.19502);

                                    }                                        
                                }
                            
                        }
                    }
                