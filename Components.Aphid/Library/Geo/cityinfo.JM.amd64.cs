
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
                                    public const string Country = "JM";
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
                            
                                        var cur = (Math.Abs(17.8748 - lat) + Math.Abs(-76.56245 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(18.06667 - lat) + Math.Abs(-77.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.41211 - lat) + Math.Abs(-77.72183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.31482 - lat) + Math.Abs(-77.52067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96076 - lat) + Math.Abs(-76.51427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07916 - lat) + Math.Abs(-76.78473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99107 - lat) + Math.Abs(-76.95742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.8878 - lat) + Math.Abs(-77.66713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16709 - lat) + Math.Abs(-77.70348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.93578 - lat) + Math.Abs(-76.4573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21895 - lat) + Math.Abs(-78.1332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05336 - lat) + Math.Abs(-77.69836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.44854 - lat) + Math.Abs(-78.07321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.43581 - lat) + Math.Abs(-77.20098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45962 - lat) + Math.Abs(-77.3357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.774 - lat) + Math.Abs(-77.26107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.30123 - lat) + Math.Abs(-77.55259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16586 - lat) + Math.Abs(-76.96417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.25478 - lat) + Math.Abs(-76.88799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.84019 - lat) + Math.Abs(-77.28223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03535 - lat) + Math.Abs(-77.41166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.93738 - lat) + Math.Abs(-76.84062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.95032 - lat) + Math.Abs(-76.88215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.36849 - lat) + Math.Abs(-76.88946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17615 - lat) + Math.Abs(-76.4509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08988 - lat) + Math.Abs(-77.10759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26158 - lat) + Math.Abs(-78.07117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.40319 - lat) + Math.Abs(-76.94641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.90918 - lat) + Math.Abs(-77.09718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.94144 - lat) + Math.Abs(-77.10898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4076 - lat) + Math.Abs(-77.10312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.00747 - lat) + Math.Abs(-76.78319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26844 - lat) + Math.Abs(-78.3481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96526 - lat) + Math.Abs(-77.60528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.88145 - lat) + Math.Abs(-76.40927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.07767 - lat) + Math.Abs(-76.42577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47116 - lat) + Math.Abs(-77.91883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.27556 - lat) + Math.Abs(-77.11177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01375 - lat) + Math.Abs(-76.75186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04 - lat) + Math.Abs(-77.33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96454 - lat) + Math.Abs(-77.24515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03333 - lat) + Math.Abs(-76.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.34464 - lat) + Math.Abs(-77.79544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04168 - lat) + Math.Abs(-77.50714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04444 - lat) + Math.Abs(-76.27735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.96667 - lat) + Math.Abs(-77.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16069 - lat) + Math.Abs(-77.76349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.31023 - lat) + Math.Abs(-77.01045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45095 - lat) + Math.Abs(-78.17356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.12587 - lat) + Math.Abs(-77.14823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.81007 - lat) + Math.Abs(-77.24061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.13683 - lat) + Math.Abs(-77.03171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.0721 - lat) + Math.Abs(-77.75059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.99702 - lat) + Math.Abs(-76.79358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16184 - lat) + Math.Abs(-77.27049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.30922 - lat) + Math.Abs(-76.85482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.19882 - lat) + Math.Abs(-76.56539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.87569 - lat) + Math.Abs(-77.23711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.01248 - lat) + Math.Abs(-76.79928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.03578 - lat) + Math.Abs(-76.71783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.93361 - lat) + Math.Abs(-76.27254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.32642 - lat) + Math.Abs(-77.00971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29407 - lat) + Math.Abs(-78.15469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.49358 - lat) + Math.Abs(-77.65587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.18333 - lat) + Math.Abs(-77.08536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.92397 - lat) + Math.Abs(-76.58824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.468 - lat) + Math.Abs(-77.53633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.45873 - lat) + Math.Abs(-77.39997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23731 - lat) + Math.Abs(-77.97626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.91184 - lat) + Math.Abs(-76.24864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05078 - lat) + Math.Abs(-76.79372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.20783 - lat) + Math.Abs(-77.50754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08333 - lat) + Math.Abs(-77.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39747 - lat) + Math.Abs(-78.10337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.31326 - lat) + Math.Abs(-77.90252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.88678 - lat) + Math.Abs(-77.59022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.23287 - lat) + Math.Abs(-76.66118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.10205 - lat) + Math.Abs(-77.00541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.16602 - lat) + Math.Abs(-78.02702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02636 - lat) + Math.Abs(-77.84873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29503 - lat) + Math.Abs(-77.95112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.9482 - lat) + Math.Abs(-76.34916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.39216 - lat) + Math.Abs(-77.26429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.17228 - lat) + Math.Abs(-77.64375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3637 - lat) + Math.Abs(-78.03736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.2717 - lat) + Math.Abs(-76.76523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4103 - lat) + Math.Abs(-77.93166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.86932 - lat) + Math.Abs(-77.56769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.30768 - lat) + Math.Abs(-77.35335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.29434 - lat) + Math.Abs(-77.54239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.15287 - lat) + Math.Abs(-77.47121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.2624 - lat) + Math.Abs(-77.64586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yallahs", "14", 17.8748, -76.56245);
case 1: return new CityInfo("Williamsfield", "04", 18.06667, -77.46667);
case 2: return new CityInfo("Wakefield", "15", 18.41211, -77.72183);
case 3: return new CityInfo("Ulster Spring", "15", 18.31482, -77.52067);
case 4: return new CityInfo("Trinity Ville", "14", 17.96076, -76.51427);
case 5: return new CityInfo("Stony Hill", "08", 18.07916, -76.78473);
case 6: return new CityInfo("Spanish Town", "10", 17.99107, -76.95742);
case 7: return new CityInfo("Southfield", "11", 17.8878, -77.66713);
case 8: return new CityInfo("Siloah", "11", 18.16709, -77.70348);
case 9: return new CityInfo("Seaforth", "14", 17.93578, -76.4573);
case 10: return new CityInfo("Savanna-la-Mar", "16", 18.21895, -78.1332);
case 11: return new CityInfo("Santa Cruz", "11", 18.05336, -77.69836);
case 12: return new CityInfo("Sandy Bay", "02", 18.44854, -78.07321);
case 13: return new CityInfo("Saint Ann’s Bay", "09", 18.43581, -77.20098);
case 14: return new CityInfo("Runaway Bay", "09", 18.45962, -77.3357);
case 15: return new CityInfo("Rocky Point", "01", 17.774, -77.26107);
case 16: return new CityInfo("Rock Spring", "15", 18.30123, -77.55259);
case 17: return new CityInfo("Riversdale", "10", 18.16586, -76.96417);
case 18: return new CityInfo("Richmond", "13", 18.25478, -76.88799);
case 19: return new CityInfo("Race Course", "01", 17.84019, -77.28223);
case 20: return new CityInfo("Porus", "04", 18.03535, -77.41166);
case 21: return new CityInfo("Port Royal", "17", 17.93738, -76.84062);
case 22: return new CityInfo("Portmore", "10", 17.95032, -76.88215);
case 23: return new CityInfo("Port Maria", "13", 18.36849, -76.88946);
case 24: return new CityInfo("Port Antonio", "07", 18.17615, -76.4509);
case 25: return new CityInfo("Point Hill", "10", 18.08988, -77.10759);
case 26: return new CityInfo("Petersfield", "16", 18.26158, -78.07117);
case 27: return new CityInfo("Oracabessa", "13", 18.40319, -76.94641);
case 28: return new CityInfo("Old Harbour Bay", "10", 17.90918, -77.09718);
case 29: return new CityInfo("Old Harbour", "10", 17.94144, -77.10898);
case 30: return new CityInfo("Ocho Rios", "09", 18.4076, -77.10312);
case 31: return new CityInfo("New Kingston", "08", 18.00747, -76.78319);
case 32: return new CityInfo("Negril", "16", 18.26844, -78.3481);
case 33: return new CityInfo("Nain", "11", 17.96526, -77.60528);
case 34: return new CityInfo("Morant Bay", "14", 17.88145, -76.40927);
case 35: return new CityInfo("Moore Town", "07", 18.07767, -76.42577);
case 36: return new CityInfo("Montego Bay", "12", 18.47116, -77.91883);
case 37: return new CityInfo("Moneague", "09", 18.27556, -77.11177);
case 38: return new CityInfo("Mona Heights", "08", 18.01375, -76.75186);
case 39: return new CityInfo("Mocho", "01", 18.04, -77.33);
case 40: return new CityInfo("May Pen", "01", 17.96454, -77.24515);
case 41: return new CityInfo("Mavis Bank", "08", 18.03333, -76.66667);
case 42: return new CityInfo("Maroon Town", "12", 18.34464, -77.79544);
case 43: return new CityInfo("Mandeville", "04", 18.04168, -77.50714);
case 44: return new CityInfo("Manchioneal", "07", 18.04444, -76.27735);
case 45: return new CityInfo("Malvern", "11", 17.96667, -77.7);
case 46: return new CityInfo("Maggotty", "11", 18.16069, -77.76349);
case 47: return new CityInfo("Lucky Hill", "13", 18.31023, -77.01045);
case 48: return new CityInfo("Lucea", "02", 18.45095, -78.17356);
case 49: return new CityInfo("Lluidas Vale", "10", 18.12587, -77.14823);
case 50: return new CityInfo("Lionel Town", "01", 17.81007, -77.24061);
case 51: return new CityInfo("Linstead", "10", 18.13683, -77.03171);
case 52: return new CityInfo("Lacovia", "11", 18.0721, -77.75059);
case 53: return new CityInfo("Kingston", "17", 17.99702, -76.79358);
case 54: return new CityInfo("Kellits", "01", 18.16184, -77.27049);
case 55: return new CityInfo("Islington", "13", 18.30922, -76.85482);
case 56: return new CityInfo("Hope Bay", "07", 18.19882, -76.56539);
case 57: return new CityInfo("Hayes", "01", 17.87569, -77.23711);
case 58: return new CityInfo("Half Way Tree", "08", 18.01248, -76.79928);
case 59: return new CityInfo("Gordon Town", "08", 18.03578, -76.71783);
case 60: return new CityInfo("Golden Grove", "14", 17.93361, -76.27254);
case 61: return new CityInfo("Gayle", "13", 18.32642, -77.00971);
case 62: return new CityInfo("Frome", "16", 18.29407, -78.15469);
case 63: return new CityInfo("Falmouth", "15", 18.49358, -77.65587);
case 64: return new CityInfo("Ewarton", "10", 18.18333, -77.08536);
case 65: return new CityInfo("Easington", "14", 17.92397, -76.58824);
case 66: return new CityInfo("Duncans", "15", 18.468, -77.53633);
case 67: return new CityInfo("Discovery Bay", "09", 18.45873, -77.39997);
case 68: return new CityInfo("Darliston", "16", 18.23731, -77.97626);
case 69: return new CityInfo("Dalvey", "14", 17.91184, -76.24864);
case 70: return new CityInfo("Constant Spring", "08", 18.05078, -76.79372);
case 71: return new CityInfo("Coleyville", "04", 18.20783, -77.50754);
case 72: return new CityInfo("Chapelton", "01", 18.08333, -77.26667);
case 73: return new CityInfo("Cascade", "02", 18.39747, -78.10337);
case 74: return new CityInfo("Cambridge", "12", 18.31326, -77.90252);
case 75: return new CityInfo("Bull Savanna", "11", 17.88678, -77.59022);
case 76: return new CityInfo("Buff Bay", "07", 18.23287, -76.66118);
case 77: return new CityInfo("Bog Walk", "10", 18.10205, -77.00541);
case 78: return new CityInfo("Bluefields", "16", 18.16602, -78.02702);
case 79: return new CityInfo("Black River", "11", 18.02636, -77.84873);
case 80: return new CityInfo("Bethel Town", "16", 18.29503, -77.95112);
case 81: return new CityInfo("Bath", "14", 17.9482, -76.34916);
case 82: return new CityInfo("Bamboo", "09", 18.39216, -77.26429);
case 83: return new CityInfo("Balaclava", "11", 18.17228, -77.64375);
case 84: return new CityInfo("Mt Peto", "02", 18.3637, -78.03736);
case 85: return new CityInfo("Annotto Bay", "13", 18.2717, -76.76523);
case 86: return new CityInfo("Anchovy", "12", 18.4103, -77.93166);
case 87: return new CityInfo("Alligator Pond", "11", 17.86932, -77.56769);
case 88: return new CityInfo("Alexandria", "09", 18.30768, -77.35335);
case 89: return new CityInfo("Albert Town", "15", 18.29434, -77.54239);
case 90: return new CityInfo("Limit", "01", 18.15287, -77.47121);
default: return new CityInfo("Quickstep", "15", 18.2624, -77.64586);

                                    }                                        
                                }
                            
                        }
                    }
                