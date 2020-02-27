
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
                                    public const string Country = "TN";
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
                            
                                        var cur = (Math.Abs(33.54445 - lat) + Math.Abs(9.97157 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(36.64375 - lat) + Math.Abs(10.57428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03959 - lat) + Math.Abs(10.03876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.40291 - lat) + Math.Abs(10.14292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.46813 - lat) + Math.Abs(8.54951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83408 - lat) + Math.Abs(10.04057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.63544 - lat) + Math.Abs(10.82732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81897 - lat) + Math.Abs(10.16579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.91968 - lat) + Math.Abs(8.13352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.92967 - lat) + Math.Abs(10.45177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.5513 - lat) + Math.Abs(9.44307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.38849 - lat) + Math.Abs(7.94313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.57244 - lat) + Math.Abs(8.67031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78333 - lat) + Math.Abs(10.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89174 - lat) + Math.Abs(8.55276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.45692 - lat) + Math.Abs(9.24751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95442 - lat) + Math.Abs(8.75801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82539 - lat) + Math.Abs(10.63699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.08497 - lat) + Math.Abs(9.37082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.37505 - lat) + Math.Abs(10.93899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03823 - lat) + Math.Abs(9.48494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95667 - lat) + Math.Abs(10.47306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53333 - lat) + Math.Abs(10.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67139 - lat) + Math.Abs(10.31583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8687 - lat) + Math.Abs(10.34174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28581 - lat) + Math.Abs(10.3858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.31909 - lat) + Math.Abs(7.93519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.22292 - lat) + Math.Abs(8.35547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.78333 - lat) + Math.Abs(10.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.39444 - lat) + Math.Abs(11.04361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05722 - lat) + Math.Abs(9.23806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74056 - lat) + Math.Abs(10.76028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54332 - lat) + Math.Abs(9.0737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67931 - lat) + Math.Abs(10.29195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31662 - lat) + Math.Abs(10.39551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19043 - lat) + Math.Abs(10.18365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76946 - lat) + Math.Abs(10.27468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41808 - lat) + Math.Abs(10.99475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68561 - lat) + Math.Abs(10.84256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81668 - lat) + Math.Abs(10.56865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.57861 - lat) + Math.Abs(10.85861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84757 - lat) + Math.Abs(11.09386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.54178 - lat) + Math.Abs(9.66334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.70439 - lat) + Math.Abs(8.96903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.64773 - lat) + Math.Abs(10.89046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86108 - lat) + Math.Abs(10.33161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.37419 - lat) + Math.Abs(9.90651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.0629 - lat) + Math.Abs(10.11829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.32045 - lat) + Math.Abs(9.32424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.425 - lat) + Math.Abs(8.78417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.88146 - lat) + Math.Abs(10.0982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.29411 - lat) + Math.Abs(8.76657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.87309 - lat) + Math.Abs(7.87765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.45606 - lat) + Math.Abs(10.73763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.80813 - lat) + Math.Abs(10.99228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.04045 - lat) + Math.Abs(9.66557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72917 - lat) + Math.Abs(10.58082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85673 - lat) + Math.Abs(8.47654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.62477 - lat) + Math.Abs(10.66727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23618 - lat) + Math.Abs(9.91448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72818 - lat) + Math.Abs(10.95757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.68312 - lat) + Math.Abs(10.58431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15368 - lat) + Math.Abs(9.78594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23737 - lat) + Math.Abs(9.86313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81006 - lat) + Math.Abs(10.09557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16617 - lat) + Math.Abs(11.03504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85798 - lat) + Math.Abs(9.20072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.64964 - lat) + Math.Abs(9.61231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.35495 - lat) + Math.Abs(10.50548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.66667 - lat) + Math.Abs(10.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.81363 - lat) + Math.Abs(9.36434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.50114 - lat) + Math.Abs(8.78024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.27311 - lat) + Math.Abs(9.42385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.50398 - lat) + Math.Abs(11.11215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.57778 - lat) + Math.Abs(9.01472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.62231 - lat) + Math.Abs(10.75696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.035 - lat) + Math.Abs(10.90809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.87576 - lat) + Math.Abs(10.85745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03027 - lat) + Math.Abs(10.50904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8609 - lat) + Math.Abs(10.60313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72866 - lat) + Math.Abs(10.34163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81825 - lat) + Math.Abs(10.3052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.63235 - lat) + Math.Abs(9.67624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16939 - lat) + Math.Abs(10.19064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.46632 - lat) + Math.Abs(9.0203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.97606 - lat) + Math.Abs(8.2081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16667 - lat) + Math.Abs(9.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.46798 - lat) + Math.Abs(10.75167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.53853 - lat) + Math.Abs(10.55093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.89927 - lat) + Math.Abs(9.78496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35251 - lat) + Math.Abs(9.62175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73592 - lat) + Math.Abs(10.0924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.93212 - lat) + Math.Abs(9.19321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.13783 - lat) + Math.Abs(11.21965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75452 - lat) + Math.Abs(10.22167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27442 - lat) + Math.Abs(9.87391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.46917 - lat) + Math.Abs(10.78222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.65038 - lat) + Math.Abs(10.59004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.25279 - lat) + Math.Abs(10.19883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.5672 - lat) + Math.Abs(10.80869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7 - lat) + Math.Abs(10.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72564 - lat) + Math.Abs(9.18169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.50056 - lat) + Math.Abs(11.06056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.2992 - lat) + Math.Abs(10.06999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.93325 - lat) + Math.Abs(10.02081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.66887 - lat) + Math.Abs(10.89246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.0764 - lat) + Math.Abs(9.02117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.4628 - lat) + Math.Abs(9.26404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.75166 - lat) + Math.Abs(10.71109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23722 - lat) + Math.Abs(11.115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86012 - lat) + Math.Abs(10.19337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.3827 - lat) + Math.Abs(8.15549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85932 - lat) + Math.Abs(9.78654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65129 - lat) + Math.Abs(9.05306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.70915 - lat) + Math.Abs(10.67397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89607 - lat) + Math.Abs(8.88493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6781 - lat) + Math.Abs(10.09633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16758 - lat) + Math.Abs(8.83651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75 - lat) + Math.Abs(10.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.48485 - lat) + Math.Abs(9.00678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.77799 - lat) + Math.Abs(10.82617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67446 - lat) + Math.Abs(10.15633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72556 - lat) + Math.Abs(10.85528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.32081 - lat) + Math.Abs(8.40157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.57758 - lat) + Math.Abs(9.84193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24516 - lat) + Math.Abs(10.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68206 - lat) + Math.Abs(10.72746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.87818 - lat) + Math.Abs(10.32466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.46499 - lat) + Math.Abs(10.80612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.50472 - lat) + Math.Abs(11.06222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.32802 - lat) + Math.Abs(9.13613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.17424 - lat) + Math.Abs(8.70486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3 - lat) + Math.Abs(10.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05002 - lat) + Math.Abs(11.01442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.82063 - lat) + Math.Abs(10.85394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.4 - lat) + Math.Abs(10.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.89152 - lat) + Math.Abs(9.79629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.65547 - lat) + Math.Abs(8.69602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.80368 - lat) + Math.Abs(9.84424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61739 - lat) + Math.Abs(10.99466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16911 - lat) + Math.Abs(10.03478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8691 - lat) + Math.Abs(10.5653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.44766 - lat) + Math.Abs(10.7557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89239 - lat) + Math.Abs(10.59434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Matmata", "29", 33.54445, 9.97157);
case 1: return new CityInfo("Zaouiat Djedidi", "19", 36.64375, 10.57428);
case 2: return new CityInfo("Zahānah", "18", 37.03959, 10.03876);
case 3: return new CityInfo("Zaghouan", "37", 36.40291, 10.14292);
case 4: return new CityInfo("Wadi Maliz", "06", 36.46813, 8.54951);
case 5: return new CityInfo("Oued Lill", "39", 36.83408, 10.04057);
case 6: return new CityInfo("Touza", "16", 35.63544, 10.82732);
case 7: return new CityInfo("Tunis", "36", 36.81897, 10.16579);
case 8: return new CityInfo("Tozeur", "35", 33.91968, 8.13352);
case 9: return new CityInfo("Tataouine", "34", 32.92967, 10.45177);
case 10: return new CityInfo("Testour", "17", 36.5513, 9.44307);
case 11: return new CityInfo("Tamaghzah", "35", 34.38849, 7.94313);
case 12: return new CityInfo("Thala", "02", 35.57244, 8.67031);
case 13: return new CityInfo("Takelsa", "19", 36.78333, 10.63333);
case 14: return new CityInfo("Tajerouine", "14", 35.89174, 8.55276);
case 15: return new CityInfo("Tabursuq", "17", 36.45692, 9.24751);
case 16: return new CityInfo("Tabarka", "06", 36.95442, 8.75801);
case 17: return new CityInfo("Sousse", "23", 35.82539, 10.63699);
case 18: return new CityInfo("Siliana", "22", 36.08497, 9.37082);
case 19: return new CityInfo("Sidi Alouane", "15", 35.37505, 10.93899);
case 20: return new CityInfo("Sidi Bouzid", "33", 35.03823, 9.48494);
case 21: return new CityInfo("Sidi Bou Ali", "23", 35.95667, 10.47306);
case 22: return new CityInfo("Sidi Ben Nour", "16", 35.53333, 10.91667);
case 23: return new CityInfo("Sidi el Hani", "23", 35.67139, 10.31583);
case 24: return new CityInfo("Sidi Bou Saïd", "36", 36.8687, 10.34174);
case 25: return new CityInfo("Chorbane", "15", 35.28581, 10.3858);
case 26: return new CityInfo("Chebika", "35", 34.31909, 7.93519);
case 27: return new CityInfo("Sakiet Sidi Youssef", "14", 36.22292, 8.35547);
case 28: return new CityInfo("Skanes", "16", 35.78333, 10.8);
case 29: return new CityInfo("Salakta", "15", 35.39444, 11.04361);
case 30: return new CityInfo("Sejenane", "18", 37.05722, 9.23806);
case 31: return new CityInfo("Sfax", "32", 34.74056, 10.76028);
case 32: return new CityInfo("Sbiba", "02", 35.54332, 9.0737);
case 33: return new CityInfo("La Sebala du Mornag", "27", 36.67931, 10.29195);
case 34: return new CityInfo("Remada", "34", 32.31662, 10.39551);
case 35: return new CityInfo("Rafrāf", "18", 37.19043, 10.18365);
case 36: return new CityInfo("Radès", "27", 36.76946, 10.27468);
case 37: return new CityInfo("Ksour Essaf", "15", 35.41808, 10.99475);
case 38: return new CityInfo("Ksibet el Mediouni", "16", 35.68561, 10.84256);
case 39: return new CityInfo("Korbous", "19", 36.81668, 10.56865);
case 40: return new CityInfo("Korba", "19", 36.57861, 10.85861);
case 41: return new CityInfo("Kélibia", "19", 36.84757, 11.09386);
case 42: return new CityInfo("Goubellat", "17", 36.54178, 9.66334);
case 43: return new CityInfo("Kebili", "31", 33.70439, 8.96903);
case 44: return new CityInfo("Ksar Hellal", "16", 35.64773, 10.89046);
case 45: return new CityInfo("Carthage", "36", 36.86108, 10.33161);
case 46: return new CityInfo("El Fahs", "37", 36.37419, 9.90651);
case 47: return new CityInfo("Galaat el Andeless", "38", 37.0629, 10.11829);
case 48: return new CityInfo("Gafour", "22", 36.32045, 9.32424);
case 49: return new CityInfo("Gafsa", "30", 34.425, 8.78417);
case 50: return new CityInfo("Gabès", "29", 33.88146, 10.0982);
case 51: return new CityInfo("Nibbar", "14", 36.29411, 8.76657);
case 52: return new CityInfo("Nefta", "35", 33.87309, 7.87765);
case 53: return new CityInfo("Nabeul", "19", 36.45606, 10.73763);
case 54: return new CityInfo("Midoun", "28", 33.80813, 10.99228);
case 55: return new CityInfo("Mateur", "18", 37.04045, 9.66557);
case 56: return new CityInfo("Msaken", "23", 35.72917, 10.58082);
case 57: return new CityInfo("Menzel Salem", "14", 35.85673, 8.47654);
case 58: return new CityInfo("Menzel Kamel", "16", 35.62477, 10.66727);
case 59: return new CityInfo("Menzel Jemil", "18", 37.23618, 9.91448);
case 60: return new CityInfo("Menzel Heurr", "19", 36.72818, 10.95757);
case 61: return new CityInfo("Mennzel Bou Zelfa", "19", 36.68312, 10.58431);
case 62: return new CityInfo("Menzel Bourguiba", "18", 37.15368, 9.78594);
case 63: return new CityInfo("Menzel Abderhaman", "18", 37.23737, 9.86313);
case 64: return new CityInfo("Manouba", "39", 36.81006, 10.09557);
case 65: return new CityInfo("Melloulèche", "15", 35.16617, 11.03504);
case 66: return new CityInfo("Maktar", "22", 35.85798, 9.20072);
case 67: return new CityInfo("Medjez el Bab", "17", 36.64964, 9.61231);
case 68: return new CityInfo("Medenine", "28", 33.35495, 10.50548);
case 69: return new CityInfo("Lemta", "16", 35.66667, 10.88333);
case 70: return new CityInfo("Kesra", "22", 35.81363, 9.36434);
case 71: return new CityInfo("Jendouba", "06", 36.50114, 8.78024);
case 72: return new CityInfo("Jilma", "33", 35.27311, 9.42385);
case 73: return new CityInfo("Zarzis", "28", 33.50398, 11.11215);
case 74: return new CityInfo("Jemna", "31", 33.57778, 9.01472);
case 75: return new CityInfo("Djemmal", "16", 35.62231, 10.75696);
case 76: return new CityInfo("Djebeniana", "32", 35.035, 10.90809);
case 77: return new CityInfo("Houmt El Souk", "28", 33.87576, 10.85745);
case 78: return new CityInfo("Harqalah", "23", 36.03027, 10.50904);
case 79: return new CityInfo("Hammam Sousse", "23", 35.8609, 10.60313);
case 80: return new CityInfo("Hammam-Lif", "27", 36.72866, 10.34163);
case 81: return new CityInfo("La Goulette", "36", 36.81825, 10.3052);
case 82: return new CityInfo("Haffouz", "03", 35.63235, 9.67624);
case 83: return new CityInfo("Rhar el Melah", "18", 37.16939, 10.19064);
case 84: return new CityInfo("Douz", "31", 33.46632, 9.0203);
case 85: return new CityInfo("Degache", "35", 33.97606, 8.2081);
case 86: return new CityInfo("Douar Tindja", "18", 37.16667, 9.75);
case 87: return new CityInfo("Dar Chabanne", "19", 36.46798, 10.75167);
case 88: return new CityInfo("Bou Arkoub", "19", 36.53853, 10.55093);
case 89: return new CityInfo("Bou Attouche", "29", 33.89927, 9.78496);
case 90: return new CityInfo("Bou Arada", "22", 36.35251, 9.62175);
case 91: return new CityInfo("Bir Ali Ben Khalifa", "32", 34.73592, 10.0924);
case 92: return new CityInfo("Bir el Hafey", "33", 34.93212, 9.19321);
case 93: return new CityInfo("Ben Gardane", "28", 33.13783, 11.21965);
case 94: return new CityInfo("Ben Arous", "27", 36.75452, 10.22167);
case 95: return new CityInfo("Bizerte", "18", 37.27442, 9.87391);
case 96: return new CityInfo("Beni Khiar", "19", 36.46917, 10.78222);
case 97: return new CityInfo("Beni Khalled", "19", 36.65038, 10.59004);
case 98: return new CityInfo("Beni Kheddache", "28", 33.25279, 10.19883);
case 99: return new CityInfo("Beni Hassane", "16", 35.5672, 10.80869);
case 100: return new CityInfo("Banbalah", "16", 35.7, 10.8);
case 101: return new CityInfo("Béja", "17", 36.72564, 9.18169);
case 102: return new CityInfo("Zouila", "15", 35.50056, 11.06056);
case 103: return new CityInfo("Skhira", "32", 34.2992, 10.06999);
case 104: return new CityInfo("Sbikha", "03", 35.93325, 10.02081);
case 105: return new CityInfo("Seïada", "16", 35.66887, 10.89246);
case 106: return new CityInfo("As Sars", "14", 36.0764, 9.02117);
case 107: return new CityInfo("As Sanad", "30", 34.4628, 9.26404);
case 108: return new CityInfo("Sahline", "16", 35.75166, 10.71109);
case 109: return new CityInfo("Chebba", "15", 35.23722, 11.115);
case 110: return new CityInfo("Ariana", "38", 36.86012, 10.19337);
case 111: return new CityInfo("Ar Rudayyif", "30", 34.3827, 8.15549);
case 112: return new CityInfo("Er Regueb", "33", 34.85932, 9.78654);
case 113: return new CityInfo("Rohia", "02", 35.65129, 9.05306);
case 114: return new CityInfo("Ouardenine", "16", 35.70915, 10.67397);
case 115: return new CityInfo("El Ksour", "14", 35.89607, 8.88493);
case 116: return new CityInfo("Kairouan", "03", 35.6781, 10.09633);
case 117: return new CityInfo("Kasserine", "02", 35.16758, 8.83651);
case 118: return new CityInfo("Gremda", "32", 34.75, 10.78333);
case 119: return new CityInfo("El Golaa", "31", 33.48485, 9.00678);
case 120: return new CityInfo("Monastir", "16", 35.77799, 10.82617);
case 121: return new CityInfo("La Mohammedia", "36", 36.67446, 10.15633);
case 122: return new CityInfo("El Mida", "19", 36.72556, 10.85528);
case 123: return new CityInfo("Metlaoui", "30", 34.32081, 8.40157);
case 124: return new CityInfo("Mezzouna", "33", 34.57758, 9.84193);
case 125: return new CityInfo("Al Matlīn", "18", 37.24516, 10.05);
case 126: return new CityInfo("Mesdour", "16", 35.68206, 10.72746);
case 127: return new CityInfo("Al Marsá", "36", 36.87818, 10.32466);
case 128: return new CityInfo("El Maamoura", "19", 36.46499, 10.80612);
case 129: return new CityInfo("Mahdia", "15", 35.50472, 11.06222);
case 130: return new CityInfo("Le Krib", "22", 36.32802, 9.13613);
case 131: return new CityInfo("El Kef", "14", 36.17424, 8.70486);
case 132: return new CityInfo("El Jem", "15", 35.3, 10.71667);
case 133: return new CityInfo("El Haouaria", "19", 37.05002, 11.01442);
case 134: return new CityInfo("Erriadh", "28", 33.82063, 10.85394);
case 135: return new CityInfo("Hammamet", "19", 36.4, 10.61667);
case 136: return new CityInfo("El Hamma", "29", 33.89152, 9.79629);
case 137: return new CityInfo("Fernana", "06", 36.65547, 8.69602);
case 138: return new CityInfo("El Battan", "39", 36.80368, 9.84424);
case 139: return new CityInfo("Bekalta", "16", 35.61739, 10.99466);
case 140: return new CityInfo("El Alia", "18", 37.16911, 10.03478);
case 141: return new CityInfo("Akouda", "23", 35.8691, 10.5653);
case 142: return new CityInfo("Douane", "19", 36.44766, 10.7557);
default: return new CityInfo("Port el Kantaoui", "23", 35.89239, 10.59434);

                                    }                                        
                                }
                            
                        }
                    }
                