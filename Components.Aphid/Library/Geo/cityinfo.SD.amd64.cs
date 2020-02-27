
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
                                    public const string Country = "SD";
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
                            
                                        var cur = (Math.Abs(19.18163 - lat) + Math.Abs(30.47689 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(12.90918 - lat) + Math.Abs(23.47058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.1525 - lat) + Math.Abs(36.2032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.16028 - lat) + Math.Abs(33.13972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.40118 - lat) + Math.Abs(33.51989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4619 - lat) + Math.Abs(32.2065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.9061 - lat) + Math.Abs(31.2158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.60169 - lat) + Math.Abs(26.68759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.8013 - lat) + Math.Abs(32.4078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.64453 - lat) + Math.Abs(32.47773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.4254 - lat) + Math.Abs(37.729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.01667 - lat) + Math.Abs(31.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.63246 - lat) + Math.Abs(30.3797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.1483 - lat) + Math.Abs(33.93117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.6915 - lat) + Math.Abs(33.4341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.1059 - lat) + Math.Abs(37.3321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56907 - lat) + Math.Abs(33.56718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.18087 - lat) + Math.Abs(32.73999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.04888 - lat) + Math.Abs(24.88069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.47036 - lat) + Math.Abs(31.81126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.35 - lat) + Math.Abs(32.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(33.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.2 - lat) + Math.Abs(24.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.1629 - lat) + Math.Abs(32.66347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.55 - lat) + Math.Abs(34.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.55 - lat) + Math.Abs(31.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.0361 - lat) + Math.Abs(33.1712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.45099 - lat) + Math.Abs(36.39998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.63333 - lat) + Math.Abs(30.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.01111 - lat) + Math.Abs(29.71833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.06667 - lat) + Math.Abs(36.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.4486 - lat) + Math.Abs(34.2186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51667 - lat) + Math.Abs(35.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05 - lat) + Math.Abs(29.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.61745 - lat) + Math.Abs(37.21644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.02158 - lat) + Math.Abs(33.98299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7 - lat) + Math.Abs(30.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.70217 - lat) + Math.Abs(33.98638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.31667 - lat) + Math.Abs(33.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.8659 - lat) + Math.Abs(34.3869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.71667 - lat) + Math.Abs(30.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.81667 - lat) + Math.Abs(36.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.51667 - lat) + Math.Abs(30.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.7 - lat) + Math.Abs(28.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.18421 - lat) + Math.Abs(30.21669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8648 - lat) + Math.Abs(32.3668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03493 - lat) + Math.Abs(35.38344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.5748 - lat) + Math.Abs(33.3373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.03333 - lat) + Math.Abs(27.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.7095 - lat) + Math.Abs(33.3565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.2459 - lat) + Math.Abs(32.9891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4 - lat) + Math.Abs(29.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.55177 - lat) + Math.Abs(32.53241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.3476 - lat) + Math.Abs(32.9437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7463 - lat) + Math.Abs(32.4996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.45262 - lat) + Math.Abs(22.44725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9398 - lat) + Math.Abs(33.234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(34.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75264 - lat) + Math.Abs(33.29836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.73292 - lat) + Math.Abs(28.35786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.62793 - lat) + Math.Abs(25.34936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.26197 - lat) + Math.Abs(33.90812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.0012 - lat) + Math.Abs(32.3116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.46186 - lat) + Math.Abs(26.12583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.2 - lat) + Math.Abs(34.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.59898 - lat) + Math.Abs(33.97205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.7891 - lat) + Math.Abs(34.3592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.05 - lat) + Math.Abs(30.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.35 - lat) + Math.Abs(29.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4562 - lat) + Math.Abs(31.2285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.27543 - lat) + Math.Abs(25.14026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.71195 - lat) + Math.Abs(28.3462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4741 - lat) + Math.Abs(33.24919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Dongola", "43", 19.18163, 30.47689);
case 1: return new CityInfo("Zalingei", "61", 12.90918, 23.47058);
case 2: return new CityInfo("Wagar", "52", 16.1525, 36.2032);
case 3: return new CityInfo("Wad Rāwah", "38", 15.16028, 33.13972);
case 4: return new CityInfo("Wad Medani", "38", 14.40118, 33.51989);
case 5: return new CityInfo("Wad az Zāki", "41", 14.4619, 32.2065);
case 6: return new CityInfo("Umm Ruwaba", "56", 12.9061, 31.2158);
case 7: return new CityInfo("Umm Kaddadah", "55", 13.60169, 26.68759);
case 8: return new CityInfo("Um Jar Al Gharbiyya", "41", 13.8013, 32.4078);
case 9: return new CityInfo("Omdurman", "29", 15.64453, 32.47773);
case 10: return new CityInfo("Tokār", "36", 18.4254, 37.729);
case 11: return new CityInfo("Tandaltī", "41", 13.01667, 31.86667);
case 12: return new CityInfo("Talodi", "50", 10.63246, 30.3797);
case 13: return new CityInfo("Singa", "58", 13.1483, 33.93117);
case 14: return new CityInfo("Shendi", "53", 16.6915, 33.4341);
case 15: return new CityInfo("Sawākin", "36", 19.1059, 37.3321);
case 16: return new CityInfo("Sinnar", "58", 13.56907, 33.56718);
case 17: return new CityInfo("Rabak", "41", 13.18087, 32.73999);
case 18: return new CityInfo("Nyala", "49", 12.04888, 24.88069);
case 19: return new CityInfo("Merowe", "43", 18.47036, 31.81126);
case 20: return new CityInfo("Marabba", "41", 12.35, 32.18333);
case 21: return new CityInfo("Maiurno", "58", 13.41667, 33.66667);
case 22: return new CityInfo("Kutum", "55", 14.2, 24.66667);
case 23: return new CityInfo("Kosti", "41", 13.1629, 32.66347);
case 24: return new CityInfo("Kurmuk", "42", 10.55, 34.28333);
case 25: return new CityInfo("Kuraymah", "43", 18.55, 31.85);
case 26: return new CityInfo("Kināna", "58", 14.0361, 33.1712);
case 27: return new CityInfo("Kassala", "52", 15.45099, 36.39998);
case 28: return new CityInfo("Karmah an Nuzul", "43", 19.63333, 30.41667);
case 29: return new CityInfo("Kadugli", "50", 11.01111, 29.71833);
case 30: return new CityInfo("Gebeit", "36", 21.06667, 36.31667);
case 31: return new CityInfo("Jalqani", "58", 12.4486, 34.2186);
case 32: return new CityInfo("Doka", "39", 13.51667, 35.76667);
case 33: return new CityInfo("Dilling", "50", 12.05, 29.65);
case 34: return new CityInfo("Port Sudan", "36", 19.61745, 37.21644);
case 35: return new CityInfo("Berber", "53", 18.02158, 33.98299);
case 36: return new CityInfo("Bārah", "56", 13.7, 30.36667);
case 37: return new CityInfo("Atbara", "53", 17.70217, 33.98638);
case 38: return new CityInfo("As Sūkī", "58", 13.31667, 33.88333);
case 39: return new CityInfo("Ar Ruseris", "42", 11.8659, 34.3869);
case 40: return new CityInfo("Ar Rahad", "56", 12.71667, 30.65);
case 41: return new CityInfo("Aroma", "52", 15.81667, 36.13333);
case 42: return new CityInfo("Argo", "43", 19.51667, 30.41667);
case 43: return new CityInfo("An Nuhūd", "62", 12.7, 28.43333);
case 44: return new CityInfo("El Obeid", "56", 13.18421, 30.21669);
case 45: return new CityInfo("Al Qiţena", "41", 14.8648, 32.3668);
case 46: return new CityInfo("Al Qadarif", "39", 14.03493, 35.38344);
case 47: return new CityInfo("Al Masallamiyya", "38", 14.5748, 33.3373);
case 48: return new CityInfo("Al Mijlad", "62", 11.03333, 27.73333);
case 49: return new CityInfo("El Matama", "53", 16.7095, 33.3565);
case 50: return new CityInfo("Al Manāqil", "38", 14.2459, 32.9891);
case 51: return new CityInfo("Al Lagowa", "62", 11.4, 29.13333);
case 52: return new CityInfo("Khartoum", "29", 15.55177, 32.53241);
case 53: return new CityInfo("Al Kiremit al ‘Arakiyyīn", "38", 14.3476, 32.9437);
case 54: return new CityInfo("Al Kawa", "41", 13.7463, 32.4996);
case 55: return new CityInfo("Geneina", "47", 13.45262, 22.44725);
case 56: return new CityInfo("Al Hilāliyya", "38", 14.9398, 33.234);
case 57: return new CityInfo("Al Ḩawātah", "39", 13.41667, 34.63333);
case 58: return new CityInfo("Al Hasaheisa", "38", 14.75264, 33.29836);
case 59: return new CityInfo("Al Fūlah", "50", 11.73292, 28.35786);
case 60: return new CityInfo("El Fasher", "55", 13.62793, 25.34936);
case 61: return new CityInfo("El Bauga", "53", 18.26197, 33.90812);
case 62: return new CityInfo("Ad Douiem", "41", 14.0012, 32.3116);
case 63: return new CityInfo("El Daein", "60", 11.46186, 26.12583);
case 64: return new CityInfo("Ad Dindar", "58", 13.2, 34.16667);
case 65: return new CityInfo("Ed Damer", "53", 17.59898, 33.97205);
case 66: return new CityInfo("Ad-Damazin", "42", 11.7891, 34.3592);
case 67: return new CityInfo("Ad Dabbah", "43", 18.05, 30.95);
case 68: return new CityInfo("Abū Zabad", "62", 12.35, 29.25);
case 69: return new CityInfo("Abu Jibeha", "50", 11.4562, 31.2285);
case 70: return new CityInfo("Gereida", "49", 11.27543, 25.14026);
case 71: return new CityInfo("El Fula", "62", 11.71195, 28.3462);
default: return new CityInfo("Nagaro", "38", 14.4741, 33.24919);

                                    }                                        
                                }
                            
                        }
                    }
                