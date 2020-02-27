
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
                                    public const string Country = "NC";
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
                            
                                        var cur = (Math.Abs(-22.15 - lat) + Math.Abs(166.88333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-20.91687 - lat) + Math.Abs(167.26461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.71161 - lat) + Math.Abs(163.64702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.96667 - lat) + Math.Abs(164.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.66645 - lat) + Math.Abs(167.49627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.79094 - lat) + Math.Abs(165.24987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.61667 - lat) + Math.Abs(166.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.54751 - lat) + Math.Abs(167.88019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.65 - lat) + Math.Abs(165.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.35 - lat) + Math.Abs(165.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.23333 - lat) + Math.Abs(164.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13333 - lat) + Math.Abs(164.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.4 - lat) + Math.Abs(164.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.08333 - lat) + Math.Abs(165.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.93333 - lat) + Math.Abs(165.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.13105 - lat) + Math.Abs(166.35717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.35 - lat) + Math.Abs(164.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.27407 - lat) + Math.Abs(166.44884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.26257 - lat) + Math.Abs(166.56621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.7 - lat) + Math.Abs(165.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.71079 - lat) + Math.Abs(165.82764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.56667 - lat) + Math.Abs(164.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.05951 - lat) + Math.Abs(164.86582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.66667 - lat) + Math.Abs(164.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.28333 - lat) + Math.Abs(165.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.68333 - lat) + Math.Abs(164.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.65284 - lat) + Math.Abs(166.53641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.15757 - lat) + Math.Abs(166.4572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.53333 - lat) + Math.Abs(165.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.5669 - lat) + Math.Abs(165.49736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.86226 - lat) + Math.Abs(166.05122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yaté-Barrage", "00", -22.15, 166.88333);
case 1: return new CityInfo("Wé", "03", -20.91687, 167.26461);
case 2: return new CityInfo("Wala", "01", -19.71161, 163.64702);
case 3: return new CityInfo("Voh", "01", -20.96667, 164.7);
case 4: return new CityInfo("Vao", "02", -22.66645, 167.49627);
case 5: return new CityInfo("Touho", "01", -20.79094, 165.24987);
case 6: return new CityInfo("Thio", "02", -21.61667, 166.21667);
case 7: return new CityInfo("Tadine", "03", -21.54751, 167.88019);
case 8: return new CityInfo("Sarraméa", "02", -21.65, 165.85);
case 9: return new CityInfo("Poya", "01", -21.35, 165.15);
case 10: return new CityInfo("Poum", "01", -20.23333, 164.01667);
case 11: return new CityInfo("Pouembout", "01", -21.13333, 164.9);
case 12: return new CityInfo("Pouébo", "01", -20.4, 164.56667);
case 13: return new CityInfo("Ponérihouen", "01", -21.08333, 165.4);
case 14: return new CityInfo("Poindimié", "01", -20.93333, 165.33333);
case 15: return new CityInfo("Païta", "02", -22.13105, 166.35717);
case 16: return new CityInfo("Ouégoa", "01", -20.35, 164.43333);
case 17: return new CityInfo("Nouméa", "02", -22.27407, 166.44884);
case 18: return new CityInfo("Mont-Dore", "02", -22.26257, 166.56621);
case 19: return new CityInfo("Moindou", "02", -21.7, 165.68333);
case 20: return new CityInfo("La Foa", "02", -21.71079, 165.82764);
case 21: return new CityInfo("Koumac", "01", -20.56667, 164.28333);
case 22: return new CityInfo("Koné", "01", -21.05951, 164.86582);
case 23: return new CityInfo("Kaala-Gomén", "01", -20.66667, 164.4);
case 24: return new CityInfo("Houaïlou", "01", -21.28333, 165.61667);
case 25: return new CityInfo("Hienghène", "01", -20.68333, 164.93333);
case 26: return new CityInfo("Fayaoué", "03", -20.65284, 166.53641);
case 27: return new CityInfo("Dumbéa", "02", -22.15757, 166.4572);
case 28: return new CityInfo("Canala", "01", -21.53333, 165.95);
case 29: return new CityInfo("Bourail", "02", -21.5669, 165.49736);
default: return new CityInfo("Bouloupari", "02", -21.86226, 166.05122);

                                    }                                        
                                }
                            
                        }
                    }
                