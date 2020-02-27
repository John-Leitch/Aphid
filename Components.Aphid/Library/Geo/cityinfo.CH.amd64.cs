
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
                                    public const string Country = "CH";
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
                            
                                        var cur = (Math.Abs(47.43825 - lat) + Math.Abs(7.53027 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(46.55539 - lat) + Math.Abs(7.37302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47452 - lat) + Math.Abs(9.11196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52508 - lat) + Math.Abs(7.89986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58764 - lat) + Math.Abs(8.29365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36667 - lat) + Math.Abs(8.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60206 - lat) + Math.Abs(9.95965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44925 - lat) + Math.Abs(7.80789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33158 - lat) + Math.Abs(8.62271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39108 - lat) + Math.Abs(7.60047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17242 - lat) + Math.Abs(8.51745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20173 - lat) + Math.Abs(7.56649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34019 - lat) + Math.Abs(8.57407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99905 - lat) + Math.Abs(7.45809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28779 - lat) + Math.Abs(7.94586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93575 - lat) + Math.Abs(9.56491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88091 - lat) + Math.Abs(7.47713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69862 - lat) + Math.Abs(10.09268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01998 - lat) + Math.Abs(7.74863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13673 - lat) + Math.Abs(7.92495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47633 - lat) + Math.Abs(8.08506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41723 - lat) + Math.Abs(7.90616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90196 - lat) + Math.Abs(7.66185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33122 - lat) + Math.Abs(6.95872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80034 - lat) + Math.Abs(6.74249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77852 - lat) + Math.Abs(6.64115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51901 - lat) + Math.Abs(6.4185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07851 - lat) + Math.Abs(7.82922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10586 - lat) + Math.Abs(7.66681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2557 - lat) + Math.Abs(7.81626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44205 - lat) + Math.Abs(8.36261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53356 - lat) + Math.Abs(8.25666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49633 - lat) + Math.Abs(9.10904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10279 - lat) + Math.Abs(7.29518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92984 - lat) + Math.Abs(7.56306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19478 - lat) + Math.Abs(8.71903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05983 - lat) + Math.Abs(8.07389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26871 - lat) + Math.Abs(7.79652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4607 - lat) + Math.Abs(7.99835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90322 - lat) + Math.Abs(8.39423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35066 - lat) + Math.Abs(8.27517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97118 - lat) + Math.Abs(7.35685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48139 - lat) + Math.Abs(7.97577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46108 - lat) + Math.Abs(9.38601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35751 - lat) + Math.Abs(8.59105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50564 - lat) + Math.Abs(8.72413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.236 - lat) + Math.Abs(8.04827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47899 - lat) + Math.Abs(8.21842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67587 - lat) + Math.Abs(7.63972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12183 - lat) + Math.Abs(7.99418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40315 - lat) + Math.Abs(7.78161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20583 - lat) + Math.Abs(9.35402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66369 - lat) + Math.Abs(7.86175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66745 - lat) + Math.Abs(8.46774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41928 - lat) + Math.Abs(8.84524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60447 - lat) + Math.Abs(8.50815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46152 - lat) + Math.Abs(9.04552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26339 - lat) + Math.Abs(7.96801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5977 - lat) + Math.Abs(9.03141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5217 - lat) + Math.Abs(8.78967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25194 - lat) + Math.Abs(7.6461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36201 - lat) + Math.Abs(8.51497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3264 - lat) + Math.Abs(8.79779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47049 - lat) + Math.Abs(8.31636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05578 - lat) + Math.Abs(8.10182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29914 - lat) + Math.Abs(8.86462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08386 - lat) + Math.Abs(7.39926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28052 - lat) + Math.Abs(7.52664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43063 - lat) + Math.Abs(8.76787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42022 - lat) + Math.Abs(8.43644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56667 - lat) + Math.Abs(9.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03208 - lat) + Math.Abs(8.43219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49797 - lat) + Math.Abs(7.93141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13447 - lat) + Math.Abs(9.09644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18457 - lat) + Math.Abs(8.021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29955 - lat) + Math.Abs(9.08657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76973 - lat) + Math.Abs(7.50835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58956 - lat) + Math.Abs(8.47121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49654 - lat) + Math.Abs(8.95325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23208 - lat) + Math.Abs(7.65253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34365 - lat) + Math.Abs(7.86982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44867 - lat) + Math.Abs(9.60495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1122 - lat) + Math.Abs(7.77798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33339 - lat) + Math.Abs(8.29791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41499 - lat) + Math.Abs(8.59672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12411 - lat) + Math.Abs(9.31194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94856 - lat) + Math.Abs(7.6204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35627 - lat) + Math.Abs(9.28345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46859 - lat) + Math.Abs(9.28665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63421 - lat) + Math.Abs(9.09504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38333 - lat) + Math.Abs(7.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27595 - lat) + Math.Abs(8.91405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10169 - lat) + Math.Abs(8.51693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40226 - lat) + Math.Abs(7.51511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66003 - lat) + Math.Abs(8.84782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22683 - lat) + Math.Abs(8.6687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61545 - lat) + Math.Abs(7.01732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33746 - lat) + Math.Abs(6.8895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12172 - lat) + Math.Abs(8.90225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27585 - lat) + Math.Abs(7.90114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39016 - lat) + Math.Abs(8.69085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01014 - lat) + Math.Abs(8.4842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25899 - lat) + Math.Abs(7.90192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2937 - lat) + Math.Abs(7.88149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14327 - lat) + Math.Abs(8.84202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31101 - lat) + Math.Abs(6.90062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47098 - lat) + Math.Abs(8.15975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35009 - lat) + Math.Abs(8.24762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52682 - lat) + Math.Abs(8.21486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15838 - lat) + Math.Abs(7.01889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39869 - lat) + Math.Abs(6.92654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72074 - lat) + Math.Abs(6.95638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29832 - lat) + Math.Abs(7.05631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79054 - lat) + Math.Abs(7.11717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01342 - lat) + Math.Abs(8.96879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35 - lat) + Math.Abs(7.41342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42129 - lat) + Math.Abs(6.93048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16699 - lat) + Math.Abs(6.18436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21239 - lat) + Math.Abs(7.39826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46299 - lat) + Math.Abs(6.84345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22171 - lat) + Math.Abs(7.27858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28382 - lat) + Math.Abs(6.16214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18482 - lat) + Math.Abs(8.73224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21702 - lat) + Math.Abs(6.08497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13667 - lat) + Math.Abs(7.03906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1002 - lat) + Math.Abs(7.22651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4526 - lat) + Math.Abs(7.15128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51419 - lat) + Math.Abs(8.717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43796 - lat) + Math.Abs(8.14722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94616 - lat) + Math.Abs(7.56065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62164 - lat) + Math.Abs(6.9882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3186 - lat) + Math.Abs(7.60743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22179 - lat) + Math.Abs(6.20285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61647 - lat) + Math.Abs(9.18025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71256 - lat) + Math.Abs(6.37894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43653 - lat) + Math.Abs(9.13422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22421 - lat) + Math.Abs(8.98263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13248 - lat) + Math.Abs(7.55355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5844 - lat) + Math.Abs(9.34101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79435 - lat) + Math.Abs(7.57789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34713 - lat) + Math.Abs(8.72091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02667 - lat) + Math.Abs(7.50081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13696 - lat) + Math.Abs(7.77193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31669 - lat) + Math.Abs(9.2795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31637 - lat) + Math.Abs(8.79369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.197 - lat) + Math.Abs(9.30856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9275 - lat) + Math.Abs(9.53422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63921 - lat) + Math.Abs(8.79064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50213 - lat) + Math.Abs(8.25554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6853 - lat) + Math.Abs(7.84722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86281 - lat) + Math.Abs(8.76923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3212 - lat) + Math.Abs(8.38102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30998 - lat) + Math.Abs(8.11371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40787 - lat) + Math.Abs(8.72607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06258 - lat) + Math.Abs(8.8052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41396 - lat) + Math.Abs(8.44761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5025 - lat) + Math.Abs(8.34729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13645 - lat) + Math.Abs(8.5853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36911 - lat) + Math.Abs(8.45699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.67074 - lat) + Math.Abs(8.63542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11699 - lat) + Math.Abs(7.89607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21096 - lat) + Math.Abs(8.01808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26441 - lat) + Math.Abs(8.67925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77392 - lat) + Math.Abs(7.57251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30353 - lat) + Math.Abs(8.0232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23672 - lat) + Math.Abs(8.7573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86587 - lat) + Math.Abs(7.30998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09005 - lat) + Math.Abs(8.40335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0942 - lat) + Math.Abs(7.15699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30028 - lat) + Math.Abs(7.702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49201 - lat) + Math.Abs(8.25412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43633 - lat) + Math.Abs(8.84629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20291 - lat) + Math.Abs(8.94896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74292 - lat) + Math.Abs(8.98716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63539 - lat) + Math.Abs(8.68919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92228 - lat) + Math.Abs(7.8452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94168 - lat) + Math.Abs(7.87996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2289 - lat) + Math.Abs(6.91589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40782 - lat) + Math.Abs(9.46498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90075 - lat) + Math.Abs(9.5612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36561 - lat) + Math.Abs(7.8868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23573 - lat) + Math.Abs(8.07652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72796 - lat) + Math.Abs(7.13769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41538 - lat) + Math.Abs(6.20813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94018 - lat) + Math.Abs(6.67595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66862 - lat) + Math.Abs(8.42995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22298 - lat) + Math.Abs(7.10287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01699 - lat) + Math.Abs(7.73639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4789 - lat) + Math.Abs(8.70215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23837 - lat) + Math.Abs(7.85239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86031 - lat) + Math.Abs(7.49216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66014 - lat) + Math.Abs(9.57883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69724 - lat) + Math.Abs(9.43938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54594 - lat) + Math.Abs(8.96358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75118 - lat) + Math.Abs(7.62166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70383 - lat) + Math.Abs(6.75501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75319 - lat) + Math.Abs(7.57442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49941 - lat) + Math.Abs(7.55669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74717 - lat) + Math.Abs(8.70724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29175 - lat) + Math.Abs(8.56351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43534 - lat) + Math.Abs(8.10027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32896 - lat) + Math.Abs(8.11777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3908 - lat) + Math.Abs(9.38644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06813 - lat) + Math.Abs(8.96501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32688 - lat) + Math.Abs(8.02097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55809 - lat) + Math.Abs(8.28914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4491 - lat) + Math.Abs(7.88491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22079 - lat) + Math.Abs(7.19759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0663 - lat) + Math.Abs(7.19883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06838 - lat) + Math.Abs(7.77766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26898 - lat) + Math.Abs(8.85024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34503 - lat) + Math.Abs(6.83041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82964 - lat) + Math.Abs(9.40648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65698 - lat) + Math.Abs(9.13999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81483 - lat) + Math.Abs(7.21852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17088 - lat) + Math.Abs(8.11113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02747 - lat) + Math.Abs(7.74526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53602 - lat) + Math.Abs(8.09628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53967 - lat) + Math.Abs(9.18585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37172 - lat) + Math.Abs(8.07967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19852 - lat) + Math.Abs(7.61949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27917 - lat) + Math.Abs(7.92895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95835 - lat) + Math.Abs(7.52508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52588 - lat) + Math.Abs(8.95317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1951 - lat) + Math.Abs(8.48581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05484 - lat) + Math.Abs(8.58584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04975 - lat) + Math.Abs(8.61214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65933 - lat) + Math.Abs(8.85964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54403 - lat) + Math.Abs(7.95256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77807 - lat) + Math.Abs(7.63249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66667 - lat) + Math.Abs(8.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38197 - lat) + Math.Abs(8.16681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9768 - lat) + Math.Abs(8.33553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95805 - lat) + Math.Abs(8.36609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3429 - lat) + Math.Abs(9.59072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22937 - lat) + Math.Abs(7.88269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23341 - lat) + Math.Abs(7.87273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28395 - lat) + Math.Abs(8.04208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24254 - lat) + Math.Abs(8.72342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5294 - lat) + Math.Abs(8.46353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84846 - lat) + Math.Abs(8.93642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42285 - lat) + Math.Abs(8.36792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87259 - lat) + Math.Abs(8.73017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68473 - lat) + Math.Abs(7.69111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4109 - lat) + Math.Abs(9.44335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65521 - lat) + Math.Abs(6.74197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6691 - lat) + Math.Abs(7.05249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99766 - lat) + Math.Abs(8.93783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14369 - lat) + Math.Abs(6.04282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20791 - lat) + Math.Abs(7.53714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65852 - lat) + Math.Abs(6.87774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46408 - lat) + Math.Abs(7.80888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03242 - lat) + Math.Abs(7.18882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46222 - lat) + Math.Abs(8.99763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22739 - lat) + Math.Abs(7.35559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19296 - lat) + Math.Abs(8.39384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4581 - lat) + Math.Abs(9.79514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70041 - lat) + Math.Abs(9.45404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.7891 - lat) + Math.Abs(8.67325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71656 - lat) + Math.Abs(7.71335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91944 - lat) + Math.Abs(7.72418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54459 - lat) + Math.Abs(8.37952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29192 - lat) + Math.Abs(7.53559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17449 - lat) + Math.Abs(8.89781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12213 - lat) + Math.Abs(9.48601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53545 - lat) + Math.Abs(8.73728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99855 - lat) + Math.Abs(8.81968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34848 - lat) + Math.Abs(8.16072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81717 - lat) + Math.Abs(10.33683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26063 - lat) + Math.Abs(9.50268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46797 - lat) + Math.Abs(8.75775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57321 - lat) + Math.Abs(6.92948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13577 - lat) + Math.Abs(8.19149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18363 - lat) + Math.Abs(8.99162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07752 - lat) + Math.Abs(7.15279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20531 - lat) + Math.Abs(7.45521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46249 - lat) + Math.Abs(7.72039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42886 - lat) + Math.Abs(9.76364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78765 - lat) + Math.Abs(7.53937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32503 - lat) + Math.Abs(8.20724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97302 - lat) + Math.Abs(8.58689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03445 - lat) + Math.Abs(7.31249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88199 - lat) + Math.Abs(8.61611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15585 - lat) + Math.Abs(7.66567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42181 - lat) + Math.Abs(8.54779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79671 - lat) + Math.Abs(10.29804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02076 - lat) + Math.Abs(8.65414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35255 - lat) + Math.Abs(9.24894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01705 - lat) + Math.Abs(8.17261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99541 - lat) + Math.Abs(9.0701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58541 - lat) + Math.Abs(8.14455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95161 - lat) + Math.Abs(8.01723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03661 - lat) + Math.Abs(7.37723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17326 - lat) + Math.Abs(8.92811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16896 - lat) + Math.Abs(7.9887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51702 - lat) + Math.Abs(9.14089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3691 - lat) + Math.Abs(8.00167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53853 - lat) + Math.Abs(7.50572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3059 - lat) + Math.Abs(8.05119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11173 - lat) + Math.Abs(7.39368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8575 - lat) + Math.Abs(7.25031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22538 - lat) + Math.Abs(8.94836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29155 - lat) + Math.Abs(8.08809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39668 - lat) + Math.Abs(8.44763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74818 - lat) + Math.Abs(8.48213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4465 - lat) + Math.Abs(8.14089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44992 - lat) + Math.Abs(8.16833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1746 - lat) + Math.Abs(8.71345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96973 - lat) + Math.Abs(9.6872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17765 - lat) + Math.Abs(8.13204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8655 - lat) + Math.Abs(8.65465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71814 - lat) + Math.Abs(9.45903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15995 - lat) + Math.Abs(9.04549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82784 - lat) + Math.Abs(7.85987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37664 - lat) + Math.Abs(8.14263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69732 - lat) + Math.Abs(8.63493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61248 - lat) + Math.Abs(9.98465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14937 - lat) + Math.Abs(7.17514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59732 - lat) + Math.Abs(9.59816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53844 - lat) + Math.Abs(6.73222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25115 - lat) + Math.Abs(7.34558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08246 - lat) + Math.Abs(8.63565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21462 - lat) + Math.Abs(6.03553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89611 - lat) + Math.Abs(8.24531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31109 - lat) + Math.Abs(8.2495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04896 - lat) + Math.Abs(9.44103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23709 - lat) + Math.Abs(9.10684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26285 - lat) + Math.Abs(9.14485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13161 - lat) + Math.Abs(8.80262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50827 - lat) + Math.Abs(7.39559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31782 - lat) + Math.Abs(9.17599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17717 - lat) + Math.Abs(7.80349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49937 - lat) + Math.Abs(9.84327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45253 - lat) + Math.Abs(9.63741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24368 - lat) + Math.Abs(8.96438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42391 - lat) + Math.Abs(9.37477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82207 - lat) + Math.Abs(7.26091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19167 - lat) + Math.Abs(8.68196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94373 - lat) + Math.Abs(10.36058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53399 - lat) + Math.Abs(9.87276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1189 - lat) + Math.Abs(7.02078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55433 - lat) + Math.Abs(9.37229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31155 - lat) + Math.Abs(7.5712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63473 - lat) + Math.Abs(6.97336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39069 - lat) + Math.Abs(8.85294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36474 - lat) + Math.Abs(7.15436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91111 - lat) + Math.Abs(6.56219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47963 - lat) + Math.Abs(6.45992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21826 - lat) + Math.Abs(7.0032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1727 - lat) + Math.Abs(7.44427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50794 - lat) + Math.Abs(6.38753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25152 - lat) + Math.Abs(7.41714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15284 - lat) + Math.Abs(6.99692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39217 - lat) + Math.Abs(6.80594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82203 - lat) + Math.Abs(6.50283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4459 - lat) + Math.Abs(6.15737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01511 - lat) + Math.Abs(6.98832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89419 - lat) + Math.Abs(6.77251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17035 - lat) + Math.Abs(7.18771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25619 - lat) + Math.Abs(6.99648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24339 - lat) + Math.Abs(7.20607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32163 - lat) + Math.Abs(7.98254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86718 - lat) + Math.Abs(8.23344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12281 - lat) + Math.Abs(7.93651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10805 - lat) + Math.Abs(7.92741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91018 - lat) + Math.Abs(9.80865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48945 - lat) + Math.Abs(7.26003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25603 - lat) + Math.Abs(8.85552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2948 - lat) + Math.Abs(9.53857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08425 - lat) + Math.Abs(8.12645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39669 - lat) + Math.Abs(8.77515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30688 - lat) + Math.Abs(8.55135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77977 - lat) + Math.Abs(7.39167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40131 - lat) + Math.Abs(8.12877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43349 - lat) + Math.Abs(7.88255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45041 - lat) + Math.Abs(8.52993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77783 - lat) + Math.Abs(9.1484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82216 - lat) + Math.Abs(7.4389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61916 - lat) + Math.Abs(6.82225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37101 - lat) + Math.Abs(8.38083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98374 - lat) + Math.Abs(7.72167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89868 - lat) + Math.Abs(7.5446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93309 - lat) + Math.Abs(8.98699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48811 - lat) + Math.Abs(7.20659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14283 - lat) + Math.Abs(8.4314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30508 - lat) + Math.Abs(7.89196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1042 - lat) + Math.Abs(8.67585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46757 - lat) + Math.Abs(7.08368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42366 - lat) + Math.Abs(7.48024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.478 - lat) + Math.Abs(9.4903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53092 - lat) + Math.Abs(8.57555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11458 - lat) + Math.Abs(8.39021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14624 - lat) + Math.Abs(8.72793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69652 - lat) + Math.Abs(6.91898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16881 - lat) + Math.Abs(8.24528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56586 - lat) + Math.Abs(9.37869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56403 - lat) + Math.Abs(6.60538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4582 - lat) + Math.Abs(6.33499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13521 - lat) + Math.Abs(7.81334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41029 - lat) + Math.Abs(7.95333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49981 - lat) + Math.Abs(9.3958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24119 - lat) + Math.Abs(7.82141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48082 - lat) + Math.Abs(7.45767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36091 - lat) + Math.Abs(6.93272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90123 - lat) + Math.Abs(8.97167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70114 - lat) + Math.Abs(7.89445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43099 - lat) + Math.Abs(8.68624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81028 - lat) + Math.Abs(7.48014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23158 - lat) + Math.Abs(7.56829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17276 - lat) + Math.Abs(7.2236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55191 - lat) + Math.Abs(8.79654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44856 - lat) + Math.Abs(9.04902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20622 - lat) + Math.Abs(8.69686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21757 - lat) + Math.Abs(7.94459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64224 - lat) + Math.Abs(7.06183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55437 - lat) + Math.Abs(7.79403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4663 - lat) + Math.Abs(9.59028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79891 - lat) + Math.Abs(9.39764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69363 - lat) + Math.Abs(7.62102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53989 - lat) + Math.Abs(6.5881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57187 - lat) + Math.Abs(8.31782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25732 - lat) + Math.Abs(8.18091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39824 - lat) + Math.Abs(7.68718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24719 - lat) + Math.Abs(7.97135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17097 - lat) + Math.Abs(8.97704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42611 - lat) + Math.Abs(9.483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4341 - lat) + Math.Abs(8.46874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23431 - lat) + Math.Abs(7.22239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76766 - lat) + Math.Abs(7.24028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39812 - lat) + Math.Abs(9.58503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49927 - lat) + Math.Abs(8.796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31196 - lat) + Math.Abs(7.80029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22557 - lat) + Math.Abs(8.82228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30952 - lat) + Math.Abs(7.50058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70797 - lat) + Math.Abs(8.80949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43932 - lat) + Math.Abs(8.82166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60438 - lat) + Math.Abs(8.54305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02146 - lat) + Math.Abs(7.27178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.107 - lat) + Math.Abs(9.24199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98647 - lat) + Math.Abs(8.86877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51027 - lat) + Math.Abs(6.66183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50093 - lat) + Math.Abs(6.78249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33939 - lat) + Math.Abs(9.55759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53698 - lat) + Math.Abs(6.60456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21975 - lat) + Math.Abs(6.25517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02021 - lat) + Math.Abs(8.97429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52071 - lat) + Math.Abs(7.69356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75145 - lat) + Math.Abs(7.17778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39518 - lat) + Math.Abs(6.2496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32441 - lat) + Math.Abs(10.05823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41728 - lat) + Math.Abs(7.07573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4955 - lat) + Math.Abs(9.90126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81527 - lat) + Math.Abs(7.04142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57887 - lat) + Math.Abs(9.92015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73488 - lat) + Math.Abs(7.25119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16789 - lat) + Math.Abs(6.11664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74198 - lat) + Math.Abs(7.28666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17501 - lat) + Math.Abs(7.33791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17006 - lat) + Math.Abs(9.02522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59693 - lat) + Math.Abs(8.9542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51394 - lat) + Math.Abs(8.6423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36476 - lat) + Math.Abs(8.62375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45984 - lat) + Math.Abs(7.58975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24836 - lat) + Math.Abs(8.17752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22772 - lat) + Math.Abs(7.89719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36453 - lat) + Math.Abs(8.79202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20109 - lat) + Math.Abs(8.77816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98704 - lat) + Math.Abs(6.88903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19398 - lat) + Math.Abs(7.24913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4669 - lat) + Math.Abs(6.35349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27568 - lat) + Math.Abs(7.34161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61077 - lat) + Math.Abs(6.52519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82192 - lat) + Math.Abs(6.93817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50548 - lat) + Math.Abs(6.66819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58093 - lat) + Math.Abs(6.42941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54191 - lat) + Math.Abs(6.83989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70123 - lat) + Math.Abs(6.6754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28228 - lat) + Math.Abs(8.40432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40125 - lat) + Math.Abs(8.21383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46053 - lat) + Math.Abs(8.39141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95694 - lat) + Math.Abs(7.49019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61175 - lat) + Math.Abs(8.72781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31208 - lat) + Math.Abs(8.98579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16068 - lat) + Math.Abs(7.21368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02903 - lat) + Math.Abs(7.14437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13891 - lat) + Math.Abs(7.30775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57094 - lat) + Math.Abs(6.82557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46936 - lat) + Math.Abs(7.87248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72504 - lat) + Math.Abs(6.53069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43169 - lat) + Math.Abs(8.57588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18396 - lat) + Math.Abs(6.10237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34999 - lat) + Math.Abs(7.90329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29524 - lat) + Math.Abs(6.99314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31382 - lat) + Math.Abs(7.92533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42832 - lat) + Math.Abs(8.39491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27049 - lat) + Math.Abs(8.72023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40823 - lat) + Math.Abs(8.54258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28764 - lat) + Math.Abs(7.71612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14953 - lat) + Math.Abs(7.73603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26413 - lat) + Math.Abs(8.4215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51407 - lat) + Math.Abs(7.55786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32514 - lat) + Math.Abs(8.80005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50226 - lat) + Math.Abs(8.40702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43076 - lat) + Math.Abs(9.12724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38507 - lat) + Math.Abs(8.42581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4875 - lat) + Math.Abs(8.29652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74126 - lat) + Math.Abs(7.28149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75 - lat) + Math.Abs(9.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16673 - lat) + Math.Abs(8.39441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32088 - lat) + Math.Abs(9.56808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27444 - lat) + Math.Abs(8.57838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17793 - lat) + Math.Abs(7.69489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60477 - lat) + Math.Abs(8.76709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31244 - lat) + Math.Abs(8.39242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15642 - lat) + Math.Abs(8.11567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41474 - lat) + Math.Abs(8.71644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0384 - lat) + Math.Abs(8.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35673 - lat) + Math.Abs(9.11076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36538 - lat) + Math.Abs(7.95173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47576 - lat) + Math.Abs(8.51896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35639 - lat) + Math.Abs(8.04594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40841 - lat) + Math.Abs(8.46515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53742 - lat) + Math.Abs(8.29036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4878 - lat) + Math.Abs(8.61828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42531 - lat) + Math.Abs(9.55134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39353 - lat) + Math.Abs(7.75169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84117 - lat) + Math.Abs(7.6173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03665 - lat) + Math.Abs(7.62745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31334 - lat) + Math.Abs(7.76836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2607 - lat) + Math.Abs(7.66359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87363 - lat) + Math.Abs(7.4028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38318 - lat) + Math.Abs(6.23955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44814 - lat) + Math.Abs(8.64908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3941 - lat) + Math.Abs(7.61951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84073 - lat) + Math.Abs(8.98236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0102 - lat) + Math.Abs(8.8561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13469 - lat) + Math.Abs(8.13774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80145 - lat) + Math.Abs(7.02784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95622 - lat) + Math.Abs(6.72462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11487 - lat) + Math.Abs(7.08014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8501 - lat) + Math.Abs(7.57748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50614 - lat) + Math.Abs(8.37711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12598 - lat) + Math.Abs(9.05428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42409 - lat) + Math.Abs(8.30404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40079 - lat) + Math.Abs(8.1764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47487 - lat) + Math.Abs(9.18543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37157 - lat) + Math.Abs(7.98837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31243 - lat) + Math.Abs(7.78364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39753 - lat) + Math.Abs(8.00797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46547 - lat) + Math.Abs(9.20568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29646 - lat) + Math.Abs(7.7718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27175 - lat) + Math.Abs(7.69583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12545 - lat) + Math.Abs(7.24033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69012 - lat) + Math.Abs(8.49981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68579 - lat) + Math.Abs(8.61474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09989 - lat) + Math.Abs(8.20416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44985 - lat) + Math.Abs(8.32682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17699 - lat) + Math.Abs(8.20911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99179 - lat) + Math.Abs(6.931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06337 - lat) + Math.Abs(9.05734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52764 - lat) + Math.Abs(8.6649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19185 - lat) + Math.Abs(7.97769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32536 - lat) + Math.Abs(7.98912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36975 - lat) + Math.Abs(8.68894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09775 - lat) + Math.Abs(9.06361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52271 - lat) + Math.Abs(7.64511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62683 - lat) + Math.Abs(10.44624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92827 - lat) + Math.Abs(7.11715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27428 - lat) + Math.Abs(8.33854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93122 - lat) + Math.Abs(7.48658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27145 - lat) + Math.Abs(7.83935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97676 - lat) + Math.Abs(8.76499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52102 - lat) + Math.Abs(9.32484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99548 - lat) + Math.Abs(7.14626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63197 - lat) + Math.Abs(9.23271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87298 - lat) + Math.Abs(7.561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31504 - lat) + Math.Abs(7.94123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47719 - lat) + Math.Abs(8.99677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51848 - lat) + Math.Abs(7.60966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02175 - lat) + Math.Abs(7.45036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54563 - lat) + Math.Abs(7.92123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60195 - lat) + Math.Abs(9.00357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81345 - lat) + Math.Abs(7.50881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95466 - lat) + Math.Abs(7.26102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22902 - lat) + Math.Abs(8.38898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33578 - lat) + Math.Abs(8.05536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27818 - lat) + Math.Abs(7.36951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66758 - lat) + Math.Abs(6.79781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91108 - lat) + Math.Abs(6.61111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36252 - lat) + Math.Abs(9.04296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47097 - lat) + Math.Abs(9.42278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98271 - lat) + Math.Abs(8.61826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0851 - lat) + Math.Abs(7.21413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.239 - lat) + Math.Abs(6.852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51127 - lat) + Math.Abs(6.49854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.925 - lat) + Math.Abs(8.916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86004 - lat) + Math.Abs(9.02318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84915 - lat) + Math.Abs(9.01907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59956 - lat) + Math.Abs(6.37668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43301 - lat) + Math.Abs(6.91143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25451 - lat) + Math.Abs(6.95406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18649 - lat) + Math.Abs(8.99892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31338 - lat) + Math.Abs(7.48839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79289 - lat) + Math.Abs(6.61222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98323 - lat) + Math.Abs(8.91786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30958 - lat) + Math.Abs(8.72029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08878 - lat) + Math.Abs(9.07242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5776 - lat) + Math.Abs(6.3632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55915 - lat) + Math.Abs(7.84329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36222 - lat) + Math.Abs(9.13541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17769 - lat) + Math.Abs(8.81473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31119 - lat) + Math.Abs(7.54701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67958 - lat) + Math.Abs(6.9263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23424 - lat) + Math.Abs(6.08025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18548 - lat) + Math.Abs(7.00004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24529 - lat) + Math.Abs(8.46347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09155 - lat) + Math.Abs(7.44528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3939 - lat) + Math.Abs(9.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34368 - lat) + Math.Abs(7.49988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7601 - lat) + Math.Abs(8.61053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25944 - lat) + Math.Abs(8.37633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08364 - lat) + Math.Abs(8.03971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17764 - lat) + Math.Abs(8.59215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23965 - lat) + Math.Abs(8.18996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87019 - lat) + Math.Abs(8.9816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41903 - lat) + Math.Abs(8.27331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95455 - lat) + Math.Abs(8.94725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18213 - lat) + Math.Abs(7.85128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92202 - lat) + Math.Abs(8.98435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29489 - lat) + Math.Abs(8.22867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72709 - lat) + Math.Abs(8.1872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15965 - lat) + Math.Abs(7.34801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27232 - lat) + Math.Abs(8.64617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1247 - lat) + Math.Abs(8.44274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04691 - lat) + Math.Abs(8.37467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16703 - lat) + Math.Abs(8.06793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51957 - lat) + Math.Abs(8.93365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30374 - lat) + Math.Abs(7.6282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67833 - lat) + Math.Abs(7.86889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96974 - lat) + Math.Abs(9.54463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01257 - lat) + Math.Abs(8.94354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10276 - lat) + Math.Abs(7.07245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07817 - lat) + Math.Abs(7.05099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.62913 - lat) + Math.Abs(8.65326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59252 - lat) + Math.Abs(9.06851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65644 - lat) + Math.Abs(7.05948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77611 - lat) + Math.Abs(7.16459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55009 - lat) + Math.Abs(6.87217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25686 - lat) + Math.Abs(8.69893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64625 - lat) + Math.Abs(8.91519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40588 - lat) + Math.Abs(8.9819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03628 - lat) + Math.Abs(8.18193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23839 - lat) + Math.Abs(7.27286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81248 - lat) + Math.Abs(9.53196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98096 - lat) + Math.Abs(9.57527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52468 - lat) + Math.Abs(7.84537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00472 - lat) + Math.Abs(9.53115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.139 - lat) + Math.Abs(7.21407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24689 - lat) + Math.Abs(8.7062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52868 - lat) + Math.Abs(7.81128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14892 - lat) + Math.Abs(8.8561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16463 - lat) + Math.Abs(7.79858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06445 - lat) + Math.Abs(7.58228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0741 - lat) + Math.Abs(7.30655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05048 - lat) + Math.Abs(8.30635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91957 - lat) + Math.Abs(9.7608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00757 - lat) + Math.Abs(7.69165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50241 - lat) + Math.Abs(6.68647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39451 - lat) + Math.Abs(9.08312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05753 - lat) + Math.Abs(7.91692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21426 - lat) + Math.Abs(7.58463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78578 - lat) + Math.Abs(8.15984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2302 - lat) + Math.Abs(9.0642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83401 - lat) + Math.Abs(6.84534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01008 - lat) + Math.Abs(8.96004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9664 - lat) + Math.Abs(9.03715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70854 - lat) + Math.Abs(6.83931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19135 - lat) + Math.Abs(7.79102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38372 - lat) + Math.Abs(7.94655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31301 - lat) + Math.Abs(9.19663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16866 - lat) + Math.Abs(8.75928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51729 - lat) + Math.Abs(8.99669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75508 - lat) + Math.Abs(8.66847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30016 - lat) + Math.Abs(8.97986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17086 - lat) + Math.Abs(8.79953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05 - lat) + Math.Abs(8.26274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92127 - lat) + Math.Abs(8.99799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8469 - lat) + Math.Abs(7.67831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44299 - lat) + Math.Abs(8.67362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86161 - lat) + Math.Abs(8.95166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08331 - lat) + Math.Abs(7.06592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08368 - lat) + Math.Abs(7.13476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48455 - lat) + Math.Abs(7.73446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40398 - lat) + Math.Abs(7.42787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90881 - lat) + Math.Abs(7.19636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99249 - lat) + Math.Abs(7.18729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32381 - lat) + Math.Abs(9.08758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1866 - lat) + Math.Abs(7.2078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34183 - lat) + Math.Abs(7.01151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47753 - lat) + Math.Abs(6.23603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17458 - lat) + Math.Abs(7.45775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30969 - lat) + Math.Abs(8.17309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37943 - lat) + Math.Abs(7.62687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31736 - lat) + Math.Abs(7.63412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90413 - lat) + Math.Abs(6.48039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99735 - lat) + Math.Abs(6.73059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01528 - lat) + Math.Abs(6.8513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21099 - lat) + Math.Abs(7.00792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06774 - lat) + Math.Abs(6.70478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17715 - lat) + Math.Abs(6.90498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72215 - lat) + Math.Abs(9.55905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38853 - lat) + Math.Abs(8.17503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28298 - lat) + Math.Abs(7.44976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22464 - lat) + Math.Abs(6.95784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45826 - lat) + Math.Abs(7.44298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18155 - lat) + Math.Abs(7.36814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55815 - lat) + Math.Abs(6.63145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05619 - lat) + Math.Abs(6.74913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05702 - lat) + Math.Abs(7.07052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6546 - lat) + Math.Abs(7.77548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5879 - lat) + Math.Abs(8.17611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60688 - lat) + Math.Abs(6.23062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82896 - lat) + Math.Abs(7.01621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25893 - lat) + Math.Abs(8.83756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59307 - lat) + Math.Abs(7.90938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47139 - lat) + Math.Abs(7.7603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.516 - lat) + Math.Abs(6.63282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96564 - lat) + Math.Abs(7.74214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3126 - lat) + Math.Abs(7.65465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90214 - lat) + Math.Abs(7.23973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55985 - lat) + Math.Abs(8.06225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42193 - lat) + Math.Abs(7.49946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39457 - lat) + Math.Abs(7.85578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03327 - lat) + Math.Abs(8.58339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61061 - lat) + Math.Abs(7.06496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45312 - lat) + Math.Abs(6.85856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65863 - lat) + Math.Abs(6.51077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04591 - lat) + Math.Abs(6.80946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6962 - lat) + Math.Abs(7.13721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59353 - lat) + Math.Abs(9.24727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28643 - lat) + Math.Abs(8.53627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93936 - lat) + Math.Abs(7.78738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21526 - lat) + Math.Abs(7.79607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34917 - lat) + Math.Abs(7.76802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06592 - lat) + Math.Abs(7.09717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95 - lat) + Math.Abs(9.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95802 - lat) + Math.Abs(7.67952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11682 - lat) + Math.Abs(7.13476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29951 - lat) + Math.Abs(7.90235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27893 - lat) + Math.Abs(7.13726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86744 - lat) + Math.Abs(6.49043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47227 - lat) + Math.Abs(6.87366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19224 - lat) + Math.Abs(8.85324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09993 - lat) + Math.Abs(6.82586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98055 - lat) + Math.Abs(6.60639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64966 - lat) + Math.Abs(6.31907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80452 - lat) + Math.Abs(9.25787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41484 - lat) + Math.Abs(8.04979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08557 - lat) + Math.Abs(8.44206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31805 - lat) + Math.Abs(8.58401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38887 - lat) + Math.Abs(8.33045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91446 - lat) + Math.Abs(9.77929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24755 - lat) + Math.Abs(9.17064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0311 - lat) + Math.Abs(8.28547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17449 - lat) + Math.Abs(7.59799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65051 - lat) + Math.Abs(9.17504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00964 - lat) + Math.Abs(7.5664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66139 - lat) + Math.Abs(7.72777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13125 - lat) + Math.Abs(7.60525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87909 - lat) + Math.Abs(7.62013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92436 - lat) + Math.Abs(7.41457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33337 - lat) + Math.Abs(8.02237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45793 - lat) + Math.Abs(8.78295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60972 - lat) + Math.Abs(8.2375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19953 - lat) + Math.Abs(8.07315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2235 - lat) + Math.Abs(8.46197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45152 - lat) + Math.Abs(8.58491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88918 - lat) + Math.Abs(9.83826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58361 - lat) + Math.Abs(8.2488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42518 - lat) + Math.Abs(7.41607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14571 - lat) + Math.Abs(7.78965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99965 - lat) + Math.Abs(7.41735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82085 - lat) + Math.Abs(7.54847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41159 - lat) + Math.Abs(9.0402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08538 - lat) + Math.Abs(7.58288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43223 - lat) + Math.Abs(8.35097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32438 - lat) + Math.Abs(8.54548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81956 - lat) + Math.Abs(7.58402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5935 - lat) + Math.Abs(9.31723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97586 - lat) + Math.Abs(7.1957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90121 - lat) + Math.Abs(8.27514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91035 - lat) + Math.Abs(7.47096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06015 - lat) + Math.Abs(7.2686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49467 - lat) + Math.Abs(7.67326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56212 - lat) + Math.Abs(7.659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21367 - lat) + Math.Abs(9.0259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02032 - lat) + Math.Abs(7.23545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5416 - lat) + Math.Abs(8.04337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53966 - lat) + Math.Abs(7.72605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2359 - lat) + Math.Abs(6.26701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42402 - lat) + Math.Abs(9.08689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2975 - lat) + Math.Abs(8.39282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22983 - lat) + Math.Abs(8.83884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90405 - lat) + Math.Abs(7.16272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00149 - lat) + Math.Abs(9.55657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92892 - lat) + Math.Abs(9.71275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04802 - lat) + Math.Abs(7.50787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61131 - lat) + Math.Abs(7.27593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16228 - lat) + Math.Abs(7.24474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91079 - lat) + Math.Abs(8.56121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3624 - lat) + Math.Abs(8.79265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32571 - lat) + Math.Abs(8.96656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1253 - lat) + Math.Abs(8.34885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17751 - lat) + Math.Abs(8.70016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68387 - lat) + Math.Abs(7.86638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00584 - lat) + Math.Abs(7.10609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9988 - lat) + Math.Abs(8.61529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4113 - lat) + Math.Abs(8.72125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98764 - lat) + Math.Abs(8.72509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77413 - lat) + Math.Abs(9.20461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94531 - lat) + Math.Abs(9.57218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01105 - lat) + Math.Abs(8.64538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60674 - lat) + Math.Abs(8.87343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11502 - lat) + Math.Abs(7.86209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57803 - lat) + Math.Abs(8.98081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59576 - lat) + Math.Abs(8.49116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17536 - lat) + Math.Abs(8.42497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36464 - lat) + Math.Abs(9.31847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01692 - lat) + Math.Abs(8.30956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5001 - lat) + Math.Abs(8.06275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49425 - lat) + Math.Abs(9.46246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25983 - lat) + Math.Abs(8.59778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40313 - lat) + Math.Abs(8.4971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63469 - lat) + Math.Abs(9.00756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25298 - lat) + Math.Abs(8.77212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4229 - lat) + Math.Abs(7.77041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33315 - lat) + Math.Abs(7.75257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18083 - lat) + Math.Abs(8.31802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45389 - lat) + Math.Abs(7.64459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16841 - lat) + Math.Abs(8.29179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22403 - lat) + Math.Abs(8.26425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36334 - lat) + Math.Abs(8.82418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29426 - lat) + Math.Abs(8.84393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(9.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0427 - lat) + Math.Abs(7.54143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42136 - lat) + Math.Abs(7.59985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73521 - lat) + Math.Abs(7.66185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15068 - lat) + Math.Abs(8.22582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5461 - lat) + Math.Abs(8.70532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18795 - lat) + Math.Abs(7.7062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29064 - lat) + Math.Abs(8.61464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83125 - lat) + Math.Abs(7.47775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30141 - lat) + Math.Abs(6.24332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38615 - lat) + Math.Abs(9.27916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98429 - lat) + Math.Abs(8.30944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18032 - lat) + Math.Abs(7.40477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60304 - lat) + Math.Abs(8.91077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29629 - lat) + Math.Abs(7.59298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56272 - lat) + Math.Abs(8.68215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38596 - lat) + Math.Abs(8.21785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73378 - lat) + Math.Abs(8.5853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30062 - lat) + Math.Abs(9.17517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82762 - lat) + Math.Abs(7.29944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06755 - lat) + Math.Abs(7.66665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79482 - lat) + Math.Abs(7.60433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75109 - lat) + Math.Abs(7.68391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44255 - lat) + Math.Abs(9.53293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50716 - lat) + Math.Abs(8.77057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67009 - lat) + Math.Abs(7.11041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24496 - lat) + Math.Abs(8.53299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36931 - lat) + Math.Abs(9.36752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97787 - lat) + Math.Abs(8.05326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69648 - lat) + Math.Abs(8.45827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87867 - lat) + Math.Abs(9.52618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38851 - lat) + Math.Abs(8.25285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49462 - lat) + Math.Abs(9.34487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33497 - lat) + Math.Abs(7.84133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52035 - lat) + Math.Abs(8.8892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72639 - lat) + Math.Abs(7.86304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60349 - lat) + Math.Abs(9.28742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73814 - lat) + Math.Abs(8.62843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21072 - lat) + Math.Abs(8.17932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31375 - lat) + Math.Abs(7.83102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76756 - lat) + Math.Abs(7.32946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66509 - lat) + Math.Abs(7.87299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47215 - lat) + Math.Abs(7.28685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27377 - lat) + Math.Abs(7.05975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58338 - lat) + Math.Abs(7.08207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97965 - lat) + Math.Abs(9.64639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1331 - lat) + Math.Abs(8.05041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59447 - lat) + Math.Abs(8.67826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06534 - lat) + Math.Abs(7.35689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24832 - lat) + Math.Abs(9.14829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25288 - lat) + Math.Abs(7.45947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8336 - lat) + Math.Abs(7.07116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62396 - lat) + Math.Abs(8.03601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25938 - lat) + Math.Abs(7.38408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05438 - lat) + Math.Abs(8.42995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1921 - lat) + Math.Abs(7.39586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44231 - lat) + Math.Abs(7.58906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36717 - lat) + Math.Abs(8.68115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04208 - lat) + Math.Abs(8.91832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3593 - lat) + Math.Abs(8.10243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76233 - lat) + Math.Abs(6.88808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53899 - lat) + Math.Abs(7.08575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80946 - lat) + Math.Abs(6.646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05101 - lat) + Math.Abs(6.95489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23188 - lat) + Math.Abs(6.12091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87185 - lat) + Math.Abs(6.9284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59214 - lat) + Math.Abs(6.46391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19529 - lat) + Math.Abs(7.83745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18248 - lat) + Math.Abs(9.44395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65922 - lat) + Math.Abs(6.60398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6638 - lat) + Math.Abs(9.13371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41551 - lat) + Math.Abs(9.25482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3051 - lat) + Math.Abs(8.75831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90143 - lat) + Math.Abs(6.77985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21631 - lat) + Math.Abs(9.03076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18256 - lat) + Math.Abs(8.86657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22604 - lat) + Math.Abs(8.74309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27166 - lat) + Math.Abs(8.14396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32725 - lat) + Math.Abs(9.34705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14677 - lat) + Math.Abs(7.87136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23128 - lat) + Math.Abs(9.02355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58518 - lat) + Math.Abs(6.50974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26477 - lat) + Math.Abs(8.96167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04761 - lat) + Math.Abs(8.54616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47401 - lat) + Math.Abs(9.46711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23353 - lat) + Math.Abs(9.02218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33534 - lat) + Math.Abs(7.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55871 - lat) + Math.Abs(8.50167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4313 - lat) + Math.Abs(8.56272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04057 - lat) + Math.Abs(9.06804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42082 - lat) + Math.Abs(6.2701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17246 - lat) + Math.Abs(9.00793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83333 - lat) + Math.Abs(8.18065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49875 - lat) + Math.Abs(8.00497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40141 - lat) + Math.Abs(8.87369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4091 - lat) + Math.Abs(6.17809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50945 - lat) + Math.Abs(6.30736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45785 - lat) + Math.Abs(6.29654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.7623 - lat) + Math.Abs(7.20845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1997 - lat) + Math.Abs(8.10689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14064 - lat) + Math.Abs(7.97007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84023 - lat) + Math.Abs(7.54503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99419 - lat) + Math.Abs(8.525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17087 - lat) + Math.Abs(7.57249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43537 - lat) + Math.Abs(6.21809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20222 - lat) + Math.Abs(6.14569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85333 - lat) + Math.Abs(8.96115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47585 - lat) + Math.Abs(7.66028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46497 - lat) + Math.Abs(7.85174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21447 - lat) + Math.Abs(8.26537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48136 - lat) + Math.Abs(8.23949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38103 - lat) + Math.Abs(9.09239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20429 - lat) + Math.Abs(9.44172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01199 - lat) + Math.Abs(7.05771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31599 - lat) + Math.Abs(7.7421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02841 - lat) + Math.Abs(7.05183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94875 - lat) + Math.Abs(7.15804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3615 - lat) + Math.Abs(9.45356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53935 - lat) + Math.Abs(8.85311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70329 - lat) + Math.Abs(8.49878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13851 - lat) + Math.Abs(7.11468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50688 - lat) + Math.Abs(7.73129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27103 - lat) + Math.Abs(7.83136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58723 - lat) + Math.Abs(7.64945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60123 - lat) + Math.Abs(6.68085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51169 - lat) + Math.Abs(8.02471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80237 - lat) + Math.Abs(7.15128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50686 - lat) + Math.Abs(7.71648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20534 - lat) + Math.Abs(8.75842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95425 - lat) + Math.Abs(7.33835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55776 - lat) + Math.Abs(8.89893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0862 - lat) + Math.Abs(7.52727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33277 - lat) + Math.Abs(6.19243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40292 - lat) + Math.Abs(7.08108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05495 - lat) + Math.Abs(6.8868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6839 - lat) + Math.Abs(8.62995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09058 - lat) + Math.Abs(9.34301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88391 - lat) + Math.Abs(8.01558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90478 - lat) + Math.Abs(8.62396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83705 - lat) + Math.Abs(9.28458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90224 - lat) + Math.Abs(6.58253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41301 - lat) + Math.Abs(9.18324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02567 - lat) + Math.Abs(9.51365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88994 - lat) + Math.Abs(7.32204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57608 - lat) + Math.Abs(8.60633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41422 - lat) + Math.Abs(8.96862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11897 - lat) + Math.Abs(9.13239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67303 - lat) + Math.Abs(9.68592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39981 - lat) + Math.Abs(8.13533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91627 - lat) + Math.Abs(9.74145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18707 - lat) + Math.Abs(8.74724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69054 - lat) + Math.Abs(8.64357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9488 - lat) + Math.Abs(7.21124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84566 - lat) + Math.Abs(9.47588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27873 - lat) + Math.Abs(8.62165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38775 - lat) + Math.Abs(8.75149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90829 - lat) + Math.Abs(7.07803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37169 - lat) + Math.Abs(8.63869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80131 - lat) + Math.Abs(9.23086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.477 - lat) + Math.Abs(8.80125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79401 - lat) + Math.Abs(7.65502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3817 - lat) + Math.Abs(6.20695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11422 - lat) + Math.Abs(7.49407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18096 - lat) + Math.Abs(7.02232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15046 - lat) + Math.Abs(7.23895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15031 - lat) + Math.Abs(8.01759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48225 - lat) + Math.Abs(7.54654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84876 - lat) + Math.Abs(6.8465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9135 - lat) + Math.Abs(7.93426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46361 - lat) + Math.Abs(8.96381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64793 - lat) + Math.Abs(8.87472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23981 - lat) + Math.Abs(8.92156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81885 - lat) + Math.Abs(8.65052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09368 - lat) + Math.Abs(7.59507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37415 - lat) + Math.Abs(7.54116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.67057 - lat) + Math.Abs(9.08573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66021 - lat) + Math.Abs(7.55445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30298 - lat) + Math.Abs(8.59743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54814 - lat) + Math.Abs(9.23415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0422 - lat) + Math.Abs(7.09728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78773 - lat) + Math.Abs(7.77102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07816 - lat) + Math.Abs(7.85149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75368 - lat) + Math.Abs(7.14609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54896 - lat) + Math.Abs(6.66831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99559 - lat) + Math.Abs(8.06354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56669 - lat) + Math.Abs(7.08418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98423 - lat) + Math.Abs(8.41003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03363 - lat) + Math.Abs(9.07888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98192 - lat) + Math.Abs(9.1528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82107 - lat) + Math.Abs(8.40133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95658 - lat) + Math.Abs(8.51467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07819 - lat) + Math.Abs(8.27331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50561 - lat) + Math.Abs(8.59406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91902 - lat) + Math.Abs(9.17242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49715 - lat) + Math.Abs(8.86523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29352 - lat) + Math.Abs(7.77995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12849 - lat) + Math.Abs(8.74735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53361 - lat) + Math.Abs(7.98801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34374 - lat) + Math.Abs(9.5314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15116 - lat) + Math.Abs(8.16695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54268 - lat) + Math.Abs(9.38048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34922 - lat) + Math.Abs(8.18553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57738 - lat) + Math.Abs(8.52122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87575 - lat) + Math.Abs(7.79567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44202 - lat) + Math.Abs(9.46901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29976 - lat) + Math.Abs(8.69032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31957 - lat) + Math.Abs(7.78424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42575 - lat) + Math.Abs(8.69094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48874 - lat) + Math.Abs(8.10277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75777 - lat) + Math.Abs(7.08279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60735 - lat) + Math.Abs(6.80895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6413 - lat) + Math.Abs(6.63317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26195 - lat) + Math.Abs(9.12473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07937 - lat) + Math.Abs(8.34041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08953 - lat) + Math.Abs(7.7917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32094 - lat) + Math.Abs(8.15874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27856 - lat) + Math.Abs(8.84156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84916 - lat) + Math.Abs(7.1915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39724 - lat) + Math.Abs(8.61872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38437 - lat) + Math.Abs(8.23981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48038 - lat) + Math.Abs(7.61644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14892 - lat) + Math.Abs(7.04292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01831 - lat) + Math.Abs(8.05501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85208 - lat) + Math.Abs(6.99075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86716 - lat) + Math.Abs(7.01337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.07192 - lat) + Math.Abs(6.9592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83483 - lat) + Math.Abs(9.45075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70341 - lat) + Math.Abs(8.8509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14665 - lat) + Math.Abs(8.39355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41827 - lat) + Math.Abs(8.6188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40165 - lat) + Math.Abs(8.40015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68908 - lat) + Math.Abs(8.74958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.386 - lat) + Math.Abs(9.65558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64928 - lat) + Math.Abs(7.56477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48146 - lat) + Math.Abs(8.4585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4138 - lat) + Math.Abs(7.81085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1985 - lat) + Math.Abs(7.58844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4526 - lat) + Math.Abs(8.0533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36493 - lat) + Math.Abs(7.34453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21515 - lat) + Math.Abs(7.6188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37429 - lat) + Math.Abs(9.20019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80429 - lat) + Math.Abs(9.83723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65948 - lat) + Math.Abs(7.49111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66175 - lat) + Math.Abs(7.80808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19564 - lat) + Math.Abs(5.99497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9242 - lat) + Math.Abs(8.38785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62115 - lat) + Math.Abs(6.54871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21405 - lat) + Math.Abs(7.98519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66515 - lat) + Math.Abs(8.6179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48892 - lat) + Math.Abs(6.72945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81479 - lat) + Math.Abs(6.88888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17473 - lat) + Math.Abs(8.91684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95577 - lat) + Math.Abs(7.01855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54586 - lat) + Math.Abs(6.57567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27875 - lat) + Math.Abs(9.00261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28329 - lat) + Math.Abs(7.44032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37465 - lat) + Math.Abs(6.16367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92525 - lat) + Math.Abs(6.6327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34074 - lat) + Math.Abs(7.31827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45724 - lat) + Math.Abs(7.04825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17822 - lat) + Math.Abs(7.07236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40799 - lat) + Math.Abs(7.04088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23956 - lat) + Math.Abs(7.33655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36069 - lat) + Math.Abs(7.37371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33853 - lat) + Math.Abs(7.37243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90648 - lat) + Math.Abs(7.11215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40483 - lat) + Math.Abs(7.12522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33461 - lat) + Math.Abs(7.28186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61443 - lat) + Math.Abs(6.50631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94306 - lat) + Math.Abs(6.8444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26297 - lat) + Math.Abs(6.22461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40781 - lat) + Math.Abs(7.16267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0396 - lat) + Math.Abs(7.01872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81029 - lat) + Math.Abs(7.10535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19457 - lat) + Math.Abs(7.14517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87598 - lat) + Math.Abs(7.15212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31682 - lat) + Math.Abs(6.19114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15088 - lat) + Math.Abs(8.92617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2237 - lat) + Math.Abs(7.30283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17341 - lat) + Math.Abs(6.08437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85027 - lat) + Math.Abs(6.71968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03635 - lat) + Math.Abs(8.95526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55709 - lat) + Math.Abs(6.47284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27385 - lat) + Math.Abs(6.94789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45246 - lat) + Math.Abs(7.09979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25763 - lat) + Math.Abs(9.02252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78143 - lat) + Math.Abs(9.54377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84986 - lat) + Math.Abs(9.53287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2802 - lat) + Math.Abs(7.53962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83203 - lat) + Math.Abs(9.03119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06629 - lat) + Math.Abs(6.93332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81439 - lat) + Math.Abs(6.78685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48208 - lat) + Math.Abs(6.77805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39303 - lat) + Math.Abs(7.00038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58624 - lat) + Math.Abs(6.60587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28844 - lat) + Math.Abs(7.47487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19534 - lat) + Math.Abs(6.19406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70244 - lat) + Math.Abs(6.5694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53005 - lat) + Math.Abs(6.57068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52691 - lat) + Math.Abs(6.90083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47455 - lat) + Math.Abs(7.13155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1249 - lat) + Math.Abs(7.13138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61957 - lat) + Math.Abs(7.16486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47676 - lat) + Math.Abs(6.8268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15003 - lat) + Math.Abs(5.97153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17543 - lat) + Math.Abs(6.86903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83213 - lat) + Math.Abs(6.65977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20275 - lat) + Math.Abs(7.22319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18213 - lat) + Math.Abs(8.46358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26758 - lat) + Math.Abs(7.51145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31479 - lat) + Math.Abs(8.60332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05878 - lat) + Math.Abs(6.9004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35069 - lat) + Math.Abs(6.195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51217 - lat) + Math.Abs(9.85794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.7194 - lat) + Math.Abs(9.43271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43241 - lat) + Math.Abs(6.93855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33541 - lat) + Math.Abs(9.12129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86211 - lat) + Math.Abs(9.00843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97364 - lat) + Math.Abs(8.87739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17412 - lat) + Math.Abs(6.01982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18096 - lat) + Math.Abs(6.13921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90368 - lat) + Math.Abs(8.97922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03592 - lat) + Math.Abs(8.96605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16483 - lat) + Math.Abs(9.00547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06734 - lat) + Math.Abs(8.9733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04595 - lat) + Math.Abs(8.98725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15172 - lat) + Math.Abs(8.94719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03672 - lat) + Math.Abs(8.93403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50635 - lat) + Math.Abs(7.86414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26828 - lat) + Math.Abs(8.31064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11442 - lat) + Math.Abs(8.09425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88812 - lat) + Math.Abs(6.55137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36022 - lat) + Math.Abs(9.07213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5511 - lat) + Math.Abs(6.55597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39415 - lat) + Math.Abs(7.54117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27381 - lat) + Math.Abs(9.10735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45276 - lat) + Math.Abs(6.29139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21192 - lat) + Math.Abs(8.0942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54921 - lat) + Math.Abs(9.1495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87565 - lat) + Math.Abs(8.66539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78464 - lat) + Math.Abs(7.49988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05901 - lat) + Math.Abs(7.62786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14035 - lat) + Math.Abs(7.37175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28053 - lat) + Math.Abs(7.81506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97398 - lat) + Math.Abs(8.42279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83119 - lat) + Math.Abs(6.55403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61797 - lat) + Math.Abs(7.0569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52197 - lat) + Math.Abs(8.54049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37348 - lat) + Math.Abs(9.42507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39358 - lat) + Math.Abs(8.08233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16743 - lat) + Math.Abs(9.47794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09625 - lat) + Math.Abs(8.34729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81351 - lat) + Math.Abs(7.67463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57282 - lat) + Math.Abs(8.56281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26698 - lat) + Math.Abs(8.8179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44586 - lat) + Math.Abs(7.73759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42173 - lat) + Math.Abs(8.63263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47318 - lat) + Math.Abs(8.67569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02269 - lat) + Math.Abs(7.14793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25953 - lat) + Math.Abs(10.12385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33595 - lat) + Math.Abs(9.1302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48096 - lat) + Math.Abs(8.20869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1237 - lat) + Math.Abs(7.27887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47835 - lat) + Math.Abs(9.03454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60513 - lat) + Math.Abs(7.09891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25954 - lat) + Math.Abs(7.94689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12013 - lat) + Math.Abs(8.71181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41763 - lat) + Math.Abs(7.5434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31667 - lat) + Math.Abs(7.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75084 - lat) + Math.Abs(8.10139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.7545 - lat) + Math.Abs(8.03847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39783 - lat) + Math.Abs(7.65222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35109 - lat) + Math.Abs(8.34214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40668 - lat) + Math.Abs(7.54554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76986 - lat) + Math.Abs(9.06036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49568 - lat) + Math.Abs(8.08451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89304 - lat) + Math.Abs(7.69757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38319 - lat) + Math.Abs(6.85963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94991 - lat) + Math.Abs(6.83757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02725 - lat) + Math.Abs(6.88911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52343 - lat) + Math.Abs(7.57211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63643 - lat) + Math.Abs(9.20882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28488 - lat) + Math.Abs(8.00599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61596 - lat) + Math.Abs(6.66149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89229 - lat) + Math.Abs(7.2277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37891 - lat) + Math.Abs(6.1762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31505 - lat) + Math.Abs(8.46836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31725 - lat) + Math.Abs(8.18963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68736 - lat) + Math.Abs(7.8935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47738 - lat) + Math.Abs(7.15221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49493 - lat) + Math.Abs(7.01297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81103 - lat) + Math.Abs(9.39821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62847 - lat) + Math.Abs(7.39054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9751 - lat) + Math.Abs(7.49697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35374 - lat) + Math.Abs(6.16603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37808 - lat) + Math.Abs(8.90991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.7421 - lat) + Math.Abs(7.52136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46778 - lat) + Math.Abs(6.89615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44993 - lat) + Math.Abs(7.51936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33779 - lat) + Math.Abs(8.01088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5529 - lat) + Math.Abs(7.62322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29086 - lat) + Math.Abs(8.19741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43432 - lat) + Math.Abs(8.20891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11367 - lat) + Math.Abs(8.93324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46152 - lat) + Math.Abs(8.24816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35515 - lat) + Math.Abs(8.44256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01357 - lat) + Math.Abs(8.91103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54021 - lat) + Math.Abs(7.56932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14995 - lat) + Math.Abs(9.02551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92629 - lat) + Math.Abs(7.62508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53761 - lat) + Math.Abs(6.33362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13713 - lat) + Math.Abs(7.24608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18009 - lat) + Math.Abs(7.56246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35972 - lat) + Math.Abs(8.96965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24965 - lat) + Math.Abs(7.0098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23711 - lat) + Math.Abs(7.28325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92958 - lat) + Math.Abs(6.8147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20062 - lat) + Math.Abs(7.42405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57039 - lat) + Math.Abs(7.66425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20612 - lat) + Math.Abs(8.19265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1765 - lat) + Math.Abs(6.07544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94809 - lat) + Math.Abs(7.44744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69763 - lat) + Math.Abs(8.57431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35155 - lat) + Math.Abs(8.37232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62934 - lat) + Math.Abs(9.74762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57879 - lat) + Math.Abs(9.16635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69138 - lat) + Math.Abs(6.70759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65276 - lat) + Math.Abs(8.65391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19942 - lat) + Math.Abs(9.00735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89129 - lat) + Math.Abs(7.49825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51891 - lat) + Math.Abs(6.67636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10852 - lat) + Math.Abs(7.24608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19278 - lat) + Math.Abs(9.01703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25739 - lat) + Math.Abs(6.15475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.92345 - lat) + Math.Abs(7.02209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82171 - lat) + Math.Abs(7.10674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26059 - lat) + Math.Abs(8.20506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44152 - lat) + Math.Abs(6.24762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76737 - lat) + Math.Abs(8.53535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96653 - lat) + Math.Abs(8.47575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69896 - lat) + Math.Abs(7.79428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68403 - lat) + Math.Abs(6.5671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36745 - lat) + Math.Abs(8.87905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79031 - lat) + Math.Abs(6.52279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93559 - lat) + Math.Abs(8.57836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13164 - lat) + Math.Abs(7.53817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44342 - lat) + Math.Abs(8.62851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18993 - lat) + Math.Abs(7.31209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33808 - lat) + Math.Abs(7.24373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55839 - lat) + Math.Abs(7.57327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3822 - lat) + Math.Abs(7.47229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01947 - lat) + Math.Abs(7.52709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33709 - lat) + Math.Abs(8.85645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85728 - lat) + Math.Abs(7.15881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23996 - lat) + Math.Abs(7.7359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30888 - lat) + Math.Abs(7.8657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31613 - lat) + Math.Abs(7.69318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15371 - lat) + Math.Abs(8.32233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55485 - lat) + Math.Abs(6.3731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72984 - lat) + Math.Abs(6.41357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40556 - lat) + Math.Abs(9.60702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84638 - lat) + Math.Abs(9.00724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08333 - lat) + Math.Abs(7.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00601 - lat) + Math.Abs(9.50266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47333 - lat) + Math.Abs(8.30592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50317 - lat) + Math.Abs(8.54556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20388 - lat) + Math.Abs(8.73224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19625 - lat) + Math.Abs(8.52954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18088 - lat) + Math.Abs(7.60116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28249 - lat) + Math.Abs(7.41028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78753 - lat) + Math.Abs(7.06735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88004 - lat) + Math.Abs(7.04071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20519 - lat) + Math.Abs(8.74546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21082 - lat) + Math.Abs(8.36583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97545 - lat) + Math.Abs(6.87903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73661 - lat) + Math.Abs(7.01998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37752 - lat) + Math.Abs(8.52127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53557 - lat) + Math.Abs(7.71468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49514 - lat) + Math.Abs(6.39155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43093 - lat) + Math.Abs(9.63448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24185 - lat) + Math.Abs(8.64406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24673 - lat) + Math.Abs(7.61353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86255 - lat) + Math.Abs(8.63036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50555 - lat) + Math.Abs(6.85039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61301 - lat) + Math.Abs(6.62184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15451 - lat) + Math.Abs(8.77327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87606 - lat) + Math.Abs(8.94103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45962 - lat) + Math.Abs(6.20813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30211 - lat) + Math.Abs(9.113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06337 - lat) + Math.Abs(8.52349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77793 - lat) + Math.Abs(9.67621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95909 - lat) + Math.Abs(8.98441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93519 - lat) + Math.Abs(7.66473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49412 - lat) + Math.Abs(7.61979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28692 - lat) + Math.Abs(8.36356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51323 - lat) + Math.Abs(7.76515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20951 - lat) + Math.Abs(7.26012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74733 - lat) + Math.Abs(7.12152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16533 - lat) + Math.Abs(7.43139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51667 - lat) + Math.Abs(9.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2781 - lat) + Math.Abs(7.38542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55237 - lat) + Math.Abs(6.42889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33103 - lat) + Math.Abs(9.40996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27673 - lat) + Math.Abs(6.22204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43855 - lat) + Math.Abs(9.27436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63565 - lat) + Math.Abs(8.59388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6034 - lat) + Math.Abs(9.42614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72754 - lat) + Math.Abs(7.58247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54699 - lat) + Math.Abs(9.29586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14888 - lat) + Math.Abs(9.14233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37766 - lat) + Math.Abs(9.54746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61052 - lat) + Math.Abs(9.2616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19916 - lat) + Math.Abs(7.96964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79587 - lat) + Math.Abs(7.25877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18994 - lat) + Math.Abs(8.83823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88042 - lat) + Math.Abs(8.64441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06954 - lat) + Math.Abs(8.71602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94227 - lat) + Math.Abs(8.2718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55074 - lat) + Math.Abs(7.53599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42542 - lat) + Math.Abs(7.13018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12493 - lat) + Math.Abs(7.63614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51727 - lat) + Math.Abs(7.0567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14998 - lat) + Math.Abs(8.00313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52855 - lat) + Math.Abs(8.61189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3181 - lat) + Math.Abs(6.96457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99863 - lat) + Math.Abs(8.9003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29749 - lat) + Math.Abs(7.66322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27743 - lat) + Math.Abs(8.45128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52581 - lat) + Math.Abs(9.03307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26932 - lat) + Math.Abs(8.48504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65848 - lat) + Math.Abs(7.6965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47104 - lat) + Math.Abs(7.5973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25637 - lat) + Math.Abs(8.2409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30374 - lat) + Math.Abs(7.61052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30997 - lat) + Math.Abs(8.52462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06521 - lat) + Math.Abs(8.36124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49142 - lat) + Math.Abs(7.56031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45473 - lat) + Math.Abs(8.94261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42373 - lat) + Math.Abs(9.32113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23845 - lat) + Math.Abs(7.76854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32067 - lat) + Math.Abs(7.89986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04439 - lat) + Math.Abs(7.27578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39254 - lat) + Math.Abs(8.04422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49204 - lat) + Math.Abs(8.90099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57884 - lat) + Math.Abs(7.64683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19843 - lat) + Math.Abs(6.18642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24706 - lat) + Math.Abs(6.23423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21043 - lat) + Math.Abs(6.23114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18815 - lat) + Math.Abs(6.19904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34152 - lat) + Math.Abs(8.47149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34361 - lat) + Math.Abs(8.48301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46651 - lat) + Math.Abs(7.78502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41438 - lat) + Math.Abs(7.71755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52899 - lat) + Math.Abs(6.56261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28833 - lat) + Math.Abs(8.43124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27324 - lat) + Math.Abs(8.45218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27852 - lat) + Math.Abs(8.44507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27852 - lat) + Math.Abs(8.45651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28277 - lat) + Math.Abs(8.45409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27669 - lat) + Math.Abs(8.45737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28055 - lat) + Math.Abs(8.46008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32419 - lat) + Math.Abs(8.47251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25015 - lat) + Math.Abs(8.53023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29794 - lat) + Math.Abs(8.44833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26197 - lat) + Math.Abs(8.41588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26943 - lat) + Math.Abs(8.42448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26574 - lat) + Math.Abs(8.43013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33197 - lat) + Math.Abs(8.47732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57285 - lat) + Math.Abs(8.64781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68399 - lat) + Math.Abs(8.66086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60058 - lat) + Math.Abs(8.68362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.62571 - lat) + Math.Abs(8.6496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63244 - lat) + Math.Abs(8.79963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63436 - lat) + Math.Abs(8.60852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51761 - lat) + Math.Abs(8.54046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52776 - lat) + Math.Abs(8.54705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52632 - lat) + Math.Abs(8.54106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52337 - lat) + Math.Abs(8.54879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51975 - lat) + Math.Abs(8.53224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51885 - lat) + Math.Abs(8.53682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51716 - lat) + Math.Abs(8.54651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4191 - lat) + Math.Abs(8.62078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57201 - lat) + Math.Abs(8.52695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.504 - lat) + Math.Abs(8.59477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51455 - lat) + Math.Abs(8.59146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51644 - lat) + Math.Abs(8.58712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51178 - lat) + Math.Abs(8.59092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.512 - lat) + Math.Abs(8.59528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53307 - lat) + Math.Abs(8.58455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52262 - lat) + Math.Abs(8.51564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50799 - lat) + Math.Abs(8.51203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50815 - lat) + Math.Abs(8.51542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50399 - lat) + Math.Abs(8.49749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45134 - lat) + Math.Abs(8.58683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46584 - lat) + Math.Abs(8.58145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45399 - lat) + Math.Abs(8.58306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45424 - lat) + Math.Abs(8.59066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45255 - lat) + Math.Abs(8.59464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44642 - lat) + Math.Abs(8.57661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44233 - lat) + Math.Abs(8.57496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4433 - lat) + Math.Abs(8.57925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44455 - lat) + Math.Abs(8.58724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44726 - lat) + Math.Abs(8.58808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45431 - lat) + Math.Abs(8.63477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42908 - lat) + Math.Abs(8.56657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42696 - lat) + Math.Abs(8.57886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42442 - lat) + Math.Abs(8.57658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43424 - lat) + Math.Abs(8.56905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43721 - lat) + Math.Abs(8.56642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41906 - lat) + Math.Abs(8.58586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41446 - lat) + Math.Abs(8.59727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41738 - lat) + Math.Abs(8.60028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40906 - lat) + Math.Abs(8.60345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49193 - lat) + Math.Abs(8.55371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46945 - lat) + Math.Abs(8.40614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46088 - lat) + Math.Abs(8.43555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45726 - lat) + Math.Abs(8.44152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45492 - lat) + Math.Abs(8.43985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43983 - lat) + Math.Abs(8.43813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43844 - lat) + Math.Abs(8.44465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44728 - lat) + Math.Abs(8.40835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44368 - lat) + Math.Abs(8.4097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51096 - lat) + Math.Abs(8.47099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50069 - lat) + Math.Abs(8.47078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49065 - lat) + Math.Abs(8.50048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49518 - lat) + Math.Abs(8.49472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49428 - lat) + Math.Abs(8.50305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48012 - lat) + Math.Abs(8.48576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46941 - lat) + Math.Abs(8.50078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47596 - lat) + Math.Abs(8.51929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4799 - lat) + Math.Abs(8.52471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47143 - lat) + Math.Abs(8.51289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47778 - lat) + Math.Abs(8.50646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43076 - lat) + Math.Abs(8.46898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45329 - lat) + Math.Abs(8.46091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44828 - lat) + Math.Abs(8.47661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44681 - lat) + Math.Abs(8.46641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43525 - lat) + Math.Abs(8.4624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43618 - lat) + Math.Abs(8.46659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44077 - lat) + Math.Abs(8.47846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43373 - lat) + Math.Abs(8.4705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42947 - lat) + Math.Abs(8.46115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42772 - lat) + Math.Abs(8.46566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4494 - lat) + Math.Abs(8.53255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45286 - lat) + Math.Abs(8.52619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4455 - lat) + Math.Abs(8.52612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49284 - lat) + Math.Abs(8.44872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48775 - lat) + Math.Abs(8.45062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55622 - lat) + Math.Abs(8.43851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33969 - lat) + Math.Abs(8.84 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34 - lat) + Math.Abs(8.84918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27103 - lat) + Math.Abs(8.8218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26494 - lat) + Math.Abs(8.85048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27942 - lat) + Math.Abs(8.86162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27655 - lat) + Math.Abs(8.87504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32023 - lat) + Math.Abs(8.75775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31151 - lat) + Math.Abs(8.78339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27632 - lat) + Math.Abs(8.75851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2875 - lat) + Math.Abs(8.85719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25548 - lat) + Math.Abs(8.8449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25368 - lat) + Math.Abs(8.85654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25894 - lat) + Math.Abs(8.86512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26614 - lat) + Math.Abs(8.86712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.265 - lat) + Math.Abs(8.92851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33089 - lat) + Math.Abs(8.78762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33319 - lat) + Math.Abs(8.80982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32852 - lat) + Math.Abs(8.8204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3281 - lat) + Math.Abs(8.79192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31128 - lat) + Math.Abs(8.52675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3202 - lat) + Math.Abs(8.51508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3187 - lat) + Math.Abs(8.52425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31637 - lat) + Math.Abs(8.51888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31554 - lat) + Math.Abs(8.53357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30958 - lat) + Math.Abs(8.52055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31142 - lat) + Math.Abs(8.53446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30811 - lat) + Math.Abs(8.53176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30446 - lat) + Math.Abs(8.5208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30005 - lat) + Math.Abs(8.52204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30285 - lat) + Math.Abs(8.52727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30007 - lat) + Math.Abs(8.52604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32229 - lat) + Math.Abs(8.52172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25604 - lat) + Math.Abs(8.60159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25445 - lat) + Math.Abs(8.61324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24729 - lat) + Math.Abs(8.6066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26584 - lat) + Math.Abs(8.5876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25837 - lat) + Math.Abs(8.59013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33106 - lat) + Math.Abs(8.54225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32728 - lat) + Math.Abs(8.53957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32329 - lat) + Math.Abs(8.54923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32012 - lat) + Math.Abs(8.54306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31773 - lat) + Math.Abs(8.54904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29377 - lat) + Math.Abs(8.53758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28306 - lat) + Math.Abs(8.53386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27242 - lat) + Math.Abs(8.58021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27628 - lat) + Math.Abs(8.57257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20715 - lat) + Math.Abs(8.70607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20323 - lat) + Math.Abs(8.70516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20973 - lat) + Math.Abs(8.69133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30378 - lat) + Math.Abs(8.55427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29047 - lat) + Math.Abs(8.56633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29178 - lat) + Math.Abs(8.55602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29748 - lat) + Math.Abs(8.55634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28495 - lat) + Math.Abs(8.56954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28439 - lat) + Math.Abs(8.5483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22923 - lat) + Math.Abs(8.6722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2473 - lat) + Math.Abs(8.6327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24303 - lat) + Math.Abs(8.64591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23943 - lat) + Math.Abs(8.65741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23367 - lat) + Math.Abs(8.65251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23395 - lat) + Math.Abs(8.66346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22772 - lat) + Math.Abs(8.66303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22364 - lat) + Math.Abs(8.67149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21847 - lat) + Math.Abs(8.6744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22115 - lat) + Math.Abs(8.68385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30531 - lat) + Math.Abs(8.59026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30658 - lat) + Math.Abs(8.60271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30052 - lat) + Math.Abs(8.59489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2995 - lat) + Math.Abs(8.60188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25441 - lat) + Math.Abs(8.77557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24964 - lat) + Math.Abs(8.77218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25354 - lat) + Math.Abs(8.78104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2513 - lat) + Math.Abs(8.77697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31783 - lat) + Math.Abs(8.58303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32729 - lat) + Math.Abs(8.58077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32714 - lat) + Math.Abs(8.60068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32112 - lat) + Math.Abs(8.58881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31307 - lat) + Math.Abs(8.58849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31493 - lat) + Math.Abs(8.59736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25612 - lat) + Math.Abs(8.69161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24636 - lat) + Math.Abs(8.70608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27049 - lat) + Math.Abs(8.65647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27359 - lat) + Math.Abs(8.72065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26628 - lat) + Math.Abs(8.72741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.239 - lat) + Math.Abs(8.73567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23471 - lat) + Math.Abs(8.73857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26654 - lat) + Math.Abs(8.67765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26426 - lat) + Math.Abs(8.68338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33648 - lat) + Math.Abs(8.61528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34726 - lat) + Math.Abs(8.58629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3451 - lat) + Math.Abs(8.60088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37209 - lat) + Math.Abs(8.86816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35865 - lat) + Math.Abs(8.82372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42797 - lat) + Math.Abs(8.69822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42121 - lat) + Math.Abs(8.68557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42142 - lat) + Math.Abs(8.69151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42388 - lat) + Math.Abs(8.69653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45652 - lat) + Math.Abs(8.69428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44345 - lat) + Math.Abs(8.69961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4307 - lat) + Math.Abs(8.67284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36943 - lat) + Math.Abs(8.78309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39853 - lat) + Math.Abs(8.6096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39681 - lat) + Math.Abs(8.60976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39825 - lat) + Math.Abs(8.61458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39502 - lat) + Math.Abs(8.61184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39352 - lat) + Math.Abs(8.6085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3933 - lat) + Math.Abs(8.6149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39531 - lat) + Math.Abs(8.62046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39263 - lat) + Math.Abs(8.61978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39097 - lat) + Math.Abs(8.63155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39491 - lat) + Math.Abs(8.62621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39469 - lat) + Math.Abs(8.63162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39272 - lat) + Math.Abs(8.64653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40109 - lat) + Math.Abs(8.62724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40651 - lat) + Math.Abs(8.62826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40229 - lat) + Math.Abs(8.6228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40464 - lat) + Math.Abs(8.61599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38418 - lat) + Math.Abs(8.59615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30736 - lat) + Math.Abs(8.68339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28325 - lat) + Math.Abs(8.71038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36077 - lat) + Math.Abs(8.63687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37341 - lat) + Math.Abs(8.6773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37042 - lat) + Math.Abs(8.68151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3643 - lat) + Math.Abs(8.68979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35243 - lat) + Math.Abs(8.64107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34868 - lat) + Math.Abs(8.64229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3297 - lat) + Math.Abs(8.6541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32406 - lat) + Math.Abs(8.66002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35635 - lat) + Math.Abs(8.62657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30401 - lat) + Math.Abs(8.72211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31536 - lat) + Math.Abs(8.71828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38592 - lat) + Math.Abs(8.65888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38308 - lat) + Math.Abs(8.64954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38387 - lat) + Math.Abs(8.65677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38151 - lat) + Math.Abs(8.65748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34579 - lat) + Math.Abs(8.71839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34743 - lat) + Math.Abs(8.70088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36016 - lat) + Math.Abs(8.7139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34874 - lat) + Math.Abs(8.73319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34088 - lat) + Math.Abs(8.72555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37099 - lat) + Math.Abs(8.69254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36408 - lat) + Math.Abs(8.74152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33169 - lat) + Math.Abs(8.71266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40644 - lat) + Math.Abs(8.68296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39246 - lat) + Math.Abs(8.6791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38877 - lat) + Math.Abs(8.67482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38713 - lat) + Math.Abs(8.66657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38722 - lat) + Math.Abs(8.68079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38387 - lat) + Math.Abs(8.71763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38385 - lat) + Math.Abs(8.66564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41182 - lat) + Math.Abs(8.64516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55516 - lat) + Math.Abs(8.76671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49265 - lat) + Math.Abs(8.8668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50166 - lat) + Math.Abs(8.86366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50232 - lat) + Math.Abs(8.78724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49898 - lat) + Math.Abs(8.81522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.547 - lat) + Math.Abs(8.70695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54766 - lat) + Math.Abs(8.71572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52654 - lat) + Math.Abs(8.71384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53039 - lat) + Math.Abs(8.73067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53743 - lat) + Math.Abs(8.72915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53345 - lat) + Math.Abs(8.73415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53652 - lat) + Math.Abs(8.74155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52795 - lat) + Math.Abs(8.78209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49951 - lat) + Math.Abs(8.72872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50571 - lat) + Math.Abs(8.73372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49409 - lat) + Math.Abs(8.72334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4934 - lat) + Math.Abs(8.71512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49764 - lat) + Math.Abs(8.71272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50207 - lat) + Math.Abs(8.71625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50596 - lat) + Math.Abs(8.7515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51339 - lat) + Math.Abs(8.75998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49826 - lat) + Math.Abs(8.75723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50977 - lat) + Math.Abs(8.76274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5195 - lat) + Math.Abs(8.7564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48913 - lat) + Math.Abs(8.76034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48446 - lat) + Math.Abs(8.76517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46494 - lat) + Math.Abs(8.77756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48393 - lat) + Math.Abs(8.75586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.481 - lat) + Math.Abs(8.76249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48952 - lat) + Math.Abs(8.7704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48205 - lat) + Math.Abs(8.77289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48135 - lat) + Math.Abs(8.69855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47405 - lat) + Math.Abs(8.7021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49279 - lat) + Math.Abs(8.70223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48727 - lat) + Math.Abs(8.7074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51386 - lat) + Math.Abs(8.71583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50618 - lat) + Math.Abs(8.71563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51097 - lat) + Math.Abs(8.7007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49873 - lat) + Math.Abs(8.69897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51098 - lat) + Math.Abs(8.6929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50904 - lat) + Math.Abs(8.67968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51262 - lat) + Math.Abs(8.684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49419 - lat) + Math.Abs(8.73948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49104 - lat) + Math.Abs(8.75258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48821 - lat) + Math.Abs(8.74938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45748 - lat) + Math.Abs(8.77413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44585 - lat) + Math.Abs(8.79796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36001 - lat) + Math.Abs(8.4605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40819 - lat) + Math.Abs(8.39719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40606 - lat) + Math.Abs(8.40652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40838 - lat) + Math.Abs(8.38752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40477 - lat) + Math.Abs(8.39168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40065 - lat) + Math.Abs(8.39416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39919 - lat) + Math.Abs(8.40146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39374 - lat) + Math.Abs(8.4011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40009 - lat) + Math.Abs(8.40818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39718 - lat) + Math.Abs(8.41609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39706 - lat) + Math.Abs(8.42576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42254 - lat) + Math.Abs(8.40949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4257 - lat) + Math.Abs(8.40884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42057 - lat) + Math.Abs(8.41611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41171 - lat) + Math.Abs(8.41563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40711 - lat) + Math.Abs(8.46276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41211 - lat) + Math.Abs(8.46055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40919 - lat) + Math.Abs(8.45627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40686 - lat) + Math.Abs(8.47254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40514 - lat) + Math.Abs(8.47261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39779 - lat) + Math.Abs(8.4477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40338 - lat) + Math.Abs(8.44352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39489 - lat) + Math.Abs(8.43027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39631 - lat) + Math.Abs(8.43608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39598 - lat) + Math.Abs(8.44202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39358 - lat) + Math.Abs(8.44453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39721 - lat) + Math.Abs(8.45734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39592 - lat) + Math.Abs(8.4612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40069 - lat) + Math.Abs(8.46077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37064 - lat) + Math.Abs(8.45321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37243 - lat) + Math.Abs(8.4559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36332 - lat) + Math.Abs(8.46444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.393 - lat) + Math.Abs(8.41973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3892 - lat) + Math.Abs(8.42265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38977 - lat) + Math.Abs(8.42886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38586 - lat) + Math.Abs(8.42387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38495 - lat) + Math.Abs(8.42763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38703 - lat) + Math.Abs(8.43306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38072 - lat) + Math.Abs(8.42343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3821 - lat) + Math.Abs(8.42845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37924 - lat) + Math.Abs(8.42109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40814 - lat) + Math.Abs(8.41367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41511 - lat) + Math.Abs(8.57014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42476 - lat) + Math.Abs(8.52125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32538 - lat) + Math.Abs(8.51391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33362 - lat) + Math.Abs(8.51433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.364 - lat) + Math.Abs(8.59396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39503 - lat) + Math.Abs(8.52529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41444 - lat) + Math.Abs(8.47928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37161 - lat) + Math.Abs(8.54501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41814 - lat) + Math.Abs(8.5122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36601 - lat) + Math.Abs(8.54594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41127 - lat) + Math.Abs(8.5648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4063 - lat) + Math.Abs(8.57242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40187 - lat) + Math.Abs(8.58633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37188 - lat) + Math.Abs(8.54036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37269 - lat) + Math.Abs(8.53576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3401 - lat) + Math.Abs(8.53134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3605 - lat) + Math.Abs(8.53127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36372 - lat) + Math.Abs(8.50417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37382 - lat) + Math.Abs(8.51164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37178 - lat) + Math.Abs(8.52584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37767 - lat) + Math.Abs(8.52854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38311 - lat) + Math.Abs(8.50942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38481 - lat) + Math.Abs(8.53011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39052 - lat) + Math.Abs(8.51292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3953 - lat) + Math.Abs(8.53721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38917 - lat) + Math.Abs(8.5504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38013 - lat) + Math.Abs(8.56133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37011 - lat) + Math.Abs(8.56306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3624 - lat) + Math.Abs(8.56755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35462 - lat) + Math.Abs(8.55537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35727 - lat) + Math.Abs(8.55744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3525 - lat) + Math.Abs(8.57011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37398 - lat) + Math.Abs(8.49007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38946 - lat) + Math.Abs(8.48533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38213 - lat) + Math.Abs(8.65727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4971 - lat) + Math.Abs(8.45216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24372 - lat) + Math.Abs(8.49692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39227 - lat) + Math.Abs(8.66988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38098 - lat) + Math.Abs(8.59978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55908 - lat) + Math.Abs(8.43344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49494 - lat) + Math.Abs(8.71954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38767 - lat) + Math.Abs(8.52152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44674 - lat) + Math.Abs(8.40648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40372 - lat) + Math.Abs(8.57608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51036 - lat) + Math.Abs(8.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53954 - lat) + Math.Abs(8.78887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57244 - lat) + Math.Abs(8.52093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49066 - lat) + Math.Abs(8.49987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41432 - lat) + Math.Abs(8.41484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34987 - lat) + Math.Abs(8.64013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47646 - lat) + Math.Abs(8.76996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35785 - lat) + Math.Abs(8.50296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42326 - lat) + Math.Abs(8.52166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38245 - lat) + Math.Abs(8.47993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33674 - lat) + Math.Abs(8.44099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51692 - lat) + Math.Abs(8.76863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42213 - lat) + Math.Abs(8.41085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40773 - lat) + Math.Abs(8.5005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33756 - lat) + Math.Abs(8.5211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3548 - lat) + Math.Abs(8.56097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25619 - lat) + Math.Abs(8.7991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5356 - lat) + Math.Abs(8.73209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37055 - lat) + Math.Abs(8.54177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48705 - lat) + Math.Abs(8.74681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37328 - lat) + Math.Abs(8.58038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26574 - lat) + Math.Abs(8.65567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39223 - lat) + Math.Abs(8.54381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50238 - lat) + Math.Abs(8.79874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27464 - lat) + Math.Abs(8.58236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29409 - lat) + Math.Abs(8.56929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70604 - lat) + Math.Abs(8.72241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31375 - lat) + Math.Abs(8.36137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52627 - lat) + Math.Abs(6.47206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46677 - lat) + Math.Abs(9.56643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50513 - lat) + Math.Abs(6.46479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51854 - lat) + Math.Abs(6.52682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28885 - lat) + Math.Abs(8.5411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21974 - lat) + Math.Abs(7.51469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16313 - lat) + Math.Abs(6.14745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18981 - lat) + Math.Abs(6.11441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4099 - lat) + Math.Abs(7.84481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17323 - lat) + Math.Abs(8.80219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91334 - lat) + Math.Abs(7.12556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74025 - lat) + Math.Abs(8.66298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70121 - lat) + Math.Abs(8.55236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50154 - lat) + Math.Abs(8.23122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09247 - lat) + Math.Abs(9.05415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47883 - lat) + Math.Abs(6.84114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20989 - lat) + Math.Abs(9.48931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81201 - lat) + Math.Abs(7.12639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89489 - lat) + Math.Abs(6.93689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19057 - lat) + Math.Abs(6.04287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46396 - lat) + Math.Abs(8.20988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30212 - lat) + Math.Abs(7.53619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41188 - lat) + Math.Abs(7.83716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11412 - lat) + Math.Abs(9.05866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47329 - lat) + Math.Abs(6.79601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62545 - lat) + Math.Abs(6.43713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22168 - lat) + Math.Abs(6.10814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30977 - lat) + Math.Abs(8.32384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84877 - lat) + Math.Abs(6.62763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41641 - lat) + Math.Abs(8.08508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30277 - lat) + Math.Abs(9.1238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51428 - lat) + Math.Abs(6.2598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51606 - lat) + Math.Abs(6.33018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55798 - lat) + Math.Abs(6.33551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60558 - lat) + Math.Abs(6.42074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.607 - lat) + Math.Abs(6.45086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61714 - lat) + Math.Abs(6.47223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64272 - lat) + Math.Abs(6.47661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64914 - lat) + Math.Abs(6.45335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65804 - lat) + Math.Abs(6.4852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66758 - lat) + Math.Abs(6.52639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66699 - lat) + Math.Abs(6.50966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68171 - lat) + Math.Abs(6.6039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68578 - lat) + Math.Abs(6.64793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69337 - lat) + Math.Abs(6.69213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96194 - lat) + Math.Abs(7.11251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01017 - lat) + Math.Abs(6.99941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87548 - lat) + Math.Abs(7.58529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41833 - lat) + Math.Abs(8.31983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27579 - lat) + Math.Abs(8.06581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78593 - lat) + Math.Abs(7.09768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53932 - lat) + Math.Abs(6.62227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44874 - lat) + Math.Abs(8.00273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31439 - lat) + Math.Abs(8.34586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43712 - lat) + Math.Abs(7.81149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5429 - lat) + Math.Abs(8.13516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65312 - lat) + Math.Abs(6.92958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33725 - lat) + Math.Abs(8.47527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29908 - lat) + Math.Abs(8.12242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01902 - lat) + Math.Abs(8.94236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26703 - lat) + Math.Abs(8.48539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69793 - lat) + Math.Abs(7.11094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57096 - lat) + Math.Abs(6.77835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39935 - lat) + Math.Abs(6.17524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50862 - lat) + Math.Abs(9.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79859 - lat) + Math.Abs(6.61094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00252 - lat) + Math.Abs(8.84052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73774 - lat) + Math.Abs(7.5558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89404 - lat) + Math.Abs(7.20531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85846 - lat) + Math.Abs(7.46663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78184 - lat) + Math.Abs(6.67029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97768 - lat) + Math.Abs(6.80835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60647 - lat) + Math.Abs(6.74273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02483 - lat) + Math.Abs(7.67395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13632 - lat) + Math.Abs(7.83226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82975 - lat) + Math.Abs(7.49542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62843 - lat) + Math.Abs(9.4297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74612 - lat) + Math.Abs(6.85929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88049 - lat) + Math.Abs(7.65696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.7321 - lat) + Math.Abs(6.46266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18583 - lat) + Math.Abs(7.83194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23625 - lat) + Math.Abs(7.68991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05684 - lat) + Math.Abs(7.57679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01 - lat) + Math.Abs(9.54472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1887;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zwingen", "BL", 47.43825, 7.53027);
case 1: return new CityInfo("Zweisimmen", "BE", 46.55539, 7.37302);
case 2: return new CityInfo("Zuzwil", "SG", 47.47452, 9.11196);
case 3: return new CityInfo("Zuzgen", "AG", 47.52508, 7.89986);
case 4: return new CityInfo("Bad Zurzach", "AG", 47.58764, 8.29365);
case 5: return new CityInfo("Zürich", "ZH", 47.36667, 8.55);
case 6: return new CityInfo("Zuoz", "GR", 46.60206, 9.95965);
case 7: return new CityInfo("Zunzgen", "BL", 47.44925, 7.80789);
case 8: return new CityInfo("Zumikon", "ZH", 47.33158, 8.62271);
case 9: return new CityInfo("Zullwil", "SO", 47.39108, 7.60047);
case 10: return new CityInfo("Zug", "ZG", 47.17242, 8.51745);
case 11: return new CityInfo("Zuchwil", "SO", 47.20173, 7.56649);
case 12: return new CityInfo("Zollikon", "ZH", 47.34019, 8.57407);
case 13: return new CityInfo("Zollikofen", "BE", 46.99905, 7.45809);
case 14: return new CityInfo("Zofingen", "AG", 47.28779, 7.94586);
case 15: return new CityInfo("Zizers", "GR", 46.93575, 9.56491);
case 16: return new CityInfo("Zimmerwald", "BE", 46.88091, 7.47713);
case 17: return new CityInfo("Zernez", "GR", 46.69862, 10.09268);
case 18: return new CityInfo("Zermatt", "VS", 46.01998, 7.74863);
case 19: return new CityInfo("Zell", "LU", 47.13673, 7.92495);
case 20: return new CityInfo("Zeihen", "AG", 47.47633, 8.08506);
case 21: return new CityInfo("Zeglingen", "BL", 47.41723, 7.90616);
case 22: return new CityInfo("Zäziwil", "BE", 46.90196, 7.66185);
case 23: return new CityInfo("Yvorne", "VD", 46.33122, 6.95872);
case 24: return new CityInfo("Yvonand", "VD", 46.80034, 6.74249);
case 25: return new CityInfo("Yverdon-les-Bains", "VD", 46.77852, 6.64115);
case 26: return new CityInfo("Yens", "VD", 46.51901, 6.4185);
case 27: return new CityInfo("Wyssachen", "BE", 47.07851, 7.82922);
case 28: return new CityInfo("Wynigen", "BE", 47.10586, 7.66681);
case 29: return new CityInfo("Wynau", "BE", 47.2557, 7.81626);
case 30: return new CityInfo("Würenlos", "AG", 47.44205, 8.36261);
case 31: return new CityInfo("Würenlingen", "AG", 47.53356, 8.25666);
case 32: return new CityInfo("Wuppenau", "TG", 47.49633, 9.10904);
case 33: return new CityInfo("Worben", "BE", 47.10279, 7.29518);
case 34: return new CityInfo("Worb", "BE", 46.92984, 7.56306);
case 35: return new CityInfo("Wollerau", "SZ", 47.19478, 8.71903);
case 36: return new CityInfo("Wolhusen", "LU", 47.05983, 8.07389);
case 37: return new CityInfo("Wolfwil", "SO", 47.26871, 7.79652);
case 38: return new CityInfo("Wölflinswil", "AG", 47.4607, 7.99835);
case 39: return new CityInfo("Wolfenschiessen", "NW", 46.90322, 8.39423);
case 40: return new CityInfo("Wohlen", "AG", 47.35066, 8.27517);
case 41: return new CityInfo("Wohlen", "BE", 46.97118, 7.35685);
case 42: return new CityInfo("Wittnau", "AG", 47.48139, 7.97577);
case 43: return new CityInfo("Wittenbach", "SG", 47.46108, 9.38601);
case 44: return new CityInfo("Zürich (Kreis 7) / Witikon", "ZH", 47.35751, 8.59105);
case 45: return new CityInfo("Winterthur", "ZH", 47.50564, 8.72413);
case 46: return new CityInfo("Winikon", "LU", 47.236, 8.04827);
case 47: return new CityInfo("Windisch", "AG", 47.47899, 8.21842);
case 48: return new CityInfo("Wimmis", "BE", 46.67587, 7.63972);
case 49: return new CityInfo("Willisau", "LU", 47.12183, 7.99418);
case 50: return new CityInfo("Wiler", "VS", 46.40315, 7.78161);
case 51: return new CityInfo("Wildhaus", "SG", 47.20583, 9.35402);
case 52: return new CityInfo("Wilderswil", "BE", 46.66369, 7.86175);
case 53: return new CityInfo("Wilchingen", "SH", 47.66745, 8.46774);
case 54: return new CityInfo("Wila", "ZH", 47.41928, 8.84524);
case 55: return new CityInfo("Wil", "ZH", 47.60447, 8.50815);
case 56: return new CityInfo("Wil", "SG", 47.46152, 9.04552);
case 57: return new CityInfo("Wikon", "LU", 47.26339, 7.96801);
case 58: return new CityInfo("Wigoltingen", "TG", 47.5977, 9.03141);
case 59: return new CityInfo("Wiesendangen / Wiesendangen (Dorf)", "ZH", 47.5217, 8.78967);
case 60: return new CityInfo("Wiedlisbach", "BE", 47.25194, 7.6461);
case 61: return new CityInfo("Zürich (Kreis 3) / Alt-Wiedikon", "ZH", 47.36201, 8.51497);
case 62: return new CityInfo("Wetzikon", "ZH", 47.3264, 8.79779);
case 63: return new CityInfo("Wettingen", "AG", 47.47049, 8.31636);
case 64: return new CityInfo("Werthenstein", "LU", 47.05578, 8.10182);
case 65: return new CityInfo("Wernetshausen", "ZH", 47.29914, 8.86462);
case 66: return new CityInfo("Wengi", "BE", 47.08386, 7.39926);
case 67: return new CityInfo("Welschenrohr", "SO", 47.28052, 7.52664);
case 68: return new CityInfo("Weisslingen", "ZH", 47.43063, 8.76787);
case 69: return new CityInfo("Weiningen", "ZH", 47.42022, 8.43644);
case 70: return new CityInfo("Weinfelden", "TG", 47.56667, 9.1);
case 71: return new CityInfo("Weggis", "LU", 47.03208, 8.43219);
case 72: return new CityInfo("Wegenstetten", "AG", 47.49797, 7.93141);
case 73: return new CityInfo("Weesen", "SG", 47.13447, 9.09644);
case 74: return new CityInfo("Wauwil", "LU", 47.18457, 8.021);
case 75: return new CityInfo("Wattwil", "SG", 47.29955, 9.08657);
case 76: return new CityInfo("Wattenwil", "BE", 46.76973, 7.50835);
case 77: return new CityInfo("Wasterkingen", "ZH", 47.58956, 8.47121);
case 78: return new CityInfo("Wängi", "TG", 47.49654, 8.95325);
case 79: return new CityInfo("Wangen an der Aare", "BE", 47.23208, 7.65253);
case 80: return new CityInfo("Wangen", "SO", 47.34365, 7.86982);
case 81: return new CityInfo("Walzenhausen", "AR", 47.44867, 9.60495);
case 82: return new CityInfo("Walterswil", "BE", 47.1122, 7.77798);
case 83: return new CityInfo("Waltenschwil", "AG", 47.33339, 8.29791);
case 84: return new CityInfo("Wallisellen", "ZH", 47.41499, 8.59672);
case 85: return new CityInfo("Walenstadt", "SG", 47.12411, 9.31194);
case 86: return new CityInfo("Walkringen", "BE", 46.94856, 7.6204);
case 87: return new CityInfo("Waldstatt", "AR", 47.35627, 9.28345);
case 88: return new CityInfo("Waldkirch", "SG", 47.46859, 9.28665);
case 89: return new CityInfo("Wäldi", "TG", 47.63421, 9.09504);
case 90: return new CityInfo("Waldenburg", "BL", 47.38333, 7.75);
case 91: return new CityInfo("Wald", "ZH", 47.27595, 8.91405);
case 92: return new CityInfo("Walchwil", "ZG", 47.10169, 8.51693);
case 93: return new CityInfo("Wahlen", "BL", 47.40226, 7.51511);
case 94: return new CityInfo("Wagenhausen", "TG", 47.66003, 8.84782);
case 95: return new CityInfo("Wädenswil", "ZH", 47.22683, 8.6687);
case 96: return new CityInfo("Vuadens", "FR", 46.61545, 7.01732);
case 97: return new CityInfo("Vouvry", "VS", 46.33746, 6.8895);
case 98: return new CityInfo("Vorderthal", "SZ", 47.12172, 8.90225);
case 99: return new CityInfo("Vordemwald", "AG", 47.27585, 7.90114);
case 100: return new CityInfo("Volketswil / Volketswil (Dorf)", "ZH", 47.39016, 8.69085);
case 101: return new CityInfo("Vitznau", "LU", 47.01014, 8.4842);
case 102: return new CityInfo("Visperterminen", "VS", 46.25899, 7.90192);
case 103: return new CityInfo("Visp", "VS", 46.2937, 7.88149);
case 104: return new CityInfo("Vira", "TI", 46.14327, 8.84202);
case 105: return new CityInfo("Vionnaz", "VS", 46.31101, 6.90062);
case 106: return new CityInfo("Villnachern", "AG", 47.47098, 8.15975);
case 107: return new CityInfo("Villmergen", "AG", 47.35009, 8.24762);
case 108: return new CityInfo("Villigen", "AG", 47.52682, 8.21486);
case 109: return new CityInfo("Villeret", "BE", 47.15838, 7.01889);
case 110: return new CityInfo("Villeneuve", "VD", 46.39869, 6.92654);
case 111: return new CityInfo("Villaz-Saint-Pierre", "FR", 46.72074, 6.95638);
case 112: return new CityInfo("Villars-sur-Ollon", "VD", 46.29832, 7.05631);
case 113: return new CityInfo("Villars-sur-Glâne", "FR", 46.79054, 7.11717);
case 114: return new CityInfo("Viganello", "TI", 46.01342, 8.96879);
case 115: return new CityInfo("Vicques", "JU", 47.35, 7.41342);
case 116: return new CityInfo("Veytaux", "VD", 46.42129, 6.93048);
case 117: return new CityInfo("Veyrier", "GE", 46.16699, 6.18436);
case 118: return new CityInfo("Vex", "VS", 46.21239, 7.39826);
case 119: return new CityInfo("Vevey", "VD", 46.46299, 6.84345);
case 120: return new CityInfo("Vétroz", "VS", 46.22171, 7.27858);
case 121: return new CityInfo("Versoix", "GE", 46.28382, 6.16214);
case 122: return new CityInfo("Verscio", "TI", 46.18482, 8.73224);
case 123: return new CityInfo("Vernier", "GE", 46.21702, 6.08497);
case 124: return new CityInfo("Vernayaz", "VS", 46.13667, 7.03906);
case 125: return new CityInfo("Verbier", "VS", 46.1002, 7.22651);
case 126: return new CityInfo("Vendlincourt", "JU", 47.4526, 7.15128);
case 127: return new CityInfo("Veltheim (Kreis 5)", "ZH", 47.51419, 8.717);
case 128: return new CityInfo("Veltheim", "AG", 47.43796, 8.14722);
case 129: return new CityInfo("Vechigen", "BE", 46.94616, 7.56065);
case 130: return new CityInfo("Vaulruz", "FR", 46.62164, 6.9882);
case 131: return new CityInfo("Varen", "VS", 46.3186, 7.60743);
case 132: return new CityInfo("Vandœuvres", "GE", 46.22179, 6.20285);
case 133: return new CityInfo("Vals Platz", "GR", 46.61647, 9.18025);
case 134: return new CityInfo("Vallorbe", "VD", 46.71256, 6.37894);
case 135: return new CityInfo("Uzwil", "SG", 47.43653, 9.13422);
case 136: return new CityInfo("Uznach", "SG", 47.22421, 8.98263);
case 137: return new CityInfo("Utzenstorf", "BE", 47.13248, 7.55355);
case 138: return new CityInfo("Uttwil", "TG", 47.5844, 9.34101);
case 139: return new CityInfo("Uttigen", "BE", 46.79435, 7.57789);
case 140: return new CityInfo("Uster", "ZH", 47.34713, 8.72091);
case 141: return new CityInfo("Urtenen", "BE", 47.02667, 7.50081);
case 142: return new CityInfo("Ursenbach", "BE", 47.13696, 7.77193);
case 143: return new CityInfo("Urnäsch", "AR", 47.31669, 9.2795);
case 144: return new CityInfo("Wetzikon / Unter-Wetzikon", "ZH", 47.31637, 8.79369);
case 145: return new CityInfo("Unterwasser", "SG", 47.197, 9.30856);
case 146: return new CityInfo("Untervaz", "GR", 46.9275, 9.53422);
case 147: return new CityInfo("Unterstammheim", "ZH", 47.63921, 8.79064);
case 148: return new CityInfo("Untersiggenthal", "AG", 47.50213, 8.25554);
case 149: return new CityInfo("Unterseen", "BE", 46.6853, 7.84722);
case 150: return new CityInfo("Unterschächen", "UR", 46.86281, 8.76923);
case 151: return new CityInfo("Unterlunkhofen", "AG", 47.3212, 8.38102);
case 152: return new CityInfo("Unterkulm", "AG", 47.30998, 8.11371);
case 153: return new CityInfo("Illnau / Unter-Illnau", "ZH", 47.40787, 8.72607);
case 154: return new CityInfo("Unteriberg", "SZ", 47.06258, 8.8052);
case 155: return new CityInfo("Unterengstringen", "ZH", 47.41396, 8.44761);
case 156: return new CityInfo("Ehrendingen", "AG", 47.5025, 8.34729);
case 157: return new CityInfo("Unterägeri", "ZG", 47.13645, 8.5853);
case 158: return new CityInfo("Uitikon", "ZH", 47.36911, 8.45699);
case 159: return new CityInfo("Uhwiesen", "ZH", 47.67074, 8.63542);
case 160: return new CityInfo("Ufhusen", "LU", 47.11699, 7.89607);
case 161: return new CityInfo("Uffikon", "LU", 47.21096, 8.01808);
case 162: return new CityInfo("Uetikon", "ZH", 47.26441, 8.67925);
case 163: return new CityInfo("Uetendorf", "BE", 46.77392, 7.57251);
case 164: return new CityInfo("Uerkheim", "AG", 47.30353, 8.0232);
case 165: return new CityInfo("Uerikon", "ZH", 47.23672, 8.7573);
case 166: return new CityInfo("Ueberstorf", "FR", 46.86587, 7.30998);
case 167: return new CityInfo("Udligenswil", "LU", 47.09005, 8.40335);
case 168: return new CityInfo("Twann", "BE", 47.0942, 7.15699);
case 169: return new CityInfo("Turtmann", "VS", 46.30028, 7.702);
case 170: return new CityInfo("Turgi", "AG", 47.49201, 8.25412);
case 171: return new CityInfo("Turbenthal", "ZH", 47.43633, 8.84629);
case 172: return new CityInfo("Tuggen", "SZ", 47.20291, 8.94896);
case 173: return new CityInfo("Trun", "GR", 46.74292, 8.98716);
case 174: return new CityInfo("Trüllikon", "ZH", 47.63539, 8.68919);
case 175: return new CityInfo("Trubschachen", "BE", 46.92228, 7.8452);
case 176: return new CityInfo("Trub", "BE", 46.94168, 7.87996);
case 177: return new CityInfo("Troistorrents", "VS", 46.2289, 6.91589);
case 178: return new CityInfo("Trogen", "AR", 47.40782, 9.46498);
case 179: return new CityInfo("Trimmis", "GR", 46.90075, 9.5612);
case 180: return new CityInfo("Trimbach", "SO", 47.36561, 7.8868);
case 181: return new CityInfo("Triengen", "LU", 47.23573, 8.07652);
case 182: return new CityInfo("Treyvaux", "FR", 46.72796, 7.13769);
case 183: return new CityInfo("Trélex", "VD", 46.41538, 6.20813);
case 184: return new CityInfo("Travers", "NE", 46.94018, 6.67595);
case 185: return new CityInfo("Trasadingen", "SH", 47.66862, 8.42995);
case 186: return new CityInfo("Tramelan", "BE", 47.22298, 7.10287);
case 187: return new CityInfo("Trachselwald", "BE", 47.01699, 7.73639);
case 188: return new CityInfo("Töss (Kreis 4)", "ZH", 47.4789, 8.70215);
case 189: return new CityInfo("Törbel", "VS", 46.23837, 7.85239);
case 190: return new CityInfo("Toffen", "BE", 46.86031, 7.49216);
case 191: return new CityInfo("Tiefencastel", "GR", 46.66014, 9.57883);
case 192: return new CityInfo("Thusis", "GR", 46.69724, 9.43938);
case 193: return new CityInfo("Thundorf", "TG", 47.54594, 8.96358);
case 194: return new CityInfo("Thun", "BE", 46.75118, 7.62166);
case 195: return new CityInfo("Thierrens", "VD", 46.70383, 6.75501);
case 196: return new CityInfo("Thierachern", "BE", 46.75319, 7.57442);
case 197: return new CityInfo("Therwil", "BL", 47.49941, 7.55669);
case 198: return new CityInfo("Thayngen", "SH", 47.74717, 8.70724);
case 199: return new CityInfo("Thalwil", "ZH", 47.29175, 8.56351);
case 200: return new CityInfo("Thalheim", "AG", 47.43534, 8.10027);
case 201: return new CityInfo("Teufenthal", "AG", 47.32896, 8.11777);
case 202: return new CityInfo("Teufen", "AR", 47.3908, 9.38644);
case 203: return new CityInfo("Tesserete", "TI", 46.06813, 8.96501);
case 204: return new CityInfo("Termen", "VS", 46.32688, 8.02097);
case 205: return new CityInfo("Tegerfelden", "AG", 47.55809, 8.28914);
case 206: return new CityInfo("Tecknau", "BL", 47.4491, 7.88491);
case 207: return new CityInfo("Tavannes", "BE", 47.22079, 7.19759);
case 208: return new CityInfo("Täuffelen", "BE", 47.0663, 7.19883);
case 209: return new CityInfo("Täsch", "VS", 46.06838, 7.77766);
case 210: return new CityInfo("Tann", "ZH", 47.26898, 8.85024);
case 211: return new CityInfo("Tanay", "VS", 46.34503, 6.83041);
case 212: return new CityInfo("Tamins", "GR", 46.82964, 9.40648);
case 213: return new CityInfo("Tägerwilen", "TG", 47.65698, 9.13999);
case 214: return new CityInfo("Tafers", "FR", 46.81483, 7.21852);
case 215: return new CityInfo("Sursee", "LU", 47.17088, 8.11113);
case 216: return new CityInfo("Sumiswald", "BE", 47.02747, 7.74526);
case 217: return new CityInfo("Sulz", "AG", 47.53602, 8.09628);
case 218: return new CityInfo("Sulgen", "TG", 47.53967, 9.18585);
case 219: return new CityInfo("Suhr", "AG", 47.37172, 8.07967);
case 220: return new CityInfo("Subingen", "SO", 47.19852, 7.61949);
case 221: return new CityInfo("Strengelbach", "AG", 47.27917, 7.92895);
case 222: return new CityInfo("Stettlen", "BE", 46.95835, 7.52508);
case 223: return new CityInfo("Stettfurt", "TG", 47.52588, 8.95317);
case 224: return new CityInfo("Steinhausen", "ZG", 47.1951, 8.48581);
case 225: return new CityInfo("Steinerberg", "SZ", 47.05484, 8.58584);
case 226: return new CityInfo("Steinen", "SZ", 47.04975, 8.61214);
case 227: return new CityInfo("Stein am Rhein", "SH", 47.65933, 8.85964);
case 228: return new CityInfo("Stein", "AG", 47.54403, 7.95256);
case 229: return new CityInfo("Steffisburg", "BE", 46.77807, 7.63249);
case 230: return new CityInfo("Steckborn", "TG", 47.66667, 8.98333);
case 231: return new CityInfo("Staufen", "AG", 47.38197, 8.16681);
case 232: return new CityInfo("Stansstad", "NW", 46.9768, 8.33553);
case 233: return new CityInfo("Stans", "NW", 46.95805, 8.36609);
case 234: return new CityInfo("Stampa", "GR", 46.3429, 9.59072);
case 235: return new CityInfo("Staldenried", "VS", 46.22937, 7.88269);
case 236: return new CityInfo("Stalden", "VS", 46.23341, 7.87273);
case 237: return new CityInfo("Staffelbach", "AG", 47.28395, 8.04208);
case 238: return new CityInfo("Stäfa", "ZH", 47.24254, 8.72342);
case 239: return new CityInfo("Stadel", "ZH", 47.5294, 8.46353);
case 240: return new CityInfo("Stabio", "TI", 45.84846, 8.93642);
case 241: return new CityInfo("Spreitenbach", "AG", 47.42285, 8.36792);
case 242: return new CityInfo("Spiringen", "UR", 46.87259, 8.73017);
case 243: return new CityInfo("Spiez", "BE", 46.68473, 7.69111);
case 244: return new CityInfo("Speicher", "AR", 47.4109, 9.44335);
case 245: return new CityInfo("Sottens", "VD", 46.65521, 6.74197);
case 246: return new CityInfo("Sorens", "FR", 46.6691, 7.05249);
case 247: return new CityInfo("Sorengo", "TI", 45.99766, 8.93783);
case 248: return new CityInfo("Soral", "GE", 46.14369, 6.04282);
case 249: return new CityInfo("Solothurn", "SO", 47.20791, 7.53714);
case 250: return new CityInfo("Siviriez", "FR", 46.65852, 6.87774);
case 251: return new CityInfo("Sissach", "BL", 47.46408, 7.80888);
case 252: return new CityInfo("Siselen", "BE", 47.03242, 7.18882);
case 253: return new CityInfo("Sirnach", "TG", 47.46222, 8.99763);
case 254: return new CityInfo("Sitten", "VS", 46.22739, 7.35559);
case 255: return new CityInfo("Sins", "AG", 47.19296, 8.39384);
case 256: return new CityInfo("Silvaplana", "GR", 46.4581, 9.79514);
case 257: return new CityInfo("Sils im Domleschg", "GR", 46.70041, 9.45404);
case 258: return new CityInfo("Silenen", "UR", 46.7891, 8.67325);
case 259: return new CityInfo("Sigriswil", "BE", 46.71656, 7.71335);
case 260: return new CityInfo("Signau", "BE", 46.91944, 7.72418);
case 261: return new CityInfo("Siglistorf", "AG", 47.54459, 8.37952);
case 262: return new CityInfo("Sierre", "VS", 46.29192, 7.53559);
case 263: return new CityInfo("Siebnen", "SZ", 47.17449, 8.89781);
case 264: return new CityInfo("Sevelen", "SG", 47.12213, 9.48601);
case 265: return new CityInfo("Seuzach / Seuzach (Dorf)", "ZH", 47.53545, 8.73728);
case 266: return new CityInfo("Sessa", "TI", 45.99855, 8.81968);
case 267: return new CityInfo("Seon", "AG", 47.34848, 8.16072);
case 268: return new CityInfo("Sent", "GR", 46.81717, 10.33683);
case 269: return new CityInfo("Sennwald", "SG", 47.26063, 9.50268);
case 270: return new CityInfo("Seen (Kreis 3) / Sennhof", "ZH", 47.46797, 8.75775);
case 271: return new CityInfo("Semsales", "FR", 46.57321, 6.92948);
case 272: return new CityInfo("Sempach", "LU", 47.13577, 8.19149);
case 273: return new CityInfo("Sementina", "TI", 46.18363, 8.99162);
case 274: return new CityInfo("Sembrancher", "VS", 46.07752, 7.15279);
case 275: return new CityInfo("Selzach", "SO", 47.20531, 7.45521);
case 276: return new CityInfo("Seltisberg", "BL", 47.46249, 7.72039);
case 277: return new CityInfo("Sils-Segl Maria", "GR", 46.42886, 9.76364);
case 278: return new CityInfo("Seftigen", "BE", 46.78765, 7.53937);
case 279: return new CityInfo("Seengen", "AG", 47.32503, 8.20724);
case 280: return new CityInfo("Seelisberg", "UR", 46.97302, 8.58689);
case 281: return new CityInfo("Seedorf", "BE", 47.03445, 7.31249);
case 282: return new CityInfo("Seedorf", "UR", 46.88199, 8.61611);
case 283: return new CityInfo("Seeberg", "BE", 47.15585, 7.66567);
case 284: return new CityInfo("Zürich (Kreis 11) / Seebach", "ZH", 47.42181, 8.54779);
case 285: return new CityInfo("Scuol", "GR", 46.79671, 10.29804);
case 286: return new CityInfo("Schwyz", "SZ", 47.02076, 8.65414);
case 287: return new CityInfo("Schwellbrunn", "AR", 47.35255, 9.24894);
case 288: return new CityInfo("Schwarzenberg", "LU", 47.01705, 8.17261);
case 289: return new CityInfo("Schwanden", "GL", 46.99541, 9.0701);
case 290: return new CityInfo("Schwaderloch", "AG", 47.58541, 8.14455);
case 291: return new CityInfo("Schüpfheim", "LU", 46.95161, 8.01723);
case 292: return new CityInfo("Schüpfen", "BE", 47.03661, 7.37723);
case 293: return new CityInfo("Schübelbach", "SZ", 47.17326, 8.92811);
case 294: return new CityInfo("Schötz", "LU", 47.16896, 7.9887);
case 295: return new CityInfo("Schönholzerswilen", "TG", 47.51702, 9.14089);
case 296: return new CityInfo("Schönenwerd", "SO", 47.3691, 8.00167);
case 297: return new CityInfo("Schönenbuch", "BL", 47.53853, 7.50572);
case 298: return new CityInfo("Schöftland", "AG", 47.3059, 8.05119);
case 299: return new CityInfo("Schnottwil", "SO", 47.11173, 7.39368);
case 300: return new CityInfo("Schmitten", "FR", 46.8575, 7.25031);
case 301: return new CityInfo("Schmerikon", "SG", 47.22538, 8.94836);
case 302: return new CityInfo("Schlossrued", "AG", 47.29155, 8.08809);
case 303: return new CityInfo("Schlieren", "ZH", 47.39668, 8.44763);
case 304: return new CityInfo("Schleitheim", "SH", 47.74818, 8.48213);
case 305: return new CityInfo("Schinznach Dorf", "AG", 47.4465, 8.14089);
case 306: return new CityInfo("Schinznach Bad", "AG", 47.44992, 8.16833);
case 307: return new CityInfo("Schindellegi", "SZ", 47.1746, 8.71345);
case 308: return new CityInfo("Schiers", "GR", 46.96973, 9.6872);
case 309: return new CityInfo("Schenkon", "LU", 47.17765, 8.13204);
case 310: return new CityInfo("Schattdorf", "UR", 46.8655, 8.65465);
case 311: return new CityInfo("Scharans", "GR", 46.71814, 9.45903);
case 312: return new CityInfo("Schänis", "SG", 47.15995, 9.04549);
case 313: return new CityInfo("Schangnau", "BE", 46.82784, 7.85987);
case 314: return new CityInfo("Schafisheim", "AG", 47.37664, 8.14263);
case 315: return new CityInfo("Schaffhausen", "SH", 47.69732, 8.63493);
case 316: return new CityInfo("Scanfs", "GR", 46.61248, 9.98465);
case 317: return new CityInfo("Saxon", "VS", 46.14937, 7.17514);
case 318: return new CityInfo("Savognin", "GR", 46.59732, 9.59816);
case 319: return new CityInfo("Savigny", "VD", 46.53844, 6.73222);
case 320: return new CityInfo("Savièse", "VS", 46.25115, 7.34558);
case 321: return new CityInfo("Sattel", "SZ", 47.08246, 8.63565);
case 322: return new CityInfo("Satigny", "GE", 46.21462, 6.03553);
case 323: return new CityInfo("Sarnen", "OW", 46.89611, 8.24531);
case 324: return new CityInfo("Sarmenstorf", "AG", 47.31109, 8.2495);
case 325: return new CityInfo("Sargans", "SG", 47.04896, 9.44103);
case 326: return new CityInfo("San Vittore", "GR", 46.23709, 9.10684);
case 327: return new CityInfo("Santa Maria in Calanca", "GR", 46.26285, 9.14485);
case 328: return new CityInfo("San Nazzaro", "TI", 46.13161, 8.80262);
case 329: return new CityInfo("Sankt Stephan", "BE", 46.50827, 7.39559);
case 330: return new CityInfo("Sankt Peterzell", "SG", 47.31782, 9.17599);
case 331: return new CityInfo("Sankt Niklaus", "VS", 46.17717, 7.80349);
case 332: return new CityInfo("St. Moritz", "GR", 46.49937, 9.84327);
case 333: return new CityInfo("Sankt Margrethen", "SG", 47.45253, 9.63741);
case 334: return new CityInfo("Sankt Gallenkappel", "SG", 47.24368, 8.96438);
case 335: return new CityInfo("Sankt Gallen", "SG", 47.42391, 9.37477);
case 336: return new CityInfo("Sankt Antoni", "FR", 46.82207, 7.26091);
case 337: return new CityInfo("Samstagern", "ZH", 47.19167, 8.68196);
case 338: return new CityInfo("Samnaun", "GR", 46.94373, 10.36058);
case 339: return new CityInfo("Samedan", "GR", 46.53399, 9.87276);
case 340: return new CityInfo("Salvan", "VS", 46.1189, 7.02078);
case 341: return new CityInfo("Salmsach", "TG", 47.55433, 9.37229);
case 342: return new CityInfo("Salgesch", "VS", 46.31155, 7.5712);
case 343: return new CityInfo("Sâles", "FR", 46.63473, 6.97336);
case 344: return new CityInfo("Saland", "ZH", 47.39069, 8.85294);
case 345: return new CityInfo("Saint-Ursanne", "JU", 47.36474, 7.15436);
case 346: return new CityInfo("Saint-Sulpice", "NE", 46.91111, 6.56219);
case 347: return new CityInfo("Saint-Prex", "VD", 46.47963, 6.45992);
case 348: return new CityInfo("Saint-Maurice", "VS", 46.21826, 7.0032);
case 349: return new CityInfo("Saint-Martin", "VS", 46.1727, 7.44427);
case 350: return new CityInfo("Saint-Livres", "VD", 46.50794, 6.38753);
case 351: return new CityInfo("Saint-Léonard", "VS", 46.25152, 7.41714);
case 352: return new CityInfo("Saint-Imier", "BE", 47.15284, 6.99692);
case 353: return new CityInfo("Saint-Gingolph", "VS", 46.39217, 6.80594);
case 354: return new CityInfo("Sainte-Croix", "VD", 46.82203, 6.50283);
case 355: return new CityInfo("Saint-Cergue", "VD", 46.4459, 6.15737);
case 356: return new CityInfo("Saint-Blaise", "NE", 47.01511, 6.98832);
case 357: return new CityInfo("Saint-Aubin-Sauges", "NE", 46.89419, 6.77251);
case 358: return new CityInfo("Saillon", "VS", 46.17035, 7.18771);
case 359: return new CityInfo("Saignelégier", "JU", 47.25619, 6.99648);
case 360: return new CityInfo("Saicourt", "BE", 47.24339, 7.20607);
case 361: return new CityInfo("Safenwil", "AG", 47.32163, 7.98254);
case 362: return new CityInfo("Sachseln", "OW", 46.86718, 8.23344);
case 363: return new CityInfo("Saas-Grund", "VS", 46.12281, 7.93651);
case 364: return new CityInfo("Saas-Fee", "VS", 46.10805, 7.92741);
case 365: return new CityInfo("Saas im Prättigau", "GR", 46.91018, 9.80865);
case 366: return new CityInfo("Saanen", "BE", 46.48945, 7.26003);
case 367: return new CityInfo("Rüti", "ZH", 47.25603, 8.85552);
case 368: return new CityInfo("Rüthi", "SG", 47.2948, 9.53857);
case 369: return new CityInfo("Ruswil", "LU", 47.08425, 8.12645);
case 370: return new CityInfo("Russikon", "ZH", 47.39669, 8.77515);
case 371: return new CityInfo("Rüschlikon", "ZH", 47.30688, 8.55135);
case 372: return new CityInfo("Rüschegg", "BE", 46.77977, 7.39167);
case 373: return new CityInfo("Rupperswil", "AG", 47.40131, 8.12877);
case 374: return new CityInfo("Rünenberg", "BL", 47.43349, 7.88255);
case 375: return new CityInfo("Rümlang", "ZH", 47.45041, 8.52993);
case 376: return new CityInfo("Rueun", "GR", 46.77783, 9.1484);
case 377: return new CityInfo("Rüeggisberg", "BE", 46.82216, 7.4389);
case 378: return new CityInfo("Rue", "FR", 46.61916, 6.82225);
case 379: return new CityInfo("Rudolfstetten", "AG", 47.37101, 8.38083);
case 380: return new CityInfo("Rüderswil", "BE", 46.98374, 7.72167);
case 381: return new CityInfo("Rubigen", "BE", 46.89868, 7.5446);
case 382: return new CityInfo("Rovio", "TI", 45.93309, 8.98699);
case 383: return new CityInfo("Rougemont", "VD", 46.48811, 7.20659);
case 384: return new CityInfo("Rotkreuz", "ZG", 47.14283, 8.4314);
case 385: return new CityInfo("Rothrist", "AG", 47.30508, 7.89196);
case 386: return new CityInfo("Rothenthurm", "SZ", 47.1042, 8.67585);
case 387: return new CityInfo("Rossinière", "VD", 46.46757, 7.08368);
case 388: return new CityInfo("Röschenz", "BL", 47.42366, 7.48024);
case 389: return new CityInfo("Rorschach", "SG", 47.478, 9.4903);
case 390: return new CityInfo("Rorbas", "ZH", 47.53092, 8.57555);
case 391: return new CityInfo("Root", "LU", 47.11458, 8.39021);
case 392: return new CityInfo("Ronco sopra Ascona", "TI", 46.14624, 8.72793);
case 393: return new CityInfo("Romont", "FR", 46.69652, 6.91898);
case 394: return new CityInfo("Römerswil", "LU", 47.16881, 8.24528);
case 395: return new CityInfo("Romanshorn", "TG", 47.56586, 9.37869);
case 396: return new CityInfo("Romanel-sur-Lausanne", "VD", 46.56403, 6.60538);
case 397: return new CityInfo("Rolle", "VD", 46.4582, 6.33499);
case 398: return new CityInfo("Rohrbach", "BE", 47.13521, 7.81334);
case 399: return new CityInfo("Rohr", "SO", 47.41029, 7.95333);
case 400: return new CityInfo("Roggwil", "TG", 47.49981, 9.3958);
case 401: return new CityInfo("Roggwil", "BE", 47.24119, 7.82141);
case 402: return new CityInfo("Rodersdorf", "SO", 47.48082, 7.45767);
case 403: return new CityInfo("Roche", "VD", 46.36091, 6.93272);
case 404: return new CityInfo("Riva San Vitale", "TI", 45.90123, 8.97167);
case 405: return new CityInfo("Ringgenberg", "BE", 46.70114, 7.89445);
case 406: return new CityInfo("Effretikon / Rikon", "ZH", 47.43099, 8.68624);
case 407: return new CityInfo("Riggisberg", "BE", 46.81028, 7.48014);
case 408: return new CityInfo("Riedholz", "SO", 47.23158, 7.56829);
case 409: return new CityInfo("Riddes", "VS", 46.17276, 7.2236);
case 410: return new CityInfo("Rickenbach", "ZH", 47.55191, 8.79654);
case 411: return new CityInfo("Rickenbach bei Wil", "TG", 47.44856, 9.04902);
case 412: return new CityInfo("Richterswil", "ZH", 47.20622, 8.69686);
case 413: return new CityInfo("Richenthal", "LU", 47.21757, 7.94459);
case 414: return new CityInfo("Riaz", "FR", 46.64224, 7.06183);
case 415: return new CityInfo("Rheinfelden", "AG", 47.55437, 7.79403);
case 416: return new CityInfo("Rheineck", "SG", 47.4663, 9.59028);
case 417: return new CityInfo("Rhäzüns", "GR", 46.79891, 9.39764);
case 418: return new CityInfo("Reutigen", "BE", 46.69363, 7.62102);
case 419: return new CityInfo("Renens", "VD", 46.53989, 6.5881);
case 420: return new CityInfo("Rekingen", "AG", 47.57187, 8.31782);
case 421: return new CityInfo("Reinach", "AG", 47.25732, 8.18091);
case 422: return new CityInfo("Reigoldswil", "BL", 47.39824, 7.68718);
case 423: return new CityInfo("Reiden", "LU", 47.24719, 7.97135);
case 424: return new CityInfo("Reichenburg", "SZ", 47.17097, 8.97704);
case 425: return new CityInfo("Rehetobel", "AR", 47.42611, 9.483);
case 426: return new CityInfo("Regensdorf", "ZH", 47.4341, 8.46874);
case 427: return new CityInfo("Reconvilier", "BE", 47.23431, 7.22239);
case 428: return new CityInfo("Rechthalten", "FR", 46.76766, 7.24028);
case 429: return new CityInfo("Rebstein", "SG", 47.39812, 9.58503);
case 430: return new CityInfo("Elsau-Räterschen / Räterschen", "ZH", 47.49927, 8.796);
case 431: return new CityInfo("Raron", "VS", 46.31196, 7.80029);
case 432: return new CityInfo("Rapperswil", "SG", 47.22557, 8.82228);
case 433: return new CityInfo("Randogne", "VS", 46.30952, 7.50058);
case 434: return new CityInfo("Ramsen", "SH", 47.70797, 8.80949);
case 435: return new CityInfo("Rämismühle", "ZH", 47.43932, 8.82166);
case 436: return new CityInfo("Rafz", "ZH", 47.60438, 8.54305);
case 437: return new CityInfo("Radelfingen", "BE", 47.02146, 7.27178);
case 438: return new CityInfo("Quarten", "SG", 47.107, 9.24199);
case 439: return new CityInfo("Pura", "TI", 45.98647, 8.86877);
case 440: return new CityInfo("Pully", "VD", 46.51027, 6.66183);
case 441: return new CityInfo("Puidoux", "VD", 46.50093, 6.78249);
case 442: return new CityInfo("Promontogno", "GR", 46.33939, 9.55759);
case 443: return new CityInfo("Prilly", "VD", 46.53698, 6.60456);
case 444: return new CityInfo("Presinge", "GE", 46.21975, 6.25517);
case 445: return new CityInfo("Pregassona", "TI", 46.02021, 8.97429);
case 446: return new CityInfo("Pratteln", "BL", 47.52071, 7.69356);
case 447: return new CityInfo("Praroman", "FR", 46.75145, 7.17778);
case 448: return new CityInfo("Prangins", "VD", 46.39518, 6.2496);
case 449: return new CityInfo("Poschiavo", "GR", 46.32441, 10.05823);
case 450: return new CityInfo("Porrentruy", "JU", 47.41728, 7.07573);
case 451: return new CityInfo("Pontresina", "GR", 46.4955, 9.90126);
case 452: return new CityInfo("Ponthaux", "FR", 46.81527, 7.04142);
case 453: return new CityInfo("La Punt Chamues-ch", "GR", 46.57887, 9.92015);
case 454: return new CityInfo("Plasselb", "FR", 46.73488, 7.25119);
case 455: return new CityInfo("Plan-les-Ouates", "GE", 46.16789, 6.11664);
case 456: return new CityInfo("Plaffeien", "FR", 46.74198, 7.28666);
case 457: return new CityInfo("Pieterlen", "BE", 47.17501, 7.33791);
case 458: return new CityInfo("Pianezzo", "TI", 46.17006, 9.02522);
case 459: return new CityInfo("Pfyn", "TG", 47.59693, 8.9542);
case 460: return new CityInfo("Pfungen", "ZH", 47.51394, 8.6423);
case 461: return new CityInfo("Pfaffhausen", "ZH", 47.36476, 8.62375);
case 462: return new CityInfo("Pfeffingen", "BL", 47.45984, 7.58975);
case 463: return new CityInfo("Pfeffikon", "LU", 47.24836, 8.17752);
case 464: return new CityInfo("Pfaffnau", "LU", 47.22772, 7.89719);
case 465: return new CityInfo("Pfäffikon", "ZH", 47.36453, 8.79202);
case 466: return new CityInfo("Pfäffikon", "SZ", 47.20109, 8.77816);
case 467: return new CityInfo("Peseux", "NE", 46.98704, 6.88903);
case 468: return new CityInfo("Péry", "BE", 47.19398, 7.24913);
case 469: return new CityInfo("Perroy", "VD", 46.4669, 6.35349);
case 470: return new CityInfo("Perrefitte", "BE", 47.27568, 7.34161);
case 471: return new CityInfo("Penthalaz", "VD", 46.61077, 6.52519);
case 472: return new CityInfo("Payerne", "VD", 46.82192, 6.93817);
case 473: return new CityInfo("Paudex", "VD", 46.50548, 6.66819);
case 474: return new CityInfo("Pampigny", "VD", 46.58093, 6.42941);
case 475: return new CityInfo("Palézieux", "VD", 46.54191, 6.83989);
case 476: return new CityInfo("Pailly", "VD", 46.70123, 6.6754);
case 477: return new CityInfo("Ottenbach", "ZH", 47.28228, 8.40432);
case 478: return new CityInfo("Othmarsingen", "AG", 47.40125, 8.21383);
case 479: return new CityInfo("Otelfingen", "ZH", 47.46053, 8.39141);
case 480: return new CityInfo("Ostermundigen", "BE", 46.95694, 7.49019);
case 481: return new CityInfo("Ossingen", "ZH", 47.61175, 8.72781);
case 482: return new CityInfo("Osogna", "TI", 46.31208, 8.98579);
case 483: return new CityInfo("Orvin", "BE", 47.16068, 7.21368);
case 484: return new CityInfo("Orsières", "VS", 46.02903, 7.14437);
case 485: return new CityInfo("Orpund", "BE", 47.13891, 7.30775);
case 486: return new CityInfo("Oron-la-Ville", "VD", 46.57094, 6.82557);
case 487: return new CityInfo("Ormalingen", "BL", 47.46936, 7.87248);
case 488: return new CityInfo("Orbe", "VD", 46.72504, 6.53069);
case 489: return new CityInfo("Opfikon", "ZH", 47.43169, 8.57588);
case 490: return new CityInfo("Onex", "GE", 46.18396, 6.10237);
case 491: return new CityInfo("Olten", "SO", 47.34999, 7.90329);
case 492: return new CityInfo("Ollon", "VD", 46.29524, 6.99314);
case 493: return new CityInfo("Oftringen", "AG", 47.31382, 7.92533);
case 494: return new CityInfo("Oetwil / Oetwil an der Limmat", "ZH", 47.42832, 8.39491);
case 495: return new CityInfo("Oetwil", "ZH", 47.27049, 8.72023);
case 496: return new CityInfo("Zürich (Kreis 11) / Oerlikon", "ZH", 47.40823, 8.54258);
case 497: return new CityInfo("Oensingen", "SO", 47.28764, 7.71612);
case 498: return new CityInfo("Ochlenberg", "BE", 47.14953, 7.73603);
case 499: return new CityInfo("Obfelden", "ZH", 47.26413, 8.4215);
case 500: return new CityInfo("Oberwil", "BL", 47.51407, 7.55786);
case 501: return new CityInfo("Wetzikon / Ober-Wetzikon", "ZH", 47.32514, 8.80005);
case 502: return new CityInfo("Oberweningen", "ZH", 47.50226, 8.40702);
case 503: return new CityInfo("Oberuzwil", "SG", 47.43076, 9.12724);
case 504: return new CityInfo("Urdorf", "ZH", 47.38507, 8.42581);
case 505: return new CityInfo("Obersiggenthal", "AG", 47.4875, 8.29652);
case 506: return new CityInfo("Oberschrot", "FR", 46.74126, 7.28149);
case 507: return new CityInfo("Obersaxen", "GR", 46.75, 9.1);
case 508: return new CityInfo("Oberrüti", "AG", 47.16673, 8.39441);
case 509: return new CityInfo("Oberriet", "SG", 47.32088, 9.56808);
case 510: return new CityInfo("Oberrieden", "ZH", 47.27444, 8.57838);
case 511: return new CityInfo("Oberönz", "BE", 47.17793, 7.69489);
case 512: return new CityInfo("Oberneuforn", "TG", 47.60477, 8.76709);
case 513: return new CityInfo("Oberlunkhofen", "AG", 47.31244, 8.39242);
case 514: return new CityInfo("Oberkirch", "LU", 47.15642, 8.11567);
case 515: return new CityInfo("Illnau / Ober-Illnau", "ZH", 47.41474, 8.71644);
case 516: return new CityInfo("Oberiberg", "SZ", 47.0384, 8.77917);
case 517: return new CityInfo("Oberhelfenschwil", "SG", 47.35673, 9.11076);
case 518: return new CityInfo("Obergösgen", "SO", 47.36538, 7.95173);
case 519: return new CityInfo("Oberglatt", "ZH", 47.47576, 8.51896);
case 520: return new CityInfo("Oberentfelden", "AG", 47.35639, 8.04594);
case 521: return new CityInfo("Oberengstringen", "ZH", 47.40841, 8.46515);
case 522: return new CityInfo("Endingen", "AG", 47.53742, 8.29036);
case 523: return new CityInfo("Oberembrach", "ZH", 47.4878, 8.61828);
case 524: return new CityInfo("Oberegg", "AI", 47.42531, 9.55134);
case 525: return new CityInfo("Oberdorf", "BL", 47.39353, 7.75169);
case 526: return new CityInfo("Oberdiessbach", "BE", 46.84117, 7.6173);
case 527: return new CityInfo("Oberburg", "BE", 47.03665, 7.62745);
case 528: return new CityInfo("Oberbuchsiten", "SO", 47.31334, 7.76836);
case 529: return new CityInfo("Oberbipp", "BE", 47.2607, 7.66359);
case 530: return new CityInfo("Oberbalm", "BE", 46.87363, 7.4028);
case 531: return new CityInfo("Nyon", "VD", 46.38318, 6.23955);
case 532: return new CityInfo("Nürensdorf", "ZH", 47.44814, 8.64908);
case 533: return new CityInfo("Nunningen", "SO", 47.3941, 7.61951);
case 534: return new CityInfo("Novazzano", "TI", 45.84073, 8.98236);
case 535: return new CityInfo("Novaggio", "TI", 46.0102, 8.8561);
case 536: return new CityInfo("Nottwil", "LU", 47.13469, 8.13774);
case 537: return new CityInfo("Noréaz", "FR", 46.80145, 7.02784);
case 538: return new CityInfo("Noiraigue", "NE", 46.95622, 6.72462);
case 539: return new CityInfo("Nods", "BE", 47.11487, 7.08014);
case 540: return new CityInfo("Wichtrach", "BE", 46.8501, 7.57748);
case 541: return new CityInfo("Niederweningen / Niederweningen (Dorf)", "ZH", 47.50614, 8.37711);
case 542: return new CityInfo("Niederurnen", "GL", 47.12598, 9.05428);
case 543: return new CityInfo("Niederrohrdorf", "AG", 47.42409, 8.30404);
case 544: return new CityInfo("Niederlenz", "AG", 47.40079, 8.1764);
case 545: return new CityInfo("Niederhelfenschwil", "SG", 47.47487, 9.18543);
case 546: return new CityInfo("Niedergösgen", "SO", 47.37157, 7.98837);
case 547: return new CityInfo("Niedergesteln", "VS", 46.31243, 7.78364);
case 548: return new CityInfo("Erlinsbach", "SO", 47.39753, 8.00797);
case 549: return new CityInfo("Niederbüren", "SG", 47.46547, 9.20568);
case 550: return new CityInfo("Niederbuchsiten", "SO", 47.29646, 7.7718);
case 551: return new CityInfo("Niederbipp", "BE", 47.27175, 7.69583);
case 552: return new CityInfo("Nidau", "BE", 47.12545, 7.24033);
case 553: return new CityInfo("Neunkirch", "SH", 47.69012, 8.49981);
case 554: return new CityInfo("Neuhausen", "SH", 47.68579, 8.61474);
case 555: return new CityInfo("Neuenkirch", "LU", 47.09989, 8.20416);
case 556: return new CityInfo("Neuenhof", "AG", 47.44985, 8.32682);
case 557: return new CityInfo("Neudorf", "LU", 47.17699, 8.20911);
case 558: return new CityInfo("Neuchâtel", "NE", 46.99179, 6.931);
case 559: return new CityInfo("Netstal", "GL", 47.06337, 9.05734);
case 560: return new CityInfo("Neftenbach / Dorf Neftenbach", "ZH", 47.52764, 8.6649);
case 561: return new CityInfo("Nebikon", "LU", 47.19185, 7.97769);
case 562: return new CityInfo("Naters", "VS", 46.32536, 7.98912);
case 563: return new CityInfo("Nänikon", "ZH", 47.36975, 8.68894);
case 564: return new CityInfo("Näfels", "GL", 47.09775, 9.06361);
case 565: return new CityInfo("Muttenz", "BL", 47.52271, 7.64511);
case 566: return new CityInfo("Müstair", "GR", 46.62683, 10.44624);
case 567: return new CityInfo("Murten/Morat", "FR", 46.92827, 7.11715);
case 568: return new CityInfo("Muri", "AG", 47.27428, 8.33854);
case 569: return new CityInfo("Muri", "BE", 46.93122, 7.48658);
case 570: return new CityInfo("Murgenthal", "AG", 47.27145, 7.83935);
case 571: return new CityInfo("Muotathal", "SZ", 46.97676, 8.76499);
case 572: return new CityInfo("Muolen", "SG", 47.52102, 9.32484);
case 573: return new CityInfo("Müntschemier", "BE", 46.99548, 7.14626);
case 574: return new CityInfo("Münsterlingen", "TG", 47.63197, 9.23271);
case 575: return new CityInfo("Münsingen", "BE", 46.87298, 7.561);
case 576: return new CityInfo("Mund", "VS", 46.31504, 7.94123);
case 577: return new CityInfo("Münchwilen", "TG", 47.47719, 8.99677);
case 578: return new CityInfo("Münchenstein", "BL", 47.51848, 7.60966);
case 579: return new CityInfo("Münchenbuchsee", "BE", 47.02175, 7.45036);
case 580: return new CityInfo("Mumpf", "AG", 47.54563, 7.92123);
case 581: return new CityInfo("Müllheim", "TG", 47.60195, 9.00357);
case 582: return new CityInfo("Mühlethurnen", "BE", 46.81345, 7.50881);
case 583: return new CityInfo("Mühleberg", "BE", 46.95466, 7.26102);
case 584: return new CityInfo("Mühlau", "AG", 47.22902, 8.38898);
case 585: return new CityInfo("Muhen", "AG", 47.33578, 8.05536);
case 586: return new CityInfo("Moutier", "BE", 47.27818, 7.36951);
case 587: return new CityInfo("Moudon", "VD", 46.66758, 6.79781);
case 588: return new CityInfo("Môtiers", "NE", 46.91108, 6.61111);
case 589: return new CityInfo("Mosnang", "SG", 47.36252, 9.04296);
case 590: return new CityInfo("Mörschwil", "SG", 47.47097, 9.42278);
case 591: return new CityInfo("Morschach", "SZ", 46.98271, 8.61826);
case 592: return new CityInfo("Mörigen", "BE", 47.0851, 7.21413);
case 593: return new CityInfo("Morgins", "VS", 46.239, 6.852);
case 594: return new CityInfo("Morges", "VD", 46.51127, 6.49854);
case 595: return new CityInfo("Morcote", "TI", 45.925, 8.916);
case 596: return new CityInfo("Morbio Superiore", "TI", 45.86004, 9.02318);
case 597: return new CityInfo("Morbio Inferiore", "TI", 45.84915, 9.01907);
case 598: return new CityInfo("Montricher", "VD", 46.59956, 6.37668);
case 599: return new CityInfo("Montreux", "VD", 46.43301, 6.91143);
case 600: return new CityInfo("Monthey", "VS", 46.25451, 6.95406);
case 601: return new CityInfo("Monte Carasso", "TI", 46.18649, 8.99892);
case 602: return new CityInfo("Montana", "VS", 46.31338, 7.48839);
case 603: return new CityInfo("Montagny", "VD", 46.79289, 6.61222);
case 604: return new CityInfo("Montagnola", "TI", 45.98323, 8.91786);
case 605: return new CityInfo("Mönchaltorf", "ZH", 47.30958, 8.72029);
case 606: return new CityInfo("Mollis", "GL", 47.08878, 9.07242);
case 607: return new CityInfo("Mollens", "VD", 46.5776, 6.3632);
case 608: return new CityInfo("Möhlin", "AG", 47.55915, 7.84329);
case 609: return new CityInfo("Mogelsberg", "SG", 47.36222, 9.13541);
case 610: return new CityInfo("Minusio", "TI", 46.17769, 8.81473);
case 611: return new CityInfo("Miège", "VS", 46.31119, 7.54701);
case 612: return new CityInfo("Mézières", "FR", 46.67958, 6.9263);
case 613: return new CityInfo("Meyrin", "GE", 46.23424, 6.08025);
case 614: return new CityInfo("Mex", "VS", 46.18548, 7.00004);
case 615: return new CityInfo("Mettmenstetten", "ZH", 47.24529, 8.46347);
case 616: return new CityInfo("Messen", "SO", 47.09155, 7.44528);
case 617: return new CityInfo("Mesocco", "GR", 46.3939, 9.23333);
case 618: return new CityInfo("Mervelier", "JU", 47.34368, 7.49988);
case 619: return new CityInfo("Merishausen", "SH", 47.7601, 8.61053);
case 620: return new CityInfo("Merenschwand", "AG", 47.25944, 8.37633);
case 621: return new CityInfo("Menznau", "LU", 47.08364, 8.03971);
case 622: return new CityInfo("Menzingen", "ZG", 47.17764, 8.59215);
case 623: return new CityInfo("Menziken", "AG", 47.23965, 8.18996);
case 624: return new CityInfo("Mendrisio", "TI", 45.87019, 8.9816);
case 625: return new CityInfo("Mellingen", "AG", 47.41903, 8.27331);
case 626: return new CityInfo("Melide", "TI", 45.95455, 8.94725);
case 627: return new CityInfo("Melchnau", "BE", 47.18213, 7.85128);
case 628: return new CityInfo("Melano", "TI", 45.92202, 8.98435);
case 629: return new CityInfo("Meisterschwanden", "AG", 47.29489, 8.22867);
case 630: return new CityInfo("Meiringen", "BE", 46.72709, 8.1872);
case 631: return new CityInfo("Meinisberg", "BE", 47.15965, 7.34801);
case 632: return new CityInfo("Meilen", "ZH", 47.27232, 8.64617);
case 633: return new CityInfo("Meierskappel", "LU", 47.1247, 8.44274);
case 634: return new CityInfo("Meggen", "LU", 47.04691, 8.37467);
case 635: return new CityInfo("Mauensee", "LU", 47.16703, 8.06793);
case 636: return new CityInfo("Matzingen", "TG", 47.51957, 8.93365);
case 637: return new CityInfo("Matzendorf", "SO", 47.30374, 7.6282);
case 638: return new CityInfo("Matten", "BE", 46.67833, 7.86889);
case 639: return new CityInfo("Mastrils", "GR", 46.96974, 9.54463);
case 640: return new CityInfo("Massagno", "TI", 46.01257, 8.94354);
case 641: return new CityInfo("Martigny-Ville", "VS", 46.10276, 7.07245);
case 642: return new CityInfo("Martigny-Combe", "VS", 46.07817, 7.05099);
case 643: return new CityInfo("Marthalen", "ZH", 47.62913, 8.65326);
case 644: return new CityInfo("Märstetten-Dorf", "TG", 47.59252, 9.06851);
case 645: return new CityInfo("Marsens", "FR", 46.65644, 7.05948);
case 646: return new CityInfo("Marly", "FR", 46.77611, 7.16459);
case 647: return new CityInfo("Maracon", "VD", 46.55009, 6.87217);
case 648: return new CityInfo("Männedorf", "ZH", 47.25686, 8.69893);
case 649: return new CityInfo("Mammern", "TG", 47.64625, 8.91519);
case 650: return new CityInfo("Malvaglia", "TI", 46.40588, 8.9819);
case 651: return new CityInfo("Malters", "LU", 47.03628, 8.18193);
case 652: return new CityInfo("Malleray", "BE", 47.23839, 7.27286);
case 653: return new CityInfo("Malix", "GR", 46.81248, 9.53196);
case 654: return new CityInfo("Malans", "GR", 46.98096, 9.57527);
case 655: return new CityInfo("Maisprach", "BL", 47.52468, 7.84537);
case 656: return new CityInfo("Maienfeld", "GR", 47.00472, 9.53115);
case 657: return new CityInfo("Magglingen", "BE", 47.139, 7.21407);
case 658: return new CityInfo("Maggia", "TI", 46.24689, 8.7062);
case 659: return new CityInfo("Magden", "AG", 47.52868, 7.81128);
case 660: return new CityInfo("Magadino", "TI", 46.14892, 8.8561);
case 661: return new CityInfo("Madiswil", "BE", 47.16463, 7.79858);
case 662: return new CityInfo("Lyssach", "BE", 47.06445, 7.58228);
case 663: return new CityInfo("Lyss", "BE", 47.0741, 7.30655);
case 664: return new CityInfo("Luzern", "LU", 47.05048, 8.30635);
case 665: return new CityInfo("Luzein", "GR", 46.91957, 9.7608);
case 666: return new CityInfo("Lützelflüh", "BE", 47.00757, 7.69165);
case 667: return new CityInfo("Lutry", "VD", 46.50241, 6.68647);
case 668: return new CityInfo("Lütisburg", "SG", 47.39451, 9.08312);
case 669: return new CityInfo("Luthern", "LU", 47.05753, 7.91692);
case 670: return new CityInfo("Luterbach", "SO", 47.21426, 7.58463);
case 671: return new CityInfo("Lungern", "OW", 46.78578, 8.15984);
case 672: return new CityInfo("Lumino", "TI", 46.2302, 9.0642);
case 673: return new CityInfo("Lully", "FR", 46.83401, 6.84534);
case 674: return new CityInfo("Lugano", "TI", 46.01008, 8.96004);
case 675: return new CityInfo("Luchsingen", "GL", 46.9664, 9.03715);
case 676: return new CityInfo("Lucens", "VD", 46.70854, 6.83931);
case 677: return new CityInfo("Lotzwil", "BE", 47.19135, 7.79102);
case 678: return new CityInfo("Lostorf", "SO", 47.38372, 7.94655);
case 679: return new CityInfo("Lostallo", "GR", 46.31301, 9.19663);
case 680: return new CityInfo("Losone", "TI", 46.16866, 8.75928);
case 681: return new CityInfo("Lommis", "TG", 47.51729, 8.99669);
case 682: return new CityInfo("Lohn", "SH", 47.75508, 8.66847);
case 683: return new CityInfo("Lodrino", "TI", 46.30016, 8.97986);
case 684: return new CityInfo("Locarno", "TI", 46.17086, 8.79953);
case 685: return new CityInfo("Littau", "LU", 47.05, 8.26274);
case 686: return new CityInfo("Linthal", "GL", 46.92127, 8.99799);
case 687: return new CityInfo("Linden", "BE", 46.8469, 7.67831);
case 688: return new CityInfo("Lindau", "ZH", 47.44299, 8.67362);
case 689: return new CityInfo("Ligornetto", "TI", 45.86161, 8.95166);
case 690: return new CityInfo("Lignières", "NE", 47.08331, 7.06592);
case 691: return new CityInfo("Ligerz", "BE", 47.08368, 7.13476);
case 692: return new CityInfo("Liestal", "BL", 47.48455, 7.73446);
case 693: return new CityInfo("Liesberg", "BL", 47.40398, 7.42787);
case 694: return new CityInfo("Liebistorf", "FR", 46.90881, 7.19636);
case 695: return new CityInfo("Liddes", "VS", 45.99249, 7.18729);
case 696: return new CityInfo("Lichtensteig", "SG", 47.32381, 9.08758);
case 697: return new CityInfo("Leytron", "VS", 46.1866, 7.2078);
case 698: return new CityInfo("Leysin", "VD", 46.34183, 7.01151);
case 699: return new CityInfo("Le Vaud", "VD", 46.47753, 6.23603);
case 700: return new CityInfo("Leuzigen", "BE", 47.17458, 7.45775);
case 701: return new CityInfo("Leutwil", "AG", 47.30969, 8.17309);
case 702: return new CityInfo("Leukerbad", "VS", 46.37943, 7.62687);
case 703: return new CityInfo("Leuk", "VS", 46.31736, 7.63412);
case 704: return new CityInfo("Les Verrières", "NE", 46.90413, 6.48039);
case 705: return new CityInfo("Les Ponts-de-Martel", "NE", 46.99735, 6.73059);
case 706: return new CityInfo("Les Geneveys-sur-Coffrane", "NE", 47.01528, 6.8513);
case 707: return new CityInfo("Les Breuleux", "JU", 47.21099, 7.00792);
case 708: return new CityInfo("Les Brenets", "NE", 47.06774, 6.70478);
case 709: return new CityInfo("Les Bois", "JU", 47.17715, 6.90498);
case 710: return new CityInfo("Lenzerheide", "GR", 46.72215, 9.55905);
case 711: return new CityInfo("Lenzburg", "AG", 47.38853, 8.17503);
case 712: return new CityInfo("Lens", "VS", 46.28298, 7.44976);
case 713: return new CityInfo("Le Noirmont", "JU", 47.22464, 6.95784);
case 714: return new CityInfo("Lenk", "BE", 46.45826, 7.44298);
case 715: return new CityInfo("Lengnau", "BE", 47.18155, 7.36814);
case 716: return new CityInfo("Le Mont-sur-Lausanne", "VD", 46.55815, 6.63145);
case 717: return new CityInfo("Le Locle", "NE", 47.05619, 6.74913);
case 718: return new CityInfo("Le Landeron", "NE", 47.05702, 7.07052);
case 719: return new CityInfo("Leissigen", "BE", 46.6546, 7.77548);
case 720: return new CityInfo("Leibstadt", "AG", 47.5879, 8.17611);
case 721: return new CityInfo("Le Chenit", "VD", 46.60688, 6.23062);
case 722: return new CityInfo("Léchelles", "FR", 46.82896, 7.01621);
case 723: return new CityInfo("Lavertezzo", "TI", 46.25893, 8.83756);
case 724: return new CityInfo("Lauterbrunnen", "BE", 46.59307, 7.90938);
case 725: return new CityInfo("Lausen", "BL", 47.47139, 7.7603);
case 726: return new CityInfo("Lausanne", "VD", 46.516, 6.63282);
case 727: return new CityInfo("Lauperswil", "BE", 46.96564, 7.74214);
case 728: return new CityInfo("Laupersdorf", "SO", 47.3126, 7.65465);
case 729: return new CityInfo("Laupen", "BE", 46.90214, 7.23973);
case 730: return new CityInfo("Laufenburg", "AG", 47.55985, 8.06225);
case 731: return new CityInfo("Laufen", "BL", 47.42193, 7.49946);
case 732: return new CityInfo("Läufelfingen", "BL", 47.39457, 7.85578);
case 733: return new CityInfo("Lauerz", "SZ", 47.03327, 8.58339);
case 734: return new CityInfo("La Tour-de-Trême", "FR", 46.61061, 7.06496);
case 735: return new CityInfo("La Tour-de-Peilz", "VD", 46.45312, 6.85856);
case 736: return new CityInfo("La Sarraz", "VD", 46.65863, 6.51077);
case 737: return new CityInfo("La Sagne", "NE", 47.04591, 6.80946);
case 738: return new CityInfo("La Roche", "FR", 46.6962, 7.13721);
case 739: return new CityInfo("Langrickenbach", "TG", 47.59353, 9.24727);
case 740: return new CityInfo("Langnau / Langnau (Dorf)", "ZH", 47.28643, 8.53627);
case 741: return new CityInfo("Langnau", "BE", 46.93936, 7.78738);
case 742: return new CityInfo("Langenthal", "BE", 47.21526, 7.79607);
case 743: return new CityInfo("Langenbruck", "BL", 47.34917, 7.76802);
case 744: return new CityInfo("La Neuveville", "BE", 47.06592, 7.09717);
case 745: return new CityInfo("Landquart", "GR", 46.95, 9.56667);
case 746: return new CityInfo("Landiswil", "BE", 46.95802, 7.67952);
case 747: return new CityInfo("Lamboing", "BE", 47.11682, 7.13476);
case 748: return new CityInfo("Lalden", "VS", 46.29951, 7.90235);
case 749: return new CityInfo("Lajoux", "JU", 47.27893, 7.13726);
case 750: return new CityInfo("La Côte-aux-Fées", "NE", 46.86744, 6.49043);
case 751: return new CityInfo("St-Légier-La Chiésaz", "VD", 46.47227, 6.87366);
case 752: return new CityInfo("Lachen", "SZ", 47.19224, 8.85324);
case 753: return new CityInfo("La Chaux-de-Fonds", "NE", 47.09993, 6.82586);
case 754: return new CityInfo("La Brévine", "NE", 46.98055, 6.60639);
case 755: return new CityInfo("L'Abbaye", "VD", 46.64966, 6.31907);
case 756: return new CityInfo("Laax", "GR", 46.80452, 9.25787);
case 757: return new CityInfo("Küttigen", "AG", 47.41484, 8.04979);
case 758: return new CityInfo("Küssnacht", "SZ", 47.08557, 8.44206);
case 759: return new CityInfo("Küsnacht", "ZH", 47.31805, 8.58401);
case 760: return new CityInfo("Künten", "AG", 47.38887, 8.33045);
case 761: return new CityInfo("Küblis", "GR", 46.91446, 9.77929);
case 762: return new CityInfo("Krummenau", "SG", 47.24755, 9.17064);
case 763: return new CityInfo("Kriens", "LU", 47.0311, 8.28547);
case 764: return new CityInfo("Kriegstetten", "SO", 47.17449, 7.59799);
case 765: return new CityInfo("Kreuzlingen", "TG", 47.65051, 9.17504);
case 766: return new CityInfo("Krauchthal", "BE", 47.00964, 7.5664);
case 767: return new CityInfo("Krattigen", "BE", 46.66139, 7.72777);
case 768: return new CityInfo("Koppigen", "BE", 47.13125, 7.60525);
case 769: return new CityInfo("Konolfingen", "BE", 46.87909, 7.62013);
case 770: return new CityInfo("Köniz", "BE", 46.92436, 7.41457);
case 771: return new CityInfo("Kölliken", "AG", 47.33337, 8.02237);
case 772: return new CityInfo("Kollbrunn", "ZH", 47.45793, 8.78295);
case 773: return new CityInfo("Koblenz", "AG", 47.60972, 8.2375);
case 774: return new CityInfo("Knutwil", "LU", 47.19953, 8.07315);
case 775: return new CityInfo("Knonau", "ZH", 47.2235, 8.46197);
case 776: return new CityInfo("Kloten", "ZH", 47.45152, 8.58491);
case 777: return new CityInfo("Klosters Serneus", "GR", 46.88918, 9.83826);
case 778: return new CityInfo("Klingnau", "AG", 47.58361, 8.2488);
case 779: return new CityInfo("Kleinlützel", "SO", 47.42518, 7.41607);
case 780: return new CityInfo("Kleindietwil", "BE", 47.14571, 7.78965);
case 781: return new CityInfo("Kirchlindach", "BE", 46.99965, 7.41735);
case 782: return new CityInfo("Kirchdorf", "BE", 46.82085, 7.54847);
case 783: return new CityInfo("Kirchberg", "SG", 47.41159, 9.0402);
case 784: return new CityInfo("Kirchberg", "BE", 47.08538, 7.58288);
case 785: return new CityInfo("Killwangen", "AG", 47.43223, 8.35097);
case 786: return new CityInfo("Kilchberg", "ZH", 47.32438, 8.54548);
case 787: return new CityInfo("Kiesen", "BE", 46.81956, 7.58402);
case 788: return new CityInfo("Kesswil", "TG", 47.5935, 9.31723);
case 789: return new CityInfo("Kerzers", "FR", 46.97586, 7.1957);
case 790: return new CityInfo("Kerns", "OW", 46.90121, 8.27514);
case 791: return new CityInfo("Kehrsatz", "BE", 46.91035, 7.47096);
case 792: return new CityInfo("Kappelen", "BE", 47.06015, 7.2686);
case 793: return new CityInfo("Kandersteg", "BE", 46.49467, 7.67326);
case 794: return new CityInfo("Kandergrund", "BE", 46.56212, 7.659);
case 795: return new CityInfo("Kaltbrunn", "SG", 47.21367, 9.0259);
case 796: return new CityInfo("Kallnach", "BE", 47.02032, 7.23545);
case 797: return new CityInfo("Kaisten", "AG", 47.5416, 8.04337);
case 798: return new CityInfo("Kaiseraugst", "AG", 47.53966, 7.72605);
case 799: return new CityInfo("Jussy", "GE", 46.2359, 6.26701);
case 800: return new CityInfo("Jonschwil", "SG", 47.42402, 9.08689);
case 801: return new CityInfo("Jonen", "AG", 47.2975, 8.39282);
case 802: return new CityInfo("Jona", "SG", 47.22983, 8.83884);
case 803: return new CityInfo("Jeuss", "FR", 46.90405, 7.16272);
case 804: return new CityInfo("Jenins", "GR", 47.00149, 9.55657);
case 805: return new CityInfo("Jenaz", "GR", 46.92892, 9.71275);
case 806: return new CityInfo("Jegenstorf", "BE", 47.04802, 7.50787);
case 807: return new CityInfo("Jaun", "FR", 46.61131, 7.27593);
case 808: return new CityInfo("Iserables", "VS", 46.16228, 7.24474);
case 809: return new CityInfo("Isenthal", "UR", 46.91079, 8.56121);
case 810: return new CityInfo("Pfäffikon / Irgenhausen", "ZH", 47.3624, 8.79265);
case 811: return new CityInfo("Iragna", "TI", 46.32571, 8.96656);
case 812: return new CityInfo("Inwil", "LU", 47.1253, 8.34885);
case 813: return new CityInfo("Intragna", "TI", 46.17751, 8.70016);
case 814: return new CityInfo("Interlaken", "BE", 46.68387, 7.86638);
case 815: return new CityInfo("Ins", "BE", 47.00584, 7.10609);
case 816: return new CityInfo("Ingenbohl", "SZ", 46.9988, 8.61529);
case 817: return new CityInfo("Illnau", "ZH", 47.4113, 8.72125);
case 818: return new CityInfo("Illgau", "SZ", 46.98764, 8.72509);
case 819: return new CityInfo("Ilanz", "GR", 46.77413, 9.20461);
case 820: return new CityInfo("Igis", "GR", 46.94531, 9.57218);
case 821: return new CityInfo("Ibach", "SZ", 47.01105, 8.64538);
case 822: return new CityInfo("Hüttwilen", "TG", 47.60674, 8.87343);
case 823: return new CityInfo("Huttwil", "BE", 47.11502, 7.86209);
case 824: return new CityInfo("Hüttlingen", "TG", 47.57803, 8.98081);
case 825: return new CityInfo("Hüntwangen", "ZH", 47.59576, 8.49116);
case 826: return new CityInfo("Hünenberg", "ZG", 47.17536, 8.42497);
case 827: return new CityInfo("Hundwil", "AR", 47.36464, 9.31847);
case 828: return new CityInfo("Horw", "LU", 47.01692, 8.30956);
case 829: return new CityInfo("Hornussen", "AG", 47.5001, 8.06275);
case 830: return new CityInfo("Horn", "SG", 47.49425, 9.46246);
case 831: return new CityInfo("Horgen", "ZH", 47.25983, 8.59778);
case 832: return new CityInfo("Zürich (Kreis 10) / Höngg", "ZH", 47.40313, 8.4971);
case 833: return new CityInfo("Homburg", "TG", 47.63469, 9.00756);
case 834: return new CityInfo("Hombrechtikon", "ZH", 47.25298, 8.77212);
case 835: return new CityInfo("Hölstein", "BL", 47.4229, 7.77041);
case 836: return new CityInfo("Holderbank", "SO", 47.33315, 7.75257);
case 837: return new CityInfo("Hohenrain", "LU", 47.18083, 8.31802);
case 838: return new CityInfo("Hochwald", "SO", 47.45389, 7.64459);
case 839: return new CityInfo("Hochdorf", "LU", 47.16841, 8.29179);
case 840: return new CityInfo("Hitzkirch", "LU", 47.22403, 8.26425);
case 841: return new CityInfo("Hittnau / Hittnau (Dorf)", "ZH", 47.36334, 8.82418);
case 842: return new CityInfo("Hinwil", "ZH", 47.29426, 8.84393);
case 843: return new CityInfo("Hinterrhein", "GR", 46.53333, 9.2);
case 844: return new CityInfo("Hindelbank", "BE", 47.0427, 7.54143);
case 845: return new CityInfo("Himmelried", "SO", 47.42136, 7.59985);
case 846: return new CityInfo("Hilterfingen", "BE", 46.73521, 7.66185);
case 847: return new CityInfo("Hildisrieden", "LU", 47.15068, 8.22582);
case 848: return new CityInfo("Hettlingen", "ZH", 47.5461, 8.70532);
case 849: return new CityInfo("Herzogenbuchsee", "BE", 47.18795, 7.7062);
case 850: return new CityInfo("Herrliberg", "ZH", 47.29064, 8.61464);
case 851: return new CityInfo("Hermiswil", "BE", 46.83125, 7.47775);
case 852: return new CityInfo("Hermance", "GE", 46.30141, 6.24332);
case 853: return new CityInfo("Herisau", "AR", 47.38615, 9.27916);
case 854: return new CityInfo("Hergiswil", "NW", 46.98429, 8.30944);
case 855: return new CityInfo("Hérémence", "VS", 46.18032, 7.40477);
case 856: return new CityInfo("Herdern", "TG", 47.60304, 8.91077);
case 857: return new CityInfo("Herbetswil", "SO", 47.29629, 7.59298);
case 858: return new CityInfo("Henggart", "ZH", 47.56272, 8.68215);
case 859: return new CityInfo("Hendschiken", "AG", 47.38596, 8.21785);
case 860: return new CityInfo("Hemmental", "SH", 47.73378, 8.5853);
case 861: return new CityInfo("Hemberg", "SG", 47.30062, 9.17517);
case 862: return new CityInfo("Heitenried", "FR", 46.82762, 7.29944);
case 863: return new CityInfo("Heimiswil", "BE", 47.06755, 7.66665);
case 864: return new CityInfo("Heimberg", "BE", 46.79482, 7.60433);
case 865: return new CityInfo("Heiligenschwendi", "BE", 46.75109, 7.68391);
case 866: return new CityInfo("Heiden", "AR", 47.44255, 9.53293);
case 867: return new CityInfo("Oberwinterthur (Kreis 2) / Hegi", "ZH", 47.50716, 8.77057);
case 868: return new CityInfo("Hauteville", "FR", 46.67009, 7.11041);
case 869: return new CityInfo("Hausen am Albis / Hausen (Dorf)", "ZH", 47.24496, 8.53299);
case 870: return new CityInfo("Haslen", "AI", 47.36931, 9.36752);
case 871: return new CityInfo("Hasle", "LU", 46.97787, 8.05326);
case 872: return new CityInfo("Hallau", "SH", 47.69648, 8.45827);
case 873: return new CityInfo("Haldenstein", "GR", 46.87867, 9.52618);
case 874: return new CityInfo("Hägglingen", "AG", 47.38851, 8.25285);
case 875: return new CityInfo("Häggenschwil", "SG", 47.49462, 9.34487);
case 876: return new CityInfo("Hägendorf", "SO", 47.33497, 7.84133);
case 877: return new CityInfo("Hagenbuch", "ZH", 47.52035, 8.8892);
case 878: return new CityInfo("Habkern", "BE", 46.72639, 7.86304);
case 879: return new CityInfo("Güttingen", "TG", 47.60349, 9.28742);
case 880: return new CityInfo("Gurtnellen", "UR", 46.73814, 8.62843);
case 881: return new CityInfo("Gunzwil", "LU", 47.21072, 8.17932);
case 882: return new CityInfo("Gunzgen", "SO", 47.31375, 7.83102);
case 883: return new CityInfo("Guggisberg", "BE", 46.76756, 7.32946);
case 884: return new CityInfo("Gsteig", "BE", 46.66509, 7.87299);
case 885: return new CityInfo("Gstaad", "BE", 46.47215, 7.28685);
case 886: return new CityInfo("Gryon", "VD", 46.27377, 7.05975);
case 887: return new CityInfo("Gruyères", "FR", 46.58338, 7.08207);
case 888: return new CityInfo("Grüsch", "GR", 46.97965, 9.64639);
case 889: return new CityInfo("Grosswangen", "LU", 47.1331, 8.05041);
case 890: return new CityInfo("Andelfingen", "ZH", 47.59447, 8.67826);
case 891: return new CityInfo("Grossaffoltern", "BE", 47.06534, 7.35689);
case 892: return new CityInfo("Grono", "GR", 46.24832, 9.14829);
case 893: return new CityInfo("Grône", "VS", 46.25288, 7.45947);
case 894: return new CityInfo("Grolley", "FR", 46.8336, 7.07116);
case 895: return new CityInfo("Grindelwald", "BE", 46.62396, 8.03601);
case 896: return new CityInfo("Grimisuat", "VS", 46.25938, 7.38408);
case 897: return new CityInfo("Greppen", "LU", 47.05438, 8.42995);
case 898: return new CityInfo("Grenchen", "SO", 47.1921, 7.39586);
case 899: return new CityInfo("Grellingen", "BL", 47.44231, 7.58906);
case 900: return new CityInfo("Greifensee", "ZH", 47.36717, 8.68115);
case 901: return new CityInfo("Gravesano", "TI", 46.04208, 8.91832);
case 902: return new CityInfo("Gränichen", "AG", 47.3593, 8.10243);
case 903: return new CityInfo("Granges", "VD", 46.76233, 6.88808);
case 904: return new CityInfo("Grandvillard", "FR", 46.53899, 7.08575);
case 905: return new CityInfo("Grandson", "VD", 46.80946, 6.646);
case 906: return new CityInfo("Grand-Savagnier", "NE", 47.05101, 6.95489);
case 907: return new CityInfo("Le Grand-Saconnex", "GE", 46.23188, 6.12091);
case 908: return new CityInfo("Grandcour", "VD", 46.87185, 6.9284);
case 909: return new CityInfo("Grancy", "VD", 46.59214, 6.46391);
case 910: return new CityInfo("Grächen", "VS", 46.19529, 7.83745);
case 911: return new CityInfo("Grabs", "SG", 47.18248, 9.44395);
case 912: return new CityInfo("Goumoens-la-Ville", "VD", 46.65922, 6.60398);
case 913: return new CityInfo("Gottlieben", "TG", 47.6638, 9.13371);
case 914: return new CityInfo("Gossau", "SG", 47.41551, 9.25482);
case 915: return new CityInfo("Gossau", "ZH", 47.3051, 8.75831);
case 916: return new CityInfo("Gorgier", "NE", 46.90143, 6.77985);
case 917: return new CityInfo("Gorduno", "TI", 46.21631, 9.03076);
case 918: return new CityInfo("Gordola", "TI", 46.18256, 8.86657);
case 919: return new CityInfo("Gordevio", "TI", 46.22604, 8.74309);
case 920: return new CityInfo("Gontenschwil", "AG", 47.27166, 8.14396);
case 921: return new CityInfo("Gonten", "AI", 47.32725, 9.34705);
case 922: return new CityInfo("Gondiswil", "BE", 47.14677, 7.87136);
case 923: return new CityInfo("Gommiswald", "SG", 47.23128, 9.02355);
case 924: return new CityInfo("Gollion", "VD", 46.58518, 6.50974);
case 925: return new CityInfo("Goldingen", "SG", 47.26477, 8.96167);
case 926: return new CityInfo("Goldau", "SZ", 47.04761, 8.54616);
case 927: return new CityInfo("Goldach", "SG", 47.47401, 9.46711);
case 928: return new CityInfo("Gnosca", "TI", 46.23353, 9.02218);
case 929: return new CityInfo("Glovelier", "JU", 47.33534, 7.20556);
case 930: return new CityInfo("Glattfelden", "ZH", 47.55871, 8.50167);
case 931: return new CityInfo("Glattbrugg", "ZH", 47.4313, 8.56272);
case 932: return new CityInfo("Glarus", "GL", 47.04057, 9.06804);
case 933: return new CityInfo("Gland", "VD", 46.42082, 6.2701);
case 934: return new CityInfo("Giubiasco", "TI", 46.17246, 9.00793);
case 935: return new CityInfo("Giswil", "OW", 46.83333, 8.18065);
case 936: return new CityInfo("Gipf-Oberfrick", "AG", 47.49875, 8.00497);
case 937: return new CityInfo("Giornico", "TI", 46.40141, 8.87369);
case 938: return new CityInfo("Gingins", "VD", 46.4091, 6.17809);
case 939: return new CityInfo("Gimel", "VD", 46.50945, 6.30736);
case 940: return new CityInfo("Gilly", "VD", 46.45785, 6.29654);
case 941: return new CityInfo("Giffers", "FR", 46.7623, 7.20845);
case 942: return new CityInfo("Geuensee", "LU", 47.1997, 8.10689);
case 943: return new CityInfo("Gettnau", "LU", 47.14064, 7.97007);
case 944: return new CityInfo("Gerzensee", "BE", 46.84023, 7.54503);
case 945: return new CityInfo("Gersau", "SZ", 46.99419, 8.525);
case 946: return new CityInfo("Gerlafingen", "SO", 47.17087, 7.57249);
case 947: return new CityInfo("Genolier", "VD", 46.43537, 6.21809);
case 948: return new CityInfo("Genève", "GE", 46.20222, 6.14569);
case 949: return new CityInfo("Genestrerio", "TI", 45.85333, 8.96115);
case 950: return new CityInfo("Gempen", "SO", 47.47585, 7.66028);
case 951: return new CityInfo("Gelterkinden", "BL", 47.46497, 7.85174);
case 952: return new CityInfo("Gelfingen", "LU", 47.21447, 8.26537);
case 953: return new CityInfo("Gebenstorf", "AG", 47.48136, 8.23949);
case 954: return new CityInfo("Ganterschwil", "SG", 47.38103, 9.09239);
case 955: return new CityInfo("Gams", "SG", 47.20429, 9.44172);
case 956: return new CityInfo("Gampelen", "BE", 47.01199, 7.05771);
case 957: return new CityInfo("Gampel", "VS", 46.31599, 7.7421);
case 958: return new CityInfo("Gals", "BE", 47.02841, 7.05183);
case 959: return new CityInfo("Galmiz", "FR", 46.94875, 7.15804);
case 960: return new CityInfo("Gais", "AR", 47.3615, 9.45356);
case 961: return new CityInfo("Gachnang", "TG", 47.53935, 8.85311);
case 962: return new CityInfo("Gächlingen", "SH", 47.70329, 8.49878);
case 963: return new CityInfo("Fully", "VS", 46.13851, 7.11468);
case 964: return new CityInfo("Füllinsdorf", "BL", 47.50688, 7.73129);
case 965: return new CityInfo("Fulenbach", "SO", 47.27103, 7.83136);
case 966: return new CityInfo("Frutigen", "BE", 46.58723, 7.64945);
case 967: return new CityInfo("Froideville", "VD", 46.60123, 6.68085);
case 968: return new CityInfo("Frick", "AG", 47.51169, 8.02471);
case 969: return new CityInfo("Fribourg", "FR", 46.80237, 7.15128);
case 970: return new CityInfo("Frenkendorf", "BL", 47.50686, 7.71648);
case 971: return new CityInfo("Freienbach", "SZ", 47.20534, 8.75842);
case 972: return new CityInfo("Frauenkappelen", "BE", 46.95425, 7.33835);
case 973: return new CityInfo("Frauenfeld", "TG", 47.55776, 8.89893);
case 974: return new CityInfo("Fraubrunnen", "BE", 47.0862, 7.52727);
case 975: return new CityInfo("Founex", "VD", 46.33277, 6.19243);
case 976: return new CityInfo("Fontenais", "JU", 47.40292, 7.08108);
case 977: return new CityInfo("Fontainemelon", "NE", 47.05495, 6.8868);
case 978: return new CityInfo("Flurlingen", "ZH", 47.6839, 8.62995);
case 979: return new CityInfo("Flums", "SG", 47.09058, 9.34301);
case 980: return new CityInfo("Flühli", "LU", 46.88391, 8.01558);
case 981: return new CityInfo("Flüelen", "UR", 46.90478, 8.62396);
case 982: return new CityInfo("Flims", "GR", 46.83705, 9.28458);
case 983: return new CityInfo("Fleurier", "NE", 46.90224, 6.58253);
case 984: return new CityInfo("Flawil", "SG", 47.41301, 9.18324);
case 985: return new CityInfo("Fläsch", "GR", 47.02567, 9.51365);
case 986: return new CityInfo("Flamatt", "FR", 46.88994, 7.32204);
case 987: return new CityInfo("Flaach", "ZH", 47.57608, 8.60633);
case 988: return new CityInfo("Fischingen", "TG", 47.41422, 8.96862);
case 989: return new CityInfo("Filzbach", "GL", 47.11897, 9.13239);
case 990: return new CityInfo("Filisur", "GR", 46.67303, 9.68592);
case 991: return new CityInfo("Fiesch", "VS", 46.39981, 8.13533);
case 992: return new CityInfo("Fideris", "GR", 46.91627, 9.74145);
case 993: return new CityInfo("Feusisberg", "SZ", 47.18707, 8.74724);
case 994: return new CityInfo("Feuerthalen", "ZH", 47.69054, 8.64357);
case 995: return new CityInfo("Ferenbalm", "BE", 46.9488, 7.21124);
case 996: return new CityInfo("Felsberg", "GR", 46.84566, 9.47588);
case 997: return new CityInfo("Feldmeilen", "ZH", 47.27873, 8.62165);
case 998: return new CityInfo("Fehraltorf", "ZH", 47.38775, 8.75149);
case 999: return new CityInfo("Faoug", "VD", 46.90829, 7.07803);
case 1000: return new CityInfo("Fällanden", "ZH", 47.37169, 8.63869);
case 1001: return new CityInfo("Falera", "GR", 46.80131, 9.23086);
case 1002: return new CityInfo("Faido", "TI", 46.477, 8.80125);
case 1003: return new CityInfo("Fahrni", "BE", 46.79401, 7.65502);
case 1004: return new CityInfo("Eysins", "VD", 46.3817, 6.20695);
case 1005: return new CityInfo("Evolène", "VS", 46.11422, 7.49407);
case 1006: return new CityInfo("Evionnaz", "VS", 46.18096, 7.02232);
case 1007: return new CityInfo("Evilard", "BE", 47.15046, 7.23895);
case 1008: return new CityInfo("Ettiswil", "LU", 47.15031, 8.01759);
case 1009: return new CityInfo("Ettingen", "BL", 47.48225, 7.54654);
case 1010: return new CityInfo("Estavayer-le-Lac", "FR", 46.84876, 6.8465);
case 1011: return new CityInfo("Escholzmatt", "LU", 46.9135, 7.93426);
case 1012: return new CityInfo("Eschlikon", "TG", 47.46361, 8.96381);
case 1013: return new CityInfo("Eschenz", "TG", 47.64793, 8.87472);
case 1014: return new CityInfo("Eschenbach", "SG", 47.23981, 8.92156);
case 1015: return new CityInfo("Erstfeld", "UR", 46.81885, 8.65052);
case 1016: return new CityInfo("Ersigen", "BE", 47.09368, 7.59507);
case 1017: return new CityInfo("Erschwil", "SO", 47.37415, 7.54116);
case 1018: return new CityInfo("Ermatingen", "TG", 47.67057, 9.08573);
case 1019: return new CityInfo("Erlenbach im Simmental", "BE", 46.66021, 7.55445);
case 1020: return new CityInfo("Erlenbach", "ZH", 47.30298, 8.59743);
case 1021: return new CityInfo("Erlen", "TG", 47.54814, 9.23415);
case 1022: return new CityInfo("Erlach", "BE", 47.0422, 7.09728);
case 1023: return new CityInfo("Eriz", "BE", 46.78773, 7.77102);
case 1024: return new CityInfo("Eriswil", "BE", 47.07816, 7.85149);
case 1025: return new CityInfo("Ependes", "FR", 46.75368, 7.14609);
case 1026: return new CityInfo("Epalinges", "VD", 46.54896, 6.66831);
case 1027: return new CityInfo("Entlebuch", "LU", 46.99559, 8.06354);
case 1028: return new CityInfo("Enney", "FR", 46.56669, 7.08418);
case 1029: return new CityInfo("Ennetbürgen", "NW", 46.98423, 8.41003);
case 1030: return new CityInfo("Ennenda", "GL", 47.03363, 9.07888);
case 1031: return new CityInfo("Engi", "GL", 46.98192, 9.1528);
case 1032: return new CityInfo("Engelberg", "OW", 46.82107, 8.40133);
case 1033: return new CityInfo("Emmetten", "NW", 46.95658, 8.51467);
case 1034: return new CityInfo("Emmen", "LU", 47.07819, 8.27331);
case 1035: return new CityInfo("Embrach", "ZH", 47.50561, 8.59406);
case 1036: return new CityInfo("Elm", "GL", 46.91902, 9.17242);
case 1037: return new CityInfo("Elgg", "ZH", 47.49715, 8.86523);
case 1038: return new CityInfo("Eischoll", "VS", 46.29352, 7.77995);
case 1039: return new CityInfo("Einsiedeln", "SZ", 47.12849, 8.74735);
case 1040: return new CityInfo("Eiken", "AG", 47.53361, 7.98801);
case 1041: return new CityInfo("Eichberg", "SG", 47.34374, 9.5314);
case 1042: return new CityInfo("Eich", "LU", 47.15116, 8.16695);
case 1043: return new CityInfo("Egnach", "TG", 47.54268, 9.38048);
case 1044: return new CityInfo("Egliswil", "AG", 47.34922, 8.18553);
case 1045: return new CityInfo("Eglisau", "ZH", 47.57738, 8.52122);
case 1046: return new CityInfo("Eggiwil", "BE", 46.87575, 7.79567);
case 1047: return new CityInfo("Eggersriet", "SG", 47.44202, 9.46901);
case 1048: return new CityInfo("Egg", "ZH", 47.29976, 8.69032);
case 1049: return new CityInfo("Egerkingen", "SO", 47.31957, 7.78424);
case 1050: return new CityInfo("Effretikon", "ZH", 47.42575, 8.69094);
case 1051: return new CityInfo("Effingen", "AG", 47.48874, 8.10277);
case 1052: return new CityInfo("Ecuvillens", "FR", 46.75777, 7.08279);
case 1053: return new CityInfo("Ecublens", "FR", 46.60735, 6.80895);
case 1054: return new CityInfo("Echallens", "VD", 46.6413, 6.63317);
case 1055: return new CityInfo("Ebnat-Kappel", "SG", 47.26195, 9.12473);
case 1056: return new CityInfo("Ebikon", "LU", 47.07937, 8.34041);
case 1057: return new CityInfo("Dürrenroth", "BE", 47.08953, 7.7917);
case 1058: return new CityInfo("Dürrenäsch", "AG", 47.32094, 8.15874);
case 1059: return new CityInfo("Dürnten", "ZH", 47.27856, 8.84156);
case 1060: return new CityInfo("Düdingen", "FR", 46.84916, 7.1915);
case 1061: return new CityInfo("Dübendorf", "ZH", 47.39724, 8.61872);
case 1062: return new CityInfo("Dottikon", "AG", 47.38437, 8.23981);
case 1063: return new CityInfo("Dornach", "SO", 47.48038, 7.61644);
case 1064: return new CityInfo("Dorénaz", "VS", 46.14892, 7.04292);
case 1065: return new CityInfo("Doppleschwand", "LU", 47.01831, 8.05501);
case 1066: return new CityInfo("Dompierre", "FR", 46.85208, 6.99075);
case 1067: return new CityInfo("Domdidier", "FR", 46.86716, 7.01337);
case 1068: return new CityInfo("Dombresson", "NE", 47.07192, 6.9592);
case 1069: return new CityInfo("Domat", "GR", 46.83483, 9.45075);
case 1070: return new CityInfo("Disentis", "GR", 46.70341, 8.8509);
case 1071: return new CityInfo("Dietwil", "AG", 47.14665, 8.39355);
case 1072: return new CityInfo("Dietlikon / Dietlikon (Dorf)", "ZH", 47.41827, 8.6188);
case 1073: return new CityInfo("Dietikon", "ZH", 47.40165, 8.40015);
case 1074: return new CityInfo("Diessenhofen", "TG", 47.68908, 8.74958);
case 1075: return new CityInfo("Diepoldsau", "SG", 47.386, 9.65558);
case 1076: return new CityInfo("Diemtigen", "BE", 46.64928, 7.56477);
case 1077: return new CityInfo("Dielsdorf", "ZH", 47.48146, 8.4585);
case 1078: return new CityInfo("Diegten", "BL", 47.4138, 7.81085);
case 1079: return new CityInfo("Derendingen", "SO", 47.1985, 7.58844);
case 1080: return new CityInfo("Densbüren", "AG", 47.4526, 8.0533);
case 1081: return new CityInfo("Delémont", "JU", 47.36493, 7.34453);
case 1082: return new CityInfo("Deitingen", "SO", 47.21515, 7.6188);
case 1083: return new CityInfo("Degersheim", "SG", 47.37429, 9.20019);
case 1084: return new CityInfo("Davos", "GR", 46.80429, 9.83723);
case 1085: return new CityInfo("Därstetten", "BE", 46.65948, 7.49111);
case 1086: return new CityInfo("Därligen", "BE", 46.66175, 7.80808);
case 1087: return new CityInfo("Dardagny", "GE", 46.19564, 5.99497);
case 1088: return new CityInfo("Dallenwil", "NW", 46.9242, 8.38785);
case 1089: return new CityInfo("Daillens", "VD", 46.62115, 6.54871);
case 1090: return new CityInfo("Dagmersellen", "LU", 47.21405, 7.98519);
case 1091: return new CityInfo("Dachsen", "ZH", 47.66515, 8.6179);
case 1092: return new CityInfo("Cully", "VD", 46.48892, 6.72945);
case 1093: return new CityInfo("Cugy", "FR", 46.81479, 6.88888);
case 1094: return new CityInfo("Cugnasco", "TI", 46.17473, 8.91684);
case 1095: return new CityInfo("Cudrefin", "VD", 46.95577, 7.01855);
case 1096: return new CityInfo("Crissier", "VD", 46.54586, 6.57567);
case 1097: return new CityInfo("Cresciano", "TI", 46.27875, 9.00261);
case 1098: return new CityInfo("Crémines", "BE", 47.28329, 7.44032);
case 1099: return new CityInfo("Crassier", "VD", 46.37465, 6.16367);
case 1100: return new CityInfo("Couvet", "NE", 46.92525, 6.6327);
case 1101: return new CityInfo("Courtételle", "JU", 47.34074, 7.31827);
case 1102: return new CityInfo("Courtemaîche", "JU", 47.45724, 7.04825);
case 1103: return new CityInfo("Courtelary", "BE", 47.17822, 7.07236);
case 1104: return new CityInfo("Courtedoux", "JU", 47.40799, 7.04088);
case 1105: return new CityInfo("Court", "BE", 47.23956, 7.33655);
case 1106: return new CityInfo("Courroux", "JU", 47.36069, 7.37371);
case 1107: return new CityInfo("Courrendlin", "JU", 47.33853, 7.37243);
case 1108: return new CityInfo("Courgevaux", "FR", 46.90648, 7.11215);
case 1109: return new CityInfo("Courgenay", "JU", 47.40483, 7.12522);
case 1110: return new CityInfo("Courfaivre", "JU", 47.33461, 7.28186);
case 1111: return new CityInfo("Cossonay", "VD", 46.61443, 6.50631);
case 1112: return new CityInfo("Cortaillod", "NE", 46.94306, 6.8444);
case 1113: return new CityInfo("Corsier", "GE", 46.26297, 6.22461);
case 1114: return new CityInfo("Cornol", "JU", 47.40781, 7.16267);
case 1115: return new CityInfo("Cornaux", "NE", 47.0396, 7.01872);
case 1116: return new CityInfo("Corminboeuf", "FR", 46.81029, 7.10535);
case 1117: return new CityInfo("Corgémont", "BE", 47.19457, 7.14517);
case 1118: return new CityInfo("Cordast", "FR", 46.87598, 7.15212);
case 1119: return new CityInfo("Coppet", "VD", 46.31682, 6.19114);
case 1120: return new CityInfo("Contone", "TI", 46.15088, 8.92617);
case 1121: return new CityInfo("Conthey", "VS", 46.2237, 7.30283);
case 1122: return new CityInfo("Confignon", "GE", 46.17341, 6.08437);
case 1123: return new CityInfo("Concise", "VD", 46.85027, 6.71968);
case 1124: return new CityInfo("Comano", "TI", 46.03635, 8.95526);
case 1125: return new CityInfo("Colombier", "VD", 46.55709, 6.47284);
case 1126: return new CityInfo("Collombey", "VS", 46.27385, 6.94789);
case 1127: return new CityInfo("Coeuve", "JU", 47.45246, 7.09979);
case 1128: return new CityInfo("Claro", "TI", 46.25763, 9.02252);
case 1129: return new CityInfo("Churwalden", "GR", 46.78143, 9.54377);
case 1130: return new CityInfo("Chur", "GR", 46.84986, 9.53287);
case 1131: return new CityInfo("Chippis", "VS", 46.2802, 7.53962);
case 1132: return new CityInfo("Chiasso", "TI", 45.83203, 9.03119);
case 1133: return new CityInfo("Chézard-Saint-Martin", "NE", 47.06629, 6.93332);
case 1134: return new CityInfo("Cheyres", "FR", 46.81439, 6.78685);
case 1135: return new CityInfo("Chexbres", "VD", 46.48208, 6.77805);
case 1136: return new CityInfo("Chevenez", "JU", 47.39303, 7.00038);
case 1137: return new CityInfo("Cheseaux", "VD", 46.58624, 6.60587);
case 1138: return new CityInfo("Chermignon-d'en Haut", "VS", 46.28844, 7.47487);
case 1139: return new CityInfo("Chêne-Bourg", "GE", 46.19534, 6.19406);
case 1140: return new CityInfo("Chavornay", "VD", 46.70244, 6.5694);
case 1141: return new CityInfo("Chavannes", "VD", 46.53005, 6.57068);
case 1142: return new CityInfo("Châtel-Saint-Denis", "FR", 46.52691, 6.90083);
case 1143: return new CityInfo("Château-d'Oex", "VD", 46.47455, 7.13155);
case 1144: return new CityInfo("Charrat", "VS", 46.1249, 7.13138);
case 1145: return new CityInfo("Charmey", "FR", 46.61957, 7.16486);
case 1146: return new CityInfo("Chardonne", "VD", 46.47676, 6.8268);
case 1147: return new CityInfo("Chancy", "GE", 46.15003, 5.97153);
case 1148: return new CityInfo("Champéry", "VS", 46.17543, 6.86903);
case 1149: return new CityInfo("Champagne", "VD", 46.83213, 6.65977);
case 1150: return new CityInfo("Chamoson", "VS", 46.20275, 7.22319);
case 1151: return new CityInfo("Cham", "ZG", 47.18213, 8.46358);
case 1152: return new CityInfo("Chalais", "VS", 46.26758, 7.51145);
case 1153: return new CityInfo("Cevio", "TI", 46.31479, 8.60332);
case 1154: return new CityInfo("Cernier", "NE", 47.05878, 6.9004);
case 1155: return new CityInfo("Céligny", "GE", 46.35069, 6.195);
case 1156: return new CityInfo("Celerina", "GR", 46.51217, 9.85794);
case 1157: return new CityInfo("Cazis", "GR", 46.7194, 9.43271);
case 1158: return new CityInfo("Caux", "VD", 46.43241, 6.93855);
case 1159: return new CityInfo("Cauco", "GR", 46.33541, 9.12129);
case 1160: return new CityInfo("Castel San Pietro", "TI", 45.86211, 9.00843);
case 1161: return new CityInfo("Caslano", "TI", 45.97364, 8.87739);
case 1162: return new CityInfo("Cartigny", "GE", 46.17412, 6.01982);
case 1163: return new CityInfo("Carouge", "GE", 46.18096, 6.13921);
case 1164: return new CityInfo("Capolago", "TI", 45.90368, 8.97922);
case 1165: return new CityInfo("Canobbio", "TI", 46.03592, 8.96605);
case 1166: return new CityInfo("Camorino", "TI", 46.16483, 9.00547);
case 1167: return new CityInfo("Cagiallo", "TI", 46.06734, 8.9733);
case 1168: return new CityInfo("Cadro", "TI", 46.04595, 8.98725);
case 1169: return new CityInfo("Cadenazzo", "TI", 46.15172, 8.94719);
case 1170: return new CityInfo("Cadempino", "TI", 46.03672, 8.93403);
case 1171: return new CityInfo("Buus", "BL", 47.50635, 7.86414);
case 1172: return new CityInfo("Buttwil", "AG", 47.26828, 8.31064);
case 1173: return new CityInfo("Buttisholz", "LU", 47.11442, 8.09425);
case 1174: return new CityInfo("Buttes", "NE", 46.88812, 6.55137);
case 1175: return new CityInfo("Bütschwil", "SG", 47.36022, 9.07213);
case 1176: return new CityInfo("Bussigny", "VD", 46.5511, 6.55597);
case 1177: return new CityInfo("Büsserach", "SO", 47.39415, 7.54117);
case 1178: return new CityInfo("Buseno", "GR", 46.27381, 9.10735);
case 1179: return new CityInfo("Bursins", "VD", 46.45276, 6.29139);
case 1180: return new CityInfo("Büron", "LU", 47.21192, 8.0942);
case 1181: return new CityInfo("Bürglen", "TG", 47.54921, 9.1495);
case 1182: return new CityInfo("Bürglen", "UR", 46.87565, 8.66539);
case 1183: return new CityInfo("Burgistein", "BE", 46.78464, 7.49988);
case 1184: return new CityInfo("Burgdorf", "BE", 47.05901, 7.62786);
case 1185: return new CityInfo("Büren an der Aare", "BE", 47.14035, 7.37175);
case 1186: return new CityInfo("Bürchen", "VS", 46.28053, 7.81506);
case 1187: return new CityInfo("Buochs", "NW", 46.97398, 8.42279);
case 1188: return new CityInfo("Bullet", "VD", 46.83119, 6.55403);
case 1189: return new CityInfo("Bulle", "FR", 46.61797, 7.0569);
case 1190: return new CityInfo("Bülach", "ZH", 47.52197, 8.54049);
case 1191: return new CityInfo("Bühler", "AR", 47.37348, 9.42507);
case 1192: return new CityInfo("Buchs", "AG", 47.39358, 8.08233);
case 1193: return new CityInfo("Buchs", "SG", 47.16743, 9.47794);
case 1194: return new CityInfo("Buchrain", "LU", 47.09625, 8.34729);
case 1195: return new CityInfo("Buchholterberg", "BE", 46.81351, 7.67463);
case 1196: return new CityInfo("Buchberg", "SH", 47.57282, 8.56281);
case 1197: return new CityInfo("Bubikon", "ZH", 47.26698, 8.8179);
case 1198: return new CityInfo("Bubendorf", "BL", 47.44586, 7.73759);
case 1199: return new CityInfo("Brüttisellen", "ZH", 47.42173, 8.63263);
case 1200: return new CityInfo("Brütten", "ZH", 47.47318, 8.67569);
case 1201: return new CityInfo("Brüttelen", "BE", 47.02269, 7.14793);
case 1202: return new CityInfo("Brusio", "GR", 46.25953, 10.12385);
case 1203: return new CityInfo("Brunnadern", "SG", 47.33595, 9.1302);
case 1204: return new CityInfo("Brugg", "AG", 47.48096, 8.20869);
case 1205: return new CityInfo("Brügg", "BE", 47.1237, 7.27887);
case 1206: return new CityInfo("Bronschhofen", "SG", 47.47835, 9.03454);
case 1207: return new CityInfo("Broc", "FR", 46.60513, 7.09891);
case 1208: return new CityInfo("Brittnau", "AG", 47.25954, 7.94689);
case 1209: return new CityInfo("Brissago", "TI", 46.12013, 8.71181);
case 1210: return new CityInfo("Brislach", "BL", 47.41763, 7.5434);
case 1211: return new CityInfo("Brig", "VS", 46.31667, 7.98333);
case 1212: return new CityInfo("Brienzwiler", "BE", 46.75084, 8.10139);
case 1213: return new CityInfo("Brienz", "BE", 46.7545, 8.03847);
case 1214: return new CityInfo("Bretzwil", "BL", 47.39783, 7.65222);
case 1215: return new CityInfo("Bremgarten", "AG", 47.35109, 8.34214);
case 1216: return new CityInfo("Breitenbach", "SO", 47.40668, 7.54554);
case 1217: return new CityInfo("Breíl", "GR", 46.76986, 9.06036);
case 1218: return new CityInfo("Bözen", "AG", 47.49568, 8.08451);
case 1219: return new CityInfo("Bowil", "BE", 46.89304, 7.69757);
case 1220: return new CityInfo("Le Bouveret", "VS", 46.38319, 6.85963);
case 1221: return new CityInfo("Boudry", "NE", 46.94991, 6.83757);
case 1222: return new CityInfo("Boudevilliers", "NE", 47.02725, 6.88911);
case 1223: return new CityInfo("Bottmingen", "BL", 47.52343, 7.57211);
case 1224: return new CityInfo("Bottighofen", "TG", 47.63643, 9.20882);
case 1225: return new CityInfo("Bottenwil", "AG", 47.28488, 8.00599);
case 1226: return new CityInfo("Bottens", "VD", 46.61596, 6.66149);
case 1227: return new CityInfo("Bösingen", "FR", 46.89229, 7.2277);
case 1228: return new CityInfo("Borex", "VD", 46.37891, 6.1762);
case 1229: return new CityInfo("Bonstetten", "ZH", 47.31505, 8.46836);
case 1230: return new CityInfo("Boniswil", "AG", 47.31725, 8.18963);
case 1231: return new CityInfo("Bönigen", "BE", 46.68736, 7.8935);
case 1232: return new CityInfo("Bonfol", "JU", 47.47738, 7.15221);
case 1233: return new CityInfo("Boncourt", "JU", 47.49493, 7.01297);
case 1234: return new CityInfo("Bonaduz", "GR", 46.81103, 9.39821);
case 1235: return new CityInfo("Boltigen", "BE", 46.62847, 7.39054);
case 1236: return new CityInfo("Bolligen", "BE", 46.9751, 7.49697);
case 1237: return new CityInfo("Bogis-Bossey", "VD", 46.35374, 6.16603);
case 1238: return new CityInfo("Bodio", "TI", 46.37808, 8.90991);
case 1239: return new CityInfo("Blumenstein", "BE", 46.7421, 7.52136);
case 1240: return new CityInfo("Blonay", "VD", 46.46778, 6.89615);
case 1241: return new CityInfo("Blauen", "BL", 47.44993, 7.51936);
case 1242: return new CityInfo("Bitsch", "VS", 46.33779, 8.01088);
case 1243: return new CityInfo("Birsfelden", "BL", 47.5529, 7.62322);
case 1244: return new CityInfo("Birrwil", "AG", 47.29086, 8.19741);
case 1245: return new CityInfo("Birr", "AG", 47.43432, 8.20891);
case 1246: return new CityInfo("Bironico", "TI", 46.11367, 8.93324);
case 1247: return new CityInfo("Birmenstorf", "AG", 47.46152, 8.24816);
case 1248: return new CityInfo("Birmensdorf", "ZH", 47.35515, 8.44256);
case 1249: return new CityInfo("Bioggio", "TI", 46.01357, 8.91103);
case 1250: return new CityInfo("Binningen", "BL", 47.54021, 7.56932);
case 1251: return new CityInfo("Bilten", "GL", 47.14995, 9.02551);
case 1252: return new CityInfo("Biglen", "BE", 46.92629, 7.62508);
case 1253: return new CityInfo("Bière", "VD", 46.53761, 6.33362);
case 1254: return new CityInfo("Biel/Bienne", "BE", 47.13713, 7.24608);
case 1255: return new CityInfo("Biberist", "SO", 47.18009, 7.56246);
case 1256: return new CityInfo("Biasca", "TI", 46.35972, 8.96965);
case 1257: return new CityInfo("Bex", "VD", 46.24965, 7.0098);
case 1258: return new CityInfo("Bévilard", "BE", 47.23711, 7.28325);
case 1259: return new CityInfo("Bevaix", "NE", 46.92958, 6.8147);
case 1260: return new CityInfo("Bettlach", "SO", 47.20062, 7.42405);
case 1261: return new CityInfo("Bettingen", "BS", 47.57039, 7.66425);
case 1262: return new CityInfo("Beromünster", "LU", 47.20612, 8.19265);
case 1263: return new CityInfo("Bernex", "GE", 46.1765, 6.07544);
case 1264: return new CityInfo("Bern", "BE", 46.94809, 7.44744);
case 1265: return new CityInfo("Beringen", "SH", 47.69763, 8.57431);
case 1266: return new CityInfo("Berikon", "AG", 47.35155, 8.37232);
case 1267: return new CityInfo("Bergün", "GR", 46.62934, 9.74762);
case 1268: return new CityInfo("Berg", "TG", 47.57879, 9.16635);
case 1269: return new CityInfo("Bercher", "VD", 46.69138, 6.70759);
case 1270: return new CityInfo("Benken", "ZH", 47.65276, 8.65391);
case 1271: return new CityInfo("Benken", "SG", 47.19942, 9.00735);
case 1272: return new CityInfo("Belp", "BE", 46.89129, 7.49825);
case 1273: return new CityInfo("Belmont-sur-Lausanne", "VD", 46.51891, 6.67636);
case 1274: return new CityInfo("Bellmund", "BE", 47.10852, 7.24608);
case 1275: return new CityInfo("Bellinzona", "TI", 46.19278, 9.01703);
case 1276: return new CityInfo("Bellevue", "GE", 46.25739, 6.15475);
case 1277: return new CityInfo("Bellerive", "VD", 46.92345, 7.02209);
case 1278: return new CityInfo("Belfaux", "FR", 46.82171, 7.10674);
case 1279: return new CityInfo("Beinwil", "AG", 47.26059, 8.20506);
case 1280: return new CityInfo("Begnins", "VD", 46.44152, 6.24762);
case 1281: return new CityInfo("Beggingen", "SH", 47.76737, 8.53535);
case 1282: return new CityInfo("Beckenried", "NW", 46.96653, 8.47575);
case 1283: return new CityInfo("Beatenberg", "BE", 46.69896, 7.79428);
case 1284: return new CityInfo("Bavois", "VD", 46.68403, 6.5671);
case 1285: return new CityInfo("Bauma", "ZH", 47.36745, 8.87905);
case 1286: return new CityInfo("Baulmes", "VD", 46.79031, 6.52279);
case 1287: return new CityInfo("Bauen", "UR", 46.93559, 8.57836);
case 1288: return new CityInfo("Bätterkinden", "BE", 47.13164, 7.53817);
case 1289: return new CityInfo("Bassersdorf", "ZH", 47.44342, 8.62851);
case 1290: return new CityInfo("Basse-Nendaz", "VS", 46.18993, 7.31209);
case 1291: return new CityInfo("Bassecourt", "JU", 47.33808, 7.24373);
case 1292: return new CityInfo("Basel", "BS", 47.55839, 7.57327);
case 1293: return new CityInfo("Bärschwil", "SO", 47.3822, 7.47229);
case 1294: return new CityInfo("Bäriswil", "BE", 47.01947, 7.52709);
case 1295: return new CityInfo("Bäretswil", "ZH", 47.33709, 8.85645);
case 1296: return new CityInfo("Barberêche", "FR", 46.85728, 7.15881);
case 1297: return new CityInfo("Bannwil", "BE", 47.23996, 7.7359);
case 1298: return new CityInfo("Baltschieder", "VS", 46.30888, 7.8657);
case 1299: return new CityInfo("Balsthal", "SO", 47.31613, 7.69318);
case 1300: return new CityInfo("Ballwil", "LU", 47.15371, 8.32233);
case 1301: return new CityInfo("Ballens", "VD", 46.55485, 6.3731);
case 1302: return new CityInfo("Ballaigues", "VD", 46.72984, 6.41357);
case 1303: return new CityInfo("Balgach", "SG", 47.40556, 9.60702);
case 1304: return new CityInfo("Balerna", "TI", 45.84638, 9.00724);
case 1305: return new CityInfo("Bagnes", "VS", 46.08333, 7.21667);
case 1306: return new CityInfo("Bad Ragaz", "SG", 47.00601, 9.50266);
case 1307: return new CityInfo("Baden", "AG", 47.47333, 8.30592);
case 1308: return new CityInfo("Bachenbülach", "ZH", 47.50317, 8.54556);
case 1309: return new CityInfo("Bäch", "SZ", 47.20388, 8.73224);
case 1310: return new CityInfo("Baar", "ZG", 47.19625, 8.52954);
case 1311: return new CityInfo("Ayer", "VS", 46.18088, 7.60116);
case 1312: return new CityInfo("Ayent", "VS", 46.28249, 7.41028);
case 1313: return new CityInfo("Avry-sur-Matran", "FR", 46.78753, 7.06735);
case 1314: return new CityInfo("Avenches", "VD", 46.88004, 7.04071);
case 1315: return new CityInfo("Avegno", "TI", 46.20519, 8.74546);
case 1316: return new CityInfo("Auw", "AG", 47.21082, 8.36583);
case 1317: return new CityInfo("Auvernier", "NE", 46.97545, 6.87903);
case 1318: return new CityInfo("Autigny", "FR", 46.73661, 7.01998);
case 1319: return new CityInfo("Zürich (Kreis 4) / Aussersihl", "ZH", 47.37752, 8.52127);
case 1320: return new CityInfo("Augst", "BL", 47.53557, 7.71468);
case 1321: return new CityInfo("Aubonne", "VD", 46.49514, 6.39155);
case 1322: return new CityInfo("Au", "SG", 47.43093, 9.63448);
case 1323: return new CityInfo("Au", "ZH", 47.24185, 8.64406);
case 1324: return new CityInfo("Attiswil", "BE", 47.24673, 7.61353);
case 1325: return new CityInfo("Attinghausen", "UR", 46.86255, 8.63036);
case 1326: return new CityInfo("Attalens", "FR", 46.50555, 6.85039);
case 1327: return new CityInfo("Assens", "VD", 46.61301, 6.62184);
case 1328: return new CityInfo("Ascona", "TI", 46.15451, 8.77327);
case 1329: return new CityInfo("Arzo", "TI", 45.87606, 8.94103);
case 1330: return new CityInfo("Arzier", "VD", 46.45962, 6.20813);
case 1331: return new CityInfo("Arvigo", "GR", 46.30211, 9.113);
case 1332: return new CityInfo("Arth", "SZ", 47.06337, 8.52349);
case 1333: return new CityInfo("Arosa", "GR", 46.77793, 9.67621);
case 1334: return new CityInfo("Arogno", "TI", 45.95909, 8.98441);
case 1335: return new CityInfo("Arni", "BE", 46.93519, 7.66473);
case 1336: return new CityInfo("Arlesheim", "BL", 47.49412, 7.61979);
case 1337: return new CityInfo("Aristau", "AG", 47.28692, 8.36356);
case 1338: return new CityInfo("Arisdorf", "BL", 47.51323, 7.76515);
case 1339: return new CityInfo("Ardon", "VS", 46.20951, 7.26012);
case 1340: return new CityInfo("Arconciel", "FR", 46.74733, 7.12152);
case 1341: return new CityInfo("Arch", "BE", 47.16533, 7.43139);
case 1342: return new CityInfo("Arbon", "TG", 47.51667, 9.43333);
case 1343: return new CityInfo("Arbaz", "VS", 46.2781, 7.38542);
case 1344: return new CityInfo("Apples", "VD", 46.55237, 6.42889);
case 1345: return new CityInfo("Appenzell", "AI", 47.33103, 9.40996);
case 1346: return new CityInfo("Anières", "GE", 46.27673, 6.22204);
case 1347: return new CityInfo("Andwil", "SG", 47.43855, 9.27436);
case 1348: return new CityInfo("Andermatt", "UR", 46.63565, 8.59388);
case 1349: return new CityInfo("Andeer", "GR", 46.6034, 9.42614);
case 1350: return new CityInfo("Amsoldingen", "BE", 46.72754, 7.58247);
case 1351: return new CityInfo("Amriswil", "TG", 47.54699, 9.29586);
case 1352: return new CityInfo("Amden", "SG", 47.14888, 9.14233);
case 1353: return new CityInfo("Altstätten", "SG", 47.37766, 9.54746);
case 1354: return new CityInfo("Altnau", "TG", 47.61052, 9.2616);
case 1355: return new CityInfo("Altishofen", "LU", 47.19916, 7.96964);
case 1356: return new CityInfo("Alterswil", "FR", 46.79587, 7.25877);
case 1357: return new CityInfo("Altendorf", "SZ", 47.18994, 8.83823);
case 1358: return new CityInfo("Altdorf", "UR", 46.88042, 8.64441);
case 1359: return new CityInfo("Alpthal", "SZ", 47.06954, 8.71602);
case 1360: return new CityInfo("Alpnach", "OW", 46.94227, 8.2718);
case 1361: return new CityInfo("Allschwil", "BL", 47.55074, 7.53599);
case 1362: return new CityInfo("Alle", "JU", 47.42542, 7.13018);
case 1363: return new CityInfo("Alchenstorf", "BE", 47.12493, 7.63614);
case 1364: return new CityInfo("Albeuve", "FR", 46.51727, 7.0567);
case 1365: return new CityInfo("Alberswil", "LU", 47.14998, 8.00313);
case 1366: return new CityInfo("Airolo", "TI", 46.52855, 8.61189);
case 1367: return new CityInfo("Aigle", "VD", 46.3181, 6.96457);
case 1368: return new CityInfo("Agno", "TI", 45.99863, 8.9003);
case 1369: return new CityInfo("Agarn", "VS", 46.29749, 7.66322);
case 1370: return new CityInfo("Affoltern am Albis", "ZH", 47.27743, 8.45128);
case 1371: return new CityInfo("Affeltrangen", "TG", 47.52581, 9.03307);
case 1372: return new CityInfo("Aeugst / Aeugst (Dorf)", "ZH", 47.26932, 8.48504);
case 1373: return new CityInfo("Aeschi b. Spiez", "BE", 46.65848, 7.6965);
case 1374: return new CityInfo("Aesch", "BL", 47.47104, 7.5973);
case 1375: return new CityInfo("Aesch", "LU", 47.25637, 8.2409);
case 1376: return new CityInfo("Aedermannsdorf", "SO", 47.30374, 7.61052);
case 1377: return new CityInfo("Adliswil", "ZH", 47.30997, 8.52462);
case 1378: return new CityInfo("Adligenswil", "LU", 47.06521, 8.36124);
case 1379: return new CityInfo("Adelboden", "BE", 46.49142, 7.56031);
case 1380: return new CityInfo("Acquarossa", "TI", 46.45473, 8.94261);
case 1381: return new CityInfo("Abtwil", "SG", 47.42373, 9.32113);
case 1382: return new CityInfo("Aarwangen", "BE", 47.23845, 7.76854);
case 1383: return new CityInfo("Aarburg", "AG", 47.32067, 7.89986);
case 1384: return new CityInfo("Aarberg", "BE", 47.04439, 7.27578);
case 1385: return new CityInfo("Aarau", "AG", 47.39254, 8.04422);
case 1386: return new CityInfo("Aadorf", "TG", 47.49204, 8.90099);
case 1387: return new CityInfo("Riehen", "BS", 47.57884, 7.64683);
case 1388: return new CityInfo("Chêne-Bougeries", "GE", 46.19843, 6.18642);
case 1389: return new CityInfo("Meinier", "GE", 46.24706, 6.23423);
case 1390: return new CityInfo("Puplinge", "GE", 46.21043, 6.23114);
case 1391: return new CityInfo("Thônex", "GE", 46.18815, 6.19904);
case 1392: return new CityInfo("Wettswil / Wettswil (Dorf)", "ZH", 47.34152, 8.47149);
case 1393: return new CityInfo("Sellenbüren", "ZH", 47.34361, 8.48301);
case 1394: return new CityInfo("Itingen", "BL", 47.46651, 7.78502);
case 1395: return new CityInfo("Arboldswil", "BL", 47.41438, 7.71755);
case 1396: return new CityInfo("Ecublens", "VD", 46.52899, 6.56261);
case 1397: return new CityInfo("Zwillikon", "ZH", 47.28833, 8.43124);
case 1398: return new CityInfo("Affoltern / Hasenbüel", "ZH", 47.27324, 8.45218);
case 1399: return new CityInfo("Affoltern / Goldiger Berg", "ZH", 47.27852, 8.44507);
case 1400: return new CityInfo("Affoltern / Oberdorf", "ZH", 47.27852, 8.45651);
case 1401: return new CityInfo("Affoltern / Unterdorf", "ZH", 47.28277, 8.45409);
case 1402: return new CityInfo("Affoltern / Butzen", "ZH", 47.27669, 8.45737);
case 1403: return new CityInfo("Affoltern / Sonnenberg", "ZH", 47.28055, 8.46008);
case 1404: return new CityInfo("Schachen", "ZH", 47.32419, 8.47251);
case 1405: return new CityInfo("Hausen / Heisch", "ZH", 47.25015, 8.53023);
case 1406: return new CityInfo("Hedingen", "ZH", 47.29794, 8.44833);
case 1407: return new CityInfo("Obfelden / Oberlunnern", "ZH", 47.26197, 8.41588);
case 1408: return new CityInfo("Obfelden / Bickwil", "ZH", 47.26943, 8.42448);
case 1409: return new CityInfo("Obfelden / Toussen", "ZH", 47.26574, 8.43013);
case 1410: return new CityInfo("Wettswil / Ausser-Dorf", "ZH", 47.33197, 8.47732);
case 1411: return new CityInfo("Dorf", "ZH", 47.57285, 8.64781);
case 1412: return new CityInfo("Langwiesen", "ZH", 47.68399, 8.66086);
case 1413: return new CityInfo("Kleinandelfingen", "ZH", 47.60058, 8.68362);
case 1414: return new CityInfo("Marthalen / Dorfkern", "ZH", 47.62571, 8.6496);
case 1415: return new CityInfo("Oberstammheim", "ZH", 47.63244, 8.79963);
case 1416: return new CityInfo("Neu-Rheinau", "ZH", 47.63436, 8.60852);
case 1417: return new CityInfo("Bülach / Altstadt", "ZH", 47.51761, 8.54046);
case 1418: return new CityInfo("Bülach / Chröpfli", "ZH", 47.52776, 8.54705);
case 1419: return new CityInfo("Bülach / Soligänter", "ZH", 47.52632, 8.54106);
case 1420: return new CityInfo("Bülach / Gstückt", "ZH", 47.52337, 8.54879);
case 1421: return new CityInfo("Bülach / Grossstein", "ZH", 47.51975, 8.53224);
case 1422: return new CityInfo("Bülach / Herti", "ZH", 47.51885, 8.53682);
case 1423: return new CityInfo("Bülach / Seematt", "ZH", 47.51716, 8.54651);
case 1424: return new CityInfo("Dietlikon / Eichwiesen", "ZH", 47.4191, 8.62078);
case 1425: return new CityInfo("Seglingen / Ober-Seglingen", "ZH", 47.57201, 8.52695);
case 1426: return new CityInfo("Embrach / Embrach (Dorfkern)", "ZH", 47.504, 8.59477);
case 1427: return new CityInfo("Embrach / Kellersacker", "ZH", 47.51455, 8.59146);
case 1428: return new CityInfo("Embrach / Ebnet", "ZH", 47.51644, 8.58712);
case 1429: return new CityInfo("Embrach / Wildbach", "ZH", 47.51178, 8.59092);
case 1430: return new CityInfo("Embrach / Bächli", "ZH", 47.512, 8.59528);
case 1431: return new CityInfo("Freienstein", "ZH", 47.53307, 8.58455);
case 1432: return new CityInfo("Hochfelden", "ZH", 47.52262, 8.51564);
case 1433: return new CityInfo("Höri", "ZH", 47.50799, 8.51203);
case 1434: return new CityInfo("Bückler-Dörnler", "ZH", 47.50815, 8.51542);
case 1435: return new CityInfo("Ober-Höri", "ZH", 47.50399, 8.49749);
case 1436: return new CityInfo("Kloten / Kloten (Zentrum)", "ZH", 47.45134, 8.58683);
case 1437: return new CityInfo("Kloten / Freienberg (Chanzler-Chlini Chaseren)", "ZH", 47.46584, 8.58145);
case 1438: return new CityInfo("Kloten / Horainli", "ZH", 47.45399, 8.58306);
case 1439: return new CityInfo("Kloten / Geissberg", "ZH", 47.45424, 8.59066);
case 1440: return new CityInfo("Kloten / Hostrass", "ZH", 47.45255, 8.59464);
case 1441: return new CityInfo("Kloten / Holberg", "ZH", 47.44642, 8.57661);
case 1442: return new CityInfo("Kloten / Balsberg", "ZH", 47.44233, 8.57496);
case 1443: return new CityInfo("Kloten / Bramen", "ZH", 47.4433, 8.57925);
case 1444: return new CityInfo("Kloten / Spitz", "ZH", 47.44455, 8.58724);
case 1445: return new CityInfo("Kloten / Rütlen", "ZH", 47.44726, 8.58808);
case 1446: return new CityInfo("Birchwil", "ZH", 47.45431, 8.63477);
case 1447: return new CityInfo("Glattbrugg / Wydacker/Bettacker/Lättenwiesen", "ZH", 47.42908, 8.56657);
case 1448: return new CityInfo("Grossacker/Opfikon", "ZH", 47.42696, 8.57886);
case 1449: return new CityInfo("Rietgrabenhang", "ZH", 47.42442, 8.57658);
case 1450: return new CityInfo("Glattbrugg / Zentrum Müllacker", "ZH", 47.43424, 8.56905);
case 1451: return new CityInfo("Glattbrugg / Rohr/Platten-Balsberg", "ZH", 47.43721, 8.56642);
case 1452: return new CityInfo("Wallisellen / Wallisellen-West", "ZH", 47.41906, 8.58586);
case 1453: return new CityInfo("Wallisellen / Wallisellen-Ost", "ZH", 47.41446, 8.59727);
case 1454: return new CityInfo("Wallisellen / Rieden", "ZH", 47.41738, 8.60028);
case 1455: return new CityInfo("Wallisellen / Hof", "ZH", 47.40906, 8.60345);
case 1456: return new CityInfo("Winkel", "ZH", 47.49193, 8.55371);
case 1457: return new CityInfo("Boppelsen", "ZH", 47.46945, 8.40614);
case 1458: return new CityInfo("Buchs / Buchs (Nord)", "ZH", 47.46088, 8.43555);
case 1459: return new CityInfo("Buchs / Zürcherstrasse", "ZH", 47.45726, 8.44152);
case 1460: return new CityInfo("Buchs / Ringstrasse", "ZH", 47.45492, 8.43985);
case 1461: return new CityInfo("Dällikon / Dällikon (Dorf)", "ZH", 47.43983, 8.43813);
case 1462: return new CityInfo("Dällikon / Sytenacher", "ZH", 47.43844, 8.44465);
case 1463: return new CityInfo("Dänikon / Bifang", "ZH", 47.44728, 8.40835);
case 1464: return new CityInfo("Rain", "LU", 47.44368, 8.4097);
case 1465: return new CityInfo("Neerach", "ZH", 47.51096, 8.47099);
case 1466: return new CityInfo("Riedt", "ZH", 47.50069, 8.47078);
case 1467: return new CityInfo("Niederglatt / Niederglatt (Dorfkern)", "ZH", 47.49065, 8.50048);
case 1468: return new CityInfo("Niederglatt / Nöschikon", "ZH", 47.49518, 8.49472);
case 1469: return new CityInfo("Niederglatt / Grafschaft", "ZH", 47.49428, 8.50305);
case 1470: return new CityInfo("Niederhasli", "ZH", 47.48012, 8.48576);
case 1471: return new CityInfo("Oberhasli / Birch", "ZH", 47.46941, 8.50078);
case 1472: return new CityInfo("Oberglatt / Oberglatt (Dorfkern)", "ZH", 47.47596, 8.51929);
case 1473: return new CityInfo("Oberglatt / Bellen-Grafschaft", "ZH", 47.4799, 8.52471);
case 1474: return new CityInfo("Oberglatt / Bahnhofquartier", "ZH", 47.47143, 8.51289);
case 1475: return new CityInfo("Hofstetten", "ZH", 47.47778, 8.50646);
case 1476: return new CityInfo("Regensdorf / Zentrum", "ZH", 47.43076, 8.46898);
case 1477: return new CityInfo("Sonnhalde", "ZH", 47.45329, 8.46091);
case 1478: return new CityInfo("Laubisser", "ZH", 47.44828, 8.47661);
case 1479: return new CityInfo("Adlikon", "ZH", 47.44681, 8.46641);
case 1480: return new CityInfo("Regensdorf / Hofacher-Geeren", "ZH", 47.43525, 8.4624);
case 1481: return new CityInfo("Regensdorf / Feldblumen-Riedthofstrasse", "ZH", 47.43618, 8.46659);
case 1482: return new CityInfo("Sand", "ZH", 47.44077, 8.47846);
case 1483: return new CityInfo("Regensdorf / Watterstrasse", "ZH", 47.43373, 8.4705);
case 1484: return new CityInfo("Regensdorf / Hubacher", "ZH", 47.42947, 8.46115);
case 1485: return new CityInfo("Regensdorf / Obstgarten", "ZH", 47.42772, 8.46566);
case 1486: return new CityInfo("Rümlang / Rümlang (Dorfkern)", "ZH", 47.4494, 8.53255);
case 1487: return new CityInfo("Rümlang / Säntisstrasse-Aegler", "ZH", 47.45286, 8.52619);
case 1488: return new CityInfo("Rümlang / Huebacher", "ZH", 47.4455, 8.52612);
case 1489: return new CityInfo("Steinmaur / Nieder-Steinmaur", "ZH", 47.49284, 8.44872);
case 1490: return new CityInfo("Schibler", "ZH", 47.48775, 8.45062);
case 1491: return new CityInfo("Weiach / Weiach (Dorfkern)", "ZH", 47.55622, 8.43851);
case 1492: return new CityInfo("Adetswil", "ZH", 47.33969, 8.84);
case 1493: return new CityInfo("Weid (bei Adetswil)", "ZH", 47.34, 8.84918);
case 1494: return new CityInfo("Bubikon / Station", "ZH", 47.27103, 8.8218);
case 1495: return new CityInfo("Tann / Tann (Dorfkern)", "ZH", 47.26494, 8.85048);
case 1496: return new CityInfo("Oberdürnten", "ZH", 47.27942, 8.86162);
case 1497: return new CityInfo("Breitenmatt", "ZH", 47.27655, 8.87504);
case 1498: return new CityInfo("Bertschikon", "ZH", 47.32023, 8.75775);
case 1499: return new CityInfo("Grüt", "ZH", 47.31151, 8.78339);
case 1500: return new CityInfo("Binzikon", "ZH", 47.27632, 8.75851);
case 1501: return new CityInfo("Hadlikon", "ZH", 47.2875, 8.85719);
case 1502: return new CityInfo("Rüti / Westlicher Dorfteil", "ZH", 47.25548, 8.8449);
case 1503: return new CityInfo("Rüti / Dorfzentrum, Südl. Teil", "ZH", 47.25368, 8.85654);
case 1504: return new CityInfo("Rüti / Oberdorf", "ZH", 47.25894, 8.86512);
case 1505: return new CityInfo("Pilgerhof", "ZH", 47.26614, 8.86712);
case 1506: return new CityInfo("Laupen", "ZH", 47.265, 8.92851);
case 1507: return new CityInfo("Wetzikon / Robenhausen", "ZH", 47.33089, 8.78762);
case 1508: return new CityInfo("Wetzikon / Kempten", "ZH", 47.33319, 8.80982);
case 1509: return new CityInfo("Oberkempten", "ZH", 47.32852, 8.8204);
case 1510: return new CityInfo("Widum", "ZH", 47.3281, 8.79192);
case 1511: return new CityInfo("Adliswil / Adliswil (Stadtkern)", "ZH", 47.31128, 8.52675);
case 1512: return new CityInfo("Adliswil / Oberleimbach", "ZH", 47.3202, 8.51508);
case 1513: return new CityInfo("Adliswil / Sood", "ZH", 47.3187, 8.52425);
case 1514: return new CityInfo("Adliswil / Hündli-Zopf", "ZH", 47.31637, 8.51888);
case 1515: return new CityInfo("Adliswil / Lebern", "ZH", 47.31554, 8.53357);
case 1516: return new CityInfo("Adliswil / Sonnenberg", "ZH", 47.30958, 8.52055);
case 1517: return new CityInfo("Adliswil / Tal", "ZH", 47.31142, 8.53446);
case 1518: return new CityInfo("Adliswil / Wacht", "ZH", 47.30811, 8.53176);
case 1519: return new CityInfo("Adliswil / Wanneten", "ZH", 47.30446, 8.5208);
case 1520: return new CityInfo("Adliswil / Büchel", "ZH", 47.30005, 8.52204);
case 1521: return new CityInfo("Adliswil / Sihlau", "ZH", 47.30285, 8.52727);
case 1522: return new CityInfo("Adliswil / Buttenau", "ZH", 47.30007, 8.52604);
case 1523: return new CityInfo("Adliswil / Sihlhof", "ZH", 47.32229, 8.52172);
case 1524: return new CityInfo("Horgen / Horgen (Dorfkern)", "ZH", 47.25604, 8.60159);
case 1525: return new CityInfo("Horgen / Käpfnach", "ZH", 47.25445, 8.61324);
case 1526: return new CityInfo("Horgen / Allmend", "ZH", 47.24729, 8.6066);
case 1527: return new CityInfo("Horgen / Scheller-Stockerstrasse", "ZH", 47.26584, 8.5876);
case 1528: return new CityInfo("Horgen / Oberdorf", "ZH", 47.25837, 8.59013);
case 1529: return new CityInfo("Kilchberg / Hornhalden", "ZH", 47.33106, 8.54225);
case 1530: return new CityInfo("Kilchberg / Bächler-Stocken", "ZH", 47.32728, 8.53957);
case 1531: return new CityInfo("Kilchberg / Bendlikon", "ZH", 47.32329, 8.54923);
case 1532: return new CityInfo("Kilchberg / Kilchberg (Dorfkern)", "ZH", 47.32012, 8.54306);
case 1533: return new CityInfo("Kilchberg / Schwanden", "ZH", 47.31773, 8.54904);
case 1534: return new CityInfo("Langnau / Vitaquartier", "ZH", 47.29377, 8.53758);
case 1535: return new CityInfo("Mühlehalde", "ZH", 47.28306, 8.53386);
case 1536: return new CityInfo("Oberrieden / Mitte", "ZH", 47.27242, 8.58021);
case 1537: return new CityInfo("Oberrieden / Berg", "ZH", 47.27628, 8.57257);
case 1538: return new CityInfo("Richterswil / Dorfkern", "ZH", 47.20715, 8.70607);
case 1539: return new CityInfo("Richterswil / Richterswil (Dorfkern)", "ZH", 47.20323, 8.70516);
case 1540: return new CityInfo("Richterswil / Burghalde", "ZH", 47.20973, 8.69133);
case 1541: return new CityInfo("Rüschlikon / Alte Landstrasse", "ZH", 47.30378, 8.55427);
case 1542: return new CityInfo("Thalwil / Dorfkern", "ZH", 47.29047, 8.56633);
case 1543: return new CityInfo("Thalwil / Berg", "ZH", 47.29178, 8.55602);
case 1544: return new CityInfo("Thalwil / Nord", "ZH", 47.29748, 8.55634);
case 1545: return new CityInfo("Thalwil / Süd", "ZH", 47.28495, 8.56954);
case 1546: return new CityInfo("Gattikon", "ZH", 47.28439, 8.5483);
case 1547: return new CityInfo("Wädenswil / Dorf (Wädenswil)", "ZH", 47.22923, 8.6722);
case 1548: return new CityInfo("Au / Unter-Dorf", "ZH", 47.2473, 8.6327);
case 1549: return new CityInfo("Au / Mittel-Dorf", "ZH", 47.24303, 8.64591);
case 1550: return new CityInfo("Au / Ober-Ort/Gwad", "ZH", 47.23943, 8.65741);
case 1551: return new CityInfo("Wädenswil / Hangenmoos", "ZH", 47.23367, 8.65251);
case 1552: return new CityInfo("Wädenswil / Büelen", "ZH", 47.23395, 8.66346);
case 1553: return new CityInfo("Wädenswil / Untermosen-Fuhr", "ZH", 47.22772, 8.66303);
case 1554: return new CityInfo("Wädenswil / Leihof-Mühlebach", "ZH", 47.22364, 8.67149);
case 1555: return new CityInfo("Wädenswil / Eichweid", "ZH", 47.21847, 8.6744);
case 1556: return new CityInfo("Wädenswil / Boller-Giessen", "ZH", 47.22115, 8.68385);
case 1557: return new CityInfo("Erlenbach / rechts des Dorfbachs unterhalb Bahnlinie", "ZH", 47.30531, 8.59026);
case 1558: return new CityInfo("Erlenbach / rechts des Dorfbachs oberhalb Bahnlinie", "ZH", 47.30658, 8.60271);
case 1559: return new CityInfo("Erlenbach / links des Dorfbachs unterhalb Bahnlinie", "ZH", 47.30052, 8.59489);
case 1560: return new CityInfo("Erlenbach / links des Dorfbachs oberhalb Bahnlinie", "ZH", 47.2995, 8.60188);
case 1561: return new CityInfo("Hombrechtikon / Bochslen", "ZH", 47.25441, 8.77557);
case 1562: return new CityInfo("Hombrechtikon / Eichberg", "ZH", 47.24964, 8.77218);
case 1563: return new CityInfo("Hombrechtikon / Tobel", "ZH", 47.25354, 8.78104);
case 1564: return new CityInfo("Hombrechtikon / Grossacher", "ZH", 47.2513, 8.77697);
case 1565: return new CityInfo("Küsnacht / Dorf", "ZH", 47.31783, 8.58303);
case 1566: return new CityInfo("Küsnacht / Goldbach", "ZH", 47.32729, 8.58077);
case 1567: return new CityInfo("Küsnacht / Itschnach", "ZH", 47.32714, 8.60068);
case 1568: return new CityInfo("Küsnacht / Schiedhalden", "ZH", 47.32112, 8.58881);
case 1569: return new CityInfo("Küsnacht / Heslibach", "ZH", 47.31307, 8.58849);
case 1570: return new CityInfo("Küsnacht / Allmend", "ZH", 47.31493, 8.59736);
case 1571: return new CityInfo("Männedorf / Dorfkern", "ZH", 47.25612, 8.69161);
case 1572: return new CityInfo("Männedorf / Ausserfeld", "ZH", 47.24636, 8.70608);
case 1573: return new CityInfo("Meilen / Halten", "ZH", 47.27049, 8.65647);
case 1574: return new CityInfo("Oetwil / Zelgliacker", "ZH", 47.27359, 8.72065);
case 1575: return new CityInfo("Oetwil / Vogelsang", "ZH", 47.26628, 8.72741);
case 1576: return new CityInfo("Dorf", "ZH", 47.239, 8.73567);
case 1577: return new CityInfo("Kehlhof", "ZH", 47.23471, 8.73857);
case 1578: return new CityInfo("Uetikon / Grossdorf", "ZH", 47.26654, 8.67765);
case 1579: return new CityInfo("Uetikon / Chlidorf", "ZH", 47.26426, 8.68338);
case 1580: return new CityInfo("Zumikon / Fröschgüllen", "ZH", 47.33648, 8.61528);
case 1581: return new CityInfo("Rebwies", "ZH", 47.34726, 8.58629);
case 1582: return new CityInfo("Zollikerberg", "ZH", 47.3451, 8.60088);
case 1583: return new CityInfo("Altlandenberg", "ZH", 47.37209, 8.86816);
case 1584: return new CityInfo("Oberhittnau", "ZH", 47.35865, 8.82372);
case 1585: return new CityInfo("Effretikon / Watt", "ZH", 47.42797, 8.69822);
case 1586: return new CityInfo("Effretikon / Brandenriet / Vogelsang", "ZH", 47.42121, 8.68557);
case 1587: return new CityInfo("Effretikon / Moosburg", "ZH", 47.42142, 8.69151);
case 1588: return new CityInfo("Effretikon / Rappenhalde-Bannhalde", "ZH", 47.42388, 8.69653);
case 1589: return new CityInfo("Winterberg", "ZH", 47.45652, 8.69428);
case 1590: return new CityInfo("Grafstal", "ZH", 47.44345, 8.69961);
case 1591: return new CityInfo("Tagelswangen", "ZH", 47.4307, 8.67284);
case 1592: return new CityInfo("Pfäffikon / Pfäffikon (Dorfkern)", "ZH", 47.36943, 8.78309);
case 1593: return new CityInfo("Dübendorf / Birchlen", "ZH", 47.39853, 8.6096);
case 1594: return new CityInfo("Dübendorf / Heugatterstrasse", "ZH", 47.39681, 8.60976);
case 1595: return new CityInfo("Dübendorf / Meiershofstrasse", "ZH", 47.39825, 8.61458);
case 1596: return new CityInfo("Dübendorf / Vogelquartier", "ZH", 47.39502, 8.61184);
case 1597: return new CityInfo("Dübendorf / Wasserfurren", "ZH", 47.39352, 8.6085);
case 1598: return new CityInfo("Dübendorf / Zelgli", "ZH", 47.3933, 8.6149);
case 1599: return new CityInfo("Dübendorf / Neuhausstrasse", "ZH", 47.39531, 8.62046);
case 1600: return new CityInfo("Dübendorf / Grüzenstrasse", "ZH", 47.39263, 8.61978);
case 1601: return new CityInfo("Dübendorf / Frickenbuck", "ZH", 47.39097, 8.63155);
case 1602: return new CityInfo("Dübendorf / Aesch", "ZH", 47.39491, 8.62621);
case 1603: return new CityInfo("Dübendorf / Sonnenberg", "ZH", 47.39469, 8.63162);
case 1604: return new CityInfo("Dübendorf / Gfenn", "ZH", 47.39272, 8.64653);
case 1605: return new CityInfo("Dübendorf / Kunklerstrasse", "ZH", 47.40109, 8.62724);
case 1606: return new CityInfo("Dübendorf / Eglishölzli", "ZH", 47.40651, 8.62826);
case 1607: return new CityInfo("Dübendorf / Stägenbuck", "ZH", 47.40229, 8.6228);
case 1608: return new CityInfo("Dübendorf / Im Zwinggarten", "ZH", 47.40464, 8.61599);
case 1609: return new CityInfo("Gockhausen / Meisenrain", "ZH", 47.38418, 8.59615);
case 1610: return new CityInfo("Hinteregg", "ZH", 47.30736, 8.68339);
case 1611: return new CityInfo("Esslingen", "ZH", 47.28325, 8.71038);
case 1612: return new CityInfo("Benglen", "ZH", 47.36077, 8.63687);
case 1613: return new CityInfo("Greifensee / Ocht", "ZH", 47.37341, 8.6773);
case 1614: return new CityInfo("Greifensee / Müllerwis / Seilerwis", "ZH", 47.37042, 8.68151);
case 1615: return new CityInfo("Greifensee / Pfisterhölzli", "ZH", 47.3643, 8.68979);
case 1616: return new CityInfo("Ebmatingen / Bachtobel", "ZH", 47.35243, 8.64107);
case 1617: return new CityInfo("Ebmatingen / Lebern", "ZH", 47.34868, 8.64229);
case 1618: return new CityInfo("Aesch", "ZH", 47.3297, 8.6541);
case 1619: return new CityInfo("Scheuren", "ZH", 47.32406, 8.66002);
case 1620: return new CityInfo("Binz", "ZH", 47.35635, 8.62657);
case 1621: return new CityInfo("Mönchaltorf / Dorf", "ZH", 47.30401, 8.72211);
case 1622: return new CityInfo("Mönchaltorf / Hohfurren", "ZH", 47.31536, 8.71828);
case 1623: return new CityInfo("Schwerzenbach / Chimli", "ZH", 47.38592, 8.65888);
case 1624: return new CityInfo("Schwerzenbach / Blatten", "ZH", 47.38308, 8.64954);
case 1625: return new CityInfo("Schwerzenbach / Chropfacher", "ZH", 47.38387, 8.65677);
case 1626: return new CityInfo("Schwerzenbach / Widacher", "ZH", 47.38151, 8.65748);
case 1627: return new CityInfo("Uster / Kirch-Uster", "ZH", 47.34579, 8.71839);
case 1628: return new CityInfo("Uster / Nieder-Uster", "ZH", 47.34743, 8.70088);
case 1629: return new CityInfo("Uster / Gschwader", "ZH", 47.36016, 8.7139);
case 1630: return new CityInfo("Uster / Ober-Uster", "ZH", 47.34874, 8.73319);
case 1631: return new CityInfo("Uster / Nossikon", "ZH", 47.34088, 8.72555);
case 1632: return new CityInfo("Nänikon / Nänikon (Dorfkern)", "ZH", 47.37099, 8.69254);
case 1633: return new CityInfo("Wermatswil", "ZH", 47.36408, 8.74152);
case 1634: return new CityInfo("Riedikon", "ZH", 47.33169, 8.71266);
case 1635: return new CityInfo("Kindhausen / Kindhausen (Dorf)", "ZH", 47.40644, 8.68296);
case 1636: return new CityInfo("Hegnau / Sunnebüel-Eich", "ZH", 47.39246, 8.6791);
case 1637: return new CityInfo("Hegnau / Alt-Hegnau", "ZH", 47.38877, 8.67482);
case 1638: return new CityInfo("Hegnau / Dammboden-Grindel", "ZH", 47.38713, 8.66657);
case 1639: return new CityInfo("Hegnau / Im Zentrum", "ZH", 47.38722, 8.68079);
case 1640: return new CityInfo("Gutenswil", "ZH", 47.38387, 8.71763);
case 1641: return new CityInfo("Zimikon / Rütiwies", "ZH", 47.38385, 8.66564);
case 1642: return new CityInfo("Wangen", "ZH", 47.41182, 8.64516);
case 1643: return new CityInfo("Dinhard", "ZH", 47.55516, 8.76671);
case 1644: return new CityInfo("Elgg / Städtchen und Umgebung", "ZH", 47.49265, 8.8668);
case 1645: return new CityInfo("Elgg / Neu-Elgg", "ZH", 47.50166, 8.86366);
case 1646: return new CityInfo("Rümikon", "ZH", 47.50232, 8.78724);
case 1647: return new CityInfo("Schottikon", "ZH", 47.49898, 8.81522);
case 1648: return new CityInfo("Hettlingen / Dorfkern", "ZH", 47.547, 8.70695);
case 1649: return new CityInfo("Hettlingen / Gübel", "ZH", 47.54766, 8.71572);
case 1650: return new CityInfo("Ober-Ohringen", "ZH", 47.52654, 8.71384);
case 1651: return new CityInfo("Seuzach Dorf / Hochgrüt-Scheidweg", "ZH", 47.53039, 8.73067);
case 1652: return new CityInfo("Seuzach Dorf / Pünten-Ifang", "ZH", 47.53743, 8.72915);
case 1653: return new CityInfo("Seuzach Dorf / Breite-Weid", "ZH", 47.53345, 8.73415);
case 1654: return new CityInfo("Seuzach Dorf / Brandbüel", "ZH", 47.53652, 8.74155);
case 1655: return new CityInfo("Wiesendangen / Steinegg", "ZH", 47.52795, 8.78209);
case 1656: return new CityInfo("Stadt Winterthur (Kreis 1) / Altstadt", "ZH", 47.49951, 8.72872);
case 1657: return new CityInfo("Stadt Winterthur (Kreis 1) / Lind", "ZH", 47.50571, 8.73372);
case 1658: return new CityInfo("Stadt Winterthur (Kreis 1) / Heiligberg", "ZH", 47.49409, 8.72334);
case 1659: return new CityInfo("Stadt Winterthur (Kreis 1) / Tössfeld", "ZH", 47.4934, 8.71512);
case 1660: return new CityInfo("Stadt Winterthur (Kreis 1) / Brühlberg", "ZH", 47.49764, 8.71272);
case 1661: return new CityInfo("Stadt Winterthur (Kreis 1) / Neuwiesen", "ZH", 47.50207, 8.71625);
case 1662: return new CityInfo("Oberwinterthur (Kreis 2) / Talacker", "ZH", 47.50596, 8.7515);
case 1663: return new CityInfo("Oberwinterthur (Kreis 2) / Guggenbühl", "ZH", 47.51339, 8.75998);
case 1664: return new CityInfo("Oberwinterthur (Kreis 2) / Grüze", "ZH", 47.49826, 8.75723);
case 1665: return new CityInfo("Oberwinterthur (Kreis 2) / Hegmatten", "ZH", 47.50977, 8.76274);
case 1666: return new CityInfo("Oberwinterthur (Kreis 2) / Zinzikon", "ZH", 47.5195, 8.7564);
case 1667: return new CityInfo("Seen (Kreis 3) / Waser", "ZH", 47.48913, 8.76034);
case 1668: return new CityInfo("Seen (Kreis 3) / Büelwiesen", "ZH", 47.48446, 8.76517);
case 1669: return new CityInfo("Seen (Kreis 3) / Iberg", "ZH", 47.46494, 8.77756);
case 1670: return new CityInfo("Seen (Kreis 3) / Waldegg", "ZH", 47.48393, 8.75586);
case 1671: return new CityInfo("Seen (Kreis 3) / Ganzenbühl", "ZH", 47.481, 8.76249);
case 1672: return new CityInfo("Seen (Kreis 3) / Sonnenberg", "ZH", 47.48952, 8.7704);
case 1673: return new CityInfo("Seen (Kreis 3) / Oberseen", "ZH", 47.48205, 8.77289);
case 1674: return new CityInfo("Töss (Kreis 4) / Vorder-Dättnau", "ZH", 47.48135, 8.69855);
case 1675: return new CityInfo("Töss (Kreis 4) / Steig", "ZH", 47.47405, 8.7021);
case 1676: return new CityInfo("Töss (Kreis 4) / Schlosstal", "ZH", 47.49279, 8.70223);
case 1677: return new CityInfo("Töss (Kreis 4) / Eichliacker", "ZH", 47.48727, 8.7074);
case 1678: return new CityInfo("Veltheim (Kreis 5) / Rosenberg", "ZH", 47.51386, 8.71583);
case 1679: return new CityInfo("Veltheim (Kreis 5) / Blumenau", "ZH", 47.50618, 8.71563);
case 1680: return new CityInfo("Wülflingen (Kreis 6) / Weinberg", "ZH", 47.51097, 8.7007);
case 1681: return new CityInfo("Wülflingen (Kreis 6) / Oberfeld", "ZH", 47.49873, 8.69897);
case 1682: return new CityInfo("Wülflingen (Kreis 6) / Lindenplatz", "ZH", 47.51098, 8.6929);
case 1683: return new CityInfo("Wülflingen (Kreis 6) / Niederfeld", "ZH", 47.50904, 8.67968);
case 1684: return new CityInfo("Wülflingen (Kreis 6) / Härti", "ZH", 47.51262, 8.684);
case 1685: return new CityInfo("Mattenbach (Kreis 7) / Deutweg", "ZH", 47.49419, 8.73948);
case 1686: return new CityInfo("Mattenbach (Kreis 7) / Gutschick", "ZH", 47.49104, 8.75258);
case 1687: return new CityInfo("Mattenbach (Kreis 7) / Endliker", "ZH", 47.48821, 8.74938);
case 1688: return new CityInfo("Kollbrunn / Kollbrunn (Dorfkern)", "ZH", 47.45748, 8.77413);
case 1689: return new CityInfo("Rikon / Rikon (Dorfkern)", "ZH", 47.44585, 8.79796);
case 1690: return new CityInfo("Birmensdorf / Haslen", "ZH", 47.36001, 8.4605);
case 1691: return new CityInfo("Dietikon / Vorstadt", "ZH", 47.40819, 8.39719);
case 1692: return new CityInfo("Dietikon / Unterdorf", "ZH", 47.40606, 8.40652);
case 1693: return new CityInfo("Dietikon / Fondli", "ZH", 47.40838, 8.38752);
case 1694: return new CityInfo("Dietikon / Almend", "ZH", 47.40477, 8.39168);
case 1695: return new CityInfo("Dietikon / Oberdorf", "ZH", 47.40065, 8.39416);
case 1696: return new CityInfo("Dietikon / Kreuzacker", "ZH", 47.39919, 8.40146);
case 1697: return new CityInfo("Dietikon / Rütematt", "ZH", 47.39374, 8.4011);
case 1698: return new CityInfo("Dietikon / Guggenbühl", "ZH", 47.40009, 8.40818);
case 1699: return new CityInfo("Dietikon / Hofacker", "ZH", 47.39718, 8.41609);
case 1700: return new CityInfo("Dietikon / Schönenwerd", "ZH", 47.39706, 8.42576);
case 1701: return new CityInfo("Geroldswil / Huebwiesen", "ZH", 47.42254, 8.40949);
case 1702: return new CityInfo("Geroldswil / Bergacker", "ZH", 47.4257, 8.40884);
case 1703: return new CityInfo("Geroldswil / Haslern", "ZH", 47.42057, 8.41611);
case 1704: return new CityInfo("Fahrweid (nördl. Teil) / Fahrweid", "ZH", 47.41171, 8.41563);
case 1705: return new CityInfo("Oberengstringen / Zentrum", "ZH", 47.40711, 8.46276);
case 1706: return new CityInfo("Oberengstringen / Sonnenberg", "ZH", 47.41211, 8.46055);
case 1707: return new CityInfo("Oberengstringen / Rauchacher", "ZH", 47.40919, 8.45627);
case 1708: return new CityInfo("Oberengstringen / Eggbühl", "ZH", 47.40686, 8.47254);
case 1709: return new CityInfo("Oberengstringen / Kirchweg", "ZH", 47.40514, 8.47261);
case 1710: return new CityInfo("Schlieren / Zentrum", "ZH", 47.39779, 8.4477);
case 1711: return new CityInfo("Schlieren / Engstingerquartier", "ZH", 47.40338, 8.44352);
case 1712: return new CityInfo("Schlieren / Spital", "ZH", 47.39489, 8.43027);
case 1713: return new CityInfo("Schlieren / Pflugstrasse", "ZH", 47.39631, 8.43608);
case 1714: return new CityInfo("Schlieren / Freiestrasse", "ZH", 47.39598, 8.44202);
case 1715: return new CityInfo("Schlieren / Kamp", "ZH", 47.39358, 8.44453);
case 1716: return new CityInfo("Schlieren / Boden", "ZH", 47.39721, 8.45734);
case 1717: return new CityInfo("Schlieren / Halde", "ZH", 47.39592, 8.4612);
case 1718: return new CityInfo("Schlieren / Industrie Ost", "ZH", 47.40069, 8.46077);
case 1719: return new CityInfo("Uitikon / Uitikon (Dorfkern)", "ZH", 47.37064, 8.45321);
case 1720: return new CityInfo("Uitikon / Halde", "ZH", 47.37243, 8.4559);
case 1721: return new CityInfo("Uitikon / Waldegg", "ZH", 47.36332, 8.46444);
case 1722: return new CityInfo("Urdorf / Nieder-Urdorf", "ZH", 47.393, 8.41973);
case 1723: return new CityInfo("Urdorf / Bodenfeld", "ZH", 47.3892, 8.42265);
case 1724: return new CityInfo("Urdorf / Moos", "ZH", 47.38977, 8.42886);
case 1725: return new CityInfo("Urdorf / Zentrum", "ZH", 47.38586, 8.42387);
case 1726: return new CityInfo("Urdorf / Heidenkeller", "ZH", 47.38495, 8.42763);
case 1727: return new CityInfo("Urdorf / Ob der Bahn", "ZH", 47.38703, 8.43306);
case 1728: return new CityInfo("Urdorf / Oberurdorf", "ZH", 47.38072, 8.42343);
case 1729: return new CityInfo("Urdorf / Fadmatt", "ZH", 47.3821, 8.42845);
case 1730: return new CityInfo("Urdorf / Baumgarten", "ZH", 47.37924, 8.42109);
case 1731: return new CityInfo("Fahrweid (südl. Teil)", "ZH", 47.40814, 8.41367);
case 1732: return new CityInfo("Zürich (Kreis 12) / Auzelg", "ZH", 47.41511, 8.57014);
case 1733: return new CityInfo("Zürich (Kreis 11) / Schwandenholz", "ZH", 47.42476, 8.52125);
case 1734: return new CityInfo("Zürich (Kreis 2) / Mittel-Leimbach", "ZH", 47.32538, 8.51391);
case 1735: return new CityInfo("Zürich (Kreis 2) / Unter-Leimbach", "ZH", 47.33362, 8.51433);
case 1736: return new CityInfo("Zürich (Kreis 7) / Looren", "ZH", 47.364, 8.59396);
case 1737: return new CityInfo("Zürich (Kreis 10) / Wipkingen", "ZH", 47.39503, 8.52529);
case 1738: return new CityInfo("Zürich (Kreis 10) / Rütihof", "ZH", 47.41444, 8.47928);
case 1739: return new CityInfo("Zürich (Kreis 1) / Rathaus", "ZH", 47.37161, 8.54501);
case 1740: return new CityInfo("Zürich (Kreis 11) / Affoltern", "ZH", 47.41814, 8.5122);
case 1741: return new CityInfo("Zürich (Kreis 1) / Hochschulen", "ZH", 47.36601, 8.54594);
case 1742: return new CityInfo("Zürich (Kreis 12) / Saatlen", "ZH", 47.41127, 8.5648);
case 1743: return new CityInfo("Zürich (Kreis 12) / Schwamendingen-Mitte", "ZH", 47.4063, 8.57242);
case 1744: return new CityInfo("Zürich (Kreis 12) / Hirzenbach", "ZH", 47.40187, 8.58633);
case 1745: return new CityInfo("Zürich (Kreis 1) / Lindenhof", "ZH", 47.37188, 8.54036);
case 1746: return new CityInfo("Zürich (Kreis 1) / City", "ZH", 47.37269, 8.53576);
case 1747: return new CityInfo("Zürich (Kreis 2) / Wollishofen", "ZH", 47.3401, 8.53134);
case 1748: return new CityInfo("Zürich (Kreis 2) / Enge", "ZH", 47.3605, 8.53127);
case 1749: return new CityInfo("Zürich (Kreis 3) / Friesenberg", "ZH", 47.36372, 8.50417);
case 1750: return new CityInfo("Zürich (Kreis 3) / Sihlfeld", "ZH", 47.37382, 8.51164);
case 1751: return new CityInfo("Zürich (Kreis 4) / Werd", "ZH", 47.37178, 8.52584);
case 1752: return new CityInfo("Zürich (Kreis 4) / Langstrasse", "ZH", 47.37767, 8.52854);
case 1753: return new CityInfo("Zürich (Kreis 4) / Hard", "ZH", 47.38311, 8.50942);
case 1754: return new CityInfo("Zürich (Kreis 5) / Gewerbeschule", "ZH", 47.38481, 8.53011);
case 1755: return new CityInfo("Zürich (Kreis 5) / Escher-Wyss", "ZH", 47.39052, 8.51292);
case 1756: return new CityInfo("Zürich (Kreis 6) / Unterstrass", "ZH", 47.3953, 8.53721);
case 1757: return new CityInfo("Zürich (Kreis 6) / Oberstrass", "ZH", 47.38917, 8.5504);
case 1758: return new CityInfo("Zürich (Kreis 7) / Fluntern", "ZH", 47.38013, 8.56133);
case 1759: return new CityInfo("Zürich (Kreis 7) / Hottingen", "ZH", 47.37011, 8.56306);
case 1760: return new CityInfo("Zürich (Kreis 7) / Hirslanden", "ZH", 47.3624, 8.56755);
case 1761: return new CityInfo("Zürich (Kreis 8) / Seefeld", "ZH", 47.35462, 8.55537);
case 1762: return new CityInfo("Zürich (Kreis 8) / Mühlebach", "ZH", 47.35727, 8.55744);
case 1763: return new CityInfo("Zürich (Kreis 8) / Weinegg", "ZH", 47.3525, 8.57011);
case 1764: return new CityInfo("Zürich (Kreis 9) / Albisrieden", "ZH", 47.37398, 8.49007);
case 1765: return new CityInfo("Zürich (Kreis 9) / Altstetten", "ZH", 47.38946, 8.48533);
case 1766: return new CityInfo("Schwerzenbach", "ZH", 47.38213, 8.65727);
case 1767: return new CityInfo("Steinmaur", "ZH", 47.4971, 8.45216);
case 1768: return new CityInfo("Rifferswil", "ZH", 47.24372, 8.49692);
case 1769: return new CityInfo("Hegnau", "ZH", 47.39227, 8.66988);
case 1770: return new CityInfo("Gockhausen", "ZH", 47.38098, 8.59978);
case 1771: return new CityInfo("Weiach", "ZH", 47.55908, 8.43344);
case 1772: return new CityInfo("Stadt Winterthur (Kreis 1)", "ZH", 47.49494, 8.71954);
case 1773: return new CityInfo("Zürich (Kreis 5)", "ZH", 47.38767, 8.52152);
case 1774: return new CityInfo("Dänikon", "ZH", 47.44674, 8.40648);
case 1775: return new CityInfo("Zürich (Kreis 12)", "ZH", 47.40372, 8.57608);
case 1776: return new CityInfo("Wülflingen (Kreis 6)", "ZH", 47.51036, 8.68333);
case 1777: return new CityInfo("Sulz", "ZH", 47.53954, 8.78887);
case 1778: return new CityInfo("Seglingen", "ZH", 47.57244, 8.52093);
case 1779: return new CityInfo("Niederglatt", "ZH", 47.49066, 8.49987);
case 1780: return new CityInfo("Fahrweid (nördl. Teil)", "ZH", 47.41432, 8.41484);
case 1781: return new CityInfo("Ebmatingen", "ZH", 47.34987, 8.64013);
case 1782: return new CityInfo("Seen (Kreis 3)", "ZH", 47.47646, 8.76996);
case 1783: return new CityInfo("Zürich (Kreis 3)", "ZH", 47.35785, 8.50296);
case 1784: return new CityInfo("Zürich (Kreis 11)", "ZH", 47.42326, 8.52166);
case 1785: return new CityInfo("Zürich (Kreis 9)", "ZH", 47.38245, 8.47993);
case 1786: return new CityInfo("Aesch", "ZH", 47.33674, 8.44099);
case 1787: return new CityInfo("Oberwinterthur (Kreis 2)", "ZH", 47.51692, 8.76863);
case 1788: return new CityInfo("Geroldswil", "ZH", 47.42213, 8.41085);
case 1789: return new CityInfo("Zürich (Kreis 10)", "ZH", 47.40773, 8.5005);
case 1790: return new CityInfo("Zürich (Kreis 2)", "ZH", 47.33756, 8.5211);
case 1791: return new CityInfo("Zürich (Kreis 8)", "ZH", 47.3548, 8.56097);
case 1792: return new CityInfo("Wolfhausen", "ZH", 47.25619, 8.7991);
case 1793: return new CityInfo("Seuzach Dorf", "ZH", 47.5356, 8.73209);
case 1794: return new CityInfo("Zürich (Kreis 1)", "ZH", 47.37055, 8.54177);
case 1795: return new CityInfo("Mattenbach (Kreis 7)", "ZH", 47.48705, 8.74681);
case 1796: return new CityInfo("Zürich (Kreis 7)", "ZH", 47.37328, 8.58038);
case 1797: return new CityInfo("Obermeilen", "ZH", 47.26574, 8.65567);
case 1798: return new CityInfo("Zürich (Kreis 6)", "ZH", 47.39223, 8.54381);
case 1799: return new CityInfo("Elsau-Räterschen", "ZH", 47.50238, 8.79874);
case 1800: return new CityInfo("Oberrieden / See", "ZH", 47.27464, 8.58236);
case 1801: return new CityInfo("Thalwil / See", "ZH", 47.29409, 8.56929);
case 1802: return new CityInfo("Dörflingen", "SH", 47.70604, 8.72241);
case 1803: return new CityInfo("Rottenschwil", "AG", 47.31375, 8.36137);
case 1804: return new CityInfo("Vufflens-le-Château", "VD", 46.52627, 6.47206);
case 1805: return new CityInfo("Thal", "SG", 47.46677, 9.56643);
case 1806: return new CityInfo("Lully VD", "VD", 46.50513, 6.46479);
case 1807: return new CityInfo("Préverenges", "VD", 46.51854, 6.52682);
case 1808: return new CityInfo("Langnau am Albis", "ZH", 47.28885, 8.5411);
case 1809: return new CityInfo("Langendorf", "SO", 47.21974, 7.51469);
case 1810: return new CityInfo("Troinex", "GE", 46.16313, 6.14745);
case 1811: return new CityInfo("Lancy", "GE", 46.18981, 6.11441);
case 1812: return new CityInfo("Buckten", "BL", 47.4099, 7.84481);
case 1813: return new CityInfo("Muralto", "TI", 46.17323, 8.80219);
case 1814: return new CityInfo("Münchenwiler", "BE", 46.91334, 7.12556);
case 1815: return new CityInfo("Stetten", "SH", 47.74025, 8.66298);
case 1816: return new CityInfo("Löhningen", "SH", 47.70121, 8.55236);
case 1817: return new CityInfo("Lauffohr (Brugg)", "AG", 47.50154, 8.23122);
case 1818: return new CityInfo("Colla", "TI", 46.09247, 9.05415);
case 1819: return new CityInfo("Jongny", "VD", 46.47883, 6.84114);
case 1820: return new CityInfo("Haag (Rheintal)", "SG", 47.20989, 9.48931);
case 1821: return new CityInfo("Givisiez", "FR", 46.81201, 7.12639);
case 1822: return new CityInfo("Gletterens", "FR", 46.89489, 6.93689);
case 1823: return new CityInfo("Aire-la-Ville", "GE", 46.19057, 6.04287);
case 1824: return new CityInfo("Hausen", "AG", 47.46396, 8.20988);
case 1825: return new CityInfo("Veyras", "VS", 46.30212, 7.53619);
case 1826: return new CityInfo("Känerkinden", "BL", 47.41188, 7.83716);
case 1827: return new CityInfo("Oberurnen", "GL", 47.11412, 9.05866);
case 1828: return new CityInfo("Saint Saphorin", "VD", 46.47329, 6.79601);
case 1829: return new CityInfo("Cuarnens", "VD", 46.62545, 6.43713);
case 1830: return new CityInfo("Les Avanchets", "GE", 46.22168, 6.10814);
case 1831: return new CityInfo("Bünzen", "AG", 47.30977, 8.32384);
case 1832: return new CityInfo("Villars-Burquin", "VD", 46.84877, 6.62763);
case 1833: return new CityInfo("Biberstein", "AG", 47.41641, 8.08508);
case 1834: return new CityInfo("Braggio", "GR", 46.30277, 9.1238);
case 1835: return new CityInfo("Saint-George", "VD", 46.51428, 6.2598);
case 1836: return new CityInfo("Saubraz", "VD", 46.51606, 6.33018);
case 1837: return new CityInfo("Berolle", "VD", 46.55798, 6.33551);
case 1838: return new CityInfo("Mauraz", "VD", 46.60558, 6.42074);
case 1839: return new CityInfo("Chavannes-le-Veyron", "VD", 46.607, 6.45086);
case 1840: return new CityInfo("La Chaux", "VD", 46.61714, 6.47223);
case 1841: return new CityInfo("Chevilly", "VD", 46.64272, 6.47661);
case 1842: return new CityInfo("Moiry", "VD", 46.64914, 6.45335);
case 1843: return new CityInfo("Ferreyres", "VD", 46.65804, 6.4852);
case 1844: return new CityInfo("Orny", "VD", 46.66758, 6.52639);
case 1845: return new CityInfo("Pompaples", "VD", 46.66699, 6.50966);
case 1846: return new CityInfo("Penthéréaz", "VD", 46.68171, 6.6039);
case 1847: return new CityInfo("Vuarrens", "VD", 46.68578, 6.64793);
case 1848: return new CityInfo("Rueyres", "VD", 46.69337, 6.69213);
case 1849: return new CityInfo("Bas-Vully", "FR", 46.96194, 7.11251);
case 1850: return new CityInfo("Marin-Epagnier", "NE", 47.01017, 6.99941);
case 1851: return new CityInfo("Tägertschi", "BE", 46.87548, 7.58529);
case 1852: return new CityInfo("Oberrohrdorf", "AG", 47.41833, 8.31983);
case 1853: return new CityInfo("Kirchleerau", "AG", 47.27579, 8.06581);
case 1854: return new CityInfo("Matran", "FR", 46.78593, 7.09768);
case 1855: return new CityInfo("Blécherette", "VD", 46.53932, 6.62227);
case 1856: return new CityInfo("Oberhof", "AG", 47.44874, 8.00273);
case 1857: return new CityInfo("Besenbüren", "AG", 47.31439, 8.34586);
case 1858: return new CityInfo("Tenniken", "BL", 47.43712, 7.81149);
case 1859: return new CityInfo("Gansingen", "AG", 47.5429, 8.13516);
case 1860: return new CityInfo("Vuisternens-devant-Romont", "FR", 46.65312, 6.92958);
case 1861: return new CityInfo("Wettswil", "ZH", 47.33725, 8.47527);
case 1862: return new CityInfo("Oberkulm", "AG", 47.29908, 8.12242);
case 1863: return new CityInfo("Savosa", "TI", 46.01902, 8.94236);
case 1864: return new CityInfo("Aeugst am Albis", "ZH", 47.26703, 8.48539);
case 1865: return new CityInfo("Pont-la-Ville", "FR", 46.69793, 7.11094);
case 1866: return new CityInfo("Servion", "VD", 46.57096, 6.77835);
case 1867: return new CityInfo("Chéserex", "VD", 46.39935, 6.17524);
case 1868: return new CityInfo("Hohentannen", "TG", 47.50862, 9.225);
case 1869: return new CityInfo("Valeyres-sous-Montagny", "VD", 46.79859, 6.61094);
case 1870: return new CityInfo("Bedigliora", "TI", 46.00252, 8.84052);
case 1871: return new CityInfo("Uebeschi", "BE", 46.73774, 7.5558);
case 1872: return new CityInfo("Kleinbösingen", "FR", 46.89404, 7.20531);
case 1873: return new CityInfo("Niedermuhlern", "BE", 46.85846, 7.46663);
case 1874: return new CityInfo("Cheseaux-Noréaz", "VD", 46.78184, 6.67029);
case 1875: return new CityInfo("Rochefort", "NE", 46.97768, 6.80835);
case 1876: return new CityInfo("Corcelles-le-Jorat", "VD", 46.60647, 6.74273);
case 1877: return new CityInfo("Rüegsau", "BE", 47.02483, 7.67395);
case 1878: return new CityInfo("Auswil", "BE", 47.13632, 7.83226);
case 1879: return new CityInfo("Rümligen", "BE", 46.82975, 7.49542);
case 1880: return new CityInfo("Donat", "GR", 46.62843, 9.4297);
case 1881: return new CityInfo("Surpierre", "FR", 46.74612, 6.85929);
case 1882: return new CityInfo("Oberhünigen", "BE", 46.88049, 7.65696);
case 1883: return new CityInfo("Les Clées", "VD", 46.7321, 6.46266);
case 1884: return new CityInfo("Busswil bei Melchnau", "BE", 47.18583, 7.83194);
case 1885: return new CityInfo("Walliswil bei Niederbipp", "BE", 47.23625, 7.68991);
case 1886: return new CityInfo("Rüti bei Lyssach", "BE", 47.05684, 7.57679);
default: return new CityInfo("Röfels", "GR", 47.01, 9.54472);

                                    }                                        
                                }
                            
                        }
                    }
                