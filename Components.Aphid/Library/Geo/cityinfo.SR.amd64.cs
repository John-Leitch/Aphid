
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
                                    public const string Country = "SR";
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
                            
                                        var cur = (Math.Abs(5.7601 - lat) + Math.Abs(-56.66523 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(5.87618 - lat) + Math.Abs(-56.32572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.86638 - lat) + Math.Abs(-55.16682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.58983 - lat) + Math.Abs(-55.19462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.92606 - lat) + Math.Abs(-56.97297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.88573 - lat) + Math.Abs(-55.08871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.61411 - lat) + Math.Abs(-54.40121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87722 - lat) + Math.Abs(-55.04322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.7 - lat) + Math.Abs(-55.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.8 - lat) + Math.Abs(-55.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00435 - lat) + Math.Abs(-55.15333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.05594 - lat) + Math.Abs(-54.98043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.49788 - lat) + Math.Abs(-54.05522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.67207 - lat) + Math.Abs(-54.10355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Wageningen", "14", 5.7601, -56.66523);
case 1: return new CityInfo("Totness", "12", 5.87618, -56.32572);
case 2: return new CityInfo("Paramaribo", "16", 5.86638, -55.16682);
case 3: return new CityInfo("Onverwacht", "15", 5.58983, -55.19462);
case 4: return new CityInfo("Nieuw Nickerie", "14", 5.92606, -56.97297);
case 5: return new CityInfo("Nieuw Amsterdam", "11", 5.88573, -55.08871);
case 6: return new CityInfo("Moengo", "13", 5.61411, -54.40121);
case 7: return new CityInfo("Mariënburg", "11", 5.87722, -55.04322);
case 8: return new CityInfo("Lelydorp", "19", 5.7, -55.23333);
case 9: return new CityInfo("Groningen", "17", 5.8, -55.46667);
case 10: return new CityInfo("Brownsweg", "10", 5.00435, -55.15333);
case 11: return new CityInfo("Brokopondo", "10", 5.05594, -54.98043);
case 12: return new CityInfo("Albina", "13", 5.49788, -54.05522);
default: return new CityInfo("Benzdorp (Monte Hermon)", "18", 3.67207, -54.10355);

                                    }                                        
                                }
                            
                        }
                    }
                