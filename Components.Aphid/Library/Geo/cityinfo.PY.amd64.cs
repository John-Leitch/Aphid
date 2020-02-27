
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
                                    public const string Country = "PY";
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
                            
                                        var cur = (Math.Abs(-26.61471 - lat) + Math.Abs(-56.24607 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-25.40777 - lat) + Math.Abs(-57.28889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.05784 - lat) + Math.Abs(-55.92267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.12371 - lat) + Math.Abs(-55.64418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.45 - lat) + Math.Abs(-56.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.7581 - lat) + Math.Abs(-56.80249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.01667 - lat) + Math.Abs(-57.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.83333 - lat) + Math.Abs(-56.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.56139 - lat) + Math.Abs(-57.28343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.74946 - lat) + Math.Abs(-56.43518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.01614 - lat) + Math.Abs(-57.85589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.09306 - lat) + Math.Abs(-57.52361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.38333 - lat) + Math.Abs(-57.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3676 - lat) + Math.Abs(-57.59274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.7 - lat) + Math.Abs(-56.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.59595 - lat) + Math.Abs(-56.87073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.8079 - lat) + Math.Abs(-56.52148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.11667 - lat) + Math.Abs(-55.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.26111 - lat) + Math.Abs(-57.08329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.45 - lat) + Math.Abs(-56.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.66652 - lat) + Math.Abs(-56.95215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.1431 - lat) + Math.Abs(-56.76803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.8873 - lat) + Math.Abs(-56.84905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.78333 - lat) + Math.Abs(-55.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.78333 - lat) + Math.Abs(-56.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.41327 - lat) + Math.Abs(-56.79708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.08534 - lat) + Math.Abs(-57.08745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.83268 - lat) + Math.Abs(-56.20575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.96667 - lat) + Math.Abs(-56.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.15 - lat) + Math.Abs(-57.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.5 - lat) + Math.Abs(-57.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.33968 - lat) + Math.Abs(-57.50879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.16667 - lat) + Math.Abs(-57.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.11229 - lat) + Math.Abs(-55.93861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.30168 - lat) + Math.Abs(-55.96509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.66944 - lat) + Math.Abs(-57.14583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.53333 - lat) + Math.Abs(-56.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.02853 - lat) + Math.Abs(-56.0428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.47184 - lat) + Math.Abs(-55.69227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.31741 - lat) + Math.Abs(-56.33087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.26667 - lat) + Math.Abs(-57.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.31067 - lat) + Math.Abs(-57.29628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.42126 - lat) + Math.Abs(-57.54725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.96667 - lat) + Math.Abs(-54.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.0625 - lat) + Math.Abs(-54.30694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.53333 - lat) + Math.Abs(-55.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23333 - lat) + Math.Abs(-56.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.97606 - lat) + Math.Abs(-57.23353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.44127 - lat) + Math.Abs(-57.14272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.4 - lat) + Math.Abs(-54.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.15304 - lat) + Math.Abs(-56.92837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.56384 - lat) + Math.Abs(-54.61097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.46498 - lat) + Math.Abs(-57.04183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.48406 - lat) + Math.Abs(-57.2349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.86012 - lat) + Math.Abs(-55.54357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.85874 - lat) + Math.Abs(-58.30639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.54722 - lat) + Math.Abs(-55.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.24418 - lat) + Math.Abs(-58.54143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.62083 - lat) + Math.Abs(-57.14722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.03333 - lat) + Math.Abs(-55.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.95052 - lat) + Math.Abs(-56.3296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.40402 - lat) + Math.Abs(-56.54938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.6108 - lat) + Math.Abs(-57.46563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.91137 - lat) + Math.Abs(-56.70091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.18333 - lat) + Math.Abs(-57.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3949 - lat) + Math.Abs(-57.53574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.75702 - lat) + Math.Abs(-55.13777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.63333 - lat) + Math.Abs(-56.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.96667 - lat) + Math.Abs(-55.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.2793 - lat) + Math.Abs(-57.70307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.01667 - lat) + Math.Abs(-54.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.21921 - lat) + Math.Abs(-56.75777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.97518 - lat) + Math.Abs(-56.30927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.71938 - lat) + Math.Abs(-56.42179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.18271 - lat) + Math.Abs(-56.47282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.65668 - lat) + Math.Abs(-54.72272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.16611 - lat) + Math.Abs(-57.48562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.88327 - lat) + Math.Abs(-56.48217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.25186 - lat) + Math.Abs(-57.46075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.12957 - lat) + Math.Abs(-54.61376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.34682 - lat) + Math.Abs(-57.60647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.88627 - lat) + Math.Abs(-56.84084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.05598 - lat) + Math.Abs(-55.7413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.05508 - lat) + Math.Abs(-56.48463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.39258 - lat) + Math.Abs(-57.35421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.98611 - lat) + Math.Abs(-55.14963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.58035 - lat) + Math.Abs(-55.5819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.85172 - lat) + Math.Abs(-56.61385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.53541 - lat) + Math.Abs(-56.82352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.46158 - lat) + Math.Abs(-56.85333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.50054 - lat) + Math.Abs(-57.36717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.30853 - lat) + Math.Abs(-56.89986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.691 - lat) + Math.Abs(-56.26781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.07315 - lat) + Math.Abs(-55.64247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.53333 - lat) + Math.Abs(-56.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.49096 - lat) + Math.Abs(-57.45567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.20136 - lat) + Math.Abs(-58.3674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.95 - lat) + Math.Abs(-55.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.44417 - lat) + Math.Abs(-56.90061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.09046 - lat) + Math.Abs(-56.52474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.93522 - lat) + Math.Abs(-56.22168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.04153 - lat) + Math.Abs(-57.87377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.98333 - lat) + Math.Abs(-55.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3386 - lat) + Math.Abs(-57.52167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.74199 - lat) + Math.Abs(-56.52278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.38276 - lat) + Math.Abs(-56.96088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.33056 - lat) + Math.Abs(-55.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.15 - lat) + Math.Abs(-57.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.76734 - lat) + Math.Abs(-55.27872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3838 - lat) + Math.Abs(-55.83215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.43053 - lat) + Math.Abs(-55.25412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.07158 - lat) + Math.Abs(-56.24386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.0804 - lat) + Math.Abs(-54.93933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.44444 - lat) + Math.Abs(-56.44028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.75862 - lat) + Math.Abs(-56.61677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.39985 - lat) + Math.Abs(-57.43236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.46187 - lat) + Math.Abs(-55.00007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.86667 - lat) + Math.Abs(-54.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.36667 - lat) + Math.Abs(-59.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.56667 - lat) + Math.Abs(-56.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.20791 - lat) + Math.Abs(-57.53202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.36395 - lat) + Math.Abs(-55.7069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.13333 - lat) + Math.Abs(-54.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.50972 - lat) + Math.Abs(-54.61111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.18606 - lat) + Math.Abs(-56.58251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.34215 - lat) + Math.Abs(-57.64119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.22232 - lat) + Math.Abs(-56.15243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.39853 - lat) + Math.Abs(-54.7569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.1975 - lat) + Math.Abs(-56.39878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.8 - lat) + Math.Abs(-57.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.23844 - lat) + Math.Abs(-56.82693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.2 - lat) + Math.Abs(-55.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.01667 - lat) + Math.Abs(-55.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.26667 - lat) + Math.Abs(-55.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.8 - lat) + Math.Abs(-56.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3552 - lat) + Math.Abs(-57.44545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.35901 - lat) + Math.Abs(-55.76131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.19583 - lat) + Math.Abs(-56.36806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.23523 - lat) + Math.Abs(-57.18212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.47104 - lat) + Math.Abs(-56.01603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.38575 - lat) + Math.Abs(-57.14217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.18387 - lat) + Math.Abs(-56.08171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.96667 - lat) + Math.Abs(-57.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.05 - lat) + Math.Abs(-55.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.13333 - lat) + Math.Abs(-56.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.46611 - lat) + Math.Abs(-57.26194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-27.38662 - lat) + Math.Abs(-56.84724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.27876 - lat) + Math.Abs(-57.17192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.28646 - lat) + Math.Abs(-57.647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.05478 - lat) + Math.Abs(-57.09873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.48333 - lat) + Math.Abs(-55.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3125 - lat) + Math.Abs(-57.38472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.08526 - lat) + Math.Abs(-57.20221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.58333 - lat) + Math.Abs(-55.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.26263 - lat) + Math.Abs(-57.25443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.91667 - lat) + Math.Abs(-57.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.03333 - lat) + Math.Abs(-55.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.34278 - lat) + Math.Abs(-57.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.33936 - lat) + Math.Abs(-60.03157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.66667 - lat) + Math.Abs(-60.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.91667 - lat) + Math.Abs(-60.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.5076 - lat) + Math.Abs(-54.8551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-26.49324 - lat) + Math.Abs(-54.79989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yuty", "05", -26.61471, -56.24607);
case 1: return new CityInfo("Ypacarai", "06", -25.40777, -57.28889);
case 2: return new CityInfo("Yhú", "04", -25.05784, -55.92267);
case 3: return new CityInfo("Ygatimi", "19", -24.12371, -55.64418);
case 4: return new CityInfo("Yegros", "05", -26.45, -56.4);
case 5: return new CityInfo("Ybytymi", "15", -25.7581, -56.80249);
case 6: return new CityInfo("Ybycuí", "15", -26.01667, -57.05);
case 7: return new CityInfo("Yataity del Norte", "17", -24.83333, -56.35);
case 8: return new CityInfo("Yaguarón", "15", -25.56139, -57.28343);
case 9: return new CityInfo("Villarrica", "10", -25.74946, -56.43518);
case 10: return new CityInfo("Villa Oliva", "13", -26.01614, -57.85589);
case 11: return new CityInfo("Villa Hayes", "16", -25.09306, -57.52361);
case 12: return new CityInfo("Villa Florida", "12", -26.38333, -57.15);
case 13: return new CityInfo("Villa Elisa", "06", -25.3676, -57.59274);
case 14: return new CityInfo("Veinticinco de Diciembre", "17", -24.7, -56.55);
case 15: return new CityInfo("Valenzuela", "08", -25.59595, -56.87073);
case 16: return new CityInfo("Unión", "17", -24.8079, -56.52148);
case 17: return new CityInfo("Trinidad", "11", -27.11667, -55.78333);
case 18: return new CityInfo("Tobatí", "08", -25.26111, -57.08329);
case 19: return new CityInfo("Tacuatí", "17", -23.45, -56.58333);
case 20: return new CityInfo("Sapucaí", "15", -25.66652, -56.95215);
case 21: return new CityInfo("Santiago", "12", -27.1431, -56.76803);
case 22: return new CityInfo("Santa Rosa Misiones", "12", -26.8873, -56.84905);
case 23: return new CityInfo("Santa Rita", "01", -25.78333, -55.06667);
case 24: return new CityInfo("Santa María", "12", -26.78333, -56.93333);
case 25: return new CityInfo("Santa Elena", "08", -25.41327, -56.79708);
case 26: return new CityInfo("San Pedro de Ycuamandiyú", "17", -24.08534, -57.08745);
case 27: return new CityInfo("San Pedro del Paraná", "11", -26.83268, -56.20575);
case 28: return new CityInfo("San Patricio", "12", -26.96667, -56.81667);
case 29: return new CityInfo("San Pablo de Ycuámandyyú", "17", -24.15, -57.06667);
case 30: return new CityInfo("San Miguel", "12", -26.5, -57.05);
case 31: return new CityInfo("San Lorenzo", "06", -25.33968, -57.50879);
case 32: return new CityInfo("San Lázaro", "07", -22.16667, -57.91667);
case 33: return new CityInfo("San Juan Nepomuceno", "05", -26.11229, -55.93861);
case 34: return new CityInfo("San Juan del Paraná", "11", -27.30168, -55.96509);
case 35: return new CityInfo("San Juan Bautista", "12", -26.66944, -57.14583);
case 36: return new CityInfo("San José", "04", -25.53333, -56.73333);
case 37: return new CityInfo("San Joaquín", "04", -25.02853, -56.0428);
case 38: return new CityInfo("San Isidro de Curuguaty", "19", -24.47184, -55.69227);
case 39: return new CityInfo("San Cosme y Damián", "11", -27.31741, -56.33087);
case 40: return new CityInfo("San Carlos", "07", -22.26667, -57.3);
case 41: return new CityInfo("San Bernardino", "08", -25.31067, -57.29628);
case 42: return new CityInfo("San Antonio", "06", -25.42126, -57.54725);
case 43: return new CityInfo("San Alberto", "01", -24.96667, -54.9);
case 44: return new CityInfo("Salto del Guairá", "19", -24.0625, -54.30694);
case 45: return new CityInfo("Repatriación", "04", -25.53333, -55.95);
case 46: return new CityInfo("Quyquyó", "15", -26.23333, -56.98333);
case 47: return new CityInfo("Quiindy", "15", -25.97606, -57.23353);
case 48: return new CityInfo("Puerto Rosario", "17", -24.44127, -57.14272);
case 49: return new CityInfo("Puerto Mayor Otaño", "11", -26.4, -54.7);
case 50: return new CityInfo("Primero de Marzo", "08", -25.15304, -56.92837);
case 51: return new CityInfo("Presidente Franco", "01", -25.56384, -54.61097);
case 52: return new CityInfo("Piribebuy", "08", -25.46498, -57.04183);
case 53: return new CityInfo("Pirayú", "15", -25.48406, -57.2349);
case 54: return new CityInfo("Pirapó", "11", -26.86012, -55.54357);
case 55: return new CityInfo("Pilar", "13", -26.85874, -58.30639);
case 56: return new CityInfo("Pedro Juan Caballero", "02", -22.54722, -55.73333);
case 57: return new CityInfo("Paso de Patria", "13", -27.24418, -58.54143);
case 58: return new CityInfo("Paraguarí", "15", -25.62083, -57.14722);
case 59: return new CityInfo("Obligado", "11", -27.03333, -55.63333);
case 60: return new CityInfo("Ñumi", "10", -25.95052, -56.3296);
case 61: return new CityInfo("Nueva Londres", "04", -25.40402, -56.54938);
case 62: return new CityInfo("Nueva Italia", "06", -25.6108, -57.46563);
case 63: return new CityInfo("Colonia Nueva Germania", "17", -23.91137, -56.70091);
case 64: return new CityInfo("Nueva Colombia", "08", -25.18333, -57.35);
case 65: return new CityInfo("Nemby", "06", -25.3949, -57.53574);
case 66: return new CityInfo("Natalio", "11", -26.75702, -55.13777);
case 67: return new CityInfo("Natalicio Talavera", "10", -25.63333, -56.3);
case 68: return new CityInfo("Naranjal", "01", -25.96667, -55.18333);
case 69: return new CityInfo("Nanawua", "16", -25.2793, -57.70307);
case 70: return new CityInfo("Ñacunday", "01", -26.01667, -54.76667);
case 71: return new CityInfo("Mbuyapey", "15", -26.21921, -56.75777);
case 72: return new CityInfo("Mbutuý", "04", -24.97518, -56.30927);
case 73: return new CityInfo("Mbocayaty", "10", -25.71938, -56.42179);
case 74: return new CityInfo("Maciel", "05", -26.18271, -56.47282);
case 75: return new CityInfo("Cedrales", "01", -25.65668, -54.72272);
case 76: return new CityInfo("Limpio", "06", -25.16611, -57.48562);
case 77: return new CityInfo("Lima", "17", -23.88327, -56.48217);
case 78: return new CityInfo("Laureles", "13", -27.25186, -57.46075);
case 79: return new CityInfo("La Paloma", "19", -24.12957, -54.61376);
case 80: return new CityInfo("Lambaré", "06", -25.34682, -57.60647);
case 81: return new CityInfo("La Colmena", "15", -25.88627, -56.84084);
case 82: return new CityInfo("Jesús", "11", -27.05598, -55.7413);
case 83: return new CityInfo("Iturbe", "10", -26.05508, -56.48463);
case 84: return new CityInfo("Itauguá", "06", -25.39258, -57.35421);
case 85: return new CityInfo("Itakyry", "01", -24.98611, -55.14963);
case 86: return new CityInfo("Itapuá Poty", "11", -26.58035, -55.5819);
case 87: return new CityInfo("Itapé", "10", -25.85172, -56.61385);
case 88: return new CityInfo("Itacurubí del Rosario", "17", -24.53541, -56.82352);
case 89: return new CityInfo("Itacurubí de la Cordillera", "08", -25.46158, -56.85333);
case 90: return new CityInfo("Itá", "06", -25.50054, -57.36717);
case 91: return new CityInfo("Isla Pucú", "08", -25.30853, -56.89986);
case 92: return new CityInfo("Independencia", "10", -25.691, -56.26781);
case 93: return new CityInfo("Hohenau", "11", -27.07315, -55.64247);
case 94: return new CityInfo("Guayaybi", "17", -24.53333, -56.43333);
case 95: return new CityInfo("Guarambaré", "06", -25.49096, -57.45567);
case 96: return new CityInfo("General José Eduvigis Díaz", "13", -27.20136, -58.3674);
case 97: return new CityInfo("General Higinio Morínigo", "05", -25.95, -55.91667);
case 98: return new CityInfo("General Elizardo Aquino", "17", -24.44417, -56.90061);
case 99: return new CityInfo("General Delgado", "11", -27.09046, -56.52474);
case 100: return new CityInfo("General Artigas", "11", -26.93522, -56.22168);
case 101: return new CityInfo("Fuerte Olimpo", "23", -21.04153, -57.87377);
case 102: return new CityInfo("Fram", "11", -26.98333, -55.88333);
case 103: return new CityInfo("Fernando de la Mora", "06", -25.3386, -57.52167);
case 104: return new CityInfo("Félix Pérez Cardozo", "10", -25.74199, -56.52278);
case 105: return new CityInfo("Eusebio Ayala", "08", -25.38276, -56.96088);
case 106: return new CityInfo("Encarnación", "11", -27.33056, -55.86667);
case 107: return new CityInfo("Emboscada", "08", -25.15, -57.35);
case 108: return new CityInfo("Edelira", "11", -26.76734, -55.27872);
case 109: return new CityInfo("Doctor Juan Manuel Frutos", "04", -25.3838, -55.83215);
case 110: return new CityInfo("Doctor Juan León Mallorquín", "01", -25.43053, -55.25412);
case 111: return new CityInfo("Cecilio Baez", "04", -25.07158, -56.24386);
case 112: return new CityInfo("Corpus Christi", "19", -24.0804, -54.93933);
case 113: return new CityInfo("Coronel Oviedo", "04", -25.44444, -56.44028);
case 114: return new CityInfo("Coronel Martínez", "10", -25.75862, -56.61677);
case 115: return new CityInfo("Concepción", "07", -23.39985, -57.43236);
case 116: return new CityInfo("Yguazú", "01", -25.46187, -55.00007);
case 117: return new CityInfo("Colonia Minga Porá", "01", -24.86667, -54.9);
case 118: return new CityInfo("Colonia Menno", "24", -22.36667, -59.81667);
case 119: return new CityInfo("Colonia Mauricio José Troche", "10", -25.56667, -56.28333);
case 120: return new CityInfo("Mariano Roque Alonso", "06", -25.20791, -57.53202);
case 121: return new CityInfo("Colonia General Alfredo Stroessner", "04", -25.36395, -55.7069);
case 122: return new CityInfo("Colonia Catuete", "19", -24.13333, -54.61667);
case 123: return new CityInfo("Ciudad del Este", "01", -25.50972, -54.61111);
case 124: return new CityInfo("Chore", "17", -24.18606, -56.58251);
case 125: return new CityInfo("Cerrito", "13", -27.34215, -57.64119);
case 126: return new CityInfo("Carmen del Paraná", "11", -27.22232, -56.15243);
case 127: return new CityInfo("Colonia Carlos Antonio López", "11", -26.39853, -54.7569);
case 128: return new CityInfo("Carayaó", "04", -25.1975, -56.39878);
case 129: return new CityInfo("Carapeguá", "15", -25.8, -57.23333);
case 130: return new CityInfo("Caraguatay", "08", -25.23844, -56.82693);
case 131: return new CityInfo("Capitán Miranda", "11", -27.2, -55.8);
case 132: return new CityInfo("Capitán Meza", "11", -27.01667, -55.56667);
case 133: return new CityInfo("Capitán Bado", "02", -23.26667, -55.53333);
case 134: return new CityInfo("Capiíbary", "17", -24.8, -56.03333);
case 135: return new CityInfo("Capiatá", "06", -25.3552, -57.44545);
case 136: return new CityInfo("Cambyretá", "11", -27.35901, -55.76131);
case 137: return new CityInfo("Caazapá", "05", -26.19583, -56.36806);
case 138: return new CityInfo("Caapucú", "15", -26.23523, -57.18212);
case 139: return new CityInfo("Caaguazú", "04", -25.47104, -56.01603);
case 140: return new CityInfo("Caacupé", "08", -25.38575, -57.14217);
case 141: return new CityInfo("Buena Vista", "05", -26.18387, -56.08171);
case 142: return new CityInfo("Benjamín Aceval", "16", -24.96667, -57.56667);
case 143: return new CityInfo("Bella Vista", "11", -27.05, -55.55);
case 144: return new CityInfo("Bella Vista", "02", -22.13333, -56.51667);
case 145: return new CityInfo("Belén", "07", -23.46611, -57.26194);
case 146: return new CityInfo("Juan de Ayolas", "12", -27.38662, -56.84724);
case 147: return new CityInfo("Atyrá", "08", -25.27876, -57.17192);
case 148: return new CityInfo("Asunción", "22", -25.28646, -57.647);
case 149: return new CityInfo("Arroyos y Esteros", "08", -25.05478, -57.09873);
case 150: return new CityInfo("Arquitecto Tomás Romero Pereira", "11", -26.48333, -55.25);
case 151: return new CityInfo("Areguá", "06", -25.3125, -57.38472);
case 152: return new CityInfo("Antequera", "17", -24.08526, -57.20221);
case 153: return new CityInfo("Alto Verá", "11", -26.58333, -55.63333);
case 154: return new CityInfo("Altos", "08", -25.26263, -57.25443);
case 155: return new CityInfo("Acahay", "15", -25.91667, -57.15);
case 156: return new CityInfo("Abaí", "05", -26.03333, -55.93333);
case 157: return new CityInfo("Horqueta", "07", -23.34278, -57.05972);
case 158: return new CityInfo("Filadelfia", "24", -22.33936, -60.03157);
case 159: return new CityInfo("Colonia Neuland", "24", -22.66667, -60.11667);
case 160: return new CityInfo("Capitán Pablo Lagerenza", "23", -19.91667, -60.78333);
case 161: return new CityInfo("Nueva Esperanza", "19", -24.5076, -54.8551);
default: return new CityInfo("Colonia San Lorenzo", "11", -26.49324, -54.79989);

                                    }                                        
                                }
                            
                        }
                    }
                