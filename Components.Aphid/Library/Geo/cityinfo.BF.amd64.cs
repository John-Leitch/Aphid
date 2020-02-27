
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
                                    public const string Country = "BF";
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
                            
                                        var cur = (Math.Abs(12.24922 - lat) + Math.Abs(-0.61527 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(12.74846 - lat) + Math.Abs(-1.30989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.58186 - lat) + Math.Abs(-1.2971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.9591 - lat) + Math.Abs(-2.26075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.0725 - lat) + Math.Abs(-3.0694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.75844 - lat) + Math.Abs(-2.89879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8159 - lat) + Math.Abs(-1.72763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76667 - lat) + Math.Abs(-2.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.78 - lat) + Math.Abs(-0.36972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.27256 - lat) + Math.Abs(-1.71704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.41462 - lat) + Math.Abs(-1.80644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.17423 - lat) + Math.Abs(-4.08477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66667 - lat) + Math.Abs(-5.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.55618 - lat) + Math.Abs(-1.88775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.6926 - lat) + Math.Abs(-2.8987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43641 - lat) + Math.Abs(0.53044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.55444 - lat) + Math.Abs(-1.77361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05356 - lat) + Math.Abs(-1.60491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.37136 - lat) + Math.Abs(-1.41468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.31963 - lat) + Math.Abs(-2.47094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.47847 - lat) + Math.Abs(-1.20129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.16972 - lat) + Math.Abs(-1.145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.24564 - lat) + Math.Abs(-1.88148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.24972 - lat) + Math.Abs(0.7075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.52147 - lat) + Math.Abs(-1.58631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.67553 - lat) + Math.Abs(-0.46033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.77994 - lat) + Math.Abs(-1.5077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.50202 - lat) + Math.Abs(0.05886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58278 - lat) + Math.Abs(-2.42158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.36566 - lat) + Math.Abs(-1.53388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.76975 - lat) + Math.Abs(-1.93376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.72939 - lat) + Math.Abs(-3.86305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.19785 - lat) + Math.Abs(-1.40662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.66361 - lat) + Math.Abs(-1.07306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.98836 - lat) + Math.Abs(-1.34434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.51863 - lat) + Math.Abs(-1.3734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.10033 - lat) + Math.Abs(-2.10654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.53118 - lat) + Math.Abs(-1.77684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.17864 - lat) + Math.Abs(-0.35103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.25263 - lat) + Math.Abs(-2.36272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.82506 - lat) + Math.Abs(-1.06737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.32583 - lat) + Math.Abs(-1.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.18653 - lat) + Math.Abs(-1.63379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.18279 - lat) + Math.Abs(-1.79131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.06884 - lat) + Math.Abs(-1.33644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.19392 - lat) + Math.Abs(-1.87687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.01295 - lat) + Math.Abs(-1.8419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.09167 - lat) + Math.Abs(-1.08444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.5 - lat) + Math.Abs(-3.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.6561 - lat) + Math.Abs(-2.7953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.20776 - lat) + Math.Abs(-2.35893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.23484 - lat) + Math.Abs(-1.93394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4429 - lat) + Math.Abs(-0.23468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.64824 - lat) + Math.Abs(0.49314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.8 - lat) + Math.Abs(-0.55056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.00414 - lat) + Math.Abs(-1.16455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.06157 - lat) + Math.Abs(0.35843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.0354 - lat) + Math.Abs(-0.0345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.0994 - lat) + Math.Abs(-1.62554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.96209 - lat) + Math.Abs(-3.24967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.07305 - lat) + Math.Abs(1.78838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.60084 - lat) + Math.Abs(-0.71901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.46338 - lat) + Math.Abs(-3.46075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.67274 - lat) + Math.Abs(-1.53907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1464 - lat) + Math.Abs(-3.05784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.91069 - lat) + Math.Abs(-1.0819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66121 - lat) + Math.Abs(-1.89515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66664 - lat) + Math.Abs(-0.57469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.74542 - lat) + Math.Abs(-2.93006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.9704 - lat) + Math.Abs(-0.14953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.17715 - lat) + Math.Abs(-4.2979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.30092 - lat) + Math.Abs(-1.8348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.54652 - lat) + Math.Abs(-0.02438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.88333 - lat) + Math.Abs(-2.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.1691 - lat) + Math.Abs(-3.8899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.63333 - lat) + Math.Abs(-4.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.6406 - lat) + Math.Abs(-1.05426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.96549 - lat) + Math.Abs(-0.16335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25833 - lat) + Math.Abs(-0.21306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.44114 - lat) + Math.Abs(0.90735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zorgo", "11", 12.24922, -0.61527);
case 1: return new CityInfo("Zitenga", "11", 12.74846, -1.30989);
case 2: return new CityInfo("Ziniaré", "11", 12.58186, -1.2971);
case 3: return new CityInfo("Yako", "10", 12.9591, -2.26075);
case 4: return new CityInfo("Tougan", "01", 13.0725, -3.0694);
case 5: return new CityInfo("Toma", "01", 12.75844, -2.89879);
case 6: return new CityInfo("Toéghin", "11", 12.8159, -1.72763);
case 7: return new CityInfo("Titao", "10", 13.76667, -2.06667);
case 8: return new CityInfo("Tenkodogo", "04", 11.78, -0.36972);
case 9: return new CityInfo("Tanghin-Dassouri", "03", 12.27256, -1.71704);
case 10: return new CityInfo("Sourgoubila", "11", 12.41462, -1.80644);
case 11: return new CityInfo("Salanso", "01", 12.17423, -4.08477);
case 12: return new CityInfo("Sindou", "02", 10.66667, -5.16667);
case 13: return new CityInfo("Siglé", "06", 12.55618, -1.88775);
case 14: return new CityInfo("Sièn", "01", 12.6926, -2.8987);
case 15: return new CityInfo("Sebba", "12", 13.43641, 0.53044);
case 16: return new CityInfo("Sapouy", "06", 11.55444, -1.77361);
case 17: return new CityInfo("Saponé", "07", 12.05356, -1.60491);
case 18: return new CityInfo("Saaba", "03", 12.37136, -1.41468);
case 19: return new CityInfo("Réo", "06", 12.31963, -2.47094);
case 20: return new CityInfo("Nagréongo", "11", 12.47847, -1.20129);
case 21: return new CityInfo("Pô", "07", 11.16972, -1.145);
case 22: return new CityInfo("Pitmoaga", "06", 12.24564, -1.88148);
case 23: return new CityInfo("Pama", "08", 11.24972, 0.7075);
case 24: return new CityInfo("Pabré", "03", 12.52147, -1.58631);
case 25: return new CityInfo("Oursi", "12", 14.67553, -0.46033);
case 26: return new CityInfo("Ourgou-Manéga", "11", 12.77994, -1.5077);
case 27: return new CityInfo("Ouargaye", "04", 11.50202, 0.05886);
case 28: return new CityInfo("Ouahigouya", "10", 13.58278, -2.42158);
case 29: return new CityInfo("Ouagadougou", "03", 12.36566, -1.53388);
case 30: return new CityInfo("Niou", "11", 12.76975, -1.93376);
case 31: return new CityInfo("Nouna", "01", 12.72939, -3.86305);
case 32: return new CityInfo("Koubri", "03", 12.19785, -1.40662);
case 33: return new CityInfo("Manga", "07", 11.66361, -1.07306);
case 34: return new CityInfo("Mané", "05", 12.98836, -1.34434);
case 35: return new CityInfo("Loumbila", "11", 12.51863, -1.3734);
case 36: return new CityInfo("Léo", "06", 11.10033, -2.10654);
case 37: return new CityInfo("Laye", "11", 12.53118, -1.77684);
case 38: return new CityInfo("Koupéla", "04", 12.17864, -0.35103);
case 39: return new CityInfo("Koudougou", "06", 12.25263, -2.36272);
case 40: return new CityInfo("Korsimoro", "05", 12.82506, -1.06737);
case 41: return new CityInfo("Kongoussi", "05", 13.32583, -1.53472);
case 42: return new CityInfo("Komsilga", "03", 12.18653, -1.63379);
case 43: return new CityInfo("Komki-Ipala", "03", 12.18279, -1.79131);
case 44: return new CityInfo("Kombissiri", "07", 12.06884, -1.33644);
case 45: return new CityInfo("Kokologo", "06", 12.19392, -1.87687);
case 46: return new CityInfo("Kayao", "07", 12.01295, -1.8419);
case 47: return new CityInfo("Kaya", "05", 13.09167, -1.08444);
case 48: return new CityInfo("Houndé", "09", 11.5, -3.51667);
case 49: return new CityInfo("Gousi", "01", 12.6561, -2.7953);
case 50: return new CityInfo("Gourcy", "10", 13.20776, -2.35893);
case 51: return new CityInfo("Goulouré", "06", 12.23484, -1.93394);
case 52: return new CityInfo("Gorom-Gorom", "12", 14.4429, -0.23468);
case 53: return new CityInfo("Gayéri", "08", 12.64824, 0.49314);
case 54: return new CityInfo("Garango", "04", 11.8, -0.55056);
case 55: return new CityInfo("Gaongo", "07", 12.00414, -1.16455);
case 56: return new CityInfo("Fada N'gourma", "08", 12.06157, 0.35843);
case 57: return new CityInfo("Dori", "12", 14.0354, -0.0345);
case 58: return new CityInfo("Djibo", "12", 14.0994, -1.62554);
case 59: return new CityInfo("Diébougou", "13", 10.96209, -3.24967);
case 60: return new CityInfo("Diapaga", "08", 12.07305, 1.78838);
case 61: return new CityInfo("Déou", "12", 14.60084, -0.71901);
case 62: return new CityInfo("Dédougou", "01", 12.46338, -3.46075);
case 63: return new CityInfo("Dapélogo", "11", 12.67274, -1.53907);
case 64: return new CityInfo("Dano", "13", 11.1464, -3.05784);
case 65: return new CityInfo("Boussouma", "05", 12.91069, -1.0819);
case 66: return new CityInfo("Boussé", "11", 12.66121, -1.89515);
case 67: return new CityInfo("Boulsa", "05", 12.66664, -0.57469);
case 68: return new CityInfo("Boromo", "01", 11.74542, -2.93006);
case 69: return new CityInfo("Bogandé", "08", 12.9704, -0.14953);
case 70: return new CityInfo("Bobo-Dioulasso", "09", 11.17715, -4.2979);
case 71: return new CityInfo("Bingo", "06", 12.30092, -1.8348);
case 72: return new CityInfo("Bilanga", "08", 12.54652, -0.02438);
case 73: return new CityInfo("Batié", "13", 9.88333, -2.91667);
case 74: return new CityInfo("Barani", "01", 13.1691, -3.8899);
case 75: return new CityInfo("Banfora", "02", 10.63333, -4.76667);
case 76: return new CityInfo("Absouya", "11", 12.6406, -1.05426);
case 77: return new CityInfo("Tin-Akoff", "12", 14.96549, -0.16335);
case 78: return new CityInfo("Mani", "08", 13.25833, -0.21306);
default: return new CityInfo("Boundoré", "12", 13.44114, 0.90735);

                                    }                                        
                                }
                            
                        }
                    }
                