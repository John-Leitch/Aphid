
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
                                    public const string Country = "UY";
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
                            
                                        var cur = (Math.Abs(-32.69844 - lat) + Math.Abs(-57.62693 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-33.2534 - lat) + Math.Abs(-54.41947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.23943 - lat) + Math.Abs(-56.00936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.77794 - lat) + Math.Abs(-54.69183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.94419 - lat) + Math.Abs(-53.9381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.03631 - lat) + Math.Abs(-54.28054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.18917 - lat) + Math.Abs(-56.33944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.41167 - lat) + Math.Abs(-56.40222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.83333 - lat) + Math.Abs(-54.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.5165 - lat) + Math.Abs(-56.89957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.23333 - lat) + Math.Abs(-54.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.2 - lat) + Math.Abs(-55.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.4287 - lat) + Math.Abs(-57.43609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.73807 - lat) + Math.Abs(-56.09469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.26555 - lat) + Math.Abs(-57.61866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.34349 - lat) + Math.Abs(-55.76375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.71694 - lat) + Math.Abs(-55.98111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.39811 - lat) + Math.Abs(-58.32177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.59951 - lat) + Math.Abs(-55.46808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.68432 - lat) + Math.Abs(-55.702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.65191 - lat) + Math.Abs(-56.06431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.73333 - lat) + Math.Abs(-56.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.35 - lat) + Math.Abs(-55.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.79028 - lat) + Math.Abs(-56.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.49819 - lat) + Math.Abs(-56.03795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.45333 - lat) + Math.Abs(-56.39056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.92254 - lat) + Math.Abs(-54.94447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.791 - lat) + Math.Abs(-57.48824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.3536 - lat) + Math.Abs(-56.52498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.29155 - lat) + Math.Abs(-55.95571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.3375 - lat) + Math.Abs(-56.71361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.66523 - lat) + Math.Abs(-58.1332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.54465 - lat) + Math.Abs(-55.87151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.34631 - lat) + Math.Abs(-58.10094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.79123 - lat) + Math.Abs(-54.91824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.44016 - lat) + Math.Abs(-55.95861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.4513 - lat) + Math.Abs(-56.08036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.38333 - lat) + Math.Abs(-57.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.31667 - lat) + Math.Abs(-57.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.381 - lat) + Math.Abs(-56.53797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.48333 - lat) + Math.Abs(-54.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.90534 - lat) + Math.Abs(-55.55076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.59802 - lat) + Math.Abs(-53.38583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.52335 - lat) + Math.Abs(-56.7971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.93526 - lat) + Math.Abs(-57.9014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.94747 - lat) + Math.Abs(-54.93382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.66737 - lat) + Math.Abs(-56.21758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.37085 - lat) + Math.Abs(-57.85371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.86287 - lat) + Math.Abs(-55.27471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.37183 - lat) + Math.Abs(-57.60901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.3171 - lat) + Math.Abs(-58.08072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.81667 - lat) + Math.Abs(-56.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.86028 - lat) + Math.Abs(-56.05222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.71716 - lat) + Math.Abs(-55.9584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.7787 - lat) + Math.Abs(-55.23582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.50719 - lat) + Math.Abs(-57.80079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.93783 - lat) + Math.Abs(-57.80959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.97974 - lat) + Math.Abs(-58.05858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.87031 - lat) + Math.Abs(-58.41176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.3 - lat) + Math.Abs(-57.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.90328 - lat) + Math.Abs(-56.18816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.49339 - lat) + Math.Abs(-55.56219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.57375 - lat) + Math.Abs(-55.47075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.37589 - lat) + Math.Abs(-55.23771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.48759 - lat) + Math.Abs(-55.62793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.2524 - lat) + Math.Abs(-58.03047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.37028 - lat) + Math.Abs(-54.1675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.04085 - lat) + Math.Abs(-54.77732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.9 - lat) + Math.Abs(-54.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.605 - lat) + Math.Abs(-56.35639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.63459 - lat) + Math.Abs(-56.61739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.73333 - lat) + Math.Abs(-55.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.7302 - lat) + Math.Abs(-56.21915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.26204 - lat) + Math.Abs(-57.58174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.67235 - lat) + Math.Abs(-54.2065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.76031 - lat) + Math.Abs(-56.2259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.66268 - lat) + Math.Abs(-54.16452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.72689 - lat) + Math.Abs(-55.5827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.75572 - lat) + Math.Abs(-55.68141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.41888 - lat) + Math.Abs(-57.45285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.45451 - lat) + Math.Abs(-54.53586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.69618 - lat) + Math.Abs(-57.53153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.46667 - lat) + Math.Abs(-55.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.73501 - lat) + Math.Abs(-56.0347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.59454 - lat) + Math.Abs(-56.25334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.96218 - lat) + Math.Abs(-54.12309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.35846 - lat) + Math.Abs(-57.19778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.11651 - lat) + Math.Abs(-58.31067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.09556 - lat) + Math.Abs(-56.21417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.87785 - lat) + Math.Abs(-57.37166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.69753 - lat) + Math.Abs(-55.89268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.35778 - lat) + Math.Abs(-57.04883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.38056 - lat) + Math.Abs(-56.52361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.53009 - lat) + Math.Abs(-58.21701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.68216 - lat) + Math.Abs(-53.55325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.76488 - lat) + Math.Abs(-56.3645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.15 - lat) + Math.Abs(-56.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.06913 - lat) + Math.Abs(-57.84946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.46262 - lat) + Math.Abs(-57.83976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.69792 - lat) + Math.Abs(-53.45926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.86252 - lat) + Math.Abs(-55.54264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.26703 - lat) + Math.Abs(-53.79425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.09994 - lat) + Math.Abs(-55.64811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.19871 - lat) + Math.Abs(-53.85919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.00023 - lat) + Math.Abs(-58.28402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.05658 - lat) + Math.Abs(-56.47652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-33.87049 - lat) + Math.Abs(-57.36954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.29056 - lat) + Math.Abs(-56.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.52278 - lat) + Math.Abs(-56.27778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-32.76667 - lat) + Math.Abs(-55.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.25966 - lat) + Math.Abs(-57.59919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.78716 - lat) + Math.Abs(-57.77577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.71905 - lat) + Math.Abs(-57.32596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.7719 - lat) + Math.Abs(-55.7584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.4 - lat) + Math.Abs(-56.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.20498 - lat) + Math.Abs(-54.75665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.52194 - lat) + Math.Abs(-56.39361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-31.87178 - lat) + Math.Abs(-54.16351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.5855 - lat) + Math.Abs(-56.70097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.81516 - lat) + Math.Abs(-56.02435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.87722 - lat) + Math.Abs(-56.02972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.80167 - lat) + Math.Abs(-56.33417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.7524 - lat) + Math.Abs(-56.00259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Young", "12", -32.69844, -57.62693);
case 1: return new CityInfo("Villa Sara", "19", -33.2534, -54.41947);
case 2: return new CityInfo("Villa del Carmen", "05", -33.23943, -56.00936);
case 3: return new CityInfo("Vichadero", "13", -31.77794, -54.69183);
case 4: return new CityInfo("Vergara", "19", -32.94419, -53.9381);
case 5: return new CityInfo("Velázquez", "14", -34.03631, -54.28054);
case 6: return new CityInfo("25 de Mayo", "07", -34.18917, -56.33944);
case 7: return new CityInfo("25 de Agosto", "07", -34.41167, -56.40222);
case 8: return new CityInfo("Tupambaé", "03", -32.83333, -54.76667);
case 9: return new CityInfo("Trinidad", "06", -33.5165, -56.89957);
case 10: return new CityInfo("Treinta y Tres", "19", -33.23333, -54.38333);
case 11: return new CityInfo("Tranqueras", "13", -31.2, -55.75);
case 12: return new CityInfo("Tomás Gomensoro", "01", -30.4287, -57.43609);
case 13: return new CityInfo("Toledo", "02", -34.73807, -56.09469);
case 14: return new CityInfo("Tarariras", "04", -34.26555, -57.61866);
case 15: return new CityInfo("Tala", "02", -34.34349, -55.76375);
case 16: return new CityInfo("Tacuarembó", "18", -31.71694, -55.98111);
case 17: return new CityInfo("Villa Soriano", "17", -33.39811, -58.32177);
case 18: return new CityInfo("Solís de Mataojo", "08", -34.59951, -55.46808);
case 19: return new CityInfo("Soca", "02", -34.68432, -55.702);
case 20: return new CityInfo("Sauce", "02", -34.65191, -56.06431);
case 21: return new CityInfo("Sarandí Grande", "07", -33.73333, -56.33333);
case 22: return new CityInfo("Sarandí del Yi", "05", -33.35, -55.63333);
case 23: return new CityInfo("Santiago Vázquez", "10", -34.79028, -56.35);
case 24: return new CityInfo("Santa Rosa", "02", -34.49819, -56.03795);
case 25: return new CityInfo("Santa Lucía", "02", -34.45333, -56.39056);
case 26: return new CityInfo("Santa Clara de Olimar", "19", -32.92254, -54.94447);
case 27: return new CityInfo("Santa Catalina", "17", -33.791, -57.48824);
case 28: return new CityInfo("Santa Bernardina", "05", -33.3536, -56.52498);
case 29: return new CityInfo("San Ramón", "02", -34.29155, -55.95571);
case 30: return new CityInfo("San José de Mayo", "16", -34.3375, -56.71361);
case 31: return new CityInfo("San Javier", "12", -32.66523, -58.1332);
case 32: return new CityInfo("San Jacinto", "02", -34.54465, -55.87151);
case 33: return new CityInfo("San Félix", "11", -32.34631, -58.10094);
case 34: return new CityInfo("San Carlos", "09", -34.79123, -54.91824);
case 35: return new CityInfo("San Bautista", "02", -34.44016, -55.95861);
case 36: return new CityInfo("San Antonio", "02", -34.4513, -56.08036);
case 37: return new CityInfo("Salto", "15", -31.38333, -57.96667);
case 38: return new CityInfo("Rosario", "04", -34.31667, -57.35);
case 39: return new CityInfo("Rodríguez", "16", -34.381, -56.53797);
case 40: return new CityInfo("Rocha", "14", -34.48333, -54.33333);
case 41: return new CityInfo("Rivera", "13", -30.90534, -55.55076);
case 42: return new CityInfo("Río Branco", "03", -32.59802, -53.38583);
case 43: return new CityInfo("Rafael Perazza", "16", -34.52335, -56.7971);
case 44: return new CityInfo("Quebracho", "11", -31.93526, -57.9014);
case 45: return new CityInfo("Punta del Este", "09", -34.94747, -54.93382);
case 46: return new CityInfo("Progreso", "02", -34.66737, -56.21758);
case 47: return new CityInfo("Estación Porvenir", "11", -32.37085, -57.85371);
case 48: return new CityInfo("Piriápolis", "09", -34.86287, -55.27471);
case 49: return new CityInfo("Piedras Coloradas", "11", -32.37183, -57.60901);
case 50: return new CityInfo("Paysandú", "11", -32.3171, -58.08072);
case 51: return new CityInfo("Paso de los Toros", "18", -32.81667, -56.51667);
case 52: return new CityInfo("Paso de Carrasco", "02", -34.86028, -56.05222);
case 53: return new CityInfo("Pando", "02", -34.71716, -55.9584);
case 54: return new CityInfo("Pan de Azúcar", "09", -34.7787, -55.23582);
case 55: return new CityInfo("Palmitas", "17", -33.50719, -57.80079);
case 56: return new CityInfo("Ombúes de Lavalle", "04", -33.93783, -57.80959);
case 57: return new CityInfo("Nuevo Berlín", "12", -32.97974, -58.05858);
case 58: return new CityInfo("Nueva Palmira", "04", -33.87031, -58.41176);
case 59: return new CityInfo("Nueva Helvecia", "04", -34.3, -57.23333);
case 60: return new CityInfo("Montevideo", "10", -34.90328, -56.18816);
case 61: return new CityInfo("Montes", "02", -34.49339, -55.56219);
case 62: return new CityInfo("Minas de Corrales", "13", -31.57375, -55.47075);
case 63: return new CityInfo("Minas", "08", -34.37589, -55.23771);
case 64: return new CityInfo("Migues", "02", -34.48759, -55.62793);
case 65: return new CityInfo("Mercedes", "17", -33.2524, -58.03047);
case 66: return new CityInfo("Melo", "03", -32.37028, -54.1675);
case 67: return new CityInfo("Mariscala", "08", -34.04085, -54.77732);
case 68: return new CityInfo("Maldonado", "09", -34.9, -54.95);
case 69: return new CityInfo("Los Cerrillos", "02", -34.605, -56.35639);
case 70: return new CityInfo("Libertad", "16", -34.63459, -56.61739);
case 71: return new CityInfo("Las Toscas", "02", -34.73333, -55.71667);
case 72: return new CityInfo("Las Piedras", "02", -34.7302, -56.21915);
case 73: return new CityInfo("Las Piedras", "01", -30.26204, -57.58174);
case 74: return new CityInfo("Lascano", "14", -33.67235, -54.2065);
case 75: return new CityInfo("La Paz", "02", -34.76031, -56.2259);
case 76: return new CityInfo("La Paloma", "14", -34.66268, -54.16452);
case 77: return new CityInfo("La Paloma", "05", -32.72689, -55.5827);
case 78: return new CityInfo("La Floresta", "02", -34.75572, -55.68141);
case 79: return new CityInfo("Juan L. Lacaze", "04", -34.41888, -57.45285);
case 80: return new CityInfo("José Pedro Varela", "08", -33.45451, -54.53586);
case 81: return new CityInfo("José Enrique Rodó", "17", -33.69618, -57.53153);
case 82: return new CityInfo("José Batlle y Ordóñez", "08", -33.46667, -55.11667);
case 83: return new CityInfo("Joaquín Suárez", "02", -34.73501, -56.0347);
case 84: return new CityInfo("Juanicó", "02", -34.59454, -56.25334);
case 85: return new CityInfo("Isidoro Noblía", "03", -31.96218, -54.12309);
case 86: return new CityInfo("Guichón", "11", -32.35846, -57.19778);
case 87: return new CityInfo("Fray Bentos", "12", -33.11651, -58.31067);
case 88: return new CityInfo("Florida", "07", -34.09556, -56.21417);
case 89: return new CityInfo("Florencio Sánchez", "04", -33.87785, -57.37166);
case 90: return new CityInfo("Empalme Olmos", "02", -34.69753, -55.89268);
case 91: return new CityInfo("Ecilda Paullier", "16", -34.35778, -57.04883);
case 92: return new CityInfo("Durazno", "05", -33.38056, -56.52361);
case 93: return new CityInfo("Dolores", "17", -33.53009, -58.21701);
case 94: return new CityInfo("Dieciocho de Julio", "14", -33.68216, -53.55325);
case 95: return new CityInfo("Delta del Tigre", "16", -34.76488, -56.3645);
case 96: return new CityInfo("Curtina", "18", -32.15, -56.11667);
case 97: return new CityInfo("Villa Constitución", "15", -31.06913, -57.84946);
case 98: return new CityInfo("Colonia del Sacramento", "04", -34.46262, -57.83976);
case 99: return new CityInfo("Chui", "14", -33.69792, -53.45926);
case 100: return new CityInfo("Alejandro Gallinal", "07", -33.86252, -55.54264);
case 101: return new CityInfo("Cebollatí", "14", -33.26703, -53.79425);
case 102: return new CityInfo("Casupá", "07", -34.09994, -55.64811);
case 103: return new CityInfo("Castillos", "14", -34.19871, -53.85919);
case 104: return new CityInfo("Carmelo", "04", -34.00023, -58.28402);
case 105: return new CityInfo("Carlos Reyles", "05", -33.05658, -56.47652);
case 106: return new CityInfo("Cardona", "17", -33.87049, -57.36954);
case 107: return new CityInfo("Cardal", "07", -34.29056, -56.38889);
case 108: return new CityInfo("Canelones", "02", -34.52278, -56.27778);
case 109: return new CityInfo("Blanquillo", "05", -32.76667, -55.63333);
case 110: return new CityInfo("Bella Unión", "01", -30.25966, -57.59919);
case 111: return new CityInfo("Belén", "15", -30.78716, -57.77577);
case 112: return new CityInfo("Baltasar Brum", "01", -30.71905, -57.32596);
case 113: return new CityInfo("Atlántida", "02", -34.7719, -55.7584);
case 114: return new CityInfo("Artigas", "01", -30.4, -56.46667);
case 115: return new CityInfo("Aiguá", "09", -34.20498, -54.75665);
case 116: return new CityInfo("Aguas Corrientes", "02", -34.52194, -56.39361);
case 117: return new CityInfo("Aceguá", "03", -31.87178, -54.16351);
case 118: return new CityInfo("Puntas de Valdéz", "16", -34.5855, -56.70097);
case 119: return new CityInfo("Colonia Nicolich", "02", -34.81516, -56.02435);
case 120: return new CityInfo("Barra de Carrasco", "02", -34.87722, -56.02972);
case 121: return new CityInfo("Pajas Blancas", "10", -34.80167, -56.33417);
default: return new CityInfo("Barros Blancos", "02", -34.7524, -56.00259);

                                    }                                        
                                }
                            
                        }
                    }
                