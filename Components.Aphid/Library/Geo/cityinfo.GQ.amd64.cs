
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
                                    public const string Country = "GQ";
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
                            
                                        var cur = (Math.Abs(3.6992 - lat) + Math.Abs(8.9084 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-1.4068 - lat) + Math.Abs(5.63178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.33812 - lat) + Math.Abs(9.82212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.71667 - lat) + Math.Abs(8.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.12985 - lat) + Math.Abs(11.26603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.02475 - lat) + Math.Abs(10.94599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.01643 - lat) + Math.Abs(10.47066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.62742 - lat) + Math.Abs(11.31346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.33333 - lat) + Math.Abs(8.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.13609 - lat) + Math.Abs(10.61322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.58267 - lat) + Math.Abs(9.61478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.88262 - lat) + Math.Abs(9.95133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.43677 - lat) + Math.Abs(10.55124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.15106 - lat) + Math.Abs(11.33528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.08425 - lat) + Math.Abs(9.693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.38288 - lat) + Math.Abs(8.76209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.75578 - lat) + Math.Abs(8.78166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.45683 - lat) + Math.Abs(8.55465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.4261 - lat) + Math.Abs(9.62316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.58113 - lat) + Math.Abs(10.46716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.86391 - lat) + Math.Abs(9.76582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.85592 - lat) + Math.Abs(10.68994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.8658 - lat) + Math.Abs(10.76892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.03225 - lat) + Math.Abs(10.64882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.29683 - lat) + Math.Abs(10.93691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Santiago de Baney", "04", 3.6992, 8.9084);
case 1: return new CityInfo("San Antonio de Palé", "03", -1.4068, 5.63178);
case 2: return new CityInfo("Río Campo", "08", 2.33812, 9.82212);
case 3: return new CityInfo("Rebola", "04", 3.71667, 8.83333);
case 4: return new CityInfo("Nsok", "09", 1.12985, 11.26603);
case 5: return new CityInfo("Nsang", "07", 2.02475, 10.94599);
case 6: return new CityInfo("Ncue", "07", 2.01643, 10.47066);
case 7: return new CityInfo("Mongomo", "09", 1.62742, 11.31346);
case 8: return new CityInfo("Moca", "05", 3.33333, 8.66667);
case 9: return new CityInfo("Mikomeseng", "07", 2.13609, 10.61322);
case 10: return new CityInfo("Mbini", "08", 1.58267, 9.61478);
case 11: return new CityInfo("Machinda", "08", 1.88262, 9.95133);
case 12: return new CityInfo("Evinayong", "06", 1.43677, 10.55124);
case 13: return new CityInfo("Ebebiyin", "07", 2.15106, 11.33528);
case 14: return new CityInfo("Cogo", "08", 1.08425, 9.693);
case 15: return new CityInfo("Ciudad de Riaba", "05", 3.38288, 8.76209);
case 16: return new CityInfo("Malabo", "04", 3.75578, 8.78166);
case 17: return new CityInfo("Luba", "05", 3.45683, 8.55465);
case 18: return new CityInfo("Bitica", "08", 1.4261, 9.62316);
case 19: return new CityInfo("Bicurga", "06", 1.58113, 10.46716);
case 20: return new CityInfo("Bata", "08", 1.86391, 9.76582);
case 21: return new CityInfo("Ayene", "09", 1.85592, 10.68994);
case 22: return new CityInfo("Añisoc", "09", 1.8658, 10.76892);
case 23: return new CityInfo("Acurenam", "06", 1.03225, 10.64882);
default: return new CityInfo("Aconibe", "09", 1.29683, 10.93691);

                                    }                                        
                                }
                            
                        }
                    }
                