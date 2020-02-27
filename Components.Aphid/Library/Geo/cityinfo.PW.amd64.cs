
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
                                    public const string Country = "PW";
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
                            
                                        var cur = (Math.Abs(7.33978 - lat) + Math.Abs(134.47326 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(7.62416 - lat) + Math.Abs(134.64208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.49567 - lat) + Math.Abs(134.63671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.48826 - lat) + Math.Abs(134.48562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53134 - lat) + Math.Abs(134.52713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.46932 - lat) + Math.Abs(134.60991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55456 - lat) + Math.Abs(134.63612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6957 - lat) + Math.Abs(134.63054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.90601 - lat) + Math.Abs(134.12997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.00488 - lat) + Math.Abs(131.12168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.32608 - lat) + Math.Abs(132.21943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.08228 - lat) + Math.Abs(134.71725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.04192 - lat) + Math.Abs(134.25561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36451 - lat) + Math.Abs(134.51484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.44613 - lat) + Math.Abs(134.47678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.60986 - lat) + Math.Abs(134.5744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.34257 - lat) + Math.Abs(134.47888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50077 - lat) + Math.Abs(134.6238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Koror", "06", 7.33978, 134.47326);
case 1: return new CityInfo("Ulimang", "08", 7.62416, 134.64208);
case 2: return new CityInfo("Melekeok Village", "07", 7.49567, 134.63671);
case 3: return new CityInfo("Ngereklmadel", "11", 7.48826, 134.48562);
case 4: return new CityInfo("Imeong Hamlet", "13", 7.53134, 134.52713);
case 5: return new CityInfo("Ngchesar Hamlet", "12", 7.46932, 134.60991);
case 6: return new CityInfo("Ngerkeai", "14", 7.55456, 134.63612);
case 7: return new CityInfo("Mengellang", "09", 7.6957, 134.63054);
case 8: return new CityInfo("Angaur State", "03", 6.90601, 134.12997);
case 9: return new CityInfo("Tobi Village", "04", 3.00488, 131.12168);
case 10: return new CityInfo("Sonsorol Village", "16", 5.32608, 132.21943);
case 11: return new CityInfo("Kayangel", "05", 8.08228, 134.71725);
case 12: return new CityInfo("Kloulklubed", "15", 7.04192, 134.25561);
case 13: return new CityInfo("Ngetkib", "02", 7.36451, 134.51484);
case 14: return new CityInfo("Ngchemiangel", "01", 7.44613, 134.47678);
case 15: return new CityInfo("Ngardmau", "10", 7.60986, 134.5744);
case 16: return new CityInfo("Koror Town", "06", 7.34257, 134.47888);
default: return new CityInfo("Ngerulmud", "07", 7.50077, 134.6238);

                                    }                                        
                                }
                            
                        }
                    }
                