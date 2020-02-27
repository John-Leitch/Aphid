
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
                                    public const string Country = "ZM";
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
                            
                                        var cur = (Math.Abs(-9.34506 - lat) + Math.Abs(28.73396 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-9.34213 - lat) + Math.Abs(32.745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.76234 - lat) + Math.Abs(31.11405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.37273 - lat) + Math.Abs(30.12501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.84024 - lat) + Math.Abs(31.36587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.7915 - lat) + Math.Abs(29.07913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.46887 - lat) + Math.Abs(29.66193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.54323 - lat) + Math.Abs(23.10467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.1688 - lat) + Math.Abs(26.38938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.2614 - lat) + Math.Abs(27.46179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.53818 - lat) + Math.Abs(28.70876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.47593 - lat) + Math.Abs(24.29684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.23251 - lat) + Math.Abs(30.23522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.11667 - lat) + Math.Abs(23.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.36491 - lat) + Math.Abs(29.55652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.24117 - lat) + Math.Abs(31.31975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.55656 - lat) + Math.Abs(30.8149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.95867 - lat) + Math.Abs(28.63659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.75042 - lat) + Math.Abs(26.43839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.83244 - lat) + Math.Abs(27.77994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.73584 - lat) + Math.Abs(24.42926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.38447 - lat) + Math.Abs(28.698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.1732 - lat) + Math.Abs(31.36942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.98293 - lat) + Math.Abs(27.0619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.68333 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.54982 - lat) + Math.Abs(28.24071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.50914 - lat) + Math.Abs(28.15504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.83431 - lat) + Math.Abs(31.45287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.28333 - lat) + Math.Abs(27.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.24835 - lat) + Math.Abs(23.12741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.62015 - lat) + Math.Abs(29.3939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.85601 - lat) + Math.Abs(27.748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.19976 - lat) + Math.Abs(28.89431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.36667 - lat) + Math.Abs(27.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.2621 - lat) + Math.Abs(29.92712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.40669 - lat) + Math.Abs(28.28713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.29292 - lat) + Math.Abs(33.1782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.37067 - lat) + Math.Abs(23.24196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.13667 - lat) + Math.Abs(28.41661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.61667 - lat) + Math.Abs(30.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.84194 - lat) + Math.Abs(25.85425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.09691 - lat) + Math.Abs(23.13757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.80243 - lat) + Math.Abs(28.21323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.88333 - lat) + Math.Abs(29.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.45836 - lat) + Math.Abs(25.8338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.21289 - lat) + Math.Abs(31.18084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.97147 - lat) + Math.Abs(28.66985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.78333 - lat) + Math.Abs(24.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.09514 - lat) + Math.Abs(26.42727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.84151 - lat) + Math.Abs(28.09479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.46586 - lat) + Math.Abs(25.00271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.99307 - lat) + Math.Abs(22.67926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.76911 - lat) + Math.Abs(28.18136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.4469 - lat) + Math.Abs(28.44644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.59268 - lat) + Math.Abs(24.20081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.16062 - lat) + Math.Abs(32.63353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.49755 - lat) + Math.Abs(27.60691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.32916 - lat) + Math.Abs(28.68204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.80889 - lat) + Math.Abs(26.9875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.63333 - lat) + Math.Abs(32.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.54142 - lat) + Math.Abs(32.08162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.52897 - lat) + Math.Abs(27.88382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.36475 - lat) + Math.Abs(27.82286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.65685 - lat) + Math.Abs(28.07057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.63247 - lat) + Math.Abs(28.05367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.21303 - lat) + Math.Abs(33.1521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.06779 - lat) + Math.Abs(32.43917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Nchelenge", "04", -9.34506, 28.73396);
case 1: return new CityInfo("Nakonde", "10", -9.34213, 32.745);
case 2: return new CityInfo("Mpulungu", "05", -8.76234, 31.11405);
case 3: return new CityInfo("Mporokoso", "05", -9.37273, 30.12501);
case 4: return new CityInfo("Mbala", "05", -8.84024, 31.36587);
case 5: return new CityInfo("Kawambwa", "04", -9.7915, 29.07913);
case 6: return new CityInfo("Kaputa", "05", -8.46887, 29.66193);
case 7: return new CityInfo("Zambezi", "06", -13.54323, 23.10467);
case 8: return new CityInfo("Solwezi", "06", -12.1688, 26.38938);
case 9: return new CityInfo("Sinazongwe", "07", -17.2614, 27.46179);
case 10: return new CityInfo("Siavonga", "07", -16.53818, 28.70876);
case 11: return new CityInfo("Sesheke", "01", -17.47593, 24.29684);
case 12: return new CityInfo("Serenje", "02", -13.23251, 30.23522);
case 13: return new CityInfo("Senanga", "01", -16.11667, 23.26667);
case 14: return new CityInfo("Samfya", "04", -11.36491, 29.55652);
case 15: return new CityInfo("Petauke", "03", -14.24117, 31.31975);
case 16: return new CityInfo("Nyimba", "03", -14.55656, 30.8149);
case 17: return new CityInfo("Ndola", "08", -12.95867, 28.63659);
case 18: return new CityInfo("Namwala", "07", -15.75042, 26.43839);
case 19: return new CityInfo("Nakambala", "07", -15.83244, 27.77994);
case 20: return new CityInfo("Mwinilunga", "06", -11.73584, 24.42926);
case 21: return new CityInfo("Mwense", "04", -10.38447, 28.698);
case 22: return new CityInfo("Mungwi", "05", -10.1732, 31.36942);
case 23: return new CityInfo("Mumbwa", "02", -14.98293, 27.0619);
case 24: return new CityInfo("Mufumbwe", "06", -13.68333, 24.8);
case 25: return new CityInfo("Mufulira", "08", -12.54982, 28.24071);
case 26: return new CityInfo("Mpongwe", "08", -13.50914, 28.15504);
case 27: return new CityInfo("Mpika", "10", -11.83431, 31.45287);
case 28: return new CityInfo("Monze", "07", -16.28333, 27.48333);
case 29: return new CityInfo("Mongu", "01", -15.24835, 23.12741);
case 30: return new CityInfo("Mkushi", "02", -13.62015, 29.3939);
case 31: return new CityInfo("Mazabuka", "07", -15.85601, 27.748);
case 32: return new CityInfo("Mansa", "04", -11.19976, 28.89431);
case 33: return new CityInfo("Maamba", "07", -17.36667, 27.15);
case 34: return new CityInfo("Luwingu", "05", -10.2621, 29.92712);
case 35: return new CityInfo("Lusaka", "09", -15.40669, 28.28713);
case 36: return new CityInfo("Lundazi", "03", -12.29292, 33.1782);
case 37: return new CityInfo("Lukulu", "01", -14.37067, 23.24196);
case 38: return new CityInfo("Luanshya", "08", -13.13667, 28.41661);
case 39: return new CityInfo("Luangwa", "09", -15.61667, 30.41667);
case 40: return new CityInfo("Livingstone", "07", -17.84194, 25.85425);
case 41: return new CityInfo("Limulunga", "01", -15.09691, 23.13757);
case 42: return new CityInfo("Kitwe", "08", -12.80243, 28.21323);
case 43: return new CityInfo("Kataba", "08", -11.88333, 29.78333);
case 44: return new CityInfo("Kasempa", "06", -13.45836, 25.8338);
case 45: return new CityInfo("Kasama", "05", -10.21289, 31.18084);
case 46: return new CityInfo("Kapiri Mposhi", "02", -13.97147, 28.66985);
case 47: return new CityInfo("Kaoma", "01", -14.78333, 24.8);
case 48: return new CityInfo("Kansanshi", "06", -12.09514, 26.42727);
case 49: return new CityInfo("Kalulushi", "08", -12.84151, 28.09479);
case 50: return new CityInfo("Kalengwa", "06", -13.46586, 25.00271);
case 51: return new CityInfo("Kalabo", "01", -14.99307, 22.67926);
case 52: return new CityInfo("Kafue", "09", -15.76911, 28.18136);
case 53: return new CityInfo("Kabwe", "02", -14.4469, 28.44644);
case 54: return new CityInfo("Kabompo", "06", -13.59268, 24.20081);
case 55: return new CityInfo("Isoka", "10", -10.16062, 32.63353);
case 56: return new CityInfo("Gwembe", "07", -16.49755, 27.60691);
case 57: return new CityInfo("Chongwe", "09", -15.32916, 28.68204);
case 58: return new CityInfo("Choma", "07", -16.80889, 26.9875);
case 59: return new CityInfo("Chipata", "03", -13.63333, 32.65);
case 60: return new CityInfo("Chinsali", "10", -10.54142, 32.08162);
case 61: return new CityInfo("Chingola", "08", -12.52897, 27.88382);
case 62: return new CityInfo("Chililabombwe", "08", -12.36475, 27.82286);
case 63: return new CityInfo("Chibombo", "02", -14.65685, 28.07057);
case 64: return new CityInfo("Chambishi", "08", -12.63247, 28.05367);
case 65: return new CityInfo("Chama", "10", -11.21303, 33.1521);
default: return new CityInfo("Chadiza", "03", -14.06779, 32.43917);

                                    }                                        
                                }
                            
                        }
                    }
                