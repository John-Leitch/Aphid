
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
                                    public const string Country = "SH";
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
                            
                                        var cur = (Math.Abs(-7.92861 - lat) + Math.Abs(-14.41194 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-37.06757 - lat) + Math.Abs(-12.31155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.94916 - lat) + Math.Abs(-5.68571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.93872 - lat) + Math.Abs(-5.71675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.93723 - lat) + Math.Abs(-5.71996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Georgetown", "01", -7.92861, -14.41194);
case 1: return new CityInfo("Edinburgh of the Seven Seas", "03", -37.06757, -12.31155);
case 2: return new CityInfo("Longwood", "02", -15.94916, -5.68571);
case 3: return new CityInfo("Jamestown", "02", -15.93872, -5.71675);
default: return new CityInfo("Half Tree Hollow", "02", -15.93723, -5.71996);

                                    }                                        
                                }
                            
                        }
                    }
                