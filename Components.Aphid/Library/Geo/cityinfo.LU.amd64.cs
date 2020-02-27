
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
                                    public const string Country = "LU";
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
                            
                                        var cur = (Math.Abs(49.61114 - lat) + Math.Abs(6.40546 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(49.96778 - lat) + Math.Abs(5.89028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05333 - lat) + Math.Abs(5.91917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98889 - lat) + Math.Abs(5.99917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.96547 - lat) + Math.Abs(5.9339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13722 - lat) + Math.Abs(6.075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54083 - lat) + Math.Abs(6.20083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69473 - lat) + Math.Abs(6.38525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71534 - lat) + Math.Abs(6.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85918 - lat) + Math.Abs(6.08415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66321 - lat) + Math.Abs(6.13224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55676 - lat) + Math.Abs(6.28789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79636 - lat) + Math.Abs(6.28431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83667 - lat) + Math.Abs(5.90639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80306 - lat) + Math.Abs(6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.935 - lat) + Math.Abs(6.20889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76972 - lat) + Math.Abs(5.98222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.6319 - lat) + Math.Abs(6.2771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71778 - lat) + Math.Abs(6.01028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.12111 - lat) + Math.Abs(6.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.47583 - lat) + Math.Abs(6.04222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8975 - lat) + Math.Abs(6.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.62056 - lat) + Math.Abs(6.07333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67694 - lat) + Math.Abs(6.12389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81794 - lat) + Math.Abs(6.47713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66139 - lat) + Math.Abs(5.91917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56278 - lat) + Math.Abs(6.36444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52148 - lat) + Math.Abs(5.93781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70111 - lat) + Math.Abs(5.96722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.62056 - lat) + Math.Abs(6.26861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61014 - lat) + Math.Abs(6.25903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5825 - lat) + Math.Abs(5.95639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.50639 - lat) + Math.Abs(6.01278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83056 - lat) + Math.Abs(6.09861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.47 - lat) + Math.Abs(6.362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54806 - lat) + Math.Abs(5.92889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61471 - lat) + Math.Abs(6.22221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.72722 - lat) + Math.Abs(5.98639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45964 - lat) + Math.Abs(6.03089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8047 - lat) + Math.Abs(6.50532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66591 - lat) + Math.Abs(6.30257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.74167 - lat) + Math.Abs(6.11444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53721 - lat) + Math.Abs(6.14629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54639 - lat) + Math.Abs(5.84083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.545 - lat) + Math.Abs(6.36694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.48861 - lat) + Math.Abs(6.35167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86861 - lat) + Math.Abs(6.26778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76437 - lat) + Math.Abs(5.88997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5625 - lat) + Math.Abs(6.00889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.74972 - lat) + Math.Abs(6.08306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66032 - lat) + Math.Abs(6.23238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83083 - lat) + Math.Abs(5.845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.96083 - lat) + Math.Abs(6.14306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53639 - lat) + Math.Abs(6.02944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78933 - lat) + Math.Abs(5.93382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55833 - lat) + Math.Abs(5.88056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81167 - lat) + Math.Abs(5.76583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52444 - lat) + Math.Abs(6.12972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65722 - lat) + Math.Abs(6.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59639 - lat) + Math.Abs(6.26 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51361 - lat) + Math.Abs(5.89611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65743 - lat) + Math.Abs(6.24302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67528 - lat) + Math.Abs(6.00889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78694 - lat) + Math.Abs(6.17472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.50917 - lat) + Math.Abs(6.05611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53611 - lat) + Math.Abs(5.89306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65196 - lat) + Math.Abs(6.26199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.63277 - lat) + Math.Abs(6.26459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68028 - lat) + Math.Abs(6.13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.58528 - lat) + Math.Abs(6.25556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.505 - lat) + Math.Abs(6.28111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53306 - lat) + Math.Abs(5.98833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.74611 - lat) + Math.Abs(6.465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83389 - lat) + Math.Abs(6.0075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70261 - lat) + Math.Abs(6.47966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.74889 - lat) + Math.Abs(6.10611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65467 - lat) + Math.Abs(6.30416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80955 - lat) + Math.Abs(6.21521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70278 - lat) + Math.Abs(6.42639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.6275 - lat) + Math.Abs(6.02333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61167 - lat) + Math.Abs(6.13 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70131 - lat) + Math.Abs(6.14234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.72243 - lat) + Math.Abs(6.13016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56583 - lat) + Math.Abs(5.88667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56833 - lat) + Math.Abs(6.06528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.60045 - lat) + Math.Abs(6.36719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78362 - lat) + Math.Abs(6.21891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54639 - lat) + Math.Abs(5.85639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66444 - lat) + Math.Abs(6.07306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67 - lat) + Math.Abs(5.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.64639 - lat) + Math.Abs(5.91639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.62389 - lat) + Math.Abs(6.14944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69394 - lat) + Math.Abs(6.06789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66833 - lat) + Math.Abs(6.03583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.48917 - lat) + Math.Abs(6.03972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70722 - lat) + Math.Abs(6.25306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.58769 - lat) + Math.Abs(6.17065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85194 - lat) + Math.Abs(6.13472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51694 - lat) + Math.Abs(6.065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.01218 - lat) + Math.Abs(6.09089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61639 - lat) + Math.Abs(5.99028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68861 - lat) + Math.Abs(5.91472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56806 - lat) + Math.Abs(6.15139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65278 - lat) + Math.Abs(6.14139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69387 - lat) + Math.Abs(6.14166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.50759 - lat) + Math.Abs(6.14978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67207 - lat) + Math.Abs(6.14202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76907 - lat) + Math.Abs(6.24049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.57499 - lat) + Math.Abs(5.9097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.64944 - lat) + Math.Abs(5.93167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82778 - lat) + Math.Abs(5.96722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67751 - lat) + Math.Abs(6.44022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.58389 - lat) + Math.Abs(6.35917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69537 - lat) + Math.Abs(6.24577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.92131 - lat) + Math.Abs(5.96601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86499 - lat) + Math.Abs(6.17979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61667 - lat) + Math.Abs(5.9525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51616 - lat) + Math.Abs(6.18858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66602 - lat) + Math.Abs(6.34321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.746 - lat) + Math.Abs(6.18702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85556 - lat) + Math.Abs(6.04722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56278 - lat) + Math.Abs(6.15389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8475 - lat) + Math.Abs(6.10417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.91139 - lat) + Math.Abs(5.93639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.49583 - lat) + Math.Abs(5.98056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86472 - lat) + Math.Abs(6.11472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.50528 - lat) + Math.Abs(6.31639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76389 - lat) + Math.Abs(5.85722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68556 - lat) + Math.Abs(5.87861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.60155 - lat) + Math.Abs(6.38664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52417 - lat) + Math.Abs(5.96611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81212 - lat) + Math.Abs(6.41846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.48056 - lat) + Math.Abs(6.0875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.58701 - lat) + Math.Abs(5.9833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52417 - lat) + Math.Abs(5.89139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86778 - lat) + Math.Abs(6.15583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54083 - lat) + Math.Abs(6.25972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53556 - lat) + Math.Abs(6.14694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.58194 - lat) + Math.Abs(6.22667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78018 - lat) + Math.Abs(6.3395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81028 - lat) + Math.Abs(6.09722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05472 - lat) + Math.Abs(6.03139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59667 - lat) + Math.Abs(5.87583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.645 - lat) + Math.Abs(5.99083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.60694 - lat) + Math.Abs(6.32583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73611 - lat) + Math.Abs(6.02306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65579 - lat) + Math.Abs(6.07999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55389 - lat) + Math.Abs(6.32917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.90862 - lat) + Math.Abs(6.0675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70306 - lat) + Math.Abs(6.21725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.88778 - lat) + Math.Abs(5.81639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69062 - lat) + Math.Abs(6.13998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.77256 - lat) + Math.Abs(6.01532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70605 - lat) + Math.Abs(6.37201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78733 - lat) + Math.Abs(6.0654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54444 - lat) + Math.Abs(6.13778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68333 - lat) + Math.Abs(6.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.87667 - lat) + Math.Abs(6.21806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51861 - lat) + Math.Abs(6.10278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79528 - lat) + Math.Abs(5.94111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.57583 - lat) + Math.Abs(5.98389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61111 - lat) + Math.Abs(6.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.75833 - lat) + Math.Abs(6.11694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.525 - lat) + Math.Abs(6.04222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65507 - lat) + Math.Abs(6.11874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82051 - lat) + Math.Abs(6.34945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54028 - lat) + Math.Abs(6.12917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7306 - lat) + Math.Abs(6.39355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51014 - lat) + Math.Abs(5.92414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73114 - lat) + Math.Abs(5.88241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7526 - lat) + Math.Abs(6.36379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83583 - lat) + Math.Abs(6.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.92194 - lat) + Math.Abs(5.84944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56727 - lat) + Math.Abs(5.9073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52278 - lat) + Math.Abs(6.22472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.565 - lat) + Math.Abs(6.16361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51056 - lat) + Math.Abs(6.25722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53083 - lat) + Math.Abs(6.355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Wormeldange", "GR", 49.61114, 6.40546);
case 1: return new CityInfo("Winseler", "WI", 49.96778, 5.89028);
case 2: return new CityInfo("Wincrange", "CL", 50.05333, 5.91917);
case 3: return new CityInfo("Wilwerwiltz", "WI", 49.98889, 5.99917);
case 4: return new CityInfo("Wiltz", "WI", 49.96547, 5.9339);
case 5: return new CityInfo("Weiswampach", "CL", 50.13722, 6.075);
case 6: return new CityInfo("Weiler-la-Tour", "LU", 49.54083, 6.20083);
case 7: return new CityInfo("Wecker", "GR", 49.69473, 6.38525);
case 8: return new CityInfo("Wasserbillig", "GR", 49.71534, 6.49861);
case 9: return new CityInfo("Warken", "DI", 49.85918, 6.08415);
case 10: return new CityInfo("Walferdange", "LU", 49.66321, 6.13224);
case 11: return new CityInfo("Waldbredimus", "RM", 49.55676, 6.28789);
case 12: return new CityInfo("Waldbillig", "EC", 49.79636, 6.28431);
case 13: return new CityInfo("Wahl", "RD", 49.83667, 5.90639);
case 14: return new CityInfo("Vichten", "RD", 49.80306, 6);
case 15: return new CityInfo("Vianden", "VD", 49.935, 6.20889);
case 16: return new CityInfo("Useldange", "RD", 49.76972, 5.98222);
case 17: return new CityInfo("Uebersyren", "LU", 49.6319, 6.2771);
case 18: return new CityInfo("Tuntange", "ME", 49.71778, 6.01028);
case 19: return new CityInfo("Troisvierges", "CL", 50.12111, 6.00028);
case 20: return new CityInfo("Tétange", "ES", 49.47583, 6.04222);
case 21: return new CityInfo("Tandel", "VD", 49.8975, 6.18333);
case 22: return new CityInfo("Strassen", "LU", 49.62056, 6.07333);
case 23: return new CityInfo("Steinsel", "LU", 49.67694, 6.12389);
case 24: return new CityInfo("Steinheim", "EC", 49.81794, 6.47713);
case 25: return new CityInfo("Steinfort", "CA", 49.66139, 5.91917);
case 26: return new CityInfo("Stadtbredimus", "RM", 49.56278, 6.36444);
case 27: return new CityInfo("Soleuvre", "ES", 49.52148, 5.93781);
case 28: return new CityInfo("Septfontaines", "CA", 49.70111, 5.96722);
case 29: return new CityInfo("Schuttrange", "LU", 49.62056, 6.26861);
case 30: return new CityInfo("Schrassig", "LU", 49.61014, 6.25903);
case 31: return new CityInfo("Schouweiler", "CA", 49.5825, 5.95639);
case 32: return new CityInfo("Schifflange", "ES", 49.50639, 6.01278);
case 33: return new CityInfo("Schieren", "DI", 49.83056, 6.09861);
case 34: return new CityInfo("Schengen", "RM", 49.47, 6.362);
case 35: return new CityInfo("Sanem", "ES", 49.54806, 5.92889);
case 36: return new CityInfo("Sandweiler", "LU", 49.61471, 6.22221);
case 37: return new CityInfo("Saeul", "RD", 49.72722, 5.98639);
case 38: return new CityInfo("Rumelange", "ES", 49.45964, 6.03089);
case 39: return new CityInfo("Rosport", "EC", 49.8047, 6.50532);
case 40: return new CityInfo("Roodt-sur-Syre", "GR", 49.66591, 6.30257);
case 41: return new CityInfo("Rollingen", "ME", 49.74167, 6.11444);
case 42: return new CityInfo("Roeser", "ES", 49.53721, 6.14629);
case 43: return new CityInfo("Rodange", "ES", 49.54639, 5.84083);
case 44: return new CityInfo("Remich", "RM", 49.545, 6.36694);
case 45: return new CityInfo("Remerschen", "RM", 49.48861, 6.35167);
case 46: return new CityInfo("Reisdorf", "DI", 49.86861, 6.26778);
case 47: return new CityInfo("Redange-sur-Attert", "RD", 49.76437, 5.88997);
case 48: return new CityInfo("Reckange-sur-Mess", "ES", 49.5625, 6.00889);
case 49: return new CityInfo("Reckange", "ME", 49.74972, 6.08306);
case 50: return new CityInfo("Rameldange", "LU", 49.66032, 6.23238);
case 51: return new CityInfo("Rambrouch", "RD", 49.83083, 5.845);
case 52: return new CityInfo("Putscheid", "VD", 49.96083, 6.14306);
case 53: return new CityInfo("Pontpierre", "ES", 49.53639, 6.02944);
case 54: return new CityInfo("Platen", "RD", 49.78933, 5.93382);
case 55: return new CityInfo("Pétange", "ES", 49.55833, 5.88056);
case 56: return new CityInfo("Perlé", "RD", 49.81167, 5.76583);
case 57: return new CityInfo("Peppange", "ES", 49.52444, 6.12972);
case 58: return new CityInfo("Olm", "LU", 49.65722, 6.00028);
case 59: return new CityInfo("Oetrange", "LU", 49.59639, 6.26);
case 60: return new CityInfo("Obercorn", "ES", 49.51361, 5.89611);
case 61: return new CityInfo("Oberanven", "LU", 49.65743, 6.24302);
case 62: return new CityInfo("Nospelt", "CA", 49.67528, 6.00889);
case 63: return new CityInfo("Nommern", "ME", 49.78694, 6.17472);
case 64: return new CityInfo("Noertzange", "ES", 49.50917, 6.05611);
case 65: return new CityInfo("Niedercorn", "ES", 49.53611, 5.89306);
case 66: return new CityInfo("Niederanven", "LU", 49.65196, 6.26199);
case 67: return new CityInfo("Münsbach", "LU", 49.63277, 6.26459);
case 68: return new CityInfo("Müllendorf", "LU", 49.68028, 6.13);
case 69: return new CityInfo("Moutfort", "LU", 49.58528, 6.25556);
case 70: return new CityInfo("Mondorf-les-Bains", "RM", 49.505, 6.28111);
case 71: return new CityInfo("Mondercange", "ES", 49.53306, 5.98833);
case 72: return new CityInfo("Mompach", "EC", 49.74611, 6.465);
case 73: return new CityInfo("Mertzig", "DI", 49.83389, 6.0075);
case 74: return new CityInfo("Mertert", "GR", 49.70261, 6.47966);
case 75: return new CityInfo("Mersch", "ME", 49.74889, 6.10611);
case 76: return new CityInfo("Mensdorf", "GR", 49.65467, 6.30416);
case 77: return new CityInfo("Medernach", "DI", 49.80955, 6.21521);
case 78: return new CityInfo("Manternach", "GR", 49.70278, 6.42639);
case 79: return new CityInfo("Mamer", "CA", 49.6275, 6.02333);
case 80: return new CityInfo("Luxembourg", "LU", 49.61167, 6.13);
case 81: return new CityInfo("Lorentzweiler", "ME", 49.70131, 6.14234);
case 82: return new CityInfo("Lintgen", "ME", 49.72243, 6.13016);
case 83: return new CityInfo("Linger", "CA", 49.56583, 5.88667);
case 84: return new CityInfo("Leudelange", "ES", 49.56833, 6.06528);
case 85: return new CityInfo("Lenningen", "RM", 49.60045, 6.36719);
case 86: return new CityInfo("Larochette", "ME", 49.78362, 6.21891);
case 87: return new CityInfo("Lamadelaine", "ES", 49.54639, 5.85639);
case 88: return new CityInfo("Kopstal", "CA", 49.66444, 6.07306);
case 89: return new CityInfo("Koerich", "CA", 49.67, 5.95);
case 90: return new CityInfo("Kleinbettingen", "CA", 49.64639, 5.91639);
case 91: return new CityInfo("Kirchberg", "LU", 49.62389, 6.14944);
case 92: return new CityInfo("Keispelt", "CA", 49.69394, 6.06789);
case 93: return new CityInfo("Kehlen", "CA", 49.66833, 6.03583);
case 94: return new CityInfo("Kayl", "ES", 49.48917, 6.03972);
case 95: return new CityInfo("Junglinster", "GR", 49.70722, 6.25306);
case 96: return new CityInfo("Itzig", "LU", 49.58769, 6.17065);
case 97: return new CityInfo("Ingeldorf", "DI", 49.85194, 6.13472);
case 98: return new CityInfo("Huncherange", "ES", 49.51694, 6.065);
case 99: return new CityInfo("Hosingen", "CL", 50.01218, 6.09089);
case 100: return new CityInfo("Holzem", "CA", 49.61639, 5.99028);
case 101: return new CityInfo("Hobscheid", "CA", 49.68861, 5.91472);
case 102: return new CityInfo("Hesperange", "LU", 49.56806, 6.15139);
case 103: return new CityInfo("Helmsange", "LU", 49.65278, 6.14139);
case 104: return new CityInfo("Helmdange", "ME", 49.69387, 6.14166);
case 105: return new CityInfo("Hellange", "ES", 49.50759, 6.14978);
case 106: return new CityInfo("Heisdorf", "LU", 49.67207, 6.14202);
case 107: return new CityInfo("Heffingen", "ME", 49.76907, 6.24049);
case 108: return new CityInfo("Hautcharage", "CA", 49.57499, 5.9097);
case 109: return new CityInfo("Hagen", "CA", 49.64944, 5.93167);
case 110: return new CityInfo("Grosbous", "RD", 49.82778, 5.96722);
case 111: return new CityInfo("Grevenmacher", "GR", 49.67751, 6.44022);
case 112: return new CityInfo("Greiveldange", "RM", 49.58389, 6.35917);
case 113: return new CityInfo("Gonderange", "GR", 49.69537, 6.24577);
case 114: return new CityInfo("Goesdorf", "WI", 49.92131, 5.96601);
case 115: return new CityInfo("Gilsdorf", "DI", 49.86499, 6.17979);
case 116: return new CityInfo("Garnich", "CA", 49.61667, 5.9525);
case 117: return new CityInfo("Frisange", "ES", 49.51616, 6.18858);
case 118: return new CityInfo("Flaxweiler", "GR", 49.66602, 6.34321);
case 119: return new CityInfo("Fischbach", "ME", 49.746, 6.18702);
case 120: return new CityInfo("Niederfeulen", "DI", 49.85556, 6.04722);
case 121: return new CityInfo("Fentange", "LU", 49.56278, 6.15389);
case 122: return new CityInfo("Ettelbruck", "DI", 49.8475, 6.10417);
case 123: return new CityInfo("Esch-sur-Sûre", "WI", 49.91139, 5.93639);
case 124: return new CityInfo("Esch-sur-Alzette", "ES", 49.49583, 5.98056);
case 125: return new CityInfo("Erpeldange", "DI", 49.86472, 6.11472);
case 126: return new CityInfo("Elvange", "RM", 49.50528, 6.31639);
case 127: return new CityInfo("Ell", "RD", 49.76389, 5.85722);
case 128: return new CityInfo("Eischen", "CA", 49.68556, 5.87861);
case 129: return new CityInfo("Ehnen", "GR", 49.60155, 6.38664);
case 130: return new CityInfo("Ehlerange", "ES", 49.52417, 5.96611);
case 131: return new CityInfo("Echternach", "EC", 49.81212, 6.41846);
case 132: return new CityInfo("Dudelange", "ES", 49.48056, 6.0875);
case 133: return new CityInfo("Dippach", "CA", 49.58701, 5.9833);
case 134: return new CityInfo("Differdange", "ES", 49.52417, 5.89139);
case 135: return new CityInfo("Diekirch", "DI", 49.86778, 6.15583);
case 136: return new CityInfo("Dalheim", "RM", 49.54083, 6.25972);
case 137: return new CityInfo("Crauthem", "ES", 49.53556, 6.14694);
case 138: return new CityInfo("Contern", "LU", 49.58194, 6.22667);
case 139: return new CityInfo("Consdorf", "EC", 49.78018, 6.3395);
case 140: return new CityInfo("Colmar", "ME", 49.81028, 6.09722);
case 141: return new CityInfo("Clervaux", "CL", 50.05472, 6.03139);
case 142: return new CityInfo("Clemency", "CA", 49.59667, 5.87583);
case 143: return new CityInfo("Capellen", "CA", 49.645, 5.99083);
case 144: return new CityInfo("Canach", "RM", 49.60694, 6.32583);
case 145: return new CityInfo("Brouch", "ME", 49.73611, 6.02306);
case 146: return new CityInfo("Bridel", "CA", 49.65579, 6.07999);
case 147: return new CityInfo("Bous", "RM", 49.55389, 6.32917);
case 148: return new CityInfo("Bourscheid", "DI", 49.90862, 6.0675);
case 149: return new CityInfo("Bourglinster", "GR", 49.70306, 6.21725);
case 150: return new CityInfo("Boulaide", "WI", 49.88778, 5.81639);
case 151: return new CityInfo("Bofferdange", "ME", 49.69062, 6.13998);
case 152: return new CityInfo("Boevange-sur-Attert", "ME", 49.77256, 6.01532);
case 153: return new CityInfo("Biwer", "GR", 49.70605, 6.37201);
case 154: return new CityInfo("Bissen", "ME", 49.78733, 6.0654);
case 155: return new CityInfo("Bivange", "ES", 49.54444, 6.13778);
case 156: return new CityInfo("Betzdorf", "GR", 49.68333, 6.35);
case 157: return new CityInfo("Bettendorf", "DI", 49.87667, 6.21806);
case 158: return new CityInfo("Bettembourg", "ES", 49.51861, 6.10278);
case 159: return new CityInfo("Bettborn", "RD", 49.79528, 5.94111);
case 160: return new CityInfo("Bettange-sur-Mess", "CA", 49.57583, 5.98389);
case 161: return new CityInfo("Bertrange", "LU", 49.61111, 6.05);
case 162: return new CityInfo("Beringen", "ME", 49.75833, 6.11694);
case 163: return new CityInfo("Bergem", "ES", 49.525, 6.04222);
case 164: return new CityInfo("Béreldange", "LU", 49.65507, 6.11874);
case 165: return new CityInfo("Berdorf", "EC", 49.82051, 6.34945);
case 166: return new CityInfo("Berchem", "ES", 49.54028, 6.12917);
case 167: return new CityInfo("Berbourg", "GR", 49.7306, 6.39355);
case 168: return new CityInfo("Belvaux", "ES", 49.51014, 5.92414);
case 169: return new CityInfo("Beckerich", "RD", 49.73114, 5.88241);
case 170: return new CityInfo("Bech", "EC", 49.7526, 6.36379);
case 171: return new CityInfo("Beaufort", "EC", 49.83583, 6.29167);
case 172: return new CityInfo("Bavigne", "WI", 49.92194, 5.84944);
case 173: return new CityInfo("Bascharage", "CA", 49.56727, 5.9073);
case 174: return new CityInfo("Aspelt", "ES", 49.52278, 6.22472);
case 175: return new CityInfo("Alzingen", "LU", 49.565, 6.16361);
case 176: return new CityInfo("Altwies", "RM", 49.51056, 6.25722);
default: return new CityInfo("Bech-Kleinmacher", "RM", 49.53083, 6.355);

                                    }                                        
                                }
                            
                        }
                    }
                