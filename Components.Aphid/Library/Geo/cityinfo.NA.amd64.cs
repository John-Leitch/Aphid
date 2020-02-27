
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
                                    public const string Country = "NA";
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
                            
                                        var cur = (Math.Abs(-17.5 - lat) + Math.Abs(24.26667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-18.11065 - lat) + Math.Abs(21.61645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.55941 - lat) + Math.Abs(17.08323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.45 - lat) + Math.Abs(18.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22 - lat) + Math.Abs(15.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.23333 - lat) + Math.Abs(17.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.88333 - lat) + Math.Abs(18 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.67842 - lat) + Math.Abs(14.52663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.93333 - lat) + Math.Abs(19.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.317 - lat) + Math.Abs(17.09 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.11667 - lat) + Math.Abs(16.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.46369 - lat) + Math.Abs(16.64772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.35 - lat) + Math.Abs(16.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.65 - lat) + Math.Abs(17.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.4 - lat) + Math.Abs(15.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.78833 - lat) + Math.Abs(15.70436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.55 - lat) + Math.Abs(16.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.06068 - lat) + Math.Abs(13.83998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.78333 - lat) + Math.Abs(15.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.88333 - lat) + Math.Abs(15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.91667 - lat) + Math.Abs(15.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.36463 - lat) + Math.Abs(16.58146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.43333 - lat) + Math.Abs(15.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.58333 - lat) + Math.Abs(17.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.88758 - lat) + Math.Abs(15.06677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.98333 - lat) + Math.Abs(16.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.61667 - lat) + Math.Abs(18.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.63333 - lat) + Math.Abs(17.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.83333 - lat) + Math.Abs(16.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.64807 - lat) + Math.Abs(15.15383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.36667 - lat) + Math.Abs(14.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.58333 - lat) + Math.Abs(18.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.52306 - lat) + Math.Abs(17.06028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.93333 - lat) + Math.Abs(15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.01667 - lat) + Math.Abs(18.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.91667 - lat) + Math.Abs(18.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.11667 - lat) + Math.Abs(14.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.56667 - lat) + Math.Abs(18.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.45 - lat) + Math.Abs(18.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.46667 - lat) + Math.Abs(16.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48333 - lat) + Math.Abs(17.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.13333 - lat) + Math.Abs(19.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.41667 - lat) + Math.Abs(14.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.9575 - lat) + Math.Abs(14.50528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.5 - lat) + Math.Abs(14.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Katima Mulilo", "28", -17.5, 24.26667);
case 1: return new CityInfo("Bagani", "28", -18.11065, 21.61645);
case 2: return new CityInfo("Windhoek", "21", -22.55941, 17.08323);
case 3: return new CityInfo("Warmbad", "31", -28.45, 18.73333);
case 4: return new CityInfo("Usakos", "29", -22, 15.6);
case 5: return new CityInfo("Tsumeb", "38", -19.23333, 17.71667);
case 6: return new CityInfo("Tses", "31", -25.88333, 18);
case 7: return new CityInfo("Swakopmund", "29", -22.67842, 14.52663);
case 8: return new CityInfo("Rundu", "40", -17.93333, 19.76667);
case 9: return new CityInfo("Rehoboth", "30", -23.317, 17.09);
case 10: return new CityInfo("Outjo", "32", -20.11667, 16.15);
case 11: return new CityInfo("Otjiwarongo", "39", -20.46369, 16.64772);
case 12: return new CityInfo("Otjimbingwe", "29", -22.35, 16.13333);
case 13: return new CityInfo("Otavi", "39", -19.65, 17.33333);
case 14: return new CityInfo("Oshikango", "33", -17.4, 15.88333);
case 15: return new CityInfo("Oshakati", "37", -17.78833, 15.70436);
case 16: return new CityInfo("Oranjemund", "31", -28.55, 16.43333);
case 17: return new CityInfo("Opuwo", "32", -18.06068, 13.83998);
case 18: return new CityInfo("Ongwediva", "37", -17.78333, 15.76667);
case 19: return new CityInfo("Ongandjera", "36", -17.88333, 15.06667);
case 20: return new CityInfo("Ondangwa", "37", -17.91667, 15.95);
case 21: return new CityInfo("Omuthiya", "38", -18.36463, 16.58146);
case 22: return new CityInfo("Omaruru", "29", -21.43333, 15.93333);
case 23: return new CityInfo("Okakarara", "39", -20.58333, 17.43333);
case 24: return new CityInfo("Okahao", "36", -17.88758, 15.06677);
case 25: return new CityInfo("Okahandja", "39", -21.98333, 16.91667);
case 26: return new CityInfo("Nkurenkuru", "41", -17.61667, 18.6);
case 27: return new CityInfo("Mariental", "30", -24.63333, 17.96667);
case 28: return new CityInfo("Maltahöhe", "30", -24.83333, 16.98333);
case 29: return new CityInfo("Lüderitz", "31", -26.64807, 15.15383);
case 30: return new CityInfo("Khorixas", "32", -20.36667, 14.96667);
case 31: return new CityInfo("Keetmanshoop", "31", -26.58333, 18.13333);
case 32: return new CityInfo("Katutura", "21", -22.52306, 17.06028);
case 33: return new CityInfo("Karibib", "29", -21.93333, 15.83333);
case 34: return new CityInfo("Karasburg", "31", -28.01667, 18.75);
case 35: return new CityInfo("Hoachanas", "30", -23.91667, 18.05);
case 36: return new CityInfo("Hentiesbaai", "29", -22.11667, 14.28333);
case 37: return new CityInfo("Grootfontein", "39", -19.56667, 18.11667);
case 38: return new CityInfo("Gobabis", "35", -22.45, 18.96667);
case 39: return new CityInfo("Eenhana", "33", -17.46667, 16.33333);
case 40: return new CityInfo("Bethanie", "31", -26.48333, 17.15);
case 41: return new CityInfo("Aranos", "30", -24.13333, 19.11667);
case 42: return new CityInfo("Arandis", "29", -22.41667, 14.96667);
case 43: return new CityInfo("Walvis Bay", "29", -22.9575, 14.50528);
default: return new CityInfo("Outapi", "36", -17.5, 14.98333);

                                    }                                        
                                }
                            
                        }
                    }
                