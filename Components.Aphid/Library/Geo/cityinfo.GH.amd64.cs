
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
                                    public const string Country = "GH";
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
                            
                                        var cur = (Math.Abs(9.44272 - lat) + Math.Abs(-0.00991 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(5.35113 - lat) + Math.Abs(-0.62313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.20583 - lat) + Math.Abs(-2.48944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73855 - lat) + Math.Abs(-2.1036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.06069 - lat) + Math.Abs(-2.50192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.58365 - lat) + Math.Abs(-0.10722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.6698 - lat) + Math.Abs(-0.01657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.59054 - lat) + Math.Abs(-1.93947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.30383 - lat) + Math.Abs(-1.98956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.40079 - lat) + Math.Abs(-0.8393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.89816 - lat) + Math.Abs(-1.76029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73156 - lat) + Math.Abs(-1.6137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.53711 - lat) + Math.Abs(-0.69984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.33991 - lat) + Math.Abs(-2.32676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04089 - lat) + Math.Abs(-0.45004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.01806 - lat) + Math.Abs(-1.66437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.92678 - lat) + Math.Abs(-1.75773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.62441 - lat) + Math.Abs(-0.8253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.20913 - lat) + Math.Abs(-1.06058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55083 - lat) + Math.Abs(-0.51875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.43385 - lat) + Math.Abs(-2.14295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.53449 - lat) + Math.Abs(-0.41679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.92665 - lat) + Math.Abs(-0.98577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.20228 - lat) + Math.Abs(-1.66796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.60105 - lat) + Math.Abs(-0.07713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.80893 - lat) + Math.Abs(-0.35026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.89557 - lat) + Math.Abs(-1.0921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.52726 - lat) + Math.Abs(-0.36982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.26176 - lat) + Math.Abs(-0.75897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.59321 - lat) + Math.Abs(-0.73462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06273 - lat) + Math.Abs(-1.4001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.6658 - lat) + Math.Abs(-0.16307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.68848 - lat) + Math.Abs(-1.62443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.99536 - lat) + Math.Abs(0.29306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.46885 - lat) + Math.Abs(-0.01127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.61667 - lat) + Math.Abs(-1.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.09408 - lat) + Math.Abs(-0.25913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.05627 - lat) + Math.Abs(-1.73058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.16494 - lat) + Math.Abs(-0.55376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79391 - lat) + Math.Abs(-0.0498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.91793 - lat) + Math.Abs(0.98789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.5758 - lat) + Math.Abs(-2.78516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.15181 - lat) + Math.Abs(0.47362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.60084 - lat) + Math.Abs(0.4713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.57692 - lat) + Math.Abs(-0.31038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.80355 - lat) + Math.Abs(-2.5172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.70119 - lat) + Math.Abs(-1.28657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.0847 - lat) + Math.Abs(-1.35093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.38558 - lat) + Math.Abs(-1.35617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.95996 - lat) + Math.Abs(-1.77792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.06616 - lat) + Math.Abs(0.17947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.17487 - lat) + Math.Abs(-2.09961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.65003 - lat) + Math.Abs(-0.2361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.08296 - lat) + Math.Abs(-1.81884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.10535 - lat) + Math.Abs(-1.2466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.78556 - lat) + Math.Abs(-0.85139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46346 - lat) + Math.Abs(-2.31938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.4534 - lat) + Math.Abs(-2.58404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.45195 - lat) + Math.Abs(-1.57866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.38706 - lat) + Math.Abs(-0.37738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.09034 - lat) + Math.Abs(-2.02498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.0616 - lat) + Math.Abs(-0.24169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.86641 - lat) + Math.Abs(-2.24181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.86006 - lat) + Math.Abs(-0.6635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28483 - lat) + Math.Abs(-0.73711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.79473 - lat) + Math.Abs(0.89728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04024 - lat) + Math.Abs(-0.80876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.97462 - lat) + Math.Abs(-0.08542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.8938 - lat) + Math.Abs(-1.01636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.80004 - lat) + Math.Abs(-1.08193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.11982 - lat) + Math.Abs(1.19012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.69775 - lat) + Math.Abs(-0.32824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55602 - lat) + Math.Abs(-0.1969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.84802 - lat) + Math.Abs(-0.17449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.36073 - lat) + Math.Abs(-1.94856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73333 - lat) + Math.Abs(-1.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.78722 - lat) + Math.Abs(-2.08361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53333 - lat) + Math.Abs(-0.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.78442 - lat) + Math.Abs(-0.78449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yendi", "06", 9.44272, -0.00991);
case 1: return new CityInfo("Winneba", "04", 5.35113, -0.62313);
case 2: return new CityInfo("Sefwi Wiawso", "18", 6.20583, -2.48944);
case 3: return new CityInfo("Wankyi", "13", 7.73855, -2.1036);
case 4: return new CityInfo("Wa", "11", 10.06069, -2.50192);
case 5: return new CityInfo("Teshi Old Town", "01", 5.58365, -0.10722);
case 6: return new CityInfo("Tema", "01", 5.6698, -0.01657);
case 7: return new CityInfo("Techiman", "14", 7.59054, -1.93947);
case 8: return new CityInfo("Tarkwa", "09", 5.30383, -1.98956);
case 9: return new CityInfo("Tamale", "06", 9.40079, -0.8393);
case 10: return new CityInfo("Takoradi", "09", 4.89816, -1.76029);
case 11: return new CityInfo("Tafo", "02", 6.73156, -1.6137);
case 12: return new CityInfo("Swedru", "04", 5.53711, -0.69984);
case 13: return new CityInfo("Sunyani", "13", 7.33991, -2.32676);
case 14: return new CityInfo("Suhum", "05", 6.04089, -0.45004);
case 15: return new CityInfo("Shama Junction", "09", 5.01806, -1.66437);
case 16: return new CityInfo("Sekondi-Takoradi", "09", 4.92678, -1.75773);
case 17: return new CityInfo("Savelugu", "06", 9.62441, -0.8253);
case 18: return new CityInfo("Saltpond", "04", 5.20913, -1.06058);
case 19: return new CityInfo("Salaga", "06", 8.55083, -0.51875);
case 20: return new CityInfo("Prestea", "09", 5.43385, -2.14295);
case 21: return new CityInfo("Kasoa", "04", 5.53449, -0.41679);
case 22: return new CityInfo("Akim Oda", "05", 5.92665, -0.98577);
case 23: return new CityInfo("Obuase", "02", 6.20228, -1.66796);
case 24: return new CityInfo("Nungua", "01", 5.60105, -0.07713);
case 25: return new CityInfo("Nsawam", "05", 5.80893, -0.35026);
case 26: return new CityInfo("Navrongo", "10", 10.89557, -1.0921);
case 27: return new CityInfo("Nalerigu", "15", 10.52726, -0.36982);
case 28: return new CityInfo("Mumford", "04", 5.26176, -0.75897);
case 29: return new CityInfo("Mpraeso", "05", 6.59321, -0.73462);
case 30: return new CityInfo("Mampong", "02", 7.06273, -1.4001);
case 31: return new CityInfo("Medina Estates", "01", 5.6658, -0.16307);
case 32: return new CityInfo("Kumasi", "02", 6.68848, -1.62443);
case 33: return new CityInfo("Kpandu", "08", 6.99536, 0.29306);
case 34: return new CityInfo("Kpandae", "06", 8.46885, -0.01127);
case 35: return new CityInfo("Konongo", "02", 6.61667, -1.21667);
case 36: return new CityInfo("Koforidua", "05", 6.09408, -0.25913);
case 37: return new CityInfo("Kintampo", "14", 8.05627, -1.73058);
case 38: return new CityInfo("Kibi", "05", 6.16494, -0.55376);
case 39: return new CityInfo("Kete Krachi", "08", 7.79391, -0.0498);
case 40: return new CityInfo("Keta", "08", 5.91793, 0.98789);
case 41: return new CityInfo("Japekrom", "13", 7.5758, -2.78516);
case 42: return new CityInfo("Hohoe", "08", 7.15181, 0.47362);
case 43: return new CityInfo("Ho", "08", 6.60084, 0.4713);
case 44: return new CityInfo("Gbawe", "01", 5.57692, -0.31038);
case 45: return new CityInfo("Goaso", "12", 6.80355, -2.5172);
case 46: return new CityInfo("Foso", "04", 5.70119, -1.28657);
case 47: return new CityInfo("Elmina", "04", 5.0847, -1.35093);
case 48: return new CityInfo("Ejura", "02", 7.38558, -1.35617);
case 49: return new CityInfo("Dunkwa", "04", 5.95996, -1.77792);
case 50: return new CityInfo("Dambai", "16", 8.06616, 0.17947);
case 51: return new CityInfo("Duayaw-Nkwanta", "12", 7.17487, -2.09961);
case 52: return new CityInfo("Dome", "01", 5.65003, -0.2361);
case 53: return new CityInfo("Damongo", "17", 9.08296, -1.81884);
case 54: return new CityInfo("Cape Coast", "04", 5.10535, -1.2466);
case 55: return new CityInfo("Bolgatanga", "10", 10.78556, -0.85139);
case 56: return new CityInfo("Bibiani", "09", 6.46346, -2.31938);
case 57: return new CityInfo("Berekum", "13", 7.4534, -2.58404);
case 58: return new CityInfo("Bekwai", "02", 6.45195, -1.57866);
case 59: return new CityInfo("Begoro", "05", 6.38706, -0.37738);
case 60: return new CityInfo("Bechem", "12", 7.09034, -2.02498);
case 61: return new CityInfo("Bawku", "10", 11.0616, -0.24169);
case 62: return new CityInfo("Axim", "09", 4.86641, -2.24181);
case 63: return new CityInfo("Asamankese", "05", 5.86006, -0.6635);
case 64: return new CityInfo("Apam", "04", 5.28483, -0.73711);
case 65: return new CityInfo("Anloga", "08", 5.79473, 0.89728);
case 66: return new CityInfo("Akwatia", "05", 6.04024, -0.80876);
case 67: return new CityInfo("Akropong", "05", 5.97462, -0.08542);
case 68: return new CityInfo("Akim Swedru", "05", 5.8938, -1.01636);
case 69: return new CityInfo("Agogo", "02", 6.80004, -1.08193);
case 70: return new CityInfo("Aflao", "08", 6.11982, 1.19012);
case 71: return new CityInfo("Atsiaman", "01", 5.69775, -0.32824);
case 72: return new CityInfo("Accra", "01", 5.55602, -0.1969);
case 73: return new CityInfo("Aburi", "05", 5.84802, -0.17449);
case 74: return new CityInfo("Aboso", "09", 5.36073, -1.94856);
case 75: return new CityInfo("Mamponteng", "02", 6.73333, -1.55);
case 76: return new CityInfo("Wassa-Akropong", "09", 5.78722, -2.08361);
case 77: return new CityInfo("Odumase Krobo", "05", 6.53333, -0.81667);
default: return new CityInfo("Zonno", "10", 10.78442, -0.78449);

                                    }                                        
                                }
                            
                        }
                    }
                