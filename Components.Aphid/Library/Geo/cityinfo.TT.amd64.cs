
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
                                    public const string Country = "TT";
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
                            
                                        var cur = (Math.Abs(10.65245 - lat) + Math.Abs(-61.38878 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(10.38824 - lat) + Math.Abs(-61.29704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.14525 - lat) + Math.Abs(-61.5074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.18229 - lat) + Math.Abs(-60.73525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.58705 - lat) + Math.Abs(-61.13008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.27969 - lat) + Math.Abs(-61.46835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30594 - lat) + Math.Abs(-61.17556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.27184 - lat) + Math.Abs(-61.37103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66668 - lat) + Math.Abs(-61.51889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17411 - lat) + Math.Abs(-61.68407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.69974 - lat) + Math.Abs(-61.54717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16667 - lat) + Math.Abs(-61.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.65298 - lat) + Math.Abs(-61.36298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66253 - lat) + Math.Abs(-61.53697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.27979 - lat) + Math.Abs(-61.4459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30618 - lat) + Math.Abs(-61.44671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.64917 - lat) + Math.Abs(-61.49889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.72081 - lat) + Math.Abs(-61.56616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.20846 - lat) + Math.Abs(-61.45273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.42248 - lat) + Math.Abs(-61.46748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.51667 - lat) + Math.Abs(-61.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.62877 - lat) + Math.Abs(-61.33487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.63737 - lat) + Math.Abs(-61.28228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tunapuna", "TUP", 10.65245, -61.38878);
case 1: return new CityInfo("Tabaquite", "CTT", 10.38824, -61.29704);
case 2: return new CityInfo("Siparia", "SIP", 10.14525, -61.5074);
case 3: return new CityInfo("Scarborough", "11", 11.18229, -60.73525);
case 4: return new CityInfo("Sangre Grande", "SGE", 10.58705, -61.13008);
case 5: return new CityInfo("San Fernando", "10", 10.27969, -61.46835);
case 6: return new CityInfo("Rio Claro", "03", 10.30594, -61.17556);
case 7: return new CityInfo("Princes Town", "PRT", 10.27184, -61.37103);
case 8: return new CityInfo("Port of Spain", "05", 10.66668, -61.51889);
case 9: return new CityInfo("Point Fortin", "PTF", 10.17411, -61.68407);
case 10: return new CityInfo("Petit Valley", "DMN", 10.69974, -61.54717);
case 11: return new CityInfo("Peñal", "PED", 10.16667, -61.46667);
case 12: return new CityInfo("Paradise", "TUP", 10.65298, -61.36298);
case 13: return new CityInfo("Mucurapo", "05", 10.66253, -61.53697);
case 14: return new CityInfo("Mon Repos", "10", 10.27979, -61.4459);
case 15: return new CityInfo("Marabella", "10", 10.30618, -61.44671);
case 16: return new CityInfo("Laventille", "SJL", 10.64917, -61.49889);
case 17: return new CityInfo("Diego Martin", "DMN", 10.72081, -61.56616);
case 18: return new CityInfo("Debe", "PED", 10.20846, -61.45273);
case 19: return new CityInfo("Couva", "CTT", 10.42248, -61.46748);
case 20: return new CityInfo("Chaguanas", "CHA", 10.51667, -61.41667);
case 21: return new CityInfo("Arouca", "TUP", 10.62877, -61.33487);
default: return new CityInfo("Arima", "01", 10.63737, -61.28228);

                                    }                                        
                                }
                            
                        }
                    }
                