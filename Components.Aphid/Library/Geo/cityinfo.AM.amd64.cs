
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
                                    public const string Country = "AM";
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
                            
                                        var cur = (Math.Abs(39.63892 - lat) + Math.Abs(45.51111 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(39.82233 - lat) + Math.Abs(45.04169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90832 - lat) + Math.Abs(44.73328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83893 - lat) + Math.Abs(44.61951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76389 - lat) + Math.Abs(45.33239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.96515 - lat) + Math.Abs(44.55937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.88114 - lat) + Math.Abs(44.64917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79236 - lat) + Math.Abs(45.36389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53543 - lat) + Math.Abs(46.32063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91388 - lat) + Math.Abs(44.7251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6889 - lat) + Math.Abs(45.46668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55826 - lat) + Math.Abs(46.48054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38611 - lat) + Math.Abs(46.24451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79449 - lat) + Math.Abs(44.77508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90802 - lat) + Math.Abs(44.66721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4367 - lat) + Math.Abs(46.31787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87403 - lat) + Math.Abs(44.58678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94171 - lat) + Math.Abs(44.57233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83612 - lat) + Math.Abs(45.30292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55698 - lat) + Math.Abs(45.90727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76111 - lat) + Math.Abs(45.17792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83069 - lat) + Math.Abs(44.66949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97251 - lat) + Math.Abs(44.53565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90292 - lat) + Math.Abs(46.24458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74731 - lat) + Math.Abs(45.4057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50568 - lat) + Math.Abs(46.4361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20755 - lat) + Math.Abs(46.40576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84168 - lat) + Math.Abs(45.66949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51111 - lat) + Math.Abs(46.34168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68183 - lat) + Math.Abs(45.76149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7807 - lat) + Math.Abs(45.34729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76392 - lat) + Math.Abs(45.30829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27059 - lat) + Math.Abs(46.3572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97653 - lat) + Math.Abs(44.52649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99157 - lat) + Math.Abs(44.49681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53491 - lat) + Math.Abs(46.30732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49742 - lat) + Math.Abs(45.97241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9779 - lat) + Math.Abs(44.51672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95436 - lat) + Math.Abs(44.60229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95845 - lat) + Math.Abs(44.59981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87327 - lat) + Math.Abs(44.66984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.85553 - lat) + Math.Abs(44.65832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46405 - lat) + Math.Abs(45.97047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.96144 - lat) + Math.Abs(44.54447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87231 - lat) + Math.Abs(45.3501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76672 - lat) + Math.Abs(44.8111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71668 - lat) + Math.Abs(45.18329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83069 - lat) + Math.Abs(44.70569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56952 - lat) + Math.Abs(45.94452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78607 - lat) + Math.Abs(45.2279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.73608 - lat) + Math.Abs(45.35553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20684 - lat) + Math.Abs(46.5446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90008 - lat) + Math.Abs(44.6557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65973 - lat) + Math.Abs(43.89032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03332 - lat) + Math.Abs(44.18048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51111 - lat) + Math.Abs(44.4389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56671 - lat) + Math.Abs(44.79028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09168 - lat) + Math.Abs(44.39447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25848 - lat) + Math.Abs(44.73328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18111 - lat) + Math.Abs(44.51361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69505 - lat) + Math.Abs(43.74722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07233 - lat) + Math.Abs(44.21948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20428 - lat) + Math.Abs(45.19209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90302 - lat) + Math.Abs(44.63155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08893 - lat) + Math.Abs(44.16669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16557 - lat) + Math.Abs(44.29462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32507 - lat) + Math.Abs(44.48608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27508 - lat) + Math.Abs(44.30011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12081 - lat) + Math.Abs(45.06381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76426 - lat) + Math.Abs(43.77474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13068 - lat) + Math.Abs(45.25293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02434 - lat) + Math.Abs(44.59038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99731 - lat) + Math.Abs(44.58893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16838 - lat) + Math.Abs(44.75811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55548 - lat) + Math.Abs(44.90832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18329 - lat) + Math.Abs(45.73053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13348 - lat) + Math.Abs(45.44311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57549 - lat) + Math.Abs(45.39769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13611 - lat) + Math.Abs(45.33069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90698 - lat) + Math.Abs(44.60873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34729 - lat) + Math.Abs(44.37512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06778 - lat) + Math.Abs(44.39628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15959 - lat) + Math.Abs(45.46786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4751 - lat) + Math.Abs(45.05011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18254 - lat) + Math.Abs(45.63286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63348 - lat) + Math.Abs(44.96112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18048 - lat) + Math.Abs(44.27228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63428 - lat) + Math.Abs(44.22241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79849 - lat) + Math.Abs(44.10144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53259 - lat) + Math.Abs(44.72025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1382 - lat) + Math.Abs(45.19096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12072 - lat) + Math.Abs(44.28462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06952 - lat) + Math.Abs(44.07788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39172 - lat) + Math.Abs(43.87793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00995 - lat) + Math.Abs(44.38531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83221 - lat) + Math.Abs(44.26731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66105 - lat) + Math.Abs(44.01551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10712 - lat) + Math.Abs(44.05108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46252 - lat) + Math.Abs(44.70709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05829 - lat) + Math.Abs(44.38892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14693 - lat) + Math.Abs(44.84043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84042 - lat) + Math.Abs(43.91582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48328 - lat) + Math.Abs(44.38348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05548 - lat) + Math.Abs(43.93048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5473 - lat) + Math.Abs(44.94171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29169 - lat) + Math.Abs(45.13068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03531 - lat) + Math.Abs(45.14486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6709 - lat) + Math.Abs(43.87231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77487 - lat) + Math.Abs(44.2222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87043 - lat) + Math.Abs(44.21407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18516 - lat) + Math.Abs(44.24331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02789 - lat) + Math.Abs(44.36951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25568 - lat) + Math.Abs(44.58612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16388 - lat) + Math.Abs(44.36389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03888 - lat) + Math.Abs(44.06671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24731 - lat) + Math.Abs(44.41949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64026 - lat) + Math.Abs(44.04666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35553 - lat) + Math.Abs(44.52228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58612 - lat) + Math.Abs(43.94311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98248 - lat) + Math.Abs(45.36696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26392 - lat) + Math.Abs(44.31671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13206 - lat) + Math.Abs(44.00969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05321 - lat) + Math.Abs(44.61341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17244 - lat) + Math.Abs(44.99917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26672 - lat) + Math.Abs(44.65832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32233 - lat) + Math.Abs(44.58331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18886 - lat) + Math.Abs(44.33336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0013 - lat) + Math.Abs(44.59296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08612 - lat) + Math.Abs(43.99451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02228 - lat) + Math.Abs(44.42511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19733 - lat) + Math.Abs(44.3501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37793 - lat) + Math.Abs(45.18048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14172 - lat) + Math.Abs(45.27087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86695 - lat) + Math.Abs(45.34179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0639 - lat) + Math.Abs(43.98889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75767 - lat) + Math.Abs(43.99274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18329 - lat) + Math.Abs(44.25848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28607 - lat) + Math.Abs(44.54449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13068 - lat) + Math.Abs(44.08069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02857 - lat) + Math.Abs(44.55831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90534 - lat) + Math.Abs(45.48838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83472 - lat) + Math.Abs(44.11108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21948 - lat) + Math.Abs(45.76391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64376 - lat) + Math.Abs(44.05653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20156 - lat) + Math.Abs(44.22877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07233 - lat) + Math.Abs(44.29169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1814 - lat) + Math.Abs(44.40033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6723 - lat) + Math.Abs(43.95831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60611 - lat) + Math.Abs(44.65147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25293 - lat) + Math.Abs(44.63892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06542 - lat) + Math.Abs(44.41618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13892 - lat) + Math.Abs(45.30548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05829 - lat) + Math.Abs(44.47229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83486 - lat) + Math.Abs(43.7779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73381 - lat) + Math.Abs(44.68474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57507 - lat) + Math.Abs(43.87231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84715 - lat) + Math.Abs(43.83938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07637 - lat) + Math.Abs(45.25507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18726 - lat) + Math.Abs(44.0039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93717 - lat) + Math.Abs(44.77142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15933 - lat) + Math.Abs(45.23467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7882 - lat) + Math.Abs(44.16024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81538 - lat) + Math.Abs(44.39344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79532 - lat) + Math.Abs(44.27435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46676 - lat) + Math.Abs(44.79249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5625 - lat) + Math.Abs(43.9389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13611 - lat) + Math.Abs(44.24731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51947 - lat) + Math.Abs(44.93048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45569 - lat) + Math.Abs(45.07507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26947 - lat) + Math.Abs(45.14447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27789 - lat) + Math.Abs(44.66388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30011 - lat) + Math.Abs(44.16107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80456 - lat) + Math.Abs(44.4939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63721 - lat) + Math.Abs(44.14058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93668 - lat) + Math.Abs(45.1821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53697 - lat) + Math.Abs(44.41046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17048 - lat) + Math.Abs(45.57785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33069 - lat) + Math.Abs(44.37793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10444 - lat) + Math.Abs(45.28972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32507 - lat) + Math.Abs(44.70007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24739 - lat) + Math.Abs(44.53511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82572 - lat) + Math.Abs(43.95071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35398 - lat) + Math.Abs(45.12386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15701 - lat) + Math.Abs(44.09192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77482 - lat) + Math.Abs(44.54596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87877 - lat) + Math.Abs(45.14851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49748 - lat) + Math.Abs(44.7662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15446 - lat) + Math.Abs(44.03815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12231 - lat) + Math.Abs(44.37793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77614 - lat) + Math.Abs(44.96847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7942 - lat) + Math.Abs(43.84528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96715 - lat) + Math.Abs(44.47144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12793 - lat) + Math.Abs(44.41669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31091 - lat) + Math.Abs(45.67924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8046 - lat) + Math.Abs(44.54025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1861 - lat) + Math.Abs(44.26947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73053 - lat) + Math.Abs(45.00012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1347 - lat) + Math.Abs(44.78332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89255 - lat) + Math.Abs(44.19915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03844 - lat) + Math.Abs(44.56369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04449 - lat) + Math.Abs(43.94171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14587 - lat) + Math.Abs(44.43048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5625 - lat) + Math.Abs(44.88892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.11931 - lat) + Math.Abs(44.73442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54026 - lat) + Math.Abs(44.86962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39447 - lat) + Math.Abs(44.6861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72241 - lat) + Math.Abs(44.71769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20412 - lat) + Math.Abs(44.6415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16957 - lat) + Math.Abs(45.18337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50848 - lat) + Math.Abs(43.82092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79028 - lat) + Math.Abs(44.18664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05275 - lat) + Math.Abs(44.51259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0473 - lat) + Math.Abs(44.4751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04449 - lat) + Math.Abs(44.02789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01984 - lat) + Math.Abs(44.58376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9617 - lat) + Math.Abs(44.65003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56497 - lat) + Math.Abs(45.2367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22229 - lat) + Math.Abs(44.27228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7417 - lat) + Math.Abs(44.8501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57028 - lat) + Math.Abs(44.82295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83674 - lat) + Math.Abs(44.42494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2279 - lat) + Math.Abs(43.87793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18118 - lat) + Math.Abs(44.83217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59655 - lat) + Math.Abs(45.35498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45831 - lat) + Math.Abs(44.65008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31417 - lat) + Math.Abs(44.59333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33894 - lat) + Math.Abs(44.27275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45569 - lat) + Math.Abs(44.51947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20503 - lat) + Math.Abs(44.99967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88135 - lat) + Math.Abs(45.38901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86763 - lat) + Math.Abs(44.43978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01604 - lat) + Math.Abs(44.51889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10828 - lat) + Math.Abs(44.01947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25153 - lat) + Math.Abs(44.60828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24358 - lat) + Math.Abs(44.81737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71959 - lat) + Math.Abs(43.82727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80312 - lat) + Math.Abs(43.75173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68298 - lat) + Math.Abs(45.17634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00293 - lat) + Math.Abs(44.55829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23608 - lat) + Math.Abs(44.28888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07507 - lat) + Math.Abs(44.0611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14728 - lat) + Math.Abs(44.16669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97951 - lat) + Math.Abs(45.25033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15008 - lat) + Math.Abs(44.26672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12231 - lat) + Math.Abs(45.35553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2991 - lat) + Math.Abs(44.36204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33069 - lat) + Math.Abs(43.91669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2973 - lat) + Math.Abs(44.59869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45007 - lat) + Math.Abs(44.60828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2973 - lat) + Math.Abs(43.76672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16949 - lat) + Math.Abs(44.21393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37793 - lat) + Math.Abs(44.6001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15289 - lat) + Math.Abs(44.4389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0611 - lat) + Math.Abs(44.09448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65345 - lat) + Math.Abs(44.04419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03963 - lat) + Math.Abs(44.54179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7417 - lat) + Math.Abs(43.9043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1001 - lat) + Math.Abs(44.09448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86039 - lat) + Math.Abs(44.27438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14447 - lat) + Math.Abs(44.37512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16351 - lat) + Math.Abs(44.87631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13892 - lat) + Math.Abs(44.40289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04169 - lat) + Math.Abs(44.14728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78276 - lat) + Math.Abs(43.80583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25095 - lat) + Math.Abs(44.66351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05548 - lat) + Math.Abs(44.30292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.40289 - lat) + Math.Abs(44.54449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48889 - lat) + Math.Abs(44.3529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59323 - lat) + Math.Abs(44.3589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09729 - lat) + Math.Abs(44.25293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65008 - lat) + Math.Abs(43.98053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95442 - lat) + Math.Abs(43.7872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09766 - lat) + Math.Abs(44.67316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26672 - lat) + Math.Abs(44.6861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15886 - lat) + Math.Abs(45.72568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78003 - lat) + Math.Abs(43.90027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2333 - lat) + Math.Abs(44.25295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58195 - lat) + Math.Abs(44.69581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01072 - lat) + Math.Abs(44.46845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33069 - lat) + Math.Abs(44.07233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27368 - lat) + Math.Abs(44.63348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04851 - lat) + Math.Abs(44.54742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97083 - lat) + Math.Abs(44.50889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08533 - lat) + Math.Abs(44.57957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02787 - lat) + Math.Abs(44.52565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10553 - lat) + Math.Abs(44.43329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86056 - lat) + Math.Abs(44.15278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98204 - lat) + Math.Abs(45.18551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83947 - lat) + Math.Abs(45.47033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30011 - lat) + Math.Abs(44.38892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25012 - lat) + Math.Abs(44.34448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31472 - lat) + Math.Abs(45.11139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18048 - lat) + Math.Abs(43.91949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12512 - lat) + Math.Abs(43.96393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14447 - lat) + Math.Abs(44.1167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08444 - lat) + Math.Abs(44.30528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19452 - lat) + Math.Abs(44.36951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1557 - lat) + Math.Abs(44.37793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10553 - lat) + Math.Abs(44.41388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1001 - lat) + Math.Abs(44.39172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09168 - lat) + Math.Abs(44.4057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18701 - lat) + Math.Abs(45.19212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13367 - lat) + Math.Abs(44.19957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09551 - lat) + Math.Abs(44.28604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07233 - lat) + Math.Abs(44.30829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09729 - lat) + Math.Abs(44.34448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07507 - lat) + Math.Abs(44.40008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14172 - lat) + Math.Abs(44.33069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.11307 - lat) + Math.Abs(44.27169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22369 - lat) + Math.Abs(44.25409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1889 - lat) + Math.Abs(44.38611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02508 - lat) + Math.Abs(44.45007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00848 - lat) + Math.Abs(44.4917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02789 - lat) + Math.Abs(44.48328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03607 - lat) + Math.Abs(44.46948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zarrit’ap’", "10", 39.63892, 45.51111);
case 1: return new CityInfo("Zangakatun", "02", 39.82233, 45.04169);
case 2: return new CityInfo("Goravan", "02", 39.90832, 44.73328);
case 3: return new CityInfo("Yeghegnavan", "02", 39.83893, 44.61951);
case 4: return new CityInfo("Yeghegnadzor", "10", 39.76389, 45.33239);
case 5: return new CityInfo("Vostan", "02", 39.96515, 44.55937);
case 6: return new CityInfo("Vosketap’", "02", 39.88114, 44.64917);
case 7: return new CityInfo("Vernashen", "10", 39.79236, 45.36389);
case 8: return new CityInfo("Verishen", "08", 39.53543, 46.32063);
case 9: return new CityInfo("Vedi", "02", 39.91388, 44.7251);
case 10: return new CityInfo("Vayk’", "10", 39.6889, 45.46668);
case 11: return new CityInfo("Tegh", "08", 39.55826, 46.48054);
case 12: return new CityInfo("Tat’ev", "08", 39.38611, 46.24451);
case 13: return new CityInfo("Surenavan", "02", 39.79449, 44.77508);
case 14: return new CityInfo("Sisavan", "02", 39.90802, 44.66721);
case 15: return new CityInfo("Shinuhayr", "08", 39.4367, 46.31787);
case 16: return new CityInfo("Lusarrat", "02", 39.87403, 44.58678);
case 17: return new CityInfo("Shahumyan", "02", 39.94171, 44.57233);
case 18: return new CityInfo("Shatin", "10", 39.83612, 45.30292);
case 19: return new CityInfo("Shaghat", "08", 39.55698, 45.90727);
case 20: return new CityInfo("Rrind", "10", 39.76111, 45.17792);
case 21: return new CityInfo("Noyakert", "02", 39.83069, 44.66949);
case 22: return new CityInfo("Mrgavan", "02", 39.97251, 44.53565);
case 23: return new CityInfo("Meghri", "08", 38.90292, 46.24458);
case 24: return new CityInfo("Malishka", "10", 39.74731, 45.4057);
case 25: return new CityInfo("Khndzoresk", "08", 39.50568, 46.4361);
case 26: return new CityInfo("Kapan", "08", 39.20755, 46.40576);
case 27: return new CityInfo("Jermuk", "10", 39.84168, 45.66949);
case 28: return new CityInfo("Goris", "08", 39.51111, 46.34168);
case 29: return new CityInfo("Gorayk’", "08", 39.68183, 45.76149);
case 30: return new CityInfo("Gladzor", "10", 39.7807, 45.34729);
case 31: return new CityInfo("Getap’", "10", 39.76392, 45.30829);
case 32: return new CityInfo("Dzorastan", "08", 39.27059, 46.3572);
case 33: return new CityInfo("Dalar", "02", 39.97653, 44.52649);
case 34: return new CityInfo("Burastan", "02", 39.99157, 44.49681);
case 35: return new CityInfo("Akner", "08", 39.53491, 46.30732);
case 36: return new CityInfo("Brrnakot’", "08", 39.49742, 45.97241);
case 37: return new CityInfo("Berk’anush", "02", 39.9779, 44.51672);
case 38: return new CityInfo("Aygezard", "02", 39.95436, 44.60229);
case 39: return new CityInfo("Aygepat", "02", 39.95845, 44.59981);
case 40: return new CityInfo("Aygavan", "02", 39.87327, 44.66984);
case 41: return new CityInfo("Avshar", "02", 39.85553, 44.65832);
case 42: return new CityInfo("Hats’avan", "08", 39.46405, 45.97047);
case 43: return new CityInfo("Artashat", "02", 39.96144, 44.54447);
case 44: return new CityInfo("Yeghegis", "10", 39.87231, 45.3501);
case 45: return new CityInfo("Armash", "02", 39.76672, 44.8111);
case 46: return new CityInfo("Areni", "10", 39.71668, 45.18329);
case 47: return new CityInfo("Ararat", "02", 39.83069, 44.70569);
case 48: return new CityInfo("Angeghakot’", "08", 39.56952, 45.94452);
case 49: return new CityInfo("Aghavnadzor", "10", 39.78607, 45.2279);
case 50: return new CityInfo("Agarakadzor", "10", 39.73608, 45.35553);
case 51: return new CityInfo("Agarak", "08", 39.20684, 46.5446);
case 52: return new CityInfo("Aralez", "02", 39.90008, 44.6557);
case 53: return new CityInfo("Horrom", "07", 40.65973, 43.89032);
case 54: return new CityInfo("Margara", "03", 40.03332, 44.18048);
case 55: return new CityInfo("Zovuni", "01", 40.51111, 44.4389);
case 56: return new CityInfo("Zovaber", "05", 40.56671, 44.79028);
case 57: return new CityInfo("Zorak", "02", 40.09168, 44.39447);
case 58: return new CityInfo("Zarr", "05", 40.25848, 44.73328);
case 59: return new CityInfo("Yerevan", "11", 40.18111, 44.51361);
case 60: return new CityInfo("Yerazgavors", "07", 40.69505, 43.74722);
case 61: return new CityInfo("Yeraskhahun", "03", 40.07233, 44.21948);
case 62: return new CityInfo("Yeranos", "04", 40.20428, 45.19209);
case 63: return new CityInfo("Yeghegnut", "06", 40.90302, 44.63155);
case 64: return new CityInfo("Yeghegnut", "03", 40.08893, 44.16669);
case 65: return new CityInfo("Vagharshapat", "03", 40.16557, 44.29462);
case 66: return new CityInfo("Yeghvard", "05", 40.32507, 44.48608);
case 67: return new CityInfo("Voskevaz", "01", 40.27508, 44.30011);
case 68: return new CityInfo("Voskevan", "09", 41.12081, 45.06381);
case 69: return new CityInfo("Voskehask", "07", 40.76426, 43.77474);
case 70: return new CityInfo("Verin Getashen", "04", 40.13068, 45.25293);
case 71: return new CityInfo("Verin Dvin", "02", 40.02434, 44.59038);
case 72: return new CityInfo("Verin Artashat", "02", 39.99731, 44.58893);
case 73: return new CityInfo("Akht’ala", "06", 41.16838, 44.75811);
case 74: return new CityInfo("Varser", "04", 40.55548, 44.90832);
case 75: return new CityInfo("Vardenis", "04", 40.18329, 45.73053);
case 76: return new CityInfo("Vardenik", "04", 40.13348, 45.44311);
case 77: return new CityInfo("Vahan", "04", 40.57549, 45.39769);
case 78: return new CityInfo("Vaghashen", "04", 40.13611, 45.33069);
case 79: return new CityInfo("Vahagni", "06", 40.90698, 44.60873);
case 80: return new CityInfo("Ushi", "01", 40.34729, 44.37512);
case 81: return new CityInfo("Urrut", "06", 41.06778, 44.39628);
case 82: return new CityInfo("Tsovinar", "04", 40.15959, 45.46786);
case 83: return new CityInfo("Tsovazard", "04", 40.4751, 45.05011);
case 84: return new CityInfo("Tsovak", "04", 40.18254, 45.63286);
case 85: return new CityInfo("Tsovagyugh", "04", 40.63348, 44.96112);
case 86: return new CityInfo("Tsaghkunk’", "03", 40.18048, 44.27228);
case 87: return new CityInfo("Tsaghkahovit", "01", 40.63428, 44.22241);
case 88: return new CityInfo("Tsaghkaber", "06", 40.79849, 44.10144);
case 89: return new CityInfo("Tsaghkadzor", "05", 40.53259, 44.72025);
case 90: return new CityInfo("Tsovasar", "04", 40.1382, 45.19096);
case 91: return new CityInfo("Tashir", "06", 41.12072, 44.28462);
case 92: return new CityInfo("Tandzut", "03", 40.06952, 44.07788);
case 93: return new CityInfo("T’alin", "01", 40.39172, 43.87793);
case 94: return new CityInfo("Step’anavan", "06", 41.00995, 44.38531);
case 95: return new CityInfo("Spitak", "06", 40.83221, 44.26731);
case 96: return new CityInfo("Spandaryan", "07", 40.66105, 44.01551);
case 97: return new CityInfo("Alashkert", "03", 40.10712, 44.05108);
case 98: return new CityInfo("Solak", "05", 40.46252, 44.70709);
case 99: return new CityInfo("Sis", "02", 40.05829, 44.38892);
case 100: return new CityInfo("Shnogh", "06", 41.14693, 44.84043);
case 101: return new CityInfo("Shirak", "07", 40.84042, 43.91582);
case 102: return new CityInfo("Shenavan", "01", 40.48328, 44.38348);
case 103: return new CityInfo("Shenavan", "03", 40.05548, 43.93048);
case 104: return new CityInfo("Sevan", "04", 40.5473, 44.94171);
case 105: return new CityInfo("Sarukhan", "04", 40.29169, 45.13068);
case 106: return new CityInfo("Sarigyugh", "09", 41.03531, 45.14486);
case 107: return new CityInfo("Saratak", "07", 40.6709, 43.87231);
case 108: return new CityInfo("Saramej", "06", 40.77487, 44.2222);
case 109: return new CityInfo("Sarahart’", "06", 40.87043, 44.21407);
case 110: return new CityInfo("Geghakert", "03", 40.18516, 44.24331);
case 111: return new CityInfo("Rranch’par", "02", 40.02789, 44.36951);
case 112: return new CityInfo("Ptghni", "05", 40.25568, 44.58612);
case 113: return new CityInfo("Ptghunk’", "03", 40.16388, 44.36389);
case 114: return new CityInfo("P’shatavan", "03", 40.03888, 44.06671);
case 115: return new CityInfo("Prroshyan", "05", 40.24731, 44.41949);
case 116: return new CityInfo("P’ok’r Mant’ash", "07", 40.64026, 44.04666);
case 117: return new CityInfo("Zoravan", "05", 40.35553, 44.52228);
case 118: return new CityInfo("Pemzashen", "07", 40.58612, 43.94311);
case 119: return new CityInfo("Parravak’ar", "09", 40.98248, 45.36696);
case 120: return new CityInfo("Oshakan", "01", 40.26392, 44.31671);
case 121: return new CityInfo("Sardarapat", "03", 40.13206, 44.00969);
case 122: return new CityInfo("Odzun", "06", 41.05321, 44.61341);
case 123: return new CityInfo("Noyemberyan", "09", 41.17244, 44.99917);
case 124: return new CityInfo("Nor Gyugh", "05", 40.26672, 44.65832);
case 125: return new CityInfo("Nor Geghi", "05", 40.32233, 44.58331);
case 126: return new CityInfo("Norashen", "06", 41.18886, 44.33336);
case 127: return new CityInfo("Norashen", "02", 40.0013, 44.59296);
case 128: return new CityInfo("Nor Armavir", "03", 40.08612, 43.99451);
case 129: return new CityInfo("Noramarg", "02", 40.02228, 44.42511);
case 130: return new CityInfo("Norakert", "03", 40.19733, 44.3501);
case 131: return new CityInfo("Noratus", "04", 40.37793, 45.18048);
case 132: return new CityInfo("Nerk’in Getashen", "04", 40.14172, 45.27087);
case 133: return new CityInfo("Navur", "09", 40.86695, 45.34179);
case 134: return new CityInfo("Nalbandyan", "03", 40.0639, 43.98889);
case 135: return new CityInfo("Basen", "07", 40.75767, 43.99274);
case 136: return new CityInfo("Hovtamej", "03", 40.18329, 44.25848);
case 137: return new CityInfo("Mrgashen", "05", 40.28607, 44.54449);
case 138: return new CityInfo("Mrgashat", "03", 40.13068, 44.08069);
case 139: return new CityInfo("Mrganush", "02", 40.02857, 44.55831);
case 140: return new CityInfo("Mosesgegh", "09", 40.90534, 45.48838);
case 141: return new CityInfo("Mets Parni", "06", 40.83472, 44.11108);
case 142: return new CityInfo("Mets Masrik", "04", 40.21948, 45.76391);
case 143: return new CityInfo("Mets Mant’ash", "07", 40.64376, 44.05653);
case 144: return new CityInfo("Metsavan", "06", 41.20156, 44.22877);
case 145: return new CityInfo("Metsamor", "03", 40.07233, 44.29169);
case 146: return new CityInfo("Merdzavan", "03", 40.1814, 44.40033);
case 147: return new CityInfo("Meghrashen", "07", 40.6723, 43.95831);
case 148: return new CityInfo("Meghradzor", "05", 40.60611, 44.65147);
case 149: return new CityInfo("Mayakovski", "05", 40.25293, 44.63892);
case 150: return new CityInfo("Masis", "02", 40.06542, 44.41618);
case 151: return new CityInfo("Martuni", "04", 40.13892, 45.30548);
case 152: return new CityInfo("Marmarashen", "02", 40.05829, 44.47229);
case 153: return new CityInfo("Marmashen", "07", 40.83486, 43.7779);
case 154: return new CityInfo("Margahovit", "06", 40.73381, 44.68474);
case 155: return new CityInfo("Maralik", "07", 40.57507, 43.87231);
case 156: return new CityInfo("Mayisyan", "07", 40.84715, 43.83938);
case 157: return new CityInfo("Madina", "04", 40.07637, 45.25507);
case 158: return new CityInfo("Lukashin", "03", 40.18726, 44.0039);
case 159: return new CityInfo("Lorut", "06", 40.93717, 44.77142);
case 160: return new CityInfo("Lichk’", "04", 40.15933, 45.23467);
case 161: return new CityInfo("Lerrnavan", "06", 40.7882, 44.16024);
case 162: return new CityInfo("Lerrnapat", "06", 40.81538, 44.39344);
case 163: return new CityInfo("Lerrnants’k’", "06", 40.79532, 44.27435);
case 164: return new CityInfo("Lerrnanist", "05", 40.46676, 44.79249);
case 165: return new CityInfo("Lerrnakert", "07", 40.5625, 43.9389);
case 166: return new CityInfo("Khoronk’", "03", 40.13611, 44.24731);
case 167: return new CityInfo("Lchashen", "04", 40.51947, 44.93048);
case 168: return new CityInfo("Lchap’", "04", 40.45569, 45.07507);
case 169: return new CityInfo("Lanjaghbyur", "04", 40.26947, 45.14447);
case 170: return new CityInfo("Kotayk’", "05", 40.27789, 44.66388);
case 171: return new CityInfo("Kosh", "01", 40.30011, 44.16107);
case 172: return new CityInfo("Vanadzor", "06", 40.80456, 44.4939);
case 173: return new CityInfo("Hnaberd", "01", 40.63721, 44.14058);
case 174: return new CityInfo("Khasht’arrak", "09", 40.93668, 45.1821);
case 175: return new CityInfo("Kasakh", "01", 40.53697, 44.41046);
case 176: return new CityInfo("Karchaghbyur", "04", 40.17048, 45.57785);
case 177: return new CityInfo("Karbi", "01", 40.33069, 44.37793);
case 178: return new CityInfo("Karanlukh", "04", 40.10444, 45.28972);
case 179: return new CityInfo("Kaputan", "05", 40.32507, 44.70007);
case 180: return new CityInfo("K’anak’erravan", "11", 40.24739, 44.53511);
case 181: return new CityInfo("Kamo", "07", 40.82572, 43.95071);
case 182: return new CityInfo("Gavarr", "04", 40.35398, 45.12386);
case 183: return new CityInfo("Mayisyan", "03", 40.15701, 44.09192);
case 184: return new CityInfo("Shahumyan", "06", 40.77482, 44.54596);
case 185: return new CityInfo("Ijevan", "09", 40.87877, 45.14851);
case 186: return new CityInfo("Hrazdan", "05", 40.49748, 44.7662);
case 187: return new CityInfo("Armavir", "03", 40.15446, 44.03815);
case 188: return new CityInfo("Hayanist", "02", 40.12231, 44.37793);
case 189: return new CityInfo("Haghartsin", "09", 40.77614, 44.96847);
case 190: return new CityInfo("Gyumri", "07", 40.7942, 43.84528);
case 191: return new CityInfo("Gyulagarak", "06", 40.96715, 44.47144);
case 192: return new CityInfo("Ghukasavan", "02", 40.12793, 44.41669);
case 193: return new CityInfo("Geghamasar", "04", 40.31091, 45.67924);
case 194: return new CityInfo("Gugark’", "06", 40.8046, 44.54025);
case 195: return new CityInfo("Tsiatsan", "03", 40.1861, 44.26947);
case 196: return new CityInfo("Gosh", "09", 40.73053, 45.00012);
case 197: return new CityInfo("Goght’", "05", 40.1347, 44.78332);
case 198: return new CityInfo("Gogaran", "06", 40.89255, 44.19915);
case 199: return new CityInfo("Getazat", "02", 40.03844, 44.56369);
case 200: return new CityInfo("Getashen", "03", 40.04449, 43.94171);
case 201: return new CityInfo("Geghanist", "03", 40.14587, 44.43048);
case 202: return new CityInfo("Geghamavan", "04", 40.5625, 44.88892);
case 203: return new CityInfo("Garrni", "05", 40.11931, 44.73442);
case 204: return new CityInfo("Gagarin", "04", 40.54026, 44.86962);
case 205: return new CityInfo("Fantan", "05", 40.39447, 44.6861);
case 206: return new CityInfo("Fioletovo", "06", 40.72241, 44.71769);
case 207: return new CityInfo("Dzoraghbyur", "05", 40.20412, 44.6415);
case 208: return new CityInfo("Dzoragyugh", "04", 40.16957, 45.18337);
case 209: return new CityInfo("Dzit’hank’ov", "07", 40.50848, 43.82092);
case 210: return new CityInfo("Jrashen", "06", 40.79028, 44.18664);
case 211: return new CityInfo("Jrashen", "11", 40.05275, 44.51259);
case 212: return new CityInfo("Jrahovit", "02", 40.0473, 44.4751);
case 213: return new CityInfo("Janfida", "03", 40.04449, 44.02789);
case 214: return new CityInfo("Dvin", "02", 40.01984, 44.58376);
case 215: return new CityInfo("Dsegh", "06", 40.9617, 44.65003);
case 216: return new CityInfo("Drakhtik", "04", 40.56497, 45.2367);
case 217: return new CityInfo("Doghs", "03", 40.22229, 44.27228);
case 218: return new CityInfo("Dilijan", "09", 40.7417, 44.8501);
case 219: return new CityInfo("Ddmashen", "04", 40.57028, 44.82295);
case 220: return new CityInfo("Darpas", "06", 40.83674, 44.42494);
case 221: return new CityInfo("Dalarik", "03", 40.2279, 43.87793);
case 222: return new CityInfo("Chochkan", "06", 41.18118, 44.83217);
case 223: return new CityInfo("Chambarak", "04", 40.59655, 45.35498);
case 224: return new CityInfo("Bjni", "05", 40.45831, 44.65008);
case 225: return new CityInfo("Byureghavan", "05", 40.31417, 44.59333);
case 226: return new CityInfo("Byurakan", "01", 40.33894, 44.27275);
case 227: return new CityInfo("Buzhakan", "05", 40.45569, 44.51947);
case 228: return new CityInfo("Berdavan", "09", 41.20503, 44.99967);
case 229: return new CityInfo("Berd", "09", 40.88135, 45.38901);
case 230: return new CityInfo("Bazum", "06", 40.86763, 44.43978);
case 231: return new CityInfo("Byuravan", "02", 40.01604, 44.51889);
case 232: return new CityInfo("Bambakashat", "03", 40.10828, 44.01947);
case 233: return new CityInfo("Balahovit", "05", 40.25153, 44.60828);
case 234: return new CityInfo("Bagratashen", "09", 41.24358, 44.81737);
case 235: return new CityInfo("Azatan", "07", 40.71959, 43.82727);
case 236: return new CityInfo("Haykavan", "07", 40.80312, 43.75173);
case 237: return new CityInfo("Aygut", "04", 40.68298, 45.17634);
case 238: return new CityInfo("Aygestan", "02", 40.00293, 44.55829);
case 239: return new CityInfo("Aygeshat", "03", 40.23608, 44.28888);
case 240: return new CityInfo("Aygeshat", "03", 40.07507, 44.0611);
case 241: return new CityInfo("Aknalich", "03", 40.14728, 44.16669);
case 242: return new CityInfo("Aygehovit", "09", 40.97951, 45.25033);
case 243: return new CityInfo("Artimet", "03", 40.15008, 44.26672);
case 244: return new CityInfo("Astghadzor", "04", 40.12231, 45.35553);
case 245: return new CityInfo("Ashtarak", "01", 40.2991, 44.36204);
case 246: return new CityInfo("Ashnak", "01", 40.33069, 43.91669);
case 247: return new CityInfo("Arzni", "05", 40.2973, 44.59869);
case 248: return new CityInfo("Arzakan", "05", 40.45007, 44.60828);
case 249: return new CityInfo("Arteni", "01", 40.2973, 43.76672);
case 250: return new CityInfo("Arshaluys", "03", 40.16949, 44.21393);
case 251: return new CityInfo("Argel", "05", 40.37793, 44.6001);
case 252: return new CityInfo("Argavand", "11", 40.15289, 44.4389);
case 253: return new CityInfo("Argavand", "03", 40.0611, 44.09448);
case 254: return new CityInfo("Arevshat", "07", 40.65345, 44.04419);
case 255: return new CityInfo("Arevshat", "02", 40.03963, 44.54179);
case 256: return new CityInfo("Arevik", "07", 40.7417, 43.9043);
case 257: return new CityInfo("Arevik", "03", 40.1001, 44.09448);
case 258: return new CityInfo("Arevashogh", "06", 40.86039, 44.27438);
case 259: return new CityInfo("Arevashat", "03", 40.14447, 44.37512);
case 260: return new CityInfo("Archis", "09", 41.16351, 44.87631);
case 261: return new CityInfo("Arbat’", "03", 40.13892, 44.40289);
case 262: return new CityInfo("Arazap’", "03", 40.04169, 44.14728);
case 263: return new CityInfo("Arrap’i", "07", 40.78276, 43.80583);
case 264: return new CityInfo("Aramus", "05", 40.25095, 44.66351);
case 265: return new CityInfo("Arak’s", "03", 40.05548, 44.30292);
case 266: return new CityInfo("Aragyugh", "05", 40.40289, 44.54449);
case 267: return new CityInfo("Aragats", "01", 40.48889, 44.3529);
case 268: return new CityInfo("Aparan", "01", 40.59323, 44.3589);
case 269: return new CityInfo("Apaga", "03", 40.09729, 44.25293);
case 270: return new CityInfo("Anushavan", "07", 40.65008, 43.98053);
case 271: return new CityInfo("Amasia", "07", 40.95442, 43.7872);
case 272: return new CityInfo("Alaverdi", "06", 41.09766, 44.67316);
case 273: return new CityInfo("Akunk’", "05", 40.26672, 44.6861);
case 274: return new CityInfo("Akunk’", "04", 40.15886, 45.72568);
case 275: return new CityInfo("Akhuryan", "07", 40.78003, 43.90027);
case 276: return new CityInfo("Aghavnatun", "03", 40.2333, 44.25295);
case 277: return new CityInfo("Aghavnadzor", "05", 40.58195, 44.69581);
case 278: return new CityInfo("Agarak", "06", 41.01072, 44.46845);
case 279: return new CityInfo("Agarakavan", "01", 40.33069, 44.07233);
case 280: return new CityInfo("Abovyan", "05", 40.27368, 44.63348);
case 281: return new CityInfo("Abovyan", "02", 40.04851, 44.54742);
case 282: return new CityInfo("Vardablur", "06", 40.97083, 44.50889);
case 283: return new CityInfo("Bardzrashen", "02", 40.08533, 44.57957);
case 284: return new CityInfo("Nshavan", "02", 40.02787, 44.52565);
case 285: return new CityInfo("Norabats’", "02", 40.10553, 44.43329);
case 286: return new CityInfo("Shirakamut", "06", 40.86056, 44.15278);
case 287: return new CityInfo("Azatamut", "09", 40.98204, 45.18551);
case 288: return new CityInfo("Artsvaberd", "09", 40.83947, 45.47033);
case 289: return new CityInfo("Nor Yerznka", "01", 40.30011, 44.38892);
case 290: return new CityInfo("Sasunik", "01", 40.25012, 44.34448);
case 291: return new CityInfo("Gandzak", "04", 40.31472, 45.11139);
case 292: return new CityInfo("Myasnikyan", "03", 40.18048, 43.91949);
case 293: return new CityInfo("Lenughi", "03", 40.12512, 43.96393);
case 294: return new CityInfo("Metsamor", "03", 40.14447, 44.1167);
case 295: return new CityInfo("Gay", "03", 40.08444, 44.30528);
case 296: return new CityInfo("Baghramyan", "03", 40.19452, 44.36951);
case 297: return new CityInfo("Musalerr", "03", 40.1557, 44.37793);
case 298: return new CityInfo("Darakert", "02", 40.10553, 44.41388);
case 299: return new CityInfo("Dashtavan", "02", 40.1001, 44.39172);
case 300: return new CityInfo("Nizami", "02", 40.09168, 44.4057);
case 301: return new CityInfo("Vardadzor", "11", 40.18701, 45.19212);
case 302: return new CityInfo("Taronik", "03", 40.13367, 44.19957);
case 303: return new CityInfo("Aknashen", "03", 40.09551, 44.28604);
case 304: return new CityInfo("Haykashen", "03", 40.07233, 44.30829);
case 305: return new CityInfo("Hovtashat", "02", 40.09729, 44.34448);
case 306: return new CityInfo("Sayat’-Nova", "02", 40.07507, 44.40008);
case 307: return new CityInfo("Voskehat", "03", 40.14172, 44.33069);
case 308: return new CityInfo("Griboyedov", "03", 40.11307, 44.27169);
case 309: return new CityInfo("Gmbet’", "03", 40.22369, 44.25409);
case 310: return new CityInfo("Aygek", "03", 40.1889, 44.38611);
case 311: return new CityInfo("Hovtashen", "02", 40.02508, 44.45007);
case 312: return new CityInfo("Dimitrov", "02", 40.00848, 44.4917);
case 313: return new CityInfo("Mrgavet", "02", 40.02789, 44.48328);
default: return new CityInfo("Arevabuyr", "02", 40.03607, 44.46948);

                                    }                                        
                                }
                            
                        }
                    }
                