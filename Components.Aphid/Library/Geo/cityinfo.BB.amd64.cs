
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
                                    public const string Country = "BB";
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
                            
                                        var cur = (Math.Abs(13.18676 - lat) + Math.Abs(-59.57663 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.10487 - lat) + Math.Abs(-59.44861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25072 - lat) + Math.Abs(-59.64396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.07067 - lat) + Math.Abs(-59.54637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.18672 - lat) + Math.Abs(-59.63808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.21288 - lat) + Math.Abs(-59.58838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25808 - lat) + Math.Abs(-59.57763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.17018 - lat) + Math.Abs(-59.52186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3196 - lat) + Math.Abs(-59.63831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28445 - lat) + Math.Abs(-59.64223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.10732 - lat) + Math.Abs(-59.62021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.18501 - lat) + Math.Abs(-59.54519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.21133 - lat) + Math.Abs(-59.52596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Welchman Hall", "11", 13.18676, -59.57663);
case 1: return new CityInfo("Crane", "10", 13.10487, -59.44861);
case 2: return new CityInfo("Speightstown", "09", 13.25072, -59.64396);
case 3: return new CityInfo("Oistins", "01", 13.07067, -59.54637);
case 4: return new CityInfo("Holetown", "04", 13.18672, -59.63808);
case 5: return new CityInfo("Hillaby", "02", 13.21288, -59.58838);
case 6: return new CityInfo("Greenland", "02", 13.25808, -59.57763);
case 7: return new CityInfo("Four Cross Roads", "05", 13.17018, -59.52186);
case 8: return new CityInfo("Crab Hill", "07", 13.3196, -59.63831);
case 9: return new CityInfo("Checker Hall", "07", 13.28445, -59.64223);
case 10: return new CityInfo("Bridgetown", "08", 13.10732, -59.62021);
case 11: return new CityInfo("Blackmans", "06", 13.18501, -59.54519);
default: return new CityInfo("Bathsheba", "06", 13.21133, -59.52596);

                                    }                                        
                                }
                            
                        }
                    }
                