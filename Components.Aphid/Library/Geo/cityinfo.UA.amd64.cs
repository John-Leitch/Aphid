
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
                                    public const string Country = "UA";
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
                            
                                        var cur = (Math.Abs(45.38333 - lat) + Math.Abs(32.53333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(46.91562 - lat) + Math.Abs(37.09961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2387 - lat) + Math.Abs(34.15456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58518 - lat) + Math.Abs(34.4849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23154 - lat) + Math.Abs(24.37701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63013 - lat) + Math.Abs(37.55259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38468 - lat) + Math.Abs(24.14254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43694 - lat) + Math.Abs(35.27417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69028 - lat) + Math.Abs(33.52775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.91978 - lat) + Math.Abs(23.72913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23674 - lat) + Math.Abs(34.64987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.07866 - lat) + Math.Abs(30.96755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05418 - lat) + Math.Abs(34.32152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.0114 - lat) + Math.Abs(38.26444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54762 - lat) + Math.Abs(34.71028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41194 - lat) + Math.Abs(38.62361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9095 - lat) + Math.Abs(25.33926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12774 - lat) + Math.Abs(34.99148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66832 - lat) + Math.Abs(32.04047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.27985 - lat) + Math.Abs(35.98179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80597 - lat) + Math.Abs(24.89436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.71278 - lat) + Math.Abs(32.66472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67453 - lat) + Math.Abs(36.34775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.48521 - lat) + Math.Abs(31.53906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58528 - lat) + Math.Abs(38.9375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50797 - lat) + Math.Abs(33.51431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.26487 - lat) + Math.Abs(28.67669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54968 - lat) + Math.Abs(26.48744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12629 - lat) + Math.Abs(35.21513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48108 - lat) + Math.Abs(32.5949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66365 - lat) + Math.Abs(24.24918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98784 - lat) + Math.Abs(29.53129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05825 - lat) + Math.Abs(23.9726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03705 - lat) + Math.Abs(28.11201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27466 - lat) + Math.Abs(34.65778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39877 - lat) + Math.Abs(34.75776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.34493 - lat) + Math.Abs(33.50374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.24545 - lat) + Math.Abs(30.1102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50276 - lat) + Math.Abs(31.78492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32364 - lat) + Math.Abs(34.48099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.20806 - lat) + Math.Abs(34.36376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97444 - lat) + Math.Abs(34.83553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.59583 - lat) + Math.Abs(34.00921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01249 - lat) + Math.Abs(34.46848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93503 - lat) + Math.Abs(33.89163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.5206 - lat) + Math.Abs(26.24251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.49607 - lat) + Math.Abs(26.24111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66484 - lat) + Math.Abs(25.14097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66357 - lat) + Math.Abs(25.77616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32697 - lat) + Math.Abs(34.80837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12305 - lat) + Math.Abs(36.39965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86258 - lat) + Math.Abs(34.3916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21354 - lat) + Math.Abs(30.01558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14492 - lat) + Math.Abs(30.52609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07251 - lat) + Math.Abs(30.46538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33351 - lat) + Math.Abs(29.87327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.52307 - lat) + Math.Abs(25.84369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9908 - lat) + Math.Abs(29.69672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65175 - lat) + Math.Abs(29.19108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.52144 - lat) + Math.Abs(24.64857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36193 - lat) + Math.Abs(34.71056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8126 - lat) + Math.Abs(26.12902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73636 - lat) + Math.Abs(34.48345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85048 - lat) + Math.Abs(34.26426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.59232 - lat) + Math.Abs(34.31753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.82289 - lat) + Math.Abs(35.19031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15816 - lat) + Math.Abs(33.27866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79188 - lat) + Math.Abs(25.37297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12337 - lat) + Math.Abs(32.29892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65238 - lat) + Math.Abs(36.16524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7489 - lat) + Math.Abs(28.61466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02716 - lat) + Math.Abs(33.69284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03104 - lat) + Math.Abs(38.80934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.64331 - lat) + Math.Abs(25.73794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11944 - lat) + Math.Abs(26.33756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91836 - lat) + Math.Abs(24.65275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04878 - lat) + Math.Abs(28.89234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.19385 - lat) + Math.Abs(35.23943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.47054 - lat) + Math.Abs(25.28571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62211 - lat) + Math.Abs(31.10131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73748 - lat) + Math.Abs(36.01987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01082 - lat) + Math.Abs(31.08797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20091 - lat) + Math.Abs(33.36655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85364 - lat) + Math.Abs(34.48644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.99062 - lat) + Math.Abs(30.98818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23331 - lat) + Math.Abs(38.21137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87349 - lat) + Math.Abs(27.80604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53287 - lat) + Math.Abs(34.89624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.80381 - lat) + Math.Abs(32.4046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69682 - lat) + Math.Abs(31.85253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.93864 - lat) + Math.Abs(23.38254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.17996 - lat) + Math.Abs(37.52379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09801 - lat) + Math.Abs(34.9577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.35591 - lat) + Math.Abs(30.02241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27937 - lat) + Math.Abs(24.36042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1298 - lat) + Math.Abs(37.8594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.19236 - lat) + Math.Abs(26.83725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61293 - lat) + Math.Abs(34.31834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15985 - lat) + Math.Abs(33.80555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6912 - lat) + Math.Abs(34.26323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.45157 - lat) + Math.Abs(24.55436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94765 - lat) + Math.Abs(33.78759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93555 - lat) + Math.Abs(37.95634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.2424 - lat) + Math.Abs(28.28195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.98972 - lat) + Math.Abs(24.7075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96279 - lat) + Math.Abs(37.27365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50218 - lat) + Math.Abs(34.16624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.27975 - lat) + Math.Abs(31.76246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.97922 - lat) + Math.Abs(25.71139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94248 - lat) + Math.Abs(25.74375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96512 - lat) + Math.Abs(25.44159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.40418 - lat) + Math.Abs(24.93874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31742 - lat) + Math.Abs(24.48448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56851 - lat) + Math.Abs(34.88096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94407 - lat) + Math.Abs(38.05804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49187 - lat) + Math.Abs(33.53061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.89156 - lat) + Math.Abs(36.12175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04911 - lat) + Math.Abs(23.42113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58476 - lat) + Math.Abs(30.4898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71373 - lat) + Math.Abs(34.36256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.14135 - lat) + Math.Abs(23.02666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.10915 - lat) + Math.Abs(22.83865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40214 - lat) + Math.Abs(29.58595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82372 - lat) + Math.Abs(36.50264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86195 - lat) + Math.Abs(30.59195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17324 - lat) + Math.Abs(35.03238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56494 - lat) + Math.Abs(31.33078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87165 - lat) + Math.Abs(35.46458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55135 - lat) + Math.Abs(23.10579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51222 - lat) + Math.Abs(33.87482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38329 - lat) + Math.Abs(36.43739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21908 - lat) + Math.Abs(35.02708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.5444 - lat) + Math.Abs(30.15305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17334 - lat) + Math.Abs(34.21917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10954 - lat) + Math.Abs(28.68078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.89746 - lat) + Math.Abs(38.57279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.22235 - lat) + Math.Abs(30.89967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28459 - lat) + Math.Abs(24.56536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32895 - lat) + Math.Abs(33.24654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.7109 - lat) + Math.Abs(23.1851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.19225 - lat) + Math.Abs(25.93074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59764 - lat) + Math.Abs(28.443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20533 - lat) + Math.Abs(37.32139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52484 - lat) + Math.Abs(29.91222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53748 - lat) + Math.Abs(26.21568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63645 - lat) + Math.Abs(34.81387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60103 - lat) + Math.Abs(37.49674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66462 - lat) + Math.Abs(34.4982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.29078 - lat) + Math.Abs(36.94108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8699 - lat) + Math.Abs(33.99138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48746 - lat) + Math.Abs(34.49235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94023 - lat) + Math.Abs(33.84573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46872 - lat) + Math.Abs(34.59087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16654 - lat) + Math.Abs(35.37268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85253 - lat) + Math.Abs(24.32364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4213 - lat) + Math.Abs(26.14469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.24801 - lat) + Math.Abs(25.19452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11436 - lat) + Math.Abs(30.8698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.38913 - lat) + Math.Abs(30.3705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43611 - lat) + Math.Abs(33.91556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14509 - lat) + Math.Abs(34.59691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73409 - lat) + Math.Abs(33.62839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95966 - lat) + Math.Abs(33.95289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.70069 - lat) + Math.Abs(24.74599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36957 - lat) + Math.Abs(32.9398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39264 - lat) + Math.Abs(33.64668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68119 - lat) + Math.Abs(28.57138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29332 - lat) + Math.Abs(35.84451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.48149 - lat) + Math.Abs(34.12973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23278 - lat) + Math.Abs(28.48097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03462 - lat) + Math.Abs(27.23617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94381 - lat) + Math.Abs(35.43539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8456 - lat) + Math.Abs(33.67161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35666 - lat) + Math.Abs(31.23488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01479 - lat) + Math.Abs(34.91504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85807 - lat) + Math.Abs(34.87952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37733 - lat) + Math.Abs(33.21385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15571 - lat) + Math.Abs(24.79112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.69738 - lat) + Math.Abs(33.98696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82902 - lat) + Math.Abs(34.95861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.7805 - lat) + Math.Abs(23.51545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09146 - lat) + Math.Abs(34.24188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81575 - lat) + Math.Abs(24.30328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.82849 - lat) + Math.Abs(30.03957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16156 - lat) + Math.Abs(24.94532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25053 - lat) + Math.Abs(34.33797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10307 - lat) + Math.Abs(23.59099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.68932 - lat) + Math.Abs(33.70207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65242 - lat) + Math.Abs(34.33457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.9881 - lat) + Math.Abs(23.63176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30551 - lat) + Math.Abs(33.50004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54653 - lat) + Math.Abs(25.74533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.04747 - lat) + Math.Abs(23.42189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.41667 - lat) + Math.Abs(35.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61176 - lat) + Math.Abs(27.79324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01254 - lat) + Math.Abs(29.67171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07971 - lat) + Math.Abs(29.85753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.47092 - lat) + Math.Abs(24.94677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.02314 - lat) + Math.Abs(33.94144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48684 - lat) + Math.Abs(32.97498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52363 - lat) + Math.Abs(25.75753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0617 - lat) + Math.Abs(37.38373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88831 - lat) + Math.Abs(22.46052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4243 - lat) + Math.Abs(35.47989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.84531 - lat) + Math.Abs(36.83534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17572 - lat) + Math.Abs(33.94362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59333 - lat) + Math.Abs(30.90313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27756 - lat) + Math.Abs(34.70616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79116 - lat) + Math.Abs(33.72258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31969 - lat) + Math.Abs(33.30373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01502 - lat) + Math.Abs(31.06211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82852 - lat) + Math.Abs(36.32691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13938 - lat) + Math.Abs(34.72291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20698 - lat) + Math.Abs(36.02365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.18693 - lat) + Math.Abs(30.31346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38491 - lat) + Math.Abs(25.51023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12207 - lat) + Math.Abs(22.71281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53786 - lat) + Math.Abs(35.20086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32309 - lat) + Math.Abs(34.89838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.49503 - lat) + Math.Abs(32.71968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.53479 - lat) + Math.Abs(28.74358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83597 - lat) + Math.Abs(35.61223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36166 - lat) + Math.Abs(22.3997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82619 - lat) + Math.Abs(30.41487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61667 - lat) + Math.Abs(22.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19769 - lat) + Math.Abs(33.29796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2626 - lat) + Math.Abs(35.66506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78583 - lat) + Math.Abs(36.07528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95507 - lat) + Math.Abs(32.53674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.39077 - lat) + Math.Abs(39.16284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53296 - lat) + Math.Abs(30.6596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33625 - lat) + Math.Abs(35.06865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3211 - lat) + Math.Abs(39.80302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.02847 - lat) + Math.Abs(25.72327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.74838 - lat) + Math.Abs(30.22184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.33105 - lat) + Math.Abs(30.22702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23385 - lat) + Math.Abs(23.65111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69512 - lat) + Math.Abs(28.13298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04272 - lat) + Math.Abs(34.00312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.14317 - lat) + Math.Abs(30.74612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8873 - lat) + Math.Abs(34.13973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9552 - lat) + Math.Abs(24.69292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36811 - lat) + Math.Abs(23.74895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82146 - lat) + Math.Abs(33.60452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31474 - lat) + Math.Abs(38.27423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38878 - lat) + Math.Abs(34.28201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02221 - lat) + Math.Abs(33.83184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01404 - lat) + Math.Abs(28.50846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.62962 - lat) + Math.Abs(34.14355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.90219 - lat) + Math.Abs(24.84482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.77168 - lat) + Math.Abs(24.66626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60145 - lat) + Math.Abs(26.18486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.01179 - lat) + Math.Abs(23.57061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80286 - lat) + Math.Abs(23.23624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.15411 - lat) + Math.Abs(23.02967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08644 - lat) + Math.Abs(24.52294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.69747 - lat) + Math.Abs(33.83007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.34788 - lat) + Math.Abs(28.72117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.67448 - lat) + Math.Abs(28.84641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91218 - lat) + Math.Abs(23.47303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12368 - lat) + Math.Abs(34.19489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61842 - lat) + Math.Abs(32.7189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38719 - lat) + Math.Abs(29.10288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.99484 - lat) + Math.Abs(31.56281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08655 - lat) + Math.Abs(34.38521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.15231 - lat) + Math.Abs(31.53739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.07907 - lat) + Math.Abs(29.84727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90633 - lat) + Math.Abs(34.18063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93697 - lat) + Math.Abs(34.4786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53628 - lat) + Math.Abs(34.30643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.27837 - lat) + Math.Abs(23.50618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21731 - lat) + Math.Abs(35.15247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.78734 - lat) + Math.Abs(33.99408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48478 - lat) + Math.Abs(34.96567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.50961 - lat) + Math.Abs(29.23482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.9145 - lat) + Math.Abs(38.29277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11802 - lat) + Math.Abs(30.78141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75751 - lat) + Math.Abs(38.96333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48432 - lat) + Math.Abs(30.90304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.77914 - lat) + Math.Abs(38.57903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32462 - lat) + Math.Abs(29.14746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03876 - lat) + Math.Abs(38.59685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65186 - lat) + Math.Abs(29.31741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54256 - lat) + Math.Abs(28.51684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81569 - lat) + Math.Abs(34.74137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.84663 - lat) + Math.Abs(25.72621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25522 - lat) + Math.Abs(35.71238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28367 - lat) + Math.Abs(35.15244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.86403 - lat) + Math.Abs(25.00325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.49665 - lat) + Math.Abs(30.94229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1841 - lat) + Math.Abs(35.11625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22327 - lat) + Math.Abs(36.14192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.3767 - lat) + Math.Abs(29.66474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96942 - lat) + Math.Abs(35.421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98916 - lat) + Math.Abs(33.9707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.09226 - lat) + Math.Abs(37.96081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.57922 - lat) + Math.Abs(33.75105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83049 - lat) + Math.Abs(36.12761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55342 - lat) + Math.Abs(25.58918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.30187 - lat) + Math.Abs(25.70997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03239 - lat) + Math.Abs(33.69588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66566 - lat) + Math.Abs(29.74504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83818 - lat) + Math.Abs(26.41433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79197 - lat) + Math.Abs(34.36298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.74303 - lat) + Math.Abs(33.66812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40994 - lat) + Math.Abs(38.02476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97652 - lat) + Math.Abs(33.74892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83731 - lat) + Math.Abs(29.61424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.528 - lat) + Math.Abs(34.18315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18636 - lat) + Math.Abs(29.15203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55832 - lat) + Math.Abs(30.49259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.37961 - lat) + Math.Abs(25.70843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.65829 - lat) + Math.Abs(33.80929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57142 - lat) + Math.Abs(33.78728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88877 - lat) + Math.Abs(30.69482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95783 - lat) + Math.Abs(31.92085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83913 - lat) + Math.Abs(33.14374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61257 - lat) + Math.Abs(34.61497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90175 - lat) + Math.Abs(33.67638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94832 - lat) + Math.Abs(38.49166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03333 - lat) + Math.Abs(37.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48211 - lat) + Math.Abs(23.85904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.64876 - lat) + Math.Abs(24.43953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6332 - lat) + Math.Abs(34.66264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04894 - lat) + Math.Abs(33.24106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43374 - lat) + Math.Abs(38.22331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08964 - lat) + Math.Abs(39.65243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.41029 - lat) + Math.Abs(38.15035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9622 - lat) + Math.Abs(24.19658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54853 - lat) + Math.Abs(22.99578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25171 - lat) + Math.Abs(33.37194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04245 - lat) + Math.Abs(28.41733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.4378 - lat) + Math.Abs(27.64912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49898 - lat) + Math.Abs(33.69854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27202 - lat) + Math.Abs(34.72759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9216 - lat) + Math.Abs(34.80029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82426 - lat) + Math.Abs(23.8377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78892 - lat) + Math.Abs(23.37218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.84924 - lat) + Math.Abs(34.97471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65545 - lat) + Math.Abs(32.52093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.09107 - lat) + Math.Abs(37.48697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.26223 - lat) + Math.Abs(23.85609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9497 - lat) + Math.Abs(34.17924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.39247 - lat) + Math.Abs(22.54308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11333 - lat) + Math.Abs(38.4925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.60403 - lat) + Math.Abs(22.23269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1643 - lat) + Math.Abs(25.72029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3627 - lat) + Math.Abs(33.49584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.52767 - lat) + Math.Abs(25.57572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78656 - lat) + Math.Abs(33.54856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65212 - lat) + Math.Abs(33.77441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79489 - lat) + Math.Abs(29.98684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.29416 - lat) + Math.Abs(23.56357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.40186 - lat) + Math.Abs(31.09764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.07818 - lat) + Math.Abs(30.9038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40051 - lat) + Math.Abs(29.52796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.39124 - lat) + Math.Abs(30.19022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43856 - lat) + Math.Abs(23.00056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.07619 - lat) + Math.Abs(36.78852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98147 - lat) + Math.Abs(35.75904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16146 - lat) + Math.Abs(37.48934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02887 - lat) + Math.Abs(35.09174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24241 - lat) + Math.Abs(33.66354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27093 - lat) + Math.Abs(25.17293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.83361 - lat) + Math.Abs(24.5243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71037 - lat) + Math.Abs(24.1895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.75764 - lat) + Math.Abs(27.20342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33722 - lat) + Math.Abs(29.98528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75038 - lat) + Math.Abs(38.03051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.27832 - lat) + Math.Abs(38.91069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98001 - lat) + Math.Abs(23.55848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26857 - lat) + Math.Abs(36.98115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.43762 - lat) + Math.Abs(24.43997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.60318 - lat) + Math.Abs(27.61909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.76763 - lat) + Math.Abs(28.21569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56909 - lat) + Math.Abs(32.14777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65433 - lat) + Math.Abs(39.47943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70814 - lat) + Math.Abs(34.56238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37062 - lat) + Math.Abs(33.94883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56818 - lat) + Math.Abs(38.64352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98159 - lat) + Math.Abs(23.91041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54043 - lat) + Math.Abs(22.50696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66384 - lat) + Math.Abs(32.91867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66667 - lat) + Math.Abs(35.05385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88992 - lat) + Math.Abs(24.06293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53409 - lat) + Math.Abs(34.18729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34267 - lat) + Math.Abs(34.92463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52387 - lat) + Math.Abs(32.49985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94604 - lat) + Math.Abs(23.87035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70212 - lat) + Math.Abs(24.42212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.75621 - lat) + Math.Abs(24.01028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.99682 - lat) + Math.Abs(36.03464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.74722 - lat) + Math.Abs(34.53999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87185 - lat) + Math.Abs(35.10622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88208 - lat) + Math.Abs(34.44811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20805 - lat) + Math.Abs(34.87208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55041 - lat) + Math.Abs(33.95897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81784 - lat) + Math.Abs(33.79482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44747 - lat) + Math.Abs(27.41678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.47438 - lat) + Math.Abs(24.28288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04865 - lat) + Math.Abs(33.87618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08985 - lat) + Math.Abs(33.99887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.33604 - lat) + Math.Abs(28.65096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44692 - lat) + Math.Abs(25.56937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07579 - lat) + Math.Abs(32.80516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.02612 - lat) + Math.Abs(38.77225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22242 - lat) + Math.Abs(31.88714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.86667 - lat) + Math.Abs(37.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.69779 - lat) + Math.Abs(38.98133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.88694 - lat) + Math.Abs(29.34611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19806 - lat) + Math.Abs(33.60695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72768 - lat) + Math.Abs(33.32165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.30155 - lat) + Math.Abs(26.86506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.84734 - lat) + Math.Abs(23.44587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72176 - lat) + Math.Abs(33.23689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.21041 - lat) + Math.Abs(36.15376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07542 - lat) + Math.Abs(33.82084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73177 - lat) + Math.Abs(29.66569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03717 - lat) + Math.Abs(23.51346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22827 - lat) + Math.Abs(23.35016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53728 - lat) + Math.Abs(22.96467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81686 - lat) + Math.Abs(33.97791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.42732 - lat) + Math.Abs(25.97869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85149 - lat) + Math.Abs(26.19909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1161 - lat) + Math.Abs(32.91124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34892 - lat) + Math.Abs(33.87669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58484 - lat) + Math.Abs(23.6891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.48745 - lat) + Math.Abs(23.62575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32044 - lat) + Math.Abs(35.51792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.95719 - lat) + Math.Abs(34.11079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.40646 - lat) + Math.Abs(34.00704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.12157 - lat) + Math.Abs(26.11424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2732 - lat) + Math.Abs(35.21203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.56767 - lat) + Math.Abs(33.62245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.6636 - lat) + Math.Abs(24.28102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.00687 - lat) + Math.Abs(31.39471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86296 - lat) + Math.Abs(33.4698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69453 - lat) + Math.Abs(34.03119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.95675 - lat) + Math.Abs(23.54408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31195 - lat) + Math.Abs(33.20566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.88175 - lat) + Math.Abs(34.01118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38052 - lat) + Math.Abs(30.19638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95711 - lat) + Math.Abs(38.2316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69173 - lat) + Math.Abs(33.25715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64627 - lat) + Math.Abs(34.83767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.47968 - lat) + Math.Abs(33.76846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.37677 - lat) + Math.Abs(25.74664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14373 - lat) + Math.Abs(35.15509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69585 - lat) + Math.Abs(37.17348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86289 - lat) + Math.Abs(32.20387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55604 - lat) + Math.Abs(29.33357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.33197 - lat) + Math.Abs(24.98329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.18545 - lat) + Math.Abs(27.06365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18748 - lat) + Math.Abs(33.68807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81865 - lat) + Math.Abs(31.94504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65096 - lat) + Math.Abs(23.87426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.39489 - lat) + Math.Abs(37.79102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27058 - lat) + Math.Abs(33.19125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.93821 - lat) + Math.Abs(35.158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50208 - lat) + Math.Abs(23.93806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75587 - lat) + Math.Abs(28.07507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57167 - lat) + Math.Abs(34.12167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98365 - lat) + Math.Abs(38.28207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05657 - lat) + Math.Abs(38.43826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13262 - lat) + Math.Abs(30.38595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.86699 - lat) + Math.Abs(38.10007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60795 - lat) + Math.Abs(33.52134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30094 - lat) + Math.Abs(29.01958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0272 - lat) + Math.Abs(30.37682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18903 - lat) + Math.Abs(34.03639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91917 - lat) + Math.Abs(38.13494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63937 - lat) + Math.Abs(33.49632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.45593 - lat) + Math.Abs(27.71923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.25482 - lat) + Math.Abs(33.34602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24676 - lat) + Math.Abs(35.565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.72627 - lat) + Math.Abs(30.93441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32643 - lat) + Math.Abs(39.53366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17827 - lat) + Math.Abs(32.58183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59031 - lat) + Math.Abs(33.18049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.14708 - lat) + Math.Abs(37.30032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.29712 - lat) + Math.Abs(24.20462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07678 - lat) + Math.Abs(38.15602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64473 - lat) + Math.Abs(31.56497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73963 - lat) + Math.Abs(39.2323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13219 - lat) + Math.Abs(30.08247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.40257 - lat) + Math.Abs(37.06266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.33795 - lat) + Math.Abs(26.60191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01966 - lat) + Math.Abs(29.66567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5183 - lat) + Math.Abs(23.19752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13424 - lat) + Math.Abs(33.59996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.15166 - lat) + Math.Abs(35.87198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56603 - lat) + Math.Abs(24.7882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31037 - lat) + Math.Abs(34.6526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.96886 - lat) + Math.Abs(31.04628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38511 - lat) + Math.Abs(23.55662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61712 - lat) + Math.Abs(31.34995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77331 - lat) + Math.Abs(34.59609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7228 - lat) + Math.Abs(29.20455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.417 - lat) + Math.Abs(31.92009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12369 - lat) + Math.Abs(34.47458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83333 - lat) + Math.Abs(23.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65306 - lat) + Math.Abs(23.48702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78564 - lat) + Math.Abs(33.66093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01229 - lat) + Math.Abs(38.37967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.50323 - lat) + Math.Abs(23.962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38484 - lat) + Math.Abs(37.06792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9394 - lat) + Math.Abs(35.77207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93576 - lat) + Math.Abs(24.16379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36597 - lat) + Math.Abs(25.2258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91542 - lat) + Math.Abs(25.26906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.46144 - lat) + Math.Abs(24.0623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84334 - lat) + Math.Abs(30.07919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.24742 - lat) + Math.Abs(31.75432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08331 - lat) + Math.Abs(39.37764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.37087 - lat) + Math.Abs(30.18471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.48959 - lat) + Math.Abs(39.27881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65187 - lat) + Math.Abs(34.11552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11988 - lat) + Math.Abs(25.77421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.99055 - lat) + Math.Abs(33.32506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75104 - lat) + Math.Abs(33.47471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25647 - lat) + Math.Abs(33.25517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21018 - lat) + Math.Abs(23.17624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2796 - lat) + Math.Abs(27.214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.409 - lat) + Math.Abs(24.60927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55395 - lat) + Math.Abs(33.73925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.46446 - lat) + Math.Abs(33.85189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04296 - lat) + Math.Abs(33.95407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.35199 - lat) + Math.Abs(37.20602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79862 - lat) + Math.Abs(23.53336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62308 - lat) + Math.Abs(26.22743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56501 - lat) + Math.Abs(34.07815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80105 - lat) + Math.Abs(31.08383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45623 - lat) + Math.Abs(28.27914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.27706 - lat) + Math.Abs(23.64617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28034 - lat) + Math.Abs(24.9333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97458 - lat) + Math.Abs(33.69458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77083 - lat) + Math.Abs(33.48777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43357 - lat) + Math.Abs(24.90854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23079 - lat) + Math.Abs(23.62825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6683 - lat) + Math.Abs(24.5303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.14966 - lat) + Math.Abs(38.57619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.49982 - lat) + Math.Abs(23.23739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62174 - lat) + Math.Abs(24.92427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46713 - lat) + Math.Abs(22.59687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68665 - lat) + Math.Abs(30.47384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.0526 - lat) + Math.Abs(24.20089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.49613 - lat) + Math.Abs(29.22911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5486 - lat) + Math.Abs(32.92787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.28249 - lat) + Math.Abs(24.64279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85023 - lat) + Math.Abs(24.65502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41333 - lat) + Math.Abs(33.71056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32347 - lat) + Math.Abs(34.25516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.33745 - lat) + Math.Abs(33.87066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98869 - lat) + Math.Abs(25.09455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71532 - lat) + Math.Abs(23.91295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20373 - lat) + Math.Abs(34.97642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6097 - lat) + Math.Abs(30.7177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59323 - lat) + Math.Abs(32.38761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23606 - lat) + Math.Abs(36.16835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23922 - lat) + Math.Abs(34.70217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65597 - lat) + Math.Abs(34.69837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.0159 - lat) + Math.Abs(38.09979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.72094 - lat) + Math.Abs(33.07078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01501 - lat) + Math.Abs(38.30457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11969 - lat) + Math.Abs(35.0596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82145 - lat) + Math.Abs(34.67935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25927 - lat) + Math.Abs(35.31953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2699 - lat) + Math.Abs(36.33405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17436 - lat) + Math.Abs(37.69266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11201 - lat) + Math.Abs(35.4786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73479 - lat) + Math.Abs(36.34425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.16273 - lat) + Math.Abs(37.34524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79199 - lat) + Math.Abs(34.43786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73426 - lat) + Math.Abs(35.64251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57194 - lat) + Math.Abs(35.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77903 - lat) + Math.Abs(33.84649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.20804 - lat) + Math.Abs(23.54674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66832 - lat) + Math.Abs(22.75328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68755 - lat) + Math.Abs(24.26322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.9532 - lat) + Math.Abs(29.45265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63328 - lat) + Math.Abs(38.37804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.18492 - lat) + Math.Abs(27.53629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.24222 - lat) + Math.Abs(31.41583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.64092 - lat) + Math.Abs(24.9307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.25836 - lat) + Math.Abs(27.68809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.34929 - lat) + Math.Abs(24.43907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59373 - lat) + Math.Abs(34.54073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.12424 - lat) + Math.Abs(27.51087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48444 - lat) + Math.Abs(36.25361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.97852 - lat) + Math.Abs(36.2256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.91343 - lat) + Math.Abs(36.17511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.55453 - lat) + Math.Abs(30.64455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.48639 - lat) + Math.Abs(29.26361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58385 - lat) + Math.Abs(24.79776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53472 - lat) + Math.Abs(26.14585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13947 - lat) + Math.Abs(22.97194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94599 - lat) + Math.Abs(25.31672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94611 - lat) + Math.Abs(24.9795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.57528 - lat) + Math.Abs(35.1068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.10704 - lat) + Math.Abs(30.88953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.26853 - lat) + Math.Abs(25.13341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.33483 - lat) + Math.Abs(23.24887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8354 - lat) + Math.Abs(33.96159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.00509 - lat) + Math.Abs(25.51183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16579 - lat) + Math.Abs(30.59274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70109 - lat) + Math.Abs(34.44805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71104 - lat) + Math.Abs(23.13826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61783 - lat) + Math.Abs(24.52872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87156 - lat) + Math.Abs(33.85615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96155 - lat) + Math.Abs(35.2466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1006 - lat) + Math.Abs(29.72169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.88315 - lat) + Math.Abs(36.06785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60928 - lat) + Math.Abs(23.82079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24242 - lat) + Math.Abs(32.50621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88083 - lat) + Math.Abs(34.20194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65899 - lat) + Math.Abs(23.28346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.17695 - lat) + Math.Abs(36.89999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32467 - lat) + Math.Abs(33.25617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49776 - lat) + Math.Abs(34.28816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.45643 - lat) + Math.Abs(36.4367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96951 - lat) + Math.Abs(30.95914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.72933 - lat) + Math.Abs(34.63358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53122 - lat) + Math.Abs(25.57901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.90246 - lat) + Math.Abs(24.30347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.69378 - lat) + Math.Abs(29.61934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.84342 - lat) + Math.Abs(33.60921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20727 - lat) + Math.Abs(28.88607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12918 - lat) + Math.Abs(29.73086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71744 - lat) + Math.Abs(33.85596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38742 - lat) + Math.Abs(36.21471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11207 - lat) + Math.Abs(34.06478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.62988 - lat) + Math.Abs(38.54806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04433 - lat) + Math.Abs(30.85073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39287 - lat) + Math.Abs(28.86837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05582 - lat) + Math.Abs(37.31068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92513 - lat) + Math.Abs(34.05753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.06739 - lat) + Math.Abs(31.44969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43779 - lat) + Math.Abs(38.84384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97675 - lat) + Math.Abs(34.98281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.84838 - lat) + Math.Abs(34.31271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.02452 - lat) + Math.Abs(35.97871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66523 - lat) + Math.Abs(24.55846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16151 - lat) + Math.Abs(33.69308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.53552 - lat) + Math.Abs(30.51923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.5094 - lat) + Math.Abs(33.82902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73616 - lat) + Math.Abs(22.482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.51551 - lat) + Math.Abs(24.89423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.87167 - lat) + Math.Abs(36.93472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29525 - lat) + Math.Abs(34.78416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91762 - lat) + Math.Abs(33.35691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.60864 - lat) + Math.Abs(38.70917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.44143 - lat) + Math.Abs(28.45956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.53426 - lat) + Math.Abs(35.87098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.57152 - lat) + Math.Abs(24.43003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70538 - lat) + Math.Abs(31.89709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33383 - lat) + Math.Abs(34.75314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.83379 - lat) + Math.Abs(34.08465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75665 - lat) + Math.Abs(33.99177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.57768 - lat) + Math.Abs(39.71944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93692 - lat) + Math.Abs(36.27563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.674 - lat) + Math.Abs(32.8841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.17816 - lat) + Math.Abs(28.73384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.403 - lat) + Math.Abs(28.67546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.62891 - lat) + Math.Abs(25.32895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3246 - lat) + Math.Abs(28.80351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7552 - lat) + Math.Abs(34.33777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24998 - lat) + Math.Abs(30.44127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73767 - lat) + Math.Abs(24.86111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86102 - lat) + Math.Abs(33.7311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58656 - lat) + Math.Abs(33.96524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50485 - lat) + Math.Abs(34.21125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74232 - lat) + Math.Abs(34.06607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.32942 - lat) + Math.Abs(26.51425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9506 - lat) + Math.Abs(30.88229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05249 - lat) + Math.Abs(34.99294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9136 - lat) + Math.Abs(36.8253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7901 - lat) + Math.Abs(32.69941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23679 - lat) + Math.Abs(33.5649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8107 - lat) + Math.Abs(33.97308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66886 - lat) + Math.Abs(33.374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72907 - lat) + Math.Abs(33.58243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.44685 - lat) + Math.Abs(33.77588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56731 - lat) + Math.Abs(35.78575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.45714 - lat) + Math.Abs(34.14063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66763 - lat) + Math.Abs(34.05957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96401 - lat) + Math.Abs(35.35576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.18889 - lat) + Math.Abs(29.52697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.95652 - lat) + Math.Abs(34.61226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.90716 - lat) + Math.Abs(33.44869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65763 - lat) + Math.Abs(22.34183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71855 - lat) + Math.Abs(25.81251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18411 - lat) + Math.Abs(31.79375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23604 - lat) + Math.Abs(30.87608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22266 - lat) + Math.Abs(31.33314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22482 - lat) + Math.Abs(27.65228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.96233 - lat) + Math.Abs(24.89336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11056 - lat) + Math.Abs(24.18961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16406 - lat) + Math.Abs(22.96167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66961 - lat) + Math.Abs(33.11593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96336 - lat) + Math.Abs(32.23492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36855 - lat) + Math.Abs(32.76357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65531 - lat) + Math.Abs(33.94918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39937 - lat) + Math.Abs(34.90986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36215 - lat) + Math.Abs(36.36803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28866 - lat) + Math.Abs(34.13521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.62932 - lat) + Math.Abs(34.5534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48612 - lat) + Math.Abs(34.86401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23985 - lat) + Math.Abs(33.59405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76656 - lat) + Math.Abs(33.38817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47747 - lat) + Math.Abs(30.73262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61283 - lat) + Math.Abs(31.54982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.10689 - lat) + Math.Abs(30.61848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78333 - lat) + Math.Abs(23.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.40514 - lat) + Math.Abs(29.24775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70032 - lat) + Math.Abs(25.17012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81492 - lat) + Math.Abs(25.59989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54628 - lat) + Math.Abs(24.91018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.90444 - lat) + Math.Abs(24.30523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.80591 - lat) + Math.Abs(38.02112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.83087 - lat) + Math.Abs(34.9137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5158 - lat) + Math.Abs(33.17329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0302 - lat) + Math.Abs(31.00605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94275 - lat) + Math.Abs(28.85628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.34395 - lat) + Math.Abs(34.31084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62754 - lat) + Math.Abs(30.4431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11548 - lat) + Math.Abs(28.05463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69308 - lat) + Math.Abs(32.5216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1596 - lat) + Math.Abs(34.2327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.17444 - lat) + Math.Abs(26.79932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44133 - lat) + Math.Abs(22.62164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.93581 - lat) + Math.Abs(34.02355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50035 - lat) + Math.Abs(33.91748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.72576 - lat) + Math.Abs(24.16265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.84842 - lat) + Math.Abs(33.91622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83021 - lat) + Math.Abs(35.75136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.51455 - lat) + Math.Abs(24.0923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32635 - lat) + Math.Abs(31.52852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3556 - lat) + Math.Abs(34.33272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66206 - lat) + Math.Abs(34.387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44276 - lat) + Math.Abs(33.59795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0701 - lat) + Math.Abs(37.69517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.99377 - lat) + Math.Abs(33.83525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0703 - lat) + Math.Abs(27.51955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21931 - lat) + Math.Abs(26.26531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5464 - lat) + Math.Abs(39.08987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83349 - lat) + Math.Abs(36.54771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05918 - lat) + Math.Abs(34.60619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42198 - lat) + Math.Abs(34.45052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35133 - lat) + Math.Abs(34.18371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86634 - lat) + Math.Abs(33.89018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.55625 - lat) + Math.Abs(34.37399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.9781 - lat) + Math.Abs(35.9102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30855 - lat) + Math.Abs(36.05749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63799 - lat) + Math.Abs(35.24548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.78105 - lat) + Math.Abs(31.64204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78007 - lat) + Math.Abs(34.15543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00642 - lat) + Math.Abs(34.49543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83948 - lat) + Math.Abs(34.04194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44914 - lat) + Math.Abs(33.09833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45815 - lat) + Math.Abs(34.79897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59412 - lat) + Math.Abs(27.6165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.452 - lat) + Math.Abs(34.60378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17128 - lat) + Math.Abs(32.31781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63526 - lat) + Math.Abs(36.98477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50999 - lat) + Math.Abs(34.39355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58303 - lat) + Math.Abs(27.4407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08524 - lat) + Math.Abs(35.32945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11389 - lat) + Math.Abs(38.08599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96391 - lat) + Math.Abs(39.00583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65803 - lat) + Math.Abs(30.81821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19904 - lat) + Math.Abs(34.09384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22472 - lat) + Math.Abs(34.64031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96345 - lat) + Math.Abs(24.33542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00577 - lat) + Math.Abs(33.2615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36506 - lat) + Math.Abs(32.65785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.98113 - lat) + Math.Abs(29.82813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71901 - lat) + Math.Abs(35.86578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56821 - lat) + Math.Abs(32.90273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16517 - lat) + Math.Abs(35.25304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30778 - lat) + Math.Abs(31.78506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59996 - lat) + Math.Abs(33.22707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75451 - lat) + Math.Abs(33.34864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.93768 - lat) + Math.Abs(34.2525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.4996 - lat) + Math.Abs(34.24298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.69296 - lat) + Math.Abs(28.63446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.83716 - lat) + Math.Abs(27.27434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93152 - lat) + Math.Abs(31.58282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78281 - lat) + Math.Abs(34.78441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.04801 - lat) + Math.Abs(31.88688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1135 - lat) + Math.Abs(38.16064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.58464 - lat) + Math.Abs(38.17429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84842 - lat) + Math.Abs(34.38044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.19911 - lat) + Math.Abs(23.44757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44789 - lat) + Math.Abs(34.73839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21654 - lat) + Math.Abs(33.15951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57119 - lat) + Math.Abs(34.39637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54135 - lat) + Math.Abs(30.75615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96213 - lat) + Math.Abs(33.61061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.67472 - lat) + Math.Abs(22.38813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.34004 - lat) + Math.Abs(26.64171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11814 - lat) + Math.Abs(23.76588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.97076 - lat) + Math.Abs(28.83779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56101 - lat) + Math.Abs(23.03146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44085 - lat) + Math.Abs(34.98584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83398 - lat) + Math.Abs(33.87626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81526 - lat) + Math.Abs(24.21657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27088 - lat) + Math.Abs(34.44898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.74952 - lat) + Math.Abs(23.92746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72617 - lat) + Math.Abs(34.00979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40828 - lat) + Math.Abs(33.27339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05285 - lat) + Math.Abs(35.29415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.20286 - lat) + Math.Abs(29.08228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.79615 - lat) + Math.Abs(33.8083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.6348 - lat) + Math.Abs(24.56936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44788 - lat) + Math.Abs(35.83528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42985 - lat) + Math.Abs(35.8225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52372 - lat) + Math.Abs(23.98522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96591 - lat) + Math.Abs(31.9974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90618 - lat) + Math.Abs(34.02605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17959 - lat) + Math.Abs(22.69943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46586 - lat) + Math.Abs(34.54316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48329 - lat) + Math.Abs(34.35008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.72348 - lat) + Math.Abs(27.51892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52143 - lat) + Math.Abs(22.9367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43919 - lat) + Math.Abs(22.71779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79467 - lat) + Math.Abs(23.15077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.89081 - lat) + Math.Abs(38.06395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52754 - lat) + Math.Abs(31.73708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82593 - lat) + Math.Abs(34.80314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.15652 - lat) + Math.Abs(23.87232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08909 - lat) + Math.Abs(25.17327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9909 - lat) + Math.Abs(29.8047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.34511 - lat) + Math.Abs(39.65244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.22326 - lat) + Math.Abs(26.02139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17732 - lat) + Math.Abs(32.66015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00354 - lat) + Math.Abs(34.05634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1996 - lat) + Math.Abs(33.22233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44598 - lat) + Math.Abs(27.7982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.509 - lat) + Math.Abs(25.61675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.33691 - lat) + Math.Abs(31.51704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4 - lat) + Math.Abs(26.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.0775 - lat) + Math.Abs(38.90364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23423 - lat) + Math.Abs(33.7015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45114 - lat) + Math.Abs(34.67883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.93126 - lat) + Math.Abs(30.62309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66007 - lat) + Math.Abs(30.98225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47054 - lat) + Math.Abs(34.2224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30788 - lat) + Math.Abs(33.03501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.96854 - lat) + Math.Abs(33.60886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5888 - lat) + Math.Abs(22.27502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.37528 - lat) + Math.Abs(40.13222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.396 - lat) + Math.Abs(25.60518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27235 - lat) + Math.Abs(35.22235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52838 - lat) + Math.Abs(34.64058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11325 - lat) + Math.Abs(33.61071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15749 - lat) + Math.Abs(25.37904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03719 - lat) + Math.Abs(30.95153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0743 - lat) + Math.Abs(34.70672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58751 - lat) + Math.Abs(32.84501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.65431 - lat) + Math.Abs(26.86626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05247 - lat) + Math.Abs(25.62208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.52458 - lat) + Math.Abs(23.50563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25318 - lat) + Math.Abs(36.73468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87654 - lat) + Math.Abs(34.84808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63486 - lat) + Math.Abs(35.3134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93045 - lat) + Math.Abs(38.55369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82302 - lat) + Math.Abs(36.05069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1768 - lat) + Math.Abs(33.9968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5217 - lat) + Math.Abs(32.21568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84891 - lat) + Math.Abs(35.36533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63009 - lat) + Math.Abs(35.41558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95957 - lat) + Math.Abs(37.39981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43748 - lat) + Math.Abs(27.40487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38597 - lat) + Math.Abs(33.004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88389 - lat) + Math.Abs(34.55562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43055 - lat) + Math.Abs(23.75073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0055 - lat) + Math.Abs(34.25581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59555 - lat) + Math.Abs(34.55213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44083 - lat) + Math.Abs(29.55985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41748 - lat) + Math.Abs(30.27413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07473 - lat) + Math.Abs(35.14444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50958 - lat) + Math.Abs(34.18817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.44308 - lat) + Math.Abs(34.86688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1133 - lat) + Math.Abs(36.23992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87198 - lat) + Math.Abs(34.33104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21751 - lat) + Math.Abs(26.29133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5229 - lat) + Math.Abs(39.57055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.67576 - lat) + Math.Abs(24.41382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09514 - lat) + Math.Abs(37.54131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72922 - lat) + Math.Abs(34.26846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94527 - lat) + Math.Abs(37.50544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02428 - lat) + Math.Abs(34.61202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63543 - lat) + Math.Abs(34.62769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19853 - lat) + Math.Abs(36.09144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44627 - lat) + Math.Abs(34.29474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65541 - lat) + Math.Abs(24.37537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96349 - lat) + Math.Abs(30.33366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.29405 - lat) + Math.Abs(25.53436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.97982 - lat) + Math.Abs(35.85835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61356 - lat) + Math.Abs(34.36469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09051 - lat) + Math.Abs(34.849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75888 - lat) + Math.Abs(34.55789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6555 - lat) + Math.Abs(35.25649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78142 - lat) + Math.Abs(33.4479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77233 - lat) + Math.Abs(29.23833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.64308 - lat) + Math.Abs(31.63657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53563 - lat) + Math.Abs(35.89293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.06354 - lat) + Math.Abs(36.16564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24737 - lat) + Math.Abs(34.93457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43473 - lat) + Math.Abs(34.22134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58104 - lat) + Math.Abs(33.26684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.79487 - lat) + Math.Abs(26.69188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04782 - lat) + Math.Abs(37.92576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.46408 - lat) + Math.Abs(29.81128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.92111 - lat) + Math.Abs(34.91491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86312 - lat) + Math.Abs(34.04969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6835 - lat) + Math.Abs(30.39324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94691 - lat) + Math.Abs(35.92907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22601 - lat) + Math.Abs(24.03727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81063 - lat) + Math.Abs(33.56862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76535 - lat) + Math.Abs(25.5142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7026 - lat) + Math.Abs(30.65692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.92045 - lat) + Math.Abs(27.75918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.25229 - lat) + Math.Abs(30.82946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17059 - lat) + Math.Abs(31.10994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83826 - lat) + Math.Abs(24.02324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36492 - lat) + Math.Abs(25.77173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.40507 - lat) + Math.Abs(39.22675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75932 - lat) + Math.Abs(25.34244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23726 - lat) + Math.Abs(33.9051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.0521 - lat) + Math.Abs(25.40059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56705 - lat) + Math.Abs(39.31706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23469 - lat) + Math.Abs(35.72202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08203 - lat) + Math.Abs(28.40057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44574 - lat) + Math.Abs(38.26153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73646 - lat) + Math.Abs(34.40063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.01625 - lat) + Math.Abs(32.99694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.3219 - lat) + Math.Abs(31.99673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.906 - lat) + Math.Abs(34.16414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88937 - lat) + Math.Abs(36.31755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.0571 - lat) + Math.Abs(33.28581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8391 - lat) + Math.Abs(38.74098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36527 - lat) + Math.Abs(23.96382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.22022 - lat) + Math.Abs(24.84831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40174 - lat) + Math.Abs(34.68395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36776 - lat) + Math.Abs(33.26024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.737 - lat) + Math.Abs(24.64944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77552 - lat) + Math.Abs(34.24236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43024 - lat) + Math.Abs(29.89232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83716 - lat) + Math.Abs(30.25976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.47021 - lat) + Math.Abs(34.14272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08648 - lat) + Math.Abs(34.31107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.32509 - lat) + Math.Abs(28.08094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.49677 - lat) + Math.Abs(23.28992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.90485 - lat) + Math.Abs(38.44207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22964 - lat) + Math.Abs(29.05555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56428 - lat) + Math.Abs(33.79793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44694 - lat) + Math.Abs(31.07611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26107 - lat) + Math.Abs(23.38336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6557 - lat) + Math.Abs(29.96722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59769 - lat) + Math.Abs(36.4703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68735 - lat) + Math.Abs(33.92279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38263 - lat) + Math.Abs(27.63051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6892 - lat) + Math.Abs(32.32919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94111 - lat) + Math.Abs(34.95318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26844 - lat) + Math.Abs(34.05023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25373 - lat) + Math.Abs(35.91969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29857 - lat) + Math.Abs(35.77708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.42944 - lat) + Math.Abs(39.14556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05198 - lat) + Math.Abs(34.74841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96242 - lat) + Math.Abs(31.52696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.084 - lat) + Math.Abs(32.52955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.06667 - lat) + Math.Abs(24.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26852 - lat) + Math.Abs(24.4201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86328 - lat) + Math.Abs(26.09082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.55781 - lat) + Math.Abs(24.75622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68496 - lat) + Math.Abs(29.23679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.51959 - lat) + Math.Abs(32.58178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.45466 - lat) + Math.Abs(30.5238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.14973 - lat) + Math.Abs(24.27995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45842 - lat) + Math.Abs(38.2135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.358 - lat) + Math.Abs(36.64908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.629 - lat) + Math.Abs(33.86895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25868 - lat) + Math.Abs(25.17946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.72154 - lat) + Math.Abs(34.36983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81227 - lat) + Math.Abs(38.28822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.71278 - lat) + Math.Abs(35.20917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43988 - lat) + Math.Abs(23.25816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.06893 - lat) + Math.Abs(33.93912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98522 - lat) + Math.Abs(37.2821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71055 - lat) + Math.Abs(37.61517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.04139 - lat) + Math.Abs(32.01382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83811 - lat) + Math.Abs(33.61932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98178 - lat) + Math.Abs(36.38283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.37345 - lat) + Math.Abs(31.64661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31424 - lat) + Math.Abs(24.81757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38289 - lat) + Math.Abs(28.86622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56167 - lat) + Math.Abs(30.79487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.90966 - lat) + Math.Abs(33.38044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18836 - lat) + Math.Abs(33.80106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70453 - lat) + Math.Abs(34.18782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05974 - lat) + Math.Abs(32.10634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68825 - lat) + Math.Abs(23.15485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54775 - lat) + Math.Abs(33.38475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95242 - lat) + Math.Abs(30.34928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.19516 - lat) + Math.Abs(24.69624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.87382 - lat) + Math.Abs(37.90327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.38495 - lat) + Math.Abs(30.19978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17234 - lat) + Math.Abs(23.23647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12899 - lat) + Math.Abs(38.02597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.37551 - lat) + Math.Abs(34.46701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72268 - lat) + Math.Abs(33.93938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07709 - lat) + Math.Abs(39.058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46792 - lat) + Math.Abs(34.08513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.34558 - lat) + Math.Abs(24.57836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0495 - lat) + Math.Abs(38.21792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.09693 - lat) + Math.Abs(25.72459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06802 - lat) + Math.Abs(33.42041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05112 - lat) + Math.Abs(23.81586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22993 - lat) + Math.Abs(33.83239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.07636 - lat) + Math.Abs(29.64899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25 - lat) + Math.Abs(38.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.64218 - lat) + Math.Abs(33.7813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13954 - lat) + Math.Abs(38.93715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.98837 - lat) + Math.Abs(37.80225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20138 - lat) + Math.Abs(38.79765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28676 - lat) + Math.Abs(34.00036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.91447 - lat) + Math.Abs(24.6134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13088 - lat) + Math.Abs(32.7691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50661 - lat) + Math.Abs(33.26641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68204 - lat) + Math.Abs(37.53266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41343 - lat) + Math.Abs(32.67807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62258 - lat) + Math.Abs(30.77421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77458 - lat) + Math.Abs(35.25965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95716 - lat) + Math.Abs(33.7965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13643 - lat) + Math.Abs(36.31911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.83259 - lat) + Math.Abs(34.23086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.06602 - lat) + Math.Abs(35.16275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.56383 - lat) + Math.Abs(34.28877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50271 - lat) + Math.Abs(34.30134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18348 - lat) + Math.Abs(34.95066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38009 - lat) + Math.Abs(35.44186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24513 - lat) + Math.Abs(35.80739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31572 - lat) + Math.Abs(34.94756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31245 - lat) + Math.Abs(39.56284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.29235 - lat) + Math.Abs(39.73921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99103 - lat) + Math.Abs(34.03037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28198 - lat) + Math.Abs(37.17585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13432 - lat) + Math.Abs(34.04015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05776 - lat) + Math.Abs(34.35631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48241 - lat) + Math.Abs(32.9379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47379 - lat) + Math.Abs(34.12859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.57571 - lat) + Math.Abs(24.70027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65186 - lat) + Math.Abs(26.97253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.72305 - lat) + Math.Abs(37.55629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43544 - lat) + Math.Abs(25.15086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.97231 - lat) + Math.Abs(29.76424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21682 - lat) + Math.Abs(33.8481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91334 - lat) + Math.Abs(31.1214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.63096 - lat) + Math.Abs(37.68821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21526 - lat) + Math.Abs(24.70867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48836 - lat) + Math.Abs(30.32957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75305 - lat) + Math.Abs(29.53205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.06864 - lat) + Math.Abs(34.75862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36584 - lat) + Math.Abs(34.02575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8266 - lat) + Math.Abs(31.13551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65455 - lat) + Math.Abs(25.71316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87841 - lat) + Math.Abs(26.45192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31071 - lat) + Math.Abs(25.09575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75089 - lat) + Math.Abs(24.36731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32991 - lat) + Math.Abs(24.82052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25505 - lat) + Math.Abs(22.45597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76877 - lat) + Math.Abs(32.24813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.41894 - lat) + Math.Abs(31.25865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94737 - lat) + Math.Abs(36.03736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31723 - lat) + Math.Abs(29.0563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95937 - lat) + Math.Abs(28.63855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56638 - lat) + Math.Abs(32.95861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15247 - lat) + Math.Abs(23.13659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0953 - lat) + Math.Abs(29.53581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41661 - lat) + Math.Abs(31.46261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50001 - lat) + Math.Abs(33.61192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61655 - lat) + Math.Abs(27.16055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.43374 - lat) + Math.Abs(34.08516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10441 - lat) + Math.Abs(25.91026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85917 - lat) + Math.Abs(27.7969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5277 - lat) + Math.Abs(37.7069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81673 - lat) + Math.Abs(35.42287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24032 - lat) + Math.Abs(33.20263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63125 - lat) + Math.Abs(34.47387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59701 - lat) + Math.Abs(36.52618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25115 - lat) + Math.Abs(32.20795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8128 - lat) + Math.Abs(30.93934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35811 - lat) + Math.Abs(34.15802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.62739 - lat) + Math.Abs(23.69952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32807 - lat) + Math.Abs(33.44992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26936 - lat) + Math.Abs(33.29386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81667 - lat) + Math.Abs(27.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.53115 - lat) + Math.Abs(25.03649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83987 - lat) + Math.Abs(35.30441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22682 - lat) + Math.Abs(34.33698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58561 - lat) + Math.Abs(26.31601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.42851 - lat) + Math.Abs(23.6959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03034 - lat) + Math.Abs(29.93614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94367 - lat) + Math.Abs(33.78865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37237 - lat) + Math.Abs(33.78154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.09875 - lat) + Math.Abs(29.12463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59488 - lat) + Math.Abs(29.55873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.88005 - lat) + Math.Abs(36.73723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86622 - lat) + Math.Abs(33.80428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82854 - lat) + Math.Abs(31.50439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66499 - lat) + Math.Abs(31.20804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.14892 - lat) + Math.Abs(34.19653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.46275 - lat) + Math.Abs(30.78369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43161 - lat) + Math.Abs(26.26231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49584 - lat) + Math.Abs(34.47516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74305 - lat) + Math.Abs(25.97628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11934 - lat) + Math.Abs(39.4588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.39037 - lat) + Math.Abs(28.41092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58416 - lat) + Math.Abs(30.01134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83425 - lat) + Math.Abs(25.45821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44357 - lat) + Math.Abs(25.7668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20029 - lat) + Math.Abs(34.05069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54503 - lat) + Math.Abs(33.07769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22967 - lat) + Math.Abs(35.19987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0234 - lat) + Math.Abs(37.93161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.63751 - lat) + Math.Abs(38.6428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5132 - lat) + Math.Abs(32.2597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22106 - lat) + Math.Abs(35.84227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37592 - lat) + Math.Abs(35.36753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36408 - lat) + Math.Abs(35.1149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45518 - lat) + Math.Abs(29.26367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53417 - lat) + Math.Abs(22.85538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1793 - lat) + Math.Abs(23.29909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81577 - lat) + Math.Abs(29.97703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.33069 - lat) + Math.Abs(30.46836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.50693 - lat) + Math.Abs(26.49121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21114 - lat) + Math.Abs(25.92165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85413 - lat) + Math.Abs(36.21704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78367 - lat) + Math.Abs(33.27833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87096 - lat) + Math.Abs(32.60063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.40993 - lat) + Math.Abs(24.3047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.42161 - lat) + Math.Abs(26.99653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54507 - lat) + Math.Abs(33.65395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55979 - lat) + Math.Abs(27.95754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38639 - lat) + Math.Abs(25.14803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65581 - lat) + Math.Abs(32.6178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.44134 - lat) + Math.Abs(33.73228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70138 - lat) + Math.Abs(35.3401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04243 - lat) + Math.Abs(38.14728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98081 - lat) + Math.Abs(36.25272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35675 - lat) + Math.Abs(36.47542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46503 - lat) + Math.Abs(26.83457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.28656 - lat) + Math.Abs(35.76153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71431 - lat) + Math.Abs(28.83385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.84625 - lat) + Math.Abs(32.82177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70372 - lat) + Math.Abs(32.9776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.37678 - lat) + Math.Abs(35.12398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80595 - lat) + Math.Abs(30.13763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.39525 - lat) + Math.Abs(33.97239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9553 - lat) + Math.Abs(30.96823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44928 - lat) + Math.Abs(33.35755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52439 - lat) + Math.Abs(34.08012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45723 - lat) + Math.Abs(35.12975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.67935 - lat) + Math.Abs(38.08902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.64237 - lat) + Math.Abs(30.79002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91719 - lat) + Math.Abs(31.71671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.75182 - lat) + Math.Abs(31.46004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28469 - lat) + Math.Abs(33.53446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32755 - lat) + Math.Abs(36.69298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.18359 - lat) + Math.Abs(33.68269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23333 - lat) + Math.Abs(29.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.71598 - lat) + Math.Abs(35.52981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63716 - lat) + Math.Abs(32.50719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.6845 - lat) + Math.Abs(26.58559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.97974 - lat) + Math.Abs(33.52638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16829 - lat) + Math.Abs(39.16537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62412 - lat) + Math.Abs(24.95864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48481 - lat) + Math.Abs(34.41146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.10655 - lat) + Math.Abs(24.34451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0318 - lat) + Math.Abs(32.10396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.69343 - lat) + Math.Abs(22.3957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01187 - lat) + Math.Abs(24.37308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.14078 - lat) + Math.Abs(23.8738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45389 - lat) + Math.Abs(28.52608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48524 - lat) + Math.Abs(32.68651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31658 - lat) + Math.Abs(35.74643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4571 - lat) + Math.Abs(37.46403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74262 - lat) + Math.Abs(33.77676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59521 - lat) + Math.Abs(34.2203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73746 - lat) + Math.Abs(28.81441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25623 - lat) + Math.Abs(33.2907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9833 - lat) + Math.Abs(34.0616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81371 - lat) + Math.Abs(33.48698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94537 - lat) + Math.Abs(33.70591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86233 - lat) + Math.Abs(30.82815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58337 - lat) + Math.Abs(25.76871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77635 - lat) + Math.Abs(33.54387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04437 - lat) + Math.Abs(35.13717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.20875 - lat) + Math.Abs(37.24849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11947 - lat) + Math.Abs(26.82125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57019 - lat) + Math.Abs(34.94469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70276 - lat) + Math.Abs(34.35357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34929 - lat) + Math.Abs(28.84079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03962 - lat) + Math.Abs(25.66232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21525 - lat) + Math.Abs(23.32867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97569 - lat) + Math.Abs(30.46998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72082 - lat) + Math.Abs(34.55298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.072 - lat) + Math.Abs(33.6613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9215 - lat) + Math.Abs(24.70972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93865 - lat) + Math.Abs(29.89426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63879 - lat) + Math.Abs(24.36003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.29734 - lat) + Math.Abs(25.27406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92403 - lat) + Math.Abs(33.82364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31667 - lat) + Math.Abs(23.03846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.52175 - lat) + Math.Abs(30.25055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.92498 - lat) + Math.Abs(38.20235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30495 - lat) + Math.Abs(30.65478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10479 - lat) + Math.Abs(29.21773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28348 - lat) + Math.Abs(35.73864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24524 - lat) + Math.Abs(35.07127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86258 - lat) + Math.Abs(32.39425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16374 - lat) + Math.Abs(26.58394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.33576 - lat) + Math.Abs(38.05325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08971 - lat) + Math.Abs(25.92933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.67822 - lat) + Math.Abs(33.9162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68517 - lat) + Math.Abs(24.55055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58688 - lat) + Math.Abs(33.97681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11692 - lat) + Math.Abs(34.02188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13322 - lat) + Math.Abs(35.34394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0729 - lat) + Math.Abs(26.1848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54624 - lat) + Math.Abs(34.27841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11139 - lat) + Math.Abs(34.73556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66389 - lat) + Math.Abs(36.25633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82795 - lat) + Math.Abs(27.04573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.8098 - lat) + Math.Abs(35.25602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02281 - lat) + Math.Abs(34.97301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.93529 - lat) + Math.Abs(28.60383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64219 - lat) + Math.Abs(33.83098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.33208 - lat) + Math.Abs(26.01112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00804 - lat) + Math.Abs(34.02657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.96515 - lat) + Math.Abs(23.4817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11712 - lat) + Math.Abs(32.4361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23458 - lat) + Math.Abs(33.13613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56841 - lat) + Math.Abs(30.2651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6003 - lat) + Math.Abs(26.67435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73468 - lat) + Math.Abs(38.49541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1535 - lat) + Math.Abs(33.61889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50186 - lat) + Math.Abs(24.76149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78465 - lat) + Math.Abs(23.64806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89085 - lat) + Math.Abs(31.59741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80697 - lat) + Math.Abs(27.31676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89083 - lat) + Math.Abs(28.84833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63965 - lat) + Math.Abs(26.36573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.28489 - lat) + Math.Abs(31.44513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.67274 - lat) + Math.Abs(25.50163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00777 - lat) + Math.Abs(33.72899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27819 - lat) + Math.Abs(36.18601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27076 - lat) + Math.Abs(23.43475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59481 - lat) + Math.Abs(23.90915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85118 - lat) + Math.Abs(38.00632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.46594 - lat) + Math.Abs(33.69986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.41126 - lat) + Math.Abs(33.98634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68097 - lat) + Math.Abs(29.16059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.59382 - lat) + Math.Abs(33.91521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.47118 - lat) + Math.Abs(28.8253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97516 - lat) + Math.Abs(34.63102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.384 - lat) + Math.Abs(30.46131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08651 - lat) + Math.Abs(25.00767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52719 - lat) + Math.Abs(32.52417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76667 - lat) + Math.Abs(23.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.32899 - lat) + Math.Abs(30.71059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.79147 - lat) + Math.Abs(33.91593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38784 - lat) + Math.Abs(33.25959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.27423 - lat) + Math.Abs(30.32706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38792 - lat) + Math.Abs(36.57965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80396 - lat) + Math.Abs(33.48138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17592 - lat) + Math.Abs(34.8034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.33958 - lat) + Math.Abs(29.86791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81143 - lat) + Math.Abs(29.38977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.43364 - lat) + Math.Abs(34.10297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12179 - lat) + Math.Abs(24.72578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.37112 - lat) + Math.Abs(33.99099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75825 - lat) + Math.Abs(33.74434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33232 - lat) + Math.Abs(29.75903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26717 - lat) + Math.Abs(33.08693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.578 - lat) + Math.Abs(34.34464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02688 - lat) + Math.Abs(33.62956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.68002 - lat) + Math.Abs(33.60168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66737 - lat) + Math.Abs(33.73841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.39214 - lat) + Math.Abs(33.78798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56646 - lat) + Math.Abs(30.85965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08192 - lat) + Math.Abs(33.7851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03199 - lat) + Math.Abs(35.38153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0767 - lat) + Math.Abs(29.9177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73247 - lat) + Math.Abs(33.60499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79614 - lat) + Math.Abs(36.59047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.30003 - lat) + Math.Abs(39.61526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49865 - lat) + Math.Abs(34.6574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73333 - lat) + Math.Abs(24.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69083 - lat) + Math.Abs(34.30966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71168 - lat) + Math.Abs(34.39274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50213 - lat) + Math.Abs(34.33742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.14802 - lat) + Math.Abs(27.93124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.39869 - lat) + Math.Abs(37.84787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56738 - lat) + Math.Abs(23.94607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78647 - lat) + Math.Abs(30.3026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85019 - lat) + Math.Abs(37.68262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.02078 - lat) + Math.Abs(26.84122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88909 - lat) + Math.Abs(26.85636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61701 - lat) + Math.Abs(24.82488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23134 - lat) + Math.Abs(23.81532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18557 - lat) + Math.Abs(33.7639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39109 - lat) + Math.Abs(34.12392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57438 - lat) + Math.Abs(26.56503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17205 - lat) + Math.Abs(23.88954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41694 - lat) + Math.Abs(25.73432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.90411 - lat) + Math.Abs(24.08637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.49832 - lat) + Math.Abs(23.38718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04545 - lat) + Math.Abs(33.94517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18768 - lat) + Math.Abs(27.97403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80156 - lat) + Math.Abs(32.35769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04251 - lat) + Math.Abs(25.45055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.34991 - lat) + Math.Abs(23.50561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.0416 - lat) + Math.Abs(37.72962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23573 - lat) + Math.Abs(23.54914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.96029 - lat) + Math.Abs(32.1407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.37332 - lat) + Math.Abs(27.98742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.023 - lat) + Math.Abs(37.80224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63192 - lat) + Math.Abs(30.98851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9733 - lat) + Math.Abs(24.00944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11041 - lat) + Math.Abs(32.76449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13913 - lat) + Math.Abs(34.38099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7532 - lat) + Math.Abs(33.77766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86176 - lat) + Math.Abs(33.94098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36527 - lat) + Math.Abs(23.27904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75046 - lat) + Math.Abs(37.67936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06314 - lat) + Math.Abs(31.18567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37441 - lat) + Math.Abs(33.36547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86632 - lat) + Math.Abs(34.22661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38778 - lat) + Math.Abs(31.18028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46147 - lat) + Math.Abs(37.08524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.57193 - lat) + Math.Abs(22.78629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.4593 - lat) + Math.Abs(35.03865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.51134 - lat) + Math.Abs(34.6021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74631 - lat) + Math.Abs(33.27288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42945 - lat) + Math.Abs(34.61805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38169 - lat) + Math.Abs(34.97652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.7969 - lat) + Math.Abs(32.71645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48411 - lat) + Math.Abs(35.0588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93611 - lat) + Math.Abs(38.93661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.60767 - lat) + Math.Abs(32.98347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97167 - lat) + Math.Abs(28.98639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.30523 - lat) + Math.Abs(37.26091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.82501 - lat) + Math.Abs(34.52787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92731 - lat) + Math.Abs(30.76048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.10659 - lat) + Math.Abs(36.12112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.2692 - lat) + Math.Abs(27.43382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92281 - lat) + Math.Abs(34.2276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.42814 - lat) + Math.Abs(25.33619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.52354 - lat) + Math.Abs(24.62466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58264 - lat) + Math.Abs(32.77012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.34072 - lat) + Math.Abs(38.4049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12099 - lat) + Math.Abs(25.56461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.00449 - lat) + Math.Abs(29.42559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66006 - lat) + Math.Abs(33.08059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88448 - lat) + Math.Abs(34.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.03099 - lat) + Math.Abs(34.00193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71043 - lat) + Math.Abs(35.16571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35763 - lat) + Math.Abs(32.3514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83588 - lat) + Math.Abs(36.68803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05204 - lat) + Math.Abs(28.11745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01709 - lat) + Math.Abs(25.79804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83325 - lat) + Math.Abs(28.95334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43198 - lat) + Math.Abs(22.20555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13999 - lat) + Math.Abs(34.09452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60474 - lat) + Math.Abs(34.83395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36541 - lat) + Math.Abs(36.18312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88152 - lat) + Math.Abs(34.04716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.48179 - lat) + Math.Abs(22.8217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08376 - lat) + Math.Abs(32.65549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38806 - lat) + Math.Abs(24.72647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.17906 - lat) + Math.Abs(37.42593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77006 - lat) + Math.Abs(34.06729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94975 - lat) + Math.Abs(28.86874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07613 - lat) + Math.Abs(39.79618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.62298 - lat) + Math.Abs(34.53887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.39105 - lat) + Math.Abs(24.23514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.46784 - lat) + Math.Abs(28.2713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.12994 - lat) + Math.Abs(25.25576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.37281 - lat) + Math.Abs(32.15742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.62315 - lat) + Math.Abs(34.14198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66034 - lat) + Math.Abs(25.44832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65222 - lat) + Math.Abs(33.35904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.21882 - lat) + Math.Abs(31.93082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.45652 - lat) + Math.Abs(28.67018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32339 - lat) + Math.Abs(38.52272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.26732 - lat) + Math.Abs(32.94196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40808 - lat) + Math.Abs(34.8199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8464 - lat) + Math.Abs(29.06062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04399 - lat) + Math.Abs(34.63916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50657 - lat) + Math.Abs(32.69776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.83034 - lat) + Math.Abs(24.89576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69411 - lat) + Math.Abs(32.55371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66644 - lat) + Math.Abs(32.32932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85658 - lat) + Math.Abs(24.71388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.29149 - lat) + Math.Abs(25.94034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50551 - lat) + Math.Abs(31.28487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19992 - lat) + Math.Abs(36.16148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54225 - lat) + Math.Abs(28.11473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81207 - lat) + Math.Abs(25.42477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.42854 - lat) + Math.Abs(32.06207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01179 - lat) + Math.Abs(26.34203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20729 - lat) + Math.Abs(36.3762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21509 - lat) + Math.Abs(29.36728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81111 - lat) + Math.Abs(34.59538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08223 - lat) + Math.Abs(34.08673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.59348 - lat) + Math.Abs(37.85724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36507 - lat) + Math.Abs(33.54027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.36625 - lat) + Math.Abs(35.87486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38179 - lat) + Math.Abs(30.45137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.42603 - lat) + Math.Abs(29.54291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47114 - lat) + Math.Abs(36.34507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28119 - lat) + Math.Abs(34.89428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.62968 - lat) + Math.Abs(24.47398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83942 - lat) + Math.Abs(29.26775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.45931 - lat) + Math.Abs(24.24545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78202 - lat) + Math.Abs(33.42825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.29285 - lat) + Math.Abs(27.98314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.96548 - lat) + Math.Abs(24.61227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05121 - lat) + Math.Abs(23.48579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19912 - lat) + Math.Abs(33.83523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.25867 - lat) + Math.Abs(24.62777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.93554 - lat) + Math.Abs(33.87109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.84058 - lat) + Math.Abs(29.64522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.09252 - lat) + Math.Abs(30.40355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.89133 - lat) + Math.Abs(36.02096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.06879 - lat) + Math.Abs(28.04221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06254 - lat) + Math.Abs(25.38798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.54345 - lat) + Math.Abs(30.21201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.90467 - lat) + Math.Abs(23.95969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.511 - lat) + Math.Abs(38.67222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.28449 - lat) + Math.Abs(29.52626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.93235 - lat) + Math.Abs(29.19816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.51809 - lat) + Math.Abs(30.80671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37327 - lat) + Math.Abs(28.783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.99621 - lat) + Math.Abs(24.19748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.08791 - lat) + Math.Abs(25.15027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42476 - lat) + Math.Abs(33.14721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.82257 - lat) + Math.Abs(28.9407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8636 - lat) + Math.Abs(31.58393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10986 - lat) + Math.Abs(28.17459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31911 - lat) + Math.Abs(30.29728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27077 - lat) + Math.Abs(26.12624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.51564 - lat) + Math.Abs(34.2384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.25464 - lat) + Math.Abs(32.4269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.80332 - lat) + Math.Abs(26.04347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.17625 - lat) + Math.Abs(30.10429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.3777 - lat) + Math.Abs(37.62136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61839 - lat) + Math.Abs(34.97042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.64484 - lat) + Math.Abs(29.9201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3025 - lat) + Math.Abs(29.24167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.35269 - lat) + Math.Abs(30.95501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.28672 - lat) + Math.Abs(23.43238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40017 - lat) + Math.Abs(36.48765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.18333 - lat) + Math.Abs(24.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68262 - lat) + Math.Abs(28.61487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.06607 - lat) + Math.Abs(23.86435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.54939 - lat) + Math.Abs(30.8744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.807 - lat) + Math.Abs(24.53834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.16466 - lat) + Math.Abs(35.52765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.21807 - lat) + Math.Abs(32.01476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04122 - lat) + Math.Abs(24.35222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02933 - lat) + Math.Abs(34.76732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86935 - lat) + Math.Abs(35.05996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05896 - lat) + Math.Abs(32.16641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74693 - lat) + Math.Abs(31.3948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.64093 - lat) + Math.Abs(24.28874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.34998 - lat) + Math.Abs(30.18858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07166 - lat) + Math.Abs(22.89585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85775 - lat) + Math.Abs(36.55505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05694 - lat) + Math.Abs(35.33056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64093 - lat) + Math.Abs(34.38054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.87928 - lat) + Math.Abs(38.48492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70013 - lat) + Math.Abs(37.41898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95631 - lat) + Math.Abs(39.73843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1952 - lat) + Math.Abs(30.34938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80939 - lat) + Math.Abs(30.11209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10716 - lat) + Math.Abs(37.93815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.87547 - lat) + Math.Abs(36.26539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04509 - lat) + Math.Abs(34.21413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36782 - lat) + Math.Abs(29.51726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84152 - lat) + Math.Abs(33.42838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.30943 - lat) + Math.Abs(23.474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.43935 - lat) + Math.Abs(35.70736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20429 - lat) + Math.Abs(30.9078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57471 - lat) + Math.Abs(33.34397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00094 - lat) + Math.Abs(26.75106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.51407 - lat) + Math.Abs(23.21982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30783 - lat) + Math.Abs(32.84993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5716 - lat) + Math.Abs(31.78456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22968 - lat) + Math.Abs(29.20436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45 - lat) + Math.Abs(24.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85262 - lat) + Math.Abs(31.38802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36047 - lat) + Math.Abs(25.11071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20555 - lat) + Math.Abs(22.64418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0947 - lat) + Math.Abs(35.43385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9 - lat) + Math.Abs(33.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17882 - lat) + Math.Abs(25.34855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23187 - lat) + Math.Abs(22.74591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.89928 - lat) + Math.Abs(28.60235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76644 - lat) + Math.Abs(36.79872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.38226 - lat) + Math.Abs(24.00642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.48722 - lat) + Math.Abs(24.70078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48319 - lat) + Math.Abs(30.21678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6248 - lat) + Math.Abs(32.44251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.49523 - lat) + Math.Abs(39.05051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.20846 - lat) + Math.Abs(39.58975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15016 - lat) + Math.Abs(34.31287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.5341 - lat) + Math.Abs(38.73067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.61391 - lat) + Math.Abs(33.6098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.00263 - lat) + Math.Abs(26.42824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05462 - lat) + Math.Abs(34.60185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.92503 - lat) + Math.Abs(38.24822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.31503 - lat) + Math.Abs(23.13248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.40642 - lat) + Math.Abs(37.18111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37465 - lat) + Math.Abs(36.08212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0931 - lat) + Math.Abs(34.62191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63982 - lat) + Math.Abs(29.47041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.029 - lat) + Math.Abs(25.77059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2479 - lat) + Math.Abs(32.29123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71267 - lat) + Math.Abs(26.47331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.392 - lat) + Math.Abs(38.60174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23797 - lat) + Math.Abs(33.75836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.34567 - lat) + Math.Abs(32.87794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19402 - lat) + Math.Abs(35.61583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40719 - lat) + Math.Abs(32.43868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36098 - lat) + Math.Abs(31.32173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9097 - lat) + Math.Abs(37.02051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.29691 - lat) + Math.Abs(27.6622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23862 - lat) + Math.Abs(35.24659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.07717 - lat) + Math.Abs(27.68256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36612 - lat) + Math.Abs(25.34549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93548 - lat) + Math.Abs(29.61982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38336 - lat) + Math.Abs(34.94396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9939 - lat) + Math.Abs(34.4552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.4627 - lat) + Math.Abs(36.85951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.51118 - lat) + Math.Abs(33.59942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.20093 - lat) + Math.Abs(32.77451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18144 - lat) + Math.Abs(32.83463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75525 - lat) + Math.Abs(33.85782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37417 - lat) + Math.Abs(36.29705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09703 - lat) + Math.Abs(35.12991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70971 - lat) + Math.Abs(30.44827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58604 - lat) + Math.Abs(34.5668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69236 - lat) + Math.Abs(34.10156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7766 - lat) + Math.Abs(32.79988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13989 - lat) + Math.Abs(37.74255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5666 - lat) + Math.Abs(34.46111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32731 - lat) + Math.Abs(35.91295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45135 - lat) + Math.Abs(33.86889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99194 - lat) + Math.Abs(29.41824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.59559 - lat) + Math.Abs(37.99987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44061 - lat) + Math.Abs(38.732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.77118 - lat) + Math.Abs(35.06493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03678 - lat) + Math.Abs(34.39921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10919 - lat) + Math.Abs(33.69206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.90972 - lat) + Math.Abs(31.31963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66003 - lat) + Math.Abs(33.71369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11503 - lat) + Math.Abs(39.09128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80974 - lat) + Math.Abs(26.87714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54788 - lat) + Math.Abs(34.22291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.88195 - lat) + Math.Abs(29.34349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.02288 - lat) + Math.Abs(29.02023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72106 - lat) + Math.Abs(29.94502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79348 - lat) + Math.Abs(38.47768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27822 - lat) + Math.Abs(34.12823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67728 - lat) + Math.Abs(34.4097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.41808 - lat) + Math.Abs(34.04531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58194 - lat) + Math.Abs(33.6298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.70837 - lat) + Math.Abs(36.91561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83826 - lat) + Math.Abs(32.76116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32893 - lat) + Math.Abs(30.63481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57654 - lat) + Math.Abs(34.09947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02575 - lat) + Math.Abs(34.52832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46893 - lat) + Math.Abs(38.81669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81663 - lat) + Math.Abs(33.56313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69972 - lat) + Math.Abs(35.15916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51981 - lat) + Math.Abs(34.82438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31036 - lat) + Math.Abs(34.89879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01596 - lat) + Math.Abs(34.05725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94194 - lat) + Math.Abs(33.82229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01816 - lat) + Math.Abs(33.99961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54245 - lat) + Math.Abs(32.53542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10759 - lat) + Math.Abs(35.10139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81667 - lat) + Math.Abs(36.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.2197 - lat) + Math.Abs(23.48457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51717 - lat) + Math.Abs(26.64178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65311 - lat) + Math.Abs(35.69512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50357 - lat) + Math.Abs(32.7225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12944 - lat) + Math.Abs(33.6318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54044 - lat) + Math.Abs(29.46001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76044 - lat) + Math.Abs(29.98683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16302 - lat) + Math.Abs(29.78937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.2391 - lat) + Math.Abs(25.76575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36313 - lat) + Math.Abs(30.64891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50585 - lat) + Math.Abs(30.32521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01018 - lat) + Math.Abs(33.63567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5225 - lat) + Math.Abs(30.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12265 - lat) + Math.Abs(23.68858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8 - lat) + Math.Abs(26.12 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02908 - lat) + Math.Abs(34.93623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35134 - lat) + Math.Abs(34.3523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81888 - lat) + Math.Abs(34.04381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8321 - lat) + Math.Abs(34.05912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.87083 - lat) + Math.Abs(34.04278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90016 - lat) + Math.Abs(34.02503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9949 - lat) + Math.Abs(34.04167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.019 - lat) + Math.Abs(34.03049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07585 - lat) + Math.Abs(33.99942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29255 - lat) + Math.Abs(34.11183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04767 - lat) + Math.Abs(34.0838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.89717 - lat) + Math.Abs(34.07297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88687 - lat) + Math.Abs(34.10168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85511 - lat) + Math.Abs(34.12069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.89153 - lat) + Math.Abs(34.17891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04522 - lat) + Math.Abs(34.13511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.99133 - lat) + Math.Abs(34.20311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98035 - lat) + Math.Abs(34.25289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04357 - lat) + Math.Abs(34.30201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19885 - lat) + Math.Abs(34.42012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70841 - lat) + Math.Abs(34.38017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28629 - lat) + Math.Abs(34.61589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31747 - lat) + Math.Abs(34.67418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30013 - lat) + Math.Abs(34.7097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17847 - lat) + Math.Abs(34.71557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28055 - lat) + Math.Abs(34.87031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40387 - lat) + Math.Abs(34.2223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39136 - lat) + Math.Abs(34.35485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36161 - lat) + Math.Abs(34.85482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42453 - lat) + Math.Abs(34.28545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45 - lat) + Math.Abs(34.71995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46101 - lat) + Math.Abs(34.71991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46532 - lat) + Math.Abs(34.73307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45793 - lat) + Math.Abs(34.76189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45108 - lat) + Math.Abs(34.78812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48086 - lat) + Math.Abs(34.81087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52261 - lat) + Math.Abs(34.29907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5657 - lat) + Math.Abs(34.3036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.539 - lat) + Math.Abs(33.61859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60916 - lat) + Math.Abs(34.37992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65212 - lat) + Math.Abs(34.32694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69804 - lat) + Math.Abs(34.35756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64299 - lat) + Math.Abs(34.6841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74822 - lat) + Math.Abs(34.33246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77595 - lat) + Math.Abs(34.39453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08865 - lat) + Math.Abs(33.688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73704 - lat) + Math.Abs(34.41299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.6583 - lat) + Math.Abs(33.75456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83472 - lat) + Math.Abs(34.16129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8019 - lat) + Math.Abs(34.23786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88807 - lat) + Math.Abs(34.58139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94097 - lat) + Math.Abs(34.35262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38314 - lat) + Math.Abs(33.11715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50833 - lat) + Math.Abs(33.93397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71924 - lat) + Math.Abs(33.3903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73277 - lat) + Math.Abs(33.51552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8317 - lat) + Math.Abs(33.92151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96005 - lat) + Math.Abs(33.77155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99495 - lat) + Math.Abs(33.76588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24804 - lat) + Math.Abs(33.41773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14611 - lat) + Math.Abs(33.52037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1476 - lat) + Math.Abs(33.57583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13857 - lat) + Math.Abs(33.74675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25246 - lat) + Math.Abs(33.64104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28796 - lat) + Math.Abs(33.60957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28838 - lat) + Math.Abs(33.86414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29081 - lat) + Math.Abs(33.9744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12294 - lat) + Math.Abs(33.68662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09473 - lat) + Math.Abs(33.57211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05758 - lat) + Math.Abs(33.89737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03583 - lat) + Math.Abs(33.91494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98129 - lat) + Math.Abs(33.7392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.93024 - lat) + Math.Abs(33.71571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90424 - lat) + Math.Abs(33.78114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.84196 - lat) + Math.Abs(33.9956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8676 - lat) + Math.Abs(33.78995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86292 - lat) + Math.Abs(33.75897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82448 - lat) + Math.Abs(33.92098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81974 - lat) + Math.Abs(33.933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82316 - lat) + Math.Abs(33.96128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80373 - lat) + Math.Abs(33.87005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.79135 - lat) + Math.Abs(33.80347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.78677 - lat) + Math.Abs(33.61786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.74219 - lat) + Math.Abs(33.58913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73691 - lat) + Math.Abs(33.79823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70687 - lat) + Math.Abs(33.87096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7171 - lat) + Math.Abs(33.80417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.21415 - lat) + Math.Abs(28.40395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12597 - lat) + Math.Abs(22.79418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70385 - lat) + Math.Abs(30.07919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.06191 - lat) + Math.Abs(35.16395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04726 - lat) + Math.Abs(35.34538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81777 - lat) + Math.Abs(31.18263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3509 - lat) + Math.Abs(25.84738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73351 - lat) + Math.Abs(30.78472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51557 - lat) + Math.Abs(24.40381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53356 - lat) + Math.Abs(24.95974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.97954 - lat) + Math.Abs(24.07817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.06033 - lat) + Math.Abs(23.89956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69051 - lat) + Math.Abs(29.06193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.93023 - lat) + Math.Abs(23.57357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.35718 - lat) + Math.Abs(31.94773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41005 - lat) + Math.Abs(30.36724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.15821 - lat) + Math.Abs(30.07421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.37153 - lat) + Math.Abs(30.36861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.55731 - lat) + Math.Abs(30.33217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59718 - lat) + Math.Abs(30.57139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.34071 - lat) + Math.Abs(30.42356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.3689 - lat) + Math.Abs(31.12066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.39118 - lat) + Math.Abs(30.78 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.92459 - lat) + Math.Abs(35.76316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51033 - lat) + Math.Abs(31.88971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.99695 - lat) + Math.Abs(34.15603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03061 - lat) + Math.Abs(34.01068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3743 - lat) + Math.Abs(34.72013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92446 - lat) + Math.Abs(35.0754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42222 - lat) + Math.Abs(37.39778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17463 - lat) + Math.Abs(37.81199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5868 - lat) + Math.Abs(34.80948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14881 - lat) + Math.Abs(30.34601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36714 - lat) + Math.Abs(35.08132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.58362 - lat) + Math.Abs(33.64383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53249 - lat) + Math.Abs(33.59405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20581 - lat) + Math.Abs(35.19848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.79307 - lat) + Math.Abs(30.3911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66149 - lat) + Math.Abs(26.56031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.86686 - lat) + Math.Abs(30.79897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.37488 - lat) + Math.Abs(28.69955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.07015 - lat) + Math.Abs(26.22299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59483 - lat) + Math.Abs(29.4607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1740;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Olenevka", "11", 45.38333, 32.53333);
case 1: return new CityInfo("Urzuf", "05", 46.91562, 37.09961);
case 2: return new CityInfo("Novozuyevka", "11", 45.2387, 34.15456);
case 3: return new CityInfo("Lebedyn", "21", 50.58518, 34.4849);
case 4: return new CityInfo("Staryy Dobrotvir", "15", 50.23154, 24.37701);
case 5: return new CityInfo("Druzhkivka", "05", 48.63013, 37.55259);
case 6: return new CityInfo("Zhydachiv", "15", 49.38468, 24.14254);
case 7: return new CityInfo("Vasylivka", "26", 47.43694, 35.27417);
case 8: return new CityInfo("Kovyl’noye", "11", 45.69028, 33.52775);
case 9: return new CityInfo("Ivano-Frankove", "15", 49.91978, 23.72913);
case 10: return new CityInfo("Zybiny", "11", 45.23674, 34.64987);
case 11: return new CityInfo("Zvenihorodka", "01", 49.07866, 30.96755);
case 12: return new CityInfo("Zuya", "11", 45.05418, 34.32152);
case 13: return new CityInfo("Zuhres", "05", 48.0114, 38.26444);
case 14: return new CityInfo("Zorkino", "11", 45.54762, 34.71028);
case 15: return new CityInfo("Zoryns’k", "14", 48.41194, 38.62361);
case 16: return new CityInfo("Zolotyy Potik", "22", 48.9095, 25.33926);
case 17: return new CityInfo("Zolotoye Pole", "11", 45.12774, 34.99148);
case 18: return new CityInfo("Zolotonosha", "01", 49.66832, 32.04047);
case 19: return new CityInfo("Zolochiv", "07", 50.27985, 35.98179);
case 20: return new CityInfo("Zolochiv", "15", 49.80597, 24.89436);
case 21: return new CityInfo("Znomenka", "10", 48.71278, 32.66472);
case 22: return new CityInfo("Zmiyiv", "07", 49.67453, 36.34775);
case 23: return new CityInfo("Zlynka", "10", 48.48521, 31.53906);
case 24: return new CityInfo("Zymohiria", "14", 48.58528, 38.9375);
case 25: return new CityInfo("Zimino", "11", 45.50797, 33.51431);
case 26: return new CityInfo("Zhytomyr", "27", 50.26487, 28.67669);
case 27: return new CityInfo("Zhvanets", "09", 48.54968, 26.48744);
case 28: return new CityInfo("Zhuravki", "11", 45.12629, 35.21513);
case 29: return new CityInfo("Zhuravka", "02", 50.48108, 32.5949);
case 30: return new CityInfo("Blahodatne", "24", 50.66365, 24.24918);
case 31: return new CityInfo("Kvitneve", "27", 49.98784, 29.53129);
case 32: return new CityInfo("Zhovkva", "15", 50.05825, 23.9726);
case 33: return new CityInfo("Zhmerynka", "23", 49.03705, 28.11201);
case 34: return new CityInfo("Zhemchuzhina", "11", 45.27466, 34.65778);
case 35: return new CityInfo("Zhelyabovka", "11", 45.39877, 34.75776);
case 36: return new CityInfo("Zhovti Vody", "04", 48.34493, 33.50374);
case 37: return new CityInfo("Zhashkiv", "01", 49.24545, 30.1102);
case 38: return new CityInfo("Zgurovka", "13", 50.50276, 31.78492);
case 39: return new CityInfo("Zernovoye", "11", 45.32364, 34.48099);
case 40: return new CityInfo("Zin’kiv", "18", 50.20806, 34.36376);
case 41: return new CityInfo("Zemlyanichnoye", "11", 44.97444, 34.83553);
case 42: return new CityInfo("Zelyonoye", "11", 44.59583, 34.00921);
case 43: return new CityInfo("Zelenogorskoye", "11", 45.01249, 34.46848);
case 44: return new CityInfo("Zelyonaya Niva", "11", 45.93503, 33.89163);
case 45: return new CityInfo("Zdolbuniv", "19", 50.5206, 26.24251);
case 46: return new CityInfo("Zdovbytsya", "19", 50.49607, 26.24111);
case 47: return new CityInfo("Zboriv", "22", 49.66484, 25.14097);
case 48: return new CityInfo("Zbarazh", "22", 49.66357, 25.77616);
case 49: return new CityInfo("Zavetnoye", "11", 45.32697, 34.80837);
case 50: return new CityInfo("Zavetnoye", "11", 45.12305, 36.39965);
case 51: return new CityInfo("Zavet-Leninskiy", "11", 45.86258, 34.3916);
case 52: return new CityInfo("Zavallya", "10", 48.21354, 30.01558);
case 53: return new CityInfo("Karolino-Buhaz", "17", 46.14492, 30.52609);
case 54: return new CityInfo("Zatoka", "17", 46.07251, 30.46538);
case 55: return new CityInfo("Zatyshshya", "17", 47.33351, 29.87327);
case 56: return new CityInfo("Zastavna", "03", 48.52307, 25.84369);
case 57: return new CityInfo("Zorya", "17", 45.9908, 29.69672);
case 58: return new CityInfo("Zarudyntsi", "27", 49.65175, 29.19108);
case 59: return new CityInfo("Zarichchya", "06", 48.52144, 24.64857);
case 60: return new CityInfo("Zarech’ye", "11", 45.36193, 34.71056);
case 61: return new CityInfo("Zarichne", "19", 51.8126, 26.12902);
case 62: return new CityInfo("Zarechnoye", "11", 45.73636, 34.48345);
case 63: return new CityInfo("Zarechnoye", "11", 44.85048, 34.26426);
case 64: return new CityInfo("Zaprudnoye", "11", 44.59232, 34.31753);
case 65: return new CityInfo("Zaporizhia", "26", 47.82289, 35.19031);
case 66: return new CityInfo("Zaozyornoye", "11", 45.15816, 33.27866);
case 67: return new CityInfo("Zaliztsi", "22", 49.79188, 25.37297);
case 68: return new CityInfo("Zaliznyy Port", "08", 46.12337, 32.29892);
case 69: return new CityInfo("Zaliznychne", "26", 47.65238, 36.16524);
case 70: return new CityInfo("Zaliznychne", "17", 45.7489, 28.61466);
case 71: return new CityInfo("Risovoye", "11", 46.02716, 33.69284);
case 72: return new CityInfo("Zalesnoye", "14", 48.03104, 38.80934);
case 73: return new CityInfo("Zalishchyky", "22", 48.64331, 25.73794);
case 74: return new CityInfo("Zakupne", "09", 49.11944, 26.33756);
case 75: return new CityInfo("Zahvizdya", "06", 48.91836, 24.65275);
case 76: return new CityInfo("Zagnitkiv", "17", 48.04878, 28.89234);
case 77: return new CityInfo("Zachepylivka", "07", 49.19385, 35.23943);
case 78: return new CityInfo("Zabolotiv", "06", 48.47054, 25.28571);
case 79: return new CityInfo("Yuzhne", "17", 46.62211, 31.10131);
case 80: return new CityInfo("Yur”yivka", "04", 48.73748, 36.01987);
case 81: return new CityInfo("Yurkivka", "01", 49.01082, 31.08797);
case 82: return new CityInfo("Yevpatoriya", "11", 45.20091, 33.36655);
case 83: return new CityInfo("Yermakovo", "11", 45.85364, 34.48644);
case 84: return new CityInfo("Yerky", "01", 48.99062, 30.98818);
case 85: return new CityInfo("Yenakiyeve", "05", 48.23331, 38.21137);
case 86: return new CityInfo("Yemil’chyne", "27", 50.87349, 27.80604);
case 87: return new CityInfo("Yemelyanovka", "11", 45.53287, 34.89624);
case 88: return new CityInfo("Yelyzavethradka", "10", 48.80381, 32.4046);
case 89: return new CityInfo("Yelanets’", "16", 47.69682, 31.85253);
case 90: return new CityInfo("Yavoriv", "15", 49.93864, 23.38254);
case 91: return new CityInfo("Yats’kivka", "05", 49.17996, 37.52379);
case 92: return new CityInfo("L’govskoye", "11", 45.09801, 34.9577);
case 93: return new CityInfo("Yasnohorodka", "13", 50.35591, 30.02241);
case 94: return new CityInfo("Yasinya", "25", 48.27937, 24.36042);
case 95: return new CityInfo("Yasynuvata", "05", 48.1298, 37.8594);
case 96: return new CityInfo("Yarmolyntsi", "09", 49.19236, 26.83725);
case 97: return new CityInfo("Yarkoye Pole", "11", 45.61293, 34.31834);
case 98: return new CityInfo("Yarkoye", "11", 45.15985, 33.80555);
case 99: return new CityInfo("Yarkoye", "11", 45.6912, 34.26323);
case 100: return new CityInfo("Yaremche", "06", 48.45157, 24.55436);
case 101: return new CityInfo("Yampil’", "21", 51.94765, 33.78759);
case 102: return new CityInfo("Yampil’", "05", 48.93555, 37.95634);
case 103: return new CityInfo("Yampil’", "23", 48.2424, 28.28195);
case 104: return new CityInfo("Yamnytsya", "06", 48.98972, 24.7075);
case 105: return new CityInfo("Yalta", "05", 46.96279, 37.27365);
case 106: return new CityInfo("Yalta", "11", 44.50218, 34.16624);
case 107: return new CityInfo("Yahotyn", "13", 50.27975, 31.76246);
case 108: return new CityInfo("Yagel’nitsa Stara", "22", 48.97922, 25.71139);
case 109: return new CityInfo("Yahil’nytsya", "22", 48.94248, 25.74375);
case 110: return new CityInfo("Yablonovka", "22", 48.96512, 25.44159);
case 111: return new CityInfo("Yabluniv", "06", 48.40418, 24.93874);
case 112: return new CityInfo("Yablunytsya", "06", 48.31742, 24.48448);
case 113: return new CityInfo("Vyshchetarasivka", "04", 47.56851, 34.88096);
case 114: return new CityInfo("Vysoke", "05", 47.94407, 38.05804);
case 115: return new CityInfo("Vysokopillya", "08", 47.49187, 33.53061);
case 116: return new CityInfo("Vysokyy", "07", 49.89156, 36.12175);
case 117: return new CityInfo("Vyshkovo", "25", 48.04911, 23.42113);
case 118: return new CityInfo("Vyshhorod", "13", 50.58476, 30.4898);
case 119: return new CityInfo("Dneprovka", "11", 45.71373, 34.36256);
case 120: return new CityInfo("Vynohradiv", "25", 48.14135, 23.02666);
case 121: return new CityInfo("Vylok", "25", 48.10915, 22.83865);
case 122: return new CityInfo("Vylkove", "17", 45.40214, 29.58595);
case 123: return new CityInfo("Vvedenka", "07", 49.82372, 36.50264);
case 124: return new CityInfo("Vradiyivka", "16", 47.86195, 30.59195);
case 125: return new CityInfo("Vozrozhdeniye", "11", 45.17324, 35.03238);
case 126: return new CityInfo("Voznesensk", "16", 47.56494, 31.33078);
case 127: return new CityInfo("Voznesenka", "26", 46.87165, 35.46458);
case 128: return new CityInfo("Voyutychi", "15", 49.55135, 23.10579);
case 129: return new CityInfo("Voykovo", "11", 45.51222, 33.87482);
case 130: return new CityInfo("Voykovo", "11", 45.38329, 36.43739);
case 131: return new CityInfo("Vostochnoye", "11", 45.21908, 35.02708);
case 132: return new CityInfo("Vorzel’", "13", 50.5444, 30.15305);
case 133: return new CityInfo("Vorozhba", "21", 51.17334, 34.21917);
case 134: return new CityInfo("Voronovytsya", "23", 49.10954, 28.68078);
case 135: return new CityInfo("Voronove", "14", 48.89746, 38.57279);
case 136: return new CityInfo("Voronkov", "13", 50.22235, 30.89967);
case 137: return new CityInfo("Vorokhta", "06", 48.28459, 24.56536);
case 138: return new CityInfo("Vorobyovo", "11", 45.32895, 33.24654);
case 139: return new CityInfo("Volovets", "25", 48.7109, 23.1851);
case 140: return new CityInfo("Voloka", "03", 48.19225, 25.93074);
case 141: return new CityInfo("Khoroshiv", "27", 50.59764, 28.443);
case 142: return new CityInfo("Nikol's’ke", "05", 47.20533, 37.32139);
case 143: return new CityInfo("Volodarka", "13", 49.52484, 29.91222);
case 144: return new CityInfo("Volochysk", "09", 49.53748, 26.21568);
case 145: return new CityInfo("Vil’ne", "04", 47.63645, 34.81387);
case 146: return new CityInfo("Volnovakha", "05", 47.60103, 37.49674);
case 147: return new CityInfo("Novaya Zhizn’", "11", 45.66462, 34.4982);
case 148: return new CityInfo("Vovchans’k", "07", 50.29078, 36.94108);
case 149: return new CityInfo("Voinka", "11", 45.8699, 33.99138);
case 150: return new CityInfo("Vodyane", "26", 47.48746, 34.49235);
case 151: return new CityInfo("Vodnoye", "11", 44.94023, 33.84573);
case 152: return new CityInfo("Vladislavovka", "11", 45.46872, 34.59087);
case 153: return new CityInfo("Vladislavovka", "11", 45.16654, 35.37268);
case 154: return new CityInfo("Volodymyr-Volynskyi", "24", 50.85253, 24.32364);
case 155: return new CityInfo("Volodymyrets’", "19", 51.4213, 26.14469);
case 156: return new CityInfo("Vyzhnytsya", "03", 48.24801, 25.19452);
case 157: return new CityInfo("Vytachiv", "13", 50.11436, 30.8698);
case 158: return new CityInfo("Vyshneve", "13", 50.38913, 30.3705);
case 159: return new CityInfo("Vyshneve", "04", 48.43611, 33.91556);
case 160: return new CityInfo("Vishennoye", "11", 45.14509, 34.59691);
case 161: return new CityInfo("Suvorovo", "11", 44.73409, 33.62839);
case 162: return new CityInfo("Vishnyovka", "11", 45.95966, 33.95289);
case 163: return new CityInfo("Vyshnivchyk", "15", 49.70069, 24.74599);
case 164: return new CityInfo("Vynohradove", "08", 46.36957, 32.9398);
case 165: return new CityInfo("Vinogradovo", "11", 45.39264, 33.64668);
case 166: return new CityInfo("Vynohradivka", "17", 45.68119, 28.57138);
case 167: return new CityInfo("Vinogradnoye", "11", 45.29332, 35.84451);
case 168: return new CityInfo("Vinogradnoye", "11", 44.48149, 34.12973);
case 169: return new CityInfo("Vinnytsia", "23", 49.23278, 28.48097);
case 170: return new CityInfo("Vinkivtsi", "09", 49.03462, 27.23617);
case 171: return new CityInfo("Vil’nyans’k", "26", 47.94381, 35.43539);
case 172: return new CityInfo("Vilino", "11", 44.8456, 33.67161);
case 173: return new CityInfo("Veselynove", "16", 47.35666, 31.23488);
case 174: return new CityInfo("Vesele", "26", 47.01479, 34.91504);
case 175: return new CityInfo("Vesele", "11", 44.85807, 34.87952);
case 176: return new CityInfo("Veselovka", "11", 45.37733, 33.21385);
case 177: return new CityInfo("Verkhovyna", "06", 48.15571, 24.79112);
case 178: return new CityInfo("Verkhorechye", "11", 44.69738, 33.98696);
case 179: return new CityInfo("Verkhnya Syrovatka", "21", 50.82902, 34.95861);
case 180: return new CityInfo("Verchnia Rozhanka", "15", 48.7805, 23.51545);
case 181: return new CityInfo("Verkhnekurgannoye", "11", 45.09146, 34.24188);
case 182: return new CityInfo("Verkhnyaya Belka", "15", 49.81575, 24.30328);
case 183: return new CityInfo("Verkhniachka", "01", 48.82849, 30.03957);
case 184: return new CityInfo("Verkhniy Yasenov", "06", 48.16156, 24.94532);
case 185: return new CityInfo("Verkhniy Rohachyk", "08", 47.25053, 34.33797);
case 186: return new CityInfo("Verkhnie Synevydne", "15", 49.10307, 23.59099);
case 187: return new CityInfo("Verkhnesadovoye", "20", 44.68932, 33.70207);
case 188: return new CityInfo("Verkhn’odniprovs’k", "04", 48.65242, 34.33457);
case 189: return new CityInfo("Vereshitsa", "15", 49.9881, 23.63176);
case 190: return new CityInfo("Veresayevo", "11", 45.30551, 33.50004);
case 191: return new CityInfo("Verenchanka", "03", 48.54653, 25.74533);
case 192: return new CityInfo("Verblyany", "15", 50.04747, 23.42189);
case 193: return new CityInfo("Verbivka", "07", 49.41667, 35.53333);
case 194: return new CityInfo("Vendychany", "23", 48.61176, 27.79324);
case 195: return new CityInfo("Velykoploske", "17", 47.01254, 29.67171);
case 196: return new CityInfo("Velyka Mykhaylivka", "17", 47.07971, 29.85753);
case 197: return new CityInfo("Velykyy Klyuchiv", "06", 48.47092, 24.94677);
case 198: return new CityInfo("Velyki Sorochyntsi", "18", 50.02314, 33.94144);
case 199: return new CityInfo("Velyki Kopani", "08", 46.48684, 32.97498);
case 200: return new CityInfo("Velikiye Borki", "22", 49.52363, 25.75753);
case 201: return new CityInfo("Velykyy Burluk", "07", 50.0617, 37.38373);
case 202: return new CityInfo("Velykyi Bereznyi", "25", 48.88831, 22.46052);
case 203: return new CityInfo("Velyka Pysarivka", "21", 50.4243, 35.47989);
case 204: return new CityInfo("Velyka Novosilka", "05", 47.84531, 36.83534);
case 205: return new CityInfo("Velyka Lepetykha", "08", 47.17572, 33.94362);
case 206: return new CityInfo("Velyka Dymerka", "13", 50.59333, 30.90313);
case 207: return new CityInfo("Velyka Bilozerka", "26", 47.27756, 34.70616);
case 208: return new CityInfo("Velyka Bahachka", "18", 49.79116, 33.72258);
case 209: return new CityInfo("Velyka Oleksandrivka", "08", 47.31969, 33.30373);
case 210: return new CityInfo("Vatutine", "01", 49.01502, 31.06211);
case 211: return new CityInfo("Vasyshcheve", "07", 49.82852, 36.32691);
case 212: return new CityInfo("Vasilyevka", "11", 45.13938, 34.72291);
case 213: return new CityInfo("Vasyl’kivka", "04", 48.20698, 36.02365);
case 214: return new CityInfo("Vasylkiv", "13", 50.18693, 30.31346);
case 215: return new CityInfo("Vashkivtsi", "03", 48.38491, 25.51023);
case 216: return new CityInfo("Vary", "25", 48.12207, 22.71281);
case 217: return new CityInfo("Varvarivka", "18", 49.53786, 35.20086);
case 218: return new CityInfo("Varvarovka", "11", 45.32309, 34.89838);
case 219: return new CityInfo("Varva", "02", 50.49503, 32.71968);
case 220: return new CityInfo("Vapnyarka", "23", 48.53479, 28.74358);
case 221: return new CityInfo("Valky", "07", 49.83597, 35.61223);
case 222: return new CityInfo("Batiovo", "25", 48.36166, 22.3997);
case 223: return new CityInfo("Uzyn", "13", 49.82619, 30.41487);
case 224: return new CityInfo("Uzhgorod", "25", 48.61667, 22.3);
case 225: return new CityInfo("Uyutnoye", "11", 45.19769, 33.29796);
case 226: return new CityInfo("Uvarovo", "11", 45.2626, 35.66506);
case 227: return new CityInfo("Utkivka", "07", 49.78583, 36.07528);
case 228: return new CityInfo("Ustynivka", "10", 47.95507, 32.53674);
case 229: return new CityInfo("Uspenka", "14", 48.39077, 39.16284);
case 230: return new CityInfo("Usatove", "17", 46.53296, 30.6596);
case 231: return new CityInfo("Urozhaynoye", "11", 45.33625, 35.06865);
case 232: return new CityInfo("Uralo-Kavkaz", "14", 48.3211, 39.80302);
case 233: return new CityInfo("Nyzhni Petrivtsi", "03", 48.02847, 25.72327);
case 234: return new CityInfo("Uman", "01", 48.74838, 30.22184);
case 235: return new CityInfo("Blahovishchens’ke", "10", 48.33105, 30.22702);
case 236: return new CityInfo("Ulychne", "15", 49.23385, 23.65111);
case 237: return new CityInfo("Ulaniv", "23", 49.69512, 28.13298);
case 238: return new CityInfo("Ukromnoye", "11", 45.04272, 34.00312);
case 239: return new CityInfo("Ukrainka", "13", 50.14317, 30.74612);
case 240: return new CityInfo("Ukrainka", "11", 44.8873, 34.13973);
case 241: return new CityInfo("Uhryniv", "06", 48.9552, 24.69292);
case 242: return new CityInfo("Uhniv", "15", 50.36811, 23.74895);
case 243: return new CityInfo("Uglovoye", "11", 44.82146, 33.60452);
case 244: return new CityInfo("Vuhlehirs’k", "05", 48.31474, 38.27423);
case 245: return new CityInfo("Udachnoye", "11", 45.38878, 34.28201);
case 246: return new CityInfo("Kolodeznoye", "11", 45.02221, 33.83184);
case 247: return new CityInfo("Tyvriv", "23", 49.01404, 28.50846);
case 248: return new CityInfo("Zernovoye", "11", 45.62962, 34.14355);
case 249: return new CityInfo("Tysmenytsya", "06", 48.90219, 24.84482);
case 250: return new CityInfo("Tysmenychany", "06", 48.77168, 24.66626);
case 251: return new CityInfo("Tynne", "19", 50.60145, 26.18486);
case 252: return new CityInfo("Tyachiv", "25", 48.01179, 23.57061);
case 253: return new CityInfo("Tvirzha", "15", 49.80286, 23.23624);
case 254: return new CityInfo("Turka", "15", 49.15411, 23.02967);
case 255: return new CityInfo("Turiys’k", "24", 51.08644, 24.52294);
case 256: return new CityInfo("Turgenevka", "11", 44.69747, 33.83007);
case 257: return new CityInfo("Turbiv", "23", 49.34788, 28.72117);
case 258: return new CityInfo("Tulchyn", "23", 48.67448, 28.84641);
case 259: return new CityInfo("Tukhlia", "15", 48.91218, 23.47303);
case 260: return new CityInfo("Klyonovka", "11", 45.12368, 34.19489);
case 261: return new CityInfo("Tsyurupyns’k", "08", 46.61842, 32.7189);
case 262: return new CityInfo("Tsybulevka", "23", 48.38719, 29.10288);
case 263: return new CityInfo("Tsybli", "13", 49.99484, 31.56281);
case 264: return new CityInfo("Tsvetochnoye", "11", 45.08655, 34.38521);
case 265: return new CityInfo("Tsvitkove", "01", 49.15231, 31.53739);
case 266: return new CityInfo("Tsibulev", "01", 49.07907, 29.84727);
case 267: return new CityInfo("Tselinnoye", "11", 45.90633, 34.18063);
case 268: return new CityInfo("Tsarychanka", "04", 48.93697, 34.4786);
case 269: return new CityInfo("Pushkino", "11", 45.53628, 34.30643);
case 270: return new CityInfo("Truskavets’", "15", 49.27837, 23.50618);
case 271: return new CityInfo("Trudolyubovka", "11", 45.21731, 35.15247);
case 272: return new CityInfo("Trudolyubovka", "11", 44.78734, 33.99408);
case 273: return new CityInfo("Trostyanets’", "21", 50.48478, 34.96567);
case 274: return new CityInfo("Trostyanets’", "23", 48.50961, 29.23482);
case 275: return new CityInfo("Troyits’ke", "14", 49.9145, 38.29277);
case 276: return new CityInfo("Trypillia", "13", 50.11802, 30.78141);
case 277: return new CityInfo("Tr’okhizbenka", "14", 48.75751, 38.96333);
case 278: return new CityInfo("Trebukhiv", "13", 50.48432, 30.90304);
case 279: return new CityInfo("Toshkivka", "14", 48.77914, 38.57903);
case 280: return new CityInfo("Torkanivka", "23", 48.32462, 29.14746);
case 281: return new CityInfo("Chystyakove", "05", 48.03876, 38.59685);
case 282: return new CityInfo("Topory", "27", 49.65186, 29.31741);
case 283: return new CityInfo("Tomashpil’", "23", 48.54256, 28.51684);
case 284: return new CityInfo("Tomakivka", "04", 47.81569, 34.74137);
case 285: return new CityInfo("Tovste", "22", 48.84663, 25.72621);
case 286: return new CityInfo("Tokmak", "26", 47.25522, 35.71238);
case 287: return new CityInfo("Tokarevo", "11", 45.28367, 35.15244);
case 288: return new CityInfo("Tlumach", "06", 48.86403, 25.00325);
case 289: return new CityInfo("Tyshkivka", "10", 48.49665, 30.94229);
case 290: return new CityInfo("Tymoshivka", "26", 47.1841, 35.11625);
case 291: return new CityInfo("Tymchenky", "07", 49.22327, 36.14192);
case 292: return new CityInfo("Tetiiv", "13", 49.3767, 29.66474);
case 293: return new CityInfo("Terpinnya", "26", 46.96942, 35.421);
case 294: return new CityInfo("Terny", "21", 50.98916, 33.9707);
case 295: return new CityInfo("Terny", "05", 49.09226, 37.96081);
case 296: return new CityInfo("Ternovka", "20", 44.57922, 33.75105);
case 297: return new CityInfo("Ternuvate", "26", 47.83049, 36.12761);
case 298: return new CityInfo("Ternopil", "22", 49.55342, 25.58918);
case 299: return new CityInfo("Terebovlya", "22", 49.30187, 25.70997);
case 300: return new CityInfo("Teplovka", "11", 45.03239, 33.69588);
case 301: return new CityInfo("Teplyk", "23", 48.66566, 29.74504);
case 302: return new CityInfo("Teofipol", "09", 49.83818, 26.41433);
case 303: return new CityInfo("Maslovo", "11", 45.79197, 34.36298);
case 304: return new CityInfo("Tenistoye", "11", 44.74303, 33.66812);
case 305: return new CityInfo("Boykivske", "05", 47.40994, 38.02476);
case 306: return new CityInfo("Tavricheskoye", "11", 45.97652, 33.74892);
case 307: return new CityInfo("Tatarbunary", "17", 45.83731, 29.61424);
case 308: return new CityInfo("Klepinino", "11", 45.528, 34.18315);
case 309: return new CityInfo("Tarutyne", "17", 46.18636, 29.15203);
case 310: return new CityInfo("Tarashcha", "13", 49.55832, 30.49259);
case 311: return new CityInfo("Tarakaniv", "19", 50.37961, 25.70843);
case 312: return new CityInfo("Tankovoye", "11", 44.65829, 33.80929);
case 313: return new CityInfo("Sary-Bash", "11", 45.57142, 33.78728);
case 314: return new CityInfo("Talne", "01", 48.88877, 30.69482);
case 315: return new CityInfo("Talalayivka", "02", 50.95783, 31.92085);
case 316: return new CityInfo("Talalayivka", "02", 50.83913, 33.14374);
case 317: return new CityInfo("Tabachnoye", "11", 45.61257, 34.61497);
case 318: return new CityInfo("Tabachnoye", "11", 44.90175, 33.67638);
case 319: return new CityInfo("Syevyerodonets’k", "14", 48.94832, 38.49166);
case 320: return new CityInfo("Svyatogorsk", "05", 49.03333, 37.56667);
case 321: return new CityInfo("Svityaz’", "24", 51.48211, 23.85904);
case 322: return new CityInfo("Svirzh", "15", 49.64876, 24.43953);
case 323: return new CityInfo("Svetloye", "11", 45.6332, 34.66264);
case 324: return new CityInfo("Svitlovods’k", "10", 49.04894, 33.24106);
case 325: return new CityInfo("Svetlodarsk", "05", 48.43374, 38.22331);
case 326: return new CityInfo("Sverdlovs’k", "14", 48.08964, 39.65243);
case 327: return new CityInfo("Svatove", "14", 49.41029, 38.15035);
case 328: return new CityInfo("Svarychiv", "06", 48.9622, 24.19658);
case 329: return new CityInfo("Svalyava", "25", 48.54853, 22.99578);
case 330: return new CityInfo("Suvorovskoye", "11", 45.25171, 33.37194);
case 331: return new CityInfo("Sutysky", "23", 49.04245, 28.41733);
case 332: return new CityInfo("Suslivtsi", "09", 49.4378, 27.64912);
case 333: return new CityInfo("Susanino", "11", 45.49898, 33.69854);
case 334: return new CityInfo("Surs’ko-Mykhaylivka", "04", 48.27202, 34.72759);
case 335: return new CityInfo("Sumy", "21", 50.9216, 34.80029);
case 336: return new CityInfo("Sukhovolya", "15", 49.82426, 23.8377);
case 337: return new CityInfo("Sudova Vyshnya", "15", 49.78892, 23.37218);
case 338: return new CityInfo("Sudak", "11", 44.84924, 34.97471);
case 339: return new CityInfo("Subottsi", "10", 48.65545, 32.52093);
case 340: return new CityInfo("Studenok", "07", 49.09107, 37.48697);
case 341: return new CityInfo("Stryi", "15", 49.26223, 23.85609);
case 342: return new CityInfo("Strogonovka", "11", 44.9497, 34.17924);
case 343: return new CityInfo("Strabychovo", "25", 48.39247, 22.54308);
case 344: return new CityInfo("Stizhkivs’ke", "05", 48.11333, 38.4925);
case 345: return new CityInfo("Storozhnytsya", "25", 48.60403, 22.23269);
case 346: return new CityInfo("Storozhynets’", "03", 48.1643, 25.72029);
case 347: return new CityInfo("Stolbovoye", "11", 45.3627, 33.49584);
case 348: return new CityInfo("Stetseva", "06", 48.52767, 25.57572);
case 349: return new CityInfo("Botanicheskoye", "11", 45.78656, 33.54856);
case 350: return new CityInfo("Stepnoye", "11", 45.65212, 33.77441);
case 351: return new CityInfo("Stepanivka", "17", 46.79489, 29.98684);
case 352: return new CityInfo("Stebnyk", "15", 49.29416, 23.56357);
case 353: return new CityInfo("Stebliv", "01", 49.40186, 31.09764);
case 354: return new CityInfo("Stayki", "13", 50.07818, 30.9038);
case 355: return new CityInfo("Stavyshche", "27", 50.40051, 29.52796);
case 356: return new CityInfo("Stavyshche", "13", 49.39124, 30.19022);
case 357: return new CityInfo("Staryy Sambir", "15", 49.43856, 23.00056);
case 358: return new CityInfo("Staryy Saltiv", "07", 50.07619, 36.78852);
case 359: return new CityInfo("Staryy Merchyk", "07", 49.98147, 35.75904);
case 360: return new CityInfo("Staryy Krym", "05", 47.16146, 37.48934);
case 361: return new CityInfo("Stary Krym", "11", 45.02887, 35.09174);
case 362: return new CityInfo("Dolinka", "11", 45.24241, 33.66354);
case 363: return new CityInfo("Stari Kuty", "06", 48.27093, 25.17293);
case 364: return new CityInfo("Stari Bohorodchany", "06", 48.83361, 24.5243);
case 365: return new CityInfo("Staroye Selo", "15", 49.71037, 24.1895);
case 366: return new CityInfo("Starokostiantyniv", "09", 49.75764, 27.20342);
case 367: return new CityInfo("Starokozache", "17", 46.33722, 29.98528);
case 368: return new CityInfo("Starobesheve", "05", 47.75038, 38.03051);
case 369: return new CityInfo("Starobil’s’k", "14", 49.27832, 38.91069);
case 370: return new CityInfo("Starychi", "15", 49.98001, 23.55848);
case 371: return new CityInfo("Temriuk", "05", 47.26857, 36.98115);
case 372: return new CityInfo("Stara Vyzhivka", "24", 51.43762, 24.43997);
case 373: return new CityInfo("Stara Syniava", "09", 49.60318, 27.61909);
case 374: return new CityInfo("Murafa", "23", 48.76763, 28.21569);
case 375: return new CityInfo("Stanislav", "08", 46.56909, 32.14777);
case 376: return new CityInfo("Stanytsya Luhans’ka", "14", 48.65433, 39.47943);
case 377: return new CityInfo("Stal’noye", "11", 45.70814, 34.56238);
case 378: return new CityInfo("Stakhanovka", "11", 45.37062, 33.94883);
case 379: return new CityInfo("Kadiyivka", "14", 48.56818, 38.64352);
case 380: return new CityInfo("Serednye Vodyane", "25", 47.98159, 23.91041);
case 381: return new CityInfo("Serednye", "25", 48.54043, 22.50696);
case 382: return new CityInfo("Sribne", "02", 50.66384, 32.91867);
case 383: return new CityInfo("Spas’ke", "04", 48.66667, 35.05385);
case 384: return new CityInfo("Spas", "06", 48.88992, 24.06293);
case 385: return new CityInfo("Sovetskoye", "11", 44.53409, 34.18729);
case 386: return new CityInfo("Sovetskiy", "11", 45.34267, 34.92463);
case 387: return new CityInfo("Sosnytsya", "02", 51.52387, 32.49985);
case 388: return new CityInfo("Solotvyno", "25", 47.94604, 23.87035);
case 389: return new CityInfo("Solotvyn", "06", 48.70212, 24.42212);
case 390: return new CityInfo("Solonka", "15", 49.75621, 24.01028);
case 391: return new CityInfo("Solonytsivka", "07", 49.99682, 36.03464);
case 392: return new CityInfo("Solnechnogorskoye", "11", 44.74722, 34.53999);
case 393: return new CityInfo("Solnechnaya Dolina", "11", 44.87185, 35.10622);
case 394: return new CityInfo("Solyonoye Ozero", "11", 45.88208, 34.44811);
case 395: return new CityInfo("Solone", "04", 48.20805, 34.87208);
case 396: return new CityInfo("Sokolinoye", "11", 44.55041, 33.95897);
case 397: return new CityInfo("Ilyinka", "11", 45.81784, 33.79482);
case 398: return new CityInfo("Sokyryany", "03", 48.44747, 27.41678);
case 399: return new CityInfo("Sokal’", "15", 50.47438, 24.28288);
case 400: return new CityInfo("Sofiyivka", "04", 48.04865, 33.87618);
case 401: return new CityInfo("Sofiivka", "11", 45.08985, 33.99887);
case 402: return new CityInfo("Sobolivka", "23", 49.33604, 28.65096);
case 403: return new CityInfo("Sniatyn", "06", 48.44692, 25.56937);
case 404: return new CityInfo("Snihurivka", "16", 47.07579, 32.80516);
case 405: return new CityInfo("Snizhne", "05", 48.02612, 38.77225);
case 406: return new CityInfo("Smila", "01", 49.22242, 31.88714);
case 407: return new CityInfo("Sloviansk", "05", 48.86667, 37.61667);
case 408: return new CityInfo("Slov`yanoserbsk", "14", 48.69779, 38.98133);
case 409: return new CityInfo("Slobidka", "17", 47.88694, 29.34611);
case 410: return new CityInfo("Sloboda", "21", 51.19806, 33.60695);
case 411: return new CityInfo("Slavyanskoye", "11", 45.72768, 33.32165);
case 412: return new CityInfo("Slavuta", "09", 50.30155, 26.86506);
case 413: return new CityInfo("Slavske", "15", 48.84734, 23.44587);
case 414: return new CityInfo("Slavnoye", "11", 45.72176, 33.23689);
case 415: return new CityInfo("Slatyne", "07", 50.21041, 36.15376);
case 416: return new CityInfo("Skvortsovo", "11", 45.07542, 33.82084);
case 417: return new CityInfo("Skvyra", "13", 49.73177, 29.66569);
case 418: return new CityInfo("Skole", "15", 49.03717, 23.51346);
case 419: return new CityInfo("Skhidnytsya", "15", 49.22827, 23.35016);
case 420: return new CityInfo("Skelivka", "15", 49.53728, 22.96467);
case 421: return new CityInfo("Skalistoye", "11", 44.81686, 33.97791);
case 422: return new CityInfo("Skalat", "22", 49.42732, 25.97869);
case 423: return new CityInfo("Skala-Podilska", "22", 48.85149, 26.19909);
case 424: return new CityInfo("Skadovs’k", "08", 46.1161, 32.91124);
case 425: return new CityInfo("Sizovka", "11", 45.34892, 33.87669);
case 426: return new CityInfo("Synevyrska Poliana", "25", 48.58484, 23.6891);
case 427: return new CityInfo("Synevyr", "25", 48.48745, 23.62575);
case 428: return new CityInfo("Synel’nykove", "04", 48.32044, 35.51792);
case 429: return new CityInfo("Simferopol", "11", 44.95719, 34.11079);
case 430: return new CityInfo("Simeiz", "11", 44.40646, 34.00704);
case 431: return new CityInfo("Shumsk", "22", 50.12157, 26.11424);
case 432: return new CityInfo("Shubino", "11", 45.2732, 35.21203);
case 433: return new CityInfo("Shturmovoye", "20", 44.56767, 33.62245);
case 434: return new CityInfo("Shpyl’chyna", "15", 49.6636, 24.28102);
case 435: return new CityInfo("Shpola", "01", 49.00687, 31.39471);
case 436: return new CityInfo("Shostka", "21", 51.86296, 33.4698);
case 437: return new CityInfo("Sholokhove", "04", 47.69453, 34.03119);
case 438: return new CityInfo("Shklo", "15", 49.95675, 23.54408);
case 439: return new CityInfo("Shishkino", "11", 45.31195, 33.20566);
case 440: return new CityInfo("Shyshaky", "18", 49.88175, 34.01118);
case 441: return new CityInfo("Shyryayeve", "17", 47.38052, 30.19638);
case 442: return new CityInfo("Shyroke", "05", 47.95711, 38.2316);
case 443: return new CityInfo("Shyroke", "04", 47.69173, 33.25715);
case 444: return new CityInfo("Pshenichnoye", "11", 45.64627, 34.83767);
case 445: return new CityInfo("Shirokoye", "20", 44.47968, 33.76846);
case 446: return new CityInfo("Shypyntsi", "03", 48.37677, 25.74664);
case 447: return new CityInfo("Partizany", "11", 45.14373, 35.15509);
case 448: return new CityInfo("Shevchenkove", "07", 49.69585, 37.17348);
case 449: return new CityInfo("Shevchenkove", "16", 46.86289, 32.20387);
case 450: return new CityInfo("Shevchenkove", "17", 45.55604, 29.33357);
case 451: return new CityInfo("Sheshory", "06", 48.33197, 24.98329);
case 452: return new CityInfo("Shepetivka", "09", 50.18545, 27.06365);
case 453: return new CityInfo("Shelkovichnoye", "11", 45.18748, 33.68807);
case 454: return new CityInfo("Shchors", "02", 51.81865, 31.94504);
case 455: return new CityInfo("Shchyrets", "15", 49.65096, 23.87426);
case 456: return new CityInfo("Shcherbynivka", "05", 48.39489, 37.79102);
case 457: return new CityInfo("Abrikosovka", "11", 45.27058, 33.19125);
case 458: return new CityInfo("Shchebetovka", "11", 44.93821, 35.158);
case 459: return new CityInfo("Shats’k", "24", 51.50208, 23.93806);
case 460: return new CityInfo("Sharhorod", "23", 48.75587, 28.07507);
case 461: return new CityInfo("Shalyhyne", "21", 51.57167, 34.12167);
case 462: return new CityInfo("Shakhtne", "05", 47.98365, 38.28207);
case 463: return new CityInfo("Shakhtars’k", "05", 48.05657, 38.43826);
case 464: return new CityInfo("Shabo", "17", 46.13262, 30.38595);
case 465: return new CityInfo("Sivers’k", "05", 48.86699, 38.10007);
case 466: return new CityInfo("Sevastopol", "20", 44.60795, 33.52134);
case 467: return new CityInfo("Serpneve", "17", 46.30094, 29.01958);
case 468: return new CityInfo("Serhiyivka", "17", 46.0272, 30.37682);
case 469: return new CityInfo("Seredyna-Buda", "21", 52.18903, 34.03639);
case 470: return new CityInfo("Serebryanka", "05", 48.91917, 38.13494);
case 471: return new CityInfo("Serebryanka", "11", 45.63937, 33.49632);
case 472: return new CityInfo("Serebriya", "23", 48.45593, 27.71923);
case 473: return new CityInfo("Sencha", "18", 50.25482, 33.34602);
case 474: return new CityInfo("Semisotka", "11", 45.24676, 35.565);
case 475: return new CityInfo("Semypolky", "13", 50.72627, 30.93441);
case 476: return new CityInfo("Simeykyne", "14", 48.32643, 39.53366);
case 477: return new CityInfo("Semenivka", "02", 52.17827, 32.58183);
case 478: return new CityInfo("Semenivka", "18", 49.59031, 33.18049);
case 479: return new CityInfo("Selydove", "05", 48.14708, 37.30032);
case 480: return new CityInfo("Silets’", "15", 50.29712, 24.20462);
case 481: return new CityInfo("Syedove", "05", 47.07678, 38.15602);
case 482: return new CityInfo("Sedniv", "02", 51.64473, 31.56497);
case 483: return new CityInfo("Shchastya", "14", 48.73963, 39.2323);
case 484: return new CityInfo("Savran", "17", 48.13219, 30.08247);
case 485: return new CityInfo("Savyntsi", "07", 49.40257, 37.06266);
case 486: return new CityInfo("Sarny", "19", 51.33795, 26.60191);
case 487: return new CityInfo("Sarata", "17", 46.01966, 29.66567);
case 488: return new CityInfo("Sambir", "15", 49.5183, 23.19752);
case 489: return new CityInfo("Saki", "11", 45.13424, 33.59996);
case 490: return new CityInfo("Sakhnovshchyna", "07", 49.15166, 35.87198);
case 491: return new CityInfo("Sadzhavka", "06", 48.56603, 24.7882);
case 492: return new CityInfo("Sadovoye", "11", 45.31037, 34.6526);
case 493: return new CityInfo("Rzhyshchiv", "13", 49.96886, 31.04628);
case 494: return new CityInfo("Rykhtychi", "15", 49.38511, 23.55662);
case 495: return new CityInfo("Rybakivka", "16", 46.61712, 31.34995);
case 496: return new CityInfo("Rybach'e", "11", 44.77331, 34.59609);
case 497: return new CityInfo("Ruzhyn", "27", 49.7228, 29.20455);
case 498: return new CityInfo("Ruska Poliana", "01", 49.417, 31.92009);
case 499: return new CityInfo("Rusakovka", "11", 45.12369, 34.47458);
case 500: return new CityInfo("Rudne", "15", 49.83333, 23.9);
case 501: return new CityInfo("Rudky", "15", 49.65306, 23.48702);
case 502: return new CityInfo("Ruch’i", "11", 45.78564, 33.66093);
case 503: return new CityInfo("Rubizhne", "14", 49.01229, 38.37967);
case 504: return new CityInfo("Rozvadiv", "15", 49.50323, 23.962);
case 505: return new CityInfo("Rozivka", "26", 47.38484, 37.06792);
case 506: return new CityInfo("Rozivka", "26", 46.9394, 35.77207);
case 507: return new CityInfo("Rozhniativ", "06", 48.93576, 24.16379);
case 508: return new CityInfo("Rozhniv", "06", 48.36597, 25.2258);
case 509: return new CityInfo("Rozhyshche", "24", 50.91542, 25.26906);
case 510: return new CityInfo("Rozdil", "15", 49.46144, 24.0623);
case 511: return new CityInfo("Rozdil’na", "17", 46.84334, 30.07919);
case 512: return new CityInfo("Rivne", "10", 48.24742, 31.75432);
case 513: return new CityInfo("Roven’ky", "14", 48.08331, 39.37764);
case 514: return new CityInfo("Roskoshnyy", "13", 49.37087, 30.18471);
case 515: return new CityInfo("Rozkishne", "14", 48.48959, 39.27881);
case 516: return new CityInfo("Roskoshnoye", "11", 45.65187, 34.11552);
case 517: return new CityInfo("Ropcha", "03", 48.11988, 25.77421);
case 518: return new CityInfo("Romodan", "18", 49.99055, 33.32506);
case 519: return new CityInfo("Romny", "21", 50.75104, 33.47471);
case 520: return new CityInfo("Romashkino", "11", 45.25647, 33.25517);
case 521: return new CityInfo("Rokosovo", "25", 48.21018, 23.17624);
case 522: return new CityInfo("Rokytne", "19", 51.2796, 27.214);
case 523: return new CityInfo("Rohatyn", "06", 49.409, 24.60927);
case 524: return new CityInfo("Rodnoye", "20", 44.55395, 33.73925);
case 525: return new CityInfo("Rodnikovoye", "20", 44.46446, 33.85189);
case 526: return new CityInfo("Rodnikovo", "11", 45.04296, 33.95407);
case 527: return new CityInfo("Rodyns’ke", "05", 48.35199, 37.20602);
case 528: return new CityInfo("Rodatychi", "15", 49.79862, 23.53336);
case 529: return new CityInfo("Rivne", "19", 50.62308, 26.22743);
case 530: return new CityInfo("Reshetylivka", "18", 49.56501, 34.07815);
case 531: return new CityInfo("Ripky", "02", 51.80105, 31.08383);
case 532: return new CityInfo("Reni", "17", 45.45623, 28.27914);
case 533: return new CityInfo("Richky", "15", 50.27706, 23.64617);
case 534: return new CityInfo("Rechka", "06", 48.28034, 24.9333);
case 535: return new CityInfo("Razdolye", "11", 44.97458, 33.69458);
case 536: return new CityInfo("Razdol’noye", "11", 45.77083, 33.48777);
case 537: return new CityInfo("Ray", "22", 49.43357, 24.90854);
case 538: return new CityInfo("Rava-Rus’ka", "15", 50.23079, 23.62825);
case 539: return new CityInfo("Ratne", "24", 51.6683, 24.5303);
case 540: return new CityInfo("Rozsypne", "05", 48.14966, 38.57619);
case 541: return new CityInfo("Ralivka", "15", 49.49982, 23.23739);
case 542: return new CityInfo("Rakiv Lis", "24", 51.62174, 24.92427);
case 543: return new CityInfo("Rakoshyno", "25", 48.46713, 22.59687);
case 544: return new CityInfo("Rokytne", "13", 49.68665, 30.47384);
case 545: return new CityInfo("Rakhiv", "25", 48.0526, 24.20089);
case 546: return new CityInfo("Radomyshl", "27", 50.49613, 29.22911);
case 547: return new CityInfo("Radens’k", "08", 46.5486, 32.92787);
case 548: return new CityInfo("Radekhiv", "15", 50.28249, 24.64279);
case 549: return new CityInfo("Radcha", "06", 48.85023, 24.65502);
case 550: return new CityInfo("Piatykhatky", "04", 48.41333, 33.71056);
case 551: return new CityInfo("Pyatikhatka", "11", 45.32347, 34.25516);
case 552: return new CityInfo("Putyvl’", "21", 51.33745, 33.87066);
case 553: return new CityInfo("Putyla", "03", 47.98869, 25.09455);
case 554: return new CityInfo("Pustomyty", "15", 49.71532, 23.91295);
case 555: return new CityInfo("Pushkino", "11", 45.20373, 34.97642);
case 556: return new CityInfo("Pukhivka", "13", 50.6097, 30.7177);
case 557: return new CityInfo("Pryluky", "02", 50.59323, 32.38761);
case 558: return new CityInfo("Prudyanka", "07", 50.23606, 36.16835);
case 559: return new CityInfo("Prudy", "11", 45.23922, 34.70217);
case 560: return new CityInfo("Prostornoye", "11", 45.65597, 34.69837);
case 561: return new CityInfo("P'yatypill'ya", "05", 48.0159, 38.09979);
case 562: return new CityInfo("Pryyutivka", "10", 48.72094, 33.07078);
case 563: return new CityInfo("Pryvillya", "14", 49.01501, 38.30457);
case 564: return new CityInfo("Privetnoye", "11", 45.11969, 35.0596);
case 565: return new CityInfo("Privetnoye", "11", 44.82145, 34.67935);
case 566: return new CityInfo("Pryshyb", "26", 47.25927, 35.31953);
case 567: return new CityInfo("Priozyornoye", "11", 45.2699, 36.33405);
case 568: return new CityInfo("Sartana", "05", 47.17436, 37.69266);
case 569: return new CityInfo("Primorskiy", "11", 45.11201, 35.4786);
case 570: return new CityInfo("Prymors’k", "26", 46.73479, 36.34425);
case 571: return new CityInfo("Prykolotne", "07", 50.16273, 37.34524);
case 572: return new CityInfo("Pridorozhnoye", "11", 45.79199, 34.43786);
case 573: return new CityInfo("Pryazovs’ke", "26", 46.73426, 35.64251);
case 574: return new CityInfo("Preobrazhenka", "26", 47.57194, 35.81667);
case 575: return new CityInfo("Pravda", "11", 45.77903, 33.84649);
case 576: return new CityInfo("Potelych", "15", 50.20804, 23.54674);
case 577: return new CityInfo("Poroshkovo", "25", 48.66832, 22.75328);
case 578: return new CityInfo("Porohy", "06", 48.68755, 24.26322);
case 579: return new CityInfo("Popilnia", "27", 49.9532, 29.45265);
case 580: return new CityInfo("Popasna", "14", 48.63328, 38.37804);
case 581: return new CityInfo("Poninka", "09", 50.18492, 27.53629);
case 582: return new CityInfo("Pomichna", "10", 48.24222, 31.41583);
case 583: return new CityInfo("Pomoriany", "15", 49.64092, 24.9307);
case 584: return new CityInfo("Polyanka", "27", 50.25836, 27.68809);
case 585: return new CityInfo("Palyanytsya", "06", 48.34929, 24.43907);
case 586: return new CityInfo("Poltava", "18", 49.59373, 34.54073);
case 587: return new CityInfo("Polonne", "09", 50.12424, 27.51087);
case 588: return new CityInfo("Polohy", "26", 47.48444, 36.25361);
case 589: return new CityInfo("Pokrovs’ke", "04", 47.97852, 36.2256);
case 590: return new CityInfo("Pokotylivka", "07", 49.91343, 36.17511);
case 591: return new CityInfo("Pohreby", "13", 50.55453, 30.64455);
case 592: return new CityInfo("Pohrebyshche", "23", 49.48639, 29.26361);
case 593: return new CityInfo("Pidrichchya", "24", 51.58385, 24.79776);
case 594: return new CityInfo("Pidvolochysk", "22", 49.53472, 26.14585);
case 595: return new CityInfo("Pidvynohradiv", "25", 48.13947, 22.97194);
case 596: return new CityInfo("Pidkamin", "15", 49.94599, 25.31672);
case 597: return new CityInfo("Pidhirtsi", "15", 49.94611, 24.9795);
case 598: return new CityInfo("Pidhorodne", "04", 48.57528, 35.1068);
case 599: return new CityInfo("Pidhorodna", "16", 48.10704, 30.88953);
case 600: return new CityInfo("Pidhaytsi", "22", 49.26853, 25.13341);
case 601: return new CityInfo("Pidbuzh", "15", 49.33483, 23.24887);
case 602: return new CityInfo("Poshtove", "11", 44.8354, 33.96159);
case 603: return new CityInfo("Pochaiv", "22", 50.00509, 25.51183);
case 604: return new CityInfo("Pobugskoye", "10", 48.16579, 30.59274);
case 605: return new CityInfo("Pobednoye", "11", 45.70109, 34.44805);
case 606: return new CityInfo("Pnikut", "15", 49.71104, 23.13826);
case 607: return new CityInfo("Pniv", "06", 48.61783, 24.52872);
case 608: return new CityInfo("Plodovoye", "11", 44.87156, 33.85615);
case 609: return new CityInfo("Koktebel", "11", 44.96155, 35.2466);
case 610: return new CityInfo("Plakhtiyivka", "17", 46.1006, 29.72169);
case 611: return new CityInfo("Pivdenne", "07", 49.88315, 36.06785);
case 612: return new CityInfo("Pishcha", "24", 51.60928, 23.82079);
case 613: return new CityInfo("Pyriatyn", "18", 50.24242, 32.50621);
case 614: return new CityInfo("Pionerskoye", "11", 44.88083, 34.20194);
case 615: return new CityInfo("Pylypets", "25", 48.65899, 23.28346);
case 616: return new CityInfo("Petrivs’ke", "07", 49.17695, 36.89999);
case 617: return new CityInfo("Petrove", "10", 48.32467, 33.25617);
case 618: return new CityInfo("Petrovka", "11", 45.49776, 34.28816);
case 619: return new CityInfo("Petropavlivka", "04", 48.45643, 36.4367);
case 620: return new CityInfo("Kurisove", "17", 46.96951, 30.95914);
case 621: return new CityInfo("Petrykivka", "04", 48.72933, 34.63358);
case 622: return new CityInfo("Petrikov", "22", 49.53122, 25.57901);
case 623: return new CityInfo("Petranka", "06", 48.90246, 24.30347);
case 624: return new CityInfo("Piskivka", "13", 50.69378, 29.61934);
case 625: return new CityInfo("Peschanoye", "11", 44.84342, 33.60921);
case 626: return new CityInfo("Pishchanka", "23", 48.20727, 28.88607);
case 627: return new CityInfo("Peschana", "17", 48.12918, 29.73086);
case 628: return new CityInfo("Pervomayskoye", "11", 45.71744, 33.85596);
case 629: return new CityInfo("Pervomays’kyy", "07", 49.38742, 36.21471);
case 630: return new CityInfo("Pervomayskoye", "11", 45.11207, 34.06478);
case 631: return new CityInfo("Pervomays’k", "14", 48.62988, 38.54806);
case 632: return new CityInfo("Pervomays’k", "16", 48.04433, 30.85073);
case 633: return new CityInfo("Pershotravneve", "27", 51.39287, 28.86837);
case 634: return new CityInfo("Manhush", "05", 47.05582, 37.31068);
case 635: return new CityInfo("Perovo", "11", 44.92513, 34.05753);
case 636: return new CityInfo("Pereiaslav-Khmelnytskyi", "13", 50.06739, 31.44969);
case 637: return new CityInfo("Pereval’s’k", "14", 48.43779, 38.84384);
case 638: return new CityInfo("Perevalovka", "11", 44.97675, 34.98281);
case 639: return new CityInfo("Pereval'noye", "11", 44.84838, 34.31271);
case 640: return new CityInfo("Peresichna", "07", 50.02452, 35.97871);
case 641: return new CityInfo("Peremyshlyany", "15", 49.66523, 24.55846);
case 642: return new CityInfo("Perekop", "11", 46.16151, 33.69308);
case 643: return new CityInfo("Perehonivka", "10", 48.53552, 30.51923);
case 644: return new CityInfo("Peredovoye", "20", 44.5094, 33.82902);
case 645: return new CityInfo("Perechyn", "25", 48.73616, 22.482);
case 646: return new CityInfo("Pechenizhyn", "06", 48.51551, 24.89423);
case 647: return new CityInfo("Pechenihy", "07", 49.87167, 36.93472);
case 648: return new CityInfo("Pchel’niki", "11", 45.29525, 34.78416);
case 649: return new CityInfo("Pavlysh", "10", 48.91762, 33.35691);
case 650: return new CityInfo("Pavlivka", "14", 49.60864, 38.70917);
case 651: return new CityInfo("Pavlivka", "23", 49.44143, 28.45956);
case 652: return new CityInfo("Pavlohrad", "04", 48.53426, 35.87098);
case 653: return new CityInfo("Pasichna", "06", 48.57152, 24.43003);
case 654: return new CityInfo("Parutyne", "16", 46.70538, 31.89709);
case 655: return new CityInfo("Partyzany", "08", 46.33383, 34.75314);
case 656: return new CityInfo("Partizanskoye", "11", 44.83379, 34.08465);
case 657: return new CityInfo("Prokhladnoye", "11", 44.75665, 33.99177);
case 658: return new CityInfo("Makariv Yar", "14", 48.57768, 39.71944);
case 659: return new CityInfo("Panyutyne", "07", 48.93692, 36.27563);
case 660: return new CityInfo("Pantayivka", "10", 48.674, 32.8841);
case 661: return new CityInfo("Ozerne", "27", 50.17816, 28.73384);
case 662: return new CityInfo("Ozerne", "17", 45.403, 28.67546);
case 663: return new CityInfo("Ozerna", "22", 49.62891, 25.32895);
case 664: return new CityInfo("Ovruch", "27", 51.3246, 28.80351);
case 665: return new CityInfo("Ovoshchnoye", "11", 45.7552, 34.33777);
case 666: return new CityInfo("Ovidiopol", "17", 46.24998, 30.44127);
case 667: return new CityInfo("Otyniya", "06", 48.73767, 24.86111);
case 668: return new CityInfo("Otradnoye", "11", 44.86102, 33.7311);
case 669: return new CityInfo("Plotinnoye", "11", 44.58656, 33.96524);
case 670: return new CityInfo("Otradnoye", "11", 44.50485, 34.21125);
case 671: return new CityInfo("Ostrovskoye", "11", 45.74232, 34.06607);
case 672: return new CityInfo("Ostroh", "19", 50.32942, 26.51425);
case 673: return new CityInfo("Oster", "02", 50.9506, 30.88229);
case 674: return new CityInfo("Kholodovka", "11", 45.05249, 34.99294);
case 675: return new CityInfo("Osypenko", "26", 46.9136, 36.8253);
case 676: return new CityInfo("Orzhytsya", "18", 49.7901, 32.69941);
case 677: return new CityInfo("Orlyanka", "11", 45.23679, 33.5649);
case 678: return new CityInfo("Orlovskoye", "11", 45.8107, 33.97308);
case 679: return new CityInfo("Orlovka", "11", 45.66886, 33.374);
case 680: return new CityInfo("Orlovka", "20", 44.72907, 33.58243);
case 681: return new CityInfo("Orlinoye", "20", 44.44685, 33.77588);
case 682: return new CityInfo("Orikhiv", "26", 47.56731, 35.78575);
case 683: return new CityInfo("Oreanda", "11", 44.45714, 34.14063);
case 684: return new CityInfo("Ordzhonikidze", "04", 47.66763, 34.05957);
case 685: return new CityInfo("Ordzhonikidze", "11", 44.96401, 35.35576);
case 686: return new CityInfo("Orativ", "23", 49.18889, 29.52697);
case 687: return new CityInfo("Oposhnya", "18", 49.95652, 34.61226);
case 688: return new CityInfo("Onufriyivka", "10", 48.90716, 33.44869);
case 689: return new CityInfo("Onokivtsi", "25", 48.65763, 22.34183);
case 690: return new CityInfo("Olyka", "24", 50.71855, 25.81251);
case 691: return new CityInfo("Ol'shanskoye", "16", 47.18411, 31.79375);
case 692: return new CityInfo("Vil’shanka", "10", 48.23604, 30.87608);
case 693: return new CityInfo("Olyshivka", "02", 51.22266, 31.33314);
case 694: return new CityInfo("Olevs’k", "27", 51.22482, 27.65228);
case 695: return new CityInfo("Olesko", "15", 49.96233, 24.89336);
case 696: return new CityInfo("Oles’k", "24", 51.11056, 24.18961);
case 697: return new CityInfo("Oleshnyk", "25", 48.16406, 22.96167);
case 698: return new CityInfo("Oleksandriya", "10", 48.66961, 33.11593);
case 699: return new CityInfo("Oleksandrivka", "10", 48.96336, 32.23492);
case 700: return new CityInfo("Okunevka", "11", 45.36855, 32.76357);
case 701: return new CityInfo("Oktyabr’skoye", "11", 45.65531, 33.94918);
case 702: return new CityInfo("Oktyabr’skoye", "11", 45.39937, 34.90986);
case 703: return new CityInfo("Oktyabr'skoye", "11", 45.36215, 36.36803);
case 704: return new CityInfo("Oktyabr’skoye", "11", 45.28866, 34.13521);
case 705: return new CityInfo("Oktyabr’", "11", 45.62932, 34.5534);
case 706: return new CityInfo("Okhotskoye", "11", 45.48612, 34.86401);
case 707: return new CityInfo("Okhotnikovo", "11", 45.23985, 33.59405);
case 708: return new CityInfo("Ogni", "11", 45.76656, 33.38817);
case 709: return new CityInfo("Odessa", "17", 46.47747, 30.73262);
case 710: return new CityInfo("Ochakiv", "16", 46.61283, 31.54982);
case 711: return new CityInfo("Obukhiv", "13", 50.10689, 30.61848);
case 712: return new CityInfo("Obroshyne", "15", 49.78333, 23.86667);
case 713: return new CityInfo("Obodivka", "23", 48.40514, 29.24775);
case 714: return new CityInfo("Obertyn", "06", 48.70032, 25.17012);
case 715: return new CityInfo("Nyrkiv", "22", 48.81492, 25.59989);
case 716: return new CityInfo("Nuyno", "24", 51.54628, 24.91018);
case 717: return new CityInfo("Novyi Yarychiv", "15", 49.90444, 24.30523);
case 718: return new CityInfo("Novyy Svit", "05", 47.80591, 38.02112);
case 719: return new CityInfo("Novy Svet", "11", 44.83087, 34.9137);
case 720: return new CityInfo("Novyy Starodub", "10", 48.5158, 33.17329);
case 721: return new CityInfo("Novi Yarylovychi", "02", 52.0302, 31.00605);
case 722: return new CityInfo("Novi Troyany", "17", 45.94275, 28.85628);
case 723: return new CityInfo("Novi Sanzhary", "18", 49.34395, 34.31084);
case 724: return new CityInfo("Novi Petrivtsi", "13", 50.62754, 30.4431);
case 725: return new CityInfo("Novi Bilokorovychi", "27", 51.11548, 28.05463);
case 726: return new CityInfo("Novyy Buh", "16", 47.69308, 32.5216);
case 727: return new CityInfo("Novozhilovka", "11", 45.1596, 34.2327);
case 728: return new CityInfo("Novoye Sëlo", "09", 49.17444, 26.79932);
case 729: return new CityInfo("Nove Davydkovo", "25", 48.44133, 22.62164);
case 730: return new CityInfo("Dubki", "11", 44.93581, 34.02355);
case 731: return new CityInfo("Novovorontsovka", "08", 47.50035, 33.91748);
case 732: return new CityInfo("Novovolyns’k", "24", 50.72576, 24.16265);
case 733: return new CityInfo("Novovasilyevka", "11", 44.84842, 33.91622);
case 734: return new CityInfo("Novovasylivka", "26", 46.83021, 35.75136);
case 735: return new CityInfo("Varyazh", "15", 50.51455, 24.0923);
case 736: return new CityInfo("Novoukrayinka", "10", 48.32635, 31.52852);
case 737: return new CityInfo("Novotroyits’ke", "08", 46.3556, 34.33272);
case 738: return new CityInfo("Novostepnoye", "11", 45.66206, 34.387);
case 739: return new CityInfo("Novoselovskoye", "11", 45.44276, 33.59795);
case 740: return new CityInfo("Novoselivka", "05", 49.0701, 37.69517);
case 741: return new CityInfo("Novosyolovka", "11", 44.99377, 33.83525);
case 742: return new CityInfo("Novoselytsya", "09", 50.0703, 27.51955);
case 743: return new CityInfo("Novoselytsya", "03", 48.21931, 26.26531);
case 744: return new CityInfo("Novopskov", "14", 49.5464, 39.08987);
case 745: return new CityInfo("Novopokrovka", "07", 49.83349, 36.54771);
case 746: return new CityInfo("Novopokrovka", "04", 48.05918, 34.60619);
case 747: return new CityInfo("Novopokrovka", "11", 45.42198, 34.45052);
case 748: return new CityInfo("Poltavka", "11", 45.35133, 34.18371);
case 749: return new CityInfo("Novopavlovka", "11", 45.86634, 33.89018);
case 750: return new CityInfo("Novomykolayivka", "04", 48.55625, 34.37399);
case 751: return new CityInfo("Novomykolayivka", "26", 47.9781, 35.9102);
case 752: return new CityInfo("Novonikolayevka", "11", 45.30855, 36.05749);
case 753: return new CityInfo("Novomoskovs’k", "04", 48.63799, 35.24548);
case 754: return new CityInfo("Novomyrhorod", "10", 48.78105, 31.64204);
case 755: return new CityInfo("Novokrymskoye", "11", 45.78007, 34.15543);
case 756: return new CityInfo("Novoklyonovo", "11", 45.00642, 34.49543);
case 757: return new CityInfo("Novoivanovka", "11", 45.83948, 34.04194);
case 758: return new CityInfo("Novoivanovka", "11", 45.44914, 33.09833);
case 759: return new CityInfo("Novoivanovka", "11", 45.45815, 34.79897);
case 760: return new CityInfo("Novohrad-Volynskyi", "27", 50.59412, 27.6165);
case 761: return new CityInfo("Novogrigoryevka", "11", 45.452, 34.60378);
case 762: return new CityInfo("Novofedorivka", "08", 46.17128, 32.31781);
case 763: return new CityInfo("Novodonets’ke", "05", 48.63526, 36.98477);
case 764: return new CityInfo("Voskhod", "11", 45.50999, 34.39355);
case 765: return new CityInfo("Novodnistrovs’k", "03", 48.58303, 27.4407);
case 766: return new CityInfo("Novobohdanivka", "26", 47.08524, 35.32945);
case 767: return new CityInfo("Novoazovs'k", "05", 47.11389, 38.08599);
case 768: return new CityInfo("Novoaydar", "14", 48.96391, 39.00583);
case 769: return new CityInfo("Novoarkhanhel’s’k", "10", 48.65803, 30.81821);
case 770: return new CityInfo("Novoandreyevka", "11", 45.19904, 34.09384);
case 771: return new CityInfo("Novooleksiyivka", "08", 46.22472, 34.64031);
case 772: return new CityInfo("Novytsya", "06", 48.96345, 24.33542);
case 773: return new CityInfo("Novhorod-Sivers’kyy", "02", 52.00577, 33.2615);
case 774: return new CityInfo("Novhorodka", "10", 48.36506, 32.65785);
case 775: return new CityInfo("Nove-Misto", "01", 48.98113, 29.82813);
case 776: return new CityInfo("Nova Vodolaha", "07", 49.71901, 35.86578);
case 777: return new CityInfo("Nova Praha", "10", 48.56821, 32.90273);
case 778: return new CityInfo("Novopokrovka", "11", 45.16517, 35.25304);
case 779: return new CityInfo("Nova Odesa", "16", 47.30778, 31.78506);
case 780: return new CityInfo("Nova Mayachka", "08", 46.59996, 33.22707);
case 781: return new CityInfo("Nova Kakhovka", "08", 46.75451, 33.34864);
case 782: return new CityInfo("Ivanovka", "11", 44.93768, 34.2525);
case 783: return new CityInfo("Novoestoniya", "11", 45.4996, 34.24298);
case 784: return new CityInfo("Nova Borova", "27", 50.69296, 28.63446);
case 785: return new CityInfo("Nova Ushytsya", "09", 48.83716, 27.27434);
case 786: return new CityInfo("Nosivka", "02", 50.93152, 31.58282);
case 787: return new CityInfo("Nyzy", "21", 50.78281, 34.78441);
case 788: return new CityInfo("Nizhyn", "02", 51.04801, 31.88688);
case 789: return new CityInfo("Nyzhnya Krynka", "05", 48.1135, 38.16064);
case 790: return new CityInfo("Nyzhnya Duvanka", "14", 49.58464, 38.17429);
case 791: return new CityInfo("Nyzhni Sirohozy", "08", 46.84842, 34.38044);
case 792: return new CityInfo("Nyzhnye Selyshche", "25", 48.19911, 23.44757);
case 793: return new CityInfo("Nizhnegorskiy", "11", 45.44789, 34.73839);
case 794: return new CityInfo("Vitino", "11", 45.21654, 33.15951);
case 795: return new CityInfo("Nikopol", "04", 47.57119, 34.39637);
case 796: return new CityInfo("Mykolayivka", "17", 47.54135, 30.75615);
case 797: return new CityInfo("Nikolayevka", "11", 44.96213, 33.61061);
case 798: return new CityInfo("Nevyts’ke", "25", 48.67472, 22.38813);
case 799: return new CityInfo("Netishyn", "09", 50.34004, 26.64171);
case 800: return new CityInfo("Neresnytsya", "25", 48.11814, 23.76588);
case 801: return new CityInfo("Nemyriv", "23", 48.97076, 28.83779);
case 802: return new CityInfo("Nelipyno", "25", 48.56101, 23.03146);
case 803: return new CityInfo("Nekrasovka", "11", 45.44085, 34.98584);
case 804: return new CityInfo("Nedryhayliv", "21", 50.83398, 33.87626);
case 805: return new CityInfo("Nebyliv", "06", 48.81526, 24.21657);
case 806: return new CityInfo("Naydenovka", "11", 45.27088, 34.44898);
case 807: return new CityInfo("Navaria", "15", 49.74952, 23.92746);
case 808: return new CityInfo("Nauchny", "11", 44.72617, 34.00979);
case 809: return new CityInfo("Natashino", "11", 45.40828, 33.27339);
case 810: return new CityInfo("Nasypnoe", "11", 45.05285, 35.29415);
case 811: return new CityInfo("Narodychi", "27", 51.20286, 29.08228);
case 812: return new CityInfo("Malovidnoye", "11", 44.79615, 33.8083);
case 813: return new CityInfo("Nadvirna", "06", 48.6348, 24.56936);
case 814: return new CityInfo("Mysovoe", "11", 45.44788, 35.83528);
case 815: return new CityInfo("Shchyolkino", "11", 45.42985, 35.8225);
case 816: return new CityInfo("Mykolaiv", "15", 49.52372, 23.98522);
case 817: return new CityInfo("Mykolayiv", "16", 46.96591, 31.9974);
case 818: return new CityInfo("Istochnoye", "11", 45.90618, 34.02605);
case 819: return new CityInfo("Muzhiyevo", "25", 48.17959, 22.69943);
case 820: return new CityInfo("Muskatnoye", "11", 45.46586, 34.54316);
case 821: return new CityInfo("Shcherbakovo", "11", 45.48329, 34.35008);
case 822: return new CityInfo("Murovani Kurylivtsi", "23", 48.72348, 27.51892);
case 823: return new CityInfo("Murovane", "15", 49.52143, 22.9367);
case 824: return new CityInfo("Mukacheve", "25", 48.43919, 22.71779);
case 825: return new CityInfo("Mostys'ka", "15", 49.79467, 23.15077);
case 826: return new CityInfo("Mospyne", "05", 47.89081, 38.06395);
case 827: return new CityInfo("Moshny", "01", 49.52754, 31.73708);
case 828: return new CityInfo("Morskoye", "11", 44.82593, 34.80314);
case 829: return new CityInfo("Morshyn", "15", 49.15652, 23.87232);
case 830: return new CityInfo("Monastyrys’ka", "22", 49.08909, 25.17327);
case 831: return new CityInfo("Monastyryshche", "01", 48.9909, 29.8047);
case 832: return new CityInfo("Molodohvardiys’k", "14", 48.34511, 39.65244);
case 833: return new CityInfo("Molodiya", "03", 48.22326, 26.02139);
case 834: return new CityInfo("Molodizhne", "10", 48.17732, 32.66015);
case 835: return new CityInfo("Molodyozhnoye", "11", 45.00354, 34.05634);
case 836: return new CityInfo("Molochnoye", "11", 45.1996, 33.22233);
case 837: return new CityInfo("Mohyliv-Podilskyi", "23", 48.44598, 27.7982);
case 838: return new CityInfo("Mlyniv", "19", 50.509, 25.61675);
case 839: return new CityInfo("Mliiv", "01", 49.33691, 31.51704);
case 840: return new CityInfo("Mizoch", "19", 50.4, 26.15);
case 841: return new CityInfo("Miusyns’k", "14", 48.0775, 38.90364);
case 842: return new CityInfo("Mityayevo", "11", 45.23423, 33.7015);
case 843: return new CityInfo("Mitrofanovka", "11", 45.45114, 34.67883);
case 844: return new CityInfo("Mirovka", "13", 49.93126, 30.62309);
case 845: return new CityInfo("Myronivka", "13", 49.66007, 30.98225);
case 846: return new CityInfo("Mirolyubovka", "11", 45.47054, 34.2224);
case 847: return new CityInfo("Mirny", "11", 45.30788, 33.03501);
case 848: return new CityInfo("Myrhorod", "18", 49.96854, 33.60886);
case 849: return new CityInfo("Mynay", "25", 48.5888, 22.27502);
case 850: return new CityInfo("Milove", "14", 49.37528, 40.13222);
case 851: return new CityInfo("Mikulintsy", "22", 49.396, 25.60518);
case 852: return new CityInfo("Mykhaylivka", "26", 47.27235, 35.22235);
case 853: return new CityInfo("Mikhaylovka", "11", 45.52838, 34.64058);
case 854: return new CityInfo("Mikhaylovka", "11", 45.11325, 33.61071);
case 855: return new CityInfo("Myhove", "03", 48.15749, 25.37904);
case 856: return new CityInfo("Myhiya", "16", 48.03719, 30.95153);
case 857: return new CityInfo("Michurinskoye", "11", 45.0743, 34.70672);
case 858: return new CityInfo("Mezhvodnoye", "11", 45.58751, 32.84501);
case 859: return new CityInfo("Velyki Mezhyrichi", "19", 50.65431, 26.86626);
case 860: return new CityInfo("Chudey", "03", 48.05247, 25.62208);
case 861: return new CityInfo("Mizhhirya", "25", 48.52458, 23.50563);
case 862: return new CityInfo("Mezhova", "04", 48.25318, 36.73468);
case 863: return new CityInfo("Mezhdurech'e", "11", 44.87654, 34.84808);
case 864: return new CityInfo("Mezenivka", "21", 50.63486, 35.3134);
case 865: return new CityInfo("Met’olkine", "14", 48.93045, 38.55369);
case 866: return new CityInfo("Merefa", "07", 49.82302, 36.05069);
case 867: return new CityInfo("Zhuravlyovka", "11", 45.1768, 33.9968);
case 868: return new CityInfo("Mena", "02", 51.5217, 32.21568);
case 869: return new CityInfo("Melitopol", "26", 46.84891, 35.36533);
case 870: return new CityInfo("Melioratyvne", "04", 48.63009, 35.41558);
case 871: return new CityInfo("Melekyne", "05", 46.95957, 37.39981);
case 872: return new CityInfo("Medzhybizh", "09", 49.43748, 27.40487);
case 873: return new CityInfo("Medvedevo", "11", 45.38597, 33.004);
case 874: return new CityInfo("Medvedevka", "11", 45.88389, 34.55562);
case 875: return new CityInfo("Medenychi", "15", 49.43055, 23.75073);
case 876: return new CityInfo("Mazanka", "11", 45.0055, 34.25581);
case 877: return new CityInfo("Mayskoye", "11", 45.59555, 34.55213);
case 878: return new CityInfo("Mayaky", "17", 47.44083, 29.55985);
case 879: return new CityInfo("Mayaky", "17", 46.41748, 30.27413);
case 880: return new CityInfo("Matviyivka", "26", 47.07473, 35.14444);
case 881: return new CityInfo("Massandra", "11", 44.50958, 34.18817);
case 882: return new CityInfo("Mashivka", "18", 49.44308, 34.86688);
case 883: return new CityInfo("Maryevka", "11", 45.1133, 36.23992);
case 884: return new CityInfo("Martynovka", "11", 45.87198, 34.33104);
case 885: return new CityInfo("Marshintsy", "03", 48.21751, 26.29133);
case 886: return new CityInfo("Markivka", "14", 49.5229, 39.57055);
case 887: return new CityInfo("Markova", "06", 48.67576, 24.41382);
case 888: return new CityInfo("Mariupol", "05", 47.09514, 37.54131);
case 889: return new CityInfo("Mar’ino", "11", 45.72922, 34.26846);
case 890: return new CityInfo("Mar'yinka", "05", 47.94527, 37.50544);
case 891: return new CityInfo("Krinichnoye", "11", 45.02428, 34.61202);
case 892: return new CityInfo("Marhanets’", "04", 47.63543, 34.62769);
case 893: return new CityInfo("Marfovka", "11", 45.19853, 36.09144);
case 894: return new CityInfo("Mar’yanovka", "11", 45.44627, 34.29474);
case 895: return new CityInfo("Manyava", "06", 48.65541, 24.37537);
case 896: return new CityInfo("Mankivka", "01", 48.96349, 30.33366);
case 897: return new CityInfo("Manevychi", "24", 51.29405, 25.53436);
case 898: return new CityInfo("Manchenky", "07", 49.97982, 35.85835);
case 899: return new CityInfo("Maly Mayak", "11", 44.61356, 34.36469);
case 900: return new CityInfo("Muromskoye", "11", 45.09051, 34.849);
case 901: return new CityInfo("Malorechenskoye", "11", 44.75888, 34.55789);
case 902: return new CityInfo("Malokaterynivka", "26", 47.6555, 35.25649);
case 903: return new CityInfo("Malokakhovka", "08", 46.78142, 33.4479);
case 904: return new CityInfo("Malyn", "27", 50.77233, 29.23833);
case 905: return new CityInfo("Mala Vyska", "10", 48.64308, 31.63657);
case 906: return new CityInfo("Mala Tokmachka", "26", 47.53563, 35.89293);
case 907: return new CityInfo("Mala Danylivka", "07", 50.06354, 36.16564);
case 908: return new CityInfo("Mala Bilozerka", "26", 47.24737, 34.93457);
case 909: return new CityInfo("Yantarnoye", "11", 45.43473, 34.22134);
case 910: return new CityInfo("Niva", "11", 45.58104, 33.26684);
case 911: return new CityInfo("Makiv", "09", 48.79487, 26.69188);
case 912: return new CityInfo("Makiyivka", "05", 48.04782, 37.92576);
case 913: return new CityInfo("Makariv", "13", 50.46408, 29.81128);
case 914: return new CityInfo("Mahdalynivka", "04", 48.92111, 34.91491);
case 915: return new CityInfo("Magazinka", "11", 45.86312, 34.04969);
case 916: return new CityInfo("Liutizh", "13", 50.6835, 30.39324);
case 917: return new CityInfo("Lyubotyn", "07", 49.94691, 35.92907);
case 918: return new CityInfo("Liuboml", "24", 51.22601, 24.03727);
case 919: return new CityInfo("Lyubymivka", "08", 46.81063, 33.56862);
case 920: return new CityInfo("Lyubeshiv", "24", 51.76535, 25.5142);
case 921: return new CityInfo("Lyubech", "02", 51.7026, 30.65692);
case 922: return new CityInfo("Liubar", "27", 49.92045, 27.75918);
case 923: return new CityInfo("Lysianka", "01", 49.25229, 30.82946);
case 924: return new CityInfo("Lysa Hora", "16", 48.17059, 31.10994);
case 925: return new CityInfo("Lviv", "15", 49.83826, 24.02324);
case 926: return new CityInfo("Luzhany", "03", 48.36492, 25.77173);
case 927: return new CityInfo("Lutuhyne", "14", 48.40507, 39.22675);
case 928: return new CityInfo("Lutsk", "24", 50.75932, 25.34244);
case 929: return new CityInfo("Lutovynivka", "18", 49.23726, 33.9051);
case 930: return new CityInfo("Lukiv", "24", 51.0521, 25.40059);
case 931: return new CityInfo("Luhansk", "14", 48.56705, 39.31706);
case 932: return new CityInfo("Lugovoye", "11", 45.23469, 35.72202);
case 933: return new CityInfo("Luhyny", "27", 51.08203, 28.40057);
case 934: return new CityInfo("Luhans’ke", "05", 48.44574, 38.26153);
case 935: return new CityInfo("Luchistoye", "11", 44.73646, 34.40063);
case 936: return new CityInfo("Lubny", "18", 50.01625, 32.99694);
case 937: return new CityInfo("Lozovyy Yar", "13", 50.3219, 31.99673);
case 938: return new CityInfo("Lozovoye", "11", 44.906, 34.16414);
case 939: return new CityInfo("Lozova", "07", 48.88937, 36.31755);
case 940: return new CityInfo("Lozuvatka", "10", 48.0571, 33.28581);
case 941: return new CityInfo("Lozno-Oleksandrivka", "14", 49.8391, 38.74098);
case 942: return new CityInfo("Lopukhiv", "25", 48.36527, 23.96382);
case 943: return new CityInfo("Lopatyn", "15", 50.22022, 24.84831);
case 944: return new CityInfo("Lomonosovo", "11", 45.40174, 34.68395);
case 945: return new CityInfo("Lokhvytsya", "18", 50.36776, 33.26024);
case 946: return new CityInfo("Lokachi", "24", 50.737, 24.64944);
case 947: return new CityInfo("Lobanovo", "11", 45.77552, 34.24236);
case 948: return new CityInfo("Lobachiv", "13", 49.43024, 29.89232);
case 949: return new CityInfo("Lyubashivka", "17", 47.83716, 30.25976);
case 950: return new CityInfo("Livadia", "11", 44.47021, 34.14272);
case 951: return new CityInfo("Litvinenkovo", "11", 45.08648, 34.31107);
case 952: return new CityInfo("Lityn", "23", 49.32509, 28.08094);
case 953: return new CityInfo("Lysychovo", "25", 48.49677, 23.28992);
case 954: return new CityInfo("Lysychans’k", "14", 48.90485, 38.44207);
case 955: return new CityInfo("Lypovets", "23", 49.22964, 29.05555);
case 956: return new CityInfo("Lypova Dolyna", "21", 50.56428, 33.79793);
case 957: return new CityInfo("Lypnyazhka", "10", 48.44694, 31.07611);
case 958: return new CityInfo("Lypcha", "25", 48.26107, 23.38336);
case 959: return new CityInfo("Lymanske", "17", 46.6557, 29.96722);
case 960: return new CityInfo("Lyman", "07", 49.59769, 36.4703);
case 961: return new CityInfo("Lykhivka", "04", 48.68735, 33.92279);
case 962: return new CityInfo("Letychiv", "09", 49.38263, 27.63051);
case 963: return new CityInfo("Lisovi Sorochyntsi", "02", 50.6892, 32.32919);
case 964: return new CityInfo("Lesnoye", "11", 44.94111, 34.95318);
case 965: return new CityInfo("Leninskoye", "11", 45.26844, 34.05023);
case 966: return new CityInfo("Leninskoye", "11", 45.25373, 35.91969);
case 967: return new CityInfo("Lenino", "11", 45.29857, 35.77708);
case 968: return new CityInfo("Lenina", "14", 48.42944, 39.14556);
case 969: return new CityInfo("Lechebnoye", "11", 45.05198, 34.74841);
case 970: return new CityInfo("Lebedyn", "01", 48.96242, 31.52696);
case 971: return new CityInfo("Lazurne", "08", 46.084, 32.52955);
case 972: return new CityInfo("Lazi", "25", 48.06667, 24.23333);
case 973: return new CityInfo("Lazeshchyna", "25", 48.26852, 24.4201);
case 974: return new CityInfo("Lanivtsi", "22", 49.86328, 26.09082);
case 975: return new CityInfo("Lanchyn", "06", 48.55781, 24.75622);
case 976: return new CityInfo("Ladyzhyn", "23", 48.68496, 29.23679);
case 977: return new CityInfo("Ladan", "02", 50.51959, 32.58178);
case 978: return new CityInfo("Kyiv", "12", 50.45466, 30.5238);
case 979: return new CityInfo("Kvasy", "25", 48.14973, 24.27995);
case 980: return new CityInfo("Kuznetsovo-Mykhaylivka", "05", 47.45842, 38.2135);
case 981: return new CityInfo("Kuybysheve", "26", 47.358, 36.64908);
case 982: return new CityInfo("Kuibyshevo", "11", 44.629, 33.86895);
case 983: return new CityInfo("Kuty", "06", 48.25868, 25.17946);
case 984: return new CityInfo("Verkhnyaya Kutuzovka", "11", 44.72154, 34.36983);
case 985: return new CityInfo("Kuteynykove", "05", 47.81227, 38.28822);
case 986: return new CityInfo("Kushuhum", "26", 47.71278, 35.20917);
case 987: return new CityInfo("Kushnytsya", "25", 48.43988, 23.25816);
case 988: return new CityInfo("Kurgannoye", "11", 45.06893, 33.93912);
case 989: return new CityInfo("Kurakhovo", "05", 47.98522, 37.2821);
case 990: return new CityInfo("Kupjansk", "07", 49.71055, 37.61517);
case 991: return new CityInfo("Kunashëvka", "02", 51.04139, 32.01382);
case 992: return new CityInfo("Kumovo", "11", 45.83811, 33.61932);
case 993: return new CityInfo("Kulynychi", "07", 49.98178, 36.38283);
case 994: return new CityInfo("Kulykivka", "02", 51.37345, 31.64661);
case 995: return new CityInfo("Kulykiv", "15", 50.31424, 24.81757);
case 996: return new CityInfo("Kryzhopil’", "23", 48.38289, 28.86622);
case 997: return new CityInfo("Kryzhanivka", "17", 46.56167, 30.79487);
case 998: return new CityInfo("Kryvyi Rih", "04", 47.90966, 33.38044);
case 999: return new CityInfo("Krymskoye", "11", 45.18836, 33.80106);
case 1000: return new CityInfo("Krymka", "11", 45.70453, 34.18782);
case 1001: return new CityInfo("Kruty", "02", 51.05974, 32.10634);
case 1002: return new CityInfo("Krukenychi", "15", 49.68825, 23.15485);
case 1003: return new CityInfo("Krolevets’", "21", 51.54775, 33.38475);
case 1004: return new CityInfo("Kryve Ozero", "16", 47.95242, 30.34928);
case 1005: return new CityInfo("Krivopol’ye", "06", 48.19516, 24.69624);
case 1006: return new CityInfo("Kryva Luka", "05", 48.87382, 37.90327);
case 1007: return new CityInfo("Kryva Hora", "13", 51.38495, 30.19978);
case 1008: return new CityInfo("Kryva", "25", 48.17234, 23.23647);
case 1009: return new CityInfo("Krinichnaya", "05", 48.12899, 38.02597);
case 1010: return new CityInfo("Krynychky", "04", 48.37551, 34.46701);
case 1011: return new CityInfo("Krest’yanovka", "11", 45.72268, 33.93938);
case 1012: return new CityInfo("Kripens’kyy", "14", 48.07709, 39.058);
case 1013: return new CityInfo("Kremnevka", "11", 45.46792, 34.08513);
case 1014: return new CityInfo("Tatariv", "06", 48.34558, 24.57836);
case 1015: return new CityInfo("Kreminna", "14", 49.0495, 38.21792);
case 1016: return new CityInfo("Kremenets", "22", 50.09693, 25.72459);
case 1017: return new CityInfo("Kremenchuk", "18", 49.06802, 33.42041);
case 1018: return new CityInfo("Krekhiv", "15", 50.05112, 23.81586);
case 1019: return new CityInfo("Krayneye", "11", 45.22993, 33.83239);
case 1020: return new CityInfo("Krasyatychi", "13", 51.07636, 29.64899);
case 1021: return new CityInfo("Krasnyy Oktyabr’", "05", 48.25, 38.2);
case 1022: return new CityInfo("Krasnyi Mak", "11", 44.64218, 33.7813);
case 1023: return new CityInfo("Krasnyy Luch", "14", 48.13954, 38.93715);
case 1024: return new CityInfo("Lyman", "05", 48.98837, 37.80225);
case 1025: return new CityInfo("Krasnyy Kut", "14", 48.20138, 38.79765);
case 1026: return new CityInfo("Krasnoznamenka", "11", 45.28676, 34.00036);
case 1027: return new CityInfo("Krasne", "15", 49.91447, 24.6134);
case 1028: return new CityInfo("Krasne", "08", 46.13088, 32.7691);
case 1029: return new CityInfo("Krasnoyarskoye", "11", 45.50661, 33.26641);
case 1030: return new CityInfo("Krasnotorka", "05", 48.68204, 37.53266);
case 1031: return new CityInfo("Krasnosel’skoye", "11", 45.41343, 32.67807);
case 1032: return new CityInfo("Krasnosilka", "17", 46.62258, 30.77421);
case 1033: return new CityInfo("Krasnopillya", "21", 50.77458, 35.25965);
case 1034: return new CityInfo("Krasnoperekops’k", "11", 45.95716, 33.7965);
case 1035: return new CityInfo("Krasnopavlivka", "07", 49.13643, 36.31911);
case 1036: return new CityInfo("Krasnolesye", "11", 44.83259, 34.23086);
case 1037: return new CityInfo("Krasnokuts’k", "07", 50.06602, 35.16275);
case 1038: return new CityInfo("Krasnokamenka", "11", 44.56383, 34.28877);
case 1039: return new CityInfo("Krasnogvardeyskoye", "11", 45.50271, 34.30134);
case 1040: return new CityInfo("Krasnogvardeyskoye", "11", 45.18348, 34.95066);
case 1041: return new CityInfo("Krasnohrad", "07", 49.38009, 35.44186);
case 1042: return new CityInfo("Krasnogorka", "11", 45.24513, 35.80739);
case 1043: return new CityInfo("Krasnoflotskoye", "11", 45.31572, 34.94756);
case 1044: return new CityInfo("Teple", "14", 48.31245, 39.56284);
case 1045: return new CityInfo("Sorokyne", "14", 48.29235, 39.73921);
case 1046: return new CityInfo("Krasnoarmeyskoye", "11", 45.99103, 34.03037);
case 1047: return new CityInfo("Pokrovsk", "05", 48.28198, 37.17585);
case 1048: return new CityInfo("Krasna Zor'ka", "11", 45.13432, 34.04015);
case 1049: return new CityInfo("Krymskaya Roza", "11", 45.05776, 34.35631);
case 1050: return new CityInfo("Krasnaya Polyana", "11", 45.48241, 32.9379);
case 1051: return new CityInfo("Krasnaya Polyana", "11", 45.47379, 34.12859);
case 1052: return new CityInfo("Krasna", "06", 48.57571, 24.70027);
case 1053: return new CityInfo("Krasyliv", "09", 49.65186, 26.97253);
case 1054: return new CityInfo("Kramators’k", "05", 48.72305, 37.55629);
case 1055: return new CityInfo("Kozova", "22", 49.43544, 25.15086);
case 1056: return new CityInfo("Kozhanka", "13", 49.97231, 29.76424);
case 1057: return new CityInfo("Kozel’shchyna", "18", 49.21682, 33.8481);
case 1058: return new CityInfo("Kozelets’", "02", 50.91334, 31.1214);
case 1059: return new CityInfo("Kivsharivka", "07", 49.63096, 37.68821);
case 1060: return new CityInfo("Kovel", "24", 51.21526, 24.70867);
case 1061: return new CityInfo("Kotsyubyns’ke", "12", 50.48836, 30.32957);
case 1062: return new CityInfo("Podil’s’k", "17", 47.75305, 29.53205);
case 1063: return new CityInfo("Kotel’va", "18", 50.06864, 34.75862);
case 1064: return new CityInfo("Kotel’nikovo", "11", 45.36584, 34.02575);
case 1065: return new CityInfo("Kostyantynivka", "16", 47.8266, 31.13551);
case 1066: return new CityInfo("Kostryzhivka", "03", 48.65455, 25.71316);
case 1067: return new CityInfo("Kostopil’", "19", 50.87841, 26.45192);
case 1068: return new CityInfo("Kosiv", "06", 48.31071, 25.09575);
case 1069: return new CityInfo("Kosmach", "06", 48.75089, 24.36731);
case 1070: return new CityInfo("Kosmach", "06", 48.32991, 24.82052);
case 1071: return new CityInfo("Koson’", "25", 48.25505, 22.45597);
case 1072: return new CityInfo("Koryukivka", "02", 51.76877, 32.24813);
case 1073: return new CityInfo("Korsun-Shevchenkivskyi", "01", 49.41894, 31.25865);
case 1074: return new CityInfo("Korotych", "07", 49.94737, 36.03736);
case 1075: return new CityInfo("Korostyshiv", "27", 50.31723, 29.0563);
case 1076: return new CityInfo("Korosten’", "27", 50.95937, 28.63855);
case 1077: return new CityInfo("Korop", "02", 51.56638, 32.95861);
case 1078: return new CityInfo("Korolevo", "25", 48.15247, 23.13659);
case 1079: return new CityInfo("Kornyn", "27", 50.0953, 29.53581);
case 1080: return new CityInfo("Korniyivka", "13", 50.41661, 31.46261);
case 1081: return new CityInfo("Kormovoye", "11", 45.50001, 33.61192);
case 1082: return new CityInfo("Korets", "19", 50.61655, 27.16055);
case 1083: return new CityInfo("Koreiz", "11", 44.43374, 34.08516);
case 1084: return new CityInfo("Kopychyntsi", "22", 49.10441, 25.91026);
case 1085: return new CityInfo("Kopayhorod", "23", 48.85917, 27.7969);
case 1086: return new CityInfo("Kostyantynivka", "05", 48.5277, 37.7069);
case 1087: return new CityInfo("Kostyantynivka", "26", 46.81673, 35.42287);
case 1088: return new CityInfo("Konotop", "21", 51.24032, 33.20263);
case 1089: return new CityInfo("Kondratyevo", "11", 45.63125, 34.47387);
case 1090: return new CityInfo("Slobozhans’ke", "07", 49.59701, 36.52618);
case 1091: return new CityInfo("Kompaniyivka", "10", 48.25115, 32.20795);
case 1092: return new CityInfo("Dobroslav", "17", 46.8128, 30.93934);
case 1093: return new CityInfo("Komarovka", "11", 45.35811, 34.15802);
case 1094: return new CityInfo("Komarno", "15", 49.62739, 23.69952);
case 1095: return new CityInfo("Kol’tsovo", "11", 45.32807, 33.44992);
case 1096: return new CityInfo("Koloski", "11", 45.26936, 33.29386);
case 1097: return new CityInfo("Koloniya Zastav’ye", "19", 50.81667, 27.03333);
case 1098: return new CityInfo("Kolomyia", "06", 48.53115, 25.03649);
case 1099: return new CityInfo("Kolomak", "07", 49.83987, 35.30441);
case 1100: return new CityInfo("Kolodeznoye", "11", 45.22682, 34.33698);
case 1101: return new CityInfo("Kolodenka", "19", 50.58561, 26.31601);
case 1102: return new CityInfo("Kolochava", "25", 48.42851, 23.6959);
case 1103: return new CityInfo("Kulevcha", "17", 46.03034, 29.93614);
case 1104: return new CityInfo("Kol’chugino", "11", 44.94367, 33.78865);
case 1105: return new CityInfo("Il’inka", "11", 45.37237, 33.78154);
case 1106: return new CityInfo("Kodyma", "17", 48.09875, 29.12463);
case 1107: return new CityInfo("Kodra", "13", 50.59488, 29.55873);
case 1108: return new CityInfo("Kochetok", "07", 49.88005, 36.73723);
case 1109: return new CityInfo("Bryanskoye", "11", 44.86622, 33.80428);
case 1110: return new CityInfo("Kobyzhcha", "02", 50.82854, 31.50439);
case 1111: return new CityInfo("Kobleve", "16", 46.66499, 31.20804);
case 1112: return new CityInfo("Kobelyaky", "18", 49.14892, 34.19653);
case 1113: return new CityInfo("Knyazhichi", "13", 50.46275, 30.78369);
case 1114: return new CityInfo("Klishkivtsi", "03", 48.43161, 26.26231);
case 1115: return new CityInfo("Klimovo", "11", 45.49584, 34.47516);
case 1116: return new CityInfo("Klevan", "19", 50.74305, 25.97628);
case 1117: return new CityInfo("Klenovyy", "14", 48.11934, 39.4588);
case 1118: return new CityInfo("Klembivka", "23", 48.39037, 28.41092);
case 1119: return new CityInfo("Klavdiyevo-Tarasove", "13", 50.58416, 30.01134);
case 1120: return new CityInfo("Kivertsi", "24", 50.83425, 25.45821);
case 1121: return new CityInfo("Kitsman’", "03", 48.44357, 25.7668);
case 1122: return new CityInfo("Shirokoye", "11", 45.20029, 34.05069);
case 1123: return new CityInfo("Kirovskoye", "11", 45.54503, 33.07769);
case 1124: return new CityInfo("Kirovskoye", "11", 45.22967, 35.19987);
case 1125: return new CityInfo("Zarichne", "05", 49.0234, 37.93161);
case 1126: return new CityInfo("Kirovs’k", "14", 48.63751, 38.6428);
case 1127: return new CityInfo("Kropyvnytskyi", "10", 48.5132, 32.2597);
case 1128: return new CityInfo("Kirovo", "11", 45.22106, 35.84227);
case 1129: return new CityInfo("Kyrylivka", "26", 46.37592, 35.36753);
case 1130: return new CityInfo("Kyrykivka", "21", 50.36408, 35.1149);
case 1131: return new CityInfo("Kiliya", "17", 45.45518, 29.26367);
case 1132: return new CityInfo("Khyriv", "15", 49.53417, 22.85538);
case 1133: return new CityInfo("Khust", "25", 48.1793, 23.29909);
case 1134: return new CityInfo("Khrystynivka", "01", 48.81577, 29.97703);
case 1135: return new CityInfo("Khotiv", "13", 50.33069, 30.46836);
case 1136: return new CityInfo("Khotyn", "03", 48.50693, 26.49121);
case 1137: return new CityInfo("Khorostkiv", "22", 49.21114, 25.92165);
case 1138: return new CityInfo("Khorosheve", "07", 49.85413, 36.21704);
case 1139: return new CityInfo("Khorol", "18", 49.78367, 33.27833);
case 1140: return new CityInfo("Kholmy", "02", 51.87096, 32.60063);
case 1141: return new CityInfo("Khodoriv", "15", 49.40993, 24.3047);
case 1142: return new CityInfo("Khmelnytskyi", "09", 49.42161, 26.99653);
case 1143: return new CityInfo("Khmel’nitskoye", "20", 44.54507, 33.65395);
case 1144: return new CityInfo("Khmilnyk", "23", 49.55979, 27.95754);
case 1145: return new CityInfo("Khymchyn", "06", 48.38639, 25.14803);
case 1146: return new CityInfo("Kherson", "08", 46.65581, 32.6178);
case 1147: return new CityInfo("Tylovoye", "20", 44.44134, 33.73228);
case 1148: return new CityInfo("Khashchevoye", "04", 48.70138, 35.3401);
case 1149: return new CityInfo("Khartsyz’k", "05", 48.04243, 38.14728);
case 1150: return new CityInfo("Kharkiv", "07", 49.98081, 36.25272);
case 1151: return new CityInfo("Kerch", "11", 45.35675, 36.47542);
case 1152: return new CityInfo("Kel’mentsi", "03", 48.46503, 26.83457);
case 1153: return new CityInfo("Kehychivka", "07", 49.28656, 35.76153);
case 1154: return new CityInfo("Kozyatyn", "23", 49.71431, 28.83385);
case 1155: return new CityInfo("Kazanka", "16", 47.84625, 32.82177);
case 1156: return new CityInfo("Kozachi Laheri", "08", 46.70372, 32.9776);
case 1157: return new CityInfo("Kaydaki", "04", 48.37678, 35.12398);
case 1158: return new CityInfo("Katyuzhanka", "13", 50.80595, 30.13763);
case 1159: return new CityInfo("Katsiveli", "11", 44.39525, 33.97239);
case 1160: return new CityInfo("Katerynopil", "01", 48.9553, 30.96823);
case 1161: return new CityInfo("Yelizavetovo", "11", 45.44928, 33.35755);
case 1162: return new CityInfo("Karpovka", "11", 45.52439, 34.08012);
case 1163: return new CityInfo("Karlivka", "18", 49.45723, 35.12975);
case 1164: return new CityInfo("Soledar", "05", 48.67935, 38.08902);
case 1165: return new CityInfo("Karapyshi", "13", 49.64237, 30.79002);
case 1166: return new CityInfo("Kapitanivka", "10", 48.91719, 31.71671);
case 1167: return new CityInfo("Kaniv", "01", 49.75182, 31.46004);
case 1168: return new CityInfo("Glinka", "11", 45.28469, 33.53446);
case 1169: return new CityInfo("Komysh-Zorya", "26", 47.32755, 36.69298);
case 1170: return new CityInfo("Komyshnya", "18", 50.18359, 33.68269);
case 1171: return new CityInfo("Kamyshevka Vtoraya", "17", 46.23333, 29.83333);
case 1172: return new CityInfo("Komyshuvakha", "26", 47.71598, 35.52981);
case 1173: return new CityInfo("Komyshany", "08", 46.63716, 32.50719);
case 1174: return new CityInfo("Kamianets-Podilskyi", "09", 48.6845, 26.58559);
case 1175: return new CityInfo("Kamennyye Potoki", "18", 48.97974, 33.52638);
case 1176: return new CityInfo("Millerovo", "14", 48.16829, 39.16537);
case 1177: return new CityInfo("Kamin-Kashyrskyi", "24", 51.62412, 24.95864);
case 1178: return new CityInfo("Kamenka-Na-Dnepre", "26", 47.48481, 34.41146);
case 1179: return new CityInfo("Kamianka-Buzka", "15", 50.10655, 24.34451);
case 1180: return new CityInfo("Kamianka", "01", 49.0318, 32.10396);
case 1181: return new CityInfo("Kamianytsia", "25", 48.69343, 22.3957);
case 1182: return new CityInfo("Kalush", "06", 49.01187, 24.37308);
case 1183: return new CityInfo("Kalyny", "25", 48.14078, 23.8738);
case 1184: return new CityInfo("Kalynivka", "23", 49.45389, 28.52608);
case 1185: return new CityInfo("Kalinovka", "11", 45.48524, 32.68651);
case 1186: return new CityInfo("Kalinovka", "11", 45.31658, 35.74643);
case 1187: return new CityInfo("Kalynove", "05", 47.4571, 37.46403);
case 1188: return new CityInfo("Kalinino", "11", 45.74262, 33.77676);
case 1189: return new CityInfo("Kalinino", "11", 45.59521, 34.2203);
case 1190: return new CityInfo("Kalcheva", "17", 45.73746, 28.81441);
case 1191: return new CityInfo("Kalanchak", "08", 46.25623, 33.2907);
case 1192: return new CityInfo("Mirnoye", "11", 44.9833, 34.0616);
case 1193: return new CityInfo("Kakhovka", "08", 46.81371, 33.48698);
case 1194: return new CityInfo("Kayiry", "08", 46.94537, 33.70591);
case 1195: return new CityInfo("Kaharlyk", "13", 49.86233, 30.82815);
case 1196: return new CityInfo("Kadubivtsi", "03", 48.58337, 25.76871);
case 1197: return new CityInfo("Kacha", "20", 44.77635, 33.54387);
case 1198: return new CityInfo("Izyumovka", "11", 45.04437, 35.13717);
case 1199: return new CityInfo("Izyum", "07", 49.20875, 37.24849);
case 1200: return new CityInfo("Izyaslav", "09", 50.11947, 26.82125);
case 1201: return new CityInfo("Izobil’noye", "11", 45.57019, 34.94469);
case 1202: return new CityInfo("Izobil’noye", "11", 44.70276, 34.35357);
case 1203: return new CityInfo("Izmayil", "17", 45.34929, 28.84079);
case 1204: return new CityInfo("Yizhivtsi", "03", 48.03962, 25.66232);
case 1205: return new CityInfo("Iza", "25", 48.21525, 23.32867);
case 1206: return new CityInfo("Ivanivka", "17", 46.97569, 30.46998);
case 1207: return new CityInfo("Ivanivka", "08", 46.72082, 34.55298);
case 1208: return new CityInfo("Ivanovka", "11", 45.072, 33.6613);
case 1209: return new CityInfo("Ivano-Frankivsk", "06", 48.9215, 24.70972);
case 1210: return new CityInfo("Ivankiv", "13", 50.93865, 29.89426);
case 1211: return new CityInfo("Ivanychi", "24", 50.63879, 24.36003);
case 1212: return new CityInfo("Ispas", "03", 48.29734, 25.27406);
case 1213: return new CityInfo("Ishun’", "11", 45.92403, 33.82364);
case 1214: return new CityInfo("Irshava", "25", 48.31667, 23.03846);
case 1215: return new CityInfo("Irpin", "13", 50.52175, 30.25055);
case 1216: return new CityInfo("Ilovays’k", "05", 47.92498, 38.20235);
case 1217: return new CityInfo("Chornomors’k", "17", 46.30495, 30.65478);
case 1218: return new CityInfo("Illintsi", "23", 49.10479, 29.21773);
case 1219: return new CityInfo("Ilychyovo", "11", 45.28348, 35.73864);
case 1220: return new CityInfo("Ilyichevo", "11", 45.24524, 35.07127);
case 1221: return new CityInfo("Ichnya", "02", 50.86258, 32.39425);
case 1222: return new CityInfo("Horodok", "09", 49.16374, 26.58394);
case 1223: return new CityInfo("Horlivka", "05", 48.33576, 38.05325);
case 1224: return new CityInfo("Hlyboka", "03", 48.08971, 25.92933);
case 1225: return new CityInfo("Hlukhiv", "21", 51.67822, 33.9162);
case 1226: return new CityInfo("Hvizd", "06", 48.68517, 24.55055);
case 1227: return new CityInfo("Hvardiiske", "11", 45.58688, 33.97681);
case 1228: return new CityInfo("Hvardiiske", "11", 45.11692, 34.02188);
case 1229: return new CityInfo("Huty", "07", 50.13322, 35.34394);
case 1230: return new CityInfo("Husiatyn", "22", 49.0729, 26.1848);
case 1231: return new CityInfo("Gurzuf", "11", 44.54624, 34.27841);
case 1232: return new CityInfo("Hupalivka", "04", 49.11139, 34.73556);
case 1233: return new CityInfo("Hulyaypole", "26", 47.66389, 36.25633);
case 1234: return new CityInfo("Hubkiv", "19", 50.82795, 27.04573);
case 1235: return new CityInfo("Hubynykha", "04", 48.8098, 35.25602);
case 1236: return new CityInfo("Grushevka", "11", 45.02281, 34.97301);
case 1237: return new CityInfo("Hryshkivtsi", "27", 49.93529, 28.60383);
case 1238: return new CityInfo("Grishino", "11", 45.64219, 33.83098);
case 1239: return new CityInfo("Hrymayliv", "22", 49.33208, 26.01112);
case 1240: return new CityInfo("Gresovskiy", "11", 45.00804, 34.02657);
case 1241: return new CityInfo("Hrebeniv", "15", 48.96515, 23.4817);
case 1242: return new CityInfo("Hrebinka", "18", 50.11712, 32.4361);
case 1243: return new CityInfo("Hradyz’k", "18", 49.23458, 33.13613);
case 1244: return new CityInfo("Hostomel", "13", 50.56841, 30.2651);
case 1245: return new CityInfo("Hoshcha", "19", 50.6003, 26.67435);
case 1246: return new CityInfo("Hirs’ke", "14", 48.73468, 38.49541);
case 1247: return new CityInfo("Lesnovka", "11", 45.1535, 33.61889);
case 1248: return new CityInfo("Horokhiv", "24", 50.50186, 24.76149);
case 1249: return new CityInfo("Horodok", "15", 49.78465, 23.64806);
case 1250: return new CityInfo("Horodnya", "02", 51.89085, 31.59741);
case 1251: return new CityInfo("Horodnytsya", "27", 50.80697, 27.31676);
case 1252: return new CityInfo("Horodnye", "17", 45.89083, 28.84833);
case 1253: return new CityInfo("Horodyshche", "19", 50.63965, 26.36573);
case 1254: return new CityInfo("Horodyshche", "01", 49.28489, 31.44513);
case 1255: return new CityInfo("Horodenka", "06", 48.67274, 25.50163);
case 1256: return new CityInfo("Hornostayivka", "08", 47.00777, 33.72899);
case 1257: return new CityInfo("Gornostayevka", "11", 45.27819, 36.18601);
case 1258: return new CityInfo("Horinchovo", "25", 48.27076, 23.43475);
case 1259: return new CityInfo("Horbachi", "15", 49.59481, 23.90915);
case 1260: return new CityInfo("Horbachevo-Mykhaylivka", "05", 47.85118, 38.00632);
case 1261: return new CityInfo("Goncharnoye", "20", 44.46594, 33.69986);
case 1262: return new CityInfo("Goluboy Zaliv", "11", 44.41126, 33.98634);
case 1263: return new CityInfo("Golubivka", "27", 49.68097, 29.16059);
case 1264: return new CityInfo("Golubinka", "11", 44.59382, 33.91521);
case 1265: return new CityInfo("Holovyne", "27", 50.47118, 28.8253);
case 1266: return new CityInfo("Golovanovka", "11", 44.97516, 34.63102);
case 1267: return new CityInfo("Holovanivs’k", "10", 48.384, 30.46131);
case 1268: return new CityInfo("Hołoby", "24", 51.08651, 25.00767);
case 1269: return new CityInfo("Hola Prystan’", "08", 46.52719, 32.52417);
case 1270: return new CityInfo("Godovytsya", "15", 49.76667, 23.91667);
case 1271: return new CityInfo("Hnidyn", "13", 50.32899, 30.71059);
case 1272: return new CityInfo("Glubokiy Yar", "11", 44.79147, 33.91593);
case 1273: return new CityInfo("Hlobyne", "18", 49.38784, 33.25959);
case 1274: return new CityInfo("Hlevakha", "13", 50.27423, 30.32706);
case 1275: return new CityInfo("Glazovka", "11", 45.38792, 36.57965);
case 1276: return new CityInfo("Kropotkino", "11", 45.80396, 33.48138);
case 1277: return new CityInfo("Heniches’k", "08", 46.17592, 34.8034);
case 1278: return new CityInfo("Hayvoron", "10", 48.33958, 29.86791);
case 1279: return new CityInfo("Haisyn", "23", 48.81143, 29.38977);
case 1280: return new CityInfo("Gaspra", "11", 44.43364, 34.10297);
case 1281: return new CityInfo("Halych", "06", 49.12179, 24.72578);
case 1282: return new CityInfo("Hadyach", "18", 50.37112, 33.99099);
case 1283: return new CityInfo("Furmanovka", "11", 44.75825, 33.74434);
case 1284: return new CityInfo("Zakharivka", "17", 47.33232, 29.75903);
case 1285: return new CityInfo("Shtormovoye", "11", 45.26717, 33.08693);
case 1286: return new CityInfo("Partenit", "11", 44.578, 34.34464);
case 1287: return new CityInfo("Frunze", "11", 45.02688, 33.62956);
case 1288: return new CityInfo("Fruktovoye", "20", 44.68002, 33.60168);
case 1289: return new CityInfo("Frontovoye", "20", 44.66737, 33.73841);
case 1290: return new CityInfo("Foros", "11", 44.39214, 33.78798);
case 1291: return new CityInfo("Fontanka", "17", 46.56646, 30.85965);
case 1292: return new CityInfo("Filatovka", "11", 46.08192, 33.7851);
case 1293: return new CityInfo("Feodosiya", "11", 45.03199, 35.38153);
case 1294: return new CityInfo("Fastiv", "13", 50.0767, 29.9177);
case 1295: return new CityInfo("Vishnyovoye", "20", 44.73247, 33.60499);
case 1296: return new CityInfo("Eskhar", "07", 49.79614, 36.59047);
case 1297: return new CityInfo("Buran", "14", 48.30003, 39.61526);
case 1298: return new CityInfo("Energodar", "26", 47.49865, 34.6574);
case 1299: return new CityInfo("Dzvinogrud", "15", 49.73333, 24.25);
case 1300: return new CityInfo("Mirnovka", "11", 45.69083, 34.30966);
case 1301: return new CityInfo("Dzhankoy", "11", 45.71168, 34.39274);
case 1302: return new CityInfo("Vidnoye", "11", 45.50213, 34.33742);
case 1303: return new CityInfo("Romaniv", "27", 50.14802, 27.93124);
case 1304: return new CityInfo("Toretsk", "05", 48.39869, 37.84787);
case 1305: return new CityInfo("Demnya", "15", 49.56738, 23.94607);
case 1306: return new CityInfo("Dymer", "13", 50.78647, 30.3026);
case 1307: return new CityInfo("Dvorichna", "07", 49.85019, 37.68262);
case 1308: return new CityInfo("Dunayivtsi", "09", 49.02078, 26.84122);
case 1309: return new CityInfo("Dunaivtsi", "09", 48.88909, 26.85636);
case 1310: return new CityInfo("Dunayiv", "15", 49.61701, 24.82488);
case 1311: return new CityInfo("Duliby", "15", 49.23134, 23.81532);
case 1312: return new CityInfo("Dudchany", "08", 47.18557, 33.7639);
case 1313: return new CityInfo("Dubrovskoye", "11", 45.39109, 34.12392);
case 1314: return new CityInfo("Dubrovytsya", "19", 51.57438, 26.56503);
case 1315: return new CityInfo("Dubove", "25", 48.17205, 23.88954);
case 1316: return new CityInfo("Dubno", "19", 50.41694, 25.73432);
case 1317: return new CityInfo("Dublyany", "15", 49.90411, 24.08637);
case 1318: return new CityInfo("Dublyany", "15", 49.49832, 23.38718);
case 1319: return new CityInfo("Druzhba", "21", 52.04545, 33.94517);
case 1320: return new CityInfo("Druzhba", "27", 51.18768, 27.97403);
case 1321: return new CityInfo("Druzhba", "02", 50.80156, 32.35769);
case 1322: return new CityInfo("Druzhba", "22", 49.04251, 25.45055);
case 1323: return new CityInfo("Drohobych", "15", 49.34991, 23.50561);
case 1324: return new CityInfo("Drobysheve", "05", 49.0416, 37.72962);
case 1325: return new CityInfo("Drahovo", "25", 48.23573, 23.54914);
case 1326: return new CityInfo("Drabiv", "01", 49.96029, 32.1407);
case 1327: return new CityInfo("Dovbysh", "27", 50.37332, 27.98742);
case 1328: return new CityInfo("Donetsk", "05", 48.023, 37.80224);
case 1329: return new CityInfo("Domanivka", "16", 47.63192, 30.98851);
case 1330: return new CityInfo("Dolyna", "06", 48.9733, 24.00944);
case 1331: return new CityInfo("Dolyns'ka", "10", 48.11041, 32.76449);
case 1332: return new CityInfo("Dolinovka", "11", 45.13913, 34.38099);
case 1333: return new CityInfo("Dolinnoye", "11", 44.7532, 33.77766);
case 1334: return new CityInfo("Dolinka", "11", 45.86176, 33.94098);
case 1335: return new CityInfo("Dovhe", "25", 48.36527, 23.27904);
case 1336: return new CityInfo("Dokuchayevs’k", "05", 47.75046, 37.67936);
case 1337: return new CityInfo("Dobryanka", "02", 52.06314, 31.18567);
case 1338: return new CityInfo("Dobrushino", "11", 45.37441, 33.36547);
case 1339: return new CityInfo("Dobroye", "11", 44.86632, 34.22661);
case 1340: return new CityInfo("Dobrovelychkivka", "10", 48.38778, 31.18028);
case 1341: return new CityInfo("Dobropillya", "05", 48.46147, 37.08524);
case 1342: return new CityInfo("Dobromyl’", "15", 49.57193, 22.78629);
case 1343: return new CityInfo("Dnipro", "04", 48.4593, 35.03865);
case 1344: return new CityInfo("Kamianske", "04", 48.51134, 34.6021);
case 1345: return new CityInfo("Dnipryany", "08", 46.74631, 33.27288);
case 1346: return new CityInfo("Dniprovka", "26", 47.42945, 34.61805);
case 1347: return new CityInfo("Dniprorudne", "26", 47.38169, 34.97652);
case 1348: return new CityInfo("Dmytrivka", "10", 48.7969, 32.71645);
case 1349: return new CityInfo("Dmitrovka", "11", 45.48411, 35.0588);
case 1350: return new CityInfo("Dmytrivka", "05", 47.93611, 38.93661);
case 1351: return new CityInfo("Oleksandriys’ke", "10", 48.60767, 32.98347);
case 1352: return new CityInfo("Dmytrivka", "17", 45.97167, 28.98639);
case 1353: return new CityInfo("Myrnohrad", "05", 48.30523, 37.26091);
case 1354: return new CityInfo("Dykan’ka", "18", 49.82501, 34.52787);
case 1355: return new CityInfo("Desna", "02", 50.92731, 30.76048);
case 1356: return new CityInfo("Derhachi", "07", 50.10659, 36.12112);
case 1357: return new CityInfo("Derazhnya", "09", 49.2692, 27.43382);
case 1358: return new CityInfo("Denisovka", "11", 44.92281, 34.2276);
case 1359: return new CityInfo("Demydivka", "19", 50.42814, 25.33619);
case 1360: return new CityInfo("Delyatyn", "06", 48.52354, 24.62466);
case 1361: return new CityInfo("Dihtyari", "02", 50.58264, 32.77012);
case 1362: return new CityInfo("Debal’tseve", "05", 48.34072, 38.4049);
case 1363: return new CityInfo("Davydivka", "03", 48.12099, 25.56461);
case 1364: return new CityInfo("Dashiv", "23", 49.00449, 29.42559);
case 1365: return new CityInfo("Dalekoye", "11", 45.66006, 33.08059);
case 1366: return new CityInfo("Dachnoye", "11", 44.88448, 34.98333);
case 1367: return new CityInfo("Chuykivka", "21", 52.03099, 34.00193);
case 1368: return new CityInfo("Chutove", "18", 49.71043, 35.16571);
case 1369: return new CityInfo("Chulakivka", "08", 46.35763, 32.3514);
case 1370: return new CityInfo("Chuhuyiv", "07", 49.83588, 36.68803);
case 1371: return new CityInfo("Chudniv", "27", 50.05204, 28.11745);
case 1372: return new CityInfo("Chortkiv", "22", 49.01709, 25.79804);
case 1373: return new CityInfo("Chopovychi", "27", 50.83325, 28.95334);
case 1374: return new CityInfo("Chop", "25", 48.43198, 22.20555);
case 1375: return new CityInfo("Krasnoye", "11", 45.13999, 34.09452);
case 1376: return new CityInfo("Chkalovo", "11", 45.60474, 34.83395);
case 1377: return new CityInfo("Chistopolye", "11", 45.36541, 36.18312);
case 1378: return new CityInfo("Chisten’koye", "11", 44.88152, 34.04716);
case 1379: return new CityInfo("Chynadiyovo", "25", 48.48179, 22.8217);
case 1380: return new CityInfo("Chyhyryn", "01", 49.08376, 32.65549);
case 1381: return new CityInfo("Chesniki", "06", 49.38806, 24.72647);
case 1382: return new CityInfo("Chervonyy Oskil", "07", 49.17906, 37.42593);
case 1383: return new CityInfo("Yesman’", "21", 51.77006, 34.06729);
case 1384: return new CityInfo("Chervone", "27", 49.94975, 28.86874);
case 1385: return new CityInfo("Chervonopartyzans’k", "14", 48.07613, 39.79618);
case 1386: return new CityInfo("Chervonohryhorivka", "04", 47.62298, 34.53887);
case 1387: return new CityInfo("Chervonohrad", "15", 50.39105, 24.23514);
case 1388: return new CityInfo("Pulyny", "27", 50.46784, 28.2713);
case 1389: return new CityInfo("Radyvyliv", "19", 50.12994, 25.25576);
case 1390: return new CityInfo("Chervona Sloboda", "01", 49.37281, 32.15742);
case 1391: return new CityInfo("Chortomlyk", "04", 47.62315, 34.14198);
case 1392: return new CityInfo("Chernyatyn", "06", 48.66034, 25.44832);
case 1393: return new CityInfo("Chornyanka", "08", 46.65222, 33.35904);
case 1394: return new CityInfo("Chernyakhivka", "13", 50.21882, 31.93082);
case 1395: return new CityInfo("Cherniakhiv", "27", 50.45652, 28.67018);
case 1396: return new CityInfo("Chornukhyne", "14", 48.32339, 38.52272);
case 1397: return new CityInfo("Chornukhy", "18", 50.26732, 32.94196);
case 1398: return new CityInfo("Chernozemnoye", "11", 45.40808, 34.8199);
case 1399: return new CityInfo("Chornorudka", "27", 49.8464, 29.06062);
case 1400: return new CityInfo("Chernopolye", "11", 45.04399, 34.63916);
case 1401: return new CityInfo("Chernomorskoye", "11", 45.50657, 32.69776);
case 1402: return new CityInfo("Chornoliztsi", "06", 48.83034, 24.89576);
case 1403: return new CityInfo("Chornobayivka", "08", 46.69411, 32.55371);
case 1404: return new CityInfo("Chornobay", "01", 49.66644, 32.32932);
case 1405: return new CityInfo("Cherniyiv", "06", 48.85658, 24.71388);
case 1406: return new CityInfo("Chernivtsi", "03", 48.29149, 25.94034);
case 1407: return new CityInfo("Chernihiv", "02", 51.50551, 31.28487);
case 1408: return new CityInfo("Chernihivka", "26", 47.19992, 36.16148);
case 1409: return new CityInfo("Chernivtsi", "23", 48.54225, 28.11473);
case 1410: return new CityInfo("Chernelytsya", "06", 48.81207, 25.42477);
case 1411: return new CityInfo("Cherkasy", "01", 49.42854, 32.06207);
case 1412: return new CityInfo("Chemerivtsi", "09", 49.01179, 26.34203);
case 1413: return new CityInfo("Chelyadinovo", "11", 45.20729, 36.3762);
case 1414: return new CityInfo("Chechelnyk", "23", 48.21509, 29.36728);
case 1415: return new CityInfo("Chaykino", "11", 45.81111, 34.59538);
case 1416: return new CityInfo("Chaykino", "11", 45.08223, 34.08673);
case 1417: return new CityInfo("Chasiv Yar", "05", 48.59348, 37.85724);
case 1418: return new CityInfo("Chaplynka", "08", 46.36507, 33.54027);
case 1419: return new CityInfo("Chapayeve", "07", 49.36625, 35.87486);
case 1420: return new CityInfo("Kalynove", "13", 49.38179, 30.45137);
case 1421: return new CityInfo("Viytivka", "23", 48.42603, 29.54291);
case 1422: return new CityInfo("Chapayevka", "26", 47.47114, 36.34507);
case 1423: return new CityInfo("Chapayevka", "11", 45.28119, 34.89428);
case 1424: return new CityInfo("Bytkiv", "06", 48.62968, 24.47398);
case 1425: return new CityInfo("Bystriivka", "27", 49.83942, 29.26775);
case 1426: return new CityInfo("Bystrytsya", "06", 48.45931, 24.24545);
case 1427: return new CityInfo("Chernyshevo", "11", 45.78202, 33.42825);
case 1428: return new CityInfo("Bykivka", "27", 50.29285, 27.98314);
case 1429: return new CityInfo("Bus’k", "15", 49.96548, 24.61227);
case 1430: return new CityInfo("Bushtyno", "25", 48.05121, 23.48579);
case 1431: return new CityInfo("Buryn’", "21", 51.19912, 33.83523);
case 1432: return new CityInfo("Burshtyn", "06", 49.25867, 24.62777);
case 1433: return new CityInfo("Pozharskoye", "11", 44.93554, 33.87109);
case 1434: return new CityInfo("Buky", "13", 49.84058, 29.64522);
case 1435: return new CityInfo("Buky", "01", 49.09252, 30.40355);
case 1436: return new CityInfo("Budy", "07", 49.89133, 36.02096);
case 1437: return new CityInfo("Buchmany", "27", 51.06879, 28.04221);
case 1438: return new CityInfo("Buchach", "22", 49.06254, 25.38798);
case 1439: return new CityInfo("Bucha", "13", 50.54345, 30.21201);
case 1440: return new CityInfo("Bryukhovychi", "15", 49.90467, 23.95969);
case 1441: return new CityInfo("Bryanka", "14", 48.511, 38.67222);
case 1442: return new CityInfo("Brusyliv", "27", 50.28449, 29.52626);
case 1443: return new CityInfo("Brovky Pershi", "27", 49.93235, 29.19816);
case 1444: return new CityInfo("Brovary", "13", 50.51809, 30.80671);
case 1445: return new CityInfo("Broska", "17", 45.37327, 28.783);
case 1446: return new CityInfo("Broshniv-Osada", "06", 48.99621, 24.19748);
case 1447: return new CityInfo("Brody", "15", 50.08791, 25.15027);
case 1448: return new CityInfo("Brylivka", "08", 46.42476, 33.14721);
case 1449: return new CityInfo("Bratslav", "23", 48.82257, 28.9407);
case 1450: return new CityInfo("Brats’ke", "16", 47.8636, 31.58393);
case 1451: return new CityInfo("Brailiv", "23", 49.10986, 28.17459);
case 1452: return new CityInfo("Boyarka", "13", 50.31911, 30.29728);
case 1453: return new CityInfo("Boyany", "03", 48.27077, 26.12624);
case 1454: return new CityInfo("Nikita", "11", 44.51564, 34.2384);
case 1455: return new CityInfo("Borzna", "02", 51.25464, 32.4269);
case 1456: return new CityInfo("Borshchiv", "22", 48.80332, 26.04347);
case 1457: return new CityInfo("Borova", "13", 50.17625, 30.10429);
case 1458: return new CityInfo("Borova", "07", 49.3777, 37.62136);
case 1459: return new CityInfo("Boromlya", "21", 50.61839, 34.97042);
case 1460: return new CityInfo("Borodianka", "13", 50.64484, 29.9201);
case 1461: return new CityInfo("Borodino", "17", 46.3025, 29.24167);
case 1462: return new CityInfo("Boryspil’", "13", 50.35269, 30.95501);
case 1463: return new CityInfo("Boryslav", "15", 49.28672, 23.43238);
case 1464: return new CityInfo("Bondarenkovo", "11", 45.40017, 36.48765);
case 1465: return new CityInfo("Bilshivtsi", "06", 49.18333, 24.75);
case 1466: return new CityInfo("Bolhrad", "17", 45.68262, 28.61487);
case 1467: return new CityInfo("Bolekhiv", "06", 49.06607, 23.86435);
case 1468: return new CityInfo("Bohuslav", "13", 49.54939, 30.8744);
case 1469: return new CityInfo("Bohorodchany", "06", 48.807, 24.53834);
case 1470: return new CityInfo("Bohodukhiv", "07", 50.16466, 35.52765);
case 1471: return new CityInfo("Bogdanivka", "13", 50.21807, 32.01476);
case 1472: return new CityInfo("Bohdan", "25", 48.04122, 24.35222);
case 1473: return new CityInfo("Bogatoye", "11", 45.02933, 34.76732);
case 1474: return new CityInfo("Bogatovka", "11", 44.86935, 35.05996);
case 1475: return new CityInfo("Bobrynets", "10", 48.05896, 32.16641);
case 1476: return new CityInfo("Bobrovytsya", "02", 50.74693, 31.3948);
case 1477: return new CityInfo("Bibrka", "15", 49.64093, 24.28874);
case 1478: return new CityInfo("Bobrytsya", "13", 50.34998, 30.18858);
case 1479: return new CityInfo("Bobovo", "25", 48.07166, 22.89585);
case 1480: return new CityInfo("Blyznyuky", "07", 48.85775, 36.55505);
case 1481: return new CityInfo("Blizhneye", "11", 45.05694, 35.33056);
case 1482: return new CityInfo("Blizhnegorodskoye", "11", 45.64093, 34.38054);
case 1483: return new CityInfo("Blahodatne", "05", 47.87928, 38.48492);
case 1484: return new CityInfo("Blahodatne", "05", 47.70013, 37.41898);
case 1485: return new CityInfo("Biryukove", "14", 47.95631, 39.73843);
case 1486: return new CityInfo("Bilhorod-Dnistrovskyi", "17", 46.1952, 30.34938);
case 1487: return new CityInfo("Bila Tserkva", "13", 49.80939, 30.11209);
case 1488: return new CityInfo("Bezimenne", "05", 47.10716, 37.93815);
case 1489: return new CityInfo("Bezlyudivka", "07", 49.87547, 36.26539);
case 1490: return new CityInfo("Donskoye", "11", 45.04509, 34.21413);
case 1491: return new CityInfo("Bershad", "23", 48.36782, 29.51726);
case 1492: return new CityInfo("Beryslav", "08", 46.84152, 33.42838);
case 1493: return new CityInfo("Berezovo", "25", 48.30943, 23.474);
case 1494: return new CityInfo("Berezivka", "07", 49.43935, 35.70736);
case 1495: return new CityInfo("Berezivka", "17", 47.20429, 30.9078);
case 1496: return new CityInfo("Berezovka", "11", 45.57471, 33.34397);
case 1497: return new CityInfo("Berezne", "19", 51.00094, 26.75106);
case 1498: return new CityInfo("Bereznyky", "25", 48.51407, 23.21982);
case 1499: return new CityInfo("Bereznehuvate", "16", 47.30783, 32.84993);
case 1500: return new CityInfo("Berezna", "02", 51.5716, 31.78456);
case 1501: return new CityInfo("Berezyne", "17", 46.22968, 29.20436);
case 1502: return new CityInfo("Бережани", "22", 49.45, 24.93333);
case 1503: return new CityInfo("Berezanka", "16", 46.85262, 31.38802);
case 1504: return new CityInfo("Berestechko", "24", 50.36047, 25.11071);
case 1505: return new CityInfo("Berehove", "25", 48.20555, 22.64418);
case 1506: return new CityInfo("Beregovoye", "11", 45.0947, 35.43385);
case 1507: return new CityInfo("Beregovoye", "11", 44.9, 33.61667);
case 1508: return new CityInfo("Berehomet", "03", 48.17882, 25.34855);
case 1509: return new CityInfo("Velyki Berehy", "25", 48.23187, 22.74591);
case 1510: return new CityInfo("Berdychiv", "27", 49.89928, 28.60235);
case 1511: return new CityInfo("Berdyansk", "26", 46.76644, 36.79872);
case 1512: return new CityInfo("Belz", "15", 50.38226, 24.00642);
case 1513: return new CityInfo("Bili Oslavy", "06", 48.48722, 24.70078);
case 1514: return new CityInfo("Bilyayivka", "17", 46.48319, 30.21678);
case 1515: return new CityInfo("Bilozerka", "08", 46.6248, 32.44251);
case 1516: return new CityInfo("Bile", "14", 48.49523, 39.05051);
case 1517: return new CityInfo("Bilovods'k", "14", 49.20846, 39.58975);
case 1518: return new CityInfo("Bilopillya", "21", 51.15016, 34.31287);
case 1519: return new CityInfo("Bilokurakyne", "14", 49.5341, 38.73067);
case 1520: return new CityInfo("Inkerman", "20", 44.61391, 33.6098);
case 1521: return new CityInfo("Lyakhovtsy", "09", 50.00263, 26.42824);
case 1522: return new CityInfo("Bilohirsk", "11", 45.05462, 34.60185);
case 1523: return new CityInfo("Bilohorivka", "14", 48.92503, 38.24822);
case 1524: return new CityInfo("Bilky", "25", 48.31503, 23.13248);
case 1525: return new CityInfo("Bilyts’ke", "05", 48.40642, 37.18111);
case 1526: return new CityInfo("Belinskoye", "11", 45.37465, 36.08212);
case 1527: return new CityInfo("Belaya Skala", "11", 45.0931, 34.62191);
case 1528: return new CityInfo("Bila Krynytsya", "27", 50.63982, 29.47041);
case 1529: return new CityInfo("Belaya", "22", 49.029, 25.77059);
case 1530: return new CityInfo("Bekhtery", "08", 46.2479, 32.29123);
case 1531: return new CityInfo("Bazaliya", "09", 49.71267, 26.47331);
case 1532: return new CityInfo("Bayrachky", "14", 48.392, 38.60174);
case 1533: return new CityInfo("Trudovoye", "11", 45.23797, 33.75836);
case 1534: return new CityInfo("Baturyn", "02", 51.34567, 32.87794);
case 1535: return new CityInfo("Batal’noye", "11", 45.19402, 35.61583);
case 1536: return new CityInfo("Bashtanka", "16", 47.40719, 32.43868);
case 1537: return new CityInfo("Baryshivka", "13", 50.36098, 31.32173);
case 1538: return new CityInfo("Barvinkove", "07", 48.9097, 37.02051);
case 1539: return new CityInfo("Baranivka", "27", 50.29691, 27.6622);
case 1540: return new CityInfo("Sinitsyno", "11", 45.23862, 35.24659);
case 1541: return new CityInfo("Bar", "23", 49.07717, 27.68256);
case 1542: return new CityInfo("Banyliv", "03", 48.36612, 25.34549);
case 1543: return new CityInfo("Balta", "17", 47.93548, 29.61982);
case 1544: return new CityInfo("Balky", "26", 47.38336, 34.94396);
case 1545: return new CityInfo("Balki", "11", 44.9939, 34.4552);
case 1546: return new CityInfo("Balakliya", "07", 49.4627, 36.85951);
case 1547: return new CityInfo("Balaklava", "20", 44.51118, 33.59942);
case 1548: return new CityInfo("Bakhmach", "02", 51.20093, 32.77451);
case 1549: return new CityInfo("Bakhmach", "02", 51.18144, 32.83463);
case 1550: return new CityInfo("Bakhchysarai", "11", 44.75525, 33.85782);
case 1551: return new CityInfo("Baherove", "11", 45.37417, 36.29705);
case 1552: return new CityInfo("Babenkovo", "11", 45.09703, 35.12991);
case 1553: return new CityInfo("Babanka", "01", 48.70971, 30.44827);
case 1554: return new CityInfo("Azovskoye", "11", 45.58604, 34.5668);
case 1555: return new CityInfo("Abrikosovo", "11", 45.69236, 34.10156);
case 1556: return new CityInfo("Avdiyivka", "02", 51.7766, 32.79988);
case 1557: return new CityInfo("Avdiyivka", "05", 48.13989, 37.74255);
case 1558: return new CityInfo("Auly", "04", 48.5666, 34.46111);
case 1559: return new CityInfo("Ostanino", "11", 45.32731, 35.91295);
case 1560: return new CityInfo("Askaniya-Nova", "08", 46.45135, 33.86889);
case 1561: return new CityInfo("Artsyz", "17", 45.99194, 29.41824);
case 1562: return new CityInfo("Bakhmut", "05", 48.59559, 37.99987);
case 1563: return new CityInfo("Artemivs’k", "14", 48.44061, 38.732);
case 1564: return new CityInfo("Skorokhodove", "18", 49.77118, 35.06493);
case 1565: return new CityInfo("Aromatnoye", "11", 45.03678, 34.39921);
case 1566: return new CityInfo("Armyansk", "11", 46.10919, 33.69206);
case 1567: return new CityInfo("Arbuzynka", "16", 47.90972, 31.31963);
case 1568: return new CityInfo("Apostolove", "04", 47.66003, 33.71369);
case 1569: return new CityInfo("Antratsyt", "14", 48.11503, 39.09128);
case 1570: return new CityInfo("Antoniny", "09", 49.80974, 26.87714);
case 1571: return new CityInfo("Kommunary", "11", 45.54788, 34.22291);
case 1572: return new CityInfo("Andrushky", "27", 49.88195, 29.34349);
case 1573: return new CityInfo("Andrushivka", "27", 50.02288, 29.02023);
case 1574: return new CityInfo("Ananyiv Pershyi", "17", 47.72106, 29.94502);
case 1575: return new CityInfo("Amvrosiyivka", "05", 47.79348, 38.47768);
case 1576: return new CityInfo("Amurskoye", "11", 45.27822, 34.12823);
case 1577: return new CityInfo("Alushta", "11", 44.67728, 34.4097);
case 1578: return new CityInfo("Alupka", "11", 44.41808, 34.04531);
case 1579: return new CityInfo("Alekseyevka", "11", 45.58194, 33.6298);
case 1580: return new CityInfo("Oleksandrivka", "05", 48.70837, 36.91561);
case 1581: return new CityInfo("Oleksandrivka", "16", 46.83826, 32.76116);
case 1582: return new CityInfo("Oleksandrivka", "17", 46.32893, 30.63481);
case 1583: return new CityInfo("Aleksandrovka", "11", 45.57654, 34.09947);
case 1584: return new CityInfo("Aleksandrovka", "11", 45.02575, 34.52832);
case 1585: return new CityInfo("Alchevs’k", "14", 48.46893, 38.81669);
case 1586: return new CityInfo("Andreyevka", "20", 44.81663, 33.56313);
case 1587: return new CityInfo("Yakymivka", "26", 46.69972, 35.15916);
case 1588: return new CityInfo("Akimovka", "11", 45.51981, 34.82438);
case 1589: return new CityInfo("Okhtyrka", "21", 50.31036, 34.89879);
case 1590: return new CityInfo("Agrarnoye", "11", 45.01596, 34.05725);
case 1591: return new CityInfo("Lekarstvennoye", "11", 44.94194, 33.82229);
case 1592: return new CityInfo("Aeroflotskiy", "11", 45.01816, 33.99961);
case 1593: return new CityInfo("Adzhamka", "10", 48.54245, 32.53542);
case 1594: return new CityInfo("Abrikosovka", "11", 45.10759, 35.10139);
case 1595: return new CityInfo("Malynivka", "07", 49.81667, 36.73333);
case 1596: return new CityInfo("Kopashnovo", "25", 48.2197, 23.48457);
case 1597: return new CityInfo("Narkevychi", "09", 49.51717, 26.64178);
case 1598: return new CityInfo("Kirove", "26", 47.65311, 35.69512);
case 1599: return new CityInfo("Novosel’skoye", "11", 45.50357, 32.7225);
case 1600: return new CityInfo("Orekhovo", "11", 45.12944, 33.6318);
case 1601: return new CityInfo("Okny", "17", 47.54044, 29.46001);
case 1602: return new CityInfo("Pavlivka", "17", 46.76044, 29.98683);
case 1603: return new CityInfo("Kuchurhan", "17", 47.16302, 29.78937);
case 1604: return new CityInfo("Smyga", "09", 50.2391, 25.76575);
case 1605: return new CityInfo("Tayirove", "17", 46.36313, 30.64891);
case 1606: return new CityInfo("Teplodar", "17", 46.50585, 30.32521);
case 1607: return new CityInfo("Horishni Plavni", "18", 49.01018, 33.63567);
case 1608: return new CityInfo("Slavutych", "13", 51.5225, 30.71806);
case 1609: return new CityInfo("Розгирче", "06", 49.12265, 23.68858);
case 1610: return new CityInfo("Orzhiv", "19", 50.8, 26.12);
case 1611: return new CityInfo("Kurskoye", "11", 45.02908, 34.93623);
case 1612: return new CityInfo("Rovnoye", "11", 45.35134, 34.3523);
case 1613: return new CityInfo("Kizilovoye", "11", 44.81888, 34.04381);
case 1614: return new CityInfo("Kashtanovoye", "11", 44.8321, 34.05912);
case 1615: return new CityInfo("Levadki", "11", 44.87083, 34.04278);
case 1616: return new CityInfo("Trekhprudnoye", "11", 44.90016, 34.02503);
case 1617: return new CityInfo("Beloglinka", "11", 44.9949, 34.04167);
case 1618: return new CityInfo("Komsomol’skoye", "11", 45.019, 34.03049);
case 1619: return new CityInfo("Malen’koye", "11", 45.07585, 33.99942);
case 1620: return new CityInfo("Novoalekseyevka", "11", 45.29255, 34.11183);
case 1621: return new CityInfo("Solnechnoye", "11", 45.04767, 34.0838);
case 1622: return new CityInfo("Fontany", "11", 44.89717, 34.07297);
case 1623: return new CityInfo("Zalesye", "11", 44.88687, 34.10168);
case 1624: return new CityInfo("Konstantinovka", "11", 44.85511, 34.12069);
case 1625: return new CityInfo("Andrusovo", "11", 44.89153, 34.17891);
case 1626: return new CityInfo("Urozhaynoye", "11", 45.04522, 34.13511);
case 1627: return new CityInfo("Trudovoye", "11", 44.99133, 34.20311);
case 1628: return new CityInfo("Krasnovka", "11", 44.98035, 34.25289);
case 1629: return new CityInfo("Nizhniye Oreshniki", "11", 45.04357, 34.30201);
case 1630: return new CityInfo("Mel’nichnoye", "11", 45.19885, 34.42012);
case 1631: return new CityInfo("Nizhnyaya Kutuzovka", "11", 44.70841, 34.38017);
case 1632: return new CityInfo("Drofino", "11", 45.28629, 34.61589);
case 1633: return new CityInfo("Kostochkovka", "11", 45.31747, 34.67418);
case 1634: return new CityInfo("Frunze", "11", 45.30013, 34.7097);
case 1635: return new CityInfo("Pavlovka", "11", 45.17847, 34.71557);
case 1636: return new CityInfo("Novy Mir", "11", 45.28055, 34.87031);
case 1637: return new CityInfo("Krasny Partizan", "11", 45.40387, 34.2223);
case 1638: return new CityInfo("Molochnoye", "11", 45.39136, 34.35485);
case 1639: return new CityInfo("Razdol’noye", "11", 45.36161, 34.85482);
case 1640: return new CityInfo("Nekrasovo", "11", 45.42453, 34.28545);
case 1641: return new CityInfo("Plodovoye", "11", 45.45, 34.71995);
case 1642: return new CityInfo("Razlivy", "11", 45.46101, 34.71991);
case 1643: return new CityInfo("Zelyonoye", "11", 45.46532, 34.73307);
case 1644: return new CityInfo("Semennoye", "11", 45.45793, 34.76189);
case 1645: return new CityInfo("Uvarovka", "11", 45.45108, 34.78812);
case 1646: return new CityInfo("Listvennoye", "11", 45.48086, 34.81087);
case 1647: return new CityInfo("Blizhneye", "11", 45.52261, 34.29907);
case 1648: return new CityInfo("Vol’noye", "11", 45.5657, 34.3036);
case 1649: return new CityInfo("Pervomayskoye", "20", 44.539, 33.61859);
case 1650: return new CityInfo("Roshchino", "11", 45.60916, 34.37992);
case 1651: return new CityInfo("Rysakovo", "11", 45.65212, 34.32694);
case 1652: return new CityInfo("Dmitriyevka", "11", 45.69804, 34.35756);
case 1653: return new CityInfo("Borodino", "11", 45.64299, 34.6841);
case 1654: return new CityInfo("Kalinovka", "11", 45.74822, 34.33246);
case 1655: return new CityInfo("Komsomol’skoye", "11", 45.77595, 34.39453);
case 1656: return new CityInfo("Suvorovo", "11", 46.08865, 33.688);
case 1657: return new CityInfo("Izumrudnoye", "11", 45.73704, 34.41299);
case 1658: return new CityInfo("Kholmovka", "11", 44.6583, 33.75456);
case 1659: return new CityInfo("Pakharevka", "11", 45.83472, 34.16129);
case 1660: return new CityInfo("Luganskoye", "11", 45.8019, 34.23786);
case 1661: return new CityInfo("Turgenevo", "11", 45.88807, 34.58139);
case 1662: return new CityInfo("Yasnopolyanskoye", "11", 45.94097, 34.35262);
case 1663: return new CityInfo("Novoozyornoye", "11", 45.38314, 33.11715);
case 1664: return new CityInfo("Chernovo", "11", 45.50833, 33.93397);
case 1665: return new CityInfo("Kukushkino", "11", 45.71924, 33.3903);
case 1666: return new CityInfo("Senokosnoye", "11", 45.73277, 33.51552);
case 1667: return new CityInfo("Bratskoye", "11", 45.8317, 33.92151);
case 1668: return new CityInfo("Sovkhoznoye", "11", 45.96005, 33.77155);
case 1669: return new CityInfo("Pochetnoye", "11", 45.99495, 33.76588);
case 1670: return new CityInfo("Kamenolomnya", "11", 45.24804, 33.41773);
case 1671: return new CityInfo("Pribrezhnoye", "11", 45.14611, 33.52037);
case 1672: return new CityInfo("Vladimirovka", "11", 45.1476, 33.57583);
case 1673: return new CityInfo("Geroyskoye", "11", 45.13857, 33.74675);
case 1674: return new CityInfo("Zhuravli", "11", 45.25246, 33.64104);
case 1675: return new CityInfo("Kar’yernoye", "11", 45.28796, 33.60957);
case 1676: return new CityInfo("Zernovoye", "11", 45.28838, 33.86414);
case 1677: return new CityInfo("Timoshenko", "11", 45.29081, 33.9744);
case 1678: return new CityInfo("Chervonoye", "11", 45.12294, 33.68662);
case 1679: return new CityInfo("Novofedorovka", "11", 45.09473, 33.57211);
case 1680: return new CityInfo("Shkol’noye", "11", 45.05758, 33.89737);
case 1681: return new CityInfo("Arkadyevka", "11", 45.03583, 33.91494);
case 1682: return new CityInfo("Vinnitskoye", "11", 44.98129, 33.7392);
case 1683: return new CityInfo("Ravnopolye", "11", 44.93024, 33.71571);
case 1684: return new CityInfo("Prudovoye", "11", 44.90424, 33.78114);
case 1685: return new CityInfo("Topoli", "11", 44.84196, 33.9956);
case 1686: return new CityInfo("Kashtany", "11", 44.8676, 33.78995);
case 1687: return new CityInfo("Shevchenkovo", "11", 44.86292, 33.75897);
case 1688: return new CityInfo("Samokhvalovo", "11", 44.82448, 33.92098);
case 1689: return new CityInfo("Sevastyanovka", "11", 44.81974, 33.933);
case 1690: return new CityInfo("Novopavlovka", "11", 44.82316, 33.96128);
case 1691: return new CityInfo("Aromatnoye", "11", 44.80373, 33.87005);
case 1692: return new CityInfo("Viktorovka", "11", 44.79135, 33.80347);
case 1693: return new CityInfo("Solnechniy", "20", 44.78677, 33.61786);
case 1694: return new CityInfo("Polyushko", "20", 44.74219, 33.58913);
case 1695: return new CityInfo("Noven’koye", "11", 44.73691, 33.79823);
case 1696: return new CityInfo("Predushchel’noye", "11", 44.70687, 33.87096);
case 1697: return new CityInfo("Zheleznodorozhnoye", "11", 44.7171, 33.80417);
case 1698: return new CityInfo("Denyshi", "27", 50.21415, 28.40395);
case 1699: return new CityInfo("Chetfalva", "25", 48.12597, 22.79418);
case 1700: return new CityInfo("Stepove", "17", 46.70385, 30.07919);
case 1701: return new CityInfo("Pervomayskoye", "11", 45.06191, 35.16395);
case 1702: return new CityInfo("Solnechnoye", "11", 45.04726, 35.34538);
case 1703: return new CityInfo("Yuzhnoukrains'k", "16", 47.81777, 31.18263);
case 1704: return new CityInfo("Varash", "19", 51.3509, 25.84738);
case 1705: return new CityInfo("Kremidivka", "17", 46.73351, 30.78472);
case 1706: return new CityInfo("Novi Strilyscha", "15", 49.51557, 24.40381);
case 1707: return new CityInfo("Nadrichne", "22", 49.53356, 24.95974);
case 1708: return new CityInfo("Kulykiv", "15", 49.97954, 24.07817);
case 1709: return new CityInfo("Hlyns'k", "15", 50.06033, 23.89956);
case 1710: return new CityInfo("Derhanivka", "27", 49.69051, 29.06193);
case 1711: return new CityInfo("Novoyavorivs'k", "15", 49.93023, 23.57357);
case 1712: return new CityInfo("Chervone", "13", 50.35718, 31.94773);
case 1713: return new CityInfo("Sofiyivska Borschagivka", "13", 50.41005, 30.36724);
case 1714: return new CityInfo("Motovylivka", "13", 50.15821, 30.07421);
case 1715: return new CityInfo("Kriukivschina", "13", 50.37153, 30.36861);
case 1716: return new CityInfo("Horenka", "13", 50.55731, 30.33217);
case 1717: return new CityInfo("Khotyanivka", "13", 50.59718, 30.57139);
case 1718: return new CityInfo("Chabany", "13", 50.34071, 30.42356);
case 1719: return new CityInfo("Kirove", "13", 50.3689, 31.12066);
case 1720: return new CityInfo("Prolisky", "12", 50.39118, 30.78);
case 1721: return new CityInfo("Shlyakh", "07", 49.92459, 35.76316);
case 1722: return new CityInfo("Геройское", "08", 46.51033, 31.88971);
case 1723: return new CityInfo("Aykavan", "11", 44.99695, 34.15603);
case 1724: return new CityInfo("Sovkhoznoye", "11", 45.03061, 34.01068);
case 1725: return new CityInfo("Ivanovka", "11", 45.3743, 34.72013);
case 1726: return new CityInfo("Krasnokamenka", "11", 44.92446, 35.0754);
case 1727: return new CityInfo("Dianivka", "05", 47.42222, 37.39778);
case 1728: return new CityInfo("Pikuzy", "05", 47.17463, 37.81199);
case 1729: return new CityInfo("Partyzans’ke", "04", 48.5868, 34.80948);
case 1730: return new CityInfo("Salhany", "17", 46.14881, 30.34601);
case 1731: return new CityInfo("Aviatorske", "04", 48.36714, 35.08132);
case 1732: return new CityInfo("Sakharnaya Golovka", "20", 44.58362, 33.64383);
case 1733: return new CityInfo("Zolotaya Balka (1 otd.)", "20", 44.53249, 33.59405);
case 1734: return new CityInfo("Yarkoye Pole", "11", 45.20581, 35.19848);
case 1735: return new CityInfo("Tanske", "01", 48.79307, 30.3911);
case 1736: return new CityInfo("Smotrych", "09", 48.66149, 26.56031);
case 1737: return new CityInfo("Hlybochok", "01", 48.86686, 30.79897);
case 1738: return new CityInfo("Nova Pryluka", "23", 49.37488, 28.69955);
case 1739: return new CityInfo("Husiatyn", "22", 49.07015, 26.22299);
default: return new CityInfo("Horodok", "27", 50.59483, 29.4607);

                                    }                                        
                                }
                            
                        }
                    }
                