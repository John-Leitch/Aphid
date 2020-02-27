
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
                                    public const string Country = "GA";
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
                            
                                        var cur = (Math.Abs(-2.93323 - lat) + Math.Abs(10.98178 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-0.71933 - lat) + Math.Abs(8.78151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.5995 - lat) + Math.Abs(11.57933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.57464 - lat) + Math.Abs(9.26184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.65487 - lat) + Math.Abs(13.67533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.39051 - lat) + Math.Abs(9.76096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.40077 - lat) + Math.Abs(11.35813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.17827 - lat) + Math.Abs(10.76488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.4085 - lat) + Math.Abs(13.15857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.86846 - lat) + Math.Abs(11.05594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.56652 - lat) + Math.Abs(13.1987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.78205 - lat) + Math.Abs(11.54904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.61952 - lat) + Math.Abs(11.60675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.90046 - lat) + Math.Abs(11.906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.43198 - lat) + Math.Abs(10.6554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.57381 - lat) + Math.Abs(12.86419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.39241 - lat) + Math.Abs(9.45356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.58431 - lat) + Math.Abs(14.25905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.81742 - lat) + Math.Abs(12.70818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.7001 - lat) + Math.Abs(10.24055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.13667 - lat) + Math.Abs(12.46399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.65 - lat) + Math.Abs(10 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.63333 - lat) + Math.Abs(13.58357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.21544 - lat) + Math.Abs(10.58378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.00019 - lat) + Math.Abs(9.58229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.09207 - lat) + Math.Abs(11.93846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.07597 - lat) + Math.Abs(11.50065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tchibanga", "05", -2.93323, 10.98178);
case 1: return new CityInfo("Port-Gentil", "08", -0.71933, 8.78151);
case 2: return new CityInfo("Oyem", "09", 1.5995, 11.57933);
case 3: return new CityInfo("Omboué", "08", -1.57464, 9.26184);
case 4: return new CityInfo("Okondja", "02", -0.65487, 13.67533);
case 5: return new CityInfo("Ntoum", "01", 0.39051, 9.76096);
case 6: return new CityInfo("Ndendé", "04", -2.40077, 11.35813);
case 7: return new CityInfo("Ndjolé", "03", -0.17827, 10.76488);
case 8: return new CityInfo("Mounana", "02", -1.4085, 13.15857);
case 9: return new CityInfo("Mouila", "04", -1.86846, 11.05594);
case 10: return new CityInfo("Moanda", "02", -1.56652, 13.1987);
case 11: return new CityInfo("Mitzic", "09", 0.78205, 11.54904);
case 12: return new CityInfo("Mimongo", "04", -1.61952, 11.60675);
case 13: return new CityInfo("Mbigou", "04", -1.90046, 11.906);
case 14: return new CityInfo("Mayumba", "05", -3.43198, 10.6554);
case 15: return new CityInfo("Makokou", "06", 0.57381, 12.86419);
case 16: return new CityInfo("Libreville", "01", 0.39241, 9.45356);
case 17: return new CityInfo("Lékoni", "02", -1.58431, 14.25905);
case 18: return new CityInfo("Lastoursville", "07", -0.81742, 12.70818);
case 19: return new CityInfo("Lambaréné", "03", -0.7001, 10.24055);
case 20: return new CityInfo("Koulamoutou", "07", -1.13667, 12.46399);
case 21: return new CityInfo("Gamba", "08", -2.65, 10);
case 22: return new CityInfo("Franceville", "02", -1.63333, 13.58357);
case 23: return new CityInfo("Fougamou", "04", -1.21544, 10.58378);
case 24: return new CityInfo("Cocobeach", "01", 1.00019, 9.58229);
case 25: return new CityInfo("Booué", "06", -0.09207, 11.93846);
default: return new CityInfo("Bitam", "09", 2.07597, 11.50065);

                                    }                                        
                                }
                            
                        }
                    }
                