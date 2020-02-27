
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
                                    public const string Country = "CG";
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
                            
                                        var cur = (Math.Abs(-3.68192 - lat) + Math.Abs(13.34985 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(1.64806 - lat) + Math.Abs(14.58056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.77609 - lat) + Math.Abs(11.86352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.48193 - lat) + Math.Abs(15.89988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.61361 - lat) + Math.Abs(16.05167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.94968 - lat) + Math.Abs(12.70423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.00694 - lat) + Math.Abs(15.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.15361 - lat) + Math.Abs(13.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.19834 - lat) + Math.Abs(12.66664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.65194 - lat) + Math.Abs(11.8125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.75611 - lat) + Math.Abs(11.85778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.36139 - lat) + Math.Abs(14.76444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.20493 - lat) + Math.Abs(13.28608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.61804 - lat) + Math.Abs(18.05981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.87639 - lat) + Math.Abs(15.86444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.8725 - lat) + Math.Abs(14.82056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.54472 - lat) + Math.Abs(14.75333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.26613 - lat) + Math.Abs(15.28318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.19861 - lat) + Math.Abs(15.285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.18396 - lat) + Math.Abs(13.2859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Sibiti", "05", -3.68192, 13.34985);
case 1: return new CityInfo("Sémbé", "10", 1.64806, 14.58056);
case 2: return new CityInfo("Pointe-Noire", "15", -4.77609, 11.86352);
case 3: return new CityInfo("Owando", "13", -0.48193, 15.89988);
case 4: return new CityInfo("Ouésso", "10", 1.61361, 16.05167);
case 5: return new CityInfo("Mossendjo", "07", -2.94968, 12.70423);
case 6: return new CityInfo("Makoua", "13", 0.00694, 15.63333);
case 7: return new CityInfo("Madingou", "01", -4.15361, 13.55);
case 8: return new CityInfo("Dolisie", "07", -4.19834, 12.66664);
case 9: return new CityInfo("Loango", "04", -4.65194, 11.8125);
case 10: return new CityInfo("Loandjili", "15", -4.75611, 11.85778);
case 11: return new CityInfo("Kinkala", "11", -4.36139, 14.76444);
case 12: return new CityInfo("Kayes", "01", -4.20493, 13.28608);
case 13: return new CityInfo("Impfondo", "06", 1.61804, 18.05981);
case 14: return new CityInfo("Gamboma", "08", -1.87639, 15.86444);
case 15: return new CityInfo("Ewo", "14", -0.8725, 14.82056);
case 16: return new CityInfo("Djambala", "08", -2.54472, 14.75333);
case 17: return new CityInfo("Brazzaville", "12", -4.26613, 15.28318);
case 18: return new CityInfo("Boukiéro", "12", -4.19861, 15.285);
default: return new CityInfo("Nkayi", "01", -4.18396, 13.2859);

                                    }                                        
                                }
                            
                        }
                    }
                