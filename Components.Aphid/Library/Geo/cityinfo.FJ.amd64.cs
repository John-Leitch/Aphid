
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
                                    public const string Country = "FJ";
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
                            
                                        var cur = (Math.Abs(-18.14161 - lat) + Math.Abs(178.44149 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-17.80309 - lat) + Math.Abs(177.41617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.06667 - lat) + Math.Abs(179.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.61686 - lat) + Math.Abs(177.45049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.4332 - lat) + Math.Abs(179.36451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.5 - lat) + Math.Abs(177.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.23652 - lat) + Math.Abs(-178.81232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.5343 - lat) + Math.Abs(177.67407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Suva", "01", -18.14161, 178.44149);
case 1: return new CityInfo("Nadi", "05", -17.80309, 177.41617);
case 2: return new CityInfo("Levuka", "02", -18.06667, 179.31667);
case 3: return new CityInfo("Lautoka", "05", -17.61686, 177.45049);
case 4: return new CityInfo("Labasa", "03", -16.4332, 179.36451);
case 5: return new CityInfo("Ahau", "04", -12.5, 177.05);
case 6: return new CityInfo("Tubou", "02", -18.23652, -178.81232);
default: return new CityInfo("Ba", "05", -17.5343, 177.67407);

                                    }                                        
                                }
                            
                        }
                    }
                