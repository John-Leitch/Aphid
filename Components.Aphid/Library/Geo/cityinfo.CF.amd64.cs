
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
                                    public const string Country = "CF";
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
                            
                                        var cur = (Math.Abs(5.03144 - lat) + Math.Abs(25.13614 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(4.31325 - lat) + Math.Abs(22.55524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07771 - lat) + Math.Abs(22.40075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.39586 - lat) + Math.Abs(26.49211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41091 - lat) + Math.Abs(20.64728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.31902 - lat) + Math.Abs(21.17861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.62275 - lat) + Math.Abs(21.88645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.26793 - lat) + Math.Abs(21.22468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.64816 - lat) + Math.Abs(22.26331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.54233 - lat) + Math.Abs(21.98633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28488 - lat) + Math.Abs(22.78818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74132 - lat) + Math.Abs(22.81838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.76795 - lat) + Math.Abs(20.67565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.02667 - lat) + Math.Abs(21.20876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.71801 - lat) + Math.Abs(19.07389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.24269 - lat) + Math.Abs(16.44059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.52494 - lat) + Math.Abs(16.04583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.64153 - lat) + Math.Abs(18.59364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.86781 - lat) + Math.Abs(17.98923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.99337 - lat) + Math.Abs(19.96186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.98961 - lat) + Math.Abs(19.18744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.69937 - lat) + Math.Abs(18.62903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.11775 - lat) + Math.Abs(15.13926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.96075 - lat) + Math.Abs(18.7035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.94273 - lat) + Math.Abs(15.87735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.31933 - lat) + Math.Abs(16.37992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.50734 - lat) + Math.Abs(18.2767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.93404 - lat) + Math.Abs(15.59599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.49263 - lat) + Math.Abs(17.45518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.31887 - lat) + Math.Abs(17.46953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.80048 - lat) + Math.Abs(18.12747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.25671 - lat) + Math.Abs(18.41583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.26116 - lat) + Math.Abs(15.79216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.30082 - lat) + Math.Abs(18.2833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.66667 - lat) + Math.Abs(15.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.36122 - lat) + Math.Abs(18.55496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zemio", "05", 5.03144, 25.13614);
case 1: return new CityInfo("Ouango", "08", 4.31325, 22.55524);
case 2: return new CityInfo("Ouadda", "03", 8.07771, 22.40075);
case 3: return new CityInfo("Obo", "05", 5.39586, 26.49211);
case 4: return new CityInfo("Ndélé", "01", 8.41091, 20.64728);
case 5: return new CityInfo("Mobaye", "02", 4.31902, 21.17861);
case 6: return new CityInfo("Kembé", "02", 4.62275, 21.88645);
case 7: return new CityInfo("Ippy", "11", 6.26793, 21.22468);
case 8: return new CityInfo("Gambo", "08", 4.64816, 22.26331);
case 9: return new CityInfo("Bria", "03", 6.54233, 21.98633);
case 10: return new CityInfo("Birao", "14", 10.28488, 22.78818);
case 11: return new CityInfo("Bangassou", "08", 4.74132, 22.81838);
case 12: return new CityInfo("Bambari", "11", 5.76795, 20.67565);
case 13: return new CityInfo("Alindao", "02", 5.02667, 21.20876);
case 14: return new CityInfo("Sibut", "06", 5.71801, 19.07389);
case 15: return new CityInfo("Paoua", "13", 7.24269, 16.44059);
case 16: return new CityInfo("Nola", "16", 3.52494, 16.04583);
case 17: return new CityInfo("Mongoumba", "07", 3.64153, 18.59364);
case 18: return new CityInfo("Mbaïki", "07", 3.86781, 17.98923);
case 19: return new CityInfo("Kouango", "11", 4.99337, 19.96186);
case 20: return new CityInfo("Kaga Bandoro", "15", 6.98961, 19.18744);
case 21: return new CityInfo("Kabo", "12", 7.69937, 18.62903);
case 22: return new CityInfo("Gamboula", "04", 4.11775, 15.13926);
case 23: return new CityInfo("Damara", "17", 4.96075, 18.7035);
case 24: return new CityInfo("Carnot", "04", 4.94273, 15.87735);
case 25: return new CityInfo("Bozoum", "13", 6.31933, 16.37992);
case 26: return new CityInfo("Bouca", "12", 6.50734, 18.2767);
case 27: return new CityInfo("Bouar", "09", 5.93404, 15.59599);
case 28: return new CityInfo("Bossangoa", "12", 6.49263, 17.45518);
case 29: return new CityInfo("Boda", "07", 4.31887, 17.46953);
case 30: return new CityInfo("Boali", "17", 4.80048, 18.12747);
case 31: return new CityInfo("Bimbo", "17", 4.25671, 18.41583);
case 32: return new CityInfo("Berbérati", "04", 4.26116, 15.79216);
case 33: return new CityInfo("Batangafo", "12", 7.30082, 18.2833);
case 34: return new CityInfo("Baoro", "09", 5.66667, 15.96667);
default: return new CityInfo("Bangui", "18", 4.36122, 18.55496);

                                    }                                        
                                }
                            
                        }
                    }
                