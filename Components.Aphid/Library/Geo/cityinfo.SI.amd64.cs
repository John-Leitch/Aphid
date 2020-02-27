
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
                                    public const string Country = "SI";
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
                            
                                        var cur = (Math.Abs(45.83389 - lat) + Math.Abs(14.92917 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(46.54778 - lat) + Math.Abs(15.7075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45556 - lat) + Math.Abs(15.79111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40472 - lat) + Math.Abs(14.14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04222 - lat) + Math.Abs(14.10722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(15.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.315 - lat) + Math.Abs(15.47972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51361 - lat) + Math.Abs(15.72083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23896 - lat) + Math.Abs(14.48436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14251 - lat) + Math.Abs(14.43158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3941 - lat) + Math.Abs(14.50659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49183 - lat) + Math.Abs(15.62315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37962 - lat) + Math.Abs(14.06937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30725 - lat) + Math.Abs(14.29119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22 - lat) + Math.Abs(14.33667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(15.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67528 - lat) + Math.Abs(15.76917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42556 - lat) + Math.Abs(15.61222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63917 - lat) + Math.Abs(15.61556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40611 - lat) + Math.Abs(15.83861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39918 - lat) + Math.Abs(15.5424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26667 - lat) + Math.Abs(14.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27356 - lat) + Math.Abs(15.82658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65861 - lat) + Math.Abs(14.88639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22482 - lat) + Math.Abs(14.17205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16667 - lat) + Math.Abs(14.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39167 - lat) + Math.Abs(16.04972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25151 - lat) + Math.Abs(15.16482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13179 - lat) + Math.Abs(14.99694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21408 - lat) + Math.Abs(15.15954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4 - lat) + Math.Abs(14.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59639 - lat) + Math.Abs(15.16722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59472 - lat) + Math.Abs(15.2375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02028 - lat) + Math.Abs(14.27083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9125 - lat) + Math.Abs(13.63417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23333 - lat) + Math.Abs(14.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86444 - lat) + Math.Abs(13.96139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9635 - lat) + Math.Abs(14.29484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25 - lat) + Math.Abs(15.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24389 - lat) + Math.Abs(14.95139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90694 - lat) + Math.Abs(13.6775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1754 - lat) + Math.Abs(13.70785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21611 - lat) + Math.Abs(14.42306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29333 - lat) + Math.Abs(15.30333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90611 - lat) + Math.Abs(13.70056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21556 - lat) + Math.Abs(14.43861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18987 - lat) + Math.Abs(14.49492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00722 - lat) + Math.Abs(14.42194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93917 - lat) + Math.Abs(13.76556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5275 - lat) + Math.Abs(15.93944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38167 - lat) + Math.Abs(15.29583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27111 - lat) + Math.Abs(14.41806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95389 - lat) + Math.Abs(14.74528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18333 - lat) + Math.Abs(14.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84667 - lat) + Math.Abs(13.96306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85 - lat) + Math.Abs(14.69417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58361 - lat) + Math.Abs(16.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95667 - lat) + Math.Abs(14.30583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93694 - lat) + Math.Abs(14.68167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83222 - lat) + Math.Abs(14.63639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80405 - lat) + Math.Abs(15.25772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57194 - lat) + Math.Abs(16.34694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16667 - lat) + Math.Abs(14.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71888 - lat) + Math.Abs(15.12551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81556 - lat) + Math.Abs(14.29389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62778 - lat) + Math.Abs(16.32028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13333 - lat) + Math.Abs(14.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36357 - lat) + Math.Abs(14.31046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65361 - lat) + Math.Abs(16.10333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52019 - lat) + Math.Abs(15.88657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25667 - lat) + Math.Abs(15.29528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5875 - lat) + Math.Abs(16.30833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90417 - lat) + Math.Abs(15.02167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.155 - lat) + Math.Abs(15.05333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2 - lat) + Math.Abs(14.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40028 - lat) + Math.Abs(15.02157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48417 - lat) + Math.Abs(16.08361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18304 - lat) + Math.Abs(13.73321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35917 - lat) + Math.Abs(15.11028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65806 - lat) + Math.Abs(16.09167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34778 - lat) + Math.Abs(15.47611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23611 - lat) + Math.Abs(15.01833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18333 - lat) + Math.Abs(14.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52583 - lat) + Math.Abs(13.83194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64917 - lat) + Math.Abs(15.84417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18333 - lat) + Math.Abs(14.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.525 - lat) + Math.Abs(13.60556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28333 - lat) + Math.Abs(14.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22083 - lat) + Math.Abs(15.31389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38111 - lat) + Math.Abs(15.98278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96056 - lat) + Math.Abs(14.81028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46583 - lat) + Math.Abs(15.76722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71484 - lat) + Math.Abs(14.47097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5 - lat) + Math.Abs(15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97417 - lat) + Math.Abs(14.28111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17311 - lat) + Math.Abs(14.30041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11667 - lat) + Math.Abs(14.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15659 - lat) + Math.Abs(14.5957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21667 - lat) + Math.Abs(14.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.295 - lat) + Math.Abs(13.92389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39417 - lat) + Math.Abs(16.26806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4125 - lat) + Math.Abs(15.915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56667 - lat) + Math.Abs(15.53306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50306 - lat) + Math.Abs(15.74528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13472 - lat) + Math.Abs(14.43861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15 - lat) + Math.Abs(14.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5 - lat) + Math.Abs(15.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41359 - lat) + Math.Abs(14.03537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11667 - lat) + Math.Abs(14.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3 - lat) + Math.Abs(14.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54444 - lat) + Math.Abs(15.815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92442 - lat) + Math.Abs(14.6575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41056 - lat) + Math.Abs(15.63889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03194 - lat) + Math.Abs(14.02722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40889 - lat) + Math.Abs(15.84694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25749 - lat) + Math.Abs(14.30572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38 - lat) + Math.Abs(15.04861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41944 - lat) + Math.Abs(14.69361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76111 - lat) + Math.Abs(14.63556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9375 - lat) + Math.Abs(14.59194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48944 - lat) + Math.Abs(15.10667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04444 - lat) + Math.Abs(14.84417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33333 - lat) + Math.Abs(15.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88333 - lat) + Math.Abs(15.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22722 - lat) + Math.Abs(15.51917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97618 - lat) + Math.Abs(14.61177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50139 - lat) + Math.Abs(13.71778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19333 - lat) + Math.Abs(14.59667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33667 - lat) + Math.Abs(15.42583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39278 - lat) + Math.Abs(15.57444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51028 - lat) + Math.Abs(15.08056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45 - lat) + Math.Abs(15.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47639 - lat) + Math.Abs(15.65583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68892 - lat) + Math.Abs(15.73719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48578 - lat) + Math.Abs(15.69427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98333 - lat) + Math.Abs(14.57667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16551 - lat) + Math.Abs(14.30626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56639 - lat) + Math.Abs(13.79944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90667 - lat) + Math.Abs(15.29139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53359 - lat) + Math.Abs(13.76363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3756 - lat) + Math.Abs(15.10466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97556 - lat) + Math.Abs(14.31833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70924 - lat) + Math.Abs(13.87333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00778 - lat) + Math.Abs(15.31556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81903 - lat) + Math.Abs(16.03034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95004 - lat) + Math.Abs(14.84344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97778 - lat) + Math.Abs(15.09556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21722 - lat) + Math.Abs(15.3975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84 - lat) + Math.Abs(15.33611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56111 - lat) + Math.Abs(15.03889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68167 - lat) + Math.Abs(15.64806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09139 - lat) + Math.Abs(14.73306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72111 - lat) + Math.Abs(14.04111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02361 - lat) + Math.Abs(15.47694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24556 - lat) + Math.Abs(14.41972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25639 - lat) + Math.Abs(15.12194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9275 - lat) + Math.Abs(13.64111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93028 - lat) + Math.Abs(13.74361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64611 - lat) + Math.Abs(15.18222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68333 - lat) + Math.Abs(15.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22444 - lat) + Math.Abs(14.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91667 - lat) + Math.Abs(15.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47667 - lat) + Math.Abs(13.62333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.825 - lat) + Math.Abs(16.29806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65333 - lat) + Math.Abs(14.8825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53944 - lat) + Math.Abs(15.51583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98528 - lat) + Math.Abs(14.1775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5 - lat) + Math.Abs(15.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22944 - lat) + Math.Abs(15.70028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8 - lat) + Math.Abs(16.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2375 - lat) + Math.Abs(15.63972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1226 - lat) + Math.Abs(15.1919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32742 - lat) + Math.Abs(14.11004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.535 - lat) + Math.Abs(15.27278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73861 - lat) + Math.Abs(14.7275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63667 - lat) + Math.Abs(16.30278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89 - lat) + Math.Abs(13.66861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31667 - lat) + Math.Abs(14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16417 - lat) + Math.Abs(15.21528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51444 - lat) + Math.Abs(15.63611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54306 - lat) + Math.Abs(14.96917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41413 - lat) + Math.Abs(15.06087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46815 - lat) + Math.Abs(13.71439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88833 - lat) + Math.Abs(14.44417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65167 - lat) + Math.Abs(16.20417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81333 - lat) + Math.Abs(14.31111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34444 - lat) + Math.Abs(14.17444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17361 - lat) + Math.Abs(14.61222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61417 - lat) + Math.Abs(15.22639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64201 - lat) + Math.Abs(16.03781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06806 - lat) + Math.Abs(15.18389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45194 - lat) + Math.Abs(15.68139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70667 - lat) + Math.Abs(16.15639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42005 - lat) + Math.Abs(15.87018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89 - lat) + Math.Abs(13.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16667 - lat) + Math.Abs(14.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54694 - lat) + Math.Abs(14.92083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73033 - lat) + Math.Abs(14.18622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16911 - lat) + Math.Abs(14.59698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44417 - lat) + Math.Abs(15.76389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26582 - lat) + Math.Abs(14.38608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3025 - lat) + Math.Abs(14.42306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23694 - lat) + Math.Abs(15.0925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39667 - lat) + Math.Abs(15.66 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52861 - lat) + Math.Abs(13.78194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77435 - lat) + Math.Abs(14.21528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51429 - lat) + Math.Abs(13.59206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21667 - lat) + Math.Abs(15.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28333 - lat) + Math.Abs(15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31194 - lat) + Math.Abs(15.57917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98197 - lat) + Math.Abs(14.70498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06694 - lat) + Math.Abs(14.31611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4325 - lat) + Math.Abs(15.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58694 - lat) + Math.Abs(15.33056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17278 - lat) + Math.Abs(14.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96972 - lat) + Math.Abs(14.4175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.412 - lat) + Math.Abs(14.275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33528 - lat) + Math.Abs(15.88 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3525 - lat) + Math.Abs(15.08917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52167 - lat) + Math.Abs(14.14611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47194 - lat) + Math.Abs(15.08361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21667 - lat) + Math.Abs(14.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42917 - lat) + Math.Abs(16.06361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15694 - lat) + Math.Abs(15.59861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3 - lat) + Math.Abs(14.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21 - lat) + Math.Abs(13.96444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38472 - lat) + Math.Abs(15.87861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.82903 - lat) + Math.Abs(14.24969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68292 - lat) + Math.Abs(14.19588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52778 - lat) + Math.Abs(13.57056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95111 - lat) + Math.Abs(14.57194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24167 - lat) + Math.Abs(15.19 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52722 - lat) + Math.Abs(16.46139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65333 - lat) + Math.Abs(16.06611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60694 - lat) + Math.Abs(15.67667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54722 - lat) + Math.Abs(15.59556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59556 - lat) + Math.Abs(15.75861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53417 - lat) + Math.Abs(15.07917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94361 - lat) + Math.Abs(13.73028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83967 - lat) + Math.Abs(15.22528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57389 - lat) + Math.Abs(15.03278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52914 - lat) + Math.Abs(14.69838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41139 - lat) + Math.Abs(16.15444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38778 - lat) + Math.Abs(15.44667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58667 - lat) + Math.Abs(16.28028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39972 - lat) + Math.Abs(16.23194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80397 - lat) + Math.Abs(15.16886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77167 - lat) + Math.Abs(14.50583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95604 - lat) + Math.Abs(13.64837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9875 - lat) + Math.Abs(14.39889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40367 - lat) + Math.Abs(15.80675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61667 - lat) + Math.Abs(16.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27278 - lat) + Math.Abs(14.31722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61139 - lat) + Math.Abs(15.16611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6625 - lat) + Math.Abs(16.16639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33944 - lat) + Math.Abs(14.96333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41667 - lat) + Math.Abs(14.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.195 - lat) + Math.Abs(14.55139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42028 - lat) + Math.Abs(15.99333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44444 - lat) + Math.Abs(15.62139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68313 - lat) + Math.Abs(16.2208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13694 - lat) + Math.Abs(14.745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93417 - lat) + Math.Abs(15.14083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42383 - lat) + Math.Abs(13.8752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28333 - lat) + Math.Abs(14.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46528 - lat) + Math.Abs(15.12389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44141 - lat) + Math.Abs(15.20027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86028 - lat) + Math.Abs(15.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95528 - lat) + Math.Abs(15.06194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89556 - lat) + Math.Abs(13.6075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50583 - lat) + Math.Abs(15.69722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23333 - lat) + Math.Abs(15.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52139 - lat) + Math.Abs(14.85444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64722 - lat) + Math.Abs(15.31417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16694 - lat) + Math.Abs(14.575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57361 - lat) + Math.Abs(16.23667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23333 - lat) + Math.Abs(14.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1422 - lat) + Math.Abs(14.41114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68639 - lat) + Math.Abs(16.19778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39557 - lat) + Math.Abs(15.92831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55472 - lat) + Math.Abs(15.64667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31722 - lat) + Math.Abs(15.66722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35167 - lat) + Math.Abs(15.73361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16988 - lat) + Math.Abs(14.69179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54333 - lat) + Math.Abs(16.15278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35611 - lat) + Math.Abs(14.74667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72417 - lat) + Math.Abs(14.46889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54056 - lat) + Math.Abs(15.39306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37361 - lat) + Math.Abs(15.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70139 - lat) + Math.Abs(14.58028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60167 - lat) + Math.Abs(15.17389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35944 - lat) + Math.Abs(15.05194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66111 - lat) + Math.Abs(13.92806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90167 - lat) + Math.Abs(13.87972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15 - lat) + Math.Abs(14.56528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01667 - lat) + Math.Abs(14.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29972 - lat) + Math.Abs(15.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52083 - lat) + Math.Abs(16.1975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34358 - lat) + Math.Abs(14.83377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05108 - lat) + Math.Abs(14.50513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25567 - lat) + Math.Abs(15.3243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05861 - lat) + Math.Abs(14.8225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62833 - lat) + Math.Abs(16.22806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60694 - lat) + Math.Abs(16.2875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55361 - lat) + Math.Abs(15.58361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21111 - lat) + Math.Abs(15.195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31583 - lat) + Math.Abs(15.025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93566 - lat) + Math.Abs(15.47184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38333 - lat) + Math.Abs(15.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36111 - lat) + Math.Abs(14.15778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56494 - lat) + Math.Abs(16.45091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57611 - lat) + Math.Abs(15.83139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15463 - lat) + Math.Abs(15.23555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37111 - lat) + Math.Abs(15.85639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83694 - lat) + Math.Abs(16.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14834 - lat) + Math.Abs(14.65228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95915 - lat) + Math.Abs(15.49167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9 - lat) + Math.Abs(15.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3 - lat) + Math.Abs(14.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96083 - lat) + Math.Abs(13.66556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63806 - lat) + Math.Abs(16.14139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98472 - lat) + Math.Abs(15.18944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56833 - lat) + Math.Abs(16.13861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34278 - lat) + Math.Abs(14.30139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74472 - lat) + Math.Abs(13.86583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10204 - lat) + Math.Abs(14.78575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47528 - lat) + Math.Abs(15.81083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45689 - lat) + Math.Abs(13.77824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23887 - lat) + Math.Abs(14.35561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.075 - lat) + Math.Abs(15.56028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61 - lat) + Math.Abs(15.63444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61 - lat) + Math.Abs(13.93556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35 - lat) + Math.Abs(14.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52139 - lat) + Math.Abs(14.98694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84611 - lat) + Math.Abs(15.42222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21667 - lat) + Math.Abs(15.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54694 - lat) + Math.Abs(13.72944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81528 - lat) + Math.Abs(13.74833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27028 - lat) + Math.Abs(14.36111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64333 - lat) + Math.Abs(14.86333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68472 - lat) + Math.Abs(16.39778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24761 - lat) + Math.Abs(13.57907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40361 - lat) + Math.Abs(15.79111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23333 - lat) + Math.Abs(15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55 - lat) + Math.Abs(15.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08861 - lat) + Math.Abs(13.63972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94659 - lat) + Math.Abs(14.40642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22587 - lat) + Math.Abs(14.61207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57444 - lat) + Math.Abs(15.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31667 - lat) + Math.Abs(14.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89556 - lat) + Math.Abs(14.19361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48472 - lat) + Math.Abs(15.97139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60639 - lat) + Math.Abs(15.78472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5695 - lat) + Math.Abs(16.02347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97 - lat) + Math.Abs(14.43306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43056 - lat) + Math.Abs(14.06694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53694 - lat) + Math.Abs(13.66194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15 - lat) + Math.Abs(14.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58889 - lat) + Math.Abs(16.22111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93833 - lat) + Math.Abs(14.80444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56757 - lat) + Math.Abs(14.24571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12083 - lat) + Math.Abs(14.62 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96028 - lat) + Math.Abs(14.52889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00278 - lat) + Math.Abs(14.03056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58278 - lat) + Math.Abs(13.75667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.445 - lat) + Math.Abs(14.01778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60722 - lat) + Math.Abs(13.94278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70688 - lat) + Math.Abs(14.61674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14611 - lat) + Math.Abs(15.08139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21667 - lat) + Math.Abs(14.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54944 - lat) + Math.Abs(16.36028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46667 - lat) + Math.Abs(15.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28109 - lat) + Math.Abs(14.42091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93028 - lat) + Math.Abs(14.14222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02361 - lat) + Math.Abs(14.29917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18333 - lat) + Math.Abs(14.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82333 - lat) + Math.Abs(16.33417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95556 - lat) + Math.Abs(14.65889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22944 - lat) + Math.Abs(15.15056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99861 - lat) + Math.Abs(13.67389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48333 - lat) + Math.Abs(15.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57667 - lat) + Math.Abs(15.87694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8 - lat) + Math.Abs(16.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47517 - lat) + Math.Abs(13.86368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27418 - lat) + Math.Abs(15.15186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60583 - lat) + Math.Abs(15.12639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80528 - lat) + Math.Abs(16.2225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29528 - lat) + Math.Abs(14.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67333 - lat) + Math.Abs(15.99222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56667 - lat) + Math.Abs(16.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41472 - lat) + Math.Abs(16.01389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27444 - lat) + Math.Abs(15.23083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13936 - lat) + Math.Abs(14.3936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10722 - lat) + Math.Abs(14.14806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78 - lat) + Math.Abs(15.07278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60333 - lat) + Math.Abs(16.31194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33333 - lat) + Math.Abs(14.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95778 - lat) + Math.Abs(14.09361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25684 - lat) + Math.Abs(14.60969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16667 - lat) + Math.Abs(14.35444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43333 - lat) + Math.Abs(15.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51889 - lat) + Math.Abs(13.70139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6325 - lat) + Math.Abs(16.25111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61667 - lat) + Math.Abs(15.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7825 - lat) + Math.Abs(15.27556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39715 - lat) + Math.Abs(15.07903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55472 - lat) + Math.Abs(16.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.456 - lat) + Math.Abs(15.63007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75806 - lat) + Math.Abs(13.83222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99778 - lat) + Math.Abs(14.33278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38333 - lat) + Math.Abs(15.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33333 - lat) + Math.Abs(15.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58806 - lat) + Math.Abs(15.01917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01667 - lat) + Math.Abs(14.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11027 - lat) + Math.Abs(14.58729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46863 - lat) + Math.Abs(13.97202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88972 - lat) + Math.Abs(13.73694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43667 - lat) + Math.Abs(15.95361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13774 - lat) + Math.Abs(14.59371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09194 - lat) + Math.Abs(14.67722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08861 - lat) + Math.Abs(14.60083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14194 - lat) + Math.Abs(15.11278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54806 - lat) + Math.Abs(14.26611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58778 - lat) + Math.Abs(16.44167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61694 - lat) + Math.Abs(14.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75657 - lat) + Math.Abs(15.05917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70611 - lat) + Math.Abs(14.75444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60333 - lat) + Math.Abs(16.17806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52306 - lat) + Math.Abs(15.70667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99639 - lat) + Math.Abs(13.52639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65139 - lat) + Math.Abs(16.3525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48028 - lat) + Math.Abs(15.70278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0458 - lat) + Math.Abs(14.39186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3375 - lat) + Math.Abs(15.22639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89716 - lat) + Math.Abs(15.66371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13747 - lat) + Math.Abs(15.39412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15194 - lat) + Math.Abs(14.62861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68472 - lat) + Math.Abs(13.97028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49254 - lat) + Math.Abs(15.87893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05307 - lat) + Math.Abs(13.61382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13333 - lat) + Math.Abs(14.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54972 - lat) + Math.Abs(13.81361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54722 - lat) + Math.Abs(16.21917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57111 - lat) + Math.Abs(15.18889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92417 - lat) + Math.Abs(14.04361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58848 - lat) + Math.Abs(15.00093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99694 - lat) + Math.Abs(14.47056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47045 - lat) + Math.Abs(14.85009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37583 - lat) + Math.Abs(15.61639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65472 - lat) + Math.Abs(15.99583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55794 - lat) + Math.Abs(16.3041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53917 - lat) + Math.Abs(13.80528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69917 - lat) + Math.Abs(15.66917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66667 - lat) + Math.Abs(16.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57056 - lat) + Math.Abs(15.94361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79306 - lat) + Math.Abs(14.3625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25417 - lat) + Math.Abs(14.48861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55556 - lat) + Math.Abs(16.4975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23092 - lat) + Math.Abs(15.26044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72083 - lat) + Math.Abs(16.0225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38722 - lat) + Math.Abs(15.965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87471 - lat) + Math.Abs(13.948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26024 - lat) + Math.Abs(14.39037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03333 - lat) + Math.Abs(14.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95028 - lat) + Math.Abs(14.64222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32897 - lat) + Math.Abs(14.23229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90333 - lat) + Math.Abs(15.59111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56972 - lat) + Math.Abs(15.575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99529 - lat) + Math.Abs(15.4775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4 - lat) + Math.Abs(14.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61806 - lat) + Math.Abs(16.21917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28972 - lat) + Math.Abs(15.03889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85722 - lat) + Math.Abs(13.78417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33808 - lat) + Math.Abs(13.55245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91583 - lat) + Math.Abs(14.36306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27216 - lat) + Math.Abs(13.9535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34889 - lat) + Math.Abs(14.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67611 - lat) + Math.Abs(16.28389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28944 - lat) + Math.Abs(14.855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4 - lat) + Math.Abs(14.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36917 - lat) + Math.Abs(14.11361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01494 - lat) + Math.Abs(15.69285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35472 - lat) + Math.Abs(14.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05889 - lat) + Math.Abs(15.66417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89444 - lat) + Math.Abs(13.63222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36025 - lat) + Math.Abs(15.42661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98389 - lat) + Math.Abs(14.35583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54556 - lat) + Math.Abs(13.76778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60861 - lat) + Math.Abs(15.88833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60528 - lat) + Math.Abs(16.24056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81806 - lat) + Math.Abs(14.38222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38333 - lat) + Math.Abs(14.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61889 - lat) + Math.Abs(16.15028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69722 - lat) + Math.Abs(15.91056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37694 - lat) + Math.Abs(15.8025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.325 - lat) + Math.Abs(15.0925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88601 - lat) + Math.Abs(13.90946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52167 - lat) + Math.Abs(16.28111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49056 - lat) + Math.Abs(13.67056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51122 - lat) + Math.Abs(13.65377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97139 - lat) + Math.Abs(13.64944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88889 - lat) + Math.Abs(13.70167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46722 - lat) + Math.Abs(15.71639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42611 - lat) + Math.Abs(14.08722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44913 - lat) + Math.Abs(14.11135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12556 - lat) + Math.Abs(13.98167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93833 - lat) + Math.Abs(14.63278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.62139 - lat) + Math.Abs(14.46056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91444 - lat) + Math.Abs(14.22583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54 - lat) + Math.Abs(16.28861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57861 - lat) + Math.Abs(13.73611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18722 - lat) + Math.Abs(15.4325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25389 - lat) + Math.Abs(15.09333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29917 - lat) + Math.Abs(15.19556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3025 - lat) + Math.Abs(15.58222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36861 - lat) + Math.Abs(15.90639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42333 - lat) + Math.Abs(15.18444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50651 - lat) + Math.Abs(15.14424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38222 - lat) + Math.Abs(15.37917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47444 - lat) + Math.Abs(15.65583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49116 - lat) + Math.Abs(15.76336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44333 - lat) + Math.Abs(15.86528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45194 - lat) + Math.Abs(15.91222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55 - lat) + Math.Abs(15.495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55417 - lat) + Math.Abs(15.70278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65722 - lat) + Math.Abs(15.84139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56472 - lat) + Math.Abs(15.78861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00944 - lat) + Math.Abs(15.29083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50526 - lat) + Math.Abs(13.6024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52845 - lat) + Math.Abs(13.64721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51722 - lat) + Math.Abs(13.77583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53944 - lat) + Math.Abs(13.79611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57167 - lat) + Math.Abs(13.7925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94194 - lat) + Math.Abs(13.66779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86242 - lat) + Math.Abs(15.22188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13911 - lat) + Math.Abs(14.96295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34408 - lat) + Math.Abs(15.99472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20484 - lat) + Math.Abs(14.53839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31757 - lat) + Math.Abs(14.94674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50842 - lat) + Math.Abs(14.91005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15325 - lat) + Math.Abs(14.60741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00002 - lat) + Math.Abs(14.5573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49584 - lat) + Math.Abs(13.61466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54003 - lat) + Math.Abs(13.77607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39284 - lat) + Math.Abs(14.10869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48202 - lat) + Math.Abs(13.61305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26958 - lat) + Math.Abs(15.08763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61728 - lat) + Math.Abs(15.64797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34898 - lat) + Math.Abs(14.30026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26581 - lat) + Math.Abs(15.30435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14748 - lat) + Math.Abs(14.59211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3932 - lat) + Math.Abs(15.00912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26362 - lat) + Math.Abs(15.09713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13539 - lat) + Math.Abs(14.61294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92215 - lat) + Math.Abs(14.5874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08338 - lat) + Math.Abs(14.63632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54225 - lat) + Math.Abs(15.71924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27973 - lat) + Math.Abs(15.05669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54326 - lat) + Math.Abs(14.94261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51372 - lat) + Math.Abs(13.74571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50247 - lat) + Math.Abs(15.62126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63756 - lat) + Math.Abs(15.61895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12665 - lat) + Math.Abs(14.61231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40538 - lat) + Math.Abs(15.67255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56209 - lat) + Math.Abs(16.4673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27469 - lat) + Math.Abs(14.74917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15064 - lat) + Math.Abs(14.31186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15981 - lat) + Math.Abs(14.36662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43289 - lat) + Math.Abs(15.82614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26031 - lat) + Math.Abs(15.22936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30874 - lat) + Math.Abs(15.16275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32446 - lat) + Math.Abs(13.84461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56721 - lat) + Math.Abs(16.31499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52846 - lat) + Math.Abs(14.89385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24093 - lat) + Math.Abs(15.09494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18466 - lat) + Math.Abs(14.59525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42609 - lat) + Math.Abs(15.59364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40584 - lat) + Math.Abs(16.11121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5317 - lat) + Math.Abs(15.57351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41073 - lat) + Math.Abs(15.5595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51849 - lat) + Math.Abs(13.71757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95534 - lat) + Math.Abs(15.09164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52028 - lat) + Math.Abs(13.73584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65573 - lat) + Math.Abs(16.13903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40353 - lat) + Math.Abs(15.52757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88794 - lat) + Math.Abs(13.86961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11541 - lat) + Math.Abs(14.39582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13435 - lat) + Math.Abs(14.39542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35351 - lat) + Math.Abs(14.28515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38555 - lat) + Math.Abs(14.16466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59036 - lat) + Math.Abs(13.74749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42204 - lat) + Math.Abs(16.02938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14699 - lat) + Math.Abs(14.41887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25866 - lat) + Math.Abs(15.18911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54798 - lat) + Math.Abs(15.53334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29065 - lat) + Math.Abs(15.18618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55419 - lat) + Math.Abs(15.54855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12953 - lat) + Math.Abs(14.50472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31455 - lat) + Math.Abs(15.58973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01536 - lat) + Math.Abs(14.39386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Žužemberk", "N8", 45.83389, 14.92917);
case 1: return new CityInfo("Zrkovci", "J2", 46.54778, 15.7075);
case 2: return new CityInfo("Zlatoličje", "C8", 46.45556, 15.79111);
case 3: return new CityInfo("Žirovnica", "N7", 46.40472, 14.14);
case 4: return new CityInfo("Žiri", "F2", 46.04222, 14.10722);
case 5: return new CityInfo("Zimica", "26", 46.53333, 15.75);
case 6: return new CityInfo("Žiče", "C4", 46.315, 15.47972);
case 7: return new CityInfo("Zgornji Duplek", "26", 46.51361, 15.72083);
case 8: return new CityInfo("Zgornji Brnik", "12", 46.23896, 14.48436);
case 9: return new CityInfo("Zgornje Pirniče", "71", 46.14251, 14.43158);
case 10: return new CityInfo("Zgornje Jezersko", "H5", 46.3941, 14.50659);
case 11: return new CityInfo("Zgornje Hoče", "H1", 46.49183, 15.62315);
case 12: return new CityInfo("Zgornje Gorje", "O2", 46.37962, 14.06937);
case 13: return new CityInfo("Zgornje Duplje", "82", 46.30725, 14.29119);
case 14: return new CityInfo("Zgornje Bitnje", "52", 46.22, 14.33667);
case 15: return new CityInfo("Zgornja Voličina", "26", 46.53333, 15.78333);
case 16: return new CityInfo("Zgornja Velka", "B3", 46.67528, 15.76917);
case 17: return new CityInfo("Zgornja Polskava", "L8", 46.42556, 15.61222);
case 18: return new CityInfo("Zgornja Kungota", "55", 46.63917, 15.61556);
case 19: return new CityInfo("Zgornja Hajdina", "G9", 46.40611, 15.83861);
case 20: return new CityInfo("Zgornja Bistrica", "L8", 46.39918, 15.5424);
case 21: return new CityInfo("Zgornja Besnica", "52", 46.26667, 14.28333);
case 22: return new CityInfo("Žetale", "N6", 46.27356, 15.82658);
case 23: return new CityInfo("Željne", "H7", 45.65861, 14.88639);
case 24: return new CityInfo("Železniki", "F1", 46.22482, 14.17205);
case 25: return new CityInfo("Zbilje", "52", 46.16667, 14.41667);
case 26: return new CityInfo("Zavrč", "E9", 46.39167, 16.04972);
case 27: return new CityInfo("Žalec", "N5", 46.25151, 15.16482);
case 28: return new CityInfo("Zagorje ob Savi", "E7", 46.13179, 14.99694);
case 29: return new CityInfo("Zabukovica", "N5", 46.21408, 15.15954);
case 30: return new CityInfo("Zabreznica", "N7", 46.4, 14.15);
case 31: return new CityInfo("Vuzenica", "E6", 46.59639, 15.16722);
case 32: return new CityInfo("Vuhred", "A2", 46.59472, 15.2375);
case 33: return new CityInfo("Vrzdenec", "H3", 46.02028, 14.27083);
case 34: return new CityInfo("Vrtojba", "L6", 45.9125, 13.63417);
case 35: return new CityInfo("Vrhpolje pri Kamniku", "H6", 46.23333, 14.63333);
case 36: return new CityInfo("Vrhpolje", "E1", 45.86444, 13.96139);
case 37: return new CityInfo("Vrhnika", "E5", 45.9635, 14.29484);
case 38: return new CityInfo("Vrbje", "N5", 46.25, 15.15);
case 39: return new CityInfo("Vransko", "N4", 46.24389, 14.95139);
case 40: return new CityInfo("Volčja Draga", "P1", 45.90694, 13.6775);
case 41: return new CityInfo("Volče", "D2", 46.1754, 13.70785);
case 42: return new CityInfo("Voklo", "B2", 46.21611, 14.42306);
case 43: return new CityInfo("Vojnik", "N3", 46.29333, 15.30333);
case 44: return new CityInfo("Vogrsko", "P1", 45.90611, 13.70056);
case 45: return new CityInfo("Voglje", "B2", 46.21556, 14.43861);
case 46: return new CityInfo("Vodice", "E3", 46.18987, 14.49492);
case 47: return new CityInfo("Vnanje Gorice", "09", 46.00722, 14.42194);
case 48: return new CityInfo("Vitovlje", "84", 45.93917, 13.76556);
case 49: return new CityInfo("Vitomarci", "M4", 46.5275, 15.93944);
case 50: return new CityInfo("Vitanje", "E2", 46.38167, 15.29583);
case 51: return new CityInfo("Visoko", "B2", 46.27111, 14.41806);
case 52: return new CityInfo("Višnja Gora", "39", 45.95389, 14.74528);
case 53: return new CityInfo("Virmaše", "B9", 46.18333, 14.33333);
case 54: return new CityInfo("Vipava", "E1", 45.84667, 13.96306);
case 55: return new CityInfo("Videm", "20", 45.85, 14.69417);
case 56: return new CityInfo("Veržej", "N1", 46.58361, 16.16528);
case 57: return new CityInfo("Verd", "E5", 45.95667, 14.30583);
case 58: return new CityInfo("Veliko Mlačevo", "32", 45.93694, 14.68167);
case 59: return new CityInfo("Velike Lašče", "D8", 45.83222, 14.63639);
case 60: return new CityInfo("Velike Brusnice", "J7", 45.80405, 15.25772);
case 61: return new CityInfo("Velika Polana", "M9", 46.57194, 16.34694);
case 62: return new CityInfo("Valburga", "71", 46.16667, 14.43333);
case 63: return new CityInfo("Uršna Sela", "J7", 45.71888, 15.12551);
case 64: return new CityInfo("Unec", "13", 45.81556, 14.29389);
case 65: return new CityInfo("Turnišče", "D6", 46.62778, 16.32028);
case 66: return new CityInfo("Trzin", "M8", 46.13333, 14.56667);
case 67: return new CityInfo("Tržič", "D5", 46.36357, 14.31046);
case 68: return new CityInfo("Tropovci", "M6", 46.65361, 16.10333);
case 69: return new CityInfo("Trnovska Vas", "M7", 46.52019, 15.88657);
case 70: return new CityInfo("Trnovlje pri Celju", "11", 46.25667, 15.29528);
case 71: return new CityInfo("Trnje", "15", 46.5875, 16.30833);
case 72: return new CityInfo("Trebnje", "D4", 45.90417, 15.02167);
case 73: return new CityInfo("Trbovlje", "D3", 46.155, 15.05333);
case 74: return new CityInfo("Trboje", "B2", 46.2, 14.41667);
case 75: return new CityInfo("Topolšica", "C7", 46.40028, 15.02157);
case 76: return new CityInfo("Sveti Tomaž", "P8", 46.48417, 16.08361);
case 77: return new CityInfo("Tolmin", "D2", 46.18304, 13.73321);
case 78: return new CityInfo("Velenje", "D7", 46.35917, 15.11028);
case 79: return new CityInfo("Tišina", "M6", 46.65806, 16.09167);
case 80: return new CityInfo("Tepanje", "C4", 46.34778, 15.47611);
case 81: return new CityInfo("Tabor", "M5", 46.23611, 15.01833);
case 82: return new CityInfo("Sv. Duh", "B9", 46.18333, 14.33333);
case 83: return new CityInfo("Sv. Anton", "50", 45.52583, 13.83194);
case 84: return new CityInfo("Sv. Ana v Slov. Goricah", "M3", 46.64917, 15.84417);
case 85: return new CityInfo("Suhadole", "H8", 46.18333, 14.55);
case 86: return new CityInfo("Strunjan", "J9", 45.525, 13.60556);
case 87: return new CityInfo("Strahinj", "82", 46.28333, 14.31667);
case 88: return new CityInfo("Štore", "C9", 46.22083, 15.31389);
case 89: return new CityInfo("Stojnci", "J3", 46.38111, 15.98278);
case 90: return new CityInfo("Stična", "39", 45.96056, 14.81028);
case 91: return new CityInfo("Starše", "C8", 46.46583, 15.76722);
case 92: return new CityInfo("Stari Trg pri Ložu", "I7", 45.71484, 14.47097);
case 93: return new CityInfo("Stari Trg", "C2", 46.5, 15.06667);
case 94: return new CityInfo("Stara Vrhnika", "E5", 45.97417, 14.28111);
case 95: return new CityInfo("Stara Loka", "B9", 46.17311, 14.30041);
case 96: return new CityInfo("Stanežiče", "61", 46.11667, 14.43333);
case 97: return new CityInfo("Srednje Jarše", "G7", 46.15659, 14.5957);
case 98: return new CityInfo("Srednje Bitnje", "52", 46.21667, 14.33333);
case 99: return new CityInfo("Srednja Vas v Bohinju", "A3", 46.295, 13.92389);
case 100: return new CityInfo("Središče ob Dravi", "P4", 46.39417, 16.26806);
case 101: return new CityInfo("Spuhlja", "K7", 46.4125, 15.915);
case 102: return new CityInfo("Spodnji Slemen", "L5", 46.56667, 15.53306);
case 103: return new CityInfo("Spodnji Duplek", "26", 46.50306, 15.74528);
case 104: return new CityInfo("Spodnje Pirniče", "71", 46.13472, 14.43861);
case 105: return new CityInfo("Spodnje Jarše", "G7", 46.15, 14.6);
case 106: return new CityInfo("Spodnje Hoče", "H1", 46.5, 15.65);
case 107: return new CityInfo("Spodnje Gorje", "O2", 46.41359, 14.03537);
case 108: return new CityInfo("Spodnje Gameljne", "61", 46.11667, 14.5);
case 109: return new CityInfo("Spodnje Duplje", "82", 46.3, 14.3);
case 110: return new CityInfo("Spodnja Voličina", "I3", 46.54444, 15.815);
case 111: return new CityInfo("Spodnja Slivnica", "32", 45.92442, 14.6575);
case 112: return new CityInfo("Spodnja Polskava", "L8", 46.41056, 15.63889);
case 113: return new CityInfo("Spodnja Idrija", "36", 46.03194, 14.02722);
case 114: return new CityInfo("Spodnja Hajdina", "G9", 46.40889, 15.84694);
case 115: return new CityInfo("Spodnja Besnica", "82", 46.25749, 14.30572);
case 116: return new CityInfo("Šoštanj", "C7", 46.38, 15.04861);
case 117: return new CityInfo("Solčava", "M2", 46.41944, 14.69361);
case 118: return new CityInfo("Sodražica", "M1", 45.76111, 14.63556);
case 119: return new CityInfo("Smrjene", "C1", 45.9375, 14.59194);
case 120: return new CityInfo("Šmartno pri Slovenj Gradcu", "C2", 46.48944, 15.10667);
case 121: return new CityInfo("Šmartno pri Litiji", "L9", 46.04444, 14.84417);
case 122: return new CityInfo("Šmartno ob Paki", "C6", 46.33333, 15.03333);
case 123: return new CityInfo("Šmarjeta", "P3", 45.88333, 15.25);
case 124: return new CityInfo("Šmarje pri Jelšah", "C5", 46.22722, 15.51917);
case 125: return new CityInfo("Šmarje-Sap", "32", 45.97618, 14.61177);
case 126: return new CityInfo("Šmarje", "50", 45.50139, 13.71778);
case 127: return new CityInfo("Šmarca", "H6", 46.19333, 14.59667);
case 128: return new CityInfo("Slovenske Konjice", "C4", 46.33667, 15.42583);
case 129: return new CityInfo("Slovenska Bistrica", "L8", 46.39278, 15.57444);
case 130: return new CityInfo("Slovenj Gradec", "C2", 46.51028, 15.08056);
case 131: return new CityInfo("Slovenja Vas", "G9", 46.45, 15.8);
case 132: return new CityInfo("Slivnica pri Mariboru", "H1", 46.47639, 15.65583);
case 133: return new CityInfo("Sladki Vrh", "N9", 46.68892, 15.73719);
case 134: return new CityInfo("Skoke", "H1", 46.48578, 15.69427);
case 135: return new CityInfo("Škofljica", "C1", 45.98333, 14.57667);
case 136: return new CityInfo("Škofja Loka", "B9", 46.16551, 14.30626);
case 137: return new CityInfo("Zgornje Škofije", "50", 45.56639, 13.79944);
case 138: return new CityInfo("Škocjan", "B8", 45.90667, 15.29139);
case 139: return new CityInfo("Škocjan", "50", 45.53359, 13.76363);
case 140: return new CityInfo("Škale", "D7", 46.3756, 15.10466);
case 141: return new CityInfo("Sinja Gorica", "E5", 45.97556, 14.31833);
case 142: return new CityInfo("Sežana", "B7", 45.70924, 13.87333);
case 143: return new CityInfo("Sevnica", "B6", 46.00778, 15.31556);
case 144: return new CityInfo("Serdica", "A6", 46.81903, 16.03034);
case 145: return new CityInfo("Šentvid pri Stični", "39", 45.95004, 14.84344);
case 146: return new CityInfo("Šentrupert", "P2", 45.97778, 15.09556);
case 147: return new CityInfo("Šentjur", "L7", 46.21722, 15.3975);
case 148: return new CityInfo("Šentjernej", "B4", 45.84, 15.33611);
case 149: return new CityInfo("Šentjanž pri Dravogradu", "25", 46.56111, 15.03889);
case 150: return new CityInfo("Šentilj v Slov. Goricah", "B3", 46.68167, 15.64806);
case 151: return new CityInfo("Senožeti", "22", 46.09139, 14.73306);
case 152: return new CityInfo("Senožeče", "19", 45.72111, 14.04111);
case 153: return new CityInfo("Senovo", "54", 46.02361, 15.47694);
case 154: return new CityInfo("Šenčur", "B2", 46.24556, 14.41972);
case 155: return new CityInfo("Šempeter v Savinj. Dolini", "N5", 46.25639, 15.12194);
case 156: return new CityInfo("Šempeter pri Gorici", "L6", 45.9275, 13.64111);
case 157: return new CityInfo("Šempas", "84", 45.93028, 13.74361);
case 158: return new CityInfo("Semič", "B1", 45.64611, 15.18222);
case 159: return new CityInfo("Selnica ob Muri", "B3", 46.68333, 15.7);
case 160: return new CityInfo("Selca", "F1", 46.22444, 14.20556);
case 161: return new CityInfo("Sela pri Dobovi", "08", 45.91667, 15.63333);
case 162: return new CityInfo("Sečovlje", "J9", 45.47667, 13.62333);
case 163: return new CityInfo("Šalovci", "L4", 46.825, 16.29806);
case 164: return new CityInfo("Šalka Vas", "H7", 45.65333, 14.8825);
case 165: return new CityInfo("Ruše", "L3", 46.53944, 15.51583);
case 166: return new CityInfo("Rovte", "64", 45.98528, 14.1775);
case 167: return new CityInfo("Rogoza", "H1", 46.5, 15.68333);
case 168: return new CityInfo("Rogatec", "A8", 46.22944, 15.70028);
case 169: return new CityInfo("Rogašovci", "A6", 46.8, 16.03333);
case 170: return new CityInfo("Rogaška Slatina", "A7", 46.2375, 15.63972);
case 171: return new CityInfo("Rimske Toplice", "57", 46.1226, 15.1919);
case 172: return new CityInfo("Ribno", "03", 46.32742, 14.11004);
case 173: return new CityInfo("Ribnica na Pohorju", "L2", 46.535, 15.27278);
case 174: return new CityInfo("Ribnica", "L1", 45.73861, 14.7275);
case 175: return new CityInfo("Renkovci", "D6", 46.63667, 16.30278);
case 176: return new CityInfo("Renče", "P1", 45.89, 13.66861);
case 177: return new CityInfo("Rečica ob Savinji", "O9", 46.31667, 14.91667);
case 178: return new CityInfo("Spodnja Rečica", "57", 46.16417, 15.21528);
case 179: return new CityInfo("Razvanje", "J2", 46.51444, 15.63611);
case 180: return new CityInfo("Ravne na Koroškem", "K8", 46.54306, 14.96917);
case 181: return new CityInfo("Ravne", "C7", 46.41413, 15.06087);
case 182: return new CityInfo("Rateče", "53", 46.46815, 13.71439);
case 183: return new CityInfo("Rakitna", "09", 45.88833, 14.44417);
case 184: return new CityInfo("Rakičan", "80", 46.65167, 16.20417);
case 185: return new CityInfo("Rakek", "13", 45.81333, 14.31111);
case 186: return new CityInfo("Radovljica", "A3", 46.34444, 14.17444);
case 187: return new CityInfo("Radomlje", "G7", 46.17361, 14.61222);
case 188: return new CityInfo("Radlje ob Dravi", "A2", 46.61417, 15.22639);
case 189: return new CityInfo("Radenci", "A1", 46.64201, 16.03781);
case 190: return new CityInfo("Radeče", "99", 46.06806, 15.18389);
case 191: return new CityInfo("Rače", "98", 46.45194, 15.68139);
case 192: return new CityInfo("Puconci", "97", 46.70667, 16.15639);
case 193: return new CityInfo("Ptuj", "K7", 46.42005, 15.87018);
case 194: return new CityInfo("Prvačina", "84", 45.89, 13.71806);
case 195: return new CityInfo("Prevoje pri Šentvidu", "68", 46.16667, 14.66667);
case 196: return new CityInfo("Prevalje", "K6", 46.54694, 14.92083);
case 197: return new CityInfo("Prestranek", "94", 45.73033, 14.18622);
case 198: return new CityInfo("Preserje pri Radomljah", "72", 46.16911, 14.59698);
case 199: return new CityInfo("Prepolje", "C8", 46.44417, 15.76389);
case 200: return new CityInfo("Predoslje", "52", 46.26582, 14.38608);
case 201: return new CityInfo("Preddvor", "K5", 46.3025, 14.42306);
case 202: return new CityInfo("Prebold", "K4", 46.23694, 15.0925);
case 203: return new CityInfo("Pragersko", "L8", 46.39667, 15.66);
case 204: return new CityInfo("Bonini", "50", 45.52861, 13.78194);
case 205: return new CityInfo("Postojna", "94", 45.77435, 14.21528);
case 206: return new CityInfo("Portorož", "J9", 45.51429, 13.59206);
case 207: return new CityInfo("Pongrac", "N5", 46.21667, 15.13333);
case 208: return new CityInfo("Polzela", "K3", 46.28333, 15.06667);
case 209: return new CityInfo("Poljčane", "O8", 46.31194, 15.57917);
case 210: return new CityInfo("Polica", "32", 45.98197, 14.70498);
case 211: return new CityInfo("Polhov Gradec", "G4", 46.06694, 14.31611);
case 212: return new CityInfo("Podvinci", "K7", 46.4325, 15.91667);
case 213: return new CityInfo("Podvelka", "K2", 46.58694, 15.33056);
case 214: return new CityInfo("Podreča", "52", 46.17278, 14.41306);
case 215: return new CityInfo("Podpeč", "09", 45.96972, 14.4175);
case 216: return new CityInfo("Podljubelj", "D5", 46.412, 14.275);
case 217: return new CityInfo("Podlehnik", "K1", 46.33528, 15.88);
case 218: return new CityInfo("Podkraj pri Velenju", "D7", 46.3525, 15.08917);
case 219: return new CityInfo("Podgrad", "38", 45.52167, 14.14611);
case 220: return new CityInfo("Podgorje", "C2", 46.47194, 15.08361);
case 221: return new CityInfo("Podgorje", "H6", 46.21667, 14.58333);
case 222: return new CityInfo("Podgorci", "87", 46.42917, 16.06361);
case 223: return new CityInfo("Podčetrtek", "92", 46.15694, 15.59861);
case 224: return new CityInfo("Podbrezje", "82", 46.3, 14.28333);
case 225: return new CityInfo("Podbrdo", "D2", 46.21, 13.96444);
case 226: return new CityInfo("Pobrežje", "N2", 46.38472, 15.87861);
case 227: return new CityInfo("Planina", "94", 45.82903, 14.24969);
case 228: return new CityInfo("Pivka", "91", 45.68292, 14.19588);
case 229: return new CityInfo("Piran", "J9", 45.52778, 13.57056);
case 230: return new CityInfo("Pijava Gorica", "C1", 45.95111, 14.57194);
case 231: return new CityInfo("Petrovče", "N5", 46.24167, 15.19);
case 232: return new CityInfo("Petišovci", "I4", 46.52722, 16.46139);
case 233: return new CityInfo("Petanjci", "M6", 46.65333, 16.06611);
case 234: return new CityInfo("Pesnica pri Mariboru", "89", 46.60694, 15.67667);
case 235: return new CityInfo("Pekre", "J2", 46.54722, 15.59556);
case 236: return new CityInfo("Zgornje Partinje", "P7", 46.59556, 15.75861);
case 237: return new CityInfo("Pameče", "C2", 46.53417, 15.07917);
case 238: return new CityInfo("Ozeljan", "84", 45.94361, 13.73028);
case 239: return new CityInfo("Otočec", "P3", 45.83967, 15.22528);
case 240: return new CityInfo("Otiški Vrh", "25", 46.57389, 15.03278);
case 241: return new CityInfo("Osilnica", "88", 45.52914, 14.69838);
case 242: return new CityInfo("Ormož", "87", 46.41139, 16.15444);
case 243: return new CityInfo("Oplotnica", "J8", 46.38778, 15.44667);
case 244: return new CityInfo("Odranci", "86", 46.58667, 16.28028);
case 245: return new CityInfo("Obrež", "P4", 46.39972, 16.23194);
case 246: return new CityInfo("Novo Mesto", "J7", 45.80397, 15.16886);
case 247: return new CityInfo("Nova Vas", "F6", 45.77167, 14.50583);
case 248: return new CityInfo("Nova Gorica", "84", 45.95604, 13.64837);
case 249: return new CityInfo("Notranje Gorice", "09", 45.9875, 14.39889);
case 250: return new CityInfo("Njiverce", "G9", 46.40367, 15.80675);
case 251: return new CityInfo("Nedelica", "D6", 46.61667, 16.33333);
case 252: return new CityInfo("Naklo", "82", 46.27278, 14.31722);
case 253: return new CityInfo("Muta", "81", 46.61139, 15.16611);
case 254: return new CityInfo("Murska Sobota", "80", 46.6625, 16.16639);
case 255: return new CityInfo("Mozirje", "79", 46.33944, 14.96333);
case 256: return new CityInfo("Moste", "N7", 46.41667, 14.13333);
case 257: return new CityInfo("Moste", "H8", 46.195, 14.55139);
case 258: return new CityInfo("Moškanjci", "28", 46.42028, 15.99333);
case 259: return new CityInfo("Morje", "98", 46.44444, 15.62139);
case 260: return new CityInfo("Moravske Toplice", "78", 46.68313, 16.2208);
case 261: return new CityInfo("Moravče", "77", 46.13694, 14.745);
case 262: return new CityInfo("Mokronog", "O7", 45.93417, 15.14083);
case 263: return new CityInfo("Mojstrana", "53", 46.42383, 13.8752);
case 264: return new CityInfo("Mlaka pri Kranju", "52", 46.28333, 14.35);
case 265: return new CityInfo("Mislinjska Dobrava", "C2", 46.46528, 15.12389);
case 266: return new CityInfo("Mislinja", "76", 46.44141, 15.20027);
case 267: return new CityInfo("Mirna Peč", "J6", 45.86028, 15.08333);
case 268: return new CityInfo("Mirna", "O6", 45.95528, 15.06194);
case 269: return new CityInfo("Miren", "J5", 45.89556, 13.6075);
case 270: return new CityInfo("Miklavž na Dravskem Polju", "J4", 46.50583, 15.69722);
case 271: return new CityInfo("Migojnice", "N5", 46.23333, 15.16667);
case 272: return new CityInfo("Mežica", "74", 46.52139, 14.85444);
case 273: return new CityInfo("Metlika", "73", 45.64722, 15.31417);
case 274: return new CityInfo("Mengeš", "72", 46.16694, 14.575);
case 275: return new CityInfo("Melinci", "02", 46.57361, 16.23667);
case 276: return new CityInfo("Mekinje", "H6", 46.23333, 14.61667);
case 277: return new CityInfo("Medvode", "71", 46.1422, 14.41114);
case 278: return new CityInfo("Martjanci", "78", 46.68639, 16.19778);
case 279: return new CityInfo("Markovci", "J3", 46.39557, 15.92831);
case 280: return new CityInfo("Maribor", "J2", 46.55472, 15.64667);
case 281: return new CityInfo("Makole", "O5", 46.31722, 15.66722);
case 282: return new CityInfo("Majšperk", "J1", 46.35167, 15.73361);
case 283: return new CityInfo("Lukovica pri Domžalah", "68", 46.16988, 14.69179);
case 284: return new CityInfo("Lukavci", "I1", 46.54333, 16.15278);
case 285: return new CityInfo("Luče", "I9", 46.35611, 14.74667);
case 286: return new CityInfo("Lož", "I7", 45.72417, 14.46889);
case 287: return new CityInfo("Lovrenc na Pohorju", "I8", 46.54056, 15.39306);
case 288: return new CityInfo("Lovrenc na Dravskem Polju", "45", 46.37361, 15.77917);
case 289: return new CityInfo("Loški Potok", "66", 45.70139, 14.58028);
case 290: return new CityInfo("Lokve", "17", 45.60167, 15.17389);
case 291: return new CityInfo("Lokovica", "C7", 46.35944, 15.05194);
case 292: return new CityInfo("Lokev", "B7", 45.66111, 13.92806);
case 293: return new CityInfo("Lokavec", "01", 45.90167, 13.87972);
case 294: return new CityInfo("Loka pri Mengšu", "72", 46.15, 14.56528);
case 295: return new CityInfo("Log pri Brezovici", "O4", 46.01667, 14.36667);
case 296: return new CityInfo("Loče", "C4", 46.29972, 15.5);
case 297: return new CityInfo("Ljutomer", "I6", 46.52083, 16.1975);
case 298: return new CityInfo("Ljubno ob Savinji", "62", 46.34358, 14.83377);
case 299: return new CityInfo("Ljubljana", "61", 46.05108, 14.50513);
case 300: return new CityInfo("Ljubečna", "11", 46.25567, 15.3243);
case 301: return new CityInfo("Litija", "I5", 46.05861, 14.8225);
case 302: return new CityInfo("Lipovci", "02", 46.62833, 16.22806);
case 303: return new CityInfo("Lipa", "02", 46.60694, 16.2875);
case 304: return new CityInfo("Limbuš", "J2", 46.55361, 15.58361);
case 305: return new CityInfo("Liboje", "N5", 46.21111, 15.195);
case 306: return new CityInfo("Letuš", "F7", 46.31583, 15.025);
case 307: return new CityInfo("Leskovec pri Krškem", "54", 45.93566, 15.47184);
case 308: return new CityInfo("Leskovec", "L8", 46.38333, 15.63333);
case 309: return new CityInfo("Lesce", "A3", 46.36111, 14.15778);
case 310: return new CityInfo("Lendava", "I4", 46.56494, 16.45091);
case 311: return new CityInfo("Lenart v Slov. Goricah", "I3", 46.57611, 15.83139);
case 312: return new CityInfo("Laško", "57", 46.15463, 15.23555);
case 313: return new CityInfo("Lancova Vas", "N2", 46.37111, 15.85639);
case 314: return new CityInfo("Kuzma", "I2", 46.83694, 16.08333);
case 315: return new CityInfo("Krtina", "68", 46.14834, 14.65228);
case 316: return new CityInfo("Krško", "54", 45.95915, 15.49167);
case 317: return new CityInfo("Krška Vas", "08", 45.9, 15.56667);
case 318: return new CityInfo("Kropa", "A3", 46.3, 14.2);
case 319: return new CityInfo("Kromberk", "84", 45.96083, 13.66556);
case 320: return new CityInfo("Krog", "80", 46.63806, 16.14139);
case 321: return new CityInfo("Krmelj", "B6", 45.98472, 15.18944);
case 322: return new CityInfo("Križevci pri Ljutomeru", "I1", 46.56833, 16.13861);
case 323: return new CityInfo("Križe", "D5", 46.34278, 14.30139);
case 324: return new CityInfo("Križ", "B7", 45.74472, 13.86583);
case 325: return new CityInfo("Kresnice", "77", 46.10204, 14.78575);
case 326: return new CityInfo("Krčevina pri Vurbergu", "K7", 46.47528, 15.81083);
case 327: return new CityInfo("Kranjska Gora", "53", 46.45689, 13.77824);
case 328: return new CityInfo("Kranj", "52", 46.23887, 14.35561);
case 329: return new CityInfo("Kozje", "51", 46.075, 15.56028);
case 330: return new CityInfo("Kozjak nad Pesnico", "55", 46.61, 15.63444);
case 331: return new CityInfo("Kozina", "35", 45.61, 13.93556);
case 332: return new CityInfo("Kovor", "D5", 46.35, 14.28333);
case 333: return new CityInfo("Kotlje", "K8", 46.52139, 14.98694);
case 334: return new CityInfo("Kostanjevica na Krki", "O3", 45.84611, 15.42222);
case 335: return new CityInfo("Košnica pri Celju", "11", 46.21667, 15.23333);
case 336: return new CityInfo("Koper", "50", 45.54694, 13.72944);
case 337: return new CityInfo("Komen", "49", 45.81528, 13.74833);
case 338: return new CityInfo("Kokrica", "52", 46.27028, 14.36111);
case 339: return new CityInfo("Kočevje", "H7", 45.64333, 14.86333);
case 340: return new CityInfo("Kobilje", "47", 46.68472, 16.39778);
case 341: return new CityInfo("Kobarid", "46", 46.24761, 13.57907);
case 342: return new CityInfo("Kidričevo", "45", 46.40361, 15.79111);
case 343: return new CityInfo("Kasaze", "N5", 46.23333, 15.2);
case 344: return new CityInfo("Kanižarica", "17", 45.55, 15.16667);
case 345: return new CityInfo("Kanal", "44", 46.08861, 13.63972);
case 346: return new CityInfo("Kamnik pod Krimom", "09", 45.94659, 14.40642);
case 347: return new CityInfo("Kamnik", "H6", 46.22587, 14.61207);
case 348: return new CityInfo("Kamnica", "J2", 46.57444, 15.61417);
case 349: return new CityInfo("Kamna Gorica", "A3", 46.31667, 14.2);
case 350: return new CityInfo("Kalce", "64", 45.89556, 14.19361);
case 351: return new CityInfo("Juršinci", "42", 46.48472, 15.97139);
case 352: return new CityInfo("Jurovski Dol", "P7", 46.60639, 15.78472);
case 353: return new CityInfo("Sveti Jurij ob Ščavnici", "D1", 46.5695, 16.02347);
case 354: return new CityInfo("Jezero", "09", 45.97, 14.43306);
case 355: return new CityInfo("Jesenice", "H4", 46.43056, 14.06694);
case 356: return new CityInfo("Izola", "40", 45.53694, 13.66194);
case 357: return new CityInfo("Izlake", "E7", 46.15, 14.95);
case 358: return new CityInfo("Ižakovci", "02", 46.58889, 16.22111);
case 359: return new CityInfo("Ivančna Gorica", "39", 45.93833, 14.80444);
case 360: return new CityInfo("Ilirska Bistrica", "38", 45.56757, 14.24571);
case 361: return new CityInfo("Ihan", "G7", 46.12083, 14.62);
case 362: return new CityInfo("Ig", "37", 45.96028, 14.52889);
case 363: return new CityInfo("Idrija", "36", 46.00278, 14.03056);
case 364: return new CityInfo("Hrvatini", "50", 45.58278, 13.75667);
case 365: return new CityInfo("Hrušica", "H4", 46.445, 14.01778);
case 366: return new CityInfo("Hrpelje", "35", 45.60722, 13.94278);
case 367: return new CityInfo("Hrib-Loški Potok", "66", 45.70688, 14.61674);
case 368: return new CityInfo("Hrastnik", "34", 46.14611, 15.08139);
case 369: return new CityInfo("Hrastje", "B2", 46.21667, 14.4);
case 370: return new CityInfo("Hotiza", "I4", 46.54944, 16.36028);
case 371: return new CityInfo("Hotinja Vas", "H1", 46.46667, 15.66667);
case 372: return new CityInfo("Hotemaže", "B2", 46.28109, 14.42091);
case 373: return new CityInfo("Hotedršica", "64", 45.93028, 14.14222);
case 374: return new CityInfo("Horjul", "H3", 46.02361, 14.29917);
case 375: return new CityInfo("Homec", "G7", 46.18333, 14.6);
case 376: return new CityInfo("Hodoš", "H2", 46.82333, 16.33417);
case 377: return new CityInfo("Grosuplje", "32", 45.95556, 14.65889);
case 378: return new CityInfo("Griže", "N5", 46.22944, 15.15056);
case 379: return new CityInfo("Grgar", "84", 45.99861, 13.67389);
case 380: return new CityInfo("Grajenščak", "K7", 46.48333, 15.81667);
case 381: return new CityInfo("Sv. Trojica v Slov. Goricah", "P6", 46.57667, 15.87694);
case 382: return new CityInfo("Grad", "G8", 46.8, 16.1);
case 383: return new CityInfo("Gozd Martuljek", "53", 46.47517, 13.86368);
case 384: return new CityInfo("Gotovlje", "N5", 46.27418, 15.15186);
case 385: return new CityInfo("Gortina", "81", 46.60583, 15.12639);
case 386: return new CityInfo("Gornji Petrovci", "31", 46.80528, 16.2225);
case 387: return new CityInfo("Gornji Grad", "30", 46.29528, 14.80833);
case 388: return new CityInfo("Gornja Radgona", "29", 46.67333, 15.99222);
case 389: return new CityInfo("Gornja Bistrica", "15", 46.56667, 16.26667);
case 390: return new CityInfo("Gorišnica", "28", 46.41472, 16.01389);
case 391: return new CityInfo("Gorica pri Šmartnem", "11", 46.27444, 15.23083);
case 392: return new CityInfo("Goričane", "71", 46.13936, 14.3936);
case 393: return new CityInfo("Gorenja Vas", "27", 46.10722, 14.14806);
case 394: return new CityInfo("Straža", "P5", 45.78, 15.07278);
case 395: return new CityInfo("Gomilica", "D6", 46.60333, 16.31194);
case 396: return new CityInfo("Golnik", "52", 46.33333, 14.33333);
case 397: return new CityInfo("Godovič", "36", 45.95778, 14.09361);
case 398: return new CityInfo("Godič", "H6", 46.25684, 14.60969);
case 399: return new CityInfo("Godešič", "B9", 46.16667, 14.35444);
case 400: return new CityInfo("Gerečja Vas", "G9", 46.43333, 15.81667);
case 401: return new CityInfo("Gažon", "50", 45.51889, 13.70139);
case 402: return new CityInfo("Gančani", "02", 46.6325, 16.25111);
case 403: return new CityInfo("Gačnik", "89", 46.61667, 15.7);
case 404: return new CityInfo("Gabrje", "J7", 45.7825, 15.27556);
case 405: return new CityInfo("Gaberke", "C7", 46.39715, 15.07903);
case 406: return new CityInfo("Gaberje", "I4", 46.55472, 16.4);
case 407: return new CityInfo("Fram", "98", 46.456, 15.63007);
case 408: return new CityInfo("Dutovlje", "B7", 45.75806, 13.83222);
case 409: return new CityInfo("Drenov Grič", "E5", 45.99778, 14.33278);
case 410: return new CityInfo("Draženci", "N2", 46.38333, 15.85);
case 411: return new CityInfo("Draža Vas", "C4", 46.33333, 15.48333);
case 412: return new CityInfo("Dravograd", "25", 46.58806, 15.01917);
case 413: return new CityInfo("Dragomer", "O4", 46.01667, 14.38333);
case 414: return new CityInfo("Dragomelj", "G7", 46.11027, 14.58729);
case 415: return new CityInfo("Dovje", "53", 46.46863, 13.97202);
case 416: return new CityInfo("Dornberk", "84", 45.88972, 13.73694);
case 417: return new CityInfo("Dornava", "24", 46.43667, 15.95361);
case 418: return new CityInfo("Domžale", "G7", 46.13774, 14.59371);
case 419: return new CityInfo("Dolsko", "22", 46.09194, 14.67722);
case 420: return new CityInfo("Dol pri Ljubljani", "22", 46.08861, 14.60083);
case 421: return new CityInfo("Dol pri Hrastniku", "34", 46.14194, 15.11278);
case 422: return new CityInfo("Dolnji Zemon", "38", 45.54806, 14.26611);
case 423: return new CityInfo("Dolga Vas", "I4", 46.58778, 16.44167);
case 424: return new CityInfo("Dolga Vas", "H7", 45.61694, 14.88472);
case 425: return new CityInfo("Dolenjske Toplice", "G6", 45.75657, 15.05917);
case 426: return new CityInfo("Dolenja Vas", "L1", 45.70611, 14.75444);
case 427: return new CityInfo("Dokležovje", "02", 46.60333, 16.17806);
case 428: return new CityInfo("Dogoše", "J2", 46.52306, 15.70667);
case 429: return new CityInfo("Dobrovo", "07", 45.99639, 13.52639);
case 430: return new CityInfo("Dobrovnik", "G5", 46.65139, 16.3525);
case 431: return new CityInfo("Dobrovce", "J4", 46.48028, 15.70278);
case 432: return new CityInfo("Dobrova", "G4", 46.0458, 14.39186);
case 433: return new CityInfo("Dobrna", "G3", 46.3375, 15.22639);
case 434: return new CityInfo("Dobova", "08", 45.89716, 15.66371);
case 435: return new CityInfo("Dobje pri Planini", "G2", 46.13747, 15.39412);
case 436: return new CityInfo("Dob", "G7", 46.15194, 14.62861);
case 437: return new CityInfo("Divača", "19", 45.68472, 13.97028);
case 438: return new CityInfo("Destrnik", "G1", 46.49254, 15.87893);
case 439: return new CityInfo("Deskle", "44", 46.05307, 13.61382);
case 440: return new CityInfo("Depala Vas", "G7", 46.13333, 14.58333);
case 441: return new CityInfo("Dekani", "50", 45.54972, 13.81361);
case 442: return new CityInfo("Cven", "I6", 46.54722, 16.21917);
case 443: return new CityInfo("Črnomelj", "17", 45.57111, 15.18889);
case 444: return new CityInfo("Črni Vrh", "36", 45.92417, 14.04361);
case 445: return new CityInfo("Črneče", "25", 46.58848, 15.00093);
case 446: return new CityInfo("Črna Vas", "61", 45.99694, 14.47056);
case 447: return new CityInfo("Črna na Koroškem", "16", 46.47045, 14.85009);
case 448: return new CityInfo("Črešnjevec", "L8", 46.37583, 15.61639);
case 449: return new CityInfo("Črešnjevci", "29", 46.65472, 15.99583);
case 450: return new CityInfo("Črenšovci", "15", 46.55794, 16.3041);
case 451: return new CityInfo("Čežarji", "50", 45.53917, 13.80528);
case 452: return new CityInfo("Ceršak", "B3", 46.69917, 15.66917);
case 453: return new CityInfo("Černelavci", "80", 46.66667, 16.13333);
case 454: return new CityInfo("Cerkvenjak", "F9", 46.57056, 15.94361);
case 455: return new CityInfo("Cerknica", "13", 45.79306, 14.3625);
case 456: return new CityInfo("Cerklje na Gorenjskem", "12", 46.25417, 14.48861);
case 457: return new CityInfo("Čentiba", "I4", 46.55556, 16.4975);
case 458: return new CityInfo("Celje", "11", 46.23092, 15.26044);
case 459: return new CityInfo("Cankova", "F8", 46.72083, 16.0225);
case 460: return new CityInfo("Bukovci", "J3", 46.38722, 15.965);
case 461: return new CityInfo("Budanje", "01", 45.87471, 13.948);
case 462: return new CityInfo("Britof", "52", 46.26024, 14.39037);
case 463: return new CityInfo("Brezovica pri Ljubljani", "09", 46.03333, 14.4);
case 464: return new CityInfo("Brezje pri Grosupljem", "32", 45.95028, 14.64222);
case 465: return new CityInfo("Brezje", "A3", 46.32897, 14.23229);
case 466: return new CityInfo("Brežice", "08", 45.90333, 15.59111);
case 467: return new CityInfo("Bresternica", "J2", 46.56972, 15.575);
case 468: return new CityInfo("Brestanica", "54", 45.99529, 15.4775);
case 469: return new CityInfo("Breg", "N7", 46.4, 14.13333);
case 470: return new CityInfo("Brdinje", "K8", 46.53333, 15);
case 471: return new CityInfo("Bratonci", "02", 46.61806, 16.21917);
case 472: return new CityInfo("Braslovče", "F7", 46.28972, 15.03889);
case 473: return new CityInfo("Branik", "84", 45.85722, 13.78417);
case 474: return new CityInfo("Bovec", "06", 46.33808, 13.55245);
case 475: return new CityInfo("Borovnica", "05", 45.91583, 14.36306);
case 476: return new CityInfo("Bohinjska Bistrica", "04", 46.27216, 13.9535);
case 477: return new CityInfo("Bohinjska Bela", "03", 46.34889, 14.06389);
case 478: return new CityInfo("Bogojina", "78", 46.67611, 16.28389);
case 479: return new CityInfo("Bočna", "30", 46.28944, 14.855);
case 480: return new CityInfo("Blejska Dobrava", "03", 46.4, 14.1);
case 481: return new CityInfo("Bled", "03", 46.36917, 14.11361);
case 482: return new CityInfo("Bizeljsko", "08", 46.01494, 15.69285);
case 483: return new CityInfo("Bistrica pri Tržiču", "D5", 46.35472, 14.29167);
case 484: return new CityInfo("Bistrica ob Sotli", "F5", 46.05889, 15.66417);
case 485: return new CityInfo("Bilje", "J5", 45.89444, 13.63222);
case 486: return new CityInfo("Bezina", "C4", 46.36025, 15.42661);
case 487: return new CityInfo("Bevke", "E5", 45.98389, 14.35583);
case 488: return new CityInfo("Bertoki", "50", 45.54556, 13.76778);
case 489: return new CityInfo("Benedikt", "F4", 46.60861, 15.88833);
case 490: return new CityInfo("Beltinci", "02", 46.60528, 16.24056);
case 491: return new CityInfo("Begunje pri Cerknici", "13", 45.81806, 14.38222);
case 492: return new CityInfo("Begunje na Gorenjskem", "A3", 46.38333, 14.21667);
case 493: return new CityInfo("Bakovci", "80", 46.61889, 16.15028);
case 494: return new CityInfo("Apače", "N9", 46.69722, 15.91056);
case 495: return new CityInfo("Apače", "45", 46.37694, 15.8025);
case 496: return new CityInfo("Andraž nad Polzelo", "K3", 46.325, 15.0925);
case 497: return new CityInfo("Ajdovščina", "01", 45.88601, 13.90946);
case 498: return new CityInfo("Razkrižje", "K9", 46.52167, 16.28111);
case 499: return new CityInfo("Korte", "40", 45.49056, 13.67056);
case 500: return new CityInfo("Šared", "40", 45.51122, 13.65377);
case 501: return new CityInfo("Solkan", "84", 45.97139, 13.64944);
case 502: return new CityInfo("Gradišče nad Prvačino", "84", 45.88889, 13.70167);
case 503: return new CityInfo("Dravski Dvor", "J4", 46.46722, 15.71639);
case 504: return new CityInfo("Slovenski Javornik", "H4", 46.42611, 14.08722);
case 505: return new CityInfo("Koroška Bela", "H4", 46.44913, 14.11135);
case 506: return new CityInfo("Cerkno", "14", 46.12556, 13.98167);
case 507: return new CityInfo("Ponova Vas", "32", 45.93833, 14.63278);
case 508: return new CityInfo("Leskova Dolina", "I7", 45.62139, 14.46056);
case 509: return new CityInfo("Logatec", "64", 45.91444, 14.22583);
case 510: return new CityInfo("Dolnja Bistrica", "15", 46.54, 16.28861);
case 511: return new CityInfo("Ankaran", "P9", 45.57861, 13.73611);
case 512: return new CityInfo("Gorica pri Slivnici", "L7", 46.18722, 15.4325);
case 513: return new CityInfo("Latkova Vas", "K4", 46.25389, 15.09333);
case 514: return new CityInfo("Galicija", "N5", 46.29917, 15.19556);
case 515: return new CityInfo("Zgornje Poljčane", "O8", 46.3025, 15.58222);
case 516: return new CityInfo("Videm pri Ptuju", "N2", 46.36861, 15.90639);
case 517: return new CityInfo("Gornji Dolič", "76", 46.42333, 15.18444);
case 518: return new CityInfo("Legen", "C2", 46.50651, 15.14424);
case 519: return new CityInfo("Zreče", "F3", 46.38222, 15.37917);
case 520: return new CityInfo("Radizel", "H1", 46.47444, 15.65583);
case 521: return new CityInfo("Dvorjane", "26", 46.49116, 15.76336);
case 522: return new CityInfo("Mestni Vrh", "K7", 46.44333, 15.86528);
case 523: return new CityInfo("Kicar", "K7", 46.45194, 15.91222);
case 524: return new CityInfo("Selnica ob Dravi", "L5", 46.55, 15.495);
case 525: return new CityInfo("Malečnik", "J2", 46.55417, 15.70278);
case 526: return new CityInfo("Zgornja Ščavnica", "M3", 46.65722, 15.84139);
case 527: return new CityInfo("Hrastovec v Slov. Goricah", "I3", 46.56472, 15.78861);
case 528: return new CityInfo("Dolenji Boštanj", "B6", 46.00944, 15.29083);
case 529: return new CityInfo("Lucija", "J9", 45.50526, 13.6024);
case 530: return new CityInfo("Jagodje", "40", 45.52845, 13.64721);
case 531: return new CityInfo("Vanganel", "50", 45.51722, 13.77583);
case 532: return new CityInfo("Pobegi", "50", 45.53944, 13.79611);
case 533: return new CityInfo("Spodnje Škofije", "50", 45.57167, 13.7925);
case 534: return new CityInfo("Rožna Dolina", "L6", 45.94194, 13.66779);
case 535: return new CityInfo("Šmarješke Toplice", "P3", 45.86242, 15.22188);
case 536: return new CityInfo("Kisovec", "E7", 46.13911, 14.96295);
case 537: return new CityInfo("Cirkulane", "O1", 46.34408, 15.99472);
case 538: return new CityInfo("Komenda", "H8", 46.20484, 14.53839);
case 539: return new CityInfo("Nazarje", "83", 46.31757, 14.94674);
case 540: return new CityInfo("Kostel", "H9", 45.50842, 14.91005);
case 541: return new CityInfo("Vir", "G7", 46.15325, 14.60741);
case 542: return new CityInfo("Lavrica", "C1", 46.00002, 14.5573);
case 543: return new CityInfo("Seča", "J9", 45.49584, 13.61466);
case 544: return new CityInfo("Prade", "50", 45.54003, 13.77607);
case 545: return new CityInfo("Zasip", "03", 46.39284, 14.10869);
case 546: return new CityInfo("Parecag", "J9", 45.48202, 13.61305);
case 547: return new CityInfo("Breg pri Polzeli", "K3", 46.26958, 15.08763);
case 548: return new CityInfo("Gradiška", "55", 46.61728, 15.64797);
case 549: return new CityInfo("Pristava", "D5", 46.34898, 14.30026);
case 550: return new CityInfo("Zadobrova", "11", 46.26581, 15.30435);
case 551: return new CityInfo("Rodica", "G7", 46.14748, 14.59211);
case 552: return new CityInfo("Florjan", "C7", 46.3932, 15.00912);
case 553: return new CityInfo("Ločica ob Savinji", "K3", 46.26362, 15.09713);
case 554: return new CityInfo("Zaboršt", "G7", 46.13539, 14.61294);
case 555: return new CityInfo("Gradišče", "C1", 45.92215, 14.5874);
case 556: return new CityInfo("Videm", "22", 46.08338, 14.63632);
case 557: return new CityInfo("Trčova", "J2", 46.54225, 15.71924);
case 558: return new CityInfo("Parižlje", "F7", 46.27973, 15.05669);
case 559: return new CityInfo("Dobja Vas", "K8", 46.54326, 14.94261);
case 560: return new CityInfo("Kampel", "50", 45.51372, 13.74571);
case 561: return new CityInfo("Pivola", "H1", 46.50247, 15.62126);
case 562: return new CityInfo("Plintovec", "55", 46.63756, 15.61895);
case 563: return new CityInfo("Prelog", "G7", 46.12665, 14.61231);
case 564: return new CityInfo("Gaj", "45", 46.40538, 15.67255);
case 565: return new CityInfo("Lendavske Gorice", "I4", 46.56209, 16.4673);
case 566: return new CityInfo("Nova Štifta", "30", 46.27469, 14.74917);
case 567: return new CityInfo("Puštal", "B9", 46.15064, 14.31186);
case 568: return new CityInfo("Reteče", "B9", 46.15981, 14.36662);
case 569: return new CityInfo("Hajdoše", "G9", 46.43289, 15.82614);
case 570: return new CityInfo("Lopata", "11", 46.26031, 15.22936);
case 571: return new CityInfo("Studence", "N5", 46.30874, 15.16275);
case 572: return new CityInfo("Stara Fužina", "04", 46.32446, 13.84461);
case 573: return new CityInfo("Žižki", "15", 46.56721, 16.31499);
case 574: return new CityInfo("Leše", "K6", 46.52846, 14.89385);
case 575: return new CityInfo("Dolenja Vas", "K4", 46.24093, 15.09494);
case 576: return new CityInfo("Nožice", "G7", 46.18466, 14.59525);
case 577: return new CityInfo("Gabernik", "L8", 46.42609, 15.59364);
case 578: return new CityInfo("Mihovci pri Vel. Nedelji", "87", 46.40584, 16.11121);
case 579: return new CityInfo("Hrastje", "J2", 46.5317, 15.57351);
case 580: return new CityInfo("Kovača Vas", "L8", 46.41073, 15.5595);
case 581: return new CityInfo("Šalara", "50", 45.51849, 13.71757);
case 582: return new CityInfo("Slovenska Vas", "P2", 45.95534, 15.09164);
case 583: return new CityInfo("Bošamarin", "50", 45.52028, 13.73584);
case 584: return new CityInfo("Pušča", "80", 46.65573, 16.13903);
case 585: return new CityInfo("Visole", "L8", 46.40353, 15.52757);
case 586: return new CityInfo("Cesta", "01", 45.88794, 13.86961);
case 587: return new CityInfo("Žlebe", "71", 46.11541, 14.39582);
case 588: return new CityInfo("Vaše", "71", 46.13435, 14.39542);
case 589: return new CityInfo("Ročevnica", "D5", 46.35351, 14.28515);
case 590: return new CityInfo("Smokuč", "N7", 46.38555, 14.16466);
case 591: return new CityInfo("Kolomban", "50", 45.59036, 13.74749);
case 592: return new CityInfo("Zamušani", "28", 46.42204, 16.02938);
case 593: return new CityInfo("Verje", "71", 46.14699, 14.41887);
case 594: return new CityInfo("Arja Vas", "N5", 46.25866, 15.18911);
case 595: return new CityInfo("Bezena", "L3", 46.54798, 15.53334);
case 596: return new CityInfo("Pernovo", "N5", 46.29065, 15.18618);
case 597: return new CityInfo("Bistrica ob Dravi", "L3", 46.55419, 15.54855);
case 598: return new CityInfo("Srednje Gameljne", "61", 46.12953, 14.50472);
case 599: return new CityInfo("Spodnje Poljčane", "O8", 46.31455, 15.58973);
default: return new CityInfo("Lukovica pri Brezovici", "O4", 46.01536, 14.39386);

                                    }                                        
                                }
                            
                        }
                    }
                