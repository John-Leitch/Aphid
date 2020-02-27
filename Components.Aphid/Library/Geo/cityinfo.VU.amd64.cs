
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
                                    public const string Country = "VU";
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
                            
                                        var cur = (Math.Abs(-13.87611 - lat) + Math.Abs(167.55167 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-17.73648 - lat) + Math.Abs(168.31366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.04175 - lat) + Math.Abs(167.07265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.06536 - lat) + Math.Abs(167.39714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.51989 - lat) + Math.Abs(167.16235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.09992 - lat) + Math.Abs(167.41636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.54167 - lat) + Math.Abs(169.28167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.29031 - lat) + Math.Abs(167.96679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Sola", "07", -13.87611, 167.55167);
case 1: return new CityInfo("Port-Vila", "18", -17.73648, 168.31366);
case 2: return new CityInfo("Port-Olry", "13", -15.04175, 167.07265);
case 3: return new CityInfo("Norsup", "16", -16.06536, 167.39714);
case 4: return new CityInfo("Luganville", "13", -15.51989, 167.16235);
case 5: return new CityInfo("Lakatoro", "16", -16.09992, 167.41636);
case 6: return new CityInfo("Isangel", "15", -19.54167, 169.28167);
default: return new CityInfo("Saratamata", "17", -15.29031, 167.96679);

                                    }                                        
                                }
                            
                        }
                    }
                