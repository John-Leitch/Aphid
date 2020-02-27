
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
                                    public const string Country = "AZ";
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
                            
                                        var cur = (Math.Abs(39.55298 - lat) + Math.Abs(44.97993 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(39.11998 - lat) + Math.Abs(48.59383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08371 - lat) + Math.Abs(46.65988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94052 - lat) + Math.Abs(45.73244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90771 - lat) + Math.Abs(48.24052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79496 - lat) + Math.Abs(47.1117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8177 - lat) + Math.Abs(46.7528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.88074 - lat) + Math.Abs(48.39158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76006 - lat) + Math.Abs(46.74989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59621 - lat) + Math.Abs(48.98479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.40722 - lat) + Math.Abs(45.57389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71427 - lat) + Math.Abs(44.88455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94804 - lat) + Math.Abs(45.82572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.93214 - lat) + Math.Abs(48.36892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34441 - lat) + Math.Abs(46.58183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81614 - lat) + Math.Abs(48.93792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63571 - lat) + Math.Abs(47.71199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90961 - lat) + Math.Abs(46.02274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3768 - lat) + Math.Abs(49.247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20889 - lat) + Math.Abs(45.41222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03023 - lat) + Math.Abs(46.72329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03532 - lat) + Math.Abs(48.6654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77388 - lat) + Math.Abs(48.41497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75428 - lat) + Math.Abs(48.85062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59881 - lat) + Math.Abs(46.55045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39939 - lat) + Math.Abs(45.11513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67669 - lat) + Math.Abs(46.95123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53461 - lat) + Math.Abs(48.80546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91297 - lat) + Math.Abs(46.79028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43012 - lat) + Math.Abs(49.10166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94628 - lat) + Math.Abs(45.96062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87095 - lat) + Math.Abs(48.05995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45015 - lat) + Math.Abs(47.33496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76325 - lat) + Math.Abs(48.76223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.52003 - lat) + Math.Abs(47.0319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60094 - lat) + Math.Abs(47.14529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39917 - lat) + Math.Abs(47.02835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77278 - lat) + Math.Abs(47.75889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88375 - lat) + Math.Abs(45.90963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95397 - lat) + Math.Abs(45.62961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20963 - lat) + Math.Abs(48.49186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34837 - lat) + Math.Abs(45.41557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93013 - lat) + Math.Abs(48.7092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45833 - lat) + Math.Abs(48.545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77556 - lat) + Math.Abs(47.61861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41117 - lat) + Math.Abs(49.24792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15459 - lat) + Math.Abs(45.44282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45598 - lat) + Math.Abs(48.87498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9391 - lat) + Math.Abs(46.83161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93079 - lat) + Math.Abs(45.98959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29383 - lat) + Math.Abs(45.78811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.93778 - lat) + Math.Abs(48.929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99096 - lat) + Math.Abs(46.92736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33667 - lat) + Math.Abs(49.21414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97389 - lat) + Math.Abs(47.42389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81917 - lat) + Math.Abs(47.67944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.73361 - lat) + Math.Abs(47.655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44167 - lat) + Math.Abs(45.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58694 - lat) + Math.Abs(45.04611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.36613 - lat) + Math.Abs(50.29198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2184 - lat) + Math.Abs(47.71214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.6316 - lat) + Math.Abs(46.64479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47746 - lat) + Math.Abs(49.94174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61832 - lat) + Math.Abs(47.15014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8432 - lat) + Math.Abs(45.6803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63052 - lat) + Math.Abs(48.68161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58584 - lat) + Math.Abs(46.3189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46426 - lat) + Math.Abs(48.80565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49357 - lat) + Math.Abs(46.07175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05275 - lat) + Math.Abs(46.54419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51902 - lat) + Math.Abs(47.65423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3646 - lat) + Math.Abs(50.22075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99249 - lat) + Math.Abs(45.62838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34201 - lat) + Math.Abs(46.93161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58972 - lat) + Math.Abs(49.66861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07811 - lat) + Math.Abs(49.11564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8199 - lat) + Math.Abs(49.46774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32157 - lat) + Math.Abs(49.59907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39667 - lat) + Math.Abs(49.97361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53299 - lat) + Math.Abs(49.71681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16991 - lat) + Math.Abs(49.46394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63671 - lat) + Math.Abs(48.43028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82975 - lat) + Math.Abs(46.0178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63141 - lat) + Math.Abs(48.64137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27524 - lat) + Math.Abs(45.35293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19194 - lat) + Math.Abs(47.17056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76485 - lat) + Math.Abs(46.40868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4425 - lat) + Math.Abs(49.94806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00869 - lat) + Math.Abs(48.47701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4275 - lat) + Math.Abs(48.4302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.36108 - lat) + Math.Abs(48.51341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08238 - lat) + Math.Abs(49.41205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03874 - lat) + Math.Abs(48.94286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09246 - lat) + Math.Abs(45.36561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41826 - lat) + Math.Abs(46.92043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81243 - lat) + Math.Abs(46.25938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98247 - lat) + Math.Abs(47.84909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29667 - lat) + Math.Abs(49.66028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07128 - lat) + Math.Abs(47.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59811 - lat) + Math.Abs(45.60079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25213 - lat) + Math.Abs(50.84003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62333 - lat) + Math.Abs(49.55861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55611 - lat) + Math.Abs(50.00556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50821 - lat) + Math.Abs(46.8203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76395 - lat) + Math.Abs(47.05953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52983 - lat) + Math.Abs(50.00616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49182 - lat) + Math.Abs(50.14292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5336 - lat) + Math.Abs(48.92819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.54243 - lat) + Math.Abs(46.767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3256 - lat) + Math.Abs(49.73376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84618 - lat) + Math.Abs(48.38227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57723 - lat) + Math.Abs(46.85776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34257 - lat) + Math.Abs(48.15649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.40472 - lat) + Math.Abs(49.71306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87392 - lat) + Math.Abs(49.34376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90847 - lat) + Math.Abs(49.07481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44808 - lat) + Math.Abs(49.75502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41293 - lat) + Math.Abs(49.76904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30446 - lat) + Math.Abs(49.6236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61871 - lat) + Math.Abs(46.64922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78674 - lat) + Math.Abs(46.31365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48135 - lat) + Math.Abs(46.99339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04358 - lat) + Math.Abs(45.65527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47546 - lat) + Math.Abs(46.54128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09524 - lat) + Math.Abs(45.47111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10984 - lat) + Math.Abs(46.04446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44256 - lat) + Math.Abs(50.16759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42412 - lat) + Math.Abs(46.93859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.43254 - lat) + Math.Abs(46.9646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78485 - lat) + Math.Abs(48.15141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43026 - lat) + Math.Abs(50.03598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37444 - lat) + Math.Abs(49.68194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39701 - lat) + Math.Abs(50.33667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65055 - lat) + Math.Abs(47.74219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37444 - lat) + Math.Abs(50.08528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61028 - lat) + Math.Abs(46.78972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13932 - lat) + Math.Abs(49.09038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68278 - lat) + Math.Abs(46.36056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57055 - lat) + Math.Abs(45.81229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46868 - lat) + Math.Abs(46.51579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57176 - lat) + Math.Abs(49.70509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54194 - lat) + Math.Abs(49.66073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9033 - lat) + Math.Abs(45.88564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9539 - lat) + Math.Abs(45.61942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49257 - lat) + Math.Abs(49.87477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20117 - lat) + Math.Abs(48.98712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52393 - lat) + Math.Abs(46.08186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86278 - lat) + Math.Abs(46.03493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75244 - lat) + Math.Abs(45.70645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46965 - lat) + Math.Abs(46.91582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72622 - lat) + Math.Abs(45.55919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51903 - lat) + Math.Abs(50.11438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46602 - lat) + Math.Abs(49.82783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45076 - lat) + Math.Abs(50.08686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56441 - lat) + Math.Abs(50.04002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25234 - lat) + Math.Abs(47.82303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7552 - lat) + Math.Abs(48.39104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.32582 - lat) + Math.Abs(47.11357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37577 - lat) + Math.Abs(47.12619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.72626 - lat) + Math.Abs(46.40478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46344 - lat) + Math.Abs(49.91893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4444 - lat) + Math.Abs(49.80566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37767 - lat) + Math.Abs(49.89201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53971 - lat) + Math.Abs(45.61414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59313 - lat) + Math.Abs(45.799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47013 - lat) + Math.Abs(50.32476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42639 - lat) + Math.Abs(49.98361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52959 - lat) + Math.Abs(46.05225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85785 - lat) + Math.Abs(48.9354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4829 - lat) + Math.Abs(46.63483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57028 - lat) + Math.Abs(48.40087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11889 - lat) + Math.Abs(45.45389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64699 - lat) + Math.Abs(47.4738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21127 - lat) + Math.Abs(46.82135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05015 - lat) + Math.Abs(47.45937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57626 - lat) + Math.Abs(45.63727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09902 - lat) + Math.Abs(48.81886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.75259 - lat) + Math.Abs(46.27052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41894 - lat) + Math.Abs(49.96693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93972 - lat) + Math.Abs(46.37889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45639 - lat) + Math.Abs(48.64889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62528 - lat) + Math.Abs(46.97556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50781 - lat) + Math.Abs(47.16971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44222 - lat) + Math.Abs(49.98056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34024 - lat) + Math.Abs(49.8045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.72286 - lat) + Math.Abs(44.84846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Sharur City", "35", 39.55298, 44.97993);
case 1: return new CityInfo("Prishibinskoye", "15", 39.11998, 48.59383);
case 2: return new CityInfo("Zangilan", "69", 39.08371, 46.65988);
case 3: return new CityInfo("Yaycı", "35", 38.94052, 45.73244);
case 4: return new CityInfo("Yardımlı", "66", 38.90771, 48.24052);
case 5: return new CityInfo("Novyy Karanlug", "65", 39.79496, 47.1117);
case 6: return new CityInfo("Xankandi", "61", 39.8177, 46.7528);
case 7: return new CityInfo("Əhmədbəyli", "45", 39.88074, 48.39158);
case 8: return new CityInfo("Shushi", "55", 39.76006, 46.74989);
case 9: return new CityInfo("Salyan", "49", 39.59621, 48.98479);
case 10: return new CityInfo("Şahbuz", "35", 39.40722, 45.57389);
case 11: return new CityInfo("Sedarak", "35", 39.71427, 44.88455);
case 12: return new CityInfo("Sumbatan-diza", "35", 38.94804, 45.82572);
case 13: return new CityInfo("Saatlı", "45", 39.93214, 48.36892);
case 14: return new CityInfo("Qubadlı", "43", 39.34441, 46.58183);
case 15: return new CityInfo("Qaraçala", "49", 39.81614, 48.93792);
case 16: return new CityInfo("Orjonikidze", "12", 39.63571, 47.71199);
case 17: return new CityInfo("Ordubad", "35", 38.90961, 46.02274);
case 18: return new CityInfo("Neftçala", "36", 39.3768, 49.247);
case 19: return new CityInfo("Nakhchivan", "35", 39.20889, 45.41222);
case 20: return new CityInfo("Mincivan", "69", 39.03023, 46.72329);
case 21: return new CityInfo("Masally", "32", 39.03532, 48.6654);
case 22: return new CityInfo("Lerik", "31", 38.77388, 48.41497);
case 23: return new CityInfo("Lankaran", "29", 38.75428, 48.85062);
case 24: return new CityInfo("Laçın", "28", 39.59881, 46.55045);
case 25: return new CityInfo("Qıvraq", "35", 39.39939, 45.11513);
case 26: return new CityInfo("Qırmızı Bazar", "65", 39.67669, 46.95123);
case 27: return new CityInfo("Kizhaba", "08", 38.53461, 48.80546);
case 28: return new CityInfo("Xocalı", "64", 39.91297, 46.79028);
case 29: return new CityInfo("Xıllı", "36", 39.43012, 49.10166);
case 30: return new CityInfo("İstisu", "26", 39.94628, 45.96062);
case 31: return new CityInfo("Imishli", "24", 39.87095, 48.05995);
case 32: return new CityInfo("Horadiz", "18", 39.45015, 47.33496);
case 33: return new CityInfo("Haftoni", "29", 38.76325, 48.76223);
case 34: return new CityInfo("Hadrut", "65", 39.52003, 47.0319);
case 35: return new CityInfo("Fizuli", "18", 39.60094, 47.14529);
case 36: return new CityInfo("Jebrail", "14", 39.39917, 47.02835);
case 37: return new CityInfo("Dünyamalılar", "12", 39.77278, 47.75889);
case 38: return new CityInfo("Deste", "35", 38.88375, 45.90963);
case 39: return new CityInfo("Culfa", "35", 38.95397, 45.62961);
case 40: return new CityInfo("Jalilabad", "15", 39.20963, 48.49186);
case 41: return new CityInfo("Cahri", "35", 39.34837, 45.41557);
case 42: return new CityInfo("Boradigah", "32", 38.93013, 48.7092);
case 43: return new CityInfo("Pushkino", "13", 39.45833, 48.545);
case 44: return new CityInfo("Beylagan", "12", 39.77556, 47.61861);
case 45: return new CityInfo("Severo-Vostotchnyi Bank", "36", 39.41117, 49.24792);
case 46: return new CityInfo("Tazakend", "35", 39.15459, 45.44282);
case 47: return new CityInfo("Astara", "08", 38.45598, 48.87498);
case 48: return new CityInfo("Askyaran", "64", 39.9391, 46.83161);
case 49: return new CityInfo("Ashagy Aylis", "35", 38.93079, 45.98959);
case 50: return new CityInfo("Arafsa", "35", 39.29383, 45.78811);
case 51: return new CityInfo("Şirvan", "07", 39.93778, 48.929);
case 52: return new CityInfo("Ağdam", "03", 39.99096, 46.92736);
case 53: return new CityInfo("Sovetabad", "36", 39.33667, 49.21414);
case 54: return new CityInfo("Avşar", "02", 39.97389, 47.42389);
case 55: return new CityInfo("Birinci Aşıqlı", "12", 39.81917, 47.67944);
case 56: return new CityInfo("Yuxarı Aran", "12", 39.73361, 47.655);
case 57: return new CityInfo("Çalxanqala", "35", 39.44167, 45.28333);
case 58: return new CityInfo("Oğlanqala", "35", 39.58694, 45.04611);
case 59: return new CityInfo("Zyrya", "09", 40.36613, 50.29198);
case 60: return new CityInfo("Zardob", "71", 40.2184, 47.71214);
case 61: return new CityInfo("Zaqatala", "70", 41.6316, 46.64479);
case 62: return new CityInfo("Zabrat", "09", 40.47746, 49.94174);
case 63: return new CityInfo("Yevlakh", "68", 40.61832, 47.15014);
case 64: return new CityInfo("Yanıqlı", "58", 40.8432, 45.6803);
case 65: return new CityInfo("Xudat", "60", 41.63052, 48.68161);
case 66: return new CityInfo("Yelenendorf", "62", 40.58584, 46.3189);
case 67: return new CityInfo("Xaçmaz", "60", 41.46426, 48.80565);
case 68: return new CityInfo("Verkhniy Dashkesan", "16", 40.49357, 46.07175);
case 69: return new CityInfo("Vank", "26", 40.05275, 46.54419);
case 70: return new CityInfo("Ujar", "59", 40.51902, 47.65423);
case 71: return new CityInfo("Türkan", "09", 40.3646, 50.22075);
case 72: return new CityInfo("Tovuz", "58", 40.99249, 45.62838);
case 73: return new CityInfo("Terter", "57", 40.34201, 46.93161);
case 74: return new CityInfo("Sumqayıt", "54", 40.58972, 49.66861);
case 75: return new CityInfo("Kyzyl-Burun", "53", 41.07811, 49.11564);
case 76: return new CityInfo("Şuraabad", "63", 40.8199, 49.46774);
case 77: return new CityInfo("Şonqar", "09", 40.32157, 49.59907);
case 78: return new CityInfo("Qaraçuxur", "09", 40.39667, 49.97361);
case 79: return new CityInfo("Saray", "01", 40.53299, 49.71681);
case 80: return new CityInfo("Sanqaçal", "09", 40.16991, 49.46394);
case 81: return new CityInfo("Samur", "44", 41.63671, 48.43028);
case 82: return new CityInfo("Shamkhor", "51", 40.82975, 46.0178);
case 83: return new CityInfo("Shamakhi", "50", 40.63141, 48.64137);
case 84: return new CityInfo("Saloğlu", "05", 41.27524, 45.35293);
case 85: return new CityInfo("Sheki", "48", 41.19194, 47.17056);
case 86: return new CityInfo("Samux", "52", 40.76485, 46.40868);
case 87: return new CityInfo("Sabunçu", "09", 40.4425, 49.94806);
case 88: return new CityInfo("Sabirabad", "46", 40.00869, 48.47701);
case 89: return new CityInfo("Qusar", "44", 41.4275, 48.4302);
case 90: return new CityInfo("Quba", "42", 41.36108, 48.51341);
case 91: return new CityInfo("Qobustan", "09", 40.08238, 49.41205);
case 92: return new CityInfo("Hacıqabul", "23", 40.03874, 48.94286);
case 93: return new CityInfo("Qazax", "40", 41.09246, 45.36561);
case 94: return new CityInfo("Qax", "39", 41.41826, 46.92043);
case 95: return new CityInfo("Qasım İsmayılov", "51", 40.81243, 46.25938);
case 96: return new CityInfo("Qutqashen", "38", 40.98247, 47.84909);
case 97: return new CityInfo("Puta", "09", 40.29667, 49.66028);
case 98: return new CityInfo("Oğuz", "37", 41.07128, 47.46528);
case 99: return new CityInfo("Novosaratovka", "19", 40.59811, 45.60079);
case 100: return new CityInfo("Neft Daşları", "09", 40.25213, 50.84003);
case 101: return new CityInfo("Hacı Zeynalabdin", "54", 40.62333, 49.55861);
case 102: return new CityInfo("Nardaran", "09", 40.55611, 50.00556);
case 103: return new CityInfo("Naftalan", "34", 40.50821, 46.8203);
case 104: return new CityInfo("Mingelchaur", "33", 40.76395, 47.05953);
case 105: return new CityInfo("Maştağa", "09", 40.52983, 50.00616);
case 106: return new CityInfo("Mardakan", "09", 40.49182, 50.14292);
case 107: return new CityInfo("Qobustan", "41", 40.5336, 48.92819);
case 108: return new CityInfo("Mamrux", "70", 41.54243, 46.767);
case 109: return new CityInfo("Lökbatan", "09", 40.3256, 49.73376);
case 110: return new CityInfo("Lahıc", "25", 40.84618, 48.38227);
case 111: return new CityInfo("Qızılhacılı", "21", 40.57723, 46.85776);
case 112: return new CityInfo("Kyurdarmir", "27", 40.34257, 48.15649);
case 113: return new CityInfo("Qobu", "01", 40.40472, 49.71306);
case 114: return new CityInfo("Kilyazi", "63", 40.87392, 49.34376);
case 115: return new CityInfo("Khyzy", "63", 40.90847, 49.07481);
case 116: return new CityInfo("Khirdalan", "01", 40.44808, 49.75502);
case 117: return new CityInfo("Khodzhi-Gasan", "09", 40.41293, 49.76904);
case 118: return new CityInfo("Korgöz", "09", 40.30446, 49.6236);
case 119: return new CityInfo("Qazanbulaq", "21", 40.61871, 46.64922);
case 120: return new CityInfo("Qarayeri", "52", 40.78674, 46.31365);
case 121: return new CityInfo("Qaramanlı", "67", 40.48135, 46.99339);
case 122: return new CityInfo("Qaraxanlı", "58", 41.04358, 45.65527);
case 123: return new CityInfo("Qandax", "70", 41.47546, 46.54128);
case 124: return new CityInfo("Vurğun", "05", 41.09524, 45.47111);
case 125: return new CityInfo("Kerbakhiar", "26", 40.10984, 46.04446);
case 126: return new CityInfo("Qala", "09", 40.44256, 50.16759);
case 127: return new CityInfo("Qax İngiloy", "39", 41.42412, 46.93859);
case 128: return new CityInfo("Qaxbaş", "39", 41.43254, 46.9646);
case 129: return new CityInfo("İsmayıllı", "25", 40.78485, 48.15141);
case 130: return new CityInfo("Yeni Suraxanı", "09", 40.43026, 50.03598);
case 131: return new CityInfo("Gyuzdek", "01", 40.37444, 49.68194);
case 132: return new CityInfo("Gyurgyan", "09", 40.39701, 50.33667);
case 133: return new CityInfo("Geoktschai", "22", 40.65055, 47.74219);
case 134: return new CityInfo("Hövsan", "09", 40.37444, 50.08528);
case 135: return new CityInfo("Goranboy", "21", 40.61028, 46.78972);
case 136: return new CityInfo("Gilgilçay", "53", 41.13932, 49.09038);
case 137: return new CityInfo("Ganja", "20", 40.68278, 46.36056);
case 138: return new CityInfo("Kyadabek", "19", 40.57055, 45.81229);
case 139: return new CityInfo("Faldarlı", "70", 41.46868, 46.51579);
case 140: return new CityInfo("Corat", "54", 40.57176, 49.70509);
case 141: return new CityInfo("Ceyranbatan", "01", 40.54194, 49.66073);
case 142: return new CityInfo("Dzagam", "51", 40.9033, 45.88564);
case 143: return new CityInfo("Dondar Quşçu", "58", 40.9539, 45.61942);
case 144: return new CityInfo("Digah", "01", 40.49257, 49.87477);
case 145: return new CityInfo("Divichibazar", "17", 41.20117, 48.98712);
case 146: return new CityInfo("Yukhary-Dashkesan", "16", 40.52393, 46.08186);
case 147: return new CityInfo("Dolyar", "51", 40.86278, 46.03493);
case 148: return new CityInfo("Çobansığnaq", "58", 40.75244, 45.70645);
case 149: return new CityInfo("Çinarlı", "39", 41.46965, 46.91582);
case 150: return new CityInfo("Çatax", "58", 40.72622, 45.55919);
case 151: return new CityInfo("Buzovna", "09", 40.51903, 50.11438);
case 152: return new CityInfo("Binagadi", "09", 40.46602, 49.82783);
case 153: return new CityInfo("Biny Selo", "09", 40.45076, 50.08686);
case 154: return new CityInfo("Bilajer", "09", 40.56441, 50.04002);
case 155: return new CityInfo("Begimli", "71", 40.25234, 47.82303);
case 156: return new CityInfo("Basqal", "25", 40.7552, 48.39104);
case 157: return new CityInfo("Baş Göynük", "47", 41.32582, 47.11357);
case 158: return new CityInfo("Barda", "11", 40.37577, 47.12619);
case 159: return new CityInfo("Belokany", "10", 41.72626, 46.40478);
case 160: return new CityInfo("Balakhani", "09", 40.46344, 49.91893);
case 161: return new CityInfo("Bilajari", "09", 40.4444, 49.80566);
case 162: return new CityInfo("Baku", "09", 40.37767, 49.89201);
case 163: return new CityInfo("Arıqıran", "19", 40.53971, 45.61414);
case 164: return new CityInfo("Arıqdam", "19", 40.59313, 45.799);
case 165: return new CityInfo("Pirallahı", "09", 40.47013, 50.32476);
case 166: return new CityInfo("Amirdzhan", "09", 40.42639, 49.98361);
case 167: return new CityInfo("Alunitdağ", "16", 40.52959, 46.05225);
case 168: return new CityInfo("Altıağac", "63", 40.85785, 48.9354);
case 169: return new CityInfo("Aliabad", "70", 41.4829, 46.63483);
case 170: return new CityInfo("Aghsu", "06", 40.57028, 48.40087);
case 171: return new CityInfo("Aghstafa", "05", 41.11889, 45.45389);
case 172: return new CityInfo("Ağdaş", "04", 40.64699, 47.4738);
case 173: return new CityInfo("Martakert", "57", 40.21127, 46.82135);
case 174: return new CityInfo("Agdzhabedy", "02", 40.05015, 47.45937);
case 175: return new CityInfo("Böyük Qaramurad", "19", 40.57626, 45.63727);
case 176: return new CityInfo("Mughan", "23", 40.09902, 48.81886);
case 177: return new CityInfo("Qabaqçöl", "10", 41.75259, 46.27052);
case 178: return new CityInfo("Bakıxanov", "09", 40.41894, 49.96693);
case 179: return new CityInfo("Qırmızı Samux", "52", 40.93972, 46.37889);
case 180: return new CityInfo("Hacıhüseynli", "42", 41.45639, 48.64889);
case 181: return new CityInfo("Aran", "67", 40.62528, 46.97556);
case 182: return new CityInfo("Samuxlu", "11", 40.50781, 47.16971);
case 183: return new CityInfo("Ramana", "09", 40.44222, 49.98056);
case 184: return new CityInfo("Badamdar", "09", 40.34024, 49.8045);
default: return new CityInfo("Heydarabad", "35", 39.72286, 44.84846);

                                    }                                        
                                }
                            
                        }
                    }
                