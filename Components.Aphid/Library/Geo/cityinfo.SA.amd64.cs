
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
                                    public const string Country = "SA";
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
                            
                                        var cur = (Math.Abs(24.08954 - lat) + Math.Abs(38.0618 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(26.08793 - lat) + Math.Abs(43.96368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.02126 - lat) + Math.Abs(37.2685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.65361 - lat) + Math.Abs(49.91639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.67252 - lat) + Math.Abs(38.66374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.21406 - lat) + Math.Abs(41.6331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.55778 - lat) + Math.Abs(49.99167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.5733 - lat) + Math.Abs(50.04028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.1 - lat) + Math.Abs(44.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.3998 - lat) + Math.Abs(36.57151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.49987 - lat) + Math.Abs(38.21603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.95 - lat) + Math.Abs(42.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.49258 - lat) + Math.Abs(39.58572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.48345 - lat) + Math.Abs(50.04849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.59601 - lat) + Math.Abs(42.94435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.96974 - lat) + Math.Abs(40.20641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.6497 - lat) + Math.Abs(49.95522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.1495 - lat) + Math.Abs(42.62537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.70791 - lat) + Math.Abs(50.06194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.79856 - lat) + Math.Abs(39.03493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.00054 - lat) + Math.Abs(42.6052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.49326 - lat) + Math.Abs(44.12766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.27103 - lat) + Math.Abs(48.42419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.45988 - lat) + Math.Abs(42.5572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.07064 - lat) + Math.Abs(45.45775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.42664 - lat) + Math.Abs(39.82563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.3 - lat) + Math.Abs(42.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.5 - lat) + Math.Abs(49.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.88917 - lat) + Math.Abs(42.55111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.49012 - lat) + Math.Abs(39.18624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.52188 - lat) + Math.Abs(41.69073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.43279 - lat) + Math.Abs(45.97077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.70222 - lat) + Math.Abs(42.11833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.35134 - lat) + Math.Abs(35.69014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.32599 - lat) + Math.Abs(43.97497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.93402 - lat) + Math.Abs(49.6688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.78292 - lat) + Math.Abs(38.79047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.29945 - lat) + Math.Abs(44.81542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.28864 - lat) + Math.Abs(50.11396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.36232 - lat) + Math.Abs(49.72757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.27028 - lat) + Math.Abs(40.41583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.46067 - lat) + Math.Abs(45.57792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.18251 - lat) + Math.Abs(44.59964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.97083 - lat) + Math.Abs(48.73 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.68773 - lat) + Math.Abs(46.72185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.86944 - lat) + Math.Abs(43.4973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.97531 - lat) + Math.Abs(41.03808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.14547 - lat) + Math.Abs(42.12009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.33176 - lat) + Math.Abs(37.34282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.24551 - lat) + Math.Abs(36.45249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.60853 - lat) + Math.Abs(37.92316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.48333 - lat) + Math.Abs(49.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.31117 - lat) + Math.Abs(46.12729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.56542 - lat) + Math.Abs(50.0089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.41667 - lat) + Math.Abs(49.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.47878 - lat) + Math.Abs(49.55824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.38333 - lat) + Math.Abs(49.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.40768 - lat) + Math.Abs(49.59028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.1588 - lat) + Math.Abs(41.28337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.86012 - lat) + Math.Abs(44.22228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.4 - lat) + Math.Abs(49.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.91097 - lat) + Math.Abs(45.35665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.46861 - lat) + Math.Abs(39.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.27944 - lat) + Math.Abs(50.20833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.15541 - lat) + Math.Abs(47.33457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.43905 - lat) + Math.Abs(48.49132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.61951 - lat) + Math.Abs(39.69659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.0174 - lat) + Math.Abs(49.62251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.4 - lat) + Math.Abs(49.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.57946 - lat) + Math.Abs(42.9124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.37736 - lat) + Math.Abs(49.72154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.36467 - lat) + Math.Abs(49.58764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.13915 - lat) + Math.Abs(43.65782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.43333 - lat) + Math.Abs(49.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.01288 - lat) + Math.Abs(41.46767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.50387 - lat) + Math.Abs(45.34813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.56324 - lat) + Math.Abs(49.94331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.9065 - lat) + Math.Abs(42.91724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.027 - lat) + Math.Abs(43.157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.99104 - lat) + Math.Abs(47.16181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.50772 - lat) + Math.Abs(44.39237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.72285 - lat) + Math.Abs(42.25261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.43442 - lat) + Math.Abs(50.10326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.96887 - lat) + Math.Abs(42.83251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.21639 - lat) + Math.Abs(42.50528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.11713 - lat) + Math.Abs(40.38925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.4267 - lat) + Math.Abs(42.8343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.70347 - lat) + Math.Abs(45.86835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.4436 - lat) + Math.Abs(43.25164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.12361 - lat) + Math.Abs(41.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.75806 - lat) + Math.Abs(43.77389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.43333 - lat) + Math.Abs(41.75829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.35903 - lat) + Math.Abs(40.2803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.07268 - lat) + Math.Abs(40.31842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.82611 - lat) + Math.Abs(42.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.49023 - lat) + Math.Abs(46.26871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.59246 - lat) + Math.Abs(54.09599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.74299 - lat) + Math.Abs(42.95528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yanbu", "05", 24.08954, 38.0618);
case 1: return new CityInfo("Unaizah", "08", 26.08793, 43.96368);
case 2: return new CityInfo("Umluj", "19", 25.02126, 37.2685);
case 3: return new CityInfo("Umm as Sāhik", "06", 26.65361, 49.91639);
case 4: return new CityInfo("Turaif", "15", 31.67252, 38.66374);
case 5: return new CityInfo("Turabah", "14", 21.21406, 41.6331);
case 6: return new CityInfo("At Tūbī", "06", 26.55778, 49.99167);
case 7: return new CityInfo("Tārūt", "06", 26.5733, 50.04028);
case 8: return new CityInfo("Tanūmah", "08", 27.1, 44.13333);
case 9: return new CityInfo("Tabuk", "19", 28.3998, 36.57151);
case 10: return new CityInfo("Ţubarjal", "20", 30.49987, 38.21603);
case 11: return new CityInfo("Tabālah", "11", 19.95, 42.4);
case 12: return new CityInfo("Sulţānah", "05", 24.49258, 39.58572);
case 13: return new CityInfo("Sayhāt", "06", 26.48345, 50.04849);
case 14: return new CityInfo("Şāmitah", "17", 16.59601, 42.94435);
case 15: return new CityInfo("Sakakah", "20", 29.96974, 40.20641);
case 16: return new CityInfo("Şafwá", "06", 26.6497, 49.95522);
case 17: return new CityInfo("Şabyā", "17", 17.1495, 42.62537);
case 18: return new CityInfo("Raḩīmah", "06", 26.70791, 50.06194);
case 19: return new CityInfo("Rābigh", "14", 22.79856, 39.03493);
case 20: return new CityInfo("Qal‘at Bīshah", "11", 20.00054, 42.6052);
case 21: return new CityInfo("Najrān", "16", 17.49326, 44.12766);
case 22: return new CityInfo("Mulayjah", "06", 27.27103, 48.42419);
case 23: return new CityInfo("Mislīyah", "17", 17.45988, 42.5572);
case 24: return new CityInfo("Marāt", "10", 25.07064, 45.45775);
case 25: return new CityInfo("Mecca", "14", 21.42664, 39.82563);
case 26: return new CityInfo("Khamis Mushait", "11", 18.3, 42.73333);
case 27: return new CityInfo("Julayjilah", "06", 25.5, 49.6);
case 28: return new CityInfo("Jizan", "17", 16.88917, 42.55111);
case 29: return new CityInfo("Jeddah", "14", 21.49012, 39.18624);
case 30: return new CityInfo("Ha'il", "13", 27.52188, 41.69073);
case 31: return new CityInfo("Hafar Al-Batin", "06", 28.43279, 45.97077);
case 32: return new CityInfo("Farasān", "17", 16.70222, 42.11833);
case 33: return new CityInfo("Duba", "19", 27.35134, 35.69014);
case 34: return new CityInfo("Buraydah", "08", 26.32599, 43.97497);
case 35: return new CityInfo("Abqaiq", "06", 25.93402, 49.6688);
case 36: return new CityInfo("Badr Ḩunayn", "05", 23.78292, 38.79047);
case 37: return new CityInfo("Az Zulfī", "10", 26.29945, 44.81542);
case 38: return new CityInfo("Dhahran", "06", 26.28864, 50.11396);
case 39: return new CityInfo("Aţ Ţaraf", "06", 25.36232, 49.72757);
case 40: return new CityInfo("Ta’if", "14", 21.27028, 40.41583);
case 41: return new CityInfo("As Sulayyil", "10", 20.46067, 45.57792);
case 42: return new CityInfo("Sājir", "10", 25.18251, 44.59964);
case 43: return new CityInfo("As Saffānīyah", "06", 27.97083, 48.73);
case 44: return new CityInfo("Riyadh", "10", 24.68773, 46.72185);
case 45: return new CityInfo("Ar Rass", "08", 25.86944, 43.4973);
case 46: return new CityInfo("Arar", "15", 30.97531, 41.03808);
case 47: return new CityInfo("An Nimāş", "11", 19.14547, 42.12009);
case 48: return new CityInfo("Qurayyat", "20", 31.33176, 37.34282);
case 49: return new CityInfo("Al Wajh", "19", 26.24551, 36.45249);
case 50: return new CityInfo("Al-`Ula", "05", 26.60853, 37.92316);
case 51: return new CityInfo("Al Qurayn", "06", 25.48333, 49.6);
case 52: return new CityInfo("Qaisumah", "06", 28.31117, 46.12729);
case 53: return new CityInfo("Al Qaţīf", "06", 26.56542, 50.0089);
case 54: return new CityInfo("Al Qārah", "06", 25.41667, 49.66667);
case 55: return new CityInfo("Al Muţayrifī", "06", 25.47878, 49.55824);
case 56: return new CityInfo("Al Munayzilah", "06", 25.38333, 49.66667);
case 57: return new CityInfo("Al Mubarraz", "06", 25.40768, 49.59028);
case 58: return new CityInfo("Al Mindak", "02", 20.1588, 41.28337);
case 59: return new CityInfo("Al Mithnab", "08", 25.86012, 44.22228);
case 60: return new CityInfo("Al Markaz", "06", 25.4, 49.73333);
case 61: return new CityInfo("Al Majma‘ah", "10", 25.91097, 45.35665);
case 62: return new CityInfo("Medina", "05", 24.46861, 39.61417);
case 63: return new CityInfo("Khobar", "06", 26.27944, 50.20833);
case 64: return new CityInfo("Al Kharj", "10", 24.15541, 47.33457);
case 65: return new CityInfo("Al Khafjī", "06", 28.43905, 48.49132);
case 66: return new CityInfo("Al Jumūm", "14", 21.61951, 39.69659);
case 67: return new CityInfo("Al Jubayl", "06", 27.0174, 49.62251);
case 68: return new CityInfo("Al Jubayl", "06", 25.4, 49.65);
case 69: return new CityInfo("Al Jarādīyah", "17", 16.57946, 42.9124);
case 70: return new CityInfo("Al Jafr", "06", 25.37736, 49.72154);
case 71: return new CityInfo("Al Hufūf", "06", 25.36467, 49.58764);
case 72: return new CityInfo("Al Bukayrīyah", "08", 26.13915, 43.65782);
case 73: return new CityInfo("Al Baţţālīyah", "06", 25.43333, 49.63333);
case 74: return new CityInfo("Al Bahah", "02", 20.01288, 41.46767);
case 75: return new CityInfo("Al Arţāwīyah", "10", 26.50387, 45.34813);
case 76: return new CityInfo("Al Awjām", "06", 26.56324, 49.94331);
case 77: return new CityInfo("Afif", "10", 23.9065, 42.91724);
case 78: return new CityInfo("Adh Dhibiyah", "08", 26.027, 43.157);
case 79: return new CityInfo("Ad Dilam", "10", 23.99104, 47.16181);
case 80: return new CityInfo("Ad Dawādimī", "10", 24.50772, 44.39237);
case 81: return new CityInfo("Ad Darb", "17", 17.72285, 42.25261);
case 82: return new CityInfo("Dammam", "06", 26.43442, 50.10326);
case 83: return new CityInfo("Abū ‘Arīsh", "17", 16.96887, 42.83251);
case 84: return new CityInfo("Abha", "11", 18.21639, 42.50528);
case 85: return new CityInfo("Şuwayr", "20", 30.11713, 40.38925);
case 86: return new CityInfo("Wed Alnkil", "08", 25.4267, 42.8343);
case 87: return new CityInfo("Tumayr", "10", 25.70347, 45.86835);
case 88: return new CityInfo("Al Fuwayliq", "08", 26.4436, 43.25164);
case 89: return new CityInfo("Al Majāridah", "11", 19.12361, 41.91111);
case 90: return new CityInfo("Ain AlBaraha", "10", 24.75806, 43.77389);
case 91: return new CityInfo("Al Muwayh", "14", 22.43333, 41.75829);
case 92: return new CityInfo("Al Hadā", "14", 21.35903, 40.2803);
case 93: return new CityInfo("Ash Shafā", "14", 21.07268, 40.31842);
case 94: return new CityInfo("Mizhirah", "17", 16.82611, 42.73333);
case 95: return new CityInfo("shokhaibٍ", "10", 24.49023, 46.26871);
case 96: return new CityInfo("Shaybah", "06", 22.59246, 54.09599);
default: return new CityInfo("Alrmtheiah", "08", 24.74299, 42.95528);

                                    }                                        
                                }
                            
                        }
                    }
                