
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
                                    public const string Country = "SO";
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
                            
                                        var cur = (Math.Abs(4.55 - lat) + Math.Abs(43.03333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(4.12129 - lat) + Math.Abs(43.88945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.6544 - lat) + Math.Abs(47.8575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.6185 - lat) + Math.Abs(44.8938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.80958 - lat) + Math.Abs(43.24627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.01897 - lat) + Math.Abs(44.51111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.62794 - lat) + Math.Abs(42.44067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.78784 - lat) + Math.Abs(44.52999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.47197 - lat) + Math.Abs(49.87282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.4092 - lat) + Math.Abs(45.06397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.03711 - lat) + Math.Abs(45.34375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.71594 - lat) + Math.Abs(44.77166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.9726 - lat) + Math.Abs(45.5347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.80315 - lat) + Math.Abs(42.54417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.68573 - lat) + Math.Abs(43.94397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1595 - lat) + Math.Abs(48.1967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.35817 - lat) + Math.Abs(42.54536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.48829 - lat) + Math.Abs(42.78535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.78087 - lat) + Math.Abs(45.50048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.06968 - lat) + Math.Abs(42.74497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.3766 - lat) + Math.Abs(45.5996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.2837 - lat) + Math.Abs(50.23 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3505 - lat) + Math.Abs(48.5268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.56 - lat) + Math.Abs(44.065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.40207 - lat) + Math.Abs(48.48284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.32892 - lat) + Math.Abs(42.22091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.76972 - lat) + Math.Abs(47.43083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.9803 - lat) + Math.Abs(49.8164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.25311 - lat) + Math.Abs(42.57377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.53597 - lat) + Math.Abs(46.38666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61616 - lat) + Math.Abs(47.36795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.84878 - lat) + Math.Abs(47.18064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.68501 - lat) + Math.Abs(46.6176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.99907 - lat) + Math.Abs(45.35824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.96611 - lat) + Math.Abs(50.75694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.7603 - lat) + Math.Abs(46.3222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13603 - lat) + Math.Abs(46.62761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.80257 - lat) + Math.Abs(44.07805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.21917 - lat) + Math.Abs(41.83725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.85375 - lat) + Math.Abs(45.56744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.52213 - lat) + Math.Abs(45.53363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.08333 - lat) + Math.Abs(42.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.28421 - lat) + Math.Abs(49.18158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.87037 - lat) + Math.Abs(51.05795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.43959 - lat) + Math.Abs(45.01432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.73583 - lat) + Math.Abs(45.20361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.11383 - lat) + Math.Abs(43.6498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.28636 - lat) + Math.Abs(51.0773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.4942 - lat) + Math.Abs(50.8122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.34464 - lat) + Math.Abs(42.27644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.1381 - lat) + Math.Abs(45.1212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47738 - lat) + Math.Abs(47.35971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.89206 - lat) + Math.Abs(43.38531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9 - lat) + Math.Abs(44.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yeed", "01", 4.55, 43.03333);
case 1: return new CityInfo("Xuddur", "01", 4.12129, 43.88945);
case 2: return new CityInfo("Xarardheere", "10", 4.6544, 47.8575);
case 3: return new CityInfo("Wanlaweyn", "14", 2.6185, 44.8938);
case 4: return new CityInfo("Waajid", "01", 3.80958, 43.24627);
case 5: return new CityInfo("Tayeeglow", "01", 4.01897, 44.51111);
case 6: return new CityInfo("Saacow", "08", 1.62794, 42.44067);
case 7: return new CityInfo("Qoryooley", "14", 1.78784, 44.52999);
case 8: return new CityInfo("Qandala", "03", 11.47197, 49.87282);
case 9: return new CityInfo("Oodweyne", "19", 9.4092, 45.06397);
case 10: return new CityInfo("Mogadishu", "02", 2.03711, 45.34375);
case 11: return new CityInfo("Marka", "14", 1.71594, 44.77166);
case 12: return new CityInfo("Mahaddayweyne", "13", 2.9726, 45.5347);
case 13: return new CityInfo("Luuq", "06", 3.80315, 42.54417);
case 14: return new CityInfo("Lughaye", "21", 10.68573, 43.94397);
case 15: return new CityInfo("Las Khorey", "12", 11.1595, 48.1967);
case 16: return new CityInfo("Kismayo", "09", -0.35817, 42.54536);
case 17: return new CityInfo("Jilib", "08", 0.48829, 42.78535);
case 18: return new CityInfo("Jawhar", "13", 2.78087, 45.50048);
case 19: return new CityInfo("Jamaame", "09", 0.06968, 42.74497);
case 20: return new CityInfo("Jalalaqsi", "07", 3.3766, 45.5996);
case 21: return new CityInfo("Iskushuban", "03", 10.2837, 50.23);
case 22: return new CityInfo("Hobyo", "10", 5.3505, 48.5268);
case 23: return new CityInfo("Hargeysa", "20", 9.56, 44.065);
case 24: return new CityInfo("Garoowe", "18", 8.40207, 48.48284);
case 25: return new CityInfo("Garbahaarrey", "06", 3.32892, 42.22091);
case 26: return new CityInfo("Gaalkacyo", "10", 6.76972, 47.43083);
case 27: return new CityInfo("Eyl", "18", 7.9803, 49.8164);
case 28: return new CityInfo("Dujuuma", "08", 1.25311, 42.57377);
case 29: return new CityInfo("Dhuusamarreeb", "05", 5.53597, 46.38666);
case 30: return new CityInfo("Ceerigaabo", "12", 10.61616, 47.36795);
case 31: return new CityInfo("Ceeldheer", "05", 3.84878, 47.18064);
case 32: return new CityInfo("Ceelbuur", "05", 4.68501, 46.6176);
case 33: return new CityInfo("Ceek", "19", 8.99907, 45.35824);
case 34: return new CityInfo("Caluula", "03", 11.96611, 50.75694);
case 35: return new CityInfo("Cadale", "13", 2.7603, 46.3222);
case 36: return new CityInfo("Adado", "05", 6.13603, 46.62761);
case 37: return new CityInfo("Buurhakaba", "04", 2.80257, 44.07805);
case 38: return new CityInfo("Buur Gaabo", "09", -1.21917, 41.83725);
case 39: return new CityInfo("Buulobarde", "07", 3.85375, 45.56744);
case 40: return new CityInfo("Burao", "19", 9.52213, 45.53363);
case 41: return new CityInfo("Bu’aale", "08", 1.08333, 42.58333);
case 42: return new CityInfo("Bosaso", "03", 11.28421, 49.18158);
case 43: return new CityInfo("Bereeda", "03", 11.87037, 51.05795);
case 44: return new CityInfo("Berbera", "20", 10.43959, 45.01432);
case 45: return new CityInfo("Beledweyne", "07", 4.73583, 45.20361);
case 46: return new CityInfo("Baidoa", "04", 3.11383, 43.6498);
case 47: return new CityInfo("Bargaal", "03", 11.28636, 51.0773);
case 48: return new CityInfo("Bandarbeyla", "03", 9.4942, 50.8122);
case 49: return new CityInfo("Baardheere", "06", 2.34464, 42.27644);
case 50: return new CityInfo("Afgooye", "14", 2.1381, 45.1212);
case 51: return new CityInfo("Laascaanood", "22", 8.47738, 47.35971);
case 52: return new CityInfo("Baki", "21", 9.89206, 43.38531);
default: return new CityInfo("Baligubadle", "20", 9, 44.00028);

                                    }                                        
                                }
                            
                        }
                    }
                