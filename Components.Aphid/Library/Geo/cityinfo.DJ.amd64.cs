
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
                                    public const string Country = "DJ";
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
                            
                                        var cur = (Math.Abs(11.78778 - lat) + Math.Abs(42.88222 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(11.96693 - lat) + Math.Abs(43.28835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.46111 - lat) + Math.Abs(43.25278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.31028 - lat) + Math.Abs(42.92944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.15028 - lat) + Math.Abs(42.47624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.58901 - lat) + Math.Abs(43.14503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.10454 - lat) + Math.Abs(42.36971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.52639 - lat) + Math.Abs(42.85194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.15583 - lat) + Math.Abs(42.7125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.42167 - lat) + Math.Abs(42.89556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.42389 - lat) + Math.Abs(43.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.71583 - lat) + Math.Abs(41.83611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4895 - lat) + Math.Abs(43.07528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tadjourah", "05", 11.78778, 42.88222);
case 1: return new CityInfo("Obock", "04", 11.96693, 43.28835);
case 2: return new CityInfo("Loyada", "07", 11.46111, 43.25278);
case 3: return new CityInfo("Holhol", "01", 11.31028, 42.92944);
case 4: return new CityInfo("Dorra", "05", 12.15028, 42.47624);
case 5: return new CityInfo("Djibouti", "07", 11.58901, 43.14503);
case 6: return new CityInfo("Dikhil", "06", 11.10454, 42.36971);
case 7: return new CityInfo("Arta", "08", 11.52639, 42.85194);
case 8: return new CityInfo("'Ali Sabieh", "01", 11.15583, 42.7125);
case 9: return new CityInfo("Alaïli Ḏaḏḏa‘", "04", 12.42167, 42.89556);
case 10: return new CityInfo("Goubétto", "01", 11.42389, 43.00028);
case 11: return new CityInfo("Gâlâfi", "06", 11.71583, 41.83611);
default: return new CityInfo("Chabelley", "01", 11.4895, 43.07528);

                                    }                                        
                                }
                            
                        }
                    }
                