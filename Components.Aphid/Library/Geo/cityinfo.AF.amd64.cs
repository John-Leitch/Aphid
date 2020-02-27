
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
                                    public const string Country = "AF";
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
                            
                                        var cur = (Math.Abs(33.54149 - lat) + Math.Abs(69.73446 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(34.3436 - lat) + Math.Abs(67.90567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.65389 - lat) + Math.Abs(61.19778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3782 - lat) + Math.Abs(64.77457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.94831 - lat) + Math.Abs(66.42132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.32462 - lat) + Math.Abs(68.44068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.08352 - lat) + Math.Abs(66.84029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.43778 - lat) + Math.Abs(69.02774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.52947 - lat) + Math.Abs(71.3441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.9848 - lat) + Math.Abs(65.4736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.34264 - lat) + Math.Abs(61.74675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.84734 - lat) + Math.Abs(68.44573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.14641 - lat) + Math.Abs(68.79213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.95962 - lat) + Math.Abs(61.86037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.3726 - lat) + Math.Abs(66.17708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.46572 - lat) + Math.Abs(69.61131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73525 - lat) + Math.Abs(66.97379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.93742 - lat) + Math.Abs(68.64622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.25122 - lat) + Math.Abs(63.85553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.68847 - lat) + Math.Abs(68.40205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.97509 - lat) + Math.Abs(63.72868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.69032 - lat) + Math.Abs(63.86361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.59431 - lat) + Math.Abs(61.26895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.52118 - lat) + Math.Abs(64.42116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.88168 - lat) + Math.Abs(70.27674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.62998 - lat) + Math.Abs(65.87806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73605 - lat) + Math.Abs(69.53451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.69941 - lat) + Math.Abs(66.06164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85501 - lat) + Math.Abs(69.64917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.24139 - lat) + Math.Abs(62.94936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.00575 - lat) + Math.Abs(66.40001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.20204 - lat) + Math.Abs(69.5152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.09916 - lat) + Math.Abs(66.20823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00553 - lat) + Math.Abs(68.85578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.57169 - lat) + Math.Abs(70.58859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.30294 - lat) + Math.Abs(62.1474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.28744 - lat) + Math.Abs(69.91283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03975 - lat) + Math.Abs(69.00685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66757 - lat) + Math.Abs(65.7529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.42386 - lat) + Math.Abs(69.37684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.80347 - lat) + Math.Abs(66.32376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97984 - lat) + Math.Abs(70.73928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.10737 - lat) + Math.Abs(64.3052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.52154 - lat) + Math.Abs(67.41315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.69056 - lat) + Math.Abs(69.36881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.00037 - lat) + Math.Abs(68.71346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13529 - lat) + Math.Abs(65.8297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02298 - lat) + Math.Abs(69.35112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.56521 - lat) + Math.Abs(67.03324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.50998 - lat) + Math.Abs(65.67632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58962 - lat) + Math.Abs(69.76005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79023 - lat) + Math.Abs(71.10962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.98333 - lat) + Math.Abs(67.96517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21544 - lat) + Math.Abs(65.93249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.70177 - lat) + Math.Abs(65.23055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07275 - lat) + Math.Abs(64.8359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.1396 - lat) + Math.Abs(67.44046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84972 - lat) + Math.Abs(66.43694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.248 - lat) + Math.Abs(63.0044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.40744 - lat) + Math.Abs(70.63937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26468 - lat) + Math.Abs(68.01551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31999 - lat) + Math.Abs(67.63387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.15 - lat) + Math.Abs(62.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12604 - lat) + Math.Abs(69.83045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79951 - lat) + Math.Abs(62.13917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.52234 - lat) + Math.Abs(68.6264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91939 - lat) + Math.Abs(65.0649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.06183 - lat) + Math.Abs(66.27801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68747 - lat) + Math.Abs(64.29318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41853 - lat) + Math.Abs(66.04358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.55402 - lat) + Math.Abs(70.24292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03999 - lat) + Math.Abs(66.78891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21959 - lat) + Math.Abs(68.7802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94023 - lat) + Math.Abs(61.77589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.19801 - lat) + Math.Abs(68.10798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98735 - lat) + Math.Abs(63.12891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04119 - lat) + Math.Abs(70.47298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.61591 - lat) + Math.Abs(63.66681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54729 - lat) + Math.Abs(65.5676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10575 - lat) + Math.Abs(66.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.64921 - lat) + Math.Abs(70.5914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8085 - lat) + Math.Abs(63.43003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.42064 - lat) + Math.Abs(70.92261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.94458 - lat) + Math.Abs(68.71512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.99529 - lat) + Math.Abs(69.02274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.76664 - lat) + Math.Abs(65.76486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.5572 - lat) + Math.Abs(65.4343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.68956 - lat) + Math.Abs(64.8531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.38795 - lat) + Math.Abs(67.02327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58787 - lat) + Math.Abs(68.95091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.90029 - lat) + Math.Abs(68.79627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.36972 - lat) + Math.Abs(63.17639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.92775 - lat) + Math.Abs(66.63253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.9515 - lat) + Math.Abs(69.1828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.4435 - lat) + Math.Abs(70.80413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.61341 - lat) + Math.Abs(70.76498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.40315 - lat) + Math.Abs(64.46959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.72178 - lat) + Math.Abs(66.13023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73414 - lat) + Math.Abs(66.95292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.5723 - lat) + Math.Abs(66.77403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.62398 - lat) + Math.Abs(70.00511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.89793 - lat) + Math.Abs(67.95652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.21995 - lat) + Math.Abs(71.52284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76009 - lat) + Math.Abs(71.04738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.18934 - lat) + Math.Abs(69.27179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.0649 - lat) + Math.Abs(69.13343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.64286 - lat) + Math.Abs(64.23982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.44565 - lat) + Math.Abs(64.74486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.58408 - lat) + Math.Abs(63.32886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.82009 - lat) + Math.Abs(67.76934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.21422 - lat) + Math.Abs(69.10026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17635 - lat) + Math.Abs(66.51271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74999 - lat) + Math.Abs(69.11899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.22037 - lat) + Math.Abs(68.31259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.43624 - lat) + Math.Abs(61.8383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.92139 - lat) + Math.Abs(64.78361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.64916 - lat) + Math.Abs(69.7812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.0279 - lat) + Math.Abs(66.12817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.67139 - lat) + Math.Abs(70.20944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.70904 - lat) + Math.Abs(67.11087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40856 - lat) + Math.Abs(71.03839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.24001 - lat) + Math.Abs(68.8663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81665 - lat) + Math.Abs(70.10211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99252 - lat) + Math.Abs(66.29654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28403 - lat) + Math.Abs(70.17017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.24494 - lat) + Math.Abs(69.9968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.59382 - lat) + Math.Abs(64.37161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71382 - lat) + Math.Abs(61.62272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48936 - lat) + Math.Abs(66.66409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.50141 - lat) + Math.Abs(66.27997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.29565 - lat) + Math.Abs(61.95221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.10319 - lat) + Math.Abs(70.46073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8711 - lat) + Math.Abs(62.54762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.02866 - lat) + Math.Abs(70.77258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72895 - lat) + Math.Abs(68.857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.99916 - lat) + Math.Abs(69.21582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68567 - lat) + Math.Abs(68.23801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06588 - lat) + Math.Abs(69.42126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.82881 - lat) + Math.Abs(65.62432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88965 - lat) + Math.Abs(70.21875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.4948 - lat) + Math.Abs(70.00605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.56267 - lat) + Math.Abs(66.5814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.33951 - lat) + Math.Abs(69.92041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69736 - lat) + Math.Abs(67.69826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.17835 - lat) + Math.Abs(67.68758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.58908 - lat) + Math.Abs(68.90093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.42898 - lat) + Math.Abs(69.73482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.52919 - lat) + Math.Abs(62.79055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.5488 - lat) + Math.Abs(63.7888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.62587 - lat) + Math.Abs(69.53695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.00108 - lat) + Math.Abs(65.22392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95127 - lat) + Math.Abs(72.318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86279 - lat) + Math.Abs(66.16656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6825 - lat) + Math.Abs(69.11556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5275 - lat) + Math.Abs(65.75833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.8385 - lat) + Math.Abs(67.07377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.24088 - lat) + Math.Abs(70.18274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.62519 - lat) + Math.Abs(65.05511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48108 - lat) + Math.Abs(62.5863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9536 - lat) + Math.Abs(70.77897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.61332 - lat) + Math.Abs(65.71013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.83676 - lat) + Math.Abs(68.40233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78371 - lat) + Math.Abs(69.15001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.77226 - lat) + Math.Abs(69.94489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.20357 - lat) + Math.Abs(65.47311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.12819 - lat) + Math.Abs(70.71828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.52813 - lat) + Math.Abs(69.17233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86477 - lat) + Math.Abs(70.83421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06361 - lat) + Math.Abs(64.14917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.76315 - lat) + Math.Abs(68.39722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.4708 - lat) + Math.Abs(68.65438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.42647 - lat) + Math.Abs(70.45153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11833 - lat) + Math.Abs(69.23778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.98303 - lat) + Math.Abs(67.33558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.34817 - lat) + Math.Abs(62.19967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10922 - lat) + Math.Abs(69.43341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05643 - lat) + Math.Abs(70.40061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.28665 - lat) + Math.Abs(70.37247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.21223 - lat) + Math.Abs(62.21235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.35822 - lat) + Math.Abs(70.76264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50989 - lat) + Math.Abs(68.85598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.72692 - lat) + Math.Abs(67.63696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.3448 - lat) + Math.Abs(61.49321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.73062 - lat) + Math.Abs(63.78264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.5222 - lat) + Math.Abs(70.79063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55391 - lat) + Math.Abs(68.42096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.82089 - lat) + Math.Abs(64.57005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.59744 - lat) + Math.Abs(69.22592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11664 - lat) + Math.Abs(70.58002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.82091 - lat) + Math.Abs(66.45921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.29111 - lat) + Math.Abs(64.86222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.78529 - lat) + Math.Abs(63.24735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.57288 - lat) + Math.Abs(69.85783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.37451 - lat) + Math.Abs(62.11638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83268 - lat) + Math.Abs(69.07756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66667 - lat) + Math.Abs(61.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.30157 - lat) + Math.Abs(62.2465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18897 - lat) + Math.Abs(68.93644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.60918 - lat) + Math.Abs(68.68473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.55132 - lat) + Math.Abs(65.79302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9504 - lat) + Math.Abs(70.07102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.98821 - lat) + Math.Abs(66.82069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43259 - lat) + Math.Abs(64.92071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.14237 - lat) + Math.Abs(61.4469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.56277 - lat) + Math.Abs(67.82191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.43205 - lat) + Math.Abs(65.63484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95806 - lat) + Math.Abs(67.27998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.69031 - lat) + Math.Abs(69.31511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74767 - lat) + Math.Abs(69.04784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66319 - lat) + Math.Abs(66.99339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.28159 - lat) + Math.Abs(69.58531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1539 - lat) + Math.Abs(69.4435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.02978 - lat) + Math.Abs(63.8395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13333 - lat) + Math.Abs(69.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.97744 - lat) + Math.Abs(65.37828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.13231 - lat) + Math.Abs(64.1934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38414 - lat) + Math.Abs(69.45294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86667 - lat) + Math.Abs(70.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99249 - lat) + Math.Abs(71.41935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79095 - lat) + Math.Abs(69.47504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90617 - lat) + Math.Abs(68.48869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.69246 - lat) + Math.Abs(70.92688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41674 - lat) + Math.Abs(65.98234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.34731 - lat) + Math.Abs(63.73966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01583 - lat) + Math.Abs(65.10721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67818 - lat) + Math.Abs(66.80325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.79712 - lat) + Math.Abs(68.93749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01361 - lat) + Math.Abs(69.17139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69132 - lat) + Math.Abs(68.79093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.83003 - lat) + Math.Abs(69.9192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.80298 - lat) + Math.Abs(69.81671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.34099 - lat) + Math.Abs(69.4377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91112 - lat) + Math.Abs(71.0688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55267 - lat) + Math.Abs(68.29828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.24475 - lat) + Math.Abs(62.19165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39773 - lat) + Math.Abs(69.81464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.51952 - lat) + Math.Abs(65.25093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87706 - lat) + Math.Abs(68.0879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84026 - lat) + Math.Abs(65.2309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.39205 - lat) + Math.Abs(68.22317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.24749 - lat) + Math.Abs(70.87218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.22242 - lat) + Math.Abs(69.15037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67283 - lat) + Math.Abs(71.34339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.96744 - lat) + Math.Abs(68.9492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.63348 - lat) + Math.Abs(69.26019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82156 - lat) + Math.Abs(67.82734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75635 - lat) + Math.Abs(66.8972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.00254 - lat) + Math.Abs(70.90664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.49376 - lat) + Math.Abs(69.27427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13068 - lat) + Math.Abs(68.70829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.17355 - lat) + Math.Abs(69.64573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08571 - lat) + Math.Abs(69.47958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.73506 - lat) + Math.Abs(67.3574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03333 - lat) + Math.Abs(71.35809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.68333 - lat) + Math.Abs(71.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87311 - lat) + Math.Abs(71.14697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.55981 - lat) + Math.Abs(66.48926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.905 - lat) + Math.Abs(66.18341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95293 - lat) + Math.Abs(65.12376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23251 - lat) + Math.Abs(69.37719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.7587 - lat) + Math.Abs(61.65397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.21144 - lat) + Math.Abs(66.04765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84616 - lat) + Math.Abs(64.53074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.4362 - lat) + Math.Abs(70.06711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83529 - lat) + Math.Abs(70.3593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.94253 - lat) + Math.Abs(69.71908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.05195 - lat) + Math.Abs(68.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.43206 - lat) + Math.Abs(63.29802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8965 - lat) + Math.Abs(69.72049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.20011 - lat) + Math.Abs(70.27806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66172 - lat) + Math.Abs(69.35095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.64573 - lat) + Math.Abs(62.26959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08796 - lat) + Math.Abs(63.0678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.92232 - lat) + Math.Abs(65.93398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95076 - lat) + Math.Abs(69.2287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8529 - lat) + Math.Abs(69.17062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78764 - lat) + Math.Abs(69.05878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68474 - lat) + Math.Abs(69.02863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.59972 - lat) + Math.Abs(69.25993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.99474 - lat) + Math.Abs(68.05081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.22156 - lat) + Math.Abs(69.21397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.05352 - lat) + Math.Abs(69.25654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21528 - lat) + Math.Abs(67.63972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31292 - lat) + Math.Abs(69.51519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01468 - lat) + Math.Abs(69.59934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.2973 - lat) + Math.Abs(69.68125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.79331 - lat) + Math.Abs(69.0866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.15806 - lat) + Math.Abs(69.31278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.28991 - lat) + Math.Abs(61.52194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.85355 - lat) + Math.Abs(68.44971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.38278 - lat) + Math.Abs(66.27233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.91914 - lat) + Math.Abs(71.09863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96597 - lat) + Math.Abs(71.2746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.41204 - lat) + Math.Abs(70.29634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.66144 - lat) + Math.Abs(65.66098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58469 - lat) + Math.Abs(68.95524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92891 - lat) + Math.Abs(68.46273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.39561 - lat) + Math.Abs(68.86618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.15599 - lat) + Math.Abs(64.78566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83006 - lat) + Math.Abs(65.04299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61794 - lat) + Math.Abs(69.47134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.02634 - lat) + Math.Abs(66.83799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.61922 - lat) + Math.Abs(69.62805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52845 - lat) + Math.Abs(70.4482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59233 - lat) + Math.Abs(70.55814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.52115 - lat) + Math.Abs(68.89985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47355 - lat) + Math.Abs(70.61617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.39951 - lat) + Math.Abs(69.16705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.12583 - lat) + Math.Abs(70.70778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99015 - lat) + Math.Abs(70.91302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.97704 - lat) + Math.Abs(69.37308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.17568 - lat) + Math.Abs(68.73045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.67067 - lat) + Math.Abs(69.32983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zorkot", "37", 33.54149, 69.73446);
case 1: return new CityInfo("Wulêswālī Bihsūd", "27", 34.3436, 67.90567);
case 2: return new CityInfo("Kuhsān", "11", 34.65389, 61.19778);
case 3: return new CityInfo("Lāsh", "07", 35.3782, 64.77457);
case 4: return new CityInfo("Tukzār", "33", 35.94831, 66.42132);
case 5: return new CityInfo("Mīray", "08", 33.32462, 68.44068);
case 6: return new CityInfo("Āq Kupruk", "30", 36.08352, 66.84029);
case 7: return new CityInfo("Zurmat", "36", 33.43778, 69.02774);
case 8: return new CityInfo("Zaybāk", "01", 36.52947, 71.3441);
case 9: return new CityInfo("Zīārat-e Shāh Maqşūd", "23", 31.9848, 65.4736);
case 10: return new CityInfo("Zindah Jān", "11", 34.34264, 61.74675);
case 11: return new CityInfo("Zarghūn Shahr", "29", 32.84734, 68.44573);
case 12: return new CityInfo("Zaṟah Sharan", "29", 33.14641, 68.79213);
case 13: return new CityInfo("Zaranj", "19", 30.95962, 61.86037);
case 14: return new CityInfo("Zamtō Kêlay", "23", 32.3726, 66.17708);
case 15: return new CityInfo("Yangī Qal‘ah", "26", 37.46572, 69.61131);
case 16: return new CityInfo("Bāzār-e Yakāwlang", "05", 34.73525, 66.97379);
case 17: return new CityInfo("Yaḩyá Khēl", "29", 32.93742, 68.64622);
case 18: return new CityInfo("Wāshēr", "10", 32.25122, 63.85553);
case 19: return new CityInfo("Tōrmay", "08", 33.68847, 68.40205);
case 20: return new CityInfo("Tūlak", "09", 33.97509, 63.72868);
case 21: return new CityInfo("Tītān", "09", 33.69032, 63.86361);
case 22: return new CityInfo("Tīr Pul", "11", 34.59431, 61.26895);
case 23: return new CityInfo("Taywarah", "09", 33.52118, 64.42116);
case 24: return new CityInfo("Bāzār-e Tashkān", "01", 36.88168, 70.27674);
case 25: return new CityInfo("Tarinkot", "39", 32.62998, 65.87806);
case 26: return new CityInfo("Taloqan", "26", 36.73605, 69.53451);
case 27: return new CityInfo("Tagāw-Bāy", "33", 35.69941, 66.06164);
case 28: return new CityInfo("Tagāb", "14", 34.85501, 69.64917);
case 29: return new CityInfo("Markaz-e Ḩukūmat-e Sulţān-e Bakwāh", "06", 32.24139, 62.94936);
case 30: return new CityInfo("Spīn Bōldak", "23", 31.00575, 66.40001);
case 31: return new CityInfo("Spērah", "37", 33.20204, 69.5152);
case 32: return new CityInfo("Sōzmah Qal‘ah", "33", 36.09916, 66.20823);
case 33: return new CityInfo("Siyāhgird", "40", 35.00553, 68.85578);
case 34: return new CityInfo("Sheywah", "18", 34.57169, 70.58859);
case 35: return new CityInfo("Shīnḏanḏ", "11", 33.30294, 62.1474);
case 36: return new CityInfo("Shaykh Amīr Kêlay", "37", 33.28744, 69.91283);
case 37: return new CityInfo("Qāshqāl", "40", 35.03975, 69.00685);
case 38: return new CityInfo("Shibirghān", "31", 36.66757, 65.7529);
case 39: return new CityInfo("Shwāk", "36", 33.42386, 69.37684);
case 40: return new CityInfo("Shahr-e Şafā", "28", 31.80347, 66.32376);
case 41: return new CityInfo("Shahrān", "01", 36.97984, 70.73928);
case 42: return new CityInfo("Shahrak", "09", 34.10737, 64.3052);
case 43: return new CityInfo("‘Alāqahdārī Shāh Jōy", "28", 32.52154, 67.41315);
case 44: return new CityInfo("Wulêswālī Sayyid Karam", "36", 33.69056, 69.36881);
case 45: return new CityInfo("Markaz-e Sayyidābād", "27", 34.00037, 68.71346);
case 46: return new CityInfo("Şayād", "33", 36.13529, 65.8297);
case 47: return new CityInfo("Sidqābād", "14", 35.02298, 69.35112);
case 48: return new CityInfo("Sāyagaz", "28", 32.56521, 67.03324);
case 49: return new CityInfo("Sar-e Tayghān", "41", 33.50998, 65.67632);
case 50: return new CityInfo("Sarōbī", "13", 34.58962, 69.76005);
case 51: return new CityInfo("Sar Kāṉī", "34", 34.79023, 71.10962);
case 52: return new CityInfo("Sarfirāz Kalā", "08", 32.98333, 67.96517);
case 53: return new CityInfo("Sar-e Pul", "33", 36.21544, 65.93249);
case 54: return new CityInfo("Sar Chakān", "07", 35.70177, 65.23055);
case 55: return new CityInfo("Sangīn", "10", 32.07275, 64.8359);
case 56: return new CityInfo("Sang-e Māshah", "08", 33.1396, 67.44046);
case 57: return new CityInfo("Sang-e Chārak", "33", 35.84972, 66.43694);
case 58: return new CityInfo("Sang Atesh", "02", 35.248, 63.0044);
case 59: return new CityInfo("Sangar Sarāy", "18", 34.40744, 70.63937);
case 60: return new CityInfo("Aībak", "32", 36.26468, 68.01551);
case 61: return new CityInfo("Rū-ye Sang", "05", 35.31999, 67.63387);
case 62: return new CityInfo("Rūdbār", "19", 30.15, 62.6);
case 63: return new CityInfo("Rustāq", "26", 37.12604, 69.83045);
case 64: return new CityInfo("Rabāţ-e Sangī-ye Pā’īn", "11", 34.79951, 62.13917);
case 65: return new CityInfo("Rāmak", "08", 33.52234, 68.6264);
case 66: return new CityInfo("Qurghān", "07", 36.91939, 65.0649);
case 67: return new CityInfo("Quchanghī", "41", 34.06183, 66.27801);
case 68: return new CityInfo("Sangalak-i-Kaisar", "07", 35.68747, 64.29318);
case 69: return new CityInfo("Qarqīn", "31", 37.41853, 66.04358);
case 70: return new CityInfo("Qarghah’ī", "35", 34.55402, 70.24292);
case 71: return new CityInfo("Qarchī Gak", "30", 37.03999, 66.78891);
case 72: return new CityInfo("Qarāwul", "24", 37.21959, 68.7802);
case 73: return new CityInfo("Qarah Bāgh", "11", 34.94023, 61.77589);
case 74: return new CityInfo("Qarah Bāgh", "08", 33.19801, 68.10798);
case 75: return new CityInfo("Qala i Naw", "02", 34.98735, 63.12891);
case 76: return new CityInfo("Qal‘ah-ye Kūf", "01", 38.04119, 70.47298);
case 77: return new CityInfo("Qal‘ah-ye Kuhnah", "06", 32.61591, 63.66681);
case 78: return new CityInfo("Qal‘ah-ye Shahr", "33", 35.54729, 65.5676);
case 79: return new CityInfo("Qalāt", "28", 32.10575, 66.90833);
case 80: return new CityInfo("Qal‘ah-ye Shāhī", "18", 34.64921, 70.5914);
case 81: return new CityInfo("Qādis", "02", 34.8085, 63.43003);
case 82: return new CityInfo("Pārūn", "38", 35.42064, 70.92261);
case 83: return new CityInfo("Pul-e Khumrī", "03", 35.94458, 68.71512);
case 84: return new CityInfo("Pul-e ‘Alam", "17", 33.99529, 69.02274);
case 85: return new CityInfo("Pasnay", "33", 35.76664, 65.76486);
case 86: return new CityInfo("Pāshmūl", "23", 31.5572, 65.4343);
case 87: return new CityInfo("Pasāband", "09", 33.68956, 64.8531);
case 88: return new CityInfo("Panjāb", "05", 34.38795, 67.02327);
case 89: return new CityInfo("Paghmān", "13", 34.58787, 68.95091);
case 90: return new CityInfo("Ōmnah", "29", 32.90029, 68.79627);
case 91: return new CityInfo("Qaryeh-ye Owbeh", "11", 34.36972, 63.17639);
case 92: return new CityInfo("Uruzgān", "39", 32.92775, 66.63253);
case 93: return new CityInfo("Urgun", "29", 32.9515, 69.1828);
case 94: return new CityInfo("Nūsay", "01", 38.4435, 70.80413);
case 95: return new CityInfo("Nūrgal", "34", 34.61341, 70.76498);
case 96: return new CityInfo("Now Zād", "10", 32.40315, 64.46959);
case 97: return new CityInfo("Nīlī", "41", 33.72178, 66.13023);
case 98: return new CityInfo("Nayak", "05", 34.73414, 66.95292);
case 99: return new CityInfo("Nāyak", "28", 32.5723, 66.77403);
case 100: return new CityInfo("Now Dahānak", "42", 35.62398, 70.00511);
case 101: return new CityInfo("Ōkak", "08", 33.89793, 67.95652);
case 102: return new CityInfo("Nāṟay", "34", 35.21995, 71.52284);
case 103: return new CityInfo("Narang", "34", 34.76009, 71.04738);
case 104: return new CityInfo("Nīkêh", "29", 33.18934, 69.27179);
case 105: return new CityInfo("Nahrīn", "03", 36.0649, 69.13343);
case 106: return new CityInfo("Ḩukūmat-e Nād ‘Alī", "10", 31.64286, 64.23982);
case 107: return new CityInfo("Mūsá Qal‘ah", "10", 32.44565, 64.74486);
case 108: return new CityInfo("Bala Murghab", "02", 35.58408, 63.32886);
case 109: return new CityInfo("Muqêr", "08", 32.82009, 67.76934);
case 110: return new CityInfo("Muḩammad Āghah Wuluswālī", "17", 34.21422, 69.10026);
case 111: return new CityInfo("Mīzān ‘Alāqahdārī", "28", 32.17635, 66.51271);
case 112: return new CityInfo("Mīr Bachah Kōṯ", "13", 34.74999, 69.11899);
case 113: return new CityInfo("Mīrān", "27", 34.22037, 68.31259);
case 114: return new CityInfo("Mīrābād", "19", 30.43624, 61.8383);
case 115: return new CityInfo("Maymana", "07", 35.92139, 64.78361);
case 116: return new CityInfo("Maīdān Khūlah", "36", 33.64916, 69.7812);
case 117: return new CityInfo("Mingajik", "31", 37.0279, 66.12817);
case 118: return new CityInfo("Mehtar Lām", "35", 34.67139, 70.20944);
case 119: return new CityInfo("Mazār-e Sharīf", "30", 36.70904, 67.11087);
case 120: return new CityInfo("Māymay", "01", 38.40856, 71.03839);
case 121: return new CityInfo("Mutā Khān", "29", 33.24001, 68.8663);
case 122: return new CityInfo("Mashhad", "01", 36.81665, 70.10211);
case 123: return new CityInfo("Mardīān", "31", 36.99252, 66.29654);
case 124: return new CityInfo("Mandōl", "38", 35.28403, 70.17017);
case 125: return new CityInfo("Māmā Khēl", "18", 34.24494, 69.9968);
case 126: return new CityInfo("Lashkar Gāh", "10", 31.59382, 64.37161);
case 127: return new CityInfo("Lāsh-e Juwayn", "06", 31.71382, 61.62272);
case 128: return new CityInfo("Larkird", "33", 35.48936, 66.66409);
case 129: return new CityInfo("La‘l", "09", 34.50141, 66.27997);
case 130: return new CityInfo("Kushk", "11", 33.29565, 61.95221);
case 131: return new CityInfo("Kōṯowāl", "18", 34.10319, 70.46073);
case 132: return new CityInfo("Kushk-e Kuhnah", "11", 34.8711, 62.54762);
case 133: return new CityInfo("Kuran wa Munjan", "01", 36.02866, 70.77258);
case 134: return new CityInfo("Kunduz", "24", 36.72895, 68.857);
case 135: return new CityInfo("Khōshī", "17", 33.99916, 69.21582);
case 136: return new CityInfo("Khōshāmand", "29", 32.68567, 68.23801);
case 137: return new CityInfo("Khwājah Ghār", "26", 37.06588, 69.42126);
case 138: return new CityInfo("Khwājah Dū Kōh", "31", 36.82881, 65.62432);
case 139: return new CityInfo("Deh Khwāhān", "01", 37.88965, 70.21875);
case 140: return new CityInfo("Khulbisāt", "37", 33.4948, 70.00605);
case 141: return new CityInfo("Khūgyāṉī", "23", 31.56267, 66.5814);
case 142: return new CityInfo("Khōst", "37", 33.33951, 69.92041);
case 143: return new CityInfo("Khulm", "30", 36.69736, 67.69826);
case 144: return new CityInfo("Khudāydād Khēl", "05", 35.17835, 67.68758);
case 145: return new CityInfo("Khinjān", "03", 35.58908, 68.90093);
case 146: return new CityInfo("Khinj", "42", 35.42898, 69.73482);
case 147: return new CityInfo("Khāsh", "19", 31.52919, 62.79055);
case 148: return new CityInfo("Khān Neshīn", "10", 30.5488, 63.7888);
case 149: return new CityInfo("Khānaqāh", "26", 36.62587, 69.53695);
case 150: return new CityInfo("Chahār Bāgh", "07", 37.00108, 65.22392);
case 151: return new CityInfo("Khandūd", "01", 36.95127, 72.318);
case 152: return new CityInfo("Khānaqāh", "31", 36.86279, 66.16656);
case 153: return new CityInfo("Khanabad", "24", 36.6825, 69.11556);
case 154: return new CityInfo("Khamyāb", "31", 37.5275, 65.75833);
case 155: return new CityInfo("Khākirān", "28", 32.8385, 67.07377);
case 156: return new CityInfo("Kaz̲h̲ah", "18", 34.24088, 70.18274);
case 157: return new CityInfo("Kishk-e Nakhūd", "23", 31.62519, 65.05511);
case 158: return new CityInfo("Karukh", "11", 34.48108, 62.5863);
case 159: return new CityInfo("Kanḏay", "34", 34.9536, 70.77897);
case 160: return new CityInfo("Kandahār", "23", 31.61332, 65.71013);
case 161: return new CityInfo("Kalān Deh", "27", 33.83676, 68.40233);
case 162: return new CityInfo("Kalakān", "13", 34.78371, 69.15001);
case 163: return new CityInfo("Kalafgān", "26", 36.77226, 69.94489);
case 164: return new CityInfo("Kajrān", "41", 33.20357, 65.47311);
case 165: return new CityInfo("Kai", "18", 34.12819, 70.71828);
case 166: return new CityInfo("Kabul", "13", 34.52813, 69.17233);
case 167: return new CityInfo("Jurm", "01", 36.86477, 70.83421);
case 168: return new CityInfo("Jawand", "02", 35.06361, 64.14917);
case 169: return new CityInfo("Jānī Khēl", "29", 32.76315, 68.39722);
case 170: return new CityInfo("Jalrēz", "27", 34.4708, 68.65438);
case 171: return new CityInfo("Jalālābād", "18", 34.42647, 70.45153);
case 172: return new CityInfo("Jabal os Saraj", "40", 35.11833, 69.23778);
case 173: return new CityInfo("Ḩukūmat-e Shīnkaī", "28", 31.98303, 67.33558);
case 174: return new CityInfo("Herāt", "11", 34.34817, 62.19967);
case 175: return new CityInfo("Ḩājī Khēl", "14", 35.10922, 69.43341);
case 176: return new CityInfo("Ḩāfiz̧ Moghul", "01", 37.05643, 70.40061);
case 177: return new CityInfo("Khafizan", "18", 34.28665, 70.37247);
case 178: return new CityInfo("Guz̄arah", "11", 34.21223, 62.21235);
case 179: return new CityInfo("Gōshtah", "18", 34.35822, 70.76264);
case 180: return new CityInfo("Gōmal Kêlay", "29", 32.50989, 68.85598);
case 181: return new CityInfo("‘Alāqahdārī Gēlān", "08", 32.72692, 67.63696);
case 182: return new CityInfo("Ghōriyān", "11", 34.3448, 61.49321);
case 183: return new CityInfo("Ghormach", "02", 35.73062, 63.78264);
case 184: return new CityInfo("Ghurayd Gharamē", "01", 36.5222, 70.79063);
case 185: return new CityInfo("Ghazni", "08", 33.55391, 68.42096);
case 186: return new CityInfo("Gereshk", "10", 31.82089, 64.57005);
case 187: return new CityInfo("Gardez", "36", 33.59744, 69.22592);
case 188: return new CityInfo("Fayzabad", "01", 37.11664, 70.58002);
case 189: return new CityInfo("Faīẕābād", "31", 36.82091, 66.45921);
case 190: return new CityInfo("Fayẕābād", "07", 36.29111, 64.86222);
case 191: return new CityInfo("Qal‘ah-ye Fārsī", "11", 33.78529, 63.24735);
case 192: return new CityInfo("Farkhār", "26", 36.57288, 69.85783);
case 193: return new CityInfo("Farah", "06", 32.37451, 62.11638);
case 194: return new CityInfo("Istālif", "13", 34.83268, 69.07756);
case 195: return new CityInfo("Kafir Qala", "11", 34.66667, 61.06667);
case 196: return new CityInfo("Injīl", "11", 34.30157, 62.2465);
case 197: return new CityInfo("Imām Şāḩib", "24", 37.18897, 68.93644);
case 198: return new CityInfo("Dōshī", "03", 35.60918, 68.68473);
case 199: return new CityInfo("Dowlatyār", "09", 34.55132, 65.79302);
case 200: return new CityInfo("Dowlat Shāh", "35", 34.9504, 70.07102);
case 201: return new CityInfo("Dowlatābād", "30", 36.98821, 66.82069);
case 202: return new CityInfo("Dowlatābād", "07", 36.43259, 64.92071);
case 203: return new CityInfo("Dū Qal‘ah", "06", 32.14237, 61.4469);
case 204: return new CityInfo("Dūāb", "32", 35.56277, 67.82191);
case 205: return new CityInfo("Dê Nārkhēl Kêlay", "23", 32.43205, 65.63484);
case 206: return new CityInfo("Dehī", "32", 35.95806, 67.27998);
case 207: return new CityInfo("Deh-e Şalāḩ", "03", 35.69031, 69.31511);
case 208: return new CityInfo("Deh-e Now", "13", 34.74767, 69.04784);
case 209: return new CityInfo("Dehdādī", "30", 36.66319, 66.99339);
case 210: return new CityInfo("Dwah Manḏay", "37", 33.28159, 69.58531);
case 211: return new CityInfo("Dasht-e Qal‘ah", "26", 37.1539, 69.4435);
case 212: return new CityInfo("Dasht-e Qal‘ah", "06", 33.02978, 63.8395);
case 213: return new CityInfo("Dasht-e Archī", "24", 37.13333, 69.16667);
case 214: return new CityInfo("Darzāb", "31", 35.97744, 65.37828);
case 215: return new CityInfo("Markaz-e Ḩukūmat-e Darwēshān", "10", 31.13231, 64.1934);
case 216: return new CityInfo("Darqad", "26", 37.38414, 69.45294);
case 217: return new CityInfo("Darāyim", "01", 36.86667, 70.38333);
case 218: return new CityInfo("Dāngām", "34", 34.99249, 71.41935);
case 219: return new CityInfo("Ḏanḏar", "40", 34.79095, 69.47504);
case 220: return new CityInfo("Ḩukūmatī Dahanah-ye Ghōrī", "03", 35.90617, 68.48869);
case 221: return new CityInfo("Tsowkêy", "34", 34.69246, 70.92688);
case 222: return new CityInfo("Chīras", "33", 35.41674, 65.98234);
case 223: return new CityInfo("Chisht-e Sharīf", "11", 34.34731, 63.73966);
case 224: return new CityInfo("Chinār", "23", 32.01583, 65.10721);
case 225: return new CityInfo("Chimtāl", "30", 36.67818, 66.80325);
case 226: return new CityInfo("Charkh", "17", 33.79712, 68.93749);
case 227: return new CityInfo("Charikar", "40", 35.01361, 69.17139);
case 228: return new CityInfo("Dowr-e Rabāţ", "24", 36.69132, 68.79093);
case 229: return new CityInfo("Tsapêraī", "36", 33.83003, 69.9192);
case 230: return new CityInfo("Tsamkanī", "36", 33.80298, 69.81671);
case 231: return new CityInfo("Chakaray", "13", 34.34099, 69.4377);
case 232: return new CityInfo("Chākarān", "01", 36.91112, 71.0688);
case 233: return new CityInfo("Chahār Qal‘ah", "08", 33.55267, 68.29828);
case 234: return new CityInfo("Chahār Burj", "11", 34.24475, 62.19165);
case 235: return new CityInfo("Chāh Āb", "26", 37.39773, 69.81464);
case 236: return new CityInfo("Fayrōz Kōh", "09", 34.51952, 65.25093);
case 237: return new CityInfo("Bulōlah", "05", 34.87706, 68.0879);
case 238: return new CityInfo("Bal Chirāgh", "07", 35.84026, 65.2309);
case 239: return new CityInfo("Bāzār-e Tālah", "03", 35.39205, 68.22317);
case 240: return new CityInfo("Bāsawul", "18", 34.24749, 70.87218);
case 241: return new CityInfo("Būrkah", "03", 36.22242, 69.15037);
case 242: return new CityInfo("Barg-e Matāl", "38", 35.67283, 71.34339);
case 243: return new CityInfo("Baraki Barak", "17", 33.96744, 68.9492);
case 244: return new CityInfo("Banū", "03", 35.63348, 69.26019);
case 245: return new CityInfo("Bāmyān", "05", 34.82156, 67.82734);
case 246: return new CityInfo("Balkh", "30", 36.75635, 66.8972);
case 247: return new CityInfo("Bahārak", "01", 37.00254, 70.90664);
case 248: return new CityInfo("Bagrāmī", "13", 34.49376, 69.27427);
case 249: return new CityInfo("Baghlān", "03", 36.13068, 68.70829);
case 250: return new CityInfo("Ḩukūmatī Azrah", "17", 34.17355, 69.64573);
case 251: return new CityInfo("Ārt Khwājah", "26", 37.08571, 69.47958);
case 252: return new CityInfo("‘Alāqahdārī Aṯghar", "28", 31.73506, 67.3574);
case 253: return new CityInfo("Āsmār", "34", 35.03333, 71.35809);
case 254: return new CityInfo("Ashkāsham", "01", 36.68333, 71.53333);
case 255: return new CityInfo("Asadābād", "34", 34.87311, 71.14697);
case 256: return new CityInfo("Arghestān", "23", 31.55981, 66.48926);
case 257: return new CityInfo("Āqchah", "31", 36.905, 66.18341);
case 258: return new CityInfo("Andkhōy", "07", 36.95293, 65.12376);
case 259: return new CityInfo("’Unābah", "42", 35.23251, 69.37719);
case 260: return new CityInfo("Anār Darah", "06", 32.7587, 61.65397);
case 261: return new CityInfo("Amānzī", "23", 30.21144, 66.04765);
case 262: return new CityInfo("‘Alāqahdārī-ye Almār", "07", 35.84616, 64.53074);
case 263: return new CityInfo("‘Alī Shēr ‘Alāqahdārī", "37", 33.4362, 70.06711);
case 264: return new CityInfo("Wuluswālī ‘Alīngār", "35", 34.83529, 70.3593);
case 265: return new CityInfo("‘Alī Khēl", "36", 33.94253, 69.71908);
case 266: return new CityInfo("‘Alāqahdārī Yōsuf Khēl", "29", 33.05195, 68.65);
case 267: return new CityInfo("‘Alāqahdārī Dīshū", "10", 30.43206, 63.29802);
case 268: return new CityInfo("Alah Sāy", "14", 34.8965, 69.72049);
case 269: return new CityInfo("Pachīr wa Āgām", "18", 34.20011, 70.27806);
case 270: return new CityInfo("Afaki", "26", 36.66172, 69.35095);
case 271: return new CityInfo("Adraskan", "11", 33.64573, 62.26959);
case 272: return new CityInfo("Āb-e Kamarī", "02", 35.08796, 63.0678);
case 273: return new CityInfo("Khadīr", "41", 33.92232, 65.93398);
case 274: return new CityInfo("Ghulām ‘Alī", "40", 34.95076, 69.2287);
case 275: return new CityInfo("Qarah Bāgh Bāzār", "13", 34.8529, 69.17062);
case 276: return new CityInfo("Zargarān", "13", 34.78764, 69.05878);
case 277: return new CityInfo("Surkh Bilandī", "13", 34.68474, 69.02863);
case 278: return new CityInfo("Pul-e Sangī", "13", 34.59972, 69.25993);
case 279: return new CityInfo("Langar", "32", 35.99474, 68.05081);
case 280: return new CityInfo("Bāgh-e Maīdān", "40", 35.22156, 69.21397);
case 281: return new CityInfo("Ibrāhīm Khān", "40", 35.05352, 69.25654);
case 282: return new CityInfo("Qaranghū Tōghaī", "30", 37.21528, 67.63972);
case 283: return new CityInfo("Bāzārak", "42", 35.31292, 69.51519);
case 284: return new CityInfo("Shērwānī-ye Bālā", "14", 35.01468, 69.59934);
case 285: return new CityInfo("Kirāmān", "42", 35.2973, 69.68125);
case 286: return new CityInfo("‘Alāqahdārī Saṟōbī", "29", 32.79331, 69.0866);
case 287: return new CityInfo("Zerok-Alakadari", "29", 33.15806, 69.31278);
case 288: return new CityInfo("Kushkak", "06", 32.28991, 61.52194);
case 289: return new CityInfo("Khayr Kōṯ", "29", 32.85355, 68.44971);
case 290: return new CityInfo("Chowṉêy", "41", 33.38278, 66.27233);
case 291: return new CityInfo("Wuṯahpūr", "34", 34.91914, 71.09863);
case 292: return new CityInfo("Karbori", "34", 34.96597, 71.2746);
case 293: return new CityInfo("Sulţānpūr-e ‘Ulyā", "18", 34.41204, 70.29634);
case 294: return new CityInfo("Babasakhib", "23", 31.66144, 65.66098);
case 295: return new CityInfo("Chandal Bā’ī", "13", 34.58469, 68.95524);
case 296: return new CityInfo("Dahan-e Jarf", "40", 34.92891, 68.46273);
case 297: return new CityInfo("Maydanshakhr", "27", 34.39561, 68.86618);
case 298: return new CityInfo("Dū Laīnah", "09", 34.15599, 64.78566);
case 299: return new CityInfo("Qaram Qōl", "07", 36.83006, 65.04299);
case 300: return new CityInfo("Pul-e Ḩişār", "03", 35.61794, 69.47134);
case 301: return new CityInfo("Lab-Sar", "30", 36.02634, 66.83799);
case 302: return new CityInfo("Ţāqchah Khānah", "26", 36.61922, 69.62805);
case 303: return new CityInfo("March", "01", 37.52845, 70.4482);
case 304: return new CityInfo("Zīrakī", "01", 37.59233, 70.55814);
case 305: return new CityInfo("Aliabad", "24", 36.52115, 68.89985);
case 306: return new CityInfo("Pas Pul", "01", 37.47355, 70.61617);
case 307: return new CityInfo("Qal‘ah-ye Na‘īm", "13", 34.39951, 69.16705);
case 308: return new CityInfo("Markaz-e Woluswalī-ye Āchīn", "18", 34.12583, 70.70778);
case 309: return new CityInfo("Manogay", "34", 34.99015, 70.91302);
case 310: return new CityInfo("Stêr Giyān", "29", 32.97704, 69.37308);
case 311: return new CityInfo("Sharan", "29", 33.17568, 68.73045);
default: return new CityInfo("Salām Khēl", "36", 33.67067, 69.32983);

                                    }                                        
                                }
                            
                        }
                    }
                