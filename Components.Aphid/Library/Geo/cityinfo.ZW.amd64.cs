
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
                                    public const string Country = "ZW";
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
                            
                                        var cur = (Math.Abs(-20.32674 - lat) + Math.Abs(30.06648 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-17.93285 - lat) + Math.Abs(25.83066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.67016 - lat) + Math.Abs(30.00589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.78333 - lat) + Math.Abs(29.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.31159 - lat) + Math.Abs(31.57561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.88972 - lat) + Math.Abs(31.24472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.52785 - lat) + Math.Abs(32.12843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.03333 - lat) + Math.Abs(29.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.03333 - lat) + Math.Abs(30.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.48333 - lat) + Math.Abs(27.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.89112 - lat) + Math.Abs(32.69781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.96167 - lat) + Math.Abs(32.40557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.70587 - lat) + Math.Abs(32.16796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.21667 - lat) + Math.Abs(32.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.88333 - lat) + Math.Abs(30.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.03333 - lat) + Math.Abs(30.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.27924 - lat) + Math.Abs(30.52828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.39699 - lat) + Math.Abs(32.22677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.9707 - lat) + Math.Abs(32.67086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.64322 - lat) + Math.Abs(31.784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.77251 - lat) + Math.Abs(31.58381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.89387 - lat) + Math.Abs(30.16828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.50404 - lat) + Math.Abs(30.97388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.06373 - lat) + Math.Abs(30.82766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.03665 - lat) + Math.Abs(30.48225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.18527 - lat) + Math.Abs(31.55193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.91667 - lat) + Math.Abs(31.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.13901 - lat) + Math.Abs(31.84933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.93149 - lat) + Math.Abs(27.80696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.33225 - lat) + Math.Abs(30.17768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.92809 - lat) + Math.Abs(29.81486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.80993 - lat) + Math.Abs(29.69247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.51667 - lat) + Math.Abs(28.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.31563 - lat) + Math.Abs(27.05729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.33328 - lat) + Math.Abs(29.91534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.67563 - lat) + Math.Abs(28.84687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.78333 - lat) + Math.Abs(29.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.36446 - lat) + Math.Abs(26.49877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.27733 - lat) + Math.Abs(32.0515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.82772 - lat) + Math.Abs(31.05337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.45 - lat) + Math.Abs(29.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.93622 - lat) + Math.Abs(29.00698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.20476 - lat) + Math.Abs(28.9349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.35514 - lat) + Math.Abs(31.06718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.53333 - lat) + Math.Abs(29.28502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28979 - lat) + Math.Abs(28.92261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.06667 - lat) + Math.Abs(31.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.61667 - lat) + Math.Abs(26.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.38333 - lat) + Math.Abs(30.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.02112 - lat) + Math.Abs(30.89218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.03333 - lat) + Math.Abs(28.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.05 - lat) + Math.Abs(31.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.18833 - lat) + Math.Abs(32.62365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.36667 - lat) + Math.Abs(30.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.8 - lat) + Math.Abs(32.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.13021 - lat) + Math.Abs(30.14074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.06294 - lat) + Math.Abs(29.89246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.72289 - lat) + Math.Abs(31.11462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.15 - lat) + Math.Abs(28.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.62027 - lat) + Math.Abs(27.34139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.30192 - lat) + Math.Abs(31.33056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.21667 - lat) + Math.Abs(30 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.25283 - lat) + Math.Abs(30.8473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.38333 - lat) + Math.Abs(30.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.89 - lat) + Math.Abs(31.1475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.01274 - lat) + Math.Abs(31.07555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zvishavane", "08", -20.32674, 30.06648);
case 1: return new CityInfo("Victoria Falls", "06", -17.93285, 25.83066);
case 2: return new CityInfo("Shurugwi", "02", -19.67016, 30.00589);
case 3: return new CityInfo("Shangani", "02", -19.78333, 29.36667);
case 4: return new CityInfo("Shamva", "03", -17.31159, 31.57561);
case 5: return new CityInfo("Ruwa", "04", -17.88972, 31.24472);
case 6: return new CityInfo("Rusape", "01", -18.52785, 32.12843);
case 7: return new CityInfo("Redcliff", "02", -19.03333, 29.78333);
case 8: return new CityInfo("Raffingora", "05", -17.03333, 30.43333);
case 9: return new CityInfo("Plumtree", "07", -20.48333, 27.81667);
case 10: return new CityInfo("Penhalonga", "01", -18.89112, 32.69781);
case 11: return new CityInfo("Odzi", "01", -18.96167, 32.40557);
case 12: return new CityInfo("Nyazura", "01", -18.70587, 32.16796);
case 13: return new CityInfo("Nyanga", "01", -18.21667, 32.75);
case 14: return new CityInfo("Norton", "05", -17.88333, 30.7);
case 15: return new CityInfo("Mvurwi", "03", -17.03333, 30.85);
case 16: return new CityInfo("Mvuma", "02", -19.27924, 30.52828);
case 17: return new CityInfo("Mutoko", "04", -17.39699, 32.22677);
case 18: return new CityInfo("Mutare", "01", -18.9707, 32.67086);
case 19: return new CityInfo("Murehwa", "04", -17.64322, 31.784);
case 20: return new CityInfo("Mount Darwin", "03", -16.77251, 31.58381);
case 21: return new CityInfo("Mhangura", "05", -16.89387, 30.16828);
case 22: return new CityInfo("Mazowe", "03", -17.50404, 30.97388);
case 23: return new CityInfo("Masvingo", "08", -20.06373, 30.82766);
case 24: return new CityInfo("Mashava", "08", -20.03665, 30.48225);
case 25: return new CityInfo("Marondera", "04", -18.18527, 31.55193);
case 26: return new CityInfo("Madziwa", "03", -16.91667, 31.53333);
case 27: return new CityInfo("Macheke", "04", -18.13901, 31.84933);
case 28: return new CityInfo("Lupane", "06", -18.93149, 27.80696);
case 29: return new CityInfo("Lalapanzi", "02", -19.33225, 30.17768);
case 30: return new CityInfo("Kwekwe", "02", -18.92809, 29.81486);
case 31: return new CityInfo("Karoi", "05", -16.80993, 29.69247);
case 32: return new CityInfo("Kariba", "05", -16.51667, 28.8);
case 33: return new CityInfo("Kamativi Mine", "06", -18.31563, 27.05729);
case 34: return new CityInfo("Kadoma", "05", -18.33328, 29.91534);
case 35: return new CityInfo("Inyati", "06", -19.67563, 28.84687);
case 36: return new CityInfo("Insiza", "07", -19.78333, 29.2);
case 37: return new CityInfo("Hwange", "06", -18.36446, 26.49877);
case 38: return new CityInfo("Headlands", "01", -18.27733, 32.0515);
case 39: return new CityInfo("Harare", "10", -17.82772, 31.05337);
case 40: return new CityInfo("Gweru", "02", -19.45, 29.81667);
case 41: return new CityInfo("Gwanda", "07", -20.93622, 29.00698);
case 42: return new CityInfo("Gokwe", "02", -18.20476, 28.9349);
case 43: return new CityInfo("Glendale", "03", -17.35514, 31.06718);
case 44: return new CityInfo("Filabusi", "07", -20.53333, 29.28502);
case 45: return new CityInfo("Esigodini", "07", -20.28979, 28.92261);
case 46: return new CityInfo("Dorowa Mining Lease", "01", -19.06667, 31.75);
case 47: return new CityInfo("Dete", "06", -18.61667, 26.86667);
case 48: return new CityInfo("Concession", "03", -17.38333, 30.95);
case 49: return new CityInfo("Chivhu", "04", -19.02112, 30.89218);
case 50: return new CityInfo("Chirundu", "05", -16.03333, 28.85);
case 51: return new CityInfo("Chiredzi", "08", -21.05, 31.66667);
case 52: return new CityInfo("Chipinge", "01", -20.18833, 32.62365);
case 53: return new CityInfo("Chinhoyi", "05", -17.36667, 30.2);
case 54: return new CityInfo("Chimanimani", "01", -19.8, 32.86667);
case 55: return new CityInfo("Chegutu", "05", -18.13021, 30.14074);
case 56: return new CityInfo("Chakari", "05", -18.06294, 29.89246);
case 57: return new CityInfo("Centenary", "03", -16.72289, 31.11462);
case 58: return new CityInfo("Bulawayo", "09", -20.15, 28.58333);
case 59: return new CityInfo("Binga", "06", -17.62027, 27.34139);
case 60: return new CityInfo("Bindura", "03", -17.30192, 31.33056);
case 61: return new CityInfo("Beitbridge", "07", -22.21667, 30);
case 62: return new CityInfo("Beatrice", "04", -18.25283, 30.8473);
case 63: return new CityInfo("Banket", "05", -17.38333, 30.4);
case 64: return new CityInfo("Epworth", "10", -17.89, 31.1475);
default: return new CityInfo("Chitungwiza", "10", -18.01274, 31.07555);

                                    }                                        
                                }
                            
                        }
                    }
                