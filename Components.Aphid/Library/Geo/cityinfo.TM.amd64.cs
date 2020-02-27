
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
                                    public const string Country = "TM";
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
                            
                                        var cur = (Math.Abs(39.51075 - lat) + Math.Abs(54.36713 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(37.34821 - lat) + Math.Abs(59.61431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.97644 - lat) + Math.Abs(56.27575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20611 - lat) + Math.Abs(54.59056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24463 - lat) + Math.Abs(55.51536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43749 - lat) + Math.Abs(56.28081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.915 - lat) + Math.Abs(58.08987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05415 - lat) + Math.Abs(58.19721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43624 - lat) + Math.Abs(57.43158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95 - lat) + Math.Abs(58.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88754 - lat) + Math.Abs(58.51596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83333 - lat) + Math.Abs(59.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65041 - lat) + Math.Abs(59.9164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.05513 - lat) + Math.Abs(59.37877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02216 - lat) + Math.Abs(52.95517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32773 - lat) + Math.Abs(59.15442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.12824 - lat) + Math.Abs(59.67101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83625 - lat) + Math.Abs(59.96661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29886 - lat) + Math.Abs(62.35975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38338 - lat) + Math.Abs(60.50545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4816 - lat) + Math.Abs(62.91374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78393 - lat) + Math.Abs(63.88035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49656 - lat) + Math.Abs(61.97142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59378 - lat) + Math.Abs(61.83031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83573 - lat) + Math.Abs(65.21058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.27992 - lat) + Math.Abs(62.34383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81244 - lat) + Math.Abs(66.04656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17037 - lat) + Math.Abs(63.61165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07328 - lat) + Math.Abs(63.57861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61852 - lat) + Math.Abs(62.16715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18746 - lat) + Math.Abs(61.4036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Balkanabat", "02", 39.51075, 54.36713);
case 1: return new CityInfo("Kaka", "01", 37.34821, 59.61431);
case 2: return new CityInfo("Serdar", "02", 38.97644, 56.27575);
case 3: return new CityInfo("Gumdag", "02", 39.20611, 54.59056);
case 4: return new CityInfo("Bereket", "02", 39.24463, 55.51536);
case 5: return new CityInfo("Magtymguly", "02", 38.43749, 56.28081);
case 6: return new CityInfo("Arçabil", "01", 37.915, 58.08987);
case 7: return new CityInfo("Abadan", "01", 38.05415, 58.19721);
case 8: return new CityInfo("Baharly", "01", 38.43624, 57.43158);
case 9: return new CityInfo("Ashgabat", "S", 37.95, 58.38333);
case 10: return new CityInfo("Annau", "01", 37.88754, 58.51596);
case 11: return new CityInfo("Yylanly", "03", 41.83333, 59.65);
case 12: return new CityInfo("Tagta", "03", 41.65041, 59.9164);
case 13: return new CityInfo("Akdepe", "03", 42.05513, 59.37877);
case 14: return new CityInfo("Türkmenbaşy", "02", 40.02216, 52.95517);
case 15: return new CityInfo("Köneürgench", "03", 42.32773, 59.15442);
case 16: return new CityInfo("Boldumsaz", "03", 42.12824, 59.67101);
case 17: return new CityInfo("Daşoguz", "03", 41.83625, 59.96661);
case 18: return new CityInfo("Yolöten", "05", 37.29886, 62.35975);
case 19: return new CityInfo("Tejen", "01", 37.38338, 60.50545);
case 20: return new CityInfo("Seydi", "05", 39.4816, 62.91374);
case 21: return new CityInfo("Saýat", "04", 38.78393, 63.88035);
case 22: return new CityInfo("Murgab", "00", 37.49656, 61.97142);
case 23: return new CityInfo("Mary", "05", 37.59378, 61.83031);
case 24: return new CityInfo("Atamyrat", "04", 37.83573, 65.21058);
case 25: return new CityInfo("Serhetabat", "05", 35.27992, 62.34383);
case 26: return new CityInfo("Gowurdak", "04", 37.81244, 66.04656);
case 27: return new CityInfo("Farap", "04", 39.17037, 63.61165);
case 28: return new CityInfo("Türkmenabat", "04", 39.07328, 63.57861);
case 29: return new CityInfo("Bayramaly", "05", 37.61852, 62.16715);
default: return new CityInfo("Gazojak", "04", 41.18746, 61.4036);

                                    }                                        
                                }
                            
                        }
                    }
                