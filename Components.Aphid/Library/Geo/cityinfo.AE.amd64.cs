
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
                                    public const string Country = "AE";
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
                            
                                        var cur = (Math.Abs(25.56473 - lat) + Math.Abs(55.55517 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(25.78953 - lat) + Math.Abs(55.9432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.14355 - lat) + Math.Abs(53.7881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.27623 - lat) + Math.Abs(56.36256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.65416 - lat) + Math.Abs(53.70522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.33132 - lat) + Math.Abs(56.34199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.07725 - lat) + Math.Abs(55.30927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.59246 - lat) + Math.Abs(56.26176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.61955 - lat) + Math.Abs(56.27291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.33737 - lat) + Math.Abs(55.41206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.11028 - lat) + Math.Abs(52.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.11641 - lat) + Math.Abs(56.34141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.19167 - lat) + Math.Abs(55.76056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.40177 - lat) + Math.Abs(55.47878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.28812 - lat) + Math.Abs(55.88157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.45118 - lat) + Math.Abs(54.39696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.42588 - lat) + Math.Abs(54.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.30978 - lat) + Math.Abs(54.62944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.35893 - lat) + Math.Abs(54.48267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.39268 - lat) + Math.Abs(54.70779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.14479 - lat) + Math.Abs(56.24764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Umm Al Quwain City", "07", 25.56473, 55.55517);
case 1: return new CityInfo("Ras Al Khaimah City", "05", 25.78953, 55.9432);
case 2: return new CityInfo("Muzayri‘", "01", 23.14355, 53.7881);
case 3: return new CityInfo("Murbaḩ", "06", 25.27623, 56.36256);
case 4: return new CityInfo("Zayed City", "01", 23.65416, 53.70522);
case 5: return new CityInfo("Khawr Fakkān", "06", 25.33132, 56.34199);
case 6: return new CityInfo("Dubai", "03", 25.07725, 55.30927);
case 7: return new CityInfo("Dibba Al-Fujairah", "04", 25.59246, 56.26176);
case 8: return new CityInfo("Dibba Al-Hisn", "04", 25.61955, 56.27291);
case 9: return new CityInfo("Sharjah", "06", 25.33737, 55.41206);
case 10: return new CityInfo("Ar Ruways", "01", 24.11028, 52.73056);
case 11: return new CityInfo("Al Fujairah City", "04", 25.11641, 56.34141);
case 12: return new CityInfo("Al Ain City", "01", 24.19167, 55.76056);
case 13: return new CityInfo("Ajman City", "02", 25.40177, 55.47878);
case 14: return new CityInfo("Adh Dhayd", "06", 25.28812, 55.88157);
case 15: return new CityInfo("Abu Dhabi", "01", 24.45118, 54.39696);
case 16: return new CityInfo("Khalifah A City", "01", 24.42588, 54.605);
case 17: return new CityInfo("Bani Yas City", "01", 24.30978, 54.62944);
case 18: return new CityInfo("Musaffah", "01", 24.35893, 54.48267);
case 19: return new CityInfo("Al Shamkhah City", "01", 24.39268, 54.70779);
default: return new CityInfo("Reef Al Fujairah City", "04", 25.14479, 56.24764);

                                    }                                        
                                }
                            
                        }
                    }
                