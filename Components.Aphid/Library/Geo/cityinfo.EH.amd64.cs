
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
                                    public const string Country = "EH";
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
                            
                                        var cur = (Math.Abs(27.09611 - lat) + Math.Abs(-13.41583 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(27.1418 - lat) + Math.Abs(-13.18797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.68477 - lat) + Math.Abs(-15.95798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.46175 - lat) + Math.Abs(-12.99412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Laayoune Plage", "00", 27.09611, -13.41583);
case 1: return new CityInfo("Laayoune", "", 27.1418, -13.18797);
case 2: return new CityInfo("Dakhla", "CE", 23.68477, -15.95798);
default: return new CityInfo("Daoura", "", 27.46175, -12.99412);

                                    }                                        
                                }
                            
                        }
                    }
                