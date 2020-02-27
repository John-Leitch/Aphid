
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
                                    public const string Country = "SZ";
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
                            
                                        var cur = (Math.Abs(-25.98333 - lat) + Math.Abs(31.71667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-26.4525 - lat) + Math.Abs(31.94722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.6282 - lat) + Math.Abs(31.42021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.96082 - lat) + Math.Abs(31.24666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.03333 - lat) + Math.Abs(31.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.11222 - lat) + Math.Abs(31.19833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.03333 - lat) + Math.Abs(31.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.45 - lat) + Math.Abs(31.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.31667 - lat) + Math.Abs(31.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.49884 - lat) + Math.Abs(31.38004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.56667 - lat) + Math.Abs(31.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.46667 - lat) + Math.Abs(31.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.31005 - lat) + Math.Abs(31.89198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48333 - lat) + Math.Abs(31.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.88333 - lat) + Math.Abs(31.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.21667 - lat) + Math.Abs(31.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.97917 - lat) + Math.Abs(31.32444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23333 - lat) + Math.Abs(31.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.96667 - lat) + Math.Abs(31.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.81667 - lat) + Math.Abs(31.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.55 - lat) + Math.Abs(31.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.07427 - lat) + Math.Abs(31.87672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.82659 - lat) + Math.Abs(31.3273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tshaneni", "02", -25.98333, 31.71667);
case 1: return new CityInfo("Siteki", "02", -26.4525, 31.94722);
case 2: return new CityInfo("Sidvokodvo", "03", -26.6282, 31.42021);
case 3: return new CityInfo("Piggs Peak", "01", -25.96082, 31.24666);
case 4: return new CityInfo("Nsoko", "02", -27.03333, 31.95);
case 5: return new CityInfo("Nhlangano", "04", -27.11222, 31.19833);
case 6: return new CityInfo("Mhlume", "02", -26.03333, 31.85);
case 7: return new CityInfo("Mhlambanyatsi", "03", -26.45, 31.01667);
case 8: return new CityInfo("Mbabane", "01", -26.31667, 31.13333);
case 9: return new CityInfo("Manzini", "03", -26.49884, 31.38004);
case 10: return new CityInfo("Malkerns", "03", -26.56667, 31.18333);
case 11: return new CityInfo("Lobamba", "01", -26.46667, 31.2);
case 12: return new CityInfo("Lavumisa", "04", -27.31005, 31.89198);
case 13: return new CityInfo("Kwaluseni", "03", -26.48333, 31.33333);
case 14: return new CityInfo("Kubuta", "04", -26.88333, 31.48333);
case 15: return new CityInfo("Hluti", "04", -27.21667, 31.61667);
case 16: return new CityInfo("Hlatikulu", "04", -26.97917, 31.32444);
case 17: return new CityInfo("Darkton", "00", -26.23333, 31.03333);
case 18: return new CityInfo("Bulembu", "01", -25.96667, 31.13333);
case 19: return new CityInfo("Big Bend", "02", -26.81667, 31.93333);
case 20: return new CityInfo("Bhunya", "03", -26.55, 31.01667);
case 21: return new CityInfo("Vuvulane", "02", -26.07427, 31.87672);
default: return new CityInfo("Ntfonjeni", "01", -25.82659, 31.3273);

                                    }                                        
                                }
                            
                        }
                    }
                