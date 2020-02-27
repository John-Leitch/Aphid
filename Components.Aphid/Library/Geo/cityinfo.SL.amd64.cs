
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
                                    public const string Country = "SL";
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
                            
                                        var cur = (Math.Abs(7.31356 - lat) + Math.Abs(-11.30818 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(8.44347 - lat) + Math.Abs(-12.23929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.71441 - lat) + Math.Abs(-11.17057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.30052 - lat) + Math.Abs(-11.20455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3389 - lat) + Math.Abs(-13.07091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.45092 - lat) + Math.Abs(-11.90071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53991 - lat) + Math.Abs(-10.73132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13526 - lat) + Math.Abs(-10.6196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62667 - lat) + Math.Abs(-13.215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70395 - lat) + Math.Abs(-11.2126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64789 - lat) + Math.Abs(-11.9606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61243 - lat) + Math.Abs(-11.00755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79311 - lat) + Math.Abs(-12.05294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.01801 - lat) + Math.Abs(-10.59496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.99471 - lat) + Math.Abs(-10.9502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6323 - lat) + Math.Abs(-13.2025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.22591 - lat) + Math.Abs(-12.6776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.67121 - lat) + Math.Abs(-12.38497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50596 - lat) + Math.Abs(-11.47897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.76609 - lat) + Math.Abs(-12.78696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70552 - lat) + Math.Abs(-11.02241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58611 - lat) + Math.Abs(-13.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09807 - lat) + Math.Abs(-10.69429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.18507 - lat) + Math.Abs(-11.1329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55518 - lat) + Math.Abs(-11.04278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.15898 - lat) + Math.Abs(-12.43168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61427 - lat) + Math.Abs(-11.01252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.76237 - lat) + Math.Abs(-12.30864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.99343 - lat) + Math.Abs(-10.75355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61119 - lat) + Math.Abs(-13.19101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.78197 - lat) + Math.Abs(-11.95171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66492 - lat) + Math.Abs(-11.8026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.17392 - lat) + Math.Abs(-10.74834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92262 - lat) + Math.Abs(-12.85688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.08742 - lat) + Math.Abs(-11.68841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.9186 - lat) + Math.Abs(-13.03674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88605 - lat) + Math.Abs(-12.04417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62964 - lat) + Math.Abs(-11.66168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.72306 - lat) + Math.Abs(-11.9488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.68439 - lat) + Math.Abs(-12.53499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.75931 - lat) + Math.Abs(-12.03383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27903 - lat) + Math.Abs(-12.1578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.39841 - lat) + Math.Abs(-12.66476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.70952 - lat) + Math.Abs(-11.69354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.64387 - lat) + Math.Abs(-10.9714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87687 - lat) + Math.Abs(-11.19025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.8879 - lat) + Math.Abs(-11.15932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.93814 - lat) + Math.Abs(-13.11541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12504 - lat) + Math.Abs(-12.91816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.49689 - lat) + Math.Abs(-12.24061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2789 - lat) + Math.Abs(-10.573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.58893 - lat) + Math.Abs(-11.55256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87815 - lat) + Math.Abs(-10.78976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37994 - lat) + Math.Abs(-13.13693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93974 - lat) + Math.Abs(-11.14132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.46439 - lat) + Math.Abs(-11.23952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43194 - lat) + Math.Abs(-13.28972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88405 - lat) + Math.Abs(-11.04908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.87852 - lat) + Math.Abs(-11.16548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55502 - lat) + Math.Abs(-11.6926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.49431 - lat) + Math.Abs(-11.83064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.48714 - lat) + Math.Abs(-13.2356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.40906 - lat) + Math.Abs(-11.54328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98976 - lat) + Math.Abs(-10.84223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2796 - lat) + Math.Abs(-10.37135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.17421 - lat) + Math.Abs(-10.86432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.89209 - lat) + Math.Abs(-11.90541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.04466 - lat) + Math.Abs(-11.74576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.52639 - lat) + Math.Abs(-12.505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.24611 - lat) + Math.Abs(-11.52583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.18763 - lat) + Math.Abs(-11.34026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96472 - lat) + Math.Abs(-11.73833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87481 - lat) + Math.Abs(-11.34548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.95225 - lat) + Math.Abs(-11.98029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91376 - lat) + Math.Abs(-11.44669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.34959 - lat) + Math.Abs(-11.33059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.99344 - lat) + Math.Abs(-11.71468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11996 - lat) + Math.Abs(-11.50702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10826 - lat) + Math.Abs(-11.84772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15356 - lat) + Math.Abs(-11.38712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69778 - lat) + Math.Abs(-13.23917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55091 - lat) + Math.Abs(-11.6075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.35806 - lat) + Math.Abs(-11.72083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33333 - lat) + Math.Abs(-13.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zimmi", "03", 7.31356, -11.30818);
case 1: return new CityInfo("Yonibana", "02", 8.44347, -12.23929);
case 2: return new CityInfo("Yengema", "01", 8.71441, -11.17057);
case 3: return new CityInfo("Wima", "01", 8.30052, -11.20455);
case 4: return new CityInfo("Waterloo", "04", 8.3389, -13.07091);
case 5: return new CityInfo("Tongole", "03", 7.45092, -11.90071);
case 6: return new CityInfo("Tombu", "01", 8.53991, -10.73132);
case 7: return new CityInfo("Tombodu", "01", 8.13526, -10.6196);
case 8: return new CityInfo("Tintafor", "02", 8.62667, -13.215);
case 9: return new CityInfo("Tefeya", "01", 8.70395, -11.2126);
case 10: return new CityInfo("Sumbuya", "03", 7.64789, -11.9606);
case 11: return new CityInfo("Simbakoro", "01", 8.61243, -11.00755);
case 12: return new CityInfo("Serabu", "03", 7.79311, -12.05294);
case 13: return new CityInfo("Seidu", "02", 9.01801, -10.59496);
case 14: return new CityInfo("Segbwema", "01", 7.99471, -10.9502);
case 15: return new CityInfo("Sawkta", "02", 8.6323, -13.2025);
case 16: return new CityInfo("Rotifunk", "03", 8.22591, -12.6776);
case 17: return new CityInfo("Rokupr", "02", 8.67121, -12.38497);
case 18: return new CityInfo("Potoru", "03", 7.50596, -11.47897);
case 19: return new CityInfo("Port Loko", "05", 8.76609, -12.78696);
case 20: return new CityInfo("Koyima", "01", 8.70552, -11.02241);
case 21: return new CityInfo("Pepel", "02", 8.58611, -13.05444);
case 22: return new CityInfo("Pendembu", "01", 8.09807, -10.69429);
case 23: return new CityInfo("Panguma", "01", 8.18507, -11.1329);
case 24: return new CityInfo("Giehun", "01", 8.55518, -11.04278);
case 25: return new CityInfo("Moyamba", "03", 8.15898, -12.43168);
case 26: return new CityInfo("Motema", "01", 8.61427, -11.01252);
case 27: return new CityInfo("Mogbwemo", "03", 7.76237, -12.30864);
case 28: return new CityInfo("Mobai", "01", 7.99343, -10.75355);
case 29: return new CityInfo("Masoyila", "02", 8.61119, -13.19101);
case 30: return new CityInfo("Masingbi", "02", 8.78197, -11.95171);
case 31: return new CityInfo("Masaka", "02", 8.66492, -11.8026);
case 32: return new CityInfo("Manowa", "01", 8.17392, -10.74834);
case 33: return new CityInfo("Mange", "02", 8.92262, -12.85688);
case 34: return new CityInfo("Mamboma", "03", 8.08742, -11.68841);
case 35: return new CityInfo("Mambolo", "02", 8.9186, -13.03674);
case 36: return new CityInfo("Makeni", "02", 8.88605, -12.04417);
case 37: return new CityInfo("Makali", "02", 8.62964, -11.66168);
case 38: return new CityInfo("Magburaka", "02", 8.72306, -11.9488);
case 39: return new CityInfo("Lunsar", "02", 8.68439, -12.53499);
case 40: return new CityInfo("Loma", "02", 9.75931, -12.03383);
case 41: return new CityInfo("Largo", "03", 8.27903, -12.1578);
case 42: return new CityInfo("Kukuna", "02", 9.39841, -12.66476);
case 43: return new CityInfo("Koribundu", "03", 7.70952, -11.69354);
case 44: return new CityInfo("Koidu", "01", 8.64387, -10.9714);
case 45: return new CityInfo("Kenema", "01", 7.87687, -11.19025);
case 46: return new CityInfo("Kayima", "01", 8.8879, -11.15932);
case 47: return new CityInfo("Kassiri", "02", 8.93814, -13.11541);
case 48: return new CityInfo("Kambia", "02", 9.12504, -12.91816);
case 49: return new CityInfo("Kamakwie", "02", 9.49689, -12.24061);
case 50: return new CityInfo("Kailahun", "01", 8.2789, -10.573);
case 51: return new CityInfo("Kabala", "02", 9.58893, -11.55256);
case 52: return new CityInfo("Jojoima", "01", 7.87815, -10.78976);
case 53: return new CityInfo("Hastings", "04", 8.37994, -13.13693);
case 54: return new CityInfo("Hangha", "01", 7.93974, -11.14132);
case 55: return new CityInfo("Gorahun", "01", 7.46439, -11.23952);
case 56: return new CityInfo("Freetown", "04", 8.43194, -13.28972);
case 57: return new CityInfo("Giehun", "01", 7.88405, -11.04908);
case 58: return new CityInfo("Gberia Fotombu", "02", 9.87852, -11.16548);
case 59: return new CityInfo("Gandorhun", "03", 7.55502, -11.6926);
case 60: return new CityInfo("Gandorhun", "03", 7.49431, -11.83064);
case 61: return new CityInfo("Freetown", "04", 8.48714, -13.2356);
case 62: return new CityInfo("Foindu", "03", 7.40906, -11.54328);
case 63: return new CityInfo("Daru", "01", 7.98976, -10.84223);
case 64: return new CityInfo("Buedu", "01", 8.2796, -10.37135);
case 65: return new CityInfo("Bunumbu", "01", 8.17421, -10.86432);
case 66: return new CityInfo("Bumpe", "03", 7.89209, -11.90541);
case 67: return new CityInfo("Bumbuna", "02", 9.04466, -11.74576);
case 68: return new CityInfo("Bonthe", "03", 7.52639, -12.505);
case 69: return new CityInfo("Bomi", "03", 7.24611, -11.52583);
case 70: return new CityInfo("Boajibu", "01", 8.18763, -11.34026);
case 71: return new CityInfo("Bo", "03", 7.96472, -11.73833);
case 72: return new CityInfo("Blama", "01", 7.87481, -11.34548);
case 73: return new CityInfo("Binkolo", "02", 8.95225, -11.98029);
case 74: return new CityInfo("Bindi", "02", 9.91376, -11.44669);
case 75: return new CityInfo("Barma", "01", 8.34959, -11.33059);
case 76: return new CityInfo("Baoma", "03", 7.99344, -11.71468);
case 77: return new CityInfo("Palima", "03", 8.11996, -11.50702);
case 78: return new CityInfo("Baiima", "03", 8.10826, -11.84772);
case 79: return new CityInfo("Alikalia", "02", 9.15356, -11.38712);
case 80: return new CityInfo("Konakridee", "02", 8.69778, -13.23917);
case 81: return new CityInfo("Gbewebu", "03", 7.55091, -11.6075);
case 82: return new CityInfo("Pujehun", "03", 7.35806, -11.72083);
default: return new CityInfo("Kent", "04", 8.33333, -13.06667);

                                    }                                        
                                }
                            
                        }
                    }
                