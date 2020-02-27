
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
                                    public const string Country = "GL";
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
                            
                                        var cur = (Math.Abs(72.7872 - lat) + Math.Abs(-56.14436 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(67.00876 - lat) + Math.Abs(-50.68937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.93946 - lat) + Math.Abs(-53.6735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.24721 - lat) + Math.Abs(-53.53682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.11667 - lat) + Math.Abs(-49.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.81926 - lat) + Math.Abs(-51.19221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71839 - lat) + Math.Abs(-46.03561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.99402 - lat) + Math.Abs(-49.66776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.18347 - lat) + Math.Abs(-51.72157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.91298 - lat) + Math.Abs(-46.05055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14169 - lat) + Math.Abs(-45.24069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.41506 - lat) + Math.Abs(-52.89822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.30648 - lat) + Math.Abs(-53.46405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.48456 - lat) + Math.Abs(-21.96221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.21981 - lat) + Math.Abs(-51.09861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.61451 - lat) + Math.Abs(-37.63676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.70981 - lat) + Math.Abs(-52.86988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.67442 - lat) + Math.Abs(-52.12545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(77.46666 - lat) + Math.Abs(-69.23155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Upernavik", "11839537", 72.7872, -56.14436);
case 1: return new CityInfo("Kangerlussuaq", "06", 67.00876, -50.68937);
case 2: return new CityInfo("Sisimiut", "06", 66.93946, -53.6735);
case 3: return new CityInfo("Qeqertarsuaq", "11839537", 69.24721, -53.53682);
case 4: return new CityInfo("Qeqertarsuaq", "07", 62.11667, -49.78333);
case 5: return new CityInfo("Qasigiannguit", "11839534", 68.81926, -51.19221);
case 6: return new CityInfo("Qaqortoq", "04", 60.71839, -46.03561);
case 7: return new CityInfo("Paamiut", "07", 61.99402, -49.66776);
case 8: return new CityInfo("Nuuk", "07", 64.18347, -51.72157);
case 9: return new CityInfo("Narsaq", "04", 60.91298, -46.05055);
case 10: return new CityInfo("Nanortalik", "04", 60.14169, -45.24069);
case 11: return new CityInfo("Maniitsoq", "06", 65.41506, -52.89822);
case 12: return new CityInfo("Kangaatsiaq", "05", 68.30648, -53.46405);
case 13: return new CityInfo("Ittoqqortoormiit", "02", 70.48456, -21.96221);
case 14: return new CityInfo("Ilulissat", "11839537", 69.21981, -51.09861);
case 15: return new CityInfo("Tasiilaq", "07", 65.61451, -37.63676);
case 16: return new CityInfo("Aasiaat", "11839534", 68.70981, -52.86988);
case 17: return new CityInfo("Uummannaq", "11839537", 70.67442, -52.12545);
default: return new CityInfo("Qaanaaq", "11839537", 77.46666, -69.23155);

                                    }                                        
                                }
                            
                        }
                    }
                