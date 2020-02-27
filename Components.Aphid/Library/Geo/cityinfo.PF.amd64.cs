
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
                                    public const string Country = "PF";
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
                            
                                        var cur = (Math.Abs(-9.80342 - lat) + Math.Abs(-139.04202 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-23.12322 - lat) + Math.Abs(-134.96858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.50741 - lat) + Math.Abs(-151.74913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.78333 - lat) + Math.Abs(-149.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.72891 - lat) + Math.Abs(-151.44482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.76099 - lat) + Math.Abs(-149.31676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.53333 - lat) + Math.Abs(-149.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.79139 - lat) + Math.Abs(-151.48893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.5 - lat) + Math.Abs(-149.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.84645 - lat) + Math.Abs(-149.26682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.74744 - lat) + Math.Abs(-149.16123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.75139 - lat) + Math.Abs(-149.35602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.63333 - lat) + Math.Abs(-149.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.73831 - lat) + Math.Abs(-149.22376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.51667 - lat) + Math.Abs(-149.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.49538 - lat) + Math.Abs(-149.87437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.53733 - lat) + Math.Abs(-149.5665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.75 - lat) + Math.Abs(-149.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.51863 - lat) + Math.Abs(-149.82193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.68333 - lat) + Math.Abs(-149.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.77207 - lat) + Math.Abs(-149.41341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.45133 - lat) + Math.Abs(-151.34191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.34722 - lat) + Math.Abs(-149.48487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.50648 - lat) + Math.Abs(-149.48899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.56667 - lat) + Math.Abs(-149.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.6 - lat) + Math.Abs(-149.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.79217 - lat) + Math.Abs(-151.01091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.56352 - lat) + Math.Abs(-149.86905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.73535 - lat) + Math.Abs(-151.0327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.71085 - lat) + Math.Abs(-151.03455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.66917 - lat) + Math.Abs(-149.30919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.48679 - lat) + Math.Abs(-151.74102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.55 - lat) + Math.Abs(-149.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.47814 - lat) + Math.Abs(-151.35126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.51667 - lat) + Math.Abs(-149.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.50148 - lat) + Math.Abs(-151.72135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.55 - lat) + Math.Abs(-149.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.74395 - lat) + Math.Abs(-149.32444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.91093 - lat) + Math.Abs(-140.09972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.46647 - lat) + Math.Abs(-136.46328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Atuona", "04", -9.80342, -139.04202);
case 1: return new CityInfo("Rikitea", "03", -23.12322, -134.96858);
case 2: return new CityInfo("Vaitape", "02", -16.50741, -151.74913);
case 3: return new CityInfo("Vairao", "01", -17.78333, -149.28333);
case 4: return new CityInfo("Uturoa", "02", -16.72891, -151.44482);
case 5: return new CityInfo("Tohautu", "01", -17.76099, -149.31676);
case 6: return new CityInfo("Tiarei", "00", -17.53333, -149.33333);
case 7: return new CityInfo("Tevaitoa", "00", -16.79139, -151.48893);
case 8: return new CityInfo("Teavaro", "01", -17.5, -149.76667);
case 9: return new CityInfo("Teahupoo", "01", -17.84645, -149.26682);
case 10: return new CityInfo("Tautira", "01", -17.74744, -149.16123);
case 11: return new CityInfo("Taunoa", "01", -17.75139, -149.35602);
case 12: return new CityInfo("Punaauia", "01", -17.63333, -149.6);
case 13: return new CityInfo("Pueu", "01", -17.73831, -149.22376);
case 14: return new CityInfo("Pirae", "01", -17.51667, -149.53333);
case 15: return new CityInfo("Papetoai", "01", -17.49538, -149.87437);
case 16: return new CityInfo("Papeete", "01", -17.53733, -149.5665);
case 17: return new CityInfo("Papao", "01", -17.75, -149.55);
case 18: return new CityInfo("Paopao", "01", -17.51863, -149.82193);
case 19: return new CityInfo("Paea", "01", -17.68333, -149.58333);
case 20: return new CityInfo("Otutara", "01", -17.77207, -149.41341);
case 21: return new CityInfo("Moerai", "05", -22.45133, -151.34191);
case 22: return new CityInfo("Mataura", "00", -23.34722, -149.48487);
case 23: return new CityInfo("Mahina", "01", -17.50648, -149.48899);
case 24: return new CityInfo("Mahaena", "00", -17.56667, -149.31667);
case 25: return new CityInfo("Hitiaa", "00", -17.6, -149.3);
case 26: return new CityInfo("Haapu", "02", -16.79217, -151.01091);
case 27: return new CityInfo("Haapiti", "01", -17.56352, -149.86905);
case 28: return new CityInfo("Fitii", "02", -16.73535, -151.0327);
case 29: return new CityInfo("Fare", "02", -16.71085, -151.03455);
case 30: return new CityInfo("Faone", "01", -17.66917, -149.30919);
case 31: return new CityInfo("Faanui", "00", -16.48679, -151.74102);
case 32: return new CityInfo("Faaa", "01", -17.55, -149.6);
case 33: return new CityInfo("Avera", "05", -22.47814, -151.35126);
case 34: return new CityInfo("Arue", "01", -17.51667, -149.5);
case 35: return new CityInfo("Anau", "02", -16.50148, -151.72135);
case 36: return new CityInfo("Afareaitu", "01", -17.55, -149.78333);
case 37: return new CityInfo("Afaahiti", "00", -17.74395, -149.32444);
case 38: return new CityInfo("Taiohae", "04", -8.91093, -140.09972);
default: return new CityInfo("Tapuarava", "03", -18.46647, -136.46328);

                                    }                                        
                                }
                            
                        }
                    }
                