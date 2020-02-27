
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
                                    public const string Country = "LA";
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
                            
                                        var cur = (Math.Abs(17.96667 - lat) + Math.Abs(102.6 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(20.4164 - lat) + Math.Abs(104.045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.5703 - lat) + Math.Abs(104.7622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.71652 - lat) + Math.Abs(106.41744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.6808 - lat) + Math.Abs(102.1003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.12022 - lat) + Math.Abs(105.79898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32459 - lat) + Math.Abs(103.99378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.75859 - lat) + Math.Abs(102.18232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.69229 - lat) + Math.Abs(101.98368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.25756 - lat) + Math.Abs(101.71032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.9235 - lat) + Math.Abs(102.44784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.43317 - lat) + Math.Abs(106.38272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.19206 - lat) + Math.Abs(101.14789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.91006 - lat) + Math.Abs(101.67348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.10116 - lat) + Math.Abs(105.65416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.4494 - lat) + Math.Abs(103.1917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4953 - lat) + Math.Abs(102.4153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.53399 - lat) + Math.Abs(106.02401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.18154 - lat) + Math.Abs(106.23038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3942 - lat) + Math.Abs(103.6611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.90997 - lat) + Math.Abs(104.00626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.96504 - lat) + Math.Abs(100.82074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.8694 - lat) + Math.Abs(102.11153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.07833 - lat) + Math.Abs(102.50608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11785 - lat) + Math.Abs(105.85469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.41027 - lat) + Math.Abs(104.83068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.73289 - lat) + Math.Abs(101.39815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.22926 - lat) + Math.Abs(102.25319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.591 - lat) + Math.Abs(104.60388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.88601 - lat) + Math.Abs(102.13503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.9486 - lat) + Math.Abs(101.40188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.22572 - lat) + Math.Abs(104.73119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.70297 - lat) + Math.Abs(105.28211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.89204 - lat) + Math.Abs(105.87787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.56286 - lat) + Math.Abs(103.72671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41705 - lat) + Math.Abs(106.69461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.24253 - lat) + Math.Abs(104.21281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.27 - lat) + Math.Abs(100.4178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6803 - lat) + Math.Abs(106.58212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8132 - lat) + Math.Abs(106.93434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.81071 - lat) + Math.Abs(106.83184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.2467 - lat) + Math.Abs(100.45401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.17193 - lat) + Math.Abs(102.72562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.40677 - lat) + Math.Abs(104.22379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.53212 - lat) + Math.Abs(101.44678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.46667 - lat) + Math.Abs(107.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.02207 - lat) + Math.Abs(107.26016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.14895 - lat) + Math.Abs(103.85895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.34222 - lat) + Math.Abs(104.34464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.94515 - lat) + Math.Abs(104.51722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.32792 - lat) + Math.Abs(103.40856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.81444 - lat) + Math.Abs(106.93444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.34582 - lat) + Math.Abs(106.72368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vientiane", "24", 17.96667, 102.6);
case 1: return new CityInfo("Xam Nua", "03", 20.4164, 104.045);
case 2: return new CityInfo("Savannakhet", "20", 16.5703, 104.7622);
case 3: return new CityInfo("Salavan", "19", 15.71652, 106.41744);
case 4: return new CityInfo("Phôngsali", "18", 21.6808, 102.1003);
case 5: return new CityInfo("Pakse", "02", 15.12022, 105.79898);
case 6: return new CityInfo("Pakkading", "23", 18.32459, 103.99378);
case 7: return new CityInfo("Ban Xiang-Ngeun", "17", 19.75859, 102.18232);
case 8: return new CityInfo("Muang Xay", "07", 20.69229, 101.98368);
case 9: return new CityInfo("Sainyabuli", "13", 19.25756, 101.71032);
case 10: return new CityInfo("Vangviang", "27", 18.9235, 102.44784);
case 11: return new CityInfo("Ban Thatèng", "26", 15.43317, 106.38272);
case 12: return new CityInfo("Muang Sing", "16", 21.19206, 101.14789);
case 13: return new CityInfo("Muang Sanakham", "27", 17.91006, 101.67348);
case 14: return new CityInfo("Phônthong", "02", 15.10116, 105.65416);
case 15: return new CityInfo("Muang Phônsavan", "14", 19.4494, 103.1917);
case 16: return new CityInfo("Muang Phôn-Hông", "27", 18.4953, 102.4153);
case 17: return new CityInfo("Muang Phin", "20", 16.53399, 106.02401);
case 18: return new CityInfo("Pakxong", "02", 15.18154, 106.23038);
case 19: return new CityInfo("Pakxan", "23", 18.3942, 103.6611);
case 20: return new CityInfo("Muang Mok", "14", 18.90997, 104.00626);
case 21: return new CityInfo("Muang Long", "16", 20.96504, 100.82074);
case 22: return new CityInfo("Ban Pakla", "07", 20.8694, 102.11153);
case 23: return new CityInfo("Khoa", "18", 21.07833, 102.50608);
case 24: return new CityInfo("Muang Không", "02", 14.11785, 105.85469);
case 25: return new CityInfo("Thakhèk", "15", 17.41027, 104.83068);
case 26: return new CityInfo("Muang Kènthao", "13", 17.73289, 101.39815);
case 27: return new CityInfo("Muang Kasi", "27", 19.22926, 102.25319);
case 28: return new CityInfo("Muang Hinboun", "15", 17.591, 104.60388);
case 29: return new CityInfo("Luang Prabang", "17", 19.88601, 102.13503);
case 30: return new CityInfo("Luang Namtha", "16", 20.9486, 101.40188);
case 31: return new CityInfo("Muang Khamkeut", "23", 18.22572, 104.73119);
case 32: return new CityInfo("Ban Dônghén", "20", 16.70297, 105.28211);
case 33: return new CityInfo("Champasak", "02", 14.89204, 105.87787);
case 34: return new CityInfo("Borikhan", "23", 18.56286, 103.72671);
case 35: return new CityInfo("Lamam", "26", 15.41705, 106.69461);
case 36: return new CityInfo("Ban Nahin", "23", 18.24253, 104.21281);
case 37: return new CityInfo("Ban Houayxay", "22", 20.27, 100.4178);
case 38: return new CityInfo("Ban Hatgnao", "01", 14.6803, 106.58212);
case 39: return new CityInfo("Ban Fangdèng", "01", 14.8132, 106.93434);
case 40: return new CityInfo("Attapeu", "01", 14.81071, 106.83184);
case 41: return new CityInfo("Ban Houakhoua", "22", 20.2467, 100.45401);
case 42: return new CityInfo("Ban Namnga", "18", 21.17193, 102.72562);
case 43: return new CityInfo("Viangxai", "03", 20.40677, 104.22379);
case 44: return new CityInfo("Muang Nalè", "16", 20.53212, 101.44678);
case 45: return new CityInfo("Dak Cheung", "26", 15.46667, 107.26667);
case 46: return new CityInfo("Sanaxy", "01", 15.02207, 107.26016);
case 47: return new CityInfo("Huameung", "03", 20.14895, 103.85895);
case 48: return new CityInfo("Viengxay", "03", 20.34222, 104.34464);
case 49: return new CityInfo("Xamtay", "03", 19.94515, 104.51722);
case 50: return new CityInfo("Viengthong", "03", 20.32792, 103.40856);
case 51: return new CityInfo("Xaysetha", "01", 14.81444, 106.93444);
default: return new CityInfo("Sekong", "26", 15.34582, 106.72368);

                                    }                                        
                                }
                            
                        }
                    }
                