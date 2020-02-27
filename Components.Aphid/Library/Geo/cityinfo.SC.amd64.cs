
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
                                    public const string Country = "SC";
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
                            
                                        var cur = (Math.Abs(-4.62001 - lat) + Math.Abs(55.45501 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-4.76667 - lat) + Math.Abs(55.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.66667 - lat) + Math.Abs(55.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.66667 - lat) + Math.Abs(55.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.61667 - lat) + Math.Abs(55.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.62091 - lat) + Math.Abs(55.43015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.73333 - lat) + Math.Abs(55.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.71667 - lat) + Math.Abs(55.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.34808 - lat) + Math.Abs(55.83269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Victoria", "26", -4.62001, 55.45501);
case 1: return new CityInfo("Takamaka", "23", -4.76667, 55.5);
case 2: return new CityInfo("Port Glaud", "27", -4.66667, 55.41667);
case 3: return new CityInfo("Cascade", "11", -4.66667, 55.5);
case 4: return new CityInfo("Bel Ombre", "10", -4.61667, 55.41667);
case 5: return new CityInfo("Beau Vallon", "08", -4.62091, 55.43015);
case 6: return new CityInfo("Anse Royale", "05", -4.73333, 55.51667);
case 7: return new CityInfo("Anse Boileau", "02", -4.71667, 55.48333);
default: return new CityInfo("La Passe", "25", -4.34808, 55.83269);

                                    }                                        
                                }
                            
                        }
                    }
                