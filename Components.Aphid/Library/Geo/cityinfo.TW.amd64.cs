
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
                                    public const string Country = "TW";
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
                            
                                        var cur = (Math.Abs(23.70944 - lat) + Math.Abs(120.54333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(23.12493 - lat) + Math.Abs(120.46138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.95671 - lat) + Math.Abs(120.57608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.46515 - lat) + Math.Abs(120.44927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.9896 - lat) + Math.Abs(121.3187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.75991 - lat) + Math.Abs(121.14457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.04776 - lat) + Math.Abs(121.53185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.45944 - lat) + Math.Abs(120.33222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.30694 - lat) + Math.Abs(120.31056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.99083 - lat) + Math.Abs(120.21333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.25 - lat) + Math.Abs(120.71694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.1469 - lat) + Math.Abs(120.6839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.88373 - lat) + Math.Abs(121.29043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.01427 - lat) + Math.Abs(121.46719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.96639 - lat) + Math.Abs(120.96952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.48556 - lat) + Math.Abs(120.44472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.67135 - lat) + Math.Abs(120.48814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.91566 - lat) + Math.Abs(120.66387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.56427 - lat) + Math.Abs(120.82367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.5654 - lat) + Math.Abs(119.58627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.74639 - lat) + Math.Abs(120.7525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.62659 - lat) + Math.Abs(120.36126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.61626 - lat) + Math.Abs(120.31333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.757 - lat) + Math.Abs(121.753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.97694 - lat) + Math.Abs(121.60444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.96005 - lat) + Math.Abs(121.53892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.80361 - lat) + Math.Abs(120.96861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.00417 - lat) + Math.Abs(120.74389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.83833 - lat) + Math.Abs(121.00778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.10957 - lat) + Math.Abs(121.84424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.43415 - lat) + Math.Abs(118.31712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.12825 - lat) + Math.Abs(121.7419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.47917 - lat) + Math.Abs(120.44889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.07327 - lat) + Math.Abs(120.56276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.99368 - lat) + Math.Abs(121.29696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.7583 - lat) + Math.Abs(121.1444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.15039 - lat) + Math.Abs(119.93284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.95908 - lat) + Math.Abs(120.68516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Douliu", "04", 23.70944, 120.54333);
case 1: return new CityInfo("Yujing", "04", 23.12493, 120.46138);
case 2: return new CityInfo("Yuanlin", "04", 23.95671, 120.57608);
case 3: return new CityInfo("Donggang", "04", 22.46515, 120.44927);
case 4: return new CityInfo("Taoyuan", "04", 24.9896, 121.3187);
case 5: return new CityInfo("Taitung", "04", 22.75991, 121.14457);
case 6: return new CityInfo("Taipei", "04", 25.04776, 121.53185);
case 7: return new CityInfo("Taibao", "04", 23.45944, 120.33222);
case 8: return new CityInfo("Xinying", "04", 23.30694, 120.31056);
case 9: return new CityInfo("Tainan", "04", 22.99083, 120.21333);
case 10: return new CityInfo("Fengyuan", "04", 24.25, 120.71694);
case 11: return new CityInfo("Taichung", "04", 24.1469, 120.6839);
case 12: return new CityInfo("Daxi", "04", 24.88373, 121.29043);
case 13: return new CityInfo("Banqiao", "03", 25.01427, 121.46719);
case 14: return new CityInfo("Puli", "04", 23.96639, 120.96952);
case 15: return new CityInfo("Pizitou", "04", 23.48556, 120.44472);
case 16: return new CityInfo("Pingtung", "04", 22.67135, 120.48814);
case 17: return new CityInfo("Nantou", "04", 23.91566, 120.66387);
case 18: return new CityInfo("Miaoli", "04", 24.56427, 120.82367);
case 19: return new CityInfo("Magong", "04", 23.5654, 119.58627);
case 20: return new CityInfo("Lugu", "04", 23.74639, 120.7525);
case 21: return new CityInfo("Fengshan", "02", 22.62659, 120.36126);
case 22: return new CityInfo("Kaohsiung", "02", 22.61626, 120.31333);
case 23: return new CityInfo("Yilan", "04", 24.757, 121.753);
case 24: return new CityInfo("Hualien City", "04", 23.97694, 121.60444);
case 25: return new CityInfo("Xindian", "03", 24.96005, 121.53892);
case 26: return new CityInfo("Hsinchu", "04", 24.80361, 120.96861);
case 27: return new CityInfo("Hengchun", "04", 22.00417, 120.74389);
case 28: return new CityInfo("Zhubei", "04", 24.83833, 121.00778);
case 29: return new CityInfo("Jiufen", "03", 25.10957, 121.84424);
case 30: return new CityInfo("Jincheng", "01", 24.43415, 118.31712);
case 31: return new CityInfo("Keelung", "04", 25.12825, 121.7419);
case 32: return new CityInfo("Jiayi Shi", "04", 23.47917, 120.44889);
case 33: return new CityInfo("Chang-hua", "04", 24.07327, 120.56276);
case 34: return new CityInfo("Taoyuan City", "04", 24.99368, 121.29696);
case 35: return new CityInfo("Taitung City", "04", 22.7583, 121.1444);
case 36: return new CityInfo("Nangan", "01", 26.15039, 119.93284);
default: return new CityInfo("Zhongxing New Village", "04", 23.95908, 120.68516);

                                    }                                        
                                }
                            
                        }
                    }
                