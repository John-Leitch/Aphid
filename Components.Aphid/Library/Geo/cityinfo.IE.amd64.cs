
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
                                    public const string Country = "IE";
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
                            
                                        var cur = (Math.Abs(55.13333 - lat) + Math.Abs(-7.45 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(51.95 - lat) + Math.Abs(-7.85056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.975 - lat) + Math.Abs(-6.04944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.68111 - lat) + Math.Abs(-7.02222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83056 - lat) + Math.Abs(-8.22972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98139 - lat) + Math.Abs(-8.51389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33417 - lat) + Math.Abs(-6.4575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8 - lat) + Math.Abs(-9.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01139 - lat) + Math.Abs(-8.34417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25833 - lat) + Math.Abs(-7.11194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.83389 - lat) + Math.Abs(-7.07556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72056 - lat) + Math.Abs(-7.5825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38889 - lat) + Math.Abs(-7.37361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67167 - lat) + Math.Abs(-7.72 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.73611 - lat) + Math.Abs(-6.42278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80028 - lat) + Math.Abs(-6.73694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27389 - lat) + Math.Abs(-7.48889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.86472 - lat) + Math.Abs(-8.76056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.51667 - lat) + Math.Abs(-8.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.555 - lat) + Math.Abs(-6.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.16235 - lat) + Math.Abs(-7.15244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.27042 - lat) + Math.Abs(-9.70264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92599 - lat) + Math.Abs(-8.60747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05861 - lat) + Math.Abs(-6.22611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.05 - lat) + Math.Abs(-8.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.47333 - lat) + Math.Abs(-8.15583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79667 - lat) + Math.Abs(-6.46333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.68194 - lat) + Math.Abs(-7.80222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52667 - lat) + Math.Abs(-7.13722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.76333 - lat) + Math.Abs(-6.26778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30972 - lat) + Math.Abs(-6.28528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79472 - lat) + Math.Abs(-7.83389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.57278 - lat) + Math.Abs(-9.37528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.09278 - lat) + Math.Abs(-8.00806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.92278 - lat) + Math.Abs(-6.54639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2859 - lat) + Math.Abs(-6.37344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.32167 - lat) + Math.Abs(-6.6475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.45972 - lat) + Math.Abs(-6.21806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.93941 - lat) + Math.Abs(-8.94346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38947 - lat) + Math.Abs(-6.11059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.47694 - lat) + Math.Abs(-6.73639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.78333 - lat) + Math.Abs(-8.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.314 - lat) + Math.Abs(-6.61373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01556 - lat) + Math.Abs(-7.15278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.62889 - lat) + Math.Abs(-6.26833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.26969 - lat) + Math.Abs(-8.46943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.71 - lat) + Math.Abs(-6.54333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52487 - lat) + Math.Abs(-9.54798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55 - lat) + Math.Abs(-9.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.58278 - lat) + Math.Abs(-6.10833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74139 - lat) + Math.Abs(-8.77417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9825 - lat) + Math.Abs(-7.92444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54 - lat) + Math.Abs(-6.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22611 - lat) + Math.Abs(-6.12444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.90872 - lat) + Math.Abs(-8.53316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32815 - lat) + Math.Abs(-6.22224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24889 - lat) + Math.Abs(-6.66611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.59722 - lat) + Math.Abs(-8.70889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.93553 - lat) + Math.Abs(-7.46109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28028 - lat) + Math.Abs(-6.44444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.52424 - lat) + Math.Abs(-6.10497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.27184 - lat) + Math.Abs(-6.38989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.30917 - lat) + Math.Abs(-8.56611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57814 - lat) + Math.Abs(-9.03248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95111 - lat) + Math.Abs(-7.80167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.63333 - lat) + Math.Abs(-8.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.83333 - lat) + Math.Abs(-7.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.41417 - lat) + Math.Abs(-7.29611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27417 - lat) + Math.Abs(-6.81778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77239 - lat) + Math.Abs(-8.49404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.34194 - lat) + Math.Abs(-6.22639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35222 - lat) + Math.Abs(-7.20167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.50806 - lat) + Math.Abs(-6.4625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.50767 - lat) + Math.Abs(-7.1351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.87889 - lat) + Math.Abs(-6.69333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99056 - lat) + Math.Abs(-6.08528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.09389 - lat) + Math.Abs(-7.54028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08333 - lat) + Math.Abs(-9.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32028 - lat) + Math.Abs(-6.26333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.03673 - lat) + Math.Abs(-7.64923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52444 - lat) + Math.Abs(-8.93806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93179 - lat) + Math.Abs(-6.22945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85472 - lat) + Math.Abs(-7.58028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.07694 - lat) + Math.Abs(-8.28194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28278 - lat) + Math.Abs(-6.47278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22139 - lat) + Math.Abs(-6.995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.87472 - lat) + Math.Abs(-7.59833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38681 - lat) + Math.Abs(-6.18067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.81861 - lat) + Math.Abs(-8.86694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29028 - lat) + Math.Abs(-6.75389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.08917 - lat) + Math.Abs(-8.21889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.42306 - lat) + Math.Abs(-6.1375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28833 - lat) + Math.Abs(-7.32056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03441 - lat) + Math.Abs(-7.29979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16222 - lat) + Math.Abs(-7.19111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35333 - lat) + Math.Abs(-7.34028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29611 - lat) + Math.Abs(-7.28944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87083 - lat) + Math.Abs(-8.3355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23059 - lat) + Math.Abs(-6.97388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.64306 - lat) + Math.Abs(-8.86889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5679 - lat) + Math.Abs(-8.33794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85278 - lat) + Math.Abs(-6.21694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.41667 - lat) + Math.Abs(-9.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26833 - lat) + Math.Abs(-8.92 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.09011 - lat) + Math.Abs(-6.25937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10639 - lat) + Math.Abs(-6.76528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.76648 - lat) + Math.Abs(-7.16284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.55611 - lat) + Math.Abs(-6.77 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.99639 - lat) + Math.Abs(-7.51917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.39667 - lat) + Math.Abs(-6.93667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.88508 - lat) + Math.Abs(-9.54526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71111 - lat) + Math.Abs(-8.40972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.76 - lat) + Math.Abs(-8.89556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21667 - lat) + Math.Abs(-9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30111 - lat) + Math.Abs(-6.50222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06833 - lat) + Math.Abs(-6.06583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.44917 - lat) + Math.Abs(-9.06111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18194 - lat) + Math.Abs(-6.79667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.86194 - lat) + Math.Abs(-8.19667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.65278 - lat) + Math.Abs(-6.68139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21583 - lat) + Math.Abs(-6.66694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.52466 - lat) + Math.Abs(-7.3385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.81306 - lat) + Math.Abs(-6.95139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.06667 - lat) + Math.Abs(-7.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.48333 - lat) + Math.Abs(-8.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33783 - lat) + Math.Abs(-9.18002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.19153 - lat) + Math.Abs(-7.03873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99889 - lat) + Math.Abs(-7.47278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.11361 - lat) + Math.Abs(-7.32 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.65111 - lat) + Math.Abs(-8.39611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.97556 - lat) + Math.Abs(-6.815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28944 - lat) + Math.Abs(-7.24833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29308 - lat) + Math.Abs(-6.15312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14056 - lat) + Math.Abs(-7.06639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.25 - lat) + Math.Abs(-6.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.91667 - lat) + Math.Abs(-7.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.55 - lat) + Math.Abs(-7.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26583 - lat) + Math.Abs(-8.26806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85528 - lat) + Math.Abs(-9.39833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15 - lat) + Math.Abs(-9.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05935 - lat) + Math.Abs(-9.06031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.08806 - lat) + Math.Abs(-7.69889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91526 - lat) + Math.Abs(-8.18052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30008 - lat) + Math.Abs(-6.21504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.385 - lat) + Math.Abs(-6.59361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37022 - lat) + Math.Abs(-6.23646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.30639 - lat) + Math.Abs(-8.17611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.95 - lat) + Math.Abs(-7.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13333 - lat) + Math.Abs(-8.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.45083 - lat) + Math.Abs(-6.15444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90663 - lat) + Math.Abs(-8.96968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.52743 - lat) + Math.Abs(-6.16423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35736 - lat) + Math.Abs(-6.44859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.94861 - lat) + Math.Abs(-6.54139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.19694 - lat) + Math.Abs(-8.56694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24389 - lat) + Math.Abs(-6.13306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.45389 - lat) + Math.Abs(-6.92194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.72536 - lat) + Math.Abs(-7.79823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.40556 - lat) + Math.Abs(-9.61694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.44639 - lat) + Math.Abs(-9.485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03278 - lat) + Math.Abs(-9.28833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66472 - lat) + Math.Abs(-8.62306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.83194 - lat) + Math.Abs(-7.48361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.95 - lat) + Math.Abs(-7.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36583 - lat) + Math.Abs(-6.49556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.73639 - lat) + Math.Abs(-6.9725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93268 - lat) + Math.Abs(-9.33666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.68194 - lat) + Math.Abs(-6.23917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.27194 - lat) + Math.Abs(-8.59333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.66667 - lat) + Math.Abs(-7.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36697 - lat) + Math.Abs(-8.88047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9732 - lat) + Math.Abs(-6.48597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.79059 - lat) + Math.Abs(-8.92111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13944 - lat) + Math.Abs(-8.93361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7075 - lat) + Math.Abs(-8.53056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.45222 - lat) + Math.Abs(-7.09972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.45 - lat) + Math.Abs(-8.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.90806 - lat) + Math.Abs(-6.80556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17639 - lat) + Math.Abs(-8.24417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.85 - lat) + Math.Abs(-9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.36028 - lat) + Math.Abs(-7.57667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.64011 - lat) + Math.Abs(-9.48509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.24202 - lat) + Math.Abs(-6.35615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.55882 - lat) + Math.Abs(-6.65895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25194 - lat) + Math.Abs(-6.84194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4 - lat) + Math.Abs(-8.57722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20545 - lat) + Math.Abs(-7.42573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.03083 - lat) + Math.Abs(-7.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.31723 - lat) + Math.Abs(-7.1775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8 - lat) + Math.Abs(-7.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.63333 - lat) + Math.Abs(-8.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87243 - lat) + Math.Abs(-8.64781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1 - lat) + Math.Abs(-9.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.56833 - lat) + Math.Abs(-7.67139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94222 - lat) + Math.Abs(-7.99778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0598 - lat) + Math.Abs(-9.50858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80667 - lat) + Math.Abs(-8.44361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.21165 - lat) + Math.Abs(-9.2201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80667 - lat) + Math.Abs(-8.74583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.65417 - lat) + Math.Abs(-7.25222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.97977 - lat) + Math.Abs(-7.41213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15611 - lat) + Math.Abs(-6.91444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.57033 - lat) + Math.Abs(-6.90467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13028 - lat) + Math.Abs(-6.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10278 - lat) + Math.Abs(-6.065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.40222 - lat) + Math.Abs(-6.67083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36944 - lat) + Math.Abs(-7.50333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88333 - lat) + Math.Abs(-9.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.72639 - lat) + Math.Abs(-6.87917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.16667 - lat) + Math.Abs(-8.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.67287 - lat) + Math.Abs(-6.28534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23833 - lat) + Math.Abs(-6.62222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.21591 - lat) + Math.Abs(-9.09197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7654 - lat) + Math.Abs(-8.65705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38778 - lat) + Math.Abs(-6.06528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.47306 - lat) + Math.Abs(-8.43056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.63972 - lat) + Math.Abs(-7.86306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.46667 - lat) + Math.Abs(-9.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.86389 - lat) + Math.Abs(-6.55694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.05028 - lat) + Math.Abs(-8.23194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14083 - lat) + Math.Abs(-6.06306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01526 - lat) + Math.Abs(-8.60882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.2 - lat) + Math.Abs(-6.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.39323 - lat) + Math.Abs(-8.52544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.77928 - lat) + Math.Abs(-7.49429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.54028 - lat) + Math.Abs(-6.95472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.62944 - lat) + Math.Abs(-7.07333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06639 - lat) + Math.Abs(-8.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67472 - lat) + Math.Abs(-6.2925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.57028 - lat) + Math.Abs(-9.28278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.7975 - lat) + Math.Abs(-8.2825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.96166 - lat) + Math.Abs(-6.15739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37851 - lat) + Math.Abs(-6.28028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18667 - lat) + Math.Abs(-8.3575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27245 - lat) + Math.Abs(-9.05095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.73417 - lat) + Math.Abs(-7.39889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.61139 - lat) + Math.Abs(-9.11028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9807 - lat) + Math.Abs(-9.11551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51194 - lat) + Math.Abs(-6.28028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38917 - lat) + Math.Abs(-6.29694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46722 - lat) + Math.Abs(-7.69111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.58833 - lat) + Math.Abs(-6.49972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13583 - lat) + Math.Abs(-8.27583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26944 - lat) + Math.Abs(-7.82694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28083 - lat) + Math.Abs(-9.8675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.08861 - lat) + Math.Abs(-7.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94472 - lat) + Math.Abs(-9.29222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1925 - lat) + Math.Abs(-6.16917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.50083 - lat) + Math.Abs(-6.55778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84361 - lat) + Math.Abs(-8.98639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.41419 - lat) + Math.Abs(-6.83229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.34056 - lat) + Math.Abs(-6.95917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.85 - lat) + Math.Abs(-8.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.7 - lat) + Math.Abs(-7.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33948 - lat) + Math.Abs(-7.04752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84417 - lat) + Math.Abs(-7.3925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.5125 - lat) + Math.Abs(-6.54 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15108 - lat) + Math.Abs(-6.99872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.61667 - lat) + Math.Abs(-8.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.71667 - lat) + Math.Abs(-9.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.01667 - lat) + Math.Abs(-8.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.835 - lat) + Math.Abs(-6.39611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29395 - lat) + Math.Abs(-6.13586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05556 - lat) + Math.Abs(-6.70389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.95111 - lat) + Math.Abs(-8.35917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08806 - lat) + Math.Abs(-7.62528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29067 - lat) + Math.Abs(-6.25714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54 - lat) + Math.Abs(-6.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.41901 - lat) + Math.Abs(-6.47375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.65667 - lat) + Math.Abs(-6.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33306 - lat) + Math.Abs(-6.24889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.05 - lat) + Math.Abs(-8.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.81667 - lat) + Math.Abs(-7.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.23333 - lat) + Math.Abs(-8.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.92538 - lat) + Math.Abs(-6.40292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.71889 - lat) + Math.Abs(-6.34778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.60361 - lat) + Math.Abs(-8.24444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9748 - lat) + Math.Abs(-10.12577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.69306 - lat) + Math.Abs(-6.41972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.31375 - lat) + Math.Abs(-6.22274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21667 - lat) + Math.Abs(-8.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.65378 - lat) + Math.Abs(-8.11134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.48722 - lat) + Math.Abs(-6.15194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36489 - lat) + Math.Abs(-6.18032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14083 - lat) + Math.Abs(-10.26889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.08333 - lat) + Math.Abs(-8.28944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58666 - lat) + Math.Abs(-9.05026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.34167 - lat) + Math.Abs(-6.94111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.61056 - lat) + Math.Abs(-7.0925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27833 - lat) + Math.Abs(-6.10028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32154 - lat) + Math.Abs(-6.31439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.13333 - lat) + Math.Abs(-8.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1 - lat) + Math.Abs(-9.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79833 - lat) + Math.Abs(-8.30083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51944 - lat) + Math.Abs(-8.71778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22611 - lat) + Math.Abs(-8.73306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.695 - lat) + Math.Abs(-8.75972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.64424 - lat) + Math.Abs(-6.22899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.63308 - lat) + Math.Abs(-8.70521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.43786 - lat) + Math.Abs(-8.86617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94778 - lat) + Math.Abs(-9.06306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89797 - lat) + Math.Abs(-8.47061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0725 - lat) + Math.Abs(-7.08194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.17806 - lat) + Math.Abs(-8.59972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.86083 - lat) + Math.Abs(-7.66556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.18333 - lat) + Math.Abs(-8.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.78111 - lat) + Math.Abs(-6.48694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85046 - lat) + Math.Abs(-8.2948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86278 - lat) + Math.Abs(-8.12444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.66374 - lat) + Math.Abs(-7.01779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.355 - lat) + Math.Abs(-7.70389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.18333 - lat) + Math.Abs(-7.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.41167 - lat) + Math.Abs(-6.44417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32444 - lat) + Math.Abs(-6.39722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1475 - lat) + Math.Abs(-7.52444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62306 - lat) + Math.Abs(-8.87056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94028 - lat) + Math.Abs(-8.03556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.79361 - lat) + Math.Abs(-6.2375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22167 - lat) + Math.Abs(-7.88417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.48907 - lat) + Math.Abs(-10.0191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.71667 - lat) + Math.Abs(-9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33861 - lat) + Math.Abs(-8.945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3425 - lat) + Math.Abs(-7.61389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29139 - lat) + Math.Abs(-6.68917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26667 - lat) + Math.Abs(-8.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15694 - lat) + Math.Abs(-6.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35 - lat) + Math.Abs(-8.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.96417 - lat) + Math.Abs(-8.79417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.34846 - lat) + Math.Abs(-6.34301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.34165 - lat) + Math.Abs(-6.54419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.99083 - lat) + Math.Abs(-7.36056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.77258 - lat) + Math.Abs(-8.50307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.67935 - lat) + Math.Abs(-7.29736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91028 - lat) + Math.Abs(-8.05389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37483 - lat) + Math.Abs(-6.36336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23333 - lat) + Math.Abs(-9.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.90889 - lat) + Math.Abs(-6.84222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80611 - lat) + Math.Abs(-7.21056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38639 - lat) + Math.Abs(-6.44944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.11667 - lat) + Math.Abs(-6.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.90083 - lat) + Math.Abs(-6.39028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.85 - lat) + Math.Abs(-9.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51583 - lat) + Math.Abs(-7.88556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90833 - lat) + Math.Abs(-8.26333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81167 - lat) + Math.Abs(-8.39861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.34917 - lat) + Math.Abs(-7.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.94694 - lat) + Math.Abs(-8.09 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.97278 - lat) + Math.Abs(-6.71889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26403 - lat) + Math.Abs(-9.59853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23634 - lat) + Math.Abs(-6.72836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70806 - lat) + Math.Abs(-6.49444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.25 - lat) + Math.Abs(-7.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84083 - lat) + Math.Abs(-6.92611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.04 - lat) + Math.Abs(-6.18833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.75943 - lat) + Math.Abs(-6.84095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14603 - lat) + Math.Abs(-7.8466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.61444 - lat) + Math.Abs(-8.33556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.08279 - lat) + Math.Abs(-6.7977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.545 - lat) + Math.Abs(-7.39111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94861 - lat) + Math.Abs(-10.22222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.59361 - lat) + Math.Abs(-8.47028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.37694 - lat) + Math.Abs(-7.92167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26973 - lat) + Math.Abs(-6.16058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23333 - lat) + Math.Abs(-8.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.47782 - lat) + Math.Abs(-8.28094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6553 - lat) + Math.Abs(-6.65359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.42194 - lat) + Math.Abs(-8.66417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.47417 - lat) + Math.Abs(-8.54583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20278 - lat) + Math.Abs(-6.09833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.96667 - lat) + Math.Abs(-8.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03083 - lat) + Math.Abs(-8.93167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.75222 - lat) + Math.Abs(-7.95306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99528 - lat) + Math.Abs(-8.12806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6 - lat) + Math.Abs(-6.9175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17 - lat) + Math.Abs(-6.5325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93333 - lat) + Math.Abs(-8.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38806 - lat) + Math.Abs(-6.37556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29308 - lat) + Math.Abs(-6.81843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.96405 - lat) + Math.Abs(-6.36514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3015 - lat) + Math.Abs(-6.1778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09139 - lat) + Math.Abs(-7.91333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.59194 - lat) + Math.Abs(-7.18 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1 - lat) + Math.Abs(-7.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.225 - lat) + Math.Abs(-9.99083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.93333 - lat) + Math.Abs(-7.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73889 - lat) + Math.Abs(-8.49 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25194 - lat) + Math.Abs(-9.14972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68025 - lat) + Math.Abs(-9.45254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74694 - lat) + Math.Abs(-8.7425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18861 - lat) + Math.Abs(-7.98667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93722 - lat) + Math.Abs(-6.70917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.58828 - lat) + Math.Abs(-6.18728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.5 - lat) + Math.Abs(-8.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.78889 - lat) + Math.Abs(-7.33028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.08333 - lat) + Math.Abs(-8.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13333 - lat) + Math.Abs(-6.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.56667 - lat) + Math.Abs(-7.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.86528 - lat) + Math.Abs(-7.20278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38333 - lat) + Math.Abs(-9.83361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.76667 - lat) + Math.Abs(-8.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.05 - lat) + Math.Abs(-7.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82198 - lat) + Math.Abs(-8.46233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.52162 - lat) + Math.Abs(-8.32738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45593 - lat) + Math.Abs(-9.66399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.11667 - lat) + Math.Abs(-7.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.41127 - lat) + Math.Abs(-7.75759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.60889 - lat) + Math.Abs(-6.30306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51108 - lat) + Math.Abs(-9.67097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.8 - lat) + Math.Abs(-7.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28056 - lat) + Math.Abs(-6.31639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74056 - lat) + Math.Abs(-6.76778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.53167 - lat) + Math.Abs(-6.96111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.00694 - lat) + Math.Abs(-6.81944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.63333 - lat) + Math.Abs(-9.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.47278 - lat) + Math.Abs(-8.86389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3275 - lat) + Math.Abs(-8.21944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.05 - lat) + Math.Abs(-7.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.11667 - lat) + Math.Abs(-9.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80778 - lat) + Math.Abs(-8.43556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.90134 - lat) + Math.Abs(-8.57507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.8032 - lat) + Math.Abs(-9.12913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39972 - lat) + Math.Abs(-6.12583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.60846 - lat) + Math.Abs(-6.1831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.91667 - lat) + Math.Abs(-6.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70031 - lat) + Math.Abs(-6.96181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85333 - lat) + Math.Abs(-6.3275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99139 - lat) + Math.Abs(-6.98028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15229 - lat) + Math.Abs(-6.78173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29639 - lat) + Math.Abs(-8.74306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.62327 - lat) + Math.Abs(-6.91434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.59972 - lat) + Math.Abs(-8.97556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.51163 - lat) + Math.Abs(-6.39821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79443 - lat) + Math.Abs(-6.14958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70908 - lat) + Math.Abs(-8.61431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.31167 - lat) + Math.Abs(-7.875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.32261 - lat) + Math.Abs(-9.77774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.85972 - lat) + Math.Abs(-6.54056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.76444 - lat) + Math.Abs(-8.4075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83917 - lat) + Math.Abs(-8.21222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.56194 - lat) + Math.Abs(-8.79556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.91331 - lat) + Math.Abs(-7.34456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38139 - lat) + Math.Abs(-9.3025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72233 - lat) + Math.Abs(-6.18905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.24134 - lat) + Math.Abs(-9.82198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.49667 - lat) + Math.Abs(-6.11111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.54917 - lat) + Math.Abs(-6.08278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.10472 - lat) + Math.Abs(-8.69139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85833 - lat) + Math.Abs(-10.16806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.24917 - lat) + Math.Abs(-6.35739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28393 - lat) + Math.Abs(-6.48977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51789 - lat) + Math.Abs(-6.40619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.81306 - lat) + Math.Abs(-6.39333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66768 - lat) + Math.Abs(-8.53121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71389 - lat) + Math.Abs(-8.49944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88167 - lat) + Math.Abs(-8.19583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70389 - lat) + Math.Abs(-8.86417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.42278 - lat) + Math.Abs(-7.93722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17417 - lat) + Math.Abs(-7.72556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39389 - lat) + Math.Abs(-7.71722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13306 - lat) + Math.Abs(-7.14861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.104 - lat) + Math.Abs(-6.86126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13815 - lat) + Math.Abs(-6.84024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28392 - lat) + Math.Abs(-6.86161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25139 - lat) + Math.Abs(-6.59167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.40389 - lat) + Math.Abs(-6.85889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.00833 - lat) + Math.Abs(-6.11139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10917 - lat) + Math.Abs(-6.10667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10389 - lat) + Math.Abs(-6.55361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16722 - lat) + Math.Abs(-6.13361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20278 - lat) + Math.Abs(-6.57806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20444 - lat) + Math.Abs(-6.12083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28167 - lat) + Math.Abs(-6.33917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2747 - lat) + Math.Abs(-6.2253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26667 - lat) + Math.Abs(-6.17417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27917 - lat) + Math.Abs(-6.14058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.31457 - lat) + Math.Abs(-6.275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38712 - lat) + Math.Abs(-6.2138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38721 - lat) + Math.Abs(-6.22713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37058 - lat) + Math.Abs(-6.25298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39807 - lat) + Math.Abs(-6.26693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36694 - lat) + Math.Abs(-6.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39306 - lat) + Math.Abs(-6.42694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.34283 - lat) + Math.Abs(-6.3548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29528 - lat) + Math.Abs(-6.30889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27556 - lat) + Math.Abs(-6.3675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33605 - lat) + Math.Abs(-6.37799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33625 - lat) + Math.Abs(-6.29718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.31301 - lat) + Math.Abs(-6.2453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.31467 - lat) + Math.Abs(-6.23148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30447 - lat) + Math.Abs(-6.19985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27409 - lat) + Math.Abs(-6.25397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33467 - lat) + Math.Abs(-6.30302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3887 - lat) + Math.Abs(-6.19998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39835 - lat) + Math.Abs(-6.20749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39845 - lat) + Math.Abs(-6.16179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39948 - lat) + Math.Abs(-6.18886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3735 - lat) + Math.Abs(-6.20976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38895 - lat) + Math.Abs(-6.14041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.12771 - lat) + Math.Abs(-6.06347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.68198 - lat) + Math.Abs(-8.63955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.2111 - lat) + Math.Abs(-8.50865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94497 - lat) + Math.Abs(-7.04073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73793 - lat) + Math.Abs(-8.93154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36597 - lat) + Math.Abs(-6.23985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2803 - lat) + Math.Abs(-6.3313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35019 - lat) + Math.Abs(-6.37778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72439 - lat) + Math.Abs(-8.55251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.80306 - lat) + Math.Abs(-7.59567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27866 - lat) + Math.Abs(-6.40803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37322 - lat) + Math.Abs(-6.20431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.47185 - lat) + Math.Abs(-8.50436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37923 - lat) + Math.Abs(-6.49052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33953 - lat) + Math.Abs(-8.90837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35914 - lat) + Math.Abs(-8.4684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.76718 - lat) + Math.Abs(-7.8336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.62754 - lat) + Math.Abs(-6.52674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09743 - lat) + Math.Abs(-6.08411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09052 - lat) + Math.Abs(-6.11149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27504 - lat) + Math.Abs(-6.23594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84 - lat) + Math.Abs(-7.15549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78392 - lat) + Math.Abs(-8.30097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70199 - lat) + Math.Abs(-8.65061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.84816 - lat) + Math.Abs(-8.73812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.45291 - lat) + Math.Abs(-6.29115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.44395 - lat) + Math.Abs(-6.20334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.96677 - lat) + Math.Abs(-8.64611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.80165 - lat) + Math.Abs(-7.77437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Buncrana", "U", 55.13333, -7.45);
case 1: return new CityInfo("Youghal", "M", 51.95, -7.85056);
case 2: return new CityInfo("Wicklow", "L", 52.975, -6.04944);
case 3: return new CityInfo("Paulstown", "L", 52.68111, -7.02222);
case 4: return new CityInfo("Whitegate", "M", 51.83056, -8.22972);
case 5: return new CityInfo("Whitechurch", "M", 51.98139, -8.51389);
case 6: return new CityInfo("Loch Garman", "L", 52.33417, -6.4575);
case 7: return new CityInfo("Westport", "C", 53.8, -9.51667);
case 8: return new CityInfo("Watergrasshill", "M", 52.01139, -8.34417);
case 9: return new CityInfo("Waterford", "M", 52.25833, -7.11194);
case 10: return new CityInfo("Virginia", "U", 53.83389, -7.07556);
case 11: return new CityInfo("Urlingford", "L", 52.72056, -7.5825);
case 12: return new CityInfo("Tyrrellspass", "L", 53.38889, -7.37361);
case 13: return new CityInfo("Twomileborris", "M", 52.67167, -7.72);
case 14: return new CityInfo("Tullyallen", "L", 53.73611, -6.42278);
case 15: return new CityInfo("Tullow", "L", 52.80028, -6.73694);
case 16: return new CityInfo("Tullamore", "L", 53.27389, -7.48889);
case 17: return new CityInfo("Tulla", "M", 52.86472, -8.76056);
case 18: return new CityInfo("Tuam", "C", 53.51667, -8.85);
case 19: return new CityInfo("Trim", "L", 53.555, -6.79167);
case 20: return new CityInfo("Trá Mhór", "M", 52.16235, -7.15244);
case 21: return new CityInfo("Tralee", "M", 52.27042, -9.70264);
case 22: return new CityInfo("Tower", "M", 51.92599, -8.60747);
case 23: return new CityInfo("Roundwood", "L", 53.05861, -6.22611);
case 24: return new CityInfo("Tobercurry", "C", 54.05, -8.73333);
case 25: return new CityInfo("Tipperary", "M", 52.47333, -8.15583);
case 26: return new CityInfo("Tinahely", "L", 52.79667, -6.46333);
case 27: return new CityInfo("Thurles", "M", 52.68194, -7.80222);
case 28: return new CityInfo("Thomastown", "L", 52.52667, -7.13722);
case 29: return new CityInfo("Termonfeckin", "L", 53.76333, -6.26778);
case 30: return new CityInfo("Terenure", "L", 53.30972, -6.28528);
case 31: return new CityInfo("Templemore", "M", 52.79472, -7.83389);
case 32: return new CityInfo("Tarbert", "M", 52.57278, -9.37528);
case 33: return new CityInfo("Tallow", "M", 52.09278, -8.00806);
case 34: return new CityInfo("Tallanstown", "L", 53.92278, -6.54639);
case 35: return new CityInfo("Tallaght", "L", 53.2859, -6.37344);
case 36: return new CityInfo("Taghmon", "L", 52.32167, -6.6475);
case 37: return new CityInfo("Swords", "L", 53.45972, -6.21806);
case 38: return new CityInfo("Swinford", "C", 53.93941, -8.94346);
case 39: return new CityInfo("Sutton", "L", 53.38947, -6.11059);
case 40: return new CityInfo("Summerhill", "L", 53.47694, -6.73639);
case 41: return new CityInfo("Strokestown", "C", 53.78333, -8.1);
case 42: return new CityInfo("Straffan", "L", 53.314, -6.61373);
case 43: return new CityInfo("Stradbally", "L", 53.01556, -7.15278);
case 44: return new CityInfo("Stamullin", "L", 53.62889, -6.26833);
case 45: return new CityInfo("Sligo", "C", 54.26969, -8.46943);
case 46: return new CityInfo("Slane", "L", 53.71, -6.54333);
case 47: return new CityInfo("Schull", "M", 51.52487, -9.54798);
case 48: return new CityInfo("Skibbereen", "M", 51.55, -9.26667);
case 49: return new CityInfo("Skerries", "L", 53.58278, -6.10833);
case 50: return new CityInfo("Sixmilebridge", "M", 52.74139, -8.77417);
case 51: return new CityInfo("Shinrone", "L", 52.9825, -7.92444);
case 52: return new CityInfo("Shercock", "U", 54, -6.9);
case 53: return new CityInfo("Shankill", "L", 53.22611, -6.12444);
case 54: return new CityInfo("Scarriff", "M", 52.90872, -8.53316);
case 55: return new CityInfo("Sandymount", "L", 53.32815, -6.22224);
case 56: return new CityInfo("Sallins", "L", 53.24889, -6.66611);
case 57: return new CityInfo("Patrickswell", "M", 52.59722, -8.70889);
case 58: return new CityInfo("St Johnston", "U", 54.93553, -7.46109);
case 59: return new CityInfo("Saggart", "L", 53.28028, -6.44444);
case 60: return new CityInfo("An Ros", "L", 53.52424, -6.10497);
case 61: return new CityInfo("Rosslare", "L", 52.27184, -6.38989);
case 62: return new CityInfo("Rosses Point", "C", 54.30917, -8.56611);
case 63: return new CityInfo("Ross Carbery", "M", 51.57814, -9.03248);
case 64: return new CityInfo("Roscrea", "M", 52.95111, -7.80167);
case 65: return new CityInfo("Roscommon", "C", 53.63333, -8.18333);
case 66: return new CityInfo("Roosky", "C", 53.83333, -7.91667);
case 67: return new CityInfo("Rochfortbridge", "L", 53.41417, -7.29611);
case 68: return new CityInfo("Robertstown", "L", 53.27417, -6.81778);
case 69: return new CityInfo("Riverstick", "M", 51.77239, -8.49404);
case 70: return new CityInfo("Ringsend", "L", 53.34194, -6.22639);
case 71: return new CityInfo("Rhode", "L", 53.35222, -7.20167);
case 72: return new CityInfo("Ratoath", "L", 53.50806, -6.4625);
case 73: return new CityInfo("Rathwire", "L", 53.50767, -7.1351);
case 74: return new CityInfo("Rathvilly", "L", 52.87889, -6.69333);
case 75: return new CityInfo("Rathnew", "L", 52.99056, -6.08528);
case 76: return new CityInfo("Rathmullan", "U", 55.09389, -7.54028);
case 77: return new CityInfo("Rathmore", "M", 52.08333, -9.21667);
case 78: return new CityInfo("Rathmines", "L", 53.32028, -6.26333);
case 79: return new CityInfo("Ramelton", "U", 55.03673, -7.64923);
case 80: return new CityInfo("Rathkeale", "M", 52.52444, -8.93806);
case 81: return new CityInfo("Rathdrum", "L", 52.93179, -6.22945);
case 82: return new CityInfo("Rathdowney", "L", 52.85472, -7.58028);
case 83: return new CityInfo("Rathcormac", "M", 52.07694, -8.28194);
case 84: return new CityInfo("Rathcoole", "L", 53.28278, -6.47278);
case 85: return new CityInfo("Rathangan", "L", 53.22139, -6.995);
case 86: return new CityInfo("Raphoe", "U", 54.87472, -7.59833);
case 87: return new CityInfo("Raheny", "L", 53.38681, -6.18067);
case 88: return new CityInfo("Quin", "M", 52.81861, -8.86694);
case 89: return new CityInfo("Prosperous", "L", 53.29028, -6.75389);
case 90: return new CityInfo("Portumna", "C", 53.08917, -8.21889);
case 91: return new CityInfo("Portmarnock", "L", 53.42306, -6.1375);
case 92: return new CityInfo("Portlaw", "M", 52.28833, -7.32056);
case 93: return new CityInfo("Portlaoise", "L", 53.03441, -7.29979);
case 94: return new CityInfo("Portarlington", "L", 53.16222, -7.19111);
case 95: return new CityInfo("Piltown", "L", 52.35333, -7.34028);
case 96: return new CityInfo("Daingean", "L", 53.29611, -7.28944);
case 97: return new CityInfo("Passage West", "M", 51.87083, -8.3355);
case 98: return new CityInfo("Passage East", "M", 52.23059, -6.97388);
case 99: return new CityInfo("Pallaskenry", "M", 52.64306, -8.86889);
case 100: return new CityInfo("Pallasgreen", "M", 52.5679, -8.33794);
case 101: return new CityInfo("Avoca", "L", 52.85278, -6.21694);
case 102: return new CityInfo("Oughterard", "C", 53.41667, -9.33333);
case 103: return new CityInfo("Oranmore", "C", 53.26833, -8.92);
case 104: return new CityInfo("Omeath", "L", 54.09011, -6.25937);
case 105: return new CityInfo("Old Kilcullen", "L", 53.10639, -6.76528);
case 106: return new CityInfo("Oldcastle", "L", 53.76648, -7.16284);
case 107: return new CityInfo("Newtown Trim", "L", 53.55611, -6.77);
case 108: return new CityInfo("Newtown Cunningham", "U", 54.99639, -7.51917);
case 109: return new CityInfo("New Ross", "L", 52.39667, -6.93667);
case 110: return new CityInfo("Newport", "C", 53.88508, -9.54526);
case 111: return new CityInfo("Newport", "M", 52.71111, -8.40972);
case 112: return new CityInfo("Newmarket on Fergus", "M", 52.76, -8.89556);
case 113: return new CityInfo("Newmarket", "M", 52.21667, -9);
case 114: return new CityInfo("Newcastle", "L", 53.30111, -6.50222);
case 115: return new CityInfo("Newcastle", "L", 53.06833, -6.06583);
case 116: return new CityInfo("Newcastle West", "M", 52.44917, -9.06111);
case 117: return new CityInfo("Droichead Nua", "L", 53.18194, -6.79667);
case 118: return new CityInfo("Nenagh", "M", 52.86194, -8.19667);
case 119: return new CityInfo("Navan", "L", 53.65278, -6.68139);
case 120: return new CityInfo("Naas", "L", 53.21583, -6.66694);
case 121: return new CityInfo("An Muileann gCearr", "L", 53.52466, -7.3385);
case 122: return new CityInfo("Mullagh", "U", 53.81306, -6.95139);
case 123: return new CityInfo("Muff", "U", 55.06667, -7.26667);
case 124: return new CityInfo("Moylough", "C", 53.48333, -8.56667);
case 125: return new CityInfo("Moycullen", "C", 53.33783, -9.18002);
case 126: return new CityInfo("Moville", "U", 55.19153, -7.03873);
case 127: return new CityInfo("Mountrath", "L", 52.99889, -7.47278);
case 128: return new CityInfo("Mountmellick", "L", 53.11361, -7.32);
case 129: return new CityInfo("Moroe", "M", 52.65111, -8.39611);
case 130: return new CityInfo("Moone", "L", 52.97556, -6.815);
case 131: return new CityInfo("Mooncoin", "L", 52.28944, -7.24833);
case 132: return new CityInfo("Monkstown", "L", 53.29308, -6.15312);
case 133: return new CityInfo("Monasterevin", "L", 53.14056, -7.06639);
case 134: return new CityInfo("Monaghan", "U", 54.25, -6.96667);
case 135: return new CityInfo("Mohill", "C", 53.91667, -7.86667);
case 136: return new CityInfo("Moate", "L", 53.55, -7.71667);
case 137: return new CityInfo("Mitchelstown", "M", 52.26583, -8.26806);
case 138: return new CityInfo("Miltown Malbay", "M", 52.85528, -9.39833);
case 139: return new CityInfo("Baile an Mhuilinn", "M", 52.15, -9.71667);
case 140: return new CityInfo("Millstreet", "M", 52.05935, -9.06031);
case 141: return new CityInfo("Millford", "U", 55.08806, -7.69889);
case 142: return new CityInfo("Midleton", "M", 51.91526, -8.18052);
case 143: return new CityInfo("Mount Merrion", "L", 53.30008, -6.21504);
case 144: return new CityInfo("Maynooth", "L", 53.385, -6.59361);
case 145: return new CityInfo("Marino", "L", 53.37022, -6.23646);
case 146: return new CityInfo("Manorhamilton", "C", 54.30639, -8.17611);
case 147: return new CityInfo("Manorcunningham", "U", 54.95, -7.61667);
case 148: return new CityInfo("Mallow", "M", 52.13333, -8.63333);
case 149: return new CityInfo("Malahide", "L", 53.45083, -6.15444);
case 150: return new CityInfo("Macroom", "M", 51.90663, -8.96968);
case 151: return new CityInfo("Lusk", "L", 53.52743, -6.16423);
case 152: return new CityInfo("Lucan", "L", 53.35736, -6.44859);
case 153: return new CityInfo("Louth", "L", 53.94861, -6.54139);
case 154: return new CityInfo("Loughrea", "C", 53.19694, -8.56694);
case 155: return new CityInfo("Loughlinstown", "L", 53.24389, -6.13306);
case 156: return new CityInfo("Longwood", "L", 53.45389, -6.92194);
case 157: return new CityInfo("Longford", "L", 53.72536, -7.79823);
case 158: return new CityInfo("Lixnaw", "M", 52.40556, -9.61694);
case 159: return new CityInfo("Listowel", "M", 52.44639, -9.485);
case 160: return new CityInfo("Lisdoonvarna", "M", 53.03278, -9.28833);
case 161: return new CityInfo("Luimneach", "M", 52.66472, -8.62306);
case 162: return new CityInfo("Leifear", "U", 54.83194, -7.48361);
case 163: return new CityInfo("Letterkenny", "U", 54.95, -7.73333);
case 164: return new CityInfo("Leixlip", "L", 53.36583, -6.49556);
case 165: return new CityInfo("Leighlinbridge", "L", 52.73639, -6.9725);
case 166: return new CityInfo("Lehinch", "M", 52.93268, -9.33666);
case 167: return new CityInfo("Laytown", "L", 53.68194, -6.23917);
case 168: return new CityInfo("Strandhill", "C", 54.27194, -8.59333);
case 169: return new CityInfo("Lanesborough", "L", 53.66667, -7.98333);
case 170: return new CityInfo("Lackagh", "C", 53.36697, -8.88047);
case 171: return new CityInfo("Knockbridge", "L", 53.9732, -6.48597);
case 172: return new CityInfo("Knock", "C", 53.79059, -8.92111);
case 173: return new CityInfo("Kinvarra", "C", 53.13944, -8.93361);
case 174: return new CityInfo("Kinsale", "M", 51.7075, -8.53056);
case 175: return new CityInfo("Kinnegad", "L", 53.45222, -7.09972);
case 176: return new CityInfo("Kinlough", "C", 54.45, -8.28333);
case 177: return new CityInfo("Kingscourt", "U", 53.90806, -6.80556);
case 178: return new CityInfo("Kilworth", "M", 52.17639, -8.24417);
case 179: return new CityInfo("Kiltamagh", "C", 53.85, -9);
case 180: return new CityInfo("Kilsheelan", "M", 52.36028, -7.57667);
case 181: return new CityInfo("Kilrush", "M", 52.64011, -9.48509);
case 182: return new CityInfo("Kilrane", "L", 52.24202, -6.35615);
case 183: return new CityInfo("Kilmessan", "L", 53.55882, -6.65895);
case 184: return new CityInfo("Kilmeage", "L", 53.25194, -6.84194);
case 185: return new CityInfo("Kilmallock", "M", 52.4, -8.57722);
case 186: return new CityInfo("Kilmacthomas", "M", 52.20545, -7.42573);
case 187: return new CityInfo("Kilmacrenan", "U", 55.03083, -7.77917);
case 188: return new CityInfo("Kilmacow", "L", 52.31723, -7.1775);
case 189: return new CityInfo("Killygordon", "U", 54.8, -7.68333);
case 190: return new CityInfo("Killybegs", "U", 54.63333, -8.45);
case 191: return new CityInfo("Killumney", "M", 51.87243, -8.64781);
case 192: return new CityInfo("Killorglin", "M", 52.1, -9.78333);
case 193: return new CityInfo("Killenaule", "M", 52.56833, -7.67139);
case 194: return new CityInfo("Killeagh", "M", 51.94222, -7.99778);
case 195: return new CityInfo("Cill Airne", "M", 52.0598, -9.50858);
case 196: return new CityInfo("Killaloe", "M", 52.80667, -8.44361);
case 197: return new CityInfo("Killala", "C", 54.21165, -9.2201);
case 198: return new CityInfo("Kilkishen", "M", 52.80667, -8.74583);
case 199: return new CityInfo("Kilkenny", "L", 52.65417, -7.25222);
case 200: return new CityInfo("Kildrum", "U", 54.97977, -7.41213);
case 201: return new CityInfo("Kildare", "L", 53.15611, -6.91444);
case 202: return new CityInfo("Kildalkey", "L", 53.57033, -6.90467);
case 203: return new CityInfo("Kilcullen", "L", 53.13028, -6.74444);
case 204: return new CityInfo("Kilcoole", "L", 53.10278, -6.065);
case 205: return new CityInfo("Kilcock", "L", 53.40222, -6.67083);
case 206: return new CityInfo("Kilbeggan", "L", 53.36944, -7.50333);
case 207: return new CityInfo("Kenmare", "M", 51.88333, -9.58333);
case 208: return new CityInfo("Kells", "L", 53.72639, -6.87917);
case 209: return new CityInfo("Kanturk", "M", 52.16667, -8.9);
case 210: return new CityInfo("Julianstown", "L", 53.67287, -6.28534);
case 211: return new CityInfo("Johnstown", "L", 53.23833, -6.62222);
case 212: return new CityInfo("Inishcrone", "C", 54.21591, -9.09197);
case 213: return new CityInfo("Innishannon", "M", 51.7654, -8.65705);
case 214: return new CityInfo("Howth", "L", 53.38778, -6.06528);
case 215: return new CityInfo("Hospital", "M", 52.47306, -8.43056);
case 216: return new CityInfo("Holycross", "M", 52.63972, -7.86306);
case 217: return new CityInfo("Headford", "C", 53.46667, -9.1);
case 218: return new CityInfo("Hacketstown", "L", 52.86389, -6.55694);
case 219: return new CityInfo("Gweedore", "U", 55.05028, -8.23194);
case 220: return new CityInfo("Greystones", "L", 53.14083, -6.06306);
case 221: return new CityInfo("Grenagh", "M", 52.01526, -8.60882);
case 222: return new CityInfo("Greencastle", "U", 55.2, -6.98333);
case 223: return new CityInfo("Grange", "C", 54.39323, -8.52544);
case 224: return new CityInfo("Granard", "L", 53.77928, -7.49429);
case 225: return new CityInfo("Graiguenamanagh", "L", 52.54028, -6.95472);
case 226: return new CityInfo("Gowran", "L", 52.62944, -7.07333);
case 227: return new CityInfo("Gort", "C", 53.06639, -8.81667);
case 228: return new CityInfo("Gorey", "L", 52.67472, -6.2925);
case 229: return new CityInfo("Glin", "M", 52.57028, -9.28278);
case 230: return new CityInfo("Glenties", "U", 54.7975, -8.2825);
case 231: return new CityInfo("Glenealy", "L", 52.96166, -6.15739);
case 232: return new CityInfo("Glasnevin", "L", 53.37851, -6.28028);
case 233: return new CityInfo("Glanworth", "M", 52.18667, -8.3575);
case 234: return new CityInfo("Gaillimh", "C", 53.27245, -9.05095);
case 235: return new CityInfo("Freshford", "L", 52.73417, -7.39889);
case 236: return new CityInfo("Foynes", "M", 52.61139, -9.11028);
case 237: return new CityInfo("Foxford", "C", 53.9807, -9.11551);
case 238: return new CityInfo("Ford", "L", 52.51194, -6.28028);
case 239: return new CityInfo("Finglas", "L", 53.38917, -6.29694);
case 240: return new CityInfo("Fethard", "M", 52.46722, -7.69111);
case 241: return new CityInfo("Ferns", "L", 52.58833, -6.49972);
case 242: return new CityInfo("Fermoy", "M", 52.13583, -8.27583);
case 243: return new CityInfo("Ferbane", "L", 53.26944, -7.82694);
case 244: return new CityInfo("Fenit", "M", 52.28083, -9.8675);
case 245: return new CityInfo("Fahan", "U", 55.08861, -7.47417);
case 246: return new CityInfo("Ennistimon", "M", 52.94472, -9.29222);
case 247: return new CityInfo("Enniskerry", "L", 53.1925, -6.16917);
case 248: return new CityInfo("Enniscorthy", "L", 52.50083, -6.55778);
case 249: return new CityInfo("Ennis", "M", 52.84361, -8.98639);
case 250: return new CityInfo("Enfield", "L", 53.41419, -6.83229);
case 251: return new CityInfo("Emyvale", "U", 54.34056, -6.95917);
case 252: return new CityInfo("Elphin", "C", 53.85, -8.2);
case 253: return new CityInfo("Edgeworthstown", "L", 53.7, -7.61667);
case 254: return new CityInfo("Edenderry", "L", 53.33948, -7.04752);
case 255: return new CityInfo("Durrow", "L", 52.84417, -7.3925);
case 256: return new CityInfo("Dunshaughlin", "L", 53.5125, -6.54);
case 257: return new CityInfo("Dunmore East", "M", 52.15108, -6.99872);
case 258: return new CityInfo("Dunmore", "C", 53.61667, -8.73333);
case 259: return new CityInfo("Dunmanway", "M", 51.71667, -9.11667);
case 260: return new CityInfo("Dunlewy", "U", 55.01667, -8.1);
case 261: return new CityInfo("Dunleer", "L", 53.835, -6.39611);
case 262: return new CityInfo("Dún Laoghaire", "L", 53.29395, -6.13586);
case 263: return new CityInfo("Dunlavin", "L", 53.05556, -6.70389);
case 264: return new CityInfo("Dungloe", "U", 54.95111, -8.35917);
case 265: return new CityInfo("Dungarvan", "M", 52.08806, -7.62528);
case 266: return new CityInfo("Dundrum", "L", 53.29067, -6.25714);
case 267: return new CityInfo("Dundalk", "L", 54, -6.41667);
case 268: return new CityInfo("Dunboyne", "L", 53.41901, -6.47375);
case 269: return new CityInfo("Duleek", "L", 53.65667, -6.41917);
case 270: return new CityInfo("Dublin", "L", 53.33306, -6.24889);
case 271: return new CityInfo("Drumshanbo", "C", 54.05, -8.03333);
case 272: return new CityInfo("Drumlish", "L", 53.81667, -7.76667);
case 273: return new CityInfo("Dromahair", "C", 54.23333, -8.3);
case 274: return new CityInfo("Dromiskin", "L", 53.92538, -6.40292);
case 275: return new CityInfo("Drogheda", "L", 53.71889, -6.34778);
case 276: return new CityInfo("Doon", "M", 52.60361, -8.24444);
case 277: return new CityInfo("Dooagh", "C", 53.9748, -10.12577);
case 278: return new CityInfo("Donore", "L", 53.69306, -6.41972);
case 279: return new CityInfo("Donnybrook", "L", 53.31375, -6.22274);
case 280: return new CityInfo("Doneraile", "M", 52.21667, -8.58333);
case 281: return new CityInfo("Donegal", "U", 54.65378, -8.11134);
case 282: return new CityInfo("Donabate", "L", 53.48722, -6.15194);
case 283: return new CityInfo("Dollymount", "L", 53.36489, -6.18032);
case 284: return new CityInfo("Dingle", "M", 52.14083, -10.26889);
case 285: return new CityInfo("Derrybeg", "U", 55.08333, -8.28944);
case 286: return new CityInfo("Derry", "M", 51.58666, -9.05026);
case 287: return new CityInfo("Derrinturn", "L", 53.34167, -6.94111);
case 288: return new CityInfo("Delvin", "L", 53.61056, -7.0925);
case 289: return new CityInfo("Dalkey", "L", 53.27833, -6.10028);
case 290: return new CityInfo("Crumlin", "L", 53.32154, -6.31439);
case 291: return new CityInfo("Falcarragh", "U", 55.13333, -8.1);
case 292: return new CityInfo("Crossmolina", "C", 54.1, -9.31667);
case 293: return new CityInfo("Crosshaven", "M", 51.79833, -8.30083);
case 294: return new CityInfo("Croom", "M", 52.51944, -8.71778);
case 295: return new CityInfo("Craughwell", "C", 53.22611, -8.73306);
case 296: return new CityInfo("Cratloe", "M", 52.695, -8.75972);
case 297: return new CityInfo("Courtown", "L", 52.64424, -6.22899);
case 298: return new CityInfo("Courtmacsherry", "M", 51.63308, -8.70521);
case 299: return new CityInfo("Corrofin", "C", 53.43786, -8.86617);
case 300: return new CityInfo("Corofin", "M", 52.94778, -9.06306);
case 301: return new CityInfo("Cork", "M", 51.89797, -8.47061);
case 302: return new CityInfo("Cootehill", "U", 54.0725, -7.08194);
case 303: return new CityInfo("Coolaney", "C", 54.17806, -8.59972);
case 304: return new CityInfo("Convoy", "U", 54.86083, -7.66556);
case 305: return new CityInfo("Collooney", "C", 54.18333, -8.5);
case 306: return new CityInfo("Collon", "L", 53.78111, -6.48694);
case 307: return new CityInfo("Cobh", "M", 51.85046, -8.2948);
case 308: return new CityInfo("Cloyne", "M", 51.86278, -8.12444);
case 309: return new CityInfo("Clonmellon", "L", 53.66374, -7.01779);
case 310: return new CityInfo("Cluain Meala", "M", 52.355, -7.70389);
case 311: return new CityInfo("Clones", "U", 54.18333, -7.23333);
case 312: return new CityInfo("Clonee", "L", 53.41167, -6.44417);
case 313: return new CityInfo("Clondalkin", "L", 53.32444, -6.39722);
case 314: return new CityInfo("Clonaslee", "L", 53.1475, -7.52444);
case 315: return new CityInfo("Clonakilty", "M", 51.62306, -8.87056);
case 316: return new CityInfo("Cloughjordan", "M", 52.94028, -8.03556);
case 317: return new CityInfo("Clogherhead", "L", 53.79361, -6.2375);
case 318: return new CityInfo("Cloghan", "L", 53.22167, -7.88417);
case 319: return new CityInfo("Clifden", "C", 53.48907, -10.0191);
case 320: return new CityInfo("Claremorris", "C", 53.71667, -9);
case 321: return new CityInfo("Claregalway", "C", 53.33861, -8.945);
case 322: return new CityInfo("Clara", "L", 53.3425, -7.61389);
case 323: return new CityInfo("Clane", "L", 53.29139, -6.68917);
case 324: return new CityInfo("Churchtown", "M", 52.26667, -8.73333);
case 325: return new CityInfo("Cherryville", "L", 53.15694, -6.96667);
case 326: return new CityInfo("Ráth Luirc", "M", 52.35, -8.68333);
case 327: return new CityInfo("Charlestown", "C", 53.96417, -8.79417);
case 328: return new CityInfo("Chapelizod", "L", 53.34846, -6.34301);
case 329: return new CityInfo("Celbridge", "L", 53.34165, -6.54419);
case 330: return new CityInfo("Cavan", "U", 53.99083, -7.36056);
case 331: return new CityInfo("Castlerea", "C", 53.77258, -8.50307);
case 332: return new CityInfo("Castlepollard", "L", 53.67935, -7.29736);
case 333: return new CityInfo("Castlemartyr", "M", 51.91028, -8.05389);
case 334: return new CityInfo("Castleknock", "L", 53.37483, -6.36336);
case 335: return new CityInfo("Castleisland", "M", 52.23333, -9.46667);
case 336: return new CityInfo("Castledermot", "L", 52.90889, -6.84222);
case 337: return new CityInfo("Castlecomer", "L", 52.80611, -7.21056);
case 338: return new CityInfo("Castlebridge", "L", 52.38639, -6.44944);
case 339: return new CityInfo("Castleblayney", "U", 54.11667, -6.73333);
case 340: return new CityInfo("Castlebellingham", "L", 53.90083, -6.39028);
case 341: return new CityInfo("Castlebar", "C", 53.85, -9.3);
case 342: return new CityInfo("Cashel", "M", 52.51583, -7.88556);
case 343: return new CityInfo("Carrigtwohill", "M", 51.90833, -8.26333);
case 344: return new CityInfo("Carrigaline", "M", 51.81167, -8.39861);
case 345: return new CityInfo("Carrick-on-Suir", "M", 52.34917, -7.41306);
case 346: return new CityInfo("Carrick-on-Shannon", "C", 53.94694, -8.09);
case 347: return new CityInfo("Carrickmacross", "U", 53.97278, -6.71889);
case 348: return new CityInfo("Carraroe", "C", 53.26403, -9.59853);
case 349: return new CityInfo("Carragh", "L", 53.23634, -6.72836);
case 350: return new CityInfo("Carnew", "L", 52.70806, -6.49444);
case 351: return new CityInfo("Carndonagh", "U", 55.25, -7.26667);
case 352: return new CityInfo("Carlow", "L", 52.84083, -6.92611);
case 353: return new CityInfo("Carlingford", "L", 54.04, -6.18833);
case 354: return new CityInfo("Carlanstown", "L", 53.75943, -6.84095);
case 355: return new CityInfo("Cappoquin", "M", 52.14603, -7.8466);
case 356: return new CityInfo("Cappamore", "M", 52.61444, -8.33556);
case 357: return new CityInfo("Calverstown", "L", 53.08279, -6.7977);
case 358: return new CityInfo("Callan", "L", 52.545, -7.39111);
case 359: return new CityInfo("Cahersiveen", "M", 51.94861, -10.22222);
case 360: return new CityInfo("Caherconlish", "M", 52.59361, -8.47028);
case 361: return new CityInfo("Cahir", "M", 52.37694, -7.92167);
case 362: return new CityInfo("Cabinteely", "L", 53.26973, -6.16058);
case 363: return new CityInfo("Buttevant", "M", 52.23333, -8.66667);
case 364: return new CityInfo("Bundoran", "U", 54.47782, -8.28094);
case 365: return new CityInfo("Bunclody", "L", 52.6553, -6.65359);
case 366: return new CityInfo("Bruree", "M", 52.42194, -8.66417);
case 367: return new CityInfo("Bruff", "M", 52.47417, -8.54583);
case 368: return new CityInfo("Bray", "L", 53.20278, -6.09833);
case 369: return new CityInfo("Boyle", "C", 53.96667, -8.3);
case 370: return new CityInfo("Boston", "M", 53.03083, -8.93167);
case 371: return new CityInfo("Borrisoleigh", "M", 52.75222, -7.95306);
case 372: return new CityInfo("Borrisokane", "M", 52.99528, -8.12806);
case 373: return new CityInfo("Borris", "L", 52.6, -6.9175);
case 374: return new CityInfo("Blessington", "L", 53.17, -6.5325);
case 375: return new CityInfo("Blarney", "M", 51.93333, -8.56667);
case 376: return new CityInfo("Blanchardstown", "L", 53.38806, -6.37556);
case 377: return new CityInfo("Blackwood", "L", 53.29308, -6.81843);
case 378: return new CityInfo("Blackrock", "L", 53.96405, -6.36514);
case 379: return new CityInfo("Blackrock", "L", 53.3015, -6.1778);
case 380: return new CityInfo("Birr", "L", 53.09139, -7.91333);
case 381: return new CityInfo("Bennettsbridge", "L", 52.59194, -7.18);
case 382: return new CityInfo("Belturbet", "U", 54.1, -7.45);
case 383: return new CityInfo("Belmullet", "C", 54.225, -9.99083);
case 384: return new CityInfo("Ballinagh", "U", 53.93333, -7.41667);
case 385: return new CityInfo("Belgooly", "M", 51.73889, -8.49);
case 386: return new CityInfo("Bearna", "C", 53.25194, -9.14972);
case 387: return new CityInfo("Bantry", "M", 51.68025, -9.45254);
case 388: return new CityInfo("Bandon", "M", 51.74694, -8.7425);
case 389: return new CityInfo("Banagher", "L", 53.18861, -7.98667);
case 390: return new CityInfo("Baltinglass", "L", 52.93722, -6.70917);
case 391: return new CityInfo("Balrothery", "L", 53.58828, -6.18728);
case 392: return new CityInfo("Ballyshannon", "U", 54.5, -8.18333);
case 393: return new CityInfo("Ballyragget", "L", 52.78889, -7.33028);
case 394: return new CityInfo("Ballymote", "C", 54.08333, -8.51667);
case 395: return new CityInfo("Ballymore Eustace", "L", 53.13333, -6.61667);
case 396: return new CityInfo("Ballymahon", "L", 53.56667, -7.76667);
case 397: return new CityInfo("Ballyjamesduff", "U", 53.86528, -7.20278);
case 398: return new CityInfo("Ballyheige", "M", 52.38333, -9.83361);
case 399: return new CityInfo("Ballyhaunis", "C", 53.76667, -8.76667);
case 400: return new CityInfo("Ballyhaise", "U", 54.05, -7.31667);
case 401: return new CityInfo("Ballygarvan", "M", 51.82198, -8.46233);
case 402: return new CityInfo("Ballygar", "C", 53.52162, -8.32738);
case 403: return new CityInfo("Ballyduff", "M", 52.45593, -9.66399);
case 404: return new CityInfo("Ballyconnell", "U", 54.11667, -7.58333);
case 405: return new CityInfo("Ballyclerahan", "M", 52.41127, -7.75759);
case 406: return new CityInfo("Ballycanew", "L", 52.60889, -6.30306);
case 407: return new CityInfo("Ballybunnion", "M", 52.51108, -9.67097);
case 408: return new CityInfo("Ballybofey", "U", 54.8, -7.78333);
case 409: return new CityInfo("Ballyboden", "L", 53.28056, -6.31639);
case 410: return new CityInfo("Ballon", "L", 52.74056, -6.76778);
case 411: return new CityInfo("Ballivor", "L", 53.53167, -6.96111);
case 412: return new CityInfo("Ballitore", "L", 53.00694, -6.81944);
case 413: return new CityInfo("Ballinrobe", "C", 53.63333, -9.23333);
case 414: return new CityInfo("Ballingarry", "M", 52.47278, -8.86389);
case 415: return new CityInfo("Ballinasloe", "C", 53.3275, -8.21944);
case 416: return new CityInfo("Ballinamore", "C", 54.05, -7.8);
case 417: return new CityInfo("Ballina", "C", 54.11667, -9.16667);
case 418: return new CityInfo("Ballina", "M", 52.80778, -8.43556);
case 419: return new CityInfo("Ballaghaderreen", "C", 53.90134, -8.57507);
case 420: return new CityInfo("Balla", "C", 53.8032, -9.12913);
case 421: return new CityInfo("Baldoyle", "L", 53.39972, -6.12583);
case 422: return new CityInfo("Balbriggan", "L", 53.60846, -6.1831);
case 423: return new CityInfo("Bailieborough", "U", 53.91667, -6.96667);
case 424: return new CityInfo("Bagenalstown", "L", 52.70031, -6.96181);
case 425: return new CityInfo("Aughrim", "L", 52.85333, -6.3275);
case 426: return new CityInfo("Athy", "L", 52.99139, -6.98028);
case 427: return new CityInfo("Athgarvan", "L", 53.15229, -6.78173);
case 428: return new CityInfo("Athenry", "C", 53.29639, -8.74306);
case 429: return new CityInfo("Athboy", "L", 53.62327, -6.91434);
case 430: return new CityInfo("Askeaton", "M", 52.59972, -8.97556);
case 431: return new CityInfo("Ashbourne", "L", 53.51163, -6.39821);
case 432: return new CityInfo("Arklow", "L", 52.79443, -6.14958);
case 433: return new CityInfo("Ardnacrusha", "M", 52.70908, -8.61431);
case 434: return new CityInfo("Ardfinnan", "M", 52.31167, -7.875);
case 435: return new CityInfo("Ardfert", "M", 52.32261, -9.77774);
case 436: return new CityInfo("Ardee", "L", 53.85972, -6.54056);
case 437: return new CityInfo("Ardara", "U", 54.76444, -8.4075);
case 438: return new CityInfo("Aghada", "M", 51.83917, -8.21222);
case 439: return new CityInfo("Adare", "M", 52.56194, -8.79556);
case 440: return new CityInfo("Abbeyleix", "L", 52.91331, -7.34456);
case 441: return new CityInfo("Abbeyfeale", "M", 52.38139, -9.3025);
case 442: return new CityInfo("Castletown", "L", 52.72233, -6.18905);
case 443: return new CityInfo("Knocknalower", "C", 54.24134, -9.82198);
case 444: return new CityInfo("Portraine", "L", 53.49667, -6.11111);
case 445: return new CityInfo("Loughshinny", "L", 53.54917, -6.08278);
case 446: return new CityInfo("Drommahane", "M", 52.10472, -8.69139);
case 447: return new CityInfo("Scarriff", "M", 51.85833, -10.16806);
case 448: return new CityInfo("Ballygerry", "L", 52.24917, -6.35739);
case 449: return new CityInfo("Piercetown", "L", 52.28393, -6.48977);
case 450: return new CityInfo("Ballinroad", "L", 52.51789, -6.40619);
case 451: return new CityInfo("Mucklagh", "L", 52.81306, -6.39333);
case 452: return new CityInfo("Annacotty", "M", 52.66768, -8.53121);
case 453: return new CityInfo("Castleconnell", "M", 52.71389, -8.49944);
case 454: return new CityInfo("Nenagh Bridge", "M", 52.88167, -8.19583);
case 455: return new CityInfo("Shannon", "M", 52.70389, -8.86417);
case 456: return new CityInfo("Athlone", "L", 53.42278, -7.93722);
case 457: return new CityInfo("Kilcormac", "L", 53.17417, -7.72556);
case 458: return new CityInfo("Moate", "L", 53.39389, -7.71722);
case 459: return new CityInfo("Killenard", "L", 53.13306, -7.14861);
case 460: return new CityInfo("Suncroft", "L", 53.104, -6.86126);
case 461: return new CityInfo("Brownstown Cross Roads", "L", 53.13815, -6.84024);
case 462: return new CityInfo("Allenwood Cross Roads", "L", 53.28392, -6.86161);
case 463: return new CityInfo("Kill", "L", 53.25139, -6.59167);
case 464: return new CityInfo("Johnstown Bridge", "L", 53.40389, -6.85889);
case 465: return new CityInfo("Ashford", "L", 53.00833, -6.11139);
case 466: return new CityInfo("Kilpedder", "L", 53.10917, -6.10667);
case 467: return new CityInfo("Valleymount", "L", 53.10389, -6.55361);
case 468: return new CityInfo("Kilmacanoge", "L", 53.16722, -6.13361);
case 469: return new CityInfo("Eadestown", "L", 53.20278, -6.57806);
case 470: return new CityInfo("Little Bray", "L", 53.20444, -6.12083);
case 471: return new CityInfo("Firhouse", "L", 53.28167, -6.33917);
case 472: return new CityInfo("Sandyford", "L", 53.2747, -6.2253);
case 473: return new CityInfo("Foxrock", "L", 53.26667, -6.17417);
case 474: return new CityInfo("Sallynoggin", "L", 53.27917, -6.14058);
case 475: return new CityInfo("Rathgar", "L", 53.31457, -6.275);
case 476: return new CityInfo("Artane", "L", 53.38712, -6.2138);
case 477: return new CityInfo("Beaumont", "L", 53.38721, -6.22713);
case 478: return new CityInfo("Drumcondra", "L", 53.37058, -6.25298);
case 479: return new CityInfo("Ballymun", "L", 53.39807, -6.26693);
case 480: return new CityInfo("Cabra", "L", 53.36694, -6.29444);
case 481: return new CityInfo("Hartstown", "L", 53.39306, -6.42694);
case 482: return new CityInfo("Ballyfermot", "L", 53.34283, -6.3548);
case 483: return new CityInfo("Templeogue", "L", 53.29528, -6.30889);
case 484: return new CityInfo("Oldbawn", "L", 53.27556, -6.3675);
case 485: return new CityInfo("Cherry Orchard", "L", 53.33605, -6.37799);
case 486: return new CityInfo("Rialto", "L", 53.33625, -6.29718);
case 487: return new CityInfo("Milltown", "L", 53.31301, -6.2453);
case 488: return new CityInfo("Clonskeagh", "L", 53.31467, -6.23148);
case 489: return new CityInfo("Booterstown", "L", 53.30447, -6.19985);
case 490: return new CityInfo("Ballinteer", "L", 53.27409, -6.25397);
case 491: return new CityInfo("Greenhills", "L", 53.33467, -6.30302);
case 492: return new CityInfo("Coolock", "L", 53.3887, -6.19998);
case 493: return new CityInfo("Bonnybrook", "L", 53.39835, -6.20749);
case 494: return new CityInfo("Donaghmede", "L", 53.39845, -6.16179);
case 495: return new CityInfo("Darndale", "L", 53.39948, -6.18886);
case 496: return new CityInfo("Donnycarney", "L", 53.3735, -6.20976);
case 497: return new CityInfo("Bayside", "L", 53.38895, -6.14041);
case 498: return new CityInfo("Charlesland", "L", 53.12771, -6.06347);
case 499: return new CityInfo("Moyross", "M", 52.68198, -8.63955);
case 500: return new CityInfo("Ballisodare", "C", 54.2111, -8.50865);
case 501: return new CityInfo("Ballylinan", "L", 52.94497, -7.04073);
case 502: return new CityInfo("Enniskeane", "M", 51.73793, -8.93154);
case 503: return new CityInfo("Fairview", "L", 53.36597, -6.23985);
case 504: return new CityInfo("Knocklyon", "L", 53.2803, -6.3313);
case 505: return new CityInfo("Palmerstown", "L", 53.35019, -6.37778);
case 506: return new CityInfo("Clonlara", "M", 52.72439, -8.55251);
case 507: return new CityInfo("Castlefin", "U", 54.80306, -7.59567);
case 508: return new CityInfo("Jobstown", "L", 53.27866, -6.40803);
case 509: return new CityInfo("Killester", "L", 53.37322, -6.20431);
case 510: return new CityInfo("Mountbellew", "C", 53.47185, -8.50436);
case 511: return new CityInfo("Confey", "L", 53.37923, -6.49052);
case 512: return new CityInfo("Dromcollogher", "M", 52.33953, -8.90837);
case 513: return new CityInfo("Kilfinnane", "M", 52.35914, -8.4684);
case 514: return new CityInfo("Newtownforbes", "L", 53.76718, -7.8336);
case 515: return new CityInfo("Kentstown", "L", 53.62754, -6.52674);
case 516: return new CityInfo("Kilquade", "L", 53.09743, -6.08411);
case 517: return new CityInfo("Newtownmountkennedy", "L", 53.09052, -6.11149);
case 518: return new CityInfo("Balally", "L", 53.27504, -6.23594);
case 519: return new CityInfo("Moneenroe", "L", 52.84, -7.15549);
case 520: return new CityInfo("Fountainstown", "M", 51.78392, -8.30097);
case 521: return new CityInfo("Ballycannan", "M", 52.70199, -8.65061);
case 522: return new CityInfo("Rathard", "M", 51.84816, -8.73812);
case 523: return new CityInfo("Rivermeade", "L", 53.45291, -6.29115);
case 524: return new CityInfo("Kinsealy-Drinan", "L", 53.44395, -6.20334);
case 525: return new CityInfo("Courtbrack", "M", 51.96677, -8.64611);
default: return new CityInfo("Ballybofey-Stranorlar", "U", 54.80165, -7.77437);

                                    }                                        
                                }
                            
                        }
                    }
                