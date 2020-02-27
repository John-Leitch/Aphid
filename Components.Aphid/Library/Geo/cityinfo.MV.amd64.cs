
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
                                    public const string Country = "MV";
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
                            
                                        var cur = (Math.Abs(-0.58333 - lat) + Math.Abs(73.23333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(4.17521 - lat) + Math.Abs(73.50916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.6 - lat) + Math.Abs(73.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.75713 - lat) + Math.Abs(72.96893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.10327 - lat) + Math.Abs(73.07078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.67075 - lat) + Math.Abs(72.89437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.75906 - lat) + Math.Abs(73.43296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.5306 - lat) + Math.Abs(72.99969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.29878 - lat) + Math.Abs(73.42403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88744 - lat) + Math.Abs(73.11402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.62207 - lat) + Math.Abs(73.06998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.79666 - lat) + Math.Abs(73.38824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.44438 - lat) + Math.Abs(73.36571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.91667 - lat) + Math.Abs(73.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.76687 - lat) + Math.Abs(73.4136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.66812 - lat) + Math.Abs(73.03017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15091 - lat) + Math.Abs(73.29013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.18772 - lat) + Math.Abs(73.09556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.47182 - lat) + Math.Abs(73.54699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.21169 - lat) + Math.Abs(73.54008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.83243 - lat) + Math.Abs(73.50257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.55905 - lat) + Math.Abs(73.10749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.50306 - lat) + Math.Abs(73.30859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.35582 - lat) + Math.Abs(73.35473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.34047 - lat) + Math.Abs(73.3388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.32473 - lat) + Math.Abs(73.31846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.1053 - lat) + Math.Abs(73.07115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.90045 - lat) + Math.Abs(73.46623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.94231 - lat) + Math.Abs(73.4907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.83078 - lat) + Math.Abs(73.47944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Meedhoo", "01", -0.58333, 73.23333);
case 1: return new CityInfo("Male", "38", 4.17521, 73.50916);
case 2: return new CityInfo("Hithadhoo", "01", -0.6, 73.08333);
case 3: return new CityInfo("Mahibadhoo", "10346475", 3.75713, 72.96893);
case 4: return new CityInfo("Eydhafushi", "31", 5.10327, 73.07078);
case 5: return new CityInfo("Kudahuvadhoo", "32", 2.67075, 72.89437);
case 6: return new CityInfo("Viligili", "34", 0.75906, 73.43296);
case 7: return new CityInfo("Thinadhoo", "35", 0.5306, 72.99969);
case 8: return new CityInfo("Fuvahmulah", "42", -0.29878, 73.42403);
case 9: return new CityInfo("Dhidhdhoo", "36", 6.88744, 73.11402);
case 10: return new CityInfo("Kulhudhuffushi", "37", 6.62207, 73.06998);
case 11: return new CityInfo("Hithadhoo", "05", 1.79666, 73.38824);
case 12: return new CityInfo("Naifaru", "39", 5.44438, 73.36571);
case 13: return new CityInfo("Muli", "41", 2.91667, 73.56667);
case 14: return new CityInfo("Manadhoo", "43", 5.76687, 73.4136);
case 15: return new CityInfo("Ugoofaaru", "44", 5.66812, 73.03017);
case 16: return new CityInfo("Funadhoo", "45", 6.15091, 73.29013);
case 17: return new CityInfo("Veymandoo", "46", 2.18772, 73.09556);
case 18: return new CityInfo("Felidhoo", "47", 3.47182, 73.54699);
case 19: return new CityInfo("Hulhumale", "38", 4.21169, 73.54008);
case 20: return new CityInfo("Fonadhoo", "05", 1.83243, 73.50257);
case 21: return new CityInfo("Buruni", "32", 2.55905, 73.10749);
case 22: return new CityInfo("Vilufushi", "", 2.50306, 73.30859);
case 23: return new CityInfo("Madifushi", "", 2.35582, 73.35473);
case 24: return new CityInfo("Diyamigili", "", 2.34047, 73.3388);
case 25: return new CityInfo("Guraidhoo", "", 2.32473, 73.31846);
case 26: return new CityInfo("Open Stage", "", 5.1053, 73.07115);
case 27: return new CityInfo("Guraidhoo", "38", 3.90045, 73.46623);
case 28: return new CityInfo("Maafushi", "38", 3.94231, 73.4907);
default: return new CityInfo("Maafaru", "43", 5.83078, 73.47944);

                                    }                                        
                                }
                            
                        }
                    }
                