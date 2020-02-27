
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
                                    public const string Country = "TR";
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
                            
                                        var cur = (Math.Abs(36.24444 - lat) + Math.Abs(29.985 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(36.9375 - lat) + Math.Abs(38.40917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.99118 - lat) + Math.Abs(27.67635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.96722 - lat) + Math.Abs(27.07222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89778 - lat) + Math.Abs(37.75833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81418 - lat) + Math.Abs(31.73223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76863 - lat) + Math.Abs(35.78938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57362 - lat) + Math.Abs(44.28716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27488 - lat) + Math.Abs(41.93734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84617 - lat) + Math.Abs(38.90473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84172 - lat) + Math.Abs(40.8865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91778 - lat) + Math.Abs(40.70861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.995 - lat) + Math.Abs(38.75111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25124 - lat) + Math.Abs(27.09021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26621 - lat) + Math.Abs(40.67644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39367 - lat) + Math.Abs(41.26713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.82 - lat) + Math.Abs(34.80444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88372 - lat) + Math.Abs(41.32891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97863 - lat) + Math.Abs(38.38274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.00913 - lat) + Math.Abs(38.2532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89764 - lat) + Math.Abs(40.00086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38717 - lat) + Math.Abs(41.31778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52554 - lat) + Math.Abs(41.3534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86639 - lat) + Math.Abs(36.59889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.99563 - lat) + Math.Abs(36.26004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8675 - lat) + Math.Abs(26.61111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33972 - lat) + Math.Abs(28.66444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29602 - lat) + Math.Abs(38.24526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30719 - lat) + Math.Abs(42.13891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19324 - lat) + Math.Abs(28.27537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33473 - lat) + Math.Abs(39.08122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.4095 - lat) + Math.Abs(33.83804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.50806 - lat) + Math.Abs(29.75472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.33813 - lat) + Math.Abs(40.81739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95348 - lat) + Math.Abs(36.19839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35232 - lat) + Math.Abs(35.08873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23119 - lat) + Math.Abs(34.77671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15668 - lat) + Math.Abs(33.51447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.46066 - lat) + Math.Abs(40.78441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85222 - lat) + Math.Abs(37.84639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63806 - lat) + Math.Abs(34.46722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13625 - lat) + Math.Abs(28.28403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70778 - lat) + Math.Abs(31.38639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88639 - lat) + Math.Abs(27.06694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84291 - lat) + Math.Abs(41.30137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46361 - lat) + Math.Abs(35.08306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82332 - lat) + Math.Abs(28.19573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42 - lat) + Math.Abs(32.16889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.50887 - lat) + Math.Abs(40.98989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77874 - lat) + Math.Abs(28.00299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88042 - lat) + Math.Abs(41.05004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59874 - lat) + Math.Abs(36.63264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27074 - lat) + Math.Abs(42.42472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38496 - lat) + Math.Abs(27.25643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73333 - lat) + Math.Abs(26.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.21142 - lat) + Math.Abs(35.00036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.20417 - lat) + Math.Abs(32.74778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86972 - lat) + Math.Abs(32.78833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.93083 - lat) + Math.Abs(27.25806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76089 - lat) + Math.Abs(28.90729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82837 - lat) + Math.Abs(28.57115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97744 - lat) + Math.Abs(35.05197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80414 - lat) + Math.Abs(40.99222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8802 - lat) + Math.Abs(42.43493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65809 - lat) + Math.Abs(41.9812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.48879 - lat) + Math.Abs(42.53501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99116 - lat) + Math.Abs(38.9314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.96753 - lat) + Math.Abs(36.01452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43277 - lat) + Math.Abs(40.53368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79926 - lat) + Math.Abs(36.9319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24703 - lat) + Math.Abs(41.76166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.59292 - lat) + Math.Abs(38.17327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30131 - lat) + Math.Abs(41.52061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.20293 - lat) + Math.Abs(40.75375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38268 - lat) + Math.Abs(38.33892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22614 - lat) + Math.Abs(40.0695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9025 - lat) + Math.Abs(36.06272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43748 - lat) + Math.Abs(40.68588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.63092 - lat) + Math.Abs(40.52793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.89748 - lat) + Math.Abs(41.30613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31772 - lat) + Math.Abs(37.56824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.20023 - lat) + Math.Abs(41.98471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79202 - lat) + Math.Abs(36.20603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.34025 - lat) + Math.Abs(28.14279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08428 - lat) + Math.Abs(40.54237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05414 - lat) + Math.Abs(38.5213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.04824 - lat) + Math.Abs(36.43066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81149 - lat) + Math.Abs(32.88278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.70889 - lat) + Math.Abs(39.28972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.02091 - lat) + Math.Abs(39.00533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39135 - lat) + Math.Abs(41.86528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98889 - lat) + Math.Abs(28.80806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82007 - lat) + Math.Abs(42.7839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65409 - lat) + Math.Abs(40.54635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03641 - lat) + Math.Abs(41.55227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77623 - lat) + Math.Abs(40.43894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29556 - lat) + Math.Abs(31.17778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85657 - lat) + Math.Abs(43.5223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10528 - lat) + Math.Abs(27.29722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30077 - lat) + Math.Abs(32.08548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.5768 - lat) + Math.Abs(36.50766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97342 - lat) + Math.Abs(35.62043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.89573 - lat) + Math.Abs(37.54227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.756 - lat) + Math.Abs(36.21432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10228 - lat) + Math.Abs(35.35704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.85028 - lat) + Math.Abs(33.45294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41712 - lat) + Math.Abs(28.38109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22349 - lat) + Math.Abs(39.75519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17375 - lat) + Math.Abs(41.45402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18914 - lat) + Math.Abs(41.83389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49457 - lat) + Math.Abs(43.38323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.27858 - lat) + Math.Abs(26.54315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49052 - lat) + Math.Abs(42.99036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.70947 - lat) + Math.Abs(39.70015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54057 - lat) + Math.Abs(31.6038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73361 - lat) + Math.Abs(29.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67351 - lat) + Math.Abs(29.4058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32292 - lat) + Math.Abs(26.76403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6296 - lat) + Math.Abs(34.91199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16708 - lat) + Math.Abs(38.79392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85003 - lat) + Math.Abs(27.96275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.175 - lat) + Math.Abs(31.23444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.96333 - lat) + Math.Abs(37.69361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54776 - lat) + Math.Abs(34.48528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44074 - lat) + Math.Abs(42.85236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.41305 - lat) + Math.Abs(35.89033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07825 - lat) + Math.Abs(30.45019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41987 - lat) + Math.Abs(29.29129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84361 - lat) + Math.Abs(39.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44492 - lat) + Math.Abs(37.039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27221 - lat) + Math.Abs(41.80078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10491 - lat) + Math.Abs(28.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19722 - lat) + Math.Abs(41.76479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8257 - lat) + Math.Abs(40.54402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13413 - lat) + Math.Abs(32.26146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49471 - lat) + Math.Abs(40.96806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56308 - lat) + Math.Abs(40.1757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47778 - lat) + Math.Abs(31.62639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.18022 - lat) + Math.Abs(41.5687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53854 - lat) + Math.Abs(42.76587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79529 - lat) + Math.Abs(37.9161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.36889 - lat) + Math.Abs(30.1375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38649 - lat) + Math.Abs(36.84262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80668 - lat) + Math.Abs(40.61117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49533 - lat) + Math.Abs(27.6997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62694 - lat) + Math.Abs(31.81083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.375 - lat) + Math.Abs(28.03111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09921 - lat) + Math.Abs(39.54351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16228 - lat) + Math.Abs(39.544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.26333 - lat) + Math.Abs(36.22056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1519 - lat) + Math.Abs(27.36223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26113 - lat) + Math.Abs(41.24948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06855 - lat) + Math.Abs(36.14661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.00555 - lat) + Math.Abs(34.82644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.7034 - lat) + Math.Abs(34.3627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44722 - lat) + Math.Abs(35.79917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58422 - lat) + Math.Abs(41.03675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41806 - lat) + Math.Abs(36.015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08877 - lat) + Math.Abs(27.73508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77709 - lat) + Math.Abs(40.37783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11129 - lat) + Math.Abs(41.38359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.2997 - lat) + Math.Abs(41.82465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11788 - lat) + Math.Abs(38.72622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36135 - lat) + Math.Abs(35.62627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82358 - lat) + Math.Abs(27.87496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66628 - lat) + Math.Abs(32.72214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09595 - lat) + Math.Abs(41.36834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78943 - lat) + Math.Abs(40.77161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7275 - lat) + Math.Abs(32.35528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57574 - lat) + Math.Abs(41.84564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8125 - lat) + Math.Abs(39.02167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64111 - lat) + Math.Abs(41.50542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.5017 - lat) + Math.Abs(30.52723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30968 - lat) + Math.Abs(29.77538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16183 - lat) + Math.Abs(36.10978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54237 - lat) + Math.Abs(29.49866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57351 - lat) + Math.Abs(29.07058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49221 - lat) + Math.Abs(42.28269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3214 - lat) + Math.Abs(33.88165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17963 - lat) + Math.Abs(34.02499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62966 - lat) + Math.Abs(43.36878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98699 - lat) + Math.Abs(42.1351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9243 - lat) + Math.Abs(32.49131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95031 - lat) + Math.Abs(42.29518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.8381 - lat) + Math.Abs(38.50457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.37864 - lat) + Math.Abs(42.86866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.21597 - lat) + Math.Abs(35.79021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40792 - lat) + Math.Abs(43.45706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9224 - lat) + Math.Abs(31.23608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91766 - lat) + Math.Abs(34.89277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15416 - lat) + Math.Abs(39.14837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01667 - lat) + Math.Abs(39.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61137 - lat) + Math.Abs(39.83151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41944 - lat) + Math.Abs(36.91222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6908 - lat) + Math.Abs(35.5538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95 - lat) + Math.Abs(29.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.85586 - lat) + Math.Abs(42.42834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.53867 - lat) + Math.Abs(37.6321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65035 - lat) + Math.Abs(40.69441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49737 - lat) + Math.Abs(30.97727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91361 - lat) + Math.Abs(28.15778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97612 - lat) + Math.Abs(38.42533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57373 - lat) + Math.Abs(40.73252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00548 - lat) + Math.Abs(37.9635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99389 - lat) + Math.Abs(36.08404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88111 - lat) + Math.Abs(32.3425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69386 - lat) + Math.Abs(43.81472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88989 - lat) + Math.Abs(28.15436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.2471 - lat) + Math.Abs(33.54961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53111 - lat) + Math.Abs(31.22806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87264 - lat) + Math.Abs(36.81714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41342 - lat) + Math.Abs(41.96114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29458 - lat) + Math.Abs(42.13637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53111 - lat) + Math.Abs(30.54583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81361 - lat) + Math.Abs(39.04333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58832 - lat) + Math.Abs(41.76815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99065 - lat) + Math.Abs(43.07886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65035 - lat) + Math.Abs(40.81601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81012 - lat) + Math.Abs(35.18596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18554 - lat) + Math.Abs(27.60945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.96525 - lat) + Math.Abs(41.05443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7482 - lat) + Math.Abs(27.40614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.80019 - lat) + Math.Abs(40.66971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44706 - lat) + Math.Abs(41.21976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0143 - lat) + Math.Abs(30.18486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45037 - lat) + Math.Abs(31.53409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44223 - lat) + Math.Abs(39.30938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27675 - lat) + Math.Abs(41.33569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75503 - lat) + Math.Abs(39.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49944 - lat) + Math.Abs(29.68361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74833 - lat) + Math.Abs(37.01611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06251 - lat) + Math.Abs(42.02517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.37428 - lat) + Math.Abs(42.03386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51393 - lat) + Math.Abs(42.45432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24128 - lat) + Math.Abs(28.17842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27528 - lat) + Math.Abs(32.68028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03645 - lat) + Math.Abs(38.61257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47167 - lat) + Math.Abs(37.87083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.74444 - lat) + Math.Abs(30.24278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86166 - lat) + Math.Abs(40.99283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.0882 - lat) + Math.Abs(28.97767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.13708 - lat) + Math.Abs(41.00817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24379 - lat) + Math.Abs(42.46345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92731 - lat) + Math.Abs(32.41995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.37778 - lat) + Math.Abs(33.93444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9293 - lat) + Math.Abs(41.94134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44472 - lat) + Math.Abs(30.69472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63514 - lat) + Math.Abs(42.06296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22054 - lat) + Math.Abs(41.93973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.98747 - lat) + Math.Abs(35.30592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41926 - lat) + Math.Abs(31.84527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78 - lat) + Math.Abs(30.68889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57038 - lat) + Math.Abs(40.32004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.36139 - lat) + Math.Abs(36.21361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91694 - lat) + Math.Abs(31.09889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93925 - lat) + Math.Abs(33.5386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07932 - lat) + Math.Abs(40.64246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.46436 - lat) + Math.Abs(42.72248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.46347 - lat) + Math.Abs(41.18863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.04841 - lat) + Math.Abs(36.14366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10444 - lat) + Math.Abs(30.54861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30514 - lat) + Math.Abs(44.5742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40035 - lat) + Math.Abs(27.65543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76667 - lat) + Math.Abs(31.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.74444 - lat) + Math.Abs(28.86778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95137 - lat) + Math.Abs(27.36849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49837 - lat) + Math.Abs(29.65482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81178 - lat) + Math.Abs(39.13359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97252 - lat) + Math.Abs(39.07484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97876 - lat) + Math.Abs(37.67174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.80378 - lat) + Math.Abs(29.65155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5705 - lat) + Math.Abs(39.3872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84667 - lat) + Math.Abs(38.73583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1975 - lat) + Math.Abs(26.83881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.5043 - lat) + Math.Abs(34.7563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.53544 - lat) + Math.Abs(40.87876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22889 - lat) + Math.Abs(33.68139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.34142 - lat) + Math.Abs(40.61336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38319 - lat) + Math.Abs(27.65612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32767 - lat) + Math.Abs(41.41377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73455 - lat) + Math.Abs(27.56811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42069 - lat) + Math.Abs(43.25889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.35186 - lat) + Math.Abs(36.40976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07944 - lat) + Math.Abs(31.36639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47917 - lat) + Math.Abs(36.49898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98349 - lat) + Math.Abs(33.84136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69705 - lat) + Math.Abs(32.61203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.01887 - lat) + Math.Abs(42.92092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07694 - lat) + Math.Abs(35.96671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36001 - lat) + Math.Abs(41.30055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.24309 - lat) + Math.Abs(41.95933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56609 - lat) + Math.Abs(27.3643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49361 - lat) + Math.Abs(35.37694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23953 - lat) + Math.Abs(28.69663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15172 - lat) + Math.Abs(35.50769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39833 - lat) + Math.Abs(27.57722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.26201 - lat) + Math.Abs(32.40457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92448 - lat) + Math.Abs(28.92516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69361 - lat) + Math.Abs(35.51111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64691 - lat) + Math.Abs(44.16116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.0273 - lat) + Math.Abs(29.22218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46472 - lat) + Math.Abs(30.26946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26067 - lat) + Math.Abs(40.63492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09222 - lat) + Math.Abs(40.38753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58194 - lat) + Math.Abs(38.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81184 - lat) + Math.Abs(27.84559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.68441 - lat) + Math.Abs(38.04676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.08012 - lat) + Math.Abs(35.97603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.48258 - lat) + Math.Abs(28.14774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89123 - lat) + Math.Abs(28.10333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17152 - lat) + Math.Abs(36.91632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99757 - lat) + Math.Abs(41.51046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98632 - lat) + Math.Abs(36.09056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17852 - lat) + Math.Abs(35.68843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05731 - lat) + Math.Abs(42.58375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.56131 - lat) + Math.Abs(30.18813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26791 - lat) + Math.Abs(36.56747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.27139 - lat) + Math.Abs(31.57139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89315 - lat) + Math.Abs(38.76607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.19923 - lat) + Math.Abs(38.86296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48449 - lat) + Math.Abs(39.89532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42778 - lat) + Math.Abs(34.87167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.68596 - lat) + Math.Abs(39.023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.57715 - lat) + Math.Abs(32.14132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52169 - lat) + Math.Abs(43.03593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27983 - lat) + Math.Abs(42.33427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.87424 - lat) + Math.Abs(39.47263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47231 - lat) + Math.Abs(40.83402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72285 - lat) + Math.Abs(36.39314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21368 - lat) + Math.Abs(41.88689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93573 - lat) + Math.Abs(42.54927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86574 - lat) + Math.Abs(39.32273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.84625 - lat) + Math.Abs(39.66833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99395 - lat) + Math.Abs(29.90424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67389 - lat) + Math.Abs(36.15944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.995 - lat) + Math.Abs(29.12583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8532 - lat) + Math.Abs(27.40299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48685 - lat) + Math.Abs(37.29961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6016 - lat) + Math.Abs(31.85057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22493 - lat) + Math.Abs(42.85693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97975 - lat) + Math.Abs(41.66997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.94729 - lat) + Math.Abs(38.94564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92317 - lat) + Math.Abs(28.54175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91644 - lat) + Math.Abs(29.11729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69135 - lat) + Math.Abs(39.91984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89583 - lat) + Math.Abs(42.2025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00478 - lat) + Math.Abs(42.24386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81213 - lat) + Math.Abs(34.84096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26274 - lat) + Math.Abs(41.97891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01611 - lat) + Math.Abs(27.12806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17704 - lat) + Math.Abs(41.69322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.945 - lat) + Math.Abs(38.89889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65455 - lat) + Math.Abs(43.98869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79856 - lat) + Math.Abs(41.02083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42341 - lat) + Math.Abs(43.23137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.2523 - lat) + Math.Abs(41.86198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22126 - lat) + Math.Abs(41.73862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90403 - lat) + Math.Abs(42.88434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81733 - lat) + Math.Abs(42.31643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10722 - lat) + Math.Abs(28.02111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71079 - lat) + Math.Abs(32.93482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.35259 - lat) + Math.Abs(39.2089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51343 - lat) + Math.Abs(38.77933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70849 - lat) + Math.Abs(39.98697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97 - lat) + Math.Abs(40.01872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62472 - lat) + Math.Abs(34.96472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07417 - lat) + Math.Abs(36.24778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7625 - lat) + Math.Abs(27.25306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36845 - lat) + Math.Abs(42.95806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42153 - lat) + Math.Abs(36.23403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73728 - lat) + Math.Abs(34.03866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32745 - lat) + Math.Abs(43.28403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22089 - lat) + Math.Abs(40.78476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19771 - lat) + Math.Abs(42.44731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88788 - lat) + Math.Abs(27.50234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.04944 - lat) + Math.Abs(27.34833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47394 - lat) + Math.Abs(41.55598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83915 - lat) + Math.Abs(28.76457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39671 - lat) + Math.Abs(42.9101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90333 - lat) + Math.Abs(28.99056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.99843 - lat) + Math.Abs(36.64929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.2625 - lat) + Math.Abs(29.54389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03609 - lat) + Math.Abs(27.96723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97661 - lat) + Math.Abs(39.27763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.71222 - lat) + Math.Abs(39.02917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39903 - lat) + Math.Abs(40.95442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83063 - lat) + Math.Abs(28.06682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74152 - lat) + Math.Abs(42.44075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.96572 - lat) + Math.Abs(37.51339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.5059 - lat) + Math.Abs(38.88369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81487 - lat) + Math.Abs(41.37425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17902 - lat) + Math.Abs(40.95455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.2278 - lat) + Math.Abs(27.96955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.18444 - lat) + Math.Abs(33.18095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07028 - lat) + Math.Abs(41.21465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96366 - lat) + Math.Abs(37.44047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.28104 - lat) + Math.Abs(42.50746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22883 - lat) + Math.Abs(42.41832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.00972 - lat) + Math.Abs(37.79417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.77455 - lat) + Math.Abs(38.72686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96583 - lat) + Math.Abs(34.67935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.625 - lat) + Math.Abs(34.71222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17986 - lat) + Math.Abs(39.82843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91631 - lat) + Math.Abs(28.32225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41269 - lat) + Math.Abs(39.76838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.2268 - lat) + Math.Abs(41.89014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88449 - lat) + Math.Abs(42.97597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39148 - lat) + Math.Abs(37.13614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88253 - lat) + Math.Abs(38.7592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40624 - lat) + Math.Abs(41.92018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.64389 - lat) + Math.Abs(33.43885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83306 - lat) + Math.Abs(34.62306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.88639 - lat) + Math.Abs(36.91861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73163 - lat) + Math.Abs(41.48482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.903 - lat) + Math.Abs(38.34746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16778 - lat) + Math.Abs(37.95694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.96167 - lat) + Math.Abs(40.10056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67281 - lat) + Math.Abs(43.23952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98568 - lat) + Math.Abs(43.7531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66025 - lat) + Math.Abs(27.33836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90253 - lat) + Math.Abs(35.62743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10699 - lat) + Math.Abs(27.66578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21807 - lat) + Math.Abs(28.3665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.06147 - lat) + Math.Abs(34.38286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51624 - lat) + Math.Abs(26.62487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.63721 - lat) + Math.Abs(42.31996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57735 - lat) + Math.Abs(39.33292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99127 - lat) + Math.Abs(40.99007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.93083 - lat) + Math.Abs(39.00444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48357 - lat) + Math.Abs(42.54834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31639 - lat) + Math.Abs(27.78389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84389 - lat) + Math.Abs(38.78472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86594 - lat) + Math.Abs(31.49572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41908 - lat) + Math.Abs(41.33909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92572 - lat) + Math.Abs(40.96111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3859 - lat) + Math.Abs(39.82439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66257 - lat) + Math.Abs(43.18885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.74541 - lat) + Math.Abs(34.52256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75429 - lat) + Math.Abs(40.65174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78278 - lat) + Math.Abs(39.15833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92552 - lat) + Math.Abs(42.0965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35585 - lat) + Math.Abs(41.76941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76045 - lat) + Math.Abs(41.80153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81196 - lat) + Math.Abs(34.63886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11828 - lat) + Math.Abs(40.44874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.92945 - lat) + Math.Abs(41.50325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82985 - lat) + Math.Abs(32.46777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60754 - lat) + Math.Abs(27.06938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.951 - lat) + Math.Abs(38.38237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47801 - lat) + Math.Abs(40.48152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.01783 - lat) + Math.Abs(39.60064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.855 - lat) + Math.Abs(28.27417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31309 - lat) + Math.Abs(40.74357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84853 - lat) + Math.Abs(35.65436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61202 - lat) + Math.Abs(27.42647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78667 - lat) + Math.Abs(31.44306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94044 - lat) + Math.Abs(32.91012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.1465 - lat) + Math.Abs(42.53536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35018 - lat) + Math.Abs(38.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.49463 - lat) + Math.Abs(32.09085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49778 - lat) + Math.Abs(30.98722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.96889 - lat) + Math.Abs(38.07444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.7224 - lat) + Math.Abs(33.86711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38669 - lat) + Math.Abs(39.66408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45821 - lat) + Math.Abs(40.63888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43704 - lat) + Math.Abs(37.85425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83996 - lat) + Math.Abs(34.43765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65389 - lat) + Math.Abs(32.52972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15841 - lat) + Math.Abs(40.79279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9133 - lat) + Math.Abs(28.45917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86306 - lat) + Math.Abs(38.34365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30719 - lat) + Math.Abs(41.1772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42417 - lat) + Math.Abs(29.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45121 - lat) + Math.Abs(38.67912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.06076 - lat) + Math.Abs(37.07929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86014 - lat) + Math.Abs(27.25713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64024 - lat) + Math.Abs(38.47422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32611 - lat) + Math.Abs(32.17528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92533 - lat) + Math.Abs(41.68493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65328 - lat) + Math.Abs(37.85081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58127 - lat) + Math.Abs(33.64299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.32573 - lat) + Math.Abs(30.30302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.37028 - lat) + Math.Abs(30.28694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17222 - lat) + Math.Abs(40.73536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.36353 - lat) + Math.Abs(36.45502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.88286 - lat) + Math.Abs(30.95178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3239 - lat) + Math.Abs(30.9764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.46594 - lat) + Math.Abs(42.28791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.87656 - lat) + Math.Abs(37.66279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09513 - lat) + Math.Abs(33.07989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.49754 - lat) + Math.Abs(41.00668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.54726 - lat) + Math.Abs(28.64976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9431 - lat) + Math.Abs(38.46164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43899 - lat) + Math.Abs(42.31905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54889 - lat) + Math.Abs(26.60528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.55734 - lat) + Math.Abs(26.39305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.19118 - lat) + Math.Abs(41.47775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63727 - lat) + Math.Abs(41.36876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45517 - lat) + Math.Abs(35.81573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22139 - lat) + Math.Abs(34.85056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17839 - lat) + Math.Abs(41.87878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71882 - lat) + Math.Abs(39.86268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1625 - lat) + Math.Abs(35.97834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85333 - lat) + Math.Abs(28.05167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88944 - lat) + Math.Abs(41.19889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83879 - lat) + Math.Abs(40.60811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59386 - lat) + Math.Abs(34.13625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47028 - lat) + Math.Abs(27.36528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23339 - lat) + Math.Abs(42.05796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06498 - lat) + Math.Abs(30.19565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7339 - lat) + Math.Abs(41.78396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95306 - lat) + Math.Abs(40.95917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50832 - lat) + Math.Abs(29.76233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.7323 - lat) + Math.Abs(32.18497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.966 - lat) + Math.Abs(41.86844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.74972 - lat) + Math.Abs(28.40472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86644 - lat) + Math.Abs(30.63031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87135 - lat) + Math.Abs(32.48464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86035 - lat) + Math.Abs(43.09678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43389 - lat) + Math.Abs(27.83623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90583 - lat) + Math.Abs(37.29694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92388 - lat) + Math.Abs(41.63219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11278 - lat) + Math.Abs(27.99611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54302 - lat) + Math.Abs(41.86666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75345 - lat) + Math.Abs(28.94571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22922 - lat) + Math.Abs(40.16104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76113 - lat) + Math.Abs(27.70583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09553 - lat) + Math.Abs(43.19616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.92306 - lat) + Math.Abs(38.25788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26542 - lat) + Math.Abs(40.64129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.28889 - lat) + Math.Abs(40.49786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.11664 - lat) + Math.Abs(39.65931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58417 - lat) + Math.Abs(34.27359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31694 - lat) + Math.Abs(30.74 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.98301 - lat) + Math.Abs(29.52847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18836 - lat) + Math.Abs(40.57723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45402 - lat) + Math.Abs(42.19639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25806 - lat) + Math.Abs(30.15167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86847 - lat) + Math.Abs(32.11618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30361 - lat) + Math.Abs(30.44417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58105 - lat) + Math.Abs(29.26639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65111 - lat) + Math.Abs(29.66611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01722 - lat) + Math.Abs(29.96306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61191 - lat) + Math.Abs(29.01838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78019 - lat) + Math.Abs(41.31385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9675 - lat) + Math.Abs(36.15749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14583 - lat) + Math.Abs(34.16389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.13558 - lat) + Math.Abs(43.49387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10638 - lat) + Math.Abs(27.66925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27944 - lat) + Math.Abs(30.52639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84528 - lat) + Math.Abs(33.50639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.49939 - lat) + Math.Abs(36.35755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55517 - lat) + Math.Abs(28.36506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23056 - lat) + Math.Abs(28.20444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08722 - lat) + Math.Abs(27.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.71611 - lat) + Math.Abs(37.115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32488 - lat) + Math.Abs(33.18634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4796 - lat) + Math.Abs(41.78374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31361 - lat) + Math.Abs(40.35028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.915 - lat) + Math.Abs(37.99083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67306 - lat) + Math.Abs(33.61361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68889 - lat) + Math.Abs(28.15222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82388 - lat) + Math.Abs(34.57145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.35222 - lat) + Math.Abs(30.06306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6481 - lat) + Math.Abs(29.3591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.59778 - lat) + Math.Abs(30.56056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42621 - lat) + Math.Abs(27.41731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.26288 - lat) + Math.Abs(38.49674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59606 - lat) + Math.Abs(39.02329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91361 - lat) + Math.Abs(29.22944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24073 - lat) + Math.Abs(29.30425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.96611 - lat) + Math.Abs(38.98472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9425 - lat) + Math.Abs(30.30222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7938 - lat) + Math.Abs(38.73517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23028 - lat) + Math.Abs(32.95889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81565 - lat) + Math.Abs(34.75761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77106 - lat) + Math.Abs(40.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.50188 - lat) + Math.Abs(32.86128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73222 - lat) + Math.Abs(35.48528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11487 - lat) + Math.Abs(36.46511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.89917 - lat) + Math.Abs(36.45417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.33968 - lat) + Math.Abs(40.93274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51667 - lat) + Math.Abs(31.17972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16778 - lat) + Math.Abs(28.11528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51917 - lat) + Math.Abs(40.92712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93733 - lat) + Math.Abs(40.17756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.55762 - lat) + Math.Abs(41.16231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49271 - lat) + Math.Abs(27.44547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32983 - lat) + Math.Abs(41.2276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90222 - lat) + Math.Abs(34.25472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.47993 - lat) + Math.Abs(36.71245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98599 - lat) + Math.Abs(41.66756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22028 - lat) + Math.Abs(42.34583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44463 - lat) + Math.Abs(28.36276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.48337 - lat) + Math.Abs(41.81967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29205 - lat) + Math.Abs(37.48127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3878 - lat) + Math.Abs(39.42365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67551 - lat) + Math.Abs(28.49446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.25281 - lat) + Math.Abs(42.10958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52875 - lat) + Math.Abs(31.1927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.20176 - lat) + Math.Abs(29.63766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45772 - lat) + Math.Abs(27.1142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5485 - lat) + Math.Abs(35.39603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.55861 - lat) + Math.Abs(27.83528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73055 - lat) + Math.Abs(31.53517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29044 - lat) + Math.Abs(41.00594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97118 - lat) + Math.Abs(28.85894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.70132 - lat) + Math.Abs(29.07557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83452 - lat) + Math.Abs(37.9983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68194 - lat) + Math.Abs(37.30528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83493 - lat) + Math.Abs(41.11376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69604 - lat) + Math.Abs(42.14277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01385 - lat) + Math.Abs(27.25893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58204 - lat) + Math.Abs(35.37014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15935 - lat) + Math.Abs(40.89883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71596 - lat) + Math.Abs(33.55064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52917 - lat) + Math.Abs(27.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22644 - lat) + Math.Abs(39.20853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.37301 - lat) + Math.Abs(29.82308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18111 - lat) + Math.Abs(33.215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30073 - lat) + Math.Abs(41.67582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15934 - lat) + Math.Abs(40.54377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87036 - lat) + Math.Abs(43.63014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09101 - lat) + Math.Abs(41.68301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.68328 - lat) + Math.Abs(41.41171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71944 - lat) + Math.Abs(43.05139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31512 - lat) + Math.Abs(41.96458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.20361 - lat) + Math.Abs(38.79944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95178 - lat) + Math.Abs(40.02706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59417 - lat) + Math.Abs(33.37778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45234 - lat) + Math.Abs(39.44285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.25667 - lat) + Math.Abs(35.05889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.29693 - lat) + Math.Abs(34.72159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32083 - lat) + Math.Abs(29.53028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56834 - lat) + Math.Abs(30.18417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34364 - lat) + Math.Abs(42.09918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13551 - lat) + Math.Abs(36.07743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.73062 - lat) + Math.Abs(38.11527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72816 - lat) + Math.Abs(28.60569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72894 - lat) + Math.Abs(39.63547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6364 - lat) + Math.Abs(26.51094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56437 - lat) + Math.Abs(41.81724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13609 - lat) + Math.Abs(42.08459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21646 - lat) + Math.Abs(38.30936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23354 - lat) + Math.Abs(37.39111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90587 - lat) + Math.Abs(40.83662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3575 - lat) + Math.Abs(33.72389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81167 - lat) + Math.Abs(27.215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2651 - lat) + Math.Abs(29.41369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31338 - lat) + Math.Abs(39.00995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03333 - lat) + Math.Abs(38 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43917 - lat) + Math.Abs(28.84528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78552 - lat) + Math.Abs(38.6237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5847 - lat) + Math.Abs(36.92641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99568 - lat) + Math.Abs(35.79193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.37389 - lat) + Math.Abs(36.09611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23972 - lat) + Math.Abs(32.21139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.93028 - lat) + Math.Abs(42.98889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.34585 - lat) + Math.Abs(40.80059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4 - lat) + Math.Abs(39.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41273 - lat) + Math.Abs(27.13838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58389 - lat) + Math.Abs(27.48639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76444 - lat) + Math.Abs(30.55222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93167 - lat) + Math.Abs(27.21361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.025 - lat) + Math.Abs(36.63056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58718 - lat) + Math.Abs(36.17347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67101 - lat) + Math.Abs(30.74098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.19972 - lat) + Math.Abs(30.01333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65653 - lat) + Math.Abs(40.65806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86194 - lat) + Math.Abs(30.75028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90147 - lat) + Math.Abs(28.26475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81534 - lat) + Math.Abs(30.14549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.31667 - lat) + Math.Abs(33.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85222 - lat) + Math.Abs(27.72361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6224 - lat) + Math.Abs(35.18261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87544 - lat) + Math.Abs(38.11358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26506 - lat) + Math.Abs(35.65717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60389 - lat) + Math.Abs(29.20056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94653 - lat) + Math.Abs(41.0952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87583 - lat) + Math.Abs(27.77639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98034 - lat) + Math.Abs(40.67394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45106 - lat) + Math.Abs(38.55836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.27917 - lat) + Math.Abs(31.91389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89316 - lat) + Math.Abs(41.08539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59516 - lat) + Math.Abs(32.66097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86262 - lat) + Math.Abs(37.77432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97911 - lat) + Math.Abs(41.97337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96459 - lat) + Math.Abs(41.33119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02916 - lat) + Math.Abs(30.41639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92371 - lat) + Math.Abs(44.045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.33481 - lat) + Math.Abs(41.88944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.55781 - lat) + Math.Abs(41.09551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.79859 - lat) + Math.Abs(28.22635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.61257 - lat) + Math.Abs(39.5513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95388 - lat) + Math.Abs(31.59639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10029 - lat) + Math.Abs(39.20816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.64004 - lat) + Math.Abs(33.31862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91441 - lat) + Math.Abs(28.59151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7573 - lat) + Math.Abs(29.26996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57824 - lat) + Math.Abs(29.96768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.14207 - lat) + Math.Abs(40.50149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8842 - lat) + Math.Abs(32.49222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.22498 - lat) + Math.Abs(42.4183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25057 - lat) + Math.Abs(29.23116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.60094 - lat) + Math.Abs(41.22799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.35766 - lat) + Math.Abs(41.69253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91028 - lat) + Math.Abs(35.09607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58687 - lat) + Math.Abs(38.95505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47528 - lat) + Math.Abs(42.78583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.20802 - lat) + Math.Abs(36.12787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.76706 - lat) + Math.Abs(38.97698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81622 - lat) + Math.Abs(37.92882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90904 - lat) + Math.Abs(30.5646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.24903 - lat) + Math.Abs(40.77129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.43212 - lat) + Math.Abs(32.49732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25972 - lat) + Math.Abs(30.38583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55833 - lat) + Math.Abs(27.09833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58753 - lat) + Math.Abs(32.34802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13949 - lat) + Math.Abs(40.75404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75447 - lat) + Math.Abs(32.4222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.79944 - lat) + Math.Abs(36.51778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45751 - lat) + Math.Abs(39.85956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.68231 - lat) + Math.Abs(41.67851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54945 - lat) + Math.Abs(35.54772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12725 - lat) + Math.Abs(41.4914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70612 - lat) + Math.Abs(41.4048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.95093 - lat) + Math.Abs(37.88064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12838 - lat) + Math.Abs(36.54608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24216 - lat) + Math.Abs(36.45484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86 - lat) + Math.Abs(39.03139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70373 - lat) + Math.Abs(39.2415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.70179 - lat) + Math.Abs(41.00753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83812 - lat) + Math.Abs(37.74428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7282 - lat) + Math.Abs(40.82961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.67611 - lat) + Math.Abs(29.15528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13685 - lat) + Math.Abs(36.13293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21176 - lat) + Math.Abs(42.41945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.15917 - lat) + Math.Abs(30.86139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56879 - lat) + Math.Abs(39.05739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40741 - lat) + Math.Abs(40.38578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95081 - lat) + Math.Abs(40.19855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.34159 - lat) + Math.Abs(41.16254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60561 - lat) + Math.Abs(42.985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.84944 - lat) + Math.Abs(27.24806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43394 - lat) + Math.Abs(34.18743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.68541 - lat) + Math.Abs(27.67836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.2472 - lat) + Math.Abs(41.79257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24529 - lat) + Math.Abs(37.86874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85472 - lat) + Math.Abs(38.86583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.70074 - lat) + Math.Abs(35.08726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.85639 - lat) + Math.Abs(37.38639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.98776 - lat) + Math.Abs(32.45674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.64631 - lat) + Math.Abs(35.44937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8158 - lat) + Math.Abs(38.94655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94077 - lat) + Math.Abs(34.5577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62198 - lat) + Math.Abs(38.54052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3051 - lat) + Math.Abs(41.61758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.27722 - lat) + Math.Abs(34.37194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31032 - lat) + Math.Abs(43.79906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.89472 - lat) + Math.Abs(31.85639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.79444 - lat) + Math.Abs(34.08274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73363 - lat) + Math.Abs(31.89837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13706 - lat) + Math.Abs(27.58186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72225 - lat) + Math.Abs(37.27097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32372 - lat) + Math.Abs(43.40991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.5758 - lat) + Math.Abs(42.01558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65111 - lat) + Math.Abs(29.16694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38345 - lat) + Math.Abs(31.80995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.12688 - lat) + Math.Abs(40.56082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90436 - lat) + Math.Abs(40.91508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15444 - lat) + Math.Abs(29.06778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73417 - lat) + Math.Abs(39.08861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81339 - lat) + Math.Abs(31.99971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73277 - lat) + Math.Abs(38.8116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23927 - lat) + Math.Abs(29.98651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99667 - lat) + Math.Abs(42.71239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82556 - lat) + Math.Abs(34.53212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79382 - lat) + Math.Abs(38.67297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39141 - lat) + Math.Abs(42.99018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48711 - lat) + Math.Abs(41.49446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.74594 - lat) + Math.Abs(34.62524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53278 - lat) + Math.Abs(26.12056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.34148 - lat) + Math.Abs(33.39921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23972 - lat) + Math.Abs(27.60028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.27114 - lat) + Math.Abs(29.10451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75201 - lat) + Math.Abs(40.87571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95333 - lat) + Math.Abs(42.53861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87231 - lat) + Math.Abs(39.84188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86755 - lat) + Math.Abs(37.11658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1936 - lat) + Math.Abs(37.4812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.46957 - lat) + Math.Abs(41.90593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27593 - lat) + Math.Abs(42.09814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97717 - lat) + Math.Abs(41.45761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99528 - lat) + Math.Abs(34.57306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10679 - lat) + Math.Abs(29.15375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.4246 - lat) + Math.Abs(39.05728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13947 - lat) + Math.Abs(40.87438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66 - lat) + Math.Abs(30.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03651 - lat) + Math.Abs(38.61337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.33929 - lat) + Math.Abs(42.56945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6437 - lat) + Math.Abs(34.83529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93278 - lat) + Math.Abs(28.28942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.64546 - lat) + Math.Abs(41.49115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95639 - lat) + Math.Abs(30.5114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39016 - lat) + Math.Abs(26.84127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.79917 - lat) + Math.Abs(30.03889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84949 - lat) + Math.Abs(33.8597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71389 - lat) + Math.Abs(27.91417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4499 - lat) + Math.Abs(34.30011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.25128 - lat) + Math.Abs(40.71516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1459 - lat) + Math.Abs(29.50876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76923 - lat) + Math.Abs(42.12744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.81335 - lat) + Math.Abs(43.01904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31309 - lat) + Math.Abs(27.98319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48135 - lat) + Math.Abs(39.04736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79043 - lat) + Math.Abs(32.80903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.78361 - lat) + Math.Abs(37.63667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41908 - lat) + Math.Abs(28.55894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.62687 - lat) + Math.Abs(32.6228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02096 - lat) + Math.Abs(36.4973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48906 - lat) + Math.Abs(42.15127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54648 - lat) + Math.Abs(41.30402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95308 - lat) + Math.Abs(41.40465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7428 - lat) + Math.Abs(40.20815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62712 - lat) + Math.Abs(27.63139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58919 - lat) + Math.Abs(41.52023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57528 - lat) + Math.Abs(28.48889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11367 - lat) + Math.Abs(27.87144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.88006 - lat) + Math.Abs(37.70372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95621 - lat) + Math.Abs(42.44971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55832 - lat) + Math.Abs(28.91911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90339 - lat) + Math.Abs(41.87752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.20541 - lat) + Math.Abs(40.69748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90367 - lat) + Math.Abs(42.64866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.22328 - lat) + Math.Abs(27.40386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11106 - lat) + Math.Abs(41.4196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31759 - lat) + Math.Abs(41.82065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80472 - lat) + Math.Abs(26.2075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.87556 - lat) + Math.Abs(30.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91278 - lat) + Math.Abs(37.84472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.2921 - lat) + Math.Abs(43.10189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7918 - lat) + Math.Abs(35.65923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87056 - lat) + Math.Abs(27.60283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9625 - lat) + Math.Abs(31.73306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95 - lat) + Math.Abs(39.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56249 - lat) + Math.Abs(41.37753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44984 - lat) + Math.Abs(31.54588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.74773 - lat) + Math.Abs(40.55343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18342 - lat) + Math.Abs(36.07189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41683 - lat) + Math.Abs(41.26994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.12083 - lat) + Math.Abs(31.01528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17872 - lat) + Math.Abs(27.84848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.99389 - lat) + Math.Abs(29.39131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08229 - lat) + Math.Abs(38.80346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82865 - lat) + Math.Abs(43.4333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.48939 - lat) + Math.Abs(38.24743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58669 - lat) + Math.Abs(43.56163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49249 - lat) + Math.Abs(42.51877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10417 - lat) + Math.Abs(30.93778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26942 - lat) + Math.Abs(32.31792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32392 - lat) + Math.Abs(27.12918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05944 - lat) + Math.Abs(37.3825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.6703 - lat) + Math.Abs(26.75656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.295 - lat) + Math.Abs(30.14056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51317 - lat) + Math.Abs(41.96418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09418 - lat) + Math.Abs(36.63719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.64038 - lat) + Math.Abs(29.12758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.09056 - lat) + Math.Abs(35.56722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81446 - lat) + Math.Abs(35.91233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78561 - lat) + Math.Abs(26.34083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1703 - lat) + Math.Abs(40.68684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83868 - lat) + Math.Abs(31.35559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65962 - lat) + Math.Abs(40.96418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77556 - lat) + Math.Abs(26.77167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04139 - lat) + Math.Abs(29.88667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95328 - lat) + Math.Abs(32.63285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.98556 - lat) + Math.Abs(26.89667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39976 - lat) + Math.Abs(28.96905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15569 - lat) + Math.Abs(40.64142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77667 - lat) + Math.Abs(30.52056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21538 - lat) + Math.Abs(40.6783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40167 - lat) + Math.Abs(33.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.93083 - lat) + Math.Abs(39.06 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71144 - lat) + Math.Abs(44.60099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.4548 - lat) + Math.Abs(29.28154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90861 - lat) + Math.Abs(41.27694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.73919 - lat) + Math.Abs(39.49015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29496 - lat) + Math.Abs(40.74543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74183 - lat) + Math.Abs(42.17422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.57578 - lat) + Math.Abs(27.70672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24588 - lat) + Math.Abs(40.6818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.64043 - lat) + Math.Abs(32.89179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86182 - lat) + Math.Abs(41.14413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82043 - lat) + Math.Abs(35.44011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.26899 - lat) + Math.Abs(39.75446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.00893 - lat) + Math.Abs(42.04364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51333 - lat) + Math.Abs(34.04672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90085 - lat) + Math.Abs(41.57657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.60498 - lat) + Math.Abs(34.30836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02587 - lat) + Math.Abs(43.35964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.65107 - lat) + Math.Abs(43.64401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7025 - lat) + Math.Abs(37.75972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90222 - lat) + Math.Abs(33.83722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.01972 - lat) + Math.Abs(31.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60971 - lat) + Math.Abs(27.14588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.343 - lat) + Math.Abs(29.25847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.70401 - lat) + Math.Abs(34.37374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26944 - lat) + Math.Abs(32.72898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73583 - lat) + Math.Abs(29.91775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92083 - lat) + Math.Abs(33.23083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.94654 - lat) + Math.Abs(37.98895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79803 - lat) + Math.Abs(42.67574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20591 - lat) + Math.Abs(37.1983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18373 - lat) + Math.Abs(40.64395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67417 - lat) + Math.Abs(37.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67351 - lat) + Math.Abs(35.96753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.67431 - lat) + Math.Abs(39.22321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88572 - lat) + Math.Abs(42.12767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72917 - lat) + Math.Abs(39.14139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05974 - lat) + Math.Abs(37.18786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73423 - lat) + Math.Abs(27.36164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87462 - lat) + Math.Abs(30.85042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25748 - lat) + Math.Abs(40.07435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77147 - lat) + Math.Abs(35.5725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.59611 - lat) + Math.Abs(27.02444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.35413 - lat) + Math.Abs(42.08837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39157 - lat) + Math.Abs(41.27286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13586 - lat) + Math.Abs(38.60662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09309 - lat) + Math.Abs(41.30986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22435 - lat) + Math.Abs(41.91692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58596 - lat) + Math.Abs(28.62568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9862 - lat) + Math.Abs(42.18052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.70658 - lat) + Math.Abs(28.27176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.85408 - lat) + Math.Abs(29.9772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36795 - lat) + Math.Abs(41.68999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4513 - lat) + Math.Abs(36.02349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1228 - lat) + Math.Abs(40.63761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.02333 - lat) + Math.Abs(30.60247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79939 - lat) + Math.Abs(44.06726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.805 - lat) + Math.Abs(38.85306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7025 - lat) + Math.Abs(40.79219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83917 - lat) + Math.Abs(36.23025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15421 - lat) + Math.Abs(30.20876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80194 - lat) + Math.Abs(29.60918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.98555 - lat) + Math.Abs(41.91623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54694 - lat) + Math.Abs(44.08417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30746 - lat) + Math.Abs(39.03431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13248 - lat) + Math.Abs(42.73249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08574 - lat) + Math.Abs(37.87116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84321 - lat) + Math.Abs(37.61759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76334 - lat) + Math.Abs(42.78929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84432 - lat) + Math.Abs(35.34396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96265 - lat) + Math.Abs(41.22675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1463 - lat) + Math.Abs(31.67648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79955 - lat) + Math.Abs(42.33099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69517 - lat) + Math.Abs(39.03499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8005 - lat) + Math.Abs(31.8911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79972 - lat) + Math.Abs(29.91722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91363 - lat) + Math.Abs(40.21721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.54056 - lat) + Math.Abs(43.67135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.371 - lat) + Math.Abs(38.1137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71167 - lat) + Math.Abs(36.65167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32481 - lat) + Math.Abs(32.61602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.065 - lat) + Math.Abs(30.16557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07517 - lat) + Math.Abs(41.82717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91974 - lat) + Math.Abs(41.06119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.071 - lat) + Math.Abs(26.89017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69453 - lat) + Math.Abs(42.10725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.36571 - lat) + Math.Abs(40.0645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.28869 - lat) + Math.Abs(42.06721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39056 - lat) + Math.Abs(35.49222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91486 - lat) + Math.Abs(28.56176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3751 - lat) + Math.Abs(34.73419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36336 - lat) + Math.Abs(40.26473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42746 - lat) + Math.Abs(40.86096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27682 - lat) + Math.Abs(27.3246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39179 - lat) + Math.Abs(31.50918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98295 - lat) + Math.Abs(39.30017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01422 - lat) + Math.Abs(32.01639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77417 - lat) + Math.Abs(29.0875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91751 - lat) + Math.Abs(41.14984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96151 - lat) + Math.Abs(41.17596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73278 - lat) + Math.Abs(39.34389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57757 - lat) + Math.Abs(28.26847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04607 - lat) + Math.Abs(28.65889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.34157 - lat) + Math.Abs(37.20378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95371 - lat) + Math.Abs(34.02587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08163 - lat) + Math.Abs(43.48552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11361 - lat) + Math.Abs(27.14139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17435 - lat) + Math.Abs(43.05524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91861 - lat) + Math.Abs(29.86056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73392 - lat) + Math.Abs(27.29283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.97917 - lat) + Math.Abs(31.37139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73778 - lat) + Math.Abs(27.68417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.96252 - lat) + Math.Abs(39.80792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54616 - lat) + Math.Abs(41.71652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.54583 - lat) + Math.Abs(37.50583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.86917 - lat) + Math.Abs(27.63306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88234 - lat) + Math.Abs(41.25749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9142 - lat) + Math.Abs(38.65392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.83429 - lat) + Math.Abs(28.6446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13321 - lat) + Math.Abs(39.87929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29849 - lat) + Math.Abs(41.05974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79028 - lat) + Math.Abs(28.06639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53845 - lat) + Math.Abs(39.90765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36658 - lat) + Math.Abs(44.08528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.311 - lat) + Math.Abs(27.39081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66278 - lat) + Math.Abs(42.14064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.39388 - lat) + Math.Abs(43.10094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19306 - lat) + Math.Abs(30.50417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89825 - lat) + Math.Abs(39.33366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.4308 - lat) + Math.Abs(28.99558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.94489 - lat) + Math.Abs(41.25465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.20798 - lat) + Math.Abs(39.28554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5732 - lat) + Math.Abs(32.77446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.24963 - lat) + Math.Abs(27.13429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91524 - lat) + Math.Abs(43.18653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.35328 - lat) + Math.Abs(38.79609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24806 - lat) + Math.Abs(43.61361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.1069 - lat) + Math.Abs(35.69994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23734 - lat) + Math.Abs(28.44001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57444 - lat) + Math.Abs(43.74083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33351 - lat) + Math.Abs(38.51946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73613 - lat) + Math.Abs(36.32865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70139 - lat) + Math.Abs(30.78278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.33024 - lat) + Math.Abs(42.18484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30139 - lat) + Math.Abs(29.73861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16444 - lat) + Math.Abs(27.4975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61266 - lat) + Math.Abs(28.05912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59507 - lat) + Math.Abs(40.68407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3849 - lat) + Math.Abs(40.85938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72226 - lat) + Math.Abs(40.40696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02402 - lat) + Math.Abs(33.80626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.66072 - lat) + Math.Abs(32.92437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61853 - lat) + Math.Abs(43.13679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3229 - lat) + Math.Abs(43.37482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15878 - lat) + Math.Abs(41.74132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47923 - lat) + Math.Abs(33.31805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18028 - lat) + Math.Abs(42.42111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78276 - lat) + Math.Abs(40.63484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75 - lat) + Math.Abs(35.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1758 - lat) + Math.Abs(34.48535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.82715 - lat) + Math.Abs(37.7966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38306 - lat) + Math.Abs(31.03917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51233 - lat) + Math.Abs(34.76953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05468 - lat) + Math.Abs(39.41604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60694 - lat) + Math.Abs(34.40861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84722 - lat) + Math.Abs(40.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.02472 - lat) + Math.Abs(35.8175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84003 - lat) + Math.Abs(41.27288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17554 - lat) + Math.Abs(42.22602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.38608 - lat) + Math.Abs(40.56896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19694 - lat) + Math.Abs(31.76333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24857 - lat) + Math.Abs(35.2911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.26178 - lat) + Math.Abs(37.62603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32614 - lat) + Math.Abs(26.30574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.13538 - lat) + Math.Abs(39.445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.79426 - lat) + Math.Abs(38.84814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05539 - lat) + Math.Abs(38.90754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52947 - lat) + Math.Abs(30.48028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02444 - lat) + Math.Abs(31.79056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0256 - lat) + Math.Abs(38.23665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46418 - lat) + Math.Abs(33.5241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.6925 - lat) + Math.Abs(37.42389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1533 - lat) + Math.Abs(28.14406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7001 - lat) + Math.Abs(39.00965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.26731 - lat) + Math.Abs(41.28344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80775 - lat) + Math.Abs(40.028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.30278 - lat) + Math.Abs(35.64389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69401 - lat) + Math.Abs(39.62022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.59167 - lat) + Math.Abs(31.02861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.50179 - lat) + Math.Abs(41.24877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.60963 - lat) + Math.Abs(31.93135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.155 - lat) + Math.Abs(29.69389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.19344 - lat) + Math.Abs(29.61915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09722 - lat) + Math.Abs(41.21452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.97438 - lat) + Math.Abs(38.84777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80286 - lat) + Math.Abs(39.31539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15162 - lat) + Math.Abs(41.20256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00293 - lat) + Math.Abs(43.05243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60641 - lat) + Math.Abs(40.96844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.09171 - lat) + Math.Abs(36.82356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82694 - lat) + Math.Abs(29.66833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.24446 - lat) + Math.Abs(35.51396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93503 - lat) + Math.Abs(26.934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14833 - lat) + Math.Abs(40.20348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16652 - lat) + Math.Abs(34.59296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.1544 - lat) + Math.Abs(39.06697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76667 - lat) + Math.Abs(30.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07611 - lat) + Math.Abs(29.34472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83222 - lat) + Math.Abs(34.98139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9559 - lat) + Math.Abs(28.5991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36542 - lat) + Math.Abs(41.18576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16102 - lat) + Math.Abs(40.77072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.29751 - lat) + Math.Abs(42.64226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.14317 - lat) + Math.Abs(43.91068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08361 - lat) + Math.Abs(29.39889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.87145 - lat) + Math.Abs(30.56208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56075 - lat) + Math.Abs(37.85583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73501 - lat) + Math.Abs(27.82388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11667 - lat) + Math.Abs(28.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.74523 - lat) + Math.Abs(37.28618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58502 - lat) + Math.Abs(39.68702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03732 - lat) + Math.Abs(39.13865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.51881 - lat) + Math.Abs(28.01224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.25042 - lat) + Math.Abs(39.86916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40542 - lat) + Math.Abs(29.13727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.27304 - lat) + Math.Abs(41.03364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76417 - lat) + Math.Abs(37.54361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03472 - lat) + Math.Abs(27.55944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.94465 - lat) + Math.Abs(31.16679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.5755 - lat) + Math.Abs(38.42722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.50041 - lat) + Math.Abs(26.97269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.96397 - lat) + Math.Abs(28.7427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.72028 - lat) + Math.Abs(30.29083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01362 - lat) + Math.Abs(37.17913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.8463 - lat) + Math.Abs(35.86033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.045 - lat) + Math.Abs(28.83056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.08656 - lat) + Math.Abs(42.27158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.68556 - lat) + Math.Abs(43.23028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16851 - lat) + Math.Abs(42.40652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.37823 - lat) + Math.Abs(41.34828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95443 - lat) + Math.Abs(33.02196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3983 - lat) + Math.Abs(27.16662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45917 - lat) + Math.Abs(30.595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1082 - lat) + Math.Abs(32.96113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90778 - lat) + Math.Abs(30.03667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.26972 - lat) + Math.Abs(34.26111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18375 - lat) + Math.Abs(40.71869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3625 - lat) + Math.Abs(38.52667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.21611 - lat) + Math.Abs(30.28583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62292 - lat) + Math.Abs(38.80194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82417 - lat) + Math.Abs(29.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.18963 - lat) + Math.Abs(32.24736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.981 - lat) + Math.Abs(41.41328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67134 - lat) + Math.Abs(28.31395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.835 - lat) + Math.Abs(26.06972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69495 - lat) + Math.Abs(28.04336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30917 - lat) + Math.Abs(28.16972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78806 - lat) + Math.Abs(31.10167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.32874 - lat) + Math.Abs(42.26366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42542 - lat) + Math.Abs(41.90881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.89722 - lat) + Math.Abs(38.7125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17778 - lat) + Math.Abs(42.32906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.47921 - lat) + Math.Abs(27.2399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75291 - lat) + Math.Abs(28.46744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89056 - lat) + Math.Abs(34.55889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71111 - lat) + Math.Abs(31.04861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.32748 - lat) + Math.Abs(42.17448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.62076 - lat) + Math.Abs(29.37373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76737 - lat) + Math.Abs(38.94622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49881 - lat) + Math.Abs(43.03808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16632 - lat) + Math.Abs(38.0811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52775 - lat) + Math.Abs(43.00778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.18877 - lat) + Math.Abs(35.24537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85319 - lat) + Math.Abs(31.16388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03833 - lat) + Math.Abs(27.42917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40115 - lat) + Math.Abs(42.10784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84514 - lat) + Math.Abs(40.65931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.25028 - lat) + Math.Abs(28.05917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.02577 - lat) + Math.Abs(37.97841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58942 - lat) + Math.Abs(41.48296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.88472 - lat) + Math.Abs(40.49389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84708 - lat) + Math.Abs(41.21608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.93395 - lat) + Math.Abs(38.38235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3925 - lat) + Math.Abs(28.13111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56318 - lat) + Math.Abs(43.16583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.67735 - lat) + Math.Abs(31.72458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.5064 - lat) + Math.Abs(37.7069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.68694 - lat) + Math.Abs(31.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88314 - lat) + Math.Abs(41.68686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01412 - lat) + Math.Abs(41.32372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23526 - lat) + Math.Abs(28.89612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.54693 - lat) + Math.Abs(38.07595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83709 - lat) + Math.Abs(41.60219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69278 - lat) + Math.Abs(37.86111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.14444 - lat) + Math.Abs(31.19917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91573 - lat) + Math.Abs(41.2865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12074 - lat) + Math.Abs(27.18052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63723 - lat) + Math.Abs(37.5803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.2148 - lat) + Math.Abs(32.55363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.015 - lat) + Math.Abs(27.45028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91537 - lat) + Math.Abs(42.7769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.48866 - lat) + Math.Abs(36.19489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.42611 - lat) + Math.Abs(32.1925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86278 - lat) + Math.Abs(31.05556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.14086 - lat) + Math.Abs(41.29351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23105 - lat) + Math.Abs(29.4197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49344 - lat) + Math.Abs(26.33316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97557 - lat) + Math.Abs(42.64823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.8693 - lat) + Math.Abs(39.06199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58276 - lat) + Math.Abs(36.62049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80862 - lat) + Math.Abs(26.60983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46717 - lat) + Math.Abs(27.16384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15754 - lat) + Math.Abs(41.7733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26774 - lat) + Math.Abs(28.21677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.21741 - lat) + Math.Abs(27.64744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.98306 - lat) + Math.Abs(30.92472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88738 - lat) + Math.Abs(41.13221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.83505 - lat) + Math.Abs(39.97929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42805 - lat) + Math.Abs(41.64312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.19017 - lat) + Math.Abs(38.68737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89722 - lat) + Math.Abs(30.01167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.56866 - lat) + Math.Abs(38.81634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56468 - lat) + Math.Abs(40.88757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04526 - lat) + Math.Abs(44.01718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69857 - lat) + Math.Abs(40.91243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.09906 - lat) + Math.Abs(39.51321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.01778 - lat) + Math.Abs(30.78278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4832 - lat) + Math.Abs(41.40251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.73707 - lat) + Math.Abs(29.75194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.74861 - lat) + Math.Abs(27.57889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86804 - lat) + Math.Abs(41.05536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.42006 - lat) + Math.Abs(40.05713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86819 - lat) + Math.Abs(38.99309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91411 - lat) + Math.Abs(33.72333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64917 - lat) + Math.Abs(27.88611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72532 - lat) + Math.Abs(34.10123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46106 - lat) + Math.Abs(37.57881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.55422 - lat) + Math.Abs(33.12344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97694 - lat) + Math.Abs(29.60861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.80017 - lat) + Math.Abs(33.43701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1246 - lat) + Math.Abs(42.79825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11373 - lat) + Math.Abs(41.2342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19724 - lat) + Math.Abs(36.57658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.59139 - lat) + Math.Abs(38.3191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86974 - lat) + Math.Abs(41.7511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52705 - lat) + Math.Abs(40.68618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43333 - lat) + Math.Abs(42.77417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.2175 - lat) + Math.Abs(31.27222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71769 - lat) + Math.Abs(44.0356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71261 - lat) + Math.Abs(41.9154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.11442 - lat) + Math.Abs(40.73382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7071 - lat) + Math.Abs(27.54875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.08167 - lat) + Math.Abs(28.05778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36957 - lat) + Math.Abs(40.7814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.07743 - lat) + Math.Abs(36.29051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80764 - lat) + Math.Abs(28.85665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31927 - lat) + Math.Abs(26.69341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95707 - lat) + Math.Abs(42.47948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.60111 - lat) + Math.Abs(26.40472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36127 - lat) + Math.Abs(33.6883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94911 - lat) + Math.Abs(42.0121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.89461 - lat) + Math.Abs(41.16405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.09694 - lat) + Math.Abs(31.59917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1437 - lat) + Math.Abs(33.32016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84501 - lat) + Math.Abs(27.83963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.62448 - lat) + Math.Abs(31.76941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.715 - lat) + Math.Abs(34.84667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88859 - lat) + Math.Abs(28.21528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.63639 - lat) + Math.Abs(27.24611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95083 - lat) + Math.Abs(30.63861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91046 - lat) + Math.Abs(41.36837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.21581 - lat) + Math.Abs(29.8699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92083 - lat) + Math.Abs(40.695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.03833 - lat) + Math.Abs(32.60083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86391 - lat) + Math.Abs(38.54485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41538 - lat) + Math.Abs(38.77092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5132 - lat) + Math.Abs(43.11967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0515 - lat) + Math.Abs(31.86379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.695 - lat) + Math.Abs(37.52122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81472 - lat) + Math.Abs(38.91917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.98737 - lat) + Math.Abs(38.10125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01884 - lat) + Math.Abs(34.28741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13829 - lat) + Math.Abs(40.79739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.17153 - lat) + Math.Abs(38.19851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.5634 - lat) + Math.Abs(40.1248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77375 - lat) + Math.Abs(38.26328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.29259 - lat) + Math.Abs(31.71452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.98821 - lat) + Math.Abs(42.30628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97439 - lat) + Math.Abs(35.35916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.04117 - lat) + Math.Abs(38.49516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44768 - lat) + Math.Abs(40.74755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87278 - lat) + Math.Abs(44.51917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82945 - lat) + Math.Abs(40.68025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42667 - lat) + Math.Abs(37.689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0064 - lat) + Math.Abs(36.22069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.90812 - lat) + Math.Abs(30.69556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.20655 - lat) + Math.Abs(36.15722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91987 - lat) + Math.Abs(32.85427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57757 - lat) + Math.Abs(36.35492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.355 - lat) + Math.Abs(43.26395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.07508 - lat) + Math.Abs(32.83691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85305 - lat) + Math.Abs(40.52798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27249 - lat) + Math.Abs(36.75098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99722 - lat) + Math.Abs(29.54579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.55861 - lat) + Math.Abs(30.34833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.05972 - lat) + Math.Abs(30.10917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.11244 - lat) + Math.Abs(36.24488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.2173 - lat) + Math.Abs(26.79008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.57944 - lat) + Math.Abs(26.73722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.26374 - lat) + Math.Abs(41.0625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.99159 - lat) + Math.Abs(34.37334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30778 - lat) + Math.Abs(32.86861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76903 - lat) + Math.Abs(30.9606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.61393 - lat) + Math.Abs(39.18639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79975 - lat) + Math.Abs(26.97203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02807 - lat) + Math.Abs(39.03418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.14252 - lat) + Math.Abs(44.2012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35083 - lat) + Math.Abs(28.51718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.54375 - lat) + Math.Abs(31.99982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15898 - lat) + Math.Abs(41.78915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.28246 - lat) + Math.Abs(26.37459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44034 - lat) + Math.Abs(39.87773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.10667 - lat) + Math.Abs(37.57556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16199 - lat) + Math.Abs(40.56575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.33012 - lat) + Math.Abs(42.28533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.70161 - lat) + Math.Abs(36.48535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95374 - lat) + Math.Abs(41.80674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79889 - lat) + Math.Abs(31.07111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95389 - lat) + Math.Abs(30.84778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22608 - lat) + Math.Abs(41.67253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.04861 - lat) + Math.Abs(31.79 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3575 - lat) + Math.Abs(31.41639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.37255 - lat) + Math.Abs(34.02537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.1 - lat) + Math.Abs(42.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45005 - lat) + Math.Abs(33.96484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.57389 - lat) + Math.Abs(38.22077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45345 - lat) + Math.Abs(32.3707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9434 - lat) + Math.Abs(41.05563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95694 - lat) + Math.Abs(29.07813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49139 - lat) + Math.Abs(27.26944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.00222 - lat) + Math.Abs(36.17381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15268 - lat) + Math.Abs(29.3789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76444 - lat) + Math.Abs(38.82308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16643 - lat) + Math.Abs(40.84706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91852 - lat) + Math.Abs(27.84006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4358 - lat) + Math.Abs(41.96164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.24083 - lat) + Math.Abs(33.75041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.66028 - lat) + Math.Abs(35.88361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.60217 - lat) + Math.Abs(29.74626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.94728 - lat) + Math.Abs(38.9423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.50278 - lat) + Math.Abs(28.02667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.62278 - lat) + Math.Abs(34.09583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.71111 - lat) + Math.Abs(38.9475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33899 - lat) + Math.Abs(37.97021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85424 - lat) + Math.Abs(41.18276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97709 - lat) + Math.Abs(41.05897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.92878 - lat) + Math.Abs(38.61382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.22616 - lat) + Math.Abs(41.05138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91917 - lat) + Math.Abs(38.02694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.5196 - lat) + Math.Abs(27.93865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17817 - lat) + Math.Abs(39.85627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.7489 - lat) + Math.Abs(42.48007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23874 - lat) + Math.Abs(32.11881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.64944 - lat) + Math.Abs(30.53417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.93792 - lat) + Math.Abs(38.71155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.53818 - lat) + Math.Abs(36.33626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.87484 - lat) + Math.Abs(33.91674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51728 - lat) + Math.Abs(40.90401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39576 - lat) + Math.Abs(34.34576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73362 - lat) + Math.Abs(37.11625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75667 - lat) + Math.Abs(30.54333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.24769 - lat) + Math.Abs(36.91399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76441 - lat) + Math.Abs(38.27629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.79911 - lat) + Math.Abs(42.73159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.98615 - lat) + Math.Abs(35.32531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.2262 - lat) + Math.Abs(40.48283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45549 - lat) + Math.Abs(41.29499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52671 - lat) + Math.Abs(33.85225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.42385 - lat) + Math.Abs(29.34941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.55028 - lat) + Math.Abs(34.50917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.82444 - lat) + Math.Abs(27.74667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23098 - lat) + Math.Abs(42.58409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.41333 - lat) + Math.Abs(42.83944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3671 - lat) + Math.Abs(43.07717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.30716 - lat) + Math.Abs(43.4541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47364 - lat) + Math.Abs(42.10304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.16821 - lat) + Math.Abs(36.73623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.87667 - lat) + Math.Abs(37.54694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.973 - lat) + Math.Abs(37.49488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.90583 - lat) + Math.Abs(38.34611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8986 - lat) + Math.Abs(38.88019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85414 - lat) + Math.Abs(38.97277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.949 - lat) + Math.Abs(36.19231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.68538 - lat) + Math.Abs(36.42312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.80583 - lat) + Math.Abs(36.28528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86577 - lat) + Math.Abs(36.84433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.77885 - lat) + Math.Abs(36.55776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95161 - lat) + Math.Abs(37.42232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.52531 - lat) + Math.Abs(36.18129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.46192 - lat) + Math.Abs(34.14199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58249 - lat) + Math.Abs(36.52744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26505 - lat) + Math.Abs(36.1535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2476 - lat) + Math.Abs(36.2409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.22083 - lat) + Math.Abs(36.23083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21909 - lat) + Math.Abs(36.25992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21261 - lat) + Math.Abs(36.07262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.15446 - lat) + Math.Abs(36.08314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.16696 - lat) + Math.Abs(36.05527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.17356 - lat) + Math.Abs(36.11215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.14785 - lat) + Math.Abs(36.13284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.16736 - lat) + Math.Abs(36.15788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.17802 - lat) + Math.Abs(36.14033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.181 - lat) + Math.Abs(36.27957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.16935 - lat) + Math.Abs(36.34249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.14023 - lat) + Math.Abs(36.03603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.115 - lat) + Math.Abs(36.0774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.12096 - lat) + Math.Abs(36.10481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06907 - lat) + Math.Abs(36.37076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05115 - lat) + Math.Abs(36.27609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.065 - lat) + Math.Abs(36.00944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.15027 - lat) + Math.Abs(36.12829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.32107 - lat) + Math.Abs(36.19061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.34191 - lat) + Math.Abs(36.41431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26903 - lat) + Math.Abs(36.25434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.28824 - lat) + Math.Abs(36.20903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.23292 - lat) + Math.Abs(36.10911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.23307 - lat) + Math.Abs(36.11702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.15853 - lat) + Math.Abs(36.2286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3524 - lat) + Math.Abs(36.41952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6411 - lat) + Math.Abs(36.21418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.64483 - lat) + Math.Abs(36.40836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94195 - lat) + Math.Abs(42.48568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.9193 - lat) + Math.Abs(42.82129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.90754 - lat) + Math.Abs(42.61651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47655 - lat) + Math.Abs(43.12984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.2555 - lat) + Math.Abs(42.33518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88396 - lat) + Math.Abs(42.33996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67889 - lat) + Math.Abs(39.25333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.725 - lat) + Math.Abs(39.30861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.73583 - lat) + Math.Abs(39.39389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75361 - lat) + Math.Abs(39.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75278 - lat) + Math.Abs(39.49639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78417 - lat) + Math.Abs(39.43417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78389 - lat) + Math.Abs(39.40972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.82278 - lat) + Math.Abs(39.34333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86778 - lat) + Math.Abs(39.37833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99722 - lat) + Math.Abs(39.33944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9175 - lat) + Math.Abs(39.47583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8425 - lat) + Math.Abs(39.545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.79193 - lat) + Math.Abs(39.52783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.90139 - lat) + Math.Abs(40.13111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91917 - lat) + Math.Abs(40.1575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.93111 - lat) + Math.Abs(40.1675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91528 - lat) + Math.Abs(40.1025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.96306 - lat) + Math.Abs(40.13194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.95 - lat) + Math.Abs(40.14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.92389 - lat) + Math.Abs(40.05667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99417 - lat) + Math.Abs(40.12639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.99028 - lat) + Math.Abs(40.10222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.93694 - lat) + Math.Abs(40.20917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.94472 - lat) + Math.Abs(40.2375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71731 - lat) + Math.Abs(41.4132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.19737 - lat) + Math.Abs(40.49844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10479 - lat) + Math.Abs(41.46269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.96833 - lat) + Math.Abs(32.73083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.60198 - lat) + Math.Abs(31.82067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75337 - lat) + Math.Abs(32.68018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76591 - lat) + Math.Abs(28.8028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45139 - lat) + Math.Abs(31.79305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30306 - lat) + Math.Abs(35.88639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11013 - lat) + Math.Abs(41.85816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99441 - lat) + Math.Abs(28.90417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39083 - lat) + Math.Abs(28.79639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68815 - lat) + Math.Abs(29.96738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82042 - lat) + Math.Abs(41.53743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93553 - lat) + Math.Abs(27.06631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95326 - lat) + Math.Abs(39.85546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83081 - lat) + Math.Abs(27.06971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18778 - lat) + Math.Abs(35.8875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95983 - lat) + Math.Abs(31.44355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32786 - lat) + Math.Abs(36.35144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.123 - lat) + Math.Abs(29.47696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53577 - lat) + Math.Abs(37.79566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26444 - lat) + Math.Abs(29.65306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17833 - lat) + Math.Abs(30.52 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53568 - lat) + Math.Abs(29.35364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08778 - lat) + Math.Abs(29.42194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19962 - lat) + Math.Abs(32.33133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77115 - lat) + Math.Abs(32.03375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69329 - lat) + Math.Abs(38.33723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76704 - lat) + Math.Abs(29.78275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75785 - lat) + Math.Abs(33.77819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65501 - lat) + Math.Abs(29.27693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06444 - lat) + Math.Abs(42.50081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60636 - lat) + Math.Abs(29.56225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98894 - lat) + Math.Abs(28.67582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.6325 - lat) + Math.Abs(35.52889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57487 - lat) + Math.Abs(39.86244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85672 - lat) + Math.Abs(38.62035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54432 - lat) + Math.Abs(39.52762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5725 - lat) + Math.Abs(27.76583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14361 - lat) + Math.Abs(35.45472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24472 - lat) + Math.Abs(30.02 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25361 - lat) + Math.Abs(27.87833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.31528 - lat) + Math.Abs(42.4325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04583 - lat) + Math.Abs(39.27639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26597 - lat) + Math.Abs(26.6885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91465 - lat) + Math.Abs(37.84818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61594 - lat) + Math.Abs(40.28853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53218 - lat) + Math.Abs(41.53832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73583 - lat) + Math.Abs(27.40528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02274 - lat) + Math.Abs(29.01366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24903 - lat) + Math.Abs(32.13785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13139 - lat) + Math.Abs(37.2825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42645 - lat) + Math.Abs(41.42826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41472 - lat) + Math.Abs(29.18306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23373 - lat) + Math.Abs(26.60632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01643 - lat) + Math.Abs(29.12476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58417 - lat) + Math.Abs(32.64139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86863 - lat) + Math.Abs(37.75405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70583 - lat) + Math.Abs(29.69608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44631 - lat) + Math.Abs(34.45259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20049 - lat) + Math.Abs(40.99727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03871 - lat) + Math.Abs(43.65208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06694 - lat) + Math.Abs(27.71972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96153 - lat) + Math.Abs(38.04937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.94764 - lat) + Math.Abs(34.33861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3875 - lat) + Math.Abs(36.08111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.005 - lat) + Math.Abs(39.72694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01545 - lat) + Math.Abs(34.04013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55071 - lat) + Math.Abs(39.28344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28892 - lat) + Math.Abs(41.54096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61658 - lat) + Math.Abs(37.77057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88402 - lat) + Math.Abs(39.28486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31389 - lat) + Math.Abs(36.55444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00694 - lat) + Math.Abs(38.81389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20917 - lat) + Math.Abs(36.97389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02931 - lat) + Math.Abs(28.54978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98588 - lat) + Math.Abs(37.16028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21167 - lat) + Math.Abs(36.46 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71556 - lat) + Math.Abs(36.19247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9781 - lat) + Math.Abs(27.51101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0605 - lat) + Math.Abs(29.65381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81876 - lat) + Math.Abs(29.51136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77083 - lat) + Math.Abs(29.57194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03333 - lat) + Math.Abs(28.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75972 - lat) + Math.Abs(36.3225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5098 - lat) + Math.Abs(34.21414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67361 - lat) + Math.Abs(29.39111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94745 - lat) + Math.Abs(41.49477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39694 - lat) + Math.Abs(30.49278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40944 - lat) + Math.Abs(36.12889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52556 - lat) + Math.Abs(29.73972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09889 - lat) + Math.Abs(27.0675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7791 - lat) + Math.Abs(43.12769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16005 - lat) + Math.Abs(38.08413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90588 - lat) + Math.Abs(40.12792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1675 - lat) + Math.Abs(34.37389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83129 - lat) + Math.Abs(35.64788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02139 - lat) + Math.Abs(27.98861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76901 - lat) + Math.Abs(26.90999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15733 - lat) + Math.Abs(33.716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3948 - lat) + Math.Abs(29.41559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33787 - lat) + Math.Abs(28.64945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9059 - lat) + Math.Abs(30.47448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06089 - lat) + Math.Abs(28.57231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6707 - lat) + Math.Abs(29.50819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05472 - lat) + Math.Abs(29.12278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06046 - lat) + Math.Abs(28.98717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.78124 - lat) + Math.Abs(26.47888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19064 - lat) + Math.Abs(39.11747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02683 - lat) + Math.Abs(35.16253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.22798 - lat) + Math.Abs(28.19043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27073 - lat) + Math.Abs(27.40667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07393 - lat) + Math.Abs(28.24644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1754 - lat) + Math.Abs(29.61333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19484 - lat) + Math.Abs(41.83696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92194 - lat) + Math.Abs(36.06333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54302 - lat) + Math.Abs(34.73812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62005 - lat) + Math.Abs(33.71815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09347 - lat) + Math.Abs(27.84667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.70528 - lat) + Math.Abs(27.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.11195 - lat) + Math.Abs(37.75624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77376 - lat) + Math.Abs(30.38006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.8089 - lat) + Math.Abs(33.23135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55652 - lat) + Math.Abs(42.34266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05448 - lat) + Math.Abs(28.36678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45772 - lat) + Math.Abs(42.78287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32389 - lat) + Math.Abs(29.19639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28833 - lat) + Math.Abs(38.42361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41134 - lat) + Math.Abs(31.57359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24027 - lat) + Math.Abs(42.36109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61395 - lat) + Math.Abs(27.11563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2075 - lat) + Math.Abs(27.59611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32769 - lat) + Math.Abs(42.58705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74806 - lat) + Math.Abs(35.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.32865 - lat) + Math.Abs(34.84686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95017 - lat) + Math.Abs(35.11165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44431 - lat) + Math.Abs(27.92194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69141 - lat) + Math.Abs(30.26738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48861 - lat) + Math.Abs(29.82944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27976 - lat) + Math.Abs(36.3361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.999 - lat) + Math.Abs(29.22565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93826 - lat) + Math.Abs(39.19006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02167 - lat) + Math.Abs(26.8425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25083 - lat) + Math.Abs(32.69417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48249 - lat) + Math.Abs(33.28352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02083 - lat) + Math.Abs(40.52194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39194 - lat) + Math.Abs(37.3375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03203 - lat) + Math.Abs(32.89528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51111 - lat) + Math.Abs(42.72917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95299 - lat) + Math.Abs(38.1089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92244 - lat) + Math.Abs(38.12458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62417 - lat) + Math.Abs(27.52 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.60388 - lat) + Math.Abs(33.11099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06556 - lat) + Math.Abs(37.77139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8775 - lat) + Math.Abs(29.2725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34812 - lat) + Math.Abs(26.92522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41857 - lat) + Math.Abs(32.30833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41142 - lat) + Math.Abs(40.7678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92555 - lat) + Math.Abs(32.1807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17917 - lat) + Math.Abs(40.88417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33027 - lat) + Math.Abs(32.7482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27652 - lat) + Math.Abs(36.28347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5081 - lat) + Math.Abs(30.16732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4485 - lat) + Math.Abs(32.75361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07661 - lat) + Math.Abs(32.91994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87319 - lat) + Math.Abs(34.60308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35722 - lat) + Math.Abs(30.01417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97818 - lat) + Math.Abs(34.8047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25104 - lat) + Math.Abs(41.98363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10154 - lat) + Math.Abs(28.37588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04777 - lat) + Math.Abs(40.8984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39367 - lat) + Math.Abs(38.01028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27352 - lat) + Math.Abs(35.25175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27896 - lat) + Math.Abs(41.37887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6242 - lat) + Math.Abs(33.10928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16472 - lat) + Math.Abs(31.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50611 - lat) + Math.Abs(29.65972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48917 - lat) + Math.Abs(29.30889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97782 - lat) + Math.Abs(37.89047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82165 - lat) + Math.Abs(42.13055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53945 - lat) + Math.Abs(41.98722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91728 - lat) + Math.Abs(41.63612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94055 - lat) + Math.Abs(40.25918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64 - lat) + Math.Abs(29.86306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59167 - lat) + Math.Abs(36.95167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34449 - lat) + Math.Abs(41.86088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38583 - lat) + Math.Abs(29.48111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18593 - lat) + Math.Abs(31.35179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03815 - lat) + Math.Abs(28.40866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47405 - lat) + Math.Abs(41.70647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17216 - lat) + Math.Abs(27.4992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.473 - lat) + Math.Abs(31.20755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37528 - lat) + Math.Abs(28.88222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0179 - lat) + Math.Abs(28.56176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02621 - lat) + Math.Abs(30.57707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19764 - lat) + Math.Abs(35.11684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40964 - lat) + Math.Abs(42.2364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45446 - lat) + Math.Abs(37.77353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87333 - lat) + Math.Abs(35.46306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19183 - lat) + Math.Abs(26.42097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93877 - lat) + Math.Abs(32.07642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52 - lat) + Math.Abs(35.29528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63889 - lat) + Math.Abs(26.53917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96907 - lat) + Math.Abs(27.95503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20667 - lat) + Math.Abs(27.75444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58633 - lat) + Math.Abs(27.55541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04639 - lat) + Math.Abs(27.97 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93567 - lat) + Math.Abs(29.15507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89 - lat) + Math.Abs(26.90111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15281 - lat) + Math.Abs(29.18968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05361 - lat) + Math.Abs(28.82556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18139 - lat) + Math.Abs(40.40417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81072 - lat) + Math.Abs(39.60465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40385 - lat) + Math.Abs(27.35918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34417 - lat) + Math.Abs(26.68556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83951 - lat) + Math.Abs(26.73561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91056 - lat) + Math.Abs(35.89194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.232 - lat) + Math.Abs(33.72267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83781 - lat) + Math.Abs(32.71621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26546 - lat) + Math.Abs(43.1258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84101 - lat) + Math.Abs(33.26028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03712 - lat) + Math.Abs(29.65972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80578 - lat) + Math.Abs(33.71161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10694 - lat) + Math.Abs(26.35194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09837 - lat) + Math.Abs(30.0001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87444 - lat) + Math.Abs(37.26389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44724 - lat) + Math.Abs(32.46759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02108 - lat) + Math.Abs(28.48033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88236 - lat) + Math.Abs(27.45919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72419 - lat) + Math.Abs(29.98943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47047 - lat) + Math.Abs(29.10152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80748 - lat) + Math.Abs(40.05512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12639 - lat) + Math.Abs(29.35278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.43194 - lat) + Math.Abs(31.74583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60878 - lat) + Math.Abs(36.47858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48333 - lat) + Math.Abs(32.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.30184 - lat) + Math.Abs(37.82336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75484 - lat) + Math.Abs(38.11155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.2185 - lat) + Math.Abs(43.0022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74012 - lat) + Math.Abs(30.00556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20692 - lat) + Math.Abs(39.64626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65435 - lat) + Math.Abs(29.16289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73479 - lat) + Math.Abs(33.51844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82472 - lat) + Math.Abs(37.34667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80692 - lat) + Math.Abs(40.11439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90538 - lat) + Math.Abs(31.14568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41824 - lat) + Math.Abs(35.80136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52022 - lat) + Math.Abs(32.09621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.94481 - lat) + Math.Abs(27.15829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63 - lat) + Math.Abs(29.03 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05336 - lat) + Math.Abs(30.85278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34556 - lat) + Math.Abs(33.98639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46972 - lat) + Math.Abs(32.65056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63476 - lat) + Math.Abs(28.09459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32353 - lat) + Math.Abs(42.02233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73508 - lat) + Math.Abs(27.22521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39019 - lat) + Math.Abs(26.79496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65 - lat) + Math.Abs(35.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01378 - lat) + Math.Abs(31.83197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09964 - lat) + Math.Abs(29.04163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04176 - lat) + Math.Abs(26.7009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90713 - lat) + Math.Abs(29.05499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49111 - lat) + Math.Abs(31.83861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70471 - lat) + Math.Abs(41.47385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63306 - lat) + Math.Abs(29.39472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.40778 - lat) + Math.Abs(31.85194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19828 - lat) + Math.Abs(29.21237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91032 - lat) + Math.Abs(38.5013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85583 - lat) + Math.Abs(26.63028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15902 - lat) + Math.Abs(28.91572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48336 - lat) + Math.Abs(41.5275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12682 - lat) + Math.Abs(39.43424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16833 - lat) + Math.Abs(30.22972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23167 - lat) + Math.Abs(32.68389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68225 - lat) + Math.Abs(29.53236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76917 - lat) + Math.Abs(31.32211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03083 - lat) + Math.Abs(30.3075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41444 - lat) + Math.Abs(29.82556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9231 - lat) + Math.Abs(30.26597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09258 - lat) + Math.Abs(28.33172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07833 - lat) + Math.Abs(36.0425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.37805 - lat) + Math.Abs(33.77528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.32812 - lat) + Math.Abs(31.96811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59825 - lat) + Math.Abs(43.08548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13373 - lat) + Math.Abs(34.48744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74402 - lat) + Math.Abs(36.59018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23964 - lat) + Math.Abs(42.27283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10442 - lat) + Math.Abs(30.69664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07096 - lat) + Math.Abs(30.78543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32573 - lat) + Math.Abs(31.98682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64194 - lat) + Math.Abs(30.53944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75353 - lat) + Math.Abs(34.70275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69129 - lat) + Math.Abs(29.61649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16591 - lat) + Math.Abs(42.60453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.51718 - lat) + Math.Abs(26.64381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95423 - lat) + Math.Abs(29.80598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73174 - lat) + Math.Abs(30.83992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40338 - lat) + Math.Abs(28.38055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15126 - lat) + Math.Abs(29.76935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21323 - lat) + Math.Abs(28.3612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47944 - lat) + Math.Abs(29.06833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82043 - lat) + Math.Abs(38.54941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20488 - lat) + Math.Abs(32.62768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.40361 - lat) + Math.Abs(27.30389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96067 - lat) + Math.Abs(40.78238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.32912 - lat) + Math.Abs(27.98064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07 - lat) + Math.Abs(30.15262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10364 - lat) + Math.Abs(34.76298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92046 - lat) + Math.Abs(40.43692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09722 - lat) + Math.Abs(33.40833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38688 - lat) + Math.Abs(39.68332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15669 - lat) + Math.Abs(43.13424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66667 - lat) + Math.Abs(26.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62015 - lat) + Math.Abs(29.22536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75 - lat) + Math.Abs(37.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.85211 - lat) + Math.Abs(35.06249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86096 - lat) + Math.Abs(37.8847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42861 - lat) + Math.Abs(29.72111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76499 - lat) + Math.Abs(29.92928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01192 - lat) + Math.Abs(40.36185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01384 - lat) + Math.Abs(28.94966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47981 - lat) + Math.Abs(40.99373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73528 - lat) + Math.Abs(34.47389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92115 - lat) + Math.Abs(26.38273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01333 - lat) + Math.Abs(26.33287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0271 - lat) + Math.Abs(33.3041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04932 - lat) + Math.Abs(30.38521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07806 - lat) + Math.Abs(29.51333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93518 - lat) + Math.Abs(27.28118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.67747 - lat) + Math.Abs(27.06786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.97472 - lat) + Math.Abs(33.76083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20107 - lat) + Math.Abs(25.90902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21673 - lat) + Math.Abs(29.87088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92511 - lat) + Math.Abs(33.62586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68833 - lat) + Math.Abs(33.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77484 - lat) + Math.Abs(40.55227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05833 - lat) + Math.Abs(37.08028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69087 - lat) + Math.Abs(29.83472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20432 - lat) + Math.Abs(33.55455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87444 - lat) + Math.Abs(27.98389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.22617 - lat) + Math.Abs(33.13699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26633 - lat) + Math.Abs(35.62645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01037 - lat) + Math.Abs(26.50343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03885 - lat) + Math.Abs(42.16366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39046 - lat) + Math.Abs(41.41966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.55383 - lat) + Math.Abs(32.02389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78611 - lat) + Math.Abs(29.61472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79944 - lat) + Math.Abs(30.74806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03519 - lat) + Math.Abs(40.90584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.94843 - lat) + Math.Abs(34.3945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8853 - lat) + Math.Abs(40.36495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21311 - lat) + Math.Abs(27.10688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97056 - lat) + Math.Abs(35.66222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.54898 - lat) + Math.Abs(26.82207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63822 - lat) + Math.Abs(26.85746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99106 - lat) + Math.Abs(42.88396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24067 - lat) + Math.Abs(33.328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62705 - lat) + Math.Abs(34.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.23344 - lat) + Math.Abs(42.84037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13583 - lat) + Math.Abs(29.52639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15128 - lat) + Math.Abs(26.66411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74752 - lat) + Math.Abs(35.04249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78476 - lat) + Math.Abs(35.0258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41867 - lat) + Math.Abs(32.15984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0743 - lat) + Math.Abs(34.449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5732 - lat) + Math.Abs(30.86784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83444 - lat) + Math.Abs(29.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59069 - lat) + Math.Abs(32.66111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21876 - lat) + Math.Abs(29.19487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99256 - lat) + Math.Abs(28.61428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78567 - lat) + Math.Abs(37.58969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9813 - lat) + Math.Abs(40.60465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32794 - lat) + Math.Abs(40.91863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82095 - lat) + Math.Abs(40.47035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05319 - lat) + Math.Abs(40.60664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26408 - lat) + Math.Abs(27.09288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84694 - lat) + Math.Abs(30.94111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.46001 - lat) + Math.Abs(39.47176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87306 - lat) + Math.Abs(35.21472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28228 - lat) + Math.Abs(27.28205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84018 - lat) + Math.Abs(35.17195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21051 - lat) + Math.Abs(32.24552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21913 - lat) + Math.Abs(33.48487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.40028 - lat) + Math.Abs(30.78833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39917 - lat) + Math.Abs(35.525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23114 - lat) + Math.Abs(28.84017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03083 - lat) + Math.Abs(39.00306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1049 - lat) + Math.Abs(27.65399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7769 - lat) + Math.Abs(30.99587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28472 - lat) + Math.Abs(30.31722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.06194 - lat) + Math.Abs(38.60667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37381 - lat) + Math.Abs(29.59025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73539 - lat) + Math.Abs(42.28819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68689 - lat) + Math.Abs(37.61544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78746 - lat) + Math.Abs(42.60603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70323 - lat) + Math.Abs(29.87216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27639 - lat) + Math.Abs(29.37833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.27937 - lat) + Math.Abs(41.55514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47292 - lat) + Math.Abs(36.7525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58333 - lat) + Math.Abs(36.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89389 - lat) + Math.Abs(31.95957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28644 - lat) + Math.Abs(38.11771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30583 - lat) + Math.Abs(32.14234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01972 - lat) + Math.Abs(28.14556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91698 - lat) + Math.Abs(38.38741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5075 - lat) + Math.Abs(30.2925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80361 - lat) + Math.Abs(35.20111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80083 - lat) + Math.Abs(32.19694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07234 - lat) + Math.Abs(42.25617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43094 - lat) + Math.Abs(29.15969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41028 - lat) + Math.Abs(26.67083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44529 - lat) + Math.Abs(35.62627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80276 - lat) + Math.Abs(29.43068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42153 - lat) + Math.Abs(42.34799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08125 - lat) + Math.Abs(43.45187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.269 - lat) + Math.Abs(41.14002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94082 - lat) + Math.Abs(30.48583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02778 - lat) + Math.Abs(37.50139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06436 - lat) + Math.Abs(39.14274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01927 - lat) + Math.Abs(35.20788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09922 - lat) + Math.Abs(31.81739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.24527 - lat) + Math.Abs(39.17535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94298 - lat) + Math.Abs(32.53091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86596 - lat) + Math.Abs(32.54167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87331 - lat) + Math.Abs(39.68829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02697 - lat) + Math.Abs(28.67732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0435 - lat) + Math.Abs(28.87619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66806 - lat) + Math.Abs(36.38028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87926 - lat) + Math.Abs(34.91838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75504 - lat) + Math.Abs(30.39344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28261 - lat) + Math.Abs(31.41806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.3996 - lat) + Math.Abs(27.79348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66889 - lat) + Math.Abs(36.5675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72472 - lat) + Math.Abs(26.0825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01766 - lat) + Math.Abs(28.97438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51556 - lat) + Math.Abs(29.88139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52975 - lat) + Math.Abs(33.49903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48611 - lat) + Math.Abs(29.72472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42289 - lat) + Math.Abs(32.95761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.67719 - lat) + Math.Abs(26.55597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34229 - lat) + Math.Abs(27.86129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18416 - lat) + Math.Abs(26.3574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87461 - lat) + Math.Abs(39.41536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83889 - lat) + Math.Abs(31.16389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30337 - lat) + Math.Abs(28.67635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41583 - lat) + Math.Abs(35.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.05862 - lat) + Math.Abs(41.35654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72052 - lat) + Math.Abs(32.06314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6936 - lat) + Math.Abs(29.94154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31224 - lat) + Math.Abs(36.2918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97986 - lat) + Math.Abs(43.47098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.00457 - lat) + Math.Abs(33.46029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68806 - lat) + Math.Abs(36.71639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59778 - lat) + Math.Abs(35.60417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20841 - lat) + Math.Abs(37.53123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8075 - lat) + Math.Abs(38.91722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62647 - lat) + Math.Abs(30.33557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85489 - lat) + Math.Abs(34.80703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39622 - lat) + Math.Abs(29.70793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.22078 - lat) + Math.Abs(36.615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.36896 - lat) + Math.Abs(43.40997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.60303 - lat) + Math.Abs(33.83922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21917 - lat) + Math.Abs(31.95583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84667 - lat) + Math.Abs(36.18306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79658 - lat) + Math.Abs(40.2446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75694 - lat) + Math.Abs(29.81472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02398 - lat) + Math.Abs(40.42332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7389 - lat) + Math.Abs(38.44337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.93008 - lat) + Math.Abs(27.37052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66434 - lat) + Math.Abs(29.56349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9459 - lat) + Math.Abs(39.59401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70753 - lat) + Math.Abs(30.11434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27194 - lat) + Math.Abs(29.09833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16023 - lat) + Math.Abs(39.89239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87908 - lat) + Math.Abs(41.72953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72 - lat) + Math.Abs(29.78083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77973 - lat) + Math.Abs(29.39454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.0206 - lat) + Math.Abs(27.86374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.22417 - lat) + Math.Abs(27.24806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34145 - lat) + Math.Abs(42.8368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72763 - lat) + Math.Abs(39.91177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47866 - lat) + Math.Abs(33.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60458 - lat) + Math.Abs(29.4099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23861 - lat) + Math.Abs(33.03222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54889 - lat) + Math.Abs(34.95333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15917 - lat) + Math.Abs(27.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21972 - lat) + Math.Abs(26.82278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.055 - lat) + Math.Abs(36.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64538 - lat) + Math.Abs(29.1245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89361 - lat) + Math.Abs(31.04917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12141 - lat) + Math.Abs(43.1299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66028 - lat) + Math.Abs(29.32361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.89211 - lat) + Math.Abs(33.00439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07124 - lat) + Math.Abs(29.44661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28629 - lat) + Math.Abs(27.99939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81164 - lat) + Math.Abs(32.89358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.3945 - lat) + Math.Abs(35.23665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.34529 - lat) + Math.Abs(35.05136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32194 - lat) + Math.Abs(32.45569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04118 - lat) + Math.Abs(29.17838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07306 - lat) + Math.Abs(35.49472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69516 - lat) + Math.Abs(39.09468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74267 - lat) + Math.Abs(40.23175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.09806 - lat) + Math.Abs(31.67319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08609 - lat) + Math.Abs(40.72213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42639 - lat) + Math.Abs(32.07556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01711 - lat) + Math.Abs(37.09796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.95314 - lat) + Math.Abs(34.21627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14324 - lat) + Math.Abs(28.46154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08278 - lat) + Math.Abs(39.38278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19889 - lat) + Math.Abs(36.72194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07897 - lat) + Math.Abs(28.08323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59995 - lat) + Math.Abs(33.6153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25717 - lat) + Math.Abs(33.46868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15552 - lat) + Math.Abs(26.41271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91139 - lat) + Math.Abs(38.98813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03328 - lat) + Math.Abs(27.05236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12732 - lat) + Math.Abs(38.73006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6391 - lat) + Math.Abs(41.15218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04765 - lat) + Math.Abs(40.99996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48958 - lat) + Math.Abs(32.47499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08639 - lat) + Math.Abs(36.47722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47838 - lat) + Math.Abs(41.89825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.90019 - lat) + Math.Abs(39.71231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.902 - lat) + Math.Abs(37.52786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16861 - lat) + Math.Abs(28.92083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51806 - lat) + Math.Abs(29.45222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47056 - lat) + Math.Abs(29.66333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.16824 - lat) + Math.Abs(35.76017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77486 - lat) + Math.Abs(34.88068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01489 - lat) + Math.Abs(40.67302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30028 - lat) + Math.Abs(27.54528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01284 - lat) + Math.Abs(28.53824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24002 - lat) + Math.Abs(28.06331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86778 - lat) + Math.Abs(29.13306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19559 - lat) + Math.Abs(29.06013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03686 - lat) + Math.Abs(30.62675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93805 - lat) + Math.Abs(38.23148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21889 - lat) + Math.Abs(27.77056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.95769 - lat) + Math.Abs(34.01087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26337 - lat) + Math.Abs(28.63142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48194 - lat) + Math.Abs(29.56083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46889 - lat) + Math.Abs(34.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35792 - lat) + Math.Abs(41.66579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73583 - lat) + Math.Abs(31.60611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5153 - lat) + Math.Abs(26.75664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03435 - lat) + Math.Abs(37.59409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.02191 - lat) + Math.Abs(34.60947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45 - lat) + Math.Abs(35.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.54755 - lat) + Math.Abs(42.78199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14192 - lat) + Math.Abs(29.97932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22806 - lat) + Math.Abs(27.24222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03556 - lat) + Math.Abs(36.23556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1675 - lat) + Math.Abs(31.92111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25515 - lat) + Math.Abs(26.92442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34833 - lat) + Math.Abs(27.70389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13822 - lat) + Math.Abs(35.21724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05202 - lat) + Math.Abs(39.23294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51273 - lat) + Math.Abs(37.28862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86156 - lat) + Math.Abs(33.49557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94329 - lat) + Math.Abs(33.203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.25631 - lat) + Math.Abs(40.22289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64583 - lat) + Math.Abs(34.26139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64069 - lat) + Math.Abs(43.52179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.54694 - lat) + Math.Abs(37.16917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63583 - lat) + Math.Abs(32.3375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35222 - lat) + Math.Abs(27.97667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06702 - lat) + Math.Abs(27.33575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5011 - lat) + Math.Abs(36.06887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83028 - lat) + Math.Abs(27.05548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31029 - lat) + Math.Abs(27.08171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8725 - lat) + Math.Abs(29.42833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20499 - lat) + Math.Abs(27.08317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6681 - lat) + Math.Abs(29.91478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03903 - lat) + Math.Abs(28.85671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56778 - lat) + Math.Abs(35.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4325 - lat) + Math.Abs(27.09306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.64267 - lat) + Math.Abs(33.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99111 - lat) + Math.Abs(36.63139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38325 - lat) + Math.Abs(40.14272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12727 - lat) + Math.Abs(35.28765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56972 - lat) + Math.Abs(36.13917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68667 - lat) + Math.Abs(37.39917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.01933 - lat) + Math.Abs(32.33221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.94472 - lat) + Math.Abs(34.58611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81593 - lat) + Math.Abs(33.07556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18299 - lat) + Math.Abs(42.17443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18161 - lat) + Math.Abs(41.82172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.11578 - lat) + Math.Abs(36.3001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95271 - lat) + Math.Abs(39.92674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84522 - lat) + Math.Abs(43.32747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18355 - lat) + Math.Abs(28.7402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.51944 - lat) + Math.Abs(28.82806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68706 - lat) + Math.Abs(32.62396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70036 - lat) + Math.Abs(30.35076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35121 - lat) + Math.Abs(41.30456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6181 - lat) + Math.Abs(37.00169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19111 - lat) + Math.Abs(40.9875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.12738 - lat) + Math.Abs(42.06292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10871 - lat) + Math.Abs(42.70222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.93854 - lat) + Math.Abs(40.05842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24222 - lat) + Math.Abs(33.32767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65333 - lat) + Math.Abs(35.83306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.74633 - lat) + Math.Abs(32.38633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31656 - lat) + Math.Abs(38.75285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69495 - lat) + Math.Abs(29.50986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37583 - lat) + Math.Abs(36.90444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80275 - lat) + Math.Abs(35.32256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1814 - lat) + Math.Abs(31.38514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10881 - lat) + Math.Abs(29.51871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.60556 - lat) + Math.Abs(35.59806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16833 - lat) + Math.Abs(34.8425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13512 - lat) + Math.Abs(33.08614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.685 - lat) + Math.Abs(30.62222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74093 - lat) + Math.Abs(43.61432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.08964 - lat) + Math.Abs(38.03467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64651 - lat) + Math.Abs(42.3391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.14725 - lat) + Math.Abs(28.1068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88611 - lat) + Math.Abs(29.49444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84929 - lat) + Math.Abs(30.19822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79306 - lat) + Math.Abs(37.01639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07172 - lat) + Math.Abs(38.3433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71235 - lat) + Math.Abs(35.97605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08663 - lat) + Math.Abs(31.11623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02121 - lat) + Math.Abs(39.57146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13806 - lat) + Math.Abs(29.85667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68602 - lat) + Math.Abs(33.55383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78056 - lat) + Math.Abs(30.40333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.97858 - lat) + Math.Abs(34.011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94705 - lat) + Math.Abs(38.70299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05188 - lat) + Math.Abs(28.41867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0963 - lat) + Math.Abs(28.49227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.2256 - lat) + Math.Abs(28.21311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71604 - lat) + Math.Abs(29.75223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84639 - lat) + Math.Abs(29.30889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.01295 - lat) + Math.Abs(28.88593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00711 - lat) + Math.Abs(28.88795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01667 - lat) + Math.Abs(27.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.86726 - lat) + Math.Abs(32.52863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.71549 - lat) + Math.Abs(28.70436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56674 - lat) + Math.Abs(29.14467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84894 - lat) + Math.Abs(38.8722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.23044 - lat) + Math.Abs(29.00425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66847 - lat) + Math.Abs(32.82689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8759 - lat) + Math.Abs(29.0894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9833 - lat) + Math.Abs(29.1167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09307 - lat) + Math.Abs(28.80203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.982 - lat) + Math.Abs(28.6399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02072 - lat) + Math.Abs(28.58502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9179 - lat) + Math.Abs(32.86268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.70827 - lat) + Math.Abs(29.05081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42286 - lat) + Math.Abs(38.3585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.939 - lat) + Math.Abs(39.6758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8932 - lat) + Math.Abs(38.7982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87899 - lat) + Math.Abs(37.45351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07962 - lat) + Math.Abs(37.38003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.04836 - lat) + Math.Abs(37.34371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00231 - lat) + Math.Abs(28.8598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10652 - lat) + Math.Abs(28.86847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96072 - lat) + Math.Abs(29.27067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00244 - lat) + Math.Abs(29.23187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.55519 - lat) + Math.Abs(34.9472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04754 - lat) + Math.Abs(35.51687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17128 - lat) + Math.Abs(36.32883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08398 - lat) + Math.Abs(36.8304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.37396 - lat) + Math.Abs(27.1352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.89157 - lat) + Math.Abs(30.76498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.64876 - lat) + Math.Abs(31.70387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87389 - lat) + Math.Abs(30.95091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97305 - lat) + Math.Abs(30.67686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84137 - lat) + Math.Abs(37.14407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.17132 - lat) + Math.Abs(33.55581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7916 - lat) + Math.Abs(30.295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0366 - lat) + Math.Abs(29.9018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60779 - lat) + Math.Abs(29.1736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18851 - lat) + Math.Abs(29.10974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19671 - lat) + Math.Abs(29.05935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77102 - lat) + Math.Abs(28.88614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44722 - lat) + Math.Abs(41.26513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.98607 - lat) + Math.Abs(44.22359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91375 - lat) + Math.Abs(40.20584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91351 - lat) + Math.Abs(40.22859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94146 - lat) + Math.Abs(40.13801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.88898 - lat) + Math.Abs(41.28055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91598 - lat) + Math.Abs(41.28145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89821 - lat) + Math.Abs(41.26916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.81091 - lat) + Math.Abs(30.52551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76821 - lat) + Math.Abs(30.53538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.7912 - lat) + Math.Abs(29.10141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21401 - lat) + Math.Abs(28.91567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.82855 - lat) + Math.Abs(39.61057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12954 - lat) + Math.Abs(26.42075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28732 - lat) + Math.Abs(36.29046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.91579 - lat) + Math.Abs(30.70782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03291 - lat) + Math.Abs(29.10137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98404 - lat) + Math.Abs(37.87348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33675 - lat) + Math.Abs(37.74142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06132 - lat) + Math.Abs(43.32201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80544 - lat) + Math.Abs(29.04236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2142;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Demre", "07", 36.24444, 29.985);
case 1: return new CityInfo("Yıldız", "63", 36.9375, 38.40917);
case 2: return new CityInfo("Zeytinliova", "45", 38.99118, 27.67635);
case 3: return new CityInfo("Zeytindağ", "35", 38.96722, 27.07222);
case 4: return new CityInfo("Zara", "58", 39.89778, 37.75833);
case 5: return new CityInfo("Yunak", "71", 38.81418, 31.73223);
case 6: return new CityInfo("Yumurtalık", "81", 36.76863, 35.78938);
case 7: return new CityInfo("Yüksekova", "70", 37.57362, 44.28716);
case 8: return new CityInfo("Barim", "80", 37.27488, 41.93734);
case 9: return new CityInfo("Yukarı Beğdeş", "63", 36.84617, 38.90473);
case 10: return new CityInfo("Salat", "21", 37.84172, 40.8865);
case 11: return new CityInfo("Yukarı Harım", "21", 37.91778, 40.70861);
case 12: return new CityInfo("Yukarı Çaykuyu", "63", 36.995, 38.75111);
case 13: return new CityInfo("Kozak", "35", 39.25124, 27.09021);
case 14: return new CityInfo("Yukarı Azıklı", "72", 37.26621, 40.67644);
case 15: return new CityInfo("Yücebağ", "76", 38.39367, 41.26713);
case 16: return new CityInfo("Yozgat", "66", 39.82, 34.80444);
case 17: return new CityInfo("Yontukyazı", "76", 37.88372, 41.32891);
case 18: return new CityInfo("Yonlyu", "63", 36.97863, 38.38274);
case 19: return new CityInfo("Yoncalı", "44", 39.00913, 38.2532);
case 20: return new CityInfo("Yolboyu", "21", 37.89764, 40.00086);
case 21: return new CityInfo("Yolbaşı", "72", 37.38717, 41.31778);
case 22: return new CityInfo("Yolağzı", "76", 37.52554, 41.3534);
case 23: return new CityInfo("Yıldızeli", "58", 39.86639, 36.59889);
case 24: return new CityInfo("Yiğityolu", "31", 35.99563, 36.26004);
case 25: return new CityInfo("Yiğitler", "17", 39.8675, 26.61111);
case 26: return new CityInfo("Yeşilyurt", "45", 38.33972, 28.66444);
case 27: return new CityInfo("Yeşilyurt", "44", 38.29602, 38.24526);
case 28: return new CityInfo("Yeşilyurt", "80", 37.30719, 42.13891);
case 29: return new CityInfo("Yeşilyurt", "48", 37.19324, 28.27537);
case 30: return new CityInfo("Yeşilyazı", "62", 39.33473, 39.08122);
case 31: return new CityInfo("Yeşilova", "75", 38.4095, 33.83804);
case 32: return new CityInfo("Yeşilova", "15", 37.50806, 29.75472);
case 33: return new CityInfo("Yeşilli", "72", 37.33813, 40.81739);
case 34: return new CityInfo("Erzin", "31", 36.95348, 36.19839);
case 35: return new CityInfo("Yeşilhisar", "38", 38.35232, 35.08873);
case 36: return new CityInfo("Misli", "73", 38.23119, 34.77671);
case 37: return new CityInfo("Yeşildere", "78", 37.15668, 33.51447);
case 38: return new CityInfo("Yeşilalan", "72", 37.46066, 40.78441);
case 39: return new CityInfo("Yeserti", "83", 36.85222, 37.84639);
case 40: return new CityInfo("Yerköy", "66", 39.63806, 34.46722);
case 41: return new CityInfo("Yerkesik", "48", 37.13625, 28.28403);
case 42: return new CityInfo("Yenişarbademli", "33", 37.70778, 31.38639);
case 43: return new CityInfo("Yenişakran", "35", 38.88639, 27.06694);
case 44: return new CityInfo("Yenipınar", "76", 37.84291, 41.30137);
case 45: return new CityInfo("Yenipazar", "66", 39.46361, 35.08306);
case 46: return new CityInfo("Yenipazar", "09", 37.82332, 28.19573);
case 47: return new CityInfo("Yenimehmetli", "68", 39.42, 32.16889);
case 48: return new CityInfo("Yenilmez", "72", 37.50887, 40.98989);
case 49: return new CityInfo("Yeniköy", "10", 39.77874, 28.00299);
case 50: return new CityInfo("Yeniköy", "76", 37.88042, 41.05004);
case 51: return new CityInfo("Yenicekale", "46", 37.59874, 36.63264);
case 52: return new CityInfo("Yeniköy", "80", 37.27074, 42.42472);
case 53: return new CityInfo("Didim", "09", 37.38496, 27.25643);
case 54: return new CityInfo("Yenifoça", "35", 38.73333, 26.83333);
case 55: return new CityInfo("Yenifakılı", "66", 39.21142, 35.00036);
case 56: return new CityInfo("Altpınar", "68", 39.20417, 32.74778);
case 57: return new CityInfo("Yeniceoba", "71", 38.86972, 32.78833);
case 58: return new CityInfo("Yenice", "17", 39.93083, 27.25806);
case 59: return new CityInfo("Yenice", "16", 39.76089, 28.90729);
case 60: return new CityInfo("Yenice", "09", 37.82837, 28.57115);
case 61: return new CityInfo("Yenice", "32", 36.97744, 35.05197);
case 62: return new CityInfo("Yenibaşak", "12", 38.80414, 40.99222);
case 63: return new CityInfo("Yeniaydın", "74", 37.8802, 42.43493);
case 64: return new CityInfo("Yelkesen", "74", 37.65809, 41.9812);
case 65: return new CityInfo("Reşadiye", "13", 38.48879, 42.53501);
case 66: return new CityInfo("Yediyol", "63", 36.99116, 38.9314);
case 67: return new CityInfo("Yeditepe", "31", 35.96753, 36.01452);
case 68: return new CityInfo("Yedisu", "12", 39.43277, 40.53368);
case 69: return new CityInfo("Yazyurdu", "58", 38.79926, 36.9319);
case 70: return new CityInfo("Yazman", "72", 37.24703, 41.76166);
case 71: return new CityInfo("Yazıhan", "44", 38.59292, 38.17327);
case 72: return new CityInfo("Yayvantepe", "72", 37.30131, 41.52061);
case 73: return new CityInfo("Yaylı", "72", 37.20293, 40.75375);
case 74: return new CityInfo("Yaylak", "63", 37.38268, 38.33892);
case 75: return new CityInfo("Yayladere", "12", 39.22614, 40.0695);
case 76: return new CityInfo("Yayladağı", "31", 35.9025, 36.06272);
case 77: return new CityInfo("Yaylacık", "72", 37.43748, 40.68588);
case 78: return new CityInfo("Yayla", "12", 38.63092, 40.52793);
case 79: return new CityInfo("Yaygın", "49", 38.89748, 41.30613);
case 80: return new CityInfo("Yavuzeli", "83", 37.31772, 37.56824);
case 81: return new CityInfo("Yavşan", "80", 37.20023, 41.98471);
case 82: return new CityInfo("Yavu", "58", 39.79202, 36.20603);
case 83: return new CityInfo("Yatağan", "48", 37.34025, 28.14279);
case 84: return new CityInfo("Yaşarköy", "72", 37.08428, 40.54237);
case 85: return new CityInfo("Yarpuzlu", "02", 38.05414, 38.5213);
case 86: return new CityInfo("Yarpuz", "91", 37.04824, 36.43066);
case 87: return new CityInfo("Yarma", "71", 37.81149, 32.88278);
case 88: return new CityInfo("Yarımtepe", "63", 36.70889, 39.28972);
case 89: return new CityInfo("Yardımcı", "63", 37.02091, 39.00533);
case 90: return new CityInfo("Yarbaşı", "80", 37.39135, 41.86528);
case 91: return new CityInfo("Yarbasan", "45", 38.98889, 28.80806);
case 92: return new CityInfo("Yapraktepe", "74", 37.82007, 42.7839);
case 93: return new CityInfo("Yaprakbaşı", "21", 37.65409, 40.54635);
case 94: return new CityInfo("Yanarsu", "74", 38.03641, 41.55227);
case 95: return new CityInfo("Yamaç", "12", 38.77623, 40.43894);
case 96: return new CityInfo("Yalvaç", "33", 38.29556, 31.17778);
case 97: return new CityInfo("Yalınca", "65", 37.85657, 43.5223);
case 98: return new CityInfo("Yalıkavak", "48", 37.10528, 27.29722);
case 99: return new CityInfo("Yalıhüyük", "71", 37.30077, 32.08548);
case 100: return new CityInfo("Yalangöz", "31", 36.5768, 36.50766);
case 101: return new CityInfo("Yakapınar", "81", 36.97342, 35.62043);
case 102: return new CityInfo("Yakacık", "83", 36.89573, 37.54227);
case 103: return new CityInfo("Payas", "31", 36.756, 36.21432);
case 104: return new CityInfo("Yahyalı", "38", 38.10228, 35.35704);
case 105: return new CityInfo("Yahşihan", "79", 39.85028, 33.45294);
case 106: return new CityInfo("Yağcılar", "10", 39.41712, 28.38109);
case 107: return new CityInfo("Viranşehir", "63", 37.22349, 39.75519);
case 108: return new CityInfo("Varto", "49", 39.17375, 41.45402);
case 109: return new CityInfo("Varımlı", "72", 37.18914, 41.83389);
case 110: return new CityInfo("Van", "65", 38.49457, 43.38323);
case 111: return new CityInfo("Uzunkuyu", "35", 38.27858, 26.54315);
case 112: return new CityInfo("Uzungeçit", "80", 37.49052, 42.99036);
case 113: return new CityInfo("Cimin", "24", 39.70947, 39.70015);
case 114: return new CityInfo("Üzümlü", "71", 37.54057, 31.6038);
case 115: return new CityInfo("Yeşilüzümlü", "48", 36.73361, 29.23333);
case 116: return new CityInfo("Uşak", "64", 38.67351, 29.4058);
case 117: return new CityInfo("Urla", "35", 38.32292, 26.76403);
case 118: return new CityInfo("Ürgüp", "50", 38.6296, 34.91199);
case 119: return new CityInfo("Şanlıurfa", "63", 37.16708, 38.79392);
case 120: return new CityInfo("Umurlu", "09", 37.85003, 27.96275);
case 121: return new CityInfo("Umraniye", "03", 39.175, 31.23444);
case 122: return new CityInfo("Uluyatır", "83", 36.96333, 37.69361);
case 123: return new CityInfo("Ulukışla", "73", 37.54776, 34.48528);
case 124: return new CityInfo("Uludere", "80", 37.44074, 42.85236);
case 125: return new CityInfo("Arsuz", "31", 36.41305, 35.89033);
case 126: return new CityInfo("Uluborlu", "33", 38.07825, 30.45019);
case 127: return new CityInfo("Ulubey", "64", 38.41987, 29.29129);
case 128: return new CityInfo("Uluağaç", "63", 36.84361, 39.13889);
case 129: return new CityInfo("Ulaş", "58", 39.44492, 37.039);
case 130: return new CityInfo("Ulak", "80", 37.27221, 41.80078);
case 131: return new CityInfo("Ula", "48", 37.10491, 28.41667);
case 132: return new CityInfo("Uğrak", "72", 37.19722, 41.76479);
case 133: return new CityInfo("Kerh", "21", 37.8257, 40.54402);
case 134: return new CityInfo("Üçpınar", "71", 37.13413, 32.26146);
case 135: return new CityInfo("Reshidi", "72", 37.49471, 40.96806);
case 136: return new CityInfo("Üçdam", "62", 39.56308, 40.1757);
case 137: return new CityInfo("Tuzlukçu", "71", 38.47778, 31.62639);
case 138: return new CityInfo("Melefan", "76", 38.18022, 41.5687);
case 139: return new CityInfo("Tutak", "04", 39.53854, 42.76587);
case 140: return new CityInfo("Tut", "02", 37.79529, 37.9161);
case 141: return new CityInfo("Turunçova", "07", 36.36889, 30.1375);
case 142: return new CityInfo("Türkoğlu", "46", 37.38649, 36.84262);
case 143: return new CityInfo("Türkmenhacı", "21", 37.80668, 40.61117);
case 144: return new CityInfo("Turgutlu", "45", 38.49533, 27.6997);
case 145: return new CityInfo("Turgut", "71", 38.62694, 31.81083);
case 146: return new CityInfo("Turgut", "48", 37.375, 28.03111);
case 147: return new CityInfo("Tunceli", "62", 39.09921, 39.54351);
case 148: return new CityInfo("Sütlüce", "62", 39.16228, 39.544);
case 149: return new CityInfo("Tufanbeyli", "81", 38.26333, 36.22056);
case 150: return new CityInfo("Torbalı", "35", 38.1519, 27.36223);
case 151: return new CityInfo("Toptepe", "72", 37.26113, 41.24948);
case 152: return new CityInfo("Toprakkale", "91", 37.06855, 36.14661);
case 153: return new CityInfo("Topaklı", "50", 39.00555, 34.82644);
case 154: return new CityInfo("Pınarbaşı", "32", 36.7034, 34.3627);
case 155: return new CityInfo("Tomarza", "38", 38.44722, 35.79917);
case 156: return new CityInfo("Tokluca", "72", 37.58422, 41.03675);
case 157: return new CityInfo("Toklar", "38", 38.41806, 36.015);
case 158: return new CityInfo("Tire", "35", 38.08877, 27.73508);
case 159: return new CityInfo("Tercan", "24", 39.77709, 40.37783);
case 160: return new CityInfo("Telminar", "72", 37.11129, 41.38359);
case 161: return new CityInfo("Tepeköy", "80", 37.2997, 41.82465);
case 162: return new CityInfo("Tepehan", "44", 38.11788, 38.72622);
case 163: return new CityInfo("Tepecikören", "81", 37.36135, 35.62627);
case 164: return new CityInfo("Tepecik", "09", 37.82358, 27.87496);
case 165: return new CityInfo("Tepebaşı", "78", 36.66628, 32.72214);
case 166: return new CityInfo("Tepealtı", "72", 37.09595, 41.36834);
case 167: return new CityInfo("Tepe", "21", 37.78943, 40.77161);
case 168: return new CityInfo("Temelli", "68", 39.7275, 32.35528);
case 169: return new CityInfo("Temelli", "72", 37.57574, 41.84564);
case 170: return new CityInfo("Küplüce", "63", 36.8125, 39.02167);
case 171: return new CityInfo("Tekman", "25", 39.64111, 41.50542);
case 172: return new CityInfo("Tekirova", "07", 36.5017, 30.52723);
case 173: return new CityInfo("Tefenni", "15", 37.30968, 29.77538);
case 174: return new CityInfo("Tecirli", "91", 37.16183, 36.10978);
case 175: return new CityInfo("Tavşanlı", "43", 39.54237, 29.49866);
case 176: return new CityInfo("Tavas", "20", 37.57351, 29.07058);
case 177: return new CityInfo("Tatvan", "13", 38.49221, 42.28269);
case 178: return new CityInfo("Taşucu", "32", 36.3214, 33.88165);
case 179: return new CityInfo("Taşpınar", "75", 38.17963, 34.02499);
case 180: return new CityInfo("Taşlıçay", "04", 39.62966, 43.36878);
case 181: return new CityInfo("Taşlı", "74", 37.98699, 42.1351);
case 182: return new CityInfo("Taşkent", "71", 36.9243, 32.49131);
case 183: return new CityInfo("Taşdibek", "74", 37.95031, 42.29518);
case 184: return new CityInfo("Taşdelen", "44", 38.8381, 38.50457);
case 185: return new CityInfo("Taşdelen", "80", 37.37864, 42.86866);
case 186: return new CityInfo("Bakırdağı", "38", 38.21597, 35.79021);
case 187: return new CityInfo("Kelitan", "70", 37.40792, 43.45706);
case 188: return new CityInfo("Taşağıl", "07", 36.9224, 31.23608);
case 189: return new CityInfo("Tarsus", "32", 36.91766, 34.89277);
case 190: return new CityInfo("Taraksu", "02", 38.15416, 39.14837);
case 191: return new CityInfo("Taraksu", "02", 38.01667, 39.08333);
case 192: return new CityInfo("Tanyeri", "24", 39.61137, 39.83151);
case 193: return new CityInfo("Tanır", "46", 38.41944, 36.91222);
case 194: return new CityInfo("Talas", "38", 38.6908, 35.5538);
case 195: return new CityInfo("Tahtaköprü", "16", 39.95, 29.65);
case 196: return new CityInfo("Tahir", "04", 39.85586, 42.42834);
case 197: return new CityInfo("Suvarlı", "02", 37.53867, 37.6321);
case 198: return new CityInfo("Şenocak", "72", 37.65035, 40.69441);
case 199: return new CityInfo("Pavlu Cebel", "33", 37.49737, 30.97727);
case 200: return new CityInfo("Susurluk", "10", 39.91361, 28.15778);
case 201: return new CityInfo("Suruç", "63", 36.97612, 38.42533);
case 202: return new CityInfo("Avine", "72", 37.57373, 40.73252);
case 203: return new CityInfo("Sürgü", "44", 38.00548, 37.9635);
case 204: return new CityInfo("Sulusaray", "60", 39.99389, 36.08404);
case 205: return new CityInfo("Sülüklü", "71", 38.88111, 32.3425);
case 206: return new CityInfo("Suluçem", "04", 39.69386, 43.81472);
case 207: return new CityInfo("Sultanhisar", "09", 37.88989, 28.15436);
case 208: return new CityInfo("Sultanhanı", "75", 38.2471, 33.54961);
case 209: return new CityInfo("Sultandağı", "03", 38.53111, 31.22806);
case 210: return new CityInfo("Süleymanlı", "46", 37.87264, 36.81714);
case 211: return new CityInfo("Sulak", "80", 37.41342, 41.96114);
case 212: return new CityInfo("Sulak", "80", 37.29458, 42.13637);
case 213: return new CityInfo("Şuhut", "03", 38.53111, 30.54583);
case 214: return new CityInfo("Sugeldi", "63", 36.81361, 39.04333);
case 215: return new CityInfo("Suçatı", "72", 37.58832, 41.76815);
case 216: return new CityInfo("Sözveren", "65", 37.99065, 43.07886);
case 217: return new CityInfo("Soylu", "72", 37.65035, 40.81601);
case 218: return new CityInfo("Sorgun", "66", 39.81012, 35.18596);
case 219: return new CityInfo("Soma", "45", 39.18554, 27.60945);
case 220: return new CityInfo("Solhan", "12", 38.96525, 41.05443);
case 221: return new CityInfo("Söke", "09", 37.7482, 27.40614);
case 222: return new CityInfo("Söğütlü", "12", 38.80019, 40.66971);
case 223: return new CityInfo("Kindirip", "72", 37.44706, 41.21976);
case 224: return new CityInfo("Söğüt", "11", 40.0143, 30.18486);
case 225: return new CityInfo("Sivrihisar", "26", 39.45037, 31.53409);
case 226: return new CityInfo("Sivrice", "23", 38.44223, 39.30938);
case 227: return new CityInfo("Sivrice", "72", 37.27675, 41.33569);
case 228: return new CityInfo("Siverek", "63", 37.75503, 39.31667);
case 229: return new CityInfo("Sivaslı", "64", 38.49944, 29.68361);
case 230: return new CityInfo("Sivas", "58", 39.74833, 37.01611);
case 231: return new CityInfo("Şirvan", "74", 38.06251, 42.02517);
case 232: return new CityInfo("Tililan", "80", 37.37428, 42.03386);
case 233: return new CityInfo("Şırnak", "80", 37.51393, 42.45432);
case 234: return new CityInfo("Sındırgı", "10", 39.24128, 28.17842);
case 235: return new CityInfo("Yenice", "68", 39.27528, 32.68028);
case 236: return new CityInfo("Sincik", "02", 38.03645, 38.61257);
case 237: return new CityInfo("Sincan", "58", 39.47167, 37.87083);
case 238: return new CityInfo("Sinanpaşa", "03", 38.74444, 30.24278);
case 239: return new CityInfo("Sinanköy", "21", 37.86166, 40.99283);
case 240: return new CityInfo("Simav", "43", 39.0882, 28.97767);
case 241: return new CityInfo("Silvan", "21", 38.13708, 41.00817);
case 242: return new CityInfo("Silopi", "80", 37.24379, 42.46345);
case 243: return new CityInfo("Sille", "71", 37.92731, 32.41995);
case 244: return new CityInfo("Silifke", "32", 36.37778, 33.93444);
case 245: return new CityInfo("Siirt", "74", 37.9293, 41.94134);
case 246: return new CityInfo("Seyitgazi", "26", 39.44472, 30.69472);
case 247: return new CityInfo("Erenkaya", "80", 37.63514, 42.06296);
case 248: return new CityInfo("Ortaköy", "80", 37.22054, 41.93973);
case 249: return new CityInfo("Seyhan", "81", 36.98747, 35.30592);
case 250: return new CityInfo("Seydişehir", "71", 37.41926, 31.84527);
case 251: return new CityInfo("Sevinç", "26", 39.78, 30.68889);
case 252: return new CityInfo("Servi", "12", 38.57038, 40.32004);
case 253: return new CityInfo("Serinyol", "31", 36.36139, 36.21361);
case 254: return new CityInfo("Serik", "07", 36.91694, 31.09889);
case 255: return new CityInfo("Şereflikoçhisar", "68", 38.93925, 33.5386);
case 256: return new CityInfo("Şenyurt", "72", 37.07932, 40.64246);
case 257: return new CityInfo("Şenoba", "80", 37.46436, 42.72248);
case 258: return new CityInfo("Ebish", "72", 37.46347, 41.18863);
case 259: return new CityInfo("Şenköy", "31", 36.04841, 36.14366);
case 260: return new CityInfo("Senirkent", "33", 38.10444, 30.54861);
case 261: return new CityInfo("Şemdinli", "70", 37.30514, 44.5742);
case 262: return new CityInfo("Selimiye", "48", 37.40035, 27.65543);
case 263: return new CityInfo("Side", "07", 36.76667, 31.38889);
case 264: return new CityInfo("Selendi", "45", 38.74444, 28.86778);
case 265: return new CityInfo("Selçuk", "35", 37.95137, 27.36849);
case 266: return new CityInfo("Selçikler", "64", 38.49837, 29.65482);
case 267: return new CityInfo("Selalmaz", "63", 36.81178, 39.13359);
case 268: return new CityInfo("Seksenören", "63", 36.97252, 39.07484);
case 269: return new CityInfo("Sekili", "83", 36.97876, 37.67174);
case 270: return new CityInfo("Seki", "48", 36.80378, 29.65155);
case 271: return new CityInfo("Şekerli", "63", 37.5705, 39.3872);
case 272: return new CityInfo("Şehit Nusretbey", "63", 36.84667, 38.73583);
case 273: return new CityInfo("Seferihisar", "35", 38.1975, 26.83881);
case 274: return new CityInfo("Şefaatlı", "66", 39.5043, 34.7563);
case 275: return new CityInfo("Savur", "72", 37.53544, 40.87876);
case 276: return new CityInfo("Savcılı", "40", 39.22889, 33.68139);
case 277: return new CityInfo("Kayacık", "21", 38.34142, 40.61336);
case 278: return new CityInfo("Savaştepe", "10", 39.38319, 27.65612);
case 279: return new CityInfo("Sason", "76", 38.32767, 41.41377);
case 280: return new CityInfo("Saruhanlı", "45", 38.73455, 27.56811);
case 281: return new CityInfo("Edremit", "65", 38.42069, 43.25889);
case 282: return new CityInfo("Şarkışla", "58", 39.35186, 36.40976);
case 283: return new CityInfo("Şarkîkaraağaç", "33", 38.07944, 31.36639);
case 284: return new CityInfo("Sarız", "38", 38.47917, 36.49898);
case 285: return new CityInfo("Sarıyahşi", "75", 38.98349, 33.84136);
case 286: return new CityInfo("Sarıveliler", "78", 36.69705, 32.61203);
case 287: return new CityInfo("Sarısu", "04", 39.01887, 42.92092);
case 288: return new CityInfo("Sarıoğlan", "38", 39.07694, 35.96671);
case 289: return new CityInfo("Seri", "72", 37.36001, 41.30055);
case 290: return new CityInfo("Sarıkonak", "13", 38.24309, 41.95933);
case 291: return new CityInfo("Sarıkemer", "09", 37.56609, 27.3643);
case 292: return new CityInfo("Sarıkaya", "66", 39.49361, 35.37694);
case 293: return new CityInfo("Sarıgöl", "45", 38.23953, 28.69663);
case 294: return new CityInfo("Sarıçam", "81", 37.15172, 35.50769);
case 295: return new CityInfo("Sarıbeyler", "10", 39.39833, 27.57722);
case 296: return new CityInfo("Sarayönü", "71", 38.26201, 32.40457);
case 297: return new CityInfo("Sarayköy", "20", 37.92448, 28.92516);
case 298: return new CityInfo("Saraykent", "66", 39.69361, 35.51111);
case 299: return new CityInfo("Saray", "65", 38.64691, 44.16116);
case 300: return new CityInfo("Şaphane", "43", 39.0273, 29.22218);
case 301: return new CityInfo("Sandıklı", "03", 38.46472, 30.26946);
case 302: return new CityInfo("Sancarlı", "72", 37.26067, 40.63492);
case 303: return new CityInfo("Sancak", "12", 39.09222, 40.38753);
case 304: return new CityInfo("Samsat", "02", 37.58194, 38.47417);
case 305: return new CityInfo("Şamlı", "10", 39.81184, 27.84559);
case 306: return new CityInfo("Şambayat", "02", 37.68441, 38.04676);
case 307: return new CityInfo("Samandağ", "31", 36.08012, 35.97603);
case 308: return new CityInfo("Salihli", "45", 38.48258, 28.14774);
case 309: return new CityInfo("Salavatlı", "09", 37.89123, 28.10333);
case 310: return new CityInfo("Sakçagöz", "83", 37.17152, 36.91632);
case 311: return new CityInfo("Saipbeyli", "74", 37.99757, 41.51046);
case 312: return new CityInfo("Saimbeyli", "81", 37.98632, 36.09056);
case 313: return new CityInfo("Sağkaya", "81", 37.17852, 35.68843);
case 314: return new CityInfo("Simos", "13", 38.05731, 42.58375);
case 315: return new CityInfo("Sabuncu", "43", 39.56131, 30.18813);
case 316: return new CityInfo("Reyhanlı", "31", 36.26791, 36.56747);
case 317: return new CityInfo("Reis", "71", 38.27139, 31.57139);
case 318: return new CityInfo("Refahiye", "24", 39.89315, 38.76607);
case 319: return new CityInfo("Pütürge", "44", 38.19923, 38.86296);
case 320: return new CityInfo("Pulumer", "62", 39.48449, 39.89532);
case 321: return new CityInfo("Pozantı", "81", 37.42778, 34.87167);
case 322: return new CityInfo("Poyraz", "23", 38.68596, 39.023);
case 323: return new CityInfo("Polatlı", "68", 39.57715, 32.14132);
case 324: return new CityInfo("Pirinçli", "80", 37.52169, 43.03593);
case 325: return new CityInfo("Razvaliny Ayinvan", "80", 37.27983, 42.33427);
case 326: return new CityInfo("Pınarlar", "62", 38.87424, 39.47263);
case 327: return new CityInfo("Pınardere", "72", 37.47231, 40.83402);
case 328: return new CityInfo("Pınarbaşı", "38", 38.72285, 36.39314);
case 329: return new CityInfo("Pınarbaşı", "80", 37.21368, 41.88689);
case 330: return new CityInfo("Pervari", "74", 37.93573, 42.54927);
case 331: return new CityInfo("Pertek", "62", 38.86574, 39.32273);
case 332: return new CityInfo("Akpazar", "62", 38.84625, 39.66833);
case 333: return new CityInfo("Pazaryeri", "11", 39.99395, 29.90424);
case 334: return new CityInfo("Pazarören", "38", 38.67389, 36.15944);
case 335: return new CityInfo("Pazarlar", "43", 38.995, 29.12583);
case 336: return new CityInfo("Pazarköy", "17", 39.8532, 27.40299);
case 337: return new CityInfo("Pazarcık", "46", 37.48685, 37.29961);
case 338: return new CityInfo("Payallar", "07", 36.6016, 31.85057);
case 339: return new CityInfo("Patnos", "04", 39.22493, 42.85693);
case 340: return new CityInfo("Pasinler", "25", 39.97975, 41.66997);
case 341: return new CityInfo("Parapara", "63", 36.94729, 38.94564);
case 342: return new CityInfo("Pamukören", "09", 37.92317, 28.54175);
case 343: return new CityInfo("Pamukkale", "20", 37.91644, 29.11729);
case 344: return new CityInfo("Palu", "23", 38.69135, 39.91984);
case 345: return new CityInfo("Palamutlu", "74", 37.89583, 42.2025);
case 346: return new CityInfo("Özpınar", "74", 38.00478, 42.24386);
case 347: return new CityInfo("Özonak", "50", 38.81213, 34.84096);
case 348: return new CityInfo("Ozan", "80", 37.26274, 41.97891);
case 349: return new CityInfo("Özdere", "35", 38.01611, 27.12806);
case 350: return new CityInfo("Özbek", "72", 37.17704, 41.69322);
case 351: return new CityInfo("Ozanlar", "63", 36.945, 38.89889);
case 352: return new CityInfo("Özalp", "65", 38.65455, 43.98869);
case 353: return new CityInfo("Oymataş", "76", 37.79856, 41.02083);
case 354: return new CityInfo("Oymakaya", "80", 37.42341, 43.23137);
case 355: return new CityInfo("Oymak", "80", 37.2523, 41.86198);
case 356: return new CityInfo("Oyalı", "72", 37.22126, 41.73862);
case 357: return new CityInfo("Övecek", "74", 37.90403, 42.88434);
case 358: return new CityInfo("Ovakışla", "13", 38.81733, 42.31643);
case 359: return new CityInfo("Ovakent", "35", 38.10722, 28.02111);
case 360: return new CityInfo("Ovakavağı", "71", 37.71079, 32.93482);
case 361: return new CityInfo("Ovacık", "62", 39.35259, 39.2089);
case 362: return new CityInfo("Ovacık", "63", 37.51343, 38.77933);
case 363: return new CityInfo("Ovabağ", "21", 37.70849, 39.98697);
case 364: return new CityInfo("Otlukbeli", "24", 39.97, 40.01872);
case 365: return new CityInfo("Osmanpaşa", "66", 39.62472, 34.96472);
case 366: return new CityInfo("Osmaniye", "91", 37.07417, 36.24778);
case 367: return new CityInfo("Osmancalı", "45", 38.7625, 27.25306);
case 368: return new CityInfo("Ortasu", "80", 37.36845, 42.95806);
case 369: return new CityInfo("Ortaköy", "58", 39.42153, 36.23403);
case 370: return new CityInfo("Ortaköy", "75", 38.73728, 34.03866);
case 371: return new CityInfo("Ortaköy", "80", 37.32745, 43.28403);
case 372: return new CityInfo("Ortaköy", "72", 37.22089, 40.78476);
case 373: return new CityInfo("Ortaköy", "80", 37.19771, 42.44731);
case 374: return new CityInfo("Ortaklar", "09", 37.88788, 27.50234);
case 375: return new CityInfo("Ortyakent Yahşi", "48", 37.04944, 27.34833);
case 376: return new CityInfo("Ortaca", "72", 37.47394, 41.55598);
case 377: return new CityInfo("Ortaca", "48", 36.83915, 28.76457);
case 378: return new CityInfo("Ortabağ", "80", 37.39671, 42.9101);
case 379: return new CityInfo("Orhaneli", "16", 39.90333, 28.99056);
case 380: return new CityInfo("Örenşehir", "38", 38.99843, 36.64929);
case 381: return new CityInfo("Örencik", "43", 39.2625, 29.54389);
case 382: return new CityInfo("Ören", "48", 37.03609, 27.96723);
case 383: return new CityInfo("Örenlı", "63", 36.97661, 39.27763);
case 384: return new CityInfo("Öncül", "63", 36.71222, 39.02917);
case 385: return new CityInfo("Ömerli", "72", 37.39903, 40.95442);
case 386: return new CityInfo("Ömerköy", "10", 39.83063, 28.06682);
case 387: return new CityInfo("Okçular", "74", 37.74152, 42.44075);
case 388: return new CityInfo("Oğuzeli", "83", 36.96572, 37.51339);
case 389: return new CityInfo("Oğuz", "24", 39.5059, 38.88369);
case 390: return new CityInfo("Oğuz", "76", 37.81487, 41.37425);
case 391: return new CityInfo("Dara", "72", 37.17902, 40.95455);
case 392: return new CityInfo("Ödemiş", "35", 38.2278, 27.96955);
case 393: return new CityInfo("Obruk", "71", 38.18444, 33.18095);
case 394: return new CityInfo("Nusaybin", "72", 37.07028, 41.21465);
case 395: return new CityInfo("Nurhak", "46", 37.96366, 37.44047);
case 396: return new CityInfo("Nurettin", "49", 39.28104, 42.50746);
case 397: return new CityInfo("Nurettin", "49", 39.22883, 42.41832);
case 398: return new CityInfo("Nizip", "83", 37.00972, 37.79417);
case 399: return new CityInfo("Nimet", "63", 36.77455, 38.72686);
case 400: return new CityInfo("Niğde", "73", 37.96583, 34.67935);
case 401: return new CityInfo("Nevşehir", "50", 38.625, 34.71222);
case 402: return new CityInfo("Nazimiye", "62", 39.17986, 39.82843);
case 403: return new CityInfo("Nazilli", "09", 37.91631, 28.32225);
case 404: return new CityInfo("Demirci", "63", 37.41269, 39.76838);
case 405: return new CityInfo("Narlıdere", "13", 38.2268, 41.89014);
case 406: return new CityInfo("Narlı", "74", 37.88449, 42.97597);
case 407: return new CityInfo("Narlı", "46", 37.39148, 37.13614);
case 408: return new CityInfo("Narince", "02", 37.88253, 38.7592);
case 409: return new CityInfo("Mutki", "13", 38.40624, 41.92018);
case 410: return new CityInfo("Mut", "32", 36.64389, 33.43885);
case 411: return new CityInfo("Musabeyli", "66", 39.83306, 34.62306);
case 412: return new CityInfo("Musabeyli", "90", 36.88639, 36.91861);
case 413: return new CityInfo("Muş", "49", 38.73163, 41.48482);
case 414: return new CityInfo("Mürşitpınar", "63", 36.903, 38.34746);
case 415: return new CityInfo("Mursal", "58", 39.16778, 37.95694);
case 416: return new CityInfo("Muratlı", "63", 36.96167, 40.10056);
case 417: return new CityInfo("Murat", "04", 39.67281, 43.23952);
case 418: return new CityInfo("Muradiye", "65", 38.98568, 43.7531);
case 419: return new CityInfo("Muradiye", "45", 38.66025, 27.33836);
case 420: return new CityInfo("Muncusun", "38", 38.90253, 35.62743);
case 421: return new CityInfo("Karaova", "48", 37.10699, 27.66578);
case 422: return new CityInfo("Muğla", "48", 37.21807, 28.3665);
case 423: return new CityInfo("Mucur", "40", 39.06147, 34.38286);
case 424: return new CityInfo("Mordoğan", "35", 38.51624, 26.62487);
case 425: return new CityInfo("Elmalıdere", "25", 39.63721, 42.31996);
case 426: return new CityInfo("Mollakendi", "23", 38.57735, 39.33292);
case 427: return new CityInfo("Akçayır", "21", 37.99127, 40.99007);
case 428: return new CityInfo("Minare", "63", 36.93083, 39.00444);
case 429: return new CityInfo("Balveren", "80", 37.48357, 42.54834);
case 430: return new CityInfo("Milas", "48", 37.31639, 27.78389);
case 431: return new CityInfo("Milköy", "63", 36.84389, 38.78472);
case 432: return new CityInfo("Mihalıçcık", "26", 39.86594, 31.49572);
case 433: return new CityInfo("Midyat", "72", 37.41908, 41.33909);
case 434: return new CityInfo("Bademli", "21", 37.92572, 40.96111);
case 435: return new CityInfo("Mezraa", "62", 39.3859, 39.82439);
case 436: return new CityInfo("Mezraa", "80", 37.66257, 43.18885);
case 437: return new CityInfo("Mezitli", "32", 36.74541, 34.52256);
case 438: return new CityInfo("Meydanlık", "21", 37.75429, 40.65174);
case 439: return new CityInfo("Meydankapı", "63", 36.78278, 39.15833);
case 440: return new CityInfo("Meydandere", "74", 37.92552, 42.0965);
case 441: return new CityInfo("Meydan", "13", 38.35585, 41.76941);
case 442: return new CityInfo("Söylemez", "25", 39.76045, 41.80153);
case 443: return new CityInfo("Mersin", "32", 36.81196, 34.63886);
case 444: return new CityInfo("Mermer", "21", 38.11828, 40.44874);
case 445: return new CityInfo("Mercimekkale", "49", 38.92945, 41.50325);
case 446: return new CityInfo("Meram", "71", 37.82985, 32.46777);
case 447: return new CityInfo("Menemen", "35", 38.60754, 27.06938);
case 448: return new CityInfo("Uysallı", "63", 36.951, 38.38237);
case 449: return new CityInfo("Mazıdağı", "72", 37.47801, 40.48152);
case 450: return new CityInfo("Mazgirt", "62", 39.01783, 39.60064);
case 451: return new CityInfo("Marmaris", "48", 36.855, 28.27417);
case 452: return new CityInfo("Mardin", "72", 37.31309, 40.74357);
case 453: return new CityInfo("Mansurlu", "81", 37.84853, 35.65436);
case 454: return new CityInfo("Manisa", "45", 38.61202, 27.42647);
case 455: return new CityInfo("Manavgat", "07", 36.78667, 31.44306);
case 456: return new CityInfo("Mamak", "68", 39.94044, 32.91012);
case 457: return new CityInfo("Malazgirt", "49", 39.1465, 42.53536);
case 458: return new CityInfo("Malatya", "44", 38.35018, 38.31667);
case 459: return new CityInfo("Mahmutlar", "07", 36.49463, 32.09085);
case 460: return new CityInfo("Mahmudiye", "26", 39.49778, 30.98722);
case 461: return new CityInfo("Mağaralı", "63", 36.96889, 38.07444);
case 462: return new CityInfo("Kırobası", "32", 36.7224, 33.86711);
case 463: return new CityInfo("Maden", "23", 38.38669, 39.66408);
case 464: return new CityInfo("Lice", "21", 38.45821, 40.63888);
case 465: return new CityInfo("Levent", "44", 38.43704, 37.85425);
case 466: return new CityInfo("Kuzucubelen", "32", 36.83996, 34.43765);
case 467: return new CityInfo("Kuyulusebil", "71", 38.65389, 32.52972);
case 468: return new CityInfo("Kuyulu", "72", 37.15841, 40.79279);
case 469: return new CityInfo("Kuyucak", "09", 37.9133, 28.45917);
case 470: return new CityInfo("Kuyucak", "02", 37.86306, 38.34365);
case 471: return new CityInfo("Kutlubey", "72", 37.30719, 41.1772);
case 472: return new CityInfo("Kütahya", "43", 39.42417, 29.98333);
case 473: return new CityInfo("Kuşsarayı", "23", 38.45121, 38.67912);
case 474: return new CityInfo("Kuşkayası", "58", 39.06076, 37.07929);
case 475: return new CityInfo("Kuşadası", "09", 37.86014, 27.25713);
case 476: return new CityInfo("Kuruçay", "24", 39.64024, 38.47422);
case 477: return new CityInfo("Kurthasanlı", "71", 38.32611, 32.17528);
case 478: return new CityInfo("Kurtalan", "74", 37.92533, 41.68493);
case 479: return new CityInfo("Kurşunlu", "44", 38.65328, 37.85081);
case 480: return new CityInfo("Sarıkavak", "32", 36.58127, 33.64299);
case 481: return new CityInfo("Beykonak", "07", 36.32573, 30.30302);
case 482: return new CityInfo("Kumluca", "07", 36.37028, 30.28694);
case 483: return new CityInfo("Kumlu", "72", 37.17222, 40.73536);
case 484: return new CityInfo("Kumlu", "31", 36.36353, 36.45502);
case 485: return new CityInfo("Kumköy", "07", 36.88286, 30.95178);
case 486: return new CityInfo("Kumdanlı", "33", 38.3239, 30.9764);
case 487: return new CityInfo("Kumçatı", "80", 37.46594, 42.28791);
case 488: return new CityInfo("Kuluncak", "44", 38.87656, 37.66279);
case 489: return new CityInfo("Kulu", "71", 39.09513, 33.07989);
case 490: return new CityInfo("Kulp", "21", 38.49754, 41.00668);
case 491: return new CityInfo("Kula", "45", 38.54726, 28.64976);
case 492: return new CityInfo("Küçük Ziyaret", "63", 36.9431, 38.46164);
case 493: return new CityInfo("Kotum", "13", 38.43899, 42.31905);
case 494: return new CityInfo("Küçükkuyu", "17", 39.54889, 26.60528);
case 495: return new CityInfo("Denizgiren", "35", 38.55734, 26.39305);
case 496: return new CityInfo("Kozluk", "76", 38.19118, 41.47775);
case 497: return new CityInfo("Kozlu", "76", 37.63727, 41.36876);
case 498: return new CityInfo("Kozan", "81", 37.45517, 35.81573);
case 499: return new CityInfo("Kozaklı", "50", 39.22139, 34.85056);
case 500: return new CityInfo("Köyceğiz", "72", 37.17839, 41.87878);
case 501: return new CityInfo("Kovancılar", "23", 38.71882, 39.86268);
case 502: return new CityInfo("Kösreli", "81", 37.1625, 35.97834);
case 503: return new CityInfo("Köşk", "09", 37.85333, 28.05167);
case 504: return new CityInfo("Kösetarla", "76", 37.88944, 41.19889);
case 505: return new CityInfo("Köseli", "21", 37.83879, 40.60811);
case 506: return new CityInfo("Kösefakılı", "40", 39.59386, 34.13625);
case 507: return new CityInfo("Korucu", "10", 39.47028, 27.36528);
case 508: return new CityInfo("Korucu", "80", 37.23339, 42.05796);
case 509: return new CityInfo("Korkuteli", "07", 37.06498, 30.19565);
case 510: return new CityInfo("Korkut", "49", 38.7339, 41.78396);
case 511: return new CityInfo("Kopuzlu", "21", 37.95306, 40.95917);
case 512: return new CityInfo("Köprüören", "43", 39.50832, 29.76233);
case 513: return new CityInfo("Köprülü", "07", 36.7323, 32.18497);
case 514: return new CityInfo("Köprüköy", "25", 39.966, 41.86844);
case 515: return new CityInfo("Köprübaşı", "45", 38.74972, 28.40472);
case 516: return new CityInfo("Konyaaltı", "07", 36.86644, 30.63031);
case 517: return new CityInfo("Konya", "71", 37.87135, 32.48464);
case 518: return new CityInfo("Konalga", "65", 37.86035, 43.09678);
case 519: return new CityInfo("Konakpınar", "10", 39.43389, 27.83623);
case 520: return new CityInfo("Konakpınar", "58", 38.90583, 37.29694);
case 521: return new CityInfo("Konakpınar", "74", 37.92388, 41.63219);
case 522: return new CityInfo("Konaklı", "35", 38.11278, 27.99611);
case 523: return new CityInfo("Koçtepe", "80", 37.54302, 41.86666);
case 524: return new CityInfo("Göcek", "48", 36.75345, 28.94571);
case 525: return new CityInfo("Kocatepe", "72", 37.22922, 40.16104);
case 526: return new CityInfo("Koçarlı", "09", 37.76113, 27.70583);
case 527: return new CityInfo("Kocapınar", "65", 39.09553, 43.19616);
case 528: return new CityInfo("Koçali", "02", 37.92306, 38.25788);
case 529: return new CityInfo("Kocalar", "72", 37.26542, 40.64129);
case 530: return new CityInfo("Kocaköy", "21", 38.28889, 40.49786);
case 531: return new CityInfo("Kocakoç", "62", 39.11664, 39.65931);
case 532: return new CityInfo("Kocahasanlı", "32", 36.58417, 34.27359);
case 533: return new CityInfo("Kocaaliler", "15", 37.31694, 30.74);
case 534: return new CityInfo("Kızılyaka", "15", 36.98301, 29.52847);
case 535: return new CityInfo("Kızıltepe", "72", 37.18836, 40.57723);
case 536: return new CityInfo("Kızılsu", "80", 37.45402, 42.19639);
case 537: return new CityInfo("Kızılören", "03", 38.25806, 30.15167);
case 538: return new CityInfo("Kızılören", "71", 37.86847, 32.11618);
case 539: return new CityInfo("Kızılkaya", "15", 37.30361, 30.44417);
case 540: return new CityInfo("Serinhisar", "20", 37.58105, 29.26639);
case 541: return new CityInfo("Kızılcasöğüt", "64", 38.65111, 29.66611);
case 542: return new CityInfo("Kızılcadağ", "07", 37.01722, 29.96306);
case 543: return new CityInfo("Kızılcabölük", "20", 37.61191, 29.01838);
case 544: return new CityInfo("Kızılağaç", "49", 38.78019, 41.31385);
case 545: return new CityInfo("Kışlak", "31", 35.9675, 36.15749);
case 546: return new CityInfo("Kırşehir", "40", 39.14583, 34.16389);
case 547: return new CityInfo("Kırkgeçit", "65", 38.13558, 43.49387);
case 548: return new CityInfo("Kırkağaç", "45", 39.10638, 27.66925);
case 549: return new CityInfo("Kırka", "26", 39.27944, 30.52639);
case 550: return new CityInfo("Kırıkkale", "79", 39.84528, 33.50639);
case 551: return new CityInfo("Kırıkhan", "31", 36.49939, 36.35755);
case 552: return new CityInfo("Kireç", "10", 39.55517, 28.36506);
case 553: return new CityInfo("Kiraz", "35", 38.23056, 28.20444);
case 554: return new CityInfo("Kınık", "35", 39.08722, 27.38333);
case 555: return new CityInfo("Kilis", "90", 36.71611, 37.115);
case 556: return new CityInfo("Kılbasan", "78", 37.32488, 33.18634);
case 557: return new CityInfo("Kılavuz", "72", 37.4796, 41.78374);
case 558: return new CityInfo("Kasaba", "12", 39.31361, 40.35028);
case 559: return new CityInfo("Kelekli", "83", 36.915, 37.99083);
case 560: return new CityInfo("Keskin", "79", 39.67306, 33.61361);
case 561: return new CityInfo("Kepsut", "10", 39.68889, 28.15222);
case 562: return new CityInfo("Kemerhisar", "73", 37.82388, 34.57145);
case 563: return new CityInfo("Kemer", "15", 37.35222, 30.06306);
case 564: return new CityInfo("Kemer", "48", 36.6481, 29.3591);
case 565: return new CityInfo("Kemer", "07", 36.59778, 30.56056);
case 566: return new CityInfo("Kemalpaşa", "35", 38.42621, 27.41731);
case 567: return new CityInfo("Kemaliye", "24", 39.26288, 38.49674);
case 568: return new CityInfo("Kemah", "24", 39.59606, 39.02329);
case 569: return new CityInfo("Keles", "16", 39.91361, 29.22944);
case 570: return new CityInfo("Kelekçi", "20", 37.24073, 29.30425);
case 571: return new CityInfo("Keçikıran", "63", 36.96611, 38.98472);
case 572: return new CityInfo("Keçiborlu", "33", 37.9425, 30.30222);
case 573: return new CityInfo("Keban", "23", 38.7938, 38.73517);
case 574: return new CityInfo("Kazımkarabekir", "78", 37.23028, 32.95889);
case 575: return new CityInfo("Kazanlı", "32", 36.81565, 34.75761);
case 576: return new CityInfo("Kazancı", "21", 37.77106, 40.6);
case 577: return new CityInfo("Kazancı", "78", 36.50188, 32.86128);
case 578: return new CityInfo("Kayseri", "38", 38.73222, 35.48528);
case 579: return new CityInfo("Kaypak", "91", 37.11487, 36.46511);
case 580: return new CityInfo("Kaynar", "38", 38.89917, 36.45417);
case 581: return new CityInfo("Kaynakkaya", "72", 37.33968, 40.93274);
case 582: return new CityInfo("Kaymaz", "26", 39.51667, 31.17972);
case 583: return new CityInfo("Kaymakçı", "35", 38.16778, 28.11528);
case 584: return new CityInfo("Kayatepe", "72", 37.51917, 40.92712);
case 585: return new CityInfo("Kayapınar", "21", 37.93733, 40.17756);
case 586: return new CityInfo("Kayapınar", "76", 37.55762, 41.16231);
case 587: return new CityInfo("Kayapa", "10", 39.49271, 27.44547);
case 588: return new CityInfo("Kayalıpınar", "72", 37.32983, 41.2276);
case 589: return new CityInfo("Salmanlı", "66", 39.90222, 34.25472);
case 590: return new CityInfo("Kayadibi", "58", 39.47993, 36.71245);
case 591: return new CityInfo("Kayabağlar", "74", 37.98599, 41.66756);
case 592: return new CityInfo("Rubaikale", "80", 37.22028, 42.34583);
case 593: return new CityInfo("Kavaklıdere", "48", 37.44463, 28.36276);
case 594: return new CityInfo("Kavakbaşı", "13", 38.48337, 41.81967);
case 595: return new CityInfo("Kavak", "58", 39.29205, 37.48127);
case 596: return new CityInfo("Hazar", "23", 38.3878, 39.42365);
case 597: return new CityInfo("Kavacık", "10", 39.67551, 28.49446);
case 598: return new CityInfo("Katran", "80", 37.25281, 42.10958);
case 599: return new CityInfo("Kasımlar", "33", 37.52875, 31.1927);
case 600: return new CityInfo("Kaş", "07", 36.20176, 29.63766);
case 601: return new CityInfo("Karşıyaka", "35", 38.45772, 27.1142);
case 602: return new CityInfo("Aladağ", "81", 37.5485, 35.39603);
case 603: return new CityInfo("Karpuzlu", "09", 37.55861, 27.83528);
case 604: return new CityInfo("Kızılağaç", "07", 36.73055, 31.53517);
case 605: return new CityInfo("Karlıova", "12", 39.29044, 41.00594);
case 606: return new CityInfo("Karıncalı", "16", 39.97118, 28.85894);
case 607: return new CityInfo("Kargı", "48", 36.70132, 29.07557);
case 608: return new CityInfo("Karkamış", "83", 36.83452, 37.9983);
case 609: return new CityInfo("Karayün", "58", 39.68194, 37.30528);
case 610: return new CityInfo("Karayün", "76", 37.83493, 41.11376);
case 611: return new CityInfo("Karayazı", "25", 39.69604, 42.14277);
case 612: return new CityInfo("Karatoprak", "48", 37.01385, 27.25893);
case 613: return new CityInfo("Karataş", "81", 36.58204, 35.37014);
case 614: return new CityInfo("Yukarı Aydınlı", "72", 37.15935, 40.89883);
case 615: return new CityInfo("Karapınar", "71", 37.71596, 33.55064);
case 616: return new CityInfo("Karaoğlanlı", "45", 38.52917, 27.56667);
case 617: return new CityInfo("Karaoğlan", "62", 39.22644, 39.20853);
case 618: return new CityInfo("Karamanlı", "15", 37.37301, 29.82308);
case 619: return new CityInfo("Karaman", "78", 37.18111, 33.215);
case 620: return new CityInfo("Karalar", "72", 37.30073, 41.67582);
case 621: return new CityInfo("Karakuyu", "72", 37.15934, 40.54377);
case 622: return new CityInfo("Karakoyunlu", "88", 39.87036, 43.63014);
case 623: return new CityInfo("Karaköy", "49", 39.09101, 41.68301);
case 624: return new CityInfo("Karaköy", "76", 37.68328, 41.41171);
case 625: return new CityInfo("Ağrı", "04", 39.71944, 43.05139);
case 626: return new CityInfo("Karaköprü", "25", 39.31512, 41.96458);
case 627: return new CityInfo("Karaköprü", "63", 37.20361, 38.79944);
case 628: return new CityInfo("Karakoçan", "23", 38.95178, 40.02706);
case 629: return new CityInfo("Karakeçili", "79", 39.59417, 33.37778);
case 630: return new CityInfo("Karakeçi", "63", 37.45234, 39.44285);
case 631: return new CityInfo("Karaisalı", "81", 37.25667, 35.05889);
case 632: return new CityInfo("Karahasanlı", "50", 39.29693, 34.72159);
case 633: return new CityInfo("Karahallı", "64", 38.32083, 29.53028);
case 634: return new CityInfo("Karadirek", "03", 38.56834, 30.18417);
case 635: return new CityInfo("Karaçoban", "25", 39.34364, 42.09918);
case 636: return new CityInfo("Karaçay", "31", 36.13551, 36.07743);
case 637: return new CityInfo("Karacaören", "58", 39.73062, 38.11527);
case 638: return new CityInfo("Karacasu", "09", 37.72816, 28.60569);
case 639: return new CityInfo("Karacadağ", "63", 37.72894, 39.63547);
case 640: return new CityInfo("Karaburun", "35", 38.6364, 26.51094);
case 641: return new CityInfo("Karabayır", "72", 37.56437, 41.81724);
case 642: return new CityInfo("Karaağıl", "49", 39.13609, 42.08459);
case 643: return new CityInfo("Kanlıavşar", "63", 37.21646, 38.30936);
case 644: return new CityInfo("Kangal", "58", 39.23354, 37.39111);
case 645: return new CityInfo("Kandilli", "25", 39.90587, 40.83662);
case 646: return new CityInfo("Kaman", "40", 39.3575, 33.72389);
case 647: return new CityInfo("Kalkım", "17", 39.81167, 27.215);
case 648: return new CityInfo("Kalkan", "07", 36.2651, 29.41369);
case 649: return new CityInfo("Kabahaydar", "63", 37.31338, 39.00995);
case 650: return new CityInfo("Kale", "44", 39.03333, 38);
case 651: return new CityInfo("Kale", "20", 37.43917, 28.84528);
case 652: return new CityInfo("Kâhta", "02", 37.78552, 38.6237);
case 653: return new CityInfo("Kahramanmaraş", "46", 37.5847, 36.92641);
case 654: return new CityInfo("Kadışehri", "66", 39.99568, 35.79193);
case 655: return new CityInfo("Kadirli", "91", 37.37389, 36.09611);
case 656: return new CityInfo("Kadınhanı", "71", 38.23972, 32.21139);
case 657: return new CityInfo("Kaçıt", "74", 37.93028, 42.98889);
case 658: return new CityInfo("Kabala", "72", 37.34585, 40.80059);
case 659: return new CityInfo("Kabahaydar", "63", 37.4, 39.08333);
case 660: return new CityInfo("İzmir", "35", 38.41273, 27.13838);
case 661: return new CityInfo("İvrindi", "10", 39.58389, 27.48639);
case 662: return new CityInfo("Isparta", "33", 37.76444, 30.55222);
case 663: return new CityInfo("Yuntdağ", "35", 38.93167, 27.21361);
case 664: return new CityInfo("İslahiye", "83", 37.025, 36.63056);
case 665: return new CityInfo("İskenderun", "31", 36.58718, 36.17347);
case 666: return new CityInfo("Işıklar", "03", 38.67101, 30.74098);
case 667: return new CityInfo("İshaklı", "20", 38.19972, 30.01333);
case 668: return new CityInfo("Kavsan", "72", 37.65653, 40.65806);
case 669: return new CityInfo("İscehisar", "03", 38.86194, 30.75028);
case 670: return new CityInfo("İsabeyli", "09", 37.90147, 28.26475);
case 671: return new CityInfo("İnönü", "26", 39.81534, 30.14549);
case 672: return new CityInfo("İnönü", "78", 37.31667, 33.76667);
case 673: return new CityInfo("İncirliova", "09", 37.85222, 27.72361);
case 674: return new CityInfo("İncesu", "38", 38.6224, 35.18261);
case 675: return new CityInfo("İmranlı", "58", 39.87544, 38.11358);
case 676: return new CityInfo("İmamoğlu", "81", 37.26506, 35.65717);
case 677: return new CityInfo("İlyaslı", "64", 38.60389, 29.20056);
case 678: return new CityInfo("Ilıca", "25", 39.94653, 41.0952);
case 679: return new CityInfo("Ilıca", "10", 39.87583, 27.77639);
case 680: return new CityInfo("Ilıcalar", "12", 38.98034, 40.67394);
case 681: return new CityInfo("İliç", "24", 39.45106, 38.55836);
case 682: return new CityInfo("Ilgın", "71", 38.27917, 31.91389);
case 683: return new CityInfo("İkiztepe", "76", 37.89316, 41.08539);
case 684: return new CityInfo("İkizce", "68", 39.59516, 32.66097);
case 685: return new CityInfo("İkizce", "83", 36.86262, 37.77432);
case 686: return new CityInfo("İkizbağlar", "74", 37.97911, 41.97337);
case 687: return new CityInfo("Aviski", "76", 37.96459, 41.33119);
case 688: return new CityInfo("İhsaniye", "03", 39.02916, 30.41639);
case 689: return new CityInfo("Iğdır", "88", 39.92371, 44.045);
case 690: return new CityInfo("İdil", "80", 37.33481, 41.88944);
case 691: return new CityInfo("Teffi", "72", 37.55781, 41.09551);
case 692: return new CityInfo("İçmeler", "48", 36.79859, 28.22635);
case 693: return new CityInfo("İçme", "23", 38.61257, 39.5513);
case 694: return new CityInfo("Hüyük", "71", 37.95388, 31.59639);
case 695: return new CityInfo("Hozat", "62", 39.10029, 39.20816);
case 696: return new CityInfo("Hotamış", "71", 37.64004, 33.31862);
case 697: return new CityInfo("Horsunlu", "09", 37.91441, 28.59151);
case 698: return new CityInfo("Honaz", "20", 37.7573, 29.26996);
case 699: return new CityInfo("Hocalar", "03", 38.57824, 29.96768);
case 700: return new CityInfo("Gyundyukoru", "72", 37.14207, 40.50149);
case 701: return new CityInfo("Selçuklu", "71", 37.8842, 32.49222);
case 702: return new CityInfo("Hizan", "13", 38.22498, 42.4183);
case 703: return new CityInfo("Hisarcık", "43", 39.25057, 29.23116);
case 704: return new CityInfo("Hisar", "76", 37.60094, 41.22799);
case 705: return new CityInfo("Hınıs", "25", 39.35766, 41.69253);
case 706: return new CityInfo("Himmetdede", "38", 38.91028, 35.09607);
case 707: return new CityInfo("Hilvan", "63", 37.58687, 38.95505);
case 708: return new CityInfo("Hilal", "80", 37.47528, 42.78583);
case 709: return new CityInfo("Hıdırbey", "31", 36.20802, 36.12787);
case 710: return new CityInfo("Hıdırbaba", "23", 38.76706, 38.97698);
case 711: return new CityInfo("Hekimhan", "44", 38.81622, 37.92882);
case 712: return new CityInfo("Hekimdağ", "26", 39.90904, 30.5646);
case 713: return new CityInfo("Hazro", "21", 38.24903, 40.77129);
case 714: return new CityInfo("Haymana", "68", 39.43212, 32.49732);
case 715: return new CityInfo("Haydarlı", "03", 38.25972, 30.38583);
case 716: return new CityInfo("Havran", "10", 39.55833, 27.09833);
case 717: return new CityInfo("Hatunsaray", "71", 37.58753, 32.34802);
case 718: return new CityInfo("Hatunlu", "72", 37.13949, 40.75404);
case 719: return new CityInfo("Hatip", "71", 37.75447, 32.4222);
case 720: return new CityInfo("Hassa", "31", 36.79944, 36.51778);
case 721: return new CityInfo("Alacakaya", "21", 38.45751, 39.85956);
case 722: return new CityInfo("Hasköy", "49", 38.68231, 41.67851);
case 723: return new CityInfo("Hasbek", "66", 39.54945, 35.54772);
case 724: return new CityInfo("Hasantepe", "72", 37.12725, 41.4914);
case 725: return new CityInfo("Hasankeyf", "76", 37.70612, 41.4048);
case 726: return new CityInfo("Hasançelebi", "44", 38.95093, 37.88064);
case 727: return new CityInfo("Hasanbeyli", "91", 37.12838, 36.54608);
case 728: return new CityInfo("Haruniye", "91", 37.24216, 36.45484);
case 729: return new CityInfo("Harran", "63", 36.86, 39.03139);
case 730: return new CityInfo("Harput", "23", 38.70373, 39.2415);
case 731: return new CityInfo("Harmantepe", "72", 37.70179, 41.00753);
case 732: return new CityInfo("Harmanlı", "02", 37.83812, 37.74428);
case 733: return new CityInfo("Harmanlı", "21", 37.7282, 40.82961);
case 734: return new CityInfo("Harmancık", "16", 39.67611, 29.15528);
case 735: return new CityInfo("Harbiye", "31", 36.13685, 36.13293);
case 736: return new CityInfo("Kavallı", "80", 37.21176, 42.41945);
case 737: return new CityInfo("Han", "26", 39.15917, 30.86139);
case 738: return new CityInfo("Hankendi", "23", 38.56879, 39.05739);
case 739: return new CityInfo("Hani", "21", 38.40741, 40.38578);
case 740: return new CityInfo("Hanköy", "63", 36.95081, 40.19855);
case 741: return new CityInfo("Hamzalı", "21", 38.34159, 41.16254);
case 742: return new CityInfo("Hamur", "04", 39.60561, 42.985);
case 743: return new CityInfo("Hamdibey", "17", 39.84944, 27.24806);
case 744: return new CityInfo("Halkapınar", "71", 37.43394, 34.18743);
case 745: return new CityInfo("Halitpaşa", "45", 38.68541, 27.67836);
case 746: return new CityInfo("Halilçavuş", "25", 39.2472, 41.79257);
case 747: return new CityInfo("Halfeti", "63", 37.24529, 37.86874);
case 748: return new CityInfo("Haktanır", "63", 36.85472, 38.86583);
case 749: return new CityInfo("Tuzla", "81", 36.70074, 35.08726);
case 750: return new CityInfo("Hafik", "58", 39.85639, 37.38639);
case 751: return new CityInfo("Hadim", "71", 36.98776, 32.45674);
case 752: return new CityInfo("Hacılar", "38", 38.64631, 35.44937);
case 753: return new CityInfo("Hacıekber", "63", 36.8158, 38.94655);
case 754: return new CityInfo("Hacıbektaş", "50", 38.94077, 34.5577);
case 755: return new CityInfo("Aydınlar", "23", 38.62198, 38.54052);
case 756: return new CityInfo("Haberli", "72", 37.3051, 41.61758);
case 757: return new CityInfo("Güzelyurt", "75", 38.27722, 34.37194);
case 758: return new CityInfo("Güzelsu", "65", 38.31032, 43.79906);
case 759: return new CityInfo("Güzelsu", "07", 36.89472, 31.85639);
case 760: return new CityInfo("Güzeloluk", "32", 36.79444, 34.08274);
case 761: return new CityInfo("Güzelbağ", "07", 36.73363, 31.89837);
case 762: return new CityInfo("Güvercinlik", "48", 37.13706, 27.58186);
case 763: return new CityInfo("Gürün", "58", 38.72225, 37.27097);
case 764: return new CityInfo("Gürpınar", "65", 38.32372, 43.40991);
case 765: return new CityInfo("Güroymak", "13", 38.5758, 42.01558);
case 766: return new CityInfo("Güre", "64", 38.65111, 29.16694);
case 767: return new CityInfo("Günyüzü", "26", 39.38345, 31.80995);
case 768: return new CityInfo("Kyanisipi", "72", 37.12688, 40.56082);
case 769: return new CityInfo("Güngeçti", "21", 37.90436, 40.91508);
case 770: return new CityInfo("Güney", "20", 38.15444, 29.06778);
case 771: return new CityInfo("Güneren", "63", 36.73417, 39.08861);
case 772: return new CityInfo("Eksere", "07", 36.81339, 31.99971);
case 773: return new CityInfo("Gyundash", "63", 36.73277, 38.8116);
case 774: return new CityInfo("Homa", "20", 38.23927, 29.98651);
case 775: return new CityInfo("Uzyum", "13", 37.99667, 42.71239);
case 776: return new CityInfo("Salanda", "50", 38.82556, 34.53212);
case 777: return new CityInfo("Gümüşakar", "24", 39.79382, 38.67297);
case 778: return new CityInfo("Becuh", "80", 37.39141, 42.99018);
case 779: return new CityInfo("Gülveren", "72", 37.48711, 41.49446);
case 780: return new CityInfo("Gülşehir", "50", 38.74594, 34.62524);
case 781: return new CityInfo("Gülpınar", "17", 39.53278, 26.12056);
case 782: return new CityInfo("Gülnar", "32", 36.34148, 33.39921);
case 783: return new CityInfo("Kiulukioi", "48", 37.23972, 27.60028);
case 784: return new CityInfo("Güllü", "64", 38.27114, 29.10451);
case 785: return new CityInfo("Yenisu", "12", 38.75201, 40.87571);
case 786: return new CityInfo("Güleçler", "74", 37.95333, 42.53861);
case 787: return new CityInfo("Başköy", "24", 39.87231, 39.84188);
case 788: return new CityInfo("Güldüzü", "90", 36.86755, 37.11658);
case 789: return new CityInfo("Gücük", "46", 38.1936, 37.4812);
case 790: return new CityInfo("Baraniferho", "80", 37.46957, 41.90593);
case 791: return new CityInfo("Cibri", "80", 37.27593, 42.09814);
case 792: return new CityInfo("Gözpınar", "74", 37.97717, 41.45761);
case 793: return new CityInfo("Gözne", "32", 36.99528, 34.57306);
case 794: return new CityInfo("Gözler", "20", 38.10679, 29.15375);
case 795: return new CityInfo("Gözeli", "23", 38.4246, 39.05728);
case 796: return new CityInfo("Göynük", "12", 39.13947, 40.87438);
case 797: return new CityInfo("Göynük", "07", 36.66, 30.55);
case 798: return new CityInfo("Payamlı", "63", 37.03651, 38.61337);
case 799: return new CityInfo("Bisbin", "80", 37.33929, 42.56945);
case 800: return new CityInfo("Göreme", "50", 38.6437, 34.83529);
case 801: return new CityInfo("Gördes", "45", 38.93278, 28.28942);
case 802: return new CityInfo("Derdil", "76", 37.64546, 41.49115);
case 803: return new CityInfo("Gönen", "33", 37.95639, 30.5114);
case 804: return new CityInfo("Gömeç", "10", 39.39016, 26.84127);
case 805: return new CityInfo("Gölova", "07", 36.79917, 30.03889);
case 806: return new CityInfo("Beyviran", "71", 37.84949, 33.8597);
case 807: return new CityInfo("Gölmarmara", "45", 38.71389, 27.91417);
case 808: return new CityInfo("Göllü", "40", 39.4499, 34.30011);
case 809: return new CityInfo("Göllü", "72", 37.25128, 40.71516);
case 810: return new CityInfo("Gölhisar", "15", 37.1459, 29.50876);
case 811: return new CityInfo("Gölgelikonak", "74", 37.76923, 42.12744);
case 812: return new CityInfo("Göldüzü", "13", 38.81335, 43.01904);
case 813: return new CityInfo("Gölcük", "10", 39.31309, 27.98319);
case 814: return new CityInfo("Tilfetis", "63", 37.48135, 39.04736);
case 815: return new CityInfo("Gölbaşı", "68", 39.79043, 32.80903);
case 816: return new CityInfo("Gölbaşı", "02", 37.78361, 37.63667);
case 817: return new CityInfo("Göktepe", "48", 37.41908, 28.55894);
case 818: return new CityInfo("Göktepe", "78", 36.62687, 32.6228);
case 819: return new CityInfo("Göksun", "46", 38.02096, 36.4973);
case 820: return new CityInfo("Göksu", "25", 39.48906, 42.15127);
case 821: return new CityInfo("Gökoğlan", "25", 39.54648, 41.30402);
case 822: return new CityInfo("Gökdoğan", "74", 37.95308, 41.40465);
case 823: return new CityInfo("Gökdere", "23", 38.7428, 40.20815);
case 824: return new CityInfo("Ergama", "10", 39.62712, 27.63139);
case 825: return new CityInfo("Gökçepınar", "76", 37.58919, 41.52023);
case 826: return new CityInfo("Menye", "45", 38.57528, 28.48889);
case 827: return new CityInfo("Gökçen", "35", 38.11367, 27.87144);
case 828: return new CityInfo("Kirap", "83", 36.88006, 37.70372);
case 829: return new CityInfo("Gökçekoru", "74", 37.95621, 42.44971);
case 830: return new CityInfo("Gökçedağ", "10", 39.55832, 28.91911);
case 831: return new CityInfo("Civankan", "74", 37.90339, 41.87752);
case 832: return new CityInfo("Selah", "72", 37.20541, 40.69748);
case 833: return new CityInfo("Gökbudak", "74", 37.90367, 42.64866);
case 834: return new CityInfo("Göçbeyli", "35", 39.22328, 27.40386);
case 835: return new CityInfo("Girmeli", "72", 37.11106, 41.4196);
case 836: return new CityInfo("Geyikpınar", "13", 38.31759, 41.82065);
case 837: return new CityInfo("Geyikli", "17", 39.80472, 26.2075);
case 838: return new CityInfo("Geyikbayırı", "07", 36.87556, 30.45833);
case 839: return new CityInfo("Gevence", "83", 36.91278, 37.84472);
case 840: return new CityInfo("Gevaş", "65", 38.2921, 43.10189);
case 841: return new CityInfo("Gesi", "38", 38.7918, 35.65923);
case 842: return new CityInfo("Germencik", "09", 37.87056, 27.60283);
case 843: return new CityInfo("Geriş", "07", 36.9625, 31.73306);
case 844: return new CityInfo("Gerger", "02", 37.95, 39.01667);
case 845: return new CityInfo("Gerdzhyush", "76", 37.56249, 41.37753);
case 846: return new CityInfo("Gencek", "71", 37.44984, 31.54588);
case 847: return new CityInfo("Genç", "12", 38.74773, 40.55343);
case 848: return new CityInfo("Gemerek", "58", 39.18342, 36.07189);
case 849: return new CityInfo("Gelinkaya", "72", 37.41683, 41.26994);
case 850: return new CityInfo("Gelendost", "33", 38.12083, 31.01528);
case 851: return new CityInfo("Gelembe", "45", 39.17872, 27.84848);
case 852: return new CityInfo("Gediz", "43", 38.99389, 29.39131);
case 853: return new CityInfo("Gedikler", "62", 39.08229, 38.80346);
case 854: return new CityInfo("Timar", "65", 38.82865, 43.4333);
case 855: return new CityInfo("Gedikbaşı", "58", 39.48939, 38.24743);
case 856: return new CityInfo("Geçitli", "70", 37.58669, 43.56163);
case 857: return new CityInfo("Geçitboyu", "80", 37.49249, 42.51877);
case 858: return new CityInfo("Gebiz", "07", 37.10417, 30.93778);
case 859: return new CityInfo("Gazipaşa", "07", 36.26942, 32.31792);
case 860: return new CityInfo("Gaziemir", "35", 38.32392, 27.12918);
case 861: return new CityInfo("Gaziantep", "83", 37.05944, 37.3825);
case 862: return new CityInfo("Foça", "35", 38.6703, 26.75656);
case 863: return new CityInfo("Finike", "07", 36.295, 30.14056);
case 864: return new CityInfo("Fındık", "80", 37.51317, 41.96418);
case 865: return new CityInfo("Fevzipaşa", "83", 37.09418, 36.63719);
case 866: return new CityInfo("Fethiye", "48", 36.64038, 29.12758);
case 867: return new CityInfo("Felahiye", "38", 39.09056, 35.56722);
case 868: return new CityInfo("Feke", "81", 37.81446, 35.91233);
case 869: return new CityInfo("Ezine", "17", 39.78561, 26.34083);
case 870: return new CityInfo("Eymirli", "72", 37.1703, 40.68684);
case 871: return new CityInfo("Evrenseki", "07", 36.83868, 31.35559);
case 872: return new CityInfo("Evkuran", "72", 37.65962, 40.96418);
case 873: return new CityInfo("Evciler", "17", 39.77556, 26.77167);
case 874: return new CityInfo("Evciler", "03", 38.04139, 29.88667);
case 875: return new CityInfo("Etimesgut", "68", 39.95328, 32.63285);
case 876: return new CityInfo("Etili", "17", 39.98556, 26.89667);
case 877: return new CityInfo("Eşme", "64", 38.39976, 28.96905);
case 878: return new CityInfo("Eşme", "72", 37.15569, 40.64142);
case 879: return new CityInfo("Eskişehir", "26", 39.77667, 30.52056);
case 880: return new CityInfo("Eskin", "72", 37.21538, 40.6783);
case 881: return new CityInfo("Eskil", "75", 38.40167, 33.41306);
case 882: return new CityInfo("Eskiharran", "63", 36.93083, 39.06);
case 883: return new CityInfo("Esendere", "70", 37.71144, 44.60099);
case 884: return new CityInfo("Eşen", "48", 36.4548, 29.28154);
case 885: return new CityInfo("Erzurum", "25", 39.90861, 41.27694);
case 886: return new CityInfo("Erzincan", "24", 39.73919, 39.49015);
case 887: return new CityInfo("Eryeri", "72", 37.29496, 40.74543);
case 888: return new CityInfo("Eruh", "74", 37.74183, 42.17422);
case 889: return new CityInfo("Ertuğrul", "10", 39.57578, 27.70672);
case 890: return new CityInfo("Ashagy-Tomik", "72", 37.24588, 40.6818);
case 891: return new CityInfo("Ermenek", "78", 36.64043, 32.89179);
case 892: return new CityInfo("Erköklü", "76", 37.86182, 41.14413);
case 893: return new CityInfo("Erkilet", "38", 38.82043, 35.44011);
case 894: return new CityInfo("Ergani", "21", 38.26899, 39.75446);
case 895: return new CityInfo("Erentepe", "49", 39.00893, 42.04364);
case 896: return new CityInfo("Ereğli", "71", 37.51333, 34.04672);
case 897: return new CityInfo("Erdurağı", "74", 37.90085, 41.57657);
case 898: return new CityInfo("Erdemli", "32", 36.60498, 34.30836);
case 899: return new CityInfo("Erciş", "65", 39.02587, 43.35964);
case 900: return new CityInfo("Erçek", "65", 38.65107, 43.64401);
case 901: return new CityInfo("Bulucan", "58", 39.7025, 37.75972);
case 902: return new CityInfo("Emirgazi", "71", 37.90222, 33.83722);
case 903: return new CityInfo("Emirdağ", "03", 39.01972, 31.15);
case 904: return new CityInfo("Emiralem", "35", 38.60971, 27.14588);
case 905: return new CityInfo("Emet", "43", 39.343, 29.25847);
case 906: return new CityInfo("Elvanlı", "32", 36.70401, 34.37374);
case 907: return new CityInfo("Güneysınır", "71", 37.26944, 32.72898);
case 908: return new CityInfo("Elmalı", "07", 36.73583, 29.91775);
case 909: return new CityInfo("Elmadağ", "68", 39.92083, 33.23083);
case 910: return new CityInfo("Elifoğlu", "83", 36.94654, 37.98895);
case 911: return new CityInfo("Eleşkirt", "04", 39.79803, 42.67574);
case 912: return new CityInfo("Elbistan", "46", 38.20591, 37.1983);
case 913: return new CityInfo("Elbeyli", "72", 37.18373, 40.64395);
case 914: return new CityInfo("Elbeyli", "90", 36.67417, 37.46667);
case 915: return new CityInfo("Elbaşı", "38", 38.67351, 35.96753);
case 916: return new CityInfo("Elazığ", "23", 38.67431, 39.22321);
case 917: return new CityInfo("Ekmekçiler", "74", 37.88572, 42.12767);
case 918: return new CityInfo("Ekinyazı", "63", 36.72917, 39.14139);
case 919: return new CityInfo("Celeyke", "46", 38.05974, 37.18786);
case 920: return new CityInfo("Üçpınar", "45", 38.73423, 27.36164);
case 921: return new CityInfo("Eğirdir", "33", 37.87462, 30.85042);
case 922: return new CityInfo("Eğil", "21", 38.25748, 40.07435);
case 923: return new CityInfo("Kocasinan", "38", 38.77147, 35.5725);
case 924: return new CityInfo("Edremit", "10", 39.59611, 27.02444);
case 925: return new CityInfo("Düzova", "80", 37.35413, 42.08837);
case 926: return new CityInfo("Düzoba", "72", 37.39157, 41.27286);
case 927: return new CityInfo("Dutluca", "24", 39.13586, 38.60662);
case 928: return new CityInfo("Duruca", "72", 37.09309, 41.30986);
case 929: return new CityInfo("Duruköy", "80", 37.22435, 41.91692);
case 930: return new CityInfo("Dursunbey", "10", 39.58596, 28.62568);
case 931: return new CityInfo("Durankaya", "74", 37.9862, 42.18052);
case 932: return new CityInfo("Durak", "10", 39.70658, 28.27176);
case 933: return new CityInfo("Dumlupınar", "43", 38.85408, 29.9772);
case 934: return new CityInfo("Dumanlı", "72", 37.36795, 41.68999);
case 935: return new CityInfo("Sumbas", "91", 37.4513, 36.02349);
case 936: return new CityInfo("Doyuran", "72", 37.1228, 40.63761);
case 937: return new CityInfo("Döşemealtı", "07", 37.02333, 30.60247);
case 938: return new CityInfo("Dorutay", "65", 38.79939, 44.06726);
case 939: return new CityInfo("Dorumali", "63", 36.805, 38.85306);
case 940: return new CityInfo("Doruk", "21", 37.7025, 40.79219);
case 941: return new CityInfo("Dörtyol", "31", 36.83917, 36.23025);
case 942: return new CityInfo("Dombay", "03", 38.15421, 30.20876);
case 943: return new CityInfo("Domaniç", "43", 39.80194, 29.60918);
case 944: return new CityInfo("Doluharman", "74", 37.98555, 41.91623);
case 945: return new CityInfo("Doğubayazıt", "04", 39.54694, 44.08417);
case 946: return new CityInfo("Doğanyol", "44", 38.30746, 39.03431);
case 947: return new CityInfo("Doğansu", "04", 39.13248, 42.73249);
case 948: return new CityInfo("Doğanşehir", "44", 38.08574, 37.87116);
case 949: return new CityInfo("Doğanpınar", "83", 36.84321, 37.61759);
case 950: return new CityInfo("Doğanköy", "74", 37.76334, 42.78929);
case 951: return new CityInfo("Doğankent", "81", 36.84432, 35.34396);
case 952: return new CityInfo("Doğankavak", "76", 37.96265, 41.22675);
case 953: return new CityInfo("Doğanhisar", "71", 38.1463, 31.67648);
case 954: return new CityInfo("Doğanca", "74", 37.79955, 42.33099);
case 955: return new CityInfo("Doğanbeyli", "24", 39.69517, 39.03499);
case 956: return new CityInfo("Doğanbey", "71", 37.8005, 31.8911);
case 957: return new CityInfo("Dodurga", "11", 39.79972, 29.91722);
case 958: return new CityInfo("Diyarbakır", "21", 37.91363, 40.21721);
case 959: return new CityInfo("Diyadin", "04", 39.54056, 43.67135);
case 960: return new CityInfo("Divriği", "58", 39.371, 38.1137);
case 961: return new CityInfo("Direkli", "58", 39.71167, 36.65167);
case 962: return new CityInfo("Dinek", "71", 37.32481, 32.61602);
case 963: return new CityInfo("Dinar", "03", 38.065, 30.16557);
case 964: return new CityInfo("Dilektepe", "74", 38.07517, 41.82717);
case 965: return new CityInfo("Diktepe", "21", 37.91974, 41.06119);
case 966: return new CityInfo("Dikili", "35", 39.071, 26.89017);
case 967: return new CityInfo("Dikboğaz", "74", 37.69453, 42.10725);
case 968: return new CityInfo("Dicle", "21", 38.36571, 40.0645);
case 969: return new CityInfo("Dicle", "80", 37.28869, 42.06721);
case 970: return new CityInfo("Develi", "38", 38.39056, 35.49222);
case 971: return new CityInfo("Devecikonağı", "16", 39.91486, 28.56176);
case 972: return new CityInfo("Derinkuyu", "50", 38.3751, 34.73419);
case 973: return new CityInfo("Derik", "72", 37.36336, 40.26473);
case 974: return new CityInfo("Dereyanı", "72", 37.42746, 40.86096);
case 975: return new CityInfo("Turanlı", "35", 39.27682, 27.3246);
case 976: return new CityInfo("Derebucak", "71", 37.39179, 31.50918);
case 977: return new CityInfo("Dere", "62", 38.98295, 39.30017);
case 978: return new CityInfo("Derbent", "71", 38.01422, 32.01639);
case 979: return new CityInfo("Denizli", "20", 37.77417, 29.0875);
case 980: return new CityInfo("Demiryol", "76", 37.91751, 41.14984);
case 981: return new CityInfo("Demirlipınar", "76", 37.96151, 41.17596);
case 982: return new CityInfo("Demirli", "63", 36.73278, 39.34389);
case 983: return new CityInfo("Adala", "45", 38.57757, 28.26847);
case 984: return new CityInfo("Demirci", "45", 39.04607, 28.65889);
case 985: return new CityInfo("Deliktaş", "58", 39.34157, 37.20378);
case 986: return new CityInfo("Delice", "79", 39.95371, 34.02587);
case 987: return new CityInfo("Deliçay", "65", 39.08163, 43.48552);
case 988: return new CityInfo("Değirmendere", "35", 38.11361, 27.14139);
case 989: return new CityInfo("Dedeli", "04", 39.17435, 43.05524);
case 990: return new CityInfo("Dazkırı", "03", 37.91861, 29.86056);
case 991: return new CityInfo("Davutlar", "09", 37.73392, 27.29283);
case 992: return new CityInfo("Davulga", "03", 38.97917, 31.37139);
case 993: return new CityInfo("Datça", "48", 36.73778, 27.68417);
case 994: return new CityInfo("Darıkent", "62", 38.96252, 39.80792);
case 995: return new CityInfo("Dargeçit", "72", 37.54616, 41.71652);
case 996: return new CityInfo("Darende", "44", 38.54583, 37.50583);
case 997: return new CityInfo("Danişment", "10", 39.86917, 27.63306);
case 998: return new CityInfo("Danalı", "76", 37.88234, 41.25749);
case 999: return new CityInfo("Damlacık", "02", 37.9142, 38.65392);
case 1000: return new CityInfo("Dalyan", "48", 36.83429, 28.6446);
case 1001: return new CityInfo("Dallıbahçe", "62", 39.13321, 39.87929);
case 1002: return new CityInfo("Dallıağaç", "72", 37.29849, 41.05974);
case 1003: return new CityInfo("Dalama", "09", 37.79028, 28.06639);
case 1004: return new CityInfo("Dağyolu", "62", 39.53845, 39.90765);
case 1005: return new CityInfo("Dağlıca", "70", 37.36658, 44.08528);
case 1006: return new CityInfo("Dağkızılca", "35", 38.311, 27.39081);
case 1007: return new CityInfo("Serhatta", "74", 37.66278, 42.14064);
case 1008: return new CityInfo("Dağdibi", "80", 37.39388, 43.10094);
case 1009: return new CityInfo("Dağ", "07", 37.19306, 30.50417);
case 1010: return new CityInfo("Karahan", "63", 37.89825, 39.33366);
case 1011: return new CityInfo("Dağardı", "43", 39.4308, 28.99558);
case 1012: return new CityInfo("Dadaşköy", "25", 39.94489, 41.25465);
case 1013: return new CityInfo("Çüngüş", "21", 38.20798, 39.28554);
case 1014: return new CityInfo("Çumra", "71", 37.5732, 32.77446);
case 1015: return new CityInfo("Menderes", "35", 38.24963, 27.13429);
case 1016: return new CityInfo("Cumaçay", "04", 39.91524, 43.18653);
case 1017: return new CityInfo("Akziyaret", "63", 37.35328, 38.79609);
case 1018: return new CityInfo("Çukurca", "70", 37.24806, 43.61361);
case 1019: return new CityInfo("Özvatan", "38", 39.1069, 35.69994);
case 1020: return new CityInfo("Düvertepe", "10", 39.23734, 28.44001);
case 1021: return new CityInfo("Hakkâri", "70", 37.57444, 43.74083);
case 1022: return new CityInfo("Çolaklı", "44", 38.33351, 38.51946);
case 1023: return new CityInfo("Çokak", "46", 37.73613, 36.32865);
case 1024: return new CityInfo("Çobanlar", "03", 38.70139, 30.78278);
case 1025: return new CityInfo("Cizre", "80", 37.33024, 42.18484);
case 1026: return new CityInfo("Çivril", "20", 38.30139, 29.73861);
case 1027: return new CityInfo("Çırpı", "35", 38.16444, 27.4975);
case 1028: return new CityInfo("Çine", "09", 37.61266, 28.05912);
case 1029: return new CityInfo("Cillin", "72", 37.59507, 40.68407);
case 1030: return new CityInfo("Çınaraltı", "72", 37.3849, 40.85938);
case 1031: return new CityInfo("Çınar", "21", 37.72226, 40.40696);
case 1032: return new CityInfo("Evren", "68", 39.02402, 33.80626);
case 1033: return new CityInfo("Cihanbeyli", "71", 38.66072, 32.92437);
case 1034: return new CityInfo("Karchane", "80", 37.61853, 43.13679);
case 1035: return new CityInfo("Ashuta", "70", 37.3229, 43.37482);
case 1036: return new CityInfo("Serkan", "72", 37.15878, 41.74132);
case 1037: return new CityInfo("Çiğil", "71", 37.47923, 33.31805);
case 1038: return new CityInfo("Girikbedro", "80", 37.18028, 42.42111);
case 1039: return new CityInfo("Çiftlik", "25", 39.78276, 40.63484);
case 1040: return new CityInfo("Melikgazi", "38", 38.75, 35.45);
case 1041: return new CityInfo("Çiftlik", "73", 38.1758, 34.48535);
case 1042: return new CityInfo("Çiflikköy", "83", 36.82715, 37.7966);
case 1043: return new CityInfo("Çifteler", "26", 39.38306, 31.03917);
case 1044: return new CityInfo("Çiftehan", "73", 37.51233, 34.76953);
case 1045: return new CityInfo("Çiçekli", "62", 39.05468, 39.41604);
case 1046: return new CityInfo("Çiçekdağı", "40", 39.60694, 34.40861);
case 1047: return new CityInfo("Ceylanpınar", "63", 36.84722, 40.05);
case 1048: return new CityInfo("Ceyhan", "81", 37.02472, 35.8175);
case 1049: return new CityInfo("Çevrimova", "76", 37.84003, 41.27288);
case 1050: return new CityInfo("Cevizlik", "74", 38.17554, 42.22602);
case 1051: return new CityInfo("Cevizlik", "72", 37.38608, 40.56896);
case 1052: return new CityInfo("Cevizli", "07", 37.19694, 31.76333);
case 1053: return new CityInfo("Çatalan", "81", 37.24857, 35.2911);
case 1054: return new CityInfo("Çetinkaya", "58", 39.26178, 37.62603);
case 1055: return new CityInfo("Çeşme", "35", 38.32614, 26.30574);
case 1056: return new CityInfo("Çermik", "21", 38.13538, 39.445);
case 1057: return new CityInfo("Cengerli", "24", 39.79426, 38.84814);
case 1058: return new CityInfo("Çemişgezek", "62", 39.05539, 38.90754);
case 1059: return new CityInfo("Çeltikçi", "15", 37.52947, 30.48028);
case 1060: return new CityInfo("Çeltik", "71", 39.02444, 31.79056);
case 1061: return new CityInfo("Çelikhan", "02", 38.0256, 38.23665);
case 1062: return new CityInfo("Çelebi", "79", 39.46418, 33.5241);
case 1063: return new CityInfo("Celâlli", "58", 39.6925, 37.42389);
case 1064: return new CityInfo("Çaylı", "35", 38.1533, 28.14406);
case 1065: return new CityInfo("Çaylarbaşı", "63", 37.7001, 39.00965);
case 1066: return new CityInfo("Çaylar", "49", 39.26731, 41.28344);
case 1067: return new CityInfo("Çayırlı", "24", 39.80775, 40.028);
case 1068: return new CityInfo("Çayıralan", "66", 39.30278, 35.64389);
case 1069: return new CityInfo("Çaybağı", "23", 38.69401, 39.62022);
case 1070: return new CityInfo("Çay", "03", 38.59167, 31.02861);
case 1071: return new CityInfo("Çavuşlu", "72", 37.50179, 41.24877);
case 1072: return new CityInfo("Çavuş", "71", 37.60963, 31.93135);
case 1073: return new CityInfo("Çavdır", "15", 37.155, 29.69389);
case 1074: return new CityInfo("Çavdarhisar", "43", 39.19344, 29.61915);
case 1075: return new CityInfo("Çatalözü", "72", 37.09722, 41.21452);
case 1076: return new CityInfo("Çatalçam", "24", 39.97438, 38.84777);
case 1077: return new CityInfo("Çatalarmut", "24", 39.80286, 39.31539);
case 1078: return new CityInfo("Malabadi", "21", 38.15162, 41.20256);
case 1079: return new CityInfo("Çatak", "65", 38.00293, 43.05243);
case 1080: return new CityInfo("Çat", "25", 39.60641, 40.96844);
case 1081: return new CityInfo("Çardak", "46", 38.09171, 36.82356);
case 1082: return new CityInfo("Çardak", "20", 37.82694, 29.66833);
case 1083: return new CityInfo("Çandır", "66", 39.24446, 35.51396);
case 1084: return new CityInfo("Çandarlı", "35", 38.93503, 26.934);
case 1085: return new CityInfo("Çan", "23", 39.14833, 40.20348);
case 1086: return new CityInfo("Çamlıyayla", "32", 37.16652, 34.59296);
case 1087: return new CityInfo("Çamlıdere", "63", 37.1544, 39.06697);
case 1088: return new CityInfo("Anamas", "33", 37.76667, 30.8);
case 1089: return new CityInfo("Çameli", "20", 37.07611, 29.34472);
case 1090: return new CityInfo("Çamardı", "73", 37.83222, 34.98139);
case 1091: return new CityInfo("Çaltılıbük", "16", 39.9559, 28.5991);
case 1092: return new CityInfo("Çalpınar", "72", 37.36542, 41.18576);
case 1093: return new CityInfo("Shaklan", "72", 37.16102, 40.77072);
case 1094: return new CityInfo("Çalışkan", "80", 37.29751, 42.64226);
case 1095: return new CityInfo("Çaldıran", "65", 39.14317, 43.91068);
case 1096: return new CityInfo("Çal", "20", 38.08361, 29.39889);
case 1097: return new CityInfo("Çakırlar", "07", 36.87145, 30.56208);
case 1098: return new CityInfo("Keysun", "02", 37.56075, 37.85583);
case 1099: return new CityInfo("Çakırbeyli", "09", 37.73501, 27.82388);
case 1100: return new CityInfo("Menteşe", "48", 37.11667, 28.26667);
case 1101: return new CityInfo("Çağlayancerit", "46", 37.74523, 37.28618);
case 1102: return new CityInfo("Çağlayan", "24", 39.58502, 39.68702);
case 1103: return new CityInfo("Çağlarca", "62", 39.03732, 39.13865);
case 1104: return new CityInfo("Çağış", "10", 39.51881, 28.01224);
case 1105: return new CityInfo("Dereova", "62", 39.25042, 39.86916);
case 1106: return new CityInfo("Nikfer", "20", 37.40542, 29.13727);
case 1107: return new CityInfo("Cinatamiho", "72", 37.27304, 41.03364);
case 1108: return new CityInfo("Büyükkaracaören", "83", 36.76417, 37.54361);
case 1109: return new CityInfo("Boğaziçi", "35", 38.03472, 27.55944);
case 1110: return new CityInfo("Büyükbelkis", "07", 36.94465, 31.16679);
case 1111: return new CityInfo("Armutlu", "24", 39.5755, 38.42722);
case 1112: return new CityInfo("Burhaniye", "10", 39.50041, 26.97269);
case 1113: return new CityInfo("Buharkent", "09", 37.96397, 28.7427);
case 1114: return new CityInfo("Burdur", "15", 37.72028, 30.29083);
case 1115: return new CityInfo("Burç", "83", 37.01362, 37.17913);
case 1116: return new CityInfo("Bünyan", "38", 38.8463, 35.86033);
case 1117: return new CityInfo("Buldan", "20", 38.045, 28.83056);
case 1118: return new CityInfo("Bulanık", "49", 39.08656, 42.27158);
case 1119: return new CityInfo("Buğdaylı", "80", 37.68556, 43.23028);
case 1120: return new CityInfo("Buğdaylı", "80", 37.16851, 42.40652);
case 1121: return new CityInfo("Budaklı", "72", 37.37823, 41.34828);
case 1122: return new CityInfo("Bucakkışla", "78", 36.95443, 33.02196);
case 1123: return new CityInfo("Buca", "35", 38.3983, 27.16662);
case 1124: return new CityInfo("Bucak", "15", 37.45917, 30.595);
case 1125: return new CityInfo("Bozyazı", "32", 36.1082, 32.96113);
case 1126: return new CityInfo("Bozüyük", "11", 39.90778, 30.03667);
case 1127: return new CityInfo("Boztepe", "40", 39.26972, 34.26111);
case 1128: return new CityInfo("Boztepe", "72", 37.18375, 40.71869);
case 1129: return new CityInfo("Bozova", "63", 37.3625, 38.52667);
case 1130: return new CityInfo("Bozova", "07", 37.21611, 30.28583);
case 1131: return new CityInfo("Bozoğlak", "24", 39.62292, 38.80194);
case 1132: return new CityInfo("Bozkurt", "20", 37.82417, 29.60972);
case 1133: return new CityInfo("Bozkır", "71", 37.18963, 32.24736);
case 1134: return new CityInfo("Taliban", "74", 37.981, 41.41328);
case 1135: return new CityInfo("Bozdoğan", "09", 37.67134, 28.31395);
case 1136: return new CityInfo("Bozcaada", "17", 39.835, 26.06972);
case 1137: return new CityInfo("Bozburun", "48", 36.69495, 28.04336);
case 1138: return new CityInfo("Bozarmut", "48", 37.30917, 28.16972);
case 1139: return new CityInfo("Bozan", "26", 39.78806, 31.10167);
case 1140: return new CityInfo("Bozalan", "80", 37.32874, 42.26366);
case 1141: return new CityInfo("Boyuncuk", "80", 37.42542, 41.90881);
case 1142: return new CityInfo("Boybeyi", "63", 36.89722, 38.7125);
case 1143: return new CityInfo("Bostancı", "80", 37.17778, 42.32906);
case 1144: return new CityInfo("Bornova", "35", 38.47921, 27.2399);
case 1145: return new CityInfo("Borlu", "45", 38.75291, 28.46744);
case 1146: return new CityInfo("Bor", "73", 37.89056, 34.55889);
case 1147: return new CityInfo("Bolvadin", "03", 38.71111, 31.04861);
case 1148: return new CityInfo("Simek", "13", 38.32748, 42.17448);
case 1149: return new CityInfo("Bölme", "64", 38.62076, 29.37373);
case 1150: return new CityInfo("Bolatlar", "63", 36.76737, 38.94622);
case 1151: return new CityInfo("Bolağaç", "80", 37.49881, 43.03808);
case 1152: return new CityInfo("Böğürtlen", "63", 37.16632, 38.0811);
case 1153: return new CityInfo("Boğazören", "80", 37.52775, 43.00778);
case 1154: return new CityInfo("Boğazlıyan", "66", 39.18877, 35.24537);
case 1155: return new CityInfo("Boğazkent", "07", 36.85319, 31.16388);
case 1156: return new CityInfo("Bodrum", "48", 37.03833, 27.42917);
case 1157: return new CityInfo("Bitlis", "13", 38.40115, 42.10784);
case 1158: return new CityInfo("Bismil", "21", 37.84514, 40.65931);
case 1159: return new CityInfo("Birgi", "35", 38.25028, 28.05917);
case 1160: return new CityInfo("Birecik", "63", 37.02577, 37.97841);
case 1161: return new CityInfo("Çukuryurt", "76", 37.58942, 41.48296);
case 1162: return new CityInfo("Bingöl", "12", 38.88472, 40.49389);
case 1163: return new CityInfo("Binatlı", "76", 37.84708, 41.21608);
case 1164: return new CityInfo("Binatlı", "63", 36.93395, 38.38235);
case 1165: return new CityInfo("Bigadiç", "10", 39.3925, 28.13111);
case 1166: return new CityInfo("Beytüşşebap", "80", 37.56318, 43.16583);
case 1167: return new CityInfo("Beyşehir", "71", 37.67735, 31.72458);
case 1168: return new CityInfo("Beypınarı", "58", 39.5064, 37.7069);
case 1169: return new CityInfo("Beylikova", "26", 39.68694, 31.20556);
case 1170: return new CityInfo("Beykent", "74", 37.88314, 41.68686);
case 1171: return new CityInfo("Beyçayırı", "76", 38.01412, 41.32372);
case 1172: return new CityInfo("Beyağaç", "20", 37.23526, 28.89612);
case 1173: return new CityInfo("Kızılin", "02", 37.54693, 38.07595);
case 1174: return new CityInfo("Beşpınar", "76", 37.83709, 41.60219);
case 1175: return new CityInfo("Besni", "02", 37.69278, 37.86111);
case 1176: return new CityInfo("Beşkonak", "07", 37.14444, 31.19917);
case 1177: return new CityInfo("Beşiri", "76", 37.91573, 41.2865);
case 1178: return new CityInfo("Bergama", "35", 39.12074, 27.18052);
case 1179: return new CityInfo("Belören", "02", 37.63723, 37.5803);
case 1180: return new CityInfo("Belören", "71", 37.2148, 32.55363);
case 1181: return new CityInfo("Belevi", "35", 38.015, 27.45028);
case 1182: return new CityInfo("Belenoluk", "74", 37.91537, 42.7769);
case 1183: return new CityInfo("Belen", "31", 36.48866, 36.19489);
case 1184: return new CityInfo("Demirtaş", "07", 36.42611, 32.1925);
case 1185: return new CityInfo("Belek", "07", 36.86278, 31.05556);
case 1186: return new CityInfo("Bekirhan", "76", 38.14086, 41.29351);
case 1187: return new CityInfo("Bekilli", "20", 38.23105, 29.4197);
case 1188: return new CityInfo("Behram", "17", 39.49344, 26.33316);
case 1189: return new CityInfo("Beğendik", "13", 37.97557, 42.64823);
case 1190: return new CityInfo("Bucak", "63", 37.8693, 39.06199);
case 1191: return new CityInfo("Bedirli", "58", 39.58276, 36.62049);
case 1192: return new CityInfo("Bayramiç", "17", 39.80862, 26.60983);
case 1193: return new CityInfo("Bayraklı", "35", 38.46717, 27.16384);
case 1194: return new CityInfo("Baykan", "74", 38.15754, 41.7733);
case 1195: return new CityInfo("Bayır", "48", 37.26774, 28.21677);
case 1196: return new CityInfo("Bayındır", "35", 38.21741, 27.64744);
case 1197: return new CityInfo("Bayat", "03", 38.98306, 30.92472);
case 1198: return new CityInfo("Batman", "76", 37.88738, 41.13221);
case 1199: return new CityInfo("Başyurt", "23", 38.83505, 39.97929);
case 1200: return new CityInfo("Başyurt", "72", 37.42805, 41.64312);
case 1201: return new CityInfo("Başpınar", "24", 39.19017, 38.68737);
case 1202: return new CityInfo("Başmakçı", "03", 37.89722, 30.01167);
case 1203: return new CityInfo("Baskil", "23", 38.56866, 38.81634);
case 1204: return new CityInfo("Başkavak", "72", 37.56468, 40.88757);
case 1205: return new CityInfo("Başkale", "65", 38.04526, 44.01718);
case 1206: return new CityInfo("Başhan", "21", 37.69857, 40.91243);
case 1207: return new CityInfo("Yoğun", "21", 38.09906, 39.51321);
case 1208: return new CityInfo("Barla", "33", 38.01778, 30.78278);
case 1209: return new CityInfo("Barıştepe", "72", 37.4832, 41.40251);
case 1210: return new CityInfo("Banaz", "64", 38.73707, 29.75194);
case 1211: return new CityInfo("Balya", "10", 39.74861, 27.57889);
case 1212: return new CityInfo("Balpınar", "76", 37.86804, 41.05536);
case 1213: return new CityInfo("Balpayam", "62", 39.42006, 40.05713);
case 1214: return new CityInfo("Balkat", "63", 36.86819, 38.99309);
case 1215: return new CityInfo("Balışeyh", "79", 39.91411, 33.72333);
case 1216: return new CityInfo("Balıkesir", "10", 39.64917, 27.88611);
case 1217: return new CityInfo("Balcı", "75", 38.72532, 34.10123);
case 1218: return new CityInfo("Balaban", "44", 38.46106, 37.57881);
case 1219: return new CityInfo("Bala", "68", 39.55422, 33.12344);
case 1220: return new CityInfo("Baklan", "20", 37.97694, 29.60861);
case 1221: return new CityInfo("Bahşılı", "79", 39.80017, 33.43701);
case 1222: return new CityInfo("Bahçesaray", "65", 38.1246, 42.79825);
case 1223: return new CityInfo("Bahçebaşı", "72", 37.11373, 41.2342);
case 1224: return new CityInfo("Bahçe", "81", 37.19724, 36.57658);
case 1225: return new CityInfo("Bağpınar", "02", 37.59139, 38.3191);
case 1226: return new CityInfo("Bağlıca", "74", 37.86974, 41.7511);
case 1227: return new CityInfo("Bağlıca", "72", 37.52705, 40.68618);
case 1228: return new CityInfo("Bağlıca", "80", 37.43333, 42.77417);
case 1229: return new CityInfo("Bağkonak", "33", 38.2175, 31.27222);
case 1230: return new CityInfo("Hazekyan", "70", 37.71769, 44.0356);
case 1231: return new CityInfo("Bağgöze", "74", 37.71261, 41.9154);
case 1232: return new CityInfo("Bağdere", "21", 38.11442, 40.73382);
case 1233: return new CityInfo("Bağarası", "09", 37.7071, 27.54875);
case 1234: return new CityInfo("Bademli", "35", 38.08167, 28.05778);
case 1235: return new CityInfo("Cevizpınarı", "72", 37.36957, 40.7814);
case 1236: return new CityInfo("Babatorun", "31", 36.07743, 36.29051);
case 1237: return new CityInfo("Babadağ", "20", 37.80764, 28.85665);
case 1238: return new CityInfo("Ayvalık", "10", 39.31927, 26.69341);
case 1239: return new CityInfo("Ayvalıbağ", "74", 37.95707, 42.47948);
case 1240: return new CityInfo("Ayvacık", "17", 39.60111, 26.40472);
case 1241: return new CityInfo("Ayrancı", "78", 37.36127, 33.6883);
case 1242: return new CityInfo("Tillo", "74", 37.94911, 42.0121);
case 1243: return new CityInfo("Aydınkonak", "76", 37.89461, 41.16405);
case 1244: return new CityInfo("İbradı", "07", 37.09694, 31.59917);
case 1245: return new CityInfo("Aydıncık", "32", 36.1437, 33.32016);
case 1246: return new CityInfo("Aydın", "09", 37.84501, 27.83963);
case 1247: return new CityInfo("Avsallar", "07", 36.62448, 31.76941);
case 1248: return new CityInfo("Avanos", "50", 38.715, 34.84667);
case 1249: return new CityInfo("Atça", "09", 37.88859, 28.21528);
case 1250: return new CityInfo("Atburgazı", "09", 37.63639, 27.24611);
case 1251: return new CityInfo("Atabey", "33", 37.95083, 30.63861);
case 1252: return new CityInfo("Asmadere", "76", 37.91046, 41.36837);
case 1253: return new CityInfo("Aslanapa", "43", 39.21581, 29.8699);
case 1254: return new CityInfo("Aşkale", "25", 39.92083, 40.695);
case 1255: return new CityInfo("Aşağıpınarbaşı", "71", 38.03833, 32.60083);
case 1256: return new CityInfo("Aşağı Oylum", "63", 36.86391, 38.54485);
case 1257: return new CityInfo("Kale", "44", 38.41538, 38.77092);
case 1258: return new CityInfo("Aşağıdere", "80", 37.5132, 43.11967);
case 1259: return new CityInfo("Aşağıçiğil", "71", 38.0515, 31.86379);
case 1260: return new CityInfo("Aşağıbeylerbeyi", "90", 36.695, 37.52122);
case 1261: return new CityInfo("Aşağı Beğdeş", "63", 36.81472, 38.91917);
case 1262: return new CityInfo("Arslanlı", "63", 36.98737, 38.10125);
case 1263: return new CityInfo("Arslanköy", "32", 37.01884, 34.28741);
case 1264: return new CityInfo("Arpatepe", "72", 37.13829, 40.79739);
case 1265: return new CityInfo("Danişment", "58", 39.17153, 38.19851);
case 1266: return new CityInfo("Arıcak", "23", 38.5634, 40.1248);
case 1267: return new CityInfo("Arguvan", "44", 38.77375, 38.26328);
case 1268: return new CityInfo("Argıthanı", "71", 38.29259, 31.71452);
case 1269: return new CityInfo("Aras", "25", 39.98821, 42.30628);
case 1270: return new CityInfo("Yüreğir", "81", 36.97439, 35.35916);
case 1271: return new CityInfo("Arapgir", "44", 39.04117, 38.49516);
case 1272: return new CityInfo("Aran", "72", 37.44768, 40.74755);
case 1273: return new CityInfo("Aralık", "88", 39.87278, 44.51917);
case 1274: return new CityInfo("Aralık", "21", 37.82945, 40.68025);
case 1275: return new CityInfo("Araban", "83", 37.42667, 37.689);
case 1276: return new CityInfo("Yeşilyurt", "60", 40.0064, 36.22069);
case 1277: return new CityInfo("Antalya", "07", 36.90812, 30.69556);
case 1278: return new CityInfo("Antakya", "31", 36.20655, 36.15722);
case 1279: return new CityInfo("Ankara", "68", 39.91987, 32.85427);
case 1280: return new CityInfo("Andırın", "46", 37.57757, 36.35492);
case 1281: return new CityInfo("Andaç", "80", 37.355, 43.26395);
case 1282: return new CityInfo("Anamur", "32", 36.07508, 32.83691);
case 1283: return new CityInfo("Ambar", "21", 37.85305, 40.52798);
case 1284: return new CityInfo("Altınyayla", "58", 39.27249, 36.75098);
case 1285: return new CityInfo("Altınyayla", "15", 36.99722, 29.54579);
case 1286: return new CityInfo("Altınyaka", "07", 36.55861, 30.34833);
case 1287: return new CityInfo("Altıntaş", "43", 39.05972, 30.10917);
case 1288: return new CityInfo("Altınözü", "31", 36.11244, 36.24488);
case 1289: return new CityInfo("Altınova", "10", 39.2173, 26.79008);
case 1290: return new CityInfo("Altınoluk", "10", 39.57944, 26.73722);
case 1291: return new CityInfo("Altınkum", "21", 38.26374, 41.0625);
case 1292: return new CityInfo("Altunhisar", "73", 37.99159, 34.37334);
case 1293: return new CityInfo("Altınekin", "71", 38.30778, 32.86861);
case 1294: return new CityInfo("Alpu", "26", 39.76903, 30.9606);
case 1295: return new CityInfo("Alpköy", "24", 39.61393, 39.18639);
case 1296: return new CityInfo("Aliağa", "35", 38.79975, 26.97203);
case 1297: return new CityInfo("Gerger", "02", 38.02807, 39.03418);
case 1298: return new CityInfo("Albayrak", "65", 38.14252, 44.2012);
case 1299: return new CityInfo("Alaşehir", "45", 38.35083, 28.51718);
case 1300: return new CityInfo("Alanya", "07", 36.54375, 31.99982);
case 1301: return new CityInfo("Alakamış", "72", 37.15898, 41.78915);
case 1302: return new CityInfo("Alaçatı", "35", 38.28246, 26.37459);
case 1303: return new CityInfo("Turluk", "23", 39.44034, 39.87773);
case 1304: return new CityInfo("Alacahan", "58", 39.10667, 37.57556);
case 1305: return new CityInfo("Akyazı", "72", 37.16199, 40.56575);
case 1306: return new CityInfo("Aktuzla", "49", 39.33012, 42.28533);
case 1307: return new CityInfo("Aktepe", "31", 36.70161, 36.48535);
case 1308: return new CityInfo("Aktaş", "74", 37.95374, 41.80674);
case 1309: return new CityInfo("Aksu", "33", 37.79889, 31.07111);
case 1310: return new CityInfo("Aksu", "07", 36.95389, 30.84778);
case 1311: return new CityInfo("Aksoy", "72", 37.22608, 41.67253);
case 1312: return new CityInfo("Akseki", "07", 37.04861, 31.79);
case 1313: return new CityInfo("Akşehir", "71", 38.3575, 31.41639);
case 1314: return new CityInfo("Aksaray", "75", 38.37255, 34.02537);
case 1315: return new CityInfo("Akşar", "13", 38.1, 42.53333);
case 1316: return new CityInfo("Akpınar", "40", 39.45005, 33.96484);
case 1317: return new CityInfo("Akpınar", "02", 37.57389, 38.22077);
case 1318: return new CityInfo("Akören", "71", 37.45345, 32.3707);
case 1319: return new CityInfo("Akoba", "21", 37.9434, 41.05563);
case 1320: return new CityInfo("Akköy", "20", 37.95694, 29.07813);
case 1321: return new CityInfo("Akköy", "09", 37.49139, 27.26944);
case 1322: return new CityInfo("Akkışla", "38", 39.00222, 36.17381);
case 1323: return new CityInfo("Akkent", "20", 38.15268, 29.3789);
case 1324: return new CityInfo("Akıncılar", "02", 37.76444, 38.82308);
case 1325: return new CityInfo("Akıncı", "72", 37.16643, 40.84706);
case 1326: return new CityInfo("Akhisar", "45", 38.91852, 27.84006);
case 1327: return new CityInfo("Akdizgin", "80", 37.4358, 41.96164);
case 1328: return new CityInfo("Akdere", "32", 36.24083, 33.75041);
case 1329: return new CityInfo("Akdağmadeni", "66", 39.66028, 35.88361);
case 1330: return new CityInfo("Akçay", "07", 36.60217, 29.74626);
case 1331: return new CityInfo("Akçapınar", "62", 38.94728, 38.9423);
case 1332: return new CityInfo("Akçaova", "09", 37.50278, 28.02667);
case 1333: return new CityInfo("Akçakent", "40", 39.62278, 34.09583);
case 1334: return new CityInfo("Akçakale", "63", 36.71111, 38.9475);
case 1335: return new CityInfo("Akçadağ", "44", 38.33899, 37.97021);
case 1336: return new CityInfo("Akça", "76", 37.85424, 41.18276);
case 1337: return new CityInfo("Akbaş", "21", 37.97709, 41.05897);
case 1338: return new CityInfo("Akarsu", "24", 39.92878, 38.61382);
case 1339: return new CityInfo("Akarsu", "72", 37.22616, 41.05138);
case 1340: return new CityInfo("Akarçay", "63", 36.91917, 38.02694);
case 1341: return new CityInfo("Ahmetli", "45", 38.5196, 27.93865);
case 1342: return new CityInfo("Ahmetli", "21", 38.17817, 39.85627);
case 1343: return new CityInfo("Ahlat", "13", 38.7489, 42.48007);
case 1344: return new CityInfo("Ahırlı", "71", 37.23874, 32.11881);
case 1345: return new CityInfo("Ağlasun", "15", 37.64944, 30.53417);
case 1346: return new CityInfo("Ağın", "23", 38.93792, 38.71155);
case 1347: return new CityInfo("Akcakışla", "58", 39.53818, 36.33626);
case 1348: return new CityInfo("Ağaçören", "75", 38.87484, 33.91674);
case 1349: return new CityInfo("Ağaçlı", "21", 38.51728, 40.90401);
case 1350: return new CityInfo("Gülağaç", "75", 38.39576, 34.34576);
case 1351: return new CityInfo("Ağabeyli", "46", 37.73362, 37.11625);
case 1352: return new CityInfo("Afyonkarahisar", "03", 38.75667, 30.54333);
case 1353: return new CityInfo("Afşin", "46", 38.24769, 36.91399);
case 1354: return new CityInfo("Adıyaman", "02", 37.76441, 38.27629);
case 1355: return new CityInfo("Adilcevaz", "13", 38.79911, 42.73159);
case 1356: return new CityInfo("Adana", "81", 36.98615, 35.32531);
case 1357: return new CityInfo("Adaklı", "12", 39.2262, 40.48283);
case 1358: return new CityInfo("Acırlı", "72", 37.45549, 41.29499);
case 1359: return new CityInfo("Acıpınar", "75", 38.52671, 33.85225);
case 1360: return new CityInfo("Acıpayam", "20", 37.42385, 29.34941);
case 1361: return new CityInfo("Acıgöl", "50", 38.55028, 34.50917);
case 1362: return new CityInfo("Acarlar", "09", 37.82444, 27.74667);
case 1363: return new CityInfo("Çardaklı", "80", 37.23098, 42.58409);
case 1364: return new CityInfo("Ballı", "80", 37.41333, 42.83944);
case 1365: return new CityInfo("Yemişli", "80", 37.3671, 43.07717);
case 1366: return new CityInfo("Karsani", "70", 37.30716, 43.4541);
case 1367: return new CityInfo("Kayaboyun", "80", 37.47364, 42.10304);
case 1368: return new CityInfo("Nurdağı", "83", 37.16821, 36.73623);
case 1369: return new CityInfo("Gündoğan", "83", 36.87667, 37.54694);
case 1370: return new CityInfo("Yeşildere", "83", 36.973, 37.49488);
case 1371: return new CityInfo("Küçükkendirci", "63", 36.90583, 38.34611);
case 1372: return new CityInfo("Karatepe", "63", 36.8986, 38.88019);
case 1373: return new CityInfo("Tahılalan", "63", 36.85414, 38.97277);
case 1374: return new CityInfo("Mahmutlar", "31", 36.949, 36.19231);
case 1375: return new CityInfo("Gyuvench", "31", 36.68538, 36.42312);
case 1376: return new CityInfo("Konaklı", "31", 36.80583, 36.28528);
case 1377: return new CityInfo("Yedigöz", "90", 36.86577, 36.84433);
case 1378: return new CityInfo("Aşağı Karafakılı", "31", 36.77885, 36.55776);
case 1379: return new CityInfo("Zeytinli", "83", 36.95161, 37.42232);
case 1380: return new CityInfo("Çırtıman", "31", 36.52531, 36.18129);
case 1381: return new CityInfo("Kızkalesi", "31", 36.46192, 34.14199);
case 1382: return new CityInfo("Demirkonak", "31", 36.58249, 36.52744);
case 1383: return new CityInfo("Kuzeytepe", "31", 36.26505, 36.1535);
case 1384: return new CityInfo("Kastal", "31", 36.2476, 36.2409);
case 1385: return new CityInfo("Mansurlu", "31", 36.22083, 36.23083);
case 1386: return new CityInfo("Açıkdere", "31", 36.21909, 36.25992);
case 1387: return new CityInfo("Toygarlı", "31", 36.21261, 36.07262);
case 1388: return new CityInfo("Hancağız", "31", 36.15446, 36.08314);
case 1389: return new CityInfo("Çanakoluk", "31", 36.16696, 36.05527);
case 1390: return new CityInfo("Güneysöğüt", "31", 36.17356, 36.11215);
case 1391: return new CityInfo("Gümüşgöze", "31", 36.14785, 36.13284);
case 1392: return new CityInfo("Dursunlu", "31", 36.16736, 36.15788);
case 1393: return new CityInfo("Aşağıokçular", "31", 36.17802, 36.14033);
case 1394: return new CityInfo("Atayurdu", "31", 36.181, 36.27957);
case 1395: return new CityInfo("Boynuyoğun", "31", 36.16935, 36.34249);
case 1396: return new CityInfo("Uzunbağ", "31", 36.14023, 36.03603);
case 1397: return new CityInfo("Büyükçat", "31", 36.115, 36.0774);
case 1398: return new CityInfo("Balıklıdere", "31", 36.12096, 36.10481);
case 1399: return new CityInfo("Hacıpaşa", "31", 36.06907, 36.37076);
case 1400: return new CityInfo("Avuttepe", "31", 36.05115, 36.27609);
case 1401: return new CityInfo("Gözene", "31", 36.065, 36.00944);
case 1402: return new CityInfo("Samankaya", "31", 36.15027, 36.12829);
case 1403: return new CityInfo("Anayazı", "31", 36.32107, 36.19061);
case 1404: return new CityInfo("Karasüleymanlı", "31", 36.34191, 36.41431);
case 1405: return new CityInfo("Yeşilova", "31", 36.26903, 36.25434);
case 1406: return new CityInfo("Büyük Dalyan", "31", 36.28824, 36.20903);
case 1407: return new CityInfo("Doğanköy", "31", 36.23292, 36.10911);
case 1408: return new CityInfo("Günyazı", "31", 36.23307, 36.11702);
case 1409: return new CityInfo("Tepehan", "31", 36.15853, 36.2286);
case 1410: return new CityInfo("Uzunkavak", "31", 36.3524, 36.41952);
case 1411: return new CityInfo("Denizciler", "31", 36.6411, 36.21418);
case 1412: return new CityInfo("Balarmudu", "31", 36.64483, 36.40836);
case 1413: return new CityInfo("Ormandalı", "74", 37.94195, 42.48568);
case 1414: return new CityInfo("Atlıhan", "74", 37.9193, 42.82129);
case 1415: return new CityInfo("Yukarı Balcılar", "74", 37.90754, 42.61651);
case 1416: return new CityInfo("Başaran", "80", 37.47655, 43.12984);
case 1417: return new CityInfo("Doruklu", "80", 37.2555, 42.33518);
case 1418: return new CityInfo("Karasungur", "74", 37.88396, 42.33996);
case 1419: return new CityInfo("Kepezli", "63", 36.67889, 39.25333);
case 1420: return new CityInfo("Akdiken", "63", 36.725, 39.30861);
case 1421: return new CityInfo("Bulutlu", "63", 36.73583, 39.39389);
case 1422: return new CityInfo("Pekmezli", "63", 36.75361, 39.45);
case 1423: return new CityInfo("Büyük Tokaç", "63", 36.75278, 39.49639);
case 1424: return new CityInfo("Damlasu", "63", 36.78417, 39.43417);
case 1425: return new CityInfo("Saide", "63", 36.78389, 39.40972);
case 1426: return new CityInfo("Koyunluca", "63", 36.82278, 39.34333);
case 1427: return new CityInfo("Şuayıpşehri", "63", 36.86778, 39.37833);
case 1428: return new CityInfo("Yağmurlu", "63", 36.99722, 39.33944);
case 1429: return new CityInfo("Yolbaşı", "63", 36.9175, 39.47583);
case 1430: return new CityInfo("Büyük Çaylı", "63", 36.8425, 39.545);
case 1431: return new CityInfo("Büyükyıldız", "63", 36.79193, 39.52783);
case 1432: return new CityInfo("Aşağıdoruklu", "63", 36.90139, 40.13111);
case 1433: return new CityInfo("Boğalı", "63", 36.91917, 40.1575);
case 1434: return new CityInfo("Avcılı", "63", 36.93111, 40.1675);
case 1435: return new CityInfo("Damlacık", "63", 36.91528, 40.1025);
case 1436: return new CityInfo("Yukarı Taşyalak", "63", 36.96306, 40.13194);
case 1437: return new CityInfo("Aydoğdu", "63", 36.95, 40.14);
case 1438: return new CityInfo("Yukarı Karataş", "63", 36.92389, 40.05667);
case 1439: return new CityInfo("Işıklar", "63", 36.99417, 40.12639);
case 1440: return new CityInfo("Büyük Yenice", "63", 36.99028, 40.10222);
case 1441: return new CityInfo("Yeşiltepe", "63", 36.93694, 40.20917);
case 1442: return new CityInfo("Çıplak", "72", 36.94472, 40.2375);
case 1443: return new CityInfo("Kesmeköprü", "76", 37.71731, 41.4132);
case 1444: return new CityInfo("Akziyaret", "72", 37.19737, 40.49844);
case 1445: return new CityInfo("Odabaşı", "72", 37.10479, 41.46269);
case 1446: return new CityInfo("Batikent", "68", 39.96833, 32.73083);
case 1447: return new CityInfo("Türkler", "07", 36.60198, 31.82067);
case 1448: return new CityInfo("Başyayla", "78", 36.75337, 32.68018);
case 1449: return new CityInfo("Dalaman", "48", 36.76591, 28.8028);
case 1450: return new CityInfo("Zonguldak", "85", 41.45139, 31.79305);
case 1451: return new CityInfo("Zile", "60", 40.30306, 35.88639);
case 1452: return new CityInfo("Zeytinlik", "08", 41.11013, 41.85816);
case 1453: return new CityInfo("Zeytinburnu", "34", 40.99441, 28.90417);
case 1454: return new CityInfo("Zeytinbağı", "16", 40.39083, 28.79639);
case 1455: return new CityInfo("Yuvacık", "41", 40.68815, 29.96738);
case 1456: return new CityInfo("Yusufeli", "08", 40.82042, 41.53743);
case 1457: return new CityInfo("Yürük", "59", 40.93553, 27.06631);
case 1458: return new CityInfo("Yomra", "61", 40.95326, 39.85546);
case 1459: return new CityInfo("Yoğuntaş", "39", 41.83081, 27.06971);
case 1460: return new CityInfo("Boztepe", "60", 40.18778, 35.8875);
case 1461: return new CityInfo("Yığılca", "93", 40.95983, 31.44355);
case 1462: return new CityInfo("Yeşilyurt", "60", 40.32786, 36.35144);
case 1463: return new CityInfo("Yeşilvadi", "34", 41.123, 29.47696);
case 1464: return new CityInfo("Yeşilce", "52", 40.53577, 37.79566);
case 1465: return new CityInfo("Yenişehir", "16", 40.26444, 29.65306);
case 1466: return new CityInfo("Yenipazar", "11", 40.17833, 30.52);
case 1467: return new CityInfo("Yeniköy", "16", 40.53568, 29.35364);
case 1468: return new CityInfo("Yenice", "16", 40.08778, 29.42194);
case 1469: return new CityInfo("Yenice", "89", 41.19962, 32.33133);
case 1470: return new CityInfo("Yeniçağa", "14", 40.77115, 32.03375);
case 1471: return new CityInfo("Yavuzkemal", "28", 40.69329, 38.33723);
case 1472: return new CityInfo("Körfez", "41", 40.76704, 29.78275);
case 1473: return new CityInfo("Yapraklı", "82", 40.75785, 33.77819);
case 1474: return new CityInfo("Yalova", "92", 40.65501, 29.27693);
case 1475: return new CityInfo("Yalnızçam", "86", 41.06444, 42.50081);
case 1476: return new CityInfo("Yalakdere", "41", 40.60636, 29.56225);
case 1477: return new CityInfo("Yakuplu", "34", 40.98894, 28.67582);
case 1478: return new CityInfo("Yakakent", "55", 41.6325, 35.52889);
case 1479: return new CityInfo("Yağmurdere", "69", 40.57487, 39.86244);
case 1480: return new CityInfo("Yağlıdere", "28", 40.85672, 38.62035);
case 1481: return new CityInfo("Yağlıdere", "69", 40.54432, 39.52762);
case 1482: return new CityInfo("Vize", "39", 41.5725, 27.76583);
case 1483: return new CityInfo("Vezirköprü", "55", 41.14361, 35.45472);
case 1484: return new CityInfo("Vezirhan", "11", 40.24472, 30.02);
case 1485: return new CityInfo("Velimeşe", "59", 41.25361, 27.87833);
case 1486: return new CityInfo("Veliköy", "08", 41.31528, 42.4325);
case 1487: return new CityInfo("Vakfıkebir", "61", 41.04583, 39.27639);
case 1488: return new CityInfo("Uzunköprü", "22", 41.26597, 26.6885);
case 1489: return new CityInfo("Uzunisa", "52", 40.91465, 37.84818);
case 1490: return new CityInfo("Uzungöl", "61", 40.61594, 40.28853);
case 1491: return new CityInfo("Uzundere", "25", 40.53218, 41.53832);
case 1492: return new CityInfo("Üsküp", "39", 41.73583, 27.40528);
case 1493: return new CityInfo("Üsküdar", "34", 41.02274, 29.01366);
case 1494: return new CityInfo("Uruş", "68", 40.24903, 32.13785);
case 1495: return new CityInfo("Ünye", "52", 41.13139, 37.2825);
case 1496: return new CityInfo("Şenyurt", "25", 40.42645, 41.42826);
case 1497: return new CityInfo("Umurbey", "16", 40.41472, 29.18306);
case 1498: return new CityInfo("Umurbey", "17", 40.23373, 26.60632);
case 1499: return new CityInfo("Umraniye", "34", 41.01643, 29.12476);
case 1500: return new CityInfo("Ulus", "87", 41.58417, 32.64139);
case 1501: return new CityInfo("Ulubey", "52", 40.86863, 37.75405);
case 1502: return new CityInfo("Ulaşlı", "41", 40.70583, 29.69608);
case 1503: return new CityInfo("Uğurludağ", "19", 40.44631, 34.45259);
case 1504: return new CityInfo("Ovacık", "25", 40.20049, 40.99727);
case 1505: return new CityInfo("Tuzluca", "88", 40.03871, 43.65208);
case 1506: return new CityInfo("Tütüncü", "10", 40.06694, 27.71972);
case 1507: return new CityInfo("Gülyalı", "52", 40.96153, 38.04937);
case 1508: return new CityInfo("Türkeli", "57", 41.94764, 34.33861);
case 1509: return new CityInfo("Turhal", "60", 40.3875, 36.08111);
case 1510: return new CityInfo("Trabzon", "61", 41.005, 39.72694);
case 1511: return new CityInfo("Tosya", "37", 41.01545, 34.04013);
case 1512: return new CityInfo("Torul", "69", 40.55071, 39.28344);
case 1513: return new CityInfo("Tortum", "25", 40.28892, 41.54096);
case 1514: return new CityInfo("Topçam", "52", 40.61658, 37.77057);
case 1515: return new CityInfo("Tonya", "61", 40.88402, 39.28486);
case 1516: return new CityInfo("Tokat", "60", 40.31389, 36.55444);
case 1517: return new CityInfo("Tirebolu", "28", 41.00694, 38.81389);
case 1518: return new CityInfo("Terme", "55", 41.20917, 36.97389);
case 1519: return new CityInfo("Tepecik", "34", 41.02931, 28.54978);
case 1520: return new CityInfo("Tekkiraz", "52", 40.98588, 37.16028);
case 1521: return new CityInfo("Tekkeköy", "55", 41.21167, 36.46);
case 1522: return new CityInfo("Tekke", "05", 40.71556, 36.19247);
case 1523: return new CityInfo("Tekirdağ", "59", 40.9781, 27.51101);
case 1524: return new CityInfo("Teke", "34", 41.0605, 29.65381);
case 1525: return new CityInfo("Tavşanlı", "41", 40.81876, 29.51136);
case 1526: return new CityInfo("Tavşancıl", "41", 40.77083, 29.57194);
case 1527: return new CityInfo("Tatkavaklı", "16", 40.03333, 28.36667);
case 1528: return new CityInfo("Taşova", "05", 40.75972, 36.3225);
case 1529: return new CityInfo("Taşköprü", "37", 41.5098, 34.21414);
case 1530: return new CityInfo("Taşköprü", "92", 40.67361, 29.39111);
case 1531: return new CityInfo("Zigopor", "08", 40.94745, 41.49477);
case 1532: return new CityInfo("Taraklı", "54", 40.39694, 30.49278);
case 1533: return new CityInfo("Taflan", "55", 41.40944, 36.12889);
case 1534: return new CityInfo("Tacir", "16", 40.52556, 29.73972);
case 1535: return new CityInfo("Susuzmüsellim", "59", 41.09889, 27.0675);
case 1536: return new CityInfo("Susuz", "84", 40.7791, 43.12769);
case 1537: return new CityInfo("Suşehri", "58", 40.16005, 38.08413);
case 1538: return new CityInfo("Sürmene", "61", 40.90588, 40.12792);
case 1539: return new CityInfo("Sungurlu", "19", 40.1675, 34.37389);
case 1540: return new CityInfo("Suluova", "05", 40.83129, 35.64788);
case 1541: return new CityInfo("Sultanköy", "59", 41.02139, 27.98861);
case 1542: return new CityInfo("Süloğlu", "22", 41.76901, 26.90999);
case 1543: return new CityInfo("Sulakyurt", "79", 40.15733, 33.716);
case 1544: return new CityInfo("Sölöz", "16", 40.3948, 29.41559);
case 1545: return new CityInfo("Mahmudiye", "16", 40.33787, 28.64945);
case 1546: return new CityInfo("Söğütlü", "54", 40.9059, 30.47448);
case 1547: return new CityInfo("Soldere", "16", 40.06089, 28.57231);
case 1548: return new CityInfo("Soğuksu", "92", 40.6707, 29.50819);
case 1549: return new CityInfo("Soğukpınar", "16", 40.05472, 29.12278);
case 1550: return new CityInfo("Şişli", "34", 41.06046, 28.98717);
case 1551: return new CityInfo("Sırpsındığı", "22", 41.78124, 26.47888);
case 1552: return new CityInfo("Şiran", "69", 40.19064, 39.11747);
case 1553: return new CityInfo("Sinop", "57", 42.02683, 35.16253);
case 1554: return new CityInfo("Sinekli", "34", 41.22798, 28.19043);
case 1555: return new CityInfo("Sinekçi", "17", 40.27073, 27.40667);
case 1556: return new CityInfo("Silivri", "34", 41.07393, 28.24644);
case 1557: return new CityInfo("Şile", "34", 41.1754, 29.61333);
case 1558: return new CityInfo("Seyitler", "08", 41.19484, 41.83696);
case 1559: return new CityInfo("Şeyhli", "55", 40.92194, 36.06333);
case 1560: return new CityInfo("Seydim", "19", 40.54302, 34.73812);
case 1561: return new CityInfo("Seydiler", "37", 41.62005, 33.71815);
case 1562: return new CityInfo("Şevketiye", "10", 40.09347, 27.84667);
case 1563: return new CityInfo("Sergen", "39", 41.70528, 27.70833);
case 1564: return new CityInfo("Şerefiye", "58", 40.11195, 37.75624);
case 1565: return new CityInfo("Serdivan", "54", 40.77376, 30.38006);
case 1566: return new CityInfo("Şenpazar", "37", 41.8089, 33.23135);
case 1567: return new CityInfo("Şenkaya", "25", 40.55652, 42.34266);
case 1568: return new CityInfo("Selimpaşa", "34", 41.05448, 28.36678);
case 1569: return new CityInfo("Selim", "84", 40.45772, 42.78287);
case 1570: return new CityInfo("Seçköy", "16", 40.32389, 29.19639);
case 1571: return new CityInfo("Şebin Karahisar", "28", 40.28833, 38.42361);
case 1572: return new CityInfo("Seben", "14", 40.41134, 31.57359);
case 1573: return new CityInfo("Şavşat", "08", 41.24027, 42.36109);
case 1574: return new CityInfo("Şarköy", "59", 40.61395, 27.11563);
case 1575: return new CityInfo("Sarıköy", "10", 40.2075, 27.59611);
case 1576: return new CityInfo("Sarıkamış", "84", 40.32769, 42.58705);
case 1577: return new CityInfo("Sarıbuğday", "05", 40.74806, 35.45972);
case 1578: return new CityInfo("Saraydüzü", "57", 41.32865, 34.84686);
case 1579: return new CityInfo("Saraycık", "05", 40.95017, 35.11165);
case 1580: return new CityInfo("Saray", "59", 41.44431, 27.92194);
case 1581: return new CityInfo("Sapanca", "54", 40.69141, 30.26738);
case 1582: return new CityInfo("Sansarak", "16", 40.48861, 29.82944);
case 1583: return new CityInfo("Samsun", "55", 41.27976, 36.3361);
case 1584: return new CityInfo("Samandıra", "34", 40.999, 29.22565);
case 1585: return new CityInfo("Şalpazarı", "61", 40.93826, 39.19006);
case 1586: return new CityInfo("Şahin", "59", 41.02167, 26.8425);
case 1587: return new CityInfo("Safranbolu", "89", 41.25083, 32.69417);
case 1588: return new CityInfo("Şabanözü", "82", 40.48249, 33.28352);
case 1589: return new CityInfo("Rize", "53", 41.02083, 40.52194);
case 1590: return new CityInfo("Reşadiye", "60", 40.39194, 37.3375);
case 1591: return new CityInfo("Pursaklar", "68", 40.03203, 32.89528);
case 1592: return new CityInfo("Posof", "86", 41.51111, 42.72917);
case 1593: return new CityInfo("Piraziz", "52", 40.95299, 38.1089);
case 1594: return new CityInfo("Piraziz", "28", 40.92244, 38.12458);
case 1595: return new CityInfo("Pınarhisar", "39", 41.62417, 27.52);
case 1596: return new CityInfo("Pınarbaşı", "37", 41.60388, 33.11099);
case 1597: return new CityInfo("Perşembe", "52", 41.06556, 37.77139);
case 1598: return new CityInfo("Pendik", "34", 40.8775, 29.2725);
case 1599: return new CityInfo("Pehlivanköy", "39", 41.34812, 26.92522);
case 1600: return new CityInfo("Peçenek", "68", 40.41857, 32.30833);
case 1601: return new CityInfo("Pazaryolu", "25", 40.41142, 40.7678);
case 1602: return new CityInfo("Pazarköy", "14", 40.92555, 32.1807);
case 1603: return new CityInfo("Pazar", "53", 41.17917, 40.88417);
case 1604: return new CityInfo("Pazar", "68", 40.33027, 32.7482);
case 1605: return new CityInfo("Pazar", "60", 40.27652, 36.28347);
case 1606: return new CityInfo("Pamukova", "54", 40.5081, 30.16732);
case 1607: return new CityInfo("Ovacuma", "89", 41.4485, 32.75361);
case 1608: return new CityInfo("Ovacık", "89", 41.07661, 32.91994);
case 1609: return new CityInfo("Yenikonak", "57", 41.87319, 34.60308);
case 1610: return new CityInfo("Osmaneli", "11", 40.35722, 30.01417);
case 1611: return new CityInfo("Osmancık", "19", 40.97818, 34.8047);
case 1612: return new CityInfo("Ortaköy", "08", 41.25104, 41.98363);
case 1613: return new CityInfo("Ortaköy", "34", 41.10154, 28.37588);
case 1614: return new CityInfo("Hemşin", "53", 41.04777, 40.8984);
case 1615: return new CityInfo("Ortakent", "58", 40.39367, 38.01028);
case 1616: return new CityInfo("Ortaköy", "19", 40.27352, 35.25175);
case 1617: return new CityInfo("Ortacalar", "08", 41.27896, 41.37887);
case 1618: return new CityInfo("Orta", "82", 40.6242, 33.10928);
case 1619: return new CityInfo("Ormanlı", "85", 41.16472, 31.61417);
case 1620: return new CityInfo("Orhaniye", "16", 40.50611, 29.65972);
case 1621: return new CityInfo("Orhangazi", "16", 40.48917, 29.30889);
case 1622: return new CityInfo("Ordu", "52", 40.97782, 37.89047);
case 1623: return new CityInfo("Olur", "25", 40.82165, 42.13055);
case 1624: return new CityInfo("Oltu", "25", 40.53945, 41.98722);
case 1625: return new CityInfo("Öğdem", "08", 40.91728, 41.63612);
case 1626: return new CityInfo("Of", "61", 40.94055, 40.25918);
case 1627: return new CityInfo("Nüzhetiye", "41", 40.64, 29.86306);
case 1628: return new CityInfo("Niksar", "60", 40.59167, 36.95167);
case 1629: return new CityInfo("Narman", "25", 40.34449, 41.86088);
case 1630: return new CityInfo("Narlıca", "16", 40.38583, 29.48111);
case 1631: return new CityInfo("Nallıhan", "68", 40.18593, 31.35179);
case 1632: return new CityInfo("Mustafakemalpaşa", "16", 40.03815, 28.40866);
case 1633: return new CityInfo("Muratlı", "08", 41.47405, 41.70647);
case 1634: return new CityInfo("Muratlı", "59", 41.17216, 27.4992);
case 1635: return new CityInfo("Mudurnu", "14", 40.473, 31.20755);
case 1636: return new CityInfo("Mudanya", "16", 40.37528, 28.88222);
case 1637: return new CityInfo("Mimarsinan", "34", 41.0179, 28.56176);
case 1638: return new CityInfo("Mihalgazi", "26", 40.02621, 30.57707);
case 1639: return new CityInfo("Mezraa", "55", 41.19764, 35.11684);
case 1640: return new CityInfo("Meydancık", "08", 41.40964, 42.2364);
case 1641: return new CityInfo("Mesudiye", "52", 40.45446, 37.77353);
case 1642: return new CityInfo("Merzifon", "05", 40.87333, 35.46306);
case 1643: return new CityInfo("Meriç", "22", 41.19183, 26.42097);
case 1644: return new CityInfo("Mengen", "14", 40.93877, 32.07642);
case 1645: return new CityInfo("Mecitözü", "19", 40.52, 35.29528);
case 1646: return new CityInfo("Mecidiye", "22", 40.63889, 26.53917);
case 1647: return new CityInfo("Marmara Ereğlisi", "59", 40.96907, 27.95503);
case 1648: return new CityInfo("Marmaracık", "59", 41.20667, 27.75444);
case 1649: return new CityInfo("Marmara", "10", 40.58633, 27.55541);
case 1650: return new CityInfo("Manyas", "10", 40.04639, 27.97);
case 1651: return new CityInfo("Maltepe", "34", 40.93567, 29.15507);
case 1652: return new CityInfo("Malkara", "59", 40.89, 26.90111);
case 1653: return new CityInfo("Mahmut Şevket Paşa", "34", 41.15281, 29.18968);
case 1654: return new CityInfo("Mahmutbey", "34", 41.05361, 28.82556);
case 1655: return new CityInfo("Maden", "77", 40.18139, 40.40417);
case 1656: return new CityInfo("Maçka", "61", 40.81072, 39.60465);
case 1657: return new CityInfo("Lüleburgaz", "39", 41.40385, 27.35918);
case 1658: return new CityInfo("Lapseki", "17", 40.34417, 26.68556);
case 1659: return new CityInfo("Lâlapaşa", "22", 41.83951, 26.73561);
case 1660: return new CityInfo("Ladik", "55", 40.91056, 35.89194);
case 1661: return new CityInfo("Kuzyaka", "37", 41.232, 33.72267);
case 1662: return new CityInfo("Kurucaşile", "87", 41.83781, 32.71621);
case 1663: return new CityInfo("Kurtkale", "86", 41.26546, 43.1258);
case 1664: return new CityInfo("Kurşunlu", "82", 40.84101, 33.26028);
case 1665: return new CityInfo("Kurşunlu", "16", 40.03712, 29.65972);
case 1666: return new CityInfo("Küre", "37", 41.80578, 33.71161);
case 1667: return new CityInfo("Küplü", "22", 41.10694, 26.35194);
case 1668: return new CityInfo("Küplü", "11", 40.09837, 30.0001);
case 1669: return new CityInfo("Kumru", "52", 40.87444, 37.26389);
case 1670: return new CityInfo("Kumluca", "87", 41.44724, 32.46759);
case 1671: return new CityInfo("Kumburgaz", "34", 41.02108, 28.48033);
case 1672: return new CityInfo("Kumbağ", "59", 40.88236, 27.45919);
case 1673: return new CityInfo("Kullar", "41", 40.72419, 29.98943);
case 1674: return new CityInfo("Küçükkumla", "16", 40.47047, 29.10152);
case 1675: return new CityInfo("Küçükdere", "61", 40.80748, 40.05512);
case 1676: return new CityInfo("Kozluören", "16", 40.12639, 29.35278);
case 1677: return new CityInfo("Kozlu", "85", 41.43194, 31.74583);
case 1678: return new CityInfo("Kozlu", "60", 40.60878, 36.47858);
case 1679: return new CityInfo("Kozcağız", "87", 41.48333, 32.33333);
case 1680: return new CityInfo("Koyulhisar", "58", 40.30184, 37.82336);
case 1681: return new CityInfo("Kovanlık", "28", 40.75484, 38.11155);
case 1682: return new CityInfo("Kötek", "84", 40.2185, 43.0022);
case 1683: return new CityInfo("Köseköy", "41", 40.74012, 30.00556);
case 1684: return new CityInfo("Köse", "69", 40.20692, 39.64626);
case 1685: return new CityInfo("Koruköy", "92", 40.65435, 29.16289);
case 1686: return new CityInfo("Korgun", "82", 40.73479, 33.51844);
case 1687: return new CityInfo("Korgan", "52", 40.82472, 37.34667);
case 1688: return new CityInfo("Köprübaşı", "61", 40.80692, 40.11439);
case 1689: return new CityInfo("Konuralp", "93", 40.90538, 31.14568);
case 1690: return new CityInfo("Kolay", "55", 41.41824, 35.80136);
case 1691: return new CityInfo("Saltukova", "85", 41.52022, 32.09621);
case 1692: return new CityInfo("Kofçaz", "39", 41.94481, 27.15829);
case 1693: return new CityInfo("Kocadere", "92", 40.63, 29.03);
case 1694: return new CityInfo("Kocaali", "54", 41.05336, 30.85278);
case 1695: return new CityInfo("Kızılırmak", "82", 40.34556, 33.98639);
case 1696: return new CityInfo("Kızılcahamam", "68", 40.46972, 32.65056);
case 1697: return new CityInfo("Salmydessus", "39", 41.63476, 28.09459);
case 1698: return new CityInfo("Kışlaköy", "25", 40.32353, 42.02233);
case 1699: return new CityInfo("Kırklareli", "39", 41.73508, 27.22521);
case 1700: return new CityInfo("Kırcasalih", "22", 41.39019, 26.79496);
case 1701: return new CityInfo("Dikmen", "57", 41.65, 35.26667);
case 1702: return new CityInfo("Gelegra", "68", 40.01378, 31.83197);
case 1703: return new CityInfo("Kirazlı", "16", 40.09964, 29.04163);
case 1704: return new CityInfo("Kirazlı", "17", 40.04176, 26.7009);
case 1705: return new CityInfo("Kınalı", "34", 40.90713, 29.05499);
case 1706: return new CityInfo("Kilimli", "85", 41.49111, 31.83861);
case 1707: return new CityInfo("Kılıçkaya", "08", 40.70471, 41.47385);
case 1708: return new CityInfo("Kılıç", "92", 40.63306, 29.39472);
case 1709: return new CityInfo("Kıbrıscık", "14", 40.40778, 31.85194);
case 1710: return new CityInfo("Kestel", "16", 40.19828, 29.21237);
case 1711: return new CityInfo("Keşap", "28", 40.91032, 38.5013);
case 1712: return new CityInfo("Keşan", "22", 40.85583, 26.63028);
case 1713: return new CityInfo("Kemerburgaz", "34", 41.15902, 28.91572);
case 1714: return new CityInfo("Kemalpaşa", "08", 41.48336, 41.5275);
case 1715: return new CityInfo("Kelkit", "69", 40.12682, 39.43424);
case 1716: return new CityInfo("Kefken", "41", 41.16833, 30.22972);
case 1717: return new CityInfo("Kazan", "68", 40.23167, 32.68389);
case 1718: return new CityInfo("Kaytazdere", "92", 40.68225, 29.53236);
case 1719: return new CityInfo("Kaynaşlı", "93", 40.76917, 31.32211);
case 1720: return new CityInfo("Kaynarca", "54", 41.03083, 30.3075);
case 1721: return new CityInfo("Kaynarca", "16", 40.41444, 29.82556);
case 1722: return new CityInfo("Kaymas", "41", 40.9231, 30.26597);
case 1723: return new CityInfo("Kavaklı", "34", 41.09258, 28.33172);
case 1724: return new CityInfo("Kavak", "55", 41.07833, 36.0425);
case 1725: return new CityInfo("Kastamonu", "37", 41.37805, 33.77528);
case 1726: return new CityInfo("Beycuma", "85", 41.32812, 31.96811);
case 1727: return new CityInfo("Kars", "84", 40.59825, 43.08548);
case 1728: return new CityInfo("Kargı", "19", 41.13373, 34.48744);
case 1729: return new CityInfo("Karayaka", "60", 40.74402, 36.59018);
case 1730: return new CityInfo("Karaurgan", "84", 40.23964, 42.27283);
case 1731: return new CityInfo("Karasu", "54", 41.10442, 30.69664);
case 1732: return new CityInfo("Karasu Mahallesi", "54", 41.07096, 30.78543);
case 1733: return new CityInfo("Karaşar", "68", 40.32573, 31.98682);
case 1734: return new CityInfo("Karapürçek", "54", 40.64194, 30.53944);
case 1735: return new CityInfo("Oğuzlar", "19", 40.75353, 34.70275);
case 1736: return new CityInfo("Karamürsel", "41", 40.69129, 29.61649);
case 1737: return new CityInfo("Karakurt", "84", 40.16591, 42.60453);
case 1738: return new CityInfo("Karakasım", "22", 41.51718, 26.64381);
case 1739: return new CityInfo("Çat", "41", 40.95423, 29.80598);
case 1740: return new CityInfo("Karadere", "54", 40.73174, 30.83992);
case 1741: return new CityInfo("Karacaköy", "34", 41.40338, 28.38055);
case 1742: return new CityInfo("Karacaköy", "34", 41.15126, 29.76935);
case 1743: return new CityInfo("Karacabey", "16", 40.21323, 28.3612);
case 1744: return new CityInfo("Karacaali", "16", 40.47944, 29.06833);
case 1745: return new CityInfo("Karabulduk", "28", 40.82043, 38.54941);
case 1746: return new CityInfo("Karabük", "89", 41.20488, 32.62768);
case 1747: return new CityInfo("Karabiga", "17", 40.40361, 27.30389);
case 1748: return new CityInfo("Kaptanpaşa", "53", 40.96067, 40.78238);
case 1749: return new CityInfo("Kapaklı", "59", 41.32912, 27.98064);
case 1750: return new CityInfo("Kandıra", "41", 41.07, 30.15262);
case 1751: return new CityInfo("Kâmil", "19", 41.10364, 34.76298);
case 1752: return new CityInfo("Kalkandere", "53", 40.92046, 40.43692);
case 1753: return new CityInfo("Kalecik", "68", 40.09722, 33.40833);
case 1754: return new CityInfo("Kale", "69", 40.38688, 39.68332);
case 1755: return new CityInfo("Kağızman", "84", 40.15669, 43.13424);
case 1756: return new CityInfo("Evreşe", "17", 40.66667, 26.88333);
case 1757: return new CityInfo("Kadıköy", "92", 40.62015, 29.22536);
case 1758: return new CityInfo("Kabataş", "52", 40.75, 37.45);
case 1759: return new CityInfo("Kabalı", "57", 41.85211, 35.06249);
case 1760: return new CityInfo("Kabadüz", "52", 40.86096, 37.8847);
case 1761: return new CityInfo("İznik", "16", 40.42861, 29.72111);
case 1762: return new CityInfo("İzmit", "41", 40.76499, 29.92928);
case 1763: return new CityInfo("İyidere", "53", 41.01192, 40.36185);
case 1764: return new CityInfo("Istanbul", "34", 41.01384, 28.94966);
case 1765: return new CityInfo("İspir", "25", 40.47981, 40.99373);
case 1766: return new CityInfo("İskilip", "19", 40.73528, 34.47389);
case 1767: return new CityInfo("İpsala", "22", 40.92115, 26.38273);
case 1768: return new CityInfo("İntepe", "17", 40.01333, 26.33287);
case 1769: return new CityInfo("Boyalı", "37", 41.0271, 33.3041);
case 1770: return new CityInfo("İnhisar", "11", 40.04932, 30.38521);
case 1771: return new CityInfo("İnegol", "16", 40.07806, 29.51333);
case 1772: return new CityInfo("İnecik", "59", 40.93518, 27.28118);
case 1773: return new CityInfo("İnece", "39", 41.67747, 27.06786);
case 1774: return new CityInfo("İnebolu", "37", 41.97472, 33.76083);
case 1775: return new CityInfo("Gökçeada", "17", 40.20107, 25.90902);
case 1776: return new CityInfo("Yarhisar", "11", 40.21673, 29.87088);
case 1777: return new CityInfo("Ilgaz", "82", 40.92511, 33.62586);
case 1778: return new CityInfo("İkizören", "82", 40.68833, 33.88333);
case 1779: return new CityInfo("İkizdere", "53", 40.77484, 40.55227);
case 1780: return new CityInfo("İkizce", "52", 41.05833, 37.08028);
case 1781: return new CityInfo("İhsaniye", "41", 40.69087, 29.83472);
case 1782: return new CityInfo("İhsangazi", "37", 41.20432, 33.55455);
case 1783: return new CityInfo("İğneada", "39", 41.87444, 27.98389);
case 1784: return new CityInfo("İğdir", "37", 41.22617, 33.13699);
case 1785: return new CityInfo("İğdir", "60", 40.26633, 35.62645);
case 1786: return new CityInfo("İbriktepe", "22", 41.01037, 26.50343);
case 1787: return new CityInfo("Horasan", "25", 40.03885, 42.16366);
case 1788: return new CityInfo("Hopa", "08", 41.39046, 41.41966);
case 1789: return new CityInfo("Filyos", "85", 41.55383, 32.02389);
case 1790: return new CityInfo("Hereke", "41", 40.78611, 29.61472);
case 1791: return new CityInfo("Hendek", "54", 40.79944, 30.74806);
case 1792: return new CityInfo("Nurluca", "53", 41.03519, 40.90584);
case 1793: return new CityInfo("Güzelkent", "57", 41.94843, 34.3945);
case 1794: return new CityInfo("Hayrat", "61", 40.8853, 40.36495);
case 1795: return new CityInfo("Hayrabolu", "59", 41.21311, 27.10688);
case 1796: return new CityInfo("Havza", "55", 40.97056, 35.66222);
case 1797: return new CityInfo("Havsa", "22", 41.54898, 26.82207);
case 1798: return new CityInfo("Hasköy", "22", 41.63822, 26.85746);
case 1799: return new CityInfo("Hasköy", "86", 40.99106, 42.88396);
case 1800: return new CityInfo("Hasayaz", "68", 40.24067, 33.328);
case 1801: return new CityInfo("Hanönü", "37", 41.62705, 34.46667);
case 1802: return new CityInfo("Hanak", "86", 41.23344, 42.84037);
case 1803: return new CityInfo("Hamzabey", "16", 40.13583, 29.52639);
case 1804: return new CityInfo("Hamidiye", "22", 41.15128, 26.66411);
case 1805: return new CityInfo("Dedeköy", "05", 40.74752, 35.04249);
case 1806: return new CityInfo("Hamamözü", "05", 40.78476, 35.0258);
case 1807: return new CityInfo("Perşembe", "85", 41.41867, 32.15984);
case 1808: return new CityInfo("Hacıhamza", "19", 41.0743, 34.449);
case 1809: return new CityInfo("Dokurcun", "54", 40.5732, 30.86784);
case 1810: return new CityInfo("Çayırova", "41", 40.83444, 29.4);
case 1811: return new CityInfo("Güvem", "68", 40.59069, 32.66111);
case 1812: return new CityInfo("Gürsu", "16", 40.21876, 29.19487);
case 1813: return new CityInfo("Gürpınar", "34", 40.99256, 28.61428);
case 1814: return new CityInfo("Gürgentepe", "52", 40.78567, 37.58969);
case 1815: return new CityInfo("Güneysu", "53", 40.9813, 40.60465);
case 1816: return new CityInfo("Kırık", "25", 40.32794, 40.91863);
case 1817: return new CityInfo("Güneyce", "53", 40.82095, 40.47035);
case 1818: return new CityInfo("Gündoğdu", "53", 41.05319, 40.60664);
case 1819: return new CityInfo("Gündoğdu", "17", 40.26408, 27.09288);
case 1820: return new CityInfo("Gümüşova", "93", 40.84694, 30.94111);
case 1821: return new CityInfo("Gumushkhane", "69", 40.46001, 39.47176);
case 1822: return new CityInfo("Gümüşhacıköy", "05", 40.87306, 35.21472);
case 1823: return new CityInfo("Dimetoka", "17", 40.28228, 27.28205);
case 1824: return new CityInfo("Gümüş", "05", 40.84018, 35.17195);
case 1825: return new CityInfo("Güdül", "68", 40.21051, 32.24552);
case 1826: return new CityInfo("Akkaya", "37", 41.21913, 33.48487);
case 1827: return new CityInfo("Göynük", "14", 40.40028, 30.78833);
case 1828: return new CityInfo("Göynücek", "05", 40.39917, 35.525);
case 1829: return new CityInfo("Görükle", "16", 40.23114, 28.84017);
case 1830: return new CityInfo("Görele", "28", 41.03083, 39.00306);
case 1831: return new CityInfo("Gönen", "10", 40.1049, 27.65399);
case 1832: return new CityInfo("Gölyaka", "93", 40.7769, 30.99587);
case 1833: return new CityInfo("Gölpazarı", "11", 40.28472, 30.31722);
case 1834: return new CityInfo("Gölova", "58", 40.06194, 38.60667);
case 1835: return new CityInfo("Balarim", "16", 40.37381, 29.59025);
case 1836: return new CityInfo("Kömürlü", "25", 40.73539, 42.28819);
case 1837: return new CityInfo("Gölköy", "52", 40.68689, 37.61544);
case 1838: return new CityInfo("Göle", "86", 40.78746, 42.60603);
case 1839: return new CityInfo("Gölcük", "41", 40.70323, 29.87216);
case 1840: return new CityInfo("Gölcük", "16", 40.27639, 29.37833);
case 1841: return new CityInfo("Murgul", "08", 41.27937, 41.55514);
case 1842: return new CityInfo("Gökdere", "60", 40.47292, 36.7525);
case 1843: return new CityInfo("Gökçeli", "60", 40.58333, 36.73333);
case 1844: return new CityInfo("Gökçesu", "14", 40.89389, 31.95957);
case 1845: return new CityInfo("Gökçekent", "58", 40.28644, 38.11771);
case 1846: return new CityInfo("Gökçebey", "85", 41.30583, 32.14234);
case 1847: return new CityInfo("Göbel", "10", 40.01972, 28.14556);
case 1848: return new CityInfo("Giresun", "28", 40.91698, 38.38741);
case 1849: return new CityInfo("Geyve", "54", 40.5075, 30.2925);
case 1850: return new CityInfo("Gerze", "57", 41.80361, 35.20111);
case 1851: return new CityInfo("Gerede", "14", 40.80083, 32.19694);
case 1852: return new CityInfo("Çiftlik", "25", 40.07234, 42.25617);
case 1853: return new CityInfo("Gemlik", "16", 40.43094, 29.15969);
case 1854: return new CityInfo("Gelibolu", "17", 40.41028, 26.67083);
case 1855: return new CityInfo("Gediksaray", "05", 40.44529, 35.62627);
case 1856: return new CityInfo("Gebze", "41", 40.80276, 29.43068);
case 1857: return new CityInfo("Gaziler", "25", 40.42153, 42.34799);
case 1858: return new CityInfo("Gaziler", "88", 40.08125, 43.45187);
case 1859: return new CityInfo("Fındıklı", "53", 41.269, 41.14002);
case 1860: return new CityInfo("Ferizli", "54", 40.94082, 30.48583);
case 1861: return new CityInfo("Fatsa", "52", 41.02778, 37.50139);
case 1862: return new CityInfo("Eynesil", "28", 41.06436, 39.14274);
case 1863: return new CityInfo("Eymir", "66", 40.01927, 35.20788);
case 1864: return new CityInfo("Eğerci", "85", 41.09922, 31.81739);
case 1865: return new CityInfo("Evren", "69", 40.24527, 39.17535);
case 1866: return new CityInfo("Eskipazar", "89", 40.94298, 32.53091);
case 1867: return new CityInfo("Gözyeri", "89", 40.86596, 32.54167);
case 1868: return new CityInfo("Esiroğlu", "61", 40.87331, 39.68829);
case 1869: return new CityInfo("Esenyurt", "34", 41.02697, 28.67732);
case 1870: return new CityInfo("Esenler", "34", 41.0435, 28.87619);
case 1871: return new CityInfo("Esençay", "05", 40.66806, 36.38028);
case 1872: return new CityInfo("Erfelek", "57", 41.87926, 34.91838);
case 1873: return new CityInfo("Erenler", "54", 40.75504, 30.39344);
case 1874: return new CityInfo("Ereğli", "85", 41.28261, 31.41806);
case 1875: return new CityInfo("Erdek", "10", 40.3996, 27.79348);
case 1876: return new CityInfo("Erbaa", "60", 40.66889, 36.5675);
case 1877: return new CityInfo("Enez", "22", 40.72472, 26.0825);
case 1878: return new CityInfo("Eminönü", "34", 41.01766, 28.97438);
case 1879: return new CityInfo("Elmalı", "16", 40.51556, 29.88139);
case 1880: return new CityInfo("Eldivan", "82", 40.52975, 33.49903);
case 1881: return new CityInfo("Elbeyli", "16", 40.48611, 29.72472);
case 1882: return new CityInfo("Eflani", "89", 41.42289, 32.95761);
case 1883: return new CityInfo("Edirne", "22", 41.67719, 26.55597);
case 1884: return new CityInfo("Edincik", "10", 40.34229, 27.86129);
case 1885: return new CityInfo("Eceabat", "17", 40.18416, 26.3574);
case 1886: return new CityInfo("Düzköy", "61", 40.87461, 39.41536);
case 1887: return new CityInfo("Düzce", "93", 40.83889, 31.16389);
case 1888: return new CityInfo("Durusu", "34", 41.30337, 28.67635);
case 1889: return new CityInfo("Durağan", "57", 41.41583, 35.05444);
case 1890: return new CityInfo("Dumlu", "25", 40.05862, 41.35654);
case 1891: return new CityInfo("Dörtdivan", "14", 40.72052, 32.06314);
case 1892: return new CityInfo("Karşıyaka", "41", 40.6936, 29.94154);
case 1893: return new CityInfo("Dökmetepe", "60", 40.31224, 36.2918);
case 1894: return new CityInfo("Doğruyol", "84", 40.97986, 43.47098);
case 1895: return new CityInfo("Doğanyurt", "37", 42.00457, 33.46029);
case 1896: return new CityInfo("Doğanyurt", "60", 40.68806, 36.71639);
case 1897: return new CityInfo("Doğantepe", "05", 40.59778, 35.60417);
case 1898: return new CityInfo("Doğanşar", "58", 40.20841, 37.53123);
case 1899: return new CityInfo("Doğankent", "28", 40.8075, 38.91722);
case 1900: return new CityInfo("Doğançay", "54", 40.62647, 30.33557);
case 1901: return new CityInfo("Dodurga", "19", 40.85489, 34.80703);
case 1902: return new CityInfo("Dırazali", "16", 40.39622, 29.70793);
case 1903: return new CityInfo("Dikbıyık", "55", 41.22078, 36.615);
case 1904: return new CityInfo("Digor", "84", 40.36896, 43.40997);
case 1905: return new CityInfo("Devrekani", "37", 41.60303, 33.83922);
case 1906: return new CityInfo("Devrek", "85", 41.21917, 31.95583);
case 1907: return new CityInfo("Destek", "05", 40.84667, 36.18306);
case 1908: return new CityInfo("Dernekpazarı", "61", 40.79658, 40.2446);
case 1909: return new CityInfo("Derince", "41", 40.75694, 29.81472);
case 1910: return new CityInfo("Derepazarı", "53", 41.02398, 40.42332);
case 1911: return new CityInfo("Dereli", "28", 40.7389, 38.44337);
case 1912: return new CityInfo("Dereköy", "39", 41.93008, 27.37052);
case 1913: return new CityInfo("Dereköy", "41", 40.66434, 29.56349);
case 1914: return new CityInfo("Derecik", "61", 40.9459, 39.59401);
case 1915: return new CityInfo("Büyükderbent", "41", 40.70753, 30.11434);
case 1916: return new CityInfo("Demirtaş", "16", 40.27194, 29.09833);
case 1917: return new CityInfo("Pulur", "77", 40.16023, 39.89239);
case 1918: return new CityInfo("Demirkent", "08", 40.87908, 41.72953);
case 1919: return new CityInfo("Değirmendere", "41", 40.72, 29.78083);
case 1920: return new CityInfo("Darıca", "41", 40.77973, 29.39454);
case 1921: return new CityInfo("Darıca", "10", 40.0206, 27.86374);
case 1922: return new CityInfo("Dambaslar", "59", 41.22417, 27.24806);
case 1923: return new CityInfo("Damal", "86", 41.34145, 42.8368);
case 1924: return new CityInfo("Dağbaşı", "61", 40.72763, 39.91177);
case 1925: return new CityInfo("Daday", "37", 41.47866, 33.46667);
case 1926: return new CityInfo("Çukurköy", "92", 40.60458, 29.4099);
case 1927: return new CityInfo("Çubuk", "68", 40.23861, 33.03222);
case 1928: return new CityInfo("Çorum", "19", 40.54889, 34.95333);
case 1929: return new CityInfo("Çorlu", "59", 41.15917, 27.8);
case 1930: return new CityInfo("Çöpköy", "22", 41.21972, 26.82278);
case 1931: return new CityInfo("Çırçır", "58", 40.055, 36.775);
case 1932: return new CityInfo("Çınarcık", "92", 40.64538, 29.1245);
case 1933: return new CityInfo("Çilimli", "93", 40.89361, 31.04917);
case 1934: return new CityInfo("Zurzuna", "86", 41.12141, 43.1299);
case 1935: return new CityInfo("Çiftlikköy", "92", 40.66028, 29.32361);
case 1936: return new CityInfo("Cide", "37", 41.89211, 33.00439);
case 1937: return new CityInfo("Cerrah", "16", 40.07124, 29.44661);
case 1938: return new CityInfo("Çerkezköy", "59", 41.28629, 27.99939);
case 1939: return new CityInfo("Çerkeş", "82", 40.81164, 32.89358);
case 1940: return new CityInfo("Çerçiler", "57", 41.3945, 35.23665);
case 1941: return new CityInfo("Cemilbey", "19", 40.34529, 35.05136);
case 1942: return new CityInfo("Çeltikçi", "68", 40.32194, 32.45569);
case 1943: return new CityInfo("Çekmeköy", "34", 41.04118, 29.17838);
case 1944: return new CityInfo("Çekerek", "66", 40.07306, 35.49472);
case 1945: return new CityInfo("Kürtün", "69", 40.69516, 39.09468);
case 1946: return new CityInfo("Çaykara", "61", 40.74267, 40.23175);
case 1947: return new CityInfo("Çayırhan", "68", 40.09806, 31.67319);
case 1948: return new CityInfo("Çayeli", "53", 41.08609, 40.72213);
case 1949: return new CityInfo("Çaycuma", "85", 41.42639, 32.07556);
case 1950: return new CityInfo("Çaybaşı", "52", 41.01711, 37.09796);
case 1951: return new CityInfo("Çatalzeytin", "37", 41.95314, 34.21627);
case 1952: return new CityInfo("Çatalca", "34", 41.14324, 28.46154);
case 1953: return new CityInfo("Çarşıbaşı", "61", 41.08278, 39.38278);
case 1954: return new CityInfo("Çarşamba", "55", 41.19889, 36.72194);
case 1955: return new CityInfo("Çanta", "34", 41.07897, 28.08323);
case 1956: return new CityInfo("Khanjarah", "82", 40.59995, 33.6153);
case 1957: return new CityInfo("Çandır", "68", 40.25717, 33.46868);
case 1958: return new CityInfo("Çanakkale", "17", 40.15552, 26.41271);
case 1959: return new CityInfo("Çanakçı", "28", 40.91139, 38.98813);
case 1960: return new CityInfo("Çan", "17", 40.03328, 27.05236);
case 1961: return new CityInfo("Çamoluk", "28", 40.12732, 38.73006);
case 1962: return new CityInfo("Çamlıkaya", "25", 40.6391, 41.15218);
case 1963: return new CityInfo("Çamlıhemşin", "53", 41.04765, 40.99996);
case 1964: return new CityInfo("Çamlıdere", "68", 40.48958, 32.47499);
case 1965: return new CityInfo("Çamlıbel", "60", 40.08639, 36.47722);
case 1966: return new CityInfo("Camili", "08", 41.47838, 41.89825);
case 1967: return new CityInfo("Çağlayan", "61", 40.90019, 39.71231);
case 1968: return new CityInfo("Çamaş", "52", 40.902, 37.52786);
case 1969: return new CityInfo("Çalı", "16", 40.16861, 28.92083);
case 1970: return new CityInfo("Çakırlı", "16", 40.51806, 29.45222);
case 1971: return new CityInfo("Çakırca", "16", 40.47056, 29.66333);
case 1972: return new CityInfo("Çakıralan", "55", 41.16824, 35.76017);
case 1973: return new CityInfo("Laçin", "19", 40.77486, 34.88068);
case 1974: return new CityInfo("Büyükköy", "53", 41.01489, 40.67302);
case 1975: return new CityInfo("Büyükkarıştıran", "39", 41.30028, 27.54528);
case 1976: return new CityInfo("Chekmejeh", "34", 41.01284, 28.53824);
case 1977: return new CityInfo("Büyükçavuşlu", "34", 41.24002, 28.06331);
case 1978: return new CityInfo("Adalar", "34", 40.86778, 29.13306);
case 1979: return new CityInfo("Bursa", "16", 40.19559, 29.06013);
case 1980: return new CityInfo("Sarıcakaya", "26", 40.03686, 30.62675);
case 1981: return new CityInfo("Bulancak", "28", 40.93805, 38.23148);
case 1982: return new CityInfo("Buğdaylı", "10", 40.21889, 27.77056);
case 1983: return new CityInfo("Bozkurt", "37", 41.95769, 34.01087);
case 1984: return new CityInfo("Boyalık", "34", 41.26337, 28.63142);
case 1985: return new CityInfo("Boyalıca", "16", 40.48194, 29.56083);
case 1986: return new CityInfo("Boyabat", "57", 41.46889, 34.76667);
case 1987: return new CityInfo("Borçka", "08", 41.35792, 41.66579);
case 1988: return new CityInfo("Bolu", "14", 40.73583, 31.60611);
case 1989: return new CityInfo("Bolayır", "17", 40.5153, 26.75664);
case 1990: return new CityInfo("Bolaman", "52", 41.03435, 37.59409);
case 1991: return new CityInfo("Boğazkale", "19", 40.02191, 34.60947);
case 1992: return new CityInfo("Boğazkaya", "55", 41.45, 35.86667);
case 1993: return new CityInfo("Eminbey", "86", 41.54755, 42.78199);
case 1994: return new CityInfo("Bilecik", "11", 40.14192, 29.97932);
case 1995: return new CityInfo("Biga", "17", 40.22806, 27.24222);
case 1996: return new CityInfo("Asarcık", "55", 41.03556, 36.23556);
case 1997: return new CityInfo("Beypazarı", "68", 40.1675, 31.92111);
case 1998: return new CityInfo("Beyçayırı", "17", 40.25515, 26.92442);
case 1999: return new CityInfo("Beyazköy", "59", 41.34833, 27.70389);
case 2000: return new CityInfo("Beşpınar", "55", 41.13822, 35.21724);
case 2001: return new CityInfo("Beşikdüzü", "61", 41.05202, 39.23294);
case 2002: return new CityInfo("Bereketli", "60", 40.51273, 37.28862);
case 2003: return new CityInfo("Belören", "82", 40.86156, 33.49557);
case 2004: return new CityInfo("Bayramören", "82", 40.94329, 33.203);
case 2005: return new CityInfo("Bayburt", "77", 40.25631, 40.22289);
case 2006: return new CityInfo("Bayat", "19", 40.64583, 34.26139);
case 2007: return new CityInfo("Başgedikler", "84", 40.64069, 43.52179);
case 2008: return new CityInfo("Başçiftlik", "60", 40.54694, 37.16917);
case 2009: return new CityInfo("Bartın", "87", 41.63583, 32.3375);
case 2010: return new CityInfo("Bandırma", "10", 40.35222, 27.97667);
case 2011: return new CityInfo("Banarlı", "59", 41.06702, 27.33575);
case 2012: return new CityInfo("Ondokuzmayıs", "55", 41.5011, 36.06887);
case 2013: return new CityInfo("Ballı", "59", 40.83028, 27.05548);
case 2014: return new CityInfo("Balıklıçeşme", "17", 40.31029, 27.08171);
case 2015: return new CityInfo("Balçık", "41", 40.8725, 29.42833);
case 2016: return new CityInfo("Bakacak", "17", 40.20499, 27.08317);
case 2017: return new CityInfo("Bahçecik", "41", 40.6681, 29.91478);
case 2018: return new CityInfo("Bağcılar", "34", 41.03903, 28.85671);
case 2019: return new CityInfo("Bafra", "55", 41.56778, 35.90694);
case 2020: return new CityInfo("Babaeski", "39", 41.4325, 27.09306);
case 2021: return new CityInfo("Azdavay", "37", 41.64267, 33.3);
case 2022: return new CityInfo("Ayvacık", "55", 40.99111, 36.63139);
case 2023: return new CityInfo("Aydıntepe", "77", 40.38325, 40.14272);
case 2024: return new CityInfo("Aydıncık", "66", 40.12727, 35.28765);
case 2025: return new CityInfo("Ezinepazarı", "05", 40.56972, 36.13917);
case 2026: return new CityInfo("Aybastı", "52", 40.68667, 37.39917);
case 2027: return new CityInfo("Ayaş", "68", 40.01933, 32.33221);
case 2028: return new CityInfo("Ayancık", "57", 41.94472, 34.58611);
case 2029: return new CityInfo("Atkaracalar", "82", 40.81593, 33.07556);
case 2030: return new CityInfo("Aşağı Irmaklar", "08", 41.18299, 42.17443);
case 2031: return new CityInfo("Artvin", "08", 41.18161, 41.82172);
case 2032: return new CityInfo("Artova", "60", 40.11578, 36.3001);
case 2033: return new CityInfo("Arsin", "61", 40.95271, 39.92674);
case 2034: return new CityInfo("Arpaçay", "84", 40.84522, 43.32747);
case 2035: return new CityInfo("Arnavutköy", "34", 41.18355, 28.7402);
case 2036: return new CityInfo("Armutlu", "92", 40.51944, 28.82806);
case 2037: return new CityInfo("Arıt", "87", 41.68706, 32.62396);
case 2038: return new CityInfo("Arifiye", "54", 40.70036, 30.35076);
case 2039: return new CityInfo("Arhavi", "08", 41.35121, 41.30456);
case 2040: return new CityInfo("Çamiçi", "60", 40.6181, 37.00169);
case 2041: return new CityInfo("Ardeşen", "53", 41.19111, 40.9875);
case 2042: return new CityInfo("Ardanuç", "08", 41.12738, 42.06292);
case 2043: return new CityInfo("Ardahan", "86", 41.10871, 42.70222);
case 2044: return new CityInfo("Araklı", "61", 40.93854, 40.05842);
case 2045: return new CityInfo("Araç", "37", 41.24222, 33.32767);
case 2046: return new CityInfo("Amasya", "05", 40.65333, 35.83306);
case 2047: return new CityInfo("Amasra", "87", 41.74633, 32.38633);
case 2048: return new CityInfo("Alucra", "28", 40.31656, 38.75285);
case 2049: return new CityInfo("Altınova", "92", 40.69495, 29.50986);
case 2050: return new CityInfo("Almus", "60", 40.37583, 36.90444);
case 2051: return new CityInfo("Alıcık", "05", 40.80275, 35.32256);
case 2052: return new CityInfo("Alaplı", "85", 41.1814, 31.38514);
case 2053: return new CityInfo("Alanyurt", "16", 40.10881, 29.51871);
case 2054: return new CityInfo("Alaçam", "55", 41.60556, 35.59806);
case 2055: return new CityInfo("Alaca", "19", 40.16833, 34.8425);
case 2056: return new CityInfo("Akyurt", "68", 40.13512, 33.08614);
case 2057: return new CityInfo("Akyazı", "54", 40.685, 30.62222);
case 2058: return new CityInfo("Akyaka", "84", 40.74093, 43.61432);
case 2059: return new CityInfo("Aksu", "58", 40.08964, 38.03467);
case 2060: return new CityInfo("Akşar", "25", 40.64651, 42.3391);
case 2061: return new CityInfo("Aksakal", "10", 40.14725, 28.1068);
case 2062: return new CityInfo("Mollafeneri", "41", 40.88611, 29.49444);
case 2063: return new CityInfo("Akmeşe", "41", 40.84929, 30.19822);
case 2064: return new CityInfo("Akkuş", "52", 40.79306, 37.01639);
case 2065: return new CityInfo("Akıncılar", "58", 40.07172, 38.3433);
case 2066: return new CityInfo("Akdağ", "05", 40.71235, 35.97605);
case 2067: return new CityInfo("Akçakoca", "93", 41.08663, 31.11623);
case 2068: return new CityInfo("Akçaabat", "61", 41.02121, 39.57146);
case 2069: return new CityInfo("Ağva", "34", 41.13806, 29.85667);
case 2070: return new CityInfo("Ağlı", "37", 41.68602, 33.55383);
case 2071: return new CityInfo("Adapazarı", "54", 40.78056, 30.40333);
case 2072: return new CityInfo("Abana", "37", 41.97858, 34.011);
case 2073: return new CityInfo("Espiye", "28", 40.94705, 38.70299);
case 2074: return new CityInfo("Celâliye", "34", 41.05188, 28.41867);
case 2075: return new CityInfo("Muratbey", "34", 41.0963, 28.49227);
case 2076: return new CityInfo("Büyük Sinekli", "34", 41.2256, 28.21311);
case 2077: return new CityInfo("Halıdere", "41", 40.71604, 29.75223);
case 2078: return new CityInfo("İçmeler", "34", 40.84639, 29.30889);
case 2079: return new CityInfo("Merter Keresteciler", "34", 41.01295, 28.88593);
case 2080: return new CityInfo("güngören merter", "34", 41.00711, 28.88795);
case 2081: return new CityInfo("Turgutreis", "48", 37.01667, 27.26667);
case 2082: return new CityInfo("Karatay", "71", 37.86726, 32.52863);
case 2083: return new CityInfo("Sarigerme", "48", 36.71549, 28.70436);
case 2084: return new CityInfo("Ölüdeniz", "48", 36.56674, 29.14467);
case 2085: return new CityInfo("Eymür", "69", 40.84894, 38.8722);
case 2086: return new CityInfo("Arıköy", "34", 41.23044, 29.00425);
case 2087: return new CityInfo("Çatalhöyük", "71", 37.66847, 32.82689);
case 2088: return new CityInfo("Adalan", "34", 40.8759, 29.0894);
case 2089: return new CityInfo("Ataşehir", "34", 40.9833, 29.1167);
case 2090: return new CityInfo("Başakşehir", "34", 41.09307, 28.80203);
case 2091: return new CityInfo("Beylikdüzü", "34", 40.982, 28.6399);
case 2092: return new CityInfo("Büyükçekmece", "34", 41.02072, 28.58502);
case 2093: return new CityInfo("Çankaya", "68", 39.9179, 32.86268);
case 2094: return new CityInfo("Yaniklar", "48", 36.70827, 29.05081);
case 2095: return new CityInfo("Battalgazi", "44", 38.42286, 38.3585);
case 2096: return new CityInfo("Tosköy", "61", 40.939, 39.6758);
case 2097: return new CityInfo("Güce", "28", 40.8932, 38.7982);
case 2098: return new CityInfo("Çatalpınar", "52", 40.87899, 37.45351);
case 2099: return new CityInfo("Şehitkamil", "83", 37.07962, 37.38003);
case 2100: return new CityInfo("Şahinbey", "83", 37.04836, 37.34371);
case 2101: return new CityInfo("Bahçelievler", "34", 41.00231, 28.8598);
case 2102: return new CityInfo("Sultangazi", "34", 41.10652, 28.86847);
case 2103: return new CityInfo("Sultanbeyli", "34", 40.96072, 29.27067);
case 2104: return new CityInfo("Sancaktepe", "34", 41.00244, 29.23187);
case 2105: return new CityInfo("Kamışlı", "81", 37.55519, 34.9472);
case 2106: return new CityInfo("Köprübaşı", "55", 41.04754, 35.51687);
case 2107: return new CityInfo("Çayırkent", "55", 41.17128, 36.32883);
case 2108: return new CityInfo("Salıpazarı", "55", 41.08398, 36.8304);
case 2109: return new CityInfo("Karabağlar", "35", 38.37396, 27.1352);
case 2110: return new CityInfo("Muratpaşa", "07", 36.89157, 30.76498);
case 2111: return new CityInfo("Okurcalar", "07", 36.64876, 31.70387);
case 2112: return new CityInfo("Cumayeri", "93", 40.87389, 30.95091);
case 2113: return new CityInfo("Ortaköy", "54", 40.97305, 30.67686);
case 2114: return new CityInfo("Polateli", "90", 36.84137, 37.14407);
case 2115: return new CityInfo("Ovacık", "32", 36.17132, 33.55581);
case 2116: return new CityInfo("Kazımpaşa", "54", 40.7916, 30.295);
case 2117: return new CityInfo("Akçaova", "41", 41.0366, 29.9018);
case 2118: return new CityInfo("Termal", "92", 40.60779, 29.1736);
case 2119: return new CityInfo("Yıldırım", "16", 40.18851, 29.10974);
case 2120: return new CityInfo("Osmangazi", "16", 40.19671, 29.05935);
case 2121: return new CityInfo("Büyükorhan", "16", 39.77102, 28.88614);
case 2122: return new CityInfo("Akçasır", "21", 38.44722, 41.26513);
case 2123: return new CityInfo("Taşburun", "88", 39.98607, 44.22359);
case 2124: return new CityInfo("Bağlar", "21", 37.91375, 40.20584);
case 2125: return new CityInfo("Sur", "21", 37.91351, 40.22859);
case 2126: return new CityInfo("Yenişehir", "21", 37.94146, 40.13801);
case 2127: return new CityInfo("Palandöken", "25", 39.88898, 41.28055);
case 2128: return new CityInfo("Kazımkarabekir", "25", 39.91598, 41.28145);
case 2129: return new CityInfo("Yakutiye", "25", 39.89821, 41.26916);
case 2130: return new CityInfo("Tepebaşı", "26", 39.81091, 30.52551);
case 2131: return new CityInfo("Odunpazarı", "26", 39.76821, 30.53538);
case 2132: return new CityInfo("Pamukkale", "20", 37.7912, 29.10141);
case 2133: return new CityInfo("Nilüfer", "16", 40.21401, 28.91567);
case 2134: return new CityInfo("Çaybağı", "62", 38.82855, 39.61057);
case 2135: return new CityInfo("Merkez", "17", 40.12954, 26.42075);
case 2136: return new CityInfo("İlkadım", "55", 41.28732, 36.29046);
case 2137: return new CityInfo("Kepez", "07", 36.91579, 30.70782);
case 2138: return new CityInfo("Ümraniye", "34", 41.03291, 29.10137);
case 2139: return new CityInfo("Altınordu", "52", 40.98404, 37.87348);
case 2140: return new CityInfo("Kürecik", "46", 38.33675, 37.74142);
case 2141: return new CityInfo("Doğruyol", "86", 41.06132, 43.32201);
default: return new CityInfo("Merkezefendi", "20", 37.80544, 29.04236);

                                    }                                        
                                }
                            
                        }
                    }
                