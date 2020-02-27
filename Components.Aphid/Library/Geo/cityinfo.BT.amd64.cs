
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
                                    public const string Country = "BT";
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
                            
                                        var cur = (Math.Abs(27.48615 - lat) + Math.Abs(89.89915 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(27.5026 - lat) + Math.Abs(90.50716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.46609 - lat) + Math.Abs(89.64191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.6116 - lat) + Math.Abs(91.498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.3331 - lat) + Math.Abs(91.55424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.07529 - lat) + Math.Abs(89.87688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.21689 - lat) + Math.Abs(90.65793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.86395 - lat) + Math.Abs(90.26745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.59137 - lat) + Math.Abs(89.87743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.85164 - lat) + Math.Abs(89.38837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.4305 - lat) + Math.Abs(89.41334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.53333 - lat) + Math.Abs(89.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.27471 - lat) + Math.Abs(91.23963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.66787 - lat) + Math.Abs(91.18393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.38747 - lat) + Math.Abs(89.28074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.90372 - lat) + Math.Abs(89.72689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.96667 - lat) + Math.Abs(89.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.0219 - lat) + Math.Abs(90.12291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.0989 - lat) + Math.Abs(89.53604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.54918 - lat) + Math.Abs(90.7525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.86667 - lat) + Math.Abs(90.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.78333 - lat) + Math.Abs(91.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.89903 - lat) + Math.Abs(89.09951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.03795 - lat) + Math.Abs(91.40305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.9 - lat) + Math.Abs(92.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.81667 - lat) + Math.Abs(91.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.80069 - lat) + Math.Abs(91.50519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.46821 - lat) + Math.Abs(89.64441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Wangdue Phodrang", "22", 27.48615, 89.89915);
case 1: return new CityInfo("Trongsa", "21", 27.5026, 90.50716);
case 2: return new CityInfo("Thimphu", "20", 27.46609, 89.64191);
case 3: return new CityInfo("Trashi Yangtse", "24", 27.6116, 91.498);
case 4: return new CityInfo("Trashigang", "19", 27.3331, 91.55424);
case 5: return new CityInfo("Daga", "08", 27.07529, 89.87688);
case 6: return new CityInfo("Shemgang", "18", 27.21689, 90.65793);
case 7: return new CityInfo("Sarpang", "09", 26.86395, 90.26745);
case 8: return new CityInfo("Punākha", "15", 27.59137, 89.87743);
case 9: return new CityInfo("Phuntsholing", "06", 26.85164, 89.38837);
case 10: return new CityInfo("Paro", "13", 27.4305, 89.41334);
case 11: return new CityInfo("Pajo", "15", 27.53333, 89.88333);
case 12: return new CityInfo("Mongar", "12", 27.27471, 91.23963);
case 13: return new CityInfo("Lhuentse", "11", 27.66787, 91.18393);
case 14: return new CityInfo("Ha", "10", 27.38747, 89.28074);
case 15: return new CityInfo("Gasa", "23", 27.90372, 89.72689);
case 16: return new CityInfo("Daphu", "06", 26.96667, 89.38333);
case 17: return new CityInfo("Tsirang", "07", 27.0219, 90.12291);
case 18: return new CityInfo("Tsimasham", "06", 27.0989, 89.53604);
case 19: return new CityInfo("Jakar", "05", 27.54918, 90.7525);
case 20: return new CityInfo("Panbang", "18", 26.86667, 90.98333);
case 21: return new CityInfo("Nganglam", "17", 26.78333, 91.25);
case 22: return new CityInfo("Samtse", "16", 26.89903, 89.09951);
case 23: return new CityInfo("Pemagatshel", "14", 27.03795, 91.40305);
case 24: return new CityInfo("Daifam", "17", 26.9, 92.1);
case 25: return new CityInfo("Bhangtar", "17", 26.81667, 91.71667);
case 26: return new CityInfo("Samdrup Jongkhar", "17", 26.80069, 91.50519);
default: return new CityInfo("Lungtenzampa", "20", 27.46821, 89.64441);

                                    }                                        
                                }
                            
                        }
                    }
                