
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
                                    public const string Country = "AG";
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
                            
                                        var cur = (Math.Abs(17.05037 - lat) + Math.Abs(-61.80091 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(17.12096 - lat) + Math.Abs(-61.84329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.11337 - lat) + Math.Abs(-61.81962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.11667 - lat) + Math.Abs(-61.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.09682 - lat) + Math.Abs(-61.77046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.01682 - lat) + Math.Abs(-61.83579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.04141 - lat) + Math.Abs(-61.79052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.04791 - lat) + Math.Abs(-61.70332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.02741 - lat) + Math.Abs(-61.78136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.01637 - lat) + Math.Abs(-61.7674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.63333 - lat) + Math.Abs(-61.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.16225 - lat) + Math.Abs(-61.8178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.13226 - lat) + Math.Abs(-61.80356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.06565 - lat) + Math.Abs(-61.87466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.06671 - lat) + Math.Abs(-61.79303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Swetes", "06", 17.05037, -61.80091);
case 1: return new CityInfo("Saint John’s", "04", 17.12096, -61.84329);
case 2: return new CityInfo("Potters Village", "04", 17.11337, -61.81962);
case 3: return new CityInfo("Piggotts", "03", 17.11667, -61.8);
case 4: return new CityInfo("Parham", "07", 17.09682, -61.77046);
case 5: return new CityInfo("Old Road", "05", 17.01682, -61.83579);
case 6: return new CityInfo("Liberta", "06", 17.04141, -61.79052);
case 7: return new CityInfo("Freetown", "08", 17.04791, -61.70332);
case 8: return new CityInfo("Falmouth", "06", 17.02741, -61.78136);
case 9: return new CityInfo("English Harbour Town", "06", 17.01637, -61.7674);
case 10: return new CityInfo("Codrington", "01", 17.63333, -61.83333);
case 11: return new CityInfo("Cedar Grove", "04", 17.16225, -61.8178);
case 12: return new CityInfo("Carlisle", "03", 17.13226, -61.80356);
case 13: return new CityInfo("Bolands", "05", 17.06565, -61.87466);
default: return new CityInfo("All Saints", "07", 17.06671, -61.79303);

                                    }                                        
                                }
                            
                        }
                    }
                