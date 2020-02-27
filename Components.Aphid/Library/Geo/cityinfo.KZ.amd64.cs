
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
                                    public const string Country = "KZ";
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
                            
                                        var cur = (Math.Abs(49.33333 - lat) + Math.Abs(49.4 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(43.59417 - lat) + Math.Abs(52.07889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.34116 - lat) + Math.Abs(52.86192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.14132 - lat) + Math.Abs(57.12855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.34678 - lat) + Math.Abs(51.34932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58022 - lat) + Math.Abs(57.18289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.14391 - lat) + Math.Abs(56.48196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.16667 - lat) + Math.Abs(52.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83333 - lat) + Math.Abs(59.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03333 - lat) + Math.Abs(48.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.32781 - lat) + Math.Abs(53.53246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85611 - lat) + Math.Abs(46.83361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19925 - lat) + Math.Abs(50.85544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23333 - lat) + Math.Abs(51.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.46912 - lat) + Math.Abs(57.41914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.49111 - lat) + Math.Abs(52.10861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88504 - lat) + Math.Abs(53.79194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74746 - lat) + Math.Abs(56.50611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65 - lat) + Math.Abs(53.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6 - lat) + Math.Abs(49.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66667 - lat) + Math.Abs(51.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95307 - lat) + Math.Abs(54.01978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.07854 - lat) + Math.Abs(51.28992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.25117 - lat) + Math.Abs(58.44003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76612 - lat) + Math.Abs(48.68903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43528 - lat) + Math.Abs(53.48639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80187 - lat) + Math.Abs(73.10211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11073 - lat) + Math.Abs(50.29454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.55 - lat) + Math.Abs(51.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50654 - lat) + Math.Abs(50.26388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22102 - lat) + Math.Abs(51.95723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.18032 - lat) + Math.Abs(51.68116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.82981 - lat) + Math.Abs(58.15042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.42207 - lat) + Math.Abs(46.84705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21667 - lat) + Math.Abs(50.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.25676 - lat) + Math.Abs(52.59895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52722 - lat) + Math.Abs(52.98111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09878 - lat) + Math.Abs(54.08426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.2 - lat) + Math.Abs(51.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42724 - lat) + Math.Abs(52.71392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31667 - lat) + Math.Abs(55.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68975 - lat) + Math.Abs(55.87512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24139 - lat) + Math.Abs(52.94111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54479 - lat) + Math.Abs(50.24629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56022 - lat) + Math.Abs(58.27715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06667 - lat) + Math.Abs(51.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11667 - lat) + Math.Abs(51.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.27969 - lat) + Math.Abs(57.20718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.65 - lat) + Math.Abs(51.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1681 - lat) + Math.Abs(52.99782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.77177 - lat) + Math.Abs(53.1858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.59786 - lat) + Math.Abs(51.24171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.7949 - lat) + Math.Abs(54.71762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.72654 - lat) + Math.Abs(84.27318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48778 - lat) + Math.Abs(64.07806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74211 - lat) + Math.Abs(71.71245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78333 - lat) + Math.Abs(67.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93112 - lat) + Math.Abs(81.3615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19019 - lat) + Math.Abs(61.19894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5388 - lat) + Math.Abs(75.31326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85692 - lat) + Math.Abs(72.83598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.56222 - lat) + Math.Abs(69.73428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84607 - lat) + Math.Abs(62.15264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.9 - lat) + Math.Abs(71.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21094 - lat) + Math.Abs(81.21596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91058 - lat) + Math.Abs(67.31665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46657 - lat) + Math.Abs(84.87144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61667 - lat) + Math.Abs(61.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.34525 - lat) + Math.Abs(68.4574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90652 - lat) + Math.Abs(67.24637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2927 - lat) + Math.Abs(68.105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66119 - lat) + Math.Abs(66.59684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68333 - lat) + Math.Abs(73.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5334 - lat) + Math.Abs(70.3496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.54927 - lat) + Math.Abs(81.84997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25201 - lat) + Math.Abs(77.98007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09302 - lat) + Math.Abs(81.62939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.48578 - lat) + Math.Abs(70.29601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.29733 - lat) + Math.Abs(68.25175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.40056 - lat) + Math.Abs(77.59333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.74947 - lat) + Math.Abs(66.48852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.44306 - lat) + Math.Abs(66.07982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.63389 - lat) + Math.Abs(63.49806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11573 - lat) + Math.Abs(73.16034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.69366 - lat) + Math.Abs(62.5914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05053 - lat) + Math.Abs(64.98395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05494 - lat) + Math.Abs(72.96464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.59998 - lat) + Math.Abs(69.25836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.83322 - lat) + Math.Abs(78.83089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77384 - lat) + Math.Abs(65.55227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83554 - lat) + Math.Abs(62.52078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.63736 - lat) + Math.Abs(71.87404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.30348 - lat) + Math.Abs(77.24085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01556 - lat) + Math.Abs(78.37389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70837 - lat) + Math.Abs(81.04854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83489 - lat) + Math.Abs(70.78861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.5148 - lat) + Math.Abs(69.42732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66338 - lat) + Math.Abs(68.5451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3 - lat) + Math.Abs(69.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.60334 - lat) + Math.Abs(73.75919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69946 - lat) + Math.Abs(70.99457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62811 - lat) + Math.Abs(81.91213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93592 - lat) + Math.Abs(70.18895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5872 - lat) + Math.Abs(81.04883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45376 - lat) + Math.Abs(68.17475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70885 - lat) + Math.Abs(72.59212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81958 - lat) + Math.Abs(72.65407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.88139 - lat) + Math.Abs(67.40882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.42675 - lat) + Math.Abs(80.26669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3025 - lat) + Math.Abs(69.75758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47 - lat) + Math.Abs(77.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5533 - lat) + Math.Abs(69.99835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11917 - lat) + Math.Abs(73.61917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.36178 - lat) + Math.Abs(77.97279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78333 - lat) + Math.Abs(78.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46042 - lat) + Math.Abs(69.16791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41126 - lat) + Math.Abs(79.91545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7908 - lat) + Math.Abs(72.83744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09 - lat) + Math.Abs(61.15194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9729 - lat) + Math.Abs(63.11677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85278 - lat) + Math.Abs(65.50917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45107 - lat) + Math.Abs(64.61977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21435 - lat) + Math.Abs(63.62463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36799 - lat) + Math.Abs(62.86839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.41287 - lat) + Math.Abs(75.47286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.00627 - lat) + Math.Abs(70.79607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94509 - lat) + Math.Abs(79.25502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.17869 - lat) + Math.Abs(70.46768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.86681 - lat) + Math.Abs(77.06304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72521 - lat) + Math.Abs(84.20629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.86667 - lat) + Math.Abs(69.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7165 - lat) + Math.Abs(83.8492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.37361 - lat) + Math.Abs(76.94 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28333 - lat) + Math.Abs(76.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.1666 - lat) + Math.Abs(80.00655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.90573 - lat) + Math.Abs(73.26972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.97143 - lat) + Math.Abs(82.60586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56219 - lat) + Math.Abs(72.57089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.44772 - lat) + Math.Abs(61.74942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68351 - lat) + Math.Abs(83.01674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43781 - lat) + Math.Abs(70.47841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7065 - lat) + Math.Abs(72.70807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.6295 - lat) + Math.Abs(83.52475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.72636 - lat) + Math.Abs(80.17495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41611 - lat) + Math.Abs(73.68444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45278 - lat) + Math.Abs(78.31472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22111 - lat) + Math.Abs(73.36694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75617 - lat) + Math.Abs(78.54188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43 - lat) + Math.Abs(71.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.86976 - lat) + Math.Abs(73.18463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.45981 - lat) + Math.Abs(75.80232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.895 - lat) + Math.Abs(78.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6329 - lat) + Math.Abs(70.41911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.9101 - lat) + Math.Abs(72.72066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.94197 - lat) + Math.Abs(72.76098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.54707 - lat) + Math.Abs(62.49987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.235 - lat) + Math.Abs(78.94556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.7564 - lat) + Math.Abs(69.3839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25346 - lat) + Math.Abs(76.78211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61667 - lat) + Math.Abs(63.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.34413 - lat) + Math.Abs(83.51287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.18152 - lat) + Math.Abs(69.88582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.63589 - lat) + Math.Abs(72.34079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98197 - lat) + Math.Abs(72.60761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23091 - lat) + Math.Abs(73.40146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56603 - lat) + Math.Abs(83.66146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05412 - lat) + Math.Abs(69.47928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2456 - lat) + Math.Abs(66.52081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.84796 - lat) + Math.Abs(69.76773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28333 - lat) + Math.Abs(69.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.75019 - lat) + Math.Abs(62.0584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49442 - lat) + Math.Abs(70.25478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65 - lat) + Math.Abs(73.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75 - lat) + Math.Abs(82.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.26212 - lat) + Math.Abs(71.54839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90225 - lat) + Math.Abs(78.23157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8946 - lat) + Math.Abs(68.3643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.22744 - lat) + Math.Abs(73.79555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51672 - lat) + Math.Abs(68.50463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.02143 - lat) + Math.Abs(79.22055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76278 - lat) + Math.Abs(62.1075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.65995 - lat) + Math.Abs(65.48421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(76.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.52786 - lat) + Math.Abs(68.58287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95349 - lat) + Math.Abs(76.02723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06596 - lat) + Math.Abs(76.08976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.3552 - lat) + Math.Abs(77.45245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33365 - lat) + Math.Abs(75.45775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84782 - lat) + Math.Abs(68.50643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62973 - lat) + Math.Abs(74.35586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.744 - lat) + Math.Abs(73.46848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13887 - lat) + Math.Abs(82.31114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03882 - lat) + Math.Abs(74.71287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.32671 - lat) + Math.Abs(81.57373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.28461 - lat) + Math.Abs(72.9392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.63809 - lat) + Math.Abs(62.69653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95495 - lat) + Math.Abs(66.40841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04023 - lat) + Math.Abs(76.92748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62364 - lat) + Math.Abs(73.10265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.41949 - lat) + Math.Abs(77.0202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.72371 - lat) + Math.Abs(75.32287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20694 - lat) + Math.Abs(71.39694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08333 - lat) + Math.Abs(64.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25332 - lat) + Math.Abs(82.48044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67685 - lat) + Math.Abs(72.67822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09922 - lat) + Math.Abs(66.31557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76453 - lat) + Math.Abs(69.17856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.16882 - lat) + Math.Abs(66.73887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03399 - lat) + Math.Abs(69.38048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25832 - lat) + Math.Abs(67.96991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35567 - lat) + Math.Abs(76.85477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.90596 - lat) + Math.Abs(70.44155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7927 - lat) + Math.Abs(64.18268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.08382 - lat) + Math.Abs(70.31379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71841 - lat) + Math.Abs(80.9295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06028 - lat) + Math.Abs(81.64528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.77763 - lat) + Math.Abs(69.09951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.49795 - lat) + Math.Abs(73.09592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.42193 - lat) + Math.Abs(69.82709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13287 - lat) + Math.Abs(82.52481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52983 - lat) + Math.Abs(77.47146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.47698 - lat) + Math.Abs(83.14803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.16708 - lat) + Math.Abs(69.91459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79304 - lat) + Math.Abs(75.70123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.82774 - lat) + Math.Abs(68.28074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84806 - lat) + Math.Abs(74.995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51779 - lat) + Math.Abs(68.7516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80838 - lat) + Math.Abs(76.27214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96447 - lat) + Math.Abs(80.43437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71003 - lat) + Math.Abs(81.58018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80652 - lat) + Math.Abs(68.35996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68659 - lat) + Math.Abs(71.64469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55688 - lat) + Math.Abs(83.06355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53092 - lat) + Math.Abs(69.79684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5537 - lat) + Math.Abs(68.89792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43015 - lat) + Math.Abs(68.8087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24915 - lat) + Math.Abs(66.92027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8 - lat) + Math.Abs(61.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95 - lat) + Math.Abs(79.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23466 - lat) + Math.Abs(73.06662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.44422 - lat) + Math.Abs(71.95761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98917 - lat) + Math.Abs(74.0575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1801 - lat) + Math.Abs(71.44598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26014 - lat) + Math.Abs(72.85851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.25667 - lat) + Math.Abs(76.92861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99374 - lat) + Math.Abs(70.94704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69244 - lat) + Math.Abs(75.58438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16667 - lat) + Math.Abs(75.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03333 - lat) + Math.Abs(72.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.77952 - lat) + Math.Abs(72.96128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.76788 - lat) + Math.Abs(73.67272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.71667 - lat) + Math.Abs(83.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29617 - lat) + Math.Abs(69.59997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45 - lat) + Math.Abs(72.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.63575 - lat) + Math.Abs(72.86164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.00947 - lat) + Math.Abs(67.41062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.58414 - lat) + Math.Abs(68.35382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81441 - lat) + Math.Abs(84.29102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81162 - lat) + Math.Abs(65.58796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.19806 - lat) + Math.Abs(66.76944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81694 - lat) + Math.Abs(75.04028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8 - lat) + Math.Abs(68.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.83056 - lat) + Math.Abs(70.00194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88222 - lat) + Math.Abs(68.80722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35062 - lat) + Math.Abs(71.88161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.47031 - lat) + Math.Abs(72.01514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21194 - lat) + Math.Abs(73.97861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24593 - lat) + Math.Abs(82.36252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.37633 - lat) + Math.Abs(76.62456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03106 - lat) + Math.Abs(73.70247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65005 - lat) + Math.Abs(63.31163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zhumysker", "00", 49.33333, 49.4);
case 1: return new CityInfo("Zhetibay", "09", 43.59417, 52.07889);
case 2: return new CityInfo("Zhanaozen", "09", 43.34116, 52.86192);
case 3: return new CityInfo("Temir", "04", 49.14132, 57.12855);
case 4: return new CityInfo("Taūshyq", "09", 44.34678, 51.34932);
case 5: return new CityInfo("Shubarshi", "04", 48.58022, 57.18289);
case 6: return new CityInfo("Shubarkuduk", "04", 49.14391, 56.48196);
case 7: return new CityInfo("Shetpe", "09", 44.16667, 52.11667);
case 8: return new CityInfo("Shalqar", "04", 47.83333, 59.6);
case 9: return new CityInfo("Shalkar", "06", 48.03333, 48.9);
case 10: return new CityInfo("Sayötesh", "09", 44.32781, 53.53246);
case 11: return new CityInfo("Saykhin", "07", 48.85611, 46.83361);
case 12: return new CityInfo("Peremetnoe", "07", 51.19925, 50.85544);
case 13: return new CityInfo("Oral", "07", 51.23333, 51.36667);
case 14: return new CityInfo("Kandyagash", "04", 49.46912, 57.41914);
case 15: return new CityInfo("Munayshy", "09", 43.49111, 52.10861);
case 16: return new CityInfo("Miyaly", "06", 48.88504, 53.79194);
case 17: return new CityInfo("Martuk", "04", 50.74746, 56.50611);
case 18: return new CityInfo("Maqat", "06", 47.65, 53.31667);
case 19: return new CityInfo("Maloye Ganyushkino", "06", 46.6, 49.26667);
case 20: return new CityInfo("Makhambet", "06", 47.66667, 51.58333);
case 21: return new CityInfo("Qulsary", "06", 46.95307, 54.01978);
case 22: return new CityInfo("Krūgloozernoe", "07", 51.07854, 51.28992);
case 23: return new CityInfo("Khromtau", "04", 50.25117, 58.44003);
case 24: return new CityInfo("Kaztalovka", "07", 49.76612, 48.68903);
case 25: return new CityInfo("Qaraton", "06", 46.43528, 53.48639);
case 26: return new CityInfo("Karagandy", "12", 49.80187, 73.10211);
case 27: return new CityInfo("Tasqala", "07", 51.11073, 50.29454);
case 28: return new CityInfo("Inderbor", "06", 48.55, 51.78333);
case 29: return new CityInfo("Fort-Shevchenko", "09", 44.50654, 50.26388);
case 30: return new CityInfo("Fedorovka", "07", 51.22102, 51.95723);
case 31: return new CityInfo("Yeraliyev", "09", 43.18032, 51.68116);
case 32: return new CityInfo("Embi", "04", 48.82981, 58.15042);
case 33: return new CityInfo("Zhänibek", "07", 49.42207, 46.84705);
case 34: return new CityInfo("Dzhangala", "00", 49.21667, 50.33333);
case 35: return new CityInfo("Dzhambeyty", "07", 50.25676, 52.59895);
case 36: return new CityInfo("Dossor", "06", 47.52722, 52.98111);
case 37: return new CityInfo("Chingirlau", "07", 51.09878, 54.08426);
case 38: return new CityInfo("Chapaev", "07", 50.2, 51.16667);
case 39: return new CityInfo("Burlin", "07", 51.42724, 52.71392);
case 40: return new CityInfo("Beyneu", "09", 45.31667, 55.2);
case 41: return new CityInfo("Bayganin", "04", 48.68975, 55.87512);
case 42: return new CityInfo("Bayshonas", "06", 47.24139, 52.94111);
case 43: return new CityInfo("Baūtīno", "09", 44.54479, 50.24629);
case 44: return new CityInfo("Batamshinskiy", "04", 50.56022, 58.27715);
case 45: return new CityInfo("Balykshi", "06", 47.06667, 51.86667);
case 46: return new CityInfo("Atyrau", "06", 47.11667, 51.88333);
case 47: return new CityInfo("Aktobe", "04", 50.27969, 57.20718);
case 48: return new CityInfo("Aktau", "09", 43.65, 51.16667);
case 49: return new CityInfo("Aqsay", "07", 51.1681, 52.99782);
case 50: return new CityInfo("Akkol’", "06", 48.77177, 53.1858);
case 51: return new CityInfo("Ömirzaq", "09", 43.59786, 51.24171);
case 52: return new CityInfo("Biikzhal", "06", 46.7949, 54.71762);
case 53: return new CityInfo("Zyryanovsk", "15", 49.72654, 84.27318);
case 54: return new CityInfo("Zhosaly", "14", 45.48778, 64.07806);
case 55: return new CityInfo("Zholymbet", "03", 51.74211, 71.71245);
case 56: return new CityInfo("Zhezqazghan", "12", 47.78333, 67.76667);
case 57: return new CityInfo("Zhezkent", "15", 50.93112, 81.3615);
case 58: return new CityInfo("Dzhetygara", "13", 52.19019, 61.19894);
case 59: return new CityInfo("Zhelezinka", "11", 53.5388, 75.31326);
case 60: return new CityInfo("Zharyk", "12", 48.85692, 72.83598);
case 61: return new CityInfo("Zhangatas", "17", 43.56222, 69.73428);
case 62: return new CityInfo("Ayteke Bi", "14", 45.84607, 62.15264);
case 63: return new CityInfo("Taraz", "17", 42.9, 71.36667);
case 64: return new CityInfo("Zhalghyztobe", "15", 49.21094, 81.21596);
case 65: return new CityInfo("Zhaqsy", "03", 51.91058, 67.31665);
case 66: return new CityInfo("Zaysan", "15", 47.46657, 84.87144);
case 67: return new CityInfo("Yrghyz", "04", 48.61667, 61.26667);
case 68: return new CityInfo("Yavlenka", "16", 54.34525, 68.4574);
case 69: return new CityInfo("Yanykurgan", "14", 43.90652, 67.24637);
case 70: return new CityInfo("Volodarskoye", "16", 53.2927, 68.105);
case 71: return new CityInfo("Volodarskoye", "16", 52.66119, 66.59684);
case 72: return new CityInfo("Verkhniye Kayrakty", "12", 48.68333, 73.28333);
case 73: return new CityInfo("Turar Ryskulov", "10", 42.5334, 70.3496);
case 74: return new CityInfo("Ūst’-Talovka", "15", 50.54927, 81.84997);
case 75: return new CityInfo("Ush-Tyube", "01", 45.25201, 77.98007);
case 76: return new CityInfo("Urzhar", "15", 47.09302, 81.62939);
case 77: return new CityInfo("Tyul’kubas", "10", 42.48578, 70.29601);
case 78: return new CityInfo("Turkestan", "10", 43.29733, 68.25175);
case 79: return new CityInfo("Turgen", "01", 43.40056, 77.59333);
case 80: return new CityInfo("Timiryazevo", "16", 53.74947, 66.48852);
case 81: return new CityInfo("Troyebratskiy", "13", 54.44306, 66.07982);
case 82: return new CityInfo("Torghay", "13", 49.63389, 63.49806);
case 83: return new CityInfo("Tokarevka", "12", 50.11573, 73.16034);
case 84: return new CityInfo("Tobol", "13", 52.69366, 62.5914);
case 85: return new CityInfo("Terenozek", "14", 45.05053, 64.98395);
case 86: return new CityInfo("Temirtau", "12", 50.05494, 72.96464);
case 87: return new CityInfo("Temirlanovka", "10", 42.59998, 69.25836);
case 88: return new CityInfo("Tekeli", "01", 44.83322, 78.83089);
case 89: return new CityInfo("Tasböget", "14", 44.77384, 65.55227);
case 90: return new CityInfo("Ayat", "13", 52.83554, 62.52078);
case 91: return new CityInfo("Talshik", "16", 53.63736, 71.87404);
case 92: return new CityInfo("Talghar", "01", 43.30348, 77.24085);
case 93: return new CityInfo("Taldykorgan", "01", 45.01556, 78.37389);
case 94: return new CityInfo("Suykbulak", "15", 49.70837, 81.04854);
case 95: return new CityInfo("Stepnyak", "03", 52.83489, 70.78861);
case 96: return new CityInfo("Smirnovo", "16", 54.5148, 69.42732);
case 97: return new CityInfo("Myrzakent", "10", 40.66338, 68.5451);
case 98: return new CityInfo("Shymkent", "1537272", 42.3, 69.6);
case 99: return new CityInfo("Chu", "17", 43.60334, 73.75919);
case 100: return new CityInfo("Shortandy", "03", 51.69946, 70.99457);
case 101: return new CityInfo("Shemonaīkha", "15", 50.62811, 81.91213);
case 102: return new CityInfo("Shchuchinsk", "03", 52.93592, 70.18895);
case 103: return new CityInfo("Shar", "15", 49.5872, 81.04883);
case 104: return new CityInfo("Shantobe", "03", 52.45376, 68.17475);
case 105: return new CityInfo("Shakhtinsk", "12", 49.70885, 72.59212);
case 106: return new CityInfo("Shakhan", "12", 49.81958, 72.65407);
case 107: return new CityInfo("Sergeyevka", "16", 53.88139, 67.40882);
case 108: return new CityInfo("Semey", "15", 50.42675, 80.26669);
case 109: return new CityInfo("Sayram", "10", 42.3025, 69.75758);
case 110: return new CityInfo("Sayaq", "12", 47, 77.26667);
case 111: return new CityInfo("Sastobe", "10", 42.5533, 69.99835);
case 112: return new CityInfo("Saryshaghan", "12", 46.11917, 73.61917);
case 113: return new CityInfo("Saryozek", "01", 44.36178, 77.97279);
case 114: return new CityInfo("Sarykamys", "00", 47.78333, 78.71667);
case 115: return new CityInfo("Saryaghash", "10", 41.46042, 69.16791);
case 116: return new CityInfo("Sarkand", "01", 45.41126, 79.91545);
case 117: return new CityInfo("Soran", "12", 49.7908, 72.83744);
case 118: return new CityInfo("Sekseūil", "14", 47.09, 61.15194);
case 119: return new CityInfo("Rudnyy", "13", 52.9729, 63.11677);
case 120: return new CityInfo("Kyzylorda", "14", 44.85278, 65.50917);
case 121: return new CityInfo("Qusmuryn", "13", 52.45107, 64.61977);
case 122: return new CityInfo("Kostanay", "13", 53.21435, 63.62463);
case 123: return new CityInfo("Qashar", "13", 53.36799, 62.86839);
case 124: return new CityInfo("Qarqaraly", "12", 49.41287, 75.47286);
case 125: return new CityInfo("Qarazhal", "12", 48.00627, 70.79607);
case 126: return new CityInfo("Qaraūyl", "15", 48.94509, 79.25502);
case 127: return new CityInfo("Karatau", "17", 43.17869, 70.46768);
case 128: return new CityInfo("Kapshagay", "01", 43.86681, 77.06304);
case 129: return new CityInfo("Tūghyl", "15", 47.72521, 84.20629);
case 130: return new CityInfo("Petropavl", "16", 54.86667, 69.15);
case 131: return new CityInfo("Pervorosiyskiy", "00", 49.7165, 83.8492);
case 132: return new CityInfo("Pervomayka", "01", 43.37361, 76.94);
case 133: return new CityInfo("Pavlodar", "11", 52.28333, 76.96667);
case 134: return new CityInfo("Zharkent", "01", 44.1666, 80.00655);
case 135: return new CityInfo("Oytal", "17", 42.90573, 73.26972);
case 136: return new CityInfo("Ust-Kamenogorsk", "15", 49.97143, 82.60586);
case 137: return new CityInfo("Osakarovka", "12", 50.56219, 72.57089);
case 138: return new CityInfo("Ordzhonikidze", "13", 52.44772, 61.74942);
case 139: return new CityInfo("Ognevka", "15", 49.68351, 83.01674);
case 140: return new CityInfo("Zhabagly", "10", 42.43781, 70.47841);
case 141: return new CityInfo("Novodolinskiy", "12", 49.7065, 72.70807);
case 142: return new CityInfo("Zhanga Buqtyrma", "15", 49.6295, 83.52475);
case 143: return new CityInfo("Narynkol", "01", 42.72636, 80.17495);
case 144: return new CityInfo("Mynaral", "17", 45.41611, 73.68444);
case 145: return new CityInfo("Molaly", "01", 45.45278, 78.31472);
case 146: return new CityInfo("Moyynty", "12", 47.22111, 73.36694);
case 147: return new CityInfo("Kurchatov", "15", 50.75617, 78.54188);
case 148: return new CityInfo("Sarykemer", "17", 43, 71.5);
case 149: return new CityInfo("Merke", "17", 42.86976, 73.18463);
case 150: return new CityInfo("Mayqayyng", "11", 51.45981, 75.80232);
case 151: return new CityInfo("Matay", "01", 45.895, 78.71806);
case 152: return new CityInfo("Makinsk", "03", 52.6329, 70.41911);
case 153: return new CityInfo("Lugovoye", "17", 42.9101, 72.72066);
case 154: return new CityInfo("Lugovoy", "17", 42.94197, 72.76098);
case 155: return new CityInfo("Lisakovsk", "13", 52.54707, 62.49987);
case 156: return new CityInfo("Lepsy", "01", 46.235, 78.94556);
case 157: return new CityInfo("Leninskoye", "10", 41.7564, 69.3839);
case 158: return new CityInfo("Leninskiy", "11", 52.25346, 76.78211);
case 159: return new CityInfo("Baikonur", "08", 45.61667, 63.31667);
case 160: return new CityInfo("Ridder", "15", 50.34413, 83.51287);
case 161: return new CityInfo("Lenger", "10", 42.18152, 69.88582);
case 162: return new CityInfo("Kzyltu", "16", 53.63589, 72.34079);
case 163: return new CityInfo("Kyzylzhar", "12", 49.98197, 72.60761);
case 164: return new CityInfo("Kushoky", "12", 50.23091, 73.40146);
case 165: return new CityInfo("Kurchum", "15", 48.56603, 83.66146);
case 166: return new CityInfo("Egindiköl", "03", 51.05412, 69.47928);
case 167: return new CityInfo("Krasnogorskiy", "03", 52.2456, 66.52081);
case 168: return new CityInfo("Taiynsha", "16", 53.84796, 69.76773);
case 169: return new CityInfo("Kokshetau", "03", 53.28333, 69.4);
case 170: return new CityInfo("Komsomolets", "13", 53.75019, 62.0584);
case 171: return new CityInfo("Kokterek", "10", 42.49442, 70.25478);
case 172: return new CityInfo("Koktal", "12", 49.65, 73.51667);
case 173: return new CityInfo("Kokpekty", "00", 48.75, 82.4);
case 174: return new CityInfo("Kīevka", "12", 50.26212, 71.54839);
case 175: return new CityInfo("Balpyk Bī", "01", 44.90225, 78.23157);
case 176: return new CityInfo("Asyqata", "10", 40.8946, 68.3643);
case 177: return new CityInfo("Khantaū", "17", 44.22744, 73.79555);
case 178: return new CityInfo("Kentau", "10", 43.51672, 68.50463);
case 179: return new CityInfo("Kegen", "01", 43.02143, 79.22055);
case 180: return new CityInfo("Qazaly", "14", 45.76278, 62.1075);
case 181: return new CityInfo("Karasu", "13", 52.65995, 65.48421);
case 182: return new CityInfo("Karabas", "00", 46.53333, 76.2);
case 183: return new CityInfo("Kantagi", "10", 43.52786, 68.58287);
case 184: return new CityInfo("Kalkaman", "11", 51.95349, 76.02723);
case 185: return new CityInfo("GT", "11", 53.06596, 76.08976);
case 186: return new CityInfo("Esik", "01", 43.3552, 77.45245);
case 187: return new CityInfo("Irtyshsk", "11", 53.33365, 75.45775);
case 188: return new CityInfo("Atakent", "10", 40.84782, 68.50643);
case 189: return new CityInfo("Gülshat", "12", 46.62973, 74.35586);
case 190: return new CityInfo("Granitogorsk", "17", 42.744, 73.46848);
case 191: return new CityInfo("Glubokoye", "15", 50.13887, 82.31114);
case 192: return new CityInfo("Georgiyevka", "17", 43.03882, 74.71287);
case 193: return new CityInfo("Georgīevka", "15", 49.32671, 81.57373);
case 194: return new CityInfo("Moyynkum", "17", 44.28461, 72.9392);
case 195: return new CityInfo("Fyodorovka", "13", 53.63809, 62.69653);
case 196: return new CityInfo("Esil", "03", 51.95495, 66.40841);
case 197: return new CityInfo("Aksu", "11", 52.04023, 76.92748);
case 198: return new CityInfo("Yermentau", "03", 51.62364, 73.10265);
case 199: return new CityInfo("Otegen Batyra", "01", 43.41949, 77.0202);
case 200: return new CityInfo("Ekibastuz", "11", 51.72371, 75.32287);
case 201: return new CityInfo("Zhambyl", "12", 47.20694, 71.39694);
case 202: return new CityInfo("Dzhalagash", "14", 45.08333, 64.66667);
case 203: return new CityInfo("Druzhba", "01", 45.25332, 82.48044);
case 204: return new CityInfo("Dolinka", "12", 49.67685, 72.67822);
case 205: return new CityInfo("Derzhavīnsk", "03", 51.09922, 66.31557);
case 206: return new CityInfo("Chulakkurgan", "10", 43.76453, 69.17856);
case 207: return new CityInfo("Shīeli", "14", 44.16882, 66.73887);
case 208: return new CityInfo("Chayan", "10", 43.03399, 69.38048);
case 209: return new CityInfo("Chardara", "10", 41.25832, 67.96991);
case 210: return new CityInfo("Burunday", "01", 43.35567, 76.85477);
case 211: return new CityInfo("Bulayevo", "16", 54.90596, 70.44155);
case 212: return new CityInfo("Borovskoy", "13", 53.7927, 64.18268);
case 213: return new CityInfo("Būrabay", "16", 53.08382, 70.31379);
case 214: return new CityInfo("Borodulikha", "15", 50.71841, 80.9295);
case 215: return new CityInfo("Priisk Boko", "15", 49.06028, 81.64528);
case 216: return new CityInfo("Bishkul", "16", 54.77763, 69.09951);
case 217: return new CityInfo("Bestobe", "03", 52.49795, 73.09592);
case 218: return new CityInfo("Belyye Vody", "10", 42.42193, 69.82709);
case 219: return new CityInfo("Belousovka", "15", 50.13287, 82.52481);
case 220: return new CityInfo("Belogor’ye", "11", 51.52983, 77.47146);
case 221: return new CityInfo("Belogorskīy", "15", 49.47698, 83.14803);
case 222: return new CityInfo("Bayzhansay", "10", 43.16708, 69.91459);
case 223: return new CityInfo("Bayanaul", "11", 50.79304, 75.70123);
case 224: return new CityInfo("Qogham", "10", 42.82774, 68.28074);
case 225: return new CityInfo("Balqash", "12", 46.84806, 74.995);
case 226: return new CityInfo("Balkashino", "03", 52.51779, 68.7516);
case 227: return new CityInfo("Bakanas", "01", 44.80838, 76.27214);
case 228: return new CityInfo("Ayagoz", "15", 47.96447, 80.43437);
case 229: return new CityInfo("Auezov", "15", 49.71003, 81.58018);
case 230: return new CityInfo("Atbasar", "03", 51.80652, 68.35996);
case 231: return new CityInfo("Atasū", "12", 48.68659, 71.64469);
case 232: return new CityInfo("Asūbulaq", "15", 49.55688, 83.06355);
case 233: return new CityInfo("Astrakhan", "03", 51.53092, 69.79684);
case 234: return new CityInfo("Ashchysay", "10", 43.5537, 68.89792);
case 235: return new CityInfo("Arys", "10", 42.43015, 68.8087);
case 236: return new CityInfo("Arkalyk", "13", 50.24915, 66.92027);
case 237: return new CityInfo("Aral", "14", 46.8, 61.66667);
case 238: return new CityInfo("Aqtoghay", "15", 46.95, 79.66667);
case 239: return new CityInfo("Aktau", "12", 50.23466, 73.06662);
case 240: return new CityInfo("Aksu", "03", 52.44422, 71.95761);
case 241: return new CityInfo("Aqshataū", "12", 47.98917, 74.0575);
case 242: return new CityInfo("Nur-Sultan", "05", 51.1801, 71.44598);
case 243: return new CityInfo("Aqadyr", "12", 48.26014, 72.85851);
case 244: return new CityInfo("Almaty", "02", 43.25667, 76.92861);
case 245: return new CityInfo("Akkol", "03", 51.99374, 70.94704);
case 246: return new CityInfo("Prigorodnoye", "12", 49.69244, 75.58438);
case 247: return new CityInfo("Aktogay", "12", 48.16667, 75.3);
case 248: return new CityInfo("Aktau", "12", 48.03333, 72.83333);
case 249: return new CityInfo("Aktas", "12", 49.77952, 72.96128);
case 250: return new CityInfo("Aksu-Ayuly", "12", 48.76788, 73.67272);
case 251: return new CityInfo("Aksuat", "00", 48.71667, 83.7);
case 252: return new CityInfo("Akkol’", "03", 53.29617, 69.59997);
case 253: return new CityInfo("Aqbaqay", "17", 45, 72.78333);
case 254: return new CityInfo("Abay", "12", 49.63575, 72.86164);
case 255: return new CityInfo("Shalqīya", "14", 44.00947, 67.41062);
case 256: return new CityInfo("Birlestik", "16", 53.58414, 68.35382);
case 257: return new CityInfo("Maleyevsk", "15", 49.81441, 84.29102);
case 258: return new CityInfo("Belköl", "14", 44.81162, 65.58796);
case 259: return new CityInfo("Novoishimskiy", "16", 53.19806, 66.76944);
case 260: return new CityInfo("Shashūbay", "12", 46.81694, 75.04028);
case 261: return new CityInfo("Atbasar", "03", 51.8, 68.33333);
case 262: return new CityInfo("Shyghanaq", "17", 44.83056, 70.00194);
case 263: return new CityInfo("Shubarköl", "12", 48.88222, 68.80722);
case 264: return new CityInfo("Stepnogorsk", "03", 52.35062, 71.88161);
case 265: return new CityInfo("Zavodskoy", "03", 52.47031, 72.01514);
case 266: return new CityInfo("Ülken", "01", 45.21194, 73.97861);
case 267: return new CityInfo("Altayskiy", "15", 50.24593, 82.36252);
case 268: return new CityInfo("Chemolgan", "01", 43.37633, 76.62456);
case 269: return new CityInfo("Priozersk", "12", 46.03106, 73.70247);
default: return new CityInfo("Tyuratam", "08", 45.65005, 63.31163);

                                    }                                        
                                }
                            
                        }
                    }
                