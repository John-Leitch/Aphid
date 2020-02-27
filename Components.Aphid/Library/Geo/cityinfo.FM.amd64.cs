
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
                                    public const string Country = "FM";
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
                            
                                        var cur = (Math.Abs(7.44648 - lat) + Math.Abs(151.84135 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(5.32479 - lat) + Math.Abs(163.00781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.92477 - lat) + Math.Abs(158.16109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.964 - lat) + Math.Abs(158.206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.622 - lat) + Math.Abs(138.154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.25439 - lat) + Math.Abs(144.45338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.964 - lat) + Math.Abs(158.2062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.07861 - lat) + Math.Abs(154.80752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.83619 - lat) + Math.Abs(154.97143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.78849 - lat) + Math.Abs(157.15954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.20589 - lat) + Math.Abs(160.70327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.915 - lat) + Math.Abs(153.14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6894 - lat) + Math.Abs(149.29908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.35661 - lat) + Math.Abs(149.19908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.63665 - lat) + Math.Abs(149.42788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6366 - lat) + Math.Abs(149.42878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53868 - lat) + Math.Abs(149.41428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.575 - lat) + Math.Abs(149.687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57895 - lat) + Math.Abs(149.68328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.569 - lat) + Math.Abs(150.4195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.799 - lat) + Math.Abs(150.2915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.75 - lat) + Math.Abs(150.341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.985 - lat) + Math.Abs(150.1275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.69281 - lat) + Math.Abs(159.76283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43 - lat) + Math.Abs(151.748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43269 - lat) + Math.Abs(151.74628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55811 - lat) + Math.Abs(151.90922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69242 - lat) + Math.Abs(152.33934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.609 - lat) + Math.Abs(152.2455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.98922 - lat) + Math.Abs(152.57377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.894 - lat) + Math.Abs(152.74 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.834 - lat) + Math.Abs(152.701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.592 - lat) + Math.Abs(153.564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.507 - lat) + Math.Abs(153.8205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.507 - lat) + Math.Abs(153.821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.5066 - lat) + Math.Abs(153.7105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.5066 - lat) + Math.Abs(153.711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.4918 - lat) + Math.Abs(153.54 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.4918 - lat) + Math.Abs(153.5405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.453 - lat) + Math.Abs(153.4575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.45674 - lat) + Math.Abs(153.45965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.2842 - lat) + Math.Abs(153.648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.334 - lat) + Math.Abs(153.738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.334 - lat) + Math.Abs(153.7385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.382 - lat) + Math.Abs(147.0322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.38035 - lat) + Math.Abs(147.02598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.491 - lat) + Math.Abs(146.305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.502 - lat) + Math.Abs(146.166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.588 - lat) + Math.Abs(144.508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.25 - lat) + Math.Abs(144.4445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.687 - lat) + Math.Abs(143.0375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.1435 - lat) + Math.Abs(140.394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.766 - lat) + Math.Abs(140.52 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45 - lat) + Math.Abs(137.484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.51638 - lat) + Math.Abs(138.12167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33359 - lat) + Math.Abs(163.02248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3671 - lat) + Math.Abs(162.98532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.28599 - lat) + Math.Abs(163.02609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.27486 - lat) + Math.Abs(162.97656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.83493 - lat) + Math.Abs(158.2987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.37597 - lat) + Math.Abs(151.88433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Weno", "03", 7.44648, 151.84135);
case 1: return new CityInfo("Tofol", "01", 5.32479, 163.00781);
case 2: return new CityInfo("Palikir - National Government Center", "02", 6.92477, 158.16109);
case 3: return new CityInfo("Kolonia Town", "02", 6.964, 158.206);
case 4: return new CityInfo("Rumung", "04", 9.622, 138.154);
case 5: return new CityInfo("Ifalik Village", "04", 7.25439, 144.45338);
case 6: return new CityInfo("Kolonia", "02", 6.964, 158.2062);
case 7: return new CityInfo("Kapingamarangi", "02", 1.07861, 154.80752);
case 8: return new CityInfo("Nukuoro", "02", 3.83619, 154.97143);
case 9: return new CityInfo("Ngatik", "02", 5.78849, 157.15954);
case 10: return new CityInfo("Pingelap", "02", 6.20589, 160.70327);
case 11: return new CityInfo("Namoluk", "03", 5.915, 153.14);
case 12: return new CityInfo("Houk", "03", 6.6894, 149.29908);
case 13: return new CityInfo("Polowat", "03", 7.35661, 149.19908);
case 14: return new CityInfo("Pulap Village", "03", 7.63665, 149.42788);
case 15: return new CityInfo("Pulap", "03", 7.6366, 149.42878);
case 16: return new CityInfo("Tamatam", "03", 7.53868, 149.41428);
case 17: return new CityInfo("Onoun", "03", 8.575, 149.687);
case 18: return new CityInfo("Onoun", "03", 8.57895, 149.68328);
case 19: return new CityInfo("Pisaras", "03", 8.569, 150.4195);
case 20: return new CityInfo("Onou", "03", 8.799, 150.2915);
case 21: return new CityInfo("Unanu", "03", 8.75, 150.341);
case 22: return new CityInfo("Makur", "03", 8.985, 150.1275);
case 23: return new CityInfo("Mokil", "02", 6.69281, 159.76283);
case 24: return new CityInfo("Nomwin", "03", 8.43, 151.748);
case 25: return new CityInfo("Nomwin Village", "03", 8.43269, 151.74628);
case 26: return new CityInfo("Fananu", "03", 8.55811, 151.90922);
case 27: return new CityInfo("Murilo", "03", 8.69242, 152.33934);
case 28: return new CityInfo("Ruo", "03", 8.609, 152.2455);
case 29: return new CityInfo("Nema", "03", 6.98922, 152.57377);
case 30: return new CityInfo("Losap", "03", 6.894, 152.74);
case 31: return new CityInfo("Piis", "03", 6.834, 152.701);
case 32: return new CityInfo("Ettal", "03", 5.592, 153.564);
case 33: return new CityInfo("Lukunor", "03", 5.507, 153.8205);
case 34: return new CityInfo("Lukunor Village", "03", 5.507, 153.821);
case 35: return new CityInfo("Oneop", "03", 5.5066, 153.7105);
case 36: return new CityInfo("Oneop Village", "03", 5.5066, 153.711);
case 37: return new CityInfo("Moch", "03", 5.4918, 153.54);
case 38: return new CityInfo("Moch Village", "03", 5.4918, 153.5405);
case 39: return new CityInfo("Kuttu", "03", 5.453, 153.4575);
case 40: return new CityInfo("Kuttu Village", "03", 5.45674, 153.45965);
case 41: return new CityInfo("Ta", "03", 5.2842, 153.648);
case 42: return new CityInfo("Satowan", "03", 5.334, 153.738);
case 43: return new CityInfo("Satowan Village", "03", 5.334, 153.7385);
case 44: return new CityInfo("Satawal", "04", 7.382, 147.0322);
case 45: return new CityInfo("Satawal Village", "04", 7.38035, 147.02598);
case 46: return new CityInfo("Lamotrek", "04", 7.491, 146.305);
case 47: return new CityInfo("Elato", "04", 7.502, 146.166);
case 48: return new CityInfo("Faraulep", "04", 8.588, 144.508);
case 49: return new CityInfo("Ifalik", "04", 7.25, 144.4445);
case 50: return new CityInfo("Eauripik", "04", 6.687, 143.0375);
case 51: return new CityInfo("Sorol", "04", 8.1435, 140.394);
case 52: return new CityInfo("Fais", "04", 9.766, 140.52);
case 53: return new CityInfo("Ngulu", "04", 8.45, 137.484);
case 54: return new CityInfo("Colonia", "04", 9.51638, 138.12167);
case 55: return new CityInfo("Lelu", "01", 5.33359, 163.02248);
case 56: return new CityInfo("Tafunsak", "01", 5.3671, 162.98532);
case 57: return new CityInfo("Malem", "01", 5.28599, 163.02609);
case 58: return new CityInfo("Utwe", "01", 5.27486, 162.97656);
case 59: return new CityInfo("Madolenihm Municipality Government", "02", 6.83493, 158.2987);
default: return new CityInfo("Tonoas Municipal Building", "03", 7.37597, 151.88433);

                                    }                                        
                                }
                            
                        }
                    }
                