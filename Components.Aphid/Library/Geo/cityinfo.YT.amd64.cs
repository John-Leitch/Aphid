
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
                                    public const string Country = "YT";
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
                            
                                        var cur = (Math.Abs(-12.79674 - lat) + Math.Abs(45.27938 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-12.78234 - lat) + Math.Abs(45.22878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.78339 - lat) + Math.Abs(45.25693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.8436 - lat) + Math.Abs(45.18436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.72391 - lat) + Math.Abs(45.05819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.7044 - lat) + Math.Abs(45.12231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.69982 - lat) + Math.Abs(45.06894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.75944 - lat) + Math.Abs(45.08361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.78722 - lat) + Math.Abs(45.10278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.73361 - lat) + Math.Abs(45.20417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.84639 - lat) + Math.Abs(45.13611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.83333 - lat) + Math.Abs(45.11056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.85055 - lat) + Math.Abs(45.10205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.91276 - lat) + Math.Abs(45.19256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.93194 - lat) + Math.Abs(45.14833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.9025 - lat) + Math.Abs(45.07611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.95361 - lat) + Math.Abs(45.10333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Pamandzi", "97615", -12.79674, 45.27938);
case 1: return new CityInfo("Mamoudzou", "97611", -12.78234, 45.22878);
case 2: return new CityInfo("Dzaoudzi", "97608", -12.78339, 45.25693);
case 3: return new CityInfo("Dembeni", "97607", -12.8436, 45.18436);
case 4: return new CityInfo("Acoua", "97601", -12.72391, 45.05819);
case 5: return new CityInfo("Bandraboua", "97602", -12.7044, 45.12231);
case 6: return new CityInfo("Mtsamboro", "97612", -12.69982, 45.06894);
case 7: return new CityInfo("M'Tsangamouji", "97613", -12.75944, 45.08361);
case 8: return new CityInfo("Tsingoni", "97617", -12.78722, 45.10278);
case 9: return new CityInfo("Koungou", "97610", -12.73361, 45.20417);
case 10: return new CityInfo("Ouangani", "97614", -12.84639, 45.13611);
case 11: return new CityInfo("Chiconi", "97605", -12.83333, 45.11056);
case 12: return new CityInfo("Sada", "97616", -12.85055, 45.10205);
case 13: return new CityInfo("Bandrélé", "97603", -12.91276, 45.19256);
case 14: return new CityInfo("Chirongui", "97606", -12.93194, 45.14833);
case 15: return new CityInfo("Bouéni", "97604", -12.9025, 45.07611);
default: return new CityInfo("Kani Kéli", "97609", -12.95361, 45.10333);

                                    }                                        
                                }
                            
                        }
                    }
                