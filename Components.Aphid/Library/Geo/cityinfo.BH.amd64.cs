
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
                                    public const string Country = "BH";
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
                            
                                        var cur = (Math.Abs(26.15472 - lat) + Math.Abs(50.62056 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(26.17361 - lat) + Math.Abs(50.54778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.21861 - lat) + Math.Abs(50.54778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.11528 - lat) + Math.Abs(50.50694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.06861 - lat) + Math.Abs(50.50389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.25722 - lat) + Math.Abs(50.61194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.22787 - lat) + Math.Abs(50.58565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.24556 - lat) + Math.Abs(50.65417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.13 - lat) + Math.Abs(50.555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Sitrah", "16", 26.15472, 50.62056);
case 1: return new CityInfo("Madīnat ‘Īsá", "17", 26.17361, 50.54778);
case 2: return new CityInfo("Jidd Ḩafş", "16", 26.21861, 50.54778);
case 3: return new CityInfo("Madīnat Ḩamad", "19", 26.11528, 50.50694);
case 4: return new CityInfo("Dār Kulayb", "17", 26.06861, 50.50389);
case 5: return new CityInfo("Al Muharraq", "15", 26.25722, 50.61194);
case 6: return new CityInfo("Manama", "16", 26.22787, 50.58565);
case 7: return new CityInfo("Al Ḩadd", "15", 26.24556, 50.65417);
default: return new CityInfo("Ar Rifā‘", "17", 26.13, 50.555);

                                    }                                        
                                }
                            
                        }
                    }
                