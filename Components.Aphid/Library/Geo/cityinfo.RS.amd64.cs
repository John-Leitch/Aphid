
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
                                    public const string Country = "RS";
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
                            
                                        var cur = (Math.Abs(44.64025 - lat) + Math.Abs(20.16432 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(42.31568 - lat) + Math.Abs(21.70212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38361 - lat) + Math.Abs(20.38194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.19 - lat) + Math.Abs(21.71306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.09021 - lat) + Math.Abs(21.57476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.485 - lat) + Math.Abs(20.54972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8458 - lat) + Math.Abs(20.40116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90358 - lat) + Math.Abs(22.26405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.19685 - lat) + Math.Abs(21.78838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.35611 - lat) + Math.Abs(21.215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37222 - lat) + Math.Abs(20.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11667 - lat) + Math.Abs(21.30361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.62725 - lat) + Math.Abs(20.89634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00584 - lat) + Math.Abs(20.31325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.555 - lat) + Math.Abs(21.99222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55139 - lat) + Math.Abs(21.90028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60237 - lat) + Math.Abs(20.32872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.79256 - lat) + Math.Abs(20.47491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01557 - lat) + Math.Abs(21.34793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68537 - lat) + Math.Abs(20.65536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.93713 - lat) + Math.Abs(20.15236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.96697 - lat) + Math.Abs(22.13402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07207 - lat) + Math.Abs(21.19945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03122 - lat) + Math.Abs(20.86566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.70778 - lat) + Math.Abs(22.06333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24859 - lat) + Math.Abs(20.15521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17919 - lat) + Math.Abs(21.40353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.76329 - lat) + Math.Abs(21.51646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28849 - lat) + Math.Abs(21.17057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63755 - lat) + Math.Abs(20.59288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.33389 - lat) + Math.Abs(21.07676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66486 - lat) + Math.Abs(20.35395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24376 - lat) + Math.Abs(21.03498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.72397 - lat) + Math.Abs(21.3624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20512 - lat) + Math.Abs(20.62342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67806 - lat) + Math.Abs(20.30472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04213 - lat) + Math.Abs(21.15393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87635 - lat) + Math.Abs(20.18763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.45611 - lat) + Math.Abs(20.07389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.99028 - lat) + Math.Abs(20.33139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.52273 - lat) + Math.Abs(21.63945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.228 - lat) + Math.Abs(21.37961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61694 - lat) + Math.Abs(21.0025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.36417 - lat) + Math.Abs(22.0825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58423 - lat) + Math.Abs(20.459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.25417 - lat) + Math.Abs(20.6825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26855 - lat) + Math.Abs(20.62272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68943 - lat) + Math.Abs(20.55714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20611 - lat) + Math.Abs(20.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46737 - lat) + Math.Abs(20.19867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.41333 - lat) + Math.Abs(22.12111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.2337 - lat) + Math.Abs(21.1967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.25829 - lat) + Math.Abs(21.33269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38312 - lat) + Math.Abs(20.6962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.69056 - lat) + Math.Abs(22.17083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07118 - lat) + Math.Abs(20.3251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.79306 - lat) + Math.Abs(20.28028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.57476 - lat) + Math.Abs(20.13477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.51278 - lat) + Math.Abs(20.295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14249 - lat) + Math.Abs(20.25765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28401 - lat) + Math.Abs(20.96433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9842 - lat) + Math.Abs(20.28382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.985 - lat) + Math.Abs(20.16083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29489 - lat) + Math.Abs(20.45845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56715 - lat) + Math.Abs(20.7135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72538 - lat) + Math.Abs(20.69008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67653 - lat) + Math.Abs(20.39232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.36263 - lat) + Math.Abs(21.85619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.51972 - lat) + Math.Abs(20.57361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.64333 - lat) + Math.Abs(21.87111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.36548 - lat) + Math.Abs(20.95885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66436 - lat) + Math.Abs(20.92763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87393 - lat) + Math.Abs(20.09175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50883 - lat) + Math.Abs(21.72296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9275 - lat) + Math.Abs(20.07722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1277 - lat) + Math.Abs(20.91461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00501 - lat) + Math.Abs(20.48256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36667 - lat) + Math.Abs(20.77222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97596 - lat) + Math.Abs(20.10816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20255 - lat) + Math.Abs(20.77392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38445 - lat) + Math.Abs(21.73708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14667 - lat) + Math.Abs(20.48619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27315 - lat) + Math.Abs(20.09051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84227 - lat) + Math.Abs(20.27815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.68477 - lat) + Math.Abs(20.44993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.06454 - lat) + Math.Abs(21.2281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63864 - lat) + Math.Abs(20.52136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.863 - lat) + Math.Abs(21.09345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.67222 - lat) + Math.Abs(21.54944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46082 - lat) + Math.Abs(20.56939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.74194 - lat) + Math.Abs(20.44139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3787 - lat) + Math.Abs(21.69591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43364 - lat) + Math.Abs(22.22861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74617 - lat) + Math.Abs(20.78917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58345 - lat) + Math.Abs(21.76469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.22712 - lat) + Math.Abs(20.97754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.23417 - lat) + Math.Abs(21.58806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.30917 - lat) + Math.Abs(21.64917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.84889 - lat) + Math.Abs(20.03632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.62133 - lat) + Math.Abs(21.18782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22722 - lat) + Math.Abs(21.12167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15306 - lat) + Math.Abs(22.58611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.37694 - lat) + Math.Abs(21.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20813 - lat) + Math.Abs(20.38197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10569 - lat) + Math.Abs(21.23952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.86083 - lat) + Math.Abs(21.40778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87177 - lat) + Math.Abs(20.64167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11988 - lat) + Math.Abs(20.7286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.82756 - lat) + Math.Abs(20.16279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88349 - lat) + Math.Abs(20.53336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72769 - lat) + Math.Abs(20.31845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88863 - lat) + Math.Abs(20.16642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24171 - lat) + Math.Abs(20.58089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05222 - lat) + Math.Abs(20.43028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.65486 - lat) + Math.Abs(20.20017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71916 - lat) + Math.Abs(20.30364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12554 - lat) + Math.Abs(20.23914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.13667 - lat) + Math.Abs(20.51222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18264 - lat) + Math.Abs(20.86381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78241 - lat) + Math.Abs(20.62289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05 - lat) + Math.Abs(20.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07636 - lat) + Math.Abs(20.17948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55918 - lat) + Math.Abs(20.7003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80556 - lat) + Math.Abs(20.42417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59861 - lat) + Math.Abs(20.13556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.95691 - lat) + Math.Abs(20.28076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94366 - lat) + Math.Abs(20.21931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66833 - lat) + Math.Abs(20.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.32472 - lat) + Math.Abs(21.90333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05245 - lat) + Math.Abs(21.06695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3446 - lat) + Math.Abs(20.71418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.22639 - lat) + Math.Abs(22.53083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87503 - lat) + Math.Abs(20.56709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00333 - lat) + Math.Abs(20.04007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30196 - lat) + Math.Abs(20.16919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76457 - lat) + Math.Abs(20.13286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93362 - lat) + Math.Abs(20.41215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.43861 - lat) + Math.Abs(20.69917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.25846 - lat) + Math.Abs(21.66456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.25194 - lat) + Math.Abs(20.08167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30508 - lat) + Math.Abs(21.06404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47085 - lat) + Math.Abs(20.41508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.28358 - lat) + Math.Abs(21.7204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5168 - lat) + Math.Abs(20.31961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.84306 - lat) + Math.Abs(21.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53815 - lat) + Math.Abs(20.80677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14964 - lat) + Math.Abs(21.47242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21598 - lat) + Math.Abs(21.17527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55611 - lat) + Math.Abs(21.28556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20979 - lat) + Math.Abs(21.33729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63834 - lat) + Math.Abs(20.306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.42771 - lat) + Math.Abs(21.94596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30244 - lat) + Math.Abs(20.42632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33815 - lat) + Math.Abs(20.49895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.52314 - lat) + Math.Abs(21.07083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.86083 - lat) + Math.Abs(20.13806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15198 - lat) + Math.Abs(21.03073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21583 - lat) + Math.Abs(20.21222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02604 - lat) + Math.Abs(20.02737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.23007 - lat) + Math.Abs(20.23819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.99806 - lat) + Math.Abs(21.94611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.92389 - lat) + Math.Abs(21.7375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38893 - lat) + Math.Abs(20.53999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.38534 - lat) + Math.Abs(20.2557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18424 - lat) + Math.Abs(21.09727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.36944 - lat) + Math.Abs(20.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03487 - lat) + Math.Abs(21.37989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.13826 - lat) + Math.Abs(21.27339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70708 - lat) + Math.Abs(20.04959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29254 - lat) + Math.Abs(21.13702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53946 - lat) + Math.Abs(20.22902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.4775 - lat) + Math.Abs(21.67 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58 - lat) + Math.Abs(21.33389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13871 - lat) + Math.Abs(20.13308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.72583 - lat) + Math.Abs(20.68944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45283 - lat) + Math.Abs(20.72976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01667 - lat) + Math.Abs(20.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7475 - lat) + Math.Abs(20.97611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23422 - lat) + Math.Abs(20.02327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11167 - lat) + Math.Abs(20.62139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31575 - lat) + Math.Abs(20.91468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18675 - lat) + Math.Abs(20.319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42254 - lat) + Math.Abs(20.48049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61147 - lat) + Math.Abs(22.60955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.82972 - lat) + Math.Abs(20.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06667 - lat) + Math.Abs(20.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18635 - lat) + Math.Abs(21.0455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89876 - lat) + Math.Abs(20.2213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44725 - lat) + Math.Abs(20.85546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26985 - lat) + Math.Abs(20.76078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17141 - lat) + Math.Abs(21.00658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47498 - lat) + Math.Abs(20.43835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.97713 - lat) + Math.Abs(21.26121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07524 - lat) + Math.Abs(21.39067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02253 - lat) + Math.Abs(21.18388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58028 - lat) + Math.Abs(20.23111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04816 - lat) + Math.Abs(20.08165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16897 - lat) + Math.Abs(20.92008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18895 - lat) + Math.Abs(20.51442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.82648 - lat) + Math.Abs(20.31791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66202 - lat) + Math.Abs(20.79138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2501 - lat) + Math.Abs(20.96016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16816 - lat) + Math.Abs(21.44264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67152 - lat) + Math.Abs(20.71648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60049 - lat) + Math.Abs(20.08539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.02603 - lat) + Math.Abs(20.46152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91995 - lat) + Math.Abs(20.01766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98533 - lat) + Math.Abs(20.06339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.65296 - lat) + Math.Abs(21.63199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.04213 - lat) + Math.Abs(21.3134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20359 - lat) + Math.Abs(20.13558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.22278 - lat) + Math.Abs(22.03194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19172 - lat) + Math.Abs(20.47239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44263 - lat) + Math.Abs(20.30003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32328 - lat) + Math.Abs(20.44294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32591 - lat) + Math.Abs(20.06532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.52223 - lat) + Math.Abs(21.7603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.46593 - lat) + Math.Abs(22.1517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.22293 - lat) + Math.Abs(21.41421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.19817 - lat) + Math.Abs(21.83258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21339 - lat) + Math.Abs(20.84995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82631 - lat) + Math.Abs(20.22487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.01417 - lat) + Math.Abs(22.77556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.0925 - lat) + Math.Abs(21.44694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0707 - lat) + Math.Abs(20.60153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47221 - lat) + Math.Abs(20.06861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.9275 - lat) + Math.Abs(21.37 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7825 - lat) + Math.Abs(20.42028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.80988 - lat) + Math.Abs(22.29881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97326 - lat) + Math.Abs(20.27614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00984 - lat) + Math.Abs(20.63702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1546 - lat) + Math.Abs(20.01851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9425 - lat) + Math.Abs(20.14333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.71882 - lat) + Math.Abs(21.44085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56361 - lat) + Math.Abs(20.53194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10814 - lat) + Math.Abs(20.38947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.89139 - lat) + Math.Abs(20.34972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.33152 - lat) + Math.Abs(21.75407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.45917 - lat) + Math.Abs(21.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.74669 - lat) + Math.Abs(20.41436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.95229 - lat) + Math.Abs(22.17869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30837 - lat) + Math.Abs(20.63514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5011 - lat) + Math.Abs(22.47238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.07488 - lat) + Math.Abs(22.09591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72355 - lat) + Math.Abs(20.22348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.83028 - lat) + Math.Abs(21.95306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3554 - lat) + Math.Abs(20.82987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.01224 - lat) + Math.Abs(21.721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76994 - lat) + Math.Abs(20.2839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.29528 - lat) + Math.Abs(21.28583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35518 - lat) + Math.Abs(21.74781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13092 - lat) + Math.Abs(20.06698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80401 - lat) + Math.Abs(20.46513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.23846 - lat) + Math.Abs(21.39673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27278 - lat) + Math.Abs(20.375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0192 - lat) + Math.Abs(20.33323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21833 - lat) + Math.Abs(22.31111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8975 - lat) + Math.Abs(21.41722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50928 - lat) + Math.Abs(20.609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77983 - lat) + Math.Abs(20.20577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61632 - lat) + Math.Abs(20.03331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15361 - lat) + Math.Abs(21.08167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64102 - lat) + Math.Abs(20.41434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18189 - lat) + Math.Abs(21.08279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.6507 - lat) + Math.Abs(20.25941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08459 - lat) + Math.Abs(20.44264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.57889 - lat) + Math.Abs(20.41583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81961 - lat) + Math.Abs(20.60772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58693 - lat) + Math.Abs(20.56421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04987 - lat) + Math.Abs(21.018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51866 - lat) + Math.Abs(20.51146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36606 - lat) + Math.Abs(20.66407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.67248 - lat) + Math.Abs(20.4653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27146 - lat) + Math.Abs(20.82833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70681 - lat) + Math.Abs(20.07928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53271 - lat) + Math.Abs(20.03082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21963 - lat) + Math.Abs(21.34463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.75306 - lat) + Math.Abs(20.09556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.30694 - lat) + Math.Abs(20.56 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38346 - lat) + Math.Abs(20.30137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08083 - lat) + Math.Abs(20.96583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.54167 - lat) + Math.Abs(21.70778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.45861 - lat) + Math.Abs(21.0525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8025 - lat) + Math.Abs(20.12583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.28722 - lat) + Math.Abs(20.61528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.29507 - lat) + Math.Abs(22.0057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21528 - lat) + Math.Abs(20.31556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76291 - lat) + Math.Abs(20.57117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77833 - lat) + Math.Abs(20.47583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77465 - lat) + Math.Abs(20.53207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.95223 - lat) + Math.Abs(20.43521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.92694 - lat) + Math.Abs(20.71889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.87701 - lat) + Math.Abs(20.50004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77917 - lat) + Math.Abs(20.45389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81167 - lat) + Math.Abs(20.51611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81789 - lat) + Math.Abs(20.46186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75711 - lat) + Math.Abs(19.4707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45408 - lat) + Math.Abs(19.6905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.95448 - lat) + Math.Abs(19.48938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12174 - lat) + Math.Abs(19.79227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57139 - lat) + Math.Abs(19.64083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61472 - lat) + Math.Abs(19.78528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96731 - lat) + Math.Abs(19.28993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25446 - lat) + Math.Abs(19.7588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67914 - lat) + Math.Abs(19.6515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.27513 - lat) + Math.Abs(19.89821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87861 - lat) + Math.Abs(19.60356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.85861 - lat) + Math.Abs(19.84878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.49502 - lat) + Math.Abs(19.2649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40861 - lat) + Math.Abs(19.88917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55726 - lat) + Math.Abs(19.5297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82018 - lat) + Math.Abs(19.64128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1 - lat) + Math.Abs(19.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.79415 - lat) + Math.Abs(19.59529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41369 - lat) + Math.Abs(19.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93895 - lat) + Math.Abs(19.16709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20285 - lat) + Math.Abs(19.93373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92077 - lat) + Math.Abs(19.28577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97639 - lat) + Math.Abs(19.61222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55389 - lat) + Math.Abs(19.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59427 - lat) + Math.Abs(19.09719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77417 - lat) + Math.Abs(19.11222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.27306 - lat) + Math.Abs(19.99944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61503 - lat) + Math.Abs(19.63601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12833 - lat) + Math.Abs(19.22639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86704 - lat) + Math.Abs(19.66006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96514 - lat) + Math.Abs(19.74151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94722 - lat) + Math.Abs(19.58611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82843 - lat) + Math.Abs(19.39437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.74667 - lat) + Math.Abs(19.69 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.294 - lat) + Math.Abs(19.74306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00806 - lat) + Math.Abs(19.82222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99088 - lat) + Math.Abs(19.10635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70961 - lat) + Math.Abs(19.42472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44967 - lat) + Math.Abs(19.62097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94326 - lat) + Math.Abs(19.4228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92191 - lat) + Math.Abs(19.49543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.99259 - lat) + Math.Abs(19.97102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70061 - lat) + Math.Abs(19.38695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38996 - lat) + Math.Abs(19.6487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.67636 - lat) + Math.Abs(19.08809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58306 - lat) + Math.Abs(19.52519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82213 - lat) + Math.Abs(19.79487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24667 - lat) + Math.Abs(19.87944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66627 - lat) + Math.Abs(19.43923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90889 - lat) + Math.Abs(19.96639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.37306 - lat) + Math.Abs(19.60139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50667 - lat) + Math.Abs(19.26111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32106 - lat) + Math.Abs(19.35048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67041 - lat) + Math.Abs(19.34495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25167 - lat) + Math.Abs(19.83694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46056 - lat) + Math.Abs(19.81139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85017 - lat) + Math.Abs(19.82321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.6014 - lat) + Math.Abs(19.66718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54278 - lat) + Math.Abs(19.675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.78853 - lat) + Math.Abs(19.50033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85617 - lat) + Math.Abs(19.54654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.37344 - lat) + Math.Abs(19.10651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70833 - lat) + Math.Abs(19.66528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77105 - lat) + Math.Abs(19.65512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36248 - lat) + Math.Abs(19.53211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96739 - lat) + Math.Abs(19.59314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18944 - lat) + Math.Abs(19.37667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.69783 - lat) + Math.Abs(19.50101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58058 - lat) + Math.Abs(19.26572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.6525 - lat) + Math.Abs(19.31 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73759 - lat) + Math.Abs(19.01082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.4024 - lat) + Math.Abs(19.58814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60889 - lat) + Math.Abs(19.52639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.36556 - lat) + Math.Abs(19.36194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55021 - lat) + Math.Abs(19.59153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58727 - lat) + Math.Abs(19.28412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.99611 - lat) + Math.Abs(19.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89292 - lat) + Math.Abs(18.9276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.47361 - lat) + Math.Abs(19.81167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80794 - lat) + Math.Abs(19.43508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.78846 - lat) + Math.Abs(19.71004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35421 - lat) + Math.Abs(19.72975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.343 - lat) + Math.Abs(19.72333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58772 - lat) + Math.Abs(19.40967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72172 - lat) + Math.Abs(19.66364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.727 - lat) + Math.Abs(19.735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53995 - lat) + Math.Abs(19.42418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.91843 - lat) + Math.Abs(19.75477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58625 - lat) + Math.Abs(19.34701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10111 - lat) + Math.Abs(19.85833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88155 - lat) + Math.Abs(19.76374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53516 - lat) + Math.Abs(19.29971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.76496 - lat) + Math.Abs(19.84489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58286 - lat) + Math.Abs(19.30858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.51645 - lat) + Math.Abs(19.33915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.34233 - lat) + Math.Abs(19.78647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.89021 - lat) + Math.Abs(19.54913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27954 - lat) + Math.Abs(19.56838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86341 - lat) + Math.Abs(19.41532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90078 - lat) + Math.Abs(19.06138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80117 - lat) + Math.Abs(19.50902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86649 - lat) + Math.Abs(19.70943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53302 - lat) + Math.Abs(19.7625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60699 - lat) + Math.Abs(19.18868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61183 - lat) + Math.Abs(19.33109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50556 - lat) + Math.Abs(19.47543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70224 - lat) + Math.Abs(19.57931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45983 - lat) + Math.Abs(19.52653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66595 - lat) + Math.Abs(19.54562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87374 - lat) + Math.Abs(19.3948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.65319 - lat) + Math.Abs(19.39016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26999 - lat) + Math.Abs(19.52484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.74977 - lat) + Math.Abs(19.71273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.49523 - lat) + Math.Abs(19.57116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.89388 - lat) + Math.Abs(19.86344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55376 - lat) + Math.Abs(19.7715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92977 - lat) + Math.Abs(19.36086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.71799 - lat) + Math.Abs(19.59533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53015 - lat) + Math.Abs(19.13022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8375 - lat) + Math.Abs(19.48056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20829 - lat) + Math.Abs(19.72063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81782 - lat) + Math.Abs(19.54801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58099 - lat) + Math.Abs(19.71932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9104 - lat) + Math.Abs(19.44916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.97083 - lat) + Math.Abs(19.5675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.78534 - lat) + Math.Abs(19.37146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36056 - lat) + Math.Abs(19.59167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92034 - lat) + Math.Abs(18.92944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81516 - lat) + Math.Abs(19.6318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24966 - lat) + Math.Abs(19.39664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39194 - lat) + Math.Abs(19.23667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6726 - lat) + Math.Abs(18.978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72222 - lat) + Math.Abs(19.70722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.84678 - lat) + Math.Abs(19.40935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.729 - lat) + Math.Abs(19.70029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.13694 - lat) + Math.Abs(19.80556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.14528 - lat) + Math.Abs(19.85889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.57261 - lat) + Math.Abs(19.58988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.56634 - lat) + Math.Abs(22.25701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55909 - lat) + Math.Abs(22.17487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38682 - lat) + Math.Abs(21.734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38853 - lat) + Math.Abs(21.72971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38999 - lat) + Math.Abs(21.74365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38674 - lat) + Math.Abs(21.7434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.38025 - lat) + Math.Abs(21.74045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.29511 - lat) + Math.Abs(22.20626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0523 - lat) + Math.Abs(19.84448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zvečka", "SE", 44.64025, 20.16432);
case 1: return new CityInfo("Žujince", "SE", 42.31568, 21.70212);
case 2: return new CityInfo("Zrenjanin", "VO", 45.38361, 20.38194);
case 3: return new CityInfo("Žitorađa", "SE", 43.19, 21.71306);
case 4: return new CityInfo("Žitni Potok", "SE", 43.09021, 21.57476);
case 5: return new CityInfo("Žitište", "VO", 45.485, 20.54972);
case 6: return new CityInfo("Zemun", "SE", 44.8458, 20.40116);
case 7: return new CityInfo("Zaječar", "SE", 43.90358, 22.26405);
case 8: return new CityInfo("Žagubica", "SE", 44.19685, 21.78838);
case 9: return new CityInfo("Žabari", "SE", 44.35611, 21.215);
case 10: return new CityInfo("Žabalj", "VO", 45.37222, 20.06389);
case 11: return new CityInfo("Vršac", "VO", 45.11667, 21.30361);
case 12: return new CityInfo("Vrnjačka Banja", "SE", 43.62725, 20.89634);
case 13: return new CityInfo("Vrbica", "VO", 46.00584, 20.31325);
case 14: return new CityInfo("Vranjska Banja", "SE", 42.555, 21.99222);
case 15: return new CityInfo("Vranje", "SE", 42.55139, 21.90028);
case 16: return new CityInfo("Vranić", "SE", 44.60237, 20.32872);
case 17: return new CityInfo("Vračar", "SE", 44.79256, 20.47491);
case 18: return new CityInfo("Vojvodinci", "VO", 45.01557, 21.34793);
case 19: return new CityInfo("Vojvoda Stepa", "VO", 45.68537, 20.65536);
case 20: return new CityInfo("Vojka", "VO", 44.93713, 20.15236);
case 21: return new CityInfo("Vlasotince", "SE", 42.96697, 22.13402);
case 22: return new CityInfo("Vlajkovac", "VO", 45.07207, 21.19945);
case 23: return new CityInfo("Vladimirovac", "VO", 45.03122, 20.86566);
case 24: return new CityInfo("Vladičin Han", "SE", 42.70778, 22.06333);
case 25: return new CityInfo("Vilovo", "VO", 45.24859, 20.15521);
case 26: return new CityInfo("Veliko Središte", "VO", 45.17919, 21.40353);
case 27: return new CityInfo("Veliko Gradište", "SE", 44.76329, 21.51646);
case 28: return new CityInfo("Veliki Gaj", "VO", 45.28849, 21.17057);
case 29: return new CityInfo("Aleksandrovo", "VO", 45.63755, 20.59288);
case 30: return new CityInfo("Velika Plana", "SE", 44.33389, 21.07676);
case 31: return new CityInfo("Velika Moštanica", "SE", 44.66486, 20.35395);
case 32: return new CityInfo("Velika Greda", "VO", 45.24376, 21.03498);
case 33: return new CityInfo("Varvarin", "SE", 43.72397, 21.3624);
case 34: return new CityInfo("Uzdin", "VO", 45.20512, 20.62342);
case 35: return new CityInfo("Umka", "SE", 44.67806, 20.30472);
case 36: return new CityInfo("Uljma", "VO", 45.04213, 21.15393);
case 37: return new CityInfo("Ugrinovci", "SE", 44.87635, 20.18763);
case 38: return new CityInfo("Ub", "SE", 44.45611, 20.07389);
case 39: return new CityInfo("Tutin", "SE", 42.99028, 20.33139);
case 40: return new CityInfo("Turija", "SE", 44.52273, 21.63945);
case 41: return new CityInfo("Tulare", "SE", 43.228, 21.37961);
case 42: return new CityInfo("Trstenik", "SE", 43.61694, 21.0025);
case 43: return new CityInfo("Trgovište", "SE", 42.36417, 22.0825);
case 44: return new CityInfo("Torda", "VO", 45.58423, 20.459);
case 45: return new CityInfo("Topola", "SE", 44.25417, 20.6825);
case 46: return new CityInfo("Tomaševac", "VO", 45.26855, 20.62272);
case 47: return new CityInfo("Toba", "VO", 45.68943, 20.55714);
case 48: return new CityInfo("Titel", "VO", 45.20611, 20.29444);
case 49: return new CityInfo("Taraš", "VO", 45.46737, 20.19867);
case 50: return new CityInfo("Svrljig", "SE", 43.41333, 22.12111);
case 51: return new CityInfo("Svilajnac", "SE", 44.2337, 21.1967);
case 52: return new CityInfo("Suvi Do", "SE", 43.25829, 21.33269);
case 53: return new CityInfo("Sutjeska", "VO", 45.38312, 20.6962);
case 54: return new CityInfo("Surdulica", "SE", 42.69056, 22.17083);
case 55: return new CityInfo("Surduk", "VO", 45.07118, 20.3251);
case 56: return new CityInfo("Surčin", "SE", 44.79306, 20.28028);
case 57: return new CityInfo("Stubline", "SE", 44.57476, 20.13477);
case 58: return new CityInfo("Stepojevac", "SE", 44.51278, 20.295);
case 59: return new CityInfo("Stari Slankamen", "VO", 45.14249, 20.25765);
case 60: return new CityInfo("Stari Lec", "VO", 45.28401, 20.96433);
case 61: return new CityInfo("Stari Banovci", "VO", 44.9842, 20.28382);
case 62: return new CityInfo("Stara Pazova", "VO", 44.985, 20.16083);
case 63: return new CityInfo("Stajićevo", "VO", 45.29489, 20.45845);
case 64: return new CityInfo("Srpski Itebej", "VO", 45.56715, 20.7135);
case 65: return new CityInfo("Srpska Crnja", "VO", 45.72538, 20.69008);
case 66: return new CityInfo("Sremčica", "SE", 44.67653, 20.39232);
case 67: return new CityInfo("Spančevac", "SE", 42.36263, 21.85619);
case 68: return new CityInfo("Sopot", "SE", 44.51972, 20.57361);
case 69: return new CityInfo("Soko Banja", "SE", 43.64333, 21.87111);
case 70: return new CityInfo("Smederevska Palanka", "SE", 44.36548, 20.95885);
case 71: return new CityInfo("Smederevo", "SE", 44.66436, 20.92763);
case 72: return new CityInfo("Šimanovci", "VO", 44.87393, 20.09175);
case 73: return new CityInfo("Ševica", "SE", 44.50883, 21.72296);
case 74: return new CityInfo("Senta", "VO", 45.9275, 20.07722);
case 75: return new CityInfo("Seleuš", "VO", 45.1277, 20.91461);
case 76: return new CityInfo("Sefkerin", "VO", 45.00501, 20.48256);
case 77: return new CityInfo("Sečanj", "VO", 45.36667, 20.77222);
case 78: return new CityInfo("Sanad", "VO", 45.97596, 20.10816);
case 79: return new CityInfo("Samoš", "VO", 45.20255, 20.77392);
case 80: return new CityInfo("Samoljica", "SE", 42.38445, 21.73708);
case 81: return new CityInfo("Sakule", "VO", 45.14667, 20.48619);
case 82: return new CityInfo("Šajkaš", "VO", 45.27315, 20.09051);
case 83: return new CityInfo("Sajan", "VO", 45.84227, 20.27815);
case 84: return new CityInfo("Rušanj", "SE", 44.68477, 20.44993);
case 85: return new CityInfo("Ritiševo", "VO", 45.06454, 21.2281);
case 86: return new CityInfo("Ripanj", "SE", 44.63864, 20.52136);
case 87: return new CityInfo("Rekovac", "SE", 43.863, 21.09345);
case 88: return new CityInfo("Ražanj", "SE", 43.67222, 21.54944);
case 89: return new CityInfo("Ravni Topolovac", "VO", 45.46082, 20.56939);
case 90: return new CityInfo("Rakovica", "SE", 44.74194, 20.44139);
case 91: return new CityInfo("Rajince", "SE", 42.3787, 21.69591);
case 92: return new CityInfo("Radovnica", "SE", 42.43364, 22.22861);
case 93: return new CityInfo("Radojevo", "VO", 45.74617, 20.78917);
case 94: return new CityInfo("Radenka", "SE", 44.58345, 21.76469);
case 95: return new CityInfo("Rača", "SE", 44.22712, 20.97754);
case 96: return new CityInfo("Prokuplje", "SE", 43.23417, 21.58806);
case 97: return new CityInfo("Preševo", "SE", 42.30917, 21.64917);
case 98: return new CityInfo("Požega", "SE", 43.84889, 20.03632);
case 99: return new CityInfo("Požarevac", "SE", 44.62133, 21.18782);
case 100: return new CityInfo("Plandište", "VO", 45.22722, 21.12167);
case 101: return new CityInfo("Pirot", "SE", 43.15306, 22.58611);
case 102: return new CityInfo("Petrovac", "SE", 44.37694, 21.41917);
case 103: return new CityInfo("Perlez", "VO", 45.20813, 20.38197);
case 104: return new CityInfo("Pavliš", "VO", 45.10569, 21.23952);
case 105: return new CityInfo("Paraćin", "SE", 43.86083, 21.40778);
case 106: return new CityInfo("Pančevo", "VO", 44.87177, 20.64167);
case 107: return new CityInfo("Padina", "VO", 45.11988, 20.7286);
case 108: return new CityInfo("Padej", "VO", 45.82756, 20.16279);
case 109: return new CityInfo("Ovča", "SE", 44.88349, 20.53336);
case 110: return new CityInfo("Ostružnica", "SE", 44.72769, 20.31845);
case 111: return new CityInfo("Ostojićevo", "VO", 45.88863, 20.16642);
case 112: return new CityInfo("Orlovat", "VO", 45.24171, 20.58089);
case 113: return new CityInfo("Opovo", "VO", 45.05222, 20.43028);
case 114: return new CityInfo("Obrenovac", "SE", 44.65486, 20.20017);
case 115: return new CityInfo("Novo Miloševo", "VO", 45.71916, 20.30364);
case 116: return new CityInfo("Novi Slankamen", "VO", 45.12554, 20.23914);
case 117: return new CityInfo("Novi Pazar", "SE", 43.13667, 20.51222);
case 118: return new CityInfo("Kozjak", "VO", 45.18264, 20.86381);
case 119: return new CityInfo("Novi Kozarci", "VO", 45.78241, 20.62289);
case 120: return new CityInfo("Novi Kneževac", "VO", 46.05, 20.1);
case 121: return new CityInfo("Novi Karlovci", "VO", 45.07636, 20.17948);
case 122: return new CityInfo("Novi Itebej", "VO", 45.55918, 20.7003);
case 123: return new CityInfo("Novi Beograd", "SE", 44.80556, 20.42417);
case 124: return new CityInfo("Novi Bečej", "VO", 45.59861, 20.13556);
case 125: return new CityInfo("Novi Banovci", "VO", 44.95691, 20.28076);
case 126: return new CityInfo("Nova Pazova", "VO", 44.94366, 20.21931);
case 127: return new CityInfo("Nova Crnja", "VO", 45.66833, 20.605);
case 128: return new CityInfo("Niš", "SE", 43.32472, 21.90333);
case 129: return new CityInfo("Nikolinci", "VO", 45.05245, 21.06695);
case 130: return new CityInfo("Neuzina", "VO", 45.3446, 20.71418);
case 131: return new CityInfo("Negotin", "SE", 44.22639, 22.53083);
case 132: return new CityInfo("Nakovo", "VO", 45.87503, 20.56709);
case 133: return new CityInfo("Adorjan", "VO", 46.00333, 20.04007);
case 134: return new CityInfo("Mošorin", "VO", 45.30196, 20.16919);
case 135: return new CityInfo("Mol", "VO", 45.76457, 20.13286);
case 136: return new CityInfo("Mokrin", "VO", 45.93362, 20.41215);
case 137: return new CityInfo("Mladenovac", "SE", 44.43861, 20.69917);
case 138: return new CityInfo("Miratovac", "SE", 42.25846, 21.66456);
case 139: return new CityInfo("Mionica", "SE", 44.25194, 20.08167);
case 140: return new CityInfo("Miletićevo", "VO", 45.30508, 21.06404);
case 141: return new CityInfo("Mihajlovo", "VO", 45.47085, 20.41508);
case 142: return new CityInfo("Merošina", "SE", 43.28358, 21.7204);
case 143: return new CityInfo("Melenci", "VO", 45.5168, 20.31961);
case 144: return new CityInfo("Medveđa", "SE", 42.84306, 21.58333);
case 145: return new CityInfo("Međa", "VO", 45.53815, 20.80677);
case 146: return new CityInfo("Markovac", "VO", 45.14964, 21.47242);
case 147: return new CityInfo("Margita", "VO", 45.21598, 21.17527);
case 148: return new CityInfo("Malo Crniće", "SE", 44.55611, 21.28556);
case 149: return new CityInfo("Mali Žam", "VO", 45.20979, 21.33729);
case 150: return new CityInfo("Mala Moštanica", "SE", 44.63834, 20.306);
case 151: return new CityInfo("Majdanpek", "SE", 44.42771, 21.94596);
case 152: return new CityInfo("Lukino Selo", "VO", 45.30244, 20.42632);
case 153: return new CityInfo("Lukićevo", "VO", 45.33815, 20.49895);
case 154: return new CityInfo("Lugavčina", "SE", 44.52314, 21.07083);
case 155: return new CityInfo("Lučani", "SE", 43.86083, 20.13806);
case 156: return new CityInfo("Lokve", "VO", 45.15198, 21.03073);
case 157: return new CityInfo("Lok", "VO", 45.21583, 20.21222);
case 158: return new CityInfo("Ljukovo", "VO", 45.02604, 20.02737);
case 159: return new CityInfo("Ljig", "SE", 44.23007, 20.23819);
case 160: return new CityInfo("Leskovac", "SE", 42.99806, 21.94611);
case 161: return new CityInfo("Lebane", "SE", 42.92389, 21.7375);
case 162: return new CityInfo("Lazarevo", "VO", 45.38893, 20.53999);
case 163: return new CityInfo("Lazarevac", "SE", 44.38534, 20.2557);
case 164: return new CityInfo("Lapovo", "SE", 44.18424, 21.09727);
case 165: return new CityInfo("Lajkovac", "SE", 44.36944, 20.16528);
case 166: return new CityInfo("Kuštilj", "VO", 45.03487, 21.37989);
case 167: return new CityInfo("Kuršumlija", "SE", 43.13826, 21.27339);
case 168: return new CityInfo("Kupinovo", "VO", 44.70708, 20.04959);
case 169: return new CityInfo("Kupinik", "VO", 45.29254, 21.13702);
case 170: return new CityInfo("Kumane", "VO", 45.53946, 20.22902);
case 171: return new CityInfo("Kučevo", "SE", 44.4775, 21.67);
case 172: return new CityInfo("Kruševac", "SE", 43.58, 21.33389);
case 173: return new CityInfo("Krčedin", "VO", 45.13871, 20.13308);
case 174: return new CityInfo("Kraljevo", "SE", 43.72583, 20.68944);
case 175: return new CityInfo("Krajišnik", "VO", 45.45283, 20.72976);
case 176: return new CityInfo("Kragujevac", "SE", 44.01667, 20.91667);
case 177: return new CityInfo("Kovin", "VO", 44.7475, 20.97611);
case 178: return new CityInfo("Kovilj", "VO", 45.23422, 20.02327);
case 179: return new CityInfo("Kovačica", "VO", 45.11167, 20.62139);
case 180: return new CityInfo("Konak", "VO", 45.31575, 20.91468);
case 181: return new CityInfo("Knićanin", "VO", 45.18675, 20.319);
case 182: return new CityInfo("Klek", "VO", 45.42254, 20.48049);
case 183: return new CityInfo("Kladovo", "SE", 44.61147, 22.60955);
case 184: return new CityInfo("Kikinda", "VO", 45.82972, 20.46528);
case 185: return new CityInfo("Kanjiža", "VO", 46.06667, 20.05);
case 186: return new CityInfo("Jermenovci", "VO", 45.18635, 21.0455);
case 187: return new CityInfo("Jazovo", "VO", 45.89876, 20.2213);
case 188: return new CityInfo("Jaša Tomić", "VO", 45.44725, 20.85546);
case 189: return new CityInfo("Jarkovac", "VO", 45.26985, 20.76078);
case 190: return new CityInfo("Janošik", "VO", 45.17141, 21.00658);
case 191: return new CityInfo("Jankov Most", "VO", 45.47498, 20.43835);
case 192: return new CityInfo("Jagodina", "SE", 43.97713, 21.26121);
case 193: return new CityInfo("Jablanka", "VO", 45.07524, 21.39067);
case 194: return new CityInfo("Izbište", "VO", 45.02253, 21.18388);
case 195: return new CityInfo("Ivanjica", "SE", 43.58028, 20.23111);
case 196: return new CityInfo("Inđija", "VO", 45.04816, 20.08165);
case 197: return new CityInfo("Ilandža", "VO", 45.16897, 20.92008);
case 198: return new CityInfo("Idvor", "VO", 45.18895, 20.51442);
case 199: return new CityInfo("Tiszahegyes", "VO", 45.82648, 20.31791);
case 200: return new CityInfo("Hetin", "VO", 45.66202, 20.79138);
case 201: return new CityInfo("Hajdučica", "VO", 45.2501, 20.96016);
case 202: return new CityInfo("Gudurica", "VO", 45.16816, 21.44264);
case 203: return new CityInfo("Grocka", "SE", 44.67152, 20.71648);
case 204: return new CityInfo("Grabovac", "SE", 44.60049, 20.08539);
case 205: return new CityInfo("Gornji Milanovac", "SE", 44.02603, 20.46152);
case 206: return new CityInfo("Gornji Breg", "VO", 45.91995, 20.01766);
case 207: return new CityInfo("Golubinci", "VO", 44.98533, 20.06339);
case 208: return new CityInfo("Golubac", "SE", 44.65296, 21.63199);
case 209: return new CityInfo("Glogovac", "SE", 44.04213, 21.3134);
case 210: return new CityInfo("Gardinovci", "VO", 45.20359, 20.13558);
case 211: return new CityInfo("Gadžin Han", "SE", 43.22278, 22.03194);
case 212: return new CityInfo("Farkaždin", "VO", 45.19172, 20.47239);
case 213: return new CityInfo("Elemir", "VO", 45.44263, 20.30003);
case 214: return new CityInfo("Ečka", "VO", 45.32328, 20.44294);
case 215: return new CityInfo("Ðurđevo", "VO", 45.32591, 20.06532);
case 216: return new CityInfo("Duboka", "SE", 44.52223, 21.7603);
case 217: return new CityInfo("Donji Milanovac", "SE", 44.46593, 22.1517);
case 218: return new CityInfo("Donja Konjuša", "SE", 43.22293, 21.41421);
case 219: return new CityInfo("Doljevac", "SE", 43.19817, 21.83258);
case 220: return new CityInfo("Dobrica", "VO", 45.21339, 20.84995);
case 221: return new CityInfo("Dobanovci", "SE", 44.82631, 20.22487);
case 222: return new CityInfo("Dimitrovgrad", "SE", 43.01417, 22.77556);
case 223: return new CityInfo("Despotovac", "SE", 44.0925, 21.44694);
case 224: return new CityInfo("Debeljača", "VO", 45.0707, 20.60153);
case 225: return new CityInfo("Čurug", "VO", 45.47221, 20.06861);
case 226: return new CityInfo("Ćuprija", "SE", 43.9275, 21.37);
case 227: return new CityInfo("Čukarica", "SE", 44.7825, 20.42028);
case 228: return new CityInfo("Crna Trava", "SE", 42.80988, 22.29881);
case 229: return new CityInfo("Crna Bara", "VO", 45.97326, 20.27614);
case 230: return new CityInfo("Crepaja", "VO", 45.00984, 20.63702);
case 231: return new CityInfo("Čortanovci", "VO", 45.1546, 20.01851);
case 232: return new CityInfo("Čoka", "VO", 45.9425, 20.14333);
case 233: return new CityInfo("Ćićevac", "SE", 43.71882, 21.44085);
case 234: return new CityInfo("Čestereg", "VO", 45.56361, 20.53194);
case 235: return new CityInfo("Čenta", "VO", 45.10814, 20.38947);
case 236: return new CityInfo("Čačak", "SE", 43.89139, 20.34972);
case 237: return new CityInfo("Buštranje", "SE", 42.33152, 21.75407);
case 238: return new CityInfo("Bujanovac", "SE", 42.45917, 21.76667);
case 239: return new CityInfo("Brezovica", "SE", 43.74669, 20.41436);
case 240: return new CityInfo("Brezovica", "SE", 42.95229, 22.17869);
case 241: return new CityInfo("Botoš", "VO", 45.30837, 20.63514);
case 242: return new CityInfo("Bosilegrad", "SE", 42.5011, 22.47238);
case 243: return new CityInfo("Bor", "SE", 44.07488, 22.09591);
case 244: return new CityInfo("Boljevci", "SE", 44.72355, 20.22348);
case 245: return new CityInfo("Boljevac", "SE", 43.83028, 21.95306);
case 246: return new CityInfo("Boka", "VO", 45.3554, 20.82987);
case 247: return new CityInfo("Bojnik", "SE", 43.01224, 21.721);
case 248: return new CityInfo("Bočar", "VO", 45.76994, 20.2839);
case 249: return new CityInfo("Blace", "SE", 43.29528, 21.28583);
case 250: return new CityInfo("Biljača", "SE", 42.35518, 21.74781);
case 251: return new CityInfo("Beška", "VO", 45.13092, 20.06698);
case 252: return new CityInfo("Belgrade", "SE", 44.80401, 20.46513);
case 253: return new CityInfo("Beloljin", "SE", 43.23846, 21.39673);
case 254: return new CityInfo("Belo Blato", "VO", 45.27278, 20.375);
case 255: return new CityInfo("Belegiš", "VO", 45.0192, 20.33323);
case 256: return new CityInfo("Bela Palanka", "SE", 43.21833, 22.31111);
case 257: return new CityInfo("Bela Crkva", "VO", 44.8975, 21.41722);
case 258: return new CityInfo("Torak", "VO", 45.50928, 20.609);
case 259: return new CityInfo("Bečmen", "SE", 44.77983, 20.20577);
case 260: return new CityInfo("Bečej", "VO", 45.61632, 20.03331);
case 261: return new CityInfo("Batočina", "SE", 44.15361, 21.08167);
case 262: return new CityInfo("Bašaid", "VO", 45.64102, 20.41434);
case 263: return new CityInfo("Barice", "VO", 45.18189, 21.08279);
case 264: return new CityInfo("Barič", "SE", 44.6507, 20.25941);
case 265: return new CityInfo("Baranda", "VO", 45.08459, 20.44264);
case 266: return new CityInfo("Barajevo", "SE", 44.57889, 20.41583);
case 267: return new CityInfo("Banatsko Veliko Selo", "VO", 45.81961, 20.60772);
case 268: return new CityInfo("Banatsko Karađorđevo", "VO", 45.58693, 20.56421);
case 269: return new CityInfo("Banatski Karlovac", "VO", 45.04987, 21.018);
case 270: return new CityInfo("Banatski Dvor", "VO", 45.51866, 20.51146);
case 271: return new CityInfo("Banatski Despotovac", "VO", 45.36606, 20.66407);
case 272: return new CityInfo("Banatska Topola", "VO", 45.67248, 20.4653);
case 273: return new CityInfo("Banatska Dubica", "VO", 45.27146, 20.82833);
case 274: return new CityInfo("Bačko Petrovo Selo", "VO", 45.70681, 20.07928);
case 275: return new CityInfo("Bačko Gradište", "VO", 45.53271, 20.03082);
case 276: return new CityInfo("Bace", "SE", 43.21963, 21.34463);
case 277: return new CityInfo("Arilje", "SE", 43.75306, 20.09556);
case 278: return new CityInfo("Aranđelovac", "SE", 44.30694, 20.56);
case 279: return new CityInfo("Aradac", "VO", 45.38346, 20.30137);
case 280: return new CityInfo("Alibunar", "VO", 45.08083, 20.96583);
case 281: return new CityInfo("Aleksinac", "SE", 43.54167, 21.70778);
case 282: return new CityInfo("Aleksandrovac", "SE", 43.45861, 21.0525);
case 283: return new CityInfo("Ada", "VO", 45.8025, 20.12583);
case 284: return new CityInfo("Raška", "SE", 43.28722, 20.61528);
case 285: return new CityInfo("Niška Banja", "SE", 43.29507, 22.0057);
case 286: return new CityInfo("Sokolovica", "SE", 43.21528, 20.31556);
case 287: return new CityInfo("Rusko Selo", "VO", 45.76291, 20.57117);
case 288: return new CityInfo("Voždovac", "SE", 44.77833, 20.47583);
case 289: return new CityInfo("Zvezdara", "SE", 44.77465, 20.53207);
case 290: return new CityInfo("Prislonica", "SE", 43.95223, 20.43521);
case 291: return new CityInfo("Knić", "SE", 43.92694, 20.71889);
case 292: return new CityInfo("Donja Gorevnica", "SE", 43.87701, 20.50004);
case 293: return new CityInfo("Savski Venac", "SE", 44.77917, 20.45389);
case 294: return new CityInfo("Palilula", "SE", 44.81167, 20.51611);
case 295: return new CityInfo("Stari Grad", "SE", 44.81789, 20.46186);
case 296: return new CityInfo("Zminjak", "SE", 44.75711, 19.4707);
case 297: return new CityInfo("Zmajevo", "VO", 45.45408, 19.6905);
case 298: return new CityInfo("Zasavica Prva", "VO", 44.95448, 19.48938);
case 299: return new CityInfo("Vrdnik", "VO", 45.12174, 19.79227);
case 300: return new CityInfo("Vrbas", "VO", 45.57139, 19.64083);
case 301: return new CityInfo("Vladimirci", "SE", 44.61472, 19.78528);
case 302: return new CityInfo("Višnjićevo", "VO", 44.96731, 19.28993);
case 303: return new CityInfo("Veternik", "VO", 45.25446, 19.7588);
case 304: return new CityInfo("Varna", "SE", 44.67914, 19.6515);
case 305: return new CityInfo("Valjevo", "SE", 44.27513, 19.89821);
case 306: return new CityInfo("Uzveće", "SE", 44.87861, 19.60356);
case 307: return new CityInfo("Užice", "SE", 43.85861, 19.84878);
case 308: return new CityInfo("Tršić", "SE", 44.49502, 19.2649);
case 309: return new CityInfo("Temerin", "VO", 45.40861, 19.88917);
case 310: return new CityInfo("Tekeriš", "SE", 44.55726, 19.5297);
case 311: return new CityInfo("Tabanović", "SE", 44.82018, 19.64128);
case 312: return new CityInfo("Subotica", "VO", 46.1, 19.66667);
case 313: return new CityInfo("Štitar", "SE", 44.79415, 19.59529);
case 314: return new CityInfo("Stepanovićevo", "VO", 45.41369, 19.7);
case 315: return new CityInfo("Stanišić", "VO", 45.93895, 19.16709);
case 316: return new CityInfo("Sremski Karlovci", "VO", 45.20285, 19.93373);
case 317: return new CityInfo("Sremska Rača", "VO", 44.92077, 19.28577);
case 318: return new CityInfo("Sremska Mitrovica", "VO", 44.97639, 19.61222);
case 319: return new CityInfo("Srbobran", "VO", 45.55389, 19.80278);
case 320: return new CityInfo("Sonta", "VO", 45.59427, 19.09719);
case 321: return new CityInfo("Sombor", "VO", 45.77417, 19.11222);
case 322: return new CityInfo("Sjenica", "SE", 43.27306, 19.99944);
case 323: return new CityInfo("Sinošević", "SE", 44.61503, 19.63601);
case 324: return new CityInfo("Šid", "VO", 45.12833, 19.22639);
case 325: return new CityInfo("Ševarice", "SE", 44.86704, 19.66006);
case 326: return new CityInfo("Šašinci", "VO", 44.96514, 19.74151);
case 327: return new CityInfo("Salaš Noćajski", "VO", 44.94722, 19.58611);
case 328: return new CityInfo("Salaš Crnobarski", "SE", 44.82843, 19.39437);
case 329: return new CityInfo("Šabac", "SE", 44.74667, 19.69);
case 330: return new CityInfo("Rumenka", "VO", 45.294, 19.74306);
case 331: return new CityInfo("Ruma", "VO", 45.00806, 19.82222);
case 332: return new CityInfo("Riđica", "VO", 45.99088, 19.10635);
case 333: return new CityInfo("Ribari", "SE", 44.70961, 19.42472);
case 334: return new CityInfo("Ravno Selo", "VO", 45.44967, 19.62097);
case 335: return new CityInfo("Ravnje", "VO", 44.94326, 19.4228);
case 336: return new CityInfo("Radenković", "VO", 44.92191, 19.49543);
case 337: return new CityInfo("Putinci", "VO", 44.99259, 19.97102);
case 338: return new CityInfo("Prnjavor", "SE", 44.70061, 19.38695);
case 339: return new CityInfo("Prijepolje", "SE", 43.38996, 19.6487);
case 340: return new CityInfo("Prigrevica", "VO", 45.67636, 19.08809);
case 341: return new CityInfo("Priboj", "SE", 43.58306, 19.52519);
case 342: return new CityInfo("Platičevo", "VO", 44.82213, 19.79487);
case 343: return new CityInfo("Petrovaradin", "VO", 45.24667, 19.87944);
case 344: return new CityInfo("Petkovica", "SE", 44.66627, 19.43923);
case 345: return new CityInfo("Pećinci", "VO", 44.90889, 19.96639);
case 346: return new CityInfo("Osečina", "SE", 44.37306, 19.60139);
case 347: return new CityInfo("Odžaci", "VO", 45.50667, 19.26111);
case 348: return new CityInfo("Obrovac", "VO", 45.32106, 19.35048);
case 349: return new CityInfo("Novo Selo", "SE", 44.67041, 19.34495);
case 350: return new CityInfo("Novi Sad", "VO", 45.25167, 19.83694);
case 351: return new CityInfo("Nova Varoš", "SE", 43.46056, 19.81139);
case 352: return new CityInfo("Nikinci", "VO", 44.85017, 19.82321);
case 353: return new CityInfo("Nakučani", "SE", 44.6014, 19.66718);
case 354: return new CityInfo("Mrovska", "SE", 44.54278, 19.675);
case 355: return new CityInfo("Mokra Gora", "SE", 43.78853, 19.50033);
case 356: return new CityInfo("Metković", "SE", 44.85617, 19.54654);
case 357: return new CityInfo("Mali Zvornik", "SE", 44.37344, 19.10651);
case 358: return new CityInfo("Mali Iđoš", "VO", 45.70833, 19.66528);
case 359: return new CityInfo("Majur", "SE", 44.77105, 19.65512);
case 360: return new CityInfo("Maglić", "VO", 45.36248, 19.53211);
case 361: return new CityInfo("Mačvanska Mitrovica", "VO", 44.96739, 19.59314);
case 362: return new CityInfo("Ljubovija", "SE", 44.18944, 19.37667);
case 363: return new CityInfo("Lipolist", "SE", 44.69783, 19.50101);
case 364: return new CityInfo("Lipnički Šor", "SE", 44.58058, 19.26572);
case 365: return new CityInfo("Lešnica", "SE", 44.6525, 19.31);
case 366: return new CityInfo("Kupusina", "VO", 45.73759, 19.01082);
case 367: return new CityInfo("Kulpin", "VO", 45.4024, 19.58814);
case 368: return new CityInfo("Kula", "VO", 45.60889, 19.52639);
case 369: return new CityInfo("Krupanj", "SE", 44.36556, 19.36194);
case 370: return new CityInfo("Krivaja", "SE", 44.55021, 19.59153);
case 371: return new CityInfo("Kozjak", "SE", 44.58727, 19.28412);
case 372: return new CityInfo("Kosjerić", "SE", 43.99611, 19.90694);
case 373: return new CityInfo("Kolut", "VO", 45.89292, 18.9276);
case 374: return new CityInfo("Koceljeva", "SE", 44.47361, 19.81167);
case 375: return new CityInfo("Klenje", "SE", 44.80794, 19.43508);
case 376: return new CityInfo("Klenak", "VO", 44.78846, 19.71004);
case 377: return new CityInfo("Kisač", "VO", 45.35421, 19.72975);
case 378: return new CityInfo("Kamenica", "SE", 44.343, 19.72333);
case 379: return new CityInfo("Joševa", "SE", 44.58772, 19.40967);
case 380: return new CityInfo("Jevremovac", "SE", 44.72172, 19.66364);
case 381: return new CityInfo("Jelenča", "SE", 44.727, 19.735);
case 382: return new CityInfo("Jarebice", "SE", 44.53995, 19.42418);
case 383: return new CityInfo("Jarak", "VO", 44.91843, 19.75477);
case 384: return new CityInfo("Jadranska Lešnica", "SE", 44.58625, 19.34701);
case 385: return new CityInfo("Irig", "VO", 45.10111, 19.85833);
case 386: return new CityInfo("Hrtkovci", "VO", 44.88155, 19.76374);
case 387: return new CityInfo("Grnčara", "SE", 44.53516, 19.29971);
case 388: return new CityInfo("Grabovci", "VO", 44.76496, 19.84489);
case 389: return new CityInfo("Gornji Dobrić", "SE", 44.58286, 19.30858);
case 390: return new CityInfo("Gornje Nedeljice", "SE", 44.51645, 19.33915);
case 391: return new CityInfo("Gornja Bukovica", "SE", 44.34233, 19.78647);
case 392: return new CityInfo("Glušci", "SE", 44.89021, 19.54913);
case 393: return new CityInfo("Gložan", "VO", 45.27954, 19.56838);
case 394: return new CityInfo("Glogovac", "SE", 44.86341, 19.41532);
case 395: return new CityInfo("Gakovo", "VO", 45.90078, 19.06138);
case 396: return new CityInfo("Dublje", "SE", 44.80117, 19.50902);
case 397: return new CityInfo("Drenovac", "SE", 44.86649, 19.70943);
case 398: return new CityInfo("Draginje", "SE", 44.53302, 19.7625);
case 399: return new CityInfo("Doroslovo", "VO", 45.60699, 19.18868);
case 400: return new CityInfo("Donji Dobrić", "SE", 44.61183, 19.33109);
case 401: return new CityInfo("Donja Badanja", "SE", 44.50556, 19.47543);
case 402: return new CityInfo("Dobrić", "SE", 44.70224, 19.57931);
case 403: return new CityInfo("Despotovo", "VO", 45.45983, 19.52653);
case 404: return new CityInfo("Culjković", "SE", 44.66595, 19.54562);
case 405: return new CityInfo("Crna Bara", "SE", 44.87374, 19.3948);
case 406: return new CityInfo("Čokešina", "SE", 44.65319, 19.39016);
case 407: return new CityInfo("Čelarevo", "VO", 45.26999, 19.52484);
case 408: return new CityInfo("Čajetina", "SE", 43.74977, 19.71273);
case 409: return new CityInfo("Bukor", "SE", 44.49523, 19.57116);
case 410: return new CityInfo("Buđanovci", "VO", 44.89388, 19.86344);
case 411: return new CityInfo("Brdarica", "SE", 44.55376, 19.7715);
case 412: return new CityInfo("Bosut", "VO", 44.92977, 19.36086);
case 413: return new CityInfo("Bogosavac", "SE", 44.71799, 19.59533);
case 414: return new CityInfo("Bogojevo", "VO", 45.53015, 19.13022);
case 415: return new CityInfo("Bogatić", "SE", 44.8375, 19.48056);
case 416: return new CityInfo("Beočin", "VO", 45.20829, 19.72063);
case 417: return new CityInfo("Belotić", "SE", 44.81782, 19.54801);
case 418: return new CityInfo("Belotić", "SE", 44.58099, 19.71932);
case 419: return new CityInfo("Banovo Polje", "SE", 44.9104, 19.44916);
case 420: return new CityInfo("Bajina Bašta", "SE", 43.97083, 19.5675);
case 421: return new CityInfo("Badovinci", "SE", 44.78534, 19.37146);
case 422: return new CityInfo("Bački Petrovac", "VO", 45.36056, 19.59167);
case 423: return new CityInfo("Bački Breg", "VO", 45.92034, 18.92944);
case 424: return new CityInfo("Bačka Topola", "VO", 45.81516, 19.6318);
case 425: return new CityInfo("Bačka Palanka", "VO", 45.24966, 19.39664);
case 426: return new CityInfo("Bač", "VO", 45.39194, 19.23667);
case 427: return new CityInfo("Apatin", "VO", 45.6726, 18.978);
case 428: return new CityInfo("Pocerski Pričinović", "SE", 44.72222, 19.70722);
case 429: return new CityInfo("Ðurići", "SE", 43.84678, 19.40935);
case 430: return new CityInfo("Zlatibor", "SE", 43.729, 19.70029);
case 431: return new CityInfo("Sokolovo Brdo", "SE", 43.13694, 19.80556);
case 432: return new CityInfo("Osječenik", "SE", 43.14528, 19.85889);
case 433: return new CityInfo("Rumska", "SE", 44.57261, 19.58988);
case 434: return new CityInfo("Knjazevac", "SE", 43.56634, 22.25701);
case 435: return new CityInfo("Kriva Feja", "SE", 42.55909, 22.17487);
case 436: return new CityInfo("Sumulicë", "SE", 42.38682, 21.734);
case 437: return new CityInfo("Lagja e Poshtme", "SE", 42.38853, 21.72971);
case 438: return new CityInfo("Lagja e Ternovcalive", "SE", 42.38999, 21.74365);
case 439: return new CityInfo("Lagja e Korbajve", "SE", 42.38674, 21.7434);
case 440: return new CityInfo("Lagja e Shimshirve", "SE", 42.38025, 21.74045);
case 441: return new CityInfo("Dolac naselje", "SE", 43.29511, 22.20626);
default: return new CityInfo("Irig", "VO", 45.0523, 19.84448);

                                    }                                        
                                }
                            
                        }
                    }
                