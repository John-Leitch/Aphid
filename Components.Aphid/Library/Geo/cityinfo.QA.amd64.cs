
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
                                    public const string Country = "QA";
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
                            
                                        var cur = (Math.Abs(25.41524 - lat) + Math.Abs(51.40647 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(25.46972 - lat) + Math.Abs(51.3975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.99226 - lat) + Math.Abs(51.55067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.21417 - lat) + Math.Abs(50.80722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.12933 - lat) + Math.Abs(51.2009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.42485 - lat) + Math.Abs(50.78227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.57744 - lat) + Math.Abs(51.48306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.37088 - lat) + Math.Abs(51.22264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.13978 - lat) + Math.Abs(51.21493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.29194 - lat) + Math.Abs(51.42444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.15107 - lat) + Math.Abs(51.53718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.17151 - lat) + Math.Abs(51.60337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.68389 - lat) + Math.Abs(51.50583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.61068 - lat) + Math.Abs(51.09108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.82882 - lat) + Math.Abs(51.24567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.28545 - lat) + Math.Abs(51.53096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.7437 - lat) + Math.Abs(50.83174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.02565 - lat) + Math.Abs(51.36971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Umm Şalāl Muḩammad", "09", 25.41524, 51.40647);
case 1: return new CityInfo("Umm Şalāl ‘Alī", "09", 25.46972, 51.3975);
case 2: return new CityInfo("Musay‘īd", "10", 24.99226, 51.55067);
case 3: return new CityInfo("Umm Bāb", "06", 25.21417, 50.80722);
case 4: return new CityInfo("Madīnat ash Shamāl", "08", 26.12933, 51.2009);
case 5: return new CityInfo("Dukhān", "14", 25.42485, 50.78227);
case 6: return new CityInfo("Az̧ Z̧a‘āyin", "13", 25.57744, 51.48306);
case 7: return new CityInfo("Ash Shīḩānīyah", "14", 25.37088, 51.22264);
case 8: return new CityInfo("Ar Ruways", "08", 26.13978, 51.21493);
case 9: return new CityInfo("Ar Rayyān", "06", 25.29194, 51.42444);
case 10: return new CityInfo("Al Wukayr", "10", 25.15107, 51.53718);
case 11: return new CityInfo("Al Wakrah", "10", 25.17151, 51.60337);
case 12: return new CityInfo("Al Khawr", "04", 25.68389, 51.50583);
case 13: return new CityInfo("Al Jumaylīyah", "14", 25.61068, 51.09108);
case 14: return new CityInfo("Al Ghuwayrīyah", "04", 25.82882, 51.24567);
case 15: return new CityInfo("Doha", "01", 25.28545, 51.53096);
case 16: return new CityInfo("Abū Samrah", "06", 24.7437, 50.83174);
default: return new CityInfo("Fuwayriţ", "08", 26.02565, 51.36971);

                                    }                                        
                                }
                            
                        }
                    }
                