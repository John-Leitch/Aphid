
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
                                    public const string Country = "UG";
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
                            
                                        var cur = (Math.Abs(2.51355 - lat) + Math.Abs(30.90909 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(3.46506 - lat) + Math.Abs(31.24689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.72833 - lat) + Math.Abs(32.51222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.40444 - lat) + Math.Abs(32.45944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.69299 - lat) + Math.Abs(34.18085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.71464 - lat) + Math.Abs(33.61113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.23132 - lat) + Math.Abs(34.24773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.49417 - lat) + Math.Abs(33.45528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.07722 - lat) + Math.Abs(31.45667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.84111 - lat) + Math.Abs(29.94194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.29889 - lat) + Math.Abs(30.13361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.18833 - lat) + Math.Abs(29.84611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.72 - lat) + Math.Abs(31.48389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.145 - lat) + Math.Abs(33.70944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.41669 - lat) + Math.Abs(30.98551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.80056 - lat) + Math.Abs(33.135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.9 - lat) + Math.Abs(30.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.88333 - lat) + Math.Abs(29.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.87944 - lat) + Math.Abs(30.26417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.04111 - lat) + Math.Abs(30.48111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.358 - lat) + Math.Abs(30.43136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.44166 - lat) + Math.Abs(33.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.43139 - lat) + Math.Abs(33.77722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.47826 - lat) + Math.Abs(31.08893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.83611 - lat) + Math.Abs(33.68611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.68944 - lat) + Math.Abs(32.42139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.30889 - lat) + Math.Abs(32.45639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.75167 - lat) + Math.Abs(32.385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.35333 - lat) + Math.Abs(32.75528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.93806 - lat) + Math.Abs(30.75944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.55849 - lat) + Math.Abs(31.39489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.225 - lat) + Math.Abs(32.31361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.66088 - lat) + Math.Abs(31.72474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.53453 - lat) + Math.Abs(34.66659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.4175 - lat) + Math.Abs(32.02278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.68417 - lat) + Math.Abs(30.07 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.60467 - lat) + Math.Abs(30.64851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.08209 - lat) + Math.Abs(34.17503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.45972 - lat) + Math.Abs(33.48028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.69606 - lat) + Math.Abs(32.08608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.67444 - lat) + Math.Abs(31.715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.33379 - lat) + Math.Abs(31.73409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.27042 - lat) + Math.Abs(30.95532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.40306 - lat) + Math.Abs(31.15722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.41611 - lat) + Math.Abs(31.40806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.84917 - lat) + Math.Abs(32.47306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.36788 - lat) + Math.Abs(32.9376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.2499 - lat) + Math.Abs(32.89985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.61556 - lat) + Math.Abs(31.5175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.63278 - lat) + Math.Abs(30.62139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.50222 - lat) + Math.Abs(31.04139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.46083 - lat) + Math.Abs(33.93611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.98056 - lat) + Math.Abs(34.13306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.41364 - lat) + Math.Abs(30.95994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.27833 - lat) + Math.Abs(32.88667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.28538 - lat) + Math.Abs(29.68497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.87633 - lat) + Math.Abs(32.06225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.19664 - lat) + Math.Abs(30.84446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.3475 - lat) + Math.Abs(32.64917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.19835 - lat) + Math.Abs(30.01302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.6162 - lat) + Math.Abs(31.3089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.04333 - lat) + Math.Abs(33.7975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.91611 - lat) + Math.Abs(31.77417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.62602 - lat) + Math.Abs(30.43594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.47722 - lat) + Math.Abs(30.1925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.8 - lat) + Math.Abs(31.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.7025 - lat) + Math.Abs(32.88861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.89111 - lat) + Math.Abs(33.96611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.18333 - lat) + Math.Abs(30.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.61667 - lat) + Math.Abs(31.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.40096 - lat) + Math.Abs(34.45038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.9575 - lat) + Math.Abs(29.78972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.17722 - lat) + Math.Abs(31.88111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.1866 - lat) + Math.Abs(30.45393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.94722 - lat) + Math.Abs(33.11972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.31628 - lat) + Math.Abs(32.58219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.16969 - lat) + Math.Abs(31.75847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.89444 - lat) + Math.Abs(33.49944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.30889 - lat) + Math.Abs(32.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.78056 - lat) + Math.Abs(31.32361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.21548 - lat) + Math.Abs(32.53453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.93778 - lat) + Math.Abs(30.80889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.73889 - lat) + Math.Abs(33.15944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.24857 - lat) + Math.Abs(29.98993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.48361 - lat) + Math.Abs(34.14917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.43902 - lat) + Math.Abs(33.20317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.60917 - lat) + Math.Abs(33.46861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.13398 - lat) + Math.Abs(30.49616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.43314 - lat) + Math.Abs(31.35241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.77457 - lat) + Math.Abs(32.29899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.20333 - lat) + Math.Abs(32.08806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.66174 - lat) + Math.Abs(30.2748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.05621 - lat) + Math.Abs(32.47949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.89833 - lat) + Math.Abs(33.1775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.7425 - lat) + Math.Abs(31.40639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.59167 - lat) + Math.Abs(30.62861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.35773 - lat) + Math.Abs(32.66332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.15167 - lat) + Math.Abs(33.155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.64996 - lat) + Math.Abs(33.17128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.19417 - lat) + Math.Abs(33.92222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.91194 - lat) + Math.Abs(33.95111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.46588 - lat) + Math.Abs(34.09221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.53695 - lat) + Math.Abs(30.18579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.77725 - lat) + Math.Abs(33.62364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.90611 - lat) + Math.Abs(34.35778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.71117 - lat) + Math.Abs(30.06469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.11781 - lat) + Math.Abs(31.41163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.16667 - lat) + Math.Abs(34.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.25917 - lat) + Math.Abs(34.75389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.15778 - lat) + Math.Abs(31.60417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.31694 - lat) + Math.Abs(34.05056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.3375 - lat) + Math.Abs(33.01056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.57139 - lat) + Math.Abs(33.74167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.48213 - lat) + Math.Abs(33.24065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.01118 - lat) + Math.Abs(34.33112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.00389 - lat) + Math.Abs(33.92556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.41667 - lat) + Math.Abs(34.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.02013 - lat) + Math.Abs(30.91105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.97556 - lat) + Math.Abs(32.53861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.00361 - lat) + Math.Abs(33.65111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.95 - lat) + Math.Abs(34.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.61556 - lat) + Math.Abs(32.83972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.24472 - lat) + Math.Abs(33.25472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.37786 - lat) + Math.Abs(31.7909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.70167 - lat) + Math.Abs(33.67611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.91667 - lat) + Math.Abs(34.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.05 - lat) + Math.Abs(33.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.41861 - lat) + Math.Abs(29.89111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.63422 - lat) + Math.Abs(32.00106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.86864 - lat) + Math.Abs(30.83019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.97842 - lat) + Math.Abs(34.3743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.235 - lat) + Math.Abs(32.38495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.81388 - lat) + Math.Abs(31.93868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.23983 - lat) + Math.Abs(33.88491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.22215 - lat) + Math.Abs(33.20608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.20061 - lat) + Math.Abs(31.80063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.40015 - lat) + Math.Abs(32.80034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.50038 - lat) + Math.Abs(33.50065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.25139 - lat) + Math.Abs(34.25012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.70076 - lat) + Math.Abs(33.3002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.35027 - lat) + Math.Abs(30.30029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.83383 - lat) + Math.Abs(33.33361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.52972 - lat) + Math.Abs(32.8016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.20994 - lat) + Math.Abs(32.58511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.32467 - lat) + Math.Abs(32.5747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.48695 - lat) + Math.Abs(32.47938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.56925 - lat) + Math.Abs(29.69516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zombo", "N", 2.51355, 30.90909);
case 1: return new CityInfo("Yumbe", "N", 3.46506, 31.24689);
case 2: return new CityInfo("Wobulenzi", "C", 0.72833, 32.51222);
case 3: return new CityInfo("Wakiso", "C", 0.40444, 32.45944);
case 4: return new CityInfo("Tororo", "E", 0.69299, 34.18085);
case 5: return new CityInfo("Soroti", "E", 1.71464, 33.61113);
case 6: return new CityInfo("Sironko", "E", 1.23132, 34.24773);
case 7: return new CityInfo("Serere", "E", 1.49417, 33.45528);
case 8: return new CityInfo("Sembabule", "C", -0.07722, 31.45667);
case 9: return new CityInfo("Rukungiri", "W", -0.84111, 29.94194);
case 10: return new CityInfo("Rubirizi", "W", -0.29889, 30.13361);
case 11: return new CityInfo("Rubanda", "W", -1.18833, 29.84611);
case 12: return new CityInfo("Rakai", "C", -0.72, 31.48389);
case 13: return new CityInfo("Pallisa", "E", 1.145, 33.70944);
case 14: return new CityInfo("Paidha", "N", 2.41669, 30.98551);
case 15: return new CityInfo("Pader Palwo", "N", 2.80056, 33.135);
case 16: return new CityInfo("Nyachera", "W", -0.9, 30.41667);
case 17: return new CityInfo("Ntungamo", "W", -0.88333, 29.65);
case 18: return new CityInfo("Ntungamo", "W", -0.87944, 30.26417);
case 19: return new CityInfo("Ntoroko", "W", 1.04111, 30.48111);
case 20: return new CityInfo("Nsika", "W", -0.358, 30.43136);
case 21: return new CityInfo("Njeru", "C", 0.44166, 33.17917);
case 22: return new CityInfo("Ngora", "E", 1.43139, 33.77722);
case 23: return new CityInfo("Nebbi", "N", 2.47826, 31.08893);
case 24: return new CityInfo("Namutumba", "E", 0.83611, 33.68611);
case 25: return new CityInfo("Namasuba", "C", 0.68944, 32.42139);
case 26: return new CityInfo("Nakasongola", "C", 1.30889, 32.45639);
case 27: return new CityInfo("Nakaseke", "C", 0.75167, 32.385);
case 28: return new CityInfo("Mukono", "C", 0.35333, 32.75528);
case 29: return new CityInfo("Muhororo", "W", 0.93806, 30.75944);
case 30: return new CityInfo("Mubende", "C", 0.55849, 31.39489);
case 31: return new CityInfo("Mpigi", "C", 0.225, 32.31361);
case 32: return new CityInfo("Moyo", "N", 3.66088, 31.72474);
case 33: return new CityInfo("Moroto", "N", 2.53453, 34.66659);
case 34: return new CityInfo("Mityana", "C", 0.4175, 32.02278);
case 35: return new CityInfo("Mitoma", "W", -0.68417, 30.07);
case 36: return new CityInfo("Mbarara", "W", -0.60467, 30.64851);
case 37: return new CityInfo("Mbale", "E", 1.08209, 34.17503);
case 38: return new CityInfo("Mayuge", "E", 0.45972, 33.48028);
case 39: return new CityInfo("Masindi Port", "W", 1.69606, 32.08608);
case 40: return new CityInfo("Masindi", "W", 1.67444, 31.715);
case 41: return new CityInfo("Masaka", "C", -0.33379, 31.73409);
case 42: return new CityInfo("Maracha", "N", 3.27042, 30.95532);
case 43: return new CityInfo("Lyantonde", "C", -0.40306, 31.15722);
case 44: return new CityInfo("Lwengo", "C", -0.41611, 31.40806);
case 45: return new CityInfo("Luwero", "C", 0.84917, 32.47306);
case 46: return new CityInfo("Lugazi", "C", 0.36788, 32.9376);
case 47: return new CityInfo("Lira", "N", 2.2499, 32.89985);
case 48: return new CityInfo("Kyotera", "C", -0.61556, 31.5175);
case 49: return new CityInfo("Kyenjojo", "W", 0.63278, 30.62139);
case 50: return new CityInfo("Kyegegwa", "W", 0.50222, 31.04139);
case 51: return new CityInfo("Kumi", "E", 1.46083, 33.93611);
case 52: return new CityInfo("Kotido", "N", 2.98056, 34.13306);
case 53: return new CityInfo("Koboko", "N", 3.41364, 30.95994);
case 54: return new CityInfo("Kitgum", "N", 3.27833, 32.88667);
case 55: return new CityInfo("Kisoro", "W", -1.28538, 29.68497);
case 56: return new CityInfo("Kiryandongo", "W", 1.87633, 32.06225);
case 57: return new CityInfo("Kiruhura", "W", -0.19664, 30.84446);
case 58: return new CityInfo("Kireka", "C", 0.3475, 32.64917);
case 59: return new CityInfo("Kilembe", "W", 0.19835, 30.01302);
case 60: return new CityInfo("Kigorobya", "W", 1.6162, 31.3089);
case 61: return new CityInfo("Kibuku", "E", 1.04333, 33.7975);
case 62: return new CityInfo("Kiboga", "C", 0.91611, 31.77417);
case 63: return new CityInfo("Kibingo", "W", -0.62602, 30.43594);
case 64: return new CityInfo("Kibiito", "W", 0.47722, 30.1925);
case 65: return new CityInfo("Kibale", "W", 0.8, 31.06667);
case 66: return new CityInfo("Kayunga", "C", 0.7025, 32.88861);
case 67: return new CityInfo("Katakwi", "E", 1.89111, 33.96611);
case 68: return new CityInfo("Kasese", "W", 0.18333, 30.08333);
case 69: return new CityInfo("Kasaali", "C", -0.61667, 31.55);
case 70: return new CityInfo("Kapchorwa", "E", 1.40096, 34.45038);
case 71: return new CityInfo("Kanungu", "W", -0.9575, 29.78972);
case 72: return new CityInfo("Kanoni", "C", 0.17722, 31.88111);
case 73: return new CityInfo("Kamwenge", "W", 0.1866, 30.45393);
case 74: return new CityInfo("Kamuli", "E", 0.94722, 33.11972);
case 75: return new CityInfo("Kampala", "C", 0.31628, 32.58219);
case 76: return new CityInfo("Kalungu", "C", -0.16969, 31.75847);
case 77: return new CityInfo("Kaliro", "E", 0.89444, 33.49944);
case 78: return new CityInfo("Kalangala", "C", -0.30889, 32.225);
case 79: return new CityInfo("Kakumiro", "W", 0.78056, 31.32361);
case 80: return new CityInfo("Kajansi", "C", 0.21548, 32.53453);
case 81: return new CityInfo("Kagadi", "W", 0.93778, 30.80889);
case 82: return new CityInfo("Kaberamaido", "E", 1.73889, 33.15944);
case 83: return new CityInfo("Kabale", "W", -1.24857, 29.98993);
case 84: return new CityInfo("Kaabong", "N", 3.48361, 34.14917);
case 85: return new CityInfo("Jinja", "E", 0.43902, 33.20317);
case 86: return new CityInfo("Iganga", "E", 0.60917, 33.46861);
case 87: return new CityInfo("Ibanda", "W", -0.13398, 30.49616);
case 88: return new CityInfo("Hoima", "W", 1.43314, 31.35241);
case 89: return new CityInfo("Gulu", "N", 2.77457, 32.29899);
case 90: return new CityInfo("Gombe", "C", 0.20333, 32.08806);
case 91: return new CityInfo("Fort Portal", "W", 0.66174, 30.2748);
case 92: return new CityInfo("Entebbe", "C", 0.05621, 32.47949);
case 93: return new CityInfo("Dokolo", "N", 1.89833, 33.1775);
case 94: return new CityInfo("Byakabanda", "C", -0.7425, 31.40639);
case 95: return new CityInfo("Bwizibwera", "W", -0.59167, 30.62861);
case 96: return new CityInfo("Bweyogerere", "C", 0.35773, 32.66332);
case 97: return new CityInfo("Buyende", "E", 1.15167, 33.155);
case 98: return new CityInfo("Buwenge", "E", 0.64996, 33.17128);
case 99: return new CityInfo("Butebo", "E", 1.19417, 33.92222);
case 100: return new CityInfo("Butaleja", "E", 0.91194, 33.95111);
case 101: return new CityInfo("Busia", "E", 0.46588, 34.09221);
case 102: return new CityInfo("Bushenyi", "W", -0.53695, 30.18579);
case 103: return new CityInfo("Busembatia", "E", 0.77725, 33.62364);
case 104: return new CityInfo("Bupoto", "E", 0.90611, 34.35778);
case 105: return new CityInfo("Bundibugyo", "W", 0.71117, 30.06469);
case 106: return new CityInfo("Bulisa", "W", 2.11781, 31.41163);
case 107: return new CityInfo("Bulambuli", "E", 1.16667, 34.38333);
case 108: return new CityInfo("Bukwa", "E", 1.25917, 34.75389);
case 109: return new CityInfo("Bukomansimbi", "C", -0.15778, 31.60417);
case 110: return new CityInfo("Bukedea", "E", 1.31694, 34.05056);
case 111: return new CityInfo("Buikwe", "C", 0.3375, 33.01056);
case 112: return new CityInfo("Bugiri", "E", 0.57139, 33.74167);
case 113: return new CityInfo("Bugembe", "E", 0.48213, 33.24065);
case 114: return new CityInfo("Bududa", "E", 1.01118, 34.33112);
case 115: return new CityInfo("Budaka", "E", 1.00389, 33.92556);
case 116: return new CityInfo("Binyin", "E", 1.41667, 34.53333);
case 117: return new CityInfo("Arua", "N", 3.02013, 30.91105);
case 118: return new CityInfo("Apac", "N", 1.97556, 32.53861);
case 119: return new CityInfo("Amuria", "E", 2.00361, 33.65111);
case 120: return new CityInfo("Amudat", "N", 1.95, 34.95);
case 121: return new CityInfo("Amolatar", "N", 1.61556, 32.83972);
case 122: return new CityInfo("Alebtong", "N", 2.24472, 33.25472);
case 123: return new CityInfo("Adjumani", "N", 3.37786, 31.7909);
case 124: return new CityInfo("Abim", "N", 2.70167, 33.67611);
case 125: return new CityInfo("Nakapiripirit", "N", 1.91667, 34.78333);
case 126: return new CityInfo("Pader", "N", 3.05, 33.21667);
case 127: return new CityInfo("Margherita", "W", 0.41861, 29.89111);
case 128: return new CityInfo("Nwoya", "N", 2.63422, 32.00106);
case 129: return new CityInfo("Isingiro", "W", -0.86864, 30.83019);
case 130: return new CityInfo("Manafwa", "E", 0.97842, 34.3743);
case 131: return new CityInfo("Oyam", "N", 2.235, 32.38495);
case 132: return new CityInfo("Amuru", "N", 2.81388, 31.93868);
case 133: return new CityInfo("Namayingo", "E", 0.23983, 33.88491);
case 134: return new CityInfo("Kitamilo", "C", 0.22215, 33.20608);
case 135: return new CityInfo("Kyankwanzi", "C", 1.20061, 31.80063);
case 136: return new CityInfo("Kole", "N", 2.40015, 32.80034);
case 137: return new CityInfo("Otuke", "N", 2.50038, 33.50065);
case 138: return new CityInfo("Napak", "N", 2.25139, 34.25012);
case 139: return new CityInfo("Luuka Town", "E", 0.70076, 33.3002);
case 140: return new CityInfo("Buhweju", "W", -0.35027, 30.30029);
case 141: return new CityInfo("Agago", "N", 2.83383, 33.33361);
case 142: return new CityInfo("Lamwo", "N", 3.52972, 32.8016);
case 143: return new CityInfo("Lweeza", "C", 0.20994, 32.58511);
case 144: return new CityInfo("Kampala Central Division", "C", 0.32467, 32.5747);
case 145: return new CityInfo("Gombe", "C", 0.48695, 32.47938);
default: return new CityInfo("Kihihi", "W", -0.56925, 29.69516);

                                    }                                        
                                }
                            
                        }
                    }
                