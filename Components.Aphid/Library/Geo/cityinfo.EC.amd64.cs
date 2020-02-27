
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
                                    public const string Country = "EC";
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
                            
                                        var cur = (Math.Abs(-3.69132 - lat) + Math.Abs(-79.61174 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-4.06685 - lat) + Math.Abs(-78.95488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.83261 - lat) + Math.Abs(-78.76076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.0968 - lat) + Math.Abs(-79.69485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.55611 - lat) + Math.Abs(-79.75191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.44158 - lat) + Math.Abs(-79.45943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.04376 - lat) + Math.Abs(-79.63837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.24917 - lat) + Math.Abs(-78.98306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.81187 - lat) + Math.Abs(-77.71727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.78679 - lat) + Math.Abs(-80.23473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.9938 - lat) + Math.Abs(-77.81286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.33965 - lat) + Math.Abs(-77.46031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.45866 - lat) + Math.Abs(-78.17171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.27974 - lat) + Math.Abs(-80.41885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.8399 - lat) + Math.Abs(-78.667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.58986 - lat) + Math.Abs(-80.40806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.25305 - lat) + Math.Abs(-79.17536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.44882 - lat) + Math.Abs(-79.95952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.18333 - lat) + Math.Abs(-80 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.22622 - lat) + Math.Abs(-80.85873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.26399 - lat) + Math.Abs(-77.88739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.20726 - lat) + Math.Abs(-80.37132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.04547 - lat) + Math.Abs(-78.59063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.70884 - lat) + Math.Abs(-79.04311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.28626 - lat) + Math.Abs(-78.83514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.33405 - lat) + Math.Abs(-78.45217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.59318 - lat) + Math.Abs(-77.83078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.96276 - lat) + Math.Abs(-79.72402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.21452 - lat) + Math.Abs(-80.95151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.32779 - lat) + Math.Abs(-79.47407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.9236 - lat) + Math.Abs(-80.44946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.67098 - lat) + Math.Abs(-78.64712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.22985 - lat) + Math.Abs(-78.52495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.02863 - lat) + Math.Abs(-79.46352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.38122 - lat) + Math.Abs(-78.60812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.48369 - lat) + Math.Abs(-78.00257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.95759 - lat) + Math.Abs(-78.69636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.95542 - lat) + Math.Abs(-90.96654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.46645 - lat) + Math.Abs(-76.98719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.26649 - lat) + Math.Abs(-79.99749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.90172 - lat) + Math.Abs(-89.61021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.74018 - lat) + Math.Abs(-90.3138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.05458 - lat) + Math.Abs(-80.45445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.72145 - lat) + Math.Abs(-79.62187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.63199 - lat) + Math.Abs(-80.38808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.68107 - lat) + Math.Abs(-79.68083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.39116 - lat) + Math.Abs(-77.94068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.17414 - lat) + Math.Abs(-78.54676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.3299 - lat) + Math.Abs(-78.54341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.81563 - lat) + Math.Abs(-80.23309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.07167 - lat) + Math.Abs(-80.0525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.32561 - lat) + Math.Abs(-79.80697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.70131 - lat) + Math.Abs(-77.96516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.93709 - lat) + Math.Abs(-79.71396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.43795 - lat) + Math.Abs(-79.75647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.55238 - lat) + Math.Abs(-80.42958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.23457 - lat) + Math.Abs(-78.26248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.91667 - lat) + Math.Abs(-78.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.16671 - lat) + Math.Abs(-79.4654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.67364 - lat) + Math.Abs(-79.6183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.61129 - lat) + Math.Abs(-80.01863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.04576 - lat) + Math.Abs(-80.65889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.04934 - lat) + Math.Abs(-77.00856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.79008 - lat) + Math.Abs(-79.28759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.13404 - lat) + Math.Abs(-79.59415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.96212 - lat) + Math.Abs(-80.71271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.25861 - lat) + Math.Abs(-79.96053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.51011 - lat) + Math.Abs(-78.56712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.30868 - lat) + Math.Abs(-78.11135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.38181 - lat) + Math.Abs(-79.9437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.88333 - lat) + Math.Abs(-80.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.99313 - lat) + Math.Abs(-79.20422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.86667 - lat) + Math.Abs(-78.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.85 - lat) + Math.Abs(-78.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.42355 - lat) + Math.Abs(-79.33977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.93521 - lat) + Math.Abs(-78.61554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.94094 - lat) + Math.Abs(-79.22506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.233 - lat) + Math.Abs(-80.91039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.086 - lat) + Math.Abs(-76.89528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.92777 - lat) + Math.Abs(-80.20583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.34872 - lat) + Math.Abs(-80.57875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.35171 - lat) + Math.Abs(-78.12233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.47523 - lat) + Math.Abs(-80.23084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.19616 - lat) + Math.Abs(-79.88621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.59263 - lat) + Math.Abs(-79.00098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.60789 - lat) + Math.Abs(-78.63105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.40359 - lat) + Math.Abs(-78.58166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.89264 - lat) + Math.Abs(-78.77814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.9592 - lat) + Math.Abs(-79.65397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.93333 - lat) + Math.Abs(-79.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.17579 - lat) + Math.Abs(-79.85519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.62279 - lat) + Math.Abs(-77.94003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.90055 - lat) + Math.Abs(-79.00453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.57364 - lat) + Math.Abs(-79.64418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.30107 - lat) + Math.Abs(-78.26428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.20924 - lat) + Math.Abs(-79.43248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.54553 - lat) + Math.Abs(-80.01165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.69819 - lat) + Math.Abs(-80.09361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.10266 - lat) + Math.Abs(-79.95665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.04084 - lat) + Math.Abs(-78.14524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.57504 - lat) + Math.Abs(-79.45998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.98652 - lat) + Math.Abs(-79.35912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.04974 - lat) + Math.Abs(-79.64944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.32796 - lat) + Math.Abs(-79.55554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.56062 - lat) + Math.Abs(-78.9394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.84582 - lat) + Math.Abs(-80.16389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.35251 - lat) + Math.Abs(-78.8936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.69832 - lat) + Math.Abs(-77.14083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.39699 - lat) + Math.Abs(-78.42289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.36501 - lat) + Math.Abs(-79.90494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.911 - lat) + Math.Abs(-79.81441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.59792 - lat) + Math.Abs(-80.42367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.80217 - lat) + Math.Abs(-79.53443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.73969 - lat) + Math.Abs(-78.8486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.33247 - lat) + Math.Abs(-78.21371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.9095 - lat) + Math.Abs(-77.80772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.24908 - lat) + Math.Abs(-78.61675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.91667 - lat) + Math.Abs(-79.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.20329 - lat) + Math.Abs(-78.84714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.01674 - lat) + Math.Abs(-77.37924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.35294 - lat) + Math.Abs(-79.66033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.19727 - lat) + Math.Abs(-78.4975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zaruma", "08", -3.69132, -79.61174);
case 1: return new CityInfo("Zamora", "20", -4.06685, -78.95488);
case 2: return new CityInfo("Yantzaza", "20", -3.83261, -78.76076);
case 3: return new CityInfo("Yaguachi Nuevo", "10", -2.0968, -79.69485);
case 4: return new CityInfo("Vinces", "13", -1.55611, -79.75191);
case 5: return new CityInfo("Ventanas", "13", -1.44158, -79.45943);
case 6: return new CityInfo("Velasco Ibarra", "10", -1.04376, -79.63837);
case 7: return new CityInfo("Valdez", "09", 1.24917, -78.98306);
case 8: return new CityInfo("Tulcán", "05", 0.81187, -77.71727);
case 9: return new CityInfo("Tosagua", "14", -0.78679, -80.23473);
case 10: return new CityInfo("Tena", "23", -0.9938, -77.81286);
case 11: return new CityInfo("Taisha", "15", -2.33965, -77.46031);
case 12: return new CityInfo("Sucúa", "15", -2.45866, -78.17171);
case 13: return new CityInfo("Sucre", "14", -1.27974, -80.41885);
case 14: return new CityInfo("Saquisilí", "07", -0.8399, -78.667);
case 15: return new CityInfo("San Vicente", "14", -0.58986, -80.40806);
case 16: return new CityInfo("Santo Domingo de los Colorados", "26", -0.25305, -79.17536);
case 17: return new CityInfo("Santa Rosa", "08", -3.44882, -79.95952);
case 18: return new CityInfo("Santa Lucía", "10", -2.18333, -80);
case 19: return new CityInfo("Santa Elena", "25", -2.22622, -80.85873);
case 20: return new CityInfo("Santa Clara", "17", -1.26399, -77.88739);
case 21: return new CityInfo("Santa Ana", "14", -1.20726, -80.37132);
case 22: return new CityInfo("San Miguel de Salcedo", "07", -1.04547, -78.59063);
case 23: return new CityInfo("San Miguel", "03", -1.70884, -79.04311);
case 24: return new CityInfo("San Lorenzo de Esmeraldas", "09", 1.28626, -78.83514);
case 25: return new CityInfo("Sangolquí", "18", -0.33405, -78.45217);
case 26: return new CityInfo("San Gabriel", "05", 0.59318, -77.83078);
case 27: return new CityInfo("Samborondón", "10", -1.96276, -79.72402);
case 28: return new CityInfo("Salinas", "25", -2.21452, -80.95151);
case 29: return new CityInfo("Rosa Zarate", "09", 0.32779, -79.47407);
case 30: return new CityInfo("Rocafuerte", "14", -0.9236, -80.44946);
case 31: return new CityInfo("Riobamba", "06", -1.67098, -78.64712);
case 32: return new CityInfo("Quito", "18", -0.22985, -78.52495);
case 33: return new CityInfo("Quevedo", "13", -1.02863, -79.46352);
case 34: return new CityInfo("Quero", "19", -1.38122, -78.60812);
case 35: return new CityInfo("Puyo", "17", -1.48369, -78.00257);
case 36: return new CityInfo("Pujilí", "07", -0.95759, -78.69636);
case 37: return new CityInfo("Puerto Villamil", "01", -0.95542, -90.96654);
case 38: return new CityInfo("Puerto Francisco de Orellana", "24", -0.46645, -76.98719);
case 39: return new CityInfo("Puerto Bolívar", "08", -3.26649, -79.99749);
case 40: return new CityInfo("Puerto Baquerizo Moreno", "01", -0.90172, -89.61021);
case 41: return new CityInfo("Puerto Ayora", "01", -0.74018, -90.3138);
case 42: return new CityInfo("Portoviejo", "14", -1.05458, -80.45445);
case 43: return new CityInfo("Portovelo", "08", -3.72145, -79.62187);
case 44: return new CityInfo("Playas", "10", -2.63199, -80.38808);
case 45: return new CityInfo("Piñas", "08", -3.68107, -79.68083);
case 46: return new CityInfo("Pimampiro", "11", 0.39116, -77.94068);
case 47: return new CityInfo("Píllaro", "19", -1.17414, -78.54676);
case 48: return new CityInfo("Pelileo", "19", -1.3299, -78.54341);
case 49: return new CityInfo("Pedro Carbo", "10", -1.81563, -80.23309);
case 50: return new CityInfo("Pedernales", "14", 0.07167, -80.0525);
case 51: return new CityInfo("Pasaje", "08", -3.32561, -79.80697);
case 52: return new CityInfo("Palora", "15", -1.70131, -77.96516);
case 53: return new CityInfo("Palestina", "10", -1.93709, -79.71396);
case 54: return new CityInfo("Palenque", "13", -1.43795, -79.75647);
case 55: return new CityInfo("Paján", "14", -1.55238, -80.42958);
case 56: return new CityInfo("Otavalo", "11", 0.23457, -78.26248);
case 57: return new CityInfo("Nulti", "02", -2.91667, -78.85);
case 58: return new CityInfo("Naranjito", "10", -2.16671, -79.4654);
case 59: return new CityInfo("Naranjal", "10", -2.67364, -79.6183);
case 60: return new CityInfo("Muisne", "09", 0.61129, -80.01863);
case 61: return new CityInfo("Montecristi", "14", -1.04576, -80.65889);
case 62: return new CityInfo("Montalvo", "17", -2.04934, -77.00856);
case 63: return new CityInfo("Montalvo", "13", -1.79008, -79.28759);
case 64: return new CityInfo("Milagro", "10", -2.13404, -79.59415);
case 65: return new CityInfo("Manta", "14", -0.96212, -80.71271);
case 66: return new CityInfo("Machala", "08", -3.25861, -79.96053);
case 67: return new CityInfo("Machachi", "18", -0.51011, -78.56712);
case 68: return new CityInfo("Macas", "15", -2.30868, -78.11135);
case 69: return new CityInfo("Macará", "12", -4.38181, -79.9437);
case 70: return new CityInfo("Lomas de Sargentillo", "10", -1.88333, -80.08333);
case 71: return new CityInfo("Loja", "12", -3.99313, -79.20422);
case 72: return new CityInfo("Llacao", "02", -2.86667, -78.88333);
case 73: return new CityInfo("La Unión", "02", -2.85, -78.78333);
case 74: return new CityInfo("La Troncal", "04", -2.42355, -79.33977);
case 75: return new CityInfo("Latacunga", "07", -0.93521, -78.61554);
case 76: return new CityInfo("La Maná", "07", -0.94094, -79.22506);
case 77: return new CityInfo("La Libertad", "10", -2.233, -80.91039);
case 78: return new CityInfo("Nueva Loja", "22", 0.086, -76.89528);
case 79: return new CityInfo("Junín", "14", -0.92777, -80.20583);
case 80: return new CityInfo("Jipijapa", "14", -1.34872, -80.57875);
case 81: return new CityInfo("Ibarra", "11", 0.35171, -78.12233);
case 82: return new CityInfo("Huaquillas", "08", -3.47523, -80.23084);
case 83: return new CityInfo("Guayaquil", "10", -2.19616, -79.88621);
case 84: return new CityInfo("Guaranda", "03", -1.59263, -79.00098);
case 85: return new CityInfo("Guano", "06", -1.60789, -78.63105);
case 86: return new CityInfo("Gualaquiza", "15", -3.40359, -78.58166);
case 87: return new CityInfo("Gualaceo", "02", -2.89264, -78.77814);
case 88: return new CityInfo("Esmeraldas", "09", 0.9592, -79.65397);
case 89: return new CityInfo("El Triunfo", "10", -1.93333, -79.96667);
case 90: return new CityInfo("Eloy Alfaro", "10", -2.17579, -79.85519);
case 91: return new CityInfo("El Ángel", "05", 0.62279, -77.94003);
case 92: return new CityInfo("Cuenca", "02", -2.90055, -79.00453);
case 93: return new CityInfo("Cube", "09", 0.57364, -79.64418);
case 94: return new CityInfo("Cotacachi", "11", 0.30107, -78.26428);
case 95: return new CityInfo("Coronel Marcelino Maridueña", "10", -2.20924, -79.43248);
case 96: return new CityInfo("Colimes", "10", -1.54553, -80.01165);
case 97: return new CityInfo("Chone", "14", -0.69819, -80.09361);
case 98: return new CityInfo("Celica", "12", -4.10266, -79.95665);
case 99: return new CityInfo("Cayambe", "18", 0.04084, -78.14524);
case 100: return new CityInfo("Catarama", "13", -1.57504, -79.45998);
case 101: return new CityInfo("Catamayo", "12", -3.98652, -79.35912);
case 102: return new CityInfo("Catacocha", "12", -4.04974, -79.64944);
case 103: return new CityInfo("Cariamanga", "12", -4.32796, -79.55554);
case 104: return new CityInfo("Cañar", "04", -2.56062, -78.9394);
case 105: return new CityInfo("Calceta", "14", -0.84582, -80.16389);
case 106: return new CityInfo("Pampanal de Bolívar", "09", 1.35251, -78.8936);
case 107: return new CityInfo("Boca Suno", "24", -0.69832, -77.14083);
case 108: return new CityInfo("Baños", "19", -1.39699, -78.42289);
case 109: return new CityInfo("Balzar", "10", -1.36501, -79.90494);
case 110: return new CityInfo("Baláo", "10", -2.911, -79.81441);
case 111: return new CityInfo("Bahía de Caráquez", "14", -0.59792, -80.42367);
case 112: return new CityInfo("Babahoyo", "13", -1.80217, -79.53443);
case 113: return new CityInfo("Azogues", "04", -2.73969, -78.8486);
case 114: return new CityInfo("Atuntaqui", "11", 0.33247, -78.21371);
case 115: return new CityInfo("Archidona", "23", -0.9095, -77.80772);
case 116: return new CityInfo("Ambato", "19", -1.24908, -78.61675);
case 117: return new CityInfo("Alfredo Baquerizo Moreno", "10", -1.91667, -79.51667);
case 118: return new CityInfo("Alausí", "06", -2.20329, -78.84714);
case 119: return new CityInfo("Gonzalo Pizarro", "22", 0.01674, -77.37924);
case 120: return new CityInfo("Wilfrido Loor Moreira", "14", -0.35294, -79.66033);
default: return new CityInfo("Tutamandahostel", "18", -0.19727, -78.4975);

                                    }                                        
                                }
                            
                        }
                    }
                