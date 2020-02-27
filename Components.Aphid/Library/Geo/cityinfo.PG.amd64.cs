
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
                                    public const string Country = "PG";
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
                            
                                        var cur = (Math.Abs(-3.54964 - lat) + Math.Abs(143.63229 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-7.33778 - lat) + Math.Abs(146.71649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.49119 - lat) + Math.Abs(143.72151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.68372 - lat) + Math.Abs(141.30195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.845 - lat) + Math.Abs(142.94667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.20037 - lat) + Math.Abs(152.16297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.47723 - lat) + Math.Abs(147.15089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.463 - lat) + Math.Abs(143.148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.76536 - lat) + Math.Abs(148.23252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.31639 - lat) + Math.Abs(155.48483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.85746 - lat) + Math.Abs(144.23058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.71065 - lat) + Math.Abs(141.63668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.90752 - lat) + Math.Abs(144.69159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.14755 - lat) + Math.Abs(143.65633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.22152 - lat) + Math.Abs(145.78695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.0341 - lat) + Math.Abs(147.27173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.33105 - lat) + Math.Abs(143.79052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.72333 - lat) + Math.Abs(146.99611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.81847 - lat) + Math.Abs(147.65968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.855 - lat) + Math.Abs(144.63111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.01972 - lat) + Math.Abs(144.96917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.3432 - lat) + Math.Abs(152.26867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.87778 - lat) + Math.Abs(147.73642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.12193 - lat) + Math.Abs(141.29061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.55085 - lat) + Math.Abs(150.13766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.21462 - lat) + Math.Abs(155.63251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.96028 - lat) + Math.Abs(145.77278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.57337 - lat) + Math.Abs(150.79516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.20655 - lat) + Math.Abs(149.54744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.28872 - lat) + Math.Abs(145.86548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.89569 - lat) + Math.Abs(145.39405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.28208 - lat) + Math.Abs(143.99354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.085 - lat) + Math.Abs(145.38667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.55793 - lat) + Math.Abs(147.84635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.07786 - lat) + Math.Abs(143.20893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.2036 - lat) + Math.Abs(146.64014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.74864 - lat) + Math.Abs(155.69147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.22977 - lat) + Math.Abs(155.56598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.06253 - lat) + Math.Abs(144.06609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.21717 - lat) + Math.Abs(142.81832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.13697 - lat) + Math.Abs(142.34913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.61038 - lat) + Math.Abs(150.66207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.31509 - lat) + Math.Abs(150.45742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.43261 - lat) + Math.Abs(154.67098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.7359 - lat) + Math.Abs(144.28834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Wewak", "11", -3.54964, 143.63229);
case 1: return new CityInfo("Wau", "14", -7.33778, 146.71649);
case 2: return new CityInfo("Wabag", "19", -5.49119, 143.72151);
case 3: return new CityInfo("Vanimo", "18", -2.68372, 141.30195);
case 4: return new CityInfo("Tari", "21", -5.845, 142.94667);
case 5: return new CityInfo("Rabaul", "10", -4.20037, 152.16297);
case 6: return new CityInfo("Port Moresby", "20", -9.47723, 147.15089);
case 7: return new CityInfo("Porgera", "19", -5.463, 143.148);
case 8: return new CityInfo("Popondetta", "04", -8.76536, 148.23252);
case 9: return new CityInfo("Panguna", "07", -6.31639, 155.48483);
case 10: return new CityInfo("Mount Hagen", "16", -5.85746, 144.23058);
case 11: return new CityInfo("Morehead", "06", -8.71065, 141.63668);
case 12: return new CityInfo("Minj", "22", -5.90752, 144.69159);
case 13: return new CityInfo("Mendi", "05", -6.14755, 143.65633);
case 14: return new CityInfo("Madang", "12", -5.22152, 145.78695);
case 15: return new CityInfo("Lorengau", "13", -2.0341, 147.27173);
case 16: return new CityInfo("Laiagam", "19", -5.33105, 143.79052);
case 17: return new CityInfo("Lae", "14", -6.72333, 146.99611);
case 18: return new CityInfo("Kwikila", "01", -9.81847, 147.65968);
case 19: return new CityInfo("Kurumul", "22", -5.855, 144.63111);
case 20: return new CityInfo("Kundiawa", "08", -6.01972, 144.96917);
case 21: return new CityInfo("Kokopo", "10", -4.3432, 152.26867);
case 22: return new CityInfo("Kokoda", "04", -8.87778, 147.73642);
case 23: return new CityInfo("Kiunga", "06", -6.12193, 141.29061);
case 24: return new CityInfo("Kimbe", "17", -5.55085, 150.13766);
case 25: return new CityInfo("Kieta", "07", -6.21462, 155.63251);
case 26: return new CityInfo("Kerema", "02", -7.96028, 145.77278);
case 27: return new CityInfo("Kavieng", "15", -2.57337, 150.79516);
case 28: return new CityInfo("Kandrian", "17", -6.20655, 149.54744);
case 29: return new CityInfo("Kainantu", "09", -6.28872, 145.86548);
case 30: return new CityInfo("Ihu", "02", -7.89569, 145.39405);
case 31: return new CityInfo("Ialibu", "05", -6.28208, 143.99354);
case 32: return new CityInfo("Goroka", "09", -6.085, 145.38667);
case 33: return new CityInfo("Finschhafen", "14", -6.55793, 147.84635);
case 34: return new CityInfo("Daru", "06", -9.07786, 143.20893);
case 35: return new CityInfo("Bulolo", "14", -7.2036, 146.64014);
case 36: return new CityInfo("Buin", "07", -6.74864, 155.69147);
case 37: return new CityInfo("Arawa", "07", -6.22977, 155.56598);
case 38: return new CityInfo("Angoram", "11", -4.06253, 144.06609);
case 39: return new CityInfo("Ambunti", "11", -4.21717, 142.81832);
case 40: return new CityInfo("Aitape", "18", -3.13697, 142.34913);
case 41: return new CityInfo("Samarai", "03", -10.61038, 150.66207);
case 42: return new CityInfo("Alotau", "03", -10.31509, 150.45742);
case 43: return new CityInfo("Buka", "07", -5.43261, 154.67098);
default: return new CityInfo("Rauna", "16", -5.7359, 144.28834);

                                    }                                        
                                }
                            
                        }
                    }
                