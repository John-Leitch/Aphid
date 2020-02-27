
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
                                    public const string Country = "AS";
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
                            
                                        var cur = (Math.Abs(-14.28694 - lat) + Math.Abs(-170.68306 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-14.26417 - lat) + Math.Abs(-170.65083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.2675 - lat) + Math.Abs(-170.56361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.27611 - lat) + Math.Abs(-170.66389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.31972 - lat) + Math.Abs(-170.77 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.35889 - lat) + Math.Abs(-170.73472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.36111 - lat) + Math.Abs(-170.78222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.05528 - lat) + Math.Abs(-171.08833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.23361 - lat) + Math.Abs(-169.51444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.36028 - lat) + Math.Abs(-170.77306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.33583 - lat) + Math.Abs(-170.72 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.3325 - lat) + Math.Abs(-170.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.2825 - lat) + Math.Abs(-170.69 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.2222 - lat) + Math.Abs(-169.51278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.27222 - lat) + Math.Abs(-170.67806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.34389 - lat) + Math.Abs(-170.785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.34722 - lat) + Math.Abs(-170.76722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.33861 - lat) + Math.Abs(-170.76784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.32278 - lat) + Math.Abs(-170.73389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.33056 - lat) + Math.Abs(-170.75278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.33139 - lat) + Math.Abs(-170.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.17528 - lat) + Math.Abs(-169.6775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.27806 - lat) + Math.Abs(-170.7025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Utulei", "010", -14.28694, -170.68306);
case 1: return new CityInfo("Āfono", "010", -14.26417, -170.65083);
case 2: return new CityInfo("Alao", "010", -14.2675, -170.56361);
case 3: return new CityInfo("Aūa", "010", -14.27611, -170.66389);
case 4: return new CityInfo("Aoloau", "050", -14.31972, -170.77);
case 5: return new CityInfo("Vaitogi", "050", -14.35889, -170.73472);
case 6: return new CityInfo("Vailoatai", "050", -14.36111, -170.78222);
case 7: return new CityInfo("Taulaga", "040", -11.05528, -171.08833);
case 8: return new CityInfo("Ta`ū", "020", -14.23361, -169.51444);
case 9: return new CityInfo("Taputimu", "050", -14.36028, -170.77306);
case 10: return new CityInfo("Tāfuna", "050", -14.33583, -170.72);
case 11: return new CityInfo("Faleniu", "050", -14.3325, -170.74444);
case 12: return new CityInfo("Fagatogo", "010", -14.2825, -170.69);
case 13: return new CityInfo("Faleāsao", "020", -14.2222, -169.51278);
case 14: return new CityInfo("Leloaloa", "010", -14.27222, -170.67806);
case 15: return new CityInfo("Leone", "050", -14.34389, -170.785);
case 16: return new CityInfo("Malaeloa/Ituau", "050", -14.34722, -170.76722);
case 17: return new CityInfo("Malaeloa/Aitulagi", "050", -14.33861, -170.76784);
case 18: return new CityInfo("Malaeimi", "050", -14.32278, -170.73389);
case 19: return new CityInfo("Mapusagafou", "050", -14.33056, -170.75278);
case 20: return new CityInfo("Mesepa", "050", -14.33139, -170.74444);
case 21: return new CityInfo("Ofu", "020", -14.17528, -169.6775);
default: return new CityInfo("Pago Pago", "010", -14.27806, -170.7025);

                                    }                                        
                                }
                            
                        }
                    }
                