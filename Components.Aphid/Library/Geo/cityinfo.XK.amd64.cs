
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
                                    public const string Country = "XK";
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
                            
                                        var cur = (Math.Abs(42.9075 - lat) + Math.Abs(20.84028 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(42.91444 - lat) + Math.Abs(20.68972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.82306 - lat) + Math.Abs(20.9675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32139 - lat) + Math.Abs(21.35833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.37056 - lat) + Math.Abs(21.15528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35861 - lat) + Math.Abs(20.825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.23944 - lat) + Math.Abs(21.02722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43306 - lat) + Math.Abs(21.03972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.74667 - lat) + Math.Abs(20.78861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.50889 - lat) + Math.Abs(20.28194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49861 - lat) + Math.Abs(20.37889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.52 - lat) + Math.Abs(20.34722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49222 - lat) + Math.Abs(21.59889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.21389 - lat) + Math.Abs(20.73972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.67272 - lat) + Math.Abs(21.16688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5075 - lat) + Math.Abs(20.31778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.53722 - lat) + Math.Abs(20.35111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.91056 - lat) + Math.Abs(21.19306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38361 - lat) + Math.Abs(20.82194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.65913 - lat) + Math.Abs(20.28828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.40694 - lat) + Math.Abs(21.49556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.40194 - lat) + Math.Abs(21.43361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.42 - lat) + Math.Abs(20.74222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.39944 - lat) + Math.Abs(20.65472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.68694 - lat) + Math.Abs(21.07028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6159 - lat) + Math.Abs(21.43405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.42389 - lat) + Math.Abs(20.80167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.33083 - lat) + Math.Abs(20.72694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.48222 - lat) + Math.Abs(20.74583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55528 - lat) + Math.Abs(20.76333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54667 - lat) + Math.Abs(20.34667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.56306 - lat) + Math.Abs(20.29083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.59778 - lat) + Math.Abs(20.29139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.52167 - lat) + Math.Abs(21.12583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32778 - lat) + Math.Abs(20.78111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.10389 - lat) + Math.Abs(20.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57028 - lat) + Math.Abs(20.46472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88333 - lat) + Math.Abs(20.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57806 - lat) + Math.Abs(21.58028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.66394 - lat) + Math.Abs(21.09611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.37139 - lat) + Math.Abs(21.37444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62167 - lat) + Math.Abs(20.57778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.23194 - lat) + Math.Abs(21.25944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.47583 - lat) + Math.Abs(20.27722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.78083 - lat) + Math.Abs(20.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5575 - lat) + Math.Abs(20.30278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.60111 - lat) + Math.Abs(21.19583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57843 - lat) + Math.Abs(20.29398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.545 - lat) + Math.Abs(20.30778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.46045 - lat) + Math.Abs(21.46986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62833 - lat) + Math.Abs(20.89389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.50722 - lat) + Math.Abs(20.36278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.71194 - lat) + Math.Abs(20.36972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.51556 - lat) + Math.Abs(20.29222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.0265 - lat) + Math.Abs(20.65333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.58063 - lat) + Math.Abs(20.31619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.31833 - lat) + Math.Abs(20.81861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.15 - lat) + Math.Abs(21.29667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54018 - lat) + Math.Abs(20.28793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38028 - lat) + Math.Abs(20.43083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.355 - lat) + Math.Abs(20.925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55806 - lat) + Math.Abs(20.45278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55278 - lat) + Math.Abs(20.33111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54933 - lat) + Math.Abs(21.06336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54583 - lat) + Math.Abs(20.33556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.52444 - lat) + Math.Abs(20.28083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zvečan", "10097358", 42.9075, 20.84028);
case 1: return new CityInfo("Zubin Potok", "10097358", 42.91444, 20.68972);
case 2: return new CityInfo("Vushtrri", "10097358", 42.82306, 20.9675);
case 3: return new CityInfo("Vitina", "10097357", 42.32139, 21.35833);
case 4: return new CityInfo("Ferizaj", "10096138", 42.37056, 21.15528);
case 5: return new CityInfo("Suva Reka", "10097361", 42.35861, 20.825);
case 6: return new CityInfo("Štrpce", "10096138", 42.23944, 21.02722);
case 7: return new CityInfo("Shtime", "10096138", 42.43306, 21.03972);
case 8: return new CityInfo("Srbica", "10097358", 42.74667, 20.78861);
case 9: return new CityInfo("Slup", "10096859", 42.50889, 20.28194);
case 10: return new CityInfo("Shaptej", "10096859", 42.49861, 20.37889);
case 11: return new CityInfo("Irzniq", "10096859", 42.52, 20.34722);
case 12: return new CityInfo("Ranilug", "10097357", 42.49222, 21.59889);
case 13: return new CityInfo("Prizren", "10097361", 42.21389, 20.73972);
case 14: return new CityInfo("Pristina", "10097360", 42.67272, 21.16688);
case 15: return new CityInfo("Prilep", "10096859", 42.5075, 20.31778);
case 16: return new CityInfo("Pozhar", "10096859", 42.53722, 20.35111);
case 17: return new CityInfo("Podujeva", "10097360", 42.91056, 21.19306);
case 18: return new CityInfo("Peqan", "10097361", 42.38361, 20.82194);
case 19: return new CityInfo("Peć", "10097359", 42.65913, 20.28828);
case 20: return new CityInfo("Pasjane", "10097357", 42.40694, 21.49556);
case 21: return new CityInfo("Partesh", "10097357", 42.40194, 21.43361);
case 22: return new CityInfo("Pagaruša", "10097361", 42.42, 20.74222);
case 23: return new CityInfo("Orahovac", "10096859", 42.39944, 20.65472);
case 24: return new CityInfo("Obiliq", "10097360", 42.68694, 21.07028);
case 25: return new CityInfo("Novo Brdo", "10097360", 42.6159, 21.43405);
case 26: return new CityInfo("Nishor", "10097361", 42.42389, 20.80167);
case 27: return new CityInfo("Mamuša", "10097361", 42.33083, 20.72694);
case 28: return new CityInfo("Mališevo", "10097361", 42.48222, 20.74583);
case 29: return new CityInfo("Llazicë", "10097361", 42.55528, 20.76333);
case 30: return new CityInfo("Lumbardhi", "10096859", 42.54667, 20.34667);
case 31: return new CityInfo("Lëbushë", "10096859", 42.56306, 20.29083);
case 32: return new CityInfo("Lybeniq", "10097359", 42.59778, 20.29139);
case 33: return new CityInfo("Lipljan", "10097360", 42.52167, 21.12583);
case 34: return new CityInfo("Leshan", "10097361", 42.32778, 20.78111);
case 35: return new CityInfo("Leposaviq", "10097358", 43.10389, 20.80278);
case 36: return new CityInfo("Kosuriq", "10097359", 42.57028, 20.46472);
case 37: return new CityInfo("Mitrovicë", "10097358", 42.88333, 20.86667);
case 38: return new CityInfo("Kamenica", "10097357", 42.57806, 21.58028);
case 39: return new CityInfo("Kosovo Polje", "10097360", 42.66394, 21.09611);
case 40: return new CityInfo("Klokot", "10097357", 42.37139, 21.37444);
case 41: return new CityInfo("Klina", "10097359", 42.62167, 20.57778);
case 42: return new CityInfo("Kačanik", "10096138", 42.23194, 21.25944);
case 43: return new CityInfo("Junik", "10096859", 42.47583, 20.27722);
case 44: return new CityInfo("Istok", "10097359", 42.78083, 20.4875);
case 45: return new CityInfo("Isniq", "10096859", 42.5575, 20.30278);
case 46: return new CityInfo("Gračanica", "10097360", 42.60111, 21.19583);
case 47: return new CityInfo("Strellc i Epërm", "10096859", 42.57843, 20.29398);
case 48: return new CityInfo("Lluka e Eperme", "10096859", 42.545, 20.30778);
case 49: return new CityInfo("Gjilan", "10097357", 42.46045, 21.46986);
case 50: return new CityInfo("Glogovac", "10097360", 42.62833, 20.89389);
case 51: return new CityInfo("Gllogjan", "10096859", 42.50722, 20.36278);
case 52: return new CityInfo("Dubova (Driloni)", "10097359", 42.71194, 20.36972);
case 53: return new CityInfo("Dranoc", "10096859", 42.51556, 20.29222);
case 54: return new CityInfo("Dragash", "10097361", 42.0265, 20.65333);
case 55: return new CityInfo("Strellc i Ulët", "10096859", 42.58063, 20.31619);
case 56: return new CityInfo("Gjinoc", "10097361", 42.31833, 20.81861);
case 57: return new CityInfo("Hani i Elezit", "10096138", 42.15, 21.29667);
case 58: return new CityInfo("Deçan", "10096859", 42.54018, 20.28793);
case 59: return new CityInfo("Gjakovë", "10096859", 42.38028, 20.43083);
case 60: return new CityInfo("Budakovo", "10097361", 42.355, 20.925);
case 61: return new CityInfo("Buqan", "10097359", 42.55806, 20.45278);
case 62: return new CityInfo("Papraqan", "10096859", 42.55278, 20.33111);
case 63: return new CityInfo("Glanica", "10097360", 42.54933, 21.06336);
case 64: return new CityInfo("Lluka e Poshtme", "10096859", 42.54583, 20.33556);
default: return new CityInfo("Lloqan", "10096859", 42.52444, 20.28083);

                                    }                                        
                                }
                            
                        }
                    }
                