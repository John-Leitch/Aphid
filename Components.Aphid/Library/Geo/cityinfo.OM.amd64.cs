
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
                                    public const string Country = "OM";
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
                            
                                        var cur = (Math.Abs(22.56667 - lat) + Math.Abs(59.52889 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(24.34745 - lat) + Math.Abs(56.70937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.31667 - lat) + Math.Abs(58.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.7426 - lat) + Math.Abs(56.46698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.01505 - lat) + Math.Abs(54.09237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.17222 - lat) + Math.Abs(56.88861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.93333 - lat) + Math.Abs(57.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.58413 - lat) + Math.Abs(58.40778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.17993 - lat) + Math.Abs(56.24774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.93333 - lat) + Math.Abs(57.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.22573 - lat) + Math.Abs(56.51572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.69057 - lat) + Math.Abs(58.53337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.95931 - lat) + Math.Abs(56.27575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.19778 - lat) + Math.Abs(56.25778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.40787 - lat) + Math.Abs(58.1283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.57769 - lat) + Math.Abs(58.39982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.67872 - lat) + Math.Abs(57.88605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.97886 - lat) + Math.Abs(57.3047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.45 - lat) + Math.Abs(58.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.84944 - lat) + Math.Abs(57.43861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.67027 - lat) + Math.Abs(58.18911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.39083 - lat) + Math.Abs(57.42444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.571 - lat) + Math.Abs(58.69472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.53077 - lat) + Math.Abs(56.563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.97144 - lat) + Math.Abs(57.09313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.25088 - lat) + Math.Abs(55.79312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.37934 - lat) + Math.Abs(57.52718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.28345 - lat) + Math.Abs(56.3328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.58645 - lat) + Math.Abs(56.53969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.30324 - lat) + Math.Abs(57.52459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.83836 - lat) + Math.Abs(52.66042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.6527 - lat) + Math.Abs(57.59926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Sur", "04", 22.56667, 59.52889);
case 1: return new CityInfo("Sohar", "11", 24.34745, 56.70937);
case 2: return new CityInfo("Sufālat Samā’il", "01", 23.31667, 58.01667);
case 3: return new CityInfo("Shināş", "11", 24.7426, 56.46698);
case 4: return new CityInfo("Şalālah", "08", 17.01505, 54.09237);
case 5: return new CityInfo("Şaḩam", "11", 24.17222, 56.88861);
case 6: return new CityInfo("Nizwá", "01", 22.93333, 57.53333);
case 7: return new CityInfo("Muscat", "06", 23.58413, 58.40778);
case 8: return new CityInfo("Khasab", "07", 26.17993, 56.24774);
case 9: return new CityInfo("Izkī", "01", 22.93333, 57.76667);
case 10: return new CityInfo("‘Ibrī", "09", 23.22573, 56.51572);
case 11: return new CityInfo("Ibrā’", "12", 22.69057, 58.53337);
case 12: return new CityInfo("Haymā’", "03", 19.95931, 56.27575);
case 13: return new CityInfo("Dib Dibba", "07", 26.19778, 56.25778);
case 14: return new CityInfo("Bidbid", "01", 23.40787, 58.1283);
case 15: return new CityInfo("Bawshar", "06", 23.57769, 58.39982);
case 16: return new CityInfo("Barkā’", "02", 23.67872, 57.88605);
case 17: return new CityInfo("Bahlā’", "01", 22.97886, 57.3047);
case 18: return new CityInfo("Badīyah", "12", 22.45, 58.8);
case 19: return new CityInfo("As Suwayq", "11", 23.84944, 57.43861);
case 20: return new CityInfo("Seeb", "06", 23.67027, 58.18911);
case 21: return new CityInfo("Rustaq", "02", 23.39083, 57.42444);
case 22: return new CityInfo("Al Qābil", "12", 22.571, 58.69472);
case 23: return new CityInfo("Liwá", "11", 24.53077, 56.563);
case 24: return new CityInfo("Al Khābūrah", "11", 23.97144, 57.09313);
case 25: return new CityInfo("Al Buraymī", "10", 24.25088, 55.79312);
case 26: return new CityInfo("Adam", "01", 22.37934, 57.52718);
case 27: return new CityInfo("Madḩā’ al Jadīdah", "07", 25.28345, 56.3328);
case 28: return new CityInfo("Yanqul", "09", 23.58645, 56.53969);
case 29: return new CityInfo("Bayt al ‘Awābī", "02", 23.30324, 57.52459);
case 30: return new CityInfo("Al Mazyūnah", "08", 17.83836, 52.66042);
default: return new CityInfo("Oman Smart Future City", "02", 23.6527, 57.59926);

                                    }                                        
                                }
                            
                        }
                    }
                