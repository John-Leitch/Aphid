
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
                                    public const string Country = "WF";
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
                            
                                        var cur = (Math.Abs(-13.227 - lat) + Math.Abs(-176.18834 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-13.34261 - lat) + Math.Abs(-176.19435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.29333 - lat) + Math.Abs(-178.15833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.28163 - lat) + Math.Abs(-176.17453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.26852 - lat) + Math.Abs(-176.16586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.3454 - lat) + Math.Abs(-176.21464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.29266 - lat) + Math.Abs(-176.18328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.31096 - lat) + Math.Abs(-178.11094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.24667 - lat) + Math.Abs(-176.18341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.27729 - lat) + Math.Abs(-176.17066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vaitupu", "98613", -13.227, -176.18834);
case 1: return new CityInfo("Utufua", "98613", -13.34261, -176.19435);
case 2: return new CityInfo("Leava", "98612", -14.29333, -178.15833);
case 3: return new CityInfo("Mata-Utu", "98613", -13.28163, -176.17453);
case 4: return new CityInfo("Liku", "98613", -13.26852, -176.16586);
case 5: return new CityInfo("Halalo", "98613", -13.3454, -176.21464);
case 6: return new CityInfo("Falaleu", "98613", -13.29266, -176.18328);
case 7: return new CityInfo("Alo", "98611", -14.31096, -178.11094);
case 8: return new CityInfo("Alele", "98613", -13.24667, -176.18341);
default: return new CityInfo("Akaka", "98613", -13.27729, -176.17066);

                                    }                                        
                                }
                            
                        }
                    }
                