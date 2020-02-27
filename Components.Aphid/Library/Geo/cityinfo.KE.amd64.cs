
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
                                    public const string Country = "KE";
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
                            
                                        var cur = (Math.Abs(0.09438 - lat) + Math.Abs(34.53602 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-3.39642 - lat) + Math.Abs(38.35729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.78079 - lat) + Math.Abs(37.62882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.38892 - lat) + Math.Abs(40.43827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.6004 - lat) + Math.Abs(34.77119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.7471 - lat) + Math.Abs(40.05732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.39605 - lat) + Math.Abs(38.55609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.03326 - lat) + Math.Abs(37.06933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.39879 - lat) + Math.Abs(37.68336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.6835 - lat) + Math.Abs(39.85687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.69069 - lat) + Math.Abs(35.11102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.11667 - lat) + Math.Abs(34 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.64756 - lat) + Math.Abs(39.38175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.47166 - lat) + Math.Abs(39.48463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.66806 - lat) + Math.Abs(37.20875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.2725 - lat) + Math.Abs(36.53806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.17344 - lat) + Math.Abs(35.86313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.28333 - lat) + Math.Abs(36.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.50974 - lat) + Math.Abs(34.73067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.54655 - lat) + Math.Abs(36.93178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.80116 - lat) + Math.Abs(34.72579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.42013 - lat) + Math.Abs(36.94759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.56333 - lat) + Math.Abs(34.93583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.03813 - lat) + Math.Abs(36.36339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.3527 - lat) + Math.Abs(36.6699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.16357 - lat) + Math.Abs(37.01773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.08083 - lat) + Math.Abs(35.87111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.00624 - lat) + Math.Abs(37.07398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.10366 - lat) + Math.Abs(35.18426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.45813 - lat) + Math.Abs(34.25353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.30719 - lat) + Math.Abs(36.07225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.71383 - lat) + Math.Abs(36.43261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.28333 - lat) + Math.Abs(36.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.93605 - lat) + Math.Abs(38.05955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.505 - lat) + Math.Abs(38.37722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.72104 - lat) + Math.Abs(37.15259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.33474 - lat) + Math.Abs(34.48796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.15816 - lat) + Math.Abs(35.19645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.68987 - lat) + Math.Abs(38.16687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.52661 - lat) + Math.Abs(39.0561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.05466 - lat) + Math.Abs(39.66359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.24849 - lat) + Math.Abs(35.73194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.06343 - lat) + Math.Abs(34.47313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.04626 - lat) + Math.Abs(37.65587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.08213 - lat) + Math.Abs(34.72139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.2332 - lat) + Math.Abs(37.94086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.33468 - lat) + Math.Abs(37.99086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.86261 - lat) + Math.Abs(39.47458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.09667 - lat) + Math.Abs(36.69806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.79602 - lat) + Math.Abs(37.13292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.93726 - lat) + Math.Abs(41.85688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.21799 - lat) + Math.Abs(40.11692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.67694 - lat) + Math.Abs(34.42167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.63513 - lat) + Math.Abs(34.28165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.80388 - lat) + Math.Abs(37.62405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.90122 - lat) + Math.Abs(36.287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.52233 - lat) + Math.Abs(37.26521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.19982 - lat) + Math.Abs(35.46735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.39337 - lat) + Math.Abs(34.30399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.31354 - lat) + Math.Abs(34.07146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.16552 - lat) + Math.Abs(35.59359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.11988 - lat) + Math.Abs(35.59642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.58249 - lat) + Math.Abs(35.18969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.1136 - lat) + Math.Abs(36.64205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.27169 - lat) + Math.Abs(40.90201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.17375 - lat) + Math.Abs(39.45206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.73947 - lat) + Math.Abs(37.13195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.36696 - lat) + Math.Abs(38.01055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.01572 - lat) + Math.Abs(35.00622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.10221 - lat) + Math.Abs(34.76171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.68174 - lat) + Math.Abs(34.76666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.52565 - lat) + Math.Abs(40.5262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.13723 - lat) + Math.Abs(39.31528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.19347 - lat) + Math.Abs(34.61967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.63045 - lat) + Math.Abs(39.84992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.24627 - lat) + Math.Abs(36.66291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.93334 - lat) + Math.Abs(36.57233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.17139 - lat) + Math.Abs(36.83556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.49887 - lat) + Math.Abs(37.28031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.77612 - lat) + Math.Abs(34.94678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.36774 - lat) + Math.Abs(35.28314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.7 - lat) + Math.Abs(37.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.9789 - lat) + Math.Abs(35.55854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.20387 - lat) + Math.Abs(35.105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.23889 - lat) + Math.Abs(35.11194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.30342 - lat) + Math.Abs(37.34813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.68553 - lat) + Math.Abs(36.96463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.89715 - lat) + Math.Abs(37.00279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.28422 - lat) + Math.Abs(34.75229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.85238 - lat) + Math.Abs(36.77683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.49194 - lat) + Math.Abs(35.74303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.67028 - lat) + Math.Abs(35.50806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.35462 - lat) + Math.Abs(37.58218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.52731 - lat) + Math.Abs(34.45714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.48256 - lat) + Math.Abs(40.03341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.42402 - lat) + Math.Abs(39.50588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.45275 - lat) + Math.Abs(39.64601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.53987 - lat) + Math.Abs(37.45743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.52036 - lat) + Math.Abs(35.26993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.05196 - lat) + Math.Abs(35.72734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.33316 - lat) + Math.Abs(37.64587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.30583 - lat) + Math.Abs(35.20365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.20694 - lat) + Math.Abs(34.49006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.46005 - lat) + Math.Abs(34.11169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.09809 - lat) + Math.Abs(33.97248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.5635 - lat) + Math.Abs(34.56055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.23522 - lat) + Math.Abs(34.28086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.78129 - lat) + Math.Abs(35.34156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.46667 - lat) + Math.Abs(35.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.4563 - lat) + Math.Abs(36.97826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.17359 - lat) + Math.Abs(34.9189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.0607 - lat) + Math.Abs(34.28806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.27088 - lat) + Math.Abs(36.37917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.58333 - lat) + Math.Abs(34.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.33139 - lat) + Math.Abs(37.86861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yala", "46", 0.09438, 34.53602);
case 1: return new CityInfo("Wundanyi", "47", -3.39642, 38.35729);
case 2: return new CityInfo("Wote", "32", -1.78079, 37.62882);
case 3: return new CityInfo("Witu", "30", -2.38892, 40.43827);
case 4: return new CityInfo("Webuye", "12", 0.6004, 34.77119);
case 5: return new CityInfo("Wajir", "54", 1.7471, 40.05732);
case 6: return new CityInfo("Voi", "47", -3.39605, 38.55609);
case 7: return new CityInfo("Thika", "05", -1.03326, 37.06933);
case 8: return new CityInfo("Taveta", "47", -3.39879, 37.68336);
case 9: return new CityInfo("Takaungu", "23", -3.6835, 39.85687);
case 10: return new CityInfo("Sotik", "11", -0.69069, 35.11102);
case 11: return new CityInfo("Sirisia", "13", 0.11667, 34);
case 12: return new CityInfo("Shimoni", "28", -4.64756, 39.38175);
case 13: return new CityInfo("Sawa Sawa", "28", -4.47166, 39.48463);
case 14: return new CityInfo("Sagana", "24", -0.66806, 37.20875);
case 15: return new CityInfo("Rumuruti", "29", 0.2725, 36.53806);
case 16: return new CityInfo("Rongai", "39", -0.17344, 35.86313);
case 17: return new CityInfo("Pumwani", "05", -1.28333, 36.85);
case 18: return new CityInfo("Oyugis", "17", -0.50974, 34.73067);
case 19: return new CityInfo("Othaya", "44", -0.54655, 36.93178);
case 20: return new CityInfo("Ogembo", "25", -0.80116, 34.72579);
case 21: return new CityInfo("Nyeri", "44", -0.42013, 36.94759);
case 22: return new CityInfo("Nyamira", "42", -0.56333, 34.93583);
case 23: return new CityInfo("Nyahururu", "29", 0.03813, 36.36339);
case 24: return new CityInfo("Ngong", "19", -1.3527, 36.6699);
case 25: return new CityInfo("Naro Moru", "44", -0.16357, 37.01773);
case 26: return new CityInfo("Narok", "41", -1.08083, 35.87111);
case 27: return new CityInfo("Nanyuki", "29", 0.00624, 37.07398);
case 28: return new CityInfo("Nandi Hills", "40", 0.10366, 35.18426);
case 29: return new CityInfo("Nambare", "13", 0.45813, 34.25353);
case 30: return new CityInfo("Nakuru", "39", -0.30719, 36.07225);
case 31: return new CityInfo("Naivasha", "39", -0.71383, 36.43261);
case 32: return new CityInfo("Nairobi", "05", -1.28333, 36.81667);
case 33: return new CityInfo("Mwingi", "27", -0.93605, 38.05955);
case 34: return new CityInfo("Mwatate", "47", -3.505, 38.37722);
case 35: return new CityInfo("Murang’a", "38", -0.72104, 37.15259);
case 36: return new CityInfo("Mumias", "20", 0.33474, 34.48796);
case 37: return new CityInfo("Muhoroni", "26", -0.15816, 35.19645);
case 38: return new CityInfo("Mtito Andei", "32", -2.68987, 38.16687);
case 39: return new CityInfo("Moyale", "34", 3.52661, 39.0561);
case 40: return new CityInfo("Mombasa", "37", -4.05466, 39.66359);
case 41: return new CityInfo("Molo", "39", -0.24849, 35.73194);
case 42: return new CityInfo("Migori", "36", -1.06343, 34.47313);
case 43: return new CityInfo("Meru", "35", 0.04626, 37.65587);
case 44: return new CityInfo("Mbale", "53", 0.08213, 34.72139);
case 45: return new CityInfo("Maua", "35", 0.2332, 37.94086);
case 46: return new CityInfo("Marsabit", "34", 2.33468, 37.99086);
case 47: return new CityInfo("Mariakani", "23", -3.86261, 39.47458);
case 48: return new CityInfo("Maralal", "45", 1.09667, 36.69806);
case 49: return new CityInfo("Maragua", "38", -0.79602, 37.13292);
case 50: return new CityInfo("Mandera", "33", 3.93726, 41.85688);
case 51: return new CityInfo("Malindi", "23", -3.21799, 40.11692);
case 52: return new CityInfo("Malikisi", "12", 0.67694, 34.42167);
case 53: return new CityInfo("Malaba", "13", 0.63513, 34.28165);
case 54: return new CityInfo("Makueni Boma", "32", -1.80388, 37.62405);
case 55: return new CityInfo("Magadi", "19", -1.90122, 36.287);
case 56: return new CityInfo("Machakos", "31", -1.52233, 37.26521);
case 57: return new CityInfo("Kipkelion", "21", -0.19982, 35.46735);
case 58: return new CityInfo("Lugulu", "13", 0.39337, 34.30399);
case 59: return new CityInfo("Luanda", "13", 0.31354, 34.07146);
case 60: return new CityInfo("Londiani", "21", -0.16552, 35.59359);
case 61: return new CityInfo("Lodwar", "51", 3.11988, 35.59642);
case 62: return new CityInfo("Litein", "21", -0.58249, 35.18969);
case 63: return new CityInfo("Limuru", "22", -1.1136, 36.64205);
case 64: return new CityInfo("Lamu", "30", -2.27169, 40.90201);
case 65: return new CityInfo("Kwale", "28", -4.17375, 39.45206);
case 66: return new CityInfo("Konza", "31", -1.73947, 37.13195);
case 67: return new CityInfo("Kitui", "27", -1.36696, 38.01055);
case 68: return new CityInfo("Kitale", "50", 1.01572, 35.00622);
case 69: return new CityInfo("Kisumu", "26", -0.10221, 34.76171);
case 70: return new CityInfo("Kisii", "25", -0.68174, 34.76666);
case 71: return new CityInfo("Kipini", "48", -2.52565, 40.5262);
case 72: return new CityInfo("Kinango", "28", -4.13723, 39.31528);
case 73: return new CityInfo("Kihancha", "36", -1.19347, 34.61967);
case 74: return new CityInfo("Kilifi", "23", -3.63045, 39.84992);
case 75: return new CityInfo("Kikuyu", "22", -1.24627, 36.66291);
case 76: return new CityInfo("Kijabe", "39", -0.93334, 36.57233);
case 77: return new CityInfo("Kiambu", "22", -1.17139, 36.83556);
case 78: return new CityInfo("Kerugoya", "24", -0.49887, 37.28031);
case 79: return new CityInfo("Keroka", "42", -0.77612, 34.94678);
case 80: return new CityInfo("Kericho", "21", -0.36774, 35.28314);
case 81: return new CityInfo("Karuri", "38", -0.7, 37.18333);
case 82: return new CityInfo("Kapsowar", "14", 0.9789, 35.55854);
case 83: return new CityInfo("Kapsabet", "40", 0.20387, 35.105);
case 84: return new CityInfo("Kapenguria", "55", 1.23889, 35.11194);
case 85: return new CityInfo("Kangundo", "31", -1.30342, 37.34813);
case 86: return new CityInfo("Kangema", "38", -0.68553, 36.96463);
case 87: return new CityInfo("Kandara", "38", -0.89715, 37.00279);
case 88: return new CityInfo("Kakamega", "20", 0.28422, 34.75229);
case 89: return new CityInfo("Kajiado", "19", -1.85238, 36.77683);
case 90: return new CityInfo("Kabarnet", "10", 0.49194, 35.74303);
case 91: return new CityInfo("Iten", "14", 0.67028, 35.50806);
case 92: return new CityInfo("Isiolo", "18", 0.35462, 37.58218);
case 93: return new CityInfo("Homa Bay", "17", -0.52731, 34.45714);
case 94: return new CityInfo("Hola", "48", -1.48256, 40.03341);
case 95: return new CityInfo("Gazi", "28", -4.42402, 39.50588);
case 96: return new CityInfo("Garissa", "16", -0.45275, 39.64601);
case 97: return new CityInfo("Embu", "15", -0.53987, 37.45743);
case 98: return new CityInfo("Eldoret", "52", 0.52036, 35.26993);
case 99: return new CityInfo("Eldama Ravine", "10", 0.05196, 35.72734);
case 100: return new CityInfo("Chuka", "49", -0.33316, 37.64587);
case 101: return new CityInfo("Chepareria", "55", 1.30583, 35.20365);
case 102: return new CityInfo("Butere", "20", 0.20694, 34.49006);
case 103: return new CityInfo("Busia", "13", 0.46005, 34.11169);
case 104: return new CityInfo("Port Victoria", "13", 0.09809, 33.97248);
case 105: return new CityInfo("Bungoma", "12", 0.5635, 34.56055);
case 106: return new CityInfo("Bondo", "46", 0.23522, 34.28086);
case 107: return new CityInfo("Sotik Post", "11", -0.78129, 35.34156);
case 108: return new CityInfo("Baringo", "10", 0.46667, 35.96667);
case 109: return new CityInfo("Athi River", "31", -1.4563, 36.97826);
case 110: return new CityInfo("Ahero", "26", -0.17359, 34.9189);
case 111: return new CityInfo("Siaya", "46", 0.0607, 34.28806);
case 112: return new CityInfo("Ol Kalou", "43", -0.27088, 36.37917);
case 113: return new CityInfo("Bungoma", "12", 0.58333, 34.58333);
default: return new CityInfo("Kathwana", "49", -0.33139, 37.86861);

                                    }                                        
                                }
                            
                        }
                    }
                