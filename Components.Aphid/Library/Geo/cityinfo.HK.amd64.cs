
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
                                    public const string Country = "HK";
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
                            
                                        var cur = (Math.Abs(22.37137 - lat) + Math.Abs(114.11329 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(22.22623 - lat) + Math.Abs(114.11241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.45 - lat) + Math.Abs(114.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.35 - lat) + Math.Abs(114.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.28142 - lat) + Math.Abs(114.17258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.39175 - lat) + Math.Abs(113.97157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.45007 - lat) + Math.Abs(114.16877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.25515 - lat) + Math.Abs(113.86309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.20453 - lat) + Math.Abs(114.13159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.38333 - lat) + Math.Abs(114.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.33023 - lat) + Math.Abs(114.15945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.38333 - lat) + Math.Abs(114.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.25556 - lat) + Math.Abs(113.90391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.31667 - lat) + Math.Abs(114.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.27832 - lat) + Math.Abs(114.17469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.28299 - lat) + Math.Abs(114.15846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.28783 - lat) + Math.Abs(113.94243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tsuen Wan", "NTW", 22.37137, 114.11329);
case 1: return new CityInfo("Yung Shue Wan", "NIS", 22.22623, 114.11241);
case 2: return new CityInfo("Yuen Long Kau Hui", "NYL", 22.45, 114.03333);
case 3: return new CityInfo("Wong Tai Sin", "KWT", 22.35, 114.18333);
case 4: return new CityInfo("Wan Chai", "HWC", 22.28142, 114.17258);
case 5: return new CityInfo("Tuen Mun", "NTM", 22.39175, 113.97157);
case 6: return new CityInfo("Tai Po", "NTP", 22.45007, 114.16877);
case 7: return new CityInfo("Tai O", "NIS", 22.25515, 113.86309);
case 8: return new CityInfo("Sok Kwu Wan", "NIS", 22.20453, 114.13159);
case 9: return new CityInfo("Sha Tin", "NST", 22.38333, 114.18333);
case 10: return new CityInfo("Sham Shui Po", "KSS", 22.33023, 114.15945);
case 11: return new CityInfo("Sai Kung", "NSK", 22.38333, 114.26667);
case 12: return new CityInfo("Ngong Ping", "NIS", 22.25556, 113.90391);
case 13: return new CityInfo("Kowloon", "KKC", 22.31667, 114.18333);
case 14: return new CityInfo("Hong Kong", "HCW", 22.27832, 114.17469);
case 15: return new CityInfo("Central", "HCW", 22.28299, 114.15846);
default: return new CityInfo("Tung Chung", "NIS", 22.28783, 113.94243);

                                    }                                        
                                }
                            
                        }
                    }
                