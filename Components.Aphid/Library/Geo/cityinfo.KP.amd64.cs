
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
                                    public const string Country = "KP";
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
                            
                                        var cur = (Math.Abs(38.85611 - lat) + Math.Abs(125.42444 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(39.81333 - lat) + Math.Abs(125.80417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90889 - lat) + Math.Abs(126.16111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89333 - lat) + Math.Abs(124.59806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15278 - lat) + Math.Abs(127.44361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95389 - lat) + Math.Abs(127.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.99139 - lat) + Math.Abs(125.97778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43167 - lat) + Math.Abs(125.93278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.19833 - lat) + Math.Abs(125.69 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75417 - lat) + Math.Abs(125.645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49472 - lat) + Math.Abs(125.47361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41667 - lat) + Math.Abs(126.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59806 - lat) + Math.Abs(125.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.50722 - lat) + Math.Abs(125.75583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16944 - lat) + Math.Abs(126.88556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9475 - lat) + Math.Abs(127.87111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03385 - lat) + Math.Abs(125.75432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24639 - lat) + Math.Abs(125.87194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0475 - lat) + Math.Abs(125.55667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.88722 - lat) + Math.Abs(125.24139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93472 - lat) + Math.Abs(125.36194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7375 - lat) + Math.Abs(125.40778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6875 - lat) + Math.Abs(125.08278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.98111 - lat) + Math.Abs(125.24472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86722 - lat) + Math.Abs(126.03028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43806 - lat) + Math.Abs(127.24306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85583 - lat) + Math.Abs(127.41806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78194 - lat) + Math.Abs(126.66639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.1425 - lat) + Math.Abs(126.09611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97083 - lat) + Math.Abs(126.55444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67028 - lat) + Math.Abs(125.77611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83167 - lat) + Math.Abs(127.61861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79861 - lat) + Math.Abs(125.79194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71028 - lat) + Math.Abs(127.59833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91833 - lat) + Math.Abs(127.53639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04056 - lat) + Math.Abs(125.71472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86389 - lat) + Math.Abs(125.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69333 - lat) + Math.Abs(125.21028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25083 - lat) + Math.Abs(125.09611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39917 - lat) + Math.Abs(125.61556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.24306 - lat) + Math.Abs(125.78 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61778 - lat) + Math.Abs(125.66472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.0425 - lat) + Math.Abs(127.52389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51083 - lat) + Math.Abs(125.49417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65028 - lat) + Math.Abs(127.40583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02472 - lat) + Math.Abs(128.15972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35778 - lat) + Math.Abs(130.46222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.51878 - lat) + Math.Abs(130.33479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19944 - lat) + Math.Abs(124.53167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97518 - lat) + Math.Abs(126.49584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.66972 - lat) + Math.Abs(129.66889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35118 - lat) + Math.Abs(130.38307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10056 - lat) + Math.Abs(124.39806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38944 - lat) + Math.Abs(125.04667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.06056 - lat) + Math.Abs(129.71167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20194 - lat) + Math.Abs(125.74833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01833 - lat) + Math.Abs(127.45472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.95722 - lat) + Math.Abs(129.99333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.71361 - lat) + Math.Abs(129.68444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.95105 - lat) + Math.Abs(129.85894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.25559 - lat) + Math.Abs(130.28308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.22609 - lat) + Math.Abs(129.20776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15472 - lat) + Math.Abs(126.28944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.81196 - lat) + Math.Abs(130.16534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58778 - lat) + Math.Abs(129.60611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66889 - lat) + Math.Abs(129.18972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96417 - lat) + Math.Abs(129.32778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09028 - lat) + Math.Abs(128.29333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96946 - lat) + Math.Abs(126.58523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32306 - lat) + Math.Abs(128.65528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.09744 - lat) + Math.Abs(129.02954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39542 - lat) + Math.Abs(128.18752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40167 - lat) + Math.Abs(128.17778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99629 - lat) + Math.Abs(126.54756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02528 - lat) + Math.Abs(127.95583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.44113 - lat) + Math.Abs(129.74601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.43389 - lat) + Math.Abs(129.67 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20056 - lat) + Math.Abs(129.47028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.79556 - lat) + Math.Abs(129.77583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46083 - lat) + Math.Abs(126.64139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.52448 - lat) + Math.Abs(130.39718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24278 - lat) + Math.Abs(128.79889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.10914 - lat) + Math.Abs(129.69997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.39273 - lat) + Math.Abs(129.64056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57763 - lat) + Math.Abs(129.8844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57716 - lat) + Math.Abs(129.837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.50417 - lat) + Math.Abs(130.49522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.66309 - lat) + Math.Abs(130.20179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.72409 - lat) + Math.Abs(130.22627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.68867 - lat) + Math.Abs(129.79459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49324 - lat) + Math.Abs(130.32051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35146 - lat) + Math.Abs(130.48817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.22753 - lat) + Math.Abs(129.25408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.93067 - lat) + Math.Abs(130.04994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27388 - lat) + Math.Abs(127.52132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34177 - lat) + Math.Abs(127.37871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45441 - lat) + Math.Abs(127.35522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yonggang-ŭp", "15", 38.85611, 125.42444);
case 1: return new CityInfo("Yŏngbyŏn", "11", 39.81333, 125.80417);
case 2: return new CityInfo("Yŏnan-ŭp", "06", 37.90889, 126.16111);
case 3: return new CityInfo("Yŏmju-ŭp", "11", 39.89333, 124.59806);
case 4: return new CityInfo("Wŏnsan", "09", 39.15278, 127.44361);
case 5: return new CityInfo("T’ongch’ŏn-ŭp", "09", 38.95389, 127.89167);
case 6: return new CityInfo("Sŭngho 1-tong", "12", 38.99139, 125.97778);
case 7: return new CityInfo("Sunch’ŏn", "15", 39.43167, 125.93278);
case 8: return new CityInfo("Sunan", "12", 39.19833, 125.69);
case 9: return new CityInfo("Songnim", "07", 38.75417, 125.645);
case 10: return new CityInfo("Sil-li", "15", 39.49472, 125.47361);
case 11: return new CityInfo("Sinmak", "07", 38.41667, 126.23333);
case 12: return new CityInfo("Sinanju", "15", 39.59806, 125.60972);
case 13: return new CityInfo("Sariwŏn", "07", 38.50722, 125.75583);
case 14: return new CityInfo("Sangsŏng-ni", "15", 39.16944, 126.88556);
case 15: return new CityInfo("Samho-rodongjagu", "03", 39.9475, 127.87111);
case 16: return new CityInfo("Pyongyang", "12", 39.03385, 125.75432);
case 17: return new CityInfo("P’yŏngsŏng", "15", 39.24639, 125.87194);
case 18: return new CityInfo("Pyŏksŏng-ŭp", "06", 38.0475, 125.55667);
case 19: return new CityInfo("Panghyŏn-dong", "11", 39.88722, 125.24139);
case 20: return new CityInfo("Ongjin", "06", 37.93472, 125.36194);
case 21: return new CityInfo("Namp’o", "15", 38.7375, 125.40778);
case 22: return new CityInfo("Kwaksan", "11", 39.6875, 125.08278);
case 23: return new CityInfo("Kusŏng", "11", 39.98111, 125.24472);
case 24: return new CityInfo("Kujang-ŭp", "11", 39.86722, 126.03028);
case 25: return new CityInfo("Kowŏn-ŭp", "03", 39.43806, 127.24306);
case 26: return new CityInfo("Kosan", "09", 38.85583, 127.41806);
case 27: return new CityInfo("Koksan", "07", 38.78194, 126.66639);
case 28: return new CityInfo("Kangdong-ŭp", "12", 39.1425, 126.09611);
case 29: return new CityInfo("Kaesŏng", "06", 37.97083, 126.55444);
case 30: return new CityInfo("Hwangju-ŭp", "07", 38.67028, 125.77611);
case 31: return new CityInfo("Hŭngnam", "03", 39.83167, 127.61861);
case 32: return new CityInfo("Hŭkkyo-ri", "07", 38.79861, 125.79194);
case 33: return new CityInfo("Hoeyang", "09", 38.71028, 127.59833);
case 34: return new CityInfo("Hamhŭng", "03", 39.91833, 127.53639);
case 35: return new CityInfo("Haeju", "06", 38.04056, 125.71472);
case 36: return new CityInfo("Chunghwa", "12", 38.86389, 125.8);
case 37: return new CityInfo("Chŏngju", "11", 39.69333, 125.21028);
case 38: return new CityInfo("Changyŏn", "06", 38.25083, 125.09611);
case 39: return new CityInfo("Chaeryŏng-ŭp", "06", 38.39917, 125.61556);
case 40: return new CityInfo("Ayang-ni", "06", 38.24306, 125.78);
case 41: return new CityInfo("Anju", "15", 39.61778, 125.66472);
case 42: return new CityInfo("Anbyŏn-ŭp", "09", 39.0425, 127.52389);
case 43: return new CityInfo("Anak", "07", 38.51083, 125.49417);
case 44: return new CityInfo("Sinsang-ni", "03", 39.65028, 127.40583);
case 45: return new CityInfo("Yuktae-dong", "03", 40.02472, 128.15972);
case 46: return new CityInfo("Ungsang-nodongjagu", "18", 42.35778, 130.46222);
case 47: return new CityInfo("Ŭndŏk", "17", 42.51878, 130.33479);
case 48: return new CityInfo("Ŭiju", "11", 40.19944, 124.53167);
case 49: return new CityInfo("Ŭijin-dong", "01", 40.97518, 126.49584);
case 50: return new CityInfo("Sŭngam-nodongjagu", "17", 41.66972, 129.66889);
case 51: return new CityInfo("Sŏnbong", "18", 42.35118, 130.38307);
case 52: return new CityInfo("Sinŭiju", "11", 40.10056, 124.39806);
case 53: return new CityInfo("Sakchu-ŭp", "11", 40.38944, 125.04667);
case 54: return new CityInfo("Puryŏng", "17", 42.06056, 129.71167);
case 55: return new CityInfo("Pukchil-lodongjagu", "11", 40.20194, 125.74833);
case 56: return new CityInfo("Yŏnggwang-ŭp", "03", 40.01833, 127.45472);
case 57: return new CityInfo("Onsŏng", "17", 42.95722, 129.99333);
case 58: return new CityInfo("Ranam", "17", 41.71361, 129.68444);
case 59: return new CityInfo("Namyang", "17", 42.95105, 129.85894);
case 60: return new CityInfo("Rajin", "18", 42.25559, 130.28308);
case 61: return new CityInfo("Musan-ŭp", "17", 42.22609, 129.20776);
case 62: return new CityInfo("Manp’o", "01", 41.15472, 126.28944);
case 63: return new CityInfo("Kyŏngwŏn", "17", 42.81196, 130.16534);
case 64: return new CityInfo("Kyŏngsŏng", "17", 41.58778, 129.60611);
case 65: return new CityInfo("Kimch’aek-si", "17", 40.66889, 129.18972);
case 66: return new CityInfo("Kilju", "17", 40.96417, 129.32778);
case 67: return new CityInfo("Kapsan-ŭp", "13", 41.09028, 128.29333);
case 68: return new CityInfo("Kanggye", "01", 40.96946, 126.58523);
case 69: return new CityInfo("Iwŏn-ŭp", "03", 40.32306, 128.65528);
case 70: return new CityInfo("Rimgan-ni", "17", 42.09744, 129.02954);
case 71: return new CityInfo("Hyesan-dong", "13", 41.39542, 128.18752);
case 72: return new CityInfo("Hyesan", "13", 41.40167, 128.17778);
case 73: return new CityInfo("Hŭngju-dong", "01", 40.99629, 126.54756);
case 74: return new CityInfo("Hongwŏn", "03", 40.02528, 127.95583);
case 75: return new CityInfo("Hoeryŏng", "17", 42.44113, 129.74601);
case 76: return new CityInfo("Hoemul-li", "17", 41.43389, 129.67);
case 77: return new CityInfo("Hau-ri", "17", 41.20056, 129.47028);
case 78: return new CityInfo("Chongjin", "17", 41.79556, 129.77583);
case 79: return new CityInfo("Chasŏng", "01", 41.46083, 126.64139);
case 80: return new CityInfo("Aoji", "17", 42.52448, 130.39718);
case 81: return new CityInfo("Sŭngjibaegam", "13", 41.24278, 128.79889);
case 82: return new CityInfo("Komusan Il-tong", "17", 42.10914, 129.69997);
case 83: return new CityInfo("Sŏng-dong", "17", 42.39273, 129.64056);
case 84: return new CityInfo("Chungbong", "17", 42.57763, 129.8844);
case 85: return new CityInfo("Sech’ŏn", "17", 42.57716, 129.837);
case 86: return new CityInfo("Hahoe-dong", "17", 42.50417, 130.49522);
case 87: return new CityInfo("Kogŏnwon", "17", 42.66309, 130.20179);
case 88: return new CityInfo("Ryongdang", "17", 42.72409, 130.22627);
case 89: return new CityInfo("Sambong", "17", 42.68867, 129.79459);
case 90: return new CityInfo("Kwirak", "17", 42.49324, 130.32051);
case 91: return new CityInfo("Ungsang", "18", 42.35146, 130.48817);
case 92: return new CityInfo("Namsan", "17", 42.22753, 129.25408);
case 93: return new CityInfo("P’ungin", "17", 42.93067, 130.04994);
case 94: return new CityInfo("Yongha", "13", 41.27388, 127.52132);
case 95: return new CityInfo("Nongnim", "13", 41.34177, 127.37871);
default: return new CityInfo("Rajuk", "13", 41.45441, 127.35522);

                                    }                                        
                                }
                            
                        }
                    }
                